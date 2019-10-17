'------------------------------------------------------------------------------------------------------------------
'* My Anime Archive! - .NET Framework
'* Build: Alpha 1.0
'* Programmed by: Cesar Mendoza @aberuwu
'* Last Updated: 10/17/2019
'* Features:
'*          -MAL XML File Visualization
'*          -Export as XML, JSON, CSV  
'*          -Anime list and user offline statistical analysis    
'*          -List organization and visualisation
'*          -List modification
'*          -Online Anime info visualization (Jikan REST API)
'*
'*
'* Visual Basic code files and forms:
'*  
'* -frmMain.vb:         Contains general code for main form visualization including listboxes,
'*                      listviews, labels, imageboxes. Visualizes loaded XML data.
'------------------------------------------------------------------------------------------------------------------

Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml
Imports System.Net
Imports System.Reflection
Imports System.IO
Imports System
Imports Newtonsoft.Json
Imports System.Drawing.Drawing2D
Imports JikanDotNet

Public Class frmMain
    Public Property animeList As List(Of Anime) = New List(Of Anime)
    Public Property sortedList As List(Of Anime) = New List(Of Anime)
    Public Property userList As List(Of User) = New List(Of User)
    Public Property animeCount As Integer = 0
    Public Property userCount As Integer = 0

    Private themes As New Themes()
    Private XmlParser As New XmlParser()

    Public USER_IMG_URL As String
    Public Property newList As Boolean = False
    Public Property darkModeOn As Boolean
    Public Property loadedXml As Boolean
    Public Property completed As Boolean = False
    Public Property windowMaximized As Boolean = False
    Public Property fullListChecked As Boolean = False
    Public Property sortCondition As Boolean = False
    Public Property sortByTitle As Boolean = False
    Public Property sortByStatus As Boolean = False
    Public Property sortByRating As Boolean = False
    Public Property sortyByWatched As Boolean = False
    Public Property filterByWatching As Boolean = False
    Public Property filterByCompleted As Boolean = False
    Public Property filterByOnHold As Boolean = False
    Public Property filterByDropped As Boolean = False
    Public Property filterByPlanToWatch As Boolean = False
    Public Property filterByNothing As Boolean = False
    Public Property asscSort As Boolean = False
    Public Property singleListClick As Boolean = False
    Public Property editClick As Boolean = False
    Public Property themePurple As Boolean = True
    Public Property themeBlue As Boolean = False
    Public Property themeOrange As Boolean = False

    Public Property ANIME_SOURCE_XML As String
    Private MAL_SOURCE_URL As String = "https://myanimelist.net/anime/"

    Async Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.ForeColor = SystemColors.GrayText
        txtSearch.Text = "🔎 Anime Search"

        welcomeOpen()

        tsFileLable.Text = ANIME_SOURCE_XML

        If loadedXml = False Then
            btnSave.Enabled = False
            btnXml.Enabled = False
        Else
            btnSave.Enabled = True
            btnXml.Enabled = True
            lstwAnimeSearch.Items(0).Selected = True
            lstwAnimeSearch.Items(0).Focused = True
            lstwAnimeSearch.Items(0).EnsureVisible()
            Me.ActiveControl = lstwAnimeSearch
        End If

        vscrSearchList.Minimum = 0
        vscrSearchList.Maximum = lstwAnimeSearch.Items.Count
    End Sub

    Async Sub loadApiInfo(id As String)
        Dim jikan As IJikan = New Jikan(True)
        Dim anime As JikanDotNet.Anime = Await jikan.GetAnime(id)
        'pcbAnimeCover.Load(anime.ImageURL)
    End Sub

    Private Sub welcomeOpen()
        Dim welcomeOpen As WelcomeOpen

        welcomeOpen = New WelcomeOpen
        welcomeOpen.ShowDialog()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        Dim ofpXml As OpenFileDialog = New OpenFileDialog()

        If ofpXml.ShowDialog = DialogResult.OK Then

            If ofpXml.FileName.Contains(".xml") Then
                txtSearch.Clear()
                txtSearch.ForeColor = SystemColors.GrayText
                txtSearch.Text = "🔎 Anime Search"
                ANIME_SOURCE_XML = ofpXml.FileName
                tsFileLable.Text = ANIME_SOURCE_XML

                XmlParser.loadXmlFile()

                Me.ActiveControl = lstAnimes
                vscrSearchList.Maximum = lstwAnimeSearch.Items.Count
                lstwAnimeSearch.Items(0).Selected = True
                lstwAnimeSearch.Items(0).Focused = True
                lstwAnimeSearch.Items(0).EnsureVisible()
                Me.ActiveControl = lstwAnimeSearch
            Else
                Dim errorPage As frmError
                errorPage = New frmError
                errorPage.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshSearchList()
    End Sub

    Public Sub refreshSearchList()
        Try
            lstAnimes.Items.Clear()
            lstwStatus.Items.Clear()
            lstwStatus.Items.Clear()
            lstwAnimeSearch.Items.Clear()
            lblNoResultFound.Visible = False
            txtSearch.Clear()
            txtSearch.ForeColor = SystemColors.GrayText
            txtSearch.Text = "🔎 Anime Search"
            vscrSearchList.Minimum = 0
            vscrSearchList.Maximum = 0


            For i As Integer = 0 To animeList.Count() - 1
                Dim itemStatus As ListViewItem = lstwStatus.Items.Add("")
                Dim str(2) As String
                Dim itemResults As ListViewItem

                If sortedList(i).Status = "Watching" Then
                    itemStatus.ImageIndex = 0
                ElseIf sortedList(i).Status = "Completed" Then
                    itemStatus.ImageIndex = 1
                ElseIf sortedList(i).Status = "Dropped" Then
                    itemStatus.ImageIndex = 2
                ElseIf sortedList(i).Status = "On-Hold" Then
                    itemStatus.ImageIndex = 3
                Else
                    itemStatus.ImageIndex = 4
                End If

                str(0) = sortedList(i).Title
                str(1) = sortedList(i).AnimeId
                itemResults = New ListViewItem(str)
                lstwAnimeSearch.Items.Add(itemResults)

            Next
            vscrSearchList.Maximum = lstwAnimeSearch.Items.Count
        Catch ex As Exception
            MsgBox("No XML File Loaded", MsgBoxStyle.Information, "No File Found")
        End Try
    End Sub


    Public Sub welcomePage()
        Dim welcomePage As frmWelcome

        welcomePage = New frmWelcome
        welcomePage.ShowDialog()
    End Sub

    Public Shared Function CheckConnection(connectionString As String) As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead(connectionString)
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    '------------------------
    ' JIKAN REST API Call
    '-------------------------
    Async Sub loadDetails(id As String)
        Try
            mtsLoading.Visible = True
            lblNoConnection.Visible = False
            Dim jikan As IJikan = New Jikan(True)
            Dim anime As JikanDotNet.Anime = Await jikan.GetAnime(id)
            Dim producers As List(Of String) = New List(Of String)

            If IsNothing(anime.Synopsis) Then
                rctSynopsis.Text = "No Synopsis Available"
            Else
                rctSynopsis.Text = anime.Synopsis
            End If

            If IsNothing(anime.Rating) Then
                lblMALRating.Text = "--"
            Else
                lblMALRating.Text = anime.Rating
            End If

            If IsNothing(anime.Premiered) Then
                lblPremiered.Text = "--"
            Else
                lblPremiered.Text = anime.Premiered
            End If

            If IsNothing(anime.Score) Then
                lblMALScore.Text = "--"
            Else
                lblMALScore.Text = anime.Score
            End If

            If IsNothing(anime.Status) Then
                lblMALStatus.Text = "--"
            Else
                lblMALStatus.Text = anime.Status
            End If

            If IsNothing(anime.Duration) Then
                lblDuration.Text = "--"
            Else
                lblDuration.Text = anime.Duration
            End If

            If IsNothing(anime.Popularity) Then
                lblPopularity.Text = "--"
            Else
                lblPopularity.Text = anime.Popularity
            End If

            If IsNothing(anime.Rank) Then
                lblRank.Text = "--"
            Else
                lblRank.Text = anime.Rank
            End If

            If IsNothing(anime.Members) Then
                lblMembers.Text = "--"
            Else
                lblMembers.Text = anime.Members
            End If

            If IsNothing(anime.Favorites) Then
                lblFavorites.Text = "--"
            Else
                lblFavorites.Text = anime.Favorites
            End If

            If IsNothing(anime.Broadcast) Then
                lblBrodcast.Text = "--"
            Else
                lblBrodcast.Text = anime.Broadcast
            End If

            If IsNothing(anime.ImageURL) Then

            Else
                pcbAnimeCover.Load(anime.ImageURL)
            End If

            mtsLoading.Visible = False
        Catch ex As Exception
            mtsLoading.Visible = True
            pcbAnimeCover.Image = My.Resources.sorry
            rctSynopsis.Clear()
            lblNoConnection.Visible = True
        End Try
    End Sub

    Private Sub chkViewDetails_CheckedChanged(sender As Object, e As EventArgs) Handles chkViewDetails.CheckedChanged
        Dim anId As String = ""
        If chkViewDetails.Checked = True Then
            For Each Itm As ListViewItem In lstwAnimeSearch.Items
                If Itm.SubItems.Count < 2 OrElse Itm.SubItems(1).Text = "" Then
                    anId = ""
                Else
                    anId = lstwAnimeSearch.SelectedItems(0).SubItems(1).Text
                End If
            Next
            gbxDetailView.Visible = True
            loadDetails(anId)
        Else
            gbxDetailView.Visible = False
        End If
    End Sub

    Private Sub lstwAnimeSearch_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstwAnimeSearch.ItemSelectionChanged
        Dim anId As String = ""
        If lstwAnimeSearch.SelectedItems.Count = -1 Then
            Return
        ElseIf lstwAnimeSearch.SelectedItems.Count = 0 Then
            Return
        End If
        Try
            For Each Itm As ListViewItem In lstwAnimeSearch.Items
                If Itm.SubItems.Count < 2 OrElse Itm.SubItems(1).Text = "" Then
                    anId = ""
                Else
                    anId = lstwAnimeSearch.SelectedItems(0).SubItems(1).Text
                End If
            Next

            If chkViewDetails.Checked = True Then
                loadDetails(anId)
            End If

            Dim animeTitle As String = lstwAnimeSearch.SelectedItems(0).SubItems(0).Text
            For i As Integer = 0 To animeList.Count() - 1
                If lstwAnimeMain.Items(i).SubItems(0).Text = anId OrElse lstwAnimeMain.Items(i).SubItems(1).Text = animeTitle Then
                    lstwAnimeMain.SelectedItems.Clear()
                    lstwAnimeMain.Items(i).Selected = True
                    lstwAnimeMain.Items(i).EnsureVisible()

                    lblTitle.Text = sortedList(i).Title
                    lblId.Text = sortedList(i).AnimeId
                    lblType.Text = sortedList(i).Type
                    lblEpisodes.Text = sortedList(i).Episodes
                    lblWatched.Text = sortedList(i).WatchedEps
                    lblScore.Text = sortedList(i).Score
                    lblStatus.Text = sortedList(i).Status
                End If
            Next
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub lstwAnimeMain_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstwAnimeMain.ItemSelectionChanged
        Dim anId As String = ""
        Try
            anId = lstwAnimeMain.FocusedItem.SubItems(0).Text

            For i As Integer = 0 To animeList.Count() - 1
                If sortedList(i).AnimeId = anId Then
                    lblTitle.Text = sortedList(i).Title
                    lblId.Text = sortedList(i).AnimeId
                    lblType.Text = sortedList(i).Type
                    lblEpisodes.Text = sortedList(i).Episodes
                    lblWatched.Text = sortedList(i).WatchedEps
                    lblScore.Text = sortedList(i).Score
                    lblStatus.Text = sortedList(i).Status
                End If
            Next
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub btnUserInfo_Click(sender As Object, e As EventArgs) Handles btnUserInfo.Click
        Dim userInfo As frmUserInfo

        userInfo = New frmUserInfo
        userInfo.ShowDialog()
    End Sub

    Private Sub tsbtnSort_Click(sender As Object, e As EventArgs) Handles tsbtnSort.Click
        Dim sortBy As frmSortWindow

        sortBy = New frmSortWindow
        sortBy.ShowDialog()
    End Sub

    Private Sub pcbtnDarkMode_Click(sender As Object, e As EventArgs) Handles pcbtnDarkMode.Click
        If darkModeOn = False Then
            darkModeOn = True
            pcbtnDarkMode.Image = My.Resources.Switch_OnP

            If themePurple = True Then
                themes.purpleThemeDarkModeMain()
            ElseIf themeBlue = True Then
                themes.blueThemeDarkModeMain()
            ElseIf themeOrange = True Then
                themes.orangeThemeDarkModeMain()
            End If

            If loadedXml = False Then
                pcbUserPicture.Image = My.Resources.user_icon_white
            End If

        ElseIf darkModeOn = True Then
            darkModeOn = False
            pcbtnDarkMode.Image = My.Resources.Switch_OffP
            Me.BackColor = Color.WhiteSmoke

            If themePurple = True Then
                themes.purpleThemeLightModeMain()
            ElseIf themeBlue = True Then
                themes.blueThemeLightModeMain()
            ElseIf themeOrange = True Then
                themes.orangeThemeLightModeMain()
            End If

            If loadedXml = False Then
                pcbUserPicture.Image = My.Resources.user_icon
            End If
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim aboutForm As frmAbout

        aboutForm = New frmAbout
        aboutForm.ShowDialog()
    End Sub

    Private Sub pcbUserPicture_Click(sender As Object, e As EventArgs) Handles pcbUserPicture.Click
        If loadedXml = True Then
            System.Diagnostics.Process.Start("https://myanimelist.net/profile/" & userList(userCount).Username)
        Else
            Return
        End If
    End Sub

    Private Sub btnXml_Click(sender As Object, e As EventArgs) Handles btnXml.Click
        Dim xmlFile As frmXml

        xmlFile = New frmXml
        xmlFile.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim saveFile As frmSave

        saveFile = New frmSave
        saveFile.ShowDialog()
    End Sub

    Private Sub tsmiListOptions_Click(sender As Object, e As EventArgs) Handles tsmiListOptions.Click
        Dim lstOptions As frmListOptions

        lstOptions = New frmListOptions
        lstOptions.ShowDialog()
    End Sub


    Private Sub lstwAnimeMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstwAnimeMain.MouseDoubleClick
        singleListClick = False
        Dim editAnime As frmEditAnime

        editAnime = New frmEditAnime
        editAnime.ShowDialog()
        lstwAnimeMain.Items.Clear()
        XmlParser.populateList()
    End Sub


    Private Sub tsbtnEdit_Click(sender As Object, e As EventArgs) Handles tsbtnEdit.Click
        Dim editAnime As frmEditAnime
        editAnime = New frmEditAnime
        editAnime.ShowDialog()
        lstwAnimeMain.Items.Clear()
        XmlParser.populateList()
        refreshSearchList()
    End Sub

    Private Sub backWork_ProgressChanged(sender As Object, e As ComponentModel.ProgressChangedEventArgs) Handles backWork.ProgressChanged
        pcbLoading.Value = Math.Min(e.ProgressPercentage, pcbLoading.Maximum)
        If e.ProgressPercentage = pcbLoading.Maximum Then
            pcbLoading.Visible = False
        End If
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "🔎 Anime Search" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text.Length = 0 Then
            txtSearch.Text = "🔎 Anime Search"
            txtSearch.ForeColor = SystemColors.GrayText
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "🔎 Anime Search" Or txtSearch.Text = "" Then
            Return
        End If

        vscrSearchList.Maximum = 0
        vscrSearchList.Minimum = 0
        lstAnimes.Items.Clear()
        lstwAnimeSearch.Items.Clear()
        lstwStatus.Items.Clear()

        Dim search As String = txtSearch.Text.Trim().ToUpper()
        Dim nameResults As String = ""

        lblNoResultFound.Visible = False

        Try
            For i = 0 To animeList.Count() - 1
                nameResults = animeList(i).Title.Trim().ToUpper()
                If nameResults.Contains(search) Then
                    Dim itemStatus As ListViewItem = lstwStatus.Items.Add("")
                    Dim str(2) As String
                    Dim itemResults As ListViewItem

                    If animeList(i).Status = "Watching" Then
                        itemStatus.ImageIndex = 0
                    ElseIf animeList(i).Status = "Completed" Then
                        itemStatus.ImageIndex = 1
                    ElseIf animeList(i).Status = "Dropped" Then
                        itemStatus.ImageIndex = 2
                    ElseIf animeList(i).Status = "On-Hold" Then
                        itemStatus.ImageIndex = 3
                    Else
                        itemStatus.ImageIndex = 4
                    End If

                    str(0) = animeList(i).Title
                    str(1) = animeList(i).AnimeId
                    itemResults = New ListViewItem(str)
                    lstwAnimeSearch.Items.Add(itemResults)
                Else
                    'lblNoResultFound.Visible = True
                End If

                vscrSearchList.Maximum = lstwAnimeSearch.Items.Count
            Next

            If lstwAnimeSearch.Items.Count = 0 Then
                lblNoResultFound.Visible = True
            Else
                lblNoResultFound.Visible = False
                lstAnimes.SelectedIndex = 0
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    '----------------------------------------------------------------
    '
    ' Graphical User Interface functions and event handlers
    ' Owner drawn events
    '
    '----------------------------------------------------------------
    Private brushPurple As Brush = Brushes.MediumPurple
    Private brushBlue As Brush = Brushes.CornflowerBlue
    Private brushOrange As Brush = Brushes.Orange

    Private Sub lstAnimes_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstAnimes.DrawItem
        On Error Resume Next
        e.DrawBackground()

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            If themePurple = True Then
                e.Graphics.FillRectangle(brushPurple, e.Bounds)
            ElseIf themeBlue = True Then
                e.Graphics.FillRectangle(brushBlue, e.Bounds)
            ElseIf themeOrange = True Then
                e.Graphics.FillRectangle(brushOrange, e.Bounds)
            End If
        End If
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(lstAnimes.GetItemText(lstAnimes.Items(e.Index)), e.Font, b, e.Bounds, StringFormat.GenericDefault)
        End Using

        e.DrawFocusRectangle()
    End Sub

    Private Sub lstAnimes_MeasureItem(sender As Object, e As MeasureItemEventArgs) Handles lstAnimes.MeasureItem
        If e.Index < 0 Then Return
        e.ItemWidth = Me.lstAnimes.Width
    End Sub

    Private Sub btnFullScreen_Click(sender As Object, e As EventArgs) Handles btnFullScreen.Click
        If windowMaximized = False Then
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            btnFullScreen.BackgroundImage = My.Resources.minimize_icon
            ttMain.SetToolTip(btnFullScreen, "Exit Full Screen")
            windowMaximized = True
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            btnFullScreen.BackgroundImage = My.Resources.full_Screen_icon
            ttMain.SetToolTip(btnFullScreen, "Full Screen")
            windowMaximized = False
        End If
    End Sub

    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView, ByVal setting As Boolean)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)
    End Sub

    Private Sub lstwTest_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lstwAnimeMain.DrawSubItem
        Dim sf As New StringFormat()
        If e.Item.Selected = True Then

            If themePurple = True Then
                e.Graphics.FillRectangle(brushPurple, e.Bounds)
            ElseIf themeBlue = True Then
                e.Graphics.FillRectangle(brushBlue, e.Bounds)
            ElseIf themeOrange = True Then
                e.Graphics.FillRectangle(brushOrange, e.Bounds)
            End If

            sf.Alignment = StringAlignment.Center
            e.Graphics.DrawString(e.SubItem.Text, Me.lstwAnimeMain.Font, Brushes.White, e.Bounds, sf)
        Else
            If darkModeOn = False Then
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds)
            End If
            e.DrawText()
        End If
    End Sub

    Private Sub lstwTest_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lstwAnimeMain.DrawColumnHeader
        Dim sf As New StringFormat()
        If themePurple = True Then
            e.Graphics.FillRectangle(Brushes.MediumOrchid, e.Bounds)
            e.Graphics.DrawString(e.Header.Text, Me.lstwAnimeMain.Font, Brushes.White, e.Bounds, sf)
        ElseIf themeBlue = True Then
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds)
            e.Graphics.DrawString(e.Header.Text, Me.lstwAnimeMain.Font, Brushes.White, e.Bounds, sf)
        Else
            e.Graphics.FillRectangle(Brushes.Tomato, e.Bounds)
            e.Graphics.DrawString(e.Header.Text, Me.lstwAnimeMain.Font, Brushes.White, e.Bounds, sf)
        End If
    End Sub

    Private Sub lstwAnimeSearch_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lstwAnimeSearch.DrawSubItem
        Dim sf As New StringFormat()
        If e.Item.Selected = True Then

            sf.Alignment = StringAlignment.Near

            If themePurple = True Then
                e.Graphics.FillRectangle(brushPurple, e.Bounds)
            ElseIf themeBlue = True Then
                e.Graphics.FillRectangle(brushBlue, e.Bounds)
            ElseIf themeOrange = True Then
                e.Graphics.FillRectangle(brushOrange, e.Bounds)
            End If

            Dim title As String = lstwAnimeSearch.SelectedItems(0).SubItems(1).Text

            For i As Integer = 0 To lstwAnimeMain.Items.Count() - 1
                If animeList(i).Title = title Then
                    If animeList(i).Status = "Watching" Then
                        e.Graphics.DrawImage(imgLst.Images(1), e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Width)
                    ElseIf animeList(i).Status = "Completed" Then
                        e.Graphics.DrawImage(imgLst.Images(2), e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Width)
                    ElseIf animeList(i).Status = "On-Hold" Then
                        e.Graphics.DrawImage(imgLst.Images(3), e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Width)
                    Else
                        e.Graphics.DrawImage(imgLst.Images(4), e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Width)
                    End If
                End If
            Next

            e.Graphics.DrawString(e.SubItem.Text, Me.lstwAnimeSearch.Font, Brushes.White, e.Bounds, sf)
        Else
            If darkModeOn = False Then
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds)
            End If
            e.DrawText()
        End If
    End Sub


    Private Sub tsmiEdit_Click(sender As Object, e As EventArgs) Handles tsmiEdit.Click
        Dim editAnime As frmEditAnime
        editAnime = New frmEditAnime
        editAnime.ShowDialog()
        lstwAnimeMain.Items.Clear()
        XmlParser.populateList()
        refreshSearchList()
    End Sub

    Private Sub tsbtnNewAnime_Click(sender As Object, e As EventArgs) Handles tsbtnNewAnime.Click
        Dim newAnime As frmNewAnime
        newAnime = New frmNewAnime
        newAnime.ShowDialog()

        XmlParser.populateList()
        refreshSearchList()
    End Sub

    Private Sub tsmiDelete_Click(sender As Object, e As EventArgs) Handles tsmiDelete.Click

    End Sub

    Private Sub tsmiVisitPage_Click(sender As Object, e As EventArgs) Handles tsmiVisitPage.Click

    End Sub

    Private Sub vscrSearchList_Scroll(sender As Object, e As ScrollEventArgs) Handles vscrSearchList.Scroll
        Try
            lstwAnimeSearch.TopItem = lstwAnimeSearch.Items(vscrSearchList.Value)
            lstwStatus.TopItem = lstwStatus.Items(vscrSearchList.Value)

            lstAnimes.TopIndex = vscrSearchList.Value
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub lstwAnimeSearch_MouseHover(sender As Object, e As EventArgs) Handles lstwAnimeSearch.MouseHover
        'vscrSearchList.Value = lstwAnimeSearch.TopItem.Index
        'lstwStatus.TopItem = lstwStatus.Items(lstwAnimeSearch.TopItem.Index)
    End Sub

    Private Sub vscrSearchList_Move(sender As Object, e As EventArgs) Handles vscrSearchList.Move
        lstwAnimeSearch.Scrollable = True
        lstwStatus.Scrollable = True
    End Sub

    Private Sub lstwAnimeSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles lstwAnimeSearch.KeyDown
        vscrSearchList.Value = lstwAnimeSearch.TopItem.Index
        lstwStatus.TopItem = lstwStatus.Items(lstwAnimeSearch.TopItem.Index)
    End Sub

    Private Sub lstwAnimeSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles lstwAnimeSearch.KeyUp
        vscrSearchList.Value = lstwAnimeSearch.TopItem.Index
        lstwStatus.TopItem = lstwStatus.Items(lstwAnimeSearch.TopItem.Index)
    End Sub

    Private WithEvents tmr As New Timer With {.Enabled = True}
    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        Try
            If vscrSearchList.Maximum > 0 Then
                vscrSearchList.Value = lstwAnimeSearch.TopItem.Index
                lstwStatus.TopItem = lstwStatus.Items(lstwAnimeSearch.TopItem.Index)
                'lstwStatus.TopItem = lstwStatus.Items(lstAnimes.TopIndex)
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub lblDarkMode_Click(sender As Object, e As EventArgs) Handles lblDarkMode.Click

    End Sub

    Private Sub pcbLogo_Click(sender As Object, e As EventArgs) Handles pcbLogo.Click
        welcomeOpen()
    End Sub


    Private Sub btnOpenHeader_Click(sender As Object, e As EventArgs) Handles btnOpenHeader.Click
        btnOpen_Click(Nothing, Nothing)
    End Sub

    Private Sub btnExportHeader_Click(sender As Object, e As EventArgs) Handles btnExportHeader.Click
        btnSave_Click(Nothing, Nothing)
    End Sub

    Private Sub btnViewXmlHeader_Click(sender As Object, e As EventArgs) Handles btnViewXmlHeader.Click
        btnXml_Click(Nothing, Nothing)
    End Sub

    Private Sub btnSortHeader_Click(sender As Object, e As EventArgs) Handles btnSortHeader.Click
        tsbtnSort_Click(Nothing, Nothing)
    End Sub

    Private Sub btnNewAnimeHeader_Click(sender As Object, e As EventArgs) Handles btnNewAnimeHeader.Click
        tsbtnNewAnime_Click(Nothing, Nothing)
    End Sub

    Private Sub btnEditHeader_Click(sender As Object, e As EventArgs) Handles btnEditHeader.Click
        tsbtnEdit_Click(Nothing, Nothing)
    End Sub

    Private Sub btnDeleteHeader_Click(sender As Object, e As EventArgs) Handles btnDeleteHeader.Click

    End Sub

    Private Sub btnInfoSettingsHeader_Click(sender As Object, e As EventArgs) Handles btnInfoSettingsHeader.Click
        btnUserInfo_Click(Nothing, Nothing)
    End Sub

End Class
Public Class ListViewDoubleBuffered
    Inherits ListView
    Public Sub New()
        Me.DoubleBuffered = True
    End Sub
End Class
