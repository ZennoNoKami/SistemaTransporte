<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCiudades
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Ciudades = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btn2 = New DevComponents.DotNetBar.ButtonX()
        Me.btn1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtCiudad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelCiudad = New DevComponents.DotNetBar.LabelX()
        Me.txtID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelID = New DevComponents.DotNetBar.LabelX()
        Me.Ciudades.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ciudades
        '
        Me.Ciudades.BackColor = System.Drawing.Color.White
        Me.Ciudades.CanvasColor = System.Drawing.SystemColors.Control
        Me.Ciudades.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Ciudades.Controls.Add(Me.btn2)
        Me.Ciudades.Controls.Add(Me.btn1)
        Me.Ciudades.Controls.Add(Me.txtCiudad)
        Me.Ciudades.Controls.Add(Me.LabelCiudad)
        Me.Ciudades.Controls.Add(Me.txtID)
        Me.Ciudades.Controls.Add(Me.LabelID)
        Me.Ciudades.DisabledBackColor = System.Drawing.Color.Empty
        Me.Ciudades.Location = New System.Drawing.Point(87, 125)
        Me.Ciudades.Name = "Ciudades"
        Me.Ciudades.Size = New System.Drawing.Size(249, 281)
        '
        '
        '
        Me.Ciudades.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Ciudades.Style.BackColorGradientAngle = 90
        Me.Ciudades.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Ciudades.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Ciudades.Style.BorderBottomWidth = 1
        Me.Ciudades.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Ciudades.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Ciudades.Style.BorderLeftWidth = 1
        Me.Ciudades.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Ciudades.Style.BorderRightWidth = 1
        Me.Ciudades.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Ciudades.Style.BorderTopWidth = 1
        Me.Ciudades.Style.CornerDiameter = 4
        Me.Ciudades.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Ciudades.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Ciudades.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Ciudades.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Ciudades.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Ciudades.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Ciudades.TabIndex = 1
        Me.Ciudades.Text = "Ciudades"
        '
        'btn2
        '
        Me.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn2.Enabled = False
        Me.btn2.FocusCuesEnabled = False
        Me.btn2.Location = New System.Drawing.Point(125, 216)
        Me.btn2.Name = "btn2"
        Me.btn2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 10, 0, 10)
        Me.btn2.Size = New System.Drawing.Size(100, 30)
        Me.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn2.TabIndex = 0
        Me.btn2.TabStop = False
        Me.btn2.Text = "Editar"
        '
        'btn1
        '
        Me.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn1.FocusCuesEnabled = False
        Me.btn1.Location = New System.Drawing.Point(19, 216)
        Me.btn1.Name = "btn1"
        Me.btn1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 10, 0)
        Me.btn1.Size = New System.Drawing.Size(100, 30)
        Me.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn1.TabIndex = 0
        Me.btn1.TabStop = False
        Me.btn1.Text = "Nuevo"
        '
        'txtCiudad
        '
        Me.txtCiudad.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCiudad.Border.Class = "TextBoxBorder"
        Me.txtCiudad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCiudad.DisabledBackColor = System.Drawing.Color.White
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.ForeColor = System.Drawing.Color.Black
        Me.txtCiudad.Location = New System.Drawing.Point(112, 113)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.PreventEnterBeep = True
        Me.txtCiudad.Size = New System.Drawing.Size(100, 20)
        Me.txtCiudad.TabIndex = 2
        '
        'LabelCiudad
        '
        '
        '
        '
        Me.LabelCiudad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelCiudad.Location = New System.Drawing.Point(26, 113)
        Me.LabelCiudad.Name = "LabelCiudad"
        Me.LabelCiudad.Size = New System.Drawing.Size(47, 20)
        Me.LabelCiudad.TabIndex = 2
        Me.LabelCiudad.Text = "Ciudad"
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
        Me.txtID.Location = New System.Drawing.Point(112, 46)
        Me.txtID.Name = "txtID"
        Me.txtID.PreventEnterBeep = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'LabelID
        '
        '
        '
        '
        Me.LabelID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelID.Location = New System.Drawing.Point(26, 46)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(59, 20)
        Me.LabelID.TabIndex = 0
        Me.LabelID.Text = "IDCiudad"
        '
        'ucCiudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Ciudades)
        Me.Name = "ucCiudades"
        Me.Size = New System.Drawing.Size(449, 609)
        Me.Ciudades.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ciudades As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btn2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCiudad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelCiudad As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelID As DevComponents.DotNetBar.LabelX
End Class
