Imports DevComponents.DotNetBar
Imports System.IO
Imports System.Text
Imports System.Security

Public Class frmUsuarios
    Dim dt As New DataTable
    Dim uc As New ucUsuarios()
    Dim sel As String
    Dim a As Boolean
    Dim cont As Integer

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'StyleManager.Style = eStyle.Office2016
        UcUsuarios2.Location = New Point(Me.ClientSize.Width / 2 - UcUsuarios2.Size.Width / 2, Me.ClientSize.Height / 2 - UcUsuarios2.Size.Height / 2)
        SlidePanel1.IsOpen = False
        Mostrar()
        ComboBoxEx1.SelectedIndex = 0
    End Sub

    Private Sub Mostrar()
        Try
            Dim func As New FUsuario
            dt = func.Mostrar()

            If dt.Rows.Count <> 0 Then
                dgv1.DataSource = dt
                dgv1.ColumnHeadersVisible = True
                With dgv1
                    .Columns(0).Visible = False
                    .Columns(1).HeaderText = "ID"
                    .Columns(2).HeaderText = "Usuario"
                    .Columns(3).HeaderText = "Contraseña"
                    .Columns(4).HeaderText = "Nombre"
                    .Columns(5).HeaderText = "Email"
                    .Columns(6).HeaderText = "Admin"
                    .Columns(0).ReadOnly = False
                    .Columns(1).ReadOnly = True
                    .Columns(2).ReadOnly = True
                    .Columns(3).ReadOnly = True
                    .Columns(4).ReadOnly = True
                    .Columns(5).ReadOnly = True
                    .Columns(6).ReadOnly = True
                End With
            Else
                dgv1.DataSource = Nothing
                dgv1.ColumnHeadersVisible = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            UcUsuarios2.Location = New Point(Me.ClientSize.Width / 2 - UcUsuarios2.Size.Width / 2, Me.ClientSize.Height / 2 - UcUsuarios2.Size.Height / 2)
            UcUsuarios2.Change("Guardar")
            UcUsuarios2.ClearTextBox()
            UcUsuarios2.LabelID.Visible = False
            UcUsuarios2.txtID.Visible = False
            UcUsuarios2.LabelX1.Text = "Nuevo Usuario"
            ' Initialize the random-number generator.
            Randomize()
            ' Generate random value between 1 and 4. 
            Dim value As Integer = CInt(Int((4 * Rnd()) + 0))

            SlidePanel1.SlideSide = value
            SlidePanel1.BringToFront()
            SlidePanel1.IsOpen = True

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

            result = MessageBoxEx.Show("Realmente desea eliminar los productos seleccionados?", "Eliminando Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    For Each row As DataGridViewRow In dgv1.Rows
                        Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcado Then
                            Dim onekey As Integer = Convert.ToInt32(row.Cells("id").Value)
                            Dim vdb As New VUsuario
                            Dim func As New FUsuario

                            vdb.G_id = onekey
                            If RetData() = onekey Then

                            End If
                            If func.Eliminar(vdb) Then

                            Else
                                MessageBox.Show("Registro no fue eliminado", "Eliminado Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    Next
                    Call Mostrar()
                Catch ex As Exception
                    MessageBoxEx.Show(ex.Message)
                End Try
            Else
                MessageBoxEx.Show("Cancelando eliminación de registros", "Eliminado Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Mostrar()
            End If
            cbEliminar.CheckState = CheckState.Unchecked
        Else
            MessageBoxEx.Show("No ha seleccionado ningun registro", "Eliminado Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        cont = 0

    End Sub

    Public Sub GuardarUsuario(ByVal name As String, ByVal user As String, ByVal password As String, ByVal email As String)
        Try
            Dim dts As New VUsuario
            Dim func As New FUsuario

            dts.G_usuario = user
            dts.G_nombre = name
            dts.G_email = email
            dts.G_pwd = Encrypt(password, "F~:KRF#q}bOzpDGp0[v2RN_{K<?&@l")
            dts.G_admin = False
            If func.Insertar(dts) Then
                Mostrar()
                SlidePanel1.IsOpen = False
                If cbEliminar.CheckState = CheckState.Checked Then
                    cbEliminar.CheckState = CheckState.Unchecked
                End If
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
    End Sub

    Public Sub ModificarUsuario(ByVal id As Integer, ByVal name As String, ByVal user As String, ByVal password As String, ByVal email As String)
        Try
            Dim dts As New VUsuario
            Dim func As New FUsuario

            dts.G_id = id
            dts.G_usuario = user
            dts.G_nombre = name
            dts.G_email = email
            dts.G_pwd = Encrypt(password, "F~:KRF#q}bOzpDGp0[v2RN_{K<?&@l")
            dts.G_admin = False
            If func.Editar(dts) Then
                Mostrar()
                SlidePanel1.IsOpen = False
                If cbEliminar.CheckState = CheckState.Checked Then
                    cbEliminar.CheckState = CheckState.Unchecked
                End If
                MessageBoxEx.Show("Usuario modificado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Mostrar()
                MessageBoxEx.Show("Usuario no modificado, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Using sw As New StreamWriter("ErrorLog.txt", FileMode.Append)
                sw.WriteLine(DateTime.Now + " " + ex.Message)
                sw.Close()
            End Using
        End Try
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Try
            UcUsuarios2.Change("Modificar")
            UcUsuarios2.LabelID.Visible = True
            UcUsuarios2.txtID.Visible = True
            UcUsuarios2.LabelX1.Text = "Modificar Usuario"
            UcUsuarios2.Modificar(dgv1.Rows(e.RowIndex).Cells(1).Value, dgv1.Rows(e.RowIndex).Cells(4).Value, dgv1.Rows(e.RowIndex).Cells(2).Value, dgv1.Rows(e.RowIndex).Cells(3).Value, dgv1.Rows(e.RowIndex).Cells(5).Value)
            ' Initialize the random-number generator.
            Randomize()
            ' Generate random value between 1 and 4. 
            Dim value As Integer = CInt(Int((4 * Rnd()) + 0))

            SlidePanel1.SlideSide = value
            SlidePanel1.BringToFront()
            SlidePanel1.IsOpen = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminar.CheckedChanged
        If cbEliminar.CheckState = CheckState.Checked Then
            dgv1.Columns(0).Visible = True
            btnEliminar.Visible = True
        Else
            dgv1.Columns(0).Visible = False
            btnEliminar.Visible = False
        End If
    End Sub

    Private Sub frmUsuarios_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMainMenu.Show()
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        If ComboBoxEx1.SelectedIndex = 0 Then
            txtbuscar.WatermarkText = "Buscar por Usuario"
            sel = "Usuario"
        ElseIf ComboBoxEx1.SelectedIndex = 1 Then
            txtbuscar.WatermarkText = "Buscar por Nombre"
            sel = "nombre"
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
                With dgv1
                    .Columns(0).Visible = False
                    .Columns(1).HeaderText = "ID"
                    .Columns(2).HeaderText = "Usuario"
                    .Columns(3).HeaderText = "Contraseña"
                    .Columns(4).HeaderText = "Nombre"
                    .Columns(5).HeaderText = "Email"
                    .Columns(5).HeaderText = "Admin"
                    .Columns(0).ReadOnly = False
                    .Columns(1).ReadOnly = True
                    .Columns(2).ReadOnly = True
                    .Columns(3).ReadOnly = True
                    .Columns(4).ReadOnly = True
                    .Columns(5).ReadOnly = True
                    .Columns(6).ReadOnly = True
                End With
            Else
                dgv1.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Buscar()
    End Sub

    Private Sub frmUsuarios_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        UcUsuarios2.Location = New Point(Me.ClientSize.Width / 2 - UcUsuarios2.Size.Width / 2, Me.ClientSize.Height / 2 - UcUsuarios2.Size.Height / 2)
    End Sub

End Class