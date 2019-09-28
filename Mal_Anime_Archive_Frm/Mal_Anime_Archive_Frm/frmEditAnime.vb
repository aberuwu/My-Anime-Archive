Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports JikanDotNet

Public Class frmEditAnime

    Private themes As New Themes()
    Private animeIndex As Integer = 0
    Private anId As String

    Async Sub frmEditAnime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sug As AutoCompleteStringCollection = New AutoCompleteStringCollection

        For i As Integer = 0 To frmMain.animeList.Count() - 1
            'ddlSelectAnime.Items.Add(frmMain.sortedList(i).Title)
            mtddlSelectAnime.Items.Add(frmMain.sortedList(i).Title)
        Next

        mtddlSelectAnime.SelectedIndex = frmMain.lstwAnimeMain.SelectedIndices(0)

        loadAnimeInfo(anId)
        loadApiInfo(anId)

        If frmMain.themePurple = True Then

            If frmMain.darkModeOn = True Then
                purpleThemeDarkMode()
            Else
                'purpleThemeLightMode()
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

    End Sub


    Private Sub loadAnimeInfo(animeId As String)
        For i As Integer = 0 To frmMain.animeList.Count() - 1
            If frmMain.sortedList(i).AnimeId = animeId Then
                animeIndex = i
                lblTitle.Text = frmMain.sortedList(i).Title
                lblAnimeID.Text = frmMain.sortedList(i).AnimeId
                lblAnimeType.Text = frmMain.sortedList(i).Type
                numUpDownScore.Value = frmMain.sortedList(i).Score
                If frmMain.sortedList(i).Status = "Watching" Then
                    mtddlStatus.SelectedIndex = 0
                ElseIf frmMain.sortedList(i).Status = "Completed" Then
                    mtddlStatus.SelectedIndex = 1
                ElseIf frmMain.sortedList(i).Status = "On-Hold" Then
                    mtddlStatus.SelectedIndex = 2
                ElseIf frmMain.sortedList(i).Status = "Dropped" Then
                    mtddlStatus.SelectedIndex = 3
                ElseIf frmMain.sortedList(i).Status = "Plan to Watch" Then
                    mtddlStatus.SelectedIndex = 4
                End If

                If frmMain.sortedList(i).Episodes = "0" Then
                    numUpDownEpisodes.Enabled = False
                    'numUp
                Else
                    numUpDownEpisodes.Value = frmMain.sortedList(i).Episodes
                End If


                numUpDownWatched.Value = frmMain.sortedList(i).WatchedEps

                'Dim startDate As String = frmMain.sortedList(i).StartDate
                'Dim dt As DateTime = Convert.ToDateTime(startDate.ToString)
                'Dim format As String = "M-dd-yyyy"
                'Dim str As String = dt.ToString(format)

                'MsgBox(str)

                'mdtStartDate.Value = Convert.ToDateTime(str)
                'mdtFinishDate.Value = formatFinishDate

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

                If frmMain.sortedList(i).Myrewatch = "Very Low" Then
                    mtddlRewatchValue.SelectedIndex = 0
                ElseIf frmMain.sortedList(i).Myrewatch = "Low" Then
                    mtddlRewatchValue.SelectedIndex = 1
                ElseIf frmMain.sortedList(i).Myrewatch = "Medium" Then
                    mtddlRewatchValue.SelectedIndex = 2
                ElseIf frmMain.sortedList(i).Myrewatch = "High" Then
                    mtddlRewatchValue.SelectedIndex = 3
                ElseIf frmMain.sortedList(i).Myrewatch = "Very High" Then
                    mtddlRewatchValue.SelectedIndex = 4
                End If

                numUpDownRewatch.Value = frmMain.sortedList(i).Myrewatchingep

                txtTags.Text = frmMain.sortedList(i).Mytags
                txtComments.Text = frmMain.sortedList(i).Mycomments
            End If
        Next
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Dim newIndex As Integer
        For i As Integer = 0 To frmMain.animeList.Count() - 1
            If frmMain.sortedList(i).AnimeId = anId Then
                newIndex = i + 1
            End If
        Next

        anId = frmMain.sortedList(newIndex).AnimeId

        loadAnimeInfo(anId)
        loadApiInfo(anId)
        mtddlSelectAnime.SelectedIndex = newIndex
    End Sub

    Private Sub btnBackward_Click(sender As Object, e As EventArgs) Handles btnBackward.Click
        Dim newIndex As Integer
        For i As Integer = 0 To frmMain.animeList.Count() - 1
            If frmMain.sortedList(i).AnimeId = anId Then
                newIndex = i - 1
            End If
        Next

        anId = frmMain.sortedList(newIndex).AnimeId

        loadAnimeInfo(anId)
        loadApiInfo(anId)
        mtddlSelectAnime.SelectedIndex = newIndex
    End Sub

    '------------------------
    ' JIKAN REST API Call
    '-------------------------
    Async Sub loadApiInfo(id As String)
        Dim jikan As IJikan = New Jikan(True)
        Dim anime As JikanDotNet.Anime = Await jikan.GetAnime(anId)

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

        If IsNothing(anime.ImageURL) Then

        Else
            pcbAnimeCover.Load(anime.ImageURL)
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

        frmMain.sortedList(animeIndex).Score = numUpDownScore.Value

        If mtddlStatus.SelectedIndex = 0 Then
            frmMain.sortedList(animeIndex).Status = "Watching"
        ElseIf mtddlStatus.SelectedIndex = 1 Then
            frmMain.sortedList(animeIndex).Status = "Completed"
        ElseIf mtddlStatus.SelectedIndex = 2 Then
            frmMain.sortedList(animeIndex).Status = "On-Hold"
        ElseIf mtddlStatus.SelectedIndex = 3 Then
            frmMain.sortedList(animeIndex).Status = "Dropped"
        ElseIf mtddlStatus.SelectedIndex = 4 Then
            frmMain.sortedList(animeIndex).Status = "Plan to Watch"
        End If

        frmMain.sortedList(animeIndex).WatchedEps = numUpDownWatched.Value
        'frmMain.animeList(animeIndex).StartDate = dtStartDate.Value
        'frmMain.animeList(animeIndex).FinishDate = dtFinishDate.Value

        If mtddlRewatchValue.SelectedIndex = 0 Then
            frmMain.sortedList(animeIndex).Myrewatch = "Very Low"
        ElseIf mtddlRewatchValue.SelectedIndex = 1 Then
            frmMain.sortedList(animeIndex).Myrewatch = "Low"
        ElseIf mtddlRewatchValue.SelectedIndex = 2 Then
            frmMain.sortedList(animeIndex).Myrewatch = "Medium"
        ElseIf mtddlRewatchValue.SelectedIndex = 3 Then
            frmMain.sortedList(animeIndex).Myrewatch = "High"
        ElseIf mtddlRewatchValue.SelectedIndex = 4 Then
            frmMain.sortedList(animeIndex).Myrewatch = "Very High"
        End If
        frmMain.sortedList(animeIndex).Myrewatch = numUpDownScore.Value


        frmMain.sortedList(animeIndex).Myrewatchingep = numUpDownScore.Value
        frmMain.sortedList(animeIndex).Mytags = txtTags.Text
        frmMain.sortedList(animeIndex).Mycomments = txtComments.Text

        'frmMain.sortedList = frmSortWindow.sortList(frmMain.animeList, "title")

        Me.Close()

    End Sub

    'Private Sub purpleThemeLightMode()
    '    'Nothing is in here because the purple light theme is the default,
    '    'therefore no arguments needed for now
    'End Sub



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

        anId = frmMain.sortedList(animeIndex).AnimeId

        loadAnimeInfo(anId)
        loadApiInfo(anId)
    End Sub

    Private Sub mtddlSelectAnime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mtddlSelectAnime.SelectedIndexChanged
        Dim search As String = mtddlSelectAnime.Text.Trim().ToUpper()
        Dim nameResults As String = ""

        animeIndex = mtddlSelectAnime.SelectedIndex

        anId = frmMain.sortedList(animeIndex).AnimeId

        loadAnimeInfo(anId)
        loadApiInfo(anId)
    End Sub

    Private Sub pcbAnimeCover_Click(sender As Object, e As EventArgs) Handles pcbAnimeCover.Click
        Process.Start("https://myanimelist.net/anime/" & anId)
    End Sub


    'THEMES

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




        pcbLoading.Style = MetroFramework.MetroColorStyle.Blue
        mtddlSelectAnime.Style = MetroFramework.MetroColorStyle.Blue
        mtddlStatus.Style = MetroFramework.MetroColorStyle.Blue
        mtddlRewatchValue.Style = MetroFramework.MetroColorStyle.Blue
        mdtStartDate.Style = MetroFramework.MetroColorStyle.Blue
        mdtFinishDate.Style = MetroFramework.MetroColorStyle.Blue


        With btnBackward
            .FlatAppearance.BorderColor = Color.Blue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        End With

        With btnForward
            .FlatAppearance.BorderColor = Color.Blue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        End With

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

        pcbLoading.Style = MetroFramework.MetroColorStyle.Orange
        mtddlSelectAnime.Style = MetroFramework.MetroColorStyle.Orange
        mtddlStatus.Style = MetroFramework.MetroColorStyle.Orange
        mtddlRewatchValue.Style = MetroFramework.MetroColorStyle.Orange
        mdtStartDate.Style = MetroFramework.MetroColorStyle.Orange
        mdtFinishDate.Style = MetroFramework.MetroColorStyle.Orange

        With btnBackward
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.DarkRed
        End With

        With btnForward
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.DarkRed
        End With

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
        'ddlStatus.BackColor = Color.FromArgb(63, 63, 63)
        'ddlRewatchValue.BackColor = Color.FromArgb(63, 63, 63)

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
        'ddlRewatchValue.ForeColor = Color.White
        'ddlStatus.ForeColor = Color.White
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
        'ddlStatus.BackColor = Color.FromArgb(63, 63, 63)
        'ddlRewatchValue.BackColor = Color.FromArgb(63, 63, 63)

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
        ' ddlRewatchValue.ForeColor = Color.White
        ' ddlStatus.ForeColor = Color.White
        lblMALScoreHeading.ForeColor = Color.White
        lblMALRatingHeading.ForeColor = Color.White
        lblPremieredHeading.ForeColor = Color.White

        pcbLoading.Style = MetroFramework.MetroColorStyle.Blue
        mtddlSelectAnime.Style = MetroFramework.MetroColorStyle.Blue
        mtddlStatus.Style = MetroFramework.MetroColorStyle.Blue
        mtddlRewatchValue.Style = MetroFramework.MetroColorStyle.Blue
        mdtStartDate.Style = MetroFramework.MetroColorStyle.Blue
        mdtFinishDate.Style = MetroFramework.MetroColorStyle.Blue

        With btnBackward
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
            .ForeColor = Color.White
        End With

        With btnForward
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
            .ForeColor = Color.White
        End With

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
        'ddlStatus.BackColor = Color.FromArgb(63, 63, 63)
        'ddlRewatchValue.BackColor = Color.FromArgb(63, 63, 63)

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
        'ddlRewatchValue.ForeColor = Color.White
        'ddlStatus.ForeColor = Color.White
        lblMALScoreHeading.ForeColor = Color.White
        lblMALRatingHeading.ForeColor = Color.White
        lblPremieredHeading.ForeColor = Color.White

        pcbLoading.Style = MetroFramework.MetroColorStyle.Orange
        mtddlSelectAnime.Style = MetroFramework.MetroColorStyle.Orange
        mtddlStatus.Style = MetroFramework.MetroColorStyle.Orange
        mtddlRewatchValue.Style = MetroFramework.MetroColorStyle.Orange
        mdtStartDate.Style = MetroFramework.MetroColorStyle.Orange
        mdtFinishDate.Style = MetroFramework.MetroColorStyle.Orange

        With btnBackward
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
            .ForeColor = Color.White
        End With

        With btnForward
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
            .ForeColor = Color.White
        End With

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

    Private Sub backWorkEdit_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles backWorkEdit.ProgressChanged
        pcbLoading.Value = Math.Min(e.ProgressPercentage, pcbLoading.Maximum)
        'If e.ProgressPercentage = pcbLoading.Maximum Then
        '    pcbLoading.Visible = False
        '    'lblLoading.Visible = False
        'End If
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