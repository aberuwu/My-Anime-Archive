Public Class WelcomeOpen

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer
    'Private chromeBrowser As ChromiumWebBrowser

    Private Sub WelcomeOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        Dim ofpXml As OpenFileDialog = New OpenFileDialog()

        If ofpXml.ShowDialog = DialogResult.OK Then
            frmMain.ANIME_SOURCE_XML = ofpXml.FileName

            If frmMain.ANIME_SOURCE_XML = "" Then
                Return
            End If

            frmMain.tsFileLable.Text = frmMain.ANIME_SOURCE_XML

            frmMain.loadXmlFile()
        ElseIf ofpXml.ShowDialog = DialogResult.Cancel Then
            Return

        End If
        Me.Close()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmMain.lblNoListLoaded.Visible = True
        Me.Close()
    End Sub

    Private Sub WelcomeOpen_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub WelcomeOpen_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub WelcomeOpen_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub lblTutorialLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblTutorialLink.LinkClicked
        MsgBox("Coming Soon UwU")
    End Sub

    Private Sub llbGitHub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbGitHub.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/aberuwu")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        If frmMain.loadedXml = False Then
            frmMain.Close()
        End If
    End Sub
End Class