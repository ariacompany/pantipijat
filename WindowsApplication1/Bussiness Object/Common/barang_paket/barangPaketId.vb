Namespace BussinessObject.Common
    Public Class BarangPaketId
        Private idbarang As Int32
        Private idpaket As Int32

        Sub New(ByVal idbar As Int32, ByVal idpak As Int32)
            idbarang = idbar
            idpaket = idpak
        End Sub

        Public Overridable Property eidbarang() As Int32
            Get
                Return idbarang
            End Get

            Set(ByVal value As Int32)
                idbarang = value
            End Set
        End Property

        Public Overridable Property eidpaket() As Int32
            Get
                Return idpaket
            End Get

            Set(ByVal value As Int32)
                idpaket = value
            End Set
        End Property

        Public Overrides Function Equals(obj As Object) As Boolean
            If IsDBNull(obj) Then
                Return False
            End If
            If Me.Equals(obj) Then
                Return True
            End If
            Dim temp As BarangPaketId = obj
            If IsDBNull(temp) Then
                Return False
            End If
            If idbarang <> temp.idbarang Then
                Return False
            End If
            If idpaket <> temp.idpaket Then
                Return False
            End If
            Return True
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return idbarang.GetHashCode + 27 * idpaket.GetHashCode
        End Function
    End Class
End Namespace
