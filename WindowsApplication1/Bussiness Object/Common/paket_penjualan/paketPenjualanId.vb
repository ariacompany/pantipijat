Public Class PaketPenjualanId
    Private idpaket As Int32
    Private idpenjualan As Int32

    Sub New(ByVal idpak As Int32, ByVal idpen As Int32)
        idpaket = idpak
        idpenjualan = idpen
    End Sub

    Public Overridable Property eidpaket() As Int32
        Get
            Return idpaket
        End Get

        Set(ByVal value As Int32)
            idpaket = value
        End Set
    End Property

    Public Overridable Property eidpenjualan() As Int32
        Get
            Return idpenjualan
        End Get

        Set(ByVal value As Int32)
            idpenjualan = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        If IsDBNull(obj) Then
            Return False
        End If
        If Me.Equals(obj) Then
            Return True
        End If
        Dim temp As PaketPenjualanId = obj
        If IsDBNull(temp) Then
            Return False
        End If
        If idpaket <> temp.idpaket Then
            Return False
        End If
        If idpenjualan <> temp.idpenjualan Then
            Return False
        End If
        Return True
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return idpaket.GetHashCode + 27 * idpenjualan.GetHashCode
    End Function
End Class
