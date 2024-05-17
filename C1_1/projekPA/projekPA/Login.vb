Imports MySql.Data.MySqlClient

Public Class login

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "admin" AndAlso txtPass.Text = "admin" Then
            MessageBox.Show("LOGIN ADMIN BERHASIL", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
            Me.Close()
        Else
            LoginUser()

        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tambahkan inisialisasi jika diperlukan
        Me.ControlBox = False
        koneksi() ' Panggil koneksi saat form load
    End Sub

  


    Private Sub LoginUser()
        Try
            Dim query As String = "SELECT COUNT(1) FROM tbuser WHERE username=@username AND password=@password"
            Using cmd As New MySqlCommand(query, CONN)
                cmd.Parameters.AddWithValue("@username", txtUser.Text)
                cmd.Parameters.AddWithValue("@password", txtPass.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count = 1 Then
                    MessageBox.Show("LOGIN USER BERHASIL", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormUser.Show()
                    Me.Close()

                Else
                    MessageBox.Show("Username atau password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPass.Clear()
                    txtUser.Clear()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        register.Show()
        Me.Close()
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
