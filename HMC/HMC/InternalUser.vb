Imports MySql.Data.MySqlClient

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

    Public Sub New(staffId As String)
        Dim sql As String = "SELECT user.user_id, staff.staff_id, practitioner.practitioner_id, " & _
                    "user.username, staff.first_name, staff.last_name FROM user LEFT JOIN staff ON staff.user_id " & _
                    "= user.user_id LEFT JOIN practitioner ON practitioner.staff_id = staff.staff_id WHERE " & _
                    "staff.staff_id = @staffid"

        Using conn As New MySqlConnection(My.Resources.connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                With cmd
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@staffid", staffId)
                End With

                Dim reader = cmd.ExecuteReader
                If reader.Read() Then
                    With Me
                        If reader.IsDBNull(1) Then
                            Throw New Exception("Can only use this application as staff!")
                        Else
                            .StaffId = reader.GetInt32("staff_id")
                        End If
                        If reader.IsDBNull(2) Then
                            .PractitionerId = -1
                        Else
                            .PractitionerId = reader.GetInt32("practitioner_id")
                        End If
                        .UserId = reader.GetInt32("user_id")
                        .Username = reader.GetString("username")
                        .FirstName = reader.GetString("first_name")
                        .LastName = reader.GetString("last_name")
                    End With
                Else
                    Throw New Exception("Could not find user in database!")
                End If
            End Using
        End Using
    End Sub
End Class
