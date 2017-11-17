<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarAnggota
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_re_password = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.btn_daftar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Diri"
        '
        'txt_tanggal_lahir
        '
        Me.txt_tanggal_lahir.Enabled = False
        Me.txt_tanggal_lahir.Location = New System.Drawing.Point(86, 127)
        Me.txt_tanggal_lahir.Name = "txt_tanggal_lahir"
        Me.txt_tanggal_lahir.Size = New System.Drawing.Size(200, 20)
        Me.txt_tanggal_lahir.TabIndex = 14
        '
        'txt_jenis_kel_2
        '
        Me.txt_jenis_kel_2.AutoSize = True
        Me.txt_jenis_kel_2.Enabled = False
        Me.txt_jenis_kel_2.Location = New System.Drawing.Point(182, 78)
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
        Me.txt_jenis_kel.Location = New System.Drawing.Point(86, 78)
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
        Me.Label6.Location = New System.Drawing.Point(6, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Alamat"
        '
        'txt_alamat
        '
        Me.txt_alamat.Enabled = False
        Me.txt_alamat.Location = New System.Drawing.Point(86, 153)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(205, 78)
        Me.txt_alamat.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tempat Lahir"
        '
        'txt_tempat_lahir
        '
        Me.txt_tempat_lahir.Enabled = False
        Me.txt_tempat_lahir.Location = New System.Drawing.Point(86, 101)
        Me.txt_tempat_lahir.Name = "txt_tempat_lahir"
        Me.txt_tempat_lahir.Size = New System.Drawing.Size(200, 20)
        Me.txt_tempat_lahir.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Location = New System.Drawing.Point(86, 49)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_re_password)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_password)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_username)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 121)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Login"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Re - Password"
        '
        'txt_re_password
        '
        Me.txt_re_password.Enabled = False
        Me.txt_re_password.Location = New System.Drawing.Point(88, 76)
        Me.txt_re_password.Name = "txt_re_password"
        Me.txt_re_password.Size = New System.Drawing.Size(186, 20)
        Me.txt_re_password.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Password"
        '
        'txt_password
        '
        Me.txt_password.Enabled = False
        Me.txt_password.Location = New System.Drawing.Point(88, 50)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(186, 20)
        Me.txt_password.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Username"
        '
        'txt_username
        '
        Me.txt_username.Enabled = False
        Me.txt_username.Location = New System.Drawing.Point(88, 26)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(184, 20)
        Me.txt_username.TabIndex = 15
        '
        'btn_daftar
        '
        Me.btn_daftar.Location = New System.Drawing.Point(416, 179)
        Me.btn_daftar.Name = "btn_daftar"
        Me.btn_daftar.Size = New System.Drawing.Size(175, 64)
        Me.btn_daftar.TabIndex = 2
        Me.btn_daftar.Text = "Daftar"
        Me.btn_daftar.UseVisualStyleBackColor = True
        '
        'DaftarAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 280)
        Me.Controls.Add(Me.btn_daftar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DaftarAnggota"
        Me.Text = "DaftarAnggota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_tempat_lahir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_daftar As Button
    Friend WithEvents txt_jenis_kel_2 As RadioButton
    Friend WithEvents txt_jenis_kel As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents txt_tanggal_lahir As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_re_password As TextBox
End Class
