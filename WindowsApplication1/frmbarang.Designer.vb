<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbarang
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
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txthargaperkiraan = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txthargajual = New System.Windows.Forms.TextBox()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.lblinventaris = New System.Windows.Forms.Label()
        Me.lblhargaperkiraan = New System.Windows.Forms.Label()
        Me.lblhargajual = New System.Windows.Forms.Label()
        Me.lblstok = New System.Windows.Forms.Label()
        Me.lblnamabarang = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.txtcaribarang = New System.Windows.Forms.TextBox()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.dglistbarang = New System.Windows.Forms.DataGridView()
        Me.groupbarang = New System.Windows.Forms.GroupBox()
        Me.grouplistbarang = New System.Windows.Forms.GroupBox()
        CType(Me.dglistbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbarang.SuspendLayout()
        Me.grouplistbarang.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(270, 71)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton2.TabIndex = 46
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "TIDAK"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(158, 73)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton1.TabIndex = 45
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "YA"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txthargaperkiraan
        '
        Me.txthargaperkiraan.Location = New System.Drawing.Point(158, 99)
        Me.txthargaperkiraan.Name = "txthargaperkiraan"
        Me.txthargaperkiraan.Size = New System.Drawing.Size(168, 20)
        Me.txthargaperkiraan.TabIndex = 44
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(303, 181)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 43
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(158, 181)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 42
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txthargajual
        '
        Me.txthargajual.Location = New System.Drawing.Point(157, 124)
        Me.txthargajual.Name = "txthargajual"
        Me.txthargajual.Size = New System.Drawing.Size(221, 20)
        Me.txthargajual.TabIndex = 36
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(157, 43)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(239, 20)
        Me.txtstok.TabIndex = 35
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(157, 17)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(168, 20)
        Me.txtnamabarang.TabIndex = 32
        '
        'lblinventaris
        '
        Me.lblinventaris.AutoSize = True
        Me.lblinventaris.Location = New System.Drawing.Point(61, 75)
        Me.lblinventaris.Name = "lblinventaris"
        Me.lblinventaris.Size = New System.Drawing.Size(72, 13)
        Me.lblinventaris.TabIndex = 30
        Me.lblinventaris.Text = "INVENTARIS"
        '
        'lblhargaperkiraan
        '
        Me.lblhargaperkiraan.AutoSize = True
        Me.lblhargaperkiraan.Location = New System.Drawing.Point(23, 102)
        Me.lblhargaperkiraan.Name = "lblhargaperkiraan"
        Me.lblhargaperkiraan.Size = New System.Drawing.Size(110, 13)
        Me.lblhargaperkiraan.TabIndex = 29
        Me.lblhargaperkiraan.Text = "HARGA PERKIRAAN"
        '
        'lblhargajual
        '
        Me.lblhargajual.AutoSize = True
        Me.lblhargajual.Location = New System.Drawing.Point(59, 127)
        Me.lblhargajual.Name = "lblhargajual"
        Me.lblhargajual.Size = New System.Drawing.Size(74, 13)
        Me.lblhargajual.TabIndex = 27
        Me.lblhargajual.Text = "HARGA JUAL"
        '
        'lblstok
        '
        Me.lblstok.AutoSize = True
        Me.lblstok.Location = New System.Drawing.Point(97, 50)
        Me.lblstok.Name = "lblstok"
        Me.lblstok.Size = New System.Drawing.Size(36, 13)
        Me.lblstok.TabIndex = 26
        Me.lblstok.Text = "STOK"
        '
        'lblnamabarang
        '
        Me.lblnamabarang.AutoSize = True
        Me.lblnamabarang.Location = New System.Drawing.Point(47, 23)
        Me.lblnamabarang.Name = "lblnamabarang"
        Me.lblnamabarang.Size = New System.Drawing.Size(86, 13)
        Me.lblnamabarang.TabIndex = 23
        Me.lblnamabarang.Text = "NAMA BARANG"
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
        'txtcaribarang
        '
        Me.txtcaribarang.Location = New System.Drawing.Point(67, 19)
        Me.txtcaribarang.Name = "txtcaribarang"
        Me.txtcaribarang.Size = New System.Drawing.Size(168, 20)
        Me.txtcaribarang.TabIndex = 2
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
        'dglistbarang
        '
        Me.dglistbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistbarang.Location = New System.Drawing.Point(10, 45)
        Me.dglistbarang.Name = "dglistbarang"
        Me.dglistbarang.Size = New System.Drawing.Size(608, 152)
        Me.dglistbarang.TabIndex = 0
        '
        'groupbarang
        '
        Me.groupbarang.Controls.Add(Me.RadioButton2)
        Me.groupbarang.Controls.Add(Me.RadioButton1)
        Me.groupbarang.Controls.Add(Me.txthargaperkiraan)
        Me.groupbarang.Controls.Add(Me.btncancel)
        Me.groupbarang.Controls.Add(Me.btnsave)
        Me.groupbarang.Controls.Add(Me.txthargajual)
        Me.groupbarang.Controls.Add(Me.txtstok)
        Me.groupbarang.Controls.Add(Me.txtnamabarang)
        Me.groupbarang.Controls.Add(Me.lblinventaris)
        Me.groupbarang.Controls.Add(Me.lblhargaperkiraan)
        Me.groupbarang.Controls.Add(Me.lblhargajual)
        Me.groupbarang.Controls.Add(Me.lblstok)
        Me.groupbarang.Controls.Add(Me.lblnamabarang)
        Me.groupbarang.Enabled = False
        Me.groupbarang.Location = New System.Drawing.Point(32, 284)
        Me.groupbarang.Name = "groupbarang"
        Me.groupbarang.Size = New System.Drawing.Size(653, 230)
        Me.groupbarang.TabIndex = 53
        Me.groupbarang.TabStop = False
        Me.groupbarang.Text = "BARANG"
        '
        'grouplistbarang
        '
        Me.grouplistbarang.Controls.Add(Me.btndelete)
        Me.grouplistbarang.Controls.Add(Me.btnedit)
        Me.grouplistbarang.Controls.Add(Me.btnnew)
        Me.grouplistbarang.Controls.Add(Me.txtcaribarang)
        Me.grouplistbarang.Controls.Add(Me.lblsearch)
        Me.grouplistbarang.Controls.Add(Me.dglistbarang)
        Me.grouplistbarang.Location = New System.Drawing.Point(35, 25)
        Me.grouplistbarang.Name = "grouplistbarang"
        Me.grouplistbarang.Size = New System.Drawing.Size(653, 243)
        Me.grouplistbarang.TabIndex = 52
        Me.grouplistbarang.TabStop = False
        Me.grouplistbarang.Text = "LIST BARANG"
        '
        'frmbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 653)
        Me.Controls.Add(Me.groupbarang)
        Me.Controls.Add(Me.grouplistbarang)
        Me.Name = "frmbarang"
        Me.Text = "frmbarang"
        CType(Me.dglistbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbarang.ResumeLayout(False)
        Me.groupbarang.PerformLayout()
        Me.grouplistbarang.ResumeLayout(False)
        Me.grouplistbarang.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txthargaperkiraan As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txthargajual As System.Windows.Forms.TextBox
    Friend WithEvents txtstok As System.Windows.Forms.TextBox
    Friend WithEvents txtnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents lblinventaris As System.Windows.Forms.Label
    Friend WithEvents lblhargaperkiraan As System.Windows.Forms.Label
    Friend WithEvents lblhargajual As System.Windows.Forms.Label
    Friend WithEvents lblstok As System.Windows.Forms.Label
    Friend WithEvents lblnamabarang As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents txtcaribarang As System.Windows.Forms.TextBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents dglistbarang As System.Windows.Forms.DataGridView
    Friend WithEvents groupbarang As System.Windows.Forms.GroupBox
    Friend WithEvents grouplistbarang As System.Windows.Forms.GroupBox
End Class
