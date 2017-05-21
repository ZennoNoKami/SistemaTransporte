<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.t_edad = New DevComponents.Editors.IntegerInput()
        Me.mtbIdentidad = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.mtbTelefono = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.btn2 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.btn1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtDireccion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelID = New DevComponents.DotNetBar.LabelX()
        Me.txtID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtbuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ID = New DevComponents.Editors.ComboItem()
        Me.Nombre = New DevComponents.Editors.ComboItem()
        Me.Identidad = New DevComponents.Editors.ComboItem()
        Me.nodata = New System.Windows.Forms.LinkLabel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cbEliminar = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.dgv1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.GroupPanel1.SuspendLayout()
        CType(Me.t_edad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GroupPanel1.Controls.Add(Me.t_edad)
        Me.GroupPanel1.Controls.Add(Me.mtbIdentidad)
        Me.GroupPanel1.Controls.Add(Me.mtbTelefono)
        Me.GroupPanel1.Controls.Add(Me.btn2)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.btn1)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.txtDireccion)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.txtEmail)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.txtNombre)
        Me.GroupPanel1.Controls.Add(Me.LabelID)
        Me.GroupPanel1.Controls.Add(Me.txtID)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(288, 449)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Clientes"
        '
        't_edad
        '
        Me.t_edad.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.t_edad.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.t_edad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t_edad.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.t_edad.Enabled = False
        Me.t_edad.ForeColor = System.Drawing.Color.Black
        Me.t_edad.Location = New System.Drawing.Point(111, 148)
        Me.t_edad.MaxValue = 99
        Me.t_edad.MinValue = 0
        Me.t_edad.Name = "t_edad"
        Me.t_edad.ShowUpDown = True
        Me.t_edad.Size = New System.Drawing.Size(62, 22)
        Me.t_edad.TabIndex = 3
        '
        'mtbIdentidad
        '
        Me.mtbIdentidad.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.mtbIdentidad.BackgroundStyle.Class = "TextBoxBorder"
        Me.mtbIdentidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mtbIdentidad.ButtonClear.Visible = True
        Me.mtbIdentidad.DisabledBackColor = System.Drawing.Color.White
        Me.mtbIdentidad.Enabled = False
        Me.mtbIdentidad.ForeColor = System.Drawing.Color.Black
        Me.mtbIdentidad.Location = New System.Drawing.Point(111, 176)
        Me.mtbIdentidad.Mask = "0000-0000-00000"
        Me.mtbIdentidad.Name = "mtbIdentidad"
        Me.mtbIdentidad.Size = New System.Drawing.Size(146, 21)
        Me.mtbIdentidad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.mtbIdentidad.TabIndex = 4
        Me.mtbIdentidad.Text = ""
        '
        'mtbTelefono
        '
        Me.mtbTelefono.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.mtbTelefono.BackgroundStyle.Class = "TextBoxBorder"
        Me.mtbTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mtbTelefono.ButtonClear.Visible = True
        Me.mtbTelefono.DisabledBackColor = System.Drawing.Color.White
        Me.mtbTelefono.Enabled = False
        Me.mtbTelefono.ForeColor = System.Drawing.Color.Black
        Me.mtbTelefono.Location = New System.Drawing.Point(111, 203)
        Me.mtbTelefono.Mask = "0000-0000"
        Me.mtbTelefono.Name = "mtbTelefono"
        Me.mtbTelefono.Size = New System.Drawing.Size(146, 21)
        Me.mtbTelefono.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.mtbTelefono.TabIndex = 5
        Me.mtbTelefono.Text = ""
        '
        'btn2
        '
        Me.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn2.Enabled = False
        Me.btn2.FocusCuesEnabled = False
        Me.btn2.Location = New System.Drawing.Point(141, 376)
        Me.btn2.Name = "btn2"
        Me.btn2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 10, 0, 10)
        Me.btn2.Size = New System.Drawing.Size(100, 30)
        Me.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn2.TabIndex = 0
        Me.btn2.TabStop = False
        Me.btn2.Text = "Editar"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(23, 203)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(55, 23)
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "Teléfono"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(23, 145)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(37, 23)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "Edad"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btn1
        '
        Me.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn1.FocusCuesEnabled = False
        Me.btn1.Location = New System.Drawing.Point(35, 376)
        Me.btn1.Name = "btn1"
        Me.btn1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 10, 0)
        Me.btn1.Size = New System.Drawing.Size(100, 30)
        Me.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn1.TabIndex = 0
        Me.btn1.TabStop = False
        Me.btn1.Text = "Nuevo"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(23, 232)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(55, 23)
        Me.LabelX5.TabIndex = 9
        Me.LabelX5.Text = "Dirección"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDireccion.Border.Class = "TextBoxBorder"
        Me.txtDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.ForeColor = System.Drawing.Color.Black
        Me.txtDireccion.Location = New System.Drawing.Point(109, 232)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PreventEnterBeep = True
        Me.txtDireccion.Size = New System.Drawing.Size(145, 101)
        Me.txtDireccion.TabIndex = 6
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(23, 174)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(55, 23)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Identidad"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(23, 116)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(37, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Email"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.txtEmail.Enabled = False
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(111, 117)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PreventEnterBeep = True
        Me.txtEmail.Size = New System.Drawing.Size(161, 22)
        Me.txtEmail.TabIndex = 2
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(23, 87)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(50, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Nombre"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.txtNombre.Enabled = False
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(111, 86)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PreventEnterBeep = True
        Me.txtNombre.Size = New System.Drawing.Size(145, 22)
        Me.txtNombre.TabIndex = 1
        '
        'LabelID
        '
        Me.LabelID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelID.ForeColor = System.Drawing.Color.Black
        Me.LabelID.Location = New System.Drawing.Point(23, 58)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(55, 23)
        Me.LabelID.TabIndex = 1
        Me.LabelID.Text = "ID Cliente"
        Me.LabelID.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.txtID.Location = New System.Drawing.Point(111, 58)
        Me.txtID.Name = "txtID"
        Me.txtID.PreventEnterBeep = True
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 0
        Me.txtID.Visible = False
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
        Me.txtbuscar.Location = New System.Drawing.Point(3, 3)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.PreventEnterBeep = True
        Me.txtbuscar.Size = New System.Drawing.Size(327, 22)
        Me.txtbuscar.TabIndex = 0
        Me.txtbuscar.TabStop = False
        Me.txtbuscar.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtbuscar.WatermarkText = "Buscar"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx1.FocusCuesEnabled = False
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 17
        Me.ComboBoxEx1.Items.AddRange(New Object() {Me.ID, Me.Nombre, Me.Identidad})
        Me.ComboBoxEx1.Location = New System.Drawing.Point(336, 3)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 0
        Me.ComboBoxEx1.TabStop = False
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        '
        'Identidad
        '
        Me.Identidad.Text = "Identidad"
        '
        'nodata
        '
        Me.nodata.AutoSize = True
        Me.nodata.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nodata.ForeColor = System.Drawing.Color.Black
        Me.nodata.Location = New System.Drawing.Point(372, 202)
        Me.nodata.Name = "nodata"
        Me.nodata.Size = New System.Drawing.Size(75, 13)
        Me.nodata.TabIndex = 4
        Me.nodata.TabStop = True
        Me.nodata.Text = "No hay datos"
        Me.nodata.Visible = False
        Me.nodata.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel2.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.cbEliminar)
        Me.GroupPanel2.Controls.Add(Me.nodata)
        Me.GroupPanel2.Controls.Add(Me.dgv1)
        Me.GroupPanel2.Controls.Add(Me.btnEliminar)
        Me.GroupPanel2.Controls.Add(Me.txtbuscar)
        Me.GroupPanel2.Controls.Add(Me.ComboBoxEx1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(353, 13)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(769, 448)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 5
        Me.GroupPanel2.Text = "Listado de Clientes"
        '
        'cbEliminar
        '
        Me.cbEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.cbEliminar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbEliminar.ForeColor = System.Drawing.Color.Black
        Me.cbEliminar.Location = New System.Drawing.Point(463, 3)
        Me.cbEliminar.Name = "cbEliminar"
        Me.cbEliminar.Size = New System.Drawing.Size(63, 23)
        Me.cbEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbEliminar.TabIndex = 0
        Me.cbEliminar.TabStop = False
        Me.cbEliminar.Text = "Eliminar"
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv1.EnableHeadersVisualStyles = False
        Me.dgv1.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgv1.Location = New System.Drawing.Point(3, 31)
        Me.dgv1.Name = "dgv1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(757, 391)
        Me.dgv1.TabIndex = 0
        Me.dgv1.TabStop = False
        Me.dgv1.UseCustomBackgroundColor = True
        '
        'Eliminar
        '
        Me.Eliminar.FalseValue = "False"
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.TrueValue = "True"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEliminar.FocusCuesEnabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(552, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Visible = False
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 472)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(1150, 511)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.t_edad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nodata As LinkLabel
    Friend WithEvents ID As DevComponents.Editors.ComboItem
    Friend WithEvents Nombre As DevComponents.Editors.ComboItem
    Friend WithEvents Identidad As DevComponents.Editors.ComboItem
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents txtbuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents LabelID As DevComponents.DotNetBar.LabelX
    Private WithEvents txtID As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtDireccion As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents btn2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents mtbIdentidad As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Private WithEvents mtbTelefono As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Private WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgv1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cbEliminar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents t_edad As DevComponents.Editors.IntegerInput
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class
