Imports MySql.Data.MySqlClient

Public Class lihat
    Private Sub lihat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Memanggil fungsi untuk menampilkan data ketika form load
        TampilkanData()
    End Sub

    Public Sub TampilkanData()
        ' Mengambil data dari database dan menampilkannya di DataGridView
        Try
            koneksi() ' Memanggil fungsi koneksi dari module
            Dim query As String = "SELECT * FROM tbtambah"
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Menampilkan ID yang dipilih ke dalam txtCari
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtCari.Text = row.Cells("id").Value.ToString() ' Pastikan nama kolom adalah "id"
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtCari.Text = "" Then
            MessageBox.Show("Pilih data yang akan diubah terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ubahForm As New ubah()
        ubahForm.txtID.Text = txtCari.Text ' Mengisi txtID di form ubah dengan nilai dari txtCari

        ' Mengambil data dari database untuk mengisi form ubah
        Try
            koneksi() ' Memanggil fungsi koneksi dari module
            Dim query As String = "SELECT * FROM tbtambah WHERE id = @id"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@id", txtCari.Text)
            RD = CMD.ExecuteReader()
            If RD.Read() Then
                ubahForm.tbtambah.Text = RD("nama_barang").ToString()
                ubahForm.tgKategori.Text = RD("kategori").ToString()
                ubahForm.tbtgl.Value = DateTime.Parse(RD("tanggal_masuk").ToString())
                If RD("kondisi").ToString() = "Baru" Then
                    ubahForm.baru.Checked = True
                Else
                    ubahForm.bekas.Checked = True
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try

        ubahForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim id As String = txtCari.Text
        If String.IsNullOrEmpty(id) Then
            MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                koneksi() ' Memanggil fungsi koneksi dari module
                Dim query As String = "DELETE FROM tbtambah WHERE id = @id"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@id", id)
                Dim rowsAffected As Integer = CMD.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TampilkanData() ' Refresh data di DataGridView
                Else
                    MessageBox.Show("Data tidak ditemukan atau tidak berhasil dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CONN.Close()
            End Try
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text <> "" Then
            Try
                koneksi()
                Dim query As String = "SELECT * FROM tbtambah WHERE id LIKE @id"
                DA = New MySqlDataAdapter(query, CONN)
                DA.SelectCommand.Parameters.AddWithValue("@id", "%" & txtCari.Text & "%")
                DS = New DataSet()
                DA.Fill(DS, "tbtambah")

                DataGridView1.DataSource = DS.Tables("tbtambah")
                CONN.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            TampilkanData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub
End Class
