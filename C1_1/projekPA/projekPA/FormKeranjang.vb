Imports MySql.Data.MySqlClient

Public Class FormKeranjang
    Private Sub FormKeranjang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        TampilkanData()
        HitungTotalHarga()
    End Sub

    Private Sub TampilkanData()
        Try
            koneksi()
            Dim query As String = "SELECT id_pembelian, nama_barang, jumlah, harga FROM tbkeranjang"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "tbkeranjang")
            DataGridView1.DataSource = DS.Tables("tbkeranjang")
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub HitungTotalHarga()
        Try
            Dim totalHarga As Decimal = 0

            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim jumlah As Integer = Convert.ToInt32(row.Cells("jumlah").Value)
                Dim harga As Decimal = Convert.ToDecimal(row.Cells("harga").Value)
                totalHarga += jumlah * harga
            Next

            tbtotal.Text = totalHarga.ToString("N0")
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus baris yang dipilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                HapusBaris()
                HitungTotalHarga()
            End If
        Else
            MessageBox.Show("Silakan pilih baris yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub HapusBaris()
        Try
            koneksi()
            Dim selectedId As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id_pembelian").Value)
            Dim query As String = "DELETE FROM tbkeranjang WHERE id_pembelian = @id_pembelian"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@id_pembelian", selectedId)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Baris berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilkanData()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub btnco_Click(sender As Object, e As EventArgs) Handles btnco.Click
        If tbtotal.Text > 0 Then
            If String.IsNullOrEmpty(tbnama.Text) OrElse String.IsNullOrEmpty(tbtelepon.Text) OrElse String.IsNullOrEmpty(tbemail.Text) OrElse String.IsNullOrEmpty(tbalamat.Text) Then
                MessageBox.Show("Silakan lengkapi data diri terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not IsNumeric(tbtelepon.Text) Then
                MessageBox.Show("Nomor telepon harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not IsValidEmail(tbemail.Text) Then
                MessageBox.Show("Format email tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim formInvoice As New FormInvoice()
            formInvoice.BarangDibeli = DS.Tables("tbkeranjang")
            formInvoice.NamaPembeli = tbnama.Text
            formInvoice.Telepon = tbtelepon.Text
            formInvoice.Email = tbemail.Text
            formInvoice.Alamat = tbalamat.Text
            formInvoice.ShowDialog()

            Me.Hide()
        Else
            MessageBox.Show("Keranjang belanja kosong. Tambahkan barang terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim mailAddress As New System.Net.Mail.MailAddress(email)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FormUser.Show()
    End Sub

End Class
