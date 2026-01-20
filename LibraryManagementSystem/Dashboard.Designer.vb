<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnNotReturnBooks = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnBorrowedBooks = New System.Windows.Forms.Button()
        Me.btnIssuedBooks = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnReturnedBooks = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.TimerMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLeft.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTop.Controls.Add(Me.btnMenu)
        Me.PanelTop.Controls.Add(Me.PictureBox1)
        Me.PanelTop.Controls.Add(Me.lblUser)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.ForeColor = System.Drawing.Color.MintCream
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(914, 63)
        Me.PanelTop.TabIndex = 0
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.SteelBlue
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(8, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(70, 55)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "__" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "__" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "__"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(746, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUser.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(781, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(88, 31)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Admin"
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelLeft.Controls.Add(Me.PanelBottom)
        Me.PanelLeft.Controls.Add(Me.PanelMenu)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 63)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(303, 444)
        Me.PanelLeft.TabIndex = 1
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.btnExit)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 395)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(303, 49)
        Me.PanelBottom.TabIndex = 16
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(0, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(303, 49)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoSize = True
        Me.PanelMenu.Controls.Add(Me.PictureBox8)
        Me.PanelMenu.Controls.Add(Me.PictureBox7)
        Me.PanelMenu.Controls.Add(Me.PictureBox6)
        Me.PanelMenu.Controls.Add(Me.PictureBox5)
        Me.PanelMenu.Controls.Add(Me.PictureBox4)
        Me.PanelMenu.Controls.Add(Me.PictureBox3)
        Me.PanelMenu.Controls.Add(Me.PictureBox2)
        Me.PanelMenu.Controls.Add(Me.btnHome)
        Me.PanelMenu.Controls.Add(Me.btnNotReturnBooks)
        Me.PanelMenu.Controls.Add(Me.btnMembers)
        Me.PanelMenu.Controls.Add(Me.btnBorrowedBooks)
        Me.PanelMenu.Controls.Add(Me.btnIssuedBooks)
        Me.PanelMenu.Controls.Add(Me.btnBooks)
        Me.PanelMenu.Controls.Add(Me.btnReturnedBooks)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(303, 360)
        Me.PanelMenu.TabIndex = 15
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(13, 314)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(50, 36)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 19
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(12, 262)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 36)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(13, 212)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(50, 36)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 17
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(12, 161)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 103)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 53)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(71, 7)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHome.Size = New System.Drawing.Size(109, 44)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnNotReturnBooks
        '
        Me.btnNotReturnBooks.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnNotReturnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotReturnBooks.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnNotReturnBooks.FlatAppearance.BorderSize = 0
        Me.btnNotReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotReturnBooks.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotReturnBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNotReturnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotReturnBooks.Location = New System.Drawing.Point(73, 304)
        Me.btnNotReturnBooks.Name = "btnNotReturnBooks"
        Me.btnNotReturnBooks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnNotReturnBooks.Size = New System.Drawing.Size(240, 53)
        Me.btnNotReturnBooks.TabIndex = 10
        Me.btnNotReturnBooks.Text = "NotReturnedBooks"
        Me.btnNotReturnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotReturnBooks.UseVisualStyleBackColor = False
        '
        'btnMembers
        '
        Me.btnMembers.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMembers.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnMembers.FlatAppearance.BorderSize = 0
        Me.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMembers.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMembers.Location = New System.Drawing.Point(69, 54)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMembers.Size = New System.Drawing.Size(124, 50)
        Me.btnMembers.TabIndex = 2
        Me.btnMembers.Text = "Members"
        Me.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnBorrowedBooks
        '
        Me.btnBorrowedBooks.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBorrowedBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowedBooks.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnBorrowedBooks.FlatAppearance.BorderSize = 0
        Me.btnBorrowedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowedBooks.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowedBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrowedBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowedBooks.Location = New System.Drawing.Point(66, 145)
        Me.btnBorrowedBooks.Name = "btnBorrowedBooks"
        Me.btnBorrowedBooks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBorrowedBooks.Size = New System.Drawing.Size(217, 68)
        Me.btnBorrowedBooks.TabIndex = 6
        Me.btnBorrowedBooks.Text = "BorrowedBooks"
        Me.btnBorrowedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowedBooks.UseVisualStyleBackColor = False
        '
        'btnIssuedBooks
        '
        Me.btnIssuedBooks.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnIssuedBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssuedBooks.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnIssuedBooks.FlatAppearance.BorderSize = 0
        Me.btnIssuedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuedBooks.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssuedBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIssuedBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssuedBooks.Location = New System.Drawing.Point(69, 203)
        Me.btnIssuedBooks.Name = "btnIssuedBooks"
        Me.btnIssuedBooks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnIssuedBooks.Size = New System.Drawing.Size(206, 54)
        Me.btnIssuedBooks.TabIndex = 8
        Me.btnIssuedBooks.Text = "IssuedBooks"
        Me.btnIssuedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssuedBooks.UseVisualStyleBackColor = False
        '
        'btnBooks
        '
        Me.btnBooks.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBooks.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnBooks.FlatAppearance.BorderSize = 0
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(70, 99)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBooks.Size = New System.Drawing.Size(119, 53)
        Me.btnBooks.TabIndex = 4
        Me.btnBooks.Text = "Books"
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.UseVisualStyleBackColor = False
        '
        'btnReturnedBooks
        '
        Me.btnReturnedBooks.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnReturnedBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturnedBooks.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btnReturnedBooks.FlatAppearance.BorderSize = 0
        Me.btnReturnedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnedBooks.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnedBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReturnedBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturnedBooks.Location = New System.Drawing.Point(73, 259)
        Me.btnReturnedBooks.Name = "btnReturnedBooks"
        Me.btnReturnedBooks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReturnedBooks.Size = New System.Drawing.Size(200, 61)
        Me.btnReturnedBooks.TabIndex = 12
        Me.btnReturnedBooks.Text = "ReturnedBooks"
        Me.btnReturnedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturnedBooks.UseVisualStyleBackColor = False
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.White
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(303, 63)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(611, 444)
        Me.PanelMain.TabIndex = 7
        '
        'TimerMenu
        '
        Me.TimerMenu.Interval = 10
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 507)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeft.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnMembers As Button
    Friend WithEvents btnBorrowedBooks As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents btnReturnedBooks As Button
    Friend WithEvents btnNotReturnBooks As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnMenu As Button
    Friend WithEvents TimerMenu As Timer
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnIssuedBooks As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
