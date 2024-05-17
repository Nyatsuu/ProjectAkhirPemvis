Imports MySql.Data.MySqlClient

Public Class ubah

    Private Sub ubah_data_Click(sender As Object, e As EventArgs) Handles ubah_data.Click
        Try
            ' Validasi input
            If Not IsValidInput() Then
                Return
            End If

            ' Inisialisasi koneksi
            koneksi()

            Dim query As String = "UPDATE tbtambah SET nama_barang = @nama_barang, kategori = @kategori, harga = @harga, tanggal_masuk = @tanggal_masuk, kondisi = @kondisi WHERE id = @id"

            ' Inisialisasi perintah SQL
            Using CMD As New MySqlCommand(query, CONN)
                ' Set parameter
                CMD.Parameters.AddWithValue("@id", txtID.Text)
                CMD.Parameters.AddWithValue("@nama_barang", tbtambah.Text)
                CMD.Parameters.AddWithValue("@kategori", tgKategori.Text)
                CMD.Parameters.AddWithValue("@harga", tbharga.Text)
                CMD.Parameters.AddWithValue("@tanggal_masuk", tbtgl.Value)
                CMD.Parameters.AddWithValue("@kondisi", If(baru.Checked, "Baru", "Bekas"))
                ' Eksekusi perintah SQL
                CMD.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Tutup form saat berhasil diupdate
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi
            CONN.Close()
        End Try
    End Sub

    Private Sub lihat_Click(sender As Object, e As EventArgs) Handles lihat.Click
        ' Mengembalikan ke form lihat
        Me.Close()
    End Sub

    Private Function IsValidInput() As Boolean
        ' Validasi input
        If String.IsNullOrWhiteSpace(txtID.Text) OrElse String.IsNullOrWhiteSpace(tbtambah.Text) OrElse String.IsNullOrWhiteSpace(tgKategori.Text) OrElse String.IsNullOrWhiteSpace(tbharga.Text) Then
            MessageBox.Show("Harap isi semua inputan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(tbharga.Text, harga) Then
            MessageBox.Show("Harga harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If harga < 0 Then
            MessageBox.Show("Harga tidak boleh negatif.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function
End Class
