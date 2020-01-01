Public Class frmWelcome
    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmMain.themePurple = True Then
            Me.BackgroundImage = My.Resources.purple_back
            With btnContinue
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.MediumPurple
                .FlatAppearance.MouseDownBackColor = Color.BlueViolet
            End With
        ElseIf frmMain.themeOrange = True Then
            Me.BackgroundImage = My.Resources.orange_back
            With btnContinue
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.Orange
                .FlatAppearance.MouseDownBackColor = Color.OrangeRed
            End With
        Else
            Me.BackgroundImage = My.Resources.blue_back
            With btnContinue
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.LightBlue
                .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
            End With
        End If

        lblWelcome.Text = "Welcome " & frmMain.userList(frmMain.userCount).Username & "!"

        Dim USER_IMG_URL As String = "https://cdn.myanimelist.net/images/userimages/" & frmMain.userList(frmMain.userCount).UserId & ".jpg"

        If frmMain.CheckConnection(USER_IMG_URL) = True Then
            pcbUserImage.Load(USER_IMG_URL)
        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Close()
    End Sub

    Private Sub lnkChangeLog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkChangeLog.LinkClicked
        Dim changelog As frmChangeLog

        changelog = New frmChangeLog
        changelog.ShowDialog()
    End Sub
End Class