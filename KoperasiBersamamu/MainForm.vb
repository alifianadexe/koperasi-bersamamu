Imports System.Drawing.Printing
Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DaftarAnggota.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        printLoad()
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

        Dim img As Image = My.Resources.logo
        gp.DrawImage(img, 10, 10)
        gp.DrawString("             KOPERASI ADEXE          ", New Font("Consolas", 20), New SolidBrush(Color.Black), x + img.Width, y)
        offset += fontHeight
        gp.DrawString("                Milik Kita Bersama        ", New Font("Consolas", 16), New SolidBrush(Color.Black), x + img.Width, y + offset)
        offset += fontHeight
        gp.DrawString("----------------------------------------------------------------", New Font("Consolas", 16), New SolidBrush(Color.Black), x, y + offset)
        offset += fontHeight + 10


    End Sub

End Class