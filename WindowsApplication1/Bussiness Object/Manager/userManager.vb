Imports WindowsApplication1.Manager
Imports WindowsApplication1.BussinessObject.Common
Imports NHibernate.Criterion

Namespace BussinessObject.Manager
    Class userManager
        Inherits genericORM(Of User, Int32)

        Function login(ByVal user As String, ByVal pass As String) As Boolean
            'config()
            openSession()
            setTransaction()
            Dim listuser As List(Of User)

            listuser = getSession.CreateQuery("from User where username= :user and pass = :pass").SetParameter("user", user).SetParameter("pass", pass).List(Of User)()
            getTransaction.Commit()
            getSession.Close()
            If listuser.Count = 1 Then
                Return True
            End If
            Return False

        End Function

        Function selectUser() As List(Of userJabatan)
            'config()
            openSession()
            setTransaction()
            Dim listUser As New List(Of User)
            Dim listUserJabatan As New List(Of userJabatan)
            'listUser = (getSession.CreateQuery("from User").List).Cast(Of userJabatan)().ToList
            listUser = (getSession.CreateQuery("from User").List).Cast(Of User)().ToList
            For Each temp As User In listUser
                listUserJabatan.Add(New userJabatan(temp))
            Next
            'listUser = getSession.CreateCriteria(GetType(User), "u").SetFetchMode("jabatan", NHibernate.FetchMode.Eager)
            getTransaction.Commit()
            getSession.Close()
            Return listUserJabatan
        End Function


       

    End Class
End Namespace
