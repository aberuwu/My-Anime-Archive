Public Class ServerStatus
    Public ServerName As String
    Public Logo As Image
    Public StatusColor As Color

    Public Sub New(ByVal new_ServerName As String, ByVal new_Logo As Image, ByVal new_StatusColor As Color)
        ServerName = new_ServerName
        Logo = new_Logo
        StatusColor = new_StatusColor
    End Sub
End Class
