Public Class ManagementSimpanan
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Private Sub ManagementSimpanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_anggota, nama FROM tbl_anggota WHERE is_active = 1 AND id_jabatan = 'JBT001' "
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid_anggota.DataSource = dt


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ManagementJenisSimpanan.Show()
    End Sub

    Private Sub data_grid_anggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid_anggota.CellClick
        If e.RowIndex >= 0 Then
            Dim id_anggota As String = data_grid_anggota.Rows(e.RowIndex).Cells(0).Value
            Dim sql As String = "SELECT tbl_det_simpanan.id_det_simpanan, jumlah_simpan as [Jumlah Simpan (Rp.)],jumlah_ambil as [Jumlah Ambil (Rp.)], tanggal_transaksi, jenis_simpanan, saldo as [Saldo (Rp.)] FROM (tbl_simpanan INNER JOIN tbl_det_simpanan ON tbl_simpanan.id_simpanan = tbl_det_simpanan.id_simpanan) INNER JOIN tbl_jenis_simpanan ON tbl_jenis_simpanan.id_jenis_simpanan = tbl_simpanan.id_jenis_simpanan WHERE tbl_simpanan.id_anggota = '" + id_anggota + "'"
            Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
            Dim dt As New DataTable

            adapter.Fill(dt)

            data_grid_simpanan.DataSource = dt
            data_grid_simpanan.Columns(1).DefaultCellStyle.Format = "##,##0.00"
            data_grid_simpanan.Columns(2).DefaultCellStyle.Format = "##,##0.00"
            data_grid_simpanan.Columns(5).DefaultCellStyle.Format = "##,##0.00"
        End If
    End Sub

End Class