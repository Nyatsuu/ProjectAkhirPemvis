Imports MySql.Data.MySqlClient

Public Class register
    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi() ' Panggil fungsi koneksi saat form dimuat
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Dim username As String = txtUser.Text.Trim()
        Dim password As String = txtPass.Text.Trim()

        If username <> "" AndAlso password <> "" Then
            Try
                ' Buat koneksi ke database
                Using conn As MySqlConnection = Module1.CONN ' Gunakan koneksi dari Module1
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    ' Periksa apakah username sudah ada
                    If IsUsernameExists(username, conn) Then
                        MessageBox.Show("Username sudah digunakan. Silakan gunakan username lain.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        ' Jika username belum ada, tambahkan user baru
                        Dim query As String = "INSERT INTO tbuser (username, password) VALUES (@username, @password)"

                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@username", username)
                            cmd.Parameters.AddWithValue("@password", password)
                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Registrasi berhasil. Silakan login dengan username dan password baru.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                login.Show()
                                Me.Close()
                            Else
                                MessageBox.Show("Gagal melakukan registrasi. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Silakan isi username dan password.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function IsUsernameExists(username As String, conn As MySqlConnection) As Boolean
        ' Query untuk memeriksa apakah username sudah ada di database
        Dim query As String = "SELECT COUNT(*) FROM tbuser WHERE username = @username"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        login.Show()
    End Sub
End Class
