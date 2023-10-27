<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reservation
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SfDateTimeEdit1 = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1553, 1086)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel2.Controls.Add(Me.SfDateTimeEdit1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(117, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1310, 150)
        Me.Panel2.TabIndex = 1
        '
        'SfDateTimeEdit1
        '
        Me.SfDateTimeEdit1.AllowNull = True
        Me.SfDateTimeEdit1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SfDateTimeEdit1.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.FullDateTime
        Me.SfDateTimeEdit1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfDateTimeEdit1.Location = New System.Drawing.Point(103, 80)
        Me.SfDateTimeEdit1.Name = "SfDateTimeEdit1"
        Me.SfDateTimeEdit1.Size = New System.Drawing.Size(331, 36)
        Me.SfDateTimeEdit1.TabIndex = 2
        Me.SfDateTimeEdit1.ToolTipText = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(944, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(542, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Equipment Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(214, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Barrow"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search Equipment Availability"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(73, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sports Equipment"
        '
        'reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1549, 967)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reservation"
        Me.Text = "reservation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents SfDateTimeEdit1 As Syncfusion.WinForms.Input.SfDateTimeEdit
End Class
