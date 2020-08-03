Imports JikanDotNet

Public Class APICalls
    Async Sub loadDetails(id As String)
        Try
            frmMain.mtsLoading.Visible = True
            frmMain.lblNoConnection.Visible = False
            Dim jikan As IJikan = New Jikan(True)
            Dim anime As JikanDotNet.Anime = Await jikan.GetAnime(id)
            Dim producers As List(Of String) = New List(Of String)

            If IsNothing(anime.Synopsis) Then
                frmMain.rctSynopsis.Text = "No Synopsis Available"
            Else
                frmMain.rctSynopsis.Text = anime.Synopsis
            End If

            If IsNothing(anime.Rating) Then
                frmMain.lblMALRating.Text = "--"
            Else
                frmMain.lblMALRating.Text = anime.Rating
            End If

            If IsNothing(anime.Premiered) Then
                frmMain.lblPremiered.Text = "--"
            Else
                frmMain.lblPremiered.Text = anime.Premiered
            End If

            If IsNothing(anime.Score) Then
                frmMain.lblMALScore.Text = "--"
            Else
                frmMain.lblMALScore.Text = anime.Score
            End If

            If IsNothing(anime.Status) Then
                frmMain.lblMALStatus.Text = "--"
            Else
                frmMain.lblMALStatus.Text = anime.Status
            End If

            If IsNothing(anime.Duration) Then
                frmMain.lblDuration.Text = "--"
            Else
                frmMain.lblDuration.Text = anime.Duration
            End If

            If IsNothing(anime.Popularity) Then
                frmMain.lblPopularity.Text = "--"
            Else
                frmMain.lblPopularity.Text = anime.Popularity
            End If

            If IsNothing(anime.Rank) Then
                frmMain.lblRank.Text = "--"
            Else
                frmMain.lblRank.Text = anime.Rank
            End If

            If IsNothing(anime.Members) Then
                frmMain.lblMembers.Text = "--"
            Else
                frmMain.lblMembers.Text = anime.Members
            End If

            If IsNothing(anime.Favorites) Then
                frmMain.lblFavorites.Text = "--"
            Else
                frmMain.lblFavorites.Text = anime.Favorites
            End If

            If IsNothing(anime.Broadcast) Then
                frmMain.lblBrodcast.Text = "--"
            Else
                frmMain.lblBrodcast.Text = anime.Broadcast
            End If

            If IsNothing(anime.ImageURL) Then

            Else
                frmMain.pcbAnimeCover.Load(anime.ImageURL)
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
