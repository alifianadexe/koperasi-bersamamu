﻿Public Class AmbilForm

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Public value As Integer

    Private Sub AmbilFormLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshDataCom()

    End Sub

    Private Sub refreshDataCom()
        Dim sql As String = "SELECT  * FROM tbl_jenis_simpanan"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Me.txt_jumlah.Text = "" Then

            If MessageBox.Show("Apakah anda ingin Mengambil uang anda dengan jumlah Berikut ?", "will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = "INSERT INTO tbl_det_simpanan (id_det_simpanan, id_simpanan, id_jenis_simpanan, tanggal_transaksi ,jumlah_simpan, jumlah_ambil, total) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7)"
                Using cmnd As New SqlClient.SqlCommand(sql, conn)

                    cmnd.Parameters.AddWithValue("@v1", generateID("id_det_simpanan", conn))
                    cmnd.Parameters.AddWithValue("@v2", Me.lbl_simpanan.Text)
                    cmnd.Parameters.AddWithValue("@v3", "JNS010")
                    cmnd.Parameters.AddWithValue("@v4", Date.Now)
                    cmnd.Parameters.AddWithValue("@v5", 0)
                    cmnd.Parameters.AddWithValue("@v6", Me.txt_jumlah.Text)

                    value = Integer.Parse(value - Val(Me.txt_jumlah.Text))

                    cmnd.Parameters.AddWithValue("@v7", value)

                    cmnd.ExecuteNonQuery()

                    updateSaldo(value)

                    MessageBox.Show("Selamat Anda Berhasil Menyimpan Uang Anda", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                End Using

            End If

        End If
    End Sub

    Private Sub updateSaldo(ByVal value As String)
        Dim sql As String = "UPDATE tbl_simpanan SET saldo = " + Str(value) + " WHERE id_simpanan = '" + Me.lbl_simpanan.Text + "'"
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