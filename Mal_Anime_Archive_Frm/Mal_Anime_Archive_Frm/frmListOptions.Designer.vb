<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOptions))
        Me.gbxOptions = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkMyId = New System.Windows.Forms.CheckBox()
        Me.chkRewatch = New System.Windows.Forms.CheckBox()
        Me.chkComments = New System.Windows.Forms.CheckBox()
        Me.chkTags = New System.Windows.Forms.CheckBox()
        Me.chkFinished = New System.Windows.Forms.CheckBox()
        Me.chkStart = New System.Windows.Forms.CheckBox()
        Me.chkScore = New System.Windows.Forms.CheckBox()
        Me.chkWatched = New System.Windows.Forms.CheckBox()
        Me.chkEpisodes = New System.Windows.Forms.CheckBox()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.chkType = New System.Windows.Forms.CheckBox()
        Me.chkTitle = New System.Windows.Forms.CheckBox()
        Me.chkID = New System.Windows.Forms.CheckBox()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.gbxOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxOptions
        '
        Me.gbxOptions.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbxOptions.Controls.Add(Me.btnSave)
        Me.gbxOptions.Controls.Add(Me.chkMyId)
        Me.gbxOptions.Controls.Add(Me.chkRewatch)
        Me.gbxOptions.Controls.Add(Me.chkComments)
        Me.gbxOptions.Controls.Add(Me.chkTags)
        Me.gbxOptions.Controls.Add(Me.chkFinished)
        Me.gbxOptions.Controls.Add(Me.chkStart)
        Me.gbxOptions.Controls.Add(Me.chkScore)
        Me.gbxOptions.Controls.Add(Me.chkWatched)
        Me.gbxOptions.Controls.Add(Me.chkEpisodes)
        Me.gbxOptions.Controls.Add(Me.chkStatus)
        Me.gbxOptions.Controls.Add(Me.chkType)
        Me.gbxOptions.Controls.Add(Me.chkTitle)
        Me.gbxOptions.Controls.Add(Me.chkID)
        Me.gbxOptions.Controls.Add(Me.lblColumns)
        Me.gbxOptions.Location = New System.Drawing.Point(-1, 51)
        Me.gbxOptions.Name = "gbxOptions"
        Me.gbxOptions.Size = New System.Drawing.Size(373, 242)
        Me.gbxOptions.TabIndex = 0
        Me.gbxOptions.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(252, 161)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "C&lose"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkMyId
        '
        Me.chkMyId.AutoSize = True
        Me.chkMyId.Checked = True
        Me.chkMyId.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMyId.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMyId.Location = New System.Drawing.Point(213, 62)
        Me.chkMyId.Name = "chkMyId"
        Me.chkMyId.Size = New System.Drawing.Size(56, 19)
        Me.chkMyId.TabIndex = 13
        Me.chkMyId.Text = "My ID"
        Me.chkMyId.UseVisualStyleBackColor = True
        '
        'chkRewatch
        '
        Me.chkRewatch.AutoSize = True
        Me.chkRewatch.Checked = True
        Me.chkRewatch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRewatch.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRewatch.Location = New System.Drawing.Point(113, 177)
        Me.chkRewatch.Name = "chkRewatch"
        Me.chkRewatch.Size = New System.Drawing.Size(100, 19)
        Me.chkRewatch.TabIndex = 12
        Me.chkRewatch.Text = "Rewatch Value"
        Me.chkRewatch.UseVisualStyleBackColor = True
        '
        'chkComments
        '
        Me.chkComments.AutoSize = True
        Me.chkComments.Checked = True
        Me.chkComments.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkComments.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComments.Location = New System.Drawing.Point(113, 154)
        Me.chkComments.Name = "chkComments"
        Me.chkComments.Size = New System.Drawing.Size(82, 19)
        Me.chkComments.TabIndex = 11
        Me.chkComments.Text = "Comments"
        Me.chkComments.UseVisualStyleBackColor = True
        '
        'chkTags
        '
        Me.chkTags.AutoSize = True
        Me.chkTags.Checked = True
        Me.chkTags.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTags.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTags.Location = New System.Drawing.Point(113, 131)
        Me.chkTags.Name = "chkTags"
        Me.chkTags.Size = New System.Drawing.Size(49, 19)
        Me.chkTags.TabIndex = 10
        Me.chkTags.Text = "Tags"
        Me.chkTags.UseVisualStyleBackColor = True
        '
        'chkFinished
        '
        Me.chkFinished.AutoSize = True
        Me.chkFinished.Checked = True
        Me.chkFinished.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFinished.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFinished.Location = New System.Drawing.Point(113, 108)
        Me.chkFinished.Name = "chkFinished"
        Me.chkFinished.Size = New System.Drawing.Size(84, 19)
        Me.chkFinished.TabIndex = 9
        Me.chkFinished.Text = "Finish Date"
        Me.chkFinished.UseVisualStyleBackColor = True
        '
        'chkStart
        '
        Me.chkStart.AutoSize = True
        Me.chkStart.Checked = True
        Me.chkStart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStart.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStart.Location = New System.Drawing.Point(113, 85)
        Me.chkStart.Name = "chkStart"
        Me.chkStart.Size = New System.Drawing.Size(77, 19)
        Me.chkStart.TabIndex = 8
        Me.chkStart.Text = "Start Date"
        Me.chkStart.UseVisualStyleBackColor = True
        '
        'chkScore
        '
        Me.chkScore.AutoSize = True
        Me.chkScore.Checked = True
        Me.chkScore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScore.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScore.Location = New System.Drawing.Point(113, 62)
        Me.chkScore.Name = "chkScore"
        Me.chkScore.Size = New System.Drawing.Size(54, 19)
        Me.chkScore.TabIndex = 7
        Me.chkScore.Text = "Score"
        Me.chkScore.UseVisualStyleBackColor = True
        '
        'chkWatched
        '
        Me.chkWatched.AutoSize = True
        Me.chkWatched.Checked = True
        Me.chkWatched.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWatched.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWatched.Location = New System.Drawing.Point(13, 177)
        Me.chkWatched.Name = "chkWatched"
        Me.chkWatched.Size = New System.Drawing.Size(72, 19)
        Me.chkWatched.TabIndex = 6
        Me.chkWatched.Text = "Watched"
        Me.chkWatched.UseVisualStyleBackColor = True
        '
        'chkEpisodes
        '
        Me.chkEpisodes.AutoSize = True
        Me.chkEpisodes.Checked = True
        Me.chkEpisodes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEpisodes.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEpisodes.Location = New System.Drawing.Point(13, 154)
        Me.chkEpisodes.Name = "chkEpisodes"
        Me.chkEpisodes.Size = New System.Drawing.Size(72, 19)
        Me.chkEpisodes.TabIndex = 5
        Me.chkEpisodes.Text = "Episodes"
        Me.chkEpisodes.UseVisualStyleBackColor = True
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Checked = True
        Me.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStatus.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStatus.Location = New System.Drawing.Point(13, 131)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(58, 19)
        Me.chkStatus.TabIndex = 4
        Me.chkStatus.Text = "Status"
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'chkType
        '
        Me.chkType.AutoSize = True
        Me.chkType.Checked = True
        Me.chkType.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkType.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkType.Location = New System.Drawing.Point(13, 108)
        Me.chkType.Name = "chkType"
        Me.chkType.Size = New System.Drawing.Size(50, 19)
        Me.chkType.TabIndex = 3
        Me.chkType.Text = "Type"
        Me.chkType.UseVisualStyleBackColor = True
        '
        'chkTitle
        '
        Me.chkTitle.AutoSize = True
        Me.chkTitle.Checked = True
        Me.chkTitle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTitle.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTitle.Location = New System.Drawing.Point(13, 85)
        Me.chkTitle.Name = "chkTitle"
        Me.chkTitle.Size = New System.Drawing.Size(48, 19)
        Me.chkTitle.TabIndex = 2
        Me.chkTitle.Text = "Title"
        Me.chkTitle.UseVisualStyleBackColor = True
        '
        'chkID
        '
        Me.chkID.AutoSize = True
        Me.chkID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkID.Location = New System.Drawing.Point(13, 62)
        Me.chkID.Name = "chkID"
        Me.chkID.Size = New System.Drawing.Size(37, 19)
        Me.chkID.TabIndex = 1
        Me.chkID.Text = "ID"
        Me.chkID.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumns.Location = New System.Drawing.Point(7, 26)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(121, 21)
        Me.lblColumns.TabIndex = 0
        Me.lblColumns.Text = "Visible Columns"
        '
        'frmListOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(367, 271)
        Me.Controls.Add(Me.gbxOptions)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListOptions"
        Me.Text = "List Options"
        Me.gbxOptions.ResumeLayout(False)
        Me.gbxOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxOptions As GroupBox
    Friend WithEvents chkRewatch As CheckBox
    Friend WithEvents chkComments As CheckBox
    Friend WithEvents chkTags As CheckBox
    Friend WithEvents chkFinished As CheckBox
    Friend WithEvents chkStart As CheckBox
    Friend WithEvents chkScore As CheckBox
    Friend WithEvents chkWatched As CheckBox
    Friend WithEvents chkEpisodes As CheckBox
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents chkType As CheckBox
    Friend WithEvents chkTitle As CheckBox
    Friend WithEvents chkID As CheckBox
    Friend WithEvents lblColumns As Label
    Friend WithEvents chkMyId As CheckBox
    Friend WithEvents btnSave As Button
End Class
