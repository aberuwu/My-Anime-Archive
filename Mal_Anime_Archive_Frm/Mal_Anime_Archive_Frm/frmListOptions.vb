Public Class frmListOptions

    Dim idchk As Boolean = False

    Private Sub frmListOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chk_CheckChanged(sender As Object, e As EventArgs) Handles chkID.CheckedChanged, chkTitle.CheckedChanged, chkType.CheckedChanged,
            chkType.CheckedChanged, chkStatus.CheckedChanged, chkEpisodes.CheckedChanged, chkWatched.CheckedChanged, chkWatched.CheckedChanged,
            chkScore.CheckedChanged, chkStart.CheckedChanged, chkFinished.CheckedChanged, chkTags.CheckedChanged, chkComments.CheckedChanged,
            chkRewatch.CheckedChanged, chkMyId.CheckedChanged


        If chkID.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(0).Width = 130 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(0).Width = 130
                frmMain.lstwAnimeMain.Columns(0).Text = "Anime ID"
                idchk = True
            End If
        Else
            frmMain.lstwAnimeMain.Columns(0).Width = 0
            frmMain.lstwAnimeMain.Columns(0).Text = ""
        End If


        If chkTitle.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(1).Width = 290 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(1).Width = 290
                frmMain.lstwAnimeMain.Columns(1).Text = "Title"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(1).Width = 0
            frmMain.lstwAnimeMain.Columns(1).Text = ""
        End If


        If chkType.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(2).Width = 140 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(2).Width = 140
                frmMain.lstwAnimeMain.Columns(2).Text = "Type"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(2).Width = 0
            frmMain.lstwAnimeMain.Columns(2).Text = ""
        End If


        If chkStatus.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(3).Width = 140 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(3).Width = 140
                frmMain.lstwAnimeMain.Columns(3).Text = "Status"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(3).Width = 0
            frmMain.lstwAnimeMain.Columns(3).Text = ""
        End If


        If chkEpisodes.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(4).Width = 130 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(4).Width = 130
                frmMain.lstwAnimeMain.Columns(4).Text = "Episodes"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(4).Width = 0
            frmMain.lstwAnimeMain.Columns(4).Text = ""
        End If


        If chkWatched.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(5).Width = 130 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(5).Width = 130
                frmMain.lstwAnimeMain.Columns(5).Text = "Watched"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(5).Width = 0
            frmMain.lstwAnimeMain.Columns(5).Text = ""
        End If


        If chkScore.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(6).Width = 115 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(6).Width = 115
                frmMain.lstwAnimeMain.Columns(6).Text = "Score"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(6).Width = 0
            frmMain.lstwAnimeMain.Columns(6).Text = ""
        End If


        If chkStart.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(7).Width = 150 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(7).Width = 150
                frmMain.lstwAnimeMain.Columns(7).Text = "Start Date"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(7).Width = 0
            frmMain.lstwAnimeMain.Columns(7).Text = ""
        End If


        If chkFinished.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(8).Width = 150 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(8).Width = 150
                frmMain.lstwAnimeMain.Columns(8).Text = "Finish Date"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(8).Width = 0
            frmMain.lstwAnimeMain.Columns(8).Text = ""
        End If


        If chkTags.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(9).Width = 180 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(9).Width = 180
                frmMain.lstwAnimeMain.Columns(9).Text = "Tags"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(9).Width = 0
            frmMain.lstwAnimeMain.Columns(9).Text = ""
        End If


        If chkComments.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(10).Width = 300 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(10).Width = 300
                frmMain.lstwAnimeMain.Columns(10).Text = "Comments"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(10).Width = 0
            frmMain.lstwAnimeMain.Columns(10).Text = ""
        End If


        If chkRewatch.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(11).Width = 80 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(11).Width = 80
                frmMain.lstwAnimeMain.Columns(11).Text = "Rewatch"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(11).Width = 0
            frmMain.lstwAnimeMain.Columns(11).Text = ""
        End If


        If chkMyId.Checked = True Then
            If frmMain.lstwAnimeMain.Columns(12).Width = 100 Then
                Return
            Else
                frmMain.lstwAnimeMain.Columns(12).Width = 100
                frmMain.lstwAnimeMain.Columns(12).Text = "My ID"
            End If
        Else
            frmMain.lstwAnimeMain.Columns(12).Width = 0
            frmMain.lstwAnimeMain.Columns(12).Text = ""
        End If


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
    End Sub


End Class