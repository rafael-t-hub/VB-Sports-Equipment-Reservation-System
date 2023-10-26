<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register_User
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbCourseAndSection = New System.Windows.Forms.ComboBox()
        Me.cbShowPass1 = New System.Windows.Forms.CheckBox()
        Me.cbShowPass = New System.Windows.Forms.CheckBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tBConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblAdminConfirmPass = New System.Windows.Forms.Label()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.lblAdminPass = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.lblAdminUsername = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tbPhoneNum = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbIDNum = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnkSignUp = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.STUDENT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STUDENT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEAR_AND_SECTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONE_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbpassword = New System.Windows.Forms.TextBox()
        Me.Tbun = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Tbpn = New System.Windows.Forms.TextBox()
        Me.Tbstatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tbyearandsection = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Tbid = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCourseAndSection
        '
        Me.cbCourseAndSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.cbCourseAndSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourseAndSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCourseAndSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.cbCourseAndSection.FormattingEnabled = True
        Me.cbCourseAndSection.Items.AddRange(New Object() {"BSCS - 1A", "BSCS - 1B", "BSCS - 2A", "BSCS - 3A", "BSCS - 4A"})
        Me.cbCourseAndSection.Location = New System.Drawing.Point(1122, 288)
        Me.cbCourseAndSection.Name = "cbCourseAndSection"
        Me.cbCourseAndSection.Size = New System.Drawing.Size(370, 39)
        Me.cbCourseAndSection.TabIndex = 63
        '
        'cbShowPass1
        '
        Me.cbShowPass1.AutoSize = True
        Me.cbShowPass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cbShowPass1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbShowPass1.Location = New System.Drawing.Point(1274, 629)
        Me.cbShowPass1.Name = "cbShowPass1"
        Me.cbShowPass1.Size = New System.Drawing.Size(143, 19)
        Me.cbShowPass1.TabIndex = 61
        Me.cbShowPass1.Text = "Show/Hide Password"
        Me.cbShowPass1.UseVisualStyleBackColor = True
        '
        'cbShowPass
        '
        Me.cbShowPass.AutoSize = True
        Me.cbShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cbShowPass.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cbShowPass.Location = New System.Drawing.Point(1274, 573)
        Me.cbShowPass.Name = "cbShowPass"
        Me.cbShowPass.Size = New System.Drawing.Size(143, 19)
        Me.cbShowPass.TabIndex = 60
        Me.cbShowPass.Text = "Show/Hide Password"
        Me.cbShowPass.UseVisualStyleBackColor = True
        '
        'tbLastName
        '
        Me.tbLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.tbLastName.Location = New System.Drawing.Point(683, 296)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(370, 31)
        Me.tbLastName.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(599, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Last Name"
        '
        'tBConfirmPass
        '
        Me.tBConfirmPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tBConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tBConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.tBConfirmPass.Location = New System.Drawing.Point(683, 525)
        Me.tBConfirmPass.Name = "tBConfirmPass"
        Me.tBConfirmPass.Size = New System.Drawing.Size(370, 31)
        Me.tBConfirmPass.TabIndex = 57
        Me.tBConfirmPass.UseSystemPasswordChar = True
        '
        'lblAdminConfirmPass
        '
        Me.lblAdminConfirmPass.AutoSize = True
        Me.lblAdminConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblAdminConfirmPass.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAdminConfirmPass.Location = New System.Drawing.Point(557, 549)
        Me.lblAdminConfirmPass.Name = "lblAdminConfirmPass"
        Me.lblAdminConfirmPass.Size = New System.Drawing.Size(107, 15)
        Me.lblAdminConfirmPass.TabIndex = 56
        Me.lblAdminConfirmPass.Text = "Confirm Password"
        '
        'tbPass
        '
        Me.tbPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.tbPass.Location = New System.Drawing.Point(1122, 433)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(370, 31)
        Me.tbPass.TabIndex = 55
        Me.tbPass.UseSystemPasswordChar = True
        '
        'lblAdminPass
        '
        Me.lblAdminPass.AutoSize = True
        Me.lblAdminPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblAdminPass.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAdminPass.Location = New System.Drawing.Point(597, 487)
        Me.lblAdminPass.Name = "lblAdminPass"
        Me.lblAdminPass.Size = New System.Drawing.Size(61, 15)
        Me.lblAdminPass.TabIndex = 54
        Me.lblAdminPass.Text = "Password"
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.tbUsername.Location = New System.Drawing.Point(683, 433)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(370, 31)
        Me.tbUsername.TabIndex = 53
        '
        'lblAdminUsername
        '
        Me.lblAdminUsername.AutoSize = True
        Me.lblAdminUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblAdminUsername.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAdminUsername.Location = New System.Drawing.Point(599, 418)
        Me.lblAdminUsername.Name = "lblAdminUsername"
        Me.lblAdminUsername.Size = New System.Drawing.Size(65, 15)
        Me.lblAdminUsername.TabIndex = 52
        Me.lblAdminUsername.Text = "Username"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(894, 652)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(237, 51)
        Me.btnRegister.TabIndex = 51
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'tbEmail
        '
        Me.tbEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.tbEmail.Location = New System.Drawing.Point(1122, 364)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(370, 31)
        Me.tbEmail.TabIndex = 50
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblEmail.Location = New System.Drawing.Point(625, 379)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 49
        Me.lblEmail.Text = "Email"
        '
        'tbPhoneNum
        '
        Me.tbPhoneNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tbPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.tbPhoneNum.Location = New System.Drawing.Point(683, 364)
        Me.tbPhoneNum.Name = "tbPhoneNum"
        Me.tbPhoneNum.Size = New System.Drawing.Size(370, 31)
        Me.tbPhoneNum.TabIndex = 48
        '
        'tbName
        '
        Me.tbName.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.tbName.Location = New System.Drawing.Point(1135, 205)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(370, 31)
        Me.tbName.TabIndex = 46
        '
        'tbIDNum
        '
        Me.tbIDNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tbIDNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbIDNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.tbIDNum.Location = New System.Drawing.Point(683, 205)
        Me.tbIDNum.Name = "tbIDNum"
        Me.tbIDNum.Size = New System.Drawing.Size(370, 31)
        Me.tbIDNum.TabIndex = 45
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblName.Location = New System.Drawing.Point(625, 222)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 15)
        Me.lblName.TabIndex = 44
        Me.lblName.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Tbpassword)
        Me.Panel1.Controls.Add(Me.Tbun)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Tbpn)
        Me.Panel1.Controls.Add(Me.Tbstatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Tbyearandsection)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.Tbid)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.DGV1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.cbCourseAndSection)
        Me.Panel1.Controls.Add(Me.cbShowPass1)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.cbShowPass)
        Me.Panel1.Controls.Add(Me.lblAdminUsername)
        Me.Panel1.Controls.Add(Me.lnkSignUp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tbLastName)
        Me.Panel1.Controls.Add(Me.lblAdminPass)
        Me.Panel1.Controls.Add(Me.tBConfirmPass)
        Me.Panel1.Controls.Add(Me.lblAdminConfirmPass)
        Me.Panel1.Controls.Add(Me.tbPass)
        Me.Panel1.Controls.Add(Me.tbUsername)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.tbEmail)
        Me.Panel1.Controls.Add(Me.tbPhoneNum)
        Me.Panel1.Controls.Add(Me.tbName)
        Me.Panel1.Controls.Add(Me.tbIDNum)
        Me.Panel1.Location = New System.Drawing.Point(0, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1583, 1062)
        Me.Panel1.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(1162, 418)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "PASSWORD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1162, 318)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "USERNAME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1162, 217)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 15)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "EMAIL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(1162, 122)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 15)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "PHONE NUMBER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(861, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 20)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Already Registered?"
        '
        'lnkSignUp
        '
        Me.lnkSignUp.AutoSize = True
        Me.lnkSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lnkSignUp.Location = New System.Drawing.Point(1020, 109)
        Me.lnkSignUp.Name = "lnkSignUp"
        Me.lnkSignUp.Size = New System.Drawing.Size(48, 20)
        Me.lnkSignUp.TabIndex = 64
        Me.lnkSignUp.TabStop = True
        Me.lnkSignUp.Text = "Login"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 1086)
        Me.Panel2.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("MS PGothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(699, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(614, 48)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Create New Student Account"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToResizeColumns = False
        Me.DGV1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow
        Me.DGV1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STUDENT_ID, Me.STUDENT_NAME, Me.YEAR_AND_SECTION, Me.STATUS, Me.PHONE_NUMBER, Me.EMAIL, Me.USERNAME, Me.PASSWORD, Me.NO})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV1.Location = New System.Drawing.Point(139, 276)
        Me.DGV1.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV1.RowHeadersWidth = 51
        Me.DGV1.RowTemplate.Height = 50
        Me.DGV1.RowTemplate.ReadOnly = True
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(1304, 511)
        Me.DGV1.TabIndex = 80
        '
        'STUDENT_ID
        '
        Me.STUDENT_ID.HeaderText = "STUDENT_ ID"
        Me.STUDENT_ID.MinimumWidth = 6
        Me.STUDENT_ID.Name = "STUDENT_ID"
        Me.STUDENT_ID.ReadOnly = True
        Me.STUDENT_ID.Width = 125
        '
        'STUDENT_NAME
        '
        Me.STUDENT_NAME.HeaderText = "STUDENT_NAME"
        Me.STUDENT_NAME.MinimumWidth = 6
        Me.STUDENT_NAME.Name = "STUDENT_NAME"
        Me.STUDENT_NAME.ReadOnly = True
        Me.STUDENT_NAME.Width = 250
        '
        'YEAR_AND_SECTION
        '
        Me.YEAR_AND_SECTION.HeaderText = "YEAR_AND_SECTION"
        Me.YEAR_AND_SECTION.MinimumWidth = 6
        Me.YEAR_AND_SECTION.Name = "YEAR_AND_SECTION"
        Me.YEAR_AND_SECTION.ReadOnly = True
        Me.YEAR_AND_SECTION.Width = 125
        '
        'STATUS
        '
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.MinimumWidth = 6
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        Me.STATUS.Width = 125
        '
        'PHONE_NUMBER
        '
        Me.PHONE_NUMBER.HeaderText = "PHONE_NUMBER"
        Me.PHONE_NUMBER.MinimumWidth = 6
        Me.PHONE_NUMBER.Name = "PHONE_NUMBER"
        Me.PHONE_NUMBER.ReadOnly = True
        Me.PHONE_NUMBER.Width = 125
        '
        'EMAIL
        '
        Me.EMAIL.HeaderText = "EMAIL"
        Me.EMAIL.MinimumWidth = 6
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        Me.EMAIL.Width = 250
        '
        'USERNAME
        '
        Me.USERNAME.HeaderText = "USERNAME"
        Me.USERNAME.MinimumWidth = 6
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.ReadOnly = True
        Me.USERNAME.Width = 125
        '
        'PASSWORD
        '
        Me.PASSWORD.HeaderText = "PASSWORD"
        Me.PASSWORD.MinimumWidth = 6
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.ReadOnly = True
        Me.PASSWORD.Width = 125
        '
        'NO
        '
        Me.NO.HeaderText = "NO"
        Me.NO.Name = "NO"
        Me.NO.ReadOnly = True
        Me.NO.Visible = False
        '
        'Tbpassword
        '
        Me.Tbpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbpassword.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbpassword.ForeColor = System.Drawing.Color.White
        Me.Tbpassword.Location = New System.Drawing.Point(915, 674)
        Me.Tbpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbpassword.Multiline = True
        Me.Tbpassword.Name = "Tbpassword"
        Me.Tbpassword.Size = New System.Drawing.Size(360, 37)
        Me.Tbpassword.TabIndex = 96
        '
        'Tbun
        '
        Me.Tbun.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbun.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbun.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbun.ForeColor = System.Drawing.Color.White
        Me.Tbun.Location = New System.Drawing.Point(915, 574)
        Me.Tbun.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbun.Multiline = True
        Me.Tbun.Name = "Tbun"
        Me.Tbun.Size = New System.Drawing.Size(360, 37)
        Me.Tbun.TabIndex = 95
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(915, 473)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 37)
        Me.TextBox1.TabIndex = 94
        '
        'Tbpn
        '
        Me.Tbpn.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbpn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbpn.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbpn.ForeColor = System.Drawing.Color.White
        Me.Tbpn.Location = New System.Drawing.Point(915, 377)
        Me.Tbpn.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbpn.Multiline = True
        Me.Tbpn.Name = "Tbpn"
        Me.Tbpn.Size = New System.Drawing.Size(360, 37)
        Me.Tbpn.TabIndex = 93
        '
        'Tbstatus
        '
        Me.Tbstatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbstatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbstatus.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbstatus.ForeColor = System.Drawing.Color.White
        Me.Tbstatus.Location = New System.Drawing.Point(310, 674)
        Me.Tbstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbstatus.Multiline = True
        Me.Tbstatus.Name = "Tbstatus"
        Me.Tbstatus.Size = New System.Drawing.Size(360, 37)
        Me.Tbstatus.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(912, 648)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(912, 548)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "USERNAME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(912, 447)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 15)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "EMAIL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(912, 352)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 15)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "PHONE NUMBER"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(307, 648)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 15)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "STATUS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(307, 548)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 15)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "YEAR AND SECTION"
        '
        'Tbyearandsection
        '
        Me.Tbyearandsection.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbyearandsection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbyearandsection.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbyearandsection.ForeColor = System.Drawing.Color.White
        Me.Tbyearandsection.Location = New System.Drawing.Point(310, 574)
        Me.Tbyearandsection.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbyearandsection.Multiline = True
        Me.Tbyearandsection.Name = "Tbyearandsection"
        Me.Tbyearandsection.Size = New System.Drawing.Size(360, 37)
        Me.Tbyearandsection.TabIndex = 85
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(307, 352)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "STUDENT ID"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label.Location = New System.Drawing.Point(307, 447)
        Me.Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(42, 15)
        Me.Label.TabIndex = 83
        Me.Label.Text = "NAME"
        '
        'Tbid
        '
        Me.Tbid.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbid.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbid.ForeColor = System.Drawing.Color.White
        Me.Tbid.Location = New System.Drawing.Point(310, 377)
        Me.Tbid.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbid.Multiline = True
        Me.Tbid.Name = "Tbid"
        Me.Tbid.Size = New System.Drawing.Size(360, 37)
        Me.Tbid.TabIndex = 82
        Me.Tbid.Tag = ""
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(310, 473)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(360, 37)
        Me.TextBox2.TabIndex = 81
        '
        'Register_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1581, 1059)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register_User"
        Me.Text = "Register_UserRegister_User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCourseAndSection As ComboBox
    Friend WithEvents cbShowPass1 As CheckBox
    Friend WithEvents cbShowPass As CheckBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tBConfirmPass As TextBox
    Friend WithEvents lblAdminConfirmPass As Label
    Friend WithEvents tbPass As TextBox
    Friend WithEvents lblAdminPass As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents lblAdminUsername As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbPhoneNum As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbIDNum As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lnkSignUp As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents STUDENT_ID As DataGridViewTextBoxColumn
    Friend WithEvents STUDENT_NAME As DataGridViewTextBoxColumn
    Friend WithEvents YEAR_AND_SECTION As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents PHONE_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents USERNAME As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORD As DataGridViewTextBoxColumn
    Friend WithEvents NO As DataGridViewTextBoxColumn
    Friend WithEvents Tbpassword As TextBox
    Friend WithEvents Tbun As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Tbpn As TextBox
    Friend WithEvents Tbstatus As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Tbyearandsection As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Tbid As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
