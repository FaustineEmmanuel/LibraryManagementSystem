Imports System.Data.SqlClient

Module DBConnection

    Private ReadOnly ConnectionString As String =
        "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function

End Module
