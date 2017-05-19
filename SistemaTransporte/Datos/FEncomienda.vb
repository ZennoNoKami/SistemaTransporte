Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Public Class FEncomienda
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            Conectado()

            cmd = New SqlCommand("mostrar_encomienda")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

    Public Function Insertar(ByVal dts As VEncomienda)
        Try
            Conectado()
            cmd = New SqlCommand("insertar_encomienda")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@idfacturacliente", dts.G_idfacturacliente)
            cmd.Parameters.AddWithValue("@nombreclienre", dts.G_nombrecliente)
            cmd.Parameters.AddWithValue("@usuario", dts.G_usuario)
            cmd.Parameters.AddWithValue("@fecha", dts.G_fecha)
            cmd.Parameters.AddWithValue("@remitente", dts.G_remitente)
            cmd.Parameters.AddWithValue("@tipopago", dts.G_tipopago)
            cmd.Parameters.AddWithValue("@subtotal", dts.G_subtotal)
            cmd.Parameters.AddWithValue("@impuesto", dts.G_impuesto)
            cmd.Parameters.AddWithValue("@total", dts.G_total)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function


    Public Function Editar(ByVal dts As VEncomienda)
        Try
            Conectado()
            cmd = New SqlCommand("editar_encomienda")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idfacturacliente", dts.G_idfacturaencomienda)
            cmd.Parameters.AddWithValue("@nombreclienre", dts.G_nombrecliente)
            cmd.Parameters.AddWithValue("@usuario", dts.G_usuario)
            cmd.Parameters.AddWithValue("@fecha", dts.G_fecha)
            cmd.Parameters.AddWithValue("@remitente", dts.G_remitente)
            cmd.Parameters.AddWithValue("@tipopago", dts.G_tipopago)
            cmd.Parameters.AddWithValue("@subtotal", dts.G_subtotal)
            cmd.Parameters.AddWithValue("@impuesto", dts.G_impuesto)
            cmd.Parameters.AddWithValue("@total", dts.G_total)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
    Public Function Eliminar(ByVal dts As VEncomienda)
        Try
            Conectado()
            cmd = New SqlCommand("eliminar_encomienda")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idfacturaencomienda", dts.G_idfacturaencomienda)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
End Class
