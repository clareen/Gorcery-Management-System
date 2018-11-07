<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginform))
        Me.logintab = New System.Windows.Forms.TabControl()
        Me.cashiertab = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_token = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.csh_dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.csh_userid = New System.Windows.Forms.TextBox()
        Me.csh_exit = New System.Windows.Forms.Button()
        Me.csh_password = New System.Windows.Forms.TextBox()
        Me.csh_login = New System.Windows.Forms.Button()
        Me.managertab = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mn_exit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mn_login = New System.Windows.Forms.Button()
        Me.mn_username = New System.Windows.Forms.TextBox()
        Me.mn_password = New System.Windows.Forms.TextBox()
        Me.admintab = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.admin_exit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.admin_login = New System.Windows.Forms.Button()
        Me.admin_username = New System.Windows.Forms.TextBox()
        Me.admin_password = New System.Windows.Forms.TextBox()
        Me.logintab.SuspendLayout()
        Me.cashiertab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.managertab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.admintab.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'logintab
        '
        Me.logintab.Controls.Add(Me.cashiertab)
        Me.logintab.Controls.Add(Me.managertab)
        Me.logintab.Controls.Add(Me.admintab)
        Me.logintab.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logintab.Location = New System.Drawing.Point(-5, -2)
        Me.logintab.Name = "logintab"
        Me.logintab.SelectedIndex = 0
        Me.logintab.Size = New System.Drawing.Size(405, 354)
        Me.logintab.TabIndex = 0
        '
        'cashiertab
        '
        Me.cashiertab.BackgroundImage = CType(resources.GetObject("cashiertab.BackgroundImage"), System.Drawing.Image)
        Me.cashiertab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cashiertab.Controls.Add(Me.GroupBox2)
        Me.cashiertab.Location = New System.Drawing.Point(4, 40)
        Me.cashiertab.Name = "cashiertab"
        Me.cashiertab.Padding = New System.Windows.Forms.Padding(3)
        Me.cashiertab.Size = New System.Drawing.Size(397, 310)
        Me.cashiertab.TabIndex = 0
        Me.cashiertab.Text = "CASHIER"
        Me.cashiertab.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_token)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.csh_dtp)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.csh_userid)
        Me.GroupBox2.Controls.Add(Me.csh_exit)
        Me.GroupBox2.Controls.Add(Me.csh_password)
        Me.GroupBox2.Controls.Add(Me.csh_login)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 213)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(43, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "TOKEN"
        '
        'txt_token
        '
        Me.txt_token.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_token.Location = New System.Drawing.Point(138, 22)
        Me.txt_token.Name = "txt_token"
        Me.txt_token.Size = New System.Drawing.Size(225, 26)
        Me.txt_token.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(35, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "USER ID"
        '
        'csh_dtp
        '
        Me.csh_dtp.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csh_dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csh_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.csh_dtp.Location = New System.Drawing.Point(138, 132)
        Me.csh_dtp.Name = "csh_dtp"
        Me.csh_dtp.Size = New System.Drawing.Size(225, 26)
        Me.csh_dtp.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(-4, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "PASSWORD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(66, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "TIME"
        '
        'csh_userid
        '
        Me.csh_userid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csh_userid.Location = New System.Drawing.Point(138, 61)
        Me.csh_userid.Name = "csh_userid"
        Me.csh_userid.Size = New System.Drawing.Size(225, 26)
        Me.csh_userid.TabIndex = 8
        '
        'csh_exit
        '
        Me.csh_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csh_exit.Location = New System.Drawing.Point(201, 174)
        Me.csh_exit.Name = "csh_exit"
        Me.csh_exit.Size = New System.Drawing.Size(98, 31)
        Me.csh_exit.TabIndex = 11
        Me.csh_exit.Text = "EXIT"
        Me.csh_exit.UseVisualStyleBackColor = True
        '
        'csh_password
        '
        Me.csh_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csh_password.Location = New System.Drawing.Point(138, 98)
        Me.csh_password.Name = "csh_password"
        Me.csh_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.csh_password.Size = New System.Drawing.Size(225, 26)
        Me.csh_password.TabIndex = 9
        '
        'csh_login
        '
        Me.csh_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csh_login.Location = New System.Drawing.Point(40, 174)
        Me.csh_login.Name = "csh_login"
        Me.csh_login.Size = New System.Drawing.Size(98, 31)
        Me.csh_login.TabIndex = 10
        Me.csh_login.Text = "LOGIN"
        Me.csh_login.UseVisualStyleBackColor = True
        '
        'managertab
        '
        Me.managertab.BackgroundImage = CType(resources.GetObject("managertab.BackgroundImage"), System.Drawing.Image)
        Me.managertab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.managertab.Controls.Add(Me.GroupBox1)
        Me.managertab.Location = New System.Drawing.Point(4, 40)
        Me.managertab.Name = "managertab"
        Me.managertab.Padding = New System.Windows.Forms.Padding(3)
        Me.managertab.Size = New System.Drawing.Size(397, 310)
        Me.managertab.TabIndex = 1
        Me.managertab.Text = "MANAGER"
        Me.managertab.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.mn_exit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mn_login)
        Me.GroupBox1.Controls.Add(Me.mn_username)
        Me.GroupBox1.Controls.Add(Me.mn_password)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 143)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(23, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ID NUMBER"
        '
        'mn_exit
        '
        Me.mn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_exit.Location = New System.Drawing.Point(225, 99)
        Me.mn_exit.Name = "mn_exit"
        Me.mn_exit.Size = New System.Drawing.Size(99, 31)
        Me.mn_exit.TabIndex = 11
        Me.mn_exit.Text = "EXIT"
        Me.mn_exit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(19, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PASSWORD"
        '
        'mn_login
        '
        Me.mn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_login.Location = New System.Drawing.Point(31, 99)
        Me.mn_login.Name = "mn_login"
        Me.mn_login.Size = New System.Drawing.Size(99, 31)
        Me.mn_login.TabIndex = 10
        Me.mn_login.Text = "LOGIN"
        Me.mn_login.UseVisualStyleBackColor = True
        '
        'mn_username
        '
        Me.mn_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_username.Location = New System.Drawing.Point(171, 21)
        Me.mn_username.Name = "mn_username"
        Me.mn_username.Size = New System.Drawing.Size(194, 26)
        Me.mn_username.TabIndex = 8
        '
        'mn_password
        '
        Me.mn_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn_password.Location = New System.Drawing.Point(171, 60)
        Me.mn_password.Name = "mn_password"
        Me.mn_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mn_password.Size = New System.Drawing.Size(194, 26)
        Me.mn_password.TabIndex = 9
        '
        'admintab
        '
        Me.admintab.BackgroundImage = CType(resources.GetObject("admintab.BackgroundImage"), System.Drawing.Image)
        Me.admintab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.admintab.Controls.Add(Me.GroupBox3)
        Me.admintab.ForeColor = System.Drawing.Color.Crimson
        Me.admintab.Location = New System.Drawing.Point(4, 40)
        Me.admintab.Name = "admintab"
        Me.admintab.Padding = New System.Windows.Forms.Padding(3)
        Me.admintab.Size = New System.Drawing.Size(397, 310)
        Me.admintab.TabIndex = 2
        Me.admintab.Text = "ADMIN"
        Me.admintab.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.admin_exit)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.admin_login)
        Me.GroupBox3.Controls.Add(Me.admin_username)
        Me.GroupBox3.Controls.Add(Me.admin_password)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 135)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'admin_exit
        '
        Me.admin_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_exit.ForeColor = System.Drawing.Color.Black
        Me.admin_exit.Location = New System.Drawing.Point(213, 89)
        Me.admin_exit.Name = "admin_exit"
        Me.admin_exit.Size = New System.Drawing.Size(97, 31)
        Me.admin_exit.TabIndex = 5
        Me.admin_exit.Text = "EXIT"
        Me.admin_exit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(14, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD"
        '
        'admin_login
        '
        Me.admin_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_login.ForeColor = System.Drawing.Color.Black
        Me.admin_login.Location = New System.Drawing.Point(16, 89)
        Me.admin_login.Name = "admin_login"
        Me.admin_login.Size = New System.Drawing.Size(97, 31)
        Me.admin_login.TabIndex = 4
        Me.admin_login.Text = "LOGIN"
        Me.admin_login.UseVisualStyleBackColor = True
        '
        'admin_username
        '
        Me.admin_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_username.Location = New System.Drawing.Point(157, 22)
        Me.admin_username.Name = "admin_username"
        Me.admin_username.Size = New System.Drawing.Size(208, 26)
        Me.admin_username.TabIndex = 2
        '
        'admin_password
        '
        Me.admin_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_password.Location = New System.Drawing.Point(158, 57)
        Me.admin_password.Name = "admin_password"
        Me.admin_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.admin_password.Size = New System.Drawing.Size(207, 26)
        Me.admin_password.TabIndex = 3
        '
        'Loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(395, 347)
        Me.Controls.Add(Me.logintab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loginform"
        Me.logintab.ResumeLayout(False)
        Me.cashiertab.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.managertab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.admintab.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logintab As System.Windows.Forms.TabControl
    Friend WithEvents cashiertab As System.Windows.Forms.TabPage
    Friend WithEvents managertab As System.Windows.Forms.TabPage
    Friend WithEvents admintab As System.Windows.Forms.TabPage
    Friend WithEvents admin_exit As System.Windows.Forms.Button
    Friend WithEvents admin_login As System.Windows.Forms.Button
    Friend WithEvents admin_password As System.Windows.Forms.TextBox
    Friend WithEvents admin_username As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents csh_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents csh_exit As System.Windows.Forms.Button
    Friend WithEvents csh_login As System.Windows.Forms.Button
    Friend WithEvents csh_password As System.Windows.Forms.TextBox
    Friend WithEvents csh_userid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mn_exit As System.Windows.Forms.Button
    Friend WithEvents mn_login As System.Windows.Forms.Button
    Friend WithEvents mn_password As System.Windows.Forms.TextBox
    Friend WithEvents mn_username As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_token As System.Windows.Forms.TextBox
End Class
