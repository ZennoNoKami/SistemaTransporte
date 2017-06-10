<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bus
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btn2 = New DevComponents.DotNetBar.ButtonX()
        Me.btn1 = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtIdbus = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCant = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(162, 24)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Id AutoBus:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(122, 84)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(115, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Cantidad de asientos:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txtCant)
        Me.GroupPanel1.Controls.Add(Me.txtIdbus)
        Me.GroupPanel1.Controls.Add(Me.btn2)
        Me.GroupPanel1.Controls.Add(Me.btn1)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 21)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(673, 159)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 4
        Me.GroupPanel1.Text = "Detalles"
        '
        'btn2
        '
        Me.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn2.Location = New System.Drawing.Point(487, 76)
        Me.btn2.Name = "btn2"
        Me.btn2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btn2.Size = New System.Drawing.Size(75, 32)
        Me.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "Cancelar"
        '
        'btn1
        '
        Me.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn1.Location = New System.Drawing.Point(487, 26)
        Me.btn1.Name = "btn1"
        Me.btn1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btn1.Size = New System.Drawing.Size(75, 32)
        Me.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn1.TabIndex = 4
        Me.btn1.Text = "Nuevo"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.SistemaTransporte.My.Resources.Resources._03_Mercedes_Benz_Travego_Coach
        Me.PictureBox1.Location = New System.Drawing.Point(12, 195)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(673, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txtIdbus
        '
        Me.txtIdbus.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdbus.Border.Class = "TextBoxBorder"
        Me.txtIdbus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdbus.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdbus.ForeColor = System.Drawing.Color.Black
        Me.txtIdbus.Location = New System.Drawing.Point(243, 24)
        Me.txtIdbus.Name = "txtIdbus"
        Me.txtIdbus.PreventEnterBeep = True
        Me.txtIdbus.Size = New System.Drawing.Size(100, 22)
        Me.txtIdbus.TabIndex = 6
        '
        'txtCant
        '
        Me.txtCant.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCant.Border.Class = "TextBoxBorder"
        Me.txtCant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCant.DisabledBackColor = System.Drawing.Color.White
        Me.txtCant.ForeColor = System.Drawing.Color.Black
        Me.txtCant.Location = New System.Drawing.Point(243, 85)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.PreventEnterBeep = True
        Me.txtCant.Size = New System.Drawing.Size(100, 22)
        Me.txtCant.TabIndex = 7
        '
        'Bus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 457)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Bus"
        Me.Text = ".:. Bus .:."
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCant As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdbus As DevComponents.DotNetBar.Controls.TextBoxX
End Class
