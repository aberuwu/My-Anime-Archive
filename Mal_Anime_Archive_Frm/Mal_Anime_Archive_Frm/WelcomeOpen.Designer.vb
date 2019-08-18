<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeOpen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeOpen))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnChooseFile = New System.Windows.Forms.Button()
        Me.lblTutorialLink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.llbGitHub = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnNewList = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        resources.ApplyResources(Me.lblWelcome, "lblWelcome")
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWelcome.Name = "lblWelcome"
        '
        'btnChooseFile
        '
        Me.btnChooseFile.BackColor = System.Drawing.Color.Transparent
        Me.btnChooseFile.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnChooseFile.FlatAppearance.BorderSize = 2
        Me.btnChooseFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnChooseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        resources.ApplyResources(Me.btnChooseFile, "btnChooseFile")
        Me.btnChooseFile.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnChooseFile.Name = "btnChooseFile"
        Me.btnChooseFile.UseVisualStyleBackColor = False
        '
        'lblTutorialLink
        '
        Me.lblTutorialLink.ActiveLinkColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblTutorialLink, "lblTutorialLink")
        Me.lblTutorialLink.BackColor = System.Drawing.Color.Transparent
        Me.lblTutorialLink.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTutorialLink.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.lblTutorialLink.Name = "lblTutorialLink"
        Me.lblTutorialLink.TabStop = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Love
        Me.PictureBox1.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Love
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnContinue, "btnContinue")
        Me.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnContinue.FlatAppearance.BorderSize = 2
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnContinue.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Name = "Label1"
        '
        'llbGitHub
        '
        Me.llbGitHub.ActiveLinkColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.llbGitHub, "llbGitHub")
        Me.llbGitHub.BackColor = System.Drawing.Color.Transparent
        Me.llbGitHub.ForeColor = System.Drawing.SystemColors.Control
        Me.llbGitHub.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.llbGitHub.Name = "llbGitHub"
        Me.llbGitHub.TabStop = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.MAA_logo_White
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'btnNewList
        '
        Me.btnNewList.BackColor = System.Drawing.Color.Transparent
        Me.btnNewList.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnNewList.FlatAppearance.BorderSize = 2
        Me.btnNewList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnNewList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        resources.ApplyResources(Me.btnNewList, "btnNewList")
        Me.btnNewList.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNewList.Name = "btnNewList"
        Me.btnNewList.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Name = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'WelcomeOpen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewList)
        Me.Controls.Add(Me.llbGitHub)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblTutorialLink)
        Me.Controls.Add(Me.btnChooseFile)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WelcomeOpen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnChooseFile As Button
    Friend WithEvents lblTutorialLink As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents llbGitHub As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnNewList As Button
    Friend WithEvents btnExit As Button
End Class
