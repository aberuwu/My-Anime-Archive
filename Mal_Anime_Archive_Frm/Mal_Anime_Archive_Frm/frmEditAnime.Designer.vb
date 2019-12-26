<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditAnime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditAnime))
        Me.gbxEdit = New System.Windows.Forms.GroupBox()
        Me.mdtFinishDate = New MetroFramework.Controls.MetroDateTime()
        Me.mdtStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.pcbLoading = New MetroFramework.Controls.MetroProgressBar()
        Me.lblMALRating = New System.Windows.Forms.Label()
        Me.lblPremiered = New System.Windows.Forms.Label()
        Me.lblMALScore = New System.Windows.Forms.Label()
        Me.lblPremieredHeading = New System.Windows.Forms.Label()
        Me.lblMALRatingHeading = New System.Windows.Forms.Label()
        Me.lblMALScoreHeading = New System.Windows.Forms.Label()
        Me.rctSynopsis = New System.Windows.Forms.RichTextBox()
        Me.pcbAnimeCover = New System.Windows.Forms.PictureBox()
        Me.chkViewComments = New System.Windows.Forms.CheckBox()
        Me.lblAnimeType = New System.Windows.Forms.Label()
        Me.lblAnimeID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.numUpDownRewatch = New System.Windows.Forms.NumericUpDown()
        Me.lblRewatchTimes = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.dtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.numUpDownWatched = New System.Windows.Forms.NumericUpDown()
        Me.numUpDownEpisodes = New System.Windows.Forms.NumericUpDown()
        Me.numUpDownScore = New System.Windows.Forms.NumericUpDown()
        Me.lblRewatchHeading = New System.Windows.Forms.Label()
        Me.lblTagsHeading = New System.Windows.Forms.Label()
        Me.lblFinishDateHeading = New System.Windows.Forms.Label()
        Me.lblStartDateHeading = New System.Windows.Forms.Label()
        Me.lblScoreHeading = New System.Windows.Forms.Label()
        Me.lblWatchedHeading = New System.Windows.Forms.Label()
        Me.lblEpisodesHeading = New System.Windows.Forms.Label()
        Me.lblStatusHeading = New System.Windows.Forms.Label()
        Me.lblTypeHeading = New System.Windows.Forms.Label()
        Me.lblTitleHeading = New System.Windows.Forms.Label()
        Me.lblAnimeIDHeading = New System.Windows.Forms.Label()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.mtddlStatus = New MetroFramework.Controls.MetroComboBox()
        Me.ddlStatus = New System.Windows.Forms.ComboBox()
        Me.mtddlRewatchValue = New MetroFramework.Controls.MetroComboBox()
        Me.ddlRewatchValue = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnBackward = New System.Windows.Forms.Button()
        Me.ddlSelectAnime = New System.Windows.Forms.ComboBox()
        Me.backWorkEdit = New System.ComponentModel.BackgroundWorker()
        Me.mtddlSelectAnime = New MetroFramework.Controls.MetroComboBox()
        Me.gbxEdit.SuspendLayout()
        CType(Me.pcbAnimeCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDownRewatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDownWatched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDownEpisodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDownScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxEdit
        '
        Me.gbxEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbxEdit.Controls.Add(Me.mdtFinishDate)
        Me.gbxEdit.Controls.Add(Me.mdtStartDate)
        Me.gbxEdit.Controls.Add(Me.pcbLoading)
        Me.gbxEdit.Controls.Add(Me.lblMALRating)
        Me.gbxEdit.Controls.Add(Me.lblPremiered)
        Me.gbxEdit.Controls.Add(Me.lblMALScore)
        Me.gbxEdit.Controls.Add(Me.lblPremieredHeading)
        Me.gbxEdit.Controls.Add(Me.lblMALRatingHeading)
        Me.gbxEdit.Controls.Add(Me.lblMALScoreHeading)
        Me.gbxEdit.Controls.Add(Me.rctSynopsis)
        Me.gbxEdit.Controls.Add(Me.pcbAnimeCover)
        Me.gbxEdit.Controls.Add(Me.chkViewComments)
        Me.gbxEdit.Controls.Add(Me.lblAnimeType)
        Me.gbxEdit.Controls.Add(Me.lblAnimeID)
        Me.gbxEdit.Controls.Add(Me.lblTitle)
        Me.gbxEdit.Controls.Add(Me.numUpDownRewatch)
        Me.gbxEdit.Controls.Add(Me.lblRewatchTimes)
        Me.gbxEdit.Controls.Add(Me.btnCancel)
        Me.gbxEdit.Controls.Add(Me.btnSave)
        Me.gbxEdit.Controls.Add(Me.dtFinishDate)
        Me.gbxEdit.Controls.Add(Me.dtStartDate)
        Me.gbxEdit.Controls.Add(Me.numUpDownWatched)
        Me.gbxEdit.Controls.Add(Me.numUpDownEpisodes)
        Me.gbxEdit.Controls.Add(Me.numUpDownScore)
        Me.gbxEdit.Controls.Add(Me.lblRewatchHeading)
        Me.gbxEdit.Controls.Add(Me.lblTagsHeading)
        Me.gbxEdit.Controls.Add(Me.lblFinishDateHeading)
        Me.gbxEdit.Controls.Add(Me.lblStartDateHeading)
        Me.gbxEdit.Controls.Add(Me.lblScoreHeading)
        Me.gbxEdit.Controls.Add(Me.lblWatchedHeading)
        Me.gbxEdit.Controls.Add(Me.lblEpisodesHeading)
        Me.gbxEdit.Controls.Add(Me.lblStatusHeading)
        Me.gbxEdit.Controls.Add(Me.lblTypeHeading)
        Me.gbxEdit.Controls.Add(Me.lblTitleHeading)
        Me.gbxEdit.Controls.Add(Me.lblAnimeIDHeading)
        Me.gbxEdit.Controls.Add(Me.txtTags)
        Me.gbxEdit.Controls.Add(Me.txtComments)
        Me.gbxEdit.Controls.Add(Me.mtddlStatus)
        Me.gbxEdit.Controls.Add(Me.ddlStatus)
        Me.gbxEdit.Controls.Add(Me.mtddlRewatchValue)
        Me.gbxEdit.Controls.Add(Me.ddlRewatchValue)
        Me.gbxEdit.Location = New System.Drawing.Point(-3, 71)
        Me.gbxEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxEdit.Name = "gbxEdit"
        Me.gbxEdit.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxEdit.Size = New System.Drawing.Size(1237, 623)
        Me.gbxEdit.TabIndex = 0
        Me.gbxEdit.TabStop = False
        '
        'mdtFinishDate
        '
        Me.mdtFinishDate.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdtFinishDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.mdtFinishDate.CalendarTitleBackColor = System.Drawing.Color.BlueViolet
        Me.mdtFinishDate.CustomFormat = "yyyy-dd-M"
        Me.mdtFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mdtFinishDate.Location = New System.Drawing.Point(948, 161)
        Me.mdtFinishDate.Margin = New System.Windows.Forms.Padding(4)
        Me.mdtFinishDate.MinimumSize = New System.Drawing.Size(0, 30)
        Me.mdtFinishDate.Name = "mdtFinishDate"
        Me.mdtFinishDate.Size = New System.Drawing.Size(153, 30)
        Me.mdtFinishDate.Style = MetroFramework.MetroColorStyle.Purple
        Me.mdtFinishDate.TabIndex = 109
        Me.mdtFinishDate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mdtFinishDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'mdtStartDate
        '
        Me.mdtStartDate.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdtStartDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.mdtStartDate.CalendarTitleBackColor = System.Drawing.Color.BlueViolet
        Me.mdtStartDate.CustomFormat = "yyyy-dd-M"
        Me.mdtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mdtStartDate.Location = New System.Drawing.Point(948, 114)
        Me.mdtStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.mdtStartDate.MinimumSize = New System.Drawing.Size(0, 30)
        Me.mdtStartDate.Name = "mdtStartDate"
        Me.mdtStartDate.Size = New System.Drawing.Size(153, 30)
        Me.mdtStartDate.Style = MetroFramework.MetroColorStyle.Purple
        Me.mdtStartDate.TabIndex = 108
        Me.mdtStartDate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mdtStartDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'pcbLoading
        '
        Me.pcbLoading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbLoading.Location = New System.Drawing.Point(0, 2)
        Me.pcbLoading.Margin = New System.Windows.Forms.Padding(4)
        Me.pcbLoading.Name = "pcbLoading"
        Me.pcbLoading.Size = New System.Drawing.Size(1160, 10)
        Me.pcbLoading.Step = 1
        Me.pcbLoading.Style = MetroFramework.MetroColorStyle.Purple
        Me.pcbLoading.TabIndex = 105
        Me.pcbLoading.Value = 100
        '
        'lblMALRating
        '
        Me.lblMALRating.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMALRating.AutoSize = True
        Me.lblMALRating.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMALRating.Location = New System.Drawing.Point(767, 368)
        Me.lblMALRating.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMALRating.Name = "lblMALRating"
        Me.lblMALRating.Size = New System.Drawing.Size(60, 28)
        Me.lblMALRating.TabIndex = 52
        Me.lblMALRating.Text = "####"
        '
        'lblPremiered
        '
        Me.lblPremiered.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPremiered.AutoSize = True
        Me.lblPremiered.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPremiered.Location = New System.Drawing.Point(955, 321)
        Me.lblPremiered.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPremiered.Name = "lblPremiered"
        Me.lblPremiered.Size = New System.Drawing.Size(60, 28)
        Me.lblPremiered.TabIndex = 51
        Me.lblPremiered.Text = "####"
        '
        'lblMALScore
        '
        Me.lblMALScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMALScore.AutoSize = True
        Me.lblMALScore.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMALScore.Location = New System.Drawing.Point(767, 321)
        Me.lblMALScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMALScore.Name = "lblMALScore"
        Me.lblMALScore.Size = New System.Drawing.Size(60, 28)
        Me.lblMALScore.TabIndex = 50
        Me.lblMALScore.Text = "####"
        '
        'lblPremieredHeading
        '
        Me.lblPremieredHeading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPremieredHeading.AutoSize = True
        Me.lblPremieredHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremieredHeading.Location = New System.Drawing.Point(835, 321)
        Me.lblPremieredHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPremieredHeading.Name = "lblPremieredHeading"
        Me.lblPremieredHeading.Size = New System.Drawing.Size(106, 28)
        Me.lblPremieredHeading.TabIndex = 49
        Me.lblPremieredHeading.Text = "Premiered"
        '
        'lblMALRatingHeading
        '
        Me.lblMALRatingHeading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMALRatingHeading.AutoSize = True
        Me.lblMALRatingHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALRatingHeading.Location = New System.Drawing.Point(640, 367)
        Me.lblMALRatingHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMALRatingHeading.Name = "lblMALRatingHeading"
        Me.lblMALRatingHeading.Size = New System.Drawing.Size(117, 28)
        Me.lblMALRatingHeading.TabIndex = 48
        Me.lblMALRatingHeading.Text = "MAL Rating"
        '
        'lblMALScoreHeading
        '
        Me.lblMALScoreHeading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMALScoreHeading.AutoSize = True
        Me.lblMALScoreHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALScoreHeading.Location = New System.Drawing.Point(640, 321)
        Me.lblMALScoreHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMALScoreHeading.Name = "lblMALScoreHeading"
        Me.lblMALScoreHeading.Size = New System.Drawing.Size(109, 28)
        Me.lblMALScoreHeading.TabIndex = 47
        Me.lblMALScoreHeading.Text = "MAL Score"
        '
        'rctSynopsis
        '
        Me.rctSynopsis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rctSynopsis.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rctSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rctSynopsis.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rctSynopsis.Location = New System.Drawing.Point(25, 305)
        Me.rctSynopsis.Margin = New System.Windows.Forms.Padding(4)
        Me.rctSynopsis.Name = "rctSynopsis"
        Me.rctSynopsis.ReadOnly = True
        Me.rctSynopsis.Size = New System.Drawing.Size(585, 108)
        Me.rctSynopsis.TabIndex = 46
        Me.rctSynopsis.Text = ""
        '
        'pcbAnimeCover
        '
        Me.pcbAnimeCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbAnimeCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbAnimeCover.Location = New System.Drawing.Point(27, 23)
        Me.pcbAnimeCover.Margin = New System.Windows.Forms.Padding(4)
        Me.pcbAnimeCover.Name = "pcbAnimeCover"
        Me.pcbAnimeCover.Size = New System.Drawing.Size(312, 274)
        Me.pcbAnimeCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbAnimeCover.TabIndex = 45
        Me.pcbAnimeCover.TabStop = False
        '
        'chkViewComments
        '
        Me.chkViewComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkViewComments.AutoSize = True
        Me.chkViewComments.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewComments.Location = New System.Drawing.Point(814, 427)
        Me.chkViewComments.Margin = New System.Windows.Forms.Padding(4)
        Me.chkViewComments.Name = "chkViewComments"
        Me.chkViewComments.Size = New System.Drawing.Size(171, 32)
        Me.chkViewComments.TabIndex = 29
        Me.chkViewComments.Text = "View Comments"
        Me.chkViewComments.UseVisualStyleBackColor = True
        '
        'lblAnimeType
        '
        Me.lblAnimeType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnimeType.AutoSize = True
        Me.lblAnimeType.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimeType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnimeType.Location = New System.Drawing.Point(803, 62)
        Me.lblAnimeType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnimeType.Name = "lblAnimeType"
        Me.lblAnimeType.Size = New System.Drawing.Size(71, 32)
        Me.lblAnimeType.TabIndex = 28
        Me.lblAnimeType.Text = "####"
        '
        'lblAnimeID
        '
        Me.lblAnimeID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnimeID.AutoSize = True
        Me.lblAnimeID.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimeID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnimeID.Location = New System.Drawing.Point(492, 62)
        Me.lblAnimeID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnimeID.Name = "lblAnimeID"
        Me.lblAnimeID.Size = New System.Drawing.Size(71, 32)
        Me.lblAnimeID.TabIndex = 27
        Me.lblAnimeID.Text = "####"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(361, 21)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(71, 32)
        Me.lblTitle.TabIndex = 26
        Me.lblTitle.Text = "####"
        '
        'numUpDownRewatch
        '
        Me.numUpDownRewatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownRewatch.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownRewatch.Location = New System.Drawing.Point(948, 251)
        Me.numUpDownRewatch.Margin = New System.Windows.Forms.Padding(4)
        Me.numUpDownRewatch.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numUpDownRewatch.Name = "numUpDownRewatch"
        Me.numUpDownRewatch.Size = New System.Drawing.Size(112, 34)
        Me.numUpDownRewatch.TabIndex = 25
        '
        'lblRewatchTimes
        '
        Me.lblRewatchTimes.AutoSize = True
        Me.lblRewatchTimes.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRewatchTimes.Location = New System.Drawing.Point(719, 256)
        Me.lblRewatchTimes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRewatchTimes.Name = "lblRewatchTimes"
        Me.lblRewatchTimes.Size = New System.Drawing.Size(167, 32)
        Me.lblRewatchTimes.TabIndex = 24
        Me.lblRewatchTimes.Text = "Rewatch Times"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1004, 540)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 43)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1004, 476)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 43)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtFinishDate
        '
        Me.dtFinishDate.CustomFormat = "yyyy/mm/dd"
        Me.dtFinishDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinishDate.Location = New System.Drawing.Point(948, 161)
        Me.dtFinishDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFinishDate.Name = "dtFinishDate"
        Me.dtFinishDate.Size = New System.Drawing.Size(153, 34)
        Me.dtFinishDate.TabIndex = 18
        Me.dtFinishDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'dtStartDate
        '
        Me.dtStartDate.CustomFormat = "yyyy/mm/dd"
        Me.dtStartDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStartDate.Location = New System.Drawing.Point(948, 114)
        Me.dtStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Size = New System.Drawing.Size(153, 34)
        Me.dtStartDate.TabIndex = 17
        Me.dtStartDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'numUpDownWatched
        '
        Me.numUpDownWatched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownWatched.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownWatched.Location = New System.Drawing.Point(499, 251)
        Me.numUpDownWatched.Margin = New System.Windows.Forms.Padding(4)
        Me.numUpDownWatched.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numUpDownWatched.Name = "numUpDownWatched"
        Me.numUpDownWatched.Size = New System.Drawing.Size(112, 34)
        Me.numUpDownWatched.TabIndex = 15
        '
        'numUpDownEpisodes
        '
        Me.numUpDownEpisodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownEpisodes.Enabled = False
        Me.numUpDownEpisodes.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownEpisodes.Location = New System.Drawing.Point(499, 208)
        Me.numUpDownEpisodes.Margin = New System.Windows.Forms.Padding(4)
        Me.numUpDownEpisodes.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numUpDownEpisodes.Name = "numUpDownEpisodes"
        Me.numUpDownEpisodes.Size = New System.Drawing.Size(112, 34)
        Me.numUpDownEpisodes.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.numUpDownEpisodes, "Number of Episodes in series." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If no episode ammount is yet available," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this will" &
        " be disabled")
        '
        'numUpDownScore
        '
        Me.numUpDownScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownScore.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownScore.Location = New System.Drawing.Point(499, 114)
        Me.numUpDownScore.Margin = New System.Windows.Forms.Padding(4)
        Me.numUpDownScore.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numUpDownScore.Name = "numUpDownScore"
        Me.numUpDownScore.Size = New System.Drawing.Size(112, 34)
        Me.numUpDownScore.TabIndex = 13
        '
        'lblRewatchHeading
        '
        Me.lblRewatchHeading.AutoSize = True
        Me.lblRewatchHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRewatchHeading.Location = New System.Drawing.Point(719, 213)
        Me.lblRewatchHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRewatchHeading.Name = "lblRewatchHeading"
        Me.lblRewatchHeading.Size = New System.Drawing.Size(163, 32)
        Me.lblRewatchHeading.TabIndex = 12
        Me.lblRewatchHeading.Text = "Rewatch Value"
        '
        'lblTagsHeading
        '
        Me.lblTagsHeading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTagsHeading.AutoSize = True
        Me.lblTagsHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagsHeading.Location = New System.Drawing.Point(19, 425)
        Me.lblTagsHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTagsHeading.Name = "lblTagsHeading"
        Me.lblTagsHeading.Size = New System.Drawing.Size(60, 32)
        Me.lblTagsHeading.TabIndex = 9
        Me.lblTagsHeading.Text = "Tags"
        '
        'lblFinishDateHeading
        '
        Me.lblFinishDateHeading.AutoSize = True
        Me.lblFinishDateHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinishDateHeading.Location = New System.Drawing.Point(719, 166)
        Me.lblFinishDateHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinishDateHeading.Name = "lblFinishDateHeading"
        Me.lblFinishDateHeading.Size = New System.Drawing.Size(121, 32)
        Me.lblFinishDateHeading.TabIndex = 8
        Me.lblFinishDateHeading.Text = "FinishDate"
        '
        'lblStartDateHeading
        '
        Me.lblStartDateHeading.AutoSize = True
        Me.lblStartDateHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDateHeading.Location = New System.Drawing.Point(719, 118)
        Me.lblStartDateHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartDateHeading.Name = "lblStartDateHeading"
        Me.lblStartDateHeading.Size = New System.Drawing.Size(119, 32)
        Me.lblStartDateHeading.TabIndex = 7
        Me.lblStartDateHeading.Text = "Start Date"
        '
        'lblScoreHeading
        '
        Me.lblScoreHeading.AutoSize = True
        Me.lblScoreHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreHeading.Location = New System.Drawing.Point(360, 113)
        Me.lblScoreHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScoreHeading.Name = "lblScoreHeading"
        Me.lblScoreHeading.Size = New System.Drawing.Size(72, 32)
        Me.lblScoreHeading.TabIndex = 6
        Me.lblScoreHeading.Text = "Score"
        '
        'lblWatchedHeading
        '
        Me.lblWatchedHeading.AutoSize = True
        Me.lblWatchedHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatchedHeading.Location = New System.Drawing.Point(360, 250)
        Me.lblWatchedHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWatchedHeading.Name = "lblWatchedHeading"
        Me.lblWatchedHeading.Size = New System.Drawing.Size(106, 32)
        Me.lblWatchedHeading.TabIndex = 5
        Me.lblWatchedHeading.Text = "Watched"
        '
        'lblEpisodesHeading
        '
        Me.lblEpisodesHeading.AutoSize = True
        Me.lblEpisodesHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodesHeading.Location = New System.Drawing.Point(360, 207)
        Me.lblEpisodesHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEpisodesHeading.Name = "lblEpisodesHeading"
        Me.lblEpisodesHeading.Size = New System.Drawing.Size(106, 32)
        Me.lblEpisodesHeading.TabIndex = 4
        Me.lblEpisodesHeading.Text = "Episodes"
        '
        'lblStatusHeading
        '
        Me.lblStatusHeading.AutoSize = True
        Me.lblStatusHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusHeading.Location = New System.Drawing.Point(360, 161)
        Me.lblStatusHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatusHeading.Name = "lblStatusHeading"
        Me.lblStatusHeading.Size = New System.Drawing.Size(77, 32)
        Me.lblStatusHeading.TabIndex = 3
        Me.lblStatusHeading.Text = "Status"
        '
        'lblTypeHeading
        '
        Me.lblTypeHeading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTypeHeading.AutoSize = True
        Me.lblTypeHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeHeading.Location = New System.Drawing.Point(716, 62)
        Me.lblTypeHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTypeHeading.Name = "lblTypeHeading"
        Me.lblTypeHeading.Size = New System.Drawing.Size(66, 32)
        Me.lblTypeHeading.TabIndex = 2
        Me.lblTypeHeading.Text = "Type"
        '
        'lblTitleHeading
        '
        Me.lblTitleHeading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitleHeading.AutoSize = True
        Me.lblTitleHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHeading.Location = New System.Drawing.Point(444, 21)
        Me.lblTitleHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleHeading.Name = "lblTitleHeading"
        Me.lblTitleHeading.Size = New System.Drawing.Size(62, 32)
        Me.lblTitleHeading.TabIndex = 1
        Me.lblTitleHeading.Text = "Title"
        Me.lblTitleHeading.Visible = False
        '
        'lblAnimeIDHeading
        '
        Me.lblAnimeIDHeading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnimeIDHeading.AutoSize = True
        Me.lblAnimeIDHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimeIDHeading.Location = New System.Drawing.Point(361, 62)
        Me.lblAnimeIDHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnimeIDHeading.Name = "lblAnimeIDHeading"
        Me.lblAnimeIDHeading.Size = New System.Drawing.Size(116, 32)
        Me.lblAnimeIDHeading.TabIndex = 0
        Me.lblAnimeIDHeading.Text = "Anime ID"
        '
        'txtTags
        '
        Me.txtTags.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTags.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTags.Location = New System.Drawing.Point(25, 462)
        Me.txtTags.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTags.Multiline = True
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(959, 139)
        Me.txtTags.TabIndex = 20
        '
        'txtComments
        '
        Me.txtComments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComments.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(25, 462)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(959, 139)
        Me.txtComments.TabIndex = 30
        Me.txtComments.Visible = False
        '
        'mtddlStatus
        '
        Me.mtddlStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtddlStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtddlStatus.FormattingEnabled = True
        Me.mtddlStatus.ItemHeight = 24
        Me.mtddlStatus.Items.AddRange(New Object() {"Watching", "Completed", "On-Hold", "Dropped", "Plan to Watch"})
        Me.mtddlStatus.Location = New System.Drawing.Point(499, 161)
        Me.mtddlStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.mtddlStatus.Name = "mtddlStatus"
        Me.mtddlStatus.Size = New System.Drawing.Size(153, 30)
        Me.mtddlStatus.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtddlStatus.TabIndex = 106
        Me.mtddlStatus.UseCustomBackColor = True
        Me.mtddlStatus.UseSelectable = True
        '
        'ddlStatus
        '
        Me.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlStatus.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlStatus.FormattingEnabled = True
        Me.ddlStatus.Items.AddRange(New Object() {"Watching", "Completed", "On-Hold", "Dropped", "Plan to Watch"})
        Me.ddlStatus.Location = New System.Drawing.Point(499, 161)
        Me.ddlStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlStatus.Name = "ddlStatus"
        Me.ddlStatus.Size = New System.Drawing.Size(153, 36)
        Me.ddlStatus.TabIndex = 16
        '
        'mtddlRewatchValue
        '
        Me.mtddlRewatchValue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtddlRewatchValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtddlRewatchValue.FormattingEnabled = True
        Me.mtddlRewatchValue.ItemHeight = 24
        Me.mtddlRewatchValue.Items.AddRange(New Object() {"Very Low", "Low", "Medium", "High", "Very High"})
        Me.mtddlRewatchValue.Location = New System.Drawing.Point(948, 207)
        Me.mtddlRewatchValue.Margin = New System.Windows.Forms.Padding(4)
        Me.mtddlRewatchValue.Name = "mtddlRewatchValue"
        Me.mtddlRewatchValue.Size = New System.Drawing.Size(153, 30)
        Me.mtddlRewatchValue.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtddlRewatchValue.TabIndex = 107
        Me.mtddlRewatchValue.UseCustomBackColor = True
        Me.mtddlRewatchValue.UseSelectable = True
        '
        'ddlRewatchValue
        '
        Me.ddlRewatchValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlRewatchValue.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlRewatchValue.FormattingEnabled = True
        Me.ddlRewatchValue.Items.AddRange(New Object() {"Very Low", "Low", "Medium", "High", "Very High"})
        Me.ddlRewatchValue.Location = New System.Drawing.Point(948, 207)
        Me.ddlRewatchValue.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlRewatchValue.Name = "ddlRewatchValue"
        Me.ddlRewatchValue.Size = New System.Drawing.Size(153, 36)
        Me.ddlRewatchValue.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Anime Details/Edit"
        '
        'btnForward
        '
        Me.btnForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForward.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForward.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForward.ForeColor = System.Drawing.Color.Black
        Me.btnForward.Location = New System.Drawing.Point(1105, 21)
        Me.btnForward.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(41, 36)
        Me.btnForward.TabIndex = 47
        Me.btnForward.Text = ">"
        Me.btnForward.UseVisualStyleBackColor = False
        '
        'btnBackward
        '
        Me.btnBackward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackward.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBackward.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnBackward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnBackward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackward.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackward.ForeColor = System.Drawing.Color.Black
        Me.btnBackward.Location = New System.Drawing.Point(1065, 21)
        Me.btnBackward.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackward.Name = "btnBackward"
        Me.btnBackward.Size = New System.Drawing.Size(41, 36)
        Me.btnBackward.TabIndex = 48
        Me.btnBackward.Text = "<"
        Me.btnBackward.UseVisualStyleBackColor = False
        '
        'ddlSelectAnime
        '
        Me.ddlSelectAnime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddlSelectAnime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ddlSelectAnime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ddlSelectAnime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ddlSelectAnime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ddlSelectAnime.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlSelectAnime.FormattingEnabled = True
        Me.ddlSelectAnime.Location = New System.Drawing.Point(640, 21)
        Me.ddlSelectAnime.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlSelectAnime.Name = "ddlSelectAnime"
        Me.ddlSelectAnime.Size = New System.Drawing.Size(425, 36)
        Me.ddlSelectAnime.TabIndex = 49
        '
        'backWorkEdit
        '
        Me.backWorkEdit.WorkerReportsProgress = True
        '
        'mtddlSelectAnime
        '
        Me.mtddlSelectAnime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtddlSelectAnime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtddlSelectAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtddlSelectAnime.FormattingEnabled = True
        Me.mtddlSelectAnime.ItemHeight = 24
        Me.mtddlSelectAnime.Location = New System.Drawing.Point(640, 21)
        Me.mtddlSelectAnime.Margin = New System.Windows.Forms.Padding(4)
        Me.mtddlSelectAnime.Name = "mtddlSelectAnime"
        Me.mtddlSelectAnime.Size = New System.Drawing.Size(425, 30)
        Me.mtddlSelectAnime.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtddlSelectAnime.TabIndex = 50
        Me.mtddlSelectAnime.UseCustomBackColor = True
        Me.mtddlSelectAnime.UseSelectable = True
        '
        'frmEditAnime
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1151, 688)
        Me.Controls.Add(Me.btnBackward)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxEdit)
        Me.Controls.Add(Me.mtddlSelectAnime)
        Me.Controls.Add(Me.ddlSelectAnime)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1450, 865)
        Me.MinimumSize = New System.Drawing.Size(1166, 725)
        Me.Name = "frmEditAnime"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "My Anime Archive - Edit Anime"
        Me.gbxEdit.ResumeLayout(False)
        Me.gbxEdit.PerformLayout()
        CType(Me.pcbAnimeCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDownRewatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDownWatched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDownEpisodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDownScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxEdit As GroupBox
    Friend WithEvents txtTags As TextBox
    Friend WithEvents ddlRewatchValue As ComboBox
    Friend WithEvents dtFinishDate As DateTimePicker
    Friend WithEvents dtStartDate As DateTimePicker
    Friend WithEvents ddlStatus As ComboBox
    Friend WithEvents numUpDownWatched As NumericUpDown
    Friend WithEvents numUpDownEpisodes As NumericUpDown
    Friend WithEvents numUpDownScore As NumericUpDown
    Friend WithEvents lblRewatchHeading As Label
    Friend WithEvents lblTagsHeading As Label
    Friend WithEvents lblFinishDateHeading As Label
    Friend WithEvents lblStartDateHeading As Label
    Friend WithEvents lblScoreHeading As Label
    Friend WithEvents lblWatchedHeading As Label
    Friend WithEvents lblEpisodesHeading As Label
    Friend WithEvents lblStatusHeading As Label
    Friend WithEvents lblTypeHeading As Label
    Friend WithEvents lblTitleHeading As Label
    Friend WithEvents lblAnimeIDHeading As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblAnimeType As Label
    Friend WithEvents lblAnimeID As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents numUpDownRewatch As NumericUpDown
    Friend WithEvents lblRewatchTimes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkViewComments As CheckBox
    Friend WithEvents txtComments As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents rctSynopsis As RichTextBox
    Friend WithEvents pcbAnimeCover As PictureBox
    Friend WithEvents btnForward As Button
    Friend WithEvents btnBackward As Button
    Friend WithEvents lblMALRating As Label
    Friend WithEvents lblPremiered As Label
    Friend WithEvents lblMALScore As Label
    Friend WithEvents lblPremieredHeading As Label
    Friend WithEvents lblMALRatingHeading As Label
    Friend WithEvents lblMALScoreHeading As Label
    Friend WithEvents ddlSelectAnime As ComboBox
    Friend WithEvents pcbLoading As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents backWorkEdit As System.ComponentModel.BackgroundWorker
    Friend WithEvents mtddlSelectAnime As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mtddlStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mtddlRewatchValue As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mdtStartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mdtFinishDate As MetroFramework.Controls.MetroDateTime
End Class
