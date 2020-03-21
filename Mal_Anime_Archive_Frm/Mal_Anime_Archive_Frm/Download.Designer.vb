<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Download
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
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblImportProg = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'btnDownload
        '
        Me.btnDownload.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDownload.Location = New System.Drawing.Point(99, 105)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(124, 33)
        Me.btnDownload.TabIndex = 2
        Me.btnDownload.Text = "Download List"
        Me.btnDownload.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.Location = New System.Drawing.Point(250, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Manually Add Anime"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(85, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 51)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Import your anime list?"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"You can download and import your anime list from"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"MyAnim"& _ 
    "eLIst.net"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblImportProg
        '
        Me.lblImportProg.BackColor = System.Drawing.Color.Transparent
        Me.lblImportProg.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblImportProg.ForeColor = System.Drawing.Color.Black
        Me.lblImportProg.Location = New System.Drawing.Point(85, 141)
        Me.lblImportProg.Name = "lblImportProg"
        Me.lblImportProg.Size = New System.Drawing.Size(273, 51)
        Me.lblImportProg.TabIndex = 5
        Me.lblImportProg.Text = "Importing List... (?/?)"
        Me.lblImportProg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblImportProg.Visible = false
        '
        'Download
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 179)
        Me.Controls.Add(Me.lblImportProg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDownload)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Download"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Anime List"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnDownload As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblImportProg As Label
End Class
