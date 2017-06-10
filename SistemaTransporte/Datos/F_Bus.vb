Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Public Class F_Bus
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            Conectado()

            cmd = New SqlCommand("mostrar_bus")
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
    Public Function Insertar(ByVal dts As VBus)
        Try
            Conectado()
            cmd = New SqlCommand("insertar_bus")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@id", dts.G_id)
            cmd.Parameters.AddWithValue("@cantidadasientos", dts.G_cantidadasientos)

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


    Public Function Editar(ByVal dts As VBus)
        Try
            Conectado()
            cmd = New SqlCommand("editar_bus")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idautobus", dts.G_idautobus)
            cmd.Parameters.AddWithValue("@cantidadasientos", dts.G_cantidadasientos)

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

    Public Function Eliminar(ByVal dts As VBus)
        Try
            Conectado()
            cmd = New SqlCommand("eliminar_bus")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idautobus", dts.G_idautobus)

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
