<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembersForm
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
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Location = New System.Drawing.Point(0, 278)
        Me.dgvMembers.MultiSelect = False
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.ReadOnly = True
        Me.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembers.Size = New System.Drawing.Size(800, 172)
        Me.dgvMembers.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "MEMBERS MANAGEMENT"
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.Salmon
        Me.PanelTop.Controls.Add(Me.Label2)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(800, 61)
        Me.PanelTop.TabIndex = 14
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.RosyBrown
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 61)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(41, 389)
        Me.PanelLeft.TabIndex = 15
        '
        'PanelMain
        '
        Me.PanelMain.Controls.Add(Me.btnClear)
        Me.PanelMain.Controls.Add(Me.btnDelete)
        Me.PanelMain.Controls.Add(Me.btnUpdate)
        Me.PanelMain.Controls.Add(Me.btnAdd)
        Me.PanelMain.Controls.Add(Me.txtAddress)
        Me.PanelMain.Controls.Add(Me.lblAddress)
        Me.PanelMain.Controls.Add(Me.txtEmail)
        Me.PanelMain.Controls.Add(Me.lblEmail)
        Me.PanelMain.Controls.Add(Me.txtPhone)
        Me.PanelMain.Controls.Add(Me.Label1)
        Me.PanelMain.Controls.Add(Me.txtFullName)
        Me.PanelMain.Controls.Add(Me.lblFullName)
        Me.PanelMain.Location = New System.Drawing.Point(96, 65)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(703, 213)
        Me.PanelMain.TabIndex = 16
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(423, 148)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 40)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(304, 148)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 40)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(176, 148)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 40)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(57, 148)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 40)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(482, 70)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(167, 32)
        Me.txtAddress.TabIndex = 21
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(368, 79)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(76, 23)
        Me.lblAddress.TabIndex = 20
        Me.lblAddress.Text = "Address"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(176, 70)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(167, 32)
        Me.txtEmail.TabIndex = 19
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(53, 79)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(60, 23)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(482, 3)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(167, 32)
        Me.txtPhone.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(382, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Phone"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(176, 6)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(167, 32)
        Me.txtFullName.TabIndex = 15
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(53, 15)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(99, 23)
        Me.lblFullName.TabIndex = 14
        Me.lblFullName.Text = "Full Name"
        '
        'MembersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.dgvMembers)
        Me.Name = "MembersForm"
        Me.Text = "MembersForm"
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblFullName As Label
End Class
