Imports System.Data.Odbc
Public Class transaksi
    Dim id As String
    Dim tanggaltayang As DateTime
    Dim tanggalsekarang As DateTime = DateTime.Now
    Sub auto()
        koneksi()
        Dim hitung As String
        Dim urut As String
        cmd = New OdbcCommand("select * from transaksi where id_transaksi in (select max(id_transaksi) from transaksi)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "TRS" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 4) + 1
            urut = "TRS" + Microsoft.VisualBasic.Right("0000" + hitung, 4)
        End If
        id = urut
    End Sub
    Sub bawaan()
        ListBoxNama.ClearSelected()
        ComboBoxTanggal.Items.Clear()
        ComboBoxTanggal.Text = ""
        LabelHarga.Text = 0
        NumericUpDownTiket.Value = 0
        LabelHars.Text = ""
        NumericUpDownTiket.Maximum = 0
        ListBoxNama.Enabled = False
        NumericUpDownTiket.Enabled = False
        ButtonTambah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = False
        ButtonKembali.Enabled = True
    End Sub
    Sub tambah()
        ListBoxNama.Enabled = True
        ComboBoxTanggal.Enabled = False
        NumericUpDownTiket.Enabled = True
        ButtonTambah.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True
        ButtonKembali.Enabled = False
        relasi()
    End Sub
    Sub tampildgv()
        koneksi()
        da = New OdbcDataAdapter("select * from transaksi", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "transaksi")
        DataGridView1.DataSource = (ds.Tables("transaksi"))
        DataGridView1.Columns(0).HeaderText = "ID Transaksi"
        DataGridView1.Columns(1).HeaderText = "Nama Film"
        DataGridView1.Columns(2).HeaderText = "Jumlah Tiket"
        DataGridView1.Columns(3).HeaderText = "Harga Tiket"
        DataGridView1.Columns(4).HeaderText = "Tanggal Nonton"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub relasi()
        koneksi()
        Dim dt As New DataTable()
        cmd = New OdbcCommand("SELECT DISTINCT * FROM film ", conn)
        dr = cmd.ExecuteReader
        ListBoxNama.Items.Clear()
        While dr.Read
            Dim tikett As Integer
            tikett = dr!jumlah_kursi
            tanggaltayang = dr!tanggal_tayang
            Dim data As String = dr.GetString(1)
            If Not ListBoxNama.Items.Contains(data) Then
                If tanggaltayang >= tanggalsekarang Then
                    If tikett > 0 Then
                        ListBoxNama.Items.Add(data)
                    End If
                End If
            End If
        End While
    End Sub
    Sub simpan()
        koneksi()
        Dim simpandata As String
        Dim caritiket As String
        Dim kurangin As String
        Dim tanggal As String
        Dim tiket As Integer = NumericUpDownTiket.Value
        tanggal = Format(ComboBoxTanggal.SelectedItem, "yyyy-MM-dd hh:mm:ss")
        If tiket = 0 Then
            MsgBox("Nilai Tidak boleh 0")
        Else
            caritiket = "select * from film where tanggal_tayang >='" & ComboBoxTanggal.SelectedItem & "'and nama='" & ListBoxNama.SelectedItem & "'"
            cmd = New OdbcCommand(caritiket, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            kurangin = "update film set jumlah_kursi='" & CInt(dr!jumlah_kursi) - CInt(NumericUpDownTiket.Value) & "'where tanggal_tayang >='" & ComboBoxTanggal.SelectedItem & "'and nama='" & ListBoxNama.SelectedItem & "'"
            cmd = New OdbcCommand(kurangin, conn)
            cmd.ExecuteNonQuery()

            simpandata = "insert into transaksi values('" & id & "','" & ListBoxNama.SelectedItem & "','" & NumericUpDownTiket.Value & "','" & LabelHarga.Text & "','" & tanggal & "')"
            cmd = New OdbcCommand(simpandata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Menyimpan Data")
            tampildgv()
            bawaan()
        End If
    End Sub
    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        relasi()
        tampildgv()
    End Sub
    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Me.Close()
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        bawaan()
    End Sub
    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        tambah()
        auto()
    End Sub

    Private Sub ListBoxNama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNama.SelectedIndexChanged
        ComboBoxTanggal.Text = ""
        ComboBoxTanggal.Items.Clear()
        LabelHarga.Text = 0
        NumericUpDownTiket.Value = 0
        cmd = New OdbcCommand("select * from film where tanggal_tayang >='" & tanggalsekarang & "'and nama='" & ListBoxNama.SelectedItem & "' and jumlah_kursi > 0", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            tanggaltayang = dr!tanggal_tayang
            Dim tikett As Integer = dr!jumlah_kursi
            If tanggaltayang >= tanggalsekarang And tikett > 0 Then
                ComboBoxTanggal.Items.Add(dr!tanggal_tayang)
                ComboBoxTanggal.Enabled = True
            End If
        End While
    End Sub

    Private Sub ComboBoxTanggal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTanggal.SelectedIndexChanged
        cmd = New OdbcCommand("select * from film where tanggal_tayang >='" & ComboBoxTanggal.SelectedItem & "'and nama='" & ListBoxNama.SelectedItem & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            NumericUpDownTiket.Maximum = dr!jumlah_kursi
            LabelHars.Text = CInt(dr!harga)
        End If
        NumericUpDownTiket.Value = 0
    End Sub

    Private Sub NumericUpDownTiket_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownTiket.ValueChanged
        If NumericUpDownTiket.Value = 1 Then
            LabelHarga.Text = LabelHars.Text
        Else
            LabelHarga.Text = Val(NumericUpDownTiket.Value) * Val(LabelHars.Text)
        End If
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        simpan()
    End Sub
End Class