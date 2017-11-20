Public Class ManagementPinjaman
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Private Sub ManagementPinjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub data_grid_anggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid_anggota.CellClick
        If e.RowIndex >= 0 Then
            Dim id_anggota As String = data_grid_anggota.Rows(e.RowIndex).Cells(0).Value
            Dim sql As String = "SELECT tbl_peminjaman.id_peminjaman as [ID Peminjaman], jumlah_peminjaman, kali_angsur, jumlah_angsur, bunga, total_bunga, total_angsur FROM tbl_total_bunga INNER JOIN tbl_peminjaman ON tbl_peminjaman.id_peminjaman = tbl_total_bunga.id_peminjaman WHERE id_anggota = '" + id_anggota + "'"
            Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
            Dim dt As New DataTable

            adapter.Fill(dt)

            data_grid_pinjaman.DataSource = dt
            data_grid_pinjaman.Columns(1).DefaultCellStyle.Format = "##,##0.00"
            data_grid_pinjaman.Columns(3).DefaultCellStyle.Format = "##,##0.00"
            data_grid_pinjaman.Columns(4).DefaultCellStyle.Format = "##,##0.00"
            data_grid_pinjaman.Columns(5).DefaultCellStyle.Format = "##,##0.00"
            data_grid_pinjaman.Columns(7).DefaultCellStyle.Format = "##,##0.00"

        End If
    End Sub
End Class