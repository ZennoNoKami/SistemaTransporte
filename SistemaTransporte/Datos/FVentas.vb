Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Public Class FVentas
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            Conectado()

            cmd = New SqlCommand("mostrar_ventas")
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
    Public Function Insertar(ByVal dts As V_Ventas)
        Try
            Conectado()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.G_nombre)
            cmd.Parameters.AddWithValue("@edad", dts.G_edad)
            cmd.Parameters.AddWithValue("@identidad", dts.G_identidad)
            cmd.Parameters.AddWithValue("@origen", dts.G_origen)
            cmd.Parameters.AddWithValue("@destino", dts.G_destino)
            cmd.Parameters.AddWithValue("@hora", dts.G_hora)
            cmd.Parameters.AddWithValue("@fecha", dts.G_fecha)
            cmd.Parameters.AddWithValue("@precio", dts.G_precio)
            cmd.Parameters.AddWithValue("@tipopago", dts.G_tipopago)
            cmd.Parameters.AddWithValue("@subtotal", dts.G_subtotal)
            cmd.Parameters.AddWithValue("@impuesto", dts.G_impuesto)
            cmd.Parameters.AddWithValue("@total", dts.G_total)
            cmd.Parameters.AddWithValue("@asientobus", dts.G_asientobus)
            cmd.Parameters.AddWithValue("@estado", dts.G_estado)

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
    Public Function Cancelar(ByVal dts As V_Ventas)
        Try
            Conectado()
            cmd = New SqlCommand("cancelar_boleto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idboleto", dts.G_idboleto)
            cmd.Parameters.AddWithValue("@estado", dts.G_estado)

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
