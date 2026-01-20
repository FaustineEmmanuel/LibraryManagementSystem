Public Class Dashboard

    Private isMenuExpanded As Boolean = True
    Private expandedWidth As Integer = 200
    Private collapsedWidth As Integer = 60

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        TimerMenu.Start()
    End Sub

    Private Sub TimerMenu_Tick(sender As Object, e As EventArgs) Handles TimerMenu.Tick

        If isMenuExpanded Then
            PanelLeft.Width -= 10

            If PanelLeft.Width <= collapsedWidth Then
                TimerMenu.Stop()
                PanelLeft.Width = collapsedWidth
                isMenuExpanded = False
                HideMenuText()
            End If
        Else
            PanelLeft.Width += 10

            If PanelLeft.Width >= expandedWidth Then
                TimerMenu.Stop()
                PanelLeft.Width = expandedWidth
                isMenuExpanded = True
                ShowMenuText()
            End If
        End If

    End Sub

    Private Sub HideMenuText()
        For Each ctrl As Control In PanelLeft.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Text = ""
                CType(ctrl, Button).ImageAlign = ContentAlignment.MiddleCenter
            End If
        Next
    End Sub

    Private Sub ShowMenuText()
        btnHome.Text = " Home"
        btnMembers.Text = " Members"
        btnBooks.Text = " Books"
        btnBorrowedBooks.Text = " BorrowedBooks"
        btnIssuedBooks.Text = " IssuedBook"
        btnReturnedBooks.Text = " ReturnedBook"
        btnNotReturnBooks.Text = " NotReturned_Book"
        btnExit.Text = " Exit System"
    End Sub
    Private Sub LoadForm(childForm As Form)

        PanelMain.Controls.Clear()

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        PanelMain.Controls.Add(childForm)
        childForm.Show()

    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        LoadForm(New HomeForm())
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        LoadForm(New MembersForm())
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        LoadForm(New BooksForm())
    End Sub

    Private Sub btnBorrowedBooks_Click(sender As Object, e As EventArgs) Handles btnBorrowedBooks.Click
        LoadForm(New BorrowedBooksForm())
    End Sub

    Private Sub btnIssuedBooks_Click(sender As Object, e As EventArgs) Handles btnIssuedBooks.Click
        LoadForm(New IssuedBooksForm())
    End Sub

    Private Sub btnReturnedBooks_Click(sender As Object, e As EventArgs) Handles btnReturnedBooks.Click
        LoadForm(New ReturnedBooksForm())
    End Sub

    Private Sub btnNotReturnedBooks_Click(sender As Object, e As EventArgs) Handles btnNotReturnBooks.Click
        LoadForm(New NotReturnedBooksForm())
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadForm(New HomeForm())
    End Sub



End Class
