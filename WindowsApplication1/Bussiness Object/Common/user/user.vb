Imports NHibernate
Imports NHibernate.Cfg
Imports System.Configuration

Namespace BussinessObject.Common
    Public Class User
        Private iduser As Int32
        Private username As String
        Private pass As String
        Private nama As String
        Private alamat As String
        Private komisi As Int32
        Private noktp As String
        Private jeniskelamin As Char
        Private telepon As String
        Private agama As String
        Private isdelete As Boolean
        Private jabatan As Jabatan

        Public Overridable Property eiduser() As Int32
            Get
                Return iduser
            End Get
            Set(ByVal value As Int32)
                iduser = value
            End Set
        End Property

        Public Overridable Property eusername() As String
            Get
                Return username
            End Get
            Set(ByVal value As String)
                username = value
            End Set
        End Property

        Public Overridable Property epass() As String
            Get
                Return pass
            End Get
            Set(ByVal value As String)
                pass = value
            End Set
        End Property

        Public Overridable Property enama() As String
            Get
                Return nama
            End Get
            Set(ByVal value As String)
                nama = value
            End Set
        End Property

        Public Overridable Property ealamat() As String
            Get
                Return alamat
            End Get
            Set(ByVal value As String)
                alamat = value
            End Set
        End Property

        Public Overridable Property ekomisi() As Int32
            Get
                Return komisi
            End Get
            Set(ByVal value As Int32)
                komisi = value
            End Set
        End Property

        Public Overridable Property enoktp() As String
            Get
                Return noktp
            End Get
            Set(ByVal value As String)
                noktp = value
            End Set
        End Property

        Public Overridable Property ejeniskelamin() As Char
            Get
                Return jeniskelamin
            End Get
            Set(ByVal value As Char)
                jeniskelamin = value
            End Set
        End Property

        Public Overridable Property etelepon() As String
            Get
                Return telepon
            End Get
            Set(ByVal value As String)
                telepon = value
            End Set
        End Property

        Public Overridable Property eagama() As String
            Get
                Return agama
            End Get
            Set(ByVal value As String)
                agama = value
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
            
        Public Overridable Property eidjabatan() As Jabatan
            Get
                Return jabatan
            End Get
            Set(value As Jabatan)
                jabatan = value
            End Set
        End Property
    End Class
End Namespace
