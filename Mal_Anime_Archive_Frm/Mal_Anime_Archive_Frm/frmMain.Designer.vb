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
        Me.timerMain = New System.Windows.Forms.Timer(Me.components)
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.backWork = New System.ComponentModel.BackgroundWorker()
        Me.ssMain.SuspendLayout()
        CType(Me.spltMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltMain.Panel1.SuspendLayout()
        Me.spltMain.Panel2.SuspendLayout()
        Me.spltMain.SuspendLayout()
        Me.ctmAnimeList.SuspendLayout()
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
        Me.lstAnimes.Size = New System.Drawing.Size(327, 690)
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
        Me.txtSearch.Size = New System.Drawing.Size(228, 26)
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
        Me.lblDarkMode.Location = New System.Drawing.Point(831, 94)
        Me.lblDarkMode.Name = "lblDarkMode"
        Me.lblDarkMode.Size = New System.Drawing.Size(70, 17)
        Me.lblDarkMode.TabIndex = 28
        Me.lblDarkMode.Text = "Dark Mode"
        Me.lblDarkMode.Visible = False
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
        Me.btnRefresh.Location = New System.Drawing.Point(229, 1)
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
        Me.btnFullScreen.Location = New System.Drawing.Point(970, 91)
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
        Me.btnSearch.Location = New System.Drawing.Point(263, 1)
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
        Me.vscrSearchList.Location = New System.Drawing.Point(323, 14)
        Me.vscrSearchList.Maximum = 0
        Me.vscrSearchList.Name = "vscrSearchList"
        Me.vscrSearchList.Size = New System.Drawing.Size(16, 734)
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
        Me.lstwStatus.Size = New System.Drawing.Size(14, 720)
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
        Me.lblNoResultFound.Location = New System.Drawing.Point(75, 302)
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
        Me.lstwAnimeSearch.Size = New System.Drawing.Size(351, 721)
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
        'lblNoListLoaded
        '
        Me.lblNoListLoaded.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNoListLoaded.AutoSize = True
        Me.lblNoListLoaded.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoListLoaded.ForeColor = System.Drawing.Color.Gray
        Me.lblNoListLoaded.Location = New System.Drawing.Point(406, 260)
        Me.lblNoListLoaded.Name = "lblNoListLoaded"
        Me.lblNoListLoaded.Size = New System.Drawing.Size(171, 32)
        Me.lblNoListLoaded.TabIndex = 42
        Me.lblNoListLoaded.Text = "No List Loaded"
        Me.lblNoListLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoListLoaded.Visible = False
        '
        'tsMain
        '
        Me.tsMain.BackColor = System.Drawing.Color.Black
        Me.tsMain.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.tsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.btnSave, Me.btnXml, Me.btnAbout, Me.tsbtnSort, Me.tsbtnNewAnime, Me.tsbtnEdit, Me.tsbtnDelete, Me.btnUserInfo})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1006, 25)
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
        Me.btnOpen.Size = New System.Drawing.Size(56, 22)
        Me.btnOpen.Text = "&Open"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.SaveAs_16x
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 22)
        Me.btnSave.Text = "&Export List"
        '
        'btnXml
        '
        Me.btnXml.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXml.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.xml_ico
        Me.btnXml.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXml.Name = "btnXml"
        Me.btnXml.Size = New System.Drawing.Size(77, 22)
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
        Me.btnAbout.Size = New System.Drawing.Size(60, 22)
        Me.btnAbout.Text = "&About"
        '
        'tsbtnSort
        '
        Me.tsbtnSort.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnSort.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.filter2
        Me.tsbtnSort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSort.Name = "tsbtnSort"
        Me.tsbtnSort.Size = New System.Drawing.Size(65, 22)
        Me.tsbtnSort.Text = "Sort by"
        '
        'tsbtnNewAnime
        '
        Me.tsbtnNewAnime.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.new_icon
        Me.tsbtnNewAnime.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewAnime.Name = "tsbtnNewAnime"
        Me.tsbtnNewAnime.Size = New System.Drawing.Size(89, 22)
        Me.tsbtnNewAnime.Text = "&New Anime"
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.edit_icon
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(85, 22)
        Me.tsbtnEdit.Text = "&Edit Anime"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.delete_icon
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(60, 22)
        Me.tsbtnDelete.Text = "&Delete"
        '
        'btnUserInfo
        '
        Me.btnUserInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUserInfo.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.btnUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUserInfo.Name = "btnUserInfo"
        Me.btnUserInfo.Size = New System.Drawing.Size(98, 22)
        Me.btnUserInfo.Text = "&User/Settings"
        '
        'pcbtnDarkMode
        '
        Me.pcbtnDarkMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbtnDarkMode.BackColor = System.Drawing.Color.Transparent
        Me.pcbtnDarkMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbtnDarkMode.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Switch_OffP
        Me.pcbtnDarkMode.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Switch_OffP
        Me.pcbtnDarkMode.Location = New System.Drawing.Point(901, 89)
        Me.pcbtnDarkMode.Name = "pcbtnDarkMode"
        Me.pcbtnDarkMode.Size = New System.Drawing.Size(63, 25)
        Me.pcbtnDarkMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbtnDarkMode.TabIndex = 29
        Me.pcbtnDarkMode.TabStop = False
        Me.pcbtnDarkMode.Visible = False
        '
        'pcbUserPicture
        '
        Me.pcbUserPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbUserPicture.BackColor = System.Drawing.Color.Transparent
        Me.pcbUserPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbUserPicture.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.pcbUserPicture.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.pcbUserPicture.Location = New System.Drawing.Point(959, 28)
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
        Me.pcbLogo.Location = New System.Drawing.Point(806, 21)
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
        Me.lstwAnimeMain.Size = New System.Drawing.Size(968, 579)
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
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 754)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.spltMain)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1092, 575)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
End Class
