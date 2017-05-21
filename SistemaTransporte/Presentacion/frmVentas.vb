Imports DevComponents.DotNetBar

Public Class frmVentas
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager.Style = eStyle.Office2016
        SlidePanel1.IsOpen = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonX5.Click
        If SlidePanel1.IsOpen Then
            With SlidePanel1
                .SendToBack()
                .IsOpen = False
            End With

        Else
            With SlidePanel1
                .BringToFront()
                .IsOpen = True
            End With
        End If
    End Sub

    Private Sub frmVentas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMainMenu.Show()
    End Sub
End Class