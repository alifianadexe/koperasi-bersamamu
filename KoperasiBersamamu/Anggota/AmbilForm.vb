Imports System.Drawing.Printing
Public Class AmbilForm

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
                    printLoad()

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

    Private Sub printLoad()
        Dim pd As New PrintDocument
        AddHandler pd.PrintPage, AddressOf Me.print_page
        PrintPreviewDialog1.Document = pd
        If PrintPreviewDialog1.ShowDialog = DialogResult.OK Then
            pd.Print()
        End If
    End Sub

    Private Sub print_page(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim gp As Graphics = ev.Graphics
        Dim fn As New Font("Consolas", 12)

        Dim offset As Integer = 40
        Dim x As Integer = 10
        Dim y As Integer = 30
        Dim fontHeight As Integer = fn.Height

        'header
        Dim img As Image = My.Resources.logo
        gp.DrawImage(img, 10, 10)
        gp.DrawString("             KOPERASI ADEXE          ", New Font("Consolas", 20), New SolidBrush(Color.Black), x + img.Width, y)
        gp.DrawString("                Milik Kita Bersama        ", New Font("Consolas", 16), New SolidBrush(Color.Black), x + img.Width, y + 30)
        offset += fontHeight + 20
        gp.DrawString("             Bukti Pengambilan Anggota        ", New Font("Consolas", 16), New SolidBrush(Color.Black), x + img.Width, y + offset)
        offset += fontHeight
        gp.DrawString("----------------------------------------------------------------", New Font("Consolas", 16), New SolidBrush(Color.Black), x, y + offset)
        offset += fontHeight + 10
        'end header

        Dim sql As String = "SELECT nama,tbl_simpanan.id_simpanan as [id_simpanan], tbl_det_simpanan.id_det_simpanan as [id_det_pinjaman], saldo, jenis_simpanan, tanggal_transaksi, jumlah_ambil, total FROM ((tbl_simpanan INNER JOIN tbl_anggota ON tbl_simpanan.id_anggota = tbl_anggota.id_anggota) INNER JOIN tbl_det_simpanan ON tbl_det_simpanan.id_simpanan = tbl_simpanan.id_simpanan )INNER JOIN tbl_jenis_simpanan ON tbl_jenis_simpanan.id_jenis_simpanan = tbl_det_simpanan.id_jenis_simpanan WHERE tbl_simpanan.id_simpanan = '" + Me.lbl_simpanan.Text + "' ORDER BY id_det_simpanan DESC"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then

            Dim namaa As String = rd.Item("nama")
            Dim nama As String = ("Nama Peminjam     : " + namaa).ToString.PadRight(30)

            Dim id As String = ("ID Simpanan       : " + rd.Item("id_simpanan")).ToString.PadRight(50)
            Dim id_trans As String = ("ID Transaksi      : " + rd.Item("id_det_pinjaman")).ToString.PadRight(40)
            Dim tanggal As String = ("Tanggal Transaksi : " + rd.Item("tanggal_transaksi")).ToString.PadRight(50)
            Dim jenis_simpanan As String = ("Jenis Simpanan    : " + rd.Item("jenis_simpanan")).ToString.PadRight(50)
            Dim jumlah As String = ("Jumlah Ambil      : " + Format(rd.Item("jumlah_ambil"), "Rp ##,##0.00")).ToString.PadRight(50)
            Dim saldo As String = ("Saldo             : " + Format(rd.Item("saldo"), "Rp ##,##0.00")).ToString.PadRight(50)

            gp.DrawString(id + id_trans, fn, New SolidBrush(Color.Black), x, y + offset)
            offset += fontHeight + 10
            gp.DrawString(nama, fn, New SolidBrush(Color.Black), x, y + offset)
            offset += fontHeight + 10
            gp.DrawString(jenis_simpanan + tanggal, fn, New SolidBrush(Color.Black), x, y + offset)
            offset += fontHeight + 10
            gp.DrawString(jumlah, fn, New SolidBrush(Color.Black), x, y + offset)
            offset += fontHeight + 10
            gp.DrawString(saldo, fn, New SolidBrush(Color.Black), x, y + offset + 40)
            offset += fontHeight + 10

            ' footer '
            gp.DrawString(("Semarang," + FormatDateTime(Date.Now, DateFormat.GeneralDate)).ToString.PadLeft(75), fn, New SolidBrush(Color.Black), x, y + offset + 60)
            offset += fontHeight + 120
            gp.DrawString("Petugas".PadLeft(25), fn, New SolidBrush(Color.Black), x, y + offset)
            gp.DrawString(namaa.PadLeft(70), fn, New SolidBrush(Color.Black), x, y + offset)
            offset += fontHeight + 10
            gp.DrawString("----------------------------------------------------------------", New Font("Consolas", 16), New SolidBrush(Color.Black), x, y + offset + 40)
            offset += fontHeight + 10

        End If
        rd.Close()

    End Sub

End Class