<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnedBooksForm
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
        Me.dgvReturnedBooks = New System.Windows.Forms.DataGridView()
        CType(Me.dgvReturnedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReturnedBooks
        '
        Me.dgvReturnedBooks.AllowUserToDeleteRows = False
        Me.dgvReturnedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnedBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReturnedBooks.Location = New System.Drawing.Point(0, 0)
        Me.dgvReturnedBooks.Name = "dgvReturnedBooks"
        Me.dgvReturnedBooks.ReadOnly = True
        Me.dgvReturnedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturnedBooks.Size = New System.Drawing.Size(800, 450)
        Me.dgvReturnedBooks.TabIndex = 0
        '
        'ReturnedBooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvReturnedBooks)
        Me.Name = "ReturnedBooksForm"
        Me.Text = "ReturnedBooksForm"
        CType(Me.dgvReturnedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvReturnedBooks As DataGridView
End Class
