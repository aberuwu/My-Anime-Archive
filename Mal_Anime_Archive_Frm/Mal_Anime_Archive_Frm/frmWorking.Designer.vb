<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Saving
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Saving))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bcwSavingFile = New System.ComponentModel.BackgroundWorker()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-3, 68)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(424, 22)
        Me.ProgressBar1.TabIndex = 0
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.BackColor = System.Drawing.Color.Transparent
        Me.lblPath.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.ForeColor = System.Drawing.Color.White
        Me.lblPath.Location = New System.Drawing.Point(12, 22)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(137, 17)
        Me.lblPath.TabIndex = 1
        Me.lblPath.Text = "Saving [File] to [Path]..."
        '
        'Timer1
        '
        '
        'bcwSavingFile
        '
        Me.bcwSavingFile.WorkerReportsProgress = True
        Me.bcwSavingFile.WorkerSupportsCancellation = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(321, 16)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 35)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "&Continue"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Saving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(418, 78)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblPath)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Saving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWorking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblPath As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bcwSavingFile As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnClose As Button
End Class
