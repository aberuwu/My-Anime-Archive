Public Class frmUserInfo

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer

    Public Property webServices As Boolean
    Public Property USER_IMG_URL As String

    Private Sub frmUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmMain.loadedXml = True Then
            lblId.Text = frmMain.userList(frmMain.userCount).UserId
            lblUserName.Text = frmMain.userList(frmMain.userCount).Username
            lblTotalAnime.Text = frmMain.userList(frmMain.userCount).TotalAnime
            lblWatching.Text = frmMain.userList(frmMain.userCount).TotalWatching
            lblCompleted.Text = frmMain.userList(frmMain.userCount).TotalCompleted
            lblOnHold.Text = frmMain.userList(frmMain.userCount).TotalOnHold
            lblDropped.Text = frmMain.userList(frmMain.userCount).TotalDropped
            lblPlanToWatch.Text = frmMain.userList(frmMain.userCount).PlaToWatch

            USER_IMG_URL = "https://cdn.myanimelist.net/images/userimages/" & frmMain.userList(frmMain.userCount).UserId & ".jpg"

            If frmMain.CheckConnection(USER_IMG_URL) = True Then
                pcbUserImage.Load(USER_IMG_URL)
            End If

        Else
            lblUserName.Text = "No User Loaded"
        End If


        'DarkMode Settings

        If frmMain.darkModeOn = True Then
            tbUser.BackColor = Color.FromArgb(44, 44, 44)
            lblUserIdHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblUserName.ForeColor = Color.FromArgb(192, 0, 192)
            lblTotalAnimeHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblTotalWatchingHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblCompletedHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblOnHoldHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblDroppedHeading.ForeColor = Color.FromArgb(192, 0, 192)
            lblPlanToWatchHeading.ForeColor = Color.FromArgb(192, 0, 192)

            lblId.ForeColor = Color.White
            lblTotalAnime.ForeColor = Color.White
            lblWatching.ForeColor = Color.White
            lblCompleted.ForeColor = Color.White
            lblOnHold.ForeColor = Color.White
            lblDropped.ForeColor = Color.White
            lblPlanToWatch.ForeColor = Color.White

            lblProgramSettings.ForeColor = Color.White
            tbSettings.BackColor = Color.FromArgb(44, 44, 44)
            lblTheme.ForeColor = Color.White
            lblFont.ForeColor = Color.White
            lblEDWebBrowser.ForeColor = Color.White
            lblDefaultSave.ForeColor = Color.White

            radEnabled.ForeColor = Color.White
            radDisabled.ForeColor = Color.White

        End If



        'USER SETTINGS
        ddlThemes.SelectedIndex = 0
        ddlFonts.SelectedIndex = 0


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmUserInfo_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmUserInfo_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmUserInfo_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub
End Class