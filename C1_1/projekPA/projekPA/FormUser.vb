Imports MySql.Data.MySqlClient

Public Class FormUser
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        TampilkanData()
        IsiComboBoxNamaBarang()
    End Sub

    ' Fungsi untuk menampilkan data pada DataGridView
    Private Sub TampilkanData()
        Try
            koneksi()
            Dim query As String = "SELECT id, nama_barang, harga, kondisi FROM tbtambah"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "tbtambah")
            DataGridView1.DataSource = DS.Tables("tbtambah")
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
    End Sub

    ' Fungsi untuk mengisi ComboBox dengan nama barang dari database
    Private Sub IsiComboBoxNamaBarang()
        Try
            koneksi()
            Dim query As String = "SELECT nama_barang FROM tbtambah"
            CMD = New MySqlCommand(query, CONN)
            RD = CMD.ExecuteReader()
            While RD.Read()
                cbnama.Items.Add(RD("nama_barang").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
    End Sub

    ' Event handler untuk tombol chart
    Private Sub btnchart_Click(sender As Object, e As EventArgs) Handles btnchart.Click
        If cbnama.SelectedItem Is Nothing Then
            MessageBox.Show("Silakan pilih barang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim namaBarang As String = cbnama.SelectedItem.ToString()
        Dim jumlah As Integer
        If Not Integer.TryParse(tbjumlah.Text, jumlah) OrElse jumlah <= 0 Then
            MessageBox.Show("Jumlah harus berupa angka positif.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        TambahKeKeranjang(namaBarang, jumlah)

        ' Setel ulang nilai input
        cbnama.SelectedIndex = -1
        tbjumlah.Text = ""
    End Sub

    ' Fungsi untuk menambahkan barang ke tabel tbkeranjang
    Private Sub TambahKeKeranjang(namaBarang As String, jumlah As Integer)
        Try
            koneksi()
            ' Mengambil harga barang dari tbtambah
            Dim hargaQuery As String = "SELECT harga FROM tbtambah WHERE nama_barang = @nama_barang"
            CMD = New MySqlCommand(hargaQuery, CONN)
            CMD.Parameters.AddWithValue("@nama_barang", namaBarang)
            Dim harga As Decimal = Convert.ToDecimal(CMD.ExecuteScalar())

            ' Menambahkan ke tbkeranjang
            Dim insertQuery As String = "INSERT INTO tbkeranjang (nama_barang, jumlah, harga) VALUES (@nama_barang, @jumlah, @harga)"
            CMD = New MySqlCommand(insertQuery, CONN)
            CMD.Parameters.AddWithValue("@nama_barang", namaBarang)
            CMD.Parameters.AddWithValue("@jumlah", jumlah)
            CMD.Parameters.AddWithValue("@harga", harga)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Barang berhasil ditambahkan ke keranjang.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormKeranjang.Show()

        ' Setel ulang nilai input
        cbnama.SelectedIndex = -1
        tbjumlah.Text = ""
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        ' Tampilkan pesan konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika pengguna memilih "Yes"
        If result = DialogResult.Yes Then
            ' Hapus isi keranjang
            HapusIsiKeranjang()

            ' Pindahkan pengguna ke form login
            login.Show()
            Me.Hide()

            ' Setel ulang nilai input
            cbnama.SelectedIndex = -1
            tbjumlah.Text = ""
        End If
    End Sub

    Private Sub HapusIsiKeranjang()
        Try
            koneksi()
            Dim query As String = "DELETE FROM tbkeranjang"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Isi keranjang berhasil dihapus setelah logout.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
    End Sub
End Class
