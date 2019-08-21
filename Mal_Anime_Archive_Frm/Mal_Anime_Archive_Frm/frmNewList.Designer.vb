<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewList))
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.mtxtUserName = New MetroFramework.Controls.MetroTextBox()
        Me.mtxtUserID = New MetroFramework.Controls.MetroTextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.pcbUserImage = New System.Windows.Forms.PictureBox()
        Me.lblDisplayUserName = New System.Windows.Forms.Label()
        Me.lblDisplayUserID = New System.Windows.Forms.Label()
        Me.lblNewListInfo = New System.Windows.Forms.Label()
        Me.mtpgbLoading = New MetroFramework.Controls.MetroProgressBar()
        Me.lblSearching = New System.Windows.Forms.Label()
        Me.lblUserSearch = New System.Windows.Forms.Label()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.chkManual = New System.Windows.Forms.CheckBox()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.pcbUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroPanel1.Controls.Add(Me.chkManual)
        Me.MetroPanel1.Controls.Add(Me.MetroTextBox1)
        Me.MetroPanel1.Controls.Add(Me.lblUserSearch)
        Me.MetroPanel1.Controls.Add(Me.lblSearching)
        Me.MetroPanel1.Controls.Add(Me.mtpgbLoading)
        Me.MetroPanel1.Controls.Add(Me.lblNewListInfo)
        Me.MetroPanel1.Controls.Add(Me.lblDisplayUserID)
        Me.MetroPanel1.Controls.Add(Me.lblDisplayUserName)
        Me.MetroPanel1.Controls.Add(Me.pcbUserImage)
        Me.MetroPanel1.Controls.Add(Me.btnApply)
        Me.MetroPanel1.Controls.Add(Me.btnSearch)
        Me.MetroPanel1.Controls.Add(Me.mtxtUserID)
        Me.MetroPanel1.Controls.Add(Me.mtxtUserName)
        Me.MetroPanel1.Controls.Add(Me.lblUserID)
        Me.MetroPanel1.Controls.Add(Me.lblUserName)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(-10, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(685, 356)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.UseCustomForeColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblHeader.Location = New System.Drawing.Point(12, 13)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(174, 32)
        Me.lblHeader.TabIndex = 4
        Me.lblHeader.Text = "New Anime List"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(82, 251)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(82, 20)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "User Name"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(82, 295)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(56, 20)
        Me.lblUserID.TabIndex = 3
        Me.lblUserID.Text = "User ID"
        '
        'mtxtUserName
        '
        '
        '
        '
        Me.mtxtUserName.CustomButton.Image = Nothing
        Me.mtxtUserName.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.mtxtUserName.CustomButton.Name = ""
        Me.mtxtUserName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxtUserName.CustomButton.TabIndex = 1
        Me.mtxtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxtUserName.CustomButton.UseSelectable = True
        Me.mtxtUserName.CustomButton.Visible = False
        Me.mtxtUserName.Lines = New String(-1) {}
        Me.mtxtUserName.Location = New System.Drawing.Point(170, 170)
        Me.mtxtUserName.MaxLength = 32767
        Me.mtxtUserName.Name = "mtxtUserName"
        Me.mtxtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxtUserName.SelectedText = ""
        Me.mtxtUserName.SelectionLength = 0
        Me.mtxtUserName.SelectionStart = 0
        Me.mtxtUserName.ShortcutsEnabled = True
        Me.mtxtUserName.Size = New System.Drawing.Size(179, 23)
        Me.mtxtUserName.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtxtUserName.TabIndex = 4
        Me.mtxtUserName.UseSelectable = True
        Me.mtxtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxtUserName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxtUserID
        '
        '
        '
        '
        Me.mtxtUserID.CustomButton.Image = Nothing
        Me.mtxtUserID.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.mtxtUserID.CustomButton.Name = ""
        Me.mtxtUserID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxtUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxtUserID.CustomButton.TabIndex = 1
        Me.mtxtUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxtUserID.CustomButton.UseSelectable = True
        Me.mtxtUserID.CustomButton.Visible = False
        Me.mtxtUserID.Enabled = False
        Me.mtxtUserID.Lines = New String(-1) {}
        Me.mtxtUserID.Location = New System.Drawing.Point(170, 295)
        Me.mtxtUserID.MaxLength = 32767
        Me.mtxtUserID.Name = "mtxtUserID"
        Me.mtxtUserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxtUserID.SelectedText = ""
        Me.mtxtUserID.SelectionLength = 0
        Me.mtxtUserID.SelectionStart = 0
        Me.mtxtUserID.ShortcutsEnabled = True
        Me.mtxtUserID.Size = New System.Drawing.Size(179, 23)
        Me.mtxtUserID.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtxtUserID.TabIndex = 5
        Me.mtxtUserID.UseSelectable = True
        Me.mtxtUserID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxtUserID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(350, 170)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(67, 23)
        Me.btnSearch.TabIndex = 42
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple
        Me.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.Black
        Me.btnApply.Location = New System.Drawing.Point(578, 305)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(84, 29)
        Me.btnApply.TabIndex = 43
        Me.btnApply.Text = "A&dd User"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'pcbUserImage
        '
        Me.pcbUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbUserImage.Image = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.user_icon
        Me.pcbUserImage.Location = New System.Drawing.Point(429, 196)
        Me.pcbUserImage.Name = "pcbUserImage"
        Me.pcbUserImage.Size = New System.Drawing.Size(127, 138)
        Me.pcbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbUserImage.TabIndex = 44
        Me.pcbUserImage.TabStop = False
        '
        'lblDisplayUserName
        '
        Me.lblDisplayUserName.AutoSize = True
        Me.lblDisplayUserName.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayUserName.Location = New System.Drawing.Point(573, 206)
        Me.lblDisplayUserName.Name = "lblDisplayUserName"
        Me.lblDisplayUserName.Size = New System.Drawing.Size(82, 20)
        Me.lblDisplayUserName.TabIndex = 45
        Me.lblDisplayUserName.Text = "User Name"
        '
        'lblDisplayUserID
        '
        Me.lblDisplayUserID.AutoSize = True
        Me.lblDisplayUserID.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayUserID.Location = New System.Drawing.Point(574, 238)
        Me.lblDisplayUserID.Name = "lblDisplayUserID"
        Me.lblDisplayUserID.Size = New System.Drawing.Size(56, 20)
        Me.lblDisplayUserID.TabIndex = 46
        Me.lblDisplayUserID.Text = "User ID"
        '
        'lblNewListInfo
        '
        Me.lblNewListInfo.AutoSize = True
        Me.lblNewListInfo.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewListInfo.Location = New System.Drawing.Point(19, 6)
        Me.lblNewListInfo.Name = "lblNewListInfo"
        Me.lblNewListInfo.Size = New System.Drawing.Size(537, 140)
        Me.lblNewListInfo.TabIndex = 47
        Me.lblNewListInfo.Text = resources.GetString("lblNewListInfo.Text")
        '
        'mtpgbLoading
        '
        Me.mtpgbLoading.Location = New System.Drawing.Point(3, 153)
        Me.mtpgbLoading.Maximum = 7
        Me.mtpgbLoading.Name = "mtpgbLoading"
        Me.mtpgbLoading.Size = New System.Drawing.Size(670, 6)
        Me.mtpgbLoading.Step = 1
        Me.mtpgbLoading.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtpgbLoading.TabIndex = 104
        Me.mtpgbLoading.Value = 7
        '
        'lblSearching
        '
        Me.lblSearching.AutoSize = True
        Me.lblSearching.BackColor = System.Drawing.Color.Transparent
        Me.lblSearching.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearching.Location = New System.Drawing.Point(466, 164)
        Me.lblSearching.Name = "lblSearching"
        Me.lblSearching.Size = New System.Drawing.Size(144, 25)
        Me.lblSearching.TabIndex = 105
        Me.lblSearching.Text = "Searching User..."
        Me.lblSearching.Visible = False
        '
        'lblUserSearch
        '
        Me.lblUserSearch.AutoSize = True
        Me.lblUserSearch.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserSearch.Location = New System.Drawing.Point(18, 170)
        Me.lblUserSearch.Name = "lblUserSearch"
        Me.lblUserSearch.Size = New System.Drawing.Size(150, 20)
        Me.lblUserSearch.TabIndex = 107
        Me.lblUserSearch.Text = "Search by User Name"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Enabled = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(170, 251)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(179, 23)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTextBox1.TabIndex = 108
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkManual
        '
        Me.chkManual.AutoSize = True
        Me.chkManual.Location = New System.Drawing.Point(86, 224)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.Size = New System.Drawing.Size(133, 21)
        Me.chkManual.TabIndex = 109
        Me.chkManual.Text = "Manually Add User"
        Me.chkManual.UseVisualStyleBackColor = True
        '
        'frmNewList
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mal_Anime_Archive_Frm.My.Resources.Resources.purple_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(660, 406)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.MetroPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmNewList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New List"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.pcbUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents mtxtUserID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxtUserName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDisplayUserID As Label
    Friend WithEvents lblDisplayUserName As Label
    Friend WithEvents pcbUserImage As PictureBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblNewListInfo As Label
    Friend WithEvents mtpgbLoading As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents lblSearching As Label
    Friend WithEvents chkManual As CheckBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblUserSearch As Label
End Class
