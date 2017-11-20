Public Class DetailAngsuran

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub DetailAngsuran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
        refreshDataGroup()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_angsur, bayar_angsur as [Angsuran Anda (Rp.)], sisa_angsur [Sisa Angsuran (Rp.)], sisa_pinjaman [Sisa Pinjaman (Rp.)], tanggal_angsur FROM tbl_angsur WHERE id_peminjaman = '" + Me.Tag + "'"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        data_gird.DataSource = dt

        data_gird.Columns(1).DefaultCellStyle.Format = "##,##0.00"
        data_gird.Columns(3).DefaultCellStyle.Format = "##,##0.00"

    End Sub

    Private Sub refreshDataGroup()
        Dim sql As String = "SELECT sisa_angsur, sisa_pinjaman, jumlah_peminjaman, kali_angsur, jumlah_angsur, bunga, total_angsur FROM tbl_peminjaman INNER JOIN tbl_angsur ON tbl_peminjaman.id_peminjaman = tbl_angsur.id_peminjaman WHERE tbl_peminjaman.id_peminjaman = '" + Me.Tag + "' ORDER BY id_angsur DESC"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        Dim angsur As Integer
        Dim sisaAngsur As Integer
        Dim sisaPinjaman As Integer

        If rd.HasRows Then

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
    End Sub

End Class