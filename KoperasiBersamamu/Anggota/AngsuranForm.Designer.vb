<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AngsuranForm
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_pinjaman = New System.Windows.Forms.Label()
        Me.lbl_sisa_pinjaman = New System.Windows.Forms.Label()
        Me.lbl_sisa_angsuran = New System.Windows.Forms.Label()
        Me.lbl_bunga = New System.Windows.Forms.Label()
        Me.lbl_jumlah_total_angsuran = New System.Windows.Forms.Label()
        Me.lbl_angsur = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bayar_majemuk_grup = New System.Windows.Forms.GroupBox()
        Me.txt_max = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_min = New System.Windows.Forms.ComboBox()
        Me.btn_bayar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_bayar = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.rdo_button_2 = New System.Windows.Forms.RadioButton()
        Me.rdo_button = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.bayar_majemuk_grup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lbl_pinjaman)
        Me.GroupBox3.Controls.Add(Me.lbl_sisa_pinjaman)
        Me.GroupBox3.Controls.Add(Me.lbl_sisa_angsuran)
        Me.GroupBox3.Controls.Add(Me.lbl_bunga)
        Me.GroupBox3.Controls.Add(Me.lbl_jumlah_total_angsuran)
        Me.GroupBox3.Controls.Add(Me.lbl_angsur)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(412, 233)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pinjaman Anda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Pinjaman"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Sisa Pinjaman"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Sisa Angsuran"
        '
        'lbl_pinjaman
        '
        Me.lbl_pinjaman.AutoSize = True
        Me.lbl_pinjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pinjaman.Location = New System.Drawing.Point(201, 125)
        Me.lbl_pinjaman.Name = "lbl_pinjaman"
        Me.lbl_pinjaman.Size = New System.Drawing.Size(61, 20)
        Me.lbl_pinjaman.TabIndex = 8
        Me.lbl_pinjaman.Text = "Bunga"
        '
        'lbl_sisa_pinjaman
        '
        Me.lbl_sisa_pinjaman.AutoSize = True
        Me.lbl_sisa_pinjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sisa_pinjaman.Location = New System.Drawing.Point(201, 184)
        Me.lbl_sisa_pinjaman.Name = "lbl_sisa_pinjaman"
        Me.lbl_sisa_pinjaman.Size = New System.Drawing.Size(193, 20)
        Me.lbl_sisa_pinjaman.TabIndex = 7
        Me.lbl_sisa_pinjaman.Text = "Jumlah Total Angsuran"
        '
        'lbl_sisa_angsuran
        '
        Me.lbl_sisa_angsuran.AutoSize = True
        Me.lbl_sisa_angsuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sisa_angsuran.Location = New System.Drawing.Point(201, 92)
        Me.lbl_sisa_angsuran.Name = "lbl_sisa_angsuran"
        Me.lbl_sisa_angsuran.Size = New System.Drawing.Size(100, 20)
        Me.lbl_sisa_angsuran.TabIndex = 6
        Me.lbl_sisa_angsuran.Text = "Kali Angsur"
        '
        'lbl_bunga
        '
        Me.lbl_bunga.AutoSize = True
        Me.lbl_bunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bunga.Location = New System.Drawing.Point(201, 27)
        Me.lbl_bunga.Name = "lbl_bunga"
        Me.lbl_bunga.Size = New System.Drawing.Size(61, 20)
        Me.lbl_bunga.TabIndex = 5
        Me.lbl_bunga.Text = "Bunga"
        '
        'lbl_jumlah_total_angsuran
        '
        Me.lbl_jumlah_total_angsuran.AutoSize = True
        Me.lbl_jumlah_total_angsuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah_total_angsuran.Location = New System.Drawing.Point(201, 155)
        Me.lbl_jumlah_total_angsuran.Name = "lbl_jumlah_total_angsuran"
        Me.lbl_jumlah_total_angsuran.Size = New System.Drawing.Size(193, 20)
        Me.lbl_jumlah_total_angsuran.TabIndex = 4
        Me.lbl_jumlah_total_angsuran.Text = "Jumlah Total Angsuran"
        '
        'lbl_angsur
        '
        Me.lbl_angsur.AutoSize = True
        Me.lbl_angsur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_angsur.Location = New System.Drawing.Point(201, 60)
        Me.lbl_angsur.Name = "lbl_angsur"
        Me.lbl_angsur.Size = New System.Drawing.Size(100, 20)
        Me.lbl_angsur.TabIndex = 3
        Me.lbl_angsur.Text = "Kali Angsur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Bunga ( 0.5% )"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jumlah Total Angsuran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Angsuran"
        '
        'bayar_majemuk_grup
        '
        Me.bayar_majemuk_grup.Controls.Add(Me.txt_max)
        Me.bayar_majemuk_grup.Controls.Add(Me.Label3)
        Me.bayar_majemuk_grup.Controls.Add(Me.txt_min)
        Me.bayar_majemuk_grup.Location = New System.Drawing.Point(227, 340)
        Me.bayar_majemuk_grup.Name = "bayar_majemuk_grup"
        Me.bayar_majemuk_grup.Size = New System.Drawing.Size(171, 51)
        Me.bayar_majemuk_grup.TabIndex = 13
        Me.bayar_majemuk_grup.TabStop = False
        Me.bayar_majemuk_grup.Text = "Angsuran Bulan Ke "
        '
        'txt_max
        '
        Me.txt_max.FormattingEnabled = True
        Me.txt_max.Location = New System.Drawing.Point(111, 19)
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(49, 21)
        Me.txt_max.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Sampai"
        '
        'txt_min
        '
        Me.txt_min.FormattingEnabled = True
        Me.txt_min.Location = New System.Drawing.Point(10, 19)
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(47, 21)
        Me.txt_min.TabIndex = 14
        '
        'btn_bayar
        '
        Me.btn_bayar.Location = New System.Drawing.Point(132, 457)
        Me.btn_bayar.Name = "btn_bayar"
        Me.btn_bayar.Size = New System.Drawing.Size(144, 48)
        Me.btn_bayar.TabIndex = 14
        Me.btn_bayar.Text = "Bayar"
        Me.btn_bayar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_bayar)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 395)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 56)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Jumlah Dibayarkan"
        '
        'lbl_bayar
        '
        Me.lbl_bayar.AutoSize = True
        Me.lbl_bayar.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bayar.Location = New System.Drawing.Point(118, 16)
        Me.lbl_bayar.Name = "lbl_bayar"
        Me.lbl_bayar.Size = New System.Drawing.Size(140, 25)
        Me.lbl_bayar.TabIndex = 8
        Me.lbl_bayar.Text = "Rp. 12,000,000"
        Me.lbl_bayar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_name
        '
        Me.lbl_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_name.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_name.Location = New System.Drawing.Point(-7, 9)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(451, 66)
        Me.lbl_name.TabIndex = 16
        Me.lbl_name.Text = "Angsuran Form"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdo_button_2
        '
        Me.rdo_button_2.AutoSize = True
        Me.rdo_button_2.Location = New System.Drawing.Point(264, 317)
        Me.rdo_button_2.Name = "rdo_button_2"
        Me.rdo_button_2.Size = New System.Drawing.Size(98, 17)
        Me.rdo_button_2.TabIndex = 17
        Me.rdo_button_2.TabStop = True
        Me.rdo_button_2.Text = "Bayar Majemuk"
        Me.rdo_button_2.UseVisualStyleBackColor = True
        '
        'rdo_button
        '
        Me.rdo_button.AutoSize = True
        Me.rdo_button.Location = New System.Drawing.Point(63, 317)
        Me.rdo_button.Name = "rdo_button"
        Me.rdo_button.Size = New System.Drawing.Size(96, 17)
        Me.rdo_button.TabIndex = 18
        Me.rdo_button.TabStop = True
        Me.rdo_button.Text = "Bayar Bulan Ini"
        Me.rdo_button.UseVisualStyleBackColor = True
        '
        'AngsuranForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 519)
        Me.Controls.Add(Me.rdo_button_2)
        Me.Controls.Add(Me.rdo_button)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_bayar)
        Me.Controls.Add(Me.bayar_majemuk_grup)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "AngsuranForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AngsuranForm"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.bayar_majemuk_grup.ResumeLayout(False)
        Me.bayar_majemuk_grup.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_bunga As Label
    Friend WithEvents lbl_jumlah_total_angsuran As Label
    Friend WithEvents lbl_angsur As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_pinjaman As Label
    Friend WithEvents lbl_sisa_pinjaman As Label
    Friend WithEvents lbl_sisa_angsuran As Label
    Friend WithEvents bayar_majemuk_grup As GroupBox
    Friend WithEvents btn_bayar As Button
    Friend WithEvents txt_max As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_min As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_bayar As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents rdo_button As RadioButton
    Friend WithEvents rdo_button_2 As RadioButton
End Class
