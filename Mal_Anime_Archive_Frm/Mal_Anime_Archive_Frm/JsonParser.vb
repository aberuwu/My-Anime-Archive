'-------------------------------------------------
' File: JsonParser.vb
' Usage: Stores methods for parsing .json scripts
' Last Updated: 11/01/2019
'--------------------------------------------------

Imports Newtonsoft.Json

Public Class JsonParser

    Public Sub loadJson(ByRef jsonFile As String)
        Dim json As String = jsonFile
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(json)


        frmMain.animeList.Add(New Anime)
        MsgBox(read.Item("animeId"))
    End Sub

End Class
