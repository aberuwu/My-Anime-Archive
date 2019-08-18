﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserInfo
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserInfo))
        Me.lblCompleted = New System.Windows.Forms.Label()
        Me.lblCompletedHeading = New System.Windows.Forms.Label()
        Me.lblWatching = New System.Windows.Forms.Label()
        Me.lblTotalWatchingHeading = New System.Windows.Forms.Label()
        Me.lblDropped = New System.Windows.Forms.Label()
        Me.lblDroppedHeading = New System.Windows.Forms.Label()
        Me.lblOnHold = New System.Windows.Forms.Label()
        Me.lblOnHoldHeading = New System.Windows.Forms.Label()
        Me.lblTotalAnime = New System.Windows.Forms.Label()
        Me.lblTotalAnimeHeading = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblUserIdHeading = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPlanToWatch = New System.Windows.Forms.Label()
        Me.lblPlanToWatchHeading = New System.Windows.Forms.Label()
        Me.pcbUserImage = New System.Windows.Forms.PictureBox()
        Me.tbSettings = New System.Windows.Forms.TabPage()
        Me.pcbPreviewDark = New System.Windows.Forms.PictureBox()
        Me.pcbPreviewLight = New System.Windows.Forms.PictureBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.lblProgramSettings = New System.Windows.Forms.Label()
        Me.radDisabled = New System.Windows.Forms.RadioButton()
        Me.radEnabled = New System.Windows.Forms.RadioButton()
        Me.lblEDWebBrowser = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnDefaultSave = New System.Windows.Forms.Button()
        Me.lblDefaultSave = New System.Windows.Forms.Label()
        Me.ddlFonts = New System.Windows.Forms.ComboBox()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.ddlThemes = New System.Windows.Forms.ComboBox()
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.tbUser = New System.Windows.Forms.TabPage()
        Me.ddlGraphSelection = New System.Windows.Forms.ComboBox()
        Me.chrtAnimeStatus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblOtherStats = New System.Windows.Forms.Label()
        Me.lblMeanScore = New System.Windows.Forms.Label()
        Me.lblEpisodes = New System.Windows.Forms.Label()
        Me.lblEpisodesHeader = New System.Windows.Forms.Label()
        Me.lblMeanScoreHeader = New System.Windows.Forms.Label()
        Me.tbUserInfo = New System.Windows.Forms.TabControl()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbxPreview = New System.Windows.Forms.GroupBox()
        Me.chkPreviewDark = New System.Windows.Forms.CheckBox()
        CType(Me.pcbUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSettings.SuspendLayout()
        CType(Me.pcbPreviewDark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPreviewLight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbUser.SuspendLayout()
        CType(Me.chrtAnimeStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbUserInfo.SuspendLayout()
        Me.gbxPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.BackColor = System.Drawing.Color.Transparent
        Me.lblCompleted.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCompleted.Location = New System.Drawing.Point(390, 120)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Size = New System.Drawing.Size(56, 25)
        Me.lblCompleted.TabIndex = 32
        Me.lblCompleted.Text = "####"
        Me.toolTip.SetToolTip(Me.lblCompleted, "Running total of all 'Completed' status anime.")
        '
        'lblCompletedHeading
        '
        Me.lblCompletedHeading.AutoSize = True
        Me.lblCompletedHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblCompletedHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedHeading.Location = New System.Drawing.Point(262, 119)
        Me.lblCompletedHeading.Name = "lblCompletedHeading"
        Me.lblCompletedHeading.Size = New System.Drawing.Size(107, 25)
        Me.lblCompletedHeading.TabIndex = 31
        Me.lblCompletedHeading.Text = "Completed:"
        Me.toolTip.SetToolTip(Me.lblCompletedHeading, "Running total of all 'Completed' status anime.")
        '
        'lblWatching
        '
        Me.lblWatching.AutoSize = True
        Me.lblWatching.BackColor = System.Drawing.Color.Transparent
        Me.lblWatching.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatching.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWatching.Location = New System.Drawing.Point(390, 90)
        Me.lblWatching.Name = "lblWatching"
        Me.lblWatching.Size = New System.Drawing.Size(56, 25)
        Me.lblWatching.TabIndex = 30
        Me.lblWatching.Text = "####"
        Me.toolTip.SetToolTip(Me.lblWatching, "Running total of all anime with 'Watching' status")
        '
        'lblTotalWatchingHeading
        '
        Me.lblTotalWatchingHeading.AutoSize = True
        Me.lblTotalWatchingHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalWatchingHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWatchingHeading.Location = New System.Drawing.Point(262, 89)
        Me.lblTotalWatchingHeading.Name = "lblTotalWatchingHeading"
        Me.lblTotalWatchingHeading.Size = New System.Drawing.Size(90, 25)
        Me.lblTotalWatchingHeading.TabIndex = 29
        Me.lblTotalWatchingHeading.Text = "Watching:"
        Me.toolTip.SetToolTip(Me.lblTotalWatchingHeading, "Running total of all anime with 'Watching' status")
        '
        'lblDropped
        '
        Me.lblDropped.AutoSize = True
        Me.lblDropped.BackColor = System.Drawing.Color.Transparent
        Me.lblDropped.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDropped.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDropped.Location = New System.Drawing.Point(596, 90)
        Me.lblDropped.Name = "lblDropped"
        Me.lblDropped.Size = New System.Drawing.Size(56, 25)
        Me.lblDropped.TabIndex = 28
        Me.lblDropped.Text = "####"
        Me.toolTip.SetToolTip(Me.lblDropped, "Running total for all anime with 'Dropped' status.")
        '
        'lblDroppedHeading
        '
        Me.lblDroppedHeading.AutoSize = True
        Me.lblDroppedHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblDroppedHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDroppedHeading.Location = New System.Drawing.Point(459, 88)
        Me.lblDroppedHeading.Name = "lblDroppedHeading"
        Me.lblDroppedHeading.Size = New System.Drawing.Size(89, 25)
        Me.lblDroppedHeading.TabIndex = 27
        Me.lblDroppedHeading.Text = "Dropped:"
        Me.toolTip.SetToolTip(Me.lblDroppedHeading, "Running total for all anime with 'Dropped' status.")
        '
        'lblOnHold
        '
        Me.lblOnHold.AutoSize = True
        Me.lblOnHold.BackColor = System.Drawing.Color.Transparent
        Me.lblOnHold.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnHold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOnHold.Location = New System.Drawing.Point(596, 57)
        Me.lblOnHold.Name = "lblOnHold"
        Me.lblOnHold.Size = New System.Drawing.Size(56, 25)
        Me.lblOnHold.TabIndex = 26
        Me.lblOnHold.Text = "####"
        Me.toolTip.SetToolTip(Me.lblOnHold, "Running total of all anime with 'On-Hold' status.")
        '
        'lblOnHoldHeading
        '
        Me.lblOnHoldHeading.AutoSize = True
        Me.lblOnHoldHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblOnHoldHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnHoldHeading.Location = New System.Drawing.Point(459, 59)
        Me.lblOnHoldHeading.Name = "lblOnHoldHeading"
        Me.lblOnHoldHeading.Size = New System.Drawing.Size(84, 25)
        Me.lblOnHoldHeading.TabIndex = 25
        Me.lblOnHoldHeading.Text = "On Hold:"
        Me.toolTip.SetToolTip(Me.lblOnHoldHeading, "Running total of all anime with 'On-Hold' status.")
        '
        'lblTotalAnime
        '
        Me.lblTotalAnime.AutoSize = True
        Me.lblTotalAnime.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAnime.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAnime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalAnime.Location = New System.Drawing.Point(390, 60)
        Me.lblTotalAnime.Name = "lblTotalAnime"
        Me.lblTotalAnime.Size = New System.Drawing.Size(56, 25)
        Me.lblTotalAnime.TabIndex = 24
        Me.lblTotalAnime.Text = "####"
        Me.toolTip.SetToolTip(Me.lblTotalAnime, "Running total of all anime on your list.")
        '
        'lblTotalAnimeHeading
        '
        Me.lblTotalAnimeHeading.AutoSize = True
        Me.lblTotalAnimeHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAnimeHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAnimeHeading.Location = New System.Drawing.Point(262, 59)
        Me.lblTotalAnimeHeading.Name = "lblTotalAnimeHeading"
        Me.lblTotalAnimeHeading.Size = New System.Drawing.Size(110, 25)
        Me.lblTotalAnimeHeading.TabIndex = 23
        Me.lblTotalAnimeHeading.Text = "Total Anime:"
        Me.toolTip.SetToolTip(Me.lblTotalAnimeHeading, "Running total of all anime on your list.")
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblId.Location = New System.Drawing.Point(101, 8)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(50, 21)
        Me.lblId.TabIndex = 22
        Me.lblId.Text = "####"
        Me.toolTip.SetToolTip(Me.lblId, "MAL User ID")
        '
        'lblUserIdHeading
        '
        Me.lblUserIdHeading.AutoSize = True
        Me.lblUserIdHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblUserIdHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserIdHeading.Location = New System.Drawing.Point(69, 5)
        Me.lblUserIdHeading.Name = "lblUserIdHeading"
        Me.lblUserIdHeading.Size = New System.Drawing.Size(33, 25)
        Me.lblUserIdHeading.TabIndex = 21
        Me.lblUserIdHeading.Text = "ID:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(262, 23)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(56, 25)
        Me.lblUserName.TabIndex = 20
        Me.lblUserName.Text = "####"
        Me.toolTip.SetToolTip(Me.lblUserName, "MAL Username.")
        '
        'lblPlanToWatch
        '
        Me.lblPlanToWatch.AutoSize = True
        Me.lblPlanToWatch.BackColor = System.Drawing.Color.Transparent
        Me.lblPlanToWatch.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanToWatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPlanToWatch.Location = New System.Drawing.Point(596, 120)
        Me.lblPlanToWatch.Name = "lblPlanToWatch"
        Me.lblPlanToWatch.Size = New System.Drawing.Size(56, 25)
        Me.lblPlanToWatch.TabIndex = 35
        Me.lblPlanToWatch.Text = "####"
        Me.toolTip.SetToolTip(Me.lblPlanToWatch, "Running total of all 'Plan To Watch' status anime.")
        '
        'lblPlanToWatchHeading
        '
        Me.lblPlanToWatchHeading.AutoSize = True
        Me.lblPlanToWatchHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblPlanToWatchHeading.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanToWatchHeading.Location = New System.Drawing.Point(459, 119)
        Me.lblPlanToWatchHeading.Name = "lblPlanToWatchHeading"
        Me.lblPlanToWatchHeading.Size = New System.Drawing.Size(126, 25)
        Me.lblPlanToWatchHeading.TabIndex = 34
        Me.lblPlanToWatchHeading.Text = "Plan To Watch:"
        Me.toolTip.SetToolTip(Me.lblPlanToWatchHeading, "Running total of all 'Plan To Watch' status anime.")
        '
        'pcbUserImage
        '
        Me.pcbUserImage.BackColor = System.Drawing.Color.Transparent
        Me.pcbUserImage.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.pcbUserImage.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.pcbUserImage.Location = New System.Drawing.Point(32, 32)
        Me.pcbUserImage.Name = "pcbUserImage"
        Me.pcbUserImage.Size = New System.Drawing.Size(188, 184)
        Me.pcbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbUserImage.TabIndex = 33
        Me.pcbUserImage.TabStop = False
        '
        'tbSettings
        '
        Me.tbSettings.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbSettings.Controls.Add(Me.chkPreviewDark)
        Me.tbSettings.Controls.Add(Me.gbxPreview)
        Me.tbSettings.Controls.Add(Me.Button1)
        Me.tbSettings.Controls.Add(Me.btnSaveSettings)
        Me.tbSettings.Controls.Add(Me.lblProgramSettings)
        Me.tbSettings.Controls.Add(Me.radDisabled)
        Me.tbSettings.Controls.Add(Me.radEnabled)
        Me.tbSettings.Controls.Add(Me.lblEDWebBrowser)
        Me.tbSettings.Controls.Add(Me.txtPath)
        Me.tbSettings.Controls.Add(Me.btnDefaultSave)
        Me.tbSettings.Controls.Add(Me.lblDefaultSave)
        Me.tbSettings.Controls.Add(Me.ddlFonts)
        Me.tbSettings.Controls.Add(Me.lblFont)
        Me.tbSettings.Controls.Add(Me.ddlThemes)
        Me.tbSettings.Controls.Add(Me.lblTheme)
        Me.tbSettings.Location = New System.Drawing.Point(4, 24)
        Me.tbSettings.Name = "tbSettings"
        Me.tbSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSettings.Size = New System.Drawing.Size(738, 445)
        Me.tbSettings.TabIndex = 1
        Me.tbSettings.Text = "Settings"
        '
        'pcbPreviewDark
        '
        Me.pcbPreviewDark.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbPreviewDark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbPreviewDark.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Purple_Dark
        Me.pcbPreviewDark.Location = New System.Drawing.Point(8, 21)
        Me.pcbPreviewDark.Name = "pcbPreviewDark"
        Me.pcbPreviewDark.Size = New System.Drawing.Size(469, 233)
        Me.pcbPreviewDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPreviewDark.TabIndex = 36
        Me.pcbPreviewDark.TabStop = False
        '
        'pcbPreviewLight
        '
        Me.pcbPreviewLight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbPreviewLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbPreviewLight.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Purple_Light
        Me.pcbPreviewLight.Location = New System.Drawing.Point(8, 22)
        Me.pcbPreviewLight.Name = "pcbPreviewLight"
        Me.pcbPreviewLight.Size = New System.Drawing.Size(469, 233)
        Me.pcbPreviewLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPreviewLight.TabIndex = 35
        Me.pcbPreviewLight.TabStop = False
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveSettings.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnSaveSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnSaveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSettings.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings.Location = New System.Drawing.Point(525, 387)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(85, 35)
        Me.btnSaveSettings.TabIndex = 33
        Me.btnSaveSettings.Text = "&Apply"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'lblProgramSettings
        '
        Me.lblProgramSettings.AutoSize = True
        Me.lblProgramSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblProgramSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramSettings.Location = New System.Drawing.Point(273, 8)
        Me.lblProgramSettings.Name = "lblProgramSettings"
        Me.lblProgramSettings.Size = New System.Drawing.Size(180, 30)
        Me.lblProgramSettings.TabIndex = 32
        Me.lblProgramSettings.Text = "Program Settings"
        '
        'radDisabled
        '
        Me.radDisabled.AutoSize = True
        Me.radDisabled.Location = New System.Drawing.Point(212, 54)
        Me.radDisabled.Name = "radDisabled"
        Me.radDisabled.Size = New System.Drawing.Size(70, 19)
        Me.radDisabled.TabIndex = 31
        Me.radDisabled.Text = "Disabled"
        Me.radDisabled.UseVisualStyleBackColor = True
        '
        'radEnabled
        '
        Me.radEnabled.AutoSize = True
        Me.radEnabled.Checked = True
        Me.radEnabled.Location = New System.Drawing.Point(143, 54)
        Me.radEnabled.Name = "radEnabled"
        Me.radEnabled.Size = New System.Drawing.Size(67, 19)
        Me.radEnabled.TabIndex = 30
        Me.radEnabled.TabStop = True
        Me.radEnabled.Text = "Enabled"
        Me.radEnabled.UseVisualStyleBackColor = True
        '
        'lblEDWebBrowser
        '
        Me.lblEDWebBrowser.AutoSize = True
        Me.lblEDWebBrowser.BackColor = System.Drawing.Color.Transparent
        Me.lblEDWebBrowser.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEDWebBrowser.Location = New System.Drawing.Point(12, 49)
        Me.lblEDWebBrowser.Name = "lblEDWebBrowser"
        Me.lblEDWebBrowser.Size = New System.Drawing.Size(126, 25)
        Me.lblEDWebBrowser.TabIndex = 29
        Me.lblEDWebBrowser.Text = "Web Services:"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(211, 99)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(440, 23)
        Me.txtPath.TabIndex = 28
        '
        'btnDefaultSave
        '
        Me.btnDefaultSave.Location = New System.Drawing.Point(657, 99)
        Me.btnDefaultSave.Name = "btnDefaultSave"
        Me.btnDefaultSave.Size = New System.Drawing.Size(29, 23)
        Me.btnDefaultSave.TabIndex = 27
        Me.btnDefaultSave.Text = "..."
        Me.btnDefaultSave.UseVisualStyleBackColor = True
        '
        'lblDefaultSave
        '
        Me.lblDefaultSave.AutoSize = True
        Me.lblDefaultSave.BackColor = System.Drawing.Color.Transparent
        Me.lblDefaultSave.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultSave.Location = New System.Drawing.Point(12, 95)
        Me.lblDefaultSave.Name = "lblDefaultSave"
        Me.lblDefaultSave.Size = New System.Drawing.Size(194, 25)
        Me.lblDefaultSave.TabIndex = 26
        Me.lblDefaultSave.Text = "Default Save Location:"
        '
        'ddlFonts
        '
        Me.ddlFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlFonts.FormattingEnabled = True
        Me.ddlFonts.Items.AddRange(New Object() {"Segoe UI Family", "San Serif Family", "Tahoma Faimly", "Times New Roman Family"})
        Me.ddlFonts.Location = New System.Drawing.Point(429, 151)
        Me.ddlFonts.Name = "ddlFonts"
        Me.ddlFonts.Size = New System.Drawing.Size(121, 23)
        Me.ddlFonts.TabIndex = 25
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.BackColor = System.Drawing.Color.Transparent
        Me.lblFont.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFont.Location = New System.Drawing.Point(371, 148)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(52, 25)
        Me.lblFont.TabIndex = 24
        Me.lblFont.Text = "Font:"
        '
        'ddlThemes
        '
        Me.ddlThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlThemes.FormattingEnabled = True
        Me.ddlThemes.Items.AddRange(New Object() {"Purple", "Blue", "Orange"})
        Me.ddlThemes.Location = New System.Drawing.Point(90, 147)
        Me.ddlThemes.Name = "ddlThemes"
        Me.ddlThemes.Size = New System.Drawing.Size(121, 23)
        Me.ddlThemes.TabIndex = 23
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.BackColor = System.Drawing.Color.Transparent
        Me.lblTheme.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheme.Location = New System.Drawing.Point(12, 146)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(72, 25)
        Me.lblTheme.TabIndex = 22
        Me.lblTheme.Text = "Theme:"
        '
        'tbUser
        '
        Me.tbUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbUser.Controls.Add(Me.ddlGraphSelection)
        Me.tbUser.Controls.Add(Me.chrtAnimeStatus)
        Me.tbUser.Controls.Add(Me.lblOtherStats)
        Me.tbUser.Controls.Add(Me.lblMeanScore)
        Me.tbUser.Controls.Add(Me.lblEpisodes)
        Me.tbUser.Controls.Add(Me.lblEpisodesHeader)
        Me.tbUser.Controls.Add(Me.lblMeanScoreHeader)
        Me.tbUser.Controls.Add(Me.pcbUserImage)
        Me.tbUser.Controls.Add(Me.lblUserName)
        Me.tbUser.Controls.Add(Me.lblPlanToWatch)
        Me.tbUser.Controls.Add(Me.lblUserIdHeading)
        Me.tbUser.Controls.Add(Me.lblPlanToWatchHeading)
        Me.tbUser.Controls.Add(Me.lblId)
        Me.tbUser.Controls.Add(Me.lblTotalAnimeHeading)
        Me.tbUser.Controls.Add(Me.lblCompleted)
        Me.tbUser.Controls.Add(Me.lblTotalAnime)
        Me.tbUser.Controls.Add(Me.lblCompletedHeading)
        Me.tbUser.Controls.Add(Me.lblOnHoldHeading)
        Me.tbUser.Controls.Add(Me.lblWatching)
        Me.tbUser.Controls.Add(Me.lblOnHold)
        Me.tbUser.Controls.Add(Me.lblTotalWatchingHeading)
        Me.tbUser.Controls.Add(Me.lblDroppedHeading)
        Me.tbUser.Controls.Add(Me.lblDropped)
        Me.tbUser.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUser.Location = New System.Drawing.Point(4, 24)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tbUser.Size = New System.Drawing.Size(738, 445)
        Me.tbUser.TabIndex = 0
        Me.tbUser.Text = "User Info"
        '
        'ddlGraphSelection
        '
        Me.ddlGraphSelection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddlGraphSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlGraphSelection.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlGraphSelection.FormattingEnabled = True
        Me.ddlGraphSelection.Items.AddRange(New Object() {"Anime Status", "Anime Ratings", "Anime Other"})
        Me.ddlGraphSelection.Location = New System.Drawing.Point(566, 410)
        Me.ddlGraphSelection.Name = "ddlGraphSelection"
        Me.ddlGraphSelection.Size = New System.Drawing.Size(140, 25)
        Me.ddlGraphSelection.TabIndex = 42
        '
        'chrtAnimeStatus
        '
        Me.chrtAnimeStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrtAnimeStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chrtAnimeStatus.BackImageTransparentColor = System.Drawing.Color.WhiteSmoke
        Me.chrtAnimeStatus.BackSecondaryColor = System.Drawing.Color.WhiteSmoke
        Me.chrtAnimeStatus.BorderlineColor = System.Drawing.Color.WhiteSmoke
        Me.chrtAnimeStatus.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisX.LabelStyle.Enabled = False
        ChartArea1.AxisX2.LabelStyle.Enabled = False
        ChartArea1.AxisY2.LabelStyle.Enabled = False
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
        Me.chrtAnimeStatus.Location = New System.Drawing.Point(-4, 222)
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
        Me.chrtAnimeStatus.Size = New System.Drawing.Size(746, 225)
        Me.chrtAnimeStatus.TabIndex = 41
        Me.chrtAnimeStatus.Text = "Anime"
        '
        'lblOtherStats
        '
        Me.lblOtherStats.AutoSize = True
        Me.lblOtherStats.BackColor = System.Drawing.Color.Transparent
        Me.lblOtherStats.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherStats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOtherStats.Location = New System.Drawing.Point(262, 157)
        Me.lblOtherStats.Name = "lblOtherStats"
        Me.lblOtherStats.Size = New System.Drawing.Size(102, 25)
        Me.lblOtherStats.TabIndex = 40
        Me.lblOtherStats.Text = "Other Stats"
        '
        'lblMeanScore
        '
        Me.lblMeanScore.AutoSize = True
        Me.lblMeanScore.BackColor = System.Drawing.Color.Transparent
        Me.lblMeanScore.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeanScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMeanScore.Location = New System.Drawing.Point(596, 191)
        Me.lblMeanScore.Name = "lblMeanScore"
        Me.lblMeanScore.Size = New System.Drawing.Size(56, 25)
        Me.lblMeanScore.TabIndex = 39
        Me.lblMeanScore.Text = "####"
        Me.toolTip.SetToolTip(Me.lblMeanScore, "Average of all rated anime on list.")
        '
        'lblEpisodes
        '
        Me.lblEpisodes.AutoSize = True
        Me.lblEpisodes.BackColor = System.Drawing.Color.Transparent
        Me.lblEpisodes.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEpisodes.Location = New System.Drawing.Point(390, 191)
        Me.lblEpisodes.Name = "lblEpisodes"
        Me.lblEpisodes.Size = New System.Drawing.Size(56, 25)
        Me.lblEpisodes.TabIndex = 38
        Me.lblEpisodes.Text = "####"
        Me.toolTip.SetToolTip(Me.lblEpisodes, "Running total of all watched anime episodes.")
        '
        'lblEpisodesHeader
        '
        Me.lblEpisodesHeader.AutoSize = True
        Me.lblEpisodesHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblEpisodesHeader.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisodesHeader.Location = New System.Drawing.Point(262, 191)
        Me.lblEpisodesHeader.Name = "lblEpisodesHeader"
        Me.lblEpisodesHeader.Size = New System.Drawing.Size(119, 25)
        Me.lblEpisodesHeader.TabIndex = 37
        Me.lblEpisodesHeader.Text = "Watched Eps:"
        Me.toolTip.SetToolTip(Me.lblEpisodesHeader, "Running total of all watched anime episodes.")
        '
        'lblMeanScoreHeader
        '
        Me.lblMeanScoreHeader.AutoSize = True
        Me.lblMeanScoreHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblMeanScoreHeader.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeanScoreHeader.Location = New System.Drawing.Point(459, 191)
        Me.lblMeanScoreHeader.Name = "lblMeanScoreHeader"
        Me.lblMeanScoreHeader.Size = New System.Drawing.Size(110, 25)
        Me.lblMeanScoreHeader.TabIndex = 36
        Me.lblMeanScoreHeader.Text = "Mean Score:"
        Me.toolTip.SetToolTip(Me.lblMeanScoreHeader, "Average of all rated anime on list.")
        '
        'tbUserInfo
        '
        Me.tbUserInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUserInfo.Controls.Add(Me.tbUser)
        Me.tbUserInfo.Controls.Add(Me.tbSettings)
        Me.tbUserInfo.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserInfo.Location = New System.Drawing.Point(-4, 33)
        Me.tbUserInfo.Name = "tbUserInfo"
        Me.tbUserInfo.SelectedIndex = 0
        Me.tbUserInfo.Size = New System.Drawing.Size(746, 473)
        Me.tbUserInfo.TabIndex = 37
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(657, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 25)
        Me.btnClose.TabIndex = 36
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(625, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 35)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "&Default"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbxPreview
        '
        Me.gbxPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPreview.Controls.Add(Me.pcbPreviewLight)
        Me.gbxPreview.Controls.Add(Me.pcbPreviewDark)
        Me.gbxPreview.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPreview.Location = New System.Drawing.Point(12, 178)
        Me.gbxPreview.Name = "gbxPreview"
        Me.gbxPreview.Size = New System.Drawing.Size(483, 261)
        Me.gbxPreview.TabIndex = 38
        Me.gbxPreview.TabStop = False
        Me.gbxPreview.Text = "Theme Preview"
        '
        'chkPreviewDark
        '
        Me.chkPreviewDark.AutoSize = True
        Me.chkPreviewDark.Location = New System.Drawing.Point(226, 151)
        Me.chkPreviewDark.Name = "chkPreviewDark"
        Me.chkPreviewDark.Size = New System.Drawing.Size(126, 19)
        Me.chkPreviewDark.TabIndex = 39
        Me.chkPreviewDark.Text = "Preview Dark Mode"
        Me.chkPreviewDark.UseVisualStyleBackColor = True
        '
        'frmUserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 501)
        Me.Controls.Add(Me.tbUserInfo)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(954, 730)
        Me.MinimumSize = New System.Drawing.Size(753, 540)
        Me.Name = "frmUserInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Anime Archive - User Info"
        CType(Me.pcbUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSettings.ResumeLayout(False)
        Me.tbSettings.PerformLayout()
        CType(Me.pcbPreviewDark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPreviewLight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbUser.ResumeLayout(False)
        Me.tbUser.PerformLayout()
        CType(Me.chrtAnimeStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbUserInfo.ResumeLayout(False)
        Me.gbxPreview.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCompleted As Label
    Friend WithEvents lblCompletedHeading As Label
    Friend WithEvents lblWatching As Label
    Friend WithEvents lblTotalWatchingHeading As Label
    Friend WithEvents lblDropped As Label
    Friend WithEvents lblDroppedHeading As Label
    Friend WithEvents lblOnHold As Label
    Friend WithEvents lblOnHoldHeading As Label
    Friend WithEvents lblTotalAnime As Label
    Friend WithEvents lblTotalAnimeHeading As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblUserIdHeading As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents pcbUserImage As PictureBox
    Friend WithEvents lblPlanToWatch As Label
    Friend WithEvents lblPlanToWatchHeading As Label
    Friend WithEvents tbSettings As TabPage
    Friend WithEvents tbUser As TabPage
    Friend WithEvents tbUserInfo As TabControl
    Friend WithEvents btnClose As Button
    Friend WithEvents lblProgramSettings As Label
    Friend WithEvents radDisabled As RadioButton
    Friend WithEvents radEnabled As RadioButton
    Friend WithEvents lblEDWebBrowser As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnDefaultSave As Button
    Friend WithEvents lblDefaultSave As Label
    Friend WithEvents ddlFonts As ComboBox
    Friend WithEvents lblFont As Label
    Friend WithEvents ddlThemes As ComboBox
    Friend WithEvents lblTheme As Label
    Friend WithEvents lblOtherStats As Label
    Friend WithEvents lblMeanScore As Label
    Friend WithEvents lblEpisodes As Label
    Friend WithEvents lblEpisodesHeader As Label
    Friend WithEvents lblMeanScoreHeader As Label
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents chrtAnimeStatus As DataVisualization.Charting.Chart
    Friend WithEvents ddlGraphSelection As ComboBox
    Friend WithEvents pcbPreviewLight As PictureBox
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents pcbPreviewDark As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents gbxPreview As GroupBox
    Friend WithEvents chkPreviewDark As CheckBox
End Class