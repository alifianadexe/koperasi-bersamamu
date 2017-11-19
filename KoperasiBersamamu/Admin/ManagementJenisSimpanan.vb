Public Class ManagementJenisSimpanan
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Private Sub ManagementJenisSimpanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshDataCom()
    End Sub

    Private Sub refreshDataCom()
        Dim sql As String = "SELECT * FROM tbl_jenis_simpanan"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        Me.txt_jenis.DataSource = dt
        Me.txt_jenis.ValueMember = "id_jenis_simpanan"
        Me.txt_jenis.DisplayMember = "jenis_simpanan"

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        is_clear()
        Me.txt_id.Text = generateID("id_jenis_simpanan", conn)
        is_enabled(True)
    End Sub

    Private Sub is_clear()
        Me.txt_id.Text = ""
        Me.txt_bunga.Text = ""
        Me.txt_nama.Text = ""
    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)

        Me.txt_bunga.Enabled = bool
        Me.txt_nama.Enabled = bool
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If Me.btn_insert.Text = "Insert" Then
            Dim jenis As String = ""
            Try
                If cekEmptyBox(Me.txt_nama, Me.txt_id, Me.txt_bunga) Then
                    Dim sql As String = "INSERT INTO tbl_jenis_simpanan (id_jenis_simpanan, jenis_simpanan, bunga) VALUES (@v1,@v2,@v3)"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_bunga.Text)

                        If MessageBox.Show("Apakah anda ingin menginsert data tersebut?", "Will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Selamat anda berhasil di insert", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf Me.btn_insert.Text = "Update" Then
            Dim jenis As String = ""
            Try
                If cekEmptyBox(Me.txt_nama, Me.txt_id, Me.txt_bunga) Then
                    Dim sql As String = "UPDATE tbl_jenis_simpanan SET  jenis_simpanan = @v2, bunga = @v3 WHERE id_jenis_simpanan = @v1"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_bunga.Text)

                        If MessageBox.Show("Apakah anda ingin menginsert data tersebut?", "Will you", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Selamat anda berhasil di insert", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
        is_enabled(False)
        Me.btn_insert.Text = "Insert"
        refreshDataCom()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        is_enabled(True)
        Me.btn_insert.Text = "Update"
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not Me.txt_id.Text = "" Then
            Dim sql As String = "DELETE FROM tbl_jenis_simpanan WHERE id_jenis_simpanan = '" + Me.txt_id.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            cmnd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Di Delete", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        refreshDataCom()
    End Sub

    Private Sub txt_jenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_jenis.SelectedIndexChanged
        Try
            Dim sql As String = "SELECT * FROM tbl_jenis_simpanan WHERE id_jenis_simpanan = '" + Me.txt_jenis.SelectedValue + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                Me.txt_bunga.Text = rd.Item("bunga")
                Me.txt_nama.Text = rd.Item("jenis_simpanan")
                Me.txt_id.Text = rd.Item("id_jenis_simpanan")

            End If
            rd.Close()
        Catch ex As Exception

        End Try

    End Sub
End Class