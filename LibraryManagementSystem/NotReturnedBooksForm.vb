Imports System.Data.SqlClient

Public Class NotReturnedBooksForm

    ' ================= FORM LOAD =================
    Private Sub NotReturnedBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNotReturnedBooks()
        StyleGrid()
    End Sub

    ' ================= LOAD NOT RETURNED BOOKS =================
    Private Sub LoadNotReturnedBooks()

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
                   AND b.ReturnDate IS NULL
                 ORDER BY b.IssueDate DESC"

            Dim da As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvNotReturnedBooks.DataSource = dt

        End Using

    End Sub

    ' ================= GRID STYLE =================
    Private Sub StyleGrid()
        With dgvNotReturnedBooks
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 28
        End With
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If dgvNotReturnedBooks.Rows.Count = 0 Then
            MessageBox.Show("No data to export")
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV Files (*.csv)|*.csv"
        sfd.FileName = "NotReturnedBooks.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As New IO.StreamWriter(sfd.FileName)

                ' Headers
                Dim headers = dgvNotReturnedBooks.Columns.Cast(Of DataGridViewColumn)().
                              Select(Function(c) c.HeaderText)
                sw.WriteLine(String.Join(",", headers))

                ' Rows
                For Each row As DataGridViewRow In dgvNotReturnedBooks.Rows
                    Dim cells = row.Cells.Cast(Of DataGridViewCell)().
                                Select(Function(c) c.Value?.ToString())
                    sw.WriteLine(String.Join(",", cells))
                Next

            End Using

            MessageBox.Show("Export completed successfully",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

    End Sub

End Class
