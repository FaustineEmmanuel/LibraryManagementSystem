Public Class DashboardForm
    Public Sub OpenChildForm(childForm As Form)
        PanelDashboard.Visible = False
        PanelMain.Visible = True

        PanelMain.Controls.Clear()

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        PanelMain.Controls.Add(childForm)
        childForm.Show()
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        PanelMain.Controls.Clear()
        PanelMain.Visible = False
        PanelDashboard.Visible = True
    End Sub
    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        OpenChildForm(New BooksForm)
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        OpenChildForm(New MembersForm)
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        OpenChildForm(New IssueForm)
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        OpenChildForm(New ReturnForm)
    End Sub

    Private Sub btnIssued_Click(sender As Object, e As EventArgs) Handles btnIssued.Click
        OpenChildForm(New IssuedBooksForm)
    End Sub
    Private Sub btnDefaulter_Click(sender As Object, e As EventArgs) Handles btnDefaulter.Click
        OpenChildForm(New DefaulterForm)
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?",
                       "Logout",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) = DialogResult.Yes Then

            LoginForm.Show()
            Me.Close()
        End If
    End Sub

End Class