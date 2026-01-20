Imports System.Data.SqlClient

Public Class BorrowedBooksForm

    ' ================= FORM LOAD =================
    Private Sub BorrowedBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMembers()
        LoadBooks()
        LoadBorrowedBooks()
        StyleGrid()
    End Sub

    ' ================= LOAD MEMBERS =================
    Private Sub LoadMembers()
        Using con As SqlConnection = GetConnection()
            Dim da As New SqlDataAdapter(
                "SELECT MemberID, FullName FROM Members", con)

            Dim dt As New DataTable()
            da.Fill(dt)

            cmbMembers.DataSource = dt
            cmbMembers.DisplayMember = "FullName"
            cmbMembers.ValueMember = "MemberID"
            cmbMembers.SelectedIndex = -1
        End Using
    End Sub

    ' ================= LOAD BOOKS =================
    Private Sub LoadBooks()
        Using con As SqlConnection = GetConnection()
            Dim da As New SqlDataAdapter(
                "SELECT BookID, Title FROM Books", con)

            Dim dt As New DataTable()
            da.Fill(dt)

            cmbBooks.DataSource = dt
            cmbBooks.DisplayMember = "Title"
            cmbBooks.ValueMember = "BookID"
            cmbBooks.SelectedIndex = -1
        End Using
    End Sub

    ' ================= ISSUE BOOK =================
    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click

        MessageBox.Show("Button clicked") ' DEBUG

        If cmbMembers.SelectedIndex = -1 Or cmbBooks.SelectedIndex = -1 Then
            MessageBox.Show("Please select both Member and Book")
            Exit Sub
        End If

        Using con As SqlConnection = GetConnection()
            con.Open()

            Dim checkQuery As String =
            "SELECT COUNT(*) FROM BorrowedBooks
             WHERE BookID = @BookID AND Status = 'Issued'"

            Using checkCmd As New SqlCommand(checkQuery, con)
                checkCmd.Parameters.Add("@BookID", SqlDbType.Int).Value =
                Convert.ToInt32(cmbBooks.SelectedValue)

                Dim count As Integer =
                Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This book is already issued.")
                    Exit Sub
                End If
            End Using

            Dim insertQuery As String =
            "INSERT INTO BorrowedBooks (MemberID, BookID, IssueDate, Status)
             VALUES (@MemberID, @BookID, GETDATE(), 'Issued')"

            Using insertCmd As New SqlCommand(insertQuery, con)
                insertCmd.Parameters.Add("@MemberID", SqlDbType.Int).Value =
                Convert.ToInt32(cmbMembers.SelectedValue)
                insertCmd.Parameters.Add("@BookID", SqlDbType.Int).Value =
                Convert.ToInt32(cmbBooks.SelectedValue)

                insertCmd.ExecuteNonQuery()
            End Using

        End Using

        MessageBox.Show("Book issued successfully")
        LoadBorrowedBooks()

    End Sub


    ' ================= LOAD BORROWED BOOKS =================
    Private Sub LoadBorrowedBooks()
        Using con As SqlConnection = GetConnection()

            Dim query As String =
                "SELECT 
                    b.BorrowID,
                    m.FullName AS Member,
                    bk.Title AS Book,
                    b.IssueDate,
                    b.ReturnDate,
                    b.Status
                 FROM BorrowedBooks b
                 INNER JOIN Members m ON b.MemberID = m.MemberID
                 INNER JOIN Books bk ON b.BookID = bk.BookID
                 ORDER BY b.IssueDate DESC"

            Dim da As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvBorrowedBooks.DataSource = dt

        End Using
    End Sub

    ' ================= GRID STYLE =================
    Private Sub StyleGrid()
        With dgvBorrowedBooks
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 28
        End With
    End Sub
End Class
