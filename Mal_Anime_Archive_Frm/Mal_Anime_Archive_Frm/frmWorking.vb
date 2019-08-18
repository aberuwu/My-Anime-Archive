Public Class Saving
    Private Sub frmWorking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblPath.Text = "Saving..."

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(20)

        If ProgressBar1.Value = 100 Then
            lblPath.Text = "Save Successfull!"
            btnClose.Enabled = True
        End If
    End Sub


    Private Sub bcwSavingFile_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bcwSavingFile.ProgressChanged

    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class