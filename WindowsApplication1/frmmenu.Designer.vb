<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEGAWAIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BARANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JABATANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TREATMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENJUALANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEMBELIANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.PENJUALANToolStripMenuItem, Me.PEMBELIANToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(618, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PEGAWAIToolStripMenuItem, Me.BARANGToolStripMenuItem, Me.JABATANToolStripMenuItem, Me.TREATMENTToolStripMenuItem, Me.CUSTOMERToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'PEGAWAIToolStripMenuItem
        '
        Me.PEGAWAIToolStripMenuItem.Name = "PEGAWAIToolStripMenuItem"
        Me.PEGAWAIToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PEGAWAIToolStripMenuItem.Text = "PEGAWAI"
        '
        'BARANGToolStripMenuItem
        '
        Me.BARANGToolStripMenuItem.Name = "BARANGToolStripMenuItem"
        Me.BARANGToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BARANGToolStripMenuItem.Text = "BARANG"
        '
        'JABATANToolStripMenuItem
        '
        Me.JABATANToolStripMenuItem.Name = "JABATANToolStripMenuItem"
        Me.JABATANToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JABATANToolStripMenuItem.Text = "JABATAN"
        '
        'TREATMENTToolStripMenuItem
        '
        Me.TREATMENTToolStripMenuItem.Name = "TREATMENTToolStripMenuItem"
        Me.TREATMENTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TREATMENTToolStripMenuItem.Text = "TREATMENT"
        '
        'CUSTOMERToolStripMenuItem
        '
        Me.CUSTOMERToolStripMenuItem.Name = "CUSTOMERToolStripMenuItem"
        Me.CUSTOMERToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CUSTOMERToolStripMenuItem.Text = "CUSTOMER"
        '
        'PENJUALANToolStripMenuItem
        '
        Me.PENJUALANToolStripMenuItem.Name = "PENJUALANToolStripMenuItem"
        Me.PENJUALANToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.PENJUALANToolStripMenuItem.Text = "PENJUALAN"
        '
        'PEMBELIANToolStripMenuItem
        '
        Me.PEMBELIANToolStripMenuItem.Name = "PEMBELIANToolStripMenuItem"
        Me.PEMBELIANToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.PEMBELIANToolStripMenuItem.Text = "PEMBELIAN"
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 289)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmmenu"
        Me.Text = "frmmenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEGAWAIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BARANGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JABATANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TREATMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUSTOMERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENJUALANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEMBELIANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
