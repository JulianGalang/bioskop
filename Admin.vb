Imports System.Data.Odbc
Public Class Admin
    Dim id As String
    Sub bawaan()
        ButtonTambah.Enabled = True
        ButtonTambah.Text = "TAMBAH"
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonBatal.Enabled = False
        ButtonKembali.Enabled = True

        TextBoxNama.Enabled = False
        TextBoxTelepon.Enabled = False
        RichTextBoxAlamat.Enabled = False
        TextBoxUsername.Enabled = False
        TextBoxPassword.Enabled = False
        TextBoxPassword.Visible = True

        TextBoxNama.Text = ""
        TextBoxTelepon.Text = ""
        RichTextBoxAlamat.Text = ""
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
    End Sub
    Sub tambah()
        ButtonTambah.Enabled = True
        ButtonTambah.Text = "SIMPAN"
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonBatal.Enabled = True
        ButtonKembali.Enabled = False

        TextBoxNama.Enabled = True
        TextBoxTelepon.Enabled = True
        RichTextBoxAlamat.Enabled = True
        TextBoxUsername.Enabled = True
        TextBoxPassword.Enabled = True
    End Sub
    Sub tampilbutton()
        ButtonTambah.Enabled = False
        ButtonTambah.Text = "TAMBAH"
        ButtonUbah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonBatal.Enabled = True
        ButtonKembali.Enabled = False

        TextBoxNama.Enabled = True
        TextBoxTelepon.Enabled = True
        RichTextBoxAlamat.Enabled = True
        TextBoxUsername.Enabled = True
        TextBoxPassword.Enabled = True
    End Sub
    Sub tampil()
        koneksi()
        da = New OdbcDataAdapter("select id_admin,nama,telepon,alamat,username from admin", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "admin")
        DataGridView1.DataSource = (ds.Tables("admin"))
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub auto()
        koneksi()
        Dim hitung As String
        Dim urut As String
        cmd = New OdbcCommand("select * from admin where id_admin in (select max(id_admin) from admin)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "ADM" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urut = "ADM" + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        id = urut
    End Sub
    Sub simpan()
        Dim simpandata As String
        Dim hitung As String
        hitung = "select count(*) from admin where username='" & TextBoxUsername.Text & "'"
        cmd = New OdbcCommand(hitung, conn)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If count > 0 Then
            MsgBox("Username telah digunakan")
        Else
            If TextBoxNama.Text IsNot "" And TextBoxTelepon.Text IsNot "" And RichTextBoxAlamat.Text IsNot "" And TextBoxUsername.Text IsNot "" And TextBoxPassword.Text IsNot "" Then
                simpandata = "insert into admin values('" & id & "','" & TextBoxNama.Text & "','" & TextBoxTelepon.Text & "','" & RichTextBoxAlamat.Text & "','" & TextBoxUsername.Text & "','" & TextBoxPassword.Text & "')"
                cmd = New OdbcCommand(simpandata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil Menyimpan Data")
                bawaan()
                tampil()
            Else
                MsgBox("Pastikan semuanya terisi")
            End If
        End If
        
    End Sub
    Sub ubah()
        Dim ubahdata As String
        If TextBoxNama.Text IsNot "" And TextBoxTelepon.Text IsNot "" And RichTextBoxAlamat.Text IsNot "" And TextBoxUsername.Text IsNot "" Then
            ubahdata = "update admin set nama='" & TextBoxNama.Text & "',telepon='" & TextBoxTelepon.Text & "',alamat='" & RichTextBoxAlamat.Text & "',username='" & TextBoxUsername.Text & "'where id_admin='" & id & "'"
            cmd = New OdbcCommand(ubahdata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Mengubah Data")
            bawaan()
            tampil()
        Else
            MsgBox("Pastikan semuanya terisi")
        End If

    End Sub
    Sub hapus()
        Dim hapusdata As String
        hapusdata = "delete from admin where id_admin='" & id & "';"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menghapus Data")
        bawaan()
        tampil()
    End Sub
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        tampil()
    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Me.Close()
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        bawaan()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        hapus()
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        ubah()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ButtonTambah.Text = "TAMBAH" Then
            tambah()
            auto()
        ElseIf ButtonTambah.Text = "SIMPAN" Then
            simpan()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1(0, i).Value
        TextBoxNama.Text = DataGridView1(1, i).Value
        TextBoxTelepon.Text = DataGridView1(2, i).Value
        RichTextBoxAlamat.Text = DataGridView1(3, i).Value
        TextBoxUsername.Text = DataGridView1(4, i).Value
        tampilbutton()
    End Sub

    Private Sub TextBoxNama_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNama.TextChanged

    End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged
        cmd = New OdbcCommand("select * from admin where username='" & TextBoxUsername.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBoxPassword.Text = dr!password
        End If
    End Sub
End Class