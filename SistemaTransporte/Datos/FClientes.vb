Imports System.Data.SqlClient

Public Class FClientes
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function Mostrar() As DataTable
        Try
            Conectado()

            cmd = New SqlCommand("mostrar_clientes")
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

    Public Function Buscar(ByVal dts As VClientes)
        Try
            Conectado()
            cmd = New SqlCommand("buscar_clientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@BY", dts.G_by)
            cmd.Parameters.AddWithValue("@IDCLIENTE", dts.G_idcliente)
            cmd.Parameters.AddWithValue("@NOMBRE", dts.G_nombre)
            cmd.Parameters.AddWithValue("@IDENTIDAD", dts.G_identidad)

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

    Public Function Insertar(ByVal dts As VClientes)
        Try
            Conectado()
            cmd = New SqlCommand("insertar_clientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@idcliente", dts.G_idcliente)
            cmd.Parameters.AddWithValue("@nombre", dts.G_nombre)
            cmd.Parameters.AddWithValue("@edad", dts.G_edad)
            cmd.Parameters.AddWithValue("@identidad", dts.G_identidad)
            cmd.Parameters.AddWithValue("@telefono", dts.G_telefono)
            cmd.Parameters.AddWithValue("@email", dts.G_email)
            cmd.Parameters.AddWithValue("@direccion", dts.G_direccion)

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

    Public Function Editar(ByVal dts As VClientes)
        Try
            Conectado()
            cmd = New SqlCommand("editar_clientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcliente", dts.G_idcliente)
            cmd.Parameters.AddWithValue("@nombre", dts.G_nombre)
            cmd.Parameters.AddWithValue("@edad", dts.G_edad)
            cmd.Parameters.AddWithValue("@identidad", dts.G_identidad)
            cmd.Parameters.AddWithValue("@telefono", dts.G_telefono)
            cmd.Parameters.AddWithValue("@email", dts.G_email)
            cmd.Parameters.AddWithValue("@direccion", dts.G_direccion)

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

    Public Function Eliminar(ByVal dts As VClientes)
        Try
            Conectado()
            cmd = New SqlCommand("eliminar_clientes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcliente", dts.G_idcliente)

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
