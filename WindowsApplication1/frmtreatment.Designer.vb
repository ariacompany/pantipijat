<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtreatment
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
        Me.grouptreatment = New System.Windows.Forms.GroupBox()
        Me.txtwaktu = New System.Windows.Forms.TextBox()
        Me.lblwaktu = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txttreatment = New System.Windows.Forms.TextBox()
        Me.lblkomisi = New System.Windows.Forms.Label()
        Me.lbljabatan = New System.Windows.Forms.Label()
        Me.grouplisttreatment = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.txtcaritreatment = New System.Windows.Forms.TextBox()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.dglisttreatment = New System.Windows.Forms.DataGridView()
        Me.grouptreatment.SuspendLayout()
        Me.grouplisttreatment.SuspendLayout()
        CType(Me.dglisttreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grouptreatment
        '
        Me.grouptreatment.Controls.Add(Me.txtwaktu)
        Me.grouptreatment.Controls.Add(Me.lblwaktu)
        Me.grouptreatment.Controls.Add(Me.btncancel)
        Me.grouptreatment.Controls.Add(Me.btnsave)
        Me.grouptreatment.Controls.Add(Me.txtharga)
        Me.grouptreatment.Controls.Add(Me.txttreatment)
        Me.grouptreatment.Controls.Add(Me.lblkomisi)
        Me.grouptreatment.Controls.Add(Me.lbljabatan)
        Me.grouptreatment.Location = New System.Drawing.Point(14, 275)
        Me.grouptreatment.Name = "grouptreatment"
        Me.grouptreatment.Size = New System.Drawing.Size(651, 245)
        Me.grouptreatment.TabIndex = 53
        Me.grouptreatment.TabStop = False
        Me.grouptreatment.Text = "TREATMENT"
        '
        'txtwaktu
        '
        Me.txtwaktu.Location = New System.Drawing.Point(102, 79)
        Me.txtwaktu.Name = "txtwaktu"
        Me.txtwaktu.Size = New System.Drawing.Size(150, 20)
        Me.txtwaktu.TabIndex = 8
        '
        'lblwaktu
        '
        Me.lblwaktu.AutoSize = True
        Me.lblwaktu.Location = New System.Drawing.Point(51, 82)
        Me.lblwaktu.Name = "lblwaktu"
        Me.lblwaktu.Size = New System.Drawing.Size(47, 13)
        Me.lblwaktu.TabIndex = 7
        Me.lblwaktu.Text = "WAKTU"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(356, 216)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(158, 216)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(102, 53)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(150, 20)
        Me.txtharga.TabIndex = 3
        '
        'txttreatment
        '
        Me.txttreatment.Location = New System.Drawing.Point(102, 27)
        Me.txttreatment.Name = "txttreatment"
        Me.txttreatment.Size = New System.Drawing.Size(212, 20)
        Me.txttreatment.TabIndex = 2
        '
        'lblkomisi
        '
        Me.lblkomisi.AutoSize = True
        Me.lblkomisi.Location = New System.Drawing.Point(51, 56)
        Me.lblkomisi.Name = "lblkomisi"
        Me.lblkomisi.Size = New System.Drawing.Size(45, 13)
        Me.lblkomisi.TabIndex = 1
        Me.lblkomisi.Text = "HARGA"
        '
        'lbljabatan
        '
        Me.lbljabatan.AutoSize = True
        Me.lbljabatan.Location = New System.Drawing.Point(25, 30)
        Me.lbljabatan.Name = "lbljabatan"
        Me.lbljabatan.Size = New System.Drawing.Size(74, 13)
        Me.lbljabatan.TabIndex = 0
        Me.lbljabatan.Text = "TREATMENT"
        '
        'grouplisttreatment
        '
        Me.grouplisttreatment.Controls.Add(Me.btndelete)
        Me.grouplisttreatment.Controls.Add(Me.btnedit)
        Me.grouplisttreatment.Controls.Add(Me.btnnew)
        Me.grouplisttreatment.Controls.Add(Me.txtcaritreatment)
        Me.grouplisttreatment.Controls.Add(Me.lblsearch)
        Me.grouplisttreatment.Controls.Add(Me.dglisttreatment)
        Me.grouplisttreatment.Location = New System.Drawing.Point(12, 12)
        Me.grouplisttreatment.Name = "grouplisttreatment"
        Me.grouplisttreatment.Size = New System.Drawing.Size(653, 243)
        Me.grouplisttreatment.TabIndex = 52
        Me.grouplisttreatment.TabStop = False
        Me.grouplisttreatment.Text = "LIST TREATMENT"
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
        'txtcaritreatment
        '
        Me.txtcaritreatment.Location = New System.Drawing.Point(67, 19)
        Me.txtcaritreatment.Name = "txtcaritreatment"
        Me.txtcaritreatment.Size = New System.Drawing.Size(168, 20)
        Me.txtcaritreatment.TabIndex = 2
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
        'dglisttreatment
        '
        Me.dglisttreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglisttreatment.Location = New System.Drawing.Point(10, 45)
        Me.dglisttreatment.Name = "dglisttreatment"
        Me.dglisttreatment.Size = New System.Drawing.Size(608, 152)
        Me.dglisttreatment.TabIndex = 0
        '
        'frmtreatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 668)
        Me.Controls.Add(Me.grouptreatment)
        Me.Controls.Add(Me.grouplisttreatment)
        Me.Name = "frmtreatment"
        Me.Text = "frmtreatment"
        Me.grouptreatment.ResumeLayout(False)
        Me.grouptreatment.PerformLayout()
        Me.grouplisttreatment.ResumeLayout(False)
        Me.grouplisttreatment.PerformLayout()
        CType(Me.dglisttreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grouptreatment As System.Windows.Forms.GroupBox
    Friend WithEvents txtwaktu As System.Windows.Forms.TextBox
    Friend WithEvents lblwaktu As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txttreatment As System.Windows.Forms.TextBox
    Friend WithEvents lblkomisi As System.Windows.Forms.Label
    Friend WithEvents lbljabatan As System.Windows.Forms.Label
    Friend WithEvents grouplisttreatment As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents txtcaritreatment As System.Windows.Forms.TextBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents dglisttreatment As System.Windows.Forms.DataGridView
End Class
