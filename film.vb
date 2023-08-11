Imports System.Data.Odbc
Public Class film
    Dim currentTime As DateTime = DateTime.Now
    Dim localTime As DateTime = TimeZoneInfo.ConvertTime(currentTime, TimeZoneInfo.Local)
    Dim id As String
    Dim kursi As String
    Sub bawaan()
        TextBoxNama.Text = ""
        ComboBoxTeater.Text = ""
        TextBoxHarga.Text = ""
        DateTimePickerTayang.Value = localTime

        TextBoxNama.Enabled = False
        ComboBoxTeater.Enabled = False
        TextBoxHarga.Enabled = False
        DateTimePickerTayang.Enabled = False

        ButtonTambah.Text = "TAMBAH"
        ButtonTambah.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonBatal.Enabled = False
        ButtonKembali.Enabled = True
    End Sub
    Sub idauto()
        koneksi()
        Dim hitung As String
        Dim urut As String
        cmd = New OdbcCommand("select * from film where id_film in (select max(id_film) from film)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "FILM" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urut = "FILM" + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        id = urut
    End Sub
    Sub relasi()
        koneksi()
        ComboBoxTeater.Items.Clear()
        cmd = New OdbcCommand("select * from teater", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBoxTeater.Items.Add(dr!id_teater)
        Loop
    End Sub
    Private Sub ComboBoxTeater_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTeater.SelectedIndexChanged
        cmd = New OdbcCommand("select * from teater where id_teater='" & ComboBoxTeater.SelectedItem & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            kursi = dr!jumlah_kursi
        End If
    End Sub
    Sub tambah()
        TextBoxNama.Enabled = True
        ComboBoxTeater.Enabled = True
        TextBoxHarga.Enabled = True
        DateTimePickerTayang.Enabled = True

        ButtonTambah.Text = "SIMPAN"
        ButtonTambah.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonBatal.Enabled = True
        ButtonKembali.Enabled = False
    End Sub
    Sub tampilbutton()
        TextBoxNama.Enabled = True
        ComboBoxTeater.Enabled = True
        TextBoxHarga.Enabled = True
        DateTimePickerTayang.Enabled = True

        ButtonTambah.Text = "TAMBAH"
        ButtonTambah.Enabled = False
        ButtonUbah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonBatal.Enabled = True
        ButtonKembali.Enabled = False
    End Sub
    Sub tampildgv()
        da = New OdbcDataAdapter("select * from film", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "film")
        DataGridView1.DataSource = (ds.Tables("film"))
        DataGridView1.Columns(0).HeaderText = "ID Film"
        DataGridView1.Columns(1).HeaderText = "Nama Film"
        DataGridView1.Columns(2).HeaderText = "Teater"
        DataGridView1.Columns(3).HeaderText = "Jumlah Tiket"
        DataGridView1.Columns(4).HeaderText = "Harga Tiket"
        DataGridView1.Columns(5).HeaderText = "Tanggal Tayang"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Sub simpan()
        Dim simpandata As String
        Dim nilaiDateTimePicker As DateTime = DateTimePickerTayang.Value
        Dim formatNilai As String = nilaiDateTimePicker.ToString("yyyy/MM/dd HH:mm:ss")
        If TextBoxNama.Text IsNot "" And ComboBoxTeater.SelectedItem IsNot "" And TextBoxHarga.Text IsNot "" Then
            simpandata = "insert into film values('" & id & "','" & TextBoxNama.Text & "','" & ComboBoxTeater.SelectedItem & "','" & kursi & "','" & TextBoxHarga.Text & "','" & formatNilai & "')"
            cmd = New OdbcCommand(simpandata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Menyimpan Data")
            bawaan()
            tampildgv()
        Else
            MsgBox("Pastikan semuanya terisi")
        End If
    End Sub
    Sub ubah()
        Dim ubahdata As String
        Dim nilaiDateTimePicker As DateTime = DateTimePickerTayang.Value
        Dim formatNilai As String = nilaiDateTimePicker.ToString("yyyy/MM/dd HH:mm:ss")
        If TextBoxNama.Text IsNot "" And ComboBoxTeater.SelectedItem IsNot "" And TextBoxHarga.Text IsNot "" Then
            ubahdata = "update film set nama='" & TextBoxNama.Text & "', teater='" & ComboBoxTeater.SelectedItem & "',jumlah_kursi='" & kursi & "',harga='" & TextBoxHarga.Text & "',tanggal_tayang='" & formatNilai & "'where id_film='" & id & "'"
            cmd = New OdbcCommand(ubahdata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Mengubah Data")
            bawaan()
            tampildgv()
        Else
            MsgBox("Pastikan semuanya terisi")
        End If
    End Sub
    Sub hapus()
        Dim hapusdata As String
        hapusdata = "delete from film where id_film'" & id & "';"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menghapus Data")
        bawaan()
        tampildgv()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Dim tanggal As DateTime = CType(DataGridView1(5, i).Value, DateTime)
        id = DataGridView1(0, i).Value
        TextBoxNama.Text = DataGridView1(1, i).Value
        ComboBoxTeater.Text = DataGridView1(2, i).Value
        kursi = DataGridView1(3, i).Value
        TextBoxHarga.Text = DataGridView1(4, i).Value
        DateTimePickerTayang.Value = tanggal
        tampilbutton()
    End Sub
    Private Sub film_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        relasi()
        bawaan()
        tampildgv()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ButtonTambah.Text = "TAMBAH" Then
            tambah()
            idauto()
        ElseIf ButtonTambah.Text = "SIMPAN" Then
            simpan()
        End If
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
    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Me.Close()
    End Sub
End Class