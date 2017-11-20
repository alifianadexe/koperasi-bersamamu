<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeminjamanAnggota
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
        Me.data_grid_pinjaman = New System.Windows.Forms.DataGridView()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.btn_pinjam = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kali_angsur = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_bunga = New System.Windows.Forms.Label()
        Me.lbl_jumlah_total_angsuran = New System.Windows.Forms.Label()
        Me.lbl_angsur = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_jumlah = New System.Windows.Forms.Label()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        CType(Me.data_grid_pinjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'data_grid_pinjaman
        '
        Me.data_grid_pinjaman.AllowUserToAddRows = False
        Me.data_grid_pinjaman.AllowUserToDeleteRows = False
        Me.data_grid_pinjaman.AllowUserToOrderColumns = True
        Me.data_grid_pinjaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_grid_pinjaman.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data_grid_pinjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_pinjaman.Location = New System.Drawing.Point(12, 299)
        Me.data_grid_pinjaman.Name = "data_grid_pinjaman"
        Me.data_grid_pinjaman.ReadOnly = True
        Me.data_grid_pinjaman.Size = New System.Drawing.Size(806, 178)
        Me.data_grid_pinjaman.TabIndex = 0
        '
        'lbl_name
        '
        Me.lbl_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_name.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_name.Location = New System.Drawing.Point(-5, 9)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(823, 66)
        Me.lbl_name.TabIndex = 6
        Me.lbl_name.Text = "Rekap Peminjaman "
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_hitung)
        Me.GroupBox1.Controls.Add(Me.btn_pinjam)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 215)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Peminjaman"
        '
        'btn_hitung
        '
        Me.btn_hitung.Location = New System.Drawing.Point(276, 134)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(140, 57)
        Me.btn_hitung.TabIndex = 13
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'btn_pinjam
        '
        Me.btn_pinjam.Location = New System.Drawing.Point(567, 134)
        Me.btn_pinjam.Name = "btn_pinjam"
        Me.btn_pinjam.Size = New System.Drawing.Size(216, 57)
        Me.btn_pinjam.TabIndex = 12
        Me.btn_pinjam.Text = "Pinjam"
        Me.btn_pinjam.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txt_kali_angsur)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 134)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(154, 69)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Jumlah Kali Angsur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kali  /  Bulan"
        '
        'txt_kali_angsur
        '
        Me.txt_kali_angsur.FormattingEnabled = True
        Me.txt_kali_angsur.Items.AddRange(New Object() {"1", "2", "3", "6", "9", "12", "15", "18", "21", "24"})
        Me.txt_kali_angsur.Location = New System.Drawing.Point(11, 26)
        Me.txt_kali_angsur.Name = "txt_kali_angsur"
        Me.txt_kali_angsur.Size = New System.Drawing.Size(60, 21)
        Me.txt_kali_angsur.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_bunga)
        Me.GroupBox3.Controls.Add(Me.lbl_jumlah_total_angsuran)
        Me.GroupBox3.Controls.Add(Me.lbl_angsur)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(276, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 109)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Perhitungan"
        '
        'lbl_bunga
        '
        Me.lbl_bunga.AutoSize = True
        Me.lbl_bunga.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bunga.Location = New System.Drawing.Point(221, 27)
        Me.lbl_bunga.Name = "lbl_bunga"
        Me.lbl_bunga.Size = New System.Drawing.Size(55, 17)
        Me.lbl_bunga.TabIndex = 5
        Me.lbl_bunga.Text = "Bunga"
        '
        'lbl_jumlah_total_angsuran
        '
        Me.lbl_jumlah_total_angsuran.AutoSize = True
        Me.lbl_jumlah_total_angsuran.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah_total_angsuran.Location = New System.Drawing.Point(221, 74)
        Me.lbl_jumlah_total_angsuran.Name = "lbl_jumlah_total_angsuran"
        Me.lbl_jumlah_total_angsuran.Size = New System.Drawing.Size(183, 17)
        Me.lbl_jumlah_total_angsuran.TabIndex = 4
        Me.lbl_jumlah_total_angsuran.Text = "Jumlah Total Angsuran"
        '
        'lbl_angsur
        '
        Me.lbl_angsur.AutoSize = True
        Me.lbl_angsur.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_angsur.Location = New System.Drawing.Point(221, 51)
        Me.lbl_angsur.Name = "lbl_angsur"
        Me.lbl_angsur.Size = New System.Drawing.Size(94, 17)
        Me.lbl_angsur.TabIndex = 3
        Me.lbl_angsur.Text = "Kali Angsur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Bunga ( 0.5% )"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jumlah Total Angsuran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Angsuran"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lbl_jumlah)
        Me.GroupBox2.Controls.Add(Me.txt_jumlah)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 109)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Jumlah Peminjaman "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Masukkan Jumlah"
        '
        'lbl_jumlah
        '
        Me.lbl_jumlah.AutoSize = True
        Me.lbl_jumlah.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah.Location = New System.Drawing.Point(6, 16)
        Me.lbl_jumlah.Name = "lbl_jumlah"
        Me.lbl_jumlah.Size = New System.Drawing.Size(65, 28)
        Me.lbl_jumlah.TabIndex = 8
        Me.lbl_jumlah.Text = "Rp. - "
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(6, 74)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(230, 20)
        Me.txt_jumlah.TabIndex = 6
        '
        'PeminjamanAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 489)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.data_grid_pinjaman)
        Me.Name = "PeminjamanAnggota"
        Me.Text = "PeminjamanAnggota"
        CType(Me.data_grid_pinjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents data_grid_pinjaman As DataGridView
    Friend WithEvents lbl_name As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_jumlah As Label
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_kali_angsur As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_bunga As Label
    Friend WithEvents lbl_jumlah_total_angsuran As Label
    Friend WithEvents lbl_angsur As Label
    Friend WithEvents btn_pinjam As Button
    Friend WithEvents btn_hitung As Button
End Class
