Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports System.Data.Odbc

Public Class FUsuario
    Inherits Conexion
    Dim cmd As New OdbcCommand
    Public Function Mostrar() As DataTable
        Try
            Conectar()

            cmd = New OdbcCommand("mostrar_usuarios") With {
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

    Public Function Insertar(ByVal dts As VUsuario)
        Try
            Conectar()
            cmd = New OdbcCommand("{call insertar_usuarios(?,?,?,?,?)}") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }


            cmd.Parameters.Add(New OdbcParameter("@Usuario", OdbcType.VarChar, 50))
            cmd.Parameters("@Usuario").Value = dts.G_usuario
            cmd.Parameters.Add(New OdbcParameter("@Pwd", OdbcType.VarChar, 250))
            cmd.Parameters("@Pwd").Value = dts.G_pwd
            cmd.Parameters.Add(New OdbcParameter("@Nombre", OdbcType.VarChar, 150))
            cmd.Parameters("@Nombre").Value = dts.G_nombre
            cmd.Parameters.Add(New OdbcParameter("@Email", OdbcType.VarChar, 150))
            cmd.Parameters("@Email").Value = dts.G_email
            cmd.Parameters.Add(New OdbcParameter("@Adm", OdbcType.Bit))
            cmd.Parameters("@Adm").Value = dts.G_admin

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


    Public Function Editar(ByVal dts As VUsuario)
        Try
            Conectar()
            cmd = New OdbcCommand("{call editar_usuario(?,?,?,?,?,?)}") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }


            cmd.Parameters.Add(New OdbcParameter("@id", OdbcType.Int))
            cmd.Parameters("@id").Value = dts.G_id
            cmd.Parameters.Add(New OdbcParameter("@usuario", OdbcType.VarChar, 50))
            cmd.Parameters("@usuario").Value = dts.G_usuario
            cmd.Parameters.Add(New OdbcParameter("@pwd", OdbcType.VarChar, 50))
            cmd.Parameters("@pwd").Value = dts.G_pwd
            cmd.Parameters.Add(New OdbcParameter("@nombre", OdbcType.NVarChar, 150))
            cmd.Parameters("@nombre").Value = dts.G_nombre
            cmd.Parameters.Add(New OdbcParameter("@email", OdbcType.VarChar, 150))
            cmd.Parameters("@email").Value = dts.G_email
            cmd.Parameters.Add(New OdbcParameter("@adm", OdbcType.Bit))
            cmd.Parameters("@adm").Value = dts.G_admin


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

    Public Function Eliminar(ByVal dts As VUsuario)
        Try
            Conectar()
            cmd = New OdbcCommand("{call eliminar_usuarios(?)}") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }


            cmd.Parameters.Add(New OdbcParameter("@id", OdbcType.Int))
            cmd.Parameters("@id").Value = dts.G_id

            If dts.G_id = RetData() Then
                MessageBoxEx.Show("No puedes eliminar tu propio usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DesktopAlert.AlertAnimationDuration = 150
                DesktopAlert.Show("No puedes eliminar tu propio usuario", eAlertPosition.BottomRight)
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
            Desconectar()
        End Try
    End Function

    Public Function Verificar_Usuario(ByVal dts As VUsuario)
        Try
            Conectar()

            cmd = New OdbcCommand("{call aunt_user(?)}") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }


            cmd.Parameters.Add(New OdbcParameter("@usuario", OdbcType.VarChar, 50))
            cmd.Parameters("@usuario").Value = dts.G_usuario

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

    Public Sub A()
        Try
            Conectar()

            cmd = New OdbcCommand("mostrar_usuarios") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = cnx
            }

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New OdbcDataAdapter(cmd)
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    Dim dts As VUsuario = New VUsuario() With {
                        .G_nombre = "Administrador",
                        .G_email = "admin@admin.com",
                        .G_usuario = "admin",
                        .G_pwd = Encrypt("admin", "F~:KRF#q}bOzpDGp0[v2RN_{K<?&@l"),
                        .G_admin = True
                    }
                    Insertar(dts)
                End If
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Desconectar()
        End Try
    End Sub


End Class
