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

'Imports System.Threading

Public Class frmMain

    Public Property animeList As List(Of Anime) = New List(Of Anime)
    Public Property userList As List(Of User) = New List(Of User)
    Public Property animeCount As Integer = 0
    Public Property userCount As Integer = 0

    Private USER_IMG_URL As String
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


    Public Sub sortList()
        'animeList
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtSearch.ForeColor = SystemColors.GrayText
        txtSearch.Text = "🔎 Anime Search"

        welcomeOpen()

        EnableDoubleBuffered(dgvAnime, True)

        tsFileLable.Text = ANIME_SOURCE_XML

        If loadedXml = False Then
            btnSave.Enabled = False
            btnXml.Enabled = False
        Else
            btnSave.Enabled = True
            btnXml.Enabled = True
        End If

        chkGridView.Checked = True
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
                loadXmlFile()
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


            For i As Integer = 0 To animeCount - 1
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

                'If animeList(i).Status = "Watching" Then
                '    lstAnimes.Items.Add("✦ " & i + 1 & ") " & animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                '    ttMain.SetToolTip(lstAnimes, "Watching")
                'ElseIf animeList(i).Status = "Completed" Then
                '    lstAnimes.Items.Add("◆ " & i + 1 & ") " & animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                '    ttMain.SetToolTip(lstAnimes, "Completed")
                'ElseIf animeList(i).Status = "On-Hold" Then
                '    lstAnimes.Items.Add("✧ " & i + 1 & ") " & animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                '    ttMain.SetToolTip(lstAnimes, "On-Hold")
                'ElseIf animeList(i).Status = "Dropped" Then
                '    lstAnimes.Items.Add("✲ " & i + 1 & ") " & animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                '    ttMain.SetToolTip(lstAnimes, "Dropped")
                'ElseIf animeList(i).Status = "Plan to Watch" Then
                '    lstAnimes.Items.Add("◇ " & i + 1 & ") " & animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                '    ttMain.SetToolTip(lstAnimes, "Plan to Watch")
                'End If
            Next
            vscrSearchList.Maximum = lstwAnimeSearch.Items.Count
        Catch ex As Exception
            MsgBox("No XML File Loaded", MsgBoxStyle.Information, "No File Found")
        End Try

    End Sub

    Public Sub loadXmlFile()

        animeList.Clear()
        lstwAnimeSearch.Items.Clear()
        lstwStatus.Items.Clear()
        lstAnimes.Items.Clear()
        animeCount = 0
        userCount = 0
        dgvAnime.Rows.Clear()
        lstwAnimeMain.Items.Clear()
        lblNoResultFound.Visible = False

        'Counts for Anime Fields
        Dim serIdCount As Integer = 0
        Dim episodesCount As Integer = 0
        Dim typeCount As Integer = 0
        Dim watchedCount As Integer = 0
        Dim startCount As Integer = 0
        Dim finishCount As Integer = 0
        Dim scoreCount As Integer = 0
        Dim statusCount As Integer = 0
        Dim myIdCount As Integer = 0
        Dim myRatedCount As Integer = 0
        Dim myDvdCount As Integer = 0
        Dim myStorageCount As Integer = 0
        Dim myCommentsCount As Integer = 0
        Dim myTimesCount As Integer = 0
        Dim myRewatchCount As Integer = 0
        Dim myTagsCount As Integer = 0
        Dim myRewatchingCount As Integer = 0
        Dim myRewatchingEpCount As Integer = 0
        Dim updateCount As Integer = 0


        'Counts for User Fields
        Dim userNameCount As Integer = 0
        Dim totAnimeCount As Integer = 0
        Dim totWatchCount As Integer = 0
        Dim totCompletedCount As Integer = 0
        Dim totOnHold As Integer = 0
        Dim totDropped As Integer = 0
        Dim planCount As Integer = 0
        Dim exportCount As Integer = 0

        Try
            Dim settings As XmlReaderSettings = New XmlReaderSettings
            settings.IgnoreWhitespace = True
            settings.IgnoreComments = True

            Dim reader As XmlReader = XmlReader.Create(ANIME_SOURCE_XML, settings)

            While reader.ReadState <> ReadState.EndOfFile

                If reader.Name = "user_id" AndAlso reader.NodeType = XmlNodeType.Element Then
                    userList.Add(New User)
                    userList(userCount).UserId = reader.ReadElementContentAsString

                End If

                If reader.Name = "user_export_type" AndAlso reader.NodeType = XmlNodeType.Element Then
                    userList(exportCount).UserExportType = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_name" AndAlso reader.NodeType = XmlNodeType.Element Then
                    userList(userNameCount).Username = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_anime" AndAlso reader.NodeType = XmlNodeType.Element Then
                    userList(totAnimeCount).TotalAnime = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_watching" AndAlso reader.NodeType = XmlNodeType.Element Then
                    userList(totWatchCount).TotalWatching = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_completed" AndAlso reader.NodeType = XmlNodeType.Element Then
                    userList(totCompletedCount).TotalCompleted = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_onhold" AndAlso reader.NodeType = XmlNodeType.Element Then
                    userList(totOnHold).TotalOnHold = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_dropped" AndAlso reader.NodeType = XmlNodeType.Element Then
                    userList(totDropped).TotalDropped = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_plantowatch" AndAlso reader.NodeType = XmlNodeType.Element Then
                    userList(planCount).PlaToWatch = reader.ReadElementContentAsString
                End If

                If reader.Name = "anime" AndAlso reader.NodeType = XmlNodeType.Element Then
                    ' dgvAnime.Rows.Add()
                End If

                If reader.Name = "series_animedb_id" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList.Add(New Anime)
                    animeList(serIdCount).AnimeId = reader.ReadElementContentAsString


                    serIdCount += 1
                End If

                If reader.Name = "series_title" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(animeCount).Title = reader.ReadElementContentAsString
                    animeCount += 1
                End If

                If reader.Name = "series_type" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(typeCount).Type = reader.ReadElementContentAsString
                    typeCount += 1
                End If

                If reader.Name = "series_episodes" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(episodesCount).Episodes = reader.ReadElementContentAsString
                    episodesCount += 1
                End If

                If reader.Name = "my_id" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myIdCount).MyId = reader.ReadElementContentAsString
                    myIdCount += 1
                End If

                If reader.Name = "my_watched_episodes" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(watchedCount).WatchedEps = reader.ReadElementContentAsString
                    watchedCount += 1
                End If

                If reader.Name = "my_start_date" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(startCount).StartDate = reader.ReadElementContentAsString
                    startCount += 1
                End If

                If reader.Name = "my_finish_date" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(finishCount).FinishDate = reader.ReadElementContentAsString
                    finishCount += 1
                End If

                If reader.Name = "my_rated" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myRatedCount).Myrated = reader.ReadElementContentAsString
                    myRatedCount += 1
                End If

                If reader.Name = "my_score" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(scoreCount).Score = reader.ReadElementContentAsString
                    scoreCount += 1
                End If

                If reader.Name = "my_dvd" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myDvdCount).Mydvd = reader.ReadElementContentAsString
                    myDvdCount += 1
                End If

                If reader.Name = "my_storage" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myStorageCount).Mystorage = reader.ReadElementContentAsString
                    myStorageCount += 1
                End If

                If reader.Name = "my_status" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(statusCount).Status = reader.ReadElementContentAsString
                    statusCount += 1
                End If

                If reader.Name = "my_comments" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myCommentsCount).Mycomments = reader.ReadElementContentAsString
                    myCommentsCount += 1
                End If

                If reader.Name = "my_times_watched" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myTimesCount).Mytimeswatched = reader.ReadElementContentAsString
                    myTimesCount += 1
                End If

                If reader.Name = "my_rewatch_value" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myRewatchCount).Myrewatch = reader.ReadElementContentAsString
                    myRewatchCount += 1
                End If

                If reader.Name = "my_tags" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myTagsCount).Mytags = reader.ReadElementContentAsString
                    myTagsCount += 1
                End If

                If reader.Name = "my_rewatching" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myRewatchingCount).Myrewatching = reader.ReadElementContentAsString
                    myRewatchingCount += 1
                End If

                If reader.Name = "my_rewatching_ep" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(myRewatchingEpCount).Myrewatchingep = reader.ReadElementContentAsString
                    myRewatchingEpCount += 1
                End If

                If reader.Name = "update_on_import" AndAlso reader.NodeType = XmlNodeType.Element Then
                    animeList(updateCount).Updateonimport = reader.ReadElementContentAsString
                    updateCount += 1
                End If

                reader.Read()

            End While

            reader.Close()
        Catch ex As Exception
            MsgBox("There was a problem with your XML File. Please try again with another file!", MsgBoxStyle.Critical, "Error")
            Return
        Finally

        End Try

        'txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim sug As AutoCompleteStringCollection = New AutoCompleteStringCollection

        For i As Integer = 0 To animeCount - 1

            sug.Add(animeList(i).Title)

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


            If animeList(i).Status = "Watching" Then
                lstAnimes.Items.Add(animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                ttMain.SetToolTip(lstAnimes, "Watching")
            ElseIf animeList(i).Status = "Completed" Then
                lstAnimes.Items.Add(animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                ttMain.SetToolTip(lstAnimes, "Completed")
            ElseIf animeList(i).Status = "On-Hold" Then
                lstAnimes.Items.Add(animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                ttMain.SetToolTip(lstAnimes, "On-Hold")
            ElseIf animeList(i).Status = "Dropped" Then
                lstAnimes.Items.Add(animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                ttMain.SetToolTip(lstAnimes, "Dropped")
            ElseIf animeList(i).Status = "Plan to Watch" Then
                lstAnimes.Items.Add(animeList(i).Title & animeList(i).AnimeId.PadLeft(1000))
                ttMain.SetToolTip(lstAnimes, "Plan to Watch")
            End If
        Next

        txtSearch.AutoCompleteCustomSource = sug

        PopulateList()

        USER_IMG_URL = "https://cdn.myanimelist.net/images/userimages/" & userList(userCount).UserId & ".jpg"

        If CheckConnection(USER_IMG_URL) = True Then
            pcbUserPicture.Load(USER_IMG_URL)
        End If

        loadedXml = True
        lstAnimes.SelectedIndex = 0
        btnSave.Enabled = True
        btnXml.Enabled = True
        lblNoListLoaded.Visible = False

        welcomePage()
    End Sub


    Private Sub populateSearchList()
        lstwAnimeSearch.Items.Clear()

        For i As Integer = 0 To animeCount - 1

        Next
    End Sub

    Private Sub welcomePage()
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
            For i As Integer = 0 To animeCount - 1
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
            For i As Integer = 0 To animeCount - 1
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


    '**********************************************
    '*
    '* Dark and Light Theme Functions
    '*
    '**********************************************
    Public Sub orangeThemeLightMode()
        lblTitle.ForeColor = Color.OrangeRed
        lblId.ForeColor = Color.OrangeRed
        lblType.ForeColor = Color.OrangeRed
        lblEpisodes.ForeColor = Color.OrangeRed
        lblWatched.ForeColor = Color.OrangeRed
        lblScore.ForeColor = Color.OrangeRed
        lblStatus.ForeColor = Color.OrangeRed
        lstwAnimeMain.ForeColor = Color.Black
        lstwOne.ForeColor = Color.Black
        chkGridView.ForeColor = Color.Black

        lblAnimeIdHeading.ForeColor = Color.Black
        lblTypeHeading.ForeColor = Color.Black
        lblEpisodesHeading.ForeColor = Color.Black
        lblWatchedHeading.ForeColor = Color.Black
        lblScoreHeading.ForeColor = Color.Black
        lblStatusHeading.ForeColor = Color.Black
        lblCopyright.ForeColor = Color.Black

        dgvAnime.BackgroundColor = Color.Gray

        txtSearch.BackColor = Color.WhiteSmoke
        lstwOne.BackColor = Color.WhiteSmoke
        lstwAnimeMain.BackColor = Color.WhiteSmoke
        lblCopyright.BackColor = Color.WhiteSmoke
        lstAnimes.BackColor = Color.WhiteSmoke
        lstAnimes.ForeColor = Color.Black
        'pcbLogoWhite.Visible = False
        pcbLogo.Image = My.Resources.maa_logo_orange

        lblDarkMode.ForeColor = Color.Black

        tsFileLable.ForeColor = Color.Black

        ssMain.BackColor = Color.WhiteSmoke


        'BUTTONS
        With btnRefresh
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
        End With


        With btnSearch
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
        End With

    End Sub

    Public Sub purpleThemeLightMode()
        lblTitle.ForeColor = Color.FromArgb(192, 0, 192)
        lblId.ForeColor = Color.FromArgb(192, 0, 192)
        lblType.ForeColor = Color.FromArgb(192, 0, 192)
        lblEpisodes.ForeColor = Color.FromArgb(192, 0, 192)
        lblWatched.ForeColor = Color.FromArgb(192, 0, 192)
        lblScore.ForeColor = Color.FromArgb(192, 0, 192)
        lblStatus.ForeColor = Color.FromArgb(192, 0, 192)
        lstwAnimeMain.ForeColor = Color.Black
        lstwOne.ForeColor = Color.Black
        chkGridView.ForeColor = Color.Black

        lblAnimeIdHeading.ForeColor = Color.Black
        lblTypeHeading.ForeColor = Color.Black
        lblEpisodesHeading.ForeColor = Color.Black
        lblWatchedHeading.ForeColor = Color.Black
        lblScoreHeading.ForeColor = Color.Black
        lblStatusHeading.ForeColor = Color.Black
        lblCopyright.ForeColor = Color.Black

        dgvAnime.BackgroundColor = Color.Gray

        txtSearch.BackColor = Color.WhiteSmoke
        lstwOne.BackColor = Color.WhiteSmoke
        lstwAnimeMain.BackColor = Color.WhiteSmoke
        lblCopyright.BackColor = Color.WhiteSmoke
        lstAnimes.BackColor = Color.WhiteSmoke
        lstwStatus.BackColor = Color.WhiteSmoke
        lstwAnimeSearch.BackColor = Color.WhiteSmoke
        lstwAnimeSearch.ForeColor = Color.Black
        lstAnimes.ForeColor = Color.Black
        'pcbLogoWhite.Visible = False
        pcbLogo.Image = My.Resources.maa_logo_purple

        lblDarkMode.ForeColor = Color.Black

        tsFileLable.ForeColor = Color.Black

        ssMain.BackColor = Color.WhiteSmoke

        'BUTTONS
        With btnRefresh
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With btnSearch
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

    End Sub

    Public Sub blueThemeLightMode()

        lblTitle.ForeColor = Color.Blue
        lblId.ForeColor = Color.Blue
        lblType.ForeColor = Color.Blue
        lblEpisodes.ForeColor = Color.Blue
        lblWatched.ForeColor = Color.Blue
        lblScore.ForeColor = Color.Blue
        lblStatus.ForeColor = Color.Blue
        lstwAnimeMain.ForeColor = Color.Black
        lstwOne.ForeColor = Color.Black
        chkGridView.ForeColor = Color.Black

        lblAnimeIdHeading.ForeColor = Color.Black
        lblTypeHeading.ForeColor = Color.Black
        lblEpisodesHeading.ForeColor = Color.Black
        lblWatchedHeading.ForeColor = Color.Black
        lblScoreHeading.ForeColor = Color.Black
        lblStatusHeading.ForeColor = Color.Black
        lblCopyright.ForeColor = Color.Black

        dgvAnime.BackgroundColor = Color.Gray

        txtSearch.BackColor = Color.WhiteSmoke
        lstwOne.BackColor = Color.WhiteSmoke
        lstwAnimeMain.BackColor = Color.WhiteSmoke
        lblCopyright.BackColor = Color.WhiteSmoke
        lstAnimes.BackColor = Color.WhiteSmoke
        lstAnimes.ForeColor = Color.Black
        'pcbLogoWhite.Visible = False
        pcbLogo.Image = My.Resources.maa_logo_blue

        lblDarkMode.ForeColor = Color.Black

        tsFileLable.ForeColor = Color.Black

        ssMain.BackColor = Color.WhiteSmoke

        'BUTTONS
        With btnRefresh
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.Blue
        End With

        With btnSearch
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.Blue
        End With
    End Sub

    Public Sub orangeThemeDarkMode()
        Me.BackColor = Color.FromArgb(44, 44, 44)
        lblTitle.ForeColor = Color.White
        lblId.ForeColor = Color.White
        lblType.ForeColor = Color.White
        lblEpisodes.ForeColor = Color.White
        lblWatched.ForeColor = Color.White
        lblScore.ForeColor = Color.White
        lblStatus.ForeColor = Color.White
        lstwAnimeMain.ForeColor = Color.White
        lstwOne.ForeColor = Color.White
        chkGridView.ForeColor = Color.White

        lblAnimeIdHeading.ForeColor = Color.OrangeRed
        lblTypeHeading.ForeColor = Color.OrangeRed
        lblEpisodesHeading.ForeColor = Color.OrangeRed
        lblWatchedHeading.ForeColor = Color.OrangeRed
        lblScoreHeading.ForeColor = Color.OrangeRed
        lblStatusHeading.ForeColor = Color.OrangeRed
        lblCopyright.ForeColor = Color.White
        dgvAnime.BackgroundColor = Color.FromArgb(44, 44, 44)
        lstwAnimeMain.BackColor = Color.FromArgb(44, 44, 44)
        lstwOne.BackColor = Color.FromArgb(44, 44, 44)

        lblCopyright.BackColor = Color.FromArgb(38, 35, 35)
        lstAnimes.BackColor = Color.FromArgb(44, 44, 44)
        lstAnimes.ForeColor = Color.WhiteSmoke
        ' pcbLogoWhite.Visible = True
        pcbLogo.Image = My.Resources.maa_logo_white2

        lblDarkMode.ForeColor = Color.White
        tsFileLable.ForeColor = Color.White

        ssMain.BackColor = Color.FromArgb(38, 35, 35)

        'BUTTONS

        With btnRefresh
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
        End With

        With btnSearch
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
        End With
    End Sub

    Public Sub purpleThemeDarkMode()
        Me.BackColor = Color.FromArgb(44, 44, 44)
        lblTitle.ForeColor = Color.White
        lblId.ForeColor = Color.White
        lblType.ForeColor = Color.White
        lblEpisodes.ForeColor = Color.White
        lblWatched.ForeColor = Color.White
        lblScore.ForeColor = Color.White
        lblStatus.ForeColor = Color.White
        lstwAnimeMain.ForeColor = Color.White
        lstwOne.ForeColor = Color.White
        chkGridView.ForeColor = Color.White
        lstwAnimeSearch.ForeColor = Color.White

        lblAnimeIdHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblTypeHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblEpisodesHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblWatchedHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblScoreHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblStatusHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblCopyright.ForeColor = Color.White
        dgvAnime.BackgroundColor = Color.FromArgb(44, 44, 44)
        lstwAnimeMain.BackColor = Color.FromArgb(44, 44, 44)
        lstwOne.BackColor = Color.FromArgb(44, 44, 44)
        lstwAnimeSearch.BackColor = Color.FromArgb(44, 44, 44)
        lstwStatus.BackColor = Color.FromArgb(44, 44, 44)

        lblCopyright.BackColor = Color.FromArgb(38, 35, 35)
        lstAnimes.BackColor = Color.FromArgb(44, 44, 44)
        lstAnimes.ForeColor = Color.WhiteSmoke
        'pcbLogoWhite.Visible = True
        pcbLogo.Image = My.Resources.maa_logo_white2

        lblDarkMode.ForeColor = Color.White
        tsFileLable.ForeColor = Color.White

        ssMain.BackColor = Color.FromArgb(38, 35, 35)

        'BUTTONS
        With btnRefresh
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With btnSearch
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With
    End Sub

    Public Sub blueThemeDarkMode()
        Me.BackColor = Color.FromArgb(44, 44, 44)
        lblTitle.ForeColor = Color.White
        lblId.ForeColor = Color.White
        lblType.ForeColor = Color.White
        lblEpisodes.ForeColor = Color.White
        lblWatched.ForeColor = Color.White
        lblScore.ForeColor = Color.White
        lblStatus.ForeColor = Color.White
        lstwAnimeMain.ForeColor = Color.White
        lstwOne.ForeColor = Color.White
        chkGridView.ForeColor = Color.White

        lblAnimeIdHeading.ForeColor = Color.LightBlue
        lblTypeHeading.ForeColor = Color.LightBlue
        lblEpisodesHeading.ForeColor = Color.LightBlue
        lblWatchedHeading.ForeColor = Color.LightBlue
        lblScoreHeading.ForeColor = Color.LightBlue
        lblStatusHeading.ForeColor = Color.LightBlue
        lblCopyright.ForeColor = Color.White
        dgvAnime.BackgroundColor = Color.FromArgb(44, 44, 44)
        lstwAnimeMain.BackColor = Color.FromArgb(44, 44, 44)
        lstwOne.BackColor = Color.FromArgb(44, 44, 44)

        lblCopyright.BackColor = Color.FromArgb(38, 35, 35)
        lstAnimes.BackColor = Color.FromArgb(44, 44, 44)
        lstAnimes.ForeColor = Color.WhiteSmoke
        'pcbLogoWhite.Visible = True
        pcbLogo.Image = My.Resources.maa_logo_white2

        lblDarkMode.ForeColor = Color.White
        tsFileLable.ForeColor = Color.White

        ssMain.BackColor = Color.FromArgb(38, 35, 35)

        'BUTTONS
        With btnRefresh
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.Blue
        End With

        With btnSearch
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.Blue
        End With
    End Sub

    Private Sub pcbtnDarkMode_Click(sender As Object, e As EventArgs) Handles pcbtnDarkMode.Click
        If darkModeOn = False Then
            darkModeOn = True
            pcbtnDarkMode.Image = My.Resources.Switch_OnP

            If themePurple = True Then

                purpleThemeDarkMode()

            ElseIf themeBlue = True Then

                blueThemeDarkMode()

            ElseIf themeOrange = True Then

                orangeThemeDarkMode()

            End If

            If loadedXml = False Then
                pcbUserPicture.Image = My.Resources.user_icon_white
            End If

        ElseIf darkModeOn = True Then
            darkModeOn = False
            pcbtnDarkMode.Image = My.Resources.Switch_OffP
            Me.BackColor = Color.WhiteSmoke


            If themePurple = True Then

                purpleThemeLightMode()

            ElseIf themeBlue = True Then

                blueThemeLightMode()

            ElseIf themeOrange = True Then

                orangeThemeLightMode()

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
            'chromeBrowser.Load("https://myanimelist.net/profile/" & userList(userCount).Username)
            'System.Diagnostics.Process.Start("https://myanimelist.net/profile/" & userList(userCount).Username)
            'wbsAnimeImage.Navigate("https://myanimelist.net/profile/" & userList(userCount).Username)
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

    Private Sub lstwOne_DoubleClick(sender As Object, e As EventArgs) Handles lstwOne.DoubleClick
        singleListClick = True
        Dim editAnime As frmEditAnime

        editAnime = New frmEditAnime
        editAnime.ShowDialog()
        lstwOne.Items.Clear()

        lstAnimes_SelectedIndexChanged(Nothing, New EventArgs())
    End Sub

    Private Sub lstwAnimeMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstwAnimeMain.MouseDoubleClick
        singleListClick = False
        Dim editAnime As frmEditAnime

        editAnime = New frmEditAnime
        editAnime.ShowDialog()
        lstwAnimeMain.Items.Clear()
        reloadLists()
    End Sub


    Private Sub reloadLists()
        PopulateList()
    End Sub

    'EDIT BUTTON - STILL BUGGY
    Private Sub tsbtnEdit_Click(sender As Object, e As EventArgs) Handles tsbtnEdit.Click
        Dim editAnime As frmEditAnime
        editClick = True

        editAnime = New frmEditAnime
        editAnime.ShowDialog()
    End Sub

    Private Sub chkGridView_CheckedChanged(sender As Object, e As EventArgs) Handles chkGridView.CheckedChanged
        PopulateList()
    End Sub

    Private Sub PopulateList()
        If chkGridView.Checked = True Then
            dgvAnime.Enabled = False
            dgvAnime.Visible = False
            lstwOne.Visible = False
            lstwAnimeMain.Visible = True
            lstwAnimeMain.Items.Clear()
            fullListChecked = True



            Dim currentAnime As String

            For i As Integer = 0 To animeCount - 1
                pcbLoading.Maximum = animeCount - 1
                pcbLoading.Visible = True
                lstwAnimeMain.Items.Insert(i, animeList(i).AnimeId)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).Title)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).Type)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).Status)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).Episodes)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).WatchedEps)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).Score)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).StartDate)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).FinishDate)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).Mytags)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).MyId)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).Mycomments)
                lstwAnimeMain.Items(i).SubItems.Add(animeList(i).Myrewatch)

                'backWork.RunWorkerAsync()
                backWork.ReportProgress(i)
                'backWork.ReportProgress((100 * i) / animeCount)
            Next

            currentAnime = lblId.Text

            For i As Integer = 0 To animeCount - 1
                If lstwAnimeMain.Items(i).SubItems(0).Text = currentAnime Then
                    lstwAnimeMain.Items(i).Selected = True
                    lstwAnimeMain.Items(i).EnsureVisible()
                End If
            Next
        End If
    End Sub

    Private Sub backWork_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles backWork.DoWork
        'lblLoading.Visible = True
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
        If darkModeOn = False Then
            e.DrawText()
        Else
            e.Graphics.DrawString(e.Header.Text, Me.lstwAnimeMain.Font, Brushes.White, e.Bounds, sf)
        End If
    End Sub

    Private Sub lstwOne_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lstwOne.DrawSubItem
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
            e.Graphics.DrawString(e.SubItem.Text, Me.lstwOne.Font, Brushes.White, e.Bounds, sf)
        Else
            If darkModeOn = False Then
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds)
            End If
            e.DrawText()
        End If
    End Sub


    Private Sub lstwAnimeSearch_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lstwAnimeSearch.DrawColumnHeader
        Dim sf As New StringFormat()
        If darkModeOn = False Then
            e.DrawText()
        Else
            e.Graphics.DrawString(e.Header.Text, Me.lstwAnimeSearch.Font, Brushes.White, e.Bounds, sf)
        End If
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


    Private Sub lstwOne_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lstwOne.DrawColumnHeader
        Dim sf As New StringFormat()
        If darkModeOn = False Then
            e.DrawText()
        Else
            e.Graphics.DrawString(e.Header.Text, Me.lstwOne.Font, Brushes.White, e.Bounds, sf)
        End If
    End Sub

    Private Sub tsmiEdit_Click(sender As Object, e As EventArgs) Handles tsmiEdit.Click
        singleListClick = False
        Dim editAnime As frmEditAnime

        editAnime = New frmEditAnime
        editAnime.ShowDialog()
        lstwAnimeMain.Items.Clear()
        reloadLists()
    End Sub

    Private Sub tsmiDelete_Click(sender As Object, e As EventArgs) Handles tsmiDelete.Click

    End Sub

    Private Sub tsmiVisitPage_Click(sender As Object, e As EventArgs) Handles tsmiVisitPage.Click

    End Sub

    Private Sub pcbUserPicture_DoubleClick(sender As Object, e As EventArgs) Handles pcbUserPicture.DoubleClick
        welcomeOpen()
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

    Private Sub frmMain_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
        Me.SuspendLayout()
    End Sub

    Private Sub frmMain_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Me.ResumeLayout()
    End Sub
End Class



Public Class ListViewDoubleBuffered
    Inherits ListView

    Public Sub New()
        Me.DoubleBuffered = True
    End Sub
End Class
