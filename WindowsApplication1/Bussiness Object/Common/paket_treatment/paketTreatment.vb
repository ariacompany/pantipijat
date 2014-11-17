
Namespace BussinessObject.Common
    Public Class PaketTreatment
        Private idpakettreatment As PaketTreatmentId
        Private jumlah As Int32
        Private paketSet As Paket
        Private treatmentSet As Treatment

        Sub New(ByVal idpaktreat As PaketTreatmentId, ByVal jum As Int32, ByVal paketS As Paket, ByVal treatmentS As Treatment)
            idpakettreatment = idpaktreat
            jumlah = jum
            paketSet = paketS
            treatmentSet = treatmentS
        End Sub

        Public Overridable Property eidpakettreatment() As PaketTreatmentId
            Get
                Return idpakettreatment
            End Get

            Set(ByVal value As PaketTreatmentId)
                idpakettreatment = value
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

        Public Overridable Property etreatmentset() As Treatment
            Get
                Return treatmentSet
            End Get

            Set(value As Treatment)
                treatmentSet = value
            End Set
        End Property
    End Class
End Namespace
