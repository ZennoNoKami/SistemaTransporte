Public Class V_Ventas
    Dim idboleto As Integer
    Dim nombre, edad, identidad, origen, destino, hora, tipopago, asientobus, estado As String
    Dim subtotal, impuesto, total, precio As Double
    Dim fecha As Date

    Public Property G_idboleto
        Get
            Return idboleto
        End Get
        Set(ByVal value)
            idboleto = value
        End Set
    End Property
    Public Property G_precio
        Get
            Return precio
        End Get
        Set(ByVal value)
            precio = value
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

    Public Property G_origen
        Get
            Return origen
        End Get
        Set(ByVal value)
            origen = value
        End Set
    End Property

    Public Property G_destino
        Get
            Return destino
        End Get
        Set(ByVal value)
            destino = value
        End Set
    End Property

    Public Property G_hora
        Get
            Return hora
        End Get
        Set(ByVal value)
            hora = value
        End Set
    End Property

    Public Property G_tipopago
        Get
            Return hora
        End Get
        Set(ByVal value)
            hora = value
        End Set
    End Property

    Public Property G_asientobus
        Get
            Return asientobus
        End Get
        Set(ByVal value)
            asientobus = value
        End Set
    End Property

    Public Property G_estado
        Get
            Return estado
        End Get
        Set(ByVal value)
            estado = value
        End Set
    End Property

    Public Property G_subtotal
        Get
            Return subtotal
        End Get
        Set(ByVal value)
            subtotal = value
        End Set
    End Property

    Public Property G_impuesto
        Get
            Return impuesto
        End Get
        Set(ByVal value)
            impuesto = value
        End Set
    End Property

    Public Property G_total
        Get
            Return total
        End Get
        Set(ByVal value)
            total = value
        End Set
    End Property

    Public Property G_fecha
        Get
            Return fecha
        End Get
        Set(ByVal value)
            fecha = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idfacturaencomienda As Integer, ByVal nombrecliente As String, ByVal usuario As String, ByVal fecha As Date, ByVal remitente As String, ByVal tipopago As String, ByVal descripcion As String, ByVal subtotal As Double, ByVal impuesto As Double, ByVal total As Double)

    End Sub
End Class
