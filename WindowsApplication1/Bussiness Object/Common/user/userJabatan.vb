
Namespace BussinessObject.Common
    Public Class userJabatan
        Private tempUser As User

        Sub New(ByVal u As User)
            tempUser = u
        End Sub

        Public Overridable Property eiduser() As Int32
            Get
                Return tempUser.eiduser
            End Get

            Set(ByVal value As Int32)
                tempUser.eiduser = value
            End Set
        End Property

        Public Overridable Property eusername() As String
            Get
                Return tempUser.eusername
            End Get

            Set(ByVal value As String)
                tempUser.eusername = value
            End Set
        End Property

        Public Overridable Property epass() As String
            Get
                Return tempUser.epass
            End Get

            Set(ByVal value As String)
                tempUser.epass = value
            End Set
        End Property

        Public Overridable Property enama() As String
            Get
                Return tempUser.enama
            End Get

            Set(ByVal value As String)
                tempUser.enama = value
            End Set
        End Property

        Public Overridable Property ealamat() As String
            Get
                Return tempUser.ealamat
            End Get

            Set(ByVal value As String)
                tempUser.ealamat = value
            End Set
        End Property

        Public Overridable Property ekomisi() As Int32
            Get
                Return tempUser.ekomisi
            End Get

            Set(ByVal value As Int32)
                tempUser.ekomisi = value
            End Set
        End Property

        Public Overridable Property enoktp() As String
            Get
                Return tempUser.enoktp
            End Get

            Set(ByVal value As String)
                tempUser.enoktp = value
            End Set
        End Property

        Public Overridable Property ejeniskelamin() As Char
            Get
                Return tempUser.ejeniskelamin
            End Get

            Set(ByVal value As Char)
                tempUser.ejeniskelamin = value
            End Set
        End Property

        Public Overridable Property etelepon() As String
            Get
                Return tempUser.etelepon
            End Get

            Set(ByVal value As String)
                tempUser.etelepon = value
            End Set
        End Property

        Public Overridable Property eagama() As String
            Get
                Return tempUser.eagama
            End Get

            Set(ByVal value As String)
                tempUser.eagama = value
            End Set
        End Property

        Public Overridable Property eisdeleteuser() As Boolean
            Get
                Return tempUser.eisdelete
            End Get

            Set(ByVal value As Boolean)
                tempUser.eisdelete = value
            End Set
        End Property

        Public Overridable Property eidjabatan() As Int32
            Get
                Return tempUser.eidjabatan.eidjabatan
            End Get

            Set(ByVal value As Int32)
                tempUser.eidjabatan.eidjabatan = value
            End Set
        End Property

        Public Overridable Property enamajabatan() As String
            Get
                Return tempUser.eidjabatan.enamajabatan
            End Get

            Set(ByVal value As String)
                tempUser.eidjabatan.enamajabatan = value
            End Set
        End Property

        Public Overridable Property ekomisijabatan() As Int32
            Get
                Return tempUser.eidjabatan.ekomisijabatan
            End Get

            Set(ByVal value As Int32)
                tempUser.eidjabatan.ekomisijabatan = value
            End Set
        End Property

        Public Overridable Property eisdeletejabatan() As Boolean
            Get
                Return tempUser.eidjabatan.eisdelete
            End Get

            Set(ByVal value As Boolean)
                tempUser.eidjabatan.eisdelete = value
            End Set
        End Property

    End Class
End Namespace

