Public Class JabatanMenuId
    Private idjabatan As Int32
    Private idmenu As Int32

    Sub New(ByVal idjab As Int32, ByVal idmen As Int32)
        idjabatan = idjab
        idmenu = idmen
    End Sub

    Public Overridable Property eidjabatan() As Int32
        Get
            Return idjabatan
        End Get

        Set(ByVal value As Int32)
            idjabatan = value
        End Set
    End Property

    Public Overridable Property eidmenu() As Int32
        Get
            Return idmenu
        End Get

        Set(ByVal value As Int32)
            idmenu = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        If IsDBNull(obj) Then
            Return False
        End If
        If Me.Equals(obj) Then
            Return True
        End If
        Dim temp As JabatanMenuId = obj
        If IsDBNull(temp) Then
            Return False
        End If
        If idjabatan <> temp.idjabatan Then
            Return False
        End If
        If idmenu <> temp.idmenu Then
            Return False
        End If
        Return True
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return idjabatan.GetHashCode + 27 * idmenu.GetHashCode
    End Function
End Class
