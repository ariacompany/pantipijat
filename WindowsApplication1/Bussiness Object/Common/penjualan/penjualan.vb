
Namespace BussinessObject.Common
    Public Class Penjualan
        Private paketpenjualan As NHibernate.Collection.PersistentSet

        Sub New(ByVal pakpen As NHibernate.Collection.PersistentSet)
            paketpenjualan = pakpen
        End Sub

        Public Overridable Property epaketpenjualan() As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketPenjualan)
            Get
                Return paketpenjualan
            End Get
            Set(value As NHibernate.Collection.Generic.PersistentGenericSet(Of PaketPenjualan))
                paketpenjualan = value
            End Set
        End Property
    End Class
End Namespace
