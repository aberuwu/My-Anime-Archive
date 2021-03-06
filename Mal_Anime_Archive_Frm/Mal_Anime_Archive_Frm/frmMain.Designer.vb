﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstAnimes = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblAnimeIdHeading = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblTypeHeading = New System.Windows.Forms.Label()
        Me.lblEpisodes = New System.Windows.Forms.Label()
        Me.lblEpisodesHeading = New System.Windows.Forms.Label()
        Me.lblWatched = New System.Windows.Forms.Label()
        Me.lblWatchedHeading = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreHeading = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStatusHeading = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.tsFileLable = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspb1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblDarkMode = New System.Windows.Forms.Label()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnFullScreen = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.spltMain = New System.Windows.Forms.SplitContainer()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.vscrSearchList = New System.Windows.Forms.VScrollBar()
        Me.lstwStatus = New System.Windows.Forms.ListView()
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ctmAnimeList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiListOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiVisitPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.lblNoResultFound = New System.Windows.Forms.Label()
        Me.lstwAnimeSearch = New System.Windows.Forms.ListView()
        Me.srlstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.srlstID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbxDetailView = New System.Windows.Forms.GroupBox()
        Me.btnMALQuery = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtsLoading = New MetroFramework.Controls.MetroProgressSpinner()
        Me.lblNoConnection = New System.Windows.Forms.Label()
        Me.lblCommunityHeading = New System.Windows.Forms.Label()
        Me.lblFavorites = New System.Windows.Forms.Label()
        Me.lblFavoritesHeading = New System.Windows.Forms.Label()
        Me.lblMembers = New System.Windows.Forms.Label()
        Me.lblMembersHeading = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.lblRankHeading = New System.Windows.Forms.Label()
        Me.lblPopularity = New System.Windows.Forms.Label()
        Me.lblPopularityHeading = New System.Windows.Forms.Label()
        Me.lblBrodcast = New System.Windows.Forms.Label()
        Me.lblBrodcastHeading = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblDurationHeading = New System.Windows.Forms.Label()
        Me.lblMALStatus = New System.Windows.Forms.Label()
        Me.lblMALStatusHeading = New System.Windows.Forms.Label()
        Me.lblMALRating = New System.Windows.Forms.Label()
        Me.lblPremiered = New System.Windows.Forms.Label()
        Me.lblMALScore = New System.Windows.Forms.Label()
        Me.lblPremieredHeading = New System.Windows.Forms.Label()
        Me.lblMALRatingHeading = New System.Windows.Forms.Label()
        Me.lblMALScoreHeading = New System.Windows.Forms.Label()
        Me.rctSynopsis = New System.Windows.Forms.RichTextBox()
        Me.pcbAnimeCover = New System.Windows.Forms.PictureBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnAboutHeader = New System.Windows.Forms.Button()
        Me.btnInfoSettingsHeader = New System.Windows.Forms.Button()
        Me.btnDeleteHeader = New System.Windows.Forms.Button()
        Me.btnEditHeader = New System.Windows.Forms.Button()
        Me.btnNewAnimeHeader = New System.Windows.Forms.Button()
        Me.btnSortHeader = New System.Windows.Forms.Button()
        Me.btnViewXmlHeader = New System.Windows.Forms.Button()
        Me.btnExportHeader = New System.Windows.Forms.Button()
        Me.btnOpenHeader = New System.Windows.Forms.Button()
        Me.lblNoListLoaded = New System.Windows.Forms.Label()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnXml = New System.Windows.Forms.ToolStripButton()
        Me.btnAbout = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSort = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnNewAnime = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnUserInfo = New System.Windows.Forms.ToolStripButton()
        Me.pcbtnDarkMode = New System.Windows.Forms.PictureBox()
        Me.pcbUserPicture = New System.Windows.Forms.PictureBox()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.lstwAnimeMain = New System.Windows.Forms.ListView()
        Me.animeId4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeTitle4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeType4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeStatus4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeEpisodes4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeWatched4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeScore4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeStart4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeFinish4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeTags4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.myId4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeComments4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.animeRewatch4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pcbLoading = New MetroFramework.Controls.MetroProgressBar()
        Me.chkViewDetails = New System.Windows.Forms.CheckBox()
        Me.timerMain = New System.Windows.Forms.Timer(Me.components)
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.backWork = New System.ComponentModel.BackgroundWorker()
        Me.ssMain.SuspendLayout()
        CType(Me.spltMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltMain.Panel1.SuspendLayout()
        Me.spltMain.Panel2.SuspendLayout()
        Me.spltMain.SuspendLayout()
        Me.ctmAnimeList.SuspendLayout()
        Me.gbxDetailView.SuspendLayout()
        CType(Me.pcbAnimeCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.tsMain.SuspendLayout()
        CType(Me.pcbtnDarkMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbUserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstAnimes
        '
        Me.lstAnimes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAnimes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstAnimes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAnimes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lstAnimes.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAnimes.ForeColor = System.Drawing.Color.Black
        Me.lstAnimes.FormattingEnabled = True
        Me.lstAnimes.ItemHeight = 30
        Me.lstAnimes.Location = New System.Drawing.Point(44, 29)
        Me.lstAnimes.Name = "lstAnimes"
        Me.lstAnimes.Size = New System.Drawing.Size(533, 900)
        Me.lstAnimes.TabIndex = 0
        Me.lstAnimes.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(14, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(139, 32)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Anime Title"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblId.Location = New System.Drawing.Point(92, 75)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(60, 28)
        Me.lblId.TabIndex = 5
        Me.lblId.Text = "####"
        '
        'lblAnimeIdHeading
        '
        Me.lblAnimeIdHeading.AutoSize = True
        Me.lblAnimeIdHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblAnimeIdHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimeIdHeading.ForeColor = System.Drawing.Color.Black
        Me.lblAnimeIdHeading.Location = New System.Drawing.Point(14, 72)
        Me.lblAnimeIdHeading.Name = "lblAnimeIdHeading"
        Me.lblAnimeIdHeading.Size = New System.Drawing.Size(45, 32)
        Me.lblAnimeIdHeading.TabIndex = 4
        Me.lblAnimeIdHeading.Text = "ID:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblType.Location = New System.Drawing.Point(313, 75)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(60, 28)
        Me.lblType.TabIndex = 7
        Me.lblType.Text = "####"
        '
        'lblTypeHeading
        '
        Me.lblTypeHeading.AutoSize = True
        Me.lblTypeHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblTypeHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeHeading.ForeColor = System.Drawing.Color.Black
        Me.lblTypeHeading.Location = New System.Drawing.Point(204, 72)
        Me.lblTypeHeading.Name = "lblTypeHeading"
        Me.lblTypeHeading.Size = New System.Drawing.Size(72, 32)
        Me.lblTypeHeading.TabIndex = 6
        Me.lblTypeHeading.Text = "Type:"
        '
        'lblEpisodes
        '
        Me.lblEpisodes.AutoSize = True
        Me.lblEpisodes.BackColor = System.Drawing.Color.Transparent
        Me.lblEpisodes.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEpisodes.Location = New System.Drawing.Point(313, 106)
        Me.lblEpisodes.Name = "lblEpisodes"
        Me.lblEpisodes.Size = New System.Drawing.Size(60, 28)
        Me.lblEpisodes.TabIndex = 9
        Me.lblEpisodes.Text = "####"
        '
        'lblEpisodesHeading
        '
        Me.lblEpisodesHeading.AutoSize = True
        Me.lblEpisodesHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblEpisodesHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodesHeading.ForeColor = System.Drawing.Color.Black
        Me.lblEpisodesHeading.Location = New System.Drawing.Point(204, 103)
        Me.lblEpisodesHeading.Name = "lblEpisodesHeading"
        Me.lblEpisodesHeading.Size = New System.Drawing.Size(114, 32)
        Me.lblEpisodesHeading.TabIndex = 8
        Me.lblEpisodesHeading.Text = "Episodes:"
        '
        'lblWatched
        '
        Me.lblWatched.AutoSize = True
        Me.lblWatched.BackColor = System.Drawing.Color.Transparent
        Me.lblWatched.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWatched.Location = New System.Drawing.Point(489, 105)
        Me.lblWatched.Name = "lblWatched"
        Me.lblWatched.Size = New System.Drawing.Size(60, 28)
        Me.lblWatched.TabIndex = 11
        Me.lblWatched.Text = "####"
        '
        'lblWatchedHeading
        '
        Me.lblWatchedHeading.AutoSize = True
        Me.lblWatchedHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblWatchedHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatchedHeading.ForeColor = System.Drawing.Color.Black
        Me.lblWatchedHeading.Location = New System.Drawing.Point(376, 102)
        Me.lblWatchedHeading.Name = "lblWatchedHeading"
        Me.lblWatchedHeading.Size = New System.Drawing.Size(117, 32)
        Me.lblWatchedHeading.TabIndex = 10
        Me.lblWatchedHeading.Text = "Watched:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblScore.Location = New System.Drawing.Point(489, 75)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(60, 28)
        Me.lblScore.TabIndex = 17
        Me.lblScore.Text = "####"
        '
        'lblScoreHeading
        '
        Me.lblScoreHeading.AutoSize = True
        Me.lblScoreHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreHeading.ForeColor = System.Drawing.Color.Black
        Me.lblScoreHeading.Location = New System.Drawing.Point(376, 72)
        Me.lblScoreHeading.Name = "lblScoreHeading"
        Me.lblScoreHeading.Size = New System.Drawing.Size(81, 32)
        Me.lblScoreHeading.TabIndex = 16
        Me.lblScoreHeading.Text = "Score:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(93, 106)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 28)
        Me.lblStatus.TabIndex = 19
        Me.lblStatus.Text = "####"
        '
        'lblStatusHeading
        '
        Me.lblStatusHeading.AutoSize = True
        Me.lblStatusHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusHeading.ForeColor = System.Drawing.Color.Black
        Me.lblStatusHeading.Location = New System.Drawing.Point(14, 103)
        Me.lblStatusHeading.Name = "lblStatusHeading"
        Me.lblStatusHeading.Size = New System.Drawing.Size(88, 32)
        Me.lblStatusHeading.TabIndex = 18
        Me.lblStatusHeading.Text = "Status:"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(-2, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(232, 32)
        Me.txtSearch.TabIndex = 23
        Me.ttMain.SetToolTip(Me.txtSearch, "Search Anime Name")
        '
        'ssMain
        '
        Me.ssMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFileLable, Me.tspb1})
        Me.ssMain.Location = New System.Drawing.Point(0, 728)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(1348, 26)
        Me.ssMain.TabIndex = 25
        Me.ssMain.Text = "StatusStrip1"
        '
        'tsFileLable
        '
        Me.tsFileLable.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsFileLable.ForeColor = System.Drawing.Color.Black
        Me.tsFileLable.Name = "tsFileLable"
        Me.tsFileLable.Size = New System.Drawing.Size(56, 20)
        Me.tsFileLable.Text = "FilePath"
        '
        'tspb1
        '
        Me.tspb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tspb1.Name = "tspb1"
        Me.tspb1.Size = New System.Drawing.Size(100, 18)
        Me.tspb1.Visible = False
        '
        'lblDarkMode
        '
        Me.lblDarkMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDarkMode.AutoSize = True
        Me.lblDarkMode.BackColor = System.Drawing.Color.Transparent
        Me.lblDarkMode.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDarkMode.ForeColor = System.Drawing.Color.Black
        Me.lblDarkMode.Location = New System.Drawing.Point(801, 100)
        Me.lblDarkMode.Name = "lblDarkMode"
        Me.lblDarkMode.Size = New System.Drawing.Size(94, 23)
        Me.lblDarkMode.TabIndex = 28
        Me.lblDarkMode.Text = "Dark Mode"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Location = New System.Drawing.Point(230, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(33, 27)
        Me.btnRefresh.TabIndex = 41
        Me.btnRefresh.Text = "⟲"
        Me.ttMain.SetToolTip(Me.btnRefresh, "Refresh List")
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnFullScreen
        '
        Me.btnFullScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFullScreen.BackColor = System.Drawing.Color.Transparent
        Me.btnFullScreen.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.full_Screen_icon
        Me.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFullScreen.FlatAppearance.BorderSize = 0
        Me.btnFullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFullScreen.ForeColor = System.Drawing.Color.Transparent
        Me.btnFullScreen.Location = New System.Drawing.Point(958, 96)
        Me.btnFullScreen.Name = "btnFullScreen"
        Me.btnFullScreen.Size = New System.Drawing.Size(24, 23)
        Me.btnFullScreen.TabIndex = 35
        Me.ttMain.SetToolTip(Me.btnFullScreen, "Full Screen")
        Me.btnFullScreen.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(18, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(321, 32)
        Me.TextBox1.TabIndex = 82
        Me.TextBox1.Text = "🔎 Query MAL Database"
        '
        'spltMain
        '
        Me.spltMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spltMain.Location = New System.Drawing.Point(0, 0)
        Me.spltMain.Name = "spltMain"
        '
        'spltMain.Panel1
        '
        Me.spltMain.Panel1.Controls.Add(Me.btnSearch)
        Me.spltMain.Panel1.Controls.Add(Me.txtSearch)
        Me.spltMain.Panel1.Controls.Add(Me.vscrSearchList)
        Me.spltMain.Panel1.Controls.Add(Me.lstwStatus)
        Me.spltMain.Panel1.Controls.Add(Me.btnRefresh)
        Me.spltMain.Panel1.Controls.Add(Me.lblNoResultFound)
        Me.spltMain.Panel1.Controls.Add(Me.lstwAnimeSearch)
        Me.spltMain.Panel1.Controls.Add(Me.lstAnimes)
        '
        'spltMain.Panel2
        '
        Me.spltMain.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.spltMain.Panel2.Controls.Add(Me.gbxDetailView)
        Me.spltMain.Panel2.Controls.Add(Me.pnlHeader)
        Me.spltMain.Panel2.Controls.Add(Me.lblNoListLoaded)
        Me.spltMain.Panel2.Controls.Add(Me.btnFullScreen)
        Me.spltMain.Panel2.Controls.Add(Me.tsMain)
        Me.spltMain.Panel2.Controls.Add(Me.lblDarkMode)
        Me.spltMain.Panel2.Controls.Add(Me.lblEpisodesHeading)
        Me.spltMain.Panel2.Controls.Add(Me.pcbtnDarkMode)
        Me.spltMain.Panel2.Controls.Add(Me.lblTitle)
        Me.spltMain.Panel2.Controls.Add(Me.pcbUserPicture)
        Me.spltMain.Panel2.Controls.Add(Me.lblAnimeIdHeading)
        Me.spltMain.Panel2.Controls.Add(Me.lblId)
        Me.spltMain.Panel2.Controls.Add(Me.lblTypeHeading)
        Me.spltMain.Panel2.Controls.Add(Me.lblStatus)
        Me.spltMain.Panel2.Controls.Add(Me.pcbLogo)
        Me.spltMain.Panel2.Controls.Add(Me.lblType)
        Me.spltMain.Panel2.Controls.Add(Me.lblStatusHeading)
        Me.spltMain.Panel2.Controls.Add(Me.lblEpisodes)
        Me.spltMain.Panel2.Controls.Add(Me.lblScore)
        Me.spltMain.Panel2.Controls.Add(Me.lblWatchedHeading)
        Me.spltMain.Panel2.Controls.Add(Me.lblScoreHeading)
        Me.spltMain.Panel2.Controls.Add(Me.lblWatched)
        Me.spltMain.Panel2.Controls.Add(Me.lstwAnimeMain)
        Me.spltMain.Panel2.Controls.Add(Me.pcbLoading)
        Me.spltMain.Panel2.Controls.Add(Me.chkViewDetails)
        Me.spltMain.Panel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.spltMain.Size = New System.Drawing.Size(1348, 729)
        Me.spltMain.SplitterDistance = 342
        Me.spltMain.TabIndex = 34
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(264, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 27)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'vscrSearchList
        '
        Me.vscrSearchList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vscrSearchList.LargeChange = 1
        Me.vscrSearchList.Location = New System.Drawing.Point(331, 9)
        Me.vscrSearchList.Maximum = 0
        Me.vscrSearchList.Name = "vscrSearchList"
        Me.vscrSearchList.Size = New System.Drawing.Size(16, 740)
        Me.vscrSearchList.TabIndex = 47
        '
        'lstwStatus
        '
        Me.lstwStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstwStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstwStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstwStatus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colStatus})
        Me.lstwStatus.ContextMenuStrip = Me.ctmAnimeList
        Me.lstwStatus.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstwStatus.FullRowSelect = True
        Me.lstwStatus.HideSelection = False
        Me.lstwStatus.LargeImageList = Me.imgLst
        Me.lstwStatus.Location = New System.Drawing.Point(-2, 3)
        Me.lstwStatus.MultiSelect = False
        Me.lstwStatus.Name = "lstwStatus"
        Me.lstwStatus.Size = New System.Drawing.Size(14, 746)
        Me.lstwStatus.SmallImageList = Me.imgLst
        Me.lstwStatus.TabIndex = 48
        Me.lstwStatus.UseCompatibleStateImageBehavior = False
        Me.lstwStatus.View = System.Windows.Forms.View.Details
        '
        'colStatus
        '
        Me.colStatus.Text = ""
        Me.colStatus.Width = 10
        '
        'ctmAnimeList
        '
        Me.ctmAnimeList.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctmAnimeList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEdit, Me.tsmiListOptions, Me.tsmiDelete, Me.tsmiVisitPage})
        Me.ctmAnimeList.Name = "ctmAnimeList"
        Me.ctmAnimeList.Size = New System.Drawing.Size(180, 108)
        '
        'tsmiEdit
        '
        Me.tsmiEdit.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.edit_icon
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(179, 26)
        Me.tsmiEdit.Text = "&Edit"
        '
        'tsmiListOptions
        '
        Me.tsmiListOptions.Name = "tsmiListOptions"
        Me.tsmiListOptions.Size = New System.Drawing.Size(179, 26)
        Me.tsmiListOptions.Text = "L&ist Options"
        '
        'tsmiDelete
        '
        Me.tsmiDelete.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.delete_icon
        Me.tsmiDelete.Name = "tsmiDelete"
        Me.tsmiDelete.Size = New System.Drawing.Size(179, 26)
        Me.tsmiDelete.Text = "D&elete"
        '
        'tsmiVisitPage
        '
        Me.tsmiVisitPage.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiVisitPage.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.MAL
        Me.tsmiVisitPage.Name = "tsmiVisitPage"
        Me.tsmiVisitPage.Size = New System.Drawing.Size(179, 26)
        Me.tsmiVisitPage.Text = "V&isit MAL Page"
        '
        'imgLst
        '
        Me.imgLst.ImageStream = CType(resources.GetObject("imgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLst.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLst.Images.SetKeyName(0, "green_watching2.png")
        Me.imgLst.Images.SetKeyName(1, "blue_completed2.png")
        Me.imgLst.Images.SetKeyName(2, "red_dropped2.png")
        Me.imgLst.Images.SetKeyName(3, "yellow_onhold2.png")
        Me.imgLst.Images.SetKeyName(4, "grey_plantowatch.png")
        '
        'lblNoResultFound
        '
        Me.lblNoResultFound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblNoResultFound.AutoSize = True
        Me.lblNoResultFound.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoResultFound.ForeColor = System.Drawing.Color.Gray
        Me.lblNoResultFound.Location = New System.Drawing.Point(89, 326)
        Me.lblNoResultFound.Name = "lblNoResultFound"
        Me.lblNoResultFound.Size = New System.Drawing.Size(210, 37)
        Me.lblNoResultFound.TabIndex = 41
        Me.lblNoResultFound.Text = "No Result Found"
        Me.lblNoResultFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoResultFound.Visible = False
        '
        'lstwAnimeSearch
        '
        Me.lstwAnimeSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstwAnimeSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstwAnimeSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstwAnimeSearch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.srlstName, Me.srlstID})
        Me.lstwAnimeSearch.ContextMenuStrip = Me.ctmAnimeList
        Me.lstwAnimeSearch.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstwAnimeSearch.FullRowSelect = True
        Me.lstwAnimeSearch.HideSelection = False
        Me.lstwAnimeSearch.LargeImageList = Me.imgLst
        Me.lstwAnimeSearch.Location = New System.Drawing.Point(10, 2)
        Me.lstwAnimeSearch.MultiSelect = False
        Me.lstwAnimeSearch.Name = "lstwAnimeSearch"
        Me.lstwAnimeSearch.OwnerDraw = True
        Me.lstwAnimeSearch.Size = New System.Drawing.Size(428, 746)
        Me.lstwAnimeSearch.SmallImageList = Me.imgLst
        Me.lstwAnimeSearch.TabIndex = 47
        Me.lstwAnimeSearch.UseCompatibleStateImageBehavior = False
        Me.lstwAnimeSearch.View = System.Windows.Forms.View.Details
        '
        'srlstName
        '
        Me.srlstName.Text = "Title"
        Me.srlstName.Width = 700
        '
        'srlstID
        '
        Me.srlstID.Width = 100
        '
        'gbxDetailView
        '
        Me.gbxDetailView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetailView.Controls.Add(Me.btnMALQuery)
        Me.gbxDetailView.Controls.Add(Me.TextBox1)
        Me.gbxDetailView.Controls.Add(Me.Label1)
        Me.gbxDetailView.Controls.Add(Me.mtsLoading)
        Me.gbxDetailView.Controls.Add(Me.lblNoConnection)
        Me.gbxDetailView.Controls.Add(Me.lblCommunityHeading)
        Me.gbxDetailView.Controls.Add(Me.lblFavorites)
        Me.gbxDetailView.Controls.Add(Me.lblFavoritesHeading)
        Me.gbxDetailView.Controls.Add(Me.lblMembers)
        Me.gbxDetailView.Controls.Add(Me.lblMembersHeading)
        Me.gbxDetailView.Controls.Add(Me.lblRank)
        Me.gbxDetailView.Controls.Add(Me.lblRankHeading)
        Me.gbxDetailView.Controls.Add(Me.lblPopularity)
        Me.gbxDetailView.Controls.Add(Me.lblPopularityHeading)
        Me.gbxDetailView.Controls.Add(Me.lblBrodcast)
        Me.gbxDetailView.Controls.Add(Me.lblBrodcastHeading)
        Me.gbxDetailView.Controls.Add(Me.lblDuration)
        Me.gbxDetailView.Controls.Add(Me.lblDurationHeading)
        Me.gbxDetailView.Controls.Add(Me.lblMALStatus)
        Me.gbxDetailView.Controls.Add(Me.lblMALStatusHeading)
        Me.gbxDetailView.Controls.Add(Me.lblMALRating)
        Me.gbxDetailView.Controls.Add(Me.lblPremiered)
        Me.gbxDetailView.Controls.Add(Me.lblMALScore)
        Me.gbxDetailView.Controls.Add(Me.lblPremieredHeading)
        Me.gbxDetailView.Controls.Add(Me.lblMALRatingHeading)
        Me.gbxDetailView.Controls.Add(Me.lblMALScoreHeading)
        Me.gbxDetailView.Controls.Add(Me.rctSynopsis)
        Me.gbxDetailView.Controls.Add(Me.pcbAnimeCover)
        Me.gbxDetailView.Location = New System.Drawing.Point(18, 146)
        Me.gbxDetailView.Name = "gbxDetailView"
        Me.gbxDetailView.Size = New System.Drawing.Size(964, 580)
        Me.gbxDetailView.TabIndex = 106
        Me.gbxDetailView.TabStop = False
        Me.gbxDetailView.Visible = False
        '
        'btnMALQuery
        '
        Me.btnMALQuery.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnMALQuery.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnMALQuery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnMALQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnMALQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMALQuery.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMALQuery.ForeColor = System.Drawing.Color.Black
        Me.btnMALQuery.Location = New System.Drawing.Point(340, 21)
        Me.btnMALQuery.Name = "btnMALQuery"
        Me.btnMALQuery.Size = New System.Drawing.Size(75, 27)
        Me.btnMALQuery.TabIndex = 83
        Me.btnMALQuery.Text = "Search"
        Me.btnMALQuery.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(6, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 28)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Anime information scraped from MyAnimeList.net"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mtsLoading
        '
        Me.mtsLoading.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mtsLoading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtsLoading.CustomBackground = True
        Me.mtsLoading.Location = New System.Drawing.Point(466, 269)
        Me.mtsLoading.Maximum = 100
        Me.mtsLoading.Name = "mtsLoading"
        Me.mtsLoading.Size = New System.Drawing.Size(47, 50)
        Me.mtsLoading.Speed = 2.0!
        Me.mtsLoading.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtsLoading.TabIndex = 79
        Me.mtsLoading.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtsLoading.UseCustomBackColor = True
        Me.mtsLoading.UseSelectable = True
        Me.mtsLoading.UseStyleColors = True
        Me.mtsLoading.Value = 25
        Me.mtsLoading.Visible = False
        '
        'lblNoConnection
        '
        Me.lblNoConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblNoConnection.AutoSize = True
        Me.lblNoConnection.BackColor = System.Drawing.Color.Transparent
        Me.lblNoConnection.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoConnection.ForeColor = System.Drawing.Color.Gray
        Me.lblNoConnection.Location = New System.Drawing.Point(230, 370)
        Me.lblNoConnection.Name = "lblNoConnection"
        Me.lblNoConnection.Size = New System.Drawing.Size(663, 74)
        Me.lblNoConnection.TabIndex = 78
        Me.lblNoConnection.Text = "No connection!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please connect to the internet to access online features!"
        Me.lblNoConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoConnection.Visible = False
        '
        'lblCommunityHeading
        '
        Me.lblCommunityHeading.AutoSize = True
        Me.lblCommunityHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblCommunityHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommunityHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCommunityHeading.Location = New System.Drawing.Point(583, 75)
        Me.lblCommunityHeading.Name = "lblCommunityHeading"
        Me.lblCommunityHeading.Size = New System.Drawing.Size(185, 28)
        Me.lblCommunityHeading.TabIndex = 77
        Me.lblCommunityHeading.Text = "Community Statistics"
        '
        'lblFavorites
        '
        Me.lblFavorites.AutoSize = True
        Me.lblFavorites.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavorites.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFavorites.Location = New System.Drawing.Point(688, 226)
        Me.lblFavorites.Name = "lblFavorites"
        Me.lblFavorites.Size = New System.Drawing.Size(60, 28)
        Me.lblFavorites.TabIndex = 76
        Me.lblFavorites.Text = "####"
        '
        'lblFavoritesHeading
        '
        Me.lblFavoritesHeading.AutoSize = True
        Me.lblFavoritesHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavoritesHeading.ForeColor = System.Drawing.Color.Black
        Me.lblFavoritesHeading.Location = New System.Drawing.Point(583, 226)
        Me.lblFavoritesHeading.Name = "lblFavoritesHeading"
        Me.lblFavoritesHeading.Size = New System.Drawing.Size(92, 28)
        Me.lblFavoritesHeading.TabIndex = 75
        Me.lblFavoritesHeading.Text = "Favorites"
        '
        'lblMembers
        '
        Me.lblMembers.AutoSize = True
        Me.lblMembers.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMembers.Location = New System.Drawing.Point(688, 189)
        Me.lblMembers.Name = "lblMembers"
        Me.lblMembers.Size = New System.Drawing.Size(60, 28)
        Me.lblMembers.TabIndex = 74
        Me.lblMembers.Text = "####"
        '
        'lblMembersHeading
        '
        Me.lblMembersHeading.AutoSize = True
        Me.lblMembersHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembersHeading.ForeColor = System.Drawing.Color.Black
        Me.lblMembersHeading.Location = New System.Drawing.Point(583, 189)
        Me.lblMembersHeading.Name = "lblMembersHeading"
        Me.lblMembersHeading.Size = New System.Drawing.Size(98, 28)
        Me.lblMembersHeading.TabIndex = 73
        Me.lblMembersHeading.Text = "Members"
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRank.Location = New System.Drawing.Point(688, 152)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(60, 28)
        Me.lblRank.TabIndex = 72
        Me.lblRank.Text = "####"
        '
        'lblRankHeading
        '
        Me.lblRankHeading.AutoSize = True
        Me.lblRankHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRankHeading.ForeColor = System.Drawing.Color.Black
        Me.lblRankHeading.Location = New System.Drawing.Point(583, 152)
        Me.lblRankHeading.Name = "lblRankHeading"
        Me.lblRankHeading.Size = New System.Drawing.Size(80, 28)
        Me.lblRankHeading.TabIndex = 71
        Me.lblRankHeading.Text = "Ranked"
        '
        'lblPopularity
        '
        Me.lblPopularity.AutoSize = True
        Me.lblPopularity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPopularity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPopularity.Location = New System.Drawing.Point(688, 115)
        Me.lblPopularity.Name = "lblPopularity"
        Me.lblPopularity.Size = New System.Drawing.Size(60, 28)
        Me.lblPopularity.TabIndex = 70
        Me.lblPopularity.Text = "####"
        '
        'lblPopularityHeading
        '
        Me.lblPopularityHeading.AutoSize = True
        Me.lblPopularityHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPopularityHeading.ForeColor = System.Drawing.Color.Black
        Me.lblPopularityHeading.Location = New System.Drawing.Point(583, 115)
        Me.lblPopularityHeading.Name = "lblPopularityHeading"
        Me.lblPopularityHeading.Size = New System.Drawing.Size(103, 28)
        Me.lblPopularityHeading.TabIndex = 69
        Me.lblPopularityHeading.Text = "Popularity"
        '
        'lblBrodcast
        '
        Me.lblBrodcast.AutoSize = True
        Me.lblBrodcast.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrodcast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBrodcast.Location = New System.Drawing.Point(342, 244)
        Me.lblBrodcast.Name = "lblBrodcast"
        Me.lblBrodcast.Size = New System.Drawing.Size(60, 28)
        Me.lblBrodcast.TabIndex = 68
        Me.lblBrodcast.Text = "####"
        '
        'lblBrodcastHeading
        '
        Me.lblBrodcastHeading.AutoSize = True
        Me.lblBrodcastHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrodcastHeading.ForeColor = System.Drawing.Color.Black
        Me.lblBrodcastHeading.Location = New System.Drawing.Point(242, 242)
        Me.lblBrodcastHeading.Name = "lblBrodcastHeading"
        Me.lblBrodcastHeading.Size = New System.Drawing.Size(90, 28)
        Me.lblBrodcastHeading.TabIndex = 67
        Me.lblBrodcastHeading.Text = "Brodcast"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDuration.Location = New System.Drawing.Point(343, 283)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(60, 28)
        Me.lblDuration.TabIndex = 66
        Me.lblDuration.Text = "####"
        '
        'lblDurationHeading
        '
        Me.lblDurationHeading.AutoSize = True
        Me.lblDurationHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurationHeading.ForeColor = System.Drawing.Color.Black
        Me.lblDurationHeading.Location = New System.Drawing.Point(242, 283)
        Me.lblDurationHeading.Name = "lblDurationHeading"
        Me.lblDurationHeading.Size = New System.Drawing.Size(91, 28)
        Me.lblDurationHeading.TabIndex = 65
        Me.lblDurationHeading.Text = "Duration"
        '
        'lblMALStatus
        '
        Me.lblMALStatus.AutoSize = True
        Me.lblMALStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMALStatus.Location = New System.Drawing.Point(343, 199)
        Me.lblMALStatus.Name = "lblMALStatus"
        Me.lblMALStatus.Size = New System.Drawing.Size(60, 28)
        Me.lblMALStatus.TabIndex = 64
        Me.lblMALStatus.Text = "####"
        '
        'lblMALStatusHeading
        '
        Me.lblMALStatusHeading.AutoSize = True
        Me.lblMALStatusHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALStatusHeading.ForeColor = System.Drawing.Color.Black
        Me.lblMALStatusHeading.Location = New System.Drawing.Point(242, 199)
        Me.lblMALStatusHeading.Name = "lblMALStatusHeading"
        Me.lblMALStatusHeading.Size = New System.Drawing.Size(114, 28)
        Me.lblMALStatusHeading.TabIndex = 61
        Me.lblMALStatusHeading.Text = "MAL Status"
        '
        'lblMALRating
        '
        Me.lblMALRating.AutoSize = True
        Me.lblMALRating.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMALRating.Location = New System.Drawing.Point(343, 115)
        Me.lblMALRating.Name = "lblMALRating"
        Me.lblMALRating.Size = New System.Drawing.Size(60, 28)
        Me.lblMALRating.TabIndex = 60
        Me.lblMALRating.Text = "####"
        '
        'lblPremiered
        '
        Me.lblPremiered.AutoSize = True
        Me.lblPremiered.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPremiered.Location = New System.Drawing.Point(343, 157)
        Me.lblPremiered.Name = "lblPremiered"
        Me.lblPremiered.Size = New System.Drawing.Size(60, 28)
        Me.lblPremiered.TabIndex = 59
        Me.lblPremiered.Text = "####"
        '
        'lblMALScore
        '
        Me.lblMALScore.AutoSize = True
        Me.lblMALScore.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMALScore.Location = New System.Drawing.Point(343, 73)
        Me.lblMALScore.Name = "lblMALScore"
        Me.lblMALScore.Size = New System.Drawing.Size(60, 28)
        Me.lblMALScore.TabIndex = 58
        Me.lblMALScore.Text = "####"
        '
        'lblPremieredHeading
        '
        Me.lblPremieredHeading.AutoSize = True
        Me.lblPremieredHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremieredHeading.ForeColor = System.Drawing.Color.Black
        Me.lblPremieredHeading.Location = New System.Drawing.Point(242, 157)
        Me.lblPremieredHeading.Name = "lblPremieredHeading"
        Me.lblPremieredHeading.Size = New System.Drawing.Size(106, 28)
        Me.lblPremieredHeading.TabIndex = 57
        Me.lblPremieredHeading.Text = "Premiered"
        '
        'lblMALRatingHeading
        '
        Me.lblMALRatingHeading.AutoSize = True
        Me.lblMALRatingHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALRatingHeading.ForeColor = System.Drawing.Color.Black
        Me.lblMALRatingHeading.Location = New System.Drawing.Point(242, 115)
        Me.lblMALRatingHeading.Name = "lblMALRatingHeading"
        Me.lblMALRatingHeading.Size = New System.Drawing.Size(117, 28)
        Me.lblMALRatingHeading.TabIndex = 56
        Me.lblMALRatingHeading.Text = "MAL Rating"
        '
        'lblMALScoreHeading
        '
        Me.lblMALScoreHeading.AutoSize = True
        Me.lblMALScoreHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALScoreHeading.ForeColor = System.Drawing.Color.Black
        Me.lblMALScoreHeading.Location = New System.Drawing.Point(242, 73)
        Me.lblMALScoreHeading.Name = "lblMALScoreHeading"
        Me.lblMALScoreHeading.Size = New System.Drawing.Size(109, 28)
        Me.lblMALScoreHeading.TabIndex = 55
        Me.lblMALScoreHeading.Text = "MAL Score"
        '
        'rctSynopsis
        '
        Me.rctSynopsis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rctSynopsis.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rctSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rctSynopsis.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rctSynopsis.Location = New System.Drawing.Point(16, 327)
        Me.rctSynopsis.Name = "rctSynopsis"
        Me.rctSynopsis.ReadOnly = True
        Me.rctSynopsis.Size = New System.Drawing.Size(925, 142)
        Me.rctSynopsis.TabIndex = 54
        Me.rctSynopsis.Text = ""
        '
        'pcbAnimeCover
        '
        Me.pcbAnimeCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbAnimeCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbAnimeCover.Location = New System.Drawing.Point(16, 68)
        Me.pcbAnimeCover.Name = "pcbAnimeCover"
        Me.pcbAnimeCover.Size = New System.Drawing.Size(211, 243)
        Me.pcbAnimeCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbAnimeCover.TabIndex = 53
        Me.pcbAnimeCover.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHeader.Controls.Add(Me.btnAboutHeader)
        Me.pnlHeader.Controls.Add(Me.btnInfoSettingsHeader)
        Me.pnlHeader.Controls.Add(Me.btnDeleteHeader)
        Me.pnlHeader.Controls.Add(Me.btnEditHeader)
        Me.pnlHeader.Controls.Add(Me.btnNewAnimeHeader)
        Me.pnlHeader.Controls.Add(Me.btnSortHeader)
        Me.pnlHeader.Controls.Add(Me.btnViewXmlHeader)
        Me.pnlHeader.Controls.Add(Me.btnExportHeader)
        Me.pnlHeader.Controls.Add(Me.btnOpenHeader)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1002, 32)
        Me.pnlHeader.TabIndex = 105
        '
        'btnAboutHeader
        '
        Me.btnAboutHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAboutHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnAboutHeader.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnAboutHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnAboutHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnAboutHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutHeader.ForeColor = System.Drawing.Color.White
        Me.btnAboutHeader.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Chibi3
        Me.btnAboutHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAboutHeader.Location = New System.Drawing.Point(916, 0)
        Me.btnAboutHeader.Name = "btnAboutHeader"
        Me.btnAboutHeader.Size = New System.Drawing.Size(90, 33)
        Me.btnAboutHeader.TabIndex = 49
        Me.btnAboutHeader.Text = "&About"
        Me.btnAboutHeader.UseVisualStyleBackColor = False
        '
        'btnInfoSettingsHeader
        '
        Me.btnInfoSettingsHeader.AutoSize = True
        Me.btnInfoSettingsHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnInfoSettingsHeader.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid
        Me.btnInfoSettingsHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnInfoSettingsHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnInfoSettingsHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfoSettingsHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfoSettingsHeader.ForeColor = System.Drawing.Color.White
        Me.btnInfoSettingsHeader.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_ico_blk
        Me.btnInfoSettingsHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInfoSettingsHeader.Location = New System.Drawing.Point(752, -2)
        Me.btnInfoSettingsHeader.Name = "btnInfoSettingsHeader"
        Me.btnInfoSettingsHeader.Size = New System.Drawing.Size(100, 35)
        Me.btnInfoSettingsHeader.TabIndex = 48
        Me.btnInfoSettingsHeader.Text = "    &Settings"
        Me.btnInfoSettingsHeader.UseVisualStyleBackColor = False
        '
        'btnDeleteHeader
        '
        Me.btnDeleteHeader.AutoSize = True
        Me.btnDeleteHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteHeader.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid
        Me.btnDeleteHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnDeleteHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnDeleteHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteHeader.ForeColor = System.Drawing.Color.White
        Me.btnDeleteHeader.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.delete_ico_blk
        Me.btnDeleteHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteHeader.Location = New System.Drawing.Point(661, -2)
        Me.btnDeleteHeader.Name = "btnDeleteHeader"
        Me.btnDeleteHeader.Size = New System.Drawing.Size(90, 35)
        Me.btnDeleteHeader.TabIndex = 47
        Me.btnDeleteHeader.Text = "    &Delete"
        Me.btnDeleteHeader.UseVisualStyleBackColor = False
        '
        'btnEditHeader
        '
        Me.btnEditHeader.AutoSize = True
        Me.btnEditHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnEditHeader.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid
        Me.btnEditHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnEditHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnEditHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditHeader.ForeColor = System.Drawing.Color.White
        Me.btnEditHeader.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.edit_ico_blk
        Me.btnEditHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditHeader.Location = New System.Drawing.Point(543, -2)
        Me.btnEditHeader.Name = "btnEditHeader"
        Me.btnEditHeader.Size = New System.Drawing.Size(122, 35)
        Me.btnEditHeader.TabIndex = 46
        Me.btnEditHeader.Text = "    &Edit Anime"
        Me.btnEditHeader.UseVisualStyleBackColor = False
        '
        'btnNewAnimeHeader
        '
        Me.btnNewAnimeHeader.AutoSize = True
        Me.btnNewAnimeHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnNewAnimeHeader.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid
        Me.btnNewAnimeHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnNewAnimeHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnNewAnimeHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewAnimeHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewAnimeHeader.ForeColor = System.Drawing.Color.White
        Me.btnNewAnimeHeader.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.new_ico_blk
        Me.btnNewAnimeHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewAnimeHeader.Location = New System.Drawing.Point(415, -2)
        Me.btnNewAnimeHeader.Name = "btnNewAnimeHeader"
        Me.btnNewAnimeHeader.Size = New System.Drawing.Size(127, 35)
        Me.btnNewAnimeHeader.TabIndex = 45
        Me.btnNewAnimeHeader.Text = "    &New Anime"
        Me.btnNewAnimeHeader.UseVisualStyleBackColor = False
        '
        'btnSortHeader
        '
        Me.btnSortHeader.AutoSize = True
        Me.btnSortHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnSortHeader.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid
        Me.btnSortHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnSortHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnSortHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortHeader.ForeColor = System.Drawing.Color.White
        Me.btnSortHeader.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.sort_ico_blk
        Me.btnSortHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSortHeader.Location = New System.Drawing.Point(318, -2)
        Me.btnSortHeader.Name = "btnSortHeader"
        Me.btnSortHeader.Size = New System.Drawing.Size(95, 35)
        Me.btnSortHeader.TabIndex = 44
        Me.btnSortHeader.Text = "    &Sotr by"
        Me.btnSortHeader.UseVisualStyleBackColor = False
        '
        'btnViewXmlHeader
        '
        Me.btnViewXmlHeader.AutoSize = True
        Me.btnViewXmlHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnViewXmlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnViewXmlHeader.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid
        Me.btnViewXmlHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnViewXmlHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnViewXmlHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewXmlHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewXmlHeader.ForeColor = System.Drawing.Color.White
        Me.btnViewXmlHeader.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.xml_ico_blk
        Me.btnViewXmlHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewXmlHeader.Location = New System.Drawing.Point(206, -2)
        Me.btnViewXmlHeader.Name = "btnViewXmlHeader"
        Me.btnViewXmlHeader.Size = New System.Drawing.Size(110, 35)
        Me.btnViewXmlHeader.TabIndex = 43
        Me.btnViewXmlHeader.Text = "    &View Xml"
        Me.btnViewXmlHeader.UseVisualStyleBackColor = False
        '
        'btnExportHeader
        '
        Me.btnExportHeader.AutoSize = True
        Me.btnExportHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnExportHeader.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid
        Me.btnExportHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnExportHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnExportHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportHeader.ForeColor = System.Drawing.Color.White
        Me.btnExportHeader.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.export_ico_blk
        Me.btnExportHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportHeader.Location = New System.Drawing.Point(87, -2)
        Me.btnExportHeader.Name = "btnExportHeader"
        Me.btnExportHeader.Size = New System.Drawing.Size(118, 35)
        Me.btnExportHeader.TabIndex = 42
        Me.btnExportHeader.Text = "    &Export List"
        Me.btnExportHeader.UseVisualStyleBackColor = False
        '
        'btnOpenHeader
        '
        Me.btnOpenHeader.AutoSize = True
        Me.btnOpenHeader.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenHeader.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid
        Me.btnOpenHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnOpenHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnOpenHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenHeader.ForeColor = System.Drawing.Color.White
        Me.btnOpenHeader.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.open_ico_blk
        Me.btnOpenHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpenHeader.Location = New System.Drawing.Point(3, -2)
        Me.btnOpenHeader.Name = "btnOpenHeader"
        Me.btnOpenHeader.Size = New System.Drawing.Size(83, 35)
        Me.btnOpenHeader.TabIndex = 41
        Me.btnOpenHeader.Text = "    &Open"
        Me.btnOpenHeader.UseVisualStyleBackColor = False
        '
        'lblNoListLoaded
        '
        Me.lblNoListLoaded.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNoListLoaded.AutoSize = True
        Me.lblNoListLoaded.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoListLoaded.ForeColor = System.Drawing.Color.Gray
        Me.lblNoListLoaded.Location = New System.Drawing.Point(418, 264)
        Me.lblNoListLoaded.Name = "lblNoListLoaded"
        Me.lblNoListLoaded.Size = New System.Drawing.Size(211, 41)
        Me.lblNoListLoaded.TabIndex = 42
        Me.lblNoListLoaded.Text = "No List Loaded"
        Me.lblNoListLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoListLoaded.Visible = False
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.BackColor = System.Drawing.Color.Black
        Me.tsMain.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.tsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.btnSave, Me.btnXml, Me.btnAbout, Me.tsbtnSort, Me.tsbtnNewAnime, Me.tsbtnEdit, Me.tsbtnDelete, Me.btnUserInfo})
        Me.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1002, 27)
        Me.tsMain.TabIndex = 1
        Me.tsMain.Text = "ToolStrip1"
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOpen.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.OpenFile_16x
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(70, 24)
        Me.btnOpen.Text = "&Open"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.SaveAs_16x
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 24)
        Me.btnSave.Text = "&Export List"
        '
        'btnXml
        '
        Me.btnXml.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXml.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.xml_ico
        Me.btnXml.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXml.Name = "btnXml"
        Me.btnXml.Size = New System.Drawing.Size(96, 24)
        Me.btnXml.Text = "&View Xml"
        '
        'btnAbout
        '
        Me.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAbout.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Love
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 24)
        Me.btnAbout.Text = "&About"
        '
        'tsbtnSort
        '
        Me.tsbtnSort.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnSort.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.filter2
        Me.tsbtnSort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSort.Name = "tsbtnSort"
        Me.tsbtnSort.Size = New System.Drawing.Size(82, 24)
        Me.tsbtnSort.Text = "Sort by"
        '
        'tsbtnNewAnime
        '
        Me.tsbtnNewAnime.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.new_icon
        Me.tsbtnNewAnime.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewAnime.Name = "tsbtnNewAnime"
        Me.tsbtnNewAnime.Size = New System.Drawing.Size(110, 24)
        Me.tsbtnNewAnime.Text = "&New Anime"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.edit_icon
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(106, 24)
        Me.tsbtnEdit.Text = "&Edit Anime"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.delete_icon
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(77, 24)
        Me.tsbtnDelete.Text = "&Delete"
        '
        'btnUserInfo
        '
        Me.btnUserInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUserInfo.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.btnUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserInfo.Name = "btnUserInfo"
        Me.btnUserInfo.Size = New System.Drawing.Size(87, 24)
        Me.btnUserInfo.Text = "&Settings"
        '
        'pcbtnDarkMode
        '
        Me.pcbtnDarkMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbtnDarkMode.BackColor = System.Drawing.Color.Transparent
        Me.pcbtnDarkMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbtnDarkMode.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Switch_OffP
        Me.pcbtnDarkMode.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Switch_OffP
        Me.pcbtnDarkMode.Location = New System.Drawing.Point(871, 95)
        Me.pcbtnDarkMode.Name = "pcbtnDarkMode"
        Me.pcbtnDarkMode.Size = New System.Drawing.Size(63, 25)
        Me.pcbtnDarkMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbtnDarkMode.TabIndex = 29
        Me.pcbtnDarkMode.TabStop = False
        '
        'pcbUserPicture
        '
        Me.pcbUserPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbUserPicture.BackColor = System.Drawing.Color.Transparent
        Me.pcbUserPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbUserPicture.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.pcbUserPicture.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.pcbUserPicture.Location = New System.Drawing.Point(946, 35)
        Me.pcbUserPicture.Name = "pcbUserPicture"
        Me.pcbUserPicture.Size = New System.Drawing.Size(44, 57)
        Me.pcbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbUserPicture.TabIndex = 26
        Me.pcbUserPicture.TabStop = False
        '
        'pcbLogo
        '
        Me.pcbLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pcbLogo.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.maa_logo_purple
        Me.pcbLogo.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.MAL2
        Me.pcbLogo.Location = New System.Drawing.Point(793, 28)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(151, 72)
        Me.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbLogo.TabIndex = 21
        Me.pcbLogo.TabStop = False
        '
        'lstwAnimeMain
        '
        Me.lstwAnimeMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstwAnimeMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstwAnimeMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstwAnimeMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.animeId4, Me.animeTitle4, Me.animeType4, Me.animeStatus4, Me.animeEpisodes4, Me.animeWatched4, Me.animeScore4, Me.animeStart4, Me.animeFinish4, Me.animeTags4, Me.myId4, Me.animeComments4, Me.animeRewatch4})
        Me.lstwAnimeMain.ContextMenuStrip = Me.ctmAnimeList
        Me.lstwAnimeMain.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstwAnimeMain.FullRowSelect = True
        Me.lstwAnimeMain.HideSelection = False
        Me.lstwAnimeMain.Location = New System.Drawing.Point(18, 146)
        Me.lstwAnimeMain.Name = "lstwAnimeMain"
        Me.lstwAnimeMain.OwnerDraw = True
        Me.lstwAnimeMain.Size = New System.Drawing.Size(964, 580)
        Me.lstwAnimeMain.TabIndex = 36
        Me.lstwAnimeMain.UseCompatibleStateImageBehavior = False
        Me.lstwAnimeMain.View = System.Windows.Forms.View.Details
        '
        'animeId4
        '
        Me.animeId4.Text = ""
        Me.animeId4.Width = 0
        '
        'animeTitle4
        '
        Me.animeTitle4.Text = "Title"
        Me.animeTitle4.Width = 290
        '
        'animeType4
        '
        Me.animeType4.Text = "Type"
        Me.animeType4.Width = 140
        '
        'animeStatus4
        '
        Me.animeStatus4.Text = "Status"
        Me.animeStatus4.Width = 140
        '
        'animeEpisodes4
        '
        Me.animeEpisodes4.Text = "Episodes"
        Me.animeEpisodes4.Width = 130
        '
        'animeWatched4
        '
        Me.animeWatched4.Text = "Watched"
        Me.animeWatched4.Width = 130
        '
        'animeScore4
        '
        Me.animeScore4.Text = "Score"
        Me.animeScore4.Width = 115
        '
        'animeStart4
        '
        Me.animeStart4.Text = "Start Date"
        Me.animeStart4.Width = 150
        '
        'animeFinish4
        '
        Me.animeFinish4.Text = "Finish Date"
        Me.animeFinish4.Width = 150
        '
        'animeTags4
        '
        Me.animeTags4.Text = "Tags"
        Me.animeTags4.Width = 180
        '
        'myId4
        '
        Me.myId4.Text = "My ID"
        Me.myId4.Width = 100
        '
        'animeComments4
        '
        Me.animeComments4.Text = "Comments"
        Me.animeComments4.Width = 300
        '
        'animeRewatch4
        '
        Me.animeRewatch4.Text = "Rewatch"
        Me.animeRewatch4.Width = 80
        '
        'pcbLoading
        '
        Me.pcbLoading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbLoading.Location = New System.Drawing.Point(18, 141)
        Me.pcbLoading.Maximum = 7
        Me.pcbLoading.Name = "pcbLoading"
        Me.pcbLoading.Size = New System.Drawing.Size(964, 8)
        Me.pcbLoading.Step = 1
        Me.pcbLoading.Style = MetroFramework.MetroColorStyle.Purple
        Me.pcbLoading.TabIndex = 104
        Me.pcbLoading.Value = 7
        Me.pcbLoading.Visible = False
        '
        'chkViewDetails
        '
        Me.chkViewDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkViewDetails.AutoSize = True
        Me.chkViewDetails.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewDetails.ForeColor = System.Drawing.Color.Black
        Me.chkViewDetails.Location = New System.Drawing.Point(778, 124)
        Me.chkViewDetails.Name = "chkViewDetails"
        Me.chkViewDetails.Size = New System.Drawing.Size(153, 24)
        Me.chkViewDetails.TabIndex = 107
        Me.chkViewDetails.Text = "View Online Details"
        Me.chkViewDetails.UseVisualStyleBackColor = True
        '
        'timerMain
        '
        Me.timerMain.Interval = 1000
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.Black
        Me.lblCopyright.Location = New System.Drawing.Point(573, 734)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(282, 20)
        Me.lblCopyright.TabIndex = 35
        Me.lblCopyright.Text = "Programmed by Cesar Mendoza @aberuwu"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCopyright.Visible = False
        '
        'backWork
        '
        Me.backWork.WorkerReportsProgress = True
        Me.backWork.WorkerSupportsCancellation = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 754)
        Me.Controls.Add(Me.spltMain)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.ssMain)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1092, 575)
        Me.Name = "frmMain"
        Me.Text = "My Anime Archive - Personal Anime Archive [ALPHA BUILD v1.1]"
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.spltMain.Panel1.ResumeLayout(False)
        Me.spltMain.Panel1.PerformLayout()
        Me.spltMain.Panel2.ResumeLayout(False)
        Me.spltMain.Panel2.PerformLayout()
        CType(Me.spltMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltMain.ResumeLayout(False)
        Me.ctmAnimeList.ResumeLayout(False)
        Me.gbxDetailView.ResumeLayout(False)
        Me.gbxDetailView.PerformLayout()
        CType(Me.pcbAnimeCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.pcbtnDarkMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbUserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAnimes As ListBox
    Friend WithEvents tsMain As ToolStrip
    Friend WithEvents btnOpen As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnAbout As ToolStripButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblAnimeIdHeading As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblTypeHeading As Label
    Friend WithEvents lblEpisodes As Label
    Friend WithEvents lblEpisodesHeading As Label
    Friend WithEvents lblWatched As Label
    Friend WithEvents lblWatchedHeading As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblScoreHeading As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblStatusHeading As Label
    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents tspb1 As ToolStripProgressBar
    Friend WithEvents tsFileLable As ToolStripStatusLabel
    Friend WithEvents btnUserInfo As ToolStripButton
    Friend WithEvents pcbUserPicture As PictureBox
    Friend WithEvents lblDarkMode As Label
    Friend WithEvents pcbtnDarkMode As PictureBox
    Friend WithEvents btnXml As ToolStripButton
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents spltMain As SplitContainer
    Friend WithEvents timerMain As Timer
    Friend WithEvents lblCopyright As Label
    Friend WithEvents tsbtnSort As ToolStripButton
    Friend WithEvents btnFullScreen As Button
    Friend WithEvents lstwAnimeMain As ListView
    Friend WithEvents animeId4 As ColumnHeader
    Friend WithEvents animeTitle4 As ColumnHeader
    Friend WithEvents animeType4 As ColumnHeader
    Friend WithEvents animeEpisodes4 As ColumnHeader
    Friend WithEvents animeWatched4 As ColumnHeader
    Friend WithEvents animeStart4 As ColumnHeader
    Friend WithEvents animeFinish4 As ColumnHeader
    Friend WithEvents myId4 As ColumnHeader
    Friend WithEvents animeComments4 As ColumnHeader
    Friend WithEvents animeStatus4 As ColumnHeader
    Friend WithEvents animeTags4 As ColumnHeader
    Friend WithEvents animeRewatch4 As ColumnHeader
    Friend WithEvents animeScore4 As ColumnHeader
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblNoResultFound As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblNoListLoaded As Label
    Friend WithEvents tsbtnNewAnime As ToolStripButton
    Friend WithEvents tsbtnEdit As ToolStripButton
    Friend WithEvents tsbtnDelete As ToolStripButton
    Friend WithEvents ctmAnimeList As ContextMenuStrip
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents tsmiVisitPage As ToolStripMenuItem
    Friend WithEvents backWork As System.ComponentModel.BackgroundWorker
    Friend WithEvents lstwAnimeSearch As ListView
    Friend WithEvents srlstName As ColumnHeader
    Friend WithEvents imgLst As ImageList
    Friend WithEvents lstwStatus As ListView
    Friend WithEvents colStatus As ColumnHeader
    Friend WithEvents vscrSearchList As VScrollBar
    Friend WithEvents srlstID As ColumnHeader
    Friend WithEvents tsmiListOptions As ToolStripMenuItem
    Friend WithEvents pcbLoading As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnOpenHeader As Button
    Friend WithEvents btnAboutHeader As Button
    Friend WithEvents btnInfoSettingsHeader As Button
    Friend WithEvents btnDeleteHeader As Button
    Friend WithEvents btnEditHeader As Button
    Friend WithEvents btnNewAnimeHeader As Button
    Friend WithEvents btnSortHeader As Button
    Friend WithEvents btnViewXmlHeader As Button
    Friend WithEvents btnExportHeader As Button
    Friend WithEvents gbxDetailView As GroupBox
    Friend WithEvents chkViewDetails As CheckBox
    Friend WithEvents lblMALRating As Label
    Friend WithEvents lblPremiered As Label
    Friend WithEvents lblMALScore As Label
    Friend WithEvents lblPremieredHeading As Label
    Friend WithEvents lblMALRatingHeading As Label
    Friend WithEvents lblMALScoreHeading As Label
    Friend WithEvents rctSynopsis As RichTextBox
    Friend WithEvents pcbAnimeCover As PictureBox
    Friend WithEvents lblMALStatus As Label
    Friend WithEvents lblMALStatusHeading As Label
    Friend WithEvents lblFavorites As Label
    Friend WithEvents lblFavoritesHeading As Label
    Friend WithEvents lblMembers As Label
    Friend WithEvents lblMembersHeading As Label
    Friend WithEvents lblRank As Label
    Friend WithEvents lblRankHeading As Label
    Friend WithEvents lblPopularity As Label
    Friend WithEvents lblPopularityHeading As Label
    Friend WithEvents lblBrodcast As Label
    Friend WithEvents lblBrodcastHeading As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblDurationHeading As Label
    Friend WithEvents lblCommunityHeading As Label
    Friend WithEvents lblNoConnection As Label
    Friend WithEvents mtsLoading As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMALQuery As Button
    Friend WithEvents TextBox1 As TextBox
End Class
