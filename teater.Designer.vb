<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teater
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
        Me.TextBoxTeater = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownJumlah = New System.Windows.Forms.NumericUpDown()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.NumericUpDownJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxTeater
        '
        Me.TextBoxTeater.Location = New System.Drawing.Point(161, 47)
        Me.TextBoxTeater.Name = "TextBoxTeater"
        Me.TextBoxTeater.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxTeater.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tambah Teater"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nomor Teater"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Jumlah Kursi"
        '
        'NumericUpDownJumlah
        '
        Me.NumericUpDownJumlah.Location = New System.Drawing.Point(161, 87)
        Me.NumericUpDownJumlah.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownJumlah.Name = "NumericUpDownJumlah"
        Me.NumericUpDownJumlah.Size = New System.Drawing.Size(240, 20)
        Me.NumericUpDownJumlah.TabIndex = 9
        Me.NumericUpDownJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.DimGray
        Me.ButtonBatal.FlatAppearance.BorderSize = 0
        Me.ButtonBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBatal.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBatal.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonBatal.Location = New System.Drawing.Point(307, 113)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(94, 34)
        Me.ButtonBatal.TabIndex = 15
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
        Me.ButtonHapus.Location = New System.Drawing.Point(212, 113)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(89, 34)
        Me.ButtonHapus.TabIndex = 14
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
        Me.ButtonUbah.Location = New System.Drawing.Point(119, 113)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(87, 34)
        Me.ButtonUbah.TabIndex = 13
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
        Me.ButtonTambah.Location = New System.Drawing.Point(17, 113)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(96, 34)
        Me.ButtonTambah.TabIndex = 12
        Me.ButtonTambah.Text = "TAMBAH"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(415, 72)
        Me.DataGridView1.TabIndex = 17
        '
        'teater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(427, 228)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.NumericUpDownJumlah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxTeater)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "teater"
        Me.Text = "Daftar Teater"
        CType(Me.NumericUpDownJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxTeater As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownJumlah As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
