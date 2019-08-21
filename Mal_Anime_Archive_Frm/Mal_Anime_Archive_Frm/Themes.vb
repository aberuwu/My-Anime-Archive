'---------------------------------------------
' File: Themes.vb
' Purpose: Stores all color scheme methods
' for the forms
'---------------------------------------------

Public Class Themes

    '*******************************
    '*
    '* Dark and Light Theme Methods
    '*
    '*******************************
    Public Sub orangeThemeLightModeMain()
        frmMain.lblTitle.ForeColor = Color.OrangeRed
        frmMain.lblId.ForeColor = Color.OrangeRed
        frmMain.lblType.ForeColor = Color.OrangeRed
        frmMain.lblEpisodes.ForeColor = Color.OrangeRed
        frmMain.lblWatched.ForeColor = Color.OrangeRed
        frmMain.lblScore.ForeColor = Color.OrangeRed
        frmMain.lblStatus.ForeColor = Color.OrangeRed
        frmMain.lstwAnimeMain.ForeColor = Color.Black

        frmMain.lblAnimeIdHeading.ForeColor = Color.Black
        frmMain.lblTypeHeading.ForeColor = Color.Black
        frmMain.lblEpisodesHeading.ForeColor = Color.Black
        frmMain.lblWatchedHeading.ForeColor = Color.Black
        frmMain.lblScoreHeading.ForeColor = Color.Black
        frmMain.lblStatusHeading.ForeColor = Color.Black
        frmMain.lblCopyright.ForeColor = Color.Black


        frmMain.txtSearch.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeMain.BackColor = Color.WhiteSmoke
        frmMain.lblCopyright.BackColor = Color.WhiteSmoke
        frmMain.lstAnimes.BackColor = Color.WhiteSmoke
        frmMain.lstAnimes.ForeColor = Color.Black
        frmMain.pcbLogo.Image = My.Resources.maa_logo_orange

        frmMain.lblDarkMode.ForeColor = Color.Black

        frmMain.tsFileLable.ForeColor = Color.Black

        frmMain.ssMain.BackColor = Color.WhiteSmoke

        'BUTTONS
        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
        End With


        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
        End With

    End Sub

    Public Sub purpleThemeLightModeMain()
        frmMain.lblTitle.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblId.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblType.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblEpisodes.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblWatched.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblScore.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblStatus.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lstwAnimeMain.ForeColor = Color.Black

        frmMain.lblAnimeIdHeading.ForeColor = Color.Black
        frmMain.lblTypeHeading.ForeColor = Color.Black
        frmMain.lblEpisodesHeading.ForeColor = Color.Black
        frmMain.lblWatchedHeading.ForeColor = Color.Black
        frmMain.lblScoreHeading.ForeColor = Color.Black
        frmMain.lblStatusHeading.ForeColor = Color.Black
        frmMain.lblCopyright.ForeColor = Color.Black


        frmMain.txtSearch.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeMain.BackColor = Color.WhiteSmoke
        frmMain.lblCopyright.BackColor = Color.WhiteSmoke
        frmMain.lstAnimes.BackColor = Color.WhiteSmoke
        frmMain.lstwStatus.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeSearch.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeSearch.ForeColor = Color.Black
        frmMain.lstAnimes.ForeColor = Color.Black
        frmMain.pcbLogo.Image = My.Resources.maa_logo_purple

        frmMain.lblDarkMode.ForeColor = Color.Black

        frmMain.tsFileLable.ForeColor = Color.Black

        frmMain.ssMain.BackColor = Color.WhiteSmoke

        'BUTTONS
        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

    End Sub

    Public Sub blueThemeLightModeMain()

        frmMain.lblTitle.ForeColor = Color.Blue
        frmMain.lblId.ForeColor = Color.Blue
        frmMain.lblType.ForeColor = Color.Blue
        frmMain.lblEpisodes.ForeColor = Color.Blue
        frmMain.lblWatched.ForeColor = Color.Blue
        frmMain.lblScore.ForeColor = Color.Blue
        frmMain.lblStatus.ForeColor = Color.Blue
        frmMain.lstwAnimeMain.ForeColor = Color.Black

        frmMain.lblAnimeIdHeading.ForeColor = Color.Black
        frmMain.lblTypeHeading.ForeColor = Color.Black
        frmMain.lblEpisodesHeading.ForeColor = Color.Black
        frmMain.lblWatchedHeading.ForeColor = Color.Black
        frmMain.lblScoreHeading.ForeColor = Color.Black
        frmMain.lblStatusHeading.ForeColor = Color.Black
        frmMain.lblCopyright.ForeColor = Color.Black

        frmMain.txtSearch.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeMain.BackColor = Color.WhiteSmoke
        frmMain.lblCopyright.BackColor = Color.WhiteSmoke
        frmMain.lstAnimes.BackColor = Color.WhiteSmoke
        frmMain.lstAnimes.ForeColor = Color.Black
        frmMain.pcbLogo.Image = My.Resources.maa_logo_blue

        frmMain.lblDarkMode.ForeColor = Color.Black

        frmMain.tsFileLable.ForeColor = Color.Black

        frmMain.ssMain.BackColor = Color.WhiteSmoke

        'BUTTONS
        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.Blue
        End With

        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.Blue
        End With
    End Sub

    Public Sub orangeThemeDarkModeMain()
        frmMain.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lblTitle.ForeColor = Color.White
        frmMain.lblId.ForeColor = Color.White
        frmMain.lblType.ForeColor = Color.White
        frmMain.lblEpisodes.ForeColor = Color.White
        frmMain.lblWatched.ForeColor = Color.White
        frmMain.lblScore.ForeColor = Color.White
        frmMain.lblStatus.ForeColor = Color.White
        frmMain.lstwAnimeMain.ForeColor = Color.White

        frmMain.lblAnimeIdHeading.ForeColor = Color.OrangeRed
        frmMain.lblTypeHeading.ForeColor = Color.OrangeRed
        frmMain.lblEpisodesHeading.ForeColor = Color.OrangeRed
        frmMain.lblWatchedHeading.ForeColor = Color.OrangeRed
        frmMain.lblScoreHeading.ForeColor = Color.OrangeRed
        frmMain.lblStatusHeading.ForeColor = Color.OrangeRed
        frmMain.lblCopyright.ForeColor = Color.White
        frmMain.lstwAnimeMain.BackColor = Color.FromArgb(44, 44, 44)

        frmMain.lblCopyright.BackColor = Color.FromArgb(38, 35, 35)
        frmMain.lstAnimes.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstAnimes.ForeColor = Color.WhiteSmoke
        frmMain.pcbLogo.Image = My.Resources.maa_logo_white2

        frmMain.lblDarkMode.ForeColor = Color.White
        frmMain.tsFileLable.ForeColor = Color.White

        frmMain.ssMain.BackColor = Color.FromArgb(38, 35, 35)

        'BUTTONS
        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
        End With

        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
        End With
    End Sub

    Public Sub purpleThemeDarkModeMain()
        frmMain.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lblTitle.ForeColor = Color.White
        frmMain.lblId.ForeColor = Color.White
        frmMain.lblType.ForeColor = Color.White
        frmMain.lblEpisodes.ForeColor = Color.White
        frmMain.lblWatched.ForeColor = Color.White
        frmMain.lblScore.ForeColor = Color.White
        frmMain.lblStatus.ForeColor = Color.White
        frmMain.lstwAnimeMain.ForeColor = Color.White
        frmMain.lstwAnimeSearch.ForeColor = Color.White

        frmMain.lblAnimeIdHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblTypeHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblEpisodesHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblWatchedHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblScoreHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblStatusHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblCopyright.ForeColor = Color.White
        frmMain.lstwAnimeMain.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwAnimeSearch.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwStatus.BackColor = Color.FromArgb(44, 44, 44)

        frmMain.lblCopyright.BackColor = Color.FromArgb(38, 35, 35)
        frmMain.lstAnimes.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstAnimes.ForeColor = Color.WhiteSmoke
        frmMain.pcbLogo.Image = My.Resources.maa_logo_white2

        frmMain.lblDarkMode.ForeColor = Color.White
        frmMain.tsFileLable.ForeColor = Color.White

        frmMain.ssMain.BackColor = Color.FromArgb(38, 35, 35)

        'BUTTONS
        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With
    End Sub

    Public Sub blueThemeDarkModeMain()
        frmMain.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lblTitle.ForeColor = Color.White
        frmMain.lblId.ForeColor = Color.White
        frmMain.lblType.ForeColor = Color.White
        frmMain.lblEpisodes.ForeColor = Color.White
        frmMain.lblWatched.ForeColor = Color.White
        frmMain.lblScore.ForeColor = Color.White
        frmMain.lblStatus.ForeColor = Color.White
        frmMain.lstwAnimeMain.ForeColor = Color.White

        frmMain.lblAnimeIdHeading.ForeColor = Color.LightBlue
        frmMain.lblTypeHeading.ForeColor = Color.LightBlue
        frmMain.lblEpisodesHeading.ForeColor = Color.LightBlue
        frmMain.lblWatchedHeading.ForeColor = Color.LightBlue
        frmMain.lblScoreHeading.ForeColor = Color.LightBlue
        frmMain.lblStatusHeading.ForeColor = Color.LightBlue
        frmMain.lblCopyright.ForeColor = Color.White
        frmMain.lstwAnimeMain.BackColor = Color.FromArgb(44, 44, 44)

        frmMain.lblCopyright.BackColor = Color.FromArgb(38, 35, 35)
        frmMain.lstAnimes.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstAnimes.ForeColor = Color.WhiteSmoke
        frmMain.pcbLogo.Image = My.Resources.maa_logo_white2

        frmMain.lblDarkMode.ForeColor = Color.White
        frmMain.tsFileLable.ForeColor = Color.White

        frmMain.ssMain.BackColor = Color.FromArgb(38, 35, 35)

        'BUTTONS
        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.Blue
        End With

        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.Blue
        End With
    End Sub

End Class
