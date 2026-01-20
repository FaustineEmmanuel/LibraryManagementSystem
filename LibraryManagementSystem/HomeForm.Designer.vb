<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblIssuedCount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNotReturnedCount = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMembersCount = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblReturnedCount = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBooksCount = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBorrowedCount = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel6.Controls.Add(Me.PictureBox14)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.lblIssuedCount)
        Me.Panel6.Location = New System.Drawing.Point(476, 143)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(198, 127)
        Me.Panel6.TabIndex = 12
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(36, 36)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(109, 85)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 10
        Me.PictureBox14.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(50, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 31)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "issued"
        '
        'lblIssuedCount
        '
        Me.lblIssuedCount.AutoSize = True
        Me.lblIssuedCount.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssuedCount.Location = New System.Drawing.Point(22, 5)
        Me.lblIssuedCount.Name = "lblIssuedCount"
        Me.lblIssuedCount.Size = New System.Drawing.Size(28, 31)
        Me.lblIssuedCount.TabIndex = 5
        Me.lblIssuedCount.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.PictureBox13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblNotReturnedCount)
        Me.Panel1.Location = New System.Drawing.Point(156, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 127)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(47, 36)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(115, 85)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 4
        Me.PictureBox13.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(62, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 23)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Not Returned"
        '
        'lblNotReturnedCount
        '
        Me.lblNotReturnedCount.AutoSize = True
        Me.lblNotReturnedCount.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotReturnedCount.Location = New System.Drawing.Point(25, 5)
        Me.lblNotReturnedCount.Name = "lblNotReturnedCount"
        Me.lblNotReturnedCount.Size = New System.Drawing.Size(28, 31)
        Me.lblNotReturnedCount.TabIndex = 3
        Me.lblNotReturnedCount.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.PictureBox9)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblMembersCount)
        Me.Panel2.Location = New System.Drawing.Point(126, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 108)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(31, 36)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(78, 62)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 2
        Me.PictureBox9.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Members"
        '
        'lblMembersCount
        '
        Me.lblMembersCount.AutoSize = True
        Me.lblMembersCount.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembersCount.Location = New System.Drawing.Point(9, 2)
        Me.lblMembersCount.Name = "lblMembersCount"
        Me.lblMembersCount.Size = New System.Drawing.Size(28, 31)
        Me.lblMembersCount.TabIndex = 0
        Me.lblMembersCount.Text = "0"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGreen
        Me.Panel5.Controls.Add(Me.PictureBox12)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.lblReturnedCount)
        Me.Panel5.Location = New System.Drawing.Point(582, 23)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(123, 104)
        Me.Panel5.TabIndex = 9
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(29, 38)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(71, 56)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 8
        Me.PictureBox12.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 31)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Returned"
        '
        'lblReturnedCount
        '
        Me.lblReturnedCount.AutoSize = True
        Me.lblReturnedCount.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnedCount.Location = New System.Drawing.Point(-4, 4)
        Me.lblReturnedCount.Name = "lblReturnedCount"
        Me.lblReturnedCount.Size = New System.Drawing.Size(28, 31)
        Me.lblReturnedCount.TabIndex = 7
        Me.lblReturnedCount.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel3.Controls.Add(Me.PictureBox10)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblBooksCount)
        Me.Panel3.Location = New System.Drawing.Point(273, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(123, 106)
        Me.Panel3.TabIndex = 8
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(23, 31)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(88, 63)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 4
        Me.PictureBox10.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Books"
        '
        'lblBooksCount
        '
        Me.lblBooksCount.AutoSize = True
        Me.lblBooksCount.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooksCount.Location = New System.Drawing.Point(3, 0)
        Me.lblBooksCount.Name = "lblBooksCount"
        Me.lblBooksCount.Size = New System.Drawing.Size(28, 31)
        Me.lblBooksCount.TabIndex = 3
        Me.lblBooksCount.Text = "0"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Controls.Add(Me.PictureBox11)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.lblBorrowedCount)
        Me.Panel4.Location = New System.Drawing.Point(425, 21)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(133, 106)
        Me.Panel4.TabIndex = 10
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(14, 37)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(100, 63)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 6
        Me.PictureBox11.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Borrowed"
        '
        'lblBorrowedCount
        '
        Me.lblBorrowedCount.AutoSize = True
        Me.lblBorrowedCount.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowedCount.Location = New System.Drawing.Point(3, 2)
        Me.lblBorrowedCount.Name = "lblBorrowedCount"
        Me.lblBorrowedCount.Size = New System.Drawing.Size(28, 31)
        Me.lblBorrowedCount.TabIndex = 5
        Me.lblBorrowedCount.Text = "0"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblIssuedCount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNotReturnedCount As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMembersCount As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblReturnedCount As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBooksCount As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBorrowedCount As Label
End Class
