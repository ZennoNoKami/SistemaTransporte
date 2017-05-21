Imports System.IO
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Public Class frmMenu
    Private dt As New DataTable
    Dim cmd As New SqlCommand
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager.Style = eStyle.Office2016

    End Sub


    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frmClientes.Show()
        Me.Hide()
    End Sub


    Private Sub btnCiudades_Click(sender As Object, e As EventArgs) Handles btnCiudades.Click
        frmCiudades.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        frmUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub frmMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLog.Show()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click

    End Sub

    Private Sub btnItinerario_Click(sender As Object, e As EventArgs) Handles btnItinerario.Click
        frmItinerario.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        frmLog.Close()
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        frmLog.Show()
        Me.Close()
    End Sub
End Class