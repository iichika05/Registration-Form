<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btn_signup = New Guna.UI2.WinForms.Guna2Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_gender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tb_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_lastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_firstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderRadius = 4
        Me.PictureBox1.FillColor = System.Drawing.Color.LightGray
        Me.PictureBox1.ImageRotate = 0!
        Me.PictureBox1.Location = New System.Drawing.Point(42, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 78)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(294, 242)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(145, 104)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 42
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Animated = True
        Me.DateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.DarkGray
        Me.DateTimePicker1.BorderRadius = 4
        Me.DateTimePicker1.BorderThickness = 1
        Me.DateTimePicker1.Checked = True
        Me.DateTimePicker1.FillColor = System.Drawing.Color.PaleTurquoise
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePicker1.Location = New System.Drawing.Point(188, 206)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 36)
        Me.DateTimePicker1.TabIndex = 41
        Me.DateTimePicker1.Value = New Date(2024, 10, 19, 19, 12, 11, 190)
        '
        'btn_signup
        '
        Me.btn_signup.Animated = True
        Me.btn_signup.AnimatedGIF = True
        Me.btn_signup.BorderColor = System.Drawing.Color.DimGray
        Me.btn_signup.BorderRadius = 4
        Me.btn_signup.BorderThickness = 1
        Me.btn_signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_signup.FillColor = System.Drawing.Color.Red
        Me.btn_signup.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_signup.ForeColor = System.Drawing.Color.Transparent
        Me.btn_signup.Location = New System.Drawing.Point(150, 284)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(151, 36)
        Me.btn_signup.TabIndex = 40
        Me.btn_signup.Text = "Sign Up"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MediumTurquoise
        Me.LinkLabel1.Location = New System.Drawing.Point(259, 259)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 39
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Login Here"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Already have an account?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(185, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 14)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Birthday:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Gender:"
        '
        'cb_gender
        '
        Me.cb_gender.BackColor = System.Drawing.Color.Transparent
        Me.cb_gender.BorderColor = System.Drawing.Color.DimGray
        Me.cb_gender.BorderRadius = 4
        Me.cb_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_gender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_gender.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_gender.ForeColor = System.Drawing.Color.DimGray
        Me.cb_gender.ItemHeight = 30
        Me.cb_gender.Location = New System.Drawing.Point(20, 206)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.Size = New System.Drawing.Size(162, 36)
        Me.cb_gender.TabIndex = 34
        '
        'tb_password
        '
        Me.tb_password.Animated = True
        Me.tb_password.BorderRadius = 4
        Me.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_password.DefaultText = ""
        Me.tb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_password.FillColor = System.Drawing.Color.LightGray
        Me.tb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_password.Location = New System.Drawing.Point(134, 150)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_password.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.tb_password.PlaceholderText = "Password"
        Me.tb_password.SelectedText = ""
        Me.tb_password.Size = New System.Drawing.Size(292, 36)
        Me.tb_password.TabIndex = 33
        '
        'tb_username
        '
        Me.tb_username.Animated = True
        Me.tb_username.BorderRadius = 4
        Me.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_username.DefaultText = ""
        Me.tb_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_username.FillColor = System.Drawing.Color.LightGray
        Me.tb_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_username.Location = New System.Drawing.Point(134, 108)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_username.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.tb_username.PlaceholderText = "Email or Username"
        Me.tb_username.SelectedText = ""
        Me.tb_username.Size = New System.Drawing.Size(292, 36)
        Me.tb_username.TabIndex = 32
        '
        'tb_lastname
        '
        Me.tb_lastname.Animated = True
        Me.tb_lastname.BorderRadius = 4
        Me.tb_lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_lastname.DefaultText = ""
        Me.tb_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_lastname.FillColor = System.Drawing.Color.LightGray
        Me.tb_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_lastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_lastname.Location = New System.Drawing.Point(226, 66)
        Me.tb_lastname.Name = "tb_lastname"
        Me.tb_lastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_lastname.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.tb_lastname.PlaceholderText = "Last Name"
        Me.tb_lastname.SelectedText = ""
        Me.tb_lastname.Size = New System.Drawing.Size(200, 36)
        Me.tb_lastname.TabIndex = 31
        '
        'tb_firstname
        '
        Me.tb_firstname.Animated = True
        Me.tb_firstname.BorderRadius = 4
        Me.tb_firstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_firstname.DefaultText = ""
        Me.tb_firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_firstname.FillColor = System.Drawing.Color.LightGray
        Me.tb_firstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_firstname.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_firstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_firstname.Location = New System.Drawing.Point(20, 66)
        Me.tb_firstname.Name = "tb_firstname"
        Me.tb_firstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_firstname.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.tb_firstname.PlaceholderText = "First Name"
        Me.tb_firstname.SelectedText = ""
        Me.tb_firstname.Size = New System.Drawing.Size(200, 36)
        Me.tb_firstname.TabIndex = 30
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.MediumTurquoise
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-2, -1)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(448, 58)
        Me.Guna2GradientPanel1.TabIndex = 35
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(87, 4)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(37, 30)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 30
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Sign up to continue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sign Up"
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox4.Image = CType(resources.GetObject("Guna2PictureBox4.Image"), System.Drawing.Image)
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(12, 108)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(29, 78)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox4.TabIndex = 44
        Me.Guna2PictureBox4.TabStop = False
        Me.Guna2PictureBox4.UseTransparentBackground = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 345)
        Me.Controls.Add(Me.Guna2PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_gender)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.tb_lastname)
        Me.Controls.Add(Me.tb_firstname)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btn_signup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_gender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tb_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_lastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_firstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
End Class
