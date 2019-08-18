Public Class User

    Private _userId As String = ""
    Private _username As String = ""
    Private _totalAnime As String = ""
    Private _totalWatching As String = ""
    Private _totalCompleted As String = ""
    Private _totalOnHold As String = ""
    Private _totalDropped As String = ""
    Private _plaToWatch As String = ""
    Private _userExportType As String = ""

    Public Property UserId As String
        Get
            Return _userId
        End Get
        Set(value As String)
            _userId = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property TotalAnime As String
        Get
            Return _totalAnime
        End Get
        Set(value As String)
            _totalAnime = value
        End Set
    End Property

    Public Property TotalWatching As String
        Get
            Return _totalWatching
        End Get
        Set(value As String)
            _totalWatching = value
        End Set
    End Property

    Public Property TotalCompleted As String
        Get
            Return _totalCompleted
        End Get
        Set(value As String)
            _totalCompleted = value
        End Set
    End Property

    Public Property TotalOnHold As String
        Get
            Return _totalOnHold
        End Get
        Set(value As String)
            _totalOnHold = value
        End Set
    End Property

    Public Property TotalDropped As String
        Get
            Return _totalDropped
        End Get
        Set(value As String)
            _totalDropped = value
        End Set
    End Property

    Public Property PlaToWatch As String
        Get
            Return _plaToWatch
        End Get
        Set(value As String)
            _plaToWatch = value
        End Set
    End Property

    Public Property UserExportType As String
        Get
            Return _userExportType
        End Get
        Set(value As String)
            _userExportType = value
        End Set
    End Property
End Class
