<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.btnGroup = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPerfil = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.btnUsr = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSalir = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnUsuarios = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEncomiendas = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnCiudades = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnItinerario = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnClientes = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnVentas = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.btnGroup.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuThinButton23)
        Me.Panel1.Controls.Add(Me.BunifuThinButton22)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnUsuarios)
        Me.Panel1.Controls.Add(Me.btnEncomiendas)
        Me.Panel1.Controls.Add(Me.btnCiudades)
        Me.Panel1.Controls.Add(Me.btnItinerario)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.btnClientes)
        Me.Panel1.Controls.Add(Me.btnVentas)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(161, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 500)
        Me.Panel1.TabIndex = 0
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        '
        'btnGroup
        '
        Me.btnGroup.Controls.Add(Me.btnPerfil)
        Me.btnGroup.Controls.Add(Me.ButtonX2)
        Me.btnGroup.Controls.Add(Me.ButtonX3)
        Me.BunifuTransition1.SetDecoration(Me.btnGroup, BunifuAnimatorNS.DecorationType.None)
        Me.btnGroup.Location = New System.Drawing.Point(12, 52)
        Me.btnGroup.Name = "btnGroup"
        Me.btnGroup.Size = New System.Drawing.Size(140, 89)
        Me.btnGroup.TabIndex = 3
        '
        'btnPerfil
        '
        Me.btnPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPerfil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BunifuTransition1.SetDecoration(Me.btnPerfil, BunifuAnimatorNS.DecorationType.None)
        Me.btnPerfil.FocusCuesEnabled = False
        Me.btnPerfil.Location = New System.Drawing.Point(3, 3)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(137, 23)
        Me.btnPerfil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPerfil.TabIndex = 4
        Me.btnPerfil.TabStop = False
        Me.btnPerfil.Text = "Perfil"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BunifuTransition1.SetDecoration(Me.ButtonX2, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonX2.FocusCuesEnabled = False
        Me.ButtonX2.Location = New System.Drawing.Point(3, 32)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(137, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 5
        Me.ButtonX2.TabStop = False
        Me.ButtonX2.Text = "Acerca de"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.BunifuTransition1.SetDecoration(Me.ButtonX3, BunifuAnimatorNS.DecorationType.None)
        Me.ButtonX3.FocusCuesEnabled = False
        Me.ButtonX3.Location = New System.Drawing.Point(3, 61)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(137, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 6
        Me.ButtonX3.TabStop = False
        Me.ButtonX3.Text = "Cerrar Sesión"
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'btnUsr
        '
        Me.btnUsr.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnUsr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnUsr.color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnUsr.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnUsr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnUsr, BunifuAnimatorNS.DecorationType.None)
        Me.btnUsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnUsr.ForeColor = System.Drawing.Color.White
        Me.btnUsr.Image = Global.SistemaTransporte.My.Resources.Resources.user_1_
        Me.btnUsr.ImagePosition = 20
        Me.btnUsr.ImageZoom = 50
        Me.btnUsr.LabelPosition = 37
        Me.btnUsr.LabelText = ""
        Me.btnUsr.Location = New System.Drawing.Point(12, 12)
        Me.btnUsr.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUsr.Name = "btnUsr"
        Me.btnUsr.Size = New System.Drawing.Size(140, 129)
        Me.btnUsr.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btnClose, BunifuAnimatorNS.DecorationType.None)
        Me.btnClose.Image = Global.SistemaTransporte.My.Resources.Resources.Delete_2
        Me.btnClose.ImageActive = Global.SistemaTransporte.My.Resources.Resources.Delete
        Me.btnClose.Location = New System.Drawing.Point(961, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 50)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 1
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Bus"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton23, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton23.Location = New System.Drawing.Point(265, 5)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(170, 150)
        Me.BunifuThinButton23.TabIndex = 7
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Salir"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton22.Location = New System.Drawing.Point(525, 165)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(170, 310)
        Me.BunifuThinButton22.TabIndex = 6
        Me.BunifuThinButton22.TabStop = False
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.ActiveBorderThickness = 1
        Me.btnSalir.ActiveCornerRadius = 20
        Me.btnSalir.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnSalir.ActiveForecolor = System.Drawing.Color.White
        Me.btnSalir.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.ButtonText = "Cerrar Sesión"
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnSalir, BunifuAnimatorNS.DecorationType.None)
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSalir.IdleBorderThickness = 1
        Me.btnSalir.IdleCornerRadius = 20
        Me.btnSalir.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSalir.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnSalir.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnSalir.Location = New System.Drawing.Point(525, 165)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(170, 310)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.TabStop = False
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUsuarios
        '
        Me.btnUsuarios.ActiveBorderThickness = 1
        Me.btnUsuarios.ActiveCornerRadius = 20
        Me.btnUsuarios.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnUsuarios.ActiveForecolor = System.Drawing.Color.White
        Me.btnUsuarios.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnUsuarios.BackgroundImage = CType(resources.GetObject("btnUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.btnUsuarios.ButtonText = "Usuarios"
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnUsuarios, BunifuAnimatorNS.DecorationType.None)
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnUsuarios.IdleBorderThickness = 1
        Me.btnUsuarios.IdleCornerRadius = 20
        Me.btnUsuarios.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnUsuarios.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnUsuarios.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnUsuarios.Location = New System.Drawing.Point(265, 325)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(250, 150)
        Me.btnUsuarios.TabIndex = 5
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEncomiendas
        '
        Me.btnEncomiendas.ActiveBorderThickness = 1
        Me.btnEncomiendas.ActiveCornerRadius = 20
        Me.btnEncomiendas.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEncomiendas.ActiveForecolor = System.Drawing.Color.White
        Me.btnEncomiendas.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEncomiendas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnEncomiendas.BackgroundImage = CType(resources.GetObject("btnEncomiendas.BackgroundImage"), System.Drawing.Image)
        Me.btnEncomiendas.ButtonText = "Encomiendas"
        Me.btnEncomiendas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnEncomiendas, BunifuAnimatorNS.DecorationType.None)
        Me.btnEncomiendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncomiendas.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEncomiendas.IdleBorderThickness = 1
        Me.btnEncomiendas.IdleCornerRadius = 20
        Me.btnEncomiendas.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnEncomiendas.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnEncomiendas.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnEncomiendas.Location = New System.Drawing.Point(5, 325)
        Me.btnEncomiendas.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEncomiendas.Name = "btnEncomiendas"
        Me.btnEncomiendas.Size = New System.Drawing.Size(250, 150)
        Me.btnEncomiendas.TabIndex = 4
        Me.btnEncomiendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCiudades
        '
        Me.btnCiudades.ActiveBorderThickness = 1
        Me.btnCiudades.ActiveCornerRadius = 20
        Me.btnCiudades.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnCiudades.ActiveForecolor = System.Drawing.Color.White
        Me.btnCiudades.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnCiudades.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCiudades.BackgroundImage = CType(resources.GetObject("btnCiudades.BackgroundImage"), System.Drawing.Image)
        Me.btnCiudades.ButtonText = "Ciudades"
        Me.btnCiudades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnCiudades, BunifuAnimatorNS.DecorationType.None)
        Me.btnCiudades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudades.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCiudades.IdleBorderThickness = 1
        Me.btnCiudades.IdleCornerRadius = 20
        Me.btnCiudades.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCiudades.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCiudades.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnCiudades.Location = New System.Drawing.Point(265, 165)
        Me.btnCiudades.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCiudades.Name = "btnCiudades"
        Me.btnCiudades.Size = New System.Drawing.Size(250, 150)
        Me.btnCiudades.TabIndex = 3
        Me.btnCiudades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnItinerario
        '
        Me.btnItinerario.ActiveBorderThickness = 1
        Me.btnItinerario.ActiveCornerRadius = 20
        Me.btnItinerario.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnItinerario.ActiveForecolor = System.Drawing.Color.White
        Me.btnItinerario.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnItinerario.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnItinerario.BackgroundImage = CType(resources.GetObject("btnItinerario.BackgroundImage"), System.Drawing.Image)
        Me.btnItinerario.ButtonText = "Itinerario"
        Me.btnItinerario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnItinerario, BunifuAnimatorNS.DecorationType.None)
        Me.btnItinerario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItinerario.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnItinerario.IdleBorderThickness = 1
        Me.btnItinerario.IdleCornerRadius = 20
        Me.btnItinerario.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnItinerario.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnItinerario.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnItinerario.Location = New System.Drawing.Point(5, 165)
        Me.btnItinerario.Margin = New System.Windows.Forms.Padding(5)
        Me.btnItinerario.Name = "btnItinerario"
        Me.btnItinerario.Size = New System.Drawing.Size(250, 150)
        Me.btnItinerario.TabIndex = 2
        Me.btnItinerario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Clientes"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(445, 5)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(250, 150)
        Me.BunifuThinButton21.TabIndex = 1
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClientes
        '
        Me.btnClientes.ActiveBorderThickness = 1
        Me.btnClientes.ActiveCornerRadius = 20
        Me.btnClientes.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnClientes.ActiveForecolor = System.Drawing.Color.White
        Me.btnClientes.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnClientes.BackgroundImage = CType(resources.GetObject("btnClientes.BackgroundImage"), System.Drawing.Image)
        Me.btnClientes.ButtonText = "Clientes"
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnClientes, BunifuAnimatorNS.DecorationType.None)
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnClientes.IdleBorderThickness = 1
        Me.btnClientes.IdleCornerRadius = 20
        Me.btnClientes.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClientes.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnClientes.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnClientes.Location = New System.Drawing.Point(445, 5)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(250, 150)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVentas
        '
        Me.btnVentas.ActiveBorderThickness = 1
        Me.btnVentas.ActiveCornerRadius = 20
        Me.btnVentas.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnVentas.ActiveForecolor = System.Drawing.Color.White
        Me.btnVentas.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnVentas.BackgroundImage = CType(resources.GetObject("btnVentas.BackgroundImage"), System.Drawing.Image)
        Me.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVentas.ButtonText = "Ventas"
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnVentas, BunifuAnimatorNS.DecorationType.None)
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnVentas.IdleBorderThickness = 1
        Me.btnVentas.IdleCornerRadius = 20
        Me.btnVentas.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnVentas.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVentas.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnVentas.Location = New System.Drawing.Point(5, 5)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(250, 150)
        Me.btnVentas.TabIndex = 0
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnUsr)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGroup)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.btnGroup.ResumeLayout(False)
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVentas As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnItinerario As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSalir As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnUsuarios As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEncomiendas As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnCiudades As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnClientes As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents btnUsr As Bunifu.Framework.UI.BunifuTileButton
    Public WithEvents btnGroup As FlowLayoutPanel
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Private WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPerfil As DevComponents.DotNetBar.ButtonX
End Class
