<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.RegistrationformV2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data3DataSet = New RegistrationFormV2.Data3DataSet()
        Me.Registration_formV2TableAdapter = New RegistrationFormV2.Data3DataSetTableAdapters.registration_formV2TableAdapter()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_load = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.tb_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cb_course = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_year = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.rb_female = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rb_male = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.tb_customername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_customerid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_browse = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.RegistrationformV2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.btn_browse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistrationformV2BindingSource
        '
        Me.RegistrationformV2BindingSource.DataMember = "registration_formV2"
        Me.RegistrationformV2BindingSource.DataSource = Me.Data3DataSet
        '
        'Data3DataSet
        '
        Me.Data3DataSet.DataSetName = "Data3DataSet"
        Me.Data3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Registration_formV2TableAdapter
        '
        Me.Registration_formV2TableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(251, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("SF Pro Display", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(9, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(679, 252)
        Me.DataGridView1.TabIndex = 38
        Me.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 25
        Me.DataGridView1.ThemeStyle.ReadOnly = False
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("SF Pro Display", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(5, 431)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(37, 44)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 37
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(311, 79)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(46, 16)
        Me.Guna2HtmlLabel2.TabIndex = 35
        Me.Guna2HtmlLabel2.Text = "Course:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(322, 46)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(32, 16)
        Me.Guna2HtmlLabel1.TabIndex = 34
        Me.Guna2HtmlLabel1.Text = "Year:"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.BorderRadius = 4
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.Guna2Button4.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(238, 435)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(108, 33)
        Me.Guna2Button4.TabIndex = 33
        Me.Guna2Button4.Text = "Register"
        '
        'btn_load
        '
        Me.btn_load.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_load.Animated = True
        Me.btn_load.BorderRadius = 4
        Me.btn_load.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_load.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_load.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_load.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_load.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_load.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.ForeColor = System.Drawing.Color.White
        Me.btn_load.Location = New System.Drawing.Point(352, 435)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(108, 33)
        Me.btn_load.TabIndex = 32
        Me.btn_load.Text = "Load Records"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BorderRadius = 4
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.Guna2Button2.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(466, 435)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(108, 33)
        Me.Guna2Button2.TabIndex = 31
        Me.Guna2Button2.Text = "Update"
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_delete.Animated = True
        Me.btn_delete.BorderRadius = 4
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_delete.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(580, 435)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(108, 33)
        Me.btn_delete.TabIndex = 30
        Me.btn_delete.Text = "Delete"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderRadius = 4
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageRotate = 0!
        Me.PictureBox1.Location = New System.Drawing.Point(553, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'tb_search
        '
        Me.tb_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.tb_search.Animated = True
        Me.tb_search.BackColor = System.Drawing.Color.LightGray
        Me.tb_search.BorderRadius = 14
        Me.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_search.DefaultText = ""
        Me.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_search.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_search.Location = New System.Drawing.Point(44, 435)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_search.PlaceholderText = "Search"
        Me.tb_search.SelectedText = ""
        Me.tb_search.Size = New System.Drawing.Size(188, 33)
        Me.tb_search.TabIndex = 28
        '
        'cb_course
        '
        Me.cb_course.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cb_course.BackColor = System.Drawing.Color.Transparent
        Me.cb_course.BorderRadius = 4
        Me.cb_course.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_course.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_course.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_course.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_course.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_course.ItemHeight = 30
        Me.cb_course.Location = New System.Drawing.Point(360, 85)
        Me.cb_course.Name = "cb_course"
        Me.cb_course.Size = New System.Drawing.Size(146, 36)
        Me.cb_course.TabIndex = 27
        '
        'cb_year
        '
        Me.cb_year.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cb_year.BackColor = System.Drawing.Color.Transparent
        Me.cb_year.BorderRadius = 4
        Me.cb_year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_year.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_year.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_year.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_year.ItemHeight = 30
        Me.cb_year.Items.AddRange(New Object() {""})
        Me.cb_year.Location = New System.Drawing.Point(360, 46)
        Me.cb_year.Name = "cb_year"
        Me.cb_year.Size = New System.Drawing.Size(146, 36)
        Me.cb_year.TabIndex = 26
        '
        'rb_female
        '
        Me.rb_female.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rb_female.AutoSize = True
        Me.rb_female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb_female.CheckedState.BorderThickness = 0
        Me.rb_female.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb_female.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rb_female.CheckedState.InnerOffset = -4
        Me.rb_female.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_female.Location = New System.Drawing.Point(132, 141)
        Me.rb_female.Name = "rb_female"
        Me.rb_female.Size = New System.Drawing.Size(66, 18)
        Me.rb_female.TabIndex = 25
        Me.rb_female.Text = "Female"
        Me.rb_female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rb_female.UncheckedState.BorderThickness = 2
        Me.rb_female.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rb_female.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rb_male
        '
        Me.rb_male.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rb_male.AutoSize = True
        Me.rb_male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb_male.CheckedState.BorderThickness = 0
        Me.rb_male.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb_male.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rb_male.CheckedState.InnerOffset = -4
        Me.rb_male.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_male.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_male.Location = New System.Drawing.Point(53, 141)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(51, 18)
        Me.rb_male.TabIndex = 24
        Me.rb_male.Text = "Male"
        Me.rb_male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rb_male.UncheckedState.BorderThickness = 2
        Me.rb_male.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rb_male.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'tb_customername
        '
        Me.tb_customername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_customername.Animated = True
        Me.tb_customername.BorderRadius = 4
        Me.tb_customername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_customername.DefaultText = ""
        Me.tb_customername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_customername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_customername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_customername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_customername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_customername.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_customername.Location = New System.Drawing.Point(12, 85)
        Me.tb_customername.Name = "tb_customername"
        Me.tb_customername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_customername.PlaceholderText = "Customer Name"
        Me.tb_customername.SelectedText = ""
        Me.tb_customername.Size = New System.Drawing.Size(262, 36)
        Me.tb_customername.TabIndex = 23
        '
        'tb_customerid
        '
        Me.tb_customerid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_customerid.Animated = True
        Me.tb_customerid.BackColor = System.Drawing.Color.LightGray
        Me.tb_customerid.BorderRadius = 4
        Me.tb_customerid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_customerid.DefaultText = ""
        Me.tb_customerid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_customerid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_customerid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_customerid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_customerid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_customerid.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customerid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_customerid.Location = New System.Drawing.Point(12, 46)
        Me.tb_customerid.Name = "tb_customerid"
        Me.tb_customerid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_customerid.PlaceholderText = "Customer ID (Auto Generated)"
        Me.tb_customerid.SelectedText = ""
        Me.tb_customerid.Size = New System.Drawing.Size(262, 36)
        Me.tb_customerid.TabIndex = 22
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-11, -6)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(921, 42)
        Me.Guna2GradientPanel1.TabIndex = 21
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("SF Pro Display", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(25, 10)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(175, 27)
        Me.Guna2HtmlLabel3.TabIndex = 16
        Me.Guna2HtmlLabel3.Text = "Admin Dashboard"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 45)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'btn_browse
        '
        Me.btn_browse.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_browse.BackColor = System.Drawing.Color.Transparent
        Me.btn_browse.Image = CType(resources.GetObject("btn_browse.Image"), System.Drawing.Image)
        Me.btn_browse.ImageRotate = 0!
        Me.btn_browse.Location = New System.Drawing.Point(515, 132)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(37, 48)
        Me.btn_browse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_browse.TabIndex = 39
        Me.btn_browse.TabStop = False
        Me.btn_browse.UseTransparentBackground = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(700, 475)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.cb_course)
        Me.Controls.Add(Me.cb_year)
        Me.Controls.Add(Me.rb_female)
        Me.Controls.Add(Me.rb_male)
        Me.Controls.Add(Me.tb_customername)
        Me.Controls.Add(Me.tb_customerid)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_browse)
        Me.Name = "AdminDashboard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.RegistrationformV2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.btn_browse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Data3DataSet As Data3DataSet
    Friend WithEvents RegistrationformV2BindingSource As BindingSource
    Friend WithEvents Registration_formV2TableAdapter As Data3DataSetTableAdapters.registration_formV2TableAdapter
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_load As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents tb_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cb_course As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_year As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents rb_female As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rb_male As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents tb_customername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_customerid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_browse As Guna.UI2.WinForms.Guna2PictureBox
End Class
