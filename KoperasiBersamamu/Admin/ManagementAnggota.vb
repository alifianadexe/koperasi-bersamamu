Public Class ManagementAnggota
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub ManagementAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
        refreshDataCom()
    End Sub

    Private Sub refreshData()
        Dim sql_active As String = "SELECT id_anggota,nama, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat FROM tbl_anggota WHERE is_active = 1"
        Dim adapter_active As New SqlClient.SqlDataAdapter(sql_active, conn)
        Dim dt_1 As New DataTable

        adapter_active.Fill(dt_1)
        data_grid.DataSource = dt_1

        Dim sql_non_active As String = "SELECT id_anggota,nama, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat FROM tbl_anggota WHERE is_active = 0"
        Dim adapter_non_active As New SqlClient.SqlDataAdapter(sql_non_active, conn)
        Dim dt_2 As New DataTable

        adapter_non_active.Fill(dt_2)
        data_grid_non.DataSource = dt_2
    End Sub

    Private Sub refreshDataCom()
        Dim sql As String = "SELECT * FROM tbl_jabatan"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        Me.txt_jabatan.DataSource = dt
        Me.txt_jabatan.DisplayMember = "nama_jabatan"
        Me.txt_jabatan.ValueMember = "id_jabatan"

    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)

        Me.txt_alamat.Enabled = bool
        Me.txt_jenis_kel.Enabled = bool
        Me.txt_jenis_kel_2.Enabled = bool
        Me.txt_nama.Enabled = bool
        Me.txt_password.Enabled = bool
        Me.txt_tanggal_lahir.Enabled = bool
        Me.txt_tempat_lahir.Enabled = bool
        Me.txt_username.Enabled = bool


    End Sub

    Private Sub is_clear()

        Me.txt_id.Clear()
        Me.txt_alamat.Clear()
        Me.txt_nama.Clear()
        Me.txt_password.Clear()
        Me.txt_tempat_lahir.Clear()
        Me.txt_username.Clear()

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        is_clear()
        Me.txt_id.Text = generateID("id_anggota", conn)
        is_enabled(True)
    End Sub

    Private Sub btn_ins_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If Me.btn_insert.Text = "Insert" Then
            Dim jenis As String = ""
            Try
                If cekEmptyBox(Me.txt_alamat, Me.txt_nama, Me.txt_password, Me.txt_username, Me.txt_tempat_lahir) Then
                    If cekUsername(Me.txt_username.Text, conn) Then
                        Dim sql As String = "INSERT INTO tbl_anggota (id_anggota,id_jabatan,username,password,nama,jenis_kelamin,tempat_lahir,tanggal_lahir,alamat,is_active) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10)"
                        Using cmnd As New SqlClient.SqlCommand(sql, conn)
                            cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                            cmnd.Parameters.AddWithValue("@v2", Me.txt_jabatan.SelectedValue)
                            cmnd.Parameters.AddWithValue("@v3", Me.txt_username.Text)
                            cmnd.Parameters.AddWithValue("@v4", Me.txt_password.Text)

                            If Me.txt_jenis_kel.Checked Then
                                jenis = "Laki - Laki"
                            Else
                                jenis = "Perempuan"
                            End If

                            cmnd.Parameters.AddWithValue("@v5", Me.txt_nama.Text)
                            cmnd.Parameters.AddWithValue("@v6", jenis)
                            cmnd.Parameters.AddWithValue("@v7", Me.txt_tempat_lahir.Text)
                            cmnd.Parameters.AddWithValue("@v8", Me.txt_tanggal_lahir.Value)
                            cmnd.Parameters.AddWithValue("@v9", Me.txt_alamat.Text)
                            cmnd.Parameters.AddWithValue("@v10", 0)

                            If MessageBox.Show("Apakah anda ingin menginsert data tersebut?", "Will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                cmnd.ExecuteNonQuery()
                                MessageBox.Show("Selamat anda berhasil di insert", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End Using

                    Else
                        MessageBox.Show("Username Sudah Ada", "Hmm", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf Me.btn_insert.Text = "Update" Then
            Dim jenis As String = ""
            Try
                If cekEmptyBox(Me.txt_alamat, Me.txt_nama, Me.txt_password, Me.txt_username, Me.txt_tempat_lahir) Then
                    Dim sql As String = "UPDATE tbl_anggota SET id_jabatan = @v2,username = @v3, password = @v4, nama = @v5, jenis_kelamin = @v6, tempat_lahir = @v7, tanggal_lahir = @v8, alamat = @v9 WHERE id_anggota = @v1"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)

                            cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                            cmnd.Parameters.AddWithValue("@v2", Me.txt_jabatan.SelectedValue)
                            cmnd.Parameters.AddWithValue("@v3", Me.txt_username.Text)
                            cmnd.Parameters.AddWithValue("@v4", Me.txt_password.Text)

                            If Me.txt_jenis_kel.Checked Then
                                jenis = "Laki - Laki"
                            Else
                                jenis = "Perempuan"
                            End If

                            cmnd.Parameters.AddWithValue("@v5", Me.txt_nama.Text)
                            cmnd.Parameters.AddWithValue("@v6", jenis)
                            cmnd.Parameters.AddWithValue("@v7", Me.txt_tempat_lahir.Text)
                            cmnd.Parameters.AddWithValue("@v8", Me.txt_tanggal_lahir.Value)
                            cmnd.Parameters.AddWithValue("@v9", Me.txt_alamat.Text)
                            cmnd.Parameters.AddWithValue("@v10", 0)

                            If MessageBox.Show("Apakah Data ingin Diupdate?", "Will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                cmnd.ExecuteNonQuery()
                                MessageBox.Show("Selamat anda berhasil mengupdate data tersebut", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End Using


                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
        is_enabled(False)
        Me.btn_insert.Text = "Insert"
        refreshData()
        refreshDataCom()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        is_enabled(True)
        btn_insert.Text = "Update"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not Me.txt_id.Text = "" Then
            Dim sql As String = "DELETE FROM tbl_anggota WHERE id_anggota = '" + Me.txt_id.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            If MessageBox.Show("Apakah Data diri anda Sudah benar, dan mensetujui persyaratan yang berlaku?", "Will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmnd.ExecuteNonQuery()
                MessageBox.Show("Selamat anda berhasil terdaftar, Tolong konfirmasi di petugas", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        refreshData()
    End Sub

    Private Sub btn_conf_Click(sender As Object, e As EventArgs) Handles btn_conf.Click
        If Not Me.txt_id.Text = "" Then
            If MessageBox.Show("Update data tersebut?", "Will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = "UPDATE tbl_anggota SET is_accept = 1 WHERE id_anggota = '" + Me.txt_id.Text + "'"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                cmnd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Update", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            Me.txt_id.Text = data_grid.Rows(e.RowIndex).Cells(0).Value
            Dim sql As String = "SELECT * FROM tbl_anggota WHERE id_anggota = '" + Me.txt_id.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            Dim jabatan As String = ""

            If rd.HasRows Then

                Me.txt_alamat.Text = rd.Item("alamat")
                Me.txt_nama.Text = rd.Item("nama")
                Me.txt_password.Text = rd.Item("password")
                Me.txt_tanggal_lahir.Value = rd.Item("tanggal_lahir")
                Me.txt_tempat_lahir.Text = rd.Item("tempat_lahir")
                Me.txt_username.Text = rd.Item("username")

                If rd.Item("jenis_kelamin") = "Laki  -Laki" Then
                    Me.txt_jenis_kel.Checked = True
                Else
                    Me.txt_jenis_kel_2.Checked = True
                End If

                Me.txt_jabatan.SelectedValue = rd.Item("id_jabatan")

            End If
            rd.Close()
        End If
    End Sub

    Private Sub data_grid_non_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid_non.CellClick
        If e.RowIndex >= 0 Then
            Me.txt_id.Text = data_grid_non.Rows(e.RowIndex).Cells(0).Value
            Dim sql As String = "SELECT * FROM tbl_anggota WHERE id_anggota = '" + Me.txt_id.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            Dim jabatan As String = ""

            If rd.HasRows Then

                Me.txt_alamat.Text = rd.Item("alamat")
                Me.txt_nama.Text = rd.Item("nama")
                Me.txt_password.Text = rd.Item("password")
                Me.txt_tanggal_lahir.Value = rd.Item("tanggal_lahir")
                Me.txt_tempat_lahir.Text = rd.Item("tempat_lahir")
                Me.txt_username.Text = rd.Item("username")

                If rd.Item("jenis_kelamin") = "Laki  -Laki" Then
                    Me.txt_jenis_kel.Checked = True
                Else
                    Me.txt_jenis_kel_2.Checked = True
                End If

                Me.txt_jabatan.SelectedValue = rd.Item("id_jabatan")

            End If
            rd.Close()
        End If
    End Sub
End Class