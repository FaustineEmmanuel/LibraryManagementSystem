Imports System.Data.SqlClient

Module DBConnection
    ' Connection to LibraryDB
    Public con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True")

    ' Open connection
    Public Sub OpenConnection()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox("Error connecting to database: " & ex.Message)
        End Try
    End Sub

    ' Close connection
    Public Sub CloseConnection()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("Error closing connection: " & ex.Message)
        End Try
    End Sub
End Module
