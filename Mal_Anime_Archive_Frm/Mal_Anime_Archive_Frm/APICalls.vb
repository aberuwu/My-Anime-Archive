Imports JikanDotNet

Public Class APICalls
    Async Sub loadDetails(id As String)
        Try
            frmMain.mtsLoading.Visible = True
            frmMain.lblNoConnection.Visible = False
            Dim jikan As IJikan = New Jikan()
            Dim anime = Await jikan.GetAnimeAsync(Convert.ToInt64(id))
            ''Dim producers As List(Of String) = New List(Of String)

            If IsNothing(anime.Data.Synopsis) Then
                frmMain.rctSynopsis.Text = "No Synopsis Available"
            Else
                frmMain.rctSynopsis.Text = anime.Data.Synopsis
            End If

            If IsNothing(anime.Data.Rating) Then
                frmMain.lblMALRating.Text = "--"
            Else
                frmMain.lblMALRating.Text = anime.Data.Rating
            End If

            If IsNothing(anime.Data.Season) Then
                frmMain.lblPremiered.Text = "--"
            Else
                If IsNothing(anime.Data.Year) Then
                    frmMain.lblPremiered.Text = anime.Data.Season.ToString()
                Else
                    frmMain.lblPremiered.Text = anime.Data.Season.ToString() + " " + anime.Data.Year.ToString()
                End If
            End If

            If IsNothing(anime.Data.Score) Then
                frmMain.lblMALScore.Text = "--"
            Else
                frmMain.lblMALScore.Text = anime.Data.Score
            End If

            If IsNothing(anime.Data.Status) Then
                frmMain.lblMALStatus.Text = "--"
            Else
                frmMain.lblMALStatus.Text = anime.Data.Status
            End If

            If IsNothing(anime.Data.Duration) Then
                frmMain.lblDuration.Text = "--"
            Else
                frmMain.lblDuration.Text = anime.Data.Duration
            End If

            If IsNothing(anime.Data.Popularity) Then
                frmMain.lblPopularity.Text = "--"
            Else
                frmMain.lblPopularity.Text = anime.Data.Popularity
            End If

            If IsNothing(anime.Data.Rank) Then
                frmMain.lblRank.Text = "--"
            Else
                frmMain.lblRank.Text = anime.Data.Rank
            End If

            If IsNothing(anime.Data.Members) Then
                frmMain.lblMembers.Text = "--"
            Else
                frmMain.lblMembers.Text = anime.Data.Members
            End If

            If IsNothing(anime.Data.Favorites) Then
                frmMain.lblFavorites.Text = "--"
            Else
                frmMain.lblFavorites.Text = anime.Data.Favorites
            End If

            If IsNothing(anime.Data.Broadcast.Day) Then
                frmMain.lblBrodcast.Text = "--"
            Else
                If IsNothing(anime.Data.Broadcast.Time) Then
                    frmMain.lblBrodcast.Text = anime.Data.Broadcast.Day.ToString()
                Else
                    frmMain.lblBrodcast.Text = anime.Data.Broadcast.Day.ToString() + " " + anime.Data.Broadcast.Time.ToString()
                End If
            End If

            If IsNothing(anime.Data.Images) Then

            Else
                frmMain.pcbAnimeCover.Load(anime.Data.Images.JPG.LargeImageUrl)
            End If

            frmMain.mtsLoading.Visible = False
        Catch ex As Exception
            frmMain.mtsLoading.Visible = True
            frmMain.pcbAnimeCover.Image = My.Resources.sorry
            frmMain.rctSynopsis.Clear()
            frmMain.lblNoConnection.Visible = True
        End Try
    End Sub
End Class
