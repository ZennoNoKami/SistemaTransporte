Imports System.IO
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Public Class frmCiudades
    Private dt As New DataTable
    Dim cmd As New SqlCommand
    Dim sel As String

    Private Sub frmCiudades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager.Style = eStyle.Office2016
        Mostrar()
        ComboBoxEx1.SelectedIndex = 0
        dgv1.Columns(0).Visible = False
    End Sub

    Private Sub Mostrar()
        Try
            Dim fun As New FCiudades
            dt = fun.Mostrar()

            If dt.Rows.Count <> 0 Then
                dgv1.DataSource = dt
                dgv1.ColumnHeadersVisible = True
                nodata.Visible = False
                txtbuscar.Enabled = True
                With dgv1
                    .Columns(1).HeaderText = "ID"
                    .Columns(2).HeaderText = "Ciudad"
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
                LabelID.Visible = True
                txtID.Visible = True
            End If
        ElseIf btn1.Text = "Guardar" Then
            If Me.ValidateChildren = True And txtCiudad.Text <> String.Empty Then
                Try
                    Dim dts As New VCiudades
                    Dim func As New FCiudades

                    dts.G_ciudad = txtCiudad.Text

                    If func.Insertar(dts) Then
                        Mostrar()
                        ClearTextBox()
                        ResetButtons()
                        MessageBoxEx.Show("Ciudad registrada correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Mostrar()
                        MessageBoxEx.Show("Ciudad no registrada, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If Me.ValidateChildren = True And txtCiudad.Text <> String.Empty Then
                Try
                    Dim dts As New VCiudades
                    Dim func As New FCiudades

                    dts.G_idCiudad = txtID.Text
                    dts.G_ciudad = txtCiudad.Text

                    If func.Editar(dts) Then
                        Mostrar()
                        ClearTextBox()
                        ResetButtons()
                        MessageBoxEx.Show("Ciudad modificada correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Mostrar()
                        MessageBoxEx.Show("Ciudad no modificada, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    'deshabilitar
    Private Sub DisableTextBox()
        txtCiudad.Enabled = False
        txtID.Enabled = False
    End Sub

    'habilitar
    Private Sub EnableTextBox()
        txtID.Enabled = True
        txtCiudad.Enabled = True
    End Sub

    Private Sub ClearTextBox()
        txtID.Clear()
        txtCiudad.Clear()
    End Sub

    Private Sub ResetButtons()
        btn1.Text = "Nuevo"
        btn2.Text = "Editar"
        btn2.Enabled = False
    End Sub

    Private Sub dgv2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Try
            LabelID.Visible = True
            txtID.Visible = True
            txtCiudad.Visible = True
            LabelCiudad.Visible = True
            txtID.Text = dgv1.Rows(e.RowIndex).Cells(0).Value
            txtCiudad.Text = dgv1.Rows(e.RowIndex).Cells(1).Value
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
                LabelID.Visible = True
                txtID.Visible = True
            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los registros seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgv1.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idciudad").Value)
                        Dim vdb As New VCiudades
                        Dim func As New FCiudades

                        vdb.G_idCiudad = onekey

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

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Buscar()
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        If ComboBoxEx1.SelectedIndex = 0 Then
            txtbuscar.WatermarkText = "Buscar por ID"
            sel = "idciudad"
        ElseIf ComboBoxEx1.SelectedIndex = 1 Then
            txtbuscar.WatermarkText = "Buscar por Nombre"
            sel = "ciudad"
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

    Private Sub frmCiudades_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        frmMenu.Show()

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
End Class