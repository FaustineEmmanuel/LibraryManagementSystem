Imports System.Data.SqlClient

Public Class ReturnedBooksForm

    ' ================= FORM LOAD =================
    Private Sub ReturnedBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReturnedBooks()
        StyleGrid()
    End Sub

    ' ================= LOAD RETURNED BOOKS =================
    Private Sub LoadReturnedBooks()

        Using con As SqlConnection = GetConnection()

            Dim query As String =
                "SELECT 
                    b.BorrowID,
                    m.FullName AS Member,
                    bk.Title AS Book,
                    b.IssueDate,
                    b.ReturnDate
                 FROM BorrowedBooks b
                 INNER JOIN Members m ON b.MemberID = m.MemberID
                 INNER JOIN Books bk ON b.BookID = bk.BookID
                 WHERE b.Status = 'Returned'
                 ORDER BY b.ReturnDate DESC"

            Dim da As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvReturnedBooks.DataSource = dt

        End Using

    End Sub

    ' ================= GRID STYLE =================
    Private Sub StyleGrid()
        With dgvReturnedBooks
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 28
        End With
    End Sub

End Class
