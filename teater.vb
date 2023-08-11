Imports System.Data.Odbc
Public Class teater
    Sub bawaan()
        ButtonTambah.Enabled = True
        ButtonTambah.Text = "TAMBAH"
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonBatal.Enabled = False

        TextBoxTeater.Enabled = False
        TextBoxTeater.Text = ""
        NumericUpDownJumlah.Enabled = False
        NumericUpDownJumlah.Value = 1
    End Sub
    Sub tambah()
        ButtonTambah.Enabled = True
        ButtonTambah.Text = "SIMPAN"
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonBatal.Enabled = True

        TextBoxTeater.Enabled = False
        NumericUpDownJumlah.Enabled = True
    End Sub
    Sub tampilbutton()
        ButtonTambah.Enabled = False
        ButtonTambah.Text = "TAMBAH"
        ButtonUbah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonBatal.Enabled = True

        TextBoxTeater.Enabled = True
        NumericUpDownJumlah.Enabled = True
    End Sub
    Sub auto()
        koneksi()
        Dim hitung As String
        Dim urut As String
        cmd = New OdbcCommand("select * from teater where id_teater in (select max(id_teater) from teater)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "TEATER" + "1"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 1) + 1
            urut = "TEATER" + Microsoft.VisualBasic.Right(hitung, 1)
        End If
        TextBoxTeater.Text = urut
    End Sub
    Sub tampil()
        koneksi()
        da = New OdbcDataAdapter("select * from teater", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "teater")
        DataGridView1.DataSource = (ds.Tables("teater"))
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub simpan()
        Dim simpandata As String
        If TextBoxTeater.Text IsNot "" And NumericUpDownJumlah.Value > 0 Then
            simpandata = "insert into teater values('" & TextBoxTeater.Text & "','" & CInt(NumericUpDownJumlah.Value) & "')"
            cmd = New OdbcCommand(simpandata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Menyimpan Data")
            bawaan()
            tampil()
        Else
            MsgBox("Pastikan semuanya terisi")
        End If
    End Sub
    Sub ubah()
        Dim ubahdata As String
        If TextBoxTeater.Text IsNot "" And NumericUpDownJumlah.Value > 0 Then
            ubahdata = "update teater set jumlah_kursi='" & NumericUpDownJumlah.Value & "'where id_teater='" & TextBoxTeater.Text & "'"
            cmd = New OdbcCommand(ubahdata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Menyimpan Data")
            bawaan()
            tampil()
        Else
            MsgBox("Pastikan semuanya terisi")
        End If
    End Sub
    Sub hapus()
        Dim hapusdata As String
        hapusdata = "delete from teater where id_teater='" & TextBoxTeater.Text & "';"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menghapus Data")
        bawaan()
        tampil()
    End Sub
    Private Sub teater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        tampil()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBoxTeater = DataGridView1(0, i).Value
        NumericUpDownJumlah.Value = DataGridView1(1, i).Value
        tampilbutton()
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
End Class