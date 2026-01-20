Imports System.Data.SqlClient

Public Class HomeForm

    Private Function GetCount(query As String) As Integer
        Using con As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, con)
                con.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardCounts()
    End Sub

    Private Sub LoadDashboardCounts()

        ' Members
        lblMembersCount.Text =
            GetCount("SELECT COUNT(*) FROM Members").ToString()

        ' Books
        lblBooksCount.Text =
            GetCount("SELECT COUNT(*) FROM Books").ToString()

        ' Total Borrowed (all records)
        lblBorrowedCount.Text =
            GetCount("SELECT COUNT(*) FROM BorrowedBooks").ToString()

        ' Issued (not yet returned)
        lblIssuedCount.Text =
            GetCount("SELECT COUNT(*) FROM BorrowedBooks WHERE Status='Issued'").ToString()

        ' Returned
        lblReturnedCount.Text =
            GetCount("SELECT COUNT(*) FROM BorrowedBooks WHERE Status='Returned'").ToString()

        ' Not Returned = Issued
        lblNotReturnedCount.Text =
            GetCount("SELECT COUNT(*) FROM BorrowedBooks WHERE Status='Issued'").ToString()

    End Sub

End Class
