'***************************************
'* File: frmSortWindow.vb
'* Purpose: Code in this form sorts and
'* filters user list based on specified
'* friteria
'* Last Updated: 17/08/2019 - 17:15
'***************************************
Public Class frmSortWindow

    Private themes As New Themes()
    '------------------------------------
    'Primary form load event
    '------------------------------------
    Private Sub frmSortWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        applyTheme()

        If frmMain.asscSort = False Then
            radPrimDesc.Checked = True
        End If

        If frmMain.sortByTitle = True Then
            mtddlPrimCrit.SelectedIndex = 2
        ElseIf frmMain.sortByStatus = True Then
            mtddlPrimCrit.SelectedIndex = 0
        ElseIf frmMain.sortByRating = True Then
            mtddlPrimCrit.SelectedIndex = 1
        ElseIf frmMain.sortyByWatched = True Then
            mtddlPrimCrit.SelectedIndex = 3
        End If

        If frmMain.filterByCompleted = True Then
            mtddlSecCrit.SelectedIndex = 2
        ElseIf frmMain.filterByDropped = True Then
            mtddlSecCrit.SelectedIndex = 4
        ElseIf frmMain.filterByNothing = True Then
            mtddlSecCrit.SelectedIndex = 0
        ElseIf frmMain.filterByOnHold = True Then
            mtddlSecCrit.SelectedIndex = 3
        ElseIf frmMain.filterByPlanToWatch = True Then
            mtddlSecCrit.SelectedIndex = 5
        ElseIf frmMain.filterByWatching = True Then
            mtddlSecCrit.SelectedIndex = 1
        End If
    End Sub

    '------------------------------------
    'Apply sort/filter click event
    '------------------------------------
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        resetConditions()
        primarySort()
        primaryFilter()
    End Sub

    '--------------------------------------------------------------------
    'Function sorts/orders generic anime list based on specific criteria
    '--------------------------------------------------------------------
    Public Function sortList(myList As List(Of Anime), sortOrder As String) As List(Of Anime)
        Try
            Dim sortedList As New List(Of Anime)
            If sortOrder = "title" Then
                sortedList = myList.OrderBy(Function(mts) mts.Title).ToList
            ElseIf sortOrder = "status" Then
                sortedList = myList.OrderBy(Function(mts) mts.Status).ToList
            ElseIf sortOrder = "score" Then
                sortedList = myList.OrderBy(Function(mts) mts.Score).ToList
            ElseIf sortOrder = "watched" Then
                sortedList = myList.OrderBy(Function(mts) mts.WatchedEps).ToList
            End If
            Return sortedList
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    '------------------------------------
    'Populates sorted/filtered list
    '------------------------------------
    Public Sub populateList(myList As List(Of Anime))
        For i As Integer = 0 To frmMain.animeCount - 1
            Dim itemStatus As ListViewItem = frmMain.lstwStatus.Items.Add("")
            Dim str(2) As String
            Dim itemResults As ListViewItem

            If myList(i).Status = "Watching" Then
                itemStatus.ImageIndex = 0
            ElseIf myList(i).Status = "Completed" Then
                itemStatus.ImageIndex = 1
            ElseIf myList(i).Status = "Dropped" Then
                itemStatus.ImageIndex = 2
            ElseIf myList(i).Status = "On-Hold" Then
                itemStatus.ImageIndex = 3
            Else
                itemStatus.ImageIndex = 4
            End If
            str(0) = myList(i).Title
            str(1) = myList(i).AnimeId
            itemResults = New ListViewItem(str)
            frmMain.lstwAnimeSearch.Items.Add(itemResults)
        Next
    End Sub

    '------------------------------------
    'Sort Criteria
    '------------------------------------
    Private Sub primarySort()
        If mtddlPrimCrit.SelectedIndex = 0 Then
            'Status
            If radPrimAsc.Checked = True Then
                frmMain.lstwAnimeSearch.Items.Clear()
                frmMain.lstwStatus.Items.Clear()

                Dim sortedList As List(Of Anime) = sortList(frmMain.animeList, "status")
                populateList(sortedList)
                frmMain.asscSort = True
            Else
                frmMain.lstwAnimeSearch.Items.Clear()
                frmMain.lstwStatus.Items.Clear()

                Dim sortedList As List(Of Anime) = sortList(frmMain.animeList, "status")
                sortedList.Reverse()
                populateList(sortedList)
                frmMain.asscSort = False
            End If
            frmMain.sortByStatus = True
        ElseIf mtddlPrimCrit.SelectedIndex = 1 Then
            'score
            resetConditions()
            If radPrimAsc.Checked = True Then
                frmMain.lstwAnimeSearch.Items.Clear()
                frmMain.lstwStatus.Items.Clear()

                Dim sortedList As List(Of Anime) = sortList(frmMain.animeList, "score")
                populateList(sortedList)
                frmMain.asscSort = True
            Else
                frmMain.lstwAnimeSearch.Items.Clear()
                frmMain.lstwStatus.Items.Clear()

                Dim sortedList As List(Of Anime) = sortList(frmMain.animeList, "score")
                sortedList.Reverse()
                populateList(sortedList)
                frmMain.asscSort = False
            End If
            frmMain.sortByRating = True
        ElseIf mtddlPrimCrit.SelectedIndex = 2 Then
            'Title
            resetConditions()
            If radPrimAsc.Checked = True Then
                frmMain.lstwAnimeSearch.Items.Clear()
                frmMain.lstwStatus.Items.Clear()

                Dim sortedList As List(Of Anime) = sortList(frmMain.animeList, "title")
                populateList(sortedList)
                frmMain.asscSort = True
            Else
                frmMain.lstwStatus.Items.Clear()
                frmMain.lstwAnimeSearch.Items.Clear()

                Dim sortedList As List(Of Anime) = sortList(frmMain.animeList, "title")
                sortedList.Reverse()
                populateList(sortedList)
                frmMain.asscSort = False
            End If
            frmMain.sortByTitle = True
        ElseIf mtddlPrimCrit.SelectedIndex = 3 Then
            'Watched
            resetConditions()
            If radPrimAsc.Checked = True Then
                frmMain.lstwAnimeSearch.Items.Clear()
                frmMain.lstwStatus.Items.Clear()

                Dim sortedList As List(Of Anime) = sortList(frmMain.animeList, "watched")
                populateList(sortedList)
                frmMain.asscSort = True
            Else
                frmMain.lstwAnimeSearch.Items.Clear()
                frmMain.lstwStatus.Items.Clear()

                Dim sortedList As List(Of Anime) = sortList(frmMain.animeList, "watched")
                sortedList.Reverse()
                populateList(sortedList)
                frmMain.asscSort = False
            End If
            frmMain.sortyByWatched = True
        End If
    End Sub

    '------------------------------------
    'Filter Criteria
    '------------------------------------
    Private Sub primaryFilter()
        If mtddlSecCrit.SelectedIndex = 0 Then
            'No Filter
            primarySort()
            frmMain.filterByNothing = True
        ElseIf mtddlSecCrit.SelectedIndex = 1 Then
            'Watching
            frmMain.lstwAnimeSearch.Items.Clear()
            frmMain.lstwStatus.Items.Clear()
            populateWithFilter(frmMain.animeList, "watching")
            frmMain.filterByWatching = True
        ElseIf mtddlSecCrit.SelectedIndex = 2 Then
            'Completed
            frmMain.lstwAnimeSearch.Items.Clear()
            frmMain.lstwStatus.Items.Clear()
            populateWithFilter(frmMain.animeList, "completed")
            frmMain.filterByCompleted = True
        ElseIf mtddlSecCrit.SelectedIndex = 3 Then
            'On-Hold
            frmMain.lstwAnimeSearch.Items.Clear()
            frmMain.lstwStatus.Items.Clear()
            populateWithFilter(frmMain.animeList, "on-hold")
            frmMain.filterByOnHold = True
        ElseIf mtddlSecCrit.SelectedIndex = 4 Then
            'Dropped
            frmMain.lstwAnimeSearch.Items.Clear()
            frmMain.lstwStatus.Items.Clear()
            populateWithFilter(frmMain.animeList, "dropped")
            frmMain.filterByDropped = True
        ElseIf mtddlSecCrit.SelectedIndex = 5 Then
            'Plan To Watch
            frmMain.lstwAnimeSearch.Items.Clear()
            frmMain.lstwStatus.Items.Clear()
            populateWithFilter(frmMain.animeList, "plantowatch")
            frmMain.filterByPlanToWatch = True
        End If
    End Sub

    '-----------------------------------------
    'Populates list based on filter criteria
    '-----------------------------------------
    Private Sub populateWithFilter(myList As List(Of Anime), filter As String)
        For i As Integer = 0 To frmMain.animeCount - 1
            If filter = "watching" Then
                If myList(i).Status = "Watching" Then
                    Dim itemStatus As ListViewItem = frmMain.lstwStatus.Items.Add("")
                    Dim str(2) As String
                    Dim itemResults As ListViewItem
                    If myList(i).Status = "Watching" Then
                        itemStatus.ImageIndex = 0
                    End If
                    str(0) = myList(i).Title
                    str(1) = myList(i).AnimeId
                    itemResults = New ListViewItem(str)
                    frmMain.lstwAnimeSearch.Items.Add(itemResults)
                End If
            ElseIf filter = "completed" Then
                If myList(i).Status = "Completed" Then
                    Dim itemStatus As ListViewItem = frmMain.lstwStatus.Items.Add("")
                    Dim str(2) As String
                    Dim itemResults As ListViewItem
                    If myList(i).Status = "Completed" Then
                        itemStatus.ImageIndex = 1
                    End If
                    str(0) = myList(i).Title
                    str(1) = myList(i).AnimeId
                    itemResults = New ListViewItem(str)
                    frmMain.lstwAnimeSearch.Items.Add(itemResults)
                End If
            ElseIf filter = "dropped" Then
                If myList(i).Status = "Dropped" Then
                    Dim itemStatus As ListViewItem = frmMain.lstwStatus.Items.Add("")
                    Dim str(2) As String
                    Dim itemResults As ListViewItem
                    If myList(i).Status = "Dropped" Then
                        itemStatus.ImageIndex = 2
                    End If
                    str(0) = myList(i).Title
                    str(1) = myList(i).AnimeId
                    itemResults = New ListViewItem(str)
                    frmMain.lstwAnimeSearch.Items.Add(itemResults)
                End If
            ElseIf filter = "on-hold" Then
                If myList(i).Status = "On-Hold" Then
                    Dim itemStatus As ListViewItem = frmMain.lstwStatus.Items.Add("")
                    Dim str(2) As String
                    Dim itemResults As ListViewItem
                    If myList(i).Status = "On-Hold" Then
                        itemStatus.ImageIndex = 3
                    End If
                    str(0) = myList(i).Title
                    str(1) = myList(i).AnimeId
                    itemResults = New ListViewItem(str)
                    frmMain.lstwAnimeSearch.Items.Add(itemResults)
                End If
            ElseIf filter = "plantowatch" Then
                If myList(i).Status = "Plan to Watch" Then
                    Dim itemStatus As ListViewItem = frmMain.lstwStatus.Items.Add("")
                    Dim str(2) As String
                    Dim itemResults As ListViewItem
                    If myList(i).Status = "Plan to Watch" Then
                        itemStatus.ImageIndex = 4
                    End If
                    str(0) = myList(i).Title
                    str(1) = myList(i).AnimeId
                    itemResults = New ListViewItem(str)
                    frmMain.lstwAnimeSearch.Items.Add(itemResults)
                End If
            Else
                primarySort()
            End If
        Next
    End Sub

    '------------------------------------------
    'Resets all sort/filter boolean variables
    '------------------------------------------
    Private Sub resetConditions()
        frmMain.sortByTitle = False
        frmMain.sortByStatus = False
        frmMain.sortByRating = False
        frmMain.sortyByWatched = False
        frmMain.filterByCompleted = False
        frmMain.filterByDropped = False
        frmMain.filterByNothing = False
        frmMain.filterByOnHold = False
        frmMain.filterByPlanToWatch = False
        frmMain.filterByWatching = False
    End Sub

    Private Sub applyTheme()
        If frmMain.darkModeOn = True Then
            If frmMain.themePurple = True Then
                purpleDarkThemeSort()
            ElseIf frmMain.themeBlue = True Then
                themes.blueDarkThemeSort()
            ElseIf frmMain.themeOrange = True Then
                themes.orangeDarkThemeSort()
            End If
        Else
            If frmMain.themePurple = True Then
                themes.purpleLightThemeSort()
            ElseIf frmMain.themeBlue = True Then
                themes.blueLightThemeSort()
            ElseIf frmMain.themeOrange = True Then
                themes.orangeLightThemeSort()
            End If
        End If
    End Sub
    Public Sub purpleDarkThemeSort()
        btnApply.BackColor = Color.FromArgb(44, 44, 44)

        SortSettings.BackColor = Color.FromArgb(44, 44, 44)
        lblSortCriteria.ForeColor = Color.White
        lblFilterCriteria.ForeColor = Color.White
        lblLegendHeader.ForeColor = Color.White
        lblWatching.ForeColor = Color.White
        lblOnHold.ForeColor = Color.White
        lblPlanToWatch.ForeColor = Color.White
        lblCompleted.ForeColor = Color.White
        lblDropped.ForeColor = Color.White

        radPrimAsc.ForeColor = Color.White
        radSecAsc.ForeColor = Color.White
        radPrimDesc.ForeColor = Color.White
        radSecDesc.ForeColor = Color.White

        With btnApply
            .FlatAppearance.BorderColor = Color.MediumPurple
            .FlatAppearance.MouseOverBackColor = Color.MediumPurple
            .FlatAppearance.MouseDownBackColor = Color.DarkViolet
            .ForeColor = Color.White
        End With
    End Sub
End Class