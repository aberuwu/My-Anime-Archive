'*******************************************************
'* File: Anime.vb
'* Type: Class
'* Purpose: Anime class stores all anime information
'* loaded from XML file.  Properties are used for each.
'* Last Updated: 06/08/2019
'*******************************************************
Public Class Anime

    Private _animeId As String = ""
    Private _title As String = ""
    Private _type As String = ""
    Private _episodes As String = ""
    Private _myId As String = ""
    Private _watchedEps As String = ""
    Private _startDate As String = ""
    Private _finishDate As String = ""
    Private _score As String = ""
    Private _Status As String = ""
    Private _myrated As String = ""
    Private _mydvd As String = ""
    Private _mystorage As String = ""
    Private _mycomments As String = ""
    Private _mytimeswatched As String = ""
    Private _myrewatch As String = ""
    Private _mytags As String = ""
    Private _myrewatching As String = ""
    Private _myrewatchingep As String = ""
    Private _updateonimport As String = ""


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

    Public Property MyId As String
        Get
            Return _myId
        End Get
        Set(value As String)
            _myId = value
        End Set
    End Property

    Public Property WatchedEps As String
        Get
            Return _watchedEps
        End Get
        Set(value As String)
            _watchedEps = value
        End Set
    End Property

    Public Property Score As String
        Get
            Return _score
        End Get
        Set(value As String)
            _score = value
        End Set
    End Property

    Public Property StartDate As String
        Get
            Return _startDate
        End Get
        Set(value As String)
            _startDate = value
        End Set
    End Property

    Public Property FinishDate As String
        Get
            Return _finishDate
        End Get
        Set(value As String)
            _finishDate = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _Status
        End Get
        Set(value As String)
            _Status = value
        End Set
    End Property

    Public Property Myrated As String
        Get
            Return _myrated
        End Get
        Set(value As String)
            _myrated = value
        End Set
    End Property

    Public Property Mydvd As String
        Get
            Return _mydvd
        End Get
        Set(value As String)
            _mydvd = value
        End Set
    End Property

    Public Property Mystorage As String
        Get
            Return _mystorage
        End Get
        Set(value As String)
            _mystorage = value
        End Set
    End Property

    Public Property Mycomments As String
        Get
            Return _mycomments
        End Get
        Set(value As String)
            _mycomments = value
        End Set
    End Property

    Public Property Mytimeswatched As String
        Get
            Return _mytimeswatched
        End Get
        Set(value As String)
            _mytimeswatched = value
        End Set
    End Property

    Public Property Myrewatch As String
        Get
            Return _myrewatch
        End Get
        Set(value As String)
            _myrewatch = value
        End Set
    End Property

    Public Property Mytags As String
        Get
            Return _mytags
        End Get
        Set(value As String)
            _mytags = value
        End Set
    End Property

    Public Property Myrewatching As String
        Get
            Return _myrewatching
        End Get
        Set(value As String)
            _myrewatching = value
        End Set
    End Property

    Public Property Myrewatchingep As String
        Get
            Return _myrewatchingep
        End Get
        Set(value As String)
            _myrewatchingep = value
        End Set
    End Property

    Public Property Updateonimport As String
        Get
            Return _updateonimport
        End Get
        Set(value As String)
            _updateonimport = value
        End Set
    End Property
End Class
