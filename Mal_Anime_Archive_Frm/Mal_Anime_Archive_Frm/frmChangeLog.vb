Public Class frmChangeLog

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer

    Private Sub frmChangeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChangeLog.Text = System.IO.File.ReadAllText("C:\Users\Scooby2\Documents\Personal Programming Challenges\BACKUP 5-25-2019\Mal_Anime_Archive_Frm\Mal_Anime_Archive_Frm\changelog.txt")
        txtChangeLog.Select(0, 0)
    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub frmChangeLog_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmChangeLog_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmChangeLog_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub
End Class