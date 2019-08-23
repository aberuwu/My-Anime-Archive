'**************************************************************************************************************
'* NOTE: THIS COMMIT IS STILL A WORK IN PROGRESS, I'M TESTING OUT THE SITE
'* My Anime Archive! - .NET Framework
'* Build: Alpha 1.0
'* Programmed by: Cesar Mendoza @aberuwu
'* Last Updated: 17/7/2019 - 00:53
'* Features:
'*          -MAL XML File Visualization
'*          -Export as XML, SQL, CSV   
'*          -Anime list and user offline statistical analysis    
'*          -List organization and visualisation
'*          -List modification
'*
'*
'* Visual Basic code files and forms:
'*  
'* -frmMain.vb:         Contains general code for main form visualization including listboxes,
'*                      listviews, labels, imageboxes. Visualizes loaded XML data.
'*
'* -frmXml.vb:          Contains general code for the loading of data from user selected XML file.
'*
'* -frmSave.vb:         Contains general code for the exporting of program data to user specified format.
'*
'* -frmSortWindow.vb:   Contains general code for the sorting of program listboxes and listviews. 
'* -frmUserInfo.vb:
'* -frmWelcome.vb:
'* -frmWorking.vb:
'* -WelcomeOpen.vb:
'* -Anime.vb:
'* -User.vb:
'*
'*************************************************************************************************************

Imports System.Xml
Imports System.Net
Imports System.Reflection
Imports System.IO
Imports System
Imports Newtonsoft.Json
Imports System.Drawing.Drawing2D

Public Class frmMain

    Public Property animeList As List(Of Anime) = New List(Of Anime)
    Public Property userList As List(Of User) = New List(Of User)
    Public Property animeCount As Integer = 0
    Public Property userCount As Integer = 0

    Private themes As New Themes()
    Private XmlParser As New XmlParser()

    Public USER_IMG_URL As String
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

    'Public Property header As String = "User-Agent:Mozilla/5.0 (iPhone; CPU iPhone OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3"

    Public Property ANIME_SOURCE_XML As String
    Private MAL_SOURCE_URL As String = "https://myanimelist.net/anime/"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        End If

        vscrSearchList.Minimum = 0
        vscrSearchList.Maximum = lstwAnimeSearch.Items.Count
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

    Private Sub wbsAnimeImage_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        'wbsAnimeImage.Document.Body.Style = "zoom:100%"
        completed = True
    End Sub

    Public Property lstAnimeIndexSelect As Boolean = False

    Private Sub lstAnimes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAnimes.SelectedIndexChanged

        lstAnimeIndexSelect = True

        If lstAnimes.SelectedIndex = -1 Then
            Return
        End If

        Dim animeIndex As Integer = lstAnimes.SelectedItem.ToString.Substring(1000)

        For i As Integer = 0 To animeCount - 1

            Dim tempId As Integer = Convert.ToInt32(animeList(i).AnimeId)
            'animeList(i).AnimeId.Contains(animeIndex)

            If tempId = animeIndex Then

                'MsgBox(animeList(i).AnimeId)
                If fullListChecked = True Then
                    lstwAnimeMain.SelectedItems.Clear()
                    For c As Integer = 0 To animeCount - 1
                        If lstwAnimeMain.Items(c).SubItems(0).Text = animeList(i).AnimeId Then
                            lstwAnimeMain.Items(c).Selected = True
                            lstwAnimeMain.Items(c).EnsureVisible()
                        End If
                    Next
                End If

                lblTitle.Text = animeList(i).Title
                lblId.Text = animeList(i).AnimeId
                lblType.Text = animeList(i).Type
                lblEpisodes.Text = animeList(i).Episodes
                lblWatched.Text = animeList(i).WatchedEps
                lblScore.Text = animeList(i).Score
                lblStatus.Text = animeList(i).Status

                Dim API_JIKAN_MAL_PICTURE As String = "https://api.jikan.moe/anime/" & animeList(i).AnimeId & "/pictures"

                MAL_SOURCE_URL = animeList(i).AnimeId

            End If
        Next

    End Sub


    Private Sub lstwAnimeSearch_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstwAnimeSearch.ItemSelectionChanged

        Dim anId As String
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

            Dim animeTitle As String = lstwAnimeSearch.SelectedItems(0).SubItems(0).Text
            For i As Integer = 0 To animeList.Count() - 1
                If lstwAnimeMain.Items(i).SubItems(0).Text = anId OrElse lstwAnimeMain.Items(i).SubItems(1).Text = animeTitle Then
                    lstwAnimeMain.SelectedItems.Clear()
                    lstwAnimeMain.Items(i).Selected = True
                    'lstwAnimeMain.Items(i).Focused = True
                    lstwAnimeMain.Items(i).EnsureVisible()

                    lblTitle.Text = animeList(i).Title
                    lblId.Text = animeList(i).AnimeId
                    lblType.Text = animeList(i).Type
                    lblEpisodes.Text = animeList(i).Episodes
                    lblWatched.Text = animeList(i).WatchedEps
                    lblScore.Text = animeList(i).Score
                    lblStatus.Text = animeList(i).Status
                End If
            Next
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub lstwAnimeMain_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstwAnimeMain.ItemSelectionChanged

        Dim anId As String
        Try
            anId = lstwAnimeMain.FocusedItem.SubItems(0).Text
            For i As Integer = 0 To animeList.Count() - 1
                If animeList(i).AnimeId = anId Then
                    lblTitle.Text = animeList(i).Title
                    lblId.Text = animeList(i).AnimeId
                    lblType.Text = animeList(i).Type
                    lblEpisodes.Text = animeList(i).Episodes
                    lblWatched.Text = animeList(i).WatchedEps
                    lblScore.Text = animeList(i).Score
                    lblStatus.Text = animeList(i).Status
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
        'userInfo.Show()
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

    Private Sub lstwOne_DoubleClick(sender As Object, e As EventArgs)
        singleListClick = True
        Dim editAnime As frmEditAnime

        editAnime = New frmEditAnime
        editAnime.ShowDialog()
        'lstwOne.Items.Clear()

        lstAnimes_SelectedIndexChanged(Nothing, New EventArgs())
    End Sub

    Private Sub lstwAnimeMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstwAnimeMain.MouseDoubleClick
        singleListClick = False
        Dim editAnime As frmEditAnime

        editAnime = New frmEditAnime
        editAnime.ShowDialog()
        lstwAnimeMain.Items.Clear()
        XmlParser.populateList()
    End Sub



    'EDIT BUTTON - STILL BUGGY
    Private Sub tsbtnEdit_Click(sender As Object, e As EventArgs) Handles tsbtnEdit.Click
        Dim editAnime As frmEditAnime
        editClick = True

        editAnime = New frmEditAnime
        editAnime.ShowDialog()
    End Sub


    Private Sub backWork_ProgressChanged(sender As Object, e As ComponentModel.ProgressChangedEventArgs) Handles backWork.ProgressChanged
        pcbLoading.Value = Math.Min(e.ProgressPercentage, pcbLoading.Maximum)
        If e.ProgressPercentage = pcbLoading.Maximum Then
            pcbLoading.Visible = False
            'lblLoading.Visible = False
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
            For i = 0 To animeCount - 1
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

        End Try

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
            'lstAnimes.SelectedIndex = 0
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
                'e.Graphics.FillRectangle(Brushes.MediumPurple, e.Bounds)
                e.Graphics.FillRectangle(brushPurple, e.Bounds)
            ElseIf themeBlue = True Then
                e.Graphics.FillRectangle(brushBlue, e.Bounds)
            ElseIf themeOrange = True Then
                e.Graphics.FillRectangle(brushOrange, e.Bounds)
            End If

            'e.Graphics.FillRectangle(Brushes.MediumPurple, e.Bounds)
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
        'e.DrawText()
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

    Private Sub lstwAnimeSearch_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lstwAnimeSearch.DrawColumnHeader
        Dim sf As New StringFormat()
        If themePurple = True Then
            e.Graphics.FillRectangle(Brushes.MediumOrchid, e.Bounds)
            e.Graphics.DrawString(e.Header.Text, Me.lstwAnimeSearch.Font, Brushes.White, e.Bounds, sf)
        ElseIf themeBlue = True Then
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds)
            e.Graphics.DrawString(e.Header.Text, Me.lstwAnimeSearch.Font, Brushes.White, e.Bounds, sf)
        Else
            e.Graphics.FillRectangle(Brushes.Tomato, e.Bounds)
            e.Graphics.DrawString(e.Header.Text, Me.lstwAnimeSearch.Font, Brushes.White, e.Bounds, sf)
        End If
        'If darkModeOn = False Then
        '    e.DrawText()
        'Else
        '    e.Graphics.DrawString(e.Header.Text, Me.lstwAnimeSearch.Font, Brushes.White, e.Bounds, sf)
        'End If
    End Sub

    Private Sub lstwAnimeSearch_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lstwAnimeSearch.DrawSubItem
        Dim sf As New StringFormat()
        If e.Item.Selected = True Then

            If themePurple = True Then
                e.Graphics.FillRectangle(brushPurple, e.Bounds)
            ElseIf themeBlue = True Then
                e.Graphics.FillRectangle(brushBlue, e.Bounds)
            ElseIf themeOrange = True Then
                e.Graphics.FillRectangle(brushOrange, e.Bounds)
            End If

            sf.Alignment = StringAlignment.Near
            'e.Graphics.DrawImage(imgLst.Images(0), e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height)

            e.Graphics.DrawString(e.SubItem.Text, Me.lstwAnimeSearch.Font, Brushes.White, e.Bounds, sf)
        Else
            If darkModeOn = False Then
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds)
            End If
            e.DrawText()
        End If
    End Sub


    Private Sub tsmiEdit_Click(sender As Object, e As EventArgs) Handles tsmiEdit.Click
        singleListClick = False
        Dim editAnime As frmEditAnime

        editAnime = New frmEditAnime
        editAnime.ShowDialog()
        lstwAnimeMain.Items.Clear()
        XmlParser.populateList()
    End Sub

    Private Sub tsbtnNewAnime_Click(sender As Object, e As EventArgs) Handles tsbtnNewAnime.Click
        Dim newAnime As frmNewAnime

        newAnime = New frmNewAnime
        newAnime.ShowDialog()

        XmlParser.populateList()

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
End Class
Public Class ListViewDoubleBuffered
    Inherits ListView

    Public Sub New()
        Me.DoubleBuffered = True
    End Sub
End Class
