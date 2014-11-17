
Namespace BussinessObject.Common
    Public Class Pembelian
        Private idpembelian As Int32
        Private tglpembelian As Date
        Private namasupplier As String
        Private tax As Int32
        Private grandtotal As Decimal
        Private isdelete As Boolean
        Private user As User

        Sub New(ByVal idpem As Int32, ByVal tglpem As Date, ByVal namasupp As String, ByVal t As Int32, ByVal grandt As Decimal, ByVal isdel As Boolean, ByVal u As User)
            idpembelian = idpem
            tglpembelian = tglpem
            namasupplier = namasupp
            tax = t
            grandtotal = grandt
            isdelete = isdel
            user = u
        End Sub

        Public Overridable Property eiduser() As Int32
            Get
                Return iduser
            End Get
            Set(ByVal value As Int32)
                iduser = value
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
