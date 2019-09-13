<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSave))
        Me.gbxSave = New System.Windows.Forms.GroupBox()
        Me.txtPreview = New System.Windows.Forms.RichTextBox()
        Me.lblSqlDescription = New System.Windows.Forms.Label()
        Me.btnSaveJson = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCSVDescription = New System.Windows.Forms.Label()
        Me.lblXMLDescription = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnXML = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.gbxSave.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxSave
        '
        Me.gbxSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbxSave.Controls.Add(Me.txtPreview)
        Me.gbxSave.Controls.Add(Me.lblSqlDescription)
        Me.gbxSave.Controls.Add(Me.btnSaveJson)
        Me.gbxSave.Controls.Add(Me.btnCancel)
        Me.gbxSave.Controls.Add(Me.lblCSVDescription)
        Me.gbxSave.Controls.Add(Me.lblXMLDescription)
        Me.gbxSave.Controls.Add(Me.btnExcel)
        Me.gbxSave.Controls.Add(Me.btnXML)
        Me.gbxSave.Location = New System.Drawing.Point(0, 66)
        Me.gbxSave.Name = "gbxSave"
        Me.gbxSave.Size = New System.Drawing.Size(539, 459)
        Me.gbxSave.TabIndex = 0
        Me.gbxSave.TabStop = False
        '
        'txtPreview
        '
        Me.txtPreview.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPreview.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreview.Location = New System.Drawing.Point(531, 7)
        Me.txtPreview.Name = "txtPreview"
        Me.txtPreview.ReadOnly = True
        Me.txtPreview.Size = New System.Drawing.Size(340, 445)
        Me.txtPreview.TabIndex = 7
        Me.txtPreview.Text = ""
        Me.txtPreview.WordWrap = False
        '
        'lblSqlDescription
        '
        Me.lblSqlDescription.AutoSize = True
        Me.lblSqlDescription.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSqlDescription.Location = New System.Drawing.Point(168, 191)
        Me.lblSqlDescription.Name = "lblSqlDescription"
        Me.lblSqlDescription.Size = New System.Drawing.Size(250, 15)
        Me.lblSqlDescription.TabIndex = 6
        Me.lblSqlDescription.Text = "Export as JavaScript Object Notation (.json) file"
        '
        'btnSaveJson
        '
        Me.btnSaveJson.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.json_icon
        Me.btnSaveJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSaveJson.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnSaveJson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnSaveJson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnSaveJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveJson.Location = New System.Drawing.Point(45, 163)
        Me.btnSaveJson.Name = "btnSaveJson"
        Me.btnSaveJson.Size = New System.Drawing.Size(117, 101)
        Me.btnSaveJson.TabIndex = 5
        Me.btnSaveJson.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(211, 406)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 38)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "C&lose"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblCSVDescription
        '
        Me.lblCSVDescription.AutoSize = True
        Me.lblCSVDescription.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCSVDescription.Location = New System.Drawing.Point(168, 313)
        Me.lblCSVDescription.Name = "lblCSVDescription"
        Me.lblCSVDescription.Size = New System.Drawing.Size(331, 45)
        Me.lblCSVDescription.TabIndex = 3
        Me.lblCSVDescription.Text = "Export as an Excel readable comma-separated values (.csv) file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be used and " &
    "imported into an excel spread sheet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Access database"
        '
        'lblXMLDescription
        '
        Me.lblXMLDescription.AutoSize = True
        Me.lblXMLDescription.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXMLDescription.Location = New System.Drawing.Point(168, 55)
        Me.lblXMLDescription.Name = "lblXMLDescription"
        Me.lblXMLDescription.Size = New System.Drawing.Size(299, 45)
        Me.lblXMLDescription.TabIndex = 2
        Me.lblXMLDescription.Text = "Export as Extensible Markup Language (.xml) file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Can be used in My Anime List o" &
    "r reused in this program." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Also useful for web based database use"
        '
        'btnExcel
        '
        Me.btnExcel.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Excel_purple_ico
        Me.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Location = New System.Drawing.Point(45, 287)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(117, 101)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnXML
        '
        Me.btnXML.BackColor = System.Drawing.Color.Transparent
        Me.btnXML.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.xml_purple_ico
        Me.btnXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnXML.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXML.Location = New System.Drawing.Point(45, 32)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Size = New System.Drawing.Size(117, 101)
        Me.btnXML.TabIndex = 0
        Me.btnXML.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(164, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Choose Format"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.BackColor = System.Drawing.Color.Transparent
        Me.lblPreview.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.ForeColor = System.Drawing.Color.DimGray
        Me.lblPreview.Location = New System.Drawing.Point(675, 18)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(169, 30)
        Me.lblPreview.TabIndex = 2
        Me.lblPreview.Text = "Format Preview" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(531, 519)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbxSave)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(547, 558)
        Me.MinimumSize = New System.Drawing.Size(547, 558)
        Me.Name = "frmSave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Anime Archive - Save List"
        Me.gbxSave.ResumeLayout(False)
        Me.gbxSave.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxSave As GroupBox
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnXML As Button
    Friend WithEvents lblCSVDescription As Label
    Friend WithEvents lblXMLDescription As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveJson As Button
    Friend WithEvents lblSqlDescription As Label
    Friend WithEvents txtPreview As RichTextBox
    Friend WithEvents lblPreview As Label
End Class
