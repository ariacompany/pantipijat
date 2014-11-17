<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmjabatan
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
        Me.dgcarijabatan = New System.Windows.Forms.TextBox()
        Me.txtkomisi = New System.Windows.Forms.TextBox()
        Me.txtjabatan = New System.Windows.Forms.TextBox()
        Me.lblkomisi = New System.Windows.Forms.Label()
        Me.lbljabatan = New System.Windows.Forms.Label()
        Me.grouplistpegawai = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.dglistjabatan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.grouplistpegawai.SuspendLayout()
        CType(Me.dglistjabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgcarijabatan
        '
        Me.dgcarijabatan.Location = New System.Drawing.Point(67, 19)
        Me.dgcarijabatan.Name = "dgcarijabatan"
        Me.dgcarijabatan.Size = New System.Drawing.Size(168, 20)
        Me.dgcarijabatan.TabIndex = 2
        '
        'txtkomisi
        '
        Me.txtkomisi.Location = New System.Drawing.Point(102, 53)
        Me.txtkomisi.Name = "txtkomisi"
        Me.txtkomisi.Size = New System.Drawing.Size(150, 20)
        Me.txtkomisi.TabIndex = 3
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(102, 27)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(212, 20)
        Me.txtjabatan.TabIndex = 2
        '
        'lblkomisi
        '
        Me.lblkomisi.AutoSize = True
        Me.lblkomisi.Location = New System.Drawing.Point(36, 56)
        Me.lblkomisi.Name = "lblkomisi"
        Me.lblkomisi.Size = New System.Drawing.Size(44, 13)
        Me.lblkomisi.TabIndex = 1
        Me.lblkomisi.Text = "KOMISI"
        '
        'lbljabatan
        '
        Me.lbljabatan.AutoSize = True
        Me.lbljabatan.Location = New System.Drawing.Point(25, 30)
        Me.lbljabatan.Name = "lbljabatan"
        Me.lbljabatan.Size = New System.Drawing.Size(55, 13)
        Me.lbljabatan.TabIndex = 0
        Me.lbljabatan.Text = "JABATAN"
        '
        'grouplistpegawai
        '
        Me.grouplistpegawai.Controls.Add(Me.btndelete)
        Me.grouplistpegawai.Controls.Add(Me.btnedit)
        Me.grouplistpegawai.Controls.Add(Me.btnnew)
        Me.grouplistpegawai.Controls.Add(Me.dgcarijabatan)
        Me.grouplistpegawai.Controls.Add(Me.lblsearch)
        Me.grouplistpegawai.Controls.Add(Me.dglistjabatan)
        Me.grouplistpegawai.Location = New System.Drawing.Point(12, 12)
        Me.grouplistpegawai.Name = "grouplistpegawai"
        Me.grouplistpegawai.Size = New System.Drawing.Size(653, 243)
        Me.grouplistpegawai.TabIndex = 50
        Me.grouplistpegawai.TabStop = False
        Me.grouplistpegawai.Text = "LIST JABATAN"
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
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Location = New System.Drawing.Point(7, 22)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(51, 13)
        Me.lblsearch.TabIndex = 1
        Me.lblsearch.Text = "SEARCH"
        '
        'dglistjabatan
        '
        Me.dglistjabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistjabatan.Location = New System.Drawing.Point(10, 45)
        Me.dglistjabatan.Name = "dglistjabatan"
        Me.dglistjabatan.Size = New System.Drawing.Size(608, 152)
        Me.dglistjabatan.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.txtkomisi)
        Me.GroupBox1.Controls.Add(Me.txtjabatan)
        Me.GroupBox1.Controls.Add(Me.lblkomisi)
        Me.GroupBox1.Controls.Add(Me.lbljabatan)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 275)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 245)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "JABATAN"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(369, 202)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(158, 202)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmjabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 702)
        Me.Controls.Add(Me.grouplistpegawai)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmjabatan"
        Me.Text = "frmjabatan"
        Me.grouplistpegawai.ResumeLayout(False)
        Me.grouplistpegawai.PerformLayout()
        CType(Me.dglistjabatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgcarijabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtkomisi As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents lblkomisi As System.Windows.Forms.Label
    Friend WithEvents lbljabatan As System.Windows.Forms.Label
    Friend WithEvents grouplistpegawai As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents dglistjabatan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
End Class
