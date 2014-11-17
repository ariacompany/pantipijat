Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports WindowsApplication1.BussinessObject.Common
Imports NHibernate.Mapping.ByCode

Namespace Manager
    Public Class genericORM(Of T, I)
        Public Shared logger As log4net.ILog
        Private myConfig As New Configuration
        Private myFactory As ISessionFactory
        Private mySession As ISession
        Private myTransaction As ITransaction

        'Public Sub config()
        '    myConfig.Configure()
        '    myConfig.AddAssembly(GetType(T).Assembly)
        '    myFactory = myConfig.BuildSessionFactory
        '    mySession = myFactory.OpenSession
        '    myTransaction = mySession.BeginTransaction
        'End Sub
        Public Function openSession() As ISession
            If (IsNothing(myFactory)) Then
                myConfig.Configure()
                myConfig.AddAssembly(GetType(T).Assembly)
                myFactory = myConfig.BuildSessionFactory
            End If
            mySession = myFactory.OpenSession
            Return mySession
        End Function

        Public Function getSession() As ISession
            Return mySession
        End Function

        Public Sub setTransaction()
            myTransaction = mySession.BeginTransaction
        End Sub

        Public Function getTransaction() As ITransaction
            Return myTransaction
        End Function

        Public Sub save(ByVal myObject As T)
            'config()
            openSession()
            myTransaction = mySession.BeginTransaction
            mySession.Save(myObject)
            myTransaction.Commit()
            mySession.Close()
        End Sub

        Public Sub update(ByVal myObject As T)
            'config()
            openSession()
            myTransaction = mySession.BeginTransaction
            mySession.Update(myObject)
            myTransaction.Commit()
            mySession.Close()
        End Sub

        Public Sub delete(ByVal myObject As T)
            'config()
            openSession()
            myTransaction = mySession.BeginTransaction
            mySession.Delete(myObject)
            myTransaction.Commit()
            mySession.Close()
        End Sub

        Public Function selectAll() As List(Of T)
            Dim l As List(Of T)
            'config()
            openSession()
            myTransaction = mySession.BeginTransaction
            l = (mySession.CreateCriteria(GetType(T)).List()).Cast(Of T)().ToList
            'l = mySession.CreateCriteria(GetType(T)).List()
            'mySession.QueryOver<User>().List()
            'mySession.CreateQuery(" from "+).List<T>()
            myTransaction.Commit()
            mySession.Close()
            Return l
        End Function

        Public Function findByPrimaryKey(ByVal id As I) As T
            Dim temp As T
            'config()
            openSession()
            myTransaction = mySession.BeginTransaction
            temp = mySession.Load(Of T)(id)
            myTransaction.Commit()
            mySession.Close()
            Return temp
        End Function
    End Class
End Namespace

