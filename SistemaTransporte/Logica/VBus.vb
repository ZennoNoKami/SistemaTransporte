Public Class VBus
    Dim idautobus, cantidadasientos As Integer


    Public Property G_idautobus
        Get
            Return idautobus
        End Get
        Set(ByVal value)
            idautobus = value
        End Set
    End Property

    Public Property G_cantidadasientos
        Get
            Return cantidadasientos
        End Get
        Set(ByVal value)
            cantidadasientos = value
        End Set
    End Property

    Public Sub New(ByVal idautobus As Integer, ByVal cantidadasientos As Integer)
        G_idautobus = idautobus
        G_cantidadasientos = cantidadasientos
    End Sub
End Class
