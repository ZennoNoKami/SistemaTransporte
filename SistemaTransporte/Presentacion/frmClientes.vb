Imports System.IO
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports System.ComponentModel

Public Class frmClientes
    Private dt As New DataTable
    Dim cmd As New SqlCommand
    Dim sel As String

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager.Style = eStyle.Office2016
        Mostrar()
        ComboBoxEx1.SelectedIndex = 0
        dgv1.Columns(0).Visible = False
    End Sub

    Private Sub Mostrar()
        Try
            Dim func As New FClientes
            dt = func.Mostrar()

            If dt.Rows.Count <> 0 Then
                dgv1.DataSource = dt
                dgv1.ColumnHeadersVisible = True
                nodata.Visible = False
                txtbuscar.Enabled = True
                With dgv1
                    .Columns(1).HeaderText = "ID"
                    .Columns(2).HeaderText = "Nombre"
                    .Columns(3).HeaderText = "Edad"
                    .Columns(4).HeaderText = "Identidad"
                    .Columns(5).HeaderText = "Teléfono"
                    .Columns(6).HeaderText = "Email"
                    .Columns(7).HeaderText = "Dirección"
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

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Buscar()

        'Try
        '    Dim dts As New VClientes
        '    Dim func As New FClientes
        '    Dim dt2 As New DataTable

        '    dts.G_by = ComboBoxEx1.SelectedIndex
        '    If txtbuscar.Text.Length > 0 Then
        '        If ComboBoxEx1.SelectedIndex = 0 Then
        '            dts.G_idcliente = txtbuscar.Text
        '            dts.G_nombre = "0"
        '            dts.G_identidad = "0"
        '        ElseIf ComboBoxEx1.SelectedIndex = 1 Then
        '            dts.G_idcliente = 0
        '            dts.G_nombre = txtbuscar.Text
        '            dts.G_identidad = "0"
        '        ElseIf ComboBoxEx1.SelectedIndex = 2 Then
        '            dts.G_idcliente = 0
        '            dts.G_nombre = "0"
        '            dts.G_identidad = txtbuscar.Text
        '        End If
        '        dt = func.Buscar(dts)
        '        dgv1.DataSource = dt
        '    Else
        '        Mostrar()
        '    End If



        '    'If func.Buscar(dts) Then

        '    'End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
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
            If Me.ValidateChildren = True And txtNombre.Text <> String.Empty And txtEmail.Text <> String.Empty And txtDireccion.Text <> String.Empty _
            And t_edad.Text <> String.Empty And mtbIdentidad.MaskFull = True And mtbTelefono.MaskFull = True Then
                Try
                    Dim dts As New VClientes
                    Dim func As New FClientes

                    dts.G_nombre = txtNombre.Text
                    dts.G_edad = t_edad.Value.ToString()
                    dts.G_identidad = mtbIdentidad.Text
                    dts.G_telefono = mtbTelefono.Text
                    dts.G_email = txtEmail.Text
                    dts.G_direccion = txtDireccion.Text

                    If func.Insertar(dts) Then
                        Mostrar()
                        ClearTextBox()
                        MessageBoxEx.Show("Cliente registrado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Mostrar()
                        MessageBoxEx.Show("Cliente no registrado, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If Me.ValidateChildren = True And txtNombre.Text <> String.Empty And txtEmail.Text <> String.Empty And txtDireccion.Text <> String.Empty _
            And t_edad.Text <> String.Empty And mtbIdentidad.MaskFull = True And mtbTelefono.MaskFull = True Then
                Try
                    Dim dts As New VClientes
                    Dim func As New FClientes

                    dts.G_idcliente = txtID.Text
                    dts.G_nombre = txtNombre.Text
                    dts.G_edad = t_edad.Value.ToString()
                    dts.G_identidad = mtbIdentidad.Text
                    dts.G_telefono = mtbTelefono.Text
                    dts.G_email = txtEmail.Text
                    dts.G_direccion = txtDireccion.Text

                    If func.Editar(dts) Then
                        Mostrar()
                        ClearTextBox()
                        MessageBoxEx.Show("Cliente modificado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Mostrar()
                        MessageBoxEx.Show("Cliente no modificado, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        If ComboBoxEx1.SelectedIndex = 0 Then
            txtbuscar.WatermarkText = "Buscar por ID"
            sel = "idcliente"
        ElseIf ComboBoxEx1.SelectedIndex = 1 Then
            txtbuscar.WatermarkText = "Buscar por Nombre"
            sel = "nombre"
        ElseIf ComboBoxEx1.SelectedIndex = 2 Then
            txtbuscar.WatermarkText = "Buscar por Identidad"
            sel = "identidad"
        End If
        txtbuscar.Clear()
    End Sub

    Private Sub EnableTextBox()
        txtNombre.Enabled = True
        txtEmail.Enabled = True
        mtbIdentidad.Enabled = True
        mtbTelefono.Enabled = True
        txtDireccion.Enabled = True
        t_edad.Enabled = True
    End Sub

    Private Sub DisableTextBox()
        txtNombre.Enabled = False
        txtEmail.Enabled = False
        mtbIdentidad.Enabled = False
        mtbTelefono.Enabled = False
        txtDireccion.Enabled = False
        t_edad.Enabled = False
    End Sub

    Private Sub ClearTextBox()
        txtID.Clear()
        txtNombre.Clear()
        txtEmail.Clear()
        mtbIdentidad.ResetText()
        mtbTelefono.ResetText()
        txtDireccion.Clear()
        t_edad.ResetText()
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
            txtNombre.Text = dgv1.Rows(e.RowIndex).Cells(2).Value
            t_edad.Value = dgv1.Rows(e.RowIndex).Cells(3).Value
            mtbIdentidad.Text = dgv1.Rows(e.RowIndex).Cells(4).Value
            mtbTelefono.Text = dgv1.Rows(e.RowIndex).Cells(5).Value
            txtEmail.Text = dgv1.Rows(e.RowIndex).Cells(6).Value
            txtDireccion.Text = dgv1.Rows(e.RowIndex).Cells(7).Value
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
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los productos seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgv1.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idcliente").Value)
                        Dim vdb As New VClientes
                        Dim func As New FClientes

                        vdb.G_idcliente = onekey

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
        Call ClearTextBox()
    End Sub

    Private Sub frmClientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMainMenu.Show()
    End Sub
End Class