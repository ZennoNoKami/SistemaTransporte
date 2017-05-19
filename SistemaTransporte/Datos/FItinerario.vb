Imports System.Data.SqlClient
Public Class FItinerario
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function Mostrar() As DataTable
        Try
            Conectado()

            cmd = New SqlCommand("mostrar_itinerario")
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

    Public Function Insertar(ByVal dts As VItinerario)
        Try
            Conectado()
            cmd = New SqlCommand("insertar_itinerario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@horasalida", dts.G_horasalida)
            cmd.Parameters.AddWithValue("@horallegada", dts.G_horallegada)
            cmd.Parameters.AddWithValue("@origen", dts.G_origen)
            cmd.Parameters.AddWithValue("@destino", dts.G_destino)
            cmd.Parameters.AddWithValue("@idautobus", dts.G_idautobus)
            cmd.Parameters.AddWithValue("@precio", dts.G_precio)
            cmd.Parameters.AddWithValue("@precioencomienda", dts.G_precioencomienda)

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

    Public Function Editar(ByVal dts As VItinerario)
        Try
            Conectado()
            cmd = New SqlCommand("editar_itinerario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@horasalida", dts.G_horasalida)
            cmd.Parameters.AddWithValue("@horallegada", dts.G_horallegada)
            cmd.Parameters.AddWithValue("@origen", dts.G_origen)
            cmd.Parameters.AddWithValue("@destino", dts.G_destino)
            cmd.Parameters.AddWithValue("@idautobus", dts.G_idautobus)
            cmd.Parameters.AddWithValue("@precio", dts.G_precio)
            cmd.Parameters.AddWithValue("@precioencomienda", dts.G_precioencomienda)

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

    Public Function Eliminar(ByVal dts As VItinerario)
        Try
            Conectado()
            cmd = New SqlCommand("eliminar_itinerario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@iditinerario", dts.G_iditinerario)

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


    Public Sub LLenar_CBO(ByVal cb1 As ComboBox, ByVal cb2 As ComboBox)
        Try
            Conectado()

            cmd = New SqlCommand("llenar_cbo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            Dim myAdapter As New SqlDataAdapter
            Dim reader As SqlDataReader


            myAdapter.SelectCommand = cmd
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While reader.Read()
                cb1.Items.Add(reader("ciudad").ToString())
                cb2.Items.Add(reader("ciudad").ToString())
            End While
            cb1.SelectedIndex = 0
            cb2.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LLenar_id(ByVal cb1 As ComboBox)
        Try
            Conectado()

            cmd = New SqlCommand("llenar_id")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            Dim myAdapter As New SqlDataAdapter
            Dim reader As SqlDataReader


            myAdapter.SelectCommand = cmd
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While reader.Read()
                cb1.Items.Add(reader("id").ToString())
            End While
            cb1.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub




End Class
