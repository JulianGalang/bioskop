<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SosialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SosialToolStripMenuItem, Me.StaffToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(450, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SosialToolStripMenuItem
        '
        Me.SosialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.DaftarToolStripMenuItem, Me.ToolStripSeparator1, Me.LogoutToolStripMenuItem})
        Me.SosialToolStripMenuItem.Name = "SosialToolStripMenuItem"
        Me.SosialToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SosialToolStripMenuItem.Text = "Sosial"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'DaftarToolStripMenuItem
        '
        Me.DaftarToolStripMenuItem.Name = "DaftarToolStripMenuItem"
        Me.DaftarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DaftarToolStripMenuItem.Text = "Daftar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilmToolStripMenuItem, Me.TeaterToolStripMenuItem})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'FilmToolStripMenuItem
        '
        Me.FilmToolStripMenuItem.Name = "FilmToolStripMenuItem"
        Me.FilmToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FilmToolStripMenuItem.Text = "Film"
        '
        'TeaterToolStripMenuItem
        '
        Me.TeaterToolStripMenuItem.Name = "TeaterToolStripMenuItem"
        Me.TeaterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TeaterToolStripMenuItem.Text = "Teater"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(450, 303)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SosialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeaterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
