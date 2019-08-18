Public Class frmError

    Private Sub frmError_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmMain.darkModeOn = True Then
            gbxError.BackColor = Color.FromArgb(44, 44, 44)
            lblMessage.ForeColor = Color.WhiteSmoke
            btnContinue.ForeColor = Color.WhiteSmoke
            btnTryAgain.ForeColor = Color.WhiteSmoke
        End If

    End Sub


    Private Sub btnContinue_Click_1(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Close()
    End Sub

    Private Sub btnTryAgain_Click(sender As Object, e As EventArgs) Handles btnTryAgain.Click
        Me.Close()
    End Sub
End Class