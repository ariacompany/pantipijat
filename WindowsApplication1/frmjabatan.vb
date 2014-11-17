Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common
Public Class frmjabatan
    Private jabatanmanager As New BussinessObject.Manager.jabatanManager
    Private jabatanList As List(Of Jabatan)
    Private Sub frmjabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
  
        jabatanList = jabatanmanager.selectAll()
        dglistjabatan.DataSource = jabatanList
    End Sub
End Class