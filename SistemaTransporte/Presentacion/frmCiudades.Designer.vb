<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCiudades
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Ciudades = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btn2 = New DevComponents.DotNetBar.ButtonX()
        Me.btn1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtCiudad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelCiudad = New DevComponents.DotNetBar.LabelX()
        Me.txtID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelID = New DevComponents.DotNetBar.LabelX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.txtbuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dgv1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.nodata = New System.Windows.Forms.LinkLabel()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cbEliminar = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Ciudades.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
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
        Me.Ciudades.Location = New System.Drawing.Point(23, 12)
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
        Me.Ciudades.TabIndex = 0
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
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEliminar.FocusCuesEnabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(432, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnEliminar.Size = New System.Drawing.Size(73, 23)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "Eliminar"
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtbuscar.Border.Class = "TextBoxBorder"
        Me.txtbuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtbuscar.DisabledBackColor = System.Drawing.Color.White
        Me.txtbuscar.ForeColor = System.Drawing.Color.Black
        Me.txtbuscar.Location = New System.Drawing.Point(19, 3)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.PreventEnterBeep = True
        Me.txtbuscar.Size = New System.Drawing.Size(201, 20)
        Me.txtbuscar.TabIndex = 0
        Me.txtbuscar.TabStop = False
        Me.txtbuscar.WatermarkText = "Buscar"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.BackgroundColor = System.Drawing.Color.White
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgv1.Location = New System.Drawing.Point(3, 29)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(747, 306)
        Me.dgv1.TabIndex = 0
        Me.dgv1.TabStop = False
        Me.dgv1.Tag = ""
        Me.dgv1.UseCustomBackgroundColor = True
        '
        'nodata
        '
        Me.nodata.AutoSize = True
        Me.nodata.Location = New System.Drawing.Point(318, 154)
        Me.nodata.Name = "nodata"
        Me.nodata.Size = New System.Drawing.Size(70, 13)
        Me.nodata.TabIndex = 9
        Me.nodata.TabStop = True
        Me.nodata.Text = "No hay datos"
        Me.nodata.Visible = False
        Me.nodata.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 15
        Me.ComboBoxEx1.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.ComboBoxEx1.Location = New System.Drawing.Point(226, 3)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 0
        Me.ComboBoxEx1.TabStop = False
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "ID"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Nombre"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cbEliminar)
        Me.GroupPanel1.Controls.Add(Me.nodata)
        Me.GroupPanel1.Controls.Add(Me.dgv1)
        Me.GroupPanel1.Controls.Add(Me.txtbuscar)
        Me.GroupPanel1.Controls.Add(Me.btnEliminar)
        Me.GroupPanel1.Controls.Add(Me.ComboBoxEx1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(323, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(759, 364)
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
        Me.GroupPanel1.TabIndex = 11
        Me.GroupPanel1.Text = "Lista de Ciudades"
        '
        'cbEliminar
        '
        '
        '
        '
        Me.cbEliminar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbEliminar.Location = New System.Drawing.Point(363, 1)
        Me.cbEliminar.Name = "cbEliminar"
        Me.cbEliminar.Size = New System.Drawing.Size(63, 23)
        Me.cbEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbEliminar.TabIndex = 10
        Me.cbEliminar.TabStop = False
        Me.cbEliminar.Text = "Eliminar"
        '
        'Eliminar
        '
        Me.Eliminar.FalseValue = "False"
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.TrueValue = "True"
        '
        'frmCiudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1094, 394)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Ciudades)
        Me.DoubleBuffered = True
        Me.Name = "frmCiudades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ciudades"
        Me.Ciudades.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ciudades As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btn2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCiudad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelCiudad As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelID As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtbuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgv1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents nodata As System.Windows.Forms.LinkLabel
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cbEliminar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
End Class
