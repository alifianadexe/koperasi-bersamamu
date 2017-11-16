Public Class DaftarAnggota

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub DaftarAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=locahost,1433;Network Library=DBMSSOCN;Initial Catalog=db_hotel;user id=alifianadexe;password=adexe123"
        conn.Open()

        Me.txt_id.Text = generateID("id_anggota", conn)


    End Sub


End Class