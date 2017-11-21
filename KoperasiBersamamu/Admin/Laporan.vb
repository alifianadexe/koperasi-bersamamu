Imports excel = Microsoft.Office.Interop.Excel

Public Class Laporan

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader


    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Close()
    End Sub

    Private Sub btn_anggota_Click(sender As Object, e As EventArgs) Handles btn_anggota.Click

        Dim xlApp As excel.Application
        Dim xlBook As excel.Workbook
        Dim xlWorks As excel.Worksheet


        xlApp = CreateObject("excel.Application")
        xlBook = xlApp.Workbooks.Add(Type.Missing)
        xlWorks = xlBook.Worksheets(1)

        Dim sql As String = "SELECT id_anggota, nama, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat FROM tbl_anggota WHERE is_active = 1 AND id_jabatan = 'JBT001'"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim ds As New DataSet

        adapter.Fill(ds)

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            For j As Integer = 0 To ds.Tables(0).Columns.Count - 1
                xlWorks.Cells(i + 1, j + 1) = ds.Tables(0).Rows(i).Item(j)
            Next
        Next

        Dim range As excel.Range = xlWorks.Range("E1", "E5")
        range.NumberFormat = "dd/mm/yyy"


        xlWorks.SaveAs("C:\Users\AdexeAmih\Documents\LaporanExcel\LaporanAnggota.xlsx")
        xlBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlBook)
        releaseObject(xlWorks)


        MessageBox.Show("Its Work!")

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub


End Class