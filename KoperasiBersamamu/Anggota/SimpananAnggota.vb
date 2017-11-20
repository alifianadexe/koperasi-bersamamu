Public Class SimpananAnggota

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub SimpananAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT tbl_det_simpanan.id_det_simpanan, jumlah_simpan as [Jumlah Simpan (Rp.)], jumlah_ambil as [Jumlah Ambil (Rp.)], tanggal_transaksi, jenis_simpanan, total as [Total (Rp.)] FROM (tbl_simpanan INNER JOIN tbl_det_simpanan ON tbl_simpanan.id_simpanan = tbl_det_simpanan.id_simpanan) INNER JOIN tbl_jenis_simpanan ON tbl_jenis_simpanan.id_jenis_simpanan = tbl_det_simpanan.id_jenis_simpanan WHERE tbl_simpanan.id_anggota = '" + Me.Tag + "'"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        data_grid.DataSource = dt
        data_grid.Columns(1).DefaultCellStyle.Format = "##,##0.00"
        data_grid.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        data_grid.Columns(5).DefaultCellStyle.Format = "##,##0.00"

        If (data_grid.Rows.Count - 1) >= 0 Then
            Me.lbl_saldo.Text = "Rp." + Format(Val(data_grid.Rows(data_grid.Rows.Count - 1).Cells(5).Value.ToString), "##,##0.00")
        End If

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String = "SELECT * FROM tbl_simpanan WHERE id_anggota = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()
        Dim smpn As New SimpanForm

        If rd.HasRows Then
            smpn.lbl_simpanan.Text = rd.Item("id_simpanan")
            smpn.value = rd.Item("saldo")
        End If

        smpn.Tag = Me.Tag
        rd.Close()

        smpn.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "SELECT * FROM tbl_simpanan WHERE id_anggota = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()
        Dim smpn As New AmbilForm

        If rd.HasRows Then
            smpn.lbl_simpanan.Text = rd.Item("id_simpanan")
            smpn.value = rd.Item("saldo")
        End If

        smpn.Tag = Me.Tag
        rd.Close()

        smpn.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        refreshData()
    End Sub
End Class