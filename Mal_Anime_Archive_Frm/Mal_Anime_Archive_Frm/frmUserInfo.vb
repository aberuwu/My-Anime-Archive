﻿
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmUserInfo

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer

    Public Property webServices As Boolean
    Public Property USER_IMG_URL As String

    Private Sub frmUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ddlGraphSelection.SelectedIndex = 0

        If frmMain.animeCount <= 0 Then

        Else
            Dim cArea As ChartArea = chrtAnimeStatus.ChartAreas(0)

            With cArea
                '.AxisY.Maximum = 50
                .BackColor = Color.WhiteSmoke
            End With

            chrtAnimeStatus.Series(0)("PieLabelStyle") = "Disabled"
            chrtAnimeStatus.ChartAreas(0).AxisX.IsLabelAutoFit = False

            Dim dpnt As DataPoint = New DataPoint()
            dpnt.SetValueY(frmMain.userList(0).TotalWatching)
            chrtAnimeStatus.Series("Watching").Points.Add(dpnt)
            dpnt.ToolTip = "Watching"

            Dim dpnt2 As DataPoint = New DataPoint()
            dpnt2.SetValueY(frmMain.userList(0).TotalCompleted)
            chrtAnimeStatus.Series("Completed").Points.Add(dpnt2)
            dpnt2.ToolTip = "Completed"

            Dim dpnt3 As DataPoint = New DataPoint()
            dpnt3.SetValueY(frmMain.userList(0).TotalOnHold)
            chrtAnimeStatus.Series("On-Hold").Points.Add(dpnt3)
            dpnt3.ToolTip = "On-Hold"

            Dim dpnt4 As DataPoint = New DataPoint()
            dpnt4.SetValueY(frmMain.userList(0).TotalDropped)
            chrtAnimeStatus.Series("Dropped").Points.Add(dpnt4)
            dpnt4.ToolTip = "Dropped"

            Dim dpnt5 As DataPoint = New DataPoint()
            dpnt5.SetValueY(frmMain.userList(0).PlaToWatch)
            chrtAnimeStatus.Series("Plan to Watch").Points.Add(dpnt5)
            dpnt5.ToolTip = "Plan to Watch"
            dpnt5.Color = Color.FromArgb(209, 122, 200)
            chrtAnimeStatus.Series("Plan to Watch").Color = Color.FromArgb(209, 122, 200)
        End If


        If frmMain.loadedXml = True Then
            lblId.Text = frmMain.userList(frmMain.userCount).UserId
            lblUserName.Text = frmMain.userList(frmMain.userCount).Username
            lblTotalAnime.Text = frmMain.userList(frmMain.userCount).TotalAnime
            lblWatching.Text = frmMain.userList(frmMain.userCount).TotalWatching
            lblCompleted.Text = frmMain.userList(frmMain.userCount).TotalCompleted
            lblOnHold.Text = frmMain.userList(frmMain.userCount).TotalOnHold
            lblDropped.Text = frmMain.userList(frmMain.userCount).TotalDropped
            lblPlanToWatch.Text = frmMain.userList(frmMain.userCount).PlaToWatch

            Dim episodeCount As Integer = 0
            Dim meanScoreCount As Decimal = 0
            Dim meanScore As Decimal = 0
            Dim animeWScore As Decimal = 0

            For i As Integer = 0 To frmMain.animeCount - 1
                episodeCount += Convert.ToInt32(frmMain.animeList(i).WatchedEps)
                If Convert.ToInt32(frmMain.animeList(i).Score) = 0 Then
                Else
                    meanScoreCount += Convert.ToDecimal(frmMain.animeList(i).Score)
                    animeWScore += 1
                End If
            Next

            If animeWScore = 0 Then
                meanScore = 0
            Else
                meanScore = meanScoreCount / animeWScore
            End If

            lblEpisodes.Text = episodeCount
            lblMeanScore.Text = meanScore.ToString("N2")

            USER_IMG_URL = "https://cdn.myanimelist.net/images/userimages/" & frmMain.userList(frmMain.userCount).UserId & ".jpg"

            If frmMain.CheckConnection(USER_IMG_URL) = True Then
                pcbUserImage.Load(USER_IMG_URL)
            End If
        Else
            lblUserName.Text = "No User Loaded"
        End If

        'DarkMode Settings
        If frmMain.darkModeOn = True Then


            If frmMain.themePurple = True Then
                purpleGraphThemeDarkMode()
            ElseIf frmMain.themeBlue = True Then
                blueGraphThemeDarkMode()
            ElseIf frmMain.themeOrange = True Then
                orangeGraphThemeDarkMode()
            End If

        Else

            If frmMain.themePurple = True Then
                purpleGraphThemeLightMode()
            ElseIf frmMain.themeBlue = True Then
                blueGraphThemeLightMode()
            ElseIf frmMain.themeOrange = True Then
                orangeGraphThemeLightMode()
            End If

        End If

        'USER SETTINGS

        If frmMain.themePurple = True Then
            ddlThemes.SelectedIndex = 0
            Me.BackgroundImage = My.Resources.purple_back
        ElseIf frmMain.themeBlue = True Then
            ddlThemes.SelectedIndex = 1
            Me.BackgroundImage = My.Resources.blue_back
        ElseIf frmMain.themeOrange = True Then
            ddlThemes.SelectedIndex = 2
            Me.BackgroundImage = My.Resources.orange_back
        End If

        ddlFonts.SelectedIndex = 0


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmUserInfo_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmUserInfo_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmUserInfo_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub ddlThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlThemes.SelectedIndexChanged

        If ddlThemes.SelectedIndex = -1 Then
            Return
        ElseIf ddlThemes.SelectedIndex = 0 Then
            pcbPreviewLight.Image = My.Resources.Purple_Light
            pcbPreviewDark.Image = My.Resources.Purple_Dark
        ElseIf ddlThemes.SelectedIndex = 1 Then
            pcbPreviewLight.Image = My.Resources.Blue_Light
            pcbPreviewDark.Image = My.Resources.Blue_Dark
        ElseIf ddlThemes.SelectedIndex = 2 Then
            pcbPreviewLight.Image = My.Resources.Orange_Light
            pcbPreviewDark.Image = My.Resources.Orange_Dark
        Else
            Return
        End If

    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        If ddlThemes.SelectedIndex = -1 Then
            Return
        ElseIf ddlThemes.SelectedIndex = 0 Then
            frmMain.themePurple = True
            frmMain.themeBlue = False
            frmMain.themeOrange = False
            frmMain.tsMain.BackgroundImage = My.Resources.purple_back
            Me.BackgroundImage = My.Resources.purple_back

            If frmMain.darkModeOn = True Then
                frmMain.purpleThemeDarkMode()
                purpleGraphThemeDarkMode()
            Else
                frmMain.purpleThemeLightMode()
                purpleGraphThemeLightMode()
            End If

        ElseIf ddlThemes.SelectedIndex = 1 Then
            frmMain.themeBlue = True
            frmMain.themeOrange = False
            frmMain.themePurple = False
            frmMain.tsMain.BackgroundImage = My.Resources.blue_back
            Me.BackgroundImage = My.Resources.blue_back

            If frmMain.darkModeOn = True Then
                frmMain.blueThemeDarkMode()
                blueGraphThemeDarkMode()
            Else
                frmMain.blueThemeLightMode()
                blueGraphThemeLightMode()
            End If

        ElseIf ddlThemes.SelectedIndex = 2 Then
            frmMain.themeOrange = True
            frmMain.themeBlue = False
            frmMain.themePurple = False
            frmMain.tsMain.BackgroundImage = My.Resources.orange_back
            Me.BackgroundImage = My.Resources.orange_back

            If frmMain.darkModeOn = True Then
                frmMain.orangeThemeDarkMode()
                orangeGraphThemeDarkMode()
            Else
                frmMain.orangeThemeLightMode()
                orangeGraphThemeLightMode()
            End If

        Else
            Return
        End If
    End Sub





    Private Sub purpleGraphThemeLightMode()

    End Sub


    Private Sub blueGraphThemeLightMode()

        chrtAnimeStatus.Series(0).Points(0).Color = Color.LightBlue
        chrtAnimeStatus.Series(1).Points(0).Color = Color.Blue
        chrtAnimeStatus.Series(2).Points(0).Color = Color.CadetBlue
        chrtAnimeStatus.Series(3).Points(0).Color = Color.SteelBlue
        chrtAnimeStatus.Series(4).Points(0).Color = Color.DodgerBlue


        chrtAnimeStatus.Series("Watching").Color = Color.LightBlue
        chrtAnimeStatus.Series("Completed").Color = Color.Blue
        chrtAnimeStatus.Series("On-Hold").Color = Color.CadetBlue
        chrtAnimeStatus.Series("Dropped").Color = Color.SteelBlue
        chrtAnimeStatus.Series("Plan to Watch").Color = Color.DodgerBlue

        tbUser.BackColor = Color.WhiteSmoke
        lblUserIdHeading.ForeColor = Color.Black
        lblUserName.ForeColor = Color.Blue
        lblTotalAnimeHeading.ForeColor = Color.Black
        lblTotalWatchingHeading.ForeColor = Color.Black
        lblCompletedHeading.ForeColor = Color.Black
        lblOnHoldHeading.ForeColor = Color.Black
        lblDroppedHeading.ForeColor = Color.Black
        lblPlanToWatchHeading.ForeColor = Color.Black
        lblOtherStats.ForeColor = Color.Black
        lblEpisodesHeader.ForeColor = Color.Black
        lblMeanScoreHeader.ForeColor = Color.Black

        chrtAnimeStatus.BackColor = Color.WhiteSmoke
        chrtAnimeStatus.ChartAreas(0).BackColor = Color.WhiteSmoke
        chrtAnimeStatus.ChartAreas(0).AxisX.LineColor = Color.Black
        chrtAnimeStatus.ChartAreas(0).AxisY.LineColor = Color.Black
        chrtAnimeStatus.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Black
        chrtAnimeStatus.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Black
        chrtAnimeStatus.Legends(0).BackColor = Color.WhiteSmoke
        chrtAnimeStatus.Legends(0).ForeColor = Color.Black
        chrtAnimeStatus.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Black


        lblId.ForeColor = Color.Blue
        lblTotalAnime.ForeColor = Color.Blue
        lblWatching.ForeColor = Color.Blue
        lblCompleted.ForeColor = Color.Blue
        lblOnHold.ForeColor = Color.Blue
        lblDropped.ForeColor = Color.Blue
        lblPlanToWatch.ForeColor = Color.Blue
        lblEpisodes.ForeColor = Color.Blue
        lblMeanScore.ForeColor = Color.Blue

        lblProgramSettings.ForeColor = Color.Black
        tbSettings.BackColor = Color.WhiteSmoke
        lblTheme.ForeColor = Color.Black
        lblFont.ForeColor = Color.Black
        lblEDWebBrowser.ForeColor = Color.Black
        lblDefaultSave.ForeColor = Color.Black

        radEnabled.ForeColor = Color.Black
        radDisabled.ForeColor = Color.Black
    End Sub


    Private Sub orangeGraphThemeLightMode()

        chrtAnimeStatus.Palette = ChartColorPalette.Chocolate
        chrtAnimeStatus.Series(4).Points(0).Color = Color.SaddleBrown
        chrtAnimeStatus.Series("Plan to Watch").Color = Color.SaddleBrown

        tbUser.BackColor = Color.WhiteSmoke
        lblUserIdHeading.ForeColor = Color.Black
        lblUserName.ForeColor = Color.OrangeRed
        lblTotalAnimeHeading.ForeColor = Color.Black
        lblTotalWatchingHeading.ForeColor = Color.Black
        lblCompletedHeading.ForeColor = Color.Black
        lblOnHoldHeading.ForeColor = Color.Black
        lblDroppedHeading.ForeColor = Color.Black
        lblPlanToWatchHeading.ForeColor = Color.Black
        lblOtherStats.ForeColor = Color.Black
        lblEpisodesHeader.ForeColor = Color.Black
        lblMeanScoreHeader.ForeColor = Color.Black

        chrtAnimeStatus.BackColor = Color.WhiteSmoke
        chrtAnimeStatus.ChartAreas(0).BackColor = Color.WhiteSmoke
        chrtAnimeStatus.ChartAreas(0).AxisX.LineColor = Color.Black
        chrtAnimeStatus.ChartAreas(0).AxisY.LineColor = Color.Black
        chrtAnimeStatus.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Black
        chrtAnimeStatus.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Black
        chrtAnimeStatus.Legends(0).BackColor = Color.WhiteSmoke
        chrtAnimeStatus.Legends(0).ForeColor = Color.Black
        chrtAnimeStatus.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Black


        lblId.ForeColor = Color.OrangeRed
        lblTotalAnime.ForeColor = Color.OrangeRed
        lblWatching.ForeColor = Color.OrangeRed
        lblCompleted.ForeColor = Color.OrangeRed
        lblOnHold.ForeColor = Color.OrangeRed
        lblDropped.ForeColor = Color.OrangeRed
        lblPlanToWatch.ForeColor = Color.OrangeRed
        lblEpisodes.ForeColor = Color.OrangeRed
        lblMeanScore.ForeColor = Color.OrangeRed

        lblProgramSettings.ForeColor = Color.Black
        tbSettings.BackColor = Color.WhiteSmoke
        lblTheme.ForeColor = Color.Black
        lblFont.ForeColor = Color.Black
        lblEDWebBrowser.ForeColor = Color.Black
        lblDefaultSave.ForeColor = Color.Black

        radEnabled.ForeColor = Color.Black
        radDisabled.ForeColor = Color.Black
    End Sub


    Private Sub purpleGraphThemeDarkMode()
        tbUser.BackColor = Color.FromArgb(44, 44, 44)
        lblUserIdHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblUserName.ForeColor = Color.FromArgb(209, 122, 200)
        lblTotalAnimeHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblTotalWatchingHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblCompletedHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblOnHoldHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblDroppedHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblPlanToWatchHeading.ForeColor = Color.FromArgb(209, 122, 200)
        lblOtherStats.ForeColor = Color.FromArgb(209, 122, 200)
        lblEpisodesHeader.ForeColor = Color.FromArgb(209, 122, 200)
        lblMeanScoreHeader.ForeColor = Color.FromArgb(209, 122, 200)

        chrtAnimeStatus.BackColor = Color.FromArgb(44, 44, 44)
        chrtAnimeStatus.ChartAreas(0).BackColor = Color.FromArgb(44, 44, 44)
        chrtAnimeStatus.ChartAreas(0).AxisX.LineColor = Color.FromArgb(209, 122, 200)
        chrtAnimeStatus.ChartAreas(0).AxisY.LineColor = Color.FromArgb(209, 122, 200)
        chrtAnimeStatus.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.FromArgb(209, 122, 200)
        chrtAnimeStatus.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.FromArgb(209, 122, 200)
        chrtAnimeStatus.Legends(0).BackColor = Color.FromArgb(44, 44, 44)
        chrtAnimeStatus.Legends(0).ForeColor = Color.White
        chrtAnimeStatus.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.FromArgb(209, 122, 200)


        lblId.ForeColor = Color.White
        lblTotalAnime.ForeColor = Color.White
        lblWatching.ForeColor = Color.White
        lblCompleted.ForeColor = Color.White
        lblOnHold.ForeColor = Color.White
        lblDropped.ForeColor = Color.White
        lblPlanToWatch.ForeColor = Color.White
        lblEpisodes.ForeColor = Color.White
        lblMeanScore.ForeColor = Color.White

        lblProgramSettings.ForeColor = Color.White
        tbSettings.BackColor = Color.FromArgb(44, 44, 44)
        lblTheme.ForeColor = Color.White
        lblFont.ForeColor = Color.White
        lblEDWebBrowser.ForeColor = Color.White
        lblDefaultSave.ForeColor = Color.White

        radEnabled.ForeColor = Color.White
        radDisabled.ForeColor = Color.White
    End Sub


    Private Sub blueGraphThemeDarkMode()

        chrtAnimeStatus.Series(0).Points(0).Color = Color.LightBlue
        chrtAnimeStatus.Series(1).Points(0).Color = Color.Blue
        chrtAnimeStatus.Series(2).Points(0).Color = Color.CadetBlue
        chrtAnimeStatus.Series(3).Points(0).Color = Color.SteelBlue
        chrtAnimeStatus.Series(4).Points(0).Color = Color.DodgerBlue


        chrtAnimeStatus.Series("Watching").Color = Color.LightBlue
        chrtAnimeStatus.Series("Completed").Color = Color.Blue
        chrtAnimeStatus.Series("On-Hold").Color = Color.CadetBlue
        chrtAnimeStatus.Series("Dropped").Color = Color.SteelBlue
        chrtAnimeStatus.Series("Plan to Watch").Color = Color.DodgerBlue

        tbUser.BackColor = Color.FromArgb(44, 44, 44)
        lblUserIdHeading.ForeColor = Color.LightBlue
        lblUserName.ForeColor = Color.LightBlue
        lblTotalAnimeHeading.ForeColor = Color.LightBlue
        lblTotalWatchingHeading.ForeColor = Color.LightBlue
        lblCompletedHeading.ForeColor = Color.LightBlue
        lblOnHoldHeading.ForeColor = Color.LightBlue
        lblDroppedHeading.ForeColor = Color.LightBlue
        lblPlanToWatchHeading.ForeColor = Color.LightBlue
        lblOtherStats.ForeColor = Color.LightBlue
        lblEpisodesHeader.ForeColor = Color.LightBlue
        lblMeanScoreHeader.ForeColor = Color.LightBlue

        chrtAnimeStatus.BackColor = Color.FromArgb(44, 44, 44)
        chrtAnimeStatus.ChartAreas(0).BackColor = Color.FromArgb(44, 44, 44)
        chrtAnimeStatus.ChartAreas(0).AxisX.LineColor = Color.LightBlue
        chrtAnimeStatus.ChartAreas(0).AxisY.LineColor = Color.LightBlue
        chrtAnimeStatus.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightBlue
        chrtAnimeStatus.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightBlue
        chrtAnimeStatus.Legends(0).BackColor = Color.FromArgb(44, 44, 44)
        chrtAnimeStatus.Legends(0).ForeColor = Color.White
        chrtAnimeStatus.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.LightBlue


        lblId.ForeColor = Color.White
        lblTotalAnime.ForeColor = Color.White
        lblWatching.ForeColor = Color.White
        lblCompleted.ForeColor = Color.White
        lblOnHold.ForeColor = Color.White
        lblDropped.ForeColor = Color.White
        lblPlanToWatch.ForeColor = Color.White
        lblEpisodes.ForeColor = Color.White
        lblMeanScore.ForeColor = Color.White

        lblProgramSettings.ForeColor = Color.White
        tbSettings.BackColor = Color.FromArgb(44, 44, 44)
        lblTheme.ForeColor = Color.White
        lblFont.ForeColor = Color.White
        lblEDWebBrowser.ForeColor = Color.White
        lblDefaultSave.ForeColor = Color.White

        radEnabled.ForeColor = Color.White
        radDisabled.ForeColor = Color.White
    End Sub

    Private Sub orangeGraphThemeDarkMode()

        chrtAnimeStatus.Palette = ChartColorPalette.Chocolate
        chrtAnimeStatus.Series(4).Points(0).Color = Color.SaddleBrown
        chrtAnimeStatus.Series("Plan to Watch").Color = Color.SaddleBrown

        tbUser.BackColor = Color.FromArgb(44, 44, 44)
        lblUserIdHeading.ForeColor = Color.OrangeRed
        lblUserName.ForeColor = Color.OrangeRed
        lblTotalAnimeHeading.ForeColor = Color.OrangeRed
        lblTotalWatchingHeading.ForeColor = Color.OrangeRed
        lblCompletedHeading.ForeColor = Color.OrangeRed
        lblOnHoldHeading.ForeColor = Color.OrangeRed
        lblDroppedHeading.ForeColor = Color.OrangeRed
        lblPlanToWatchHeading.ForeColor = Color.OrangeRed
        lblOtherStats.ForeColor = Color.OrangeRed
        lblEpisodesHeader.ForeColor = Color.OrangeRed
        lblMeanScoreHeader.ForeColor = Color.OrangeRed

        chrtAnimeStatus.BackColor = Color.FromArgb(44, 44, 44)
        chrtAnimeStatus.ChartAreas(0).BackColor = Color.FromArgb(44, 44, 44)
        chrtAnimeStatus.ChartAreas(0).AxisX.LineColor = Color.OrangeRed
        chrtAnimeStatus.ChartAreas(0).AxisY.LineColor = Color.OrangeRed
        chrtAnimeStatus.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.OrangeRed
        chrtAnimeStatus.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.OrangeRed
        chrtAnimeStatus.Legends(0).BackColor = Color.FromArgb(44, 44, 44)
        chrtAnimeStatus.Legends(0).ForeColor = Color.White
        chrtAnimeStatus.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.OrangeRed


        lblId.ForeColor = Color.White
        lblTotalAnime.ForeColor = Color.White
        lblWatching.ForeColor = Color.White
        lblCompleted.ForeColor = Color.White
        lblOnHold.ForeColor = Color.White
        lblDropped.ForeColor = Color.White
        lblPlanToWatch.ForeColor = Color.White
        lblEpisodes.ForeColor = Color.White
        lblMeanScore.ForeColor = Color.White

        lblProgramSettings.ForeColor = Color.White
        tbSettings.BackColor = Color.FromArgb(44, 44, 44)
        lblTheme.ForeColor = Color.White
        lblFont.ForeColor = Color.White
        lblEDWebBrowser.ForeColor = Color.White
        lblDefaultSave.ForeColor = Color.White

        radEnabled.ForeColor = Color.White
        radDisabled.ForeColor = Color.White
    End Sub

    Private Sub chkPreviewDark_CheckedChanged(sender As Object, e As EventArgs) Handles chkPreviewDark.CheckedChanged

        If chkPreviewDark.Checked = True Then
            pcbPreviewLight.Visible = False
        Else
            pcbPreviewLight.Visible = True
        End If


    End Sub
End Class