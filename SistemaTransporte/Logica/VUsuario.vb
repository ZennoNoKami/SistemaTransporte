﻿Public Class VUsuario
    Dim id As Integer
    Dim usuario, pwd, nombre, email As String
    Dim admin, estado As Boolean

    Public Property G_id
        Get
            Return id
        End Get
        Set(ByVal value)
            id = value
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

    Public Property G_pwd
        Get
            Return pwd
        End Get
        Set(ByVal value)
            pwd = value
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

    Public Property G_email
        Get
            Return email
        End Get
        Set(ByVal value)
            email = value
        End Set
    End Property

    Public Property G_admin
        Get
            Return admin
        End Get
        Set(ByVal value)
            admin = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal usuario As String, ByVal pwd As String, ByVal nombre As String, ByVal admin As Boolean, ByVal estado As Boolean)
        G_id = id
        G_usuario = usuario
        G_pwd = pwd
        G_nombre = nombre
        G_admin = admin
        G_estado = estado
    End Sub
End Class
