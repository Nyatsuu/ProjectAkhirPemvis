Imports MySql.Data.MySqlClient

Public Class tambah

    ' Event handler untuk tombol Tambah Data
    Private Sub tambah_data_Click(sender As Object, e As EventArgs) Handles tambah_data.Click

        ' Kumpulkan data dari form
        Dim namaBarang As String = tbtambah.Text
        Dim tanggalMasuk As Date = tbtgl.Value
        Dim kategori As String = If(tgKategori.SelectedItem IsNot Nothing, tgKategori.SelectedItem.ToString(), String.Empty)
        Dim harga As Decimal ' Mengubah tipe data harga menjadi Decimal
        Dim kondisi As String = If(baru.Checked, "Baru", If(bekas.Checked, "Bekas", String.Empty))

        ' Validasi input
        If String.IsNullOrWhiteSpace(namaBarang) Then
            MessageBox.Show("Nama Barang tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(kategori) Then
            MessageBox.Show("Kategori tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(tbharga.Text) Then
            MessageBox.Show("Harga tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Decimal.TryParse(tbharga.Text, harga) Then ' Parsing harga ke Decimal
            MessageBox.Show("Harga harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If harga < 0 Then ' Cek apakah harga negatif
            MessageBox.Show("Harga tidak boleh negatif.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(kondisi) Then
            MessageBox.Show("Silakan pilih kondisi barang (Baru atau Bekas).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Tampilkan dialog konfirmasi sebelum menyimpan
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menyimpan data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            ' Panggil fungsi untuk menyimpan data ke database
            SimpanDataKeDatabase(namaBarang, tanggalMasuk, kategori, harga, kondisi)
            ResetFormFields()
        Else
            MessageBox.Show("Penyimpanan data dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Fungsi untuk menyimpan data ke database
    Public Sub SimpanDataKeDatabase(namaBarang As String, tanggalMasuk As Date, kategori As String, harga As Decimal, kondisi As String) ' Mengubah tipe data harga menjadi Decimal
        ' Inisialisasi koneksi ke database
        Dim connectionString As String = "server=localhost;userid=root;password=;database=dbprojekpa"
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim query As String = "INSERT INTO tbtambah (nama_barang, tanggal_masuk, kategori, harga, kondisi) VALUES (@nama_barang, @tanggal_masuk, @kategori, @harga, @kondisi)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama_barang", namaBarang)
                cmd.Parameters.AddWithValue("@tanggal_masuk", tanggalMasuk)
                cmd.Parameters.AddWithValue("@kategori", kategori)
                cmd.Parameters.AddWithValue("@harga", harga)
                cmd.Parameters.AddWithValue("@kondisi", kondisi)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ResetFormFields()
        ' Membersihkan semua field input setelah operasi insert atau update
        tbtambah.Text = ""
        tbtgl.Value = DateTime.Now
        tgKategori.SelectedIndex = -1
        tbharga.Text = ""

        For Each radioButton As RadioButton In gbkondisi.Controls.OfType(Of RadioButton)()
            radioButton.Checked = False
        Next

    End Sub
End Class
