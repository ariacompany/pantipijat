<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpegawai
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
        Me.grouplistpegawai = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.txtcaripegawai = New System.Windows.Forms.TextBox()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.dglistpegawai = New System.Windows.Forms.DataGridView()
        Me.grouppegawai = New System.Windows.Forms.GroupBox()
        Me.cbjabatan = New System.Windows.Forms.ComboBox()
        Me.lbljabatan = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.cbagama = New System.Windows.Forms.ComboBox()
        Me.txttelepon = New System.Windows.Forms.TextBox()
        Me.rdperempuan = New System.Windows.Forms.RadioButton()
        Me.rdlaki = New System.Windows.Forms.RadioButton()
        Me.txtnoktp = New System.Windows.Forms.TextBox()
        Me.txtkomisi = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.lblagama = New System.Windows.Forms.Label()
        Me.lbltelepon = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblkomisi = New System.Windows.Forms.Label()
        Me.lblalamat = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblnama = New System.Windows.Forms.Label()
        Me.grouplistpegawai.SuspendLayout()
        CType(Me.dglistpegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grouppegawai.SuspendLayout()
        Me.SuspendLayout()
        '
        'grouplistpegawai
        '
        Me.grouplistpegawai.Controls.Add(Me.btndelete)
        Me.grouplistpegawai.Controls.Add(Me.btnedit)
        Me.grouplistpegawai.Controls.Add(Me.btnnew)
        Me.grouplistpegawai.Controls.Add(Me.txtcaripegawai)
        Me.grouplistpegawai.Controls.Add(Me.lblsearch)
        Me.grouplistpegawai.Controls.Add(Me.dglistpegawai)
        Me.grouplistpegawai.Location = New System.Drawing.Point(28, 12)
        Me.grouplistpegawai.Name = "grouplistpegawai"
        Me.grouplistpegawai.Size = New System.Drawing.Size(653, 243)
        Me.grouplistpegawai.TabIndex = 49
        Me.grouplistpegawai.TabStop = False
        Me.grouplistpegawai.Text = "LIST PEGAWAI"
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
        'txtcaripegawai
        '
        Me.txtcaripegawai.Location = New System.Drawing.Point(67, 19)
        Me.txtcaripegawai.Name = "txtcaripegawai"
        Me.txtcaripegawai.Size = New System.Drawing.Size(168, 20)
        Me.txtcaripegawai.TabIndex = 2
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
        'dglistpegawai
        '
        Me.dglistpegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistpegawai.Location = New System.Drawing.Point(10, 45)
        Me.dglistpegawai.Name = "dglistpegawai"
        Me.dglistpegawai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dglistpegawai.Size = New System.Drawing.Size(608, 152)
        Me.dglistpegawai.TabIndex = 0
        '
        'grouppegawai
        '
        Me.grouppegawai.Controls.Add(Me.cbjabatan)
        Me.grouppegawai.Controls.Add(Me.lbljabatan)
        Me.grouppegawai.Controls.Add(Me.btncancel)
        Me.grouppegawai.Controls.Add(Me.btnsave)
        Me.grouppegawai.Controls.Add(Me.cbagama)
        Me.grouppegawai.Controls.Add(Me.txttelepon)
        Me.grouppegawai.Controls.Add(Me.rdperempuan)
        Me.grouppegawai.Controls.Add(Me.rdlaki)
        Me.grouppegawai.Controls.Add(Me.txtnoktp)
        Me.grouppegawai.Controls.Add(Me.txtkomisi)
        Me.grouppegawai.Controls.Add(Me.txtalamat)
        Me.grouppegawai.Controls.Add(Me.txtpassword)
        Me.grouppegawai.Controls.Add(Me.txtusername)
        Me.grouppegawai.Controls.Add(Me.txtnama)
        Me.grouppegawai.Controls.Add(Me.lblagama)
        Me.grouppegawai.Controls.Add(Me.lbltelepon)
        Me.grouppegawai.Controls.Add(Me.Label2)
        Me.grouppegawai.Controls.Add(Me.Label1)
        Me.grouppegawai.Controls.Add(Me.lblkomisi)
        Me.grouppegawai.Controls.Add(Me.lblalamat)
        Me.grouppegawai.Controls.Add(Me.lblpassword)
        Me.grouppegawai.Controls.Add(Me.lblusername)
        Me.grouppegawai.Controls.Add(Me.lblnama)
        Me.grouppegawai.Location = New System.Drawing.Point(28, 277)
        Me.grouppegawai.Name = "grouppegawai"
        Me.grouppegawai.Size = New System.Drawing.Size(653, 347)
        Me.grouppegawai.TabIndex = 48
        Me.grouppegawai.TabStop = False
        Me.grouppegawai.Text = "PEGAWAI"
        '
        'cbjabatan
        '
        Me.cbjabatan.FormattingEnabled = True
        Me.cbjabatan.Location = New System.Drawing.Point(157, 248)
        Me.cbjabatan.Name = "cbjabatan"
        Me.cbjabatan.Size = New System.Drawing.Size(140, 21)
        Me.cbjabatan.TabIndex = 45
        '
        'lbljabatan
        '
        Me.lbljabatan.AutoSize = True
        Me.lbljabatan.Location = New System.Drawing.Point(88, 252)
        Me.lbljabatan.Name = "lbljabatan"
        Me.lbljabatan.Size = New System.Drawing.Size(55, 13)
        Me.lbljabatan.TabIndex = 44
        Me.lbljabatan.Text = "JABATAN"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(303, 309)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 43
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(143, 309)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 42
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'cbagama
        '
        Me.cbagama.FormattingEnabled = True
        Me.cbagama.Items.AddRange(New Object() {"BUDDHA", "HINDU", "ISLAM", "KRISTEN", "KATOLIK"})
        Me.cbagama.Location = New System.Drawing.Point(157, 221)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.Size = New System.Drawing.Size(121, 21)
        Me.cbagama.TabIndex = 41
        '
        'txttelepon
        '
        Me.txttelepon.Location = New System.Drawing.Point(157, 195)
        Me.txttelepon.Name = "txttelepon"
        Me.txttelepon.Size = New System.Drawing.Size(168, 20)
        Me.txttelepon.TabIndex = 40
        '
        'rdperempuan
        '
        Me.rdperempuan.AutoSize = True
        Me.rdperempuan.Location = New System.Drawing.Point(253, 176)
        Me.rdperempuan.Name = "rdperempuan"
        Me.rdperempuan.Size = New System.Drawing.Size(93, 17)
        Me.rdperempuan.TabIndex = 39
        Me.rdperempuan.Text = "PEREMPUAN"
        Me.rdperempuan.UseVisualStyleBackColor = True
        '
        'rdlaki
        '
        Me.rdlaki.AutoSize = True
        Me.rdlaki.Checked = True
        Me.rdlaki.Location = New System.Drawing.Point(157, 177)
        Me.rdlaki.Name = "rdlaki"
        Me.rdlaki.Size = New System.Drawing.Size(74, 17)
        Me.rdlaki.TabIndex = 38
        Me.rdlaki.TabStop = True
        Me.rdlaki.Text = "LAKI-LAKI"
        Me.rdlaki.UseVisualStyleBackColor = True
        '
        'txtnoktp
        '
        Me.txtnoktp.Location = New System.Drawing.Point(157, 150)
        Me.txtnoktp.Name = "txtnoktp"
        Me.txtnoktp.Size = New System.Drawing.Size(184, 20)
        Me.txtnoktp.TabIndex = 37
        '
        'txtkomisi
        '
        Me.txtkomisi.Location = New System.Drawing.Point(157, 124)
        Me.txtkomisi.Name = "txtkomisi"
        Me.txtkomisi.Size = New System.Drawing.Size(122, 20)
        Me.txtkomisi.TabIndex = 36
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(157, 98)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(264, 20)
        Me.txtalamat.TabIndex = 35
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(157, 71)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(168, 20)
        Me.txtpassword.TabIndex = 34
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(157, 43)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(184, 20)
        Me.txtusername.TabIndex = 33
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(157, 17)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(168, 20)
        Me.txtnama.TabIndex = 32
        '
        'lblagama
        '
        Me.lblagama.AutoSize = True
        Me.lblagama.Location = New System.Drawing.Point(88, 225)
        Me.lblagama.Name = "lblagama"
        Me.lblagama.Size = New System.Drawing.Size(45, 13)
        Me.lblagama.TabIndex = 31
        Me.lblagama.Text = "AGAMA"
        '
        'lbltelepon
        '
        Me.lbltelepon.AutoSize = True
        Me.lbltelepon.Location = New System.Drawing.Point(76, 202)
        Me.lbltelepon.Name = "lbltelepon"
        Me.lbltelepon.Size = New System.Drawing.Size(57, 13)
        Me.lbltelepon.TabIndex = 30
        Me.lbltelepon.Text = "TELEPON"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "JENIS KELAMIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "NO KTP"
        '
        'lblkomisi
        '
        Me.lblkomisi.AutoSize = True
        Me.lblkomisi.Location = New System.Drawing.Point(83, 129)
        Me.lblkomisi.Name = "lblkomisi"
        Me.lblkomisi.Size = New System.Drawing.Size(44, 13)
        Me.lblkomisi.TabIndex = 27
        Me.lblkomisi.Text = "KOMISI"
        '
        'lblalamat
        '
        Me.lblalamat.AutoSize = True
        Me.lblalamat.Location = New System.Drawing.Point(83, 105)
        Me.lblalamat.Name = "lblalamat"
        Me.lblalamat.Size = New System.Drawing.Size(50, 13)
        Me.lblalamat.TabIndex = 26
        Me.lblalamat.Text = "ALAMAT"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(65, 76)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(70, 13)
        Me.lblpassword.TabIndex = 25
        Me.lblpassword.Text = "PASSWORD"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(65, 48)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(68, 13)
        Me.lblusername.TabIndex = 24
        Me.lblusername.Text = "USERNAME"
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
        'frmpegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 750)
        Me.Controls.Add(Me.grouplistpegawai)
        Me.Controls.Add(Me.grouppegawai)
        Me.Name = "frmpegawai"
        Me.Text = "frmpegawai"
        Me.grouplistpegawai.ResumeLayout(False)
        Me.grouplistpegawai.PerformLayout()
        CType(Me.dglistpegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grouppegawai.ResumeLayout(False)
        Me.grouppegawai.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grouplistpegawai As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents txtcaripegawai As System.Windows.Forms.TextBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents dglistpegawai As System.Windows.Forms.DataGridView
    Friend WithEvents grouppegawai As System.Windows.Forms.GroupBox
    Friend WithEvents cbjabatan As System.Windows.Forms.ComboBox
    Friend WithEvents lbljabatan As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cbagama As System.Windows.Forms.ComboBox
    Friend WithEvents txttelepon As System.Windows.Forms.TextBox
    Friend WithEvents rdperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rdlaki As System.Windows.Forms.RadioButton
    Friend WithEvents txtnoktp As System.Windows.Forms.TextBox
    Friend WithEvents txtkomisi As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents lblagama As System.Windows.Forms.Label
    Friend WithEvents lbltelepon As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblkomisi As System.Windows.Forms.Label
    Friend WithEvents lblalamat As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lblnama As System.Windows.Forms.Label
End Class
