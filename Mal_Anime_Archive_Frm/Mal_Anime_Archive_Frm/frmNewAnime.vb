Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports JikanDotNet

Public Class frmNewAnime

    Private resultImgUrl As List(Of String) = New List(Of String)
    Private resultTitle As List(Of String) = New List(Of String)
    Private resultId As List(Of String) = New List(Of String)
    Private resultType As List(Of String) = New List(Of String)
    Private resultEpisodes As List(Of String) = New List(Of String)
    Private animeQueryInfo As List(Of QueryAnime) = New List(Of QueryAnime)

    Private Sub frmNewAnime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clearLists()
        resultImgUrl.Clear()
        resultTitle.Clear()
        resultId.Clear()
        resultType.Clear()
        resultEpisodes.Clear()
        animeQueryInfo.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        mtpgbLoading.Value = 1
        gbxResults.Visible = False
        lblSearchResults.Visible = False
        loadApiInfo(txtTitleSearch.Text)
        gbxResults.Visible = True
        displayApiInfo()
    End Sub

    Private Sub loadApiInfo(title As String)
        resultTitle.Clear()
        resultImgUrl.Clear()
        resultId.Clear()
        resultTitle.Clear()
        resultType.Clear()

        'Dim jikan As IJikan = New Jikan(True)

        'Dim animeSearch As AnimeSearchResult = Await jikan.SearchAnime(title)

        'txtTest.Text = animeSearch.Results.First().Title

        'Dim anime As JikanDotNet.Anime = Await jikan.GetAnime(anId)


        Dim apiConnect As HttpWebRequest
        Dim apiUrl As String = "https://api.jikan.moe/v3/search/anime?q=" & title & "&limit=8"
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim progress As Integer = 0

        If frmMain.CheckConnection(apiUrl) = True Then
            apiConnect = DirectCast(WebRequest.Create(apiUrl), HttpWebRequest)
            response = DirectCast(apiConnect.GetResponse(), HttpWebResponse)

            reader = New StreamReader(response.GetResponseStream)
            Dim rawresp As String

            rawresp = reader.ReadToEnd()
            Dim o As JObject = JObject.Parse(rawresp)
            Dim results As List(Of JToken) = o.Children().ToList
            For Each item As JProperty In results
                item.CreateReader()
                If item.Value.Type = JTokenType.Array Then
                    For Each subitem As JObject In item.Values
                        resultImgUrl.Add(subitem("image_url"))
                        resultTitle.Add(subitem("title"))
                        resultType.Add(subitem("type"))
                        resultId.Add(subitem("mal_id"))
                        resultEpisodes.Add(subitem("episodes"))
                        progress += 1
                        bckwNewAnime.ReportProgress(progress)
                    Next
                End If
            Next

        End If

    End Sub


    Private Sub displayApiInfo()
        Dim truncResult As String


        Dim image As Image
        For i As Integer = 0 To resultImgUrl.Count - 1

            If i = 0 Then
                pcbResult1.Load(resultImgUrl(i))
                image = pcbResult1.Image
                btnResult1.BackgroundImage = image
                If resultTitle(i).Length > 20 Then
                    truncResult = Truncate(resultTitle(i), 20)
                    txtTitle1.Text = truncResult & "..."
                Else
                    txtTitle1.Text = resultTitle(i)
                End If
            ElseIf i = 1 Then
                pcbResult2.Load(resultImgUrl(i))
                image = pcbResult2.Image
                btnResult2.BackgroundImage = image
                If resultTitle(i).Length > 20 Then
                    truncResult = Truncate(resultTitle(i), 20)
                    txtTitle2.Text = truncResult & "..."
                Else
                    txtTitle2.Text = resultTitle(i)
                End If
            ElseIf i = 2 Then
                pcbResult3.Load(resultImgUrl(i))
                image = pcbResult3.Image
                btnResult3.BackgroundImage = image
                If resultTitle(i).Length > 20 Then
                    truncResult = Truncate(resultTitle(i), 20)
                    txtTitle3.Text = truncResult & "..."
                Else
                    txtTitle3.Text = resultTitle(i)
                End If
            ElseIf i = 3 Then
                pcbResult4.Load(resultImgUrl(i))
                image = pcbResult4.Image
                btnResult4.BackgroundImage = image
                If resultTitle(i).Length > 20 Then
                    truncResult = Truncate(resultTitle(i), 20)
                    txtTitle4.Text = truncResult & "..."
                Else
                    txtTitle4.Text = resultTitle(i)
                End If
            ElseIf i = 4 Then
                pcbResult5.Load(resultImgUrl(i))
                image = pcbResult5.Image
                btnResult5.BackgroundImage = image
                If resultTitle(i).Length > 20 Then
                    truncResult = Truncate(resultTitle(i), 20)
                    txtTitle5.Text = truncResult & "..."
                Else
                    txtTitle5.Text = resultTitle(i)
                End If
            ElseIf i = 5 Then
                pcbResult6.Load(resultImgUrl(i))
                image = pcbResult6.Image
                btnResult6.BackgroundImage = image
                If resultTitle(i).Length > 20 Then
                    truncResult = Truncate(resultTitle(i), 20)
                    txtTitle6.Text = truncResult & "..."
                Else
                    txtTitle6.Text = resultTitle(i)
                End If
            ElseIf i = 6 Then
                pcbResult7.Load(resultImgUrl(i))
                image = pcbResult7.Image
                btnResult7.BackgroundImage = image
                If resultTitle(i).Length > 20 Then
                    truncResult = Truncate(resultTitle(i), 20)
                    txtTitle7.Text = truncResult & "..."
                Else
                    txtTitle7.Text = resultTitle(i)
                End If
            Else
                pcbResult8.Load(resultImgUrl(i))
                image = pcbResult8.Image
                btnResult8.BackgroundImage = image
                If resultTitle(i).Length > 20 Then
                    truncResult = Truncate(resultTitle(i), 20)
                    txtTitle8.Text = truncResult & "..."
                Else
                    txtTitle8.Text = resultTitle(i)
                End If
            End If
            'bckwNewAnime.ReportProgress(i)
        Next
    End Sub


    Public Function Truncate(value As String, length As Integer) As String
        If length > value.Length Then
            Return value
        Else
            Return value.Substring(0, length)
        End If
    End Function

    Private Sub btnResult1_Click(sender As Object, e As EventArgs) Handles btnResult1.Click
        txtTitle.Text = resultTitle(0)
        txtID.Text = resultId(0)
        numUpDownEpisodes.Value = resultEpisodes(0)

        If resultType(0) = "TV" Then
            ddlType.SelectedIndex = 0
        ElseIf resultType(0) = "Movie" Then
            ddlType.SelectedIndex = 1
        ElseIf resultType(0) = "OVA" Then
            ddlType.SelectedIndex = 2
        ElseIf resultType(0) = "Special" Then
            ddlType.SelectedIndex = 3
        Else
            ddlType.SelectedIndex = 4
        End If

        expand()
    End Sub

    Private Sub btnResult2_Click(sender As Object, e As EventArgs) Handles btnResult2.Click
        txtTitle.Text = resultTitle(1)
        txtID.Text = resultId(1)
        numUpDownEpisodes.Value = resultEpisodes(0)

        If resultType(1) = "TV" Then
            ddlType.SelectedIndex = 0
        ElseIf resultType(1) = "Movie" Then
            ddlType.SelectedIndex = 1
        ElseIf resultType(1) = "OVA" Then
            ddlType.SelectedIndex = 2
        ElseIf resultType(1) = "Special" Then
            ddlType.SelectedIndex = 3
        Else
            ddlType.SelectedIndex = 4
        End If

        expand()
    End Sub

    Private Sub btnResult3_Click(sender As Object, e As EventArgs) Handles btnResult3.Click
        txtTitle.Text = resultTitle(2)
        txtID.Text = resultId(2)
        numUpDownEpisodes.Value = resultEpisodes(2)

        If resultType(2) = "TV" Then
            ddlType.SelectedIndex = 0
        ElseIf resultType(2) = "Movie" Then
            ddlType.SelectedIndex = 1
        ElseIf resultType(2) = "OVA" Then
            ddlType.SelectedIndex = 2
        ElseIf resultType(2) = "Special" Then
            ddlType.SelectedIndex = 3
        Else
            ddlType.SelectedIndex = 4
        End If

        expand()
    End Sub

    Private Sub btnResult4_Click(sender As Object, e As EventArgs) Handles btnResult4.Click
        txtTitle.Text = resultTitle(3)
        txtID.Text = resultId(3)
        numUpDownEpisodes.Value = resultEpisodes(3)

        If resultType(3) = "TV" Then
            ddlType.SelectedIndex = 0
        ElseIf resultType(3) = "Movie" Then
            ddlType.SelectedIndex = 1
        ElseIf resultType(3) = "OVA" Then
            ddlType.SelectedIndex = 2
        ElseIf resultType(3) = "Special" Then
            ddlType.SelectedIndex = 3
        Else
            ddlType.SelectedIndex = 4
        End If

        expand()
    End Sub

    Private Sub btnResult5_Click(sender As Object, e As EventArgs) Handles btnResult5.Click
        txtTitle.Text = resultTitle(4)
        txtID.Text = resultId(4)
        numUpDownEpisodes.Value = resultEpisodes(4)

        If resultType(4) = "TV" Then
            ddlType.SelectedIndex = 0
        ElseIf resultType(4) = "Movie" Then
            ddlType.SelectedIndex = 1
        ElseIf resultType(4) = "OVA" Then
            ddlType.SelectedIndex = 2
        ElseIf resultType(4) = "Special" Then
            ddlType.SelectedIndex = 3
        Else
            ddlType.SelectedIndex = 4
        End If

        expand()
    End Sub

    Private Sub btnResult6_Click(sender As Object, e As EventArgs) Handles btnResult6.Click
        txtTitle.Text = resultTitle(5)
        txtID.Text = resultId(5)
        numUpDownEpisodes.Value = resultEpisodes(5)

        If resultType(5) = "TV" Then
            ddlType.SelectedIndex = 0
        ElseIf resultType(5) = "Movie" Then
            ddlType.SelectedIndex = 1
        ElseIf resultType(5) = "OVA" Then
            ddlType.SelectedIndex = 2
        ElseIf resultType(5) = "Special" Then
            ddlType.SelectedIndex = 3
        Else
            ddlType.SelectedIndex = 4
        End If

        expand()
    End Sub

    Private Sub btnResult7_Click(sender As Object, e As EventArgs) Handles btnResult7.Click
        txtTitle.Text = resultTitle(6)
        txtID.Text = resultId(6)
        numUpDownEpisodes.Value = resultEpisodes(6)

        If resultType(6) = "TV" Then
            ddlType.SelectedIndex = 0
        ElseIf resultType(6) = "Movie" Then
            ddlType.SelectedIndex = 1
        ElseIf resultType(6) = "OVA" Then
            ddlType.SelectedIndex = 2
        ElseIf resultType(6) = "Special" Then
            ddlType.SelectedIndex = 3
        Else
            ddlType.SelectedIndex = 4
        End If

        expand()
    End Sub

    Private Sub btnResult8_Click(sender As Object, e As EventArgs) Handles btnResult8.Click
        txtTitle.Text = resultTitle(7)
        txtID.Text = resultId(7)
        numUpDownEpisodes.Value = resultEpisodes(7)

        If resultType(7) = "TV" Then
            ddlType.SelectedIndex = 0
        ElseIf resultType(7) = "Movie" Then
            ddlType.SelectedIndex = 1
        ElseIf resultType(7) = "OVA" Then
            ddlType.SelectedIndex = 2
        ElseIf resultType(7) = "Special" Then
            ddlType.SelectedIndex = 3
        Else
            ddlType.SelectedIndex = 4
        End If

        expand()
    End Sub

    Private Sub bckwNewAnime_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bckwNewAnime.ProgressChanged
        pgbLoadingSearch.Value = Math.Min(e.ProgressPercentage, pgbLoadingSearch.Maximum)
        mtpgbLoading.Value = Math.Min(e.ProgressPercentage, mtpgbLoading.Maximum)
    End Sub

    Private collapsed As Boolean = True
    Private Sub btnExpandCollapse_Click(sender As Object, e As EventArgs) Handles btnExpandCollapse.Click
        If collapsed = False Then
            expand()
            collapsed = True
        Else
            collapse()
            collapsed = False
        End If
    End Sub

    Private Sub expand()
        Me.Size = New System.Drawing.Size(1191, 626)
        Me.CenterToParent()
        btnExpandCollapse.Text = "<"
    End Sub

    Private Sub collapse()
        Me.Size = New System.Drawing.Size(604, 626)
        Me.CenterToParent()
        btnExpandCollapse.Text = ">"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        saveAnime()
        frmMain.sortedList = frmSortWindow.sortList(frmMain.animeList, "title")
        Me.Close()
        clearLists()
    End Sub

    Private Sub saveAnime()

        Dim currentIndex As Integer = frmMain.animeList.Count()

        frmMain.animeList.Add(New Anime)
        frmMain.animeList(currentIndex).AnimeId = txtID.Text
        frmMain.animeList(currentIndex).Title = txtTitle.Text

        If ddlType.SelectedIndex = 0 Then
            frmMain.animeList(currentIndex).Type = "TV"
        ElseIf ddlType.SelectedIndex = 1 Then
            frmMain.animeList(currentIndex).Type = "Movie"
        ElseIf ddlType.SelectedIndex = 2 Then
            frmMain.animeList(currentIndex).Type = "OVA"
        ElseIf ddlType.SelectedIndex = 3 Then
            frmMain.animeList(currentIndex).Type = "Special"
        ElseIf ddlType.SelectedIndex = 4 Then
            frmMain.animeList(currentIndex).Type = "Unknown"
        End If

        frmMain.animeList(currentIndex).Episodes = numUpDownEpisodes.Value
        frmMain.animeList(currentIndex).WatchedEps = numUpDownWatched.Value
        frmMain.animeList(currentIndex).Score = numUpDownScore.Value

        If ddlStatus.SelectedIndex = 0 Then
            frmMain.animeList(currentIndex).Status = "Watching"
        ElseIf ddlStatus.SelectedIndex = 1 Then
            frmMain.animeList(currentIndex).Status = "Completed"
        ElseIf ddlStatus.SelectedIndex = 2 Then
            frmMain.animeList(currentIndex).Status = "On-Hold"
        ElseIf ddlStatus.SelectedIndex = 3 Then
            frmMain.animeList(currentIndex).Status = "Dropped"
        ElseIf ddlStatus.SelectedIndex = 4 Then
            frmMain.animeList(currentIndex).Status = "Plan to Watch"
        End If

        If ddlRewatchValue.SelectedIndex = 0 Then
            frmMain.animeList(currentIndex).Myrewatch = "Very Low"
        ElseIf ddlRewatchValue.SelectedIndex = 1 Then
            frmMain.animeList(currentIndex).Myrewatch = "Low"
        ElseIf ddlRewatchValue.SelectedIndex = 2 Then
            frmMain.animeList(currentIndex).Myrewatch = "Medium"
        ElseIf ddlRewatchValue.SelectedIndex = 3 Then
            frmMain.animeList(currentIndex).Myrewatch = "High"
        ElseIf ddlRewatchValue.SelectedIndex = 4 Then
            frmMain.animeList(currentIndex).Myrewatch = "Very High"
        End If


        frmMain.animeList(currentIndex).Myrewatchingep = numUpDownRewatch.Value
        frmMain.animeList(currentIndex).StartDate = "0000-00-00"
        frmMain.animeList(currentIndex).FinishDate = "0000-00-00"
        frmMain.animeList(currentIndex).Mycomments = txtTags.Text
    End Sub
End Class