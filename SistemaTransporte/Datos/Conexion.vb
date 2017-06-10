Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class Conexion
    Protected cnn As New SqlConnection

    Protected cnx As New OdbcConnection
    Dim linea As String = "DSN=Transportes;Uid=sa;pwd=;"

    Protected Function Conectado() As Boolean
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-MGVUJ1F;Initial Catalog=Transporte;Integrated Security=True")
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

    Protected Function Conectar() As Boolean
        Try
            If cnx.State = ConnectionState.Closed Then
                cnx.ConnectionString = linea
                cnx.Open()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Protected Function Desconectar() As Boolean
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
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
