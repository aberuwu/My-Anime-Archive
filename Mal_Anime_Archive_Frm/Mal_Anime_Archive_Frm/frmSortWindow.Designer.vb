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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
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
        Me.SortSettings.Controls.Add(Me.Label11)
        Me.SortSettings.Controls.Add(Me.Label10)
        Me.SortSettings.Controls.Add(Me.Label9)
        Me.SortSettings.Controls.Add(Me.Label8)
        Me.SortSettings.Controls.Add(Me.Label7)
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
        Me.SortSettings.Controls.Add(Me.Label1)
        Me.SortSettings.Controls.Add(Me.lblStatus)
        Me.SortSettings.Location = New System.Drawing.Point(4, 26)
        Me.SortSettings.Name = "SortSettings"
        Me.SortSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.SortSettings.Size = New System.Drawing.Size(537, 272)
        Me.SortSettings.TabIndex = 0
        Me.SortSettings.Text = "Anime list sort and filter criteria"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(269, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Plan to Watch"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(162, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Dropped"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(162, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "On-Hold"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Completed"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Watching"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filter Criteria:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(13, 23)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(111, 25)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Sort Criteria:"
        '
        'tabSettings
        '
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
        Me.ClientSize = New System.Drawing.Size(536, 296)
        Me.Controls.Add(Me.tabSettings)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(552, 335)
        Me.MinimumSize = New System.Drawing.Size(552, 335)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus As Label
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
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
