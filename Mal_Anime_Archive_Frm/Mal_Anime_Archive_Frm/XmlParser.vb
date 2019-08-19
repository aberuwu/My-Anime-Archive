'---------------------------------------------
' File: XmlParser.vb
' Purpose: This class stores methods utilized
' for parsing data from MAL xml file
'---------------------------------------------

Imports System.Xml

Public Class XmlParser

    Public Sub loadXmlFile()
        'Counts for Anime Fields
        Dim serIdCount As Integer = 0
        Dim episodesCount As Integer = 0
        Dim typeCount As Integer = 0
        Dim watchedCount As Integer = 0
        Dim startCount As Integer = 0
        Dim finishCount As Integer = 0
        Dim scoreCount As Integer = 0
        Dim statusCount As Integer = 0
        Dim myIdCount As Integer = 0
        Dim myRatedCount As Integer = 0
        Dim myDvdCount As Integer = 0
        Dim myStorageCount As Integer = 0
        Dim myCommentsCount As Integer = 0
        Dim myTimesCount As Integer = 0
        Dim myRewatchCount As Integer = 0
        Dim myTagsCount As Integer = 0
        Dim myRewatchingCount As Integer = 0
        Dim myRewatchingEpCount As Integer = 0
        Dim updateCount As Integer = 0
        'Counts for User Fields
        Dim userNameCount As Integer = 0
        Dim totAnimeCount As Integer = 0
        Dim totWatchCount As Integer = 0
        Dim totCompletedCount As Integer = 0
        Dim totOnHold As Integer = 0
        Dim totDropped As Integer = 0
        Dim planCount As Integer = 0
        Dim exportCount As Integer = 0

        Try
            frmMain.animeList.Clear()
            frmMain.lstwAnimeSearch.Items.Clear()
            frmMain.lstwStatus.Items.Clear()
            frmMain.lstAnimes.Items.Clear()
            frmMain.animeCount = 0
            frmMain.userCount = 0
            frmMain.dgvAnime.Rows.Clear()
            frmMain.lstwAnimeMain.Items.Clear()
            frmMain.lblNoResultFound.Visible = False

            Dim settings As XmlReaderSettings = New XmlReaderSettings
            settings.IgnoreWhitespace = True
            settings.IgnoreComments = True

            Dim reader As XmlReader = XmlReader.Create(frmMain.ANIME_SOURCE_XML, settings)

            While reader.ReadState <> ReadState.EndOfFile

                If reader.Name = "user_id" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.userList.Add(New User)
                    frmMain.userList(frmMain.userCount).UserId = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_export_type" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.userList(exportCount).UserExportType = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_name" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.userList(userNameCount).Username = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_anime" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.userList(totAnimeCount).TotalAnime = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_watching" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.userList(totWatchCount).TotalWatching = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_completed" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.userList(totCompletedCount).TotalCompleted = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_onhold" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.userList(totOnHold).TotalOnHold = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_dropped" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.userList(totDropped).TotalDropped = reader.ReadElementContentAsString
                End If

                If reader.Name = "user_total_plantowatch" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.userList(planCount).PlaToWatch = reader.ReadElementContentAsString
                End If

                If reader.Name = "anime" AndAlso reader.NodeType = XmlNodeType.Element Then
                    ' dgvAnime.Rows.Add()
                End If

                If reader.Name = "series_animedb_id" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList.Add(New Anime)
                    frmMain.animeList(serIdCount).AnimeId = reader.ReadElementContentAsString
                    serIdCount += 1
                End If

                If reader.Name = "series_title" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(frmMain.animeCount).Title = reader.ReadElementContentAsString
                    frmMain.animeCount += 1
                End If

                If reader.Name = "series_type" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(typeCount).Type = reader.ReadElementContentAsString
                    typeCount += 1
                End If

                If reader.Name = "series_episodes" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(episodesCount).Episodes = reader.ReadElementContentAsString
                    episodesCount += 1
                End If

                If reader.Name = "my_id" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myIdCount).MyId = reader.ReadElementContentAsString
                    myIdCount += 1
                End If

                If reader.Name = "my_watched_episodes" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(watchedCount).WatchedEps = reader.ReadElementContentAsString
                    watchedCount += 1
                End If

                If reader.Name = "my_start_date" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(startCount).StartDate = reader.ReadElementContentAsString
                    startCount += 1
                End If

                If reader.Name = "my_finish_date" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(finishCount).FinishDate = reader.ReadElementContentAsString
                    finishCount += 1
                End If

                If reader.Name = "my_rated" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myRatedCount).Myrated = reader.ReadElementContentAsString
                    myRatedCount += 1
                End If

                If reader.Name = "my_score" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(scoreCount).Score = reader.ReadElementContentAsString
                    scoreCount += 1
                End If

                If reader.Name = "my_dvd" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myDvdCount).Mydvd = reader.ReadElementContentAsString
                    myDvdCount += 1
                End If

                If reader.Name = "my_storage" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myStorageCount).Mystorage = reader.ReadElementContentAsString
                    myStorageCount += 1
                End If

                If reader.Name = "my_status" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(statusCount).Status = reader.ReadElementContentAsString
                    statusCount += 1
                End If

                If reader.Name = "my_comments" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myCommentsCount).Mycomments = reader.ReadElementContentAsString
                    myCommentsCount += 1
                End If

                If reader.Name = "my_times_watched" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myTimesCount).Mytimeswatched = reader.ReadElementContentAsString
                    myTimesCount += 1
                End If

                If reader.Name = "my_rewatch_value" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myRewatchCount).Myrewatch = reader.ReadElementContentAsString
                    myRewatchCount += 1
                End If

                If reader.Name = "my_tags" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myTagsCount).Mytags = reader.ReadElementContentAsString
                    myTagsCount += 1
                End If

                If reader.Name = "my_rewatching" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myRewatchingCount).Myrewatching = reader.ReadElementContentAsString
                    myRewatchingCount += 1
                End If

                If reader.Name = "my_rewatching_ep" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(myRewatchingEpCount).Myrewatchingep = reader.ReadElementContentAsString
                    myRewatchingEpCount += 1
                End If

                If reader.Name = "update_on_import" AndAlso reader.NodeType = XmlNodeType.Element Then
                    frmMain.animeList(updateCount).Updateonimport = reader.ReadElementContentAsString
                    updateCount += 1
                End If

                reader.Read()

            End While

            reader.Close()

        Catch ex As Exception
            'MsgBox("There was a problem with your XML File. Please try again with another file!", MsgBoxStyle.Critical, "Error")
            Dim errorPage As frmError
            errorPage = New frmError
            errorPage.ShowDialog()
            Return
        Finally

        End Try

        frmMain.txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim sug As AutoCompleteStringCollection = New AutoCompleteStringCollection

        For i As Integer = 0 To frmMain.animeCount - 1

            sug.Add(frmMain.animeList(i).Title)

            Dim itemStatus As ListViewItem = frmMain.lstwStatus.Items.Add("")
            Dim str(2) As String
            Dim itemResults As ListViewItem

            If frmMain.animeList(i).Status = "Watching" Then
                itemStatus.ImageIndex = 0
            ElseIf frmMain.animeList(i).Status = "Completed" Then
                itemStatus.ImageIndex = 1
            ElseIf frmMain.animeList(i).Status = "Dropped" Then
                itemStatus.ImageIndex = 2
            ElseIf frmMain.animeList(i).Status = "On-Hold" Then
                itemStatus.ImageIndex = 3
            Else
                itemStatus.ImageIndex = 4
            End If

            str(0) = frmMain.animeList(i).Title
            str(1) = frmMain.animeList(i).AnimeId
            itemResults = New ListViewItem(str)
            frmMain.lstwAnimeSearch.Items.Add(itemResults)

        Next

        frmMain.txtSearch.AutoCompleteCustomSource = sug

        populateList()

        frmMain.USER_IMG_URL = "https://cdn.myanimelist.net/images/userimages/" & frmMain.userList(frmMain.userCount).UserId & ".jpg"

        If frmMain.CheckConnection(frmMain.USER_IMG_URL) = True Then
            frmMain.pcbUserPicture.Load(frmMain.USER_IMG_URL)
        End If

        frmMain.loadedXml = True
        frmMain.btnSave.Enabled = True
        frmMain.btnXml.Enabled = True
        frmMain.lblNoListLoaded.Visible = False

        frmMain.welcomePage()
    End Sub


    Public Sub populateList()
        frmMain.dgvAnime.Enabled = False
        frmMain.dgvAnime.Visible = False
        frmMain.lstwOne.Visible = False
        frmMain.lstwAnimeMain.Visible = True
        frmMain.lstwAnimeMain.Items.Clear()
        frmMain.fullListChecked = True

        Dim currentAnime As String

        For i As Integer = 0 To frmMain.animeCount - 1
            frmMain.pcbLoading.Maximum = frmMain.animeCount - 1
            frmMain.pcbLoading.Visible = True
            frmMain.lstwAnimeMain.Items.Insert(i, frmMain.animeList(i).AnimeId)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).Title)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).Type)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).Status)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).Episodes)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).WatchedEps)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).Score)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).StartDate)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).FinishDate)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).Mytags)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).MyId)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).Mycomments)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.animeList(i).Myrewatch)
            frmMain.backWork.ReportProgress(i)
        Next

        currentAnime = frmMain.lblId.Text

        For i As Integer = 0 To frmMain.animeCount - 1
            If frmMain.lstwAnimeMain.Items(i).SubItems(0).Text = currentAnime Then
                frmMain.lstwAnimeMain.Items(i).Selected = True
                frmMain.lstwAnimeMain.Items(i).EnsureVisible()
            End If
        Next
    End Sub
End Class
