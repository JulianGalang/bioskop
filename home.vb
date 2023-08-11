Public Class home

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
    End Sub

    Private Sub DaftarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarToolStripMenuItem.Click
        Admin.Show()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Anda Telah Logout!")
        bawaan()
    End Sub

    Private Sub TeaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeaterToolStripMenuItem.Click
        teater.Show()
    End Sub

    Private Sub FilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmToolStripMenuItem.Click
        film.ShowDialog()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
    End Sub
    Sub bawaan()
        LoginToolStripMenuItem.Enabled = True
        DaftarToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        StaffToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        transaksi.ShowDialog()
    End Sub
End Class
