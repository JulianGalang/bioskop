<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownTiket = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonKembali = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelHarga = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxNama = New System.Windows.Forms.ListBox()
        Me.ComboBoxTanggal = New System.Windows.Forms.ComboBox()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.LabelHars = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nama Film"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 26)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Transaksi"
        '
        'NumericUpDownTiket
        '
        Me.NumericUpDownTiket.Location = New System.Drawing.Point(210, 117)
        Me.NumericUpDownTiket.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumericUpDownTiket.Name = "NumericUpDownTiket"
        Me.NumericUpDownTiket.Size = New System.Drawing.Size(289, 20)
        Me.NumericUpDownTiket.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 26)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Jumlah Tiket"
        '
        'ButtonKembali
        '
        Me.ButtonKembali.BackColor = System.Drawing.Color.DimGray
        Me.ButtonKembali.FlatAppearance.BorderSize = 0
        Me.ButtonKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonKembali.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKembali.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonKembali.Location = New System.Drawing.Point(457, 168)
        Me.ButtonKembali.Name = "ButtonKembali"
        Me.ButtonKembali.Size = New System.Drawing.Size(107, 45)
        Me.ButtonKembali.TabIndex = 28
        Me.ButtonKembali.Text = "KEMBALI"
        Me.ButtonKembali.UseVisualStyleBackColor = False
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.DimGray
        Me.ButtonBatal.FlatAppearance.BorderSize = 0
        Me.ButtonBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBatal.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBatal.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonBatal.Location = New System.Drawing.Point(310, 168)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(107, 45)
        Me.ButtonBatal.TabIndex = 27
        Me.ButtonBatal.Text = "BATAL"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackColor = System.Drawing.Color.DimGray
        Me.ButtonTambah.FlatAppearance.BorderSize = 0
        Me.ButtonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTambah.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonTambah.Location = New System.Drawing.Point(5, 168)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(107, 45)
        Me.ButtonTambah.TabIndex = 24
        Me.ButtonTambah.Text = "TAMBAH"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 219)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(559, 105)
        Me.DataGridView1.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 26)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Harga Tiket"
        '
        'LabelHarga
        '
        Me.LabelHarga.AutoSize = True
        Me.LabelHarga.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHarga.Location = New System.Drawing.Point(205, 139)
        Me.LabelHarga.Name = "LabelHarga"
        Me.LabelHarga.Size = New System.Drawing.Size(124, 26)
        Me.LabelHarga.TabIndex = 31
        Me.LabelHarga.Text = "Harga Tiket"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 26)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Tanggal Tayang"
        '
        'ListBoxNama
        '
        Me.ListBoxNama.FormattingEnabled = True
        Me.ListBoxNama.Location = New System.Drawing.Point(210, 54)
        Me.ListBoxNama.Name = "ListBoxNama"
        Me.ListBoxNama.Size = New System.Drawing.Size(289, 30)
        Me.ListBoxNama.TabIndex = 34
        '
        'ComboBoxTanggal
        '
        Me.ComboBoxTanggal.FormattingEnabled = True
        Me.ComboBoxTanggal.Location = New System.Drawing.Point(210, 90)
        Me.ComboBoxTanggal.Name = "ComboBoxTanggal"
        Me.ComboBoxTanggal.Size = New System.Drawing.Size(287, 21)
        Me.ComboBoxTanggal.TabIndex = 36
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.DimGray
        Me.ButtonSimpan.FlatAppearance.BorderSize = 0
        Me.ButtonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSimpan.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonSimpan.Location = New System.Drawing.Point(158, 168)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(107, 45)
        Me.ButtonSimpan.TabIndex = 37
        Me.ButtonSimpan.Text = "SIMPAN"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'LabelHars
        '
        Me.LabelHars.AutoSize = True
        Me.LabelHars.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHars.Location = New System.Drawing.Point(12, 9)
        Me.LabelHars.Name = "LabelHars"
        Me.LabelHars.Size = New System.Drawing.Size(0, 26)
        Me.LabelHars.TabIndex = 38
        Me.LabelHars.Visible = False
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(570, 327)
        Me.Controls.Add(Me.LabelHars)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.ComboBoxTanggal)
        Me.Controls.Add(Me.ListBoxNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelHarga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonKembali)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDownTiket)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "transaksi"
        Me.Text = "Transaksi Tiket"
        CType(Me.NumericUpDownTiket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownTiket As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonKembali As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelHarga As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBoxNama As System.Windows.Forms.ListBox
    Friend WithEvents ComboBoxTanggal As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents LabelHars As System.Windows.Forms.Label
End Class
