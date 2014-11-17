Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common

Public Class frmpegawai
    Public Shared logger As log4net.ILog
    Private usermanager1 As New BussinessObject.Manager.userManager
    Private userList As List(Of userJabatan)

    Private jabatanManager As New BussinessObject.Manager.jabatanManager
    Private jabatanList As List(Of Jabatan)
    Private Sub frmpegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Get the logger as named in the configuration file.
            logger = log4net.LogManager.GetLogger("Log4NetAssembly1")
            logger.Info("Form1_Load() - Start")
            logger.Debug("Form1_Load() - Code Implementation goes here......")
        Catch ex As Exception
            logger.Error("Form1_Load() - " & ex.Message)
        Finally
            logger.Info("Form1_Load() - Finish")
        End Try



        'userList = usermanager1.selectAll()
        userList = usermanager1.selectUser()
        dglistpegawai.DataSource = userList
        jabatanList = jabatanManager.selectAll()
        cbjabatan.DataSource = jabatanList
        cbjabatan.ValueMember = "eidjabatan"
        cbjabatan.DisplayMember = "enamajabatan"
        cbjabatan.SelectedValue = ""
        'dglistpegawai.Columns(10).Visible = False
        'dglistpegawai.Columns(11).Visible = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        grouppegawai.Enabled = False
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtnama.Text = dglistpegawai.SelectedRows.Item(0).Cells(3).Value
        txtusername.Text = dglistpegawai.SelectedRows.Item(0).Cells(1).Value
        txtpassword.Text = dglistpegawai.SelectedRows.Item(0).Cells(2).Value
        txtalamat.Text = dglistpegawai.SelectedRows.Item(0).Cells(4).Value
        txtkomisi.Text = dglistpegawai.SelectedRows.Item(0).Cells(5).Value
        txtnoktp.Text = dglistpegawai.SelectedRows.Item(0).Cells(6).Value
        txttelepon.Text = dglistpegawai.SelectedRows.Item(0).Cells(8).Value

        If (dglistpegawai.SelectedRows.Item(0).Cells(7).Value = "L") Then
            rdlaki.Checked = True
        Else
            rdperempuan.Checked = True
        End If

        Dim index As Integer
        Dim indexjabatan As Integer
        index = cbagama.FindString(dglistpegawai.SelectedRows.Item(0).Cells(9).Value)
        cbagama.SelectedIndex = index

        indexjabatan = cbjabatan.FindString(dglistpegawai.SelectedRows.Item(0).Cells(12).Value)
        cbjabatan.SelectedIndex = indexjabatan
    End Sub

    Private Sub txtcaripegawai_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcaripegawai.KeyUp

    End Sub
End Class