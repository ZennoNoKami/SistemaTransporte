Imports System.IO
Imports DevComponents.DotNetBar

Public Class Bus
    Private Sub Bus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleManager.Style = eStyle.VisualStudio2012Light
        DisableTextBox()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If btn1.Text = "Nuevo" Then
            btn1.Text = "Guardar"
            btn2.Text = "Cancelar"
            EnableTextBox()
            Clear()
            btn2.Enabled = True
        ElseIf btn1.Text = "Guardar" Then
            If txtCant.Text <> String.Empty Then
                Try
                    Dim dts As New VBus
                    Dim func As New F_Bus

                    dts.G_cantidadasientos = txtCant.Text

                    If func.Insertar(dts) Then
                        Clear()
                        MessageBoxEx.Show("AutoBus registrado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else

                        MessageBoxEx.Show("AutoBus no registrado, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub Clear()
        txtCant.Clear()
        txtIdbus.Clear()
    End Sub

    Private Sub DisableTextBox()
        txtCant.Enabled = False
        txtIdbus.Enabled = False
    End Sub
    Private Sub EnableTextBox()
        txtCant.Enabled = True
    End Sub

    Private Sub Bus_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMainMenu.Show()
    End Sub
End Class