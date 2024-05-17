Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing.Printing

Public Class FormInvoice
    Public Property BarangDibeli As DataTable
    Public Property NamaPembeli As String
    Public Property Telepon As String
    Public Property Email As String
    Public Property Alamat As String

    Private Sub FormInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        IsiInformasiBarang()
        IsiDataDiri()
        HitungTotalHarga()
    End Sub

    Private Sub IsiInformasiBarang()
        Dim barangString As String = ""

        For Each row As DataRow In BarangDibeli.Rows
            barangString += row("nama_barang").ToString() & " (" & row("jumlah").ToString() & "x), "
        Next

        lblBarangDibeli.Text = barangString.TrimEnd(", ")
    End Sub

    Private Sub IsiDataDiri()
        lblNamaPembeli.Text = NamaPembeli
        lblTelepon.Text = Telepon
        lblEmail.Text = Email
        lblAlamat.Text = Alamat
    End Sub

    Private Sub HitungTotalHarga()
        Dim totalHarga As Decimal = 0

        For Each row As DataRow In BarangDibeli.Rows
            Dim jumlah As Integer = Convert.ToInt32(row("jumlah"))
            Dim harga As Decimal = Convert.ToDecimal(row("harga"))
            totalHarga += jumlah * harga
        Next

        lblTotalHarga.Text = totalHarga.ToString("N0")
    End Sub

    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim fontJudul As New Font("Arial", 24, FontStyle.Bold)
        Dim fontSubJudul As New Font("Arial", 14, FontStyle.Bold)
        Dim fontNormal As New Font("Arial", 12)

        Dim judul As String = "INVOICE"
        Dim judulSize As SizeF = e.Graphics.MeasureString(judul, fontJudul)
        Dim judulX As Single = (e.PageBounds.Width - judulSize.Width) / 2
        Dim judulY As Single = 50
        e.Graphics.DrawString(judul, fontJudul, Brushes.Black, judulX, judulY)

        Dim pembeliY As Single = judulY + judulSize.Height + 40
        e.Graphics.DrawString("Nama Pembeli:", fontSubJudul, Brushes.Black, 50, pembeliY)
        e.Graphics.DrawString(NamaPembeli, fontNormal, Brushes.Black, 200, pembeliY)
        e.Graphics.DrawString("Telepon:", fontSubJudul, Brushes.Black, 50, pembeliY + 30)
        e.Graphics.DrawString(Telepon, fontNormal, Brushes.Black, 200, pembeliY + 30)
        e.Graphics.DrawString("Email:", fontSubJudul, Brushes.Black, 50, pembeliY + 60)
        e.Graphics.DrawString(Email, fontNormal, Brushes.Black, 200, pembeliY + 60)
        e.Graphics.DrawString("Alamat:", fontSubJudul, Brushes.Black, 50, pembeliY + 90)
        e.Graphics.DrawString(Alamat, fontNormal, Brushes.Black, 200, pembeliY + 90)

        Dim garisPembeliY As Single = pembeliY + 140
        e.Graphics.DrawLine(New Pen(Color.Black, 2), 50, garisPembeliY, e.PageBounds.Width - 50, garisPembeliY)


        Dim logo As Image = My.Resources.logo
        Dim Rect As New Rectangle(e.PageBounds.Width - 150, 50, 100, 100)
        e.Graphics.DrawImage(logo, Rect)

        Dim barangY As Single = garisPembeliY + 20
        e.Graphics.DrawString("Barang Dibeli:", fontSubJudul, Brushes.Black, 50, barangY)
        e.Graphics.DrawString(lblBarangDibeli.Text, fontNormal, Brushes.Black, 50, barangY + 30)

        Dim garisBarangY As Single = barangY + 100
        e.Graphics.DrawLine(New Pen(Color.Black, 2), 50, garisBarangY, e.PageBounds.Width - 50, garisBarangY)

        Dim totalHargaY As Single = garisBarangY + 20
        e.Graphics.DrawString("Total Harga:", fontSubJudul, Brushes.Black, 50, totalHargaY)
        e.Graphics.DrawString(lblTotalHarga.Text, fontNormal, Brushes.Black, 50, totalHargaY + 30)

        Dim garisHargaY As Single = totalHargaY + 70
        e.Graphics.DrawLine(New Pen(Color.Black, 2), 50, garisHargaY, e.PageBounds.Width - 50, garisHargaY)

        Dim tanggal As String = "Tanggal: " & DateTime.Now.ToShortDateString()
        Dim tanggalSize As SizeF = e.Graphics.MeasureString(tanggal, fontNormal)
        Dim tanggalX As Single = e.PageBounds.Width - tanggalSize.Width - 50
        e.Graphics.DrawString(tanggal, fontNormal, Brushes.Black, tanggalX, totalHargaY)

        Dim rects As New Rectangle(e.PageBounds.Left + 20, e.PageBounds.Top + 20, e.PageBounds.Width - 40, e.PageBounds.Height - 40)
        Dim dashedPen As New Pen(Color.Black, 2)
        dashedPen.DashStyle = Drawing2D.DashStyle.Solid
        e.Graphics.DrawRectangle(dashedPen, rects)
    End Sub

    Private Sub CetakInvoice()
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintPage
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
            HapusIsiKeranjang()
            FormUser.Show()
        End If
    End Sub

    Private Sub HapusIsiKeranjang()
        Try
            koneksi()
            Dim query As String = "DELETE FROM tbkeranjang"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Isi keranjang berhasil dihapus setelah mencetak invoice.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub PreviewInvoice()
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintPage
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        CetakInvoice()
    End Sub

    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        PreviewInvoice()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        FormUser.Show()
    End Sub

    Private Sub btncetak_Click_1(sender As Object, e As EventArgs) Handles btncetak.Click

    End Sub


End Class
