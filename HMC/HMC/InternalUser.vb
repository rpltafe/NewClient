Public Class InternalUser

    Private _UserId As Integer, _StaffId As Integer, _PractitionerId As Integer
    Private _Username As String, _FirstName As String, _LastName As String

    Public Property UserId As Integer
        Get
            Return _UserId
        End Get
        Set(value As Integer)
            _UserId = value
        End Set
    End Property

    Public Property StaffId As Integer
        Get
            Return _StaffId
        End Get
        Set(value As Integer)
            _StaffId = value
        End Set
    End Property

    Public Property PractitionerId As Integer
        Get
            Return _PractitionerId
        End Get
        Set(value As Integer)
            _PractitionerId = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _Username
        End Get
        Set(value As String)
            _Username = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property

    Public ReadOnly Property IsPractitioner As Boolean
        Get
            Return PractitionerId > 0
        End Get
    End Property

    Public Sub New()

    End Sub
End Class
