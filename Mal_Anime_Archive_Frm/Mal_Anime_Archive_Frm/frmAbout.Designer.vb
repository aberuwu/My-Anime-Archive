<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.gbxAbout = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.rtxtAboutMessage = New System.Windows.Forms.RichTextBox()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxAbout.SuspendLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxAbout
        '
        Me.gbxAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxAbout.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbxAbout.Controls.Add(Me.btnSave)
        Me.gbxAbout.Controls.Add(Me.rtxtAboutMessage)
        Me.gbxAbout.Controls.Add(Me.pcbLogo)
        Me.gbxAbout.Location = New System.Drawing.Point(-2, 54)
        Me.gbxAbout.Name = "gbxAbout"
        Me.gbxAbout.Size = New System.Drawing.Size(726, 405)
        Me.gbxAbout.TabIndex = 0
        Me.gbxAbout.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(52, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "&Exit"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'rtxtAboutMessage
        '
        Me.rtxtAboutMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtAboutMessage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtxtAboutMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtAboutMessage.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtAboutMessage.Location = New System.Drawing.Point(197, 21)
        Me.rtxtAboutMessage.Name = "rtxtAboutMessage"
        Me.rtxtAboutMessage.ReadOnly = True
        Me.rtxtAboutMessage.Size = New System.Drawing.Size(476, 356)
        Me.rtxtAboutMessage.TabIndex = 0
        Me.rtxtAboutMessage.Text = resources.GetString("rtxtAboutMessage.Text")
        '
        'pcbLogo
        '
        Me.pcbLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pcbLogo.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Chibi1
        Me.pcbLogo.Location = New System.Drawing.Point(27, 37)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Size = New System.Drawing.Size(183, 268)
        Me.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbLogo.TabIndex = 1
        Me.pcbLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(200, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "About My Anime Archive"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(677, 444)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxAbout)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Anime Archive - About"
        Me.gbxAbout.ResumeLayout(False)
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxAbout As GroupBox
    Friend WithEvents rtxtAboutMessage As RichTextBox
    Friend WithEvents pcbLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
End Class
