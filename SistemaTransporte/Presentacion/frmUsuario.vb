Imports DevComponents.DotNetBar
Imports System.IO
Imports System.Data.SqlClient
Public Class frmUsuario
    Private dt As New DataTable
    Dim sel As String
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager.Style = eStyle.Office2016
        Mostrar()
        ComboBoxEx1.SelectedIndex = 0
        dgv1.Columns(0).Visible = False
        dgv1.Columns(5).ReadOnly = True
    End Sub
    Private Sub Mostrar()
        Try
            Dim func As New FUsuario
            dt = func.Mostrar()

            If dt.Rows.Count <> 0 Then
                dgv1.DataSource = dt
                dgv1.ColumnHeadersVisible = True
                With dgv1
                    .Columns(1).HeaderText = "ID"
                    .Columns(2).HeaderText = "Usuario"
                    .Columns(3).HeaderText = "Contraseña"
                    .Columns(4).HeaderText = "Nombre"
                    .Columns(5).HeaderText = "Admin"
                End With
            Else
                dgv1.DataSource = Nothing
                dgv1.ColumnHeadersVisible = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub EnableTextBox()
        txtusuario.Enabled = True
        txtpwd.Enabled = True
        txtnombre.Enabled = True
        txtconfirmarpwd.Enabled = True
    End Sub
    Private Sub DisableTextBox()
        txtusuario.Enabled = False
        txtpwd.Enabled = False
        txtnombre.Enabled = False
        txtconfirmarpwd.Enabled = False
    End Sub

    Private Sub ClearTextBox()
        txtusuario.Clear()
        txtpwd.Clear()
        txtnombre.Clear()
        txtconfirmarpwd.Clear()
    End Sub

    Private Sub ResetButtons()
        btnGuardar.Text = "Nuevo"
        btnEditar.Text = "Editar"
        btnEditar.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If btnEditar.Text = "Editar" Then
            EnableTextBox()
            btnGuardar.Text = "Modificar"
            btnEditar.Text = "Cancelar"
        ElseIf btnEditar.Text = "Cancelar" Then
            ClearTextBox()
            DisableTextBox()
            ResetButtons()
        End If
    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Try
            txtusuario.Text = dgv1.Rows(e.RowIndex).Cells(0).Value
            txtnombre.Text = dgv1.Rows(e.RowIndex).Cells(1).Value
            txtpwd.Text = dgv1.Rows(e.RowIndex).Cells(2).Value
            txtconfirmarpwd.Text = dgv1.Rows(e.RowIndex).Cells(3).Value
            ResetButtons()
            btnEditar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Text = "Nuevo" Then
            btnGuardar.Text = "Guardar"
            btnEditar.Text = "Cancelar"
            EnableTextBox()
            ClearTextBox()
            btnGuardar.Enabled = True
        ElseIf btnGuardar.Text = "Guardar" Then
            If Me.ValidateChildren = True And txtusuario.Text <> String.Empty And txtnombre.Text <> String.Empty And txtpwd.Text <> String.Empty _
            And txtconfirmarpwd.Text <> String.Empty Then
                Try
                    Dim dts As New VUsuario
                    Dim func As New FUsuario

                    dts.G_usuario = txtusuario.Text
                    dts.G_nombre = txtnombre.Text
                    dts.G_pwd = txtpwd.Text
                    dts.G_pwd = txtconfirmarpwd.Text

                    If func.Insertar(dts) Then
                        Mostrar()
                        MessageBoxEx.Show("Usuario registrado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Mostrar()
                        MessageBoxEx.Show("Usuario no registrado, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        ElseIf btnGuardar.Text = "Modificar" Then
            If Me.ValidateChildren = True And txtusuario.Text <> String.Empty And txtnombre.Text <> String.Empty And txtpwd.Text <> String.Empty _
            And txtconfirmarpwd.Text <> String.Empty Then
                Try
                    Dim dts As New VUsuario
                    Dim func As New FUsuario


                    dts.G_usuario = txtusuario.Text
                    dts.G_nombre = txtnombre.Text
                    dts.G_pwd = txtpwd.Text
                    dts.G_pwd = txtconfirmarpwd.Text

                    If func.Editar(dts) Then
                        Mostrar()
                        MessageBoxEx.Show("Usuario modificado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            txtbuscar.WatermarkText = "Buscar por Usuario"
            sel = "Usuario"
        ElseIf ComboBoxEx1.SelectedIndex = 1 Then
            txtbuscar.WatermarkText = "Buscar por Nombre"
            sel = "nombre"
        End If
        txtbuscar.Clear()
    End Sub

    Private Sub frmUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Buscar()
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los productos seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgv1.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id").Value)
                        Dim vdb As New VUsuario
                        Dim func As New FUsuario

                        vdb.G_id = onekey

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
End Class