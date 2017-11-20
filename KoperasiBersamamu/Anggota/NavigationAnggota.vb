Public Class NavigationAnggota
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub NavigationAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=localhost,1433;Network Library=DBMSSOCN;Initial Catalog=db_koperasi;user id=alifianadexe;password=adexe123"
        conn.Open()

        Dim sql As String = "SELECT id_anggota, nama_jabatan, nama, tanggal_lahir, tempat_lahir,  jenis_kelamin FROM tbl_anggota INNER JOIN tbl_jabatan ON tbl_jabatan.id_jabatan = tbl_anggota.id_jabatan WHERE id_anggota = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            Me.lbl_id.Text = Me.Tag
            Me.lbl_jabatan.Text = rd.Item("nama_jabatan")
            Me.lbl_jenis.Text = rd.Item("jenis_kelamin")
            Me.lbl_nama.Text = rd.Item("nama")
            Me.lbl_ttl.Text = rd.Item("tempat_lahir") + "," + rd.Item("tanggal_lahir")
        End If
        rd.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SimpananAnggota.Tag = Me.Tag
        SimpananAnggota.Show()
    End Sub

    Private Sub NavigationAnggota_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PeminjamanAnggota.Tag = Me.Tag
        PeminjamanAnggota.Show()

    End Sub
End Class