Public Class QueryAnime


    Private _animeImageUrl As String = ""
    Private _animeId As String = ""
    Private _title As String = ""
    Private _type As String = ""
    Private _episodes As String = ""

    Public Property AnimeId As String
        Get
            Return _animeId
        End Get
        Set(value As String)
            _animeId = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property

    Public Property Episodes As String
        Get
            Return _episodes
        End Get
        Set(value As String)
            _episodes = value
        End Set
    End Property

    Public Property AnimeImageUrl As String
        Get
            Return _animeImageUrl
        End Get
        Set(value As String)
            _animeImageUrl = value
        End Set
    End Property
End Class
