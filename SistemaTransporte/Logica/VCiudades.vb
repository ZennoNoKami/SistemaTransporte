Public Class VCiudades
    Dim idCiudad, op As Integer
    Dim ciudad As String

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Property G_op
        Get
            Return op
        End Get
        Set(ByVal value)
            op = value
        End Set
    End Property

    Public Property G_idCiudad
        Get
            Return idCiudad
        End Get
        Set(ByVal value)
            idCiudad = value
        End Set
    End Property

    Public Property G_ciudad
        Get
            Return ciudad
        End Get
        Set(ByVal value)
            ciudad = value
        End Set
    End Property

    Public Sub New(ByVal op As Integer, ByVal idCiudad As Integer, ByVal ciudad As String)
        G_op = op
        G_idCiudad = idCiudad
        G_ciudad = ciudad
    End Sub

End Class
