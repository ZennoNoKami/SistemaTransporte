<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSignUp = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtConfirmarC = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtContrasena = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtUsuario = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogIn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn2 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.LoginStyle = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSignUp)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel2.Controls.Add(Me.txtConfirmarC)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel2.Controls.Add(Me.txtContrasena)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel2.Controls.Add(Me.txtUsuario)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(36, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(470, 516)
        Me.Panel2.TabIndex = 2
        '
        'btnSignUp
        '
        Me.btnSignUp.ActiveBorderThickness = 1
        Me.btnSignUp.ActiveCornerRadius = 1
        Me.btnSignUp.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnSignUp.ActiveForecolor = System.Drawing.Color.White
        Me.btnSignUp.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSignUp.BackgroundImage = CType(resources.GetObject("btnSignUp.BackgroundImage"), System.Drawing.Image)
        Me.btnSignUp.ButtonText = "Registrar"
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSignUp.IdleBorderThickness = 1
        Me.btnSignUp.IdleCornerRadius = 1
        Me.btnSignUp.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSignUp.IdleForecolor = System.Drawing.Color.White
        Me.btnSignUp.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSignUp.Location = New System.Drawing.Point(50, 441)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(370, 57)
        Me.btnSignUp.TabIndex = 3
        Me.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(47, 353)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(137, 16)
        Me.BunifuCustomLabel5.TabIndex = 10
        Me.BunifuCustomLabel5.Text = "Confirmar Contraseña"
        '
        'txtConfirmarC
        '
        Me.txtConfirmarC.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtConfirmarC.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.txtConfirmarC.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtConfirmarC.BorderThickness = 1
        Me.txtConfirmarC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtConfirmarC, BunifuAnimatorNS.DecorationType.None)
        Me.txtConfirmarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtConfirmarC.ForeColor = System.Drawing.Color.DarkGray
        Me.txtConfirmarC.isPassword = True
        Me.txtConfirmarC.Location = New System.Drawing.Point(50, 373)
        Me.txtConfirmarC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmarC.Name = "txtConfirmarC"
        Me.txtConfirmarC.Size = New System.Drawing.Size(370, 44)
        Me.txtConfirmarC.TabIndex = 5
        Me.txtConfirmarC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(47, 281)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(77, 16)
        Me.BunifuCustomLabel4.TabIndex = 8
        Me.BunifuCustomLabel4.Text = "Contraseña"
        '
        'txtContrasena
        '
        Me.txtContrasena.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtContrasena.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.txtContrasena.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtContrasena.BorderThickness = 1
        Me.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtContrasena, BunifuAnimatorNS.DecorationType.None)
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtContrasena.ForeColor = System.Drawing.Color.DarkGray
        Me.txtContrasena.isPassword = True
        Me.txtContrasena.Location = New System.Drawing.Point(50, 301)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(370, 44)
        Me.txtContrasena.TabIndex = 4
        Me.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(47, 210)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(55, 16)
        Me.BunifuCustomLabel3.TabIndex = 6
        Me.BunifuCustomLabel3.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtUsuario.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.txtUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtUsuario.BorderThickness = 1
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtUsuario.ForeColor = System.Drawing.Color.DarkGray
        Me.txtUsuario.isPassword = False
        Me.txtUsuario.Location = New System.Drawing.Point(50, 230)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(370, 44)
        Me.txtUsuario.TabIndex = 3
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(47, 142)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(42, 16)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtEmail.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtEmail.BorderThickness = 1
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtEmail, BunifuAnimatorNS.DecorationType.None)
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtEmail.ForeColor = System.Drawing.Color.DarkGray
        Me.txtEmail.isPassword = False
        Me.txtEmail.Location = New System.Drawing.Point(50, 162)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(370, 44)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(47, 66)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(57, 16)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtNombre.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.txtNombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtNombre.BorderThickness = 1
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtNombre, BunifuAnimatorNS.DecorationType.None)
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtNombre.ForeColor = System.Drawing.Color.DarkGray
        Me.txtNombre.isPassword = False
        Me.txtNombre.Location = New System.Drawing.Point(50, 86)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(370, 44)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(144, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrarse"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLogIn)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(36, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 516)
        Me.Panel1.TabIndex = 3
        '
        'btnLogIn
        '
        Me.btnLogIn.ActiveBorderThickness = 1
        Me.btnLogIn.ActiveCornerRadius = 1
        Me.btnLogIn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnLogIn.ActiveForecolor = System.Drawing.Color.White
        Me.btnLogIn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogIn.BackgroundImage = CType(resources.GetObject("btnLogIn.BackgroundImage"), System.Drawing.Image)
        Me.btnLogIn.ButtonText = "Iniciar Sesión"
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnLogIn, BunifuAnimatorNS.DecorationType.None)
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLogIn.IdleBorderThickness = 1
        Me.btnLogIn.IdleCornerRadius = 1
        Me.btnLogIn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnLogIn.IdleForecolor = System.Drawing.Color.White
        Me.btnLogIn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnLogIn.Location = New System.Drawing.Point(50, 441)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(370, 57)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(47, 258)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(77, 16)
        Me.BunifuCustomLabel7.TabIndex = 8
        Me.BunifuCustomLabel7.Text = "Contraseña"
        '
        'txtPassword
        '
        Me.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtPassword.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtPassword.BorderThickness = 1
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPassword.isPassword = True
        Me.txtPassword.Location = New System.Drawing.Point(50, 279)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(370, 44)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(47, 137)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(55, 16)
        Me.BunifuCustomLabel8.TabIndex = 6
        Me.BunifuCustomLabel8.Text = "Usuario"
        '
        'txtUser
        '
        Me.txtUser.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtUser.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.txtUser.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtUser.BorderThickness = 1
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txtUser, BunifuAnimatorNS.DecorationType.None)
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtUser.ForeColor = System.Drawing.Color.DarkGray
        Me.txtUser.isPassword = False
        Me.txtUser.Location = New System.Drawing.Point(50, 158)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(370, 44)
        Me.txtUser.TabIndex = 5
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(144, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Iniciar Sesión"
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
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 5
        Me.BunifuSeparator1.Location = New System.Drawing.Point(127, 83)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(146, 5)
        Me.BunifuSeparator1.TabIndex = 4
        Me.BunifuSeparator1.TabStop = False
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btnClose, BunifuAnimatorNS.DecorationType.None)
        Me.btnClose.Image = Global.SistemaTransporte.My.Resources.Resources.close
        Me.btnClose.ImageActive = Global.SistemaTransporte.My.Resources.Resources.close2
        Me.btnClose.Location = New System.Drawing.Point(469, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(54, 47)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 5
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'btn1
        '
        Me.btn1.ActiveBorderThickness = 1
        Me.btn1.ActiveCornerRadius = 1
        Me.btn1.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn1.ActiveForecolor = System.Drawing.Color.White
        Me.btn1.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn1.BackgroundImage = CType(resources.GetObject("btn1.BackgroundImage"), System.Drawing.Image)
        Me.btn1.ButtonText = "Iniciar Sesión"
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn1.IdleBorderThickness = 1
        Me.btn1.IdleCornerRadius = 1
        Me.btn1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn1.IdleForecolor = System.Drawing.Color.White
        Me.btn1.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn1.Location = New System.Drawing.Point(127, 31)
        Me.btn1.Margin = New System.Windows.Forms.Padding(5)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(146, 57)
        Me.btn1.TabIndex = 1
        Me.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn2
        '
        Me.btn2.ActiveBorderThickness = 1
        Me.btn2.ActiveCornerRadius = 1
        Me.btn2.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn2.ActiveForecolor = System.Drawing.Color.White
        Me.btn2.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn2.BackgroundImage = CType(resources.GetObject("btn2.BackgroundImage"), System.Drawing.Image)
        Me.btn2.ButtonText = "Registrarse"
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn2.IdleBorderThickness = 1
        Me.btn2.IdleCornerRadius = 1
        Me.btn2.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn2.IdleForecolor = System.Drawing.Color.White
        Me.btn2.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn2.Location = New System.Drawing.Point(273, 31)
        Me.btn2.Margin = New System.Windows.Forms.Padding(5)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(146, 57)
        Me.btn2.TabIndex = 0
        Me.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginStyle
        '
        Me.LoginStyle.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.LoginStyle.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(552, 644)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLog"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btn2 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSignUp As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn1 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtConfirmarC As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtContrasena As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtUsuario As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogIn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents LoginStyle As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
End Class
