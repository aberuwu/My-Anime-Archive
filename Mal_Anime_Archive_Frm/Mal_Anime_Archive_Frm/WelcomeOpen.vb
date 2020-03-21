Public Class WelcomeOpen

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer
    Private xmlParser As New XmlParser()




    Private Sub WelcomeOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'mtlstvOpenRecent.BackColor = Color.FromArgb(44, 44, 44)

        mtlstvOpenRecent.Items.Clear()
        frmMain.loadRecent()
        Dim temp As List(Of String) = frmMain.recentList
        temp.Reverse()

        For i As Integer = 0 To frmMain.recentList.Count - 1
            mtlstvOpenRecent.Items.Insert(i, temp(i))
        Next

        If frmMain.themePurple = True Then
            Me.BackgroundImage = My.Resources.purple_back
            With btnChooseFile
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.MediumPurple
                .FlatAppearance.MouseDownBackColor = Color.BlueViolet
            End With
            With btnNewList
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.MediumPurple
                .FlatAppearance.MouseDownBackColor = Color.BlueViolet
            End With
            With btnContinue
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.MediumPurple
                .FlatAppearance.MouseDownBackColor = Color.BlueViolet
            End With
            With btnExit
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.MediumPurple
                .FlatAppearance.MouseDownBackColor = Color.BlueViolet
            End With
        ElseIf frmMain.themeOrange = True Then
            Me.BackgroundImage = My.Resources.orange_back
            With btnChooseFile
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.Orange
                .FlatAppearance.MouseDownBackColor = Color.OrangeRed
            End With
            With btnNewList
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.Orange
                .FlatAppearance.MouseDownBackColor = Color.OrangeRed
            End With
            With btnContinue
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.Orange
                .FlatAppearance.MouseDownBackColor = Color.OrangeRed
            End With
            With btnExit
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.Orange
                .FlatAppearance.MouseDownBackColor = Color.OrangeRed
            End With
        Else
            Me.BackgroundImage = My.Resources.blue_back
            With btnChooseFile
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.LightBlue
                .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
            End With
            With btnNewList
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.LightBlue
                .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
            End With
            With btnContinue
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.LightBlue
                .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
            End With
            With btnExit
                .FlatAppearance.BorderColor = Color.White
                .FlatAppearance.MouseOverBackColor = Color.LightBlue
                .FlatAppearance.MouseDownBackColor = Color.CornflowerBlue
            End With
        End If
    End Sub

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        Dim ofpXml As OpenFileDialog = New OpenFileDialog()

        If ofpXml.ShowDialog = DialogResult.OK Then
            'pcbLoading.Visible = True
            frmMain.ANIME_SOURCE_XML = ofpXml.FileName

            If frmMain.ANIME_SOURCE_XML = "" Then
                Return
            End If

            frmMain.tsFileLable.Text = frmMain.ANIME_SOURCE_XML

            xmlParser.loadXmlFile(frmMain.ANIME_SOURCE_XML)

            frmMain.saveRecent()
        ElseIf ofpXml.ShowDialog = DialogResult.Cancel Then
            Return
        End If
        Me.Close()
    End Sub

    Private Sub mtlstvOpenRecent_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles mtlstvOpenRecent.MouseDoubleClick
        Dim filePath As String = mtlstvOpenRecent.SelectedItems(0).Text
        If filePath = "" Then
            Return
        Else
            xmlParser.loadXmlFile(filePath)
            frmMain.saveRecent()
            Me.Close()
        End If
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
        System.Diagnostics.Process.Start("https://github.com/aberuwu/My-Anime-Archive/blob/master/ExportListTutorial.md")
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

    Private Sub btnNewList_Click(sender As Object, e As EventArgs) Handles btnNewList.Click
        Dim newList As frmNewList
        newList = New frmNewList
        newList.ShowDialog()
        Me.Close()
        Dim download As Download
        download = New Download()
        download.ShowDialog()
        xmlParser.populateList()
        frmMain.refreshSearchList()
    End Sub

    Private Sub mttTest_Click(sender As Object, e As EventArgs)

    End Sub


    Private brushPurple As Brush = Brushes.MediumPurple
    Private brushBlue As Brush = Brushes.CornflowerBlue
    Private brushOrange As Brush = Brushes.Orange

    Private Sub mtlstvOpenRecent_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles mtlstvOpenRecent.DrawColumnHeader
        Dim sf As New StringFormat()
        If frmMain.themePurple = True Then
            e.Graphics.FillRectangle(Brushes.MediumOrchid, e.Bounds)
            e.Graphics.DrawString(e.Header.Text, Me.mtlstvOpenRecent.Font, Brushes.White, e.Bounds, sf)
        ElseIf frmMain.themeBlue = True Then
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds)
            e.Graphics.DrawString(e.Header.Text, Me.mtlstvOpenRecent.Font, Brushes.White, e.Bounds, sf)
        Else
            e.Graphics.FillRectangle(Brushes.Tomato, e.Bounds)
            e.Graphics.DrawString(e.Header.Text, Me.mtlstvOpenRecent.Font, Brushes.White, e.Bounds, sf)
        End If
    End Sub

    Private Sub mtlstvOpenRecent_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles mtlstvOpenRecent.DrawSubItem
        Dim sf As New StringFormat()
        If e.Item.Selected = True Then

            If frmMain.themePurple = True Then
                e.Graphics.FillRectangle(brushPurple, e.Bounds)
            ElseIf frmMain.themeBlue = True Then
                e.Graphics.FillRectangle(brushBlue, e.Bounds)
            ElseIf frmMain.themeOrange = True Then
                e.Graphics.FillRectangle(brushOrange, e.Bounds)
            End If

            sf.Alignment = StringAlignment.Center
            e.Graphics.DrawString(e.SubItem.Text, Me.mtlstvOpenRecent.Font, Brushes.White, e.Bounds, sf)
        Else
            If frmMain.darkModeOn = False Then
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds)
            End If
            e.DrawText()
        End If
    End Sub

    Private Sub backWork_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles backWork.ProgressChanged
        pcbLoading.Value = Math.Min(e.ProgressPercentage, pcbLoading.Maximum)
        If e.ProgressPercentage = pcbLoading.Maximum Then
            pcbLoading.Visible = False
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim download As Download
        download = New Download()
        download.ShowDialog()
        'Me.Close()
        'Dim newAnime As frmNewAnime
        'newAnime = New frmNewAnime
        'newAnime.ShowDialog()
    End Sub
End Class