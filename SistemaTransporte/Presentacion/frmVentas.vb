Imports DevComponents.DotNetBar
Imports System.Data.Odbc
Imports System.Data.Odbc.OdbcConnection

Public Class frmVentas

    Dim btn(32) As ButtonX
    Dim last As ButtonX = Nothing
    Dim lastB As String
    Dim buttons As New List(Of ButtonX)
    Dim length As Integer
    Dim dt As New DataTable
    Dim impuesto As Decimal
    Dim LLenar As FVentas = New FVentas()

    Private Sub frmVentas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMainMenu.Show()

    End Sub

    Private Sub Mostrar()
        Try
            Dim func As New FVentas
            dt = func.Mostrar()

            If dt.Rows.Count <> 0 Then
                dgv1.DataSource = dt
                dgv1.ColumnHeadersVisible = True
                With dgv1
                    .Columns(0).HeaderText = "ID"
                    .Columns(1).HeaderText = "Nombre"
                    .Columns(2).HeaderText = "Edad"
                    .Columns(3).HeaderText = "Identidad"
                    .Columns(4).HeaderText = "Origen"
                    .Columns(5).HeaderText = "Destino"
                    .Columns(6).HeaderText = "Hora"
                    .Columns(7).HeaderText = "Fecha"
                    .Columns(8).HeaderText = "Precio"
                    .Columns(9).HeaderText = "Tipo de Pago"
                    .Columns(10).HeaderText = "Subtotal"
                    .Columns(11).HeaderText = "Impuesto"
                    .Columns(12).HeaderText = "Total"
                    .Columns(13).HeaderText = "Asiento"
                    .Columns(14).HeaderText = "Estado"
                    .Columns(0).ReadOnly = True
                    .Columns(1).ReadOnly = True
                    .Columns(2).ReadOnly = True
                    .Columns(3).ReadOnly = True
                    .Columns(4).ReadOnly = True
                    .Columns(5).ReadOnly = True
                    .Columns(6).ReadOnly = True
                    .Columns(7).ReadOnly = True
                    .Columns(8).ReadOnly = True
                    .Columns(9).ReadOnly = True
                    .Columns(10).ReadOnly = True
                    .Columns(11).ReadOnly = True
                    .Columns(12).ReadOnly = True
                    .Columns(13).ReadOnly = True
                    .Columns(14).ReadOnly = True
                End With
            Else
                dgv1.DataSource = Nothing
                dgv1.ColumnHeadersVisible = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        GenerarBotones()
        'LLenar.LlenarCbo(cboOrigen, cboDestino)
        cboGenero.SelectedIndex = 0
        dtiHora.Value = DateAndTime.TimeValue("12:00")
        RadioButton1.Checked = True
        txtSubTotal.Text = "0.00"
        txtTotal.Text = "0.00"
        cboTipoPago.SelectedIndex = 0
    End Sub

    Private Sub GenerarBotones()
        length = btn.Length - 2
        For i As Integer = 0 To length
            btn(i) = New ButtonX With {
                .Text = (i + 1).ToString(),
                .Name = "btn" + (i + 1).ToString(),
                .Size = New Size(75, 75),
                .ColorTable = eButtonColor.Flat,
                .BackColor = Color.Green,
                .FocusCuesEnabled = False
            }
            AddHandler btn(i).Click, AddressOf Button_Click
            AddHandler btn(i).MouseHover, AddressOf Button_MouseHover
            Me.FlowLayoutPanel1.Controls.Add(btn(i))

        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        For i As Integer = 0 To length
            If sender Is btn(i) Then
                If btn(i).BackColor = Color.Green Then
                    txtAsiento.Text = btn(i).Text
                    btn(i).BackColor = Color.Blue
                    If last IsNot Nothing Then
                        If last.BackColor = Color.Blue Then
                            last.BackColor = Color.Green
                        End If
                        last = Nothing
                    End If
                    last = btn(i)
                ElseIf btn(i).BackColor = Color.Blue Then
                    btn(i).BackColor = Color.Green
                    txtAsiento.Clear()
                ElseIf btn(i).BackColor = Color.Red Then
                    ToastNotification.DefaultToastGlowColor = eToastGlowColor.None
                    ToastNotification.ToastForeColor = Color.Black
                    ToastNotification.ToastBackColor = Color.White
                    ToastNotification.Show(gpAsientos, "Este asiento está ocupado")
                End If

            End If
        Next
    End Sub

    Private Sub Button_MouseHover(sender As Object, e As EventArgs)
        Try
            For i As Integer = 0 To length

                If sender Is btn(i) Then
                    If btn(i).BackColor = Color.Green Then
                        btn(i).Tooltip = "Libre"
                    ElseIf btn(i).BackColor = Color.Red Then
                        btn(i).Tooltip = "Ocupado"
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim dts As New V_Ventas
            Dim func As New FVentas
            Dim imp As Double

            If RadioButton1.Checked Then
                imp = 0%
            ElseIf RadioButton2.Checked Then
                imp = 15%
            ElseIf RadioButton3.Checked Then
                imp = 18%
            End If
            dts.G_idboleto = txtBoleto.Text
            dts.G_nombre = txtNombre.Text
            dts.G_edad = txtEdad.Text
            dts.G_identidad = mtbIdentidad.Text
            dts.G_origen = cboOrigen.SelectedItem
            dts.G_destino = cboDestino.SelectedItem
            dts.G_hora = dtiHora.Text
            dts.G_fecha = dtiFecha.Text
            dts.G_precio = txtPrecio.Text
            dts.G_tipopago = cboTipoPago.Text
            dts.G_subtotal = txtSubTotal.Text
            dts.G_impuesto = imp
            dts.G_total = txtTotal.Text
            dts.G_asientobus = txtAsiento.Text
            dts.G_estado = "Activo"

            If func.Insertar(dts) Then
                Mostrar()
                MessageBoxEx.Show("Venta registrada correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Mostrar()
                MessageBoxEx.Show("No se ha podido efectuar la venta, intente de nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrecio_Validated(sender As Object, e As EventArgs) Handles txtPrecio.Validated
        Try
            txtSubTotal.Text = Convert.ToDecimal(txtPrecio.Text).ToString("F2")
            txtTotal.Text = Convert.ToDecimal(txtSubTotal.Text).ToString("F2")
            GetTotal()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Try
            GetTotal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Try
            GetTotal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Try
            GetTotal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetTotal()
        Dim subTotal As Decimal
        Dim Total As Decimal
        If txtSubTotal.Text.Length > 0 Then
            If RadioButton1.Checked Then
                impuesto = 0
                subTotal = Convert.ToDecimal(txtSubTotal.Text) + impuesto
                txtTotal.Text = subTotal.ToString("F2")
            ElseIf RadioButton2.Checked Then
                impuesto = 0.15
                subTotal = (Convert.ToDecimal(txtSubTotal.Text)) * impuesto
                Total = Convert.ToDecimal(txtSubTotal.Text) + subTotal
                txtTotal.Text = Total.ToString("F2")
            ElseIf RadioButton3.Checked Then
                impuesto = 0.18
                subTotal = (Convert.ToDecimal(txtSubTotal.Text)) * impuesto
                Total = Convert.ToDecimal(txtSubTotal.Text) + subTotal
                txtTotal.Text = Total.ToString("F2")
            End If
        End If
    End Sub


End Class