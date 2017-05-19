Public Class VItinerario
    Dim iditinerario, idautobus, by As Integer
    Dim horasalida, horallegada, origen, destino As String
    Dim precio, precioencomienda As Double

    Public Property G_by
        Get
            Return by
        End Get
        Set(ByVal value)
            by = value
        End Set
    End Property

    Public Property G_iditinerario
        Get
            Return iditinerario
        End Get
        Set(value)
            iditinerario = value
        End Set
    End Property


    Public Property G_horasalida
        Get
            Return horasalida
        End Get
        Set(value)
            horasalida = value
        End Set
    End Property

    Public Property G_horallegada
        Get
            Return horallegada
        End Get
        Set(value)
            horallegada = value
        End Set
    End Property

    Public Property G_origen
        Get
            Return origen
        End Get
        Set(value)
            origen = value
        End Set
    End Property

    Public Property G_destino
        Get
            Return destino
        End Get
        Set(value)
            destino = value
        End Set
    End Property


    Public Property G_idautobus
        Get
            Return idautobus
        End Get
        Set(value)
            idautobus = value
        End Set
    End Property


    Public Property G_precio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property


    Public Property G_precioencomienda
        Get
            Return precioencomienda
        End Get
        Set(value)
            precioencomienda = value
        End Set
    End Property

    Public Sub New(ByVal iditinerario As Integer, ByVal horasalida As String, ByVal horallegada As String, ByVal origen As String, ByVal destino As String, ByVal idautobus As String, ByVal precio As Double, ByVal precioencomienda As Double)
        G_by = by
        G_iditinerario = iditinerario
        G_horasalida = horasalida
        G_horallegada = horallegada
        G_origen = origen
        G_destino = destino
        G_idautobus = idautobus
        G_precio = precio
        G_precioencomienda = precioencomienda
    End Sub

    Public Sub New()

    End Sub



End Class
