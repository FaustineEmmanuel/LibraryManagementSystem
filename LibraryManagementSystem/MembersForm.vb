Imports System.Data.SqlClient

Public Class MembersForm

    Private selectedMemberID As Integer = -1

    ' ================= FORM LOAD =================
    Private Sub MembersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleGrid()
        LoadMembers()
    End Sub

    ' ================= LOAD MEMBERS =================
    Private Sub LoadMembers()
        Try
            Using con As SqlConnection = GetConnection()
                Dim query As String =
                    "SELECT MemberID,
                            FullName,
                            Phone,
                            ISNULL(Email,'') AS Email,
                            ISNULL(Address,'') AS Address
                     FROM Members"

                Using da As New SqlDataAdapter(query, con)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvMembers.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load Members Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= GRID STYLE =================
    Private Sub StyleGrid()
        With dgvMembers
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 28

            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font =
                New Font("Segoe UI", 10, FontStyle.Bold)
        End With
    End Sub

    ' ================= GRID CLICK =================
    Private Sub dgvMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvMembers.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMembers.Rows(e.RowIndex)

            selectedMemberID = CInt(row.Cells("MemberID").Value)
            txtFullName.Text = row.Cells("FullName").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
            txtEmail.Text = row.Cells("Email").Value.ToString()
            txtAddress.Text = row.Cells("Address").Value.ToString()
        End If
    End Sub

    ' ================= ADD MEMBER =================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtFullName.Text.Trim() = "" Then
            MessageBox.Show("Full Name is required")
            Exit Sub
        End If

        Try
            Using con As SqlConnection = GetConnection()
                Dim query As String =
                    "INSERT INTO Members (FullName, Phone, Email, Address)
                     VALUES (@FullName, @Phone, @Email, @Address)"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = txtFullName.Text.Trim()
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtPhone.Text.Trim()
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value =
                        If(txtEmail.Text.Trim() = "", DBNull.Value, txtEmail.Text.Trim())
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value =
                        If(txtAddress.Text.Trim() = "", DBNull.Value, txtAddress.Text.Trim())

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Member added successfully")
            ClearFields()
            LoadMembers()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= UPDATE MEMBER =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If selectedMemberID = -1 Then
            MessageBox.Show("Please select a member to update")
            Exit Sub
        End If

        Try
            Using con As SqlConnection = GetConnection()
                Dim query As String =
                    "UPDATE Members SET
                        FullName=@FullName,
                        Phone=@Phone,
                        Email=@Email,
                        Address=@Address
                     WHERE MemberID=@MemberID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = txtFullName.Text.Trim()
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtPhone.Text.Trim()
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value =
                        If(txtEmail.Text.Trim() = "", DBNull.Value, txtEmail.Text.Trim())
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value =
                        If(txtAddress.Text.Trim() = "", DBNull.Value, txtAddress.Text.Trim())
                    cmd.Parameters.Add("@MemberID", SqlDbType.Int).Value = selectedMemberID

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Member updated successfully")
            ClearFields()
            LoadMembers()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= DELETE MEMBER =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If selectedMemberID = -1 Then
            MessageBox.Show("Please select a member to delete")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this member?",
                           "Confirm",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        Try
            Using con As SqlConnection = GetConnection()
                Dim query As String = "DELETE FROM Members WHERE MemberID=@MemberID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@MemberID", SqlDbType.Int).Value = selectedMemberID
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Member deleted successfully")
            ClearFields()
            LoadMembers()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtFullName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        selectedMemberID = -1
        dgvMembers.ClearSelection()
    End Sub

End Class
