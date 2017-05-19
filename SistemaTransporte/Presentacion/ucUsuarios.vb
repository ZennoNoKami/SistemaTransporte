Imports DevComponents.DotNetBar

Public Class ucUsuarios
    Inherits UserControl
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If btnGuardar.Text = "Guardar" Then
                If txtNombre.Text <> String.Empty And txtUsuario.Text <> String.Empty _
                   And txtPass.Text <> String.Empty And txtCPass.Text <> String.Empty Then

                    If txtPass.Text = txtCPass.Text Then
                        frmUsuarios.GuardarUsuario(txtNombre.Text, txtUsuario.Text, txtPass.Text)
                    Else
                        MessageBoxEx.Show("Contraseñas no son iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBoxEx.Show("Faltan Datos", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf btnGuardar.Text = "Modificar" Then
                If txtNombre.Text <> String.Empty And txtUsuario.Text <> String.Empty _
                  And txtPass.Text <> String.Empty And txtCPass.Text <> String.Empty Then

                    If txtPass.Text = txtCPass.Text Then
                        frmUsuarios.ModificarUsuario(txtID.Text, txtNombre.Text, txtUsuario.Text, txtPass.Text)
                    Else
                        MessageBoxEx.Show("Contraseñas no son iguales", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBoxEx.Show("Faltan Datos", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LabelID.Visible = True
        txtID.Visible = True
        frmUsuarios.SlidePanel1.IsOpen = False
    End Sub

    Public Sub Change(ByVal val As String)
        btnGuardar.Text = val
    End Sub

    Public Sub Modificar(ByVal ID As Integer, ByVal name As String, ByVal user As String, ByVal password As String)
        txtID.Text = ID
        txtNombre.Text = name
        txtUsuario.Text = user
        txtPass.Text = password
    End Sub

    Public Sub ClearTextBox()
        txtID.Clear()
        txtNombre.Clear()
        txtUsuario.Clear()
        txtPass.Clear()
        txtCPass.Clear()
    End Sub

End Class
