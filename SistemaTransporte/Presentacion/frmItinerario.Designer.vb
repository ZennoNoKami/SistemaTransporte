<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItinerario
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Itinerario = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtHoraLlegada = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtHoraSalida = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.diPrecioEncomienda = New DevComponents.Editors.DoubleInput()
        Me.diPrecio = New DevComponents.Editors.DoubleInput()
        Me.cmbDestino = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btn2 = New DevComponents.DotNetBar.ButtonX()
        Me.btn1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelPrecioEncomienda = New DevComponents.DotNetBar.LabelX()
        Me.LabelPrecio = New DevComponents.DotNetBar.LabelX()
        Me.LabelIdAuto = New DevComponents.DotNetBar.LabelX()
        Me.cmbOrigen = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelDestino = New DevComponents.DotNetBar.LabelX()
        Me.LabelOrigen = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelID = New DevComponents.DotNetBar.LabelX()
        Me.dgv1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupPanel = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.nodata = New System.Windows.Forms.LinkLabel()
        Me.cbEliminar = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.txtbuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBoxEx3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Origen = New DevComponents.Editors.ComboItem()
        Me.Destino = New DevComponents.Editors.ComboItem()
        Me.txtIdAuto = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Itinerario.SuspendLayout()
        CType(Me.txtHoraLlegada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoraSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diPrecioEncomienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Itinerario
        '
        Me.Itinerario.BackColor = System.Drawing.Color.White
        Me.Itinerario.CanvasColor = System.Drawing.SystemColors.Control
        Me.Itinerario.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Itinerario.Controls.Add(Me.txtIdAuto)
        Me.Itinerario.Controls.Add(Me.txtHoraLlegada)
        Me.Itinerario.Controls.Add(Me.txtHoraSalida)
        Me.Itinerario.Controls.Add(Me.diPrecioEncomienda)
        Me.Itinerario.Controls.Add(Me.diPrecio)
        Me.Itinerario.Controls.Add(Me.cmbDestino)
        Me.Itinerario.Controls.Add(Me.btn2)
        Me.Itinerario.Controls.Add(Me.btn1)
        Me.Itinerario.Controls.Add(Me.LabelPrecioEncomienda)
        Me.Itinerario.Controls.Add(Me.LabelPrecio)
        Me.Itinerario.Controls.Add(Me.LabelIdAuto)
        Me.Itinerario.Controls.Add(Me.cmbOrigen)
        Me.Itinerario.Controls.Add(Me.LabelDestino)
        Me.Itinerario.Controls.Add(Me.LabelOrigen)
        Me.Itinerario.Controls.Add(Me.LabelX3)
        Me.Itinerario.Controls.Add(Me.LabelX2)
        Me.Itinerario.Controls.Add(Me.txtID)
        Me.Itinerario.Controls.Add(Me.LabelID)
        Me.Itinerario.DisabledBackColor = System.Drawing.Color.Empty
        Me.Itinerario.Location = New System.Drawing.Point(12, 12)
        Me.Itinerario.Name = "Itinerario"
        Me.Itinerario.Size = New System.Drawing.Size(336, 459)
        '
        '
        '
        Me.Itinerario.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Itinerario.Style.BackColorGradientAngle = 90
        Me.Itinerario.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Itinerario.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Itinerario.Style.BorderBottomWidth = 1
        Me.Itinerario.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Itinerario.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Itinerario.Style.BorderLeftWidth = 1
        Me.Itinerario.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Itinerario.Style.BorderRightWidth = 1
        Me.Itinerario.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Itinerario.Style.BorderTopWidth = 1
        Me.Itinerario.Style.CornerDiameter = 4
        Me.Itinerario.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Itinerario.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Itinerario.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Itinerario.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Itinerario.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Itinerario.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Itinerario.TabIndex = 0
        Me.Itinerario.Text = "Itinerario"
        '
        'txtHoraLlegada
        '
        '
        '
        '
        Me.txtHoraLlegada.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtHoraLlegada.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraLlegada.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtHoraLlegada.ButtonDropDown.Visible = True
        Me.txtHoraLlegada.Enabled = False
        Me.txtHoraLlegada.Format = DevComponents.Editors.eDateTimePickerFormat.ShortTime
        Me.txtHoraLlegada.IsPopupCalendarOpen = False
        Me.txtHoraLlegada.Location = New System.Drawing.Point(136, 121)
        '
        '
        '
        '
        '
        '
        Me.txtHoraLlegada.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraLlegada.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.txtHoraLlegada.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtHoraLlegada.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtHoraLlegada.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtHoraLlegada.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtHoraLlegada.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtHoraLlegada.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtHoraLlegada.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtHoraLlegada.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraLlegada.MonthCalendar.DisplayMonth = New Date(2017, 5, 1, 0, 0, 0, 0)
        Me.txtHoraLlegada.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.txtHoraLlegada.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtHoraLlegada.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtHoraLlegada.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtHoraLlegada.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraLlegada.MonthCalendar.TodayButtonVisible = True
        Me.txtHoraLlegada.MonthCalendar.Visible = False
        Me.txtHoraLlegada.Name = "txtHoraLlegada"
        Me.txtHoraLlegada.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraLlegada.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtHoraLlegada.TabIndex = 19
        '
        'txtHoraSalida
        '
        '
        '
        '
        Me.txtHoraSalida.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtHoraSalida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraSalida.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtHoraSalida.ButtonDropDown.Visible = True
        Me.txtHoraSalida.Enabled = False
        Me.txtHoraSalida.Format = DevComponents.Editors.eDateTimePickerFormat.ShortTime
        Me.txtHoraSalida.IsPopupCalendarOpen = False
        Me.txtHoraSalida.Location = New System.Drawing.Point(136, 79)
        '
        '
        '
        '
        '
        '
        Me.txtHoraSalida.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraSalida.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.txtHoraSalida.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtHoraSalida.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtHoraSalida.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtHoraSalida.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtHoraSalida.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtHoraSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtHoraSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtHoraSalida.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraSalida.MonthCalendar.DisplayMonth = New Date(2017, 5, 1, 0, 0, 0, 0)
        Me.txtHoraSalida.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.txtHoraSalida.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtHoraSalida.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtHoraSalida.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtHoraSalida.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHoraSalida.MonthCalendar.TodayButtonVisible = True
        Me.txtHoraSalida.MonthCalendar.Visible = False
        Me.txtHoraSalida.Name = "txtHoraSalida"
        Me.txtHoraSalida.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraSalida.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtHoraSalida.TabIndex = 2
        '
        'diPrecioEncomienda
        '
        '
        '
        '
        Me.diPrecioEncomienda.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.diPrecioEncomienda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.diPrecioEncomienda.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.diPrecioEncomienda.Enabled = False
        Me.diPrecioEncomienda.Increment = 1.0R
        Me.diPrecioEncomienda.Location = New System.Drawing.Point(136, 323)
        Me.diPrecioEncomienda.Name = "diPrecioEncomienda"
        Me.diPrecioEncomienda.ShowUpDown = True
        Me.diPrecioEncomienda.Size = New System.Drawing.Size(100, 20)
        Me.diPrecioEncomienda.TabIndex = 8
        '
        'diPrecio
        '
        '
        '
        '
        Me.diPrecio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.diPrecio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.diPrecio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.diPrecio.Enabled = False
        Me.diPrecio.Increment = 1.0R
        Me.diPrecio.Location = New System.Drawing.Point(136, 284)
        Me.diPrecio.Name = "diPrecio"
        Me.diPrecio.ShowUpDown = True
        Me.diPrecio.Size = New System.Drawing.Size(100, 20)
        Me.diPrecio.TabIndex = 7
        '
        'cmbDestino
        '
        Me.cmbDestino.DisplayMember = "Text"
        Me.cmbDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDestino.Enabled = False
        Me.cmbDestino.ForeColor = System.Drawing.Color.Black
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.ItemHeight = 15
        Me.cmbDestino.Location = New System.Drawing.Point(136, 201)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(121, 21)
        Me.cmbDestino.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbDestino.TabIndex = 5
        '
        'btn2
        '
        Me.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn2.Enabled = False
        Me.btn2.FocusCuesEnabled = False
        Me.btn2.Location = New System.Drawing.Point(157, 384)
        Me.btn2.Name = "btn2"
        Me.btn2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 10, 0, 10)
        Me.btn2.Size = New System.Drawing.Size(100, 30)
        Me.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn2.TabIndex = 17
        Me.btn2.TabStop = False
        Me.btn2.Text = "Editar"
        '
        'btn1
        '
        Me.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn1.FocusCuesEnabled = False
        Me.btn1.Location = New System.Drawing.Point(51, 384)
        Me.btn1.Name = "btn1"
        Me.btn1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 0, 10, 0)
        Me.btn1.Size = New System.Drawing.Size(100, 30)
        Me.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn1.TabIndex = 18
        Me.btn1.TabStop = False
        Me.btn1.Text = "Nuevo"
        '
        'LabelPrecioEncomienda
        '
        '
        '
        '
        Me.LabelPrecioEncomienda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelPrecioEncomienda.Location = New System.Drawing.Point(27, 323)
        Me.LabelPrecioEncomienda.Name = "LabelPrecioEncomienda"
        Me.LabelPrecioEncomienda.Size = New System.Drawing.Size(103, 23)
        Me.LabelPrecioEncomienda.TabIndex = 14
        Me.LabelPrecioEncomienda.Text = "Precio Encomienda"
        '
        'LabelPrecio
        '
        '
        '
        '
        Me.LabelPrecio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelPrecio.Location = New System.Drawing.Point(27, 284)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(75, 23)
        Me.LabelPrecio.TabIndex = 12
        Me.LabelPrecio.Text = "Precio"
        '
        'LabelIdAuto
        '
        '
        '
        '
        Me.LabelIdAuto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelIdAuto.Location = New System.Drawing.Point(27, 242)
        Me.LabelIdAuto.Name = "LabelIdAuto"
        Me.LabelIdAuto.Size = New System.Drawing.Size(75, 23)
        Me.LabelIdAuto.TabIndex = 10
        Me.LabelIdAuto.Text = "IdAutobus"
        '
        'cmbOrigen
        '
        Me.cmbOrigen.AutoCompleteCustomSource.AddRange(New String() {"La Ceiba", "Tegucilpa" & Global.Microsoft.VisualBasic.ChrW(9), "San Pedro Sula", "Tela "})
        Me.cmbOrigen.DisplayMember = "Text"
        Me.cmbOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrigen.Enabled = False
        Me.cmbOrigen.ForeColor = System.Drawing.Color.Black
        Me.cmbOrigen.FormattingEnabled = True
        Me.cmbOrigen.ItemHeight = 15
        Me.cmbOrigen.Location = New System.Drawing.Point(136, 160)
        Me.cmbOrigen.Name = "cmbOrigen"
        Me.cmbOrigen.Size = New System.Drawing.Size(121, 21)
        Me.cmbOrigen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbOrigen.TabIndex = 4
        '
        'LabelDestino
        '
        '
        '
        '
        Me.LabelDestino.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelDestino.Location = New System.Drawing.Point(27, 201)
        Me.LabelDestino.Name = "LabelDestino"
        Me.LabelDestino.Size = New System.Drawing.Size(75, 23)
        Me.LabelDestino.TabIndex = 8
        Me.LabelDestino.Text = "Destino"
        '
        'LabelOrigen
        '
        '
        '
        '
        Me.LabelOrigen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelOrigen.Location = New System.Drawing.Point(27, 160)
        Me.LabelOrigen.Name = "LabelOrigen"
        Me.LabelOrigen.Size = New System.Drawing.Size(75, 23)
        Me.LabelOrigen.TabIndex = 6
        Me.LabelOrigen.Text = "Origen"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(27, 121)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Hora Llegada"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(27, 79)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Hora Salida"
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
        Me.txtID.Location = New System.Drawing.Point(136, 41)
        Me.txtID.Name = "txtID"
        Me.txtID.PreventEnterBeep = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.Visible = False
        '
        'LabelID
        '
        '
        '
        '
        Me.LabelID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelID.Location = New System.Drawing.Point(27, 38)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(75, 23)
        Me.LabelID.TabIndex = 0
        Me.LabelID.Text = "IDItinerario"
        Me.LabelID.Visible = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.EnableHeadersVisualStyles = False
        Me.dgv1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgv1.Location = New System.Drawing.Point(3, 39)
        Me.dgv1.Name = "dgv1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(799, 396)
        Me.dgv1.TabIndex = 2
        '
        'Eliminar
        '
        Me.Eliminar.FalseValue = "False"
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.TrueValue = "True"
        '
        'GroupPanel
        '
        Me.GroupPanel.BackColor = System.Drawing.Color.White
        Me.GroupPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel.Controls.Add(Me.nodata)
        Me.GroupPanel.Controls.Add(Me.cbEliminar)
        Me.GroupPanel.Controls.Add(Me.btnEliminar)
        Me.GroupPanel.Controls.Add(Me.txtbuscar)
        Me.GroupPanel.Controls.Add(Me.ComboBoxEx3)
        Me.GroupPanel.Controls.Add(Me.dgv1)
        Me.GroupPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel.Location = New System.Drawing.Point(386, 18)
        Me.GroupPanel.Name = "GroupPanel"
        Me.GroupPanel.Size = New System.Drawing.Size(811, 459)
        '
        '
        '
        Me.GroupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel.Style.BackColorGradientAngle = 90
        Me.GroupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel.Style.BorderBottomWidth = 1
        Me.GroupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel.Style.BorderLeftWidth = 1
        Me.GroupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel.Style.BorderRightWidth = 1
        Me.GroupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel.Style.BorderTopWidth = 1
        Me.GroupPanel.Style.CornerDiameter = 4
        Me.GroupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel.TabIndex = 3
        Me.GroupPanel.Text = "Listado de Itinerario"
        '
        'nodata
        '
        Me.nodata.AutoSize = True
        Me.nodata.Location = New System.Drawing.Point(367, 213)
        Me.nodata.Name = "nodata"
        Me.nodata.Size = New System.Drawing.Size(70, 13)
        Me.nodata.TabIndex = 7
        Me.nodata.TabStop = True
        Me.nodata.Text = "No hay datos"
        Me.nodata.Visible = False
        Me.nodata.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'cbEliminar
        '
        '
        '
        '
        Me.cbEliminar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbEliminar.Location = New System.Drawing.Point(463, 11)
        Me.cbEliminar.Name = "cbEliminar"
        Me.cbEliminar.Size = New System.Drawing.Size(63, 23)
        Me.cbEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbEliminar.TabIndex = 3
        Me.cbEliminar.TabStop = False
        Me.cbEliminar.Text = "Eliminar"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEliminar.FocusCuesEnabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(552, 10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Visible = False
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
        Me.txtbuscar.Location = New System.Drawing.Point(3, 11)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.PreventEnterBeep = True
        Me.txtbuscar.Size = New System.Drawing.Size(327, 20)
        Me.txtbuscar.TabIndex = 5
        Me.txtbuscar.TabStop = False
        Me.txtbuscar.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtbuscar.WatermarkText = "Buscar"
        '
        'ComboBoxEx3
        '
        Me.ComboBoxEx3.DisplayMember = "Text"
        Me.ComboBoxEx3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx3.FocusCuesEnabled = False
        Me.ComboBoxEx3.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx3.FormattingEnabled = True
        Me.ComboBoxEx3.ItemHeight = 17
        Me.ComboBoxEx3.Items.AddRange(New Object() {Me.Origen, Me.Destino})
        Me.ComboBoxEx3.Location = New System.Drawing.Point(336, 11)
        Me.ComboBoxEx3.Name = "ComboBoxEx3"
        Me.ComboBoxEx3.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxEx3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx3.TabIndex = 6
        Me.ComboBoxEx3.TabStop = False
        '
        'Origen
        '
        Me.Origen.Text = "Origen"
        '
        'Destino
        '
        Me.Destino.Text = "Destino"
        '
        'txtIdAuto
        '
        Me.txtIdAuto.DisplayMember = "Text"
        Me.txtIdAuto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtIdAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtIdAuto.Enabled = False
        Me.txtIdAuto.ForeColor = System.Drawing.Color.Black
        Me.txtIdAuto.FormattingEnabled = True
        Me.txtIdAuto.ItemHeight = 15
        Me.txtIdAuto.Location = New System.Drawing.Point(136, 242)
        Me.txtIdAuto.Name = "txtIdAuto"
        Me.txtIdAuto.Size = New System.Drawing.Size(121, 21)
        Me.txtIdAuto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtIdAuto.TabIndex = 20
        '
        'frmItinerario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1248, 489)
        Me.Controls.Add(Me.GroupPanel)
        Me.Controls.Add(Me.Itinerario)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmItinerario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Itinerario"
        Me.Itinerario.ResumeLayout(False)
        CType(Me.txtHoraLlegada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoraSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diPrecioEncomienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel.ResumeLayout(False)
        Me.GroupPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Itinerario As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelPrecioEncomienda As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelPrecio As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelIdAuto As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelDestino As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelOrigen As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelID As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgv1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cbEliminar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Private WithEvents txtbuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents ComboBoxEx3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Origen As DevComponents.Editors.ComboItem
    Friend WithEvents Destino As DevComponents.Editors.ComboItem
    Private WithEvents btn2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents nodata As System.Windows.Forms.LinkLabel
    Friend WithEvents txtHoraSalida As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtHoraLlegada As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents diPrecioEncomienda As DevComponents.Editors.DoubleInput
    Friend WithEvents diPrecio As DevComponents.Editors.DoubleInput
    Friend WithEvents cmbDestino As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbOrigen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtIdAuto As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
