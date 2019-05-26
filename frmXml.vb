Public Class frmXml

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer
    Private maximize As Boolean
    Private minimize As Boolean

    Private Sub frmXml_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbXml.Text = System.IO.File.ReadAllText(frmMain.ANIME_SOURCE_XML)
        rtbXml.Select(0, 0)
        'tbXmlMain.
        lblXmlFile.Text = frmMain.ANIME_SOURCE_XML
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub frmXml_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmXml_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmXml_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub lblMaximize_Click(sender As Object, e As EventArgs) Handles lblMaximize.Click

        If maximize = False Then
            maximize = True
            Me.WindowState = FormWindowState.Maximized
        Else
            maximize = False
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class