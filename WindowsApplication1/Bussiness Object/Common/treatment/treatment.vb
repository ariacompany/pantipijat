
Namespace BussinessObject.Common
    Public Class Treatment
        Private pakettreatment As NHibernate.Collection.PersistentSet

        Sub New(ByVal paktreat As NHibernate.Collection.PersistentSet)
            pakettreatment = paktreat
        End Sub

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
