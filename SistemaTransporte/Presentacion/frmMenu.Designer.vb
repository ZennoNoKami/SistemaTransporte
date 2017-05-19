<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.btnItinerario = New DevComponents.DotNetBar.ButtonX()
        Me.btnCiudades = New DevComponents.DotNetBar.ButtonX()
        Me.btnCliente = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnUsr = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSalir.FocusCuesEnabled = False
        Me.btnSalir.Image = Global.SistemaTransporte.My.Resources.Resources.Logout_Rounded_Up_50
        Me.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSalir.Location = New System.Drawing.Point(193, 146)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.btnSalir.Size = New System.Drawing.Size(180, 300)
        Me.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnSalir.TabIndex = 4
        '
        'btnItinerario
        '
        Me.btnItinerario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnItinerario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnItinerario.FocusCuesEnabled = False
        Me.btnItinerario.Image = Global.SistemaTransporte.My.Resources.Resources.Leave_50
        Me.btnItinerario.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.btnItinerario.Location = New System.Drawing.Point(626, 301)
        Me.btnItinerario.Name = "btnItinerario"
        Me.btnItinerario.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.btnItinerario.Size = New System.Drawing.Size(241, 145)
        Me.btnItinerario.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnItinerario.TabIndex = 3
        '
        'btnCiudades
        '
        Me.btnCiudades.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCiudades.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCiudades.FocusCuesEnabled = False
        Me.btnCiudades.Image = Global.SistemaTransporte.My.Resources.Resources.Bus_50
        Me.btnCiudades.Location = New System.Drawing.Point(379, 301)
        Me.btnCiudades.Name = "btnCiudades"
        Me.btnCiudades.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.btnCiudades.Size = New System.Drawing.Size(241, 145)
        Me.btnCiudades.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnCiudades.TabIndex = 2
        '
        'btnCliente
        '
        Me.btnCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCliente.FocusCuesEnabled = False
        Me.btnCliente.Image = Global.SistemaTransporte.My.Resources.Resources.User_2
        Me.btnCliente.Location = New System.Drawing.Point(626, 146)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.btnCliente.Size = New System.Drawing.Size(241, 149)
        Me.btnCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnCliente.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Image = Global.SistemaTransporte.My.Resources.Resources.User
        Me.ButtonX1.Location = New System.Drawing.Point(379, 146)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.ButtonX1.Size = New System.Drawing.Size(241, 149)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.ButtonX1.TabIndex = 0
        '
        'btnUsr
        '
        Me.btnUsr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUsr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnUsr.FocusCuesEnabled = False
        Me.btnUsr.Location = New System.Drawing.Point(1243, 12)
        Me.btnUsr.Name = "btnUsr"
        Me.btnUsr.Size = New System.Drawing.Size(95, 23)
        Me.btnUsr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUsr.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        Me.btnUsr.TabIndex = 6
        Me.btnUsr.Text = "1"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonItem1.Text = "Cerrar Sesión"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.SistemaTransporte.My.Resources.Resources.Add_Ticket_50
        Me.ButtonX2.Location = New System.Drawing.Point(873, 146)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8)
        Me.ButtonX2.Size = New System.Drawing.Size(241, 149)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 7
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.btnUsr)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnItinerario)
        Me.Controls.Add(Me.btnCiudades)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.ButtonX1)
        Me.DoubleBuffered = True
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCiudades As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnItinerario As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnUsr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
