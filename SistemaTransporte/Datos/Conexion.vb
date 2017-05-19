Imports System.Data.SqlClient

Public Class Conexion
    Protected cnn As New SqlConnection

    Protected Function Conectado() As Boolean
        Try
            cnn = New SqlConnection("data source=DESKTOP-MGVUJ1F;initial catalog=Transporte;integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Protected Function Desconectado() As Boolean
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function


End Class
