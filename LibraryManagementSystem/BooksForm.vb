Imports System.Data.SqlClient

Public Class BooksForm

    Private selectedBookID As Integer = -1

    ' ================= FORM LOAD =================
    Private Sub BooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleGrid()
        LoadBooks()
    End Sub

    ' ================= LOAD BOOKS =================
    Private Sub LoadBooks()
        Try
            Using con As SqlConnection = GetConnection()
                Dim query As String =
                    "SELECT BookID,
                            Title,
                            ISNULL(Author,'') AS Author,
                            ISNULL(Category,'') AS Category,
                            Quantity
                     FROM Books"

                Using da As New SqlDataAdapter(query, con)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvBooks.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load Books Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= GRID STYLE =================
    Private Sub StyleGrid()
        With dgvBooks
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 28

            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font =
                New Font("Segoe UI", 10, FontStyle.Bold)
        End With
    End Sub

    ' ================= GRID CLICK =================
    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvBooks.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBooks.Rows(e.RowIndex)

            selectedBookID = CInt(row.Cells("BookID").Value)
            txtTitle.Text = row.Cells("Title").Value.ToString()
            txtAuthor.Text = row.Cells("Author").Value.ToString()
            txtCategory.Text = row.Cells("Category").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
        End If
    End Sub

    ' ================= ADD BOOK =================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtTitle.Text.Trim() = "" Then
            MessageBox.Show("Book title is required")
            Exit Sub
        End If

        Try
            Using con As SqlConnection = GetConnection()
                Dim query As String =
                    "INSERT INTO Books (Title, Author, Category, Quantity)
                     VALUES (@Title, @Author, @Category, @Quantity)"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = txtTitle.Text.Trim()
                    cmd.Parameters.Add("@Author", SqlDbType.NVarChar).Value =
                        If(txtAuthor.Text.Trim() = "", DBNull.Value, txtAuthor.Text.Trim())
                    cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value =
                        If(txtCategory.Text.Trim() = "", DBNull.Value, txtCategory.Text.Trim())
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value =
                        Integer.Parse(txtQuantity.Text.Trim())

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book added successfully")
            ClearFields()
            LoadBooks()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Book Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= UPDATE BOOK =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If selectedBookID = -1 Then
            MessageBox.Show("Please select a book to update")
            Exit Sub
        End If

        Try
            Using con As SqlConnection = GetConnection()
                Dim query As String =
                    "UPDATE Books SET
                        Title=@Title,
                        Author=@Author,
                        Category=@Category,
                        Quantity=@Quantity
                     WHERE BookID=@BookID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = txtTitle.Text.Trim()
                    cmd.Parameters.Add("@Author", SqlDbType.NVarChar).Value =
                        If(txtAuthor.Text.Trim() = "", DBNull.Value, txtAuthor.Text.Trim())
                    cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value =
                        If(txtCategory.Text.Trim() = "", DBNull.Value, txtCategory.Text.Trim())
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value =
                        Integer.Parse(txtQuantity.Text.Trim())
                    cmd.Parameters.Add("@BookID", SqlDbType.Int).Value = selectedBookID

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book updated successfully")
            ClearFields()
            LoadBooks()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Book Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= DELETE BOOK =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If selectedBookID = -1 Then
            MessageBox.Show("Please select a book to delete")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this book?",
                           "Confirm",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        Try
            Using con As SqlConnection = GetConnection()
                Dim query As String = "DELETE FROM Books WHERE BookID=@BookID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@BookID", SqlDbType.Int).Value = selectedBookID
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book deleted successfully")
            ClearFields()
            LoadBooks()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete Book Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtCategory.Clear()
        txtQuantity.Clear()
        selectedBookID = -1
        dgvBooks.ClearSelection()
    End Sub

    Private Sub PanelMain_Paint(sender As Object, e As PaintEventArgs) Handles PanelMain.Paint

    End Sub
End Class
