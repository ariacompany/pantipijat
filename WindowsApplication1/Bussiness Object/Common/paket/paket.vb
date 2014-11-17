
Namespace BussinessObject.Common
    Public Class Paket
        Private idpaket As Int32
        Private namapaket As String
        Private hargapaket As Decimal
        Private aktif As Boolean
        Private isdelete As Boolean
        Private barangpaket As NHibernate.Collection.PersistentSet
        Private paketpenjualan As NHibernate.Collection.PersistentSet
        Private pakettreatment As NHibernate.Collection.PersistentSet

        Sub New(ByVal idpak As Int32, ByVal namapak As String, ByVal hargapak As Decimal, ByVal akt As Boolean, ByVal isdel As Boolean, ByVal barpak As NHibernate.Collection.PersistentSet, ByVal pakpen As NHibernate.Collection.PersistentSet, ByVal paktreat As NHibernate.Collection.PersistentSet)
            idpaket = idpak
            namapaket = namapak
            hargapaket = hargapak
            aktif = akt
            isdelete = isdel
            barangpaket = barpak
            paketpenjualan = pakpen
            pakettreatment = paktreat
        End Sub

        Public Overridable Property eidpaket As Int32
            Get
                Return idpaket
            End Get

            Set(ByVal value As Int32)
                idpaket = value
            End Set
        End Property

        Public Overridable Property enamapaket As String
            Get
                Return namapaket
            End Get

            Set(ByVal value As String)
                namapaket = value
            End Set
        End Property

        Public Overridable Property ehargapaket As Decimal
            Get
                Return hargapaket
            End Get

            Set(ByVal value As Decimal)
                hargapaket = value
            End Set
        End Property

        Public Overridable Property eaktif As Decimal
            Get
                Return aktif
            End Get

            Set(ByVal value As Decimal)
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

        Public Overridable Property ebarangpaket() As NHibernate.Collection.Generic.PersistentGenericSet(Of BarangPaket)
            Get
                Return barangpaket
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of BarangPaket))
                barangpaket = value
            End Set
        End Property

        Public Overridable Property epaketpenjualan() As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketPenjualan)
            Get
                Return paketpenjualan
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketPenjualan))
                paketpenjualan = value
            End Set
        End Property

        Public Overridable Property epakettreatment() As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketTreatment)
            Get
                Return pakettreatment
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketTreatment))
                pakettreatment = value
            End Set
        End Property
    End Class
End Namespace
