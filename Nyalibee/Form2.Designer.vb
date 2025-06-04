<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        manpan = New Panel()
        dashpan = New Panel()
        Btnaddstaff = New FontAwesome.Sharp.IconButton()
        btndashboard = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        IconButton322 = New FontAwesome.Sharp.IconButton()
        PictureBox10 = New PictureBox()
        xbutton = New FontAwesome.Sharp.IconButton()
        Label4 = New Label()
        Dashboardpan = New Panel()
        DataGridView2 = New DataGridView()
        DataGridView1 = New DataGridView()
        Panel8 = New Panel()
        Label5 = New Label()
        Panel7 = New Panel()
        txtorders = New Label()
        Label3 = New Label()
        Panel6 = New Panel()
        txtemployees = New Label()
        Label2 = New Label()
        Panel5 = New Panel()
        txttotalrev = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        Label30 = New Label()
        Label28 = New Label()
        Timer1 = New Timer(components)
        managementpan = New Panel()
        DataGridView3 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        colname = New DataGridViewTextBoxColumn()
        colgender = New DataGridViewTextBoxColumn()
        colpassword = New DataGridViewTextBoxColumn()
        colusername = New DataGridViewTextBoxColumn()
        coljob = New DataGridViewTextBoxColumn()
        colusertypen = New DataGridViewTextBoxColumn()
        coldatehired = New DataGridViewTextBoxColumn()
        btnclear = New FontAwesome.Sharp.IconButton()
        btnadd = New FontAwesome.Sharp.IconButton()
        btndel = New FontAwesome.Sharp.IconButton()
        btnsearch = New FontAwesome.Sharp.IconButton()
        btnupdate = New FontAwesome.Sharp.IconButton()
        txtjob = New ComboBox()
        txtusertype = New ComboBox()
        txtgender = New ComboBox()
        txtdatehired = New DateTimePicker()
        Label9 = New Label()
        txtsearch = New TextBox()
        txtname = New TextBox()
        Label8 = New Label()
        Txtusername = New TextBox()
        Label10 = New Label()
        Label7 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        txtid = New TextBox()
        txtpassword = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        de = New DataGridViewTextBoxColumn()
        job = New DataGridViewTextBoxColumn()
        colqty = New DataGridViewTextBoxColumn()
        colitem = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        Dashboardpan.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        managementpan.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(manpan)
        Panel1.Controls.Add(dashpan)
        Panel1.Controls.Add(Btnaddstaff)
        Panel1.Controls.Add(btndashboard)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 75)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 739)
        Panel1.TabIndex = 0
        ' 
        ' manpan
        ' 
        manpan.Location = New Point(3, 165)
        manpan.Name = "manpan"
        manpan.Size = New Size(10, 55)
        manpan.TabIndex = 1
        ' 
        ' dashpan
        ' 
        dashpan.Location = New Point(3, 68)
        dashpan.Name = "dashpan"
        dashpan.Size = New Size(10, 55)
        dashpan.TabIndex = 1
        ' 
        ' Btnaddstaff
        ' 
        Btnaddstaff.FlatAppearance.BorderSize = 0
        Btnaddstaff.FlatStyle = FlatStyle.Flat
        Btnaddstaff.IconChar = FontAwesome.Sharp.IconChar.User
        Btnaddstaff.IconColor = Color.Black
        Btnaddstaff.IconFont = FontAwesome.Sharp.IconFont.Auto
        Btnaddstaff.ImageAlign = ContentAlignment.MiddleLeft
        Btnaddstaff.Location = New Point(3, 165)
        Btnaddstaff.Name = "Btnaddstaff"
        Btnaddstaff.Size = New Size(244, 55)
        Btnaddstaff.TabIndex = 0
        Btnaddstaff.Text = "Staff Management"
        Btnaddstaff.UseVisualStyleBackColor = True
        ' 
        ' btndashboard
        ' 
        btndashboard.FlatAppearance.BorderSize = 0
        btndashboard.FlatStyle = FlatStyle.Flat
        btndashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard
        btndashboard.IconColor = Color.Black
        btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btndashboard.ImageAlign = ContentAlignment.MiddleLeft
        btndashboard.Location = New Point(3, 68)
        btndashboard.Name = "btndashboard"
        btndashboard.Size = New Size(244, 55)
        btndashboard.TabIndex = 0
        btndashboard.Text = "Dashboard"
        btndashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Red
        Panel2.Controls.Add(IconButton322)
        Panel2.Controls.Add(PictureBox10)
        Panel2.Controls.Add(xbutton)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1566, 75)
        Panel2.TabIndex = 1
        ' 
        ' IconButton322
        ' 
        IconButton322.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IconButton322.FlatAppearance.BorderSize = 0
        IconButton322.FlatStyle = FlatStyle.Flat
        IconButton322.IconChar = FontAwesome.Sharp.IconChar.Maximize
        IconButton322.IconColor = Color.White
        IconButton322.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton322.IconSize = 25
        IconButton322.Location = New Point(1502, 12)
        IconButton322.Name = "IconButton322"
        IconButton322.Size = New Size(23, 25)
        IconButton322.TabIndex = 15
        IconButton322.UseVisualStyleBackColor = True
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(50, 1)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(77, 72)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 14
        PictureBox10.TabStop = False
        ' 
        ' xbutton
        ' 
        xbutton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        xbutton.FlatAppearance.BorderSize = 0
        xbutton.FlatStyle = FlatStyle.Flat
        xbutton.ForeColor = Color.White
        xbutton.IconChar = FontAwesome.Sharp.IconChar.Close
        xbutton.IconColor = Color.White
        xbutton.IconFont = FontAwesome.Sharp.IconFont.Auto
        xbutton.IconSize = 25
        xbutton.Location = New Point(1531, 12)
        xbutton.Name = "xbutton"
        xbutton.Size = New Size(23, 25)
        xbutton.TabIndex = 13
        xbutton.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Yellow
        Label4.Location = New Point(133, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 2
        Label4.Text = "Dashboard"
        ' 
        ' Dashboardpan
        ' 
        Dashboardpan.Controls.Add(DataGridView2)
        Dashboardpan.Controls.Add(DataGridView1)
        Dashboardpan.Controls.Add(Panel8)
        Dashboardpan.Controls.Add(Panel7)
        Dashboardpan.Controls.Add(Panel6)
        Dashboardpan.Controls.Add(Panel5)
        Dashboardpan.Dock = DockStyle.Fill
        Dashboardpan.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Dashboardpan.Location = New Point(250, 75)
        Dashboardpan.Name = "Dashboardpan"
        Dashboardpan.Size = New Size(1316, 739)
        Dashboardpan.TabIndex = 2
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToResizeColumns = False
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.Anchor = AnchorStyles.None
        DataGridView2.BackgroundColor = SystemColors.Control
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {colqty, colitem})
        DataGridView2.Location = New Point(690, 217)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(491, 350)
        DataGridView2.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {de, job})
        DataGridView1.GridColor = Color.Black
        DataGridView1.Location = New Point(160, 217)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView1.Size = New Size(491, 350)
        DataGridView1.TabIndex = 5
        ' 
        ' Panel8
        ' 
        Panel8.Anchor = AnchorStyles.None
        Panel8.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel8.Controls.Add(Label5)
        Panel8.Location = New Point(160, 591)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1021, 121)
        Panel8.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonShadow
        Label5.Location = New Point(3, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(1015, 47)
        Label5.TabIndex = 0
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel7
        ' 
        Panel7.Anchor = AnchorStyles.None
        Panel7.BackColor = Color.Red
        Panel7.Controls.Add(txtorders)
        Panel7.Controls.Add(Label3)
        Panel7.Location = New Point(887, 68)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(294, 114)
        Panel7.TabIndex = 1
        ' 
        ' txtorders
        ' 
        txtorders.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        txtorders.ForeColor = Color.White
        txtorders.Location = New Point(3, 51)
        txtorders.Name = "txtorders"
        txtorders.Size = New Size(288, 31)
        txtorders.TabIndex = 0
        txtorders.Text = "0"
        txtorders.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(288, 31)
        Label3.TabIndex = 0
        Label3.Text = "Total Orders"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.None
        Panel6.BackColor = Color.Red
        Panel6.Controls.Add(txtemployees)
        Panel6.Controls.Add(Label2)
        Panel6.Location = New Point(529, 68)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(294, 114)
        Panel6.TabIndex = 1
        ' 
        ' txtemployees
        ' 
        txtemployees.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        txtemployees.ForeColor = Color.White
        txtemployees.Location = New Point(3, 51)
        txtemployees.Name = "txtemployees"
        txtemployees.Size = New Size(288, 31)
        txtemployees.TabIndex = 0
        txtemployees.Text = "0"
        txtemployees.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(3, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(279, 31)
        Label2.TabIndex = 0
        Label2.Text = "Employees"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.None
        Panel5.BackColor = Color.Red
        Panel5.Controls.Add(txttotalrev)
        Panel5.Controls.Add(Label1)
        Panel5.Location = New Point(160, 68)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(294, 114)
        Panel5.TabIndex = 0
        ' 
        ' txttotalrev
        ' 
        txttotalrev.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        txttotalrev.ForeColor = Color.White
        txttotalrev.Location = New Point(3, 51)
        txttotalrev.Name = "txttotalrev"
        txttotalrev.Size = New Size(288, 31)
        txttotalrev.TabIndex = 0
        txttotalrev.Text = "0"
        txttotalrev.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(288, 31)
        Label1.TabIndex = 0
        Label1.Text = "Total Revenue"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Red
        Panel4.Controls.Add(Label30)
        Panel4.Controls.Add(Label28)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 814)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1566, 48)
        Panel4.TabIndex = 14
        ' 
        ' Label30
        ' 
        Label30.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label30.AutoSize = True
        Label30.Location = New Point(1347, 4)
        Label30.Name = "Label30"
        Label30.Size = New Size(197, 40)
        Label30.TabIndex = 14
        Label30.Text = "Copyright © 2025 Nyalibee. " & vbCrLf & "              All Rights Reserved."
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(21, 14)
        Label28.Name = "Label28"
        Label28.Size = New Size(158, 20)
        Label28.TabIndex = 15
        Label28.Text = "Nyalibee Corporations"
        ' 
        ' Timer1
        ' 
        ' 
        ' managementpan
        ' 
        managementpan.BackColor = SystemColors.Control
        managementpan.Controls.Add(DataGridView3)
        managementpan.Controls.Add(btnclear)
        managementpan.Controls.Add(btnadd)
        managementpan.Controls.Add(btndel)
        managementpan.Controls.Add(btnsearch)
        managementpan.Controls.Add(btnupdate)
        managementpan.Controls.Add(txtjob)
        managementpan.Controls.Add(txtusertype)
        managementpan.Controls.Add(txtgender)
        managementpan.Controls.Add(txtdatehired)
        managementpan.Controls.Add(Label9)
        managementpan.Controls.Add(txtsearch)
        managementpan.Controls.Add(txtname)
        managementpan.Controls.Add(Label8)
        managementpan.Controls.Add(Txtusername)
        managementpan.Controls.Add(Label10)
        managementpan.Controls.Add(Label7)
        managementpan.Controls.Add(Label11)
        managementpan.Controls.Add(Label6)
        managementpan.Controls.Add(txtid)
        managementpan.Controls.Add(txtpassword)
        managementpan.Controls.Add(Label13)
        managementpan.Controls.Add(Label14)
        managementpan.Dock = DockStyle.Fill
        managementpan.Location = New Point(250, 75)
        managementpan.Name = "managementpan"
        managementpan.Size = New Size(1316, 739)
        managementpan.TabIndex = 6
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False
        DataGridView3.AllowUserToResizeColumns = False
        DataGridView3.AllowUserToResizeRows = False
        DataGridView3.Anchor = AnchorStyles.None
        DataGridView3.BackgroundColor = SystemColors.Control
        DataGridView3.ColumnHeadersHeight = 29
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {id, colname, colgender, colpassword, colusername, coljob, colusertypen, coldatehired})
        DataGridView3.Location = New Point(74, 392)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersVisible = False
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView3.Size = New Size(1131, 341)
        DataGridView3.TabIndex = 35
        ' 
        ' id
        ' 
        id.DataPropertyName = "id"
        id.HeaderText = "ID"
        id.MinimumWidth = 6
        id.Name = "id"
        id.ReadOnly = True
        id.Width = 50
        ' 
        ' colname
        ' 
        colname.DataPropertyName = "Name_"
        colname.HeaderText = "Name"
        colname.MinimumWidth = 6
        colname.Name = "colname"
        colname.ReadOnly = True
        colname.Resizable = DataGridViewTriState.False
        colname.SortMode = DataGridViewColumnSortMode.NotSortable
        colname.Width = 210
        ' 
        ' colgender
        ' 
        colgender.DataPropertyName = "Gender"
        colgender.HeaderText = "Gender"
        colgender.MinimumWidth = 6
        colgender.Name = "colgender"
        colgender.ReadOnly = True
        colgender.Resizable = DataGridViewTriState.False
        colgender.SortMode = DataGridViewColumnSortMode.NotSortable
        colgender.Width = 135
        ' 
        ' colpassword
        ' 
        colpassword.DataPropertyName = "Password"
        colpassword.HeaderText = "Password"
        colpassword.MinimumWidth = 6
        colpassword.Name = "colpassword"
        colpassword.ReadOnly = True
        colpassword.Resizable = DataGridViewTriState.False
        colpassword.SortMode = DataGridViewColumnSortMode.NotSortable
        colpassword.Width = 145
        ' 
        ' colusername
        ' 
        colusername.DataPropertyName = "Username"
        colusername.HeaderText = "Username"
        colusername.MinimumWidth = 6
        colusername.Name = "colusername"
        colusername.ReadOnly = True
        colusername.Resizable = DataGridViewTriState.False
        colusername.Width = 130
        ' 
        ' coljob
        ' 
        coljob.DataPropertyName = "Job"
        coljob.HeaderText = "Job Role"
        coljob.MinimumWidth = 6
        coljob.Name = "coljob"
        coljob.ReadOnly = True
        coljob.Resizable = DataGridViewTriState.False
        coljob.SortMode = DataGridViewColumnSortMode.NotSortable
        coljob.Width = 150
        ' 
        ' colusertypen
        ' 
        colusertypen.DataPropertyName = "User_type"
        colusertypen.HeaderText = "User Type"
        colusertypen.MinimumWidth = 6
        colusertypen.Name = "colusertypen"
        colusertypen.ReadOnly = True
        colusertypen.Resizable = DataGridViewTriState.False
        colusertypen.SortMode = DataGridViewColumnSortMode.NotSortable
        colusertypen.Width = 137
        ' 
        ' coldatehired
        ' 
        coldatehired.DataPropertyName = "datehired"
        coldatehired.HeaderText = "Date Hired"
        coldatehired.MinimumWidth = 6
        coldatehired.Name = "coldatehired"
        coldatehired.ReadOnly = True
        coldatehired.Resizable = DataGridViewTriState.False
        coldatehired.SortMode = DataGridViewColumnSortMode.NotSortable
        coldatehired.Width = 170
        ' 
        ' btnclear
        ' 
        btnclear.Anchor = AnchorStyles.None
        btnclear.BackColor = Color.White
        btnclear.FlatAppearance.BorderSize = 0
        btnclear.FlatStyle = FlatStyle.Flat
        btnclear.IconChar = FontAwesome.Sharp.IconChar.None
        btnclear.IconColor = Color.Black
        btnclear.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnclear.Location = New Point(713, 346)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(107, 40)
        btnclear.TabIndex = 32
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.Anchor = AnchorStyles.None
        btnadd.BackColor = Color.Lime
        btnadd.FlatAppearance.BorderSize = 0
        btnadd.FlatStyle = FlatStyle.Flat
        btnadd.IconChar = FontAwesome.Sharp.IconChar.None
        btnadd.IconColor = Color.Black
        btnadd.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnadd.Location = New Point(836, 346)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(107, 40)
        btnadd.TabIndex = 32
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btndel
        ' 
        btndel.Anchor = AnchorStyles.None
        btndel.BackColor = Color.Red
        btndel.FlatAppearance.BorderSize = 0
        btndel.FlatStyle = FlatStyle.Flat
        btndel.IconChar = FontAwesome.Sharp.IconChar.None
        btndel.IconColor = Color.Black
        btndel.IconFont = FontAwesome.Sharp.IconFont.Auto
        btndel.Location = New Point(967, 346)
        btndel.Name = "btndel"
        btndel.Size = New Size(107, 40)
        btndel.TabIndex = 33
        btndel.Text = "Delete"
        btndel.UseVisualStyleBackColor = False
        ' 
        ' btnsearch
        ' 
        btnsearch.Anchor = AnchorStyles.None
        btnsearch.BackColor = SystemColors.Control
        btnsearch.FlatAppearance.BorderSize = 0
        btnsearch.FlatStyle = FlatStyle.Flat
        btnsearch.IconChar = FontAwesome.Sharp.IconChar.Search
        btnsearch.IconColor = Color.Black
        btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnsearch.IconSize = 30
        btnsearch.ImageAlign = ContentAlignment.MiddleLeft
        btnsearch.Location = New Point(342, 359)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(42, 27)
        btnsearch.TabIndex = 34
        btnsearch.TextAlign = ContentAlignment.MiddleRight
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.Anchor = AnchorStyles.None
        btnupdate.BackColor = Color.Cyan
        btnupdate.FlatAppearance.BorderSize = 0
        btnupdate.FlatStyle = FlatStyle.Flat
        btnupdate.IconChar = FontAwesome.Sharp.IconChar.None
        btnupdate.IconColor = Color.Black
        btnupdate.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnupdate.Location = New Point(1098, 346)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(107, 40)
        btnupdate.TabIndex = 34
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' txtjob
        ' 
        txtjob.Anchor = AnchorStyles.None
        txtjob.FormattingEnabled = True
        txtjob.Items.AddRange(New Object() {"Service Crew", "Cashier", "Production Crew", "Manager"})
        txtjob.Location = New Point(769, 91)
        txtjob.Name = "txtjob"
        txtjob.Size = New Size(253, 28)
        txtjob.TabIndex = 31
        ' 
        ' txtusertype
        ' 
        txtusertype.Anchor = AnchorStyles.None
        txtusertype.FormattingEnabled = True
        txtusertype.Items.AddRange(New Object() {"Admin", "Cashier", "Crew"})
        txtusertype.Location = New Point(769, 151)
        txtusertype.Name = "txtusertype"
        txtusertype.Size = New Size(253, 28)
        txtusertype.TabIndex = 31
        ' 
        ' txtgender
        ' 
        txtgender.Anchor = AnchorStyles.None
        txtgender.FormattingEnabled = True
        txtgender.Items.AddRange(New Object() {"Male", "Female"})
        txtgender.Location = New Point(318, 160)
        txtgender.Name = "txtgender"
        txtgender.Size = New Size(253, 28)
        txtgender.TabIndex = 31
        ' 
        ' txtdatehired
        ' 
        txtdatehired.Anchor = AnchorStyles.None
        txtdatehired.CustomFormat = ""
        txtdatehired.Location = New Point(769, 203)
        txtdatehired.Name = "txtdatehired"
        txtdatehired.Size = New Size(253, 27)
        txtdatehired.TabIndex = 30
        txtdatehired.Value = New Date(2025, 5, 7, 8, 37, 1, 0)
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("SimSun", 13.8F)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(637, 204)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 23)
        Label9.TabIndex = 22
        Label9.Text = "Date Hired"
        ' 
        ' txtsearch
        ' 
        txtsearch.Anchor = AnchorStyles.None
        txtsearch.Location = New Point(74, 359)
        txtsearch.Name = "txtsearch"
        txtsearch.PlaceholderText = "Search"
        txtsearch.Size = New Size(263, 27)
        txtsearch.TabIndex = 0
        ' 
        ' txtname
        ' 
        txtname.Anchor = AnchorStyles.None
        txtname.Font = New Font("Segoe UI", 10.8F)
        txtname.Location = New Point(318, 83)
        txtname.Multiline = True
        txtname.Name = "txtname"
        txtname.Size = New Size(253, 48)
        txtname.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("SimSun", 13.8F)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(649, 151)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 23)
        Label8.TabIndex = 24
        Label8.Text = "User Type"
        ' 
        ' Txtusername
        ' 
        Txtusername.Anchor = AnchorStyles.None
        Txtusername.Font = New Font("Segoe UI", 10.8F)
        Txtusername.Location = New Point(318, 209)
        Txtusername.Multiline = True
        Txtusername.Name = "Txtusername"
        Txtusername.Size = New Size(253, 48)
        Txtusername.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("SimSun", 13.8F)
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(729, 259)
        Label10.Name = "Label10"
        Label10.Size = New Size(34, 23)
        Label10.TabIndex = 25
        Label10.Text = "Id"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("SimSun", 13.8F)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(206, 288)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 23)
        Label7.TabIndex = 25
        Label7.Text = "Password"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Font = New Font("SimSun", 13.8F)
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(236, 165)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 23)
        Label11.TabIndex = 27
        Label11.Text = "Gender"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("SimSun", 13.8F)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(210, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 23)
        Label6.TabIndex = 28
        Label6.Text = "Username"
        ' 
        ' txtid
        ' 
        txtid.Anchor = AnchorStyles.None
        txtid.Font = New Font("Segoe UI", 10.8F)
        txtid.Location = New Point(769, 251)
        txtid.Multiline = True
        txtid.Name = "txtid"
        txtid.Size = New Size(90, 41)
        txtid.TabIndex = 17
        ' 
        ' txtpassword
        ' 
        txtpassword.Anchor = AnchorStyles.None
        txtpassword.Font = New Font("Segoe UI", 10.8F)
        txtpassword.Location = New Point(318, 277)
        txtpassword.Multiline = True
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(253, 41)
        txtpassword.TabIndex = 17
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Font = New Font("SimSun", 13.8F)
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(661, 96)
        Label13.Name = "Label13"
        Label13.Size = New Size(106, 23)
        Label13.TabIndex = 28
        Label13.Text = "Job Role"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Font = New Font("SimSun", 13.8F)
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(260, 96)
        Label14.Name = "Label14"
        Label14.Size = New Size(58, 23)
        Label14.TabIndex = 29
        Label14.Text = "Name"
        ' 
        ' de
        ' 
        de.DataPropertyName = "Name_"
        de.HeaderText = "Name"
        de.MinimumWidth = 6
        de.Name = "de"
        de.ReadOnly = True
        de.Resizable = DataGridViewTriState.False
        de.SortMode = DataGridViewColumnSortMode.NotSortable
        de.Width = 288
        ' 
        ' job
        ' 
        job.DataPropertyName = "Job"
        job.HeaderText = "Job Role"
        job.MinimumWidth = 6
        job.Name = "job"
        job.ReadOnly = True
        job.Resizable = DataGridViewTriState.False
        job.SortMode = DataGridViewColumnSortMode.NotSortable
        job.Width = 200
        ' 
        ' colqty
        ' 
        colqty.DataPropertyName = "qty"
        colqty.HeaderText = "Qty"
        colqty.MinimumWidth = 6
        colqty.Name = "colqty"
        colqty.ReadOnly = True
        colqty.Resizable = DataGridViewTriState.False
        colqty.SortMode = DataGridViewColumnSortMode.NotSortable
        colqty.Width = 83
        ' 
        ' colitem
        ' 
        colitem.DataPropertyName = "item"
        colitem.HeaderText = "Item"
        colitem.MinimumWidth = 6
        colitem.Name = "colitem"
        colitem.ReadOnly = True
        colitem.Resizable = DataGridViewTriState.False
        colitem.SortMode = DataGridViewColumnSortMode.NotSortable
        colitem.Width = 405
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1566, 862)
        Controls.Add(Dashboardpan)
        Controls.Add(managementpan)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        Dashboardpan.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        managementpan.ResumeLayout(False)
        managementpan.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dashboardpan As Panel
    Friend WithEvents xbutton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents IconButton322 As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Btnaddstaff As FontAwesome.Sharp.IconButton
    Friend WithEvents btndashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents managementpan As Panel
    Friend WithEvents manpan As Panel
    Friend WithEvents dashpan As Panel
    Friend WithEvents txtgender As ComboBox
    Friend WithEvents txtdatehired As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnadd As FontAwesome.Sharp.IconButton
    Friend WithEvents btndel As FontAwesome.Sharp.IconButton
    Friend WithEvents btnsearch As FontAwesome.Sharp.IconButton
    Friend WithEvents btnupdate As FontAwesome.Sharp.IconButton
    Friend WithEvents txtusertype As ComboBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtorders As Label
    Friend WithEvents txtemployees As Label
    Friend WithEvents txttotalrev As Label
    Friend WithEvents btnclear As FontAwesome.Sharp.IconButton
    Friend WithEvents txtjob As ComboBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents colname As DataGridViewTextBoxColumn
    Friend WithEvents colgender As DataGridViewTextBoxColumn
    Friend WithEvents colpassword As DataGridViewTextBoxColumn
    Friend WithEvents colusername As DataGridViewTextBoxColumn
    Friend WithEvents coljob As DataGridViewTextBoxColumn
    Friend WithEvents colusertypen As DataGridViewTextBoxColumn
    Friend WithEvents coldatehired As DataGridViewTextBoxColumn
    Friend WithEvents colqty As DataGridViewTextBoxColumn
    Friend WithEvents colitem As DataGridViewTextBoxColumn
    Friend WithEvents de As DataGridViewTextBoxColumn
    Friend WithEvents job As DataGridViewTextBoxColumn
End Class
