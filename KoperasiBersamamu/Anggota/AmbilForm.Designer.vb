<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AmbilForm
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
        Me.lbl_jumlah = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_simpanan = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_jumlah)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_jumlah)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 134)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ambil"
        '
        'lbl_jumlah
        '
        Me.lbl_jumlah.AutoSize = True
        Me.lbl_jumlah.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah.Location = New System.Drawing.Point(110, 16)
        Me.lbl_jumlah.Name = "lbl_jumlah"
        Me.lbl_jumlah.Size = New System.Drawing.Size(65, 28)
        Me.lbl_jumlah.TabIndex = 5
        Me.lbl_jumlah.Text = "Rp. - "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Jumlah (Rp.)"
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(115, 59)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(263, 20)
        Me.txt_jumlah.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ambil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_simpanan
        '
        Me.lbl_simpanan.AutoSize = True
        Me.lbl_simpanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_simpanan.Location = New System.Drawing.Point(521, 9)
        Me.lbl_simpanan.Name = "lbl_simpanan"
        Me.lbl_simpanan.Size = New System.Drawing.Size(45, 13)
        Me.lbl_simpanan.TabIndex = 4
        Me.lbl_simpanan.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(447, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID Simpanan"
        '
        'AmbilForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 176)
        Me.Controls.Add(Me.lbl_simpanan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AmbilForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AmbilForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_jumlah As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_simpanan As Label
    Friend WithEvents Label4 As Label
End Class
