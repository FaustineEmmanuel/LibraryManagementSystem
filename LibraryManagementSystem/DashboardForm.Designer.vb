<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnLogout2 = New System.Windows.Forms.Button()
        Me.btnDefaulter = New System.Windows.Forms.Button()
        Me.btnIssued = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PanelDashboard = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblDefaulters = New System.Windows.Forms.Label()
        Me.lblIssuedBooks = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.lblTotalBooks = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelDashboard.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 52)
        Me.Panel1.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.MediumBlue
        Me.btnLogout.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Location = New System.Drawing.Point(672, 9)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(29, 32)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "X"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUser.Location = New System.Drawing.Point(514, 14)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(152, 23)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Welcome, Admin"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(65, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(245, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Library Management System"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Black
        Me.PanelMenu.Controls.Add(Me.btnLogout2)
        Me.PanelMenu.Controls.Add(Me.btnDefaulter)
        Me.PanelMenu.Controls.Add(Me.btnIssued)
        Me.PanelMenu.Controls.Add(Me.btnRecords)
        Me.PanelMenu.Controls.Add(Me.btnReturn)
        Me.PanelMenu.Controls.Add(Me.btnIssue)
        Me.PanelMenu.Controls.Add(Me.btnStudents)
        Me.PanelMenu.Controls.Add(Me.btnBooks)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.btnHome)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 52)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(190, 398)
        Me.PanelMenu.TabIndex = 1
        '
        'btnLogout2
        '
        Me.btnLogout2.BackColor = System.Drawing.Color.Black
        Me.btnLogout2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout2.Location = New System.Drawing.Point(24, 360)
        Me.btnLogout2.Name = "btnLogout2"
        Me.btnLogout2.Size = New System.Drawing.Size(148, 32)
        Me.btnLogout2.TabIndex = 9
        Me.btnLogout2.Text = "Logout"
        Me.btnLogout2.UseVisualStyleBackColor = False
        '
        'btnDefaulter
        '
        Me.btnDefaulter.BackColor = System.Drawing.Color.Black
        Me.btnDefaulter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDefaulter.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaulter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDefaulter.Location = New System.Drawing.Point(24, 320)
        Me.btnDefaulter.Name = "btnDefaulter"
        Me.btnDefaulter.Size = New System.Drawing.Size(148, 32)
        Me.btnDefaulter.TabIndex = 8
        Me.btnDefaulter.Text = "Defaulter List"
        Me.btnDefaulter.UseVisualStyleBackColor = False
        '
        'btnIssued
        '
        Me.btnIssued.BackColor = System.Drawing.Color.Black
        Me.btnIssued.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssued.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssued.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIssued.Location = New System.Drawing.Point(24, 281)
        Me.btnIssued.Name = "btnIssued"
        Me.btnIssued.Size = New System.Drawing.Size(148, 32)
        Me.btnIssued.TabIndex = 7
        Me.btnIssued.Text = "Issued Books"
        Me.btnIssued.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.Black
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecords.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRecords.Location = New System.Drawing.Point(24, 243)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(148, 32)
        Me.btnRecords.TabIndex = 6
        Me.btnRecords.Text = "View Records"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Black
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReturn.Location = New System.Drawing.Point(24, 199)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(148, 32)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "Return Book"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnIssue
        '
        Me.btnIssue.BackColor = System.Drawing.Color.Black
        Me.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssue.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIssue.Location = New System.Drawing.Point(24, 160)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(148, 32)
        Me.btnIssue.TabIndex = 4
        Me.btnIssue.Text = "Issue Book"
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'btnStudents
        '
        Me.btnStudents.BackColor = System.Drawing.Color.Black
        Me.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudents.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStudents.Location = New System.Drawing.Point(24, 119)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(148, 32)
        Me.btnStudents.TabIndex = 3
        Me.btnStudents.Text = "Manage Students"
        Me.btnStudents.UseVisualStyleBackColor = False
        '
        'btnBooks
        '
        Me.btnBooks.BackColor = System.Drawing.Color.Black
        Me.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBooks.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBooks.Location = New System.Drawing.Point(24, 81)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(148, 32)
        Me.btnBooks.TabIndex = 2
        Me.btnBooks.Text = "Manage Books"
        Me.btnBooks.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Black
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDashboard.Location = New System.Drawing.Point(24, 43)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(148, 32)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "LMS Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Red
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHome.Location = New System.Drawing.Point(24, 6)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(148, 32)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home Page"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'PanelDashboard
        '
        Me.PanelDashboard.Controls.Add(Me.Panel9)
        Me.PanelDashboard.Controls.Add(Me.Panel8)
        Me.PanelDashboard.Controls.Add(Me.Panel7)
        Me.PanelDashboard.Controls.Add(Me.lblDefaulters)
        Me.PanelDashboard.Controls.Add(Me.lblIssuedBooks)
        Me.PanelDashboard.Controls.Add(Me.lblTotalStudents)
        Me.PanelDashboard.Controls.Add(Me.lblTotalBooks)
        Me.PanelDashboard.Controls.Add(Me.Panel5)
        Me.PanelDashboard.Controls.Add(Me.Panel4)
        Me.PanelDashboard.Controls.Add(Me.Panel3)
        Me.PanelDashboard.Controls.Add(Me.Panel2)
        Me.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDashboard.Location = New System.Drawing.Point(190, 52)
        Me.PanelDashboard.Name = "PanelDashboard"
        Me.PanelDashboard.Size = New System.Drawing.Size(610, 128)
        Me.PanelDashboard.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Red
        Me.Panel9.Location = New System.Drawing.Point(410, 43)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(98, 8)
        Me.Panel9.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel8.Location = New System.Drawing.Point(283, 43)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(98, 8)
        Me.Panel8.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Red
        Me.Panel7.Location = New System.Drawing.Point(156, 43)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(98, 8)
        Me.Panel7.TabIndex = 3
        '
        'lblDefaulters
        '
        Me.lblDefaulters.AutoSize = True
        Me.lblDefaulters.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaulters.Location = New System.Drawing.Point(406, 13)
        Me.lblDefaulters.Name = "lblDefaulters"
        Me.lblDefaulters.Size = New System.Drawing.Size(90, 19)
        Me.lblDefaulters.TabIndex = 5
        Me.lblDefaulters.Text = "Defaulter List"
        '
        'lblIssuedBooks
        '
        Me.lblIssuedBooks.AutoSize = True
        Me.lblIssuedBooks.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssuedBooks.Location = New System.Drawing.Point(278, 12)
        Me.lblIssuedBooks.Name = "lblIssuedBooks"
        Me.lblIssuedBooks.Size = New System.Drawing.Size(92, 19)
        Me.lblIssuedBooks.TabIndex = 4
        Me.lblIssuedBooks.Text = "Issued Books"
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.AutoSize = True
        Me.lblTotalStudents.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudents.Location = New System.Drawing.Point(151, 13)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(105, 19)
        Me.lblTotalStudents.TabIndex = 3
        Me.lblTotalStudents.Text = "No. of Students"
        '
        'lblTotalBooks
        '
        Me.lblTotalBooks.AutoSize = True
        Me.lblTotalBooks.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBooks.Location = New System.Drawing.Point(24, 12)
        Me.lblTotalBooks.Name = "lblTotalBooks"
        Me.lblTotalBooks.Size = New System.Drawing.Size(93, 19)
        Me.lblTotalBooks.TabIndex = 2
        Me.lblTotalBooks.Text = "No. of Books"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Location = New System.Drawing.Point(409, 44)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(99, 75)
        Me.Panel5.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 36)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "2"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(3, 27)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(43, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Location = New System.Drawing.Point(282, 44)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(99, 75)
        Me.Panel4.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 36)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "2"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 27)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(155, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(99, 75)
        Me.Panel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(28, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(99, 75)
        Me.Panel2.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel6.Location = New System.Drawing.Point(1, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(98, 8)
        Me.Panel6.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(190, 180)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(610, 270)
        Me.PanelMain.TabIndex = 3
        Me.PanelMain.Visible = False
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelDashboard)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelDashboard.ResumeLayout(False)
        Me.PanelDashboard.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnIssue As Button
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnLogout2 As Button
    Friend WithEvents btnDefaulter As Button
    Friend WithEvents btnIssued As Button
    Friend WithEvents btnRecords As Button
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents lblTotalBooks As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDefaulters As Label
    Friend WithEvents lblIssuedBooks As Label
    Friend WithEvents lblTotalStudents As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PanelMain As Panel
End Class
