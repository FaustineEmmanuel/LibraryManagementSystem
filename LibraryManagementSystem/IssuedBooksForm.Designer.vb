<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssuedBooksForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvIssuedBooks = New System.Windows.Forms.DataGridView()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        CType(Me.dgvIssuedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvIssuedBooks
        '
        Me.dgvIssuedBooks.AllowUserToAddRows = False
        Me.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIssuedBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIssuedBooks.Location = New System.Drawing.Point(0, 0)
        Me.dgvIssuedBooks.Name = "dgvIssuedBooks"
        Me.dgvIssuedBooks.ReadOnly = True
        Me.dgvIssuedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIssuedBooks.Size = New System.Drawing.Size(800, 450)
        Me.dgvIssuedBooks.TabIndex = 0
        '
        'btnReturnBook
        '
        Me.btnReturnBook.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnReturnBook.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.Location = New System.Drawing.Point(0, 396)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(800, 54)
        Me.btnReturnBook.TabIndex = 1
        Me.btnReturnBook.Text = "Return Book"
        Me.btnReturnBook.UseVisualStyleBackColor = True
        '
        'IssuedBooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.dgvIssuedBooks)
        Me.Name = "IssuedBooksForm"
        Me.Text = "IssuedBooksForm"
        CType(Me.dgvIssuedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvIssuedBooks As DataGridView
    Friend WithEvents btnReturnBook As Button
End Class
