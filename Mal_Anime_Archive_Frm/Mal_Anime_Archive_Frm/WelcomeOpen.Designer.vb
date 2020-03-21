<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeOpen
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
        Me.mtlstvOpenRecent = New System.Windows.Forms.ListView()
        Me.fileName = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.pcbLoading = New MetroFramework.Controls.MetroProgressBar()
        Me.backWork = New System.ComponentModel.BackgroundWorker()
        Me.btnDownload = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
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
        Me.btnChooseFile.UseVisualStyleBackColor = false
        '
        'lblTutorialLink
        '
        Me.lblTutorialLink.ActiveLinkColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.lblTutorialLink, "lblTutorialLink")
        Me.lblTutorialLink.BackColor = System.Drawing.Color.Transparent
        Me.lblTutorialLink.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTutorialLink.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.lblTutorialLink.Name = "lblTutorialLink"
        Me.lblTutorialLink.TabStop = true
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Chibi3
        Me.PictureBox1.InitialImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.Love
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = false
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
        Me.btnContinue.UseVisualStyleBackColor = false
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
        Me.llbGitHub.TabStop = true
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.MAA_logo_White
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = false
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
        Me.btnNewList.UseVisualStyleBackColor = false
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
        Me.btnExit.UseVisualStyleBackColor = false
        '
        'mtlstvOpenRecent
        '
        resources.ApplyResources(Me.mtlstvOpenRecent, "mtlstvOpenRecent")
        Me.mtlstvOpenRecent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtlstvOpenRecent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtlstvOpenRecent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.fileName})
        Me.mtlstvOpenRecent.FullRowSelect = true
        Me.mtlstvOpenRecent.HideSelection = false
        Me.mtlstvOpenRecent.Name = "mtlstvOpenRecent"
        Me.mtlstvOpenRecent.OwnerDraw = true
        Me.mtlstvOpenRecent.UseCompatibleStateImageBehavior = false
        Me.mtlstvOpenRecent.View = System.Windows.Forms.View.Details
        '
        'fileName
        '
        resources.ApplyResources(Me.fileName, "fileName")
        '
        'pcbLoading
        '
        resources.ApplyResources(Me.pcbLoading, "pcbLoading")
        Me.pcbLoading.Maximum = 7
        Me.pcbLoading.Name = "pcbLoading"
        Me.pcbLoading.Step = 1
        Me.pcbLoading.Style = MetroFramework.MetroColorStyle.Purple
        Me.pcbLoading.Value = 7
        '
        'backWork
        '
        Me.backWork.WorkerReportsProgress = true
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.Transparent
        Me.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnDownload.FlatAppearance.BorderSize = 2
        Me.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        resources.ApplyResources(Me.btnDownload, "btnDownload")
        Me.btnDownload.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.UseVisualStyleBackColor = false
        '
        'WelcomeOpen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.pcbLoading)
        Me.Controls.Add(Me.mtlstvOpenRecent)
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
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WelcomeOpen"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

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
    Friend WithEvents fileName As ColumnHeader
    Friend WithEvents pcbLoading As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents backWork As System.ComponentModel.BackgroundWorker
    Friend WithEvents mtlstvOpenRecent As ListView
    Friend WithEvents btnDownload As Button
End Class
