Public Class VClientes
    Dim idcliente, by As Integer
    Dim nombre, edad, identidad, telefono, email, direccion As String


    Public Property G_by
        Get
            Return by
        End Get
        Set(ByVal value)
            by = value
        End Set
    End Property

    Public Property G_idcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property

    Public Property G_nombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property G_edad
        Get
            Return edad
        End Get
        Set(ByVal value)
            edad = value
        End Set
    End Property

    Public Property G_identidad
        Get
            Return identidad
        End Get
        Set(ByVal value)
            identidad = value
        End Set
    End Property

    Public Property G_telefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property G_email
        Get
            Return email
        End Get
        Set(ByVal value)
            email = value
        End Set
    End Property

    Public Property G_direccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal edad As String, ByVal identidad As String, ByVal telefono As String, ByVal email As String, ByVal direccion As String)
        G_by = by
        G_idcliente = idcliente
        G_nombre = nombre
        G_edad = edad
        G_identidad = identidad
        G_telefono = telefono
        G_email = email
        G_direccion = direccion
    End Sub


End Class
