
Namespace BussinessObject.Common
    Public Class Menu
        Private idmenu As Int32
        Private namamenu As String
        Private isdelete As Boolean
        Private jabatanmenu As NHibernate.Collection.PersistentSet

        Sub New(ByVal idme As Int32, ByVal namamen As String, ByVal isdel As Boolean, ByVal jabmen As NHibernate.Collection.PersistentSet)
            idmenu = idme
            namamenu = namamen
            isdelete = isdelete
            jabatanmenu = jabmen
        End Sub

        Public Overridable Property eidmenu As Int32
            Get
                Return idmenu
            End Get

            Set(ByVal value As Int32)
                idmenu = value
            End Set
        End Property

        Public Overridable Property enamamenu As String
            Get
                Return namamenu
            End Get

            Set(ByVal value As String)
                namamenu = value
            End Set
        End Property

        Public Overridable Property eisdelete() As Boolean
            Get
                Return isdelete
            End Get

            Set(ByVal value As Boolean)
                isdelete = value
            End Set
        End Property

        Public Overridable Property ejabatanmenu() As NHibernate.Collection.Generic.PersistentGenericSet(Of JabatanMenu)
            Get
                Return jabatanmenu
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of JabatanMenu))
                jabatanmenu = value
            End Set
        End Property
    End Class
End Namespace
