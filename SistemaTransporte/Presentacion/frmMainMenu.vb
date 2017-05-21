Imports DevComponents.DotNetBar

Public Class frmMainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(Me.ClientSize.Width / 2 - Panel1.Size.Width / 2, Me.ClientSize.Height / 2 - Panel1.Size.Height / 2)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmLog.Close()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        frmClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        frmVentas.Show()
        Me.Hide()
    End Sub

    Private Sub btnItinerario_Click(sender As Object, e As EventArgs) Handles btnItinerario.Click
        frmItinerario.Show()
        Me.Hide()
    End Sub

    Private Sub btnCiudades_Click(sender As Object, e As EventArgs) Handles btnCiudades.Click
        frmCiudades.Show()
        Me.Hide()
    End Sub

    Private Sub btnEncomiendas_Click(sender As Object, e As EventArgs) Handles btnEncomiendas.Click

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBoxEx.Show("Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmLog.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        Dim superTooltip As New SuperTooltipInfo()

        superTooltip.HeaderText = "Cerrar Sesión"
        superTooltip.BodyText = "Cierra el menu y regresa al Login"

        SuperTooltip1.SetSuperTooltip(btnSalir, superTooltip)

    End Sub
End Class
