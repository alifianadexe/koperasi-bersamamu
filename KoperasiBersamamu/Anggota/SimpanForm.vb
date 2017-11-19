Public Class SimpanForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub SimpanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshDataCom()

    End Sub

    Private Sub refreshDataCom()
        Dim sql As String = "SELECT  * FROM tbl_jenis_simpanan"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        Me.txt_jenis_tabung.DataSource = dt
        Me.txt_jenis_tabung.DisplayMember = "jenis_simpanan"
        Me.txt_jenis_tabung.ValueMember = "id_jenis_simpanan"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Me.txt_jumlah.Text = "" Then
            If MessageBox.Show("Apakah anda ingin Menyimpan uang anda dengan jumlah Berikut ?", "will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = "INSERT INTO tbl_det_simpanan (id_det_simpanan, id_simpanan, id_jenis_simpanan, tanggal_transaksi ,jumlah_simpan, jumlah_ambil) VALUES (@v1,@v2,@v3,@v4)"
                Using cmnd As New SqlClient.SqlCommand(sql, conn)
                    cmnd.Parameters.AddWithValue("@v1", generateID("id_det_simpanan", conn))
                    cmnd.Parameters.AddWithValue("@v2", Me.lbl_simpanan.Text)
                    cmnd.Parameters.AddWithValue("@v3", Me.txt_jenis_tabung.Text)
                    cmnd.Parameters.AddWithValue("@v4", Date.Now)
                    cmnd.Parameters.AddWithValue("@v5", Me.txt_jumlah.Text)
                    cmnd.Parameters.AddWithValue("@v6", 0)
                    cmnd.ExecuteNonQuery()

                    updateSaldo(Me.txt_jumlah.Text)

                End Using

            End If
        End If
    End Sub

    Private Sub updateSaldo(ByVal value As Integer)
        Dim sql As String = "UPDATE tbl_simpanan SET saldo = " + value + " WHERE id_simpanan = '" + Me.lbl_simpanan.Text + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        cmnd.ExecuteNonQuery()
    End Sub

    Private Sub txt_jumlah_TextChanged(sender As Object, e As EventArgs) Handles txt_jumlah.TextChanged
        Try
            Me.lbl_jumlah.Text = "Rp." + Format(Val(Me.txt_jumlah.Text), "##,##0.00")
        Catch ex As Exception
            Me.lbl_jumlah.Text = "Jumlah Tidak Dikenali"
        End Try
    End Sub
End Class