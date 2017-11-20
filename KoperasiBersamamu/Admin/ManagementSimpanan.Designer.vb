<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementSimpanan
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
        Me.data_grid_anggota = New System.Windows.Forms.DataGridView()
        Me.data_grid_simpanan = New System.Windows.Forms.DataGridView()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.data_grid_anggota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_grid_simpanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_grid_anggota
        '
        Me.data_grid_anggota.AllowUserToAddRows = False
        Me.data_grid_anggota.AllowUserToDeleteRows = False
        Me.data_grid_anggota.AllowUserToOrderColumns = True
        Me.data_grid_anggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_anggota.Location = New System.Drawing.Point(12, 110)
        Me.data_grid_anggota.Name = "data_grid_anggota"
        Me.data_grid_anggota.ReadOnly = True
        Me.data_grid_anggota.Size = New System.Drawing.Size(245, 484)
        Me.data_grid_anggota.TabIndex = 0
        '
        'data_grid_simpanan
        '
        Me.data_grid_simpanan.AllowUserToAddRows = False
        Me.data_grid_simpanan.AllowUserToDeleteRows = False
        Me.data_grid_simpanan.AllowUserToOrderColumns = True
        Me.data_grid_simpanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_grid_simpanan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data_grid_simpanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_simpanan.Location = New System.Drawing.Point(276, 110)
        Me.data_grid_simpanan.Name = "data_grid_simpanan"
        Me.data_grid_simpanan.ReadOnly = True
        Me.data_grid_simpanan.Size = New System.Drawing.Size(771, 423)
        Me.data_grid_simpanan.TabIndex = 1
        '
        'lbl_name
        '
        Me.lbl_name.BackColor = System.Drawing.Color.Maroon
        Me.lbl_name.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_name.Location = New System.Drawing.Point(-4, 9)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(1065, 66)
        Me.lbl_name.TabIndex = 12
        Me.lbl_name.Text = "Management Simpanan"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(892, 539)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 55)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Jenis Simpanan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Daftar Anggota"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Garamond", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(276, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(771, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Rekap Tabungan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ManagementSimpanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 606)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.data_grid_simpanan)
        Me.Controls.Add(Me.data_grid_anggota)
        Me.Name = "ManagementSimpanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagementSimpanan"
        CType(Me.data_grid_anggota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_grid_simpanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents data_grid_anggota As DataGridView
    Friend WithEvents data_grid_simpanan As DataGridView
    Friend WithEvents lbl_name As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
