Imports System.Data.Odbc
Public Class login
    Sub bawaan()
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If TextBoxUsername.Text IsNot "" And TextBoxPassword.Text IsNot "" Then
            koneksi()
            cmd = New OdbcCommand("select * from admin where username='" & TextBoxUsername.Text & "' and password='" & TextBoxPassword.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                home.LoginToolStripMenuItem.Enabled = False
                home.DaftarToolStripMenuItem.Enabled = False
                home.SosialToolStripMenuItem.Enabled = True
                home.StaffToolStripMenuItem.Enabled = True
                home.TransaksiToolStripMenuItem.Enabled = True
                home.LogoutToolStripMenuItem.Enabled = True
                MsgBox("Berhasil Login, Selamat Datang " & dr!nama & " :) ")
                Me.Close()
            Else
                MsgBox("Tidak ditemukan data admin")
                bawaan()
            End If
        Else
            MsgBox("Pastikan semua terisi")

        End If
        
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class