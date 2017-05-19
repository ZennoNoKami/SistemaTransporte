Imports DevComponents.DotNetBar
Public Class frmLogin
    Dim dt As New DataTable
    Public nombre As String
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager.Style = eStyle.Office2016
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim func As New FUsuario
            Dim dts As New VUsuario

            dts.G_usuario = UsernameTextBox.Text

            dt = func.Verificar_Usuario(dts)
            MessageBox.Show(dt.Rows(0).Item(0) + "-" + dt.Rows(0).Item(1) + "-" + dt.Rows(0).Item(2))
            Dim user As String = dt.Rows(0).Item(0)
            Dim pass As String = dt.Rows(0).Item(1)
            nombre = dt.Rows(0).Item(2)
            If UsernameTextBox.Text = user And PasswordTextBox.Text = pass Then
                Me.Hide()
                frmMenu.Show()
            Else
                MessageBox.Show("Contraseña incorrecta", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try





    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
