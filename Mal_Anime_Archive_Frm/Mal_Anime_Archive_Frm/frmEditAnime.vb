Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class frmEditAnime

    Private animeIndex As Integer = 0
    Private anId As String

    Private Sub frmEditAnime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sug As AutoCompleteStringCollection = New AutoCompleteStringCollection

        For i As Integer = 0 To frmMain.animeCount - 1
            'sug.Add(frmMain.animeList(i).Title)
            ddlSelectAnime.Items.Add(frmMain.animeList(i).Title)
        Next

        ddlSelectAnime.SelectedIndex = frmMain.lstwAnimeMain.SelectedIndices(0)

        'ddlSelectAnime.AutoCompleteCustomSource = sug

        If frmMain.themePurple = True Then

            If frmMain.darkModeOn = True Then
                purpleThemeDarkMode()
            Else
                purpleThemeLightMode()
            End If

        ElseIf frmMain.themeBlue = True Then

            If frmMain.darkModeOn = True Then
                blueThemeDarkMode()
            Else
                blueThemeLightMode()
            End If

        ElseIf frmMain.themeOrange = True Then

            If frmMain.darkModeOn = True Then
                orangeThemeDarkMode()
            Else
                orangeThemeLightMode()
            End If

        End If


        If frmMain.singleListClick = False Then
            'anId = frmMain.lstwAnimeMain.FocusedItem.SubItems(0).Text
        ElseIf frmMain.editClick = True Then
            If frmMain.chkGridView.Checked = True Then
                anId = frmMain.lstwAnimeMain.FocusedItem.SubItems(0).Text
            Else
                anId = frmMain.lstwOne.FocusedItem.SubItems(0).Text
            End If
        Else

            anId = frmMain.lstwOne.FocusedItem.SubItems(0).Text
        End If


        loadAnimeInfo(anId)
        loadApiInfo(anId)

    End Sub


    Private Sub loadAnimeInfo(animeId As String)
        For i As Integer = 0 To frmMain.animeCount - 1
            If frmMain.animeList(i).AnimeId = animeId Then
                animeIndex = i
                lblTitle.Text = frmMain.animeList(i).Title
                lblAnimeID.Text = frmMain.animeList(i).AnimeId
                lblAnimeType.Text = frmMain.animeList(i).Type
                numUpDownScore.Value = frmMain.animeList(i).Score
                If frmMain.animeList(i).Status = "Watching" Then
                    ddlStatus.SelectedIndex = 0
                ElseIf frmMain.animeList(i).Status = "Completed" Then
                    ddlStatus.SelectedIndex = 1
                ElseIf frmMain.animeList(i).Status = "On-Hold" Then
                    ddlStatus.SelectedIndex = 2
                ElseIf frmMain.animeList(i).Status = "Dropped" Then
                    ddlStatus.SelectedIndex = 3
                ElseIf frmMain.animeList(i).Status = "Plan to Watch" Then
                    ddlStatus.SelectedIndex = 4
                End If

                If frmMain.animeList(i).Episodes = "0" Then
                    numUpDownEpisodes.Enabled = False
                    'numUp
                Else
                    numUpDownEpisodes.Value = frmMain.animeList(i).Episodes
                End If


                numUpDownWatched.Value = frmMain.animeList(i).WatchedEps



                'If frmMain.animeList(i).StartDate = "0000-00-00" Then

                'Else
                '    Dim tempDate As String = frmMain.animeList(i).StartDate
                '    Dim formatedDate As String
                '    Dim month As String
                '    Dim month2 As String
                '    Dim day As String
                '    Dim year As String


                '    month = tempDate.Remove(0, 5)
                '    month2 = month.Remove(2, 3)
                '    day = tempDate.Remove(0, 8)
                '    year = tempDate.Remove(4, 6)
                '    formatedDate = month2 & "/" & day & "/" & year

                '    dtStartDate.Value = formatedDate
                'End If

                'If frmMain.animeList(i).FinishDate = "0000-00-00" Then

                'Else
                '    Dim tempDate As String = frmMain.animeList(i).FinishDate
                '    Dim formatedDate As String
                '    Dim month As String
                '    Dim month2 As String
                '    Dim day As String
                '    Dim year As String


                '    month = tempDate.Remove(0, 5)
                '    month2 = month.Remove(2, 3)
                '    day = tempDate.Remove(0, 8)
                '    year = tempDate.Remove(4, 6)
                '    formatedDate = month2 & "/" & day & "/" & year

                '    dtFinishDate.Value = formatedDate
                'End If

                If frmMain.animeList(i).Myrewatch = "Very Low" Then
                    ddlRewatchValue.SelectedIndex = 0
                ElseIf frmMain.animeList(i).Myrewatch = "Low" Then
                    ddlRewatchValue.SelectedIndex = 1
                ElseIf frmMain.animeList(i).Myrewatch = "Medium" Then
                    ddlRewatchValue.SelectedIndex = 2
                ElseIf frmMain.animeList(i).Myrewatch = "High" Then
                    ddlRewatchValue.SelectedIndex = 3
                ElseIf frmMain.animeList(i).Myrewatch = "Very High" Then
                    ddlRewatchValue.SelectedIndex = 4
                End If

                numUpDownRewatch.Value = frmMain.animeList(i).Myrewatchingep

                txtTags.Text = frmMain.animeList(i).Mytags
                txtComments.Text = frmMain.animeList(i).Mycomments
            End If
        Next
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Dim newIndex As Integer
        For i As Integer = 0 To frmMain.animeCount - 1
            If frmMain.animeList(i).AnimeId = anId Then
                newIndex = i + 1
            End If
        Next

        anId = frmMain.animeList(newIndex).AnimeId

        loadAnimeInfo(anId)
        loadApiInfo(anId)
        ddlSelectAnime.SelectedIndex = newIndex
    End Sub

    Private Sub btnBackward_Click(sender As Object, e As EventArgs) Handles btnBackward.Click
        Dim newIndex As Integer
        For i As Integer = 0 To frmMain.animeCount - 1
            If frmMain.animeList(i).AnimeId = anId Then
                newIndex = i - 1
            End If
        Next

        anId = frmMain.animeList(newIndex).AnimeId

        loadAnimeInfo(anId)
        loadApiInfo(anId)
        ddlSelectAnime.SelectedIndex = newIndex
    End Sub

    Private Sub loadApiInfo(id As String)
        '*******************************
        '* JIKAN API TEST!
        '*
        '********************************
        Dim apiConnect As HttpWebRequest
        Dim apiUrl As String = "https://api.jikan.moe/anime/" & id
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        If frmMain.CheckConnection(apiUrl) = True Then
            apiConnect = DirectCast(WebRequest.Create(apiUrl), HttpWebRequest)
            response = DirectCast(apiConnect.GetResponse(), HttpWebResponse)

            reader = New StreamReader(response.GetResponseStream)

            Dim rawresp As String

            rawresp = reader.ReadToEnd()

            Dim jsonResulttodict = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(rawresp)

            Dim animeImage = jsonResulttodict.Item("image_url")
            pcbAnimeCover.Load(animeImage)

            Dim animeSynopsis = jsonResulttodict.Item("synopsis")
            rctSynopsis.Text = animeSynopsis

            Dim malScore = jsonResulttodict.Item("score")
            lblMALScore.Text = malScore

            Dim malRating = jsonResulttodict.Item("rating")
            lblMALRating.Text = malRating

            Dim premiereDate = jsonResulttodict.Item("premiered")
            lblPremiered.Text = premiereDate
        End If
    End Sub

    Private Sub chkViewComments_CheckedChanged(sender As Object, e As EventArgs) Handles chkViewComments.CheckedChanged
        If chkViewComments.Checked = True Then
            lblTagsHeading.Text = "Comments"
            txtComments.Visible = True
            txtTags.Visible = False
        Else
            lblTagsHeading.Text = "Tags"
            txtComments.Visible = False
            txtTags.Visible = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        frmMain.animeList(animeIndex).Score = numUpDownScore.Value

        If ddlStatus.SelectedIndex = 0 Then
            frmMain.animeList(animeIndex).Status = "Watching"
        ElseIf ddlStatus.SelectedIndex = 1 Then
            frmMain.animeList(animeIndex).Status = "Completed"
        ElseIf ddlStatus.SelectedIndex = 2 Then
            frmMain.animeList(animeIndex).Status = "On-Hold"
        ElseIf ddlStatus.SelectedIndex = 3 Then
            frmMain.animeList(animeIndex).Status = "Dropped"
        ElseIf ddlStatus.SelectedIndex = 4 Then
            frmMain.animeList(animeIndex).Status = "Plan to Watch"
        End If

        frmMain.animeList(animeIndex).WatchedEps = numUpDownWatched.Value
        'frmMain.animeList(animeIndex).StartDate = dtStartDate.Value
        'frmMain.animeList(animeIndex).FinishDate = dtFinishDate.Value

        If ddlRewatchValue.SelectedIndex = 0 Then
            frmMain.animeList(animeIndex).Myrewatch = "Very Low"
        ElseIf ddlRewatchValue.SelectedIndex = 1 Then
            frmMain.animeList(animeIndex).Myrewatch = "Low"
        ElseIf ddlRewatchValue.SelectedIndex = 2 Then
            frmMain.animeList(animeIndex).Myrewatch = "Medium"
        ElseIf ddlRewatchValue.SelectedIndex = 3 Then
            frmMain.animeList(animeIndex).Myrewatch = "High"
        ElseIf ddlRewatchValue.SelectedIndex = 4 Then
            frmMain.animeList(animeIndex).Myrewatch = "Very High"
        End If
        frmMain.animeList(animeIndex).Myrewatch = numUpDownScore.Value


        frmMain.animeList(animeIndex).Myrewatchingep = numUpDownScore.Value
        frmMain.animeList(animeIndex).Mytags = txtTags.Text
        frmMain.animeList(animeIndex).Mycomments = txtComments.Text

        Me.Close()

    End Sub

    Private Sub purpleThemeLightMode()
        'Nothing is in here because the purple light theme is the default,
        'therefore no arguments needed for now
    End Sub

    Private Sub blueThemeLightMode()
        Me.BackgroundImage = My.Resources.blue_back

        lblTitle.ForeColor = Color.Blue
        lblAnimeID.ForeColor = Color.Blue
        lblAnimeType.ForeColor = Color.Blue
        lblScoreHeading.ForeColor = Color.Black
        lblStatusHeading.ForeColor = Color.Black
        lblEpisodesHeading.ForeColor = Color.Black
        lblWatchedHeading.ForeColor = Color.Black
        chkViewComments.ForeColor = Color.Black
        lblTypeHeading.ForeColor = Color.Black
        lblStartDateHeading.ForeColor = Color.Black
        lblFinishDateHeading.ForeColor = Color.Black
        lblRewatchHeading.ForeColor = Color.Black
        lblRewatchTimes.ForeColor = Color.Black
        lblTagsHeading.ForeColor = Color.Black
        lblAnimeIDHeading.ForeColor = Color.Black
        lblTypeHeading.ForeColor = Color.Black
        lblMALRatingHeading.ForeColor = Color.Black
        lblMALScoreHeading.ForeColor = Color.Black
        lblPremieredHeading.ForeColor = Color.Black
        lblMALScore.ForeColor = Color.Blue
        lblMALRating.ForeColor = Color.Blue
        lblPremiered.ForeColor = Color.Blue

        With btnSave
            .FlatAppearance.BorderColor = Color.Blue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        End With

        With btnCancel
            .FlatAppearance.BorderColor = Color.Blue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        End With
    End Sub

    Private Sub orangeThemeLightMode()
        Me.BackgroundImage = My.Resources.orange_back

        lblTitle.ForeColor = Color.OrangeRed
        lblAnimeID.ForeColor = Color.OrangeRed
        lblAnimeType.ForeColor = Color.OrangeRed
        lblScoreHeading.ForeColor = Color.Black
        lblStatusHeading.ForeColor = Color.Black
        lblEpisodesHeading.ForeColor = Color.Black
        lblWatchedHeading.ForeColor = Color.Black
        chkViewComments.ForeColor = Color.Black
        lblTypeHeading.ForeColor = Color.Black
        lblStartDateHeading.ForeColor = Color.Black
        lblFinishDateHeading.ForeColor = Color.Black
        lblRewatchHeading.ForeColor = Color.Black
        lblRewatchTimes.ForeColor = Color.Black
        lblTagsHeading.ForeColor = Color.Black
        lblAnimeIDHeading.ForeColor = Color.Black
        lblTypeHeading.ForeColor = Color.Black
        lblMALRatingHeading.ForeColor = Color.Black
        lblMALScoreHeading.ForeColor = Color.Black
        lblPremieredHeading.ForeColor = Color.Black
        lblMALScore.ForeColor = Color.OrangeRed
        lblMALRating.ForeColor = Color.OrangeRed
        lblPremiered.ForeColor = Color.OrangeRed

        With btnSave
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.DarkRed
        End With

        With btnCancel
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.DarkRed
        End With
    End Sub



    Private Sub purpleThemeDarkMode()
        Me.BackgroundImage = My.Resources.purple_back

        gbxEdit.BackColor = Color.FromArgb(44, 44, 44)
        rctSynopsis.BackColor = Color.FromArgb(44, 44, 44)
        txtTags.BackColor = Color.FromArgb(63, 63, 63)
        txtComments.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownScore.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownEpisodes.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownWatched.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownRewatch.BackColor = Color.FromArgb(63, 63, 63)
        ddlStatus.BackColor = Color.FromArgb(63, 63, 63)
        ddlRewatchValue.BackColor = Color.FromArgb(63, 63, 63)

        lblTitle.ForeColor = Color.FromArgb(209, 122, 200)
        lblAnimeID.ForeColor = Color.FromArgb(209, 122, 200)
        lblAnimeType.ForeColor = Color.FromArgb(209, 122, 200)
        lblMALScore.ForeColor = Color.FromArgb(209, 122, 200)
        lblPremiered.ForeColor = Color.FromArgb(209, 122, 200)
        lblMALRating.ForeColor = Color.FromArgb(209, 122, 200)
        lblScoreHeading.ForeColor = Color.White
        lblStatusHeading.ForeColor = Color.White
        lblEpisodesHeading.ForeColor = Color.White
        lblWatchedHeading.ForeColor = Color.White
        chkViewComments.ForeColor = Color.White
        lblTypeHeading.ForeColor = Color.White
        lblStartDateHeading.ForeColor = Color.White
        lblFinishDateHeading.ForeColor = Color.White
        lblRewatchHeading.ForeColor = Color.White
        lblRewatchTimes.ForeColor = Color.White
        lblTagsHeading.ForeColor = Color.White
        lblAnimeIDHeading.ForeColor = Color.White
        lblTypeHeading.ForeColor = Color.White
        rctSynopsis.ForeColor = Color.White
        txtTags.ForeColor = Color.WhiteSmoke
        txtComments.ForeColor = Color.WhiteSmoke
        numUpDownScore.ForeColor = Color.White
        numUpDownEpisodes.ForeColor = Color.White
        numUpDownWatched.ForeColor = Color.White
        numUpDownRewatch.ForeColor = Color.White
        ddlRewatchValue.ForeColor = Color.White
        ddlStatus.ForeColor = Color.White
        lblMALScoreHeading.ForeColor = Color.White
        lblMALRatingHeading.ForeColor = Color.White
        lblPremieredHeading.ForeColor = Color.White

        With dtStartDate
            .CalendarTitleBackColor = Color.Black
            .CalendarForeColor = Color.White
            .CalendarTitleForeColor = Color.White
            .CalendarTrailingForeColor = Color.White
        End With

        With btnSave
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
            .ForeColor = Color.White
        End With

        With btnCancel
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
            .ForeColor = Color.White
        End With
    End Sub

    Private Sub blueThemeDarkMode()
        Me.BackgroundImage = My.Resources.blue_back

        gbxEdit.BackColor = Color.FromArgb(44, 44, 44)
        rctSynopsis.BackColor = Color.FromArgb(44, 44, 44)
        txtTags.BackColor = Color.FromArgb(63, 63, 63)
        txtComments.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownScore.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownEpisodes.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownWatched.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownRewatch.BackColor = Color.FromArgb(63, 63, 63)
        ddlStatus.BackColor = Color.FromArgb(63, 63, 63)
        ddlRewatchValue.BackColor = Color.FromArgb(63, 63, 63)

        lblTitle.ForeColor = Color.LightBlue
        lblAnimeID.ForeColor = Color.LightBlue
        lblAnimeType.ForeColor = Color.LightBlue
        lblMALScore.ForeColor = Color.LightBlue
        lblPremiered.ForeColor = Color.LightBlue
        lblMALRating.ForeColor = Color.LightBlue
        lblScoreHeading.ForeColor = Color.White
        lblStatusHeading.ForeColor = Color.White
        lblEpisodesHeading.ForeColor = Color.White
        lblWatchedHeading.ForeColor = Color.White
        chkViewComments.ForeColor = Color.White
        lblTypeHeading.ForeColor = Color.White
        lblStartDateHeading.ForeColor = Color.White
        lblFinishDateHeading.ForeColor = Color.White
        lblRewatchHeading.ForeColor = Color.White
        lblRewatchTimes.ForeColor = Color.White
        lblTagsHeading.ForeColor = Color.White
        lblAnimeIDHeading.ForeColor = Color.White
        lblTypeHeading.ForeColor = Color.White
        rctSynopsis.ForeColor = Color.White
        txtTags.ForeColor = Color.WhiteSmoke
        txtComments.ForeColor = Color.WhiteSmoke
        numUpDownScore.ForeColor = Color.White
        numUpDownEpisodes.ForeColor = Color.White
        numUpDownWatched.ForeColor = Color.White
        numUpDownRewatch.ForeColor = Color.White
        ddlRewatchValue.ForeColor = Color.White
        ddlStatus.ForeColor = Color.White
        lblMALScoreHeading.ForeColor = Color.White
        lblMALRatingHeading.ForeColor = Color.White
        lblPremieredHeading.ForeColor = Color.White

        With btnSave
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
            .ForeColor = Color.White
        End With

        With btnCancel
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
            .ForeColor = Color.White
        End With
    End Sub

    Private Sub orangeThemeDarkMode()
        Me.BackgroundImage = My.Resources.orange_back

        gbxEdit.BackColor = Color.FromArgb(44, 44, 44)
        rctSynopsis.BackColor = Color.FromArgb(44, 44, 44)
        txtTags.BackColor = Color.FromArgb(63, 63, 63)
        txtComments.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownScore.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownEpisodes.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownWatched.BackColor = Color.FromArgb(63, 63, 63)
        numUpDownRewatch.BackColor = Color.FromArgb(63, 63, 63)
        ddlStatus.BackColor = Color.FromArgb(63, 63, 63)
        ddlRewatchValue.BackColor = Color.FromArgb(63, 63, 63)

        lblTitle.ForeColor = Color.OrangeRed
        lblAnimeID.ForeColor = Color.OrangeRed
        lblAnimeType.ForeColor = Color.OrangeRed
        lblMALScore.ForeColor = Color.OrangeRed
        lblPremiered.ForeColor = Color.OrangeRed
        lblMALRating.ForeColor = Color.OrangeRed
        lblScoreHeading.ForeColor = Color.White
        lblStatusHeading.ForeColor = Color.White
        lblEpisodesHeading.ForeColor = Color.White
        lblWatchedHeading.ForeColor = Color.White
        chkViewComments.ForeColor = Color.White
        lblTypeHeading.ForeColor = Color.White
        lblStartDateHeading.ForeColor = Color.White
        lblFinishDateHeading.ForeColor = Color.White
        lblRewatchHeading.ForeColor = Color.White
        lblRewatchTimes.ForeColor = Color.White
        lblTagsHeading.ForeColor = Color.White
        lblAnimeIDHeading.ForeColor = Color.White
        lblTypeHeading.ForeColor = Color.White
        rctSynopsis.ForeColor = Color.White
        txtTags.ForeColor = Color.WhiteSmoke
        txtComments.ForeColor = Color.WhiteSmoke
        numUpDownScore.ForeColor = Color.White
        numUpDownEpisodes.ForeColor = Color.White
        numUpDownWatched.ForeColor = Color.White
        numUpDownRewatch.ForeColor = Color.White
        ddlRewatchValue.ForeColor = Color.White
        ddlStatus.ForeColor = Color.White
        lblMALScoreHeading.ForeColor = Color.White
        lblMALRatingHeading.ForeColor = Color.White
        lblPremieredHeading.ForeColor = Color.White

        With btnSave
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
            .ForeColor = Color.White
        End With

        With btnCancel
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
            .ForeColor = Color.White
        End With
    End Sub

    Private Sub ddlStatus_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ddlStatus.DrawItem

        Dim index As Integer = e.Index >= 0

        Dim brush As Brush = Brushes.Black

        e.DrawBackground()
        e.Graphics.DrawString(ddlStatus.Items(0).ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault)
        e.DrawFocusRectangle()
    End Sub

    Private Sub ddlSelectAnime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSelectAnime.SelectedIndexChanged
        Dim search As String = ddlSelectAnime.Text.Trim().ToUpper()
        Dim nameResults As String = ""

        animeIndex = ddlSelectAnime.SelectedIndex

        anId = frmMain.animeList(animeIndex).AnimeId

        loadAnimeInfo(anId)
        loadApiInfo(anId)
    End Sub

    Private Sub pcbAnimeCover_Click(sender As Object, e As EventArgs) Handles pcbAnimeCover.Click
        Process.Start("https://myanimelist.net/anime/" & anId)
    End Sub
End Class

Public Class MyDateTimePicker : Inherits DateTimePicker
    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using b As New SolidBrush(Me.BackColor)
            e.Graphics.FillRectangle(b, 0, 0, Width, Height)
        End Using
        e.Graphics.DrawRectangle(Pens.Gray, 0, 0, Width, Height)

        TextRenderer.DrawText(e.Graphics, Text, Font, Rectangle.FromLTRB(0, 0, Width - Height, Height), SystemColors.ControlText)

        ComboBoxRenderer.DrawDropDownButton(e.Graphics, Rectangle.FromLTRB(Width - Height, 0, Width, Height), VisualStyles.ComboBoxState.Normal)

        MyBase.OnPaint(e)
    End Sub
End Class