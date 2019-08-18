<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmError))
        Me.gbxError = New System.Windows.Forms.GroupBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnTryAgain = New System.Windows.Forms.Button()
        Me.pcbErrorSorry = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxError.SuspendLayout()
        CType(Me.pcbErrorSorry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxError
        '
        Me.gbxError.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbxError.Controls.Add(Me.btnContinue)
        Me.gbxError.Controls.Add(Me.btnTryAgain)
        Me.gbxError.Controls.Add(Me.pcbErrorSorry)
        Me.gbxError.Controls.Add(Me.lblMessage)
        Me.gbxError.Location = New System.Drawing.Point(-1, 55)
        Me.gbxError.Name = "gbxError"
        Me.gbxError.Size = New System.Drawing.Size(611, 291)
        Me.gbxError.TabIndex = 0
        Me.gbxError.TabStop = False
        '
        'btnContinue
        '
        Me.btnContinue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
        Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(318, 204)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(95, 35)
        Me.btnContinue.TabIndex = 25
        Me.btnContinue.Text = "&Home"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnTryAgain
        '
        Me.btnTryAgain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTryAgain.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnTryAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
        Me.btnTryAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTryAgain.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTryAgain.Location = New System.Drawing.Point(197, 204)
        Me.btnTryAgain.Name = "btnTryAgain"
        Me.btnTryAgain.Size = New System.Drawing.Size(95, 35)
        Me.btnTryAgain.TabIndex = 24
        Me.btnTryAgain.Text = "&Try Again"
        Me.btnTryAgain.UseVisualStyleBackColor = True
        '
        'pcbErrorSorry
        '
        Me.pcbErrorSorry.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.sorry
        Me.pcbErrorSorry.Location = New System.Drawing.Point(6, 40)
        Me.pcbErrorSorry.Name = "pcbErrorSorry"
        Me.pcbErrorSorry.Size = New System.Drawing.Size(152, 140)
        Me.pcbErrorSorry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbErrorSorry.TabIndex = 1
        Me.pcbErrorSorry.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(169, 44)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(424, 126)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = resources.GetString("lblMessage.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hold on to your horses!"
        '
        'frmError
        '
        Me.AcceptButton = Me.btnTryAgain
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(604, 313)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbxError)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmError"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "My Anime Archive - Error 101"
        Me.gbxError.ResumeLayout(False)
        Me.gbxError.PerformLayout()
        CType(Me.pcbErrorSorry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxError As GroupBox
    Friend WithEvents pcbErrorSorry As PictureBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTryAgain As Button
    Friend WithEvents btnContinue As Button
End Class
