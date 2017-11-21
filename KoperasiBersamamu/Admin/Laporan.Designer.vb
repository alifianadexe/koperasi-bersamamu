<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.btn_anggota = New System.Windows.Forms.Button()
        Me.btn_peminjaman = New System.Windows.Forms.Button()
        Me.btn_bunga = New System.Windows.Forms.Button()
        Me.btn_keuangan = New System.Windows.Forms.Button()
        Me.btn_simpanan = New System.Windows.Forms.Button()
        Me.btn_gaji = New System.Windows.Forms.Button()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_anggota
        '
        Me.btn_anggota.Location = New System.Drawing.Point(12, 113)
        Me.btn_anggota.Name = "btn_anggota"
        Me.btn_anggota.Size = New System.Drawing.Size(185, 56)
        Me.btn_anggota.TabIndex = 0
        Me.btn_anggota.Text = "Anggota"
        Me.btn_anggota.UseVisualStyleBackColor = True
        '
        'btn_peminjaman
        '
        Me.btn_peminjaman.Location = New System.Drawing.Point(12, 175)
        Me.btn_peminjaman.Name = "btn_peminjaman"
        Me.btn_peminjaman.Size = New System.Drawing.Size(185, 56)
        Me.btn_peminjaman.TabIndex = 1
        Me.btn_peminjaman.Text = "Peminjaman"
        Me.btn_peminjaman.UseVisualStyleBackColor = True
        '
        'btn_bunga
        '
        Me.btn_bunga.Location = New System.Drawing.Point(12, 237)
        Me.btn_bunga.Name = "btn_bunga"
        Me.btn_bunga.Size = New System.Drawing.Size(185, 56)
        Me.btn_bunga.TabIndex = 2
        Me.btn_bunga.Text = "Bunga"
        Me.btn_bunga.UseVisualStyleBackColor = True
        '
        'btn_keuangan
        '
        Me.btn_keuangan.Location = New System.Drawing.Point(203, 113)
        Me.btn_keuangan.Name = "btn_keuangan"
        Me.btn_keuangan.Size = New System.Drawing.Size(188, 56)
        Me.btn_keuangan.TabIndex = 3
        Me.btn_keuangan.Text = "Keuangan"
        Me.btn_keuangan.UseVisualStyleBackColor = True
        '
        'btn_simpanan
        '
        Me.btn_simpanan.Location = New System.Drawing.Point(203, 175)
        Me.btn_simpanan.Name = "btn_simpanan"
        Me.btn_simpanan.Size = New System.Drawing.Size(185, 56)
        Me.btn_simpanan.TabIndex = 4
        Me.btn_simpanan.Text = "Simpanan"
        Me.btn_simpanan.UseVisualStyleBackColor = True
        '
        'btn_gaji
        '
        Me.btn_gaji.Location = New System.Drawing.Point(203, 237)
        Me.btn_gaji.Name = "btn_gaji"
        Me.btn_gaji.Size = New System.Drawing.Size(185, 56)
        Me.btn_gaji.TabIndex = 5
        Me.btn_gaji.Text = "Gaji"
        Me.btn_gaji.UseVisualStyleBackColor = True
        '
        'lbl_name
        '
        Me.lbl_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_name.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_name.Location = New System.Drawing.Point(-4, 9)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(414, 66)
        Me.lbl_name.TabIndex = 6
        Me.lbl_name.Text = "Laporan"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 305)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.btn_gaji)
        Me.Controls.Add(Me.btn_simpanan)
        Me.Controls.Add(Me.btn_keuangan)
        Me.Controls.Add(Me.btn_bunga)
        Me.Controls.Add(Me.btn_peminjaman)
        Me.Controls.Add(Me.btn_anggota)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_anggota As Button
    Friend WithEvents btn_peminjaman As Button
    Friend WithEvents btn_bunga As Button
    Friend WithEvents btn_keuangan As Button
    Friend WithEvents btn_simpanan As Button
    Friend WithEvents btn_gaji As Button
    Friend WithEvents lbl_name As Label
End Class
