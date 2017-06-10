Imports DevComponents.DotNetBar

Public Class frmMainMenu

    Dim isOpen As Boolean
    Dim b As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(Me.ClientSize.Width / 2 - Panel1.Size.Width / 2, Me.ClientSize.Height / 2 - Panel1.Size.Height / 2)
        StyleManager.Style = eStyle.VisualStudio2012Light
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmLog.Close()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click, BunifuThinButton21.Click
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

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnSalir.Click, BunifuThinButton22.Click
        Me.Close()
        frmLog.Close()
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        Dim superTooltip As New SuperTooltipInfo()

        superTooltip.HeaderText = "Cerrar Sesión"
        superTooltip.BodyText = "Cierra el menu y regresa al Login"

        SuperTooltip1.SetSuperTooltip(btnSalir, superTooltip)

    End Sub

    Private Sub btnUsr_Click(sender As Object, e As EventArgs) Handles btnUsr.Click
        btnUsr.Enabled = False
        If isOpen = False Then
            Do Until btnGroup.Top = 150
                btnGroup.Top += 1
                btnUsr.Update()
                btnGroup.Update()
                Threading.Thread.Sleep(1)
            Loop
            isOpen = True
        Else
            Do Until btnGroup.Top = 52
                btnGroup.Top -= 1
                btnUsr.Update()
                btnGroup.Update()
                Threading.Thread.Sleep(1)
            Loop
            isOpen = False
        End If
        btnUsr.Enabled = True
    End Sub

    Private Sub frmMainMenu_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Do Until btnGroup.Top = 52
            btnGroup.Top -= 1
            Threading.Thread.Sleep(1)
        Loop
        isOpen = False
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        If MessageBoxEx.Show("Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmLog.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Bus.Show()
        Me.Hide()
    End Sub
End Class
