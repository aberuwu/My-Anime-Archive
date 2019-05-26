Imports System.Xml
Imports System.Net
Imports System.Reflection
Public Class frmMain

    Public Property animeList As List(Of Anime) = New List(Of Anime)
    Public Property userList As List(Of User) = New List(Of User)
    Public Property animeCount As Integer = 0
    Public Property userCount As Integer = 0

    Private USER_IMG_URL As String
    Public Property darkModeOn As Boolean
    Public Property loadedXml As Boolean
    Public Property completed As Boolean = False

    Public Property header As String = "User-Agent:Mozilla/5.0 (iPhone; CPU iPhone OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3"


    Public Property ANIME_SOURCE_XML As String
    Private MAL_SOURCE_URL As String = "https://myanimelist.net/anime/"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'While loadedXml = False
        '    Dim welcomeOpen As WelcomeOpen

        '    welcomeOpen = New WelcomeOpen
        '    welcomeOpen.ShowDialog()
        'End While

        'Dim Style As New DataGridViewCellStyle

        'Style.ForeColor = Color.Black

        'dgvAnime.Rows(0).DefaultCellStyle = Style


        Dim welcomeOpen As WelcomeOpen

        welcomeOpen = New WelcomeOpen
        welcomeOpen.ShowDialog()

        EnableDoubleBuffered(dgvAnime, True)

        tsFileLable.Text = ANIME_SOURCE_XML

        If loadedXml = False Then
            btnSave.Enabled = False
            btnXml.Enabled = False
        Else
            btnSave.Enabled = True
            btnXml.Enabled = True
        End If

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        Dim ofpXml As OpenFileDialog = New OpenFileDialog()

        If ofpXml.ShowDialog = DialogResult.OK Then


            If ofpXml.FileName.Contains(".xml") Then
                ANIME_SOURCE_XML = ofpXml.FileName
                tsFileLable.Text = ANIME_SOURCE_XML
                loadXmlFile()
            Else
                MsgBox("Error! Please select an XML file!", MsgBoxStyle.Critical, "File Error!")
                Return
            End If

        End If

    End Sub

    Public Sub loadXmlFile()

        animeList.Clear()
        lstAnimes.Items.Clear()
        animeCount = 0
        userCount = 0
        dgvAnime.Rows.Clear()

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
                    dgvAnime.Rows.Add()
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

        For i As Integer = 0 To animeCount - 1
            lstAnimes.Items.Add(animeList(i).Title & animeList(i).AnimeId.PadLeft(100))
            dgvAnime.Rows(i).Cells("animeId").Value = animeList(i).AnimeId
            dgvAnime.Rows(i).Cells("animeTitle").Value = animeList(i).Title
            dgvAnime.Rows(i).Cells("animeType").Value = animeList(i).Type
            dgvAnime.Rows(i).Cells("animeEpisodes").Value = animeList(i).Episodes
            dgvAnime.Rows(i).Cells("myId").Value = animeList(i).MyId
            dgvAnime.Rows(i).Cells("animeWatched").Value = animeList(i).WatchedEps
            dgvAnime.Rows(i).Cells("animeStart").Value = animeList(i).StartDate
            dgvAnime.Rows(i).Cells("animeFinish").Value = animeList(i).FinishDate
            dgvAnime.Rows(i).Cells("animeScore").Value = animeList(i).Score
            dgvAnime.Rows(i).Cells("animeStatus").Value = animeList(i).Status
            dgvAnime.Rows(i).Cells("animeRewatch").Value = animeList(i).Myrewatch
            dgvAnime.Rows(i).Cells("animeComments").Value = animeList(i).Mycomments
        Next

        USER_IMG_URL = "https://cdn.myanimelist.net/images/userimages/" & userList(userCount).UserId & ".jpg"

        If CheckConnection(USER_IMG_URL) = True Then
            pcbUserPicture.Load(USER_IMG_URL)
        End If

        loadedXml = True

        lstAnimes.SelectedIndex = 0

        btnSave.Enabled = True
        btnXml.Enabled = True

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

    Private Sub wbsAnimeImage_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbsAnimeImage.DocumentCompleted
        wbsAnimeImage.Document.Body.Style = "zoom:100%"
        completed = True
    End Sub

    Private Sub lstAnimes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAnimes.SelectedIndexChanged

        If lstAnimes.SelectedIndex = -1 Then
            Return
        End If

        Dim animeIndex As Integer = lstAnimes.SelectedItem.ToString.Substring(100)

        For i As Integer = 0 To animeCount - 1
            If animeList(i).AnimeId.Contains(animeIndex) Then
                lblTitle.Text = animeList(i).Title
                lblId.Text = animeList(i).AnimeId
                lblType.Text = animeList(i).Type
                lblEpisodes.Text = animeList(i).Episodes
                lblWatched.Text = animeList(i).WatchedEps
                lblScore.Text = animeList(i).Score
                lblStatus.Text = animeList(i).Status

                dgvAnime.Rows(i).Selected = True
                dgvAnime.FirstDisplayedScrollingRowIndex = i



                MAL_SOURCE_URL = "https://myanimelist.net/anime/" & animeList(i).AnimeId

                If CheckConnection(MAL_SOURCE_URL) = True Then
                    'HttpWebRequest request = HttpWebRequest
                    wbsAnimeImage.Navigate(MAL_SOURCE_URL)

                    'While Not completed
                    'End While
                End If

            End If
        Next
    End Sub

    Private Sub dgvAnime_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAnime.SelectionChanged



    End Sub

    Private Sub dgvAnime_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAnime.CellMouseClick

        Dim anIndex As String
        Dim anId As String

        anIndex = dgvAnime.CurrentCell.RowIndex

        If (anIndex < 0) Then
            Return
        End If

        anId = dgvAnime.Rows(anIndex).Cells(0).Value

        For i As Integer = 0 To animeCount - 1
            If animeList(i).AnimeId.Contains(anId) Then

                If lstAnimes.SelectedIndex = -1 Or i > lstAnimes.Items.Count Then
                    lblTitle.Text = animeList(i).Title
                    lblId.Text = animeList(i).AnimeId
                    lblType.Text = animeList(i).Type
                    lblEpisodes.Text = animeList(i).Episodes
                    lblWatched.Text = animeList(i).WatchedEps
                    lblScore.Text = animeList(i).Score
                    lblStatus.Text = animeList(i).Status

                    MAL_SOURCE_URL = "https://myanimelist.net/anime/" & animeList(i).AnimeId
                    If CheckConnection(MAL_SOURCE_URL) = True Then
                        wbsAnimeImage.Navigate(MAL_SOURCE_URL)
                        'While Not completed
                        'End While
                    End If
                Else
                    lstAnimes.SelectedIndex = i
                End If

            End If
        Next
    End Sub

    'Private Sub lstAnimes_MouseHover(sender As Object, e As EventArgs) Handles lstAnimes.MouseHover
    '    If lstAnimes.SelectedIndex = -1 Then
    '        Return
    '    End If

    '    Dim animeIndex As Integer = lstAnimes.SelectedItem.ToString.Substring(100)

    '    For i As Integer = 0 To animeCount - 1
    '        If animeList(i).AnimeId.Contains(animeIndex) Then
    '            Dim but As New ToolTip()
    '            but.ToolTipTitle = animeList(i).Title
    '            but.UseFading = True
    '            but.UseAnimation = True
    '            but.SetToolTip(lstAnimes, "uwu")
    '        End If
    '    Next
    'End Sub



    Private Sub wbsAnimeImage_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles wbsAnimeImage.ProgressChanged
        If e.MaximumProgress <> 0 And e.MaximumProgress >= e.CurrentProgress Then
            prbBrowser.Value = (100 * e.CurrentProgress / e.MaximumProgress)
            tspb1.Value = (100 * e.CurrentProgress / e.MaximumProgress)
        Else
            prbBrowser.Value = 100
            prbBrowser.Visible = True

            tspb1.Value = 100
            tspb1.Visible = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim search As String = txtSearch.Text.Trim().ToUpper()
        Dim nameResults As String = ""

        lstAnimes.Items.Clear()

        For i = 0 To animeCount - 1
            nameResults = animeList(i).Title.Trim().ToUpper()

            If nameResults.Contains(search) Then
                lstAnimes.Items.Add(StrConv(nameResults.ToLower(), VbStrConv.ProperCase) & animeList(i).AnimeId.PadLeft(100))
            End If
        Next
    End Sub

    Private Sub btnUserInfo_Click(sender As Object, e As EventArgs) Handles btnUserInfo.Click
        Dim userInfo As frmUserInfo

        userInfo = New frmUserInfo
        userInfo.ShowDialog()

    End Sub


    Private Sub pcbtnDarkMode_Click(sender As Object, e As EventArgs) Handles pcbtnDarkMode.Click
        If darkModeOn = False Then
            darkModeOn = True
            pcbtnDarkMode.Image = My.Resources.Switch_OnP
            Me.BackColor = Color.FromArgb(44, 44, 44) 'Color.FromArgb(38, 35, 35)
            lblTitle.ForeColor = Color.White
            lblId.ForeColor = Color.White
            lblType.ForeColor = Color.White
            lblEpisodes.ForeColor = Color.White
            lblWatched.ForeColor = Color.White
            lblScore.ForeColor = Color.White
            lblStatus.ForeColor = Color.White

            lblAnimeIdHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblTypeHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblEpisodesHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblWatchedHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblScoreHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblStatusHeading.ForeColor = Color.FromArgb(192, 0, 192)
            'Color.FromArgb(192, 0, 192)
            dgvAnime.BackgroundColor = Color.FromArgb(44, 44, 44)

            'lstAnimes.BackColor = Color.FromArgb(124, 37, 168)
            lstAnimes.BackColor = Color.FromArgb(147, 84, 166)
            lstAnimes.ForeColor = Color.White
            pcbLogoWhite.Visible = True
            pcbLogo.Visible = False

            lblDarkMode.ForeColor = Color.White

            If loadedXml = False Then
                pcbUserPicture.Image = My.Resources.user_icon_white
            End If

            tsFileLable.ForeColor = Color.White

            ssMain.BackColor = Color.FromArgb(38, 35, 35)

        ElseIf darkModeOn = True Then
            darkModeOn = False
            pcbtnDarkMode.Image = My.Resources.Switch_OffP
            Me.BackColor = Color.WhiteSmoke

            lblTitle.ForeColor = Color.FromArgb(192, 0, 192)
            lblId.ForeColor = Color.FromArgb(192, 0, 192)
            lblType.ForeColor = Color.FromArgb(192, 0, 192)
            lblEpisodes.ForeColor = Color.FromArgb(192, 0, 192)
            lblWatched.ForeColor = Color.FromArgb(192, 0, 192)
            lblScore.ForeColor = Color.FromArgb(192, 0, 192)
            lblStatus.ForeColor = Color.FromArgb(192, 0, 192)

            lblAnimeIdHeading.ForeColor = Color.Black
            lblTypeHeading.ForeColor = Color.Black
            lblEpisodesHeading.ForeColor = Color.Black
            lblWatchedHeading.ForeColor = Color.Black
            lblScoreHeading.ForeColor = Color.Black
            lblStatusHeading.ForeColor = Color.Black

            dgvAnime.BackgroundColor = Color.Gray

            lstAnimes.BackColor = Color.WhiteSmoke
            lstAnimes.ForeColor = Color.Black
            pcbLogoWhite.Visible = False
            pcbLogo.Visible = True

            lblDarkMode.ForeColor = Color.Black

            If loadedXml = False Then
                pcbUserPicture.Image = My.Resources.user_icon
            End If

            tsFileLable.ForeColor = Color.Black

            ssMain.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim changelog As frmChangeLog

        changelog = New frmChangeLog
        changelog.ShowDialog()
    End Sub

    Private Sub pcbUserPicture_Click(sender As Object, e As EventArgs) Handles pcbUserPicture.Click

        If loadedXml = True Then
            System.Diagnostics.Process.Start("https://myanimelist.net/profile/" & userList(userCount).Username)
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

    Private Sub chkGridView_CheckedChanged(sender As Object, e As EventArgs) Handles chkGridView.CheckedChanged
        If chkGridView.Checked = True Then
            dgvAnime.Visible = True
        Else
            dgvAnime.Visible = False
        End If
    End Sub

    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView, ByVal setting As Boolean)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)
    End Sub





    'Private Sub frmMain_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
    '    Me.SuspendLayout()
    'End Sub

    'Private Sub frmMain_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
    '    Me.ResumeLayout()
    'End Sub
End Class
