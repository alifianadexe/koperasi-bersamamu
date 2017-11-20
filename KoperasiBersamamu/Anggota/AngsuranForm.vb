Public Class AngsuranForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Dim max As Integer
    Dim min As Integer
    Dim angsur As Integer
    Dim sisaAngsur As Integer
    Dim sisaPinjaman As Integer

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
            angsur = rd.Item("jumlah_angsur")
            sisaAngsur = rd.Item("sisa_angsur")
            sisaPinjaman = rd.Item("sisa_pinjaman")

            Me.lbl_angsur.Text = "Rp." + Format(angsur, "##,##0.00")
            Me.lbl_bunga.Text = "Rp." + Format(rd.Item("bunga"), "##,##0.00")
            Me.lbl_jumlah_total_angsuran.Text = "Rp." + Format(rd.Item("total_angsur"), "##,##0.00")
            Me.lbl_pinjaman.Text = "Rp." + Format(rd.Item("jumlah_peminjaman"), "##,##0.00")
            Me.lbl_sisa_angsuran.Text = sisaAngsur
            Me.lbl_sisa_pinjaman.Text = "Rp." + Format(sisaPinjaman, "##,##0.00")

        End If

        rd.Close()

        Me.lbl_bayar.Text = Me.lbl_angsur.Text

        If sisaPinjaman = 0 And sisaAngsur = 0 Then
            Dim sql_up As String = "UPDATE tbl_peminjaman SET is_lunas = 1 WHERE id_peminjaman = '" + Me.Tag + "'"
            Dim cmnd_up As New SqlClient.SqlCommand(sql_up, conn)
            cmnd_up.ExecuteNonQuery()
            MessageBox.Show("Selamat, Hutang anda sudah lunas", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

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

    Private Sub btn_bayar_Click(sender As Object, e As EventArgs) Handles btn_bayar.Click
        If MessageBox.Show("Apakah anda ingin membayar angsuran bulan ini ?", "Will You", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sql As String = "INSERT INTO tbl_angsur (id_angsur, id_peminjaman, tanggal_angsur, bayar_angsur, sisa_angsur, sisa_pinjaman) VALUES (@v1,@v2,@v3,@v4,@v5,@v6)"
            Using cmnd As New SqlClient.SqlCommand(sql, conn)
                cmnd.Parameters.AddWithValue("@v1", generateID("id_angsur", conn))
                cmnd.Parameters.AddWithValue("@v2", Me.Tag)
                cmnd.Parameters.AddWithValue("@v3", Date.Now)
                cmnd.Parameters.AddWithValue("@v4", angsur)
                cmnd.Parameters.AddWithValue("@v5", (sisaAngsur - 1))
                cmnd.Parameters.AddWithValue("@v6", (sisaPinjaman - angsur))

                cmnd.ExecuteNonQuery()
                MessageBox.Show("Selamat, Anda telah membayar angsuran bulan ini", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


            End Using
        End If
        refreshData()
        refreshComboBox()
    End Sub
End Class