'---------------------------------------------
' File: Themes.vb
' Usage: Stores all color scheme methods
' for the forms
'---------------------------------------------

Public Class Themes
    '------------------------
    'Themes for Main Form
    '------------------------
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

        frmMain.spltMain.Panel2.BackColor = Color.WhiteSmoke
        frmMain.txtSearch.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeMain.BackColor = Color.WhiteSmoke
        frmMain.lblCopyright.BackColor = Color.WhiteSmoke
        frmMain.lstAnimes.BackColor = Color.WhiteSmoke
        frmMain.lstwStatus.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeSearch.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeSearch.ForeColor = Color.Black
        frmMain.lstAnimes.ForeColor = Color.Black
        frmMain.pcbLogo.Image = My.Resources.maa_logo_orange

        frmMain.lblDarkMode.ForeColor = Color.Black

        frmMain.tsFileLable.ForeColor = Color.Black

        frmMain.ssMain.BackColor = Color.WhiteSmoke

        frmMain.pcbLoading.Style = MetroFramework.MetroColorStyle.Orange

        'BUTTONS

        With frmMain.btnOpenHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnExportHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnViewXmlHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnSortHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnNewAnimeHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnEditHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnDeleteHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnInfoSettingsHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
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

        frmMain.lblMALScoreHeading.ForeColor = Color.Black
        frmMain.lblMALRatingHeading.ForeColor = Color.Black
        frmMain.lblPremieredHeading.ForeColor = Color.Black
        frmMain.lblStatusHeading.ForeColor = Color.Black
        frmMain.lblMALStatusHeading.ForeColor = Color.Black
        frmMain.lblBrodcastHeading.ForeColor = Color.Black
        frmMain.lblDurationHeading.ForeColor = Color.Black
        frmMain.lblPopularityHeading.ForeColor = Color.Black
        frmMain.lblRankHeading.ForeColor = Color.Black
        frmMain.lblMembersHeading.ForeColor = Color.Black
        frmMain.lblFavoritesHeading.ForeColor = Color.Black
        frmMain.lblCommunityHeading.ForeColor = Color.FromArgb(192, 0, 192)

        frmMain.lblMALScore.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblMALRating.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblPremiered.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblStatus.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblMALStatus.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblBrodcast.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblDuration.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblPopularity.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblRank.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblMembers.ForeColor = Color.FromArgb(192, 0, 192)
        frmMain.lblFavorites.ForeColor = Color.FromArgb(192, 0, 192)

        frmMain.rctSynopsis.ForeColor = Color.Black
        frmMain.rctSynopsis.BackColor = Color.WhiteSmoke
        frmMain.lblNoConnection.ForeColor = Color.Black
        frmMain.mtsLoading.BackColor = Color.WhiteSmoke


        frmMain.spltMain.Panel2.BackColor = Color.WhiteSmoke
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

        frmMain.pcbLoading.Style = MetroFramework.MetroColorStyle.Purple

        'BUTTONS

        With frmMain.btnOpenHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnExportHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnViewXmlHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnSortHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnNewAnimeHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnEditHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnDeleteHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnInfoSettingsHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

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

        frmMain.spltMain.Panel2.BackColor = Color.WhiteSmoke
        frmMain.txtSearch.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeMain.BackColor = Color.WhiteSmoke
        frmMain.lblCopyright.BackColor = Color.WhiteSmoke
        frmMain.lstAnimes.BackColor = Color.WhiteSmoke
        frmMain.lstwStatus.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeSearch.BackColor = Color.WhiteSmoke
        frmMain.lstwAnimeSearch.ForeColor = Color.Black
        frmMain.lstAnimes.ForeColor = Color.Black
        frmMain.pcbLogo.Image = My.Resources.maa_logo_blue

        frmMain.lblDarkMode.ForeColor = Color.Black

        frmMain.tsFileLable.ForeColor = Color.Black

        frmMain.ssMain.BackColor = Color.WhiteSmoke

        frmMain.pcbLoading.Style = MetroFramework.MetroColorStyle.Blue

        'BUTTONS

        With frmMain.btnOpenHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnExportHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnViewXmlHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnSortHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnNewAnimeHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnEditHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnDeleteHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnInfoSettingsHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
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


        frmMain.spltMain.Panel2.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwAnimeMain.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwAnimeSearch.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwStatus.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwAnimeSearch.ForeColor = Color.White

        frmMain.pcbLoading.Style = MetroFramework.MetroColorStyle.Orange

        'BUTTONS

        With frmMain.btnOpenHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnExportHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnViewXmlHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnSortHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnNewAnimeHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnEditHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnDeleteHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnInfoSettingsHeader
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With

        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.OrangeRed
        End With
    End Sub

    Public Sub purpleThemeDarkModeMain()
        frmMain.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.spltMain.Panel2.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lblTitle.ForeColor = Color.White
        frmMain.lblId.ForeColor = Color.White
        frmMain.lblType.ForeColor = Color.White
        frmMain.lblEpisodes.ForeColor = Color.White
        frmMain.lblWatched.ForeColor = Color.White
        frmMain.lblScore.ForeColor = Color.White
        frmMain.lblStatus.ForeColor = Color.White
        frmMain.lstwAnimeMain.ForeColor = Color.White
        frmMain.lstwAnimeSearch.ForeColor = Color.White

        frmMain.lblMALScoreHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblMALRatingHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblPremieredHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblStatusHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblMALStatusHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblBrodcastHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblDurationHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblPopularityHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblRankHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblMembersHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblFavoritesHeading.ForeColor = Color.FromArgb(209, 122, 200)
        frmMain.lblCommunityHeading.ForeColor = Color.FromArgb(209, 122, 200)

        frmMain.lblMALScore.ForeColor = Color.White
        frmMain.lblMALRating.ForeColor = Color.White
        frmMain.lblPremiered.ForeColor = Color.White
        frmMain.lblStatus.ForeColor = Color.White
        frmMain.lblMALStatus.ForeColor = Color.White
        frmMain.lblBrodcast.ForeColor = Color.White
        frmMain.lblDuration.ForeColor = Color.White
        frmMain.lblPopularity.ForeColor = Color.White
        frmMain.lblRank.ForeColor = Color.White
        frmMain.lblMembers.ForeColor = Color.White
        frmMain.lblFavorites.ForeColor = Color.White

        frmMain.rctSynopsis.ForeColor = Color.White
        frmMain.rctSynopsis.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lblNoConnection.ForeColor = Color.White
        frmMain.mtsLoading.BackColor = Color.FromArgb(44, 44, 44)

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

        frmMain.pcbLoading.Style = MetroFramework.MetroColorStyle.Purple

        'BUTTONS

        With frmMain.btnOpenHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnExportHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnViewXmlHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnSortHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnNewAnimeHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnEditHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnDeleteHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

        With frmMain.btnInfoSettingsHeader
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
        End With

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


        frmMain.lblCopyright.BackColor = Color.FromArgb(38, 35, 35)
        frmMain.lstAnimes.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstAnimes.ForeColor = Color.WhiteSmoke
        frmMain.pcbLogo.Image = My.Resources.maa_logo_white2

        frmMain.lblDarkMode.ForeColor = Color.White
        frmMain.tsFileLable.ForeColor = Color.White

        frmMain.ssMain.BackColor = Color.FromArgb(38, 35, 35)


        frmMain.spltMain.Panel2.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwAnimeMain.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwAnimeSearch.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwStatus.BackColor = Color.FromArgb(44, 44, 44)
        frmMain.lstwAnimeSearch.ForeColor = Color.White

        frmMain.pcbLoading.Style = MetroFramework.MetroColorStyle.Blue

        'BUTTONS

        With frmMain.btnOpenHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnExportHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnViewXmlHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnSortHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnNewAnimeHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnEditHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnDeleteHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnInfoSettingsHeader
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnRefresh
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With

        With frmMain.btnSearch
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
        End With
    End Sub

    '------------------------
    'Themes for Edit Form
    '------------------------

    Public Sub blueThemeLightModeEdit()
        frmEditAnime.BackgroundImage = My.Resources.blue_back

        frmEditAnime.lblTitle.ForeColor = Color.Blue
        frmEditAnime.lblAnimeID.ForeColor = Color.Blue
        frmEditAnime.lblAnimeType.ForeColor = Color.Blue
        frmEditAnime.lblScoreHeading.ForeColor = Color.Black
        frmEditAnime.lblStatusHeading.ForeColor = Color.Black
        frmEditAnime.lblEpisodesHeading.ForeColor = Color.Black
        frmEditAnime.lblWatchedHeading.ForeColor = Color.Black
        frmEditAnime.chkViewComments.ForeColor = Color.Black
        frmEditAnime.lblTypeHeading.ForeColor = Color.Black
        frmEditAnime.lblStartDateHeading.ForeColor = Color.Black
        frmEditAnime.lblFinishDateHeading.ForeColor = Color.Black
        frmEditAnime.lblRewatchHeading.ForeColor = Color.Black
        frmEditAnime.lblRewatchTimes.ForeColor = Color.Black
        frmEditAnime.lblTagsHeading.ForeColor = Color.Black
        frmEditAnime.lblAnimeIDHeading.ForeColor = Color.Black
        frmEditAnime.lblTypeHeading.ForeColor = Color.Black
        frmEditAnime.lblMALRatingHeading.ForeColor = Color.Black
        frmEditAnime.lblMALScoreHeading.ForeColor = Color.Black
        frmEditAnime.lblPremieredHeading.ForeColor = Color.Black
        frmEditAnime.lblMALScore.ForeColor = Color.Blue
        frmEditAnime.lblMALRating.ForeColor = Color.Blue
        frmEditAnime.lblPremiered.ForeColor = Color.Blue

        With frmEditAnime.btnSave
            .FlatAppearance.BorderColor = Color.Blue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        End With

        With frmEditAnime.btnCancel
            .FlatAppearance.BorderColor = Color.Blue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
        End With
    End Sub

    Public Sub orangeThemeLightModeEdit()
        frmEditAnime.BackgroundImage = My.Resources.orange_back

        frmEditAnime.lblTitle.ForeColor = Color.OrangeRed
        frmEditAnime.lblAnimeID.ForeColor = Color.OrangeRed
        frmEditAnime.lblAnimeType.ForeColor = Color.OrangeRed
        frmEditAnime.lblScoreHeading.ForeColor = Color.Black
        frmEditAnime.lblStatusHeading.ForeColor = Color.Black
        frmEditAnime.lblEpisodesHeading.ForeColor = Color.Black
        frmEditAnime.lblWatchedHeading.ForeColor = Color.Black
        frmEditAnime.chkViewComments.ForeColor = Color.Black
        frmEditAnime.lblTypeHeading.ForeColor = Color.Black
        frmEditAnime.lblStartDateHeading.ForeColor = Color.Black
        frmEditAnime.lblFinishDateHeading.ForeColor = Color.Black
        frmEditAnime.lblRewatchHeading.ForeColor = Color.Black
        frmEditAnime.lblRewatchTimes.ForeColor = Color.Black
        frmEditAnime.lblTagsHeading.ForeColor = Color.Black
        frmEditAnime.lblAnimeIDHeading.ForeColor = Color.Black
        frmEditAnime.lblTypeHeading.ForeColor = Color.Black
        frmEditAnime.lblMALRatingHeading.ForeColor = Color.Black
        frmEditAnime.lblMALScoreHeading.ForeColor = Color.Black
        frmEditAnime.lblPremieredHeading.ForeColor = Color.Black
        frmEditAnime.lblMALScore.ForeColor = Color.OrangeRed
        frmEditAnime.lblMALRating.ForeColor = Color.OrangeRed
        frmEditAnime.lblPremiered.ForeColor = Color.OrangeRed

        With frmEditAnime.btnSave
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.DarkRed
        End With

        With frmEditAnime.btnCancel
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.Orange
            .FlatAppearance.MouseDownBackColor = Color.DarkRed
        End With
    End Sub



    Public Sub purpleThemeDarkModeEdit()
        frmEditAnime.BackgroundImage = My.Resources.purple_back

        frmEditAnime.gbxEdit.BackColor = Color.FromArgb(44, 44, 44)
        frmEditAnime.rctSynopsis.BackColor = Color.FromArgb(44, 44, 44)
        frmEditAnime.txtTags.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.txtComments.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownScore.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownEpisodes.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownWatched.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownRewatch.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.ddlStatus.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.ddlRewatchValue.BackColor = Color.FromArgb(63, 63, 63)

        frmEditAnime.lblTitle.ForeColor = Color.FromArgb(209, 122, 200)
        frmEditAnime.lblAnimeID.ForeColor = Color.FromArgb(209, 122, 200)
        frmEditAnime.lblAnimeType.ForeColor = Color.FromArgb(209, 122, 200)
        frmEditAnime.lblMALScore.ForeColor = Color.FromArgb(209, 122, 200)
        frmEditAnime.lblPremiered.ForeColor = Color.FromArgb(209, 122, 200)
        frmEditAnime.lblMALRating.ForeColor = Color.FromArgb(209, 122, 200)
        frmEditAnime.lblScoreHeading.ForeColor = Color.White
        frmEditAnime.lblStatusHeading.ForeColor = Color.White
        frmEditAnime.lblEpisodesHeading.ForeColor = Color.White
        frmEditAnime.lblWatchedHeading.ForeColor = Color.White
        frmEditAnime.chkViewComments.ForeColor = Color.White
        frmEditAnime.lblTypeHeading.ForeColor = Color.White
        frmEditAnime.lblStartDateHeading.ForeColor = Color.White
        frmEditAnime.lblFinishDateHeading.ForeColor = Color.White
        frmEditAnime.lblRewatchHeading.ForeColor = Color.White
        frmEditAnime.lblRewatchTimes.ForeColor = Color.White
        frmEditAnime.lblTagsHeading.ForeColor = Color.White
        frmEditAnime.lblAnimeIDHeading.ForeColor = Color.White
        frmEditAnime.lblTypeHeading.ForeColor = Color.White
        frmEditAnime.rctSynopsis.ForeColor = Color.White
        frmEditAnime.txtTags.ForeColor = Color.WhiteSmoke
        frmEditAnime.txtComments.ForeColor = Color.WhiteSmoke
        frmEditAnime.numUpDownScore.ForeColor = Color.White
        frmEditAnime.numUpDownEpisodes.ForeColor = Color.White
        frmEditAnime.numUpDownWatched.ForeColor = Color.White
        frmEditAnime.numUpDownRewatch.ForeColor = Color.White
        frmEditAnime.ddlRewatchValue.ForeColor = Color.White
        frmEditAnime.ddlStatus.ForeColor = Color.White
        frmEditAnime.lblMALScoreHeading.ForeColor = Color.White
        frmEditAnime.lblMALRatingHeading.ForeColor = Color.White
        frmEditAnime.lblPremieredHeading.ForeColor = Color.White

        With frmEditAnime.dtStartDate
            .CalendarTitleBackColor = Color.Black
            .CalendarForeColor = Color.White
            .CalendarTitleForeColor = Color.White
            .CalendarTrailingForeColor = Color.White
        End With

        With frmEditAnime.btnSave
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
            .ForeColor = Color.White
        End With

        With frmEditAnime.btnCancel
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
            .ForeColor = Color.White
        End With
    End Sub

    Public Sub blueThemeDarkModeEdit()
        frmEditAnime.BackgroundImage = My.Resources.blue_back

        frmEditAnime.gbxEdit.BackColor = Color.FromArgb(44, 44, 44)
        frmEditAnime.rctSynopsis.BackColor = Color.FromArgb(44, 44, 44)
        frmEditAnime.txtTags.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.txtComments.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownScore.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownEpisodes.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownWatched.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownRewatch.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.ddlStatus.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.ddlRewatchValue.BackColor = Color.FromArgb(63, 63, 63)

        frmEditAnime.lblTitle.ForeColor = Color.LightBlue
        frmEditAnime.lblAnimeID.ForeColor = Color.LightBlue
        frmEditAnime.lblAnimeType.ForeColor = Color.LightBlue
        frmEditAnime.lblMALScore.ForeColor = Color.LightBlue
        frmEditAnime.lblPremiered.ForeColor = Color.LightBlue
        frmEditAnime.lblMALRating.ForeColor = Color.LightBlue
        frmEditAnime.lblScoreHeading.ForeColor = Color.White
        frmEditAnime.lblStatusHeading.ForeColor = Color.White
        frmEditAnime.lblEpisodesHeading.ForeColor = Color.White
        frmEditAnime.lblWatchedHeading.ForeColor = Color.White
        frmEditAnime.chkViewComments.ForeColor = Color.White
        frmEditAnime.lblTypeHeading.ForeColor = Color.White
        frmEditAnime.lblStartDateHeading.ForeColor = Color.White
        frmEditAnime.lblFinishDateHeading.ForeColor = Color.White
        frmEditAnime.lblRewatchHeading.ForeColor = Color.White
        frmEditAnime.lblRewatchTimes.ForeColor = Color.White
        frmEditAnime.lblTagsHeading.ForeColor = Color.White
        frmEditAnime.lblAnimeIDHeading.ForeColor = Color.White
        frmEditAnime.lblTypeHeading.ForeColor = Color.White
        frmEditAnime.rctSynopsis.ForeColor = Color.White
        frmEditAnime.txtTags.ForeColor = Color.WhiteSmoke
        frmEditAnime.txtComments.ForeColor = Color.WhiteSmoke
        frmEditAnime.numUpDownScore.ForeColor = Color.White
        frmEditAnime.numUpDownEpisodes.ForeColor = Color.White
        frmEditAnime.numUpDownWatched.ForeColor = Color.White
        frmEditAnime.numUpDownRewatch.ForeColor = Color.White
        frmEditAnime.ddlRewatchValue.ForeColor = Color.White
        frmEditAnime.ddlStatus.ForeColor = Color.White
        frmEditAnime.lblMALScoreHeading.ForeColor = Color.White
        frmEditAnime.lblMALRatingHeading.ForeColor = Color.White
        frmEditAnime.lblPremieredHeading.ForeColor = Color.White

        With frmEditAnime.btnSave
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
            .ForeColor = Color.White
        End With

        With frmEditAnime.btnCancel
            .FlatAppearance.BorderColor = Color.LightBlue
            .FlatAppearance.MouseOverBackColor = Color.LightBlue
            .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
            .ForeColor = Color.White
        End With
    End Sub

    Public Sub orangeThemeDarkModeEdit()
        frmEditAnime.BackgroundImage = My.Resources.orange_back

        frmEditAnime.gbxEdit.BackColor = Color.FromArgb(44, 44, 44)
        frmEditAnime.rctSynopsis.BackColor = Color.FromArgb(44, 44, 44)
        frmEditAnime.txtTags.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.txtComments.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownScore.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownEpisodes.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownWatched.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.numUpDownRewatch.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.ddlStatus.BackColor = Color.FromArgb(63, 63, 63)
        frmEditAnime.ddlRewatchValue.BackColor = Color.FromArgb(63, 63, 63)

        frmEditAnime.lblTitle.ForeColor = Color.OrangeRed
        frmEditAnime.lblAnimeID.ForeColor = Color.OrangeRed
        frmEditAnime.lblAnimeType.ForeColor = Color.OrangeRed
        frmEditAnime.lblMALScore.ForeColor = Color.OrangeRed
        frmEditAnime.lblPremiered.ForeColor = Color.OrangeRed
        frmEditAnime.lblMALRating.ForeColor = Color.OrangeRed
        frmEditAnime.lblScoreHeading.ForeColor = Color.White
        frmEditAnime.lblStatusHeading.ForeColor = Color.White
        frmEditAnime.lblEpisodesHeading.ForeColor = Color.White
        frmEditAnime.lblWatchedHeading.ForeColor = Color.White
        frmEditAnime.chkViewComments.ForeColor = Color.White
        frmEditAnime.lblTypeHeading.ForeColor = Color.White
        frmEditAnime.lblStartDateHeading.ForeColor = Color.White
        frmEditAnime.lblFinishDateHeading.ForeColor = Color.White
        frmEditAnime.lblRewatchHeading.ForeColor = Color.White
        frmEditAnime.lblRewatchTimes.ForeColor = Color.White
        frmEditAnime.lblTagsHeading.ForeColor = Color.White
        frmEditAnime.lblAnimeIDHeading.ForeColor = Color.White
        frmEditAnime.lblTypeHeading.ForeColor = Color.White
        frmEditAnime.rctSynopsis.ForeColor = Color.White
        frmEditAnime.txtTags.ForeColor = Color.WhiteSmoke
        frmEditAnime.txtComments.ForeColor = Color.WhiteSmoke
        frmEditAnime.numUpDownScore.ForeColor = Color.White
        frmEditAnime.numUpDownEpisodes.ForeColor = Color.White
        frmEditAnime.numUpDownWatched.ForeColor = Color.White
        frmEditAnime.numUpDownRewatch.ForeColor = Color.White
        frmEditAnime.ddlRewatchValue.ForeColor = Color.White
        frmEditAnime.ddlStatus.ForeColor = Color.White
        frmEditAnime.lblMALScoreHeading.ForeColor = Color.White
        frmEditAnime.lblMALRatingHeading.ForeColor = Color.White
        frmEditAnime.lblPremieredHeading.ForeColor = Color.White

        With frmEditAnime.btnSave
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
            .ForeColor = Color.White
        End With

        With frmEditAnime.btnCancel
            .FlatAppearance.BorderColor = Color.OrangeRed
            .FlatAppearance.MouseOverBackColor = Color.OrangeRed
            .FlatAppearance.MouseDownBackColor = Color.Orange
            .ForeColor = Color.White
        End With
    End Sub
End Class
