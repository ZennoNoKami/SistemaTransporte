Imports System.IO
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Public Class frmItinerario
    Private dt As New DataTable
    Dim cmd As New SqlCommand
    Dim sel As String
    Public cont As Integer
    Public a As Boolean
    Private Sub frmItinerario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager.Style = eStyle.Office2016
        Mostrar()
        ComboBoxEx3.SelectedIndex = 0
        dgv1.Columns(0).Visible = False
        LLenar_Cbo()
        LLenar_id()
    End Sub

    Private Sub LLenar_Cbo()
        Try
            Dim func As New FItinerario
            func.LLenar_CBO(cmbOrigen, cmbDestino)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LLenar_id()
        Try
            Dim func As New FItinerario
            func.LLenar_id(txtIdAuto)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Mostrar()
        Try
            Dim func As New FItinerario
            dt = func.Mostrar()

            If dt.Rows.Count <> 0 Then
                dgv1.DataSource = dt
                dgv1.ColumnHeadersVisible = True
                nodata.Visible = False
                txtbuscar.Enabled = True
                With dgv1
                    .Columns(1).HeaderText = "IDItinerario"
                    .Columns(2).HeaderText = "Hora Salida"
                    .Columns(3).HeaderText = "Hora Llegada"
                    .Columns(4).HeaderText = "Origen"
                    .Columns(5).HeaderText = "Destino"
                    .Columns(6).HeaderText = "IdAutobus"
                    .Columns(7).HeaderText = "Precio"
                    .Columns(8).HeaderText = "Precio Encomienda"
                    .Columns(0).ReadOnly = False
                    .Columns(1).ReadOnly = True
                    .Columns(2).ReadOnly = True
                    .Columns(3).ReadOnly = True
                    .Columns(4).ReadOnly = True
                    .Columns(5).ReadOnly = True
                    .Columns(6).ReadOnly = True
                    .Columns(7).ReadOnly = True
                    .Columns(8).ReadOnly = True
                End With
            Else
                dgv1.DataSource = Nothing
                dgv1.ColumnHeadersVisible = False
                nodata.Visible = True
                txtbuscar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If btn1.Text = "Nuevo" Then
            btn1.Text = "Guardar"
            btn2.Text = "Cancelar"
            EnableTextBox()
            ClearTextBox()
            btn2.Enabled = True
            If LabelID.Visible And txtID.Visible Then
                LabelID.Visible = False
                txtID.Visible = False
            End If
        ElseIf btn1.Text = "Guardar" Then
            If Me.ValidateChildren = True And txtHoraSalida.Text <> String.Empty And txtHoraLlegada.Text <> String.Empty And cmbOrigen.Text <> String.Empty _
            And cmbDestino.Text <> String.Empty And txtIdAuto.Text <> String.Empty And diPrecio.Text = True And diPrecioEncomienda.Text <> String.Empty Then
                Try
                    Dim dts As New VItinerario
                    Dim func As New FItinerario

                    dts.G_horasalida = txtHoraSalida.Text
                    dts.G_horallegada = txtHoraLlegada.Text
                    dts.G_origen = cmbOrigen.Text
                    dts.G_destino = cmbDestino.Text
                    dts.G_idautobus = txtIdAuto.Text
                    dts.G_precio = diPrecio.Text
                    dts.G_precioencomienda = diPrecioEncomienda.Text

                    If func.Insertar(dts) Then
                        Mostrar()
                        ClearTextBox()
                        MessageBoxEx.Show("Itinerario registrado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Mostrar()
                        MessageBoxEx.Show("Itinerario no registrado, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    Using sw As New StreamWriter("ErrorLog.txt", FileMode.Append)
                        sw.WriteLine(DateTime.Now + " " + ex.Message)
                        sw.Close()
                    End Using
                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf btn1.Text = "Modificar" Then
            If Me.ValidateChildren = True And txtHoraSalida.Text <> String.Empty And txtHoraLlegada.Text <> String.Empty And cmbOrigen.Text <> String.Empty _
            And cmbDestino.Text <> String.Empty And txtIdAuto.Text <> String.Empty And diPrecio.Text = True And diPrecioEncomienda.Text <> String.Empty Then
                Try
                    Dim dts As New VItinerario
                    Dim func As New FItinerario

                    dts.G_iditinerario = txtID.Text
                    dts.G_horasalida = txtHoraSalida.Text
                    dts.G_horallegada = txtHoraLlegada.Text
                    dts.G_origen = cmbOrigen.Text
                    dts.G_destino = cmbDestino.Text
                    dts.G_idautobus = txtIdAuto.Text
                    dts.G_precio = diPrecio.Text
                    dts.G_precioencomienda = diPrecioEncomienda.Text

                    If func.Editar(dts) Then
                        Mostrar()
                        ClearTextBox()
                        MessageBoxEx.Show("Itinerario modificado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Mostrar()
                        MessageBoxEx.Show("Itinerario no modificado, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    Using sw As New StreamWriter("ErrorLog.txt", FileMode.Append)
                        sw.WriteLine(DateTime.Now + " " + ex.Message)
                        sw.Close()
                    End Using
                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub



    Private Sub ComboBoxEx3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEx3.SelectedIndexChanged
        If ComboBoxEx3.SelectedIndex = 0 Then
            txtbuscar.WatermarkText = "Buscar por Origen"
            sel = "origen"
        ElseIf ComboBoxEx3.SelectedIndex = 1 Then
            txtbuscar.WatermarkText = "Buscar por destino"
            sel = "destino"
        End If
        txtbuscar.Clear()
    End Sub


    Private Sub EnableTextBox()
        txtHoraSalida.Enabled = True
        txtHoraLlegada.Enabled = True
        cmbOrigen.Enabled = True
        cmbDestino.Enabled = True
        txtIdAuto.Enabled = True
        diPrecio.Enabled = True
        diPrecioEncomienda.Enabled = True
    End Sub

    Private Sub DisableTextBox()
        txtHoraSalida.Enabled = False
        txtHoraLlegada.Enabled = False
        cmbOrigen.Enabled = False
        cmbDestino.Enabled = False
        txtIdAuto.Enabled = False
        diPrecio.Enabled = False
        diPrecioEncomienda.Enabled = False
    End Sub

    Private Sub ClearTextBox()
        txtID.Clear()
        txtHoraSalida.ResetValue()
        txtHoraLlegada.ResetValue()
        cmbOrigen.SelectedIndex = 0
        cmbDestino.SelectedIndex = 0
        txtIdAuto.SelectedIndex = 0
        diPrecio.ResetText()
        diPrecioEncomienda.ResetText()
    End Sub

    Private Sub ResetButtons()
        btn1.Text = "Nuevo"
        btn2.Text = "Editar"
        btn2.Enabled = False
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Try
            LabelID.Visible = True
            txtID.Visible = True
            txtID.Text = dgv1.Rows(e.RowIndex).Cells(1).Value
            txtHoraSalida.Text = dgv1.Rows(e.RowIndex).Cells(2).Value
            txtHoraLlegada.Value = dgv1.Rows(e.RowIndex).Cells(3).Value
            cmbOrigen.Text = dgv1.Rows(e.RowIndex).Cells(4).Value
            cmbDestino.Text = dgv1.Rows(e.RowIndex).Cells(5).Value
            txtIdAuto.Text = dgv1.Rows(e.RowIndex).Cells(6).Value
            diPrecio.Text = dgv1.Rows(e.RowIndex).Cells(7).Value
            diPrecioEncomienda.Text = dgv1.Rows(e.RowIndex).Cells(8).Value
            DisableTextBox()
            ResetButtons()
            btn2.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn2.Text = "Editar" Then
            EnableTextBox()
            btn1.Text = "Modificar"
            btn2.Text = "Cancelar"
        ElseIf btn2.Text = "Cancelar" Then
            ClearTextBox()
            DisableTextBox()
            ResetButtons()
            If LabelID.Visible And txtID.Visible Then
                LabelID.Visible = False
                txtID.Visible = False
            End If
        End If
    End Sub

    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'",
                                          sel.Trim(), txtbuscar.Text.Trim())
            If dv.Count <> 0 Then
                dgv1.DataSource = dv
            Else
                dgv1.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            dgv1.Columns.Item("Eliminar").Visible = True
            btnEliminar.Visible = True
        Else
            dgv1.Columns.Item("Eliminar").Visible = False
            btnEliminar.Visible = False
        End If
    End Sub


    Private Sub dgv1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Try
            If e.ColumnIndex = Me.dgv1.Columns.Item("Eliminar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = Me.dgv1.Rows(e.RowIndex).Cells("Eliminar")
                chkcell.Value = Not chkcell.Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        For Each r As DataGridViewRow In dgv1.Rows
            a = Convert.ToBoolean(r.Cells("Eliminar").Value)
            If a Then
                cont = 1
                Exit For
            End If
        Next

        If cont = 1 Then
            Dim result As DialogResult

            result = MessageBox.Show("Realmente desea eliminar los Registros seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If Result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In dgv1.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then
                            Dim onekey As Integer = Convert.ToInt32(row.Cells("iditinerario").Value)
                            Dim vdb As New VItinerario
                            Dim func As New FItinerario

                            vdb.G_iditinerario = onekey

                            If func.Eliminar(vdb) Then

                            Else
                                MessageBox.Show("Registro no fue eliminado", "Eliminado Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    Next
                    Call Mostrar()
                Catch ex As Exception

                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminado Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Mostrar()
            End If
            cbEliminar.CheckState = CheckState.Unchecked
        Else
            MessageBoxEx.Show("No ha seleccionado ningun registro", "Eliminado Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        cont = 0

    End Sub


    Private Sub frmItinerario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        cmbOrigen.Items.Clear()
        cmbDestino.Items.Clear()
        txtIdAuto.Items.Clear()
        frmMenu.Show()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Buscar()
    End Sub


End Class