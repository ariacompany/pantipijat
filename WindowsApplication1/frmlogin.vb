Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common

Public Class frmlogin
    Public Shared logger As log4net.ILog
    Private usermanager As New BussinessObject.Manager.userManager
    Private jabatanManager As New BussinessObject.Manager.jabatanManager
    Private jabatanList As List(Of Jabatan)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name())

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


        'For Each temp As Jabatan In jabatanList
        'cbJabatan.Items.Add(temp)
        'Next
        jabatanList = jabatanManager.selectAll()
        cbJabatan.DataSource = jabatanList
        cbJabatan.ValueMember = "eidjabatan"
        cbJabatan.DisplayMember = "enamajabatan"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ''Dim myConfig As New Configuration
        ''myConfig.Configure()
        ''myConfig.AddAssembly(GetType(User).Assembly)

        'myConfig.Configure("hibernate.cfg.xml")
        'myConfig.AddFile("hibernate.cfg.xml")
        'myConfig.Configure("hibernate.cfg.xml")
        'myConfig.AddAssembly("WindowsApplication1")
        'myConfig.SetProperty("hibernate.dialect", _
        '            "NHibernate.Dialect.MySQLDialect")

        ''Dim myFactory As ISessionFactory = myConfig.BuildSessionFactory
        ''Dim mySession As ISession = myFactory.OpenSession
        ''Dim myTransaction As ITransaction = mySession.BeginTransaction

        'Dim user As New BussinessObject.Common.User
        'user.eusername = txtUser.Text
        'user.epass = txtPass.Text
        'user.ejeniskelamin = "P"
        'user.ejabatan = cbJabatan.SelectedItem

        'Dim userManager As New BussinessObject.Manager.userManager
        'userManager.save(user)

        ''mySession.Save(user)
        ''myTransaction.Commit()
        ''mySession.Close()

        Dim menu As New frmmenu

        If usermanager.login(txtUser.Text, txtPass.Text) = True Then

            frmmenu.Show()

        Else
            MessageBox.Show("USERNAME/PASSWORD TIDAK VALID")

        End If



        'MessageBox.Show("success")

    End Sub
End Class
