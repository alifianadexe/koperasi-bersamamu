Public Class AngsuranForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Dim max As Integer
    Dim min As Integer

    Private Sub AngsuranForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
        refreshComboBox()

        Me.rdo_button.Checked = True

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT sisa_angsur, sisa_pinjaman, jumlah_peminjaman, kali_angsur, jumlah_angsur, bunga, total_angsur FROM tbl_peminjaman INNER JOIN tbl_angsur ON tbl_peminjaman.id_peminjaman = tbl_angsur.id_peminjaman WHERE tbl_peminjaman.id_peminjaman = '" + Me.Tag + "' ORDER BY id_angsur DESC"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then

            max = rd.Item("kali_angsur")
            min = rd.Item("sisa_angsur")

            Me.lbl_angsur.Text = "Rp." + Format(rd.Item("jumlah_angsur"), "##,##0.00")
            Me.lbl_bunga.Text = "Rp." + Format(rd.Item("bunga"), "##,##0.00")
            Me.lbl_jumlah_total_angsuran.Text = "Rp." + Format(rd.Item("total_angsur"), "##,##0.00")
            Me.lbl_pinjaman.Text = "Rp." + Format(rd.Item("jumlah_peminjaman"), "##,##0.00")
            Me.lbl_sisa_angsuran.Text = rd.Item("sisa_angsur")
            Me.lbl_sisa_pinjaman.Text = "Rp." + Format(rd.Item("sisa_pinjaman"), "##,##0.00")
        End If

        rd.Close()

        Me.lbl_bayar.Text = Me.lbl_angsur.Text

    End Sub

    Private Sub refreshComboBox()
        For i As Integer = (max - min) To min
            Me.txt_max.Items.Add(i)
            Me.txt_min.Items.Add(i)
        Next
    End Sub

    Private Sub rdo_button_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_button.CheckedChanged
        Me.lbl_bayar.Text = Me.lbl_angsur.Text
        bayar_majemuk_grup.Enabled = False
    End Sub

    Private Sub rdo_button_2_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_button_2.CheckedChanged
        bayar_majemuk_grup.Enabled = True
    End Sub
End Class