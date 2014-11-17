Namespace BussinessObject.Common
    Public Class BarangPaket
        Private idbarangpaket As BarangPaketId
        Private jumlah As Int32
        Private barangSet As Barang
        Private paketSet As Paket

        Sub New(ByVal idbarpak As BarangPaketId, ByVal jum As Int32, ByVal barangS As Barang, ByVal paketS As Paket)
            idbarangpaket = idbarpak
            jumlah = jum
            barangSet = barangS
            paketSet = paketS
        End Sub

        Public Overridable Property eidbarangpaket() As BarangPaketId
            Get
                Return idbarangpaket
            End Get

            Set(ByVal value As BarangPaketId)
                idbarangpaket = value
            End Set
        End Property

        Public Overridable Property ejumlah() As Int32
            Get
                Return jumlah
            End Get

            Set(value As Int32)
                jumlah = value
            End Set
        End Property

        Public Overridable Property ebarangset() As Barang
            Get
                Return barangSet
            End Get

            Set(ByVal value As Barang)
                barangSet = value
            End Set
        End Property

        Public Overridable Property epaketset() As Paket
            Get
                Return paketSet
            End Get

            Set(value As Paket)
                paketSet = value
            End Set
        End Property
    End Class
End Namespace
