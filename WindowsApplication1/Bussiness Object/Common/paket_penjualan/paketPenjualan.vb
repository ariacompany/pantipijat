
Namespace BussinessObject.Common
    Public Class PaketPenjualan
        Private idpaketpenjualan As PaketPenjualanId
        Private harga As Decimal
        Private jumlah As Int32
        Private paketSet As Paket
        Private penjualanSet As Penjualan

        Sub New(ByVal idpakpen As PaketPenjualanId, ByVal har As Decimal, ByVal jum As Int32, ByVal paketS As Paket, ByVal PenS As Penjualan)
            idpaketpenjualan = idpakpen
            harga = har
            jumlah = jum
            paketSet = paketS
            penjualanSet = PenS
        End Sub

        Public Overridable Property eidpaketpenjualan() As PaketPenjualanId
            Get
                Return idpaketpenjualan
            End Get

            Set(ByVal value As PaketPenjualanId)
                idpaketpenjualan = value
            End Set
        End Property

        Public Overridable Property eharga() As Decimal
            Get
                Return harga
            End Get

            Set(value As Decimal)
                harga = value
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

        Public Overridable Property epaketset() As Paket
            Get
                Return paketSet
            End Get

            Set(ByVal value As Paket)
                paketSet = value
            End Set
        End Property

        Public Overridable Property epenjualanset() As Penjualan
            Get
                Return penjualanSet
            End Get

            Set(value As Penjualan)
                penjualanSet = value
            End Set
        End Property
    End Class
End Namespace
