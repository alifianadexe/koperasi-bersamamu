Public Class PeminjamanAnggota
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Dim angsuranBulan As Double = 0
    Dim bunga As Double = 0
    Dim hasil As Double = 0
    Dim total_bunga As Double = 0

    Private Sub PeminjamanAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT tbl_peminjaman.id_peminjaman as [ID Peminjaman], jumlah_peminjaman as [Jumlah Peminjaman (Rp.)], kali_angsur, jumlah_angsur [Jumlah Angsur (Rp.)], bunga [Bunga (Rp.)], total_bunga [Total Bunga (Rp.)], total_angsur [Total Angsur (Rp.)] FROM tbl_total_bunga INNER JOIN tbl_peminjaman ON tbl_peminjaman.id_peminjaman = tbl_total_bunga.id_peminjaman WHERE id_anggota = '" + Me.Tag + "' AND is_lunas = 0"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        data_grid_pinjaman.DataSource = dt
        data_grid_pinjaman.Columns(1).DefaultCellStyle.Format = "##,##0.00"
        data_grid_pinjaman.Columns(3).DefaultCellStyle.Format = "##,##0.00"
        data_grid_pinjaman.Columns(4).DefaultCellStyle.Format = "##,##0.00"
        data_grid_pinjaman.Columns(5).DefaultCellStyle.Format = "##,##0.00"
        data_grid_pinjaman.Columns(6).DefaultCellStyle.Format = "##,##0.00"

    End Sub

    Private Sub txt_jumlah_TextChanged(sender As Object, e As EventArgs) Handles txt_jumlah.TextChanged
        Try
            Me.lbl_jumlah.Text = "Rp." + Format(Val(Me.txt_jumlah.Text), "##,##0.00")
        Catch ex As Exception
            Me.lbl_jumlah.Text = "Jumlah Tidak Dikenali"
        End Try
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        Dim jumlah As Integer = Val(Me.txt_jumlah.Text)
        Dim kali_angsur As Integer = Val(Me.txt_kali_angsur.Text)

        Dim angsuran As Double = 0
        Dim bungaPersen As Double = 0.05

        angsuran = jumlah / kali_angsur
        bunga = (jumlah * bungaPersen) / kali_angsur
        angsuranBulan = angsuran + bunga

        hasil = angsuranBulan * kali_angsur
        total_bunga = kali_angsur * bunga

        Me.lbl_bunga.Text = "Rp." + Format(bunga, "##,##0.00")
        Me.lbl_angsur.Text = "Rp." + Format(angsuranBulan, "##,##0.00")
        Me.lbl_jumlah_total_angsuran.Text = "Rp." + Format(hasil, "##,##0.00")

    End Sub

    Private Sub btn_pinjam_Click(sender As Object, e As EventArgs) Handles btn_pinjam.Click
        If Not Me.txt_jumlah.Text = "" Then
            If Not hasil = 0 Then
                If MessageBox.Show("Apakah anda ingin meminjam uang dengan jumlah Berikut ?", "will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    Dim id_peminjaman As String = generateID("id_peminjaman", conn)
                    Dim sql As String = "INSERT INTO tbl_peminjaman (id_peminjaman, tanggal_peminjaman, jumlah_peminjaman , kali_angsur, jumlah_angsur, bunga, total_angsur, is_lunas) VALUES (@v1,@v3,@v4,@v5,@v6,@v7,@v8,@v9)"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)

                        cmnd.Parameters.AddWithValue("@v1", id_peminjaman)
                        cmnd.Parameters.AddWithValue("@v3", Date.Now)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_jumlah.Text)
                        cmnd.Parameters.AddWithValue("@v5", Me.txt_kali_angsur.Text)
                        cmnd.Parameters.AddWithValue("@v6", angsuranBulan)
                        cmnd.Parameters.AddWithValue("@v7", bunga)
                        cmnd.Parameters.AddWithValue("@v8", hasil)
                        cmnd.Parameters.AddWithValue("@v9", 0)

                        createTotalBunga(id_peminjaman)

                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Untuk konfirmasi pengambilan uang bisa dilakukan di teller", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End Using
                End If
            End If
        End If
        refreshData()
    End Sub

    Private Sub createTotalBunga(ByVal id_peminjaman As String)
        Dim sql As String = "INSERT INTO tbl_total_bunga (id_total_bunga, id_anggota, id_peminjaman, total_bunga, saldo_shu) VALUES (@v1,@v2,@v3,@v4,@v5)"
        Using cmnd As New SqlClient.SqlCommand(sql, conn)
            cmnd.Parameters.AddWithValue("@v1", generateID("id_total_bunga", conn))
            cmnd.Parameters.AddWithValue("@v2", Me.Tag)
            cmnd.Parameters.AddWithValue("@v3", id_peminjaman)
            cmnd.Parameters.AddWithValue("@v4", total_bunga)
            cmnd.Parameters.AddWithValue("@v5", hasil)

            createAngsuran(id_peminjaman)

            cmnd.ExecuteNonQuery()

        End Using
    End Sub

    Private Sub createAngsuran(ByVal id_peminjaman As String)
        Dim sql As String = "INSERT INTO tbl_angsur (id_angsur, id_peminjaman, tanggal_angsur, bayar_angsur, sisa_angsur, sisa_pinjaman) VALUES (@v1,@v2,@v3,@v4,@v5,@v6)"
        Using cmnd As New SqlClient.SqlCommand(sql, conn)
            cmnd.Parameters.AddWithValue("@v1", generateID("id_angsur", conn))
            cmnd.Parameters.AddWithValue("@v2", id_peminjaman)
            cmnd.Parameters.AddWithValue("@v3", Date.Now)
            cmnd.Parameters.AddWithValue("@v4", 0)
            cmnd.Parameters.AddWithValue("@v5", Me.txt_kali_angsur.Text)
            cmnd.Parameters.AddWithValue("@v6", hasil)

            cmnd.ExecuteNonQuery()

        End Using
    End Sub

    Private Sub data_grid_pinjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid_pinjaman.CellClick
        If e.RowIndex >= 0 Then
            If MessageBox.Show("Bayar Angsuran Pinjaman Ini ?", "Bayar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim id_peminjaman As String = data_grid_pinjaman.Rows(e.RowIndex).Cells(0).Value
                AngsuranForm.Tag = id_peminjaman
                AngsuranForm.Show()
            End If
        End If
    End Sub

End Class