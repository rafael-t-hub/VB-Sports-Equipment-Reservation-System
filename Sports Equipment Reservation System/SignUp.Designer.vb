<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAdminIDNum = New System.Windows.Forms.TextBox()
        Me.tbAdminPhoneNum = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.tbAdminEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnAdminRegister = New System.Windows.Forms.Button()
        Me.tbAdminPass = New System.Windows.Forms.TextBox()
        Me.lblAdminPass = New System.Windows.Forms.Label()
        Me.tbAdminUsername = New System.Windows.Forms.TextBox()
        Me.lblAdminUsername = New System.Windows.Forms.Label()
        Me.tbAdminConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblAdminConfirmPass = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.MySqlConnection1 = New MySql.Data.MySqlClient.MySqlConnection()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnkSignUp = New System.Windows.Forms.LinkLabel()
        Me.cbShowHidePass = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.tbAdminName = New System.Windows.Forms.TextBox()
        Me.tbAdminLastName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(541, 308)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 15)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(540, 540)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID NUMBER"
        '
        'tbAdminIDNum
        '
        Me.tbAdminIDNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.tbAdminIDNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAdminIDNum.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.tbAdminIDNum.ForeColor = System.Drawing.Color.White
        Me.tbAdminIDNum.HideSelection = False
        Me.tbAdminIDNum.Location = New System.Drawing.Point(543, 567)
        Me.tbAdminIDNum.Name = "tbAdminIDNum"
        Me.tbAdminIDNum.Size = New System.Drawing.Size(360, 28)
        Me.tbAdminIDNum.TabIndex = 6
        '
        'tbAdminPhoneNum
        '
        Me.tbAdminPhoneNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.tbAdminPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAdminPhoneNum.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.tbAdminPhoneNum.ForeColor = System.Drawing.Color.White
        Me.tbAdminPhoneNum.HideSelection = False
        Me.tbAdminPhoneNum.Location = New System.Drawing.Point(1085, 450)
        Me.tbAdminPhoneNum.Name = "tbAdminPhoneNum"
        Me.tbAdminPhoneNum.Size = New System.Drawing.Size(360, 28)
        Me.tbAdminPhoneNum.TabIndex = 10
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(1086, 422)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(107, 15)
        Me.lblPhone.TabIndex = 9
        Me.lblPhone.Text = "PHONE NUMBER"
        '
        'tbAdminEmail
        '
        Me.tbAdminEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.tbAdminEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAdminEmail.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.tbAdminEmail.ForeColor = System.Drawing.Color.White
        Me.tbAdminEmail.HideSelection = False
        Me.tbAdminEmail.Location = New System.Drawing.Point(543, 450)
        Me.tbAdminEmail.Name = "tbAdminEmail"
        Me.tbAdminEmail.Size = New System.Drawing.Size(360, 28)
        Me.tbAdminEmail.TabIndex = 12
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(540, 422)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(43, 15)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "EMAIL"
        '
        'btnAdminRegister
        '
        Me.btnAdminRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdminRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAdminRegister.Location = New System.Drawing.Point(839, 785)
        Me.btnAdminRegister.Name = "btnAdminRegister"
        Me.btnAdminRegister.Size = New System.Drawing.Size(308, 69)
        Me.btnAdminRegister.TabIndex = 13
        Me.btnAdminRegister.Text = "Register"
        Me.btnAdminRegister.UseVisualStyleBackColor = True
        '
        'tbAdminPass
        '
        Me.tbAdminPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.tbAdminPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAdminPass.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.tbAdminPass.ForeColor = System.Drawing.Color.White
        Me.tbAdminPass.HideSelection = False
        Me.tbAdminPass.Location = New System.Drawing.Point(543, 672)
        Me.tbAdminPass.Name = "tbAdminPass"
        Me.tbAdminPass.Size = New System.Drawing.Size(360, 28)
        Me.tbAdminPass.TabIndex = 17
        Me.tbAdminPass.UseSystemPasswordChar = True
        '
        'lblAdminPass
        '
        Me.lblAdminPass.AutoSize = True
        Me.lblAdminPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblAdminPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblAdminPass.Location = New System.Drawing.Point(541, 644)
        Me.lblAdminPass.Name = "lblAdminPass"
        Me.lblAdminPass.Size = New System.Drawing.Size(76, 15)
        Me.lblAdminPass.TabIndex = 16
        Me.lblAdminPass.Text = "PASSWORD"
        '
        'tbAdminUsername
        '
        Me.tbAdminUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.tbAdminUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAdminUsername.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.tbAdminUsername.ForeColor = System.Drawing.Color.White
        Me.tbAdminUsername.HideSelection = False
        Me.tbAdminUsername.Location = New System.Drawing.Point(1085, 576)
        Me.tbAdminUsername.Name = "tbAdminUsername"
        Me.tbAdminUsername.Size = New System.Drawing.Size(360, 28)
        Me.tbAdminUsername.TabIndex = 15
        '
        'lblAdminUsername
        '
        Me.lblAdminUsername.AutoSize = True
        Me.lblAdminUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblAdminUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblAdminUsername.Location = New System.Drawing.Point(1086, 540)
        Me.lblAdminUsername.Name = "lblAdminUsername"
        Me.lblAdminUsername.Size = New System.Drawing.Size(76, 15)
        Me.lblAdminUsername.TabIndex = 14
        Me.lblAdminUsername.Text = "USERNAME"
        '
        'tbAdminConfirmPass
        '
        Me.tbAdminConfirmPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.tbAdminConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAdminConfirmPass.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.tbAdminConfirmPass.ForeColor = System.Drawing.Color.White
        Me.tbAdminConfirmPass.HideSelection = False
        Me.tbAdminConfirmPass.Location = New System.Drawing.Point(1085, 672)
        Me.tbAdminConfirmPass.Name = "tbAdminConfirmPass"
        Me.tbAdminConfirmPass.Size = New System.Drawing.Size(360, 28)
        Me.tbAdminConfirmPass.TabIndex = 19
        Me.tbAdminConfirmPass.UseSystemPasswordChar = True
        '
        'lblAdminConfirmPass
        '
        Me.lblAdminConfirmPass.AutoSize = True
        Me.lblAdminConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblAdminConfirmPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblAdminConfirmPass.Location = New System.Drawing.Point(1082, 644)
        Me.lblAdminConfirmPass.Name = "lblAdminConfirmPass"
        Me.lblAdminConfirmPass.Size = New System.Drawing.Size(135, 15)
        Me.lblAdminConfirmPass.TabIndex = 18
        Me.lblAdminConfirmPass.Text = "CONFIRM PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1082, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "LAST NAME"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("MS PGothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(700, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(578, 48)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Create New Admin Account"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(891, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 20)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Already have an Account?"
        '
        'lnkSignUp
        '
        Me.lnkSignUp.AutoSize = True
        Me.lnkSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lnkSignUp.Location = New System.Drawing.Point(1085, 225)
        Me.lnkSignUp.Name = "lnkSignUp"
        Me.lnkSignUp.Size = New System.Drawing.Size(48, 20)
        Me.lnkSignUp.TabIndex = 67
        Me.lnkSignUp.TabStop = True
        Me.lnkSignUp.Text = "Login"
        '
        'cbShowHidePass
        '
        Me.cbShowHidePass.AutoSize = True
        Me.cbShowHidePass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbShowHidePass.Location = New System.Drawing.Point(544, 728)
        Me.cbShowHidePass.Name = "cbShowHidePass"
        Me.cbShowHidePass.Size = New System.Drawing.Size(129, 17)
        Me.cbShowHidePass.TabIndex = 69
        Me.cbShowHidePass.Text = "Show/Hide Password"
        Me.cbShowHidePass.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(1089, 728)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(129, 17)
        Me.CheckBox1.TabIndex = 70
        Me.CheckBox1.Text = "Show/Hide Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'tbAdminName
        '
        Me.tbAdminName.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.tbAdminName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAdminName.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.tbAdminName.ForeColor = System.Drawing.Color.White
        Me.tbAdminName.HideSelection = False
        Me.tbAdminName.Location = New System.Drawing.Point(544, 335)
        Me.tbAdminName.Name = "tbAdminName"
        Me.tbAdminName.Size = New System.Drawing.Size(360, 28)
        Me.tbAdminName.TabIndex = 7
        '
        'tbAdminLastName
        '
        Me.tbAdminLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.tbAdminLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAdminLastName.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.tbAdminLastName.ForeColor = System.Drawing.Color.White
        Me.tbAdminLastName.HideSelection = False
        Me.tbAdminLastName.Location = New System.Drawing.Point(1085, 335)
        Me.tbAdminLastName.Name = "tbAdminLastName"
        Me.tbAdminLastName.Size = New System.Drawing.Size(360, 28)
        Me.tbAdminLastName.TabIndex = 21
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cbShowHidePass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lnkSignUp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbAdminLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbAdminConfirmPass)
        Me.Controls.Add(Me.lblAdminConfirmPass)
        Me.Controls.Add(Me.tbAdminPass)
        Me.Controls.Add(Me.lblAdminPass)
        Me.Controls.Add(Me.tbAdminUsername)
        Me.Controls.Add(Me.lblAdminUsername)
        Me.Controls.Add(Me.btnAdminRegister)
        Me.Controls.Add(Me.tbAdminEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.tbAdminPhoneNum)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.tbAdminName)
        Me.Controls.Add(Me.tbAdminIDNum)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbAdminIDNum As TextBox
    Friend WithEvents tbAdminPhoneNum As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents tbAdminEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnAdminRegister As Button
    Friend WithEvents tbAdminPass As TextBox
    Friend WithEvents lblAdminPass As Label
    Friend WithEvents tbAdminUsername As TextBox
    Friend WithEvents lblAdminUsername As Label
    Friend WithEvents tbAdminConfirmPass As TextBox
    Friend WithEvents lblAdminConfirmPass As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents MySqlConnection1 As MySql.Data.MySqlClient.MySqlConnection
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lnkSignUp As LinkLabel
    Friend WithEvents cbShowHidePass As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents tbAdminName As TextBox
    Friend WithEvents tbAdminLastName As TextBox
End Class
