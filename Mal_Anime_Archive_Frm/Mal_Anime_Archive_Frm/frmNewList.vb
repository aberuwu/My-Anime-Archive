Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports JikanDotNet

Public Class frmNewList
    Public Property loadedNewUser As Boolean = False
    Private USER_IMG_URL As String
    Private USER_NAME As String
    Private USER_ID As String
    Private Sub frmNewList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lblSearching.Visible = True
        loadApiInfo(mtxtUserName.Text)
        lblSearching.Visible = False
    End Sub

    Private Sub loadApiInfo(userName As String)
        Dim apiConnect As HttpWebRequest
        Dim apiUrl As String = "http://api.jikan.moe/v3/user/" & userName
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Try
            If frmMain.CheckConnection(apiUrl) = True Then
                apiConnect = DirectCast(WebRequest.Create(apiUrl), HttpWebRequest)
                response = DirectCast(apiConnect.GetResponse(), HttpWebResponse)


                reader = New StreamReader(response.GetResponseStream)

                Dim rawresp As String

                rawresp = reader.ReadToEnd()

                Dim jsonResulttodict = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(rawresp)

                Dim animeImage = jsonResulttodict.Item("image_url")
                pcbUserImage.Load(animeImage)

                Dim malUserName = jsonResulttodict.Item("username")
                lblDisplayUserName.Text = malUserName

                Dim tempId1 As String
                Dim tempId2 As String
                tempId1 = animeImage.ToString.Replace(".jpg", "")
                tempId2 = tempId1.Remove(0, 46)

                lblDisplayUserID.Text = tempId2

                USER_ID = tempId2
                USER_NAME = malUserName
            End If
        Catch ex As Exception
            MsgBox("No user found, please try again!")
            Return
        End Try

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        newUser(USER_NAME, USER_ID)
        Me.Close()
        WelcomeOpen.Close()
        frmMain.loadedXml = True
    End Sub

    Private Sub newUser(userName As String, userId As String)

        frmMain.animeList.Clear()
        frmMain.userList.Clear()

        frmMain.userList.Add(New User)
        frmMain.userList(0).UserId = userId
        frmMain.userList(0).Username = userName
        frmMain.userList(0).TotalAnime = "0"
        frmMain.userList(0).TotalWatching = "0"
        frmMain.userList(0).TotalCompleted = "0"
        frmMain.userList(0).TotalOnHold = "0"
        frmMain.userList(0).TotalDropped = "0"
        frmMain.userList(0).PlaToWatch = "0"
        frmMain.userList(0).UserExportType = "1"

        'Dim newAnime As frmNewAnime
        'newAnime = New frmNewAnime
        'newAnime.ShowDialog()
    End Sub
End Class