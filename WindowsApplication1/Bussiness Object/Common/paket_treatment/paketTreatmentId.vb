Public Class PaketTreatmentId
    Private idpaket As Int32
    Private idtreatment As Int32

    Sub New(ByVal idpak As Int32, ByVal idtreat As Int32)
        idpaket = idpak
        idtreatment = idtreat
    End Sub

    Public Overridable Property eidpaket() As Int32
        Get
            Return idpaket
        End Get

        Set(ByVal value As Int32)
            idpaket = value
        End Set
    End Property

    Public Overridable Property eidtreatment() As Int32
        Get
            Return idtreatment
        End Get

        Set(ByVal value As Int32)
            idtreatment = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        If IsDBNull(obj) Then
            Return False
        End If
        If Me.Equals(obj) Then
            Return True
        End If
        Dim temp As PaketTreatmentId = obj
        If IsDBNull(temp) Then
            Return False
        End If
        If idpaket <> temp.idpaket Then
            Return False
        End If
        If idtreatment <> temp.idtreatment Then
            Return False
        End If
        Return True
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return idpaket.GetHashCode + 27 * idtreatment.GetHashCode
    End Function
End Class
