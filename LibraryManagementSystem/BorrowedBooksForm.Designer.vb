<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowedBooksForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBorrowedBooks = New System.Windows.Forms.DataGridView()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.btnIssueBook = New System.Windows.Forms.Button()
        Me.cmbBooks = New System.Windows.Forms.ComboBox()
        Me.cmbMembers = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMember = New System.Windows.Forms.Label()
        Me.PanelTop.SuspendLayout()
        CType(Me.dgvBorrowedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.Green
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(800, 64)
        Me.PanelTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BORROW BOOK"
        '
        'dgvBorrowedBooks
        '
        Me.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvBorrowedBooks.Location = New System.Drawing.Point(0, 246)
        Me.dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        Me.dgvBorrowedBooks.Size = New System.Drawing.Size(800, 204)
        Me.dgvBorrowedBooks.TabIndex = 1
        '
        'PanelMain
        '
        Me.PanelMain.Controls.Add(Me.btnIssueBook)
        Me.PanelMain.Controls.Add(Me.cmbBooks)
        Me.PanelMain.Controls.Add(Me.cmbMembers)
        Me.PanelMain.Controls.Add(Me.Label2)
        Me.PanelMain.Controls.Add(Me.lblMember)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 64)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(800, 182)
        Me.PanelMain.TabIndex = 2
        '
        'btnIssueBook
        '
        Me.btnIssueBook.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueBook.Location = New System.Drawing.Point(241, 110)
        Me.btnIssueBook.Name = "btnIssueBook"
        Me.btnIssueBook.Size = New System.Drawing.Size(192, 47)
        Me.btnIssueBook.TabIndex = 4
        Me.btnIssueBook.Text = "Borrow Book"
        Me.btnIssueBook.UseVisualStyleBackColor = True
        '
        'cmbBooks
        '
        Me.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBooks.FormattingEnabled = True
        Me.cmbBooks.Location = New System.Drawing.Point(406, 67)
        Me.cmbBooks.Name = "cmbBooks"
        Me.cmbBooks.Size = New System.Drawing.Size(121, 21)
        Me.cmbBooks.TabIndex = 3
        '
        'cmbMembers
        '
        Me.cmbMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMembers.FormattingEnabled = True
        Me.cmbMembers.Location = New System.Drawing.Point(406, 29)
        Me.cmbMembers.Name = "cmbMembers"
        Me.cmbMembers.Size = New System.Drawing.Size(121, 21)
        Me.cmbMembers.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Member"
        '
        'lblMember
        '
        Me.lblMember.AutoSize = True
        Me.lblMember.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMember.Location = New System.Drawing.Point(235, 17)
        Me.lblMember.Name = "lblMember"
        Me.lblMember.Size = New System.Drawing.Size(112, 31)
        Me.lblMember.TabIndex = 0
        Me.lblMember.Text = "Member"
        '
        'BorrowedBooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.dgvBorrowedBooks)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "BorrowedBooksForm"
        Me.Text = "BorrowedBooksForm"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.dgvBorrowedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBorrowedBooks As DataGridView
    Friend WithEvents PanelMain As Panel
    Friend WithEvents cmbBooks As ComboBox
    Friend WithEvents cmbMembers As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMember As Label
    Friend WithEvents btnIssueBook As Button
End Class
