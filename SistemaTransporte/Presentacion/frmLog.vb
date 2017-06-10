Imports DevComponents.DotNetBar

Public Class frmLog

    Dim dt As New DataTable
    Public nombre As String
    Dim a As New FUsuario

    Private Sub FrmLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        StyleManager.Style = eStyle.VisualStudio2012Light
        a.A()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Panel2.SendToBack()
        Panel1.BringToFront()
        BunifuSeparator1.Left = btn1.Left
        Reset2()
        btnLogIn.Select()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Panel1.SendToBack()
        Panel2.BringToFront()
        BunifuSeparator1.Left = btn2.Left
        Reset1()
        btnSignUp.Select()
    End Sub

    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        LogIn()
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If txtNombre.Text <> String.Empty And txtEmail.Text <> String.Empty And txtUsuario.Text <> String.Empty And txtContrasena.Text <> String.Empty And txtConfirmarC.Text <> String.Empty Then
            If txtContrasena.Text = txtConfirmarC.Text Then
                Try
                    Dim dts As New VUsuario
                    Dim func As New FUsuario

                    dts.G_usuario = txtUsuario.Text
                    dts.G_nombre = txtNombre.Text
                    dts.G_email = txtEmail.Text
                    dts.G_pwd = Encrypt(txtContrasena.Text, "F~:KRF#q}bOzpDGp0[v2RN_{K<?&@l")
                    dts.G_admin = False
                    If func.Insertar(dts) Then
                        MessageBoxEx.Show("Usuario registrado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBoxEx.Show("Usuario no registrado, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception

                End Try

            Else
                MessageBoxEx.Show("Contraseñas no son iguales")
            End If
        Else
                MessageBoxEx.Show("Ingrese todos los datos", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtUser_Validated(sender As Object, e As EventArgs) Handles txtUser.Validated
        If txtUser.Text.Length > 0 Then
            txtUser.BorderColorIdle = Color.Black
        End If
    End Sub

    Private Sub TxtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        If txtPassword.Text.Length > 0 Then
            txtPassword.BorderColorIdle = Color.Black
        End If
    End Sub

    Private Sub Reset1()
        txtUser.ResetText()
        txtPassword.ResetText()
        txtUser.BorderColorIdle = Color.Black
        txtPassword.BorderColorIdle = Color.Black
    End Sub

    Private Sub Reset2()
        txtNombre.ResetText()
        txtEmail.ResetText()
        txtUsuario.ResetText()
        txtContrasena.ResetText()
        txtConfirmarC.ResetText()
        txtNombre.BorderColorIdle = Color.Black
        txtEmail.BorderColorIdle = Color.Black
        txtUsuario.BorderColorIdle = Color.Black
        txtContrasena.BorderColorIdle = Color.Black
        txtConfirmarC.BorderColorIdle = Color.Black
    End Sub

    Private Sub LogIn()
        If txtUser.Text <> String.Empty Then
            If txtPassword.Text <> String.Empty Then
                Try
                    Dim func As New FUsuario
                    Dim dts As New VUsuario

                    dts.G_usuario = txtUser.Text

                    dt = func.Verificar_Usuario(dts)
                    Dim user As String = dt.Rows(0).Item(1)
                    Dim pass As String = dt.Rows(0).Item(2)
                    Dim id As Integer = dt.Rows(0).Item(0)
                    nombre = dt.Rows(0).Item(3)
                    If txtUser.Text = user And Encrypt(txtPassword.Text, "F~:KRF#q}bOzpDGp0[v2RN_{K<?&@l") = pass Then
                        UserData(id)
                        txtUser.ResetText()
                        txtPassword.ResetText()
                        btn1.Select()
                        txtUser.BorderColorIdle = Color.Silver
                        txtPassword.BorderColorIdle = Color.Silver
                        Me.Hide()
                        frmMainMenu.btnPerfil.Text = nombre
                        frmMainMenu.Show()

                    Else
                        MessageBoxEx.Show("Contraseña incorrecta", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtPassword.BorderColorIdle = Color.Red
                        btn1.Select()
                    End If
                Catch ex As Exception
                    MessageBoxEx.Show("No se encuentra el usuario", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUser.BorderColorIdle = Color.Red
                    btn1.Select()
                    txtUser.ResetText()
                    txtPassword.ResetText()
                End Try
            Else
                MessageBoxEx.Show("Escriba su contraseña para iniciar Sesión", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPassword.BorderColorIdle = Color.Red
                btn1.Select()
            End If
        Else
            MessageBoxEx.Show("Escriba su nombre de usuario para iniciar Sesión", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUser.BorderColorIdle = Color.Red
            btn1.Select()
        End If
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        LogIn()
    End Sub
End Class