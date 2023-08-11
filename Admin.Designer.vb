<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxTelepon = New System.Windows.Forms.TextBox()
        Me.RichTextBoxAlamat = New System.Windows.Forms.RichTextBox()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonKembali = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daftar Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telepon Admin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat Admin"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(261, 45)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(317, 20)
        Me.TextBoxNama.TabIndex = 4
        '
        'TextBoxTelepon
        '
        Me.TextBoxTelepon.Location = New System.Drawing.Point(261, 87)
        Me.TextBoxTelepon.Name = "TextBoxTelepon"
        Me.TextBoxTelepon.Size = New System.Drawing.Size(317, 20)
        Me.TextBoxTelepon.TabIndex = 5
        '
        'RichTextBoxAlamat
        '
        Me.RichTextBoxAlamat.Location = New System.Drawing.Point(261, 126)
        Me.RichTextBoxAlamat.Name = "RichTextBoxAlamat"
        Me.RichTextBoxAlamat.Size = New System.Drawing.Size(317, 50)
        Me.RichTextBoxAlamat.TabIndex = 6
        Me.RichTextBoxAlamat.Text = ""
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackColor = System.Drawing.Color.DimGray
        Me.ButtonTambah.FlatAppearance.BorderSize = 0
        Me.ButtonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTambah.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonTambah.Location = New System.Drawing.Point(45, 216)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(107, 45)
        Me.ButtonTambah.TabIndex = 7
        Me.ButtonTambah.Text = "TAMBAH"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'ButtonUbah
        '
        Me.ButtonUbah.BackColor = System.Drawing.Color.DimGray
        Me.ButtonUbah.FlatAppearance.BorderSize = 0
        Me.ButtonUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUbah.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUbah.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonUbah.Location = New System.Drawing.Point(158, 216)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(107, 45)
        Me.ButtonUbah.TabIndex = 8
        Me.ButtonUbah.Text = "UBAH"
        Me.ButtonUbah.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.DimGray
        Me.ButtonHapus.FlatAppearance.BorderSize = 0
        Me.ButtonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHapus.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonHapus.Location = New System.Drawing.Point(271, 216)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(107, 45)
        Me.ButtonHapus.TabIndex = 9
        Me.ButtonHapus.Text = "HAPUS"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.DimGray
        Me.ButtonBatal.FlatAppearance.BorderSize = 0
        Me.ButtonBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBatal.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBatal.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonBatal.Location = New System.Drawing.Point(384, 216)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(107, 45)
        Me.ButtonBatal.TabIndex = 10
        Me.ButtonBatal.Text = "BATAL"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'ButtonKembali
        '
        Me.ButtonKembali.BackColor = System.Drawing.Color.DimGray
        Me.ButtonKembali.FlatAppearance.BorderSize = 0
        Me.ButtonKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonKembali.Font = New System.Drawing.Font("Gilroy ExtraBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKembali.ForeColor = System.Drawing.Color.PeachPuff
        Me.ButtonKembali.Location = New System.Drawing.Point(497, 216)
        Me.ButtonKembali.Name = "ButtonKembali"
        Me.ButtonKembali.Size = New System.Drawing.Size(107, 45)
        Me.ButtonKembali.TabIndex = 11
        Me.ButtonKembali.Text = "KEMBALI"
        Me.ButtonKembali.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 267)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(559, 109)
        Me.DataGridView1.TabIndex = 12
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(452, 182)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxPassword.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Username"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(168, 181)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxUsername.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gilroy ExtraBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(322, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 26)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Password"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(637, 388)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonKembali)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.RichTextBoxAlamat)
        Me.Controls.Add(Me.TextBoxTelepon)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Admin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTelepon As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBoxAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonKembali As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
