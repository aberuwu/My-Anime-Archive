'---------------------------------------------
' File: XmlParser.vb
' Purpose: This class stores methods utilized
' for parsing data from MAL xml file
'---------------------------------------------

Imports System.Xml

Public Class XmlParser

    Public Sub loadXmlFile()

        'Counts for Anime and User fields
        Dim serIdCount = 0, episodesCount = 0, typeCount = 0, watchedCount = 0, startCount = 0, finishCount = 0, scoreCount = 0,
            statusCount = 0, myIdCount = 0, myRatedCount = 0, myDvdCount = 0, myStorageCount = 0, myCommentsCount = 0,
            myTimesCount = 0, myRewatchCount = 0, myTagsCount = 0, myRewatchingCount = 0, myRewatchingEpCount = 0, updateCount = 0,
            userNameCount = 0, totAnimeCount = 0, totWatchCount = 0, totCompletedCount = 0, totOnHold = 0, totDropped = 0, planCount = 0,
            exportCount As Integer

        exportCount = 0

        Try
            frmMain.animeList.Clear()
            frmMain.lstwAnimeSearch.Items.Clear()
            frmMain.lstwStatus.Items.Clear()
            frmMain.lstAnimes.Items.Clear()
            frmMain.animeCount = 0
            frmMain.userCount = 0
            frmMain.lstwAnimeMain.Items.Clear()
            frmMain.lblNoResultFound.Visible = False

            Dim settings As XmlReaderSettings = New XmlReaderSettings
            settings.IgnoreWhitespace = True
            settings.IgnoreComments = True

            Dim reader As XmlReader = XmlReader.Create(frmMain.ANIME_SOURCE_XML, settings)

            While reader.ReadState <> ReadState.EndOfFile

                '---------------------------
                ' Parse User Info
                '---------------------------
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

                '---------------------------
                ' Parse Anime Info
                '---------------------------
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

            frmMain.sortedList = frmSortWindow.sortList(frmMain.animeList, "title")
        Catch ex As Exception
            Dim errorPage As frmError
            errorPage = New frmError
            errorPage.ShowDialog()
            Return
        Finally
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
            frmMain.refreshSearchList()

            frmMain.USER_IMG_URL = "https://cdn.myanimelist.net/images/userimages/" & frmMain.userList(frmMain.userCount).UserId & ".jpg"

            If frmMain.CheckConnection(frmMain.USER_IMG_URL) = True Then
                frmMain.pcbUserPicture.Load(frmMain.USER_IMG_URL)
            End If

            frmMain.loadedXml = True
            frmMain.btnSave.Enabled = True
            frmMain.btnXml.Enabled = True
            frmMain.lblNoListLoaded.Visible = False
            frmMain.newList = False

            frmMain.welcomePage()
        End Try
    End Sub


    Public Sub populateList()
        frmMain.lstwAnimeMain.Visible = True
        frmMain.lstwAnimeMain.Items.Clear()
        frmMain.fullListChecked = True

        Dim currentAnime As String
        Dim animeCount As Integer = frmMain.animeList.Count()

        For i As Integer = 0 To animeCount - 1
            frmMain.pcbLoading.Maximum = animeCount - 1
            frmMain.pcbLoading.Visible = True
            frmMain.lstwAnimeMain.Items.Insert(i, frmMain.sortedList(i).AnimeId)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).Title)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).Type)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).Status)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).Episodes)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).WatchedEps)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).Score)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).StartDate)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).FinishDate)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).Mytags)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).MyId)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).Mycomments)
            frmMain.lstwAnimeMain.Items(i).SubItems.Add(frmMain.sortedList(i).Myrewatch)
            frmMain.backWork.ReportProgress(i)
        Next

        currentAnime = frmMain.lblId.Text

        For i As Integer = 0 To frmMain.animeCount - 1
            If frmMain.lstwAnimeMain.Items(i).SubItems(0).Text = currentAnime Then
                frmMain.lstwAnimeMain.Items(i).Selected = True
                frmMain.lstwAnimeMain.Items(i).EnsureVisible()
            End If
        Next

        If animeCount > -1 Then
            frmMain.lblNoListLoaded.Visible = False
        End If

        frmMain.lstwAnimeSearch.Items.Clear()
        frmMain.lstwStatus.Items.Clear()
    End Sub
End Class
