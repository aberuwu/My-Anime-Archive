<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSortWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSortWindow))
        Me.SortSettings = New System.Windows.Forms.TabPage()
        Me.mtddlSecCrit = New MetroFramework.Controls.MetroComboBox()
        Me.mtddlPrimCrit = New MetroFramework.Controls.MetroComboBox()
        Me.lblPlanToWatch = New System.Windows.Forms.Label()
        Me.lblDropped = New System.Windows.Forms.Label()
        Me.lblOnHold = New System.Windows.Forms.Label()
        Me.lblCompleted = New System.Windows.Forms.Label()
        Me.lblWatching = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLegendHeader = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSecDesc = New System.Windows.Forms.RadioButton()
        Me.radSecAsc = New System.Windows.Forms.RadioButton()
        Me.gbxPrimary = New System.Windows.Forms.GroupBox()
        Me.radPrimDesc = New System.Windows.Forms.RadioButton()
        Me.radPrimAsc = New System.Windows.Forms.RadioButton()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.ddlSecCrit = New System.Windows.Forms.ComboBox()
        Me.ddlPrimCrit = New System.Windows.Forms.ComboBox()
        Me.lblFilterCriteria = New System.Windows.Forms.Label()
        Me.lblSortCriteria = New System.Windows.Forms.Label()
        Me.tabSettings = New System.Windows.Forms.TabControl()
        Me.SortSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxPrimary.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'SortSettings
        '
        Me.SortSettings.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SortSettings.Controls.Add(Me.mtddlSecCrit)
        Me.SortSettings.Controls.Add(Me.mtddlPrimCrit)
        Me.SortSettings.Controls.Add(Me.lblPlanToWatch)
        Me.SortSettings.Controls.Add(Me.lblDropped)
        Me.SortSettings.Controls.Add(Me.lblOnHold)
        Me.SortSettings.Controls.Add(Me.lblCompleted)
        Me.SortSettings.Controls.Add(Me.lblWatching)
        Me.SortSettings.Controls.Add(Me.Label6)
        Me.SortSettings.Controls.Add(Me.Label5)
        Me.SortSettings.Controls.Add(Me.Label4)
        Me.SortSettings.Controls.Add(Me.Label3)
        Me.SortSettings.Controls.Add(Me.Label2)
        Me.SortSettings.Controls.Add(Me.lblLegendHeader)
        Me.SortSettings.Controls.Add(Me.GroupBox1)
        Me.SortSettings.Controls.Add(Me.gbxPrimary)
        Me.SortSettings.Controls.Add(Me.btnApply)
        Me.SortSettings.Controls.Add(Me.ddlSecCrit)
        Me.SortSettings.Controls.Add(Me.ddlPrimCrit)
        Me.SortSettings.Controls.Add(Me.lblFilterCriteria)
        Me.SortSettings.Controls.Add(Me.lblSortCriteria)
        Me.SortSettings.Location = New System.Drawing.Point(4, 26)
        Me.SortSettings.Name = "SortSettings"
        Me.SortSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.SortSettings.Size = New System.Drawing.Size(537, 272)
        Me.SortSettings.TabIndex = 0
        Me.SortSettings.Text = "Anime list sort and filter criteria"
        '
        'mtddlSecCrit
        '
        Me.mtddlSecCrit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtddlSecCrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtddlSecCrit.FormattingEnabled = True
        Me.mtddlSecCrit.ItemHeight = 23
        Me.mtddlSecCrit.Items.AddRange(New Object() {"-No Filter-", "Watching", "Completed", "On-Hold", "Dropped", "Plan to Watch"})
        Me.mtddlSecCrit.Location = New System.Drawing.Point(166, 79)
        Me.mtddlSecCrit.Name = "mtddlSecCrit"
        Me.mtddlSecCrit.Size = New System.Drawing.Size(121, 29)
        Me.mtddlSecCrit.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtddlSecCrit.TabIndex = 108
        Me.mtddlSecCrit.UseCustomBackColor = True
        Me.mtddlSecCrit.UseSelectable = True
        '
        'mtddlPrimCrit
        '
        Me.mtddlPrimCrit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtddlPrimCrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtddlPrimCrit.FormattingEnabled = True
        Me.mtddlPrimCrit.ItemHeight = 23
        Me.mtddlPrimCrit.Items.AddRange(New Object() {"Status", "Rating", "Anime Title", "Watched Episodes"})
        Me.mtddlPrimCrit.Location = New System.Drawing.Point(166, 22)
        Me.mtddlPrimCrit.Name = "mtddlPrimCrit"
        Me.mtddlPrimCrit.Size = New System.Drawing.Size(121, 29)
        Me.mtddlPrimCrit.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtddlPrimCrit.TabIndex = 107
        Me.mtddlPrimCrit.UseCustomBackColor = True
        Me.mtddlPrimCrit.UseCustomForeColor = True
        Me.mtddlPrimCrit.UseSelectable = True
        '
        'lblPlanToWatch
        '
        Me.lblPlanToWatch.AutoSize = True
        Me.lblPlanToWatch.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanToWatch.Location = New System.Drawing.Point(269, 171)
        Me.lblPlanToWatch.Name = "lblPlanToWatch"
        Me.lblPlanToWatch.Size = New System.Drawing.Size(93, 20)
        Me.lblPlanToWatch.TabIndex = 21
        Me.lblPlanToWatch.Text = "Plan to Watch"
        '
        'lblDropped
        '
        Me.lblDropped.AutoSize = True
        Me.lblDropped.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDropped.Location = New System.Drawing.Point(162, 209)
        Me.lblDropped.Name = "lblDropped"
        Me.lblDropped.Size = New System.Drawing.Size(64, 20)
        Me.lblDropped.TabIndex = 20
        Me.lblDropped.Text = "Dropped"
        '
        'lblOnHold
        '
        Me.lblOnHold.AutoSize = True
        Me.lblOnHold.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnHold.Location = New System.Drawing.Point(162, 171)
        Me.lblOnHold.Name = "lblOnHold"
        Me.lblOnHold.Size = New System.Drawing.Size(63, 20)
        Me.lblOnHold.TabIndex = 19
        Me.lblOnHold.Text = "On-Hold"
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompleted.Location = New System.Drawing.Point(42, 209)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Size = New System.Drawing.Size(77, 20)
        Me.lblCompleted.TabIndex = 18
        Me.lblCompleted.Text = "Completed"
        '
        'lblWatching
        '
        Me.lblWatching.AutoSize = True
        Me.lblWatching.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatching.Location = New System.Drawing.Point(41, 171)
        Me.lblWatching.Name = "lblWatching"
        Me.lblWatching.Size = New System.Drawing.Size(66, 20)
        Me.lblWatching.TabIndex = 17
        Me.lblWatching.Text = "Watching"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(241, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "█"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(135, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "█"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(135, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "█"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "█"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "█"
        '
        'lblLegendHeader
        '
        Me.lblLegendHeader.AutoSize = True
        Me.lblLegendHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegendHeader.Location = New System.Drawing.Point(14, 134)
        Me.lblLegendHeader.Name = "lblLegendHeader"
        Me.lblLegendHeader.Size = New System.Drawing.Size(114, 21)
        Me.lblLegendHeader.TabIndex = 11
        Me.lblLegendHeader.Text = "Status Legend"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSecDesc)
        Me.GroupBox1.Controls.Add(Me.radSecAsc)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(311, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 45)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'radSecDesc
        '
        Me.radSecDesc.AutoSize = True
        Me.radSecDesc.Location = New System.Drawing.Point(100, 19)
        Me.radSecDesc.Name = "radSecDesc"
        Me.radSecDesc.Size = New System.Drawing.Size(91, 21)
        Me.radSecDesc.TabIndex = 8
        Me.radSecDesc.TabStop = True
        Me.radSecDesc.Text = "Descending"
        Me.radSecDesc.UseVisualStyleBackColor = True
        '
        'radSecAsc
        '
        Me.radSecAsc.AutoSize = True
        Me.radSecAsc.Location = New System.Drawing.Point(13, 17)
        Me.radSecAsc.Name = "radSecAsc"
        Me.radSecAsc.Size = New System.Drawing.Size(83, 21)
        Me.radSecAsc.TabIndex = 6
        Me.radSecAsc.TabStop = True
        Me.radSecAsc.Text = "Ascending"
        Me.radSecAsc.UseVisualStyleBackColor = True
        '
        'gbxPrimary
        '
        Me.gbxPrimary.Controls.Add(Me.radPrimDesc)
        Me.gbxPrimary.Controls.Add(Me.radPrimAsc)
        Me.gbxPrimary.Location = New System.Drawing.Point(312, 11)
        Me.gbxPrimary.Name = "gbxPrimary"
        Me.gbxPrimary.Size = New System.Drawing.Size(207, 45)
        Me.gbxPrimary.TabIndex = 9
        Me.gbxPrimary.TabStop = False
        '
        'radPrimDesc
        '
        Me.radPrimDesc.AutoSize = True
        Me.radPrimDesc.Location = New System.Drawing.Point(104, 17)
        Me.radPrimDesc.Name = "radPrimDesc"
        Me.radPrimDesc.Size = New System.Drawing.Size(91, 21)
        Me.radPrimDesc.TabIndex = 7
        Me.radPrimDesc.Text = "Descending"
        Me.radPrimDesc.UseVisualStyleBackColor = True
        '
        'radPrimAsc
        '
        Me.radPrimAsc.AutoSize = True
        Me.radPrimAsc.Checked = True
        Me.radPrimAsc.Location = New System.Drawing.Point(13, 17)
        Me.radPrimAsc.Name = "radPrimAsc"
        Me.radPrimAsc.Size = New System.Drawing.Size(83, 21)
        Me.radPrimAsc.TabIndex = 5
        Me.radPrimAsc.TabStop = True
        Me.radPrimAsc.Text = "Ascending"
        Me.radPrimAsc.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(424, 200)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(95, 35)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "&Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'ddlSecCrit
        '
        Me.ddlSecCrit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSecCrit.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlSecCrit.FormattingEnabled = True
        Me.ddlSecCrit.Items.AddRange(New Object() {"-No Filter-", "Watching", "Completed", "On-Hold", "Dropped", "Plan to Watch"})
        Me.ddlSecCrit.Location = New System.Drawing.Point(166, 80)
        Me.ddlSecCrit.Name = "ddlSecCrit"
        Me.ddlSecCrit.Size = New System.Drawing.Size(121, 25)
        Me.ddlSecCrit.TabIndex = 3
        '
        'ddlPrimCrit
        '
        Me.ddlPrimCrit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlPrimCrit.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlPrimCrit.FormattingEnabled = True
        Me.ddlPrimCrit.Items.AddRange(New Object() {"Status", "Rating", "Anime Title", "Watched Episodes"})
        Me.ddlPrimCrit.Location = New System.Drawing.Point(166, 23)
        Me.ddlPrimCrit.Name = "ddlPrimCrit"
        Me.ddlPrimCrit.Size = New System.Drawing.Size(121, 25)
        Me.ddlPrimCrit.TabIndex = 2
        '
        'lblFilterCriteria
        '
        Me.lblFilterCriteria.AutoSize = True
        Me.lblFilterCriteria.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterCriteria.Location = New System.Drawing.Point(13, 80)
        Me.lblFilterCriteria.Name = "lblFilterCriteria"
        Me.lblFilterCriteria.Size = New System.Drawing.Size(117, 25)
        Me.lblFilterCriteria.TabIndex = 1
        Me.lblFilterCriteria.Text = "Filter Criteria:"
        '
        'lblSortCriteria
        '
        Me.lblSortCriteria.AutoSize = True
        Me.lblSortCriteria.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortCriteria.Location = New System.Drawing.Point(13, 23)
        Me.lblSortCriteria.Name = "lblSortCriteria"
        Me.lblSortCriteria.Size = New System.Drawing.Size(111, 25)
        Me.lblSortCriteria.TabIndex = 0
        Me.lblSortCriteria.Text = "Sort Criteria:"
        '
        'tabSettings
        '
        Me.tabSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSettings.Controls.Add(Me.SortSettings)
        Me.tabSettings.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSettings.Location = New System.Drawing.Point(-5, 27)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.SelectedIndex = 0
        Me.tabSettings.Size = New System.Drawing.Size(545, 302)
        Me.tabSettings.TabIndex = 0
        '
        'frmSortWindow
        '
        Me.AcceptButton = Me.btnApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(536, 294)
        Me.Controls.Add(Me.tabSettings)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(552, 333)
        Me.MinimumSize = New System.Drawing.Size(552, 333)
        Me.Name = "frmSortWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sort & Filter"
        Me.SortSettings.ResumeLayout(False)
        Me.SortSettings.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxPrimary.ResumeLayout(False)
        Me.gbxPrimary.PerformLayout()
        Me.tabSettings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SortSettings As TabPage
    Friend WithEvents tabSettings As TabControl
    Friend WithEvents lblFilterCriteria As Label
    Friend WithEvents lblSortCriteria As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents ddlSecCrit As ComboBox
    Friend WithEvents ddlPrimCrit As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSecDesc As RadioButton
    Friend WithEvents radSecAsc As RadioButton
    Friend WithEvents gbxPrimary As GroupBox
    Friend WithEvents radPrimDesc As RadioButton
    Friend WithEvents radPrimAsc As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLegendHeader As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPlanToWatch As Label
    Friend WithEvents lblDropped As Label
    Friend WithEvents lblOnHold As Label
    Friend WithEvents lblCompleted As Label
    Friend WithEvents lblWatching As Label
    Friend WithEvents mtddlSecCrit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mtddlPrimCrit As MetroFramework.Controls.MetroComboBox
End Class
