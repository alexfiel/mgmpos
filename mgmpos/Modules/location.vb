Public Class location
    Private LocationName As String
    Private LocationDescription As String

    Public Property LocName As String
        Get
            Return LocationName
        End Get
        Set(value As String)
            LocationName = value
        End Set
    End Property
    Public Property LocDescription As String
        Get
            Return LocationDescription
        End Get
        Set(value As String)
            LocationDescription = value
        End Set
    End Property
End Class
