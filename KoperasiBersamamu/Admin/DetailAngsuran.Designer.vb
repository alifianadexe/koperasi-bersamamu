<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetailAngsuran
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
        Me.data_gird = New System.Windows.Forms.DataGridView()
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
        CType(Me.data_gird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'data_gird
        '
        Me.data_gird.AllowUserToAddRows = False
        Me.data_gird.AllowUserToDeleteRows = False
        Me.data_gird.AllowUserToOrderColumns = True
        Me.data_gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_gird.Location = New System.Drawing.Point(12, 254)
        Me.data_gird.Name = "data_gird"
        Me.data_gird.ReadOnly = True
        Me.data_gird.Size = New System.Drawing.Size(535, 240)
        Me.data_gird.TabIndex = 0
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
        Me.GroupBox3.Location = New System.Drawing.Point(68, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(412, 233)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Pinjaman"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Pinjaman"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Sisa Pinjaman"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Sisa Angsuran"
        '
        'lbl_pinjaman
        '
        Me.lbl_pinjaman.AutoSize = True
        Me.lbl_pinjaman.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pinjaman.Location = New System.Drawing.Point(201, 122)
        Me.lbl_pinjaman.Name = "lbl_pinjaman"
        Me.lbl_pinjaman.Size = New System.Drawing.Size(43, 15)
        Me.lbl_pinjaman.TabIndex = 8
        Me.lbl_pinjaman.Text = "Bunga"
        '
        'lbl_sisa_pinjaman
        '
        Me.lbl_sisa_pinjaman.AutoSize = True
        Me.lbl_sisa_pinjaman.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sisa_pinjaman.Location = New System.Drawing.Point(201, 181)
        Me.lbl_sisa_pinjaman.Name = "lbl_sisa_pinjaman"
        Me.lbl_sisa_pinjaman.Size = New System.Drawing.Size(138, 15)
        Me.lbl_sisa_pinjaman.TabIndex = 7
        Me.lbl_sisa_pinjaman.Text = "Jumlah Total Angsuran"
        '
        'lbl_sisa_angsuran
        '
        Me.lbl_sisa_angsuran.AutoSize = True
        Me.lbl_sisa_angsuran.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sisa_angsuran.Location = New System.Drawing.Point(201, 89)
        Me.lbl_sisa_angsuran.Name = "lbl_sisa_angsuran"
        Me.lbl_sisa_angsuran.Size = New System.Drawing.Size(73, 15)
        Me.lbl_sisa_angsuran.TabIndex = 6
        Me.lbl_sisa_angsuran.Text = "Kali Angsur"
        '
        'lbl_bunga
        '
        Me.lbl_bunga.AutoSize = True
        Me.lbl_bunga.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bunga.Location = New System.Drawing.Point(201, 24)
        Me.lbl_bunga.Name = "lbl_bunga"
        Me.lbl_bunga.Size = New System.Drawing.Size(43, 15)
        Me.lbl_bunga.TabIndex = 5
        Me.lbl_bunga.Text = "Bunga"
        '
        'lbl_jumlah_total_angsuran
        '
        Me.lbl_jumlah_total_angsuran.AutoSize = True
        Me.lbl_jumlah_total_angsuran.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah_total_angsuran.Location = New System.Drawing.Point(201, 152)
        Me.lbl_jumlah_total_angsuran.Name = "lbl_jumlah_total_angsuran"
        Me.lbl_jumlah_total_angsuran.Size = New System.Drawing.Size(138, 15)
        Me.lbl_jumlah_total_angsuran.TabIndex = 4
        Me.lbl_jumlah_total_angsuran.Text = "Jumlah Total Angsuran"
        '
        'lbl_angsur
        '
        Me.lbl_angsur.AutoSize = True
        Me.lbl_angsur.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_angsur.Location = New System.Drawing.Point(201, 57)
        Me.lbl_angsur.Name = "lbl_angsur"
        Me.lbl_angsur.Size = New System.Drawing.Size(73, 15)
        Me.lbl_angsur.TabIndex = 3
        Me.lbl_angsur.Text = "Kali Angsur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Bunga ( 0.5% )"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jumlah Total Angsuran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Angsuran"
        '
        'DetailAngsuran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 506)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.data_gird)
        Me.Name = "DetailAngsuran"
        Me.Text = "DetailAngsuran"
        CType(Me.data_gird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents data_gird As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_pinjaman As Label
    Friend WithEvents lbl_sisa_pinjaman As Label
    Friend WithEvents lbl_sisa_angsuran As Label
    Friend WithEvents lbl_bunga As Label
    Friend WithEvents lbl_jumlah_total_angsuran As Label
    Friend WithEvents lbl_angsur As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
