Public Class Login
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim id As String = ""

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cekEmptyBox(Me.txt_password, Me.txt_username) Then
            Dim sql As String = "SELECT * FROM tbl_anggota WHERE username = '" + Me.txt_username.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            Dim id_jabatan As String = ""

            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                Dim password As String = rd.Item("password")
                If password = Me.txt_password.Text Then
                    id = rd.Item("id_anggota")
                    id_jabatan = rd.Item("id_jabatan")
                End If
            End If
            rd.Close()

            cekLoginPriority(id_jabatan)
        End If
    End Sub

    Private Sub cekLoginPriority(ByVal id_jabatan As String)
        If Not id_jabatan = "" Then
            Dim sql As String = "SELECT * FROM tbl_jabatan WHERE id_jabatan = '" + id_jabatan + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                Select Case rd.Item("nama_jabatan")
                    Case "Anggota"
                        Dim nav As New NavigationAnggota
                        nav.Tag = id
                        nav.Show()
                        Me.Hide()
                    Case "Petugas"
                        Dim nav As New NavigationPetugas
                        nav.Tag = id
                        nav.Show()
                        Me.Hide()
                    Case "Admin"
                        Dim nav As New NavigationAdmin
                        nav.Tag = id
                        nav.Show()
                        Me.Hide()
                End Select
            End If

            rd.Close()
        End If
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub
End Class