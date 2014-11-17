
Namespace BussinessObject.Common
    Public Class Jabatan
        Private idjabatan As Int32
        Private namajabatan As String
        Private komisijabatan As Int32
        Private isdelete As Boolean
        Private user As NHibernate.Collection.PersistentSet
        Private jabatanmenu As NHibernate.Collection.PersistentSet

        Sub New(ByVal idjab As Int32, ByVal namajab As String, ByVal komisi As Int32, ByVal isdel As Boolean, ByVal u As NHibernate.Collection.PersistentSet, ByVal jabmenu As NHibernate.Collection.PersistentSet)
            idjabatan = idjab
            namajabatan = namajab
            komisijabatan = komisi
            isdelete = isdel
            user = u
            jabatanmenu = jabmenu
        End Sub

        Public Overridable Property eidjabatan() As Int32
            Get
                Return idjabatan
            End Get

            Set(ByVal value As Int32)
                idjabatan = value
            End Set
        End Property

        Public Overridable Property enamajabatan() As String
            Get
                Return namajabatan
            End Get

            Set(ByVal value As String)
                namajabatan = value
            End Set
        End Property

        Public Overridable Property ekomisijabatan() As Int32
            Get
                Return komisijabatan
            End Get

            Set(ByVal value As Int32)
                komisijabatan = value
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

        Public Overridable Property euser() As NHibernate.Collection.Generic.PersistentGenericSet(Of User)
            Get
                Return user
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of User))
                user = value
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

