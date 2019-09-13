<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.mtpnMain = New MetroFramework.Controls.MetroPanel()
        Me.ddlGraphSelection = New System.Windows.Forms.ComboBox()
        Me.chrtAnimeStatus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblOtherStats = New System.Windows.Forms.Label()
        Me.lblMeanScore = New System.Windows.Forms.Label()
        Me.lblWatchedEps = New System.Windows.Forms.Label()
        Me.lblEpisodesHeader = New System.Windows.Forms.Label()
        Me.lblMeanScoreHeader = New System.Windows.Forms.Label()
        Me.pcbUserImage = New System.Windows.Forms.PictureBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPlanToWatch = New System.Windows.Forms.Label()
        Me.lblUserIdHeading = New System.Windows.Forms.Label()
        Me.lblPlanToWatchHeading = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.lblTotalAnimeHeading = New System.Windows.Forms.Label()
        Me.lblCompleted = New System.Windows.Forms.Label()
        Me.lblTotalAnime = New System.Windows.Forms.Label()
        Me.lblCompletedHeading = New System.Windows.Forms.Label()
        Me.lblOnHoldHeading = New System.Windows.Forms.Label()
        Me.lblWatching = New System.Windows.Forms.Label()
        Me.lblOnHold = New System.Windows.Forms.Label()
        Me.lblTotalWatchingHeading = New System.Windows.Forms.Label()
        Me.lblDroppedHeading = New System.Windows.Forms.Label()
        Me.lblDropped = New System.Windows.Forms.Label()
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
        Me.tsbtnUserInfo = New System.Windows.Forms.ToolStripButton()
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
        Me.timerMain = New System.Windows.Forms.Timer(Me.components)
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.backWork = New System.ComponentModel.BackgroundWorker()
        Me.ssMain.SuspendLayout()
        CType(Me.spltMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltMain.Panel1.SuspendLayout()
        Me.spltMain.Panel2.SuspendLayout()
        Me.spltMain.SuspendLayout()
        Me.ctmAnimeList.SuspendLayout()
        Me.mtpnMain.SuspendLayout()
        CType(Me.chrtAnimeStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lstAnimes.Size = New System.Drawing.Size(529, 900)
        Me.lstAnimes.TabIndex = 0
        Me.lstAnimes.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(14, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(110, 25)
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
        Me.lblId.Size = New System.Drawing.Size(50, 21)
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
        Me.lblAnimeIdHeading.Size = New System.Drawing.Size(37, 25)
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
        Me.lblType.Size = New System.Drawing.Size(50, 21)
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
        Me.lblTypeHeading.Size = New System.Drawing.Size(57, 25)
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
        Me.lblEpisodes.Size = New System.Drawing.Size(50, 21)
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
        Me.lblEpisodesHeading.Size = New System.Drawing.Size(91, 25)
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
        Me.lblWatched.Size = New System.Drawing.Size(50, 21)
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
        Me.lblWatchedHeading.Size = New System.Drawing.Size(92, 25)
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
        Me.lblScore.Size = New System.Drawing.Size(50, 21)
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
        Me.lblScoreHeading.Size = New System.Drawing.Size(64, 25)
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
        Me.lblStatus.Size = New System.Drawing.Size(50, 21)
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
        Me.lblStatusHeading.Size = New System.Drawing.Size(69, 25)
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
        Me.txtSearch.Location = New System.Drawing.Point(0, 1)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(226, 26)
        Me.txtSearch.TabIndex = 23
        Me.ttMain.SetToolTip(Me.txtSearch, "Search Anime Name")
        '
        'ssMain
        '
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFileLable, Me.tspb1})
        Me.ssMain.Location = New System.Drawing.Point(0, 732)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(1348, 22)
        Me.ssMain.TabIndex = 25
        Me.ssMain.Text = "StatusStrip1"
        '
        'tsFileLable
        '
        Me.tsFileLable.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsFileLable.ForeColor = System.Drawing.Color.Black
        Me.tsFileLable.Name = "tsFileLable"
        Me.tsFileLable.Size = New System.Drawing.Size(45, 17)
        Me.tsFileLable.Text = "FilePath"
        '
        'tspb1
        '
        Me.tspb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tspb1.Name = "tspb1"
        Me.tspb1.Size = New System.Drawing.Size(100, 16)
        Me.tspb1.Visible = False
        '
        'lblDarkMode
        '
        Me.lblDarkMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDarkMode.AutoSize = True
        Me.lblDarkMode.BackColor = System.Drawing.Color.Transparent
        Me.lblDarkMode.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDarkMode.ForeColor = System.Drawing.Color.Black
        Me.lblDarkMode.Location = New System.Drawing.Point(805, 106)
        Me.lblDarkMode.Name = "lblDarkMode"
        Me.lblDarkMode.Size = New System.Drawing.Size(70, 17)
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
        Me.btnRefresh.Location = New System.Drawing.Point(228, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(33, 26)
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
        Me.btnFullScreen.Location = New System.Drawing.Point(962, 102)
        Me.btnFullScreen.Name = "btnFullScreen"
        Me.btnFullScreen.Size = New System.Drawing.Size(24, 23)
        Me.btnFullScreen.TabIndex = 35
        Me.ttMain.SetToolTip(Me.btnFullScreen, "Full Screen")
        Me.btnFullScreen.UseVisualStyleBackColor = False
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
        Me.spltMain.Panel2.Controls.Add(Me.mtpnMain)
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
        Me.spltMain.Panel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.spltMain.Size = New System.Drawing.Size(1348, 729)
        Me.spltMain.SplitterDistance = 338
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
        Me.btnSearch.Location = New System.Drawing.Point(263, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'vscrSearchList
        '
        Me.vscrSearchList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vscrSearchList.LargeChange = 1
        Me.vscrSearchList.Location = New System.Drawing.Point(327, 9)
        Me.vscrSearchList.Maximum = 0
        Me.vscrSearchList.Name = "vscrSearchList"
        Me.vscrSearchList.Size = New System.Drawing.Size(16, 736)
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
        Me.ctmAnimeList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEdit, Me.tsmiListOptions, Me.tsmiDelete, Me.tsmiVisitPage})
        Me.ctmAnimeList.Name = "ctmAnimeList"
        Me.ctmAnimeList.Size = New System.Drawing.Size(153, 92)
        '
        'tsmiEdit
        '
        Me.tsmiEdit.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.edit_icon
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(152, 22)
        Me.tsmiEdit.Text = "&Edit"
        '
        'tsmiListOptions
        '
        Me.tsmiListOptions.Name = "tsmiListOptions"
        Me.tsmiListOptions.Size = New System.Drawing.Size(152, 22)
        Me.tsmiListOptions.Text = "L&ist Options"
        '
        'tsmiDelete
        '
        Me.tsmiDelete.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.delete_icon
        Me.tsmiDelete.Name = "tsmiDelete"
        Me.tsmiDelete.Size = New System.Drawing.Size(152, 22)
        Me.tsmiDelete.Text = "D&elete"
        '
        'tsmiVisitPage
        '
        Me.tsmiVisitPage.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiVisitPage.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.MAL
        Me.tsmiVisitPage.Name = "tsmiVisitPage"
        Me.tsmiVisitPage.Size = New System.Drawing.Size(152, 22)
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
        Me.lblNoResultFound.Location = New System.Drawing.Point(87, 326)
        Me.lblNoResultFound.Name = "lblNoResultFound"
        Me.lblNoResultFound.Size = New System.Drawing.Size(165, 30)
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
        Me.lstwAnimeSearch.Location = New System.Drawing.Point(11, 2)
        Me.lstwAnimeSearch.MultiSelect = False
        Me.lstwAnimeSearch.Name = "lstwAnimeSearch"
        Me.lstwAnimeSearch.OwnerDraw = True
        Me.lstwAnimeSearch.Size = New System.Drawing.Size(431, 747)
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
        'mtpnMain
        '
        Me.mtpnMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtpnMain.Controls.Add(Me.ddlGraphSelection)
        Me.mtpnMain.Controls.Add(Me.chrtAnimeStatus)
        Me.mtpnMain.Controls.Add(Me.lblOtherStats)
        Me.mtpnMain.Controls.Add(Me.lblMeanScore)
        Me.mtpnMain.Controls.Add(Me.lblWatchedEps)
        Me.mtpnMain.Controls.Add(Me.lblEpisodesHeader)
        Me.mtpnMain.Controls.Add(Me.lblMeanScoreHeader)
        Me.mtpnMain.Controls.Add(Me.pcbUserImage)
        Me.mtpnMain.Controls.Add(Me.lblUserName)
        Me.mtpnMain.Controls.Add(Me.lblPlanToWatch)
        Me.mtpnMain.Controls.Add(Me.lblUserIdHeading)
        Me.mtpnMain.Controls.Add(Me.lblPlanToWatchHeading)
        Me.mtpnMain.Controls.Add(Me.lblUserId)
        Me.mtpnMain.Controls.Add(Me.lblTotalAnimeHeading)
        Me.mtpnMain.Controls.Add(Me.lblCompleted)
        Me.mtpnMain.Controls.Add(Me.lblTotalAnime)
        Me.mtpnMain.Controls.Add(Me.lblCompletedHeading)
        Me.mtpnMain.Controls.Add(Me.lblOnHoldHeading)
        Me.mtpnMain.Controls.Add(Me.lblWatching)
        Me.mtpnMain.Controls.Add(Me.lblOnHold)
        Me.mtpnMain.Controls.Add(Me.lblTotalWatchingHeading)
        Me.mtpnMain.Controls.Add(Me.lblDroppedHeading)
        Me.mtpnMain.Controls.Add(Me.lblDropped)
        Me.mtpnMain.HorizontalScrollbarBarColor = True
        Me.mtpnMain.HorizontalScrollbarHighlightOnWheel = False
        Me.mtpnMain.HorizontalScrollbarSize = 10
        Me.mtpnMain.Location = New System.Drawing.Point(18, 146)
        Me.mtpnMain.Name = "mtpnMain"
        Me.mtpnMain.Size = New System.Drawing.Size(968, 580)
        Me.mtpnMain.TabIndex = 105
        Me.mtpnMain.UseCustomBackColor = True
        Me.mtpnMain.VerticalScrollbarBarColor = True
        Me.mtpnMain.VerticalScrollbarHighlightOnWheel = False
        Me.mtpnMain.VerticalScrollbarSize = 10
        Me.mtpnMain.Visible = False
        '
        'ddlGraphSelection
        '
        Me.ddlGraphSelection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddlGraphSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlGraphSelection.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlGraphSelection.FormattingEnabled = True
        Me.ddlGraphSelection.Items.AddRange(New Object() {"Anime Status", "Anime Ratings", "Anime Other"})
        Me.ddlGraphSelection.Location = New System.Drawing.Point(800, 539)
        Me.ddlGraphSelection.Name = "ddlGraphSelection"
        Me.ddlGraphSelection.Size = New System.Drawing.Size(140, 25)
        Me.ddlGraphSelection.TabIndex = 65
        '
        'chrtAnimeStatus
        '
        Me.chrtAnimeStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrtAnimeStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chrtAnimeStatus.BackImageTransparentColor = System.Drawing.Color.WhiteSmoke
        Me.chrtAnimeStatus.BackSecondaryColor = System.Drawing.Color.WhiteSmoke
        Me.chrtAnimeStatus.BorderlineColor = System.Drawing.Color.WhiteSmoke
        Me.chrtAnimeStatus.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisX.LabelStyle.Enabled = False
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX2.LabelStyle.Enabled = False
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.LabelStyle.Enabled = False
        ChartArea1.AxisY.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY2.LabelStyle.Enabled = False
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Transparent
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackImageTransparentColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.BackSecondaryColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.Name = "ChartArea1"
        Me.chrtAnimeStatus.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.WhiteSmoke
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleFont = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chrtAnimeStatus.Legends.Add(Legend1)
        Me.chrtAnimeStatus.Location = New System.Drawing.Point(-6, 378)
        Me.chrtAnimeStatus.Name = "chrtAnimeStatus"
        Me.chrtAnimeStatus.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chrtAnimeStatus.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.BlueViolet, System.Drawing.Color.Plum, System.Drawing.Color.Purple, System.Drawing.Color.DarkOrchid, System.Drawing.Color.Silver}
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
        Series1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelBorderColor = System.Drawing.Color.Transparent
        Series1.Legend = "Legend1"
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square
        Series1.Name = "Watching"
        Series1.YValuesPerPoint = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
        Series2.LabelBackColor = System.Drawing.Color.Transparent
        Series2.Legend = "Legend1"
        Series2.Name = "Completed"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
        Series3.LabelBackColor = System.Drawing.Color.Transparent
        Series3.Legend = "Legend1"
        Series3.Name = "On-Hold"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
        Series4.LabelBackColor = System.Drawing.Color.Transparent
        Series4.LabelBorderColor = System.Drawing.Color.Transparent
        Series4.Legend = "Legend1"
        Series4.Name = "Dropped"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
        Series5.LabelBackColor = System.Drawing.Color.Transparent
        Series5.LabelBorderColor = System.Drawing.Color.Transparent
        Series5.Legend = "Legend1"
        Series5.Name = "Plan to Watch"
        Me.chrtAnimeStatus.Series.Add(Series1)
        Me.chrtAnimeStatus.Series.Add(Series2)
        Me.chrtAnimeStatus.Series.Add(Series3)
        Me.chrtAnimeStatus.Series.Add(Series4)
        Me.chrtAnimeStatus.Series.Add(Series5)
        Me.chrtAnimeStatus.Size = New System.Drawing.Size(991, 199)
        Me.chrtAnimeStatus.TabIndex = 64
        Me.chrtAnimeStatus.Text = "Anime"
        '
        'lblOtherStats
        '
        Me.lblOtherStats.AutoSize = True
        Me.lblOtherStats.BackColor = System.Drawing.Color.Transparent
        Me.lblOtherStats.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherStats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOtherStats.Location = New System.Drawing.Point(255, 177)
        Me.lblOtherStats.Name = "lblOtherStats"
        Me.lblOtherStats.Size = New System.Drawing.Size(102, 25)
        Me.lblOtherStats.TabIndex = 63
        Me.lblOtherStats.Text = "Other Stats"
        '
        'lblMeanScore
        '
        Me.lblMeanScore.AutoSize = True
        Me.lblMeanScore.BackColor = System.Drawing.Color.Transparent
        Me.lblMeanScore.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeanScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMeanScore.Location = New System.Drawing.Point(589, 211)
        Me.lblMeanScore.Name = "lblMeanScore"
        Me.lblMeanScore.Size = New System.Drawing.Size(56, 25)
        Me.lblMeanScore.TabIndex = 62
        Me.lblMeanScore.Text = "####"
        '
        'lblWatchedEps
        '
        Me.lblWatchedEps.AutoSize = True
        Me.lblWatchedEps.BackColor = System.Drawing.Color.Transparent
        Me.lblWatchedEps.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatchedEps.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWatchedEps.Location = New System.Drawing.Point(383, 211)
        Me.lblWatchedEps.Name = "lblWatchedEps"
        Me.lblWatchedEps.Size = New System.Drawing.Size(56, 25)
        Me.lblWatchedEps.TabIndex = 61
        Me.lblWatchedEps.Text = "####"
        '
        'lblEpisodesHeader
        '
        Me.lblEpisodesHeader.AutoSize = True
        Me.lblEpisodesHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblEpisodesHeader.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodesHeader.ForeColor = System.Drawing.Color.Black
        Me.lblEpisodesHeader.Location = New System.Drawing.Point(255, 211)
        Me.lblEpisodesHeader.Name = "lblEpisodesHeader"
        Me.lblEpisodesHeader.Size = New System.Drawing.Size(119, 25)
        Me.lblEpisodesHeader.TabIndex = 60
        Me.lblEpisodesHeader.Text = "Watched Eps:"
        '
        'lblMeanScoreHeader
        '
        Me.lblMeanScoreHeader.AutoSize = True
        Me.lblMeanScoreHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblMeanScoreHeader.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeanScoreHeader.ForeColor = System.Drawing.Color.Black
        Me.lblMeanScoreHeader.Location = New System.Drawing.Point(452, 211)
        Me.lblMeanScoreHeader.Name = "lblMeanScoreHeader"
        Me.lblMeanScoreHeader.Size = New System.Drawing.Size(110, 25)
        Me.lblMeanScoreHeader.TabIndex = 59
        Me.lblMeanScoreHeader.Text = "Mean Score:"
        '
        'pcbUserImage
        '
        Me.pcbUserImage.BackColor = System.Drawing.Color.Transparent
        Me.pcbUserImage.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.pcbUserImage.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.pcbUserImage.Location = New System.Drawing.Point(25, 52)
        Me.pcbUserImage.Name = "pcbUserImage"
        Me.pcbUserImage.Size = New System.Drawing.Size(188, 184)
        Me.pcbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbUserImage.TabIndex = 56
        Me.pcbUserImage.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(255, 43)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(56, 25)
        Me.lblUserName.TabIndex = 43
        Me.lblUserName.Text = "####"
        '
        'lblPlanToWatch
        '
        Me.lblPlanToWatch.AutoSize = True
        Me.lblPlanToWatch.BackColor = System.Drawing.Color.Transparent
        Me.lblPlanToWatch.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanToWatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPlanToWatch.Location = New System.Drawing.Point(589, 140)
        Me.lblPlanToWatch.Name = "lblPlanToWatch"
        Me.lblPlanToWatch.Size = New System.Drawing.Size(56, 25)
        Me.lblPlanToWatch.TabIndex = 58
        Me.lblPlanToWatch.Text = "####"
        '
        'lblUserIdHeading
        '
        Me.lblUserIdHeading.AutoSize = True
        Me.lblUserIdHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblUserIdHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserIdHeading.Location = New System.Drawing.Point(62, 25)
        Me.lblUserIdHeading.Name = "lblUserIdHeading"
        Me.lblUserIdHeading.Size = New System.Drawing.Size(33, 25)
        Me.lblUserIdHeading.TabIndex = 44
        Me.lblUserIdHeading.Text = "ID:"
        '
        'lblPlanToWatchHeading
        '
        Me.lblPlanToWatchHeading.AutoSize = True
        Me.lblPlanToWatchHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblPlanToWatchHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanToWatchHeading.ForeColor = System.Drawing.Color.Black
        Me.lblPlanToWatchHeading.Location = New System.Drawing.Point(452, 139)
        Me.lblPlanToWatchHeading.Name = "lblPlanToWatchHeading"
        Me.lblPlanToWatchHeading.Size = New System.Drawing.Size(126, 25)
        Me.lblPlanToWatchHeading.TabIndex = 57
        Me.lblPlanToWatchHeading.Text = "Plan To Watch:"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.BackColor = System.Drawing.Color.Transparent
        Me.lblUserId.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserId.Location = New System.Drawing.Point(94, 28)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(50, 21)
        Me.lblUserId.TabIndex = 45
        Me.lblUserId.Text = "####"
        '
        'lblTotalAnimeHeading
        '
        Me.lblTotalAnimeHeading.AutoSize = True
        Me.lblTotalAnimeHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAnimeHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAnimeHeading.ForeColor = System.Drawing.Color.Black
        Me.lblTotalAnimeHeading.Location = New System.Drawing.Point(255, 79)
        Me.lblTotalAnimeHeading.Name = "lblTotalAnimeHeading"
        Me.lblTotalAnimeHeading.Size = New System.Drawing.Size(110, 25)
        Me.lblTotalAnimeHeading.TabIndex = 46
        Me.lblTotalAnimeHeading.Text = "Total Anime:"
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.BackColor = System.Drawing.Color.Transparent
        Me.lblCompleted.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCompleted.Location = New System.Drawing.Point(383, 140)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Size = New System.Drawing.Size(56, 25)
        Me.lblCompleted.TabIndex = 55
        Me.lblCompleted.Text = "####"
        '
        'lblTotalAnime
        '
        Me.lblTotalAnime.AutoSize = True
        Me.lblTotalAnime.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAnime.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAnime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalAnime.Location = New System.Drawing.Point(383, 80)
        Me.lblTotalAnime.Name = "lblTotalAnime"
        Me.lblTotalAnime.Size = New System.Drawing.Size(56, 25)
        Me.lblTotalAnime.TabIndex = 47
        Me.lblTotalAnime.Text = "####"
        '
        'lblCompletedHeading
        '
        Me.lblCompletedHeading.AutoSize = True
        Me.lblCompletedHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblCompletedHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedHeading.ForeColor = System.Drawing.Color.Black
        Me.lblCompletedHeading.Location = New System.Drawing.Point(255, 139)
        Me.lblCompletedHeading.Name = "lblCompletedHeading"
        Me.lblCompletedHeading.Size = New System.Drawing.Size(107, 25)
        Me.lblCompletedHeading.TabIndex = 54
        Me.lblCompletedHeading.Text = "Completed:"
        '
        'lblOnHoldHeading
        '
        Me.lblOnHoldHeading.AutoSize = True
        Me.lblOnHoldHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblOnHoldHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnHoldHeading.ForeColor = System.Drawing.Color.Black
        Me.lblOnHoldHeading.Location = New System.Drawing.Point(452, 79)
        Me.lblOnHoldHeading.Name = "lblOnHoldHeading"
        Me.lblOnHoldHeading.Size = New System.Drawing.Size(84, 25)
        Me.lblOnHoldHeading.TabIndex = 48
        Me.lblOnHoldHeading.Text = "On Hold:"
        '
        'lblWatching
        '
        Me.lblWatching.AutoSize = True
        Me.lblWatching.BackColor = System.Drawing.Color.Transparent
        Me.lblWatching.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatching.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWatching.Location = New System.Drawing.Point(383, 110)
        Me.lblWatching.Name = "lblWatching"
        Me.lblWatching.Size = New System.Drawing.Size(56, 25)
        Me.lblWatching.TabIndex = 53
        Me.lblWatching.Text = "####"
        '
        'lblOnHold
        '
        Me.lblOnHold.AutoSize = True
        Me.lblOnHold.BackColor = System.Drawing.Color.Transparent
        Me.lblOnHold.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnHold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOnHold.Location = New System.Drawing.Point(589, 77)
        Me.lblOnHold.Name = "lblOnHold"
        Me.lblOnHold.Size = New System.Drawing.Size(56, 25)
        Me.lblOnHold.TabIndex = 49
        Me.lblOnHold.Text = "####"
        '
        'lblTotalWatchingHeading
        '
        Me.lblTotalWatchingHeading.AutoSize = True
        Me.lblTotalWatchingHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalWatchingHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWatchingHeading.ForeColor = System.Drawing.Color.Black
        Me.lblTotalWatchingHeading.Location = New System.Drawing.Point(255, 109)
        Me.lblTotalWatchingHeading.Name = "lblTotalWatchingHeading"
        Me.lblTotalWatchingHeading.Size = New System.Drawing.Size(90, 25)
        Me.lblTotalWatchingHeading.TabIndex = 52
        Me.lblTotalWatchingHeading.Text = "Watching:"
        '
        'lblDroppedHeading
        '
        Me.lblDroppedHeading.AutoSize = True
        Me.lblDroppedHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblDroppedHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDroppedHeading.ForeColor = System.Drawing.Color.Black
        Me.lblDroppedHeading.Location = New System.Drawing.Point(452, 108)
        Me.lblDroppedHeading.Name = "lblDroppedHeading"
        Me.lblDroppedHeading.Size = New System.Drawing.Size(89, 25)
        Me.lblDroppedHeading.TabIndex = 50
        Me.lblDroppedHeading.Text = "Dropped:"
        '
        'lblDropped
        '
        Me.lblDropped.AutoSize = True
        Me.lblDropped.BackColor = System.Drawing.Color.Transparent
        Me.lblDropped.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDropped.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDropped.Location = New System.Drawing.Point(589, 110)
        Me.lblDropped.Name = "lblDropped"
        Me.lblDropped.Size = New System.Drawing.Size(56, 25)
        Me.lblDropped.TabIndex = 51
        Me.lblDropped.Text = "####"
        '
        'lblNoListLoaded
        '
        Me.lblNoListLoaded.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNoListLoaded.AutoSize = True
        Me.lblNoListLoaded.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoListLoaded.ForeColor = System.Drawing.Color.Gray
        Me.lblNoListLoaded.Location = New System.Drawing.Point(420, 264)
        Me.lblNoListLoaded.Name = "lblNoListLoaded"
        Me.lblNoListLoaded.Size = New System.Drawing.Size(171, 32)
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
        Me.tsMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.btnSave, Me.btnXml, Me.btnAbout, Me.tsbtnSort, Me.tsbtnNewAnime, Me.tsbtnEdit, Me.tsbtnDelete, Me.tsbtnUserInfo, Me.btnUserInfo})
        Me.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1006, 27)
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
        Me.btnOpen.Size = New System.Drawing.Size(56, 24)
        Me.btnOpen.Text = "&Open"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.SaveAs_16x
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 24)
        Me.btnSave.Text = "&Export List"
        '
        'btnXml
        '
        Me.btnXml.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXml.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.xml_ico
        Me.btnXml.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXml.Name = "btnXml"
        Me.btnXml.Size = New System.Drawing.Size(77, 24)
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
        Me.btnAbout.Size = New System.Drawing.Size(60, 24)
        Me.btnAbout.Text = "&About"
        '
        'tsbtnSort
        '
        Me.tsbtnSort.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnSort.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.filter2
        Me.tsbtnSort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSort.Name = "tsbtnSort"
        Me.tsbtnSort.Size = New System.Drawing.Size(65, 24)
        Me.tsbtnSort.Text = "Sort by"
        '
        'tsbtnNewAnime
        '
        Me.tsbtnNewAnime.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.new_icon
        Me.tsbtnNewAnime.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewAnime.Name = "tsbtnNewAnime"
        Me.tsbtnNewAnime.Size = New System.Drawing.Size(89, 24)
        Me.tsbtnNewAnime.Text = "&New Anime"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.edit_icon
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(85, 24)
        Me.tsbtnEdit.Text = "&Edit Anime"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.delete_icon
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(60, 24)
        Me.tsbtnDelete.Text = "&Delete"
        '
        'tsbtnUserInfo
        '
        Me.tsbtnUserInfo.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.tsbtnUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUserInfo.Name = "tsbtnUserInfo"
        Me.tsbtnUserInfo.Size = New System.Drawing.Size(74, 24)
        Me.tsbtnUserInfo.Text = "&User Info"
        '
        'btnUserInfo
        '
        Me.btnUserInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUserInfo.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.btnUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserInfo.Name = "btnUserInfo"
        Me.btnUserInfo.Size = New System.Drawing.Size(70, 24)
        Me.btnUserInfo.Text = "&Settings"
        '
        'pcbtnDarkMode
        '
        Me.pcbtnDarkMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbtnDarkMode.BackColor = System.Drawing.Color.Transparent
        Me.pcbtnDarkMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbtnDarkMode.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Switch_OffP
        Me.pcbtnDarkMode.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Switch_OffP
        Me.pcbtnDarkMode.Location = New System.Drawing.Point(875, 101)
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
        Me.pcbUserPicture.Location = New System.Drawing.Point(950, 35)
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
        Me.pcbLogo.Location = New System.Drawing.Point(797, 28)
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
        Me.lstwAnimeMain.Size = New System.Drawing.Size(968, 580)
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
        Me.pcbLoading.Location = New System.Drawing.Point(18, 141)
        Me.pcbLoading.Maximum = 7
        Me.pcbLoading.Name = "pcbLoading"
        Me.pcbLoading.Size = New System.Drawing.Size(968, 8)
        Me.pcbLoading.Step = 1
        Me.pcbLoading.Style = MetroFramework.MetroColorStyle.Purple
        Me.pcbLoading.TabIndex = 104
        Me.pcbLoading.Value = 7
        Me.pcbLoading.Visible = False
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
        Me.lblCopyright.Size = New System.Drawing.Size(229, 15)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
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
        Me.Text = "My Anime Archive - Personal Anime Archive v1.0"
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.spltMain.Panel1.ResumeLayout(False)
        Me.spltMain.Panel1.PerformLayout()
        Me.spltMain.Panel2.ResumeLayout(False)
        Me.spltMain.Panel2.PerformLayout()
        CType(Me.spltMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltMain.ResumeLayout(False)
        Me.ctmAnimeList.ResumeLayout(False)
        Me.mtpnMain.ResumeLayout(False)
        Me.mtpnMain.PerformLayout()
        CType(Me.chrtAnimeStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbUserImage, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents mtpnMain As MetroFramework.Controls.MetroPanel
    Friend WithEvents ddlGraphSelection As ComboBox
    Friend WithEvents chrtAnimeStatus As DataVisualization.Charting.Chart
    Friend WithEvents lblOtherStats As Label
    Friend WithEvents lblMeanScore As Label
    Friend WithEvents lblWatchedEps As Label
    Friend WithEvents lblEpisodesHeader As Label
    Friend WithEvents lblMeanScoreHeader As Label
    Friend WithEvents pcbUserImage As PictureBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPlanToWatch As Label
    Friend WithEvents lblUserIdHeading As Label
    Friend WithEvents lblPlanToWatchHeading As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents lblTotalAnimeHeading As Label
    Friend WithEvents lblCompleted As Label
    Friend WithEvents lblTotalAnime As Label
    Friend WithEvents lblCompletedHeading As Label
    Friend WithEvents lblOnHoldHeading As Label
    Friend WithEvents lblWatching As Label
    Friend WithEvents lblOnHold As Label
    Friend WithEvents lblTotalWatchingHeading As Label
    Friend WithEvents lblDroppedHeading As Label
    Friend WithEvents lblDropped As Label
    Friend WithEvents tsbtnUserInfo As ToolStripButton
End Class
