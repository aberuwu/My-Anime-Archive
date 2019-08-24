'**********************************************
'* File: frmSave.vb
'* Purpose: Code in this form saves list array
'*          data into user selected format
'*          either XML, VSV, or SQL scripts
'* Last Updated: 07/08/2019
'***********************************************

Imports System.Xml
Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.Object
Imports System.Text
Imports System.IO

Public Class frmSave
    Public Property ANIME_LIST_SAVE_XML As String = ""
    Public Property ANIME_LIST_SAVE_CSV As String = ""
    Public Property ANIME_LIST_SAVE_SQL As String = ""

    Private drag As Boolean
    Private mousex As Integer
    Private mousey As Integer

    Private episodeCount As Integer = 0
    Private watchingCount As Integer = 0
    Private completedCount As Integer = 0
    Private droppedCount As Integer = 0
    Private onholdCount As Integer = 0
    Private plantowatchCount As Integer = 0
    Private meanScoreCount As Decimal = 0
    Private meanScore As Decimal = 0
    Private animeWScore As Decimal = 0


    Private Sub frmSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmMain.darkModeOn = True Then
            gbxSave.BackColor = Color.FromArgb(44, 44, 44)
            lblXMLDescription.ForeColor = Color.White
            lblCSVDescription.ForeColor = Color.White
            lblSqlDescription.ForeColor = Color.White
        End If

    End Sub

    'SAVE AS XML
    Private Sub btnXML_Click(sender As Object, e As EventArgs) Handles btnXML.Click
        Dim saveWindow As SaveFileDialog = New SaveFileDialog()
        saveWindow.Filter = "XML File|*.xml"
        saveWindow.Title = "Save Anime List As XML"
        saveWindow.ShowDialog()

        If saveWindow.FileName = "" Then
            Return
        End If
        ANIME_LIST_SAVE_XML = saveWindow.FileName

        GenerateXML()

        Dim workingPage As Saving
        workingPage = New Saving
        workingPage.ShowDialog()
    End Sub

    Private Sub calculateMetrics()
        For i As Integer = 0 To frmMain.animeList.Count() - 1
            episodeCount += Convert.ToInt32(frmMain.animeList(i).WatchedEps)

            If frmMain.animeList(i).Status = "Watching" Then
                watchingCount += 1
            ElseIf frmMain.animeList(i).Status = "Completed" Then
                completedCount += 1
            ElseIf frmMain.animeList(i).Status = "Dropped" Then
                droppedCount += 1
            ElseIf frmMain.animeList(i).Status = "On-Hold" Then
                onholdCount += 1
            Else
                plantowatchCount += 1
            End If

            If Convert.ToInt32(frmMain.animeList(i).Score) = 0 Then
            Else
                meanScoreCount += Convert.ToDecimal(frmMain.animeList(i).Score)
                animeWScore += 1
            End If
        Next

        If animeWScore = 0 Then
            meanScore = 0
        Else
            meanScore = meanScoreCount / animeWScore
        End If
    End Sub


    Private Sub GenerateXML()
        Dim settings As XmlWriterSettings = New XmlWriterSettings
        Dim doc As XmlDocument = New XmlDocument

        calculateMetrics()

        settings.Indent = True
        settings.IndentChars = "    "
        Dim xmlOut As XmlWriter = XmlWriter.Create(ANIME_LIST_SAVE_XML, settings)

        xmlOut.WriteStartDocument()
        xmlOut.WriteComment("XML File recreated by My Anime Archive Program.")
        xmlOut.WriteComment("Programmed by aberuwu")
        xmlOut.WriteComment("Last updated: 5/24/2019")
        xmlOut.WriteStartElement("myanimelist")

        For i As Integer = 0 To 0
            xmlOut.WriteStartElement("myinfo")
            xmlOut.WriteElementString("user_id", frmMain.userList(i).UserId)
            xmlOut.WriteElementString("user_name", frmMain.userList(i).Username)
            xmlOut.WriteElementString("user_export_type", "1")
            xmlOut.WriteElementString("user_total_anime", episodeCount)
            xmlOut.WriteElementString("user_total_watching", watchingCount)
            xmlOut.WriteElementString("user_total_completed", completedCount)
            xmlOut.WriteElementString("user_total_onhold", onholdCount)
            xmlOut.WriteElementString("user_total_dropped", droppedCount)
            xmlOut.WriteElementString("user_total_plantowatch", plantowatchCount)
            xmlOut.WriteEndElement()
        Next

        For i As Integer = 0 To frmMain.animeList.Count() - 1
            'Dim cdata As XCData = <![CDATA[frmMain.animeList(i).Title]]>
            'XmlNode XNode = XDocument.SelectSingNode("anime/series_title")
            xmlOut.WriteStartElement("anime")
            xmlOut.WriteElementString("series_animedb_id", frmMain.animeList(i).AnimeId)
            xmlOut.WriteElementString("series_title", frmMain.animeList(i).Title)
            xmlOut.WriteElementString("series_type", frmMain.animeList(i).Type)
            xmlOut.WriteElementString("series_episodes", frmMain.animeList(i).Episodes)
            xmlOut.WriteElementString("my_id", frmMain.animeList(i).MyId)
            xmlOut.WriteElementString("my_watched_episodes", frmMain.animeList(i).WatchedEps)
            xmlOut.WriteElementString("my_start_date", frmMain.animeList(i).StartDate)
            xmlOut.WriteElementString("my_finish_date", frmMain.animeList(i).FinishDate)
            xmlOut.WriteElementString("my_rated", frmMain.animeList(i).Myrated)
            xmlOut.WriteElementString("my_score", frmMain.animeList(i).Score)
            xmlOut.WriteElementString("my_dvd", frmMain.animeList(i).Mydvd)
            xmlOut.WriteElementString("my_storage", frmMain.animeList(i).Mystorage)
            xmlOut.WriteElementString("my_status", frmMain.animeList(i).Status)
            xmlOut.WriteElementString("my_comments", frmMain.animeList(i).Mycomments)
            xmlOut.WriteElementString("my_times_watched", frmMain.animeList(i).Mytimeswatched)
            xmlOut.WriteElementString("my_rewatch_value", frmMain.animeList(i).Myrewatch)
            xmlOut.WriteElementString("my_tags", frmMain.animeList(i).Mytags)
            xmlOut.WriteElementString("my_rewatching", frmMain.animeList(i).Myrewatching)
            xmlOut.WriteElementString("my_rewatching_ep", frmMain.animeList(i).Myrewatchingep)
            xmlOut.WriteElementString("update_on_import", "1")
            xmlOut.WriteEndElement()
        Next

        xmlOut.WriteEndElement()
        xmlOut.Close()
    End Sub

    'SAVE FOR EXCEL .CSV
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim saveWindow As SaveFileDialog = New SaveFileDialog()
        saveWindow.Filter = "CSV File|*.csv"
        saveWindow.Title = "Save Anime List As CSV For Excel"
        saveWindow.ShowDialog()

        Dim stringHeader As String = "series_animedb_id,series_title,series_type,series_episodes,my_id,my_watched_episodes," _
                                     & "my_start_date,my_finish_date,my_rated,my_score,my_dvd,my_storage,my_status,my_comments," _
                                     & "my_times_watched,my_rewatch_value,my_tags,my_rewatching,my_rewatching_ep,update_on_import"
        Dim stringLine As String


        If saveWindow.FileName = "" Then
            Return
        End If

        ANIME_LIST_SAVE_CSV = saveWindow.FileName

        Dim objWriter As New System.IO.StreamWriter(ANIME_LIST_SAVE_CSV)

        objWriter.WriteLine(stringHeader)

        For i As Integer = 0 To frmMain.animeCount - 1

            If frmMain.animeList(i).Title.Contains(",") Or frmMain.animeList(i).Mycomments.Contains(",") Or frmMain.animeList(i).Mytags.Contains(",") Then
                stringLine = frmMain.animeList(i).AnimeId & "," & frmMain.animeList(i).Title.Replace(",", "") & "," & frmMain.animeList(i).Type _
                    & "," & frmMain.animeList(i).Episodes & "," & frmMain.animeList(i).MyId & "," & frmMain.animeList(i).WatchedEps _
                    & "," & frmMain.animeList(i).StartDate & "," & frmMain.animeList(i).FinishDate & "," & frmMain.animeList(i).Myrated _
                    & "," & frmMain.animeList(i).Score & "," & frmMain.animeList(i).Mydvd & "," & frmMain.animeList(i).Mystorage _
                    & "," & frmMain.animeList(i).Status & "," & frmMain.animeList(i).Mycomments.Replace(",", "") & "," & frmMain.animeList(i).Mytimeswatched _
                    & "," & frmMain.animeList(i).Myrewatch & "," & frmMain.animeList(i).Mytags.Replace(",", "") & "," & frmMain.animeList(i).Myrewatching _
                    & "," & frmMain.animeList(i).Myrewatchingep & "," & frmMain.animeList(i).Updateonimport
                'stringLine = frmMain.animeList(i).Title.Replace(",", "") & "," & frmMain.animeList(i).Type & "," & frmMain.animeList(i).Episodes
            Else
                stringLine = frmMain.animeList(i).AnimeId & "," & frmMain.animeList(i).Title & "," & frmMain.animeList(i).Type _
                    & "," & frmMain.animeList(i).Episodes & "," & frmMain.animeList(i).MyId & "," & frmMain.animeList(i).WatchedEps _
                    & "," & frmMain.animeList(i).StartDate & "," & frmMain.animeList(i).FinishDate & "," & frmMain.animeList(i).Myrated _
                    & "," & frmMain.animeList(i).Score & "," & frmMain.animeList(i).Mydvd & "," & frmMain.animeList(i).Mystorage _
                    & "," & frmMain.animeList(i).Status & "," & frmMain.animeList(i).Mycomments & "," & frmMain.animeList(i).Mytimeswatched _
                    & "," & frmMain.animeList(i).Myrewatch & "," & frmMain.animeList(i).Mytags & "," & frmMain.animeList(i).Myrewatching _
                    & "," & frmMain.animeList(i).Myrewatchingep & "," & frmMain.animeList(i).Updateonimport
            End If

            objWriter.WriteLine(stringLine)
        Next

        objWriter.Close()

        Dim workingPage As Saving
        workingPage = New Saving
        workingPage.ShowDialog()

    End Sub

    'SAVE AS SQL - EXPERIMENTAL
    Private Sub btnSaveSql_Click(sender As Object, e As EventArgs) Handles btnSaveSql.Click
        Dim saveWindow As SaveFileDialog = New SaveFileDialog()
        saveWindow.Filter = "SQL File|*.sql"
        saveWindow.Title = "Save Anime List As SQL For Database"
        saveWindow.ShowDialog()

        Dim stringHeader As String = "series_animedb_id,series_title,series_type,series_episodes,my_id,my_watched_episodes," _
                                     & "my_start_date,my_finish_date,my_rated,my_score,my_dvd,my_storage,my_status,my_comments," _
                                     & "my_times_watched,my_rewatch_value,my_tags,my_rewatching,my_rewatching_ep,update_on_import"
        Dim stringLine As String


        If saveWindow.FileName = "" Then
            Return
        End If

        ANIME_LIST_SAVE_SQL = saveWindow.FileName

        Dim objWriter As New System.IO.StreamWriter(ANIME_LIST_SAVE_SQL)

        'objWriter.WriteLine(stringHeader)


        stringLine = "---SQL SCRIPT GENERATED BY MY ANIME ARCHIVE---"
        objWriter.WriteLine(stringLine)
        stringLine = "---Programmed by aberuwu---"
        objWriter.WriteLine(stringLine)
        stringLine = "---Last updated: 5/25/2019---"
        objWriter.WriteLine(stringLine)
        stringLine = ""
        objWriter.WriteLine(stringLine)

        stringLine = "CREATE TABLE mal" & frmMain.userList(frmMain.userCount).UserId & frmMain.userList(frmMain.userCount).Username
        objWriter.WriteLine(stringLine)
        stringLine = "("
        objWriter.WriteLine(stringLine)
        stringLine = "  series_animedb_id INT NOT NULL,"
        objWriter.WriteLine(stringLine)
        stringLine = "  series_title NVARCHAR(MAX) NOT NULL,"
        objWriter.WriteLine(stringLine)
        stringLine = "  series_type VARCHAR(10) NOT NULL,"
        objWriter.WriteLine(stringLine)
        stringLine = "  series_episodes INT,"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_id INT NOT NULL,"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_watched_episodes INT,"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_start_date NVARCHAR(MAX),"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_finish_date NVARCHAR(MAX),"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_rated NVARCHAR(MAX),"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_score INT,"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_dvd VARCHAR(MAX),"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_storage VARCHAR(MAX),"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_status VARCHAR(15),"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_comments NVARCHAR(MAX),"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_times_watched INT,"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_rewatch_value NVARCHAR(MAX),"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_tags NVARCHAR(MAX),"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_rewatching INT,"
        objWriter.WriteLine(stringLine)
        stringLine = "  my_rewatching_ep INT,"
        objWriter.WriteLine(stringLine)
        stringLine = "  update_on_import INT"
        objWriter.WriteLine(stringLine)
        stringLine = ");"
        objWriter.WriteLine(stringLine)


        stringLine = "INSERT INTO mal" & frmMain.userList(frmMain.userCount).UserId & frmMain.userList(frmMain.userCount).Username &
                      "(series_animedb_id, series_title, series_type, series_episodes, my_id, my_watched_episodes, my_start_date, " &
                      "my_finish_date, my_rated, my_score, my_dvd, my_storage, my_status, my_comments, my_times_watched, " &
                      "my_rewatch_value, my_tags, my_rewatching, my_rewatching_ep, update_on_import)"
        objWriter.WriteLine(stringLine)
        stringLine = "VALUES"
        objWriter.WriteLine(stringLine)

        For i As Integer = 0 To frmMain.animeCount - 1

            If i = frmMain.animeCount - 1 Then
                stringLine = "(" & "'" & frmMain.animeList(i).AnimeId & "'" & "," & "'" & frmMain.animeList(i).Title & "'" & "," & "'" & frmMain.animeList(i).Type & "'" & "," _
                & frmMain.animeList(i).Episodes & "," & frmMain.animeList(i).MyId & "," & frmMain.animeList(i).WatchedEps & "," _
                & "'" & frmMain.animeList(i).StartDate.Replace("-", "/") & "'" & "," & "'" & frmMain.animeList(i).FinishDate.Replace("-", "/") & "'" & "," & "'" & frmMain.animeList(i).Myrated & "'" & "," _
                & frmMain.animeList(i).Score & "," & "'" & frmMain.animeList(i).Mydvd & "'" & "," & "'" & frmMain.animeList(i).Mystorage & "'" & "," _
                & "'" & frmMain.animeList(i).Status & "'" & "," & "'" & frmMain.animeList(i).Mycomments & "'" & "," & frmMain.animeList(i).Mytimeswatched & "," _
                & "'" & frmMain.animeList(i).Myrewatch & "'" & "," & "'" & frmMain.animeList(i).Mytags & "'" & "," & frmMain.animeList(i).Myrewatching & "," _
                & frmMain.animeList(i).Myrewatchingep & "," & frmMain.animeList(i).Updateonimport & ")"
            Else
                stringLine = "(" & "'" & frmMain.animeList(i).AnimeId & "'" & "," & "'" & frmMain.animeList(i).Title & "'" & "," & "'" & frmMain.animeList(i).Type & "'" & "," _
                & frmMain.animeList(i).Episodes & "," & frmMain.animeList(i).MyId & "," & frmMain.animeList(i).WatchedEps & "," _
                & "'" & frmMain.animeList(i).StartDate.Replace("-", "/") & "'" & "," & "'" & frmMain.animeList(i).FinishDate.Replace("-", "/") & "'" & "," & "'" & frmMain.animeList(i).Myrated & "'" & "," _
                & frmMain.animeList(i).Score & "," & "'" & frmMain.animeList(i).Mydvd & "'" & "," & "'" & frmMain.animeList(i).Mystorage & "'" & "," _
                & "'" & frmMain.animeList(i).Status & "'" & "," & "'" & frmMain.animeList(i).Mycomments & "'" & "," & frmMain.animeList(i).Mytimeswatched & "," _
                & "'" & frmMain.animeList(i).Myrewatch & "'" & "," & "'" & frmMain.animeList(i).Mytags & "'" & "," & frmMain.animeList(i).Myrewatching & "," _
                & frmMain.animeList(i).Myrewatchingep & "," & frmMain.animeList(i).Updateonimport & ")" & ","
            End If

            objWriter.WriteLine(stringLine)
        Next

        stringLine = "SELECT * FROM mal" & frmMain.userList(0).UserId & frmMain.userList(0).Username
        objWriter.WriteLine(stringLine)

        objWriter.Close()

        Dim workingPage As Saving

        workingPage = New Saving
        workingPage.ShowDialog()
    End Sub

    Private Sub frmSave_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmSave_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmSave_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class