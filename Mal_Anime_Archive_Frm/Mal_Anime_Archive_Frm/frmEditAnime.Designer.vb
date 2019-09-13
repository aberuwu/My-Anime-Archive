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
        Me.ddlRewatchValue = New System.Windows.Forms.ComboBox()
        Me.dtFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.dtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.ddlStatus = New System.Windows.Forms.ComboBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnBackward = New System.Windows.Forms.Button()
        Me.ddlSelectAnime = New System.Windows.Forms.ComboBox()
        Me.backWorkEdit = New System.ComponentModel.BackgroundWorker()
        Me.mtddlSelectAnime = New MetroFramework.Controls.MetroComboBox()
        Me.mtddlStatus = New MetroFramework.Controls.MetroComboBox()
        Me.mtddlRewatchValue = New MetroFramework.Controls.MetroComboBox()
        Me.mdtStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.mdtFinishDate = New MetroFramework.Controls.MetroDateTime()
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
        Me.gbxEdit.Location = New System.Drawing.Point(-2, 58)
        Me.gbxEdit.Name = "gbxEdit"
        Me.gbxEdit.Size = New System.Drawing.Size(928, 506)
        Me.gbxEdit.TabIndex = 0
        Me.gbxEdit.TabStop = False
        '
        'pcbLoading
        '
        Me.pcbLoading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbLoading.Location = New System.Drawing.Point(0, 2)
        Me.pcbLoading.Name = "pcbLoading"
        Me.pcbLoading.Size = New System.Drawing.Size(870, 8)
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
        Me.lblMALRating.Location = New System.Drawing.Point(575, 299)
        Me.lblMALRating.Name = "lblMALRating"
        Me.lblMALRating.Size = New System.Drawing.Size(46, 21)
        Me.lblMALRating.TabIndex = 52
        Me.lblMALRating.Text = "####"
        '
        'lblPremiered
        '
        Me.lblPremiered.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPremiered.AutoSize = True
        Me.lblPremiered.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPremiered.Location = New System.Drawing.Point(716, 261)
        Me.lblPremiered.Name = "lblPremiered"
        Me.lblPremiered.Size = New System.Drawing.Size(46, 21)
        Me.lblPremiered.TabIndex = 51
        Me.lblPremiered.Text = "####"
        '
        'lblMALScore
        '
        Me.lblMALScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMALScore.AutoSize = True
        Me.lblMALScore.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMALScore.Location = New System.Drawing.Point(575, 261)
        Me.lblMALScore.Name = "lblMALScore"
        Me.lblMALScore.Size = New System.Drawing.Size(46, 21)
        Me.lblMALScore.TabIndex = 50
        Me.lblMALScore.Text = "####"
        '
        'lblPremieredHeading
        '
        Me.lblPremieredHeading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPremieredHeading.AutoSize = True
        Me.lblPremieredHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremieredHeading.Location = New System.Drawing.Point(626, 261)
        Me.lblPremieredHeading.Name = "lblPremieredHeading"
        Me.lblPremieredHeading.Size = New System.Drawing.Size(86, 21)
        Me.lblPremieredHeading.TabIndex = 49
        Me.lblPremieredHeading.Text = "Premiered"
        '
        'lblMALRatingHeading
        '
        Me.lblMALRatingHeading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMALRatingHeading.AutoSize = True
        Me.lblMALRatingHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALRatingHeading.Location = New System.Drawing.Point(480, 298)
        Me.lblMALRatingHeading.Name = "lblMALRatingHeading"
        Me.lblMALRatingHeading.Size = New System.Drawing.Size(95, 21)
        Me.lblMALRatingHeading.TabIndex = 48
        Me.lblMALRatingHeading.Text = "MAL Rating"
        '
        'lblMALScoreHeading
        '
        Me.lblMALScoreHeading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMALScoreHeading.AutoSize = True
        Me.lblMALScoreHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMALScoreHeading.Location = New System.Drawing.Point(480, 261)
        Me.lblMALScoreHeading.Name = "lblMALScoreHeading"
        Me.lblMALScoreHeading.Size = New System.Drawing.Size(90, 21)
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
        Me.rctSynopsis.Location = New System.Drawing.Point(19, 248)
        Me.rctSynopsis.Name = "rctSynopsis"
        Me.rctSynopsis.ReadOnly = True
        Me.rctSynopsis.Size = New System.Drawing.Size(439, 88)
        Me.rctSynopsis.TabIndex = 46
        Me.rctSynopsis.Text = ""
        '
        'pcbAnimeCover
        '
        Me.pcbAnimeCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbAnimeCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbAnimeCover.Location = New System.Drawing.Point(20, 19)
        Me.pcbAnimeCover.Name = "pcbAnimeCover"
        Me.pcbAnimeCover.Size = New System.Drawing.Size(234, 223)
        Me.pcbAnimeCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbAnimeCover.TabIndex = 45
        Me.pcbAnimeCover.TabStop = False
        '
        'chkViewComments
        '
        Me.chkViewComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkViewComments.AutoSize = True
        Me.chkViewComments.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewComments.Location = New System.Drawing.Point(599, 347)
        Me.chkViewComments.Name = "chkViewComments"
        Me.chkViewComments.Size = New System.Drawing.Size(140, 25)
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
        Me.lblAnimeType.Location = New System.Drawing.Point(602, 50)
        Me.lblAnimeType.Name = "lblAnimeType"
        Me.lblAnimeType.Size = New System.Drawing.Size(56, 25)
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
        Me.lblAnimeID.Location = New System.Drawing.Point(369, 50)
        Me.lblAnimeID.Name = "lblAnimeID"
        Me.lblAnimeID.Size = New System.Drawing.Size(56, 25)
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
        Me.lblTitle.Location = New System.Drawing.Point(271, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(56, 25)
        Me.lblTitle.TabIndex = 26
        Me.lblTitle.Text = "####"
        '
        'numUpDownRewatch
        '
        Me.numUpDownRewatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownRewatch.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownRewatch.Location = New System.Drawing.Point(711, 204)
        Me.numUpDownRewatch.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numUpDownRewatch.Name = "numUpDownRewatch"
        Me.numUpDownRewatch.Size = New System.Drawing.Size(84, 29)
        Me.numUpDownRewatch.TabIndex = 25
        '
        'lblRewatchTimes
        '
        Me.lblRewatchTimes.AutoSize = True
        Me.lblRewatchTimes.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRewatchTimes.Location = New System.Drawing.Point(539, 208)
        Me.lblRewatchTimes.Name = "lblRewatchTimes"
        Me.lblRewatchTimes.Size = New System.Drawing.Size(133, 25)
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
        Me.btnCancel.Location = New System.Drawing.Point(753, 439)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
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
        Me.btnSave.Location = New System.Drawing.Point(753, 387)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ddlRewatchValue
        '
        Me.ddlRewatchValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlRewatchValue.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlRewatchValue.FormattingEnabled = True
        Me.ddlRewatchValue.Items.AddRange(New Object() {"Very Low", "Low", "Medium", "High", "Very High"})
        Me.ddlRewatchValue.Location = New System.Drawing.Point(711, 168)
        Me.ddlRewatchValue.Name = "ddlRewatchValue"
        Me.ddlRewatchValue.Size = New System.Drawing.Size(116, 29)
        Me.ddlRewatchValue.TabIndex = 19
        '
        'dtFinishDate
        '
        Me.dtFinishDate.CustomFormat = "yyyy/mm/dd"
        Me.dtFinishDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinishDate.Location = New System.Drawing.Point(711, 131)
        Me.dtFinishDate.Name = "dtFinishDate"
        Me.dtFinishDate.Size = New System.Drawing.Size(116, 29)
        Me.dtFinishDate.TabIndex = 18
        Me.dtFinishDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'dtStartDate
        '
        Me.dtStartDate.CustomFormat = "yyyy/mm/dd"
        Me.dtStartDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStartDate.Location = New System.Drawing.Point(711, 93)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Size = New System.Drawing.Size(116, 29)
        Me.dtStartDate.TabIndex = 17
        Me.dtStartDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'ddlStatus
        '
        Me.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlStatus.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlStatus.FormattingEnabled = True
        Me.ddlStatus.Items.AddRange(New Object() {"Watching", "Completed", "On-Hold", "Dropped", "Plan to Watch"})
        Me.ddlStatus.Location = New System.Drawing.Point(374, 131)
        Me.ddlStatus.Name = "ddlStatus"
        Me.ddlStatus.Size = New System.Drawing.Size(116, 29)
        Me.ddlStatus.TabIndex = 16
        '
        'numUpDownWatched
        '
        Me.numUpDownWatched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownWatched.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownWatched.Location = New System.Drawing.Point(374, 204)
        Me.numUpDownWatched.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numUpDownWatched.Name = "numUpDownWatched"
        Me.numUpDownWatched.Size = New System.Drawing.Size(84, 29)
        Me.numUpDownWatched.TabIndex = 15
        '
        'numUpDownEpisodes
        '
        Me.numUpDownEpisodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownEpisodes.Enabled = False
        Me.numUpDownEpisodes.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownEpisodes.Location = New System.Drawing.Point(374, 169)
        Me.numUpDownEpisodes.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numUpDownEpisodes.Name = "numUpDownEpisodes"
        Me.numUpDownEpisodes.Size = New System.Drawing.Size(84, 29)
        Me.numUpDownEpisodes.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.numUpDownEpisodes, "Number of Episodes in series." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If no episode ammount is yet available," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this will" &
        " be disabled")
        '
        'numUpDownScore
        '
        Me.numUpDownScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numUpDownScore.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUpDownScore.Location = New System.Drawing.Point(374, 93)
        Me.numUpDownScore.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numUpDownScore.Name = "numUpDownScore"
        Me.numUpDownScore.Size = New System.Drawing.Size(84, 29)
        Me.numUpDownScore.TabIndex = 13
        '
        'lblRewatchHeading
        '
        Me.lblRewatchHeading.AutoSize = True
        Me.lblRewatchHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRewatchHeading.Location = New System.Drawing.Point(539, 173)
        Me.lblRewatchHeading.Name = "lblRewatchHeading"
        Me.lblRewatchHeading.Size = New System.Drawing.Size(130, 25)
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
        Me.lblTagsHeading.Location = New System.Drawing.Point(14, 345)
        Me.lblTagsHeading.Name = "lblTagsHeading"
        Me.lblTagsHeading.Size = New System.Drawing.Size(49, 25)
        Me.lblTagsHeading.TabIndex = 9
        Me.lblTagsHeading.Text = "Tags"
        '
        'lblFinishDateHeading
        '
        Me.lblFinishDateHeading.AutoSize = True
        Me.lblFinishDateHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinishDateHeading.Location = New System.Drawing.Point(539, 135)
        Me.lblFinishDateHeading.Name = "lblFinishDateHeading"
        Me.lblFinishDateHeading.Size = New System.Drawing.Size(96, 25)
        Me.lblFinishDateHeading.TabIndex = 8
        Me.lblFinishDateHeading.Text = "FinishDate"
        '
        'lblStartDateHeading
        '
        Me.lblStartDateHeading.AutoSize = True
        Me.lblStartDateHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDateHeading.Location = New System.Drawing.Point(539, 96)
        Me.lblStartDateHeading.Name = "lblStartDateHeading"
        Me.lblStartDateHeading.Size = New System.Drawing.Size(94, 25)
        Me.lblStartDateHeading.TabIndex = 7
        Me.lblStartDateHeading.Text = "Start Date"
        '
        'lblScoreHeading
        '
        Me.lblScoreHeading.AutoSize = True
        Me.lblScoreHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreHeading.Location = New System.Drawing.Point(270, 92)
        Me.lblScoreHeading.Name = "lblScoreHeading"
        Me.lblScoreHeading.Size = New System.Drawing.Size(58, 25)
        Me.lblScoreHeading.TabIndex = 6
        Me.lblScoreHeading.Text = "Score"
        '
        'lblWatchedHeading
        '
        Me.lblWatchedHeading.AutoSize = True
        Me.lblWatchedHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatchedHeading.Location = New System.Drawing.Point(270, 203)
        Me.lblWatchedHeading.Name = "lblWatchedHeading"
        Me.lblWatchedHeading.Size = New System.Drawing.Size(84, 25)
        Me.lblWatchedHeading.TabIndex = 5
        Me.lblWatchedHeading.Text = "Watched"
        '
        'lblEpisodesHeading
        '
        Me.lblEpisodesHeading.AutoSize = True
        Me.lblEpisodesHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodesHeading.Location = New System.Drawing.Point(270, 168)
        Me.lblEpisodesHeading.Name = "lblEpisodesHeading"
        Me.lblEpisodesHeading.Size = New System.Drawing.Size(85, 25)
        Me.lblEpisodesHeading.TabIndex = 4
        Me.lblEpisodesHeading.Text = "Episodes"
        '
        'lblStatusHeading
        '
        Me.lblStatusHeading.AutoSize = True
        Me.lblStatusHeading.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusHeading.Location = New System.Drawing.Point(270, 131)
        Me.lblStatusHeading.Name = "lblStatusHeading"
        Me.lblStatusHeading.Size = New System.Drawing.Size(61, 25)
        Me.lblStatusHeading.TabIndex = 3
        Me.lblStatusHeading.Text = "Status"
        '
        'lblTypeHeading
        '
        Me.lblTypeHeading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTypeHeading.AutoSize = True
        Me.lblTypeHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeHeading.Location = New System.Drawing.Point(537, 50)
        Me.lblTypeHeading.Name = "lblTypeHeading"
        Me.lblTypeHeading.Size = New System.Drawing.Size(52, 25)
        Me.lblTypeHeading.TabIndex = 2
        Me.lblTypeHeading.Text = "Type"
        '
        'lblTitleHeading
        '
        Me.lblTitleHeading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitleHeading.AutoSize = True
        Me.lblTitleHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHeading.Location = New System.Drawing.Point(333, 17)
        Me.lblTitleHeading.Name = "lblTitleHeading"
        Me.lblTitleHeading.Size = New System.Drawing.Size(49, 25)
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
        Me.lblAnimeIDHeading.Location = New System.Drawing.Point(271, 50)
        Me.lblAnimeIDHeading.Name = "lblAnimeIDHeading"
        Me.lblAnimeIDHeading.Size = New System.Drawing.Size(93, 25)
        Me.lblAnimeIDHeading.TabIndex = 0
        Me.lblAnimeIDHeading.Text = "Anime ID"
        '
        'txtTags
        '
        Me.txtTags.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTags.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTags.Location = New System.Drawing.Point(19, 375)
        Me.txtTags.Multiline = True
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(720, 114)
        Me.txtTags.TabIndex = 20
        '
        'txtComments
        '
        Me.txtComments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComments.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(19, 375)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(720, 114)
        Me.txtComments.TabIndex = 30
        Me.txtComments.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 32)
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
        Me.btnForward.Location = New System.Drawing.Point(829, 17)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(31, 29)
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
        Me.btnBackward.Location = New System.Drawing.Point(799, 17)
        Me.btnBackward.Name = "btnBackward"
        Me.btnBackward.Size = New System.Drawing.Size(31, 29)
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
        Me.ddlSelectAnime.Location = New System.Drawing.Point(480, 17)
        Me.ddlSelectAnime.Name = "ddlSelectAnime"
        Me.ddlSelectAnime.Size = New System.Drawing.Size(320, 29)
        Me.ddlSelectAnime.TabIndex = 49
        '
        'backWorkEdit
        '
        Me.backWorkEdit.WorkerReportsProgress = True
        '
        'mtddlSelectAnime
        '
        Me.mtddlSelectAnime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtddlSelectAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtddlSelectAnime.FormattingEnabled = True
        Me.mtddlSelectAnime.ItemHeight = 23
        Me.mtddlSelectAnime.Location = New System.Drawing.Point(480, 17)
        Me.mtddlSelectAnime.Name = "mtddlSelectAnime"
        Me.mtddlSelectAnime.Size = New System.Drawing.Size(320, 29)
        Me.mtddlSelectAnime.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtddlSelectAnime.TabIndex = 50
        Me.mtddlSelectAnime.UseCustomBackColor = True
        Me.mtddlSelectAnime.UseSelectable = True
        '
        'mtddlStatus
        '
        Me.mtddlStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtddlStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtddlStatus.FormattingEnabled = True
        Me.mtddlStatus.ItemHeight = 23
        Me.mtddlStatus.Items.AddRange(New Object() {"Watching", "Completed", "On-Hold", "Dropped", "Plan to Watch"})
        Me.mtddlStatus.Location = New System.Drawing.Point(374, 131)
        Me.mtddlStatus.Name = "mtddlStatus"
        Me.mtddlStatus.Size = New System.Drawing.Size(116, 29)
        Me.mtddlStatus.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtddlStatus.TabIndex = 106
        Me.mtddlStatus.UseCustomBackColor = True
        Me.mtddlStatus.UseSelectable = True
        '
        'mtddlRewatchValue
        '
        Me.mtddlRewatchValue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtddlRewatchValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtddlRewatchValue.FormattingEnabled = True
        Me.mtddlRewatchValue.ItemHeight = 23
        Me.mtddlRewatchValue.Items.AddRange(New Object() {"Very Low", "Low", "Medium", "High", "Very High"})
        Me.mtddlRewatchValue.Location = New System.Drawing.Point(711, 168)
        Me.mtddlRewatchValue.Name = "mtddlRewatchValue"
        Me.mtddlRewatchValue.Size = New System.Drawing.Size(116, 29)
        Me.mtddlRewatchValue.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtddlRewatchValue.TabIndex = 107
        Me.mtddlRewatchValue.UseCustomBackColor = True
        Me.mtddlRewatchValue.UseSelectable = True
        '
        'mdtStartDate
        '
        Me.mdtStartDate.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdtStartDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.mdtStartDate.CalendarTitleBackColor = System.Drawing.Color.BlueViolet
        Me.mdtStartDate.CustomFormat = "yyyy-dd-M"
        Me.mdtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mdtStartDate.Location = New System.Drawing.Point(711, 93)
        Me.mdtStartDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtStartDate.Name = "mdtStartDate"
        Me.mdtStartDate.Size = New System.Drawing.Size(116, 29)
        Me.mdtStartDate.Style = MetroFramework.MetroColorStyle.Purple
        Me.mdtStartDate.TabIndex = 108
        Me.mdtStartDate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mdtStartDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'mdtFinishDate
        '
        Me.mdtFinishDate.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdtFinishDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.mdtFinishDate.CalendarTitleBackColor = System.Drawing.Color.BlueViolet
        Me.mdtFinishDate.CustomFormat = "yyyy-dd-M"
        Me.mdtFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mdtFinishDate.Location = New System.Drawing.Point(711, 131)
        Me.mdtFinishDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtFinishDate.Name = "mdtFinishDate"
        Me.mdtFinishDate.Size = New System.Drawing.Size(116, 29)
        Me.mdtFinishDate.Style = MetroFramework.MetroColorStyle.Purple
        Me.mdtFinishDate.TabIndex = 109
        Me.mdtFinishDate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mdtFinishDate.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'frmEditAnime
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 559)
        Me.Controls.Add(Me.btnBackward)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxEdit)
        Me.Controls.Add(Me.mtddlSelectAnime)
        Me.Controls.Add(Me.ddlSelectAnime)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1092, 712)
        Me.MinimumSize = New System.Drawing.Size(879, 598)
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
