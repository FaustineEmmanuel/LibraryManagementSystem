Imports System.Data.SqlClient
Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter username and password", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            OpenConnection()

            Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Login Successful", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                DashboardForm.Show() ' Make sure DashboardForm exists
                Me.Hide()
            Else
                MessageBox.Show("Invalid Login Details", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CloseConnection()
        End Try
    End Sub


End Class
