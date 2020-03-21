Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Web.Script.Serialization

Public Class Download
    Private Sub Download_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Download(frmNewList.USER_NAME)
    End Sub

    Async Sub Download(userName As String)

        Try
            lblImportProg.Visible = True
            
            Dim uriString As String = "https://myanimelist.net/animelist/" + userName + "/load.json?status=7&offset=0"
            Dim uri As New Uri(uriString)
            Dim parser As New XmlParser

            Dim Request As HttpWebRequest = HttpWebRequest.Create(uri)
            Request.Method = "GET"
            

            Dim Response As HttpWebResponse = Request.GetResponse()

            Dim Read = New StreamReader(Response.GetResponseStream())
            Dim Raw As String = Read.ReadToEnd()

            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)

            frmMain.animeCount = 0

            For Each item As Object In dict
                frmMain.animeList.Add(New Anime)
            
                frmMain.animeList(frmMain.animeCount).AnimeId = item("anime_id").ToString()
                frmMain.animeList(frmMain.animeCount).Title = item("anime_title").ToString()
                frmMain.animeList(frmMain.animeCount).Type = item("anime_media_type_string").ToString()
                frmMain.animeList(frmMain.animeCount).Episodes = item("anime_num_episodes").ToString()
                frmMain.animeList(frmMain.animeCount).WatchedEps = item("num_watched_episodes").ToString()
                'frmMain.animeList(frmMain.animeCount).StartDate = item("anime_start_date_string").ToString()

                If item("status") = 1 Then
                    frmMain.animeList(frmMain.animeCount).Status = "Watching"
                ElseIf item("status") = 2 Then
                    frmMain.animeList(frmMain.animeCount).Status = "Completed"
                ElseIf item("status") = 3 Then
                 frmMain.animeList(frmMain.animeCount).Status = "On-Hold"
                ElseIf item("status") = 4 Then
                    frmMain.animeList(frmMain.animeCount).Status = "Dropped"
                ElseIf item("status") = 6 Then
                    frmMain.animeList(frmMain.animeCount).Status = "Plan to Watch"
                End If

                frmMain.animeCount += 1
                lblImportProg.Text = "Importing List... (" + frmMain.animeCount.ToString() + ")"
                lblImportProg.Refresh()
            Next

            frmMain.sortedList = frmSortWindow.sortList(frmMain.animeList, "title")
            parser.populateList()
            frmMain.refreshSearchList()
        Catch ex As Exception
            MsgBox("Connection Error: Unable to download list. Please try again later")
        End Try

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newAnime As frmNewAnime
        newAnime = New frmNewAnime
        newAnime.ShowDialog()
    End Sub
End Class