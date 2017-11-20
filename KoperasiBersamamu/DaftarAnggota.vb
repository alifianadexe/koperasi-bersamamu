Public Class DaftarAnggota

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub DaftarAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=localhost,1433;Network Library=DBMSSOCN;Initial Catalog=db_koperasi;user id=alifianadexe;password=adexe123"
        conn.Open()

        Me.txt_id.Text = generateID("id_anggota", conn)
        is_enabled(True)
    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)

        Me.txt_alamat.Enabled = bool
        Me.txt_jenis_kel.Enabled = bool
        Me.txt_jenis_kel_2.Enabled = bool
        Me.txt_nama.Enabled = bool
        Me.txt_password.Enabled = bool
        Me.txt_re_password.Enabled = bool
        Me.txt_tanggal_lahir.Enabled = bool
        Me.txt_tempat_lahir.Enabled = bool
        Me.txt_username.Enabled = bool

    End Sub

    Private Sub is_clear()

        Me.txt_id.Clear()
        Me.txt_alamat.Clear()
        Me.txt_nama.Clear()
        Me.txt_password.Clear()
        Me.txt_re_password.Clear()
        Me.txt_tempat_lahir.Clear()
        Me.txt_username.Clear()

    End Sub

    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        Dim jenis As String = ""
        Try
            If cekEmptyBox(Me.txt_alamat, Me.txt_nama, Me.txt_password, Me.txt_re_password, Me.txt_username, Me.txt_tempat_lahir) Then
                If cekUsername(Me.txt_username.Text, conn) Then
                    If Me.txt_re_password.Text = Me.txt_password.Text Then
                        Dim sql As String = "INSERT INTO tbl_anggota (id_anggota,id_jabatan,username,password,nama,jenis_kelamin,tempat_lahir,tanggal_lahir,alamat,is_active) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10)"
                        Using cmnd As New SqlClient.SqlCommand(sql, conn)
                            cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                            cmnd.Parameters.AddWithValue("@v2", "JBT001")
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



                            If MessageBox.Show("Apakah Data diri anda Sudah benar, dan mensetujui persyaratan yang berlaku?", "Will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                cmnd.ExecuteNonQuery()
                                MessageBox.Show("Selamat anda berhasil terdaftar, Tolong konfirmasi di petugas", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Me.Close()
                            End If
                        End Using
                    Else
                        MessageBox.Show("Maaf Password Tidak Cocok", "Hmm", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Username Sudah Ada", "Hmm", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class