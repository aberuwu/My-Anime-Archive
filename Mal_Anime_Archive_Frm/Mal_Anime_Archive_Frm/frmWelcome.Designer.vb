<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnkChangeLog = New System.Windows.Forms.LinkLabel()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.pcbUserImage = New System.Windows.Forms.PictureBox()
        CType(Me.pcbUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWelcome.Location = New System.Drawing.Point(155, 37)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(89, 25)
        Me.lblWelcome.TabIndex = 35
        Me.lblWelcome.Text = "Welcome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(203, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 39)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "        My Anime Archive v1.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Programmed by Cesar Mendoza " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 @ab" &
    "eruwu"
        '
        'lnkChangeLog
        '
        Me.lnkChangeLog.AutoSize = True
        Me.lnkChangeLog.BackColor = System.Drawing.Color.Transparent
        Me.lnkChangeLog.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkChangeLog.LinkColor = System.Drawing.Color.White
        Me.lnkChangeLog.Location = New System.Drawing.Point(241, 95)
        Me.lnkChangeLog.Name = "lnkChangeLog"
        Me.lnkChangeLog.Size = New System.Drawing.Size(87, 13)
        Me.lnkChangeLog.TabIndex = 37
        Me.lnkChangeLog.TabStop = True
        Me.lnkChangeLog.Text = "Vew Change Log"
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Transparent
        Me.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnContinue.FlatAppearance.BorderSize = 2
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnContinue.Location = New System.Drawing.Point(348, 26)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(90, 46)
        Me.btnContinue.TabIndex = 38
        Me.btnContinue.Text = "&Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'pcbUserImage
        '
        Me.pcbUserImage.BackColor = System.Drawing.Color.Transparent
        Me.pcbUserImage.Location = New System.Drawing.Point(12, 12)
        Me.pcbUserImage.Name = "pcbUserImage"
        Me.pcbUserImage.Size = New System.Drawing.Size(133, 123)
        Me.pcbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbUserImage.TabIndex = 34
        Me.pcbUserImage.TabStop = False
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(453, 153)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lnkChangeLog)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.pcbUserImage)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(469, 192)
        Me.MinimumSize = New System.Drawing.Size(469, 192)
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "My Anime Archive - Welcome!"
        CType(Me.pcbUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbUserImage As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lnkChangeLog As LinkLabel
    Friend WithEvents btnContinue As Button
End Class
