Public Class frmmenu

    Private Sub BARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BARANGToolStripMenuItem.Click
        Dim masterbarang As New frmbarang
        masterbarang.MdiParent = Me
        masterbarang.Show()
    End Sub

    Private Sub PEGAWAIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEGAWAIToolStripMenuItem.Click
        Dim masterpegawai As New frmpegawai
        masterpegawai.MdiParent = Me
        masterpegawai.Show()
    End Sub

    Private Sub JABATANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JABATANToolStripMenuItem.Click
        Dim masterjabatan As New frmjabatan
        masterjabatan.MdiParent = Me
        masterjabatan.Show()
    End Sub

    Private Sub TREATMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TREATMENTToolStripMenuItem.Click
        Dim mastertreatment As New frmtreatment
        mastertreatment.MdiParent = Me
        mastertreatment.Show()
    End Sub

    Private Sub CUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERToolStripMenuItem.Click
        Dim mastercustomer As New frmcustomer
        mastercustomer.MdiParent = Me
        mastercustomer.Show()
    End Sub
End Class