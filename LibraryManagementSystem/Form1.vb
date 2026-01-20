Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter username and password", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()

                Dim query As String =
                    "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUsername.Text.Trim()
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text.Trim()

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count = 1 Then
                        MessageBox.Show("Login Successful", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid Username or Password", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
