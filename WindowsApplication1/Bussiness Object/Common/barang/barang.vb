
Namespace BussinessObject.Common
    Public Class Barang
        Private idbarang As Int32
        Private namabarang As String
        Private stokbarang As Int32
        Private inventaris As Boolean
        Private hargaperkiraan As Decimal
        Private hargajual As Decimal
        Private isdelete As Boolean
        Private barangpaket As NHibernate.Collection.PersistentSet

        Sub New(ByVal idbar As Int32, ByVal namabar As String, ByVal stokbar As Int32, ByVal inventar As Boolean, ByVal hargaper As Decimal, ByVal hargaj As Decimal, ByVal isdel As Boolean, ByVal barangp As NHibernate.Collection.PersistentSet)
            idbarang = idbar
            namabarang = namabar
            stokbarang = stokbar
            inventar = inventar
            hargaperkiraan = hargaper
            hargajual = hargaj
            isdelete = isdel
            barangpaket = barangp
        End Sub

        Public Overridable Property eidbarang As Int32
            Get
                Return idbarang
            End Get

            Set(ByVal value As Int32)
                idbarang = value
            End Set
        End Property

        Public Overridable Property enamabarang As String
            Get
                Return namabarang
            End Get

            Set(ByVal value As String)
                namabarang = value
            End Set
        End Property

        Public Overridable Property estokbarang() As Int32
            Get
                Return stokbarang
            End Get

            Set(ByVal value As Int32)
                stokbarang = value
            End Set
        End Property

        Public Overridable Property einventaris As Boolean
            Get
                Return inventaris
            End Get

            Set(ByVal value As Boolean)
                inventaris = value
            End Set
        End Property

        Public Overridable Property ehargaperkiraan As Decimal
            Get
                Return hargaperkiraan
            End Get

            Set(ByVal value As Decimal)
                hargaperkiraan = value
            End Set
        End Property

        Public Overridable Property ehargajual As Decimal
            Get
                Return hargajual
            End Get

            Set(ByVal value As Decimal)
                hargajual = value
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

        Public Overridable Property ebarangpaket() As NHibernate.Collection.Generic.PersistentGenericSet(Of BarangPaket)
            Get
                Return barangpaket
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of BarangPaket))
                barangpaket = value
            End Set
        End Property
    End Class
End Namespace
