<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotReturnedBooksForm
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
        Me.dgvNotReturnedBooks = New System.Windows.Forms.DataGridView()
        Me.btnExport = New System.Windows.Forms.Button()
        CType(Me.dgvNotReturnedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNotReturnedBooks
        '
        Me.dgvNotReturnedBooks.AllowUserToAddRows = False
        Me.dgvNotReturnedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNotReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotReturnedBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNotReturnedBooks.Location = New System.Drawing.Point(0, 0)
        Me.dgvNotReturnedBooks.Name = "dgvNotReturnedBooks"
        Me.dgvNotReturnedBooks.ReadOnly = True
        Me.dgvNotReturnedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotReturnedBooks.Size = New System.Drawing.Size(800, 450)
        Me.dgvNotReturnedBooks.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(584, 355)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(170, 60)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Export to Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'NotReturnedBooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.dgvNotReturnedBooks)
        Me.Name = "NotReturnedBooksForm"
        Me.Text = "NotReturnedBooksForm"
        CType(Me.dgvNotReturnedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvNotReturnedBooks As DataGridView
    Friend WithEvents btnExport As Button
End Class
