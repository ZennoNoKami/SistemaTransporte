<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucUsuarios
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelID = New DevComponents.DotNetBar.LabelX()
        Me.txtID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbVentas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbBuses = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbClientes = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbItinerario = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbCiudades = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbUsuarios = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbEncomiendas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbAdmin = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.DisabledBackColor = System.Drawing.Color.White
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(139, 81)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PreventEnterBeep = True
        Me.txtNombre.Size = New System.Drawing.Size(135, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtUsuario.Border.Class = "TextBoxBorder"
        Me.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsuario.DisabledBackColor = System.Drawing.Color.White
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.Location = New System.Drawing.Point(140, 139)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PreventEnterBeep = True
        Me.txtUsuario.Size = New System.Drawing.Size(135, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPass.Border.Class = "TextBoxBorder"
        Me.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPass.DisabledBackColor = System.Drawing.Color.White
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(140, 168)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PreventEnterBeep = True
        Me.txtPass.Size = New System.Drawing.Size(134, 20)
        Me.txtPass.TabIndex = 4
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtCPass
        '
        Me.txtCPass.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCPass.Border.Class = "TextBoxBorder"
        Me.txtCPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCPass.DisabledBackColor = System.Drawing.Color.White
        Me.txtCPass.ForeColor = System.Drawing.Color.Black
        Me.txtCPass.Location = New System.Drawing.Point(140, 197)
        Me.txtCPass.Name = "txtCPass"
        Me.txtCPass.PreventEnterBeep = True
        Me.txtCPass.Size = New System.Drawing.Size(134, 20)
        Me.txtCPass.TabIndex = 5
        Me.txtCPass.UseSystemPasswordChar = True
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGuardar.FocusCuesEnabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(108, 365)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 10, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancelar.FocusCuesEnabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(189, 365)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 10, 0, 10)
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(35, 18)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(238, 23)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "Nuevo Usuario"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(86, 78)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(47, 23)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Nombre:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(86, 136)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(48, 23)
        Me.LabelX3.TabIndex = 8
        Me.LabelX3.Text = "Usuario:"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(66, 165)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(68, 23)
        Me.LabelX4.TabIndex = 9
        Me.LabelX4.Text = "Contraseña:"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(22, 194)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(112, 23)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "Confirmar Contraseña:"
        '
        'LabelID
        '
        '
        '
        '
        Me.LabelID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelID.Location = New System.Drawing.Point(108, 49)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(24, 23)
        Me.LabelID.TabIndex = 12
        Me.LabelID.Text = "ID:"
        Me.LabelID.Visible = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtID.Border.Class = "TextBoxBorder"
        Me.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtID.DisabledBackColor = System.Drawing.Color.White
        Me.txtID.Enabled = False
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(138, 52)
        Me.txtID.Name = "txtID"
        Me.txtID.PreventEnterBeep = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(86, 107)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(48, 23)
        Me.LabelX6.TabIndex = 14
        Me.LabelX6.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtEmail.Border.Class = "TextBoxBorder"
        Me.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEmail.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(140, 110)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PreventEnterBeep = True
        Me.txtEmail.Size = New System.Drawing.Size(135, 20)
        Me.txtEmail.TabIndex = 2
        '
        'cbVentas
        '
        '
        '
        '
        Me.cbVentas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbVentas.FocusCuesEnabled = False
        Me.cbVentas.Location = New System.Drawing.Point(66, 260)
        Me.cbVentas.Name = "cbVentas"
        Me.cbVentas.Size = New System.Drawing.Size(58, 23)
        Me.cbVentas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbVentas.TabIndex = 15
        Me.cbVentas.TabStop = False
        Me.cbVentas.Text = "Ventas"
        '
        'cbBuses
        '
        '
        '
        '
        Me.cbBuses.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbBuses.FocusCuesEnabled = False
        Me.cbBuses.Location = New System.Drawing.Point(130, 260)
        Me.cbBuses.Name = "cbBuses"
        Me.cbBuses.Size = New System.Drawing.Size(58, 23)
        Me.cbBuses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbBuses.TabIndex = 16
        Me.cbBuses.TabStop = False
        Me.cbBuses.Text = "Buses"
        '
        'cbClientes
        '
        '
        '
        '
        Me.cbClientes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbClientes.FocusCuesEnabled = False
        Me.cbClientes.Location = New System.Drawing.Point(194, 260)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(58, 23)
        Me.cbClientes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbClientes.TabIndex = 17
        Me.cbClientes.TabStop = False
        Me.cbClientes.Text = "Clientes"
        '
        'cbItinerario
        '
        '
        '
        '
        Me.cbItinerario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbItinerario.FocusCuesEnabled = False
        Me.cbItinerario.Location = New System.Drawing.Point(258, 260)
        Me.cbItinerario.Name = "cbItinerario"
        Me.cbItinerario.Size = New System.Drawing.Size(66, 23)
        Me.cbItinerario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbItinerario.TabIndex = 18
        Me.cbItinerario.TabStop = False
        Me.cbItinerario.Text = "Itinerario"
        '
        'cbCiudades
        '
        '
        '
        '
        Me.cbCiudades.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbCiudades.FocusCuesEnabled = False
        Me.cbCiudades.Location = New System.Drawing.Point(79, 289)
        Me.cbCiudades.Name = "cbCiudades"
        Me.cbCiudades.Size = New System.Drawing.Size(68, 23)
        Me.cbCiudades.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbCiudades.TabIndex = 19
        Me.cbCiudades.TabStop = False
        Me.cbCiudades.Text = "Ciudades"
        '
        'cbUsuarios
        '
        '
        '
        '
        Me.cbUsuarios.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbUsuarios.FocusCuesEnabled = False
        Me.cbUsuarios.Location = New System.Drawing.Point(153, 289)
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.Size = New System.Drawing.Size(60, 23)
        Me.cbUsuarios.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbUsuarios.TabIndex = 20
        Me.cbUsuarios.TabStop = False
        Me.cbUsuarios.Text = "Usuarios"
        '
        'cbEncomiendas
        '
        '
        '
        '
        Me.cbEncomiendas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbEncomiendas.FocusCuesEnabled = False
        Me.cbEncomiendas.Location = New System.Drawing.Point(219, 289)
        Me.cbEncomiendas.Name = "cbEncomiendas"
        Me.cbEncomiendas.Size = New System.Drawing.Size(91, 23)
        Me.cbEncomiendas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbEncomiendas.TabIndex = 21
        Me.cbEncomiendas.TabStop = False
        Me.cbEncomiendas.Text = "Encomiendas"
        '
        'cbAdmin
        '
        '
        '
        '
        Me.cbAdmin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbAdmin.FocusCuesEnabled = False
        Me.cbAdmin.Location = New System.Drawing.Point(140, 223)
        Me.cbAdmin.Name = "cbAdmin"
        Me.cbAdmin.Size = New System.Drawing.Size(98, 23)
        Me.cbAdmin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbAdmin.TabIndex = 22
        Me.cbAdmin.TabStop = False
        Me.cbAdmin.Text = "Administrador"
        '
        'ucUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.cbAdmin)
        Me.Controls.Add(Me.cbEncomiendas)
        Me.Controls.Add(Me.cbUsuarios)
        Me.Controls.Add(Me.cbCiudades)
        Me.Controls.Add(Me.cbItinerario)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.cbBuses)
        Me.Controls.Add(Me.cbVentas)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "ucUsuarios"
        Me.Size = New System.Drawing.Size(360, 400)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelID As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbVentas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbBuses As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbClientes As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbItinerario As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbCiudades As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbUsuarios As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbEncomiendas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbAdmin As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
