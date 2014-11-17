
Namespace BussinessObject.Common
    Public Class booking
        Private idbooking As Int32
        Private tglbooking As Date
        Private info As String
        Private isdelete As Boolean

        Sub New(ByVal idbook As Int32, ByVal tglbook As Date, ByVal inf As String, ByVal isdel As Boolean)
            idbooking = idbook
            tglbooking = tglbook
            info = inf
            isdelete = isdel
        End Sub

        Public Overridable Property eidbooking() As Int32
            Get
                Return idbooking
            End Get

            Set(ByVal value As Int32)
                idbooking = value
            End Set
        End Property

        Public Overridable Property etglbooking() As Date
            Get
                Return tglbooking
            End Get

            Set(ByVal value As Date)
                tglbooking = value
            End Set
        End Property

        Public Overridable Property einfo() As String
            Get
                Return info
            End Get

            Set(ByVal value As String)
                info = value
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
    End Class
End Namespace
