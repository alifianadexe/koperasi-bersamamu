<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementAnggota
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
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.data_grid_non = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_conf = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_jabatan = New System.Windows.Forms.ComboBox()
        Me.txt_tanggal_lahir = New System.Windows.Forms.DateTimePicker()
        Me.txt_jenis_kel_2 = New System.Windows.Forms.RadioButton()
        Me.txt_jenis_kel = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tempat_lahir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.data_grid_non, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(6, 6)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(604, 185)
        Me.data_grid.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 371)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(624, 223)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.data_grid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(616, 197)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Terkonfirmasi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.data_grid_non)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(616, 197)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Belum Terkonfirmasi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'data_grid_non
        '
        Me.data_grid_non.AllowUserToAddRows = False
        Me.data_grid_non.AllowUserToDeleteRows = False
        Me.data_grid_non.AllowUserToOrderColumns = True
        Me.data_grid_non.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_non.Location = New System.Drawing.Point(6, 6)
        Me.data_grid_non.Name = "data_grid_non"
        Me.data_grid_non.ReadOnly = True
        Me.data_grid_non.Size = New System.Drawing.Size(604, 185)
        Me.data_grid_non.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_status)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btn_conf)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 91)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status Aktif"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(94, 26)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(121, 13)
        Me.lbl_status.TabIndex = 2
        Me.lbl_status.Text = "Belum Terkonfirmasi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Status : "
        '
        'btn_conf
        '
        Me.btn_conf.Location = New System.Drawing.Point(97, 49)
        Me.btn_conf.Name = "btn_conf"
        Me.btn_conf.Size = New System.Drawing.Size(117, 27)
        Me.btn_conf.TabIndex = 0
        Me.btn_conf.Text = "Konfirmasi"
        Me.btn_conf.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_jabatan)
        Me.GroupBox1.Controls.Add(Me.txt_tanggal_lahir)
        Me.GroupBox1.Controls.Add(Me.txt_jenis_kel_2)
        Me.GroupBox1.Controls.Add(Me.txt_jenis_kel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_alamat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_tempat_lahir)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 275)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Diri"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Jabatan"
        '
        'txt_jabatan
        '
        Me.txt_jabatan.Enabled = False
        Me.txt_jabatan.FormattingEnabled = True
        Me.txt_jabatan.Location = New System.Drawing.Point(86, 50)
        Me.txt_jabatan.Name = "txt_jabatan"
        Me.txt_jabatan.Size = New System.Drawing.Size(175, 21)
        Me.txt_jabatan.TabIndex = 15
        '
        'txt_tanggal_lahir
        '
        Me.txt_tanggal_lahir.Enabled = False
        Me.txt_tanggal_lahir.Location = New System.Drawing.Point(86, 158)
        Me.txt_tanggal_lahir.Name = "txt_tanggal_lahir"
        Me.txt_tanggal_lahir.Size = New System.Drawing.Size(200, 20)
        Me.txt_tanggal_lahir.TabIndex = 14
        '
        'txt_jenis_kel_2
        '
        Me.txt_jenis_kel_2.AutoSize = True
        Me.txt_jenis_kel_2.Enabled = False
        Me.txt_jenis_kel_2.Location = New System.Drawing.Point(182, 109)
        Me.txt_jenis_kel_2.Name = "txt_jenis_kel_2"
        Me.txt_jenis_kel_2.Size = New System.Drawing.Size(79, 17)
        Me.txt_jenis_kel_2.TabIndex = 13
        Me.txt_jenis_kel_2.TabStop = True
        Me.txt_jenis_kel_2.Text = "Perempuan"
        Me.txt_jenis_kel_2.UseVisualStyleBackColor = True
        '
        'txt_jenis_kel
        '
        Me.txt_jenis_kel.AutoSize = True
        Me.txt_jenis_kel.Enabled = False
        Me.txt_jenis_kel.Location = New System.Drawing.Point(86, 109)
        Me.txt_jenis_kel.Name = "txt_jenis_kel"
        Me.txt_jenis_kel.Size = New System.Drawing.Size(74, 17)
        Me.txt_jenis_kel.TabIndex = 12
        Me.txt_jenis_kel.TabStop = True
        Me.txt_jenis_kel.Text = "Laki - Laki"
        Me.txt_jenis_kel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Alamat"
        '
        'txt_alamat
        '
        Me.txt_alamat.Enabled = False
        Me.txt_alamat.Location = New System.Drawing.Point(86, 191)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(205, 78)
        Me.txt_alamat.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tempat Lahir"
        '
        'txt_tempat_lahir
        '
        Me.txt_tempat_lahir.Enabled = False
        Me.txt_tempat_lahir.Location = New System.Drawing.Point(86, 132)
        Me.txt_tempat_lahir.Name = "txt_tempat_lahir"
        Me.txt_tempat_lahir.Size = New System.Drawing.Size(200, 20)
        Me.txt_tempat_lahir.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Location = New System.Drawing.Point(86, 80)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(205, 20)
        Me.txt_nama.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Anggota"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(86, 23)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(75, 20)
        Me.txt_id.TabIndex = 0
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(638, 361)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(144, 53)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(638, 420)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(144, 53)
        Me.btn_insert.TabIndex = 6
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(638, 538)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(144, 53)
        Me.btn_delete.TabIndex = 7
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(638, 479)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(144, 53)
        Me.btn_edit.TabIndex = 8
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(474, 358)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(154, 20)
        Me.txt_search.TabIndex = 9
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Location = New System.Drawing.Point(420, 361)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(41, 13)
        Me.Search.TabIndex = 10
        Me.Search.Text = "Search"
        '
        'lbl_name
        '
        Me.lbl_name.BackColor = System.Drawing.Color.Maroon
        Me.lbl_name.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_name.Location = New System.Drawing.Point(2, 9)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(792, 66)
        Me.lbl_name.TabIndex = 11
        Me.lbl_name.Text = "Management Anggota"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_password)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_username)
        Me.GroupBox3.Location = New System.Drawing.Point(341, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 91)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account Login"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Password"
        '
        'txt_password
        '
        Me.txt_password.Enabled = False
        Me.txt_password.Location = New System.Drawing.Point(88, 50)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(186, 20)
        Me.txt_password.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Username"
        '
        'txt_username
        '
        Me.txt_username.Enabled = False
        Me.txt_username.Location = New System.Drawing.Point(88, 26)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(184, 20)
        Me.txt_username.TabIndex = 15
        '
        'ManagementAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 606)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ManagementAnggota"
        Me.Text = "ManagementAnggota"
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.data_grid_non, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_tanggal_lahir As DateTimePicker
    Friend WithEvents txt_jenis_kel_2 As RadioButton
    Friend WithEvents txt_jenis_kel As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_tempat_lahir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_conf As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Search As Label
    Friend WithEvents data_grid_non As DataGridView
    Friend WithEvents lbl_name As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_jabatan As ComboBox
End Class
