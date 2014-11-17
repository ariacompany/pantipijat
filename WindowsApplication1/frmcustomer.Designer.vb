<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcustomer
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
        Me.rdaktif = New System.Windows.Forms.RadioButton()
        Me.rdnonaktif = New System.Windows.Forms.RadioButton()
        Me.lblaktifasi = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txttelepon = New System.Windows.Forms.TextBox()
        Me.rdperempuan = New System.Windows.Forms.RadioButton()
        Me.rdlaki = New System.Windows.Forms.RadioButton()
        Me.txttgllahir = New System.Windows.Forms.TextBox()
        Me.txtnomorkartu = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.lbltelepon = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltgllahir = New System.Windows.Forms.Label()
        Me.lblnokartu = New System.Windows.Forms.Label()
        Me.lblalamat = New System.Windows.Forms.Label()
        Me.lblnama = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.txtcaripelanggan = New System.Windows.Forms.TextBox()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.dglistpelanggan = New System.Windows.Forms.DataGridView()
        Me.grouplistpelanggan = New System.Windows.Forms.GroupBox()
        Me.grouppelanggan = New System.Windows.Forms.GroupBox()
        CType(Me.dglistpelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grouplistpelanggan.SuspendLayout()
        Me.grouppelanggan.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdaktif
        '
        Me.rdaktif.AutoSize = True
        Me.rdaktif.Location = New System.Drawing.Point(253, 173)
        Me.rdaktif.Name = "rdaktif"
        Me.rdaktif.Size = New System.Drawing.Size(55, 17)
        Me.rdaktif.TabIndex = 48
        Me.rdaktif.TabStop = True
        Me.rdaktif.Text = "AKTIF"
        Me.rdaktif.UseVisualStyleBackColor = True
        '
        'rdnonaktif
        '
        Me.rdnonaktif.AutoSize = True
        Me.rdnonaktif.Location = New System.Drawing.Point(157, 174)
        Me.rdnonaktif.Name = "rdnonaktif"
        Me.rdnonaktif.Size = New System.Drawing.Size(82, 17)
        Me.rdnonaktif.TabIndex = 47
        Me.rdnonaktif.TabStop = True
        Me.rdnonaktif.Text = "NON AKTIF"
        Me.rdnonaktif.UseVisualStyleBackColor = True
        '
        'lblaktifasi
        '
        Me.lblaktifasi.AutoSize = True
        Me.lblaktifasi.Location = New System.Drawing.Point(79, 175)
        Me.lblaktifasi.Name = "lblaktifasi"
        Me.lblaktifasi.Size = New System.Drawing.Size(54, 13)
        Me.lblaktifasi.TabIndex = 46
        Me.lblaktifasi.Text = "AKTIFASI"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(339, 222)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 43
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(122, 222)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 42
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txttelepon
        '
        Me.txttelepon.Location = New System.Drawing.Point(158, 73)
        Me.txttelepon.Name = "txttelepon"
        Me.txttelepon.Size = New System.Drawing.Size(168, 20)
        Me.txttelepon.TabIndex = 40
        '
        'rdperempuan
        '
        Me.rdperempuan.AutoSize = True
        Me.rdperempuan.Location = New System.Drawing.Point(253, 99)
        Me.rdperempuan.Name = "rdperempuan"
        Me.rdperempuan.Size = New System.Drawing.Size(93, 17)
        Me.rdperempuan.TabIndex = 39
        Me.rdperempuan.TabStop = True
        Me.rdperempuan.Text = "PEREMPUAN"
        Me.rdperempuan.UseVisualStyleBackColor = True
        '
        'rdlaki
        '
        Me.rdlaki.AutoSize = True
        Me.rdlaki.Location = New System.Drawing.Point(157, 100)
        Me.rdlaki.Name = "rdlaki"
        Me.rdlaki.Size = New System.Drawing.Size(74, 17)
        Me.rdlaki.TabIndex = 38
        Me.rdlaki.TabStop = True
        Me.rdlaki.Text = "LAKI-LAKI"
        Me.rdlaki.UseVisualStyleBackColor = True
        '
        'txttgllahir
        '
        Me.txttgllahir.Location = New System.Drawing.Point(157, 150)
        Me.txttgllahir.Name = "txttgllahir"
        Me.txttgllahir.Size = New System.Drawing.Size(184, 20)
        Me.txttgllahir.TabIndex = 37
        '
        'txtnomorkartu
        '
        Me.txtnomorkartu.Location = New System.Drawing.Point(157, 124)
        Me.txtnomorkartu.Name = "txtnomorkartu"
        Me.txtnomorkartu.Size = New System.Drawing.Size(221, 20)
        Me.txtnomorkartu.TabIndex = 36
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(157, 43)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(239, 20)
        Me.txtalamat.TabIndex = 35
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(157, 17)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(168, 20)
        Me.txtnama.TabIndex = 32
        '
        'lbltelepon
        '
        Me.lbltelepon.AutoSize = True
        Me.lbltelepon.Location = New System.Drawing.Point(76, 76)
        Me.lbltelepon.Name = "lbltelepon"
        Me.lbltelepon.Size = New System.Drawing.Size(57, 13)
        Me.lbltelepon.TabIndex = 30
        Me.lbltelepon.Text = "TELEPON"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "JENIS KELAMIN"
        '
        'lbltgllahir
        '
        Me.lbltgllahir.AutoSize = True
        Me.lbltgllahir.Location = New System.Drawing.Point(40, 153)
        Me.lbltgllahir.Name = "lbltgllahir"
        Me.lbltgllahir.Size = New System.Drawing.Size(93, 13)
        Me.lbltgllahir.TabIndex = 28
        Me.lbltgllahir.Text = "TANGGAL LAHIR"
        '
        'lblnokartu
        '
        Me.lblnokartu.AutoSize = True
        Me.lblnokartu.Location = New System.Drawing.Point(45, 127)
        Me.lblnokartu.Name = "lblnokartu"
        Me.lblnokartu.Size = New System.Drawing.Size(88, 13)
        Me.lblnokartu.TabIndex = 27
        Me.lblnokartu.Text = "NOMOR KARTU"
        '
        'lblalamat
        '
        Me.lblalamat.AutoSize = True
        Me.lblalamat.Location = New System.Drawing.Point(83, 50)
        Me.lblalamat.Name = "lblalamat"
        Me.lblalamat.Size = New System.Drawing.Size(50, 13)
        Me.lblalamat.TabIndex = 26
        Me.lblalamat.Text = "ALAMAT"
        '
        'lblnama
        '
        Me.lblnama.AutoSize = True
        Me.lblnama.Location = New System.Drawing.Point(95, 24)
        Me.lblnama.Name = "lblnama"
        Me.lblnama.Size = New System.Drawing.Size(38, 13)
        Me.lblnama.TabIndex = 23
        Me.lblnama.Text = "NAMA"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(466, 203)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(267, 203)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 4
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(77, 203)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(75, 23)
        Me.btnnew.TabIndex = 3
        Me.btnnew.Text = "NEW"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'txtcaripelanggan
        '
        Me.txtcaripelanggan.Location = New System.Drawing.Point(67, 19)
        Me.txtcaripelanggan.Name = "txtcaripelanggan"
        Me.txtcaripelanggan.Size = New System.Drawing.Size(168, 20)
        Me.txtcaripelanggan.TabIndex = 2
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Location = New System.Drawing.Point(7, 22)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(51, 13)
        Me.lblsearch.TabIndex = 1
        Me.lblsearch.Text = "SEARCH"
        '
        'dglistpelanggan
        '
        Me.dglistpelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistpelanggan.Location = New System.Drawing.Point(10, 45)
        Me.dglistpelanggan.Name = "dglistpelanggan"
        Me.dglistpelanggan.Size = New System.Drawing.Size(608, 152)
        Me.dglistpelanggan.TabIndex = 0
        '
        'grouplistpelanggan
        '
        Me.grouplistpelanggan.Controls.Add(Me.btndelete)
        Me.grouplistpelanggan.Controls.Add(Me.btnedit)
        Me.grouplistpelanggan.Controls.Add(Me.btnnew)
        Me.grouplistpelanggan.Controls.Add(Me.txtcaripelanggan)
        Me.grouplistpelanggan.Controls.Add(Me.lblsearch)
        Me.grouplistpelanggan.Controls.Add(Me.dglistpelanggan)
        Me.grouplistpelanggan.Location = New System.Drawing.Point(12, 12)
        Me.grouplistpelanggan.Name = "grouplistpelanggan"
        Me.grouplistpelanggan.Size = New System.Drawing.Size(653, 243)
        Me.grouplistpelanggan.TabIndex = 51
        Me.grouplistpelanggan.TabStop = False
        Me.grouplistpelanggan.Text = "LIST PELANGGAN"
        '
        'grouppelanggan
        '
        Me.grouppelanggan.Controls.Add(Me.rdaktif)
        Me.grouppelanggan.Controls.Add(Me.rdnonaktif)
        Me.grouppelanggan.Controls.Add(Me.lblaktifasi)
        Me.grouppelanggan.Controls.Add(Me.btncancel)
        Me.grouppelanggan.Controls.Add(Me.btnsave)
        Me.grouppelanggan.Controls.Add(Me.txttelepon)
        Me.grouppelanggan.Controls.Add(Me.rdperempuan)
        Me.grouppelanggan.Controls.Add(Me.rdlaki)
        Me.grouppelanggan.Controls.Add(Me.txttgllahir)
        Me.grouppelanggan.Controls.Add(Me.txtnomorkartu)
        Me.grouppelanggan.Controls.Add(Me.txtalamat)
        Me.grouppelanggan.Controls.Add(Me.txtnama)
        Me.grouppelanggan.Controls.Add(Me.lbltelepon)
        Me.grouppelanggan.Controls.Add(Me.Label2)
        Me.grouppelanggan.Controls.Add(Me.lbltgllahir)
        Me.grouppelanggan.Controls.Add(Me.lblnokartu)
        Me.grouppelanggan.Controls.Add(Me.lblalamat)
        Me.grouppelanggan.Controls.Add(Me.lblnama)
        Me.grouppelanggan.Location = New System.Drawing.Point(12, 277)
        Me.grouppelanggan.Name = "grouppelanggan"
        Me.grouppelanggan.Size = New System.Drawing.Size(653, 272)
        Me.grouppelanggan.TabIndex = 50
        Me.grouppelanggan.TabStop = False
        Me.grouppelanggan.Text = "PELANGGAN"
        '
        'frmcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 750)
        Me.Controls.Add(Me.grouplistpelanggan)
        Me.Controls.Add(Me.grouppelanggan)
        Me.Name = "frmcustomer"
        Me.Text = "frmcustomer"
        CType(Me.dglistpelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grouplistpelanggan.ResumeLayout(False)
        Me.grouplistpelanggan.PerformLayout()
        Me.grouppelanggan.ResumeLayout(False)
        Me.grouppelanggan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdaktif As System.Windows.Forms.RadioButton
    Friend WithEvents rdnonaktif As System.Windows.Forms.RadioButton
    Friend WithEvents lblaktifasi As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txttelepon As System.Windows.Forms.TextBox
    Friend WithEvents rdperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rdlaki As System.Windows.Forms.RadioButton
    Friend WithEvents txttgllahir As System.Windows.Forms.TextBox
    Friend WithEvents txtnomorkartu As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents lbltelepon As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltgllahir As System.Windows.Forms.Label
    Friend WithEvents lblnokartu As System.Windows.Forms.Label
    Friend WithEvents lblalamat As System.Windows.Forms.Label
    Friend WithEvents lblnama As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents txtcaripelanggan As System.Windows.Forms.TextBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents dglistpelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents grouplistpelanggan As System.Windows.Forms.GroupBox
    Friend WithEvents grouppelanggan As System.Windows.Forms.GroupBox
End Class
