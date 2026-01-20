Imports System.Data.SqlClient

Public Class IssuedBooksForm

    Private selectedBorrowID As Integer = -1

    ' ================= FORM LOAD =================
    Private Sub IssuedBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIssuedBooks()
        StyleGrid()
    End Sub

    ' ================= LOAD ISSUED BOOKS =================
    Private Sub LoadIssuedBooks()

        Using con As SqlConnection = GetConnection()

            Dim query As String =
                "SELECT 
                    b.BorrowID,
                    m.FullName AS Member,
                    bk.Title AS Book,
                    b.IssueDate
                 FROM BorrowedBooks b
                 INNER JOIN Members m ON b.MemberID = m.MemberID
                 INNER JOIN Books bk ON b.BookID = bk.BookID
                 WHERE b.Status = 'Issued'
                 ORDER BY b.IssueDate DESC"

            Dim da As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvIssuedBooks.DataSource = dt

        End Using

    End Sub

    ' ================= GRID STYLE =================
    Private Sub StyleGrid()
        With dgvIssuedBooks
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 28
        End With
    End Sub

    ' ================= GRID CLICK =================
    Private Sub dgvIssuedBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvIssuedBooks.CellClick

        If e.RowIndex >= 0 Then
            selectedBorrowID =
                Convert.ToInt32(dgvIssuedBooks.Rows(e.RowIndex).Cells("BorrowID").Value)
        End If

    End Sub

    ' ================= RETURN BOOK =================
    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click

        If selectedBorrowID = -1 Then
            MessageBox.Show("Please select a book to return")
            Exit Sub
        End If

        Using con As SqlConnection = GetConnection()

            Dim query As String =
                "UPDATE BorrowedBooks
                 SET Status = 'Returned',
                     ReturnDate = GETDATE()
                 WHERE BorrowID = @BorrowID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.Add("@BorrowID", SqlDbType.Int).Value = selectedBorrowID
                con.Open()
                cmd.ExecuteNonQuery()
            End Using

        End Using

        MessageBox.Show("Book returned successfully")

        selectedBorrowID = -1
        LoadIssuedBooks()

    End Sub

End Class
