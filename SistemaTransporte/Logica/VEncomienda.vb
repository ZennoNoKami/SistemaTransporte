Public Class VEncomienda
    Dim idfacturaencomienda As Integer
    Dim nombrecliente, usuario, remitente, tipopago, descripcion As String
    Dim subtotal, impuesto, total As Double
    Dim fecha As Date
    Public Property G_idfacturaencomienda
        Get
            Return idfacturaencomienda
        End Get
        Set(ByVal value)
            idfacturaencomienda = value
        End Set
    End Property

    Public Property G_nombrecliente
        Get
            Return nombrecliente
        End Get
        Set(ByVal value)
            nombrecliente = value
        End Set
    End Property

    Public Property G_usuario
        Get
            Return usuario
        End Get
        Set(ByVal value)
            usuario = value
        End Set
    End Property

    Public Property G_remitente
        Get
            Return remitente
        End Get
        Set(ByVal value)
            remitente = value
        End Set
    End Property

    Public Property G_tipopago
        Get
            Return tipopago
        End Get
        Set(ByVal value)
            tipopago = value
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

    Public Property G_descripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
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
        G_idfacturaencomienda = idfacturaencomienda
        G_nombrecliente = nombrecliente
        G_usuario = usuario
        G_fecha = fecha
        G_remitente = remitente
        G_tipopago = tipopago
        G_descripcion = descripcion
        G_subtotal = subtotal
        G_impuesto = impuesto
        G_total = total
    End Sub
End Class
