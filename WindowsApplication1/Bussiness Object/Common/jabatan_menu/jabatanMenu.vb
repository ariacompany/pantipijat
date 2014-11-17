
Namespace BussinessObject.Common
    Public Class JabatanMenu
        Private idjabatanmenu As JabatanMenuId
        Private jabatanSet As Jabatan
        Private menuSet As Menu

        Sub New(ByVal idjabmen As JabatanMenuId, ByVal jabset As Jabatan, ByVal menset As Menu)
            idjabatanmenu = idjabmen
            jabatanSet = jabset
            menuSet = menset
        End Sub

        Public Overridable Property eidjabatanmenu() As JabatanMenuId
            Get
                Return idjabatanmenu
            End Get

            Set(ByVal value As JabatanMenuId)
                idjabatanmenu = value
            End Set
        End Property

        Public Overridable Property ejabatanset() As Jabatan
            Get
                Return jabatanSet
            End Get

            Set(ByVal value As Jabatan)
                jabatanSet = value
            End Set
        End Property

        Public Overridable Property emenuset() As Menu
            Get
                Return menuSet
            End Get

            Set(value As Menu)
                menuSet = value
            End Set
        End Property
    End Class
End Namespace
