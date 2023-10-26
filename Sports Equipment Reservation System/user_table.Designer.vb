<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class user_table
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Tbemail = New System.Windows.Forms.TextBox()
        Me.Tbpn = New System.Windows.Forms.TextBox()
        Me.Tbstatus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbyearandsection = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Tbid = New System.Windows.Forms.TextBox()
        Me.Tbname = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMargin = New System.Drawing.Size(0, 250)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.DGV1)
        Me.Panel1.Controls.Add(Me.Tbpassword)
        Me.Panel1.Controls.Add(Me.Tbun)
        Me.Panel1.Controls.Add(Me.Tbemail)
        Me.Panel1.Controls.Add(Me.Tbpn)
        Me.Panel1.Controls.Add(Me.Tbstatus)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Tbyearandsection)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.Tbid)
        Me.Panel1.Controls.Add(Me.Tbname)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1570, 1085)
        Me.Panel1.TabIndex = 0
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToResizeColumns = False
        Me.DGV1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        Me.DGV1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STUDENT_ID, Me.STUDENT_NAME, Me.YEAR_AND_SECTION, Me.STATUS, Me.PHONE_NUMBER, Me.EMAIL, Me.USERNAME, Me.PASSWORD, Me.NO})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV1.Location = New System.Drawing.Point(154, 587)
        Me.DGV1.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV1.MultiSelect = False
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV1.RowHeadersWidth = 51
        Me.DGV1.RowTemplate.Height = 50
        Me.DGV1.RowTemplate.ReadOnly = True
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(1304, 310)
        Me.DGV1.TabIndex = 81
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
        Me.Tbpassword.Location = New System.Drawing.Point(906, 391)
        Me.Tbpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbpassword.Multiline = True
        Me.Tbpassword.Name = "Tbpassword"
        Me.Tbpassword.Size = New System.Drawing.Size(360, 37)
        Me.Tbpassword.TabIndex = 43
        '
        'Tbun
        '
        Me.Tbun.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbun.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbun.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbun.ForeColor = System.Drawing.Color.White
        Me.Tbun.Location = New System.Drawing.Point(906, 291)
        Me.Tbun.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbun.Multiline = True
        Me.Tbun.Name = "Tbun"
        Me.Tbun.Size = New System.Drawing.Size(360, 37)
        Me.Tbun.TabIndex = 42
        '
        'Tbemail
        '
        Me.Tbemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbemail.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbemail.ForeColor = System.Drawing.Color.White
        Me.Tbemail.Location = New System.Drawing.Point(906, 190)
        Me.Tbemail.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbemail.Multiline = True
        Me.Tbemail.Name = "Tbemail"
        Me.Tbemail.Size = New System.Drawing.Size(360, 37)
        Me.Tbemail.TabIndex = 41
        '
        'Tbpn
        '
        Me.Tbpn.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbpn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbpn.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbpn.ForeColor = System.Drawing.Color.White
        Me.Tbpn.Location = New System.Drawing.Point(906, 94)
        Me.Tbpn.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbpn.Multiline = True
        Me.Tbpn.Name = "Tbpn"
        Me.Tbpn.Size = New System.Drawing.Size(360, 37)
        Me.Tbpn.TabIndex = 40
        '
        'Tbstatus
        '
        Me.Tbstatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbstatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbstatus.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbstatus.ForeColor = System.Drawing.Color.White
        Me.Tbstatus.Location = New System.Drawing.Point(301, 391)
        Me.Tbstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbstatus.Multiline = True
        Me.Tbstatus.Name = "Tbstatus"
        Me.Tbstatus.Size = New System.Drawing.Size(360, 37)
        Me.Tbstatus.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(903, 365)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "PASSWORD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(903, 265)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "USERNAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(903, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "EMAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(903, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "PHONE NUMBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(298, 365)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "STATUS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(298, 265)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "YEAR AND SECTION"
        '
        'Tbyearandsection
        '
        Me.Tbyearandsection.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbyearandsection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbyearandsection.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbyearandsection.ForeColor = System.Drawing.Color.White
        Me.Tbyearandsection.Location = New System.Drawing.Point(301, 291)
        Me.Tbyearandsection.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbyearandsection.Multiline = True
        Me.Tbyearandsection.Name = "Tbyearandsection"
        Me.Tbyearandsection.Size = New System.Drawing.Size(360, 37)
        Me.Tbyearandsection.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(298, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "STUDENT ID"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label.Location = New System.Drawing.Point(298, 164)
        Me.Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(42, 15)
        Me.Label.TabIndex = 30
        Me.Label.Text = "NAME"
        '
        'Tbid
        '
        Me.Tbid.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbid.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbid.ForeColor = System.Drawing.Color.White
        Me.Tbid.Location = New System.Drawing.Point(301, 94)
        Me.Tbid.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbid.Multiline = True
        Me.Tbid.Name = "Tbid"
        Me.Tbid.Size = New System.Drawing.Size(360, 37)
        Me.Tbid.TabIndex = 29
        Me.Tbid.Tag = ""
        '
        'Tbname
        '
        Me.Tbname.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Tbname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbname.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.75!)
        Me.Tbname.ForeColor = System.Drawing.Color.White
        Me.Tbname.Location = New System.Drawing.Point(301, 190)
        Me.Tbname.Margin = New System.Windows.Forms.Padding(2)
        Me.Tbname.Multiline = True
        Me.Tbname.Name = "Tbname"
        Me.Tbname.Size = New System.Drawing.Size(360, 37)
        Me.Tbname.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(657, 494)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(238, 50)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(392, 494)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(234, 50)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Insert"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(1221, 494)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 50)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(923, 494)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 50)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(370, 210)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(277, 199)
        Me.Button5.TabIndex = 82
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'user_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1581, 1045)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user_table"
        Me.Text = "user_table"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Tbpassword As TextBox
    Friend WithEvents Tbun As TextBox
    Friend WithEvents Tbemail As TextBox
    Friend WithEvents Tbpn As TextBox
    Friend WithEvents Tbstatus As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Tbyearandsection As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Tbid As TextBox
    Friend WithEvents Tbname As TextBox
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
    Friend WithEvents Button5 As Button
End Class
