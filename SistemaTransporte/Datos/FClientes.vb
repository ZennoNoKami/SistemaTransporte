Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class FClientes
    Inherits Conexion
    'Dim cmd As New SqlCommand
    Dim cmd As New OdbcCommand

    Public Function Mostrar() As DataTable
        Try
            Conectar()

            cmd = New OdbcCommand("mostrar_clientes") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New OdbcDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    'Public Function Mostrar() As DataTable
    '    Try
    '        Conectado()

    '        cmd = New SqlCommand("mostrar_clientes")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn

    '        If cmd.ExecuteNonQuery Then
    '            Dim dt As New DataTable
    '            Dim da As New SqlDataAdapter(cmd)
    '            da.Fill(dt)
    '            Return dt
    '        Else
    '            Return Nothing
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Return Nothing
    '    Finally
    '        Desconectado()
    '    End Try
    'End Function

    Public Function Buscar(ByVal dts As VClientes)
        Try
            Conectar()
            cmd = New OdbcCommand("buscar_clientes") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }

            cmd.Parameters.AddWithValue("@BY", dts.G_by)
            cmd.Parameters.AddWithValue("@IDCLIENTE", dts.G_idcliente)
            cmd.Parameters.AddWithValue("@NOMBRE", dts.G_nombre)
            cmd.Parameters.AddWithValue("@IDENTIDAD", dts.G_identidad)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New OdbcDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Insertar(ByVal dts As VClientes)
        Try
            Conectar()
            cmd = New OdbcCommand("{call insertar_clientes(?,?,?,?,?,?)}") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }

            cmd.Parameters.Add(New OdbcParameter("@nombre", OdbcType.NVarChar, 50))
            cmd.Parameters("@nombre").Value = dts.G_nombre
            cmd.Parameters.Add(New OdbcParameter("@edad", OdbcType.NVarChar, 2))
            cmd.Parameters("@edad").Value = dts.G_edad
            cmd.Parameters.Add(New OdbcParameter("@identidad", OdbcType.NVarChar, 15))
            cmd.Parameters("@identidad").Value = dts.G_identidad
            cmd.Parameters.Add(New OdbcParameter("@telefono", OdbcType.NVarChar, 9))
            cmd.Parameters("@telefono").Value = dts.G_telefono
            cmd.Parameters.Add(New OdbcParameter("@email", OdbcType.NVarChar, 150))
            cmd.Parameters("@email").Value = dts.G_email
            cmd.Parameters.Add(New OdbcParameter("@direccion", OdbcType.NVarChar, 250))
            cmd.Parameters("@direccion").Value = dts.G_direccion

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Editar(ByVal dts As VClientes)
        Try
            Conectar()
            cmd = New OdbcCommand("{call editar_clientes(?,?,?,?,?,?,?)}") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }

            cmd.Parameters.Add(New OdbcParameter("@idcliente", OdbcType.Int))
            cmd.Parameters("@idcliente").Value = dts.G_idcliente
            cmd.Parameters.Add(New OdbcParameter("@nombre", OdbcType.NVarChar, 50))
            cmd.Parameters("@nombre").Value = dts.G_nombre
            cmd.Parameters.Add(New OdbcParameter("@edad", OdbcType.NVarChar, 2))
            cmd.Parameters("@edad").Value = dts.G_edad
            cmd.Parameters.Add(New OdbcParameter("@identidad", OdbcType.NVarChar, 15))
            cmd.Parameters("@identidad").Value = dts.G_identidad
            cmd.Parameters.Add(New OdbcParameter("@telefono", OdbcType.NVarChar, 9))
            cmd.Parameters("@telefono").Value = dts.G_telefono
            cmd.Parameters.Add(New OdbcParameter("@email", OdbcType.NVarChar, 150))
            cmd.Parameters("@email").Value = dts.G_email
            cmd.Parameters.Add(New OdbcParameter("@direccion", OdbcType.NVarChar, 250))
            cmd.Parameters("@direccion").Value = dts.G_direccion

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Eliminar(ByVal dts As VClientes)
        Try
            Conectar()
            cmd = New OdbcCommand("{call eliminar_clientes(?)}") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }

            cmd.Parameters.Add(New OdbcParameter("@idcliente", OdbcType.Int))
            cmd.Parameters("@idcliente").Value = dts.G_idcliente

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function


End Class
