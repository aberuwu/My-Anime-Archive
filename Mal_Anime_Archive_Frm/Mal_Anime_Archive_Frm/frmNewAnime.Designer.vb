<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewAnime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewAnime))
        Me.gbxEdit = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExpandCollapse = New System.Windows.Forms.Button()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.numUpDownRewatch = New System.Windows.Forms.NumericUpDown()
        Me.lblRewatchTimes = New System.Windows.Forms.Label()
        Me.ddlRewatchValue = New System.Windows.Forms.ComboBox()
        Me.dtFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.dtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRewatchHeading = New System.Windows.Forms.Label()
        Me.lblFinishDateHeading = New System.Windows.Forms.Label()
        Me.lblStartDateHeading = New System.Windows.Forms.Label()
        Me.numUpDownWatched = New System.Windows.Forms.NumericUpDown()
        Me.lblWatchedHeading = New System.Windows.Forms.Label()
        Me.lblSearchResults = New System.Windows.Forms.Label()
        Me.ddlType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblTitleHeader = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.ddlStatus = New System.Windows.Forms.ComboBox()
        Me.numUpDownEpisodes = New System.Windows.Forms.NumericUpDown()
        Me.numUpDownScore = New System.Windows.Forms.NumericUpDown()
        Me.lblScoreHeading = New System.Windows.Forms.Label()
        Me.lblEpisodesHeading = New System.Windows.Forms.Label()
        Me.lblStatusHeading = New System.Windows.Forms.Label()
        Me.gbxResults = New System.Windows.Forms.GroupBox()
        Me.btnResult8 = New System.Windows.Forms.Button()
        Me.btnResult7 = New System.Windows.Forms.Button()
        Me.btnResult6 = New System.Windows.Forms.Button()
        Me.btnResult5 = New System.Windows.Forms.Button()
        Me.btnResult4 = New System.Windows.Forms.Button()
        Me.btnResult3 = New System.Windows.Forms.Button()
        Me.btnResult2 = New System.Windows.Forms.Button()
        Me.btnResult1 = New System.Windows.Forms.Button()
        Me.txtTitle8 = New System.Windows.Forms.TextBox()
        Me.txtTitle7 = New System.Windows.Forms.TextBox()
        Me.txtTitle6 = New System.Windows.Forms.TextBox()
        Me.txtTitle5 = New System.Windows.Forms.TextBox()
        Me.txtTitle4 = New System.Windows.Forms.TextBox()
        Me.txtTitle3 = New System.Windows.Forms.TextBox()
        Me.txtTitle2 = New System.Windows.Forms.TextBox()
        Me.txtTitle1 = New System.Windows.Forms.TextBox()
        Me.pcbResult3 = New System.Windows.Forms.PictureBox()
        Me.pcbResult8 = New System.Windows.Forms.PictureBox()
        Me.pcbResult7 = New System.Windows.Forms.PictureBox()
        Me.pcbResult6 = New System.Windows.Forms.PictureBox()
        Me.pcbResult5 = New System.Windows.Forms.PictureBox()
        Me.pcbResult4 = New System.Windows.Forms.PictureBox()
        Me.pcbResult2 = New System.Windows.Forms.PictureBox()
        Me.pcbResult1 = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtTitleSearch = New System.Windows.Forms.TextBox()
        Me.lblAnimeTitle = New System.Windows.Forms.Label()
        Me.pgbLoadingSearch = New System.Windows.Forms.ProgressBar()
        Me.mtpgbLoading = New MetroFramework.Controls.MetroProgressBar()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bckwNewAnime = New System.ComponentModel.BackgroundWorker()
        Me.gbxEdit.SuspendLayout()
        CType(Me.numUpDownRewatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDownWatched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDownEpisodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDownScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxResults.SuspendLayout()
        CType(Me.pcbResult3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbResult8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbResult7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbResult6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbResult5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbResult4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbResult2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbResult1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxEdit
        '
        Me.gbxEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbxEdit.Controls.Add(Me.Label1)
        Me.gbxEdit.Controls.Add(Me.btnExpandCollapse)
        Me.gbxEdit.Controls.Add(Me.txtTags)
        Me.gbxEdit.Controls.Add(Me.lblComments)
        Me.gbxEdit.Controls.Add(Me.numUpDownRewatch)
        Me.gbxEdit.Controls.Add(Me.lblRewatchTimes)
        Me.gbxEdit.Controls.Add(Me.ddlRewatchValue)
        Me.gbxEdit.Controls.Add(Me.dtFinishDate)
        Me.gbxEdit.Controls.Add(Me.dtStartDate)
        Me.gbxEdit.Controls.Add(Me.lblRewatchHeading)
        Me.gbxEdit.Controls.Add(Me.lblFinishDateHeading)
        Me.gbxEdit.Controls.Add(Me.lblStartDateHeading)
        Me.gbxEdit.Controls.Add(Me.numUpDownWatched)
        Me.gbxEdit.Controls.Add(Me.lblWatchedHeading)
        Me.gbxEdit.Controls.Add(Me.lblSearchResults)
        Me.gbxEdit.Controls.Add(Me.ddlType)
        Me.gbxEdit.Controls.Add(Me.lblType)
        Me.gbxEdit.Controls.Add(Me.lblID)
        Me.gbxEdit.Controls.Add(Me.txtID)
        Me.gbxEdit.Controls.Add(Me.lblTitleHeader)
        Me.gbxEdit.Controls.Add(Me.txtTitle)
        Me.gbxEdit.Controls.Add(Me.ddlStatus)
        Me.gbxEdit.Controls.Add(Me.numUpDownEpisodes)
        Me.gbxEdit.Controls.Add(Me.numUpDownScore)
        Me.gbxEdit.Controls.Add(Me.lblScoreHeading)
        Me.gbxEdit.Controls.Add(Me.lblEpisodesHeading)
        Me.gbxEdit.Controls.Add(Me.lblStatusHeading)
        Me.gbxEdit.Controls.Add(Me.gbxResults)
        Me.gbxEdit.Controls.Add(Me.btnSearch)
        Me.gbxEdit.Controls.Add(Me.txtTitleSearch)
        Me.gbxEdit.Controls.Add(Me.lblAnimeTitle)
        Me.gbxEdit.Controls.Add(Me.pgbLoadingSearch)
        Me.gbxEdit.Controls.Add(Me.mtpgbLoading)
        Me.gbxEdit.Location = New System.Drawing.Point(-2, 58)
        Me.gbxEdit.Name = "gbxEdit"
        Me.gbxEdit.Size = New System.Drawing.Size(653, 540)
        Me.gbxEdit.TabIndex = 1
        Me.gbxEdit.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(799, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 32)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Anime Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExpandCollapse
        '
        Me.btnExpandCollapse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandCollapse.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExpandCollapse.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnExpandCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnExpandCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnExpandCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpandCollapse.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandCollapse.ForeColor = System.Drawing.Color.Black
        Me.btnExpandCollapse.Location = New System.Drawing.Point(568, 197)
        Me.btnExpandCollapse.Name = "btnExpandCollapse"
        Me.btnExpandCollapse.Size = New System.Drawing.Size(22, 110)
        Me.btnExpandCollapse.TabIndex = 101
        Me.btnExpandCollapse.Text = ">"
        Me.btnExpandCollapse.UseVisualStyleBackColor = False
        '
        'txtTags
        '
        Me.txtTags.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTags.Location = New System.Drawing.Point(606, 389)
        Me.txtTags.Multiline = True
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(544, 116)
        Me.txtTags.TabIndex = 100
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(603, 351)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(101, 25)
        Me.lblComments.TabIndex = 99
        Me.lblComments.Text = "Comments"
        '
        'numUpDownRewatch
        '
        Me.numUpDownRewatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownRewatch.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownRewatch.Location = New System.Drawing.Point(1012, 183)
        Me.numUpDownRewatch.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numUpDownRewatch.Name = "numUpDownRewatch"
        Me.numUpDownRewatch.Size = New System.Drawing.Size(84, 29)
        Me.numUpDownRewatch.TabIndex = 97
        '
        'lblRewatchTimes
        '
        Me.lblRewatchTimes.AutoSize = True
        Me.lblRewatchTimes.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRewatchTimes.Location = New System.Drawing.Point(873, 182)
        Me.lblRewatchTimes.Name = "lblRewatchTimes"
        Me.lblRewatchTimes.Size = New System.Drawing.Size(133, 25)
        Me.lblRewatchTimes.TabIndex = 96
        Me.lblRewatchTimes.Text = "Rewatch Times"
        '
        'ddlRewatchValue
        '
        Me.ddlRewatchValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlRewatchValue.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlRewatchValue.FormattingEnabled = True
        Me.ddlRewatchValue.Items.AddRange(New Object() {"Very Low", "Low", "Medium", "High", "Very High"})
        Me.ddlRewatchValue.Location = New System.Drawing.Point(1012, 143)
        Me.ddlRewatchValue.Name = "ddlRewatchValue"
        Me.ddlRewatchValue.Size = New System.Drawing.Size(116, 29)
        Me.ddlRewatchValue.TabIndex = 95
        '
        'dtFinishDate
        '
        Me.dtFinishDate.CustomFormat = "yyyy/mm/dd"
        Me.dtFinishDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinishDate.Location = New System.Drawing.Point(1012, 307)
        Me.dtFinishDate.Name = "dtFinishDate"
        Me.dtFinishDate.Size = New System.Drawing.Size(116, 29)
        Me.dtFinishDate.TabIndex = 94
        Me.dtFinishDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'dtStartDate
        '
        Me.dtStartDate.CustomFormat = "yyyy/mm/dd"
        Me.dtStartDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStartDate.Location = New System.Drawing.Point(1012, 264)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Size = New System.Drawing.Size(116, 29)
        Me.dtStartDate.TabIndex = 93
        Me.dtStartDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'lblRewatchHeading
        '
        Me.lblRewatchHeading.AutoSize = True
        Me.lblRewatchHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRewatchHeading.Location = New System.Drawing.Point(871, 143)
        Me.lblRewatchHeading.Name = "lblRewatchHeading"
        Me.lblRewatchHeading.Size = New System.Drawing.Size(130, 25)
        Me.lblRewatchHeading.TabIndex = 92
        Me.lblRewatchHeading.Text = "Rewatch Value"
        '
        'lblFinishDateHeading
        '
        Me.lblFinishDateHeading.AutoSize = True
        Me.lblFinishDateHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinishDateHeading.Location = New System.Drawing.Point(871, 307)
        Me.lblFinishDateHeading.Name = "lblFinishDateHeading"
        Me.lblFinishDateHeading.Size = New System.Drawing.Size(96, 25)
        Me.lblFinishDateHeading.TabIndex = 91
        Me.lblFinishDateHeading.Text = "FinishDate"
        '
        'lblStartDateHeading
        '
        Me.lblStartDateHeading.AutoSize = True
        Me.lblStartDateHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDateHeading.Location = New System.Drawing.Point(871, 267)
        Me.lblStartDateHeading.Name = "lblStartDateHeading"
        Me.lblStartDateHeading.Size = New System.Drawing.Size(94, 25)
        Me.lblStartDateHeading.TabIndex = 90
        Me.lblStartDateHeading.Text = "Start Date"
        '
        'numUpDownWatched
        '
        Me.numUpDownWatched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownWatched.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownWatched.Location = New System.Drawing.Point(1012, 221)
        Me.numUpDownWatched.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numUpDownWatched.Name = "numUpDownWatched"
        Me.numUpDownWatched.Size = New System.Drawing.Size(84, 29)
        Me.numUpDownWatched.TabIndex = 89
        '
        'lblWatchedHeading
        '
        Me.lblWatchedHeading.AutoSize = True
        Me.lblWatchedHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatchedHeading.Location = New System.Drawing.Point(871, 225)
        Me.lblWatchedHeading.Name = "lblWatchedHeading"
        Me.lblWatchedHeading.Size = New System.Drawing.Size(84, 25)
        Me.lblWatchedHeading.TabIndex = 88
        Me.lblWatchedHeading.Text = "Watched"
        '
        'lblSearchResults
        '
        Me.lblSearchResults.AutoSize = True
        Me.lblSearchResults.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchResults.ForeColor = System.Drawing.Color.Gray
        Me.lblSearchResults.Location = New System.Drawing.Point(25, 236)
        Me.lblSearchResults.Name = "lblSearchResults"
        Me.lblSearchResults.Size = New System.Drawing.Size(525, 64)
        Me.lblSearchResults.TabIndex = 87
        Me.lblSearchResults.Text = "Search MyAnimeList.net database for your anime!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Or add one manually if offline!"
        Me.lblSearchResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ddlType
        '
        Me.ddlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlType.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlType.FormattingEnabled = True
        Me.ddlType.Items.AddRange(New Object() {"TV", "Movie", "OVA", "Special", "Unknown"})
        Me.ddlType.Location = New System.Drawing.Point(727, 182)
        Me.ddlType.Name = "ddlType"
        Me.ddlType.Size = New System.Drawing.Size(116, 29)
        Me.ddlType.TabIndex = 84
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(601, 182)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(51, 25)
        Me.lblType.TabIndex = 83
        Me.lblType.Text = "Type"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(602, 143)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(87, 25)
        Me.lblID.TabIndex = 82
        Me.lblID.Text = "Anime ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(727, 139)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(84, 29)
        Me.txtID.TabIndex = 81
        '
        'lblTitleHeader
        '
        Me.lblTitleHeader.AutoSize = True
        Me.lblTitleHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHeader.Location = New System.Drawing.Point(602, 94)
        Me.lblTitleHeader.Name = "lblTitleHeader"
        Me.lblTitleHeader.Size = New System.Drawing.Size(46, 25)
        Me.lblTitleHeader.TabIndex = 80
        Me.lblTitleHeader.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(654, 93)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(474, 29)
        Me.txtTitle.TabIndex = 79
        '
        'ddlStatus
        '
        Me.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlStatus.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlStatus.FormattingEnabled = True
        Me.ddlStatus.Items.AddRange(New Object() {"Watching", "Completed", "On-Hold", "Dropped", "Plan to Watch"})
        Me.ddlStatus.Location = New System.Drawing.Point(727, 307)
        Me.ddlStatus.Name = "ddlStatus"
        Me.ddlStatus.Size = New System.Drawing.Size(116, 29)
        Me.ddlStatus.TabIndex = 75
        '
        'numUpDownEpisodes
        '
        Me.numUpDownEpisodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownEpisodes.Enabled = False
        Me.numUpDownEpisodes.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownEpisodes.Location = New System.Drawing.Point(727, 226)
        Me.numUpDownEpisodes.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numUpDownEpisodes.Name = "numUpDownEpisodes"
        Me.numUpDownEpisodes.Size = New System.Drawing.Size(84, 29)
        Me.numUpDownEpisodes.TabIndex = 74
        '
        'numUpDownScore
        '
        Me.numUpDownScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownScore.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownScore.Location = New System.Drawing.Point(727, 268)
        Me.numUpDownScore.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numUpDownScore.Name = "numUpDownScore"
        Me.numUpDownScore.Size = New System.Drawing.Size(84, 29)
        Me.numUpDownScore.TabIndex = 73
        '
        'lblScoreHeading
        '
        Me.lblScoreHeading.AutoSize = True
        Me.lblScoreHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreHeading.Location = New System.Drawing.Point(601, 267)
        Me.lblScoreHeading.Name = "lblScoreHeading"
        Me.lblScoreHeading.Size = New System.Drawing.Size(58, 25)
        Me.lblScoreHeading.TabIndex = 72
        Me.lblScoreHeading.Text = "Score"
        '
        'lblEpisodesHeading
        '
        Me.lblEpisodesHeading.AutoSize = True
        Me.lblEpisodesHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodesHeading.Location = New System.Drawing.Point(601, 225)
        Me.lblEpisodesHeading.Name = "lblEpisodesHeading"
        Me.lblEpisodesHeading.Size = New System.Drawing.Size(85, 25)
        Me.lblEpisodesHeading.TabIndex = 71
        Me.lblEpisodesHeading.Text = "Episodes"
        '
        'lblStatusHeading
        '
        Me.lblStatusHeading.AutoSize = True
        Me.lblStatusHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusHeading.Location = New System.Drawing.Point(601, 307)
        Me.lblStatusHeading.Name = "lblStatusHeading"
        Me.lblStatusHeading.Size = New System.Drawing.Size(61, 25)
        Me.lblStatusHeading.TabIndex = 70
        Me.lblStatusHeading.Text = "Status"
        '
        'gbxResults
        '
        Me.gbxResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxResults.Controls.Add(Me.btnResult8)
        Me.gbxResults.Controls.Add(Me.btnResult7)
        Me.gbxResults.Controls.Add(Me.btnResult6)
        Me.gbxResults.Controls.Add(Me.btnResult5)
        Me.gbxResults.Controls.Add(Me.btnResult4)
        Me.gbxResults.Controls.Add(Me.btnResult3)
        Me.gbxResults.Controls.Add(Me.btnResult2)
        Me.gbxResults.Controls.Add(Me.btnResult1)
        Me.gbxResults.Controls.Add(Me.txtTitle8)
        Me.gbxResults.Controls.Add(Me.txtTitle7)
        Me.gbxResults.Controls.Add(Me.txtTitle6)
        Me.gbxResults.Controls.Add(Me.txtTitle5)
        Me.gbxResults.Controls.Add(Me.txtTitle4)
        Me.gbxResults.Controls.Add(Me.txtTitle3)
        Me.gbxResults.Controls.Add(Me.txtTitle2)
        Me.gbxResults.Controls.Add(Me.txtTitle1)
        Me.gbxResults.Controls.Add(Me.pcbResult3)
        Me.gbxResults.Controls.Add(Me.pcbResult8)
        Me.gbxResults.Controls.Add(Me.pcbResult7)
        Me.gbxResults.Controls.Add(Me.pcbResult6)
        Me.gbxResults.Controls.Add(Me.pcbResult5)
        Me.gbxResults.Controls.Add(Me.pcbResult4)
        Me.gbxResults.Controls.Add(Me.pcbResult2)
        Me.gbxResults.Controls.Add(Me.pcbResult1)
        Me.gbxResults.Location = New System.Drawing.Point(6, 79)
        Me.gbxResults.Name = "gbxResults"
        Me.gbxResults.Size = New System.Drawing.Size(577, 436)
        Me.gbxResults.TabIndex = 58
        Me.gbxResults.TabStop = False
        Me.gbxResults.Text = "Results"
        Me.gbxResults.Visible = False
        '
        'btnResult8
        '
        Me.btnResult8.BackColor = System.Drawing.Color.Transparent
        Me.btnResult8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResult8.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnResult8.FlatAppearance.BorderSize = 2
        Me.btnResult8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnResult8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnResult8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResult8.Location = New System.Drawing.Point(439, 240)
        Me.btnResult8.Name = "btnResult8"
        Me.btnResult8.Size = New System.Drawing.Size(114, 151)
        Me.btnResult8.TabIndex = 73
        Me.btnResult8.UseVisualStyleBackColor = False
        '
        'btnResult7
        '
        Me.btnResult7.BackColor = System.Drawing.Color.Transparent
        Me.btnResult7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResult7.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnResult7.FlatAppearance.BorderSize = 2
        Me.btnResult7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnResult7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnResult7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResult7.Location = New System.Drawing.Point(297, 240)
        Me.btnResult7.Name = "btnResult7"
        Me.btnResult7.Size = New System.Drawing.Size(114, 151)
        Me.btnResult7.TabIndex = 72
        Me.btnResult7.UseVisualStyleBackColor = False
        '
        'btnResult6
        '
        Me.btnResult6.BackColor = System.Drawing.Color.Transparent
        Me.btnResult6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResult6.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnResult6.FlatAppearance.BorderSize = 2
        Me.btnResult6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnResult6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnResult6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResult6.Location = New System.Drawing.Point(157, 240)
        Me.btnResult6.Name = "btnResult6"
        Me.btnResult6.Size = New System.Drawing.Size(114, 151)
        Me.btnResult6.TabIndex = 71
        Me.btnResult6.UseVisualStyleBackColor = False
        '
        'btnResult5
        '
        Me.btnResult5.BackColor = System.Drawing.Color.Transparent
        Me.btnResult5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResult5.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnResult5.FlatAppearance.BorderSize = 2
        Me.btnResult5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnResult5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnResult5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResult5.Location = New System.Drawing.Point(18, 240)
        Me.btnResult5.Name = "btnResult5"
        Me.btnResult5.Size = New System.Drawing.Size(114, 151)
        Me.btnResult5.TabIndex = 70
        Me.btnResult5.UseVisualStyleBackColor = False
        '
        'btnResult4
        '
        Me.btnResult4.BackColor = System.Drawing.Color.Transparent
        Me.btnResult4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResult4.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnResult4.FlatAppearance.BorderSize = 2
        Me.btnResult4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnResult4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnResult4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResult4.Location = New System.Drawing.Point(439, 35)
        Me.btnResult4.Name = "btnResult4"
        Me.btnResult4.Size = New System.Drawing.Size(114, 151)
        Me.btnResult4.TabIndex = 69
        Me.btnResult4.UseVisualStyleBackColor = False
        '
        'btnResult3
        '
        Me.btnResult3.BackColor = System.Drawing.Color.Transparent
        Me.btnResult3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResult3.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnResult3.FlatAppearance.BorderSize = 2
        Me.btnResult3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnResult3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnResult3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResult3.Location = New System.Drawing.Point(297, 35)
        Me.btnResult3.Name = "btnResult3"
        Me.btnResult3.Size = New System.Drawing.Size(114, 151)
        Me.btnResult3.TabIndex = 68
        Me.btnResult3.UseVisualStyleBackColor = False
        '
        'btnResult2
        '
        Me.btnResult2.BackColor = System.Drawing.Color.Transparent
        Me.btnResult2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResult2.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnResult2.FlatAppearance.BorderSize = 2
        Me.btnResult2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnResult2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnResult2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResult2.Location = New System.Drawing.Point(157, 35)
        Me.btnResult2.Name = "btnResult2"
        Me.btnResult2.Size = New System.Drawing.Size(114, 151)
        Me.btnResult2.TabIndex = 67
        Me.btnResult2.UseVisualStyleBackColor = False
        '
        'btnResult1
        '
        Me.btnResult1.BackColor = System.Drawing.Color.Transparent
        Me.btnResult1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResult1.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnResult1.FlatAppearance.BorderSize = 2
        Me.btnResult1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnResult1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnResult1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResult1.Location = New System.Drawing.Point(18, 35)
        Me.btnResult1.Name = "btnResult1"
        Me.btnResult1.Size = New System.Drawing.Size(114, 151)
        Me.btnResult1.TabIndex = 66
        Me.btnResult1.UseVisualStyleBackColor = False
        '
        'txtTitle8
        '
        Me.txtTitle8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitle8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle8.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle8.Location = New System.Drawing.Point(434, 393)
        Me.txtTitle8.Name = "txtTitle8"
        Me.txtTitle8.ReadOnly = True
        Me.txtTitle8.Size = New System.Drawing.Size(124, 18)
        Me.txtTitle8.TabIndex = 65
        Me.txtTitle8.Text = "Takagi san"
        Me.txtTitle8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle7
        '
        Me.txtTitle7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitle7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle7.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle7.Location = New System.Drawing.Point(292, 393)
        Me.txtTitle7.Name = "txtTitle7"
        Me.txtTitle7.ReadOnly = True
        Me.txtTitle7.Size = New System.Drawing.Size(124, 18)
        Me.txtTitle7.TabIndex = 64
        Me.txtTitle7.Text = "Takagi san"
        Me.txtTitle7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle6
        '
        Me.txtTitle6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitle6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle6.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle6.Location = New System.Drawing.Point(152, 393)
        Me.txtTitle6.Name = "txtTitle6"
        Me.txtTitle6.ReadOnly = True
        Me.txtTitle6.Size = New System.Drawing.Size(124, 18)
        Me.txtTitle6.TabIndex = 63
        Me.txtTitle6.Text = "Takagi san"
        Me.txtTitle6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle5
        '
        Me.txtTitle5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitle5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle5.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle5.Location = New System.Drawing.Point(13, 393)
        Me.txtTitle5.Name = "txtTitle5"
        Me.txtTitle5.ReadOnly = True
        Me.txtTitle5.Size = New System.Drawing.Size(124, 18)
        Me.txtTitle5.TabIndex = 62
        Me.txtTitle5.Text = "Takagi san"
        Me.txtTitle5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle4
        '
        Me.txtTitle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitle4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle4.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle4.Location = New System.Drawing.Point(434, 188)
        Me.txtTitle4.Name = "txtTitle4"
        Me.txtTitle4.ReadOnly = True
        Me.txtTitle4.Size = New System.Drawing.Size(124, 18)
        Me.txtTitle4.TabIndex = 61
        Me.txtTitle4.Text = "Takagi san"
        Me.txtTitle4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle3
        '
        Me.txtTitle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitle3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle3.Location = New System.Drawing.Point(292, 188)
        Me.txtTitle3.Name = "txtTitle3"
        Me.txtTitle3.ReadOnly = True
        Me.txtTitle3.Size = New System.Drawing.Size(124, 18)
        Me.txtTitle3.TabIndex = 60
        Me.txtTitle3.Text = "Takagi san"
        Me.txtTitle3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle2
        '
        Me.txtTitle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitle2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle2.Location = New System.Drawing.Point(152, 188)
        Me.txtTitle2.Name = "txtTitle2"
        Me.txtTitle2.ReadOnly = True
        Me.txtTitle2.Size = New System.Drawing.Size(124, 18)
        Me.txtTitle2.TabIndex = 59
        Me.txtTitle2.Text = "Takagi san"
        Me.txtTitle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle1
        '
        Me.txtTitle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitle1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle1.Location = New System.Drawing.Point(13, 188)
        Me.txtTitle1.Name = "txtTitle1"
        Me.txtTitle1.ReadOnly = True
        Me.txtTitle1.Size = New System.Drawing.Size(124, 18)
        Me.txtTitle1.TabIndex = 58
        Me.txtTitle1.Text = "Takagi san"
        Me.txtTitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pcbResult3
        '
        Me.pcbResult3.Location = New System.Drawing.Point(297, 35)
        Me.pcbResult3.Name = "pcbResult3"
        Me.pcbResult3.Size = New System.Drawing.Size(114, 151)
        Me.pcbResult3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbResult3.TabIndex = 44
        Me.pcbResult3.TabStop = False
        Me.pcbResult3.Visible = False
        '
        'pcbResult8
        '
        Me.pcbResult8.Location = New System.Drawing.Point(439, 240)
        Me.pcbResult8.Name = "pcbResult8"
        Me.pcbResult8.Size = New System.Drawing.Size(114, 151)
        Me.pcbResult8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbResult8.TabIndex = 49
        Me.pcbResult8.TabStop = False
        Me.pcbResult8.Visible = False
        '
        'pcbResult7
        '
        Me.pcbResult7.Location = New System.Drawing.Point(297, 240)
        Me.pcbResult7.Name = "pcbResult7"
        Me.pcbResult7.Size = New System.Drawing.Size(114, 151)
        Me.pcbResult7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbResult7.TabIndex = 48
        Me.pcbResult7.TabStop = False
        Me.pcbResult7.Visible = False
        '
        'pcbResult6
        '
        Me.pcbResult6.Location = New System.Drawing.Point(157, 240)
        Me.pcbResult6.Name = "pcbResult6"
        Me.pcbResult6.Size = New System.Drawing.Size(114, 151)
        Me.pcbResult6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbResult6.TabIndex = 47
        Me.pcbResult6.TabStop = False
        Me.pcbResult6.Visible = False
        '
        'pcbResult5
        '
        Me.pcbResult5.Location = New System.Drawing.Point(18, 240)
        Me.pcbResult5.Name = "pcbResult5"
        Me.pcbResult5.Size = New System.Drawing.Size(114, 151)
        Me.pcbResult5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbResult5.TabIndex = 46
        Me.pcbResult5.TabStop = False
        Me.pcbResult5.Visible = False
        '
        'pcbResult4
        '
        Me.pcbResult4.Location = New System.Drawing.Point(439, 35)
        Me.pcbResult4.Name = "pcbResult4"
        Me.pcbResult4.Size = New System.Drawing.Size(114, 151)
        Me.pcbResult4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbResult4.TabIndex = 45
        Me.pcbResult4.TabStop = False
        Me.pcbResult4.Visible = False
        '
        'pcbResult2
        '
        Me.pcbResult2.Location = New System.Drawing.Point(157, 35)
        Me.pcbResult2.Name = "pcbResult2"
        Me.pcbResult2.Size = New System.Drawing.Size(114, 151)
        Me.pcbResult2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbResult2.TabIndex = 43
        Me.pcbResult2.TabStop = False
        Me.pcbResult2.Visible = False
        '
        'pcbResult1
        '
        Me.pcbResult1.Location = New System.Drawing.Point(18, 35)
        Me.pcbResult1.Name = "pcbResult1"
        Me.pcbResult1.Size = New System.Drawing.Size(114, 151)
        Me.pcbResult1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbResult1.TabIndex = 42
        Me.pcbResult1.TabStop = False
        Me.pcbResult1.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(512, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(71, 29)
        Me.btnSearch.TabIndex = 41
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(132, 27)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(377, 29)
        Me.txtTitleSearch.TabIndex = 32
        '
        'lblAnimeTitle
        '
        Me.lblAnimeTitle.AutoSize = True
        Me.lblAnimeTitle.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimeTitle.Location = New System.Drawing.Point(8, 27)
        Me.lblAnimeTitle.Name = "lblAnimeTitle"
        Me.lblAnimeTitle.Size = New System.Drawing.Size(124, 25)
        Me.lblAnimeTitle.TabIndex = 31
        Me.lblAnimeTitle.Text = "Search Anime"
        '
        'pgbLoadingSearch
        '
        Me.pgbLoadingSearch.ForeColor = System.Drawing.Color.MediumPurple
        Me.pgbLoadingSearch.Location = New System.Drawing.Point(132, 50)
        Me.pgbLoadingSearch.Maximum = 7
        Me.pgbLoadingSearch.Name = "pgbLoadingSearch"
        Me.pgbLoadingSearch.Size = New System.Drawing.Size(377, 10)
        Me.pgbLoadingSearch.Step = 1
        Me.pgbLoadingSearch.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbLoadingSearch.TabIndex = 102
        Me.pgbLoadingSearch.Visible = False
        '
        'mtpgbLoading
        '
        Me.mtpgbLoading.Location = New System.Drawing.Point(6, 71)
        Me.mtpgbLoading.Maximum = 7
        Me.mtpgbLoading.Name = "mtpgbLoading"
        Me.mtpgbLoading.Size = New System.Drawing.Size(577, 8)
        Me.mtpgbLoading.Step = 1
        Me.mtpgbLoading.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtpgbLoading.TabIndex = 103
        Me.mtpgbLoading.Value = 7
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblHeader.Location = New System.Drawing.Point(12, 14)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(133, 32)
        Me.lblHeader.TabIndex = 3
        Me.lblHeader.Text = "New Anime"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(484, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 35)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bckwNewAnime
        '
        Me.bckwNewAnime.WorkerReportsProgress = True
        '
        'frmNewAnime
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(588, 587)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.gbxEdit)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1191, 626)
        Me.MinimumSize = New System.Drawing.Size(604, 626)
        Me.Name = "frmNewAnime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Anime"
        Me.gbxEdit.ResumeLayout(False)
        Me.gbxEdit.PerformLayout()
        CType(Me.numUpDownRewatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDownWatched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDownEpisodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDownScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxResults.ResumeLayout(False)
        Me.gbxResults.PerformLayout()
        CType(Me.pcbResult3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbResult8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbResult7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbResult6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbResult5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbResult4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbResult2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbResult1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxEdit As GroupBox
    Friend WithEvents txtTitleSearch As TextBox
    Friend WithEvents lblAnimeTitle As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents gbxResults As GroupBox
    Friend WithEvents txtTitle8 As TextBox
    Friend WithEvents txtTitle7 As TextBox
    Friend WithEvents txtTitle6 As TextBox
    Friend WithEvents txtTitle5 As TextBox
    Friend WithEvents txtTitle4 As TextBox
    Friend WithEvents txtTitle3 As TextBox
    Friend WithEvents txtTitle2 As TextBox
    Friend WithEvents txtTitle1 As TextBox
    Friend WithEvents btnResult1 As Button
    Friend WithEvents pcbResult3 As PictureBox
    Friend WithEvents pcbResult8 As PictureBox
    Friend WithEvents pcbResult7 As PictureBox
    Friend WithEvents pcbResult6 As PictureBox
    Friend WithEvents pcbResult5 As PictureBox
    Friend WithEvents pcbResult4 As PictureBox
    Friend WithEvents pcbResult2 As PictureBox
    Friend WithEvents pcbResult1 As PictureBox
    Friend WithEvents btnResult8 As Button
    Friend WithEvents btnResult7 As Button
    Friend WithEvents btnResult6 As Button
    Friend WithEvents btnResult5 As Button
    Friend WithEvents btnResult4 As Button
    Friend WithEvents btnResult3 As Button
    Friend WithEvents btnResult2 As Button
    Friend WithEvents ddlStatus As ComboBox
    Friend WithEvents numUpDownEpisodes As NumericUpDown
    Friend WithEvents numUpDownScore As NumericUpDown
    Friend WithEvents lblScoreHeading As Label
    Friend WithEvents lblEpisodesHeading As Label
    Friend WithEvents lblStatusHeading As Label
    Friend WithEvents lblTitleHeader As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents ddlType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblSearchResults As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents numUpDownWatched As NumericUpDown
    Friend WithEvents lblWatchedHeading As Label
    Friend WithEvents numUpDownRewatch As NumericUpDown
    Friend WithEvents lblRewatchTimes As Label
    Friend WithEvents ddlRewatchValue As ComboBox
    Friend WithEvents dtFinishDate As DateTimePicker
    Friend WithEvents dtStartDate As DateTimePicker
    Friend WithEvents lblRewatchHeading As Label
    Friend WithEvents lblFinishDateHeading As Label
    Friend WithEvents lblStartDateHeading As Label
    Friend WithEvents lblComments As Label
    Friend WithEvents txtTags As TextBox
    Friend WithEvents bckwNewAnime As System.ComponentModel.BackgroundWorker
    Friend WithEvents pgbLoadingSearch As ProgressBar
    Friend WithEvents btnExpandCollapse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents mtpgbLoading As MetroFramework.Controls.MetroProgressBar
End Class
