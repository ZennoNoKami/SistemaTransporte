Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Public Class FUsuario
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function Mostrar() As DataTable
        Try
            Conectado()

            cmd = New SqlCommand("mostrar_usuarios")
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

    Public Function Insertar(ByVal dts As VUsuario)
        Try
            Conectado()
            cmd = New SqlCommand("insertar_usuarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@id", dts.G_id)
            cmd.Parameters.AddWithValue("@USUARIO", dts.G_usuario)
            cmd.Parameters.AddWithValue("@PWD", dts.G_pwd)
            cmd.Parameters.AddWithValue("@NOMBRE", dts.G_nombre)
            cmd.Parameters.AddWithValue("@ADM", dts.G_admin)
            cmd.Parameters.AddWithValue("@EMAIL", dts.G_email)

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


    Public Function Editar(ByVal dts As VUsuario)
        Try
            Conectado()
            cmd = New SqlCommand("editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id", dts.G_id)
            cmd.Parameters.AddWithValue("@usuario", dts.G_usuario)
            cmd.Parameters.AddWithValue("@pwd", dts.G_pwd)
            cmd.Parameters.AddWithValue("@nombre", dts.G_nombre)
            cmd.Parameters.AddWithValue("@adm", dts.G_admin)
            cmd.Parameters.AddWithValue("@email", dts.G_email)

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

    Public Function Eliminar(ByVal dts As VUsuario)
        Try
            Conectado()
            cmd = New SqlCommand("eliminar_usuarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id", dts.G_id)

            If dts.G_id = RetData() Then
                MessageBoxEx.Show("No puedes eliminar tu propio usuario")
                Return False
            Else
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function

    Public Function Verificar_Usuario(ByVal dts As VUsuario)
        Try
            Conectado()

            cmd = New SqlCommand("aunt_user")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@usuario", dts.G_usuario)

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

End Class
