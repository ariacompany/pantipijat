Namespace BussinessObject.Common
    Public Class customer
        Private idcustomer As Int32
        Private nama As String
        Private alamat As String
        Private telp As String
        Private nokartu As String
        Private jeniskelamin As Char
        Private tgllahir As Date
        Private aktif As Boolean
        Private isdelete As Boolean

        Sub New(ByVal idcus As Int32, ByVal nam As String, ByVal alm As String, ByVal tel As String, ByVal nokar As String, ByVal jenis As Char, ByVal tgllah As Date, ByVal akt As Boolean, ByVal isdel As Boolean)
            idcustomer = idcus
            nama = nam
            alamat = alm
            telp = tel
            nokartu = nokar
            jeniskelamin = jenis
            tgllahir = tgllah
            aktif = akt
            isdelete = isdel
        End Sub

        Public Overridable Property eidcustomer() As Int32
            Get
                Return idcustomer
            End Get

            Set(ByVal value As Int32)
                idcustomer = value
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

        Public Overridable Property etelp() As String
            Get
                Return telp
            End Get

            Set(ByVal value As String)
                telp = value
            End Set
        End Property

        Public Overridable Property enokartu() As String
            Get
                Return nokartu
            End Get

            Set(ByVal value As String)
                nokartu = value
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

        Public Overridable Property etgllahir() As Date
            Get
                Return tgllahir
            End Get

            Set(ByVal value As Date)
                tgllahir = value
            End Set
        End Property

        Public Overridable Property eaktif() As Boolean
            Get
                Return aktif
            End Get

            Set(ByVal value As Boolean)
                aktif = value
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
    End Class
End Namespace
