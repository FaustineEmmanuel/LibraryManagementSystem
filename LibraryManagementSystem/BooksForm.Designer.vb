<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BooksForm))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.Panelleft = New System.Windows.Forms.Panel()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.Blue
        Me.PanelTop.Controls.Add(Me.PictureBox1)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(800, 78)
        Me.PanelTop.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(173, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOOK MANAGEMENTS"
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvBooks.Location = New System.Drawing.Point(0, 297)
        Me.dgvBooks.MultiSelect = False
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(800, 198)
        Me.dgvBooks.TabIndex = 9
        '
        'Panelleft
        '
        Me.Panelleft.BackColor = System.Drawing.Color.Firebrick
        Me.Panelleft.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelleft.Location = New System.Drawing.Point(0, 78)
        Me.Panelleft.Name = "Panelleft"
        Me.Panelleft.Size = New System.Drawing.Size(74, 219)
        Me.Panelleft.TabIndex = 10
        '
        'PanelMain
        '
        Me.PanelMain.Controls.Add(Me.btnClear)
        Me.PanelMain.Controls.Add(Me.btnDelete)
        Me.PanelMain.Controls.Add(Me.btnUpdate)
        Me.PanelMain.Controls.Add(Me.btnAdd)
        Me.PanelMain.Controls.Add(Me.txtQuantity)
        Me.PanelMain.Controls.Add(Me.lblQuantity)
        Me.PanelMain.Controls.Add(Me.txtCategory)
        Me.PanelMain.Controls.Add(Me.lblCategory)
        Me.PanelMain.Controls.Add(Me.txtAuthor)
        Me.PanelMain.Controls.Add(Me.lblAuthor)
        Me.PanelMain.Controls.Add(Me.lblTitle)
        Me.PanelMain.Controls.Add(Me.txtTitle)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(74, 78)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(726, 219)
        Me.PanelMain.TabIndex = 11
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Salmon
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(429, 171)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 42)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Salmon
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(299, 171)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(76, 42)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Salmon
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(173, 171)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 42)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Salmon
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(66, 171)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 42)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(257, 130)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(296, 32)
        Me.txtQuantity.TabIndex = 16
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(128, 130)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(118, 31)
        Me.lblQuantity.TabIndex = 15
        Me.lblQuantity.Text = "Quantity"
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(257, 88)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(296, 32)
        Me.txtCategory.TabIndex = 14
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(128, 84)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(121, 31)
        Me.lblCategory.TabIndex = 13
        Me.lblCategory.Text = "Category"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(257, 47)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(296, 32)
        Me.txtAuthor.TabIndex = 12
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(128, 43)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(98, 31)
        Me.lblAuthor.TabIndex = 11
        Me.lblAuthor.Text = "Author"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(128, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(76, 31)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Title "
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(257, 7)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(296, 32)
        Me.txtTitle.TabIndex = 9
        '
        'BooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 495)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panelleft)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "BooksForm"
        Me.Text = "BooksForm"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents Panelleft As Panel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnClear As Button
End Class
