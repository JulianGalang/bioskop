<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class film
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonKembali = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerTayang = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxTeater = New System.Windows.Forms.ComboBox()
        Me.TextBoxHarga = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 26)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Tanggal Tayang"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 272)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(559, 109)
        Me.DataGridView1.TabIndex = 29
        '
        'ButtonKembali
        '
        Me.ButtonKembali.BackColor = System.Drawing.Color.DimGray
        Me.ButtonKembali.FlatAppearance.BorderSize = 0
        Me.ButtonKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonKembali.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKembali.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonKembali.Location = New System.Drawing.Point(480, 221)
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
        Me.ButtonBatal.Location = New System.Drawing.Point(367, 221)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(107, 45)
        Me.ButtonBatal.TabIndex = 27
        Me.ButtonBatal.Text = "BATAL"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.DimGray
        Me.ButtonHapus.FlatAppearance.BorderSize = 0
        Me.ButtonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHapus.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonHapus.Location = New System.Drawing.Point(254, 221)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(107, 45)
        Me.ButtonHapus.TabIndex = 26
        Me.ButtonHapus.Text = "HAPUS"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonUbah
        '
        Me.ButtonUbah.BackColor = System.Drawing.Color.DimGray
        Me.ButtonUbah.FlatAppearance.BorderSize = 0
        Me.ButtonUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUbah.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUbah.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonUbah.Location = New System.Drawing.Point(141, 221)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(107, 45)
        Me.ButtonUbah.TabIndex = 25
        Me.ButtonUbah.Text = "UBAH"
        Me.ButtonUbah.UseVisualStyleBackColor = False
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackColor = System.Drawing.Color.DimGray
        Me.ButtonTambah.FlatAppearance.BorderSize = 0
        Me.ButtonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTambah.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonTambah.Location = New System.Drawing.Point(28, 221)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(107, 45)
        Me.ButtonTambah.TabIndex = 24
        Me.ButtonTambah.Text = "TAMBAH"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(244, 50)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(317, 20)
        Me.TextBoxNama.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 26)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Harga Tiket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 26)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Teater"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 26)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama Film"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 33)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Daftar Fillm"
        '
        'DateTimePickerTayang
        '
        Me.DateTimePickerTayang.CustomFormat = "dddd    , dd MM yyyy     HH:mm:ss"
        Me.DateTimePickerTayang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTayang.Location = New System.Drawing.Point(244, 161)
        Me.DateTimePickerTayang.Name = "DateTimePickerTayang"
        Me.DateTimePickerTayang.Size = New System.Drawing.Size(317, 20)
        Me.DateTimePickerTayang.TabIndex = 31
        '
        'ComboBoxTeater
        '
        Me.ComboBoxTeater.FormattingEnabled = True
        Me.ComboBoxTeater.Location = New System.Drawing.Point(244, 86)
        Me.ComboBoxTeater.Name = "ComboBoxTeater"
        Me.ComboBoxTeater.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxTeater.TabIndex = 32
        '
        'TextBoxHarga
        '
        Me.TextBoxHarga.Location = New System.Drawing.Point(244, 125)
        Me.TextBoxHarga.Name = "TextBoxHarga"
        Me.TextBoxHarga.Size = New System.Drawing.Size(317, 20)
        Me.TextBoxHarga.TabIndex = 33
        '
        'film
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(612, 394)
        Me.Controls.Add(Me.TextBoxHarga)
        Me.Controls.Add(Me.ComboBoxTeater)
        Me.Controls.Add(Me.DateTimePickerTayang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonKembali)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "film"
        Me.Text = "Daftar Film"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonKembali As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTayang As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxTeater As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxHarga As System.Windows.Forms.TextBox
End Class
