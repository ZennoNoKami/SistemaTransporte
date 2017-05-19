Imports System.Data.SqlClient
Public Class FCiudades
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function Mostrar() As DataTable
        Try
            Conectado()

            cmd = New SqlCommand("mostrar_ciudad")
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

    Public Function Insertar(ByVal dts As VCiudades)
        Try
            Conectado()
            cmd = New SqlCommand("insertar_ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@ciudad", dts.G_ciudad)

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

    Public Function Eliminar(ByVal dts As VCiudades)
        Try
            Conectado()
            cmd = New SqlCommand("eliminar_ciudad") '''''''''''''''''''''''''''''''''''
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idciudad", dts.G_idCiudad)

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

    Public Function Editar(ByVal dts As VCiudades)
        Try
            Conectado()
            cmd = New SqlCommand("editar_ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idciudad", dts.G_idCiudad)
            cmd.Parameters.AddWithValue("@ciudad", dts.G_ciudad)

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

    Public Function Buscar(ByVal dts As VCiudades)
        Try
            Conectado()
            cmd = New SqlCommand("buscar_ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@op", dts.G_op)
            cmd.Parameters.AddWithValue("@idciudad", dts.G_idCiudad)
            cmd.Parameters.AddWithValue("@ciudad", dts.G_ciudad)


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
            Return False
        Finally
            Desconectado()
        End Try
    End Function

End Class
