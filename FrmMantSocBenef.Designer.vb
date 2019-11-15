<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantSocBenef
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantSocBenef))
        Me.LblBenef = New System.Windows.Forms.Label()
        Me.DtgBenef = New System.Windows.Forms.DataGridView()
        Me.chkBaja = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboxSocios = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNsocio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnultimo = New System.Windows.Forms.Button()
        Me.btnsiguinte = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btnprimero = New System.Windows.Forms.Button()
        Me.DtgSocios = New System.Windows.Forms.DataGridView()
        Me.CmbNombres = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnuSocios = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNuevoSocio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBorrarSocio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuModificarSocio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuNumBenefSoc = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCalcCuotaSocio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBenef = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNuevoBenef = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBorrarBenef = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuModificarBenef = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuMostrarOcultarBenef = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuOpGen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNumTotalSocios = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNumSociosBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSociosAntig = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtsRefresh = New System.Windows.Forms.ToolStripButton()
        Me.BtsToggBenef = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtsNuevoSoc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtsNuevoBenef = New System.Windows.Forms.ToolStripButton()
        CType(Me.DtgBenef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblBenef
        '
        Me.LblBenef.AutoSize = True
        Me.LblBenef.Location = New System.Drawing.Point(517, 263)
        Me.LblBenef.Name = "LblBenef"
        Me.LblBenef.Size = New System.Drawing.Size(67, 13)
        Me.LblBenef.TabIndex = 52
        Me.LblBenef.Text = "Beneficiarios"
        Me.LblBenef.Visible = False
        '
        'DtgBenef
        '
        Me.DtgBenef.AllowUserToAddRows = False
        Me.DtgBenef.AllowUserToDeleteRows = False
        Me.DtgBenef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgBenef.Location = New System.Drawing.Point(520, 287)
        Me.DtgBenef.Name = "DtgBenef"
        Me.DtgBenef.ReadOnly = True
        Me.DtgBenef.Size = New System.Drawing.Size(669, 162)
        Me.DtgBenef.TabIndex = 51
        Me.DtgBenef.Visible = False
        '
        'chkBaja
        '
        Me.chkBaja.AutoSize = True
        Me.chkBaja.Enabled = False
        Me.chkBaja.Location = New System.Drawing.Point(50, 201)
        Me.chkBaja.Margin = New System.Windows.Forms.Padding(5)
        Me.chkBaja.Name = "chkBaja"
        Me.chkBaja.Size = New System.Drawing.Size(65, 28)
        Me.chkBaja.TabIndex = 15
        Me.chkBaja.Text = "Baja"
        Me.chkBaja.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(55, 39)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "NIF"
        '
        'cboxSocios
        '
        Me.cboxSocios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSocios.FormattingEnabled = True
        Me.cboxSocios.Location = New System.Drawing.Point(55, 57)
        Me.cboxSocios.Margin = New System.Windows.Forms.Padding(5)
        Me.cboxSocios.Name = "cboxSocios"
        Me.cboxSocios.Size = New System.Drawing.Size(208, 21)
        Me.cboxSocios.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkBaja)
        Me.GroupBox1.Controls.Add(Me.lblNsocio)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblDni)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 86)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(441, 363)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DatosSocio"
        '
        'lblNsocio
        '
        Me.lblNsocio.AutoSize = True
        Me.lblNsocio.Location = New System.Drawing.Point(158, 53)
        Me.lblNsocio.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNsocio.Name = "lblNsocio"
        Me.lblNsocio.Size = New System.Drawing.Size(0, 24)
        Me.lblNsocio.TabIndex = 10
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(158, 81)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(90, 24)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "*nombre*"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(158, 111)
        Me.lblDni.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(50, 24)
        Me.lblDni.TabIndex = 12
        Me.lblDni.Text = "*dni*"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(158, 137)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(101, 24)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "*fechaAlta*"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(158, 166)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(102, 24)
        Me.lblTipo.TabIndex = 14
        Me.lblTipo.Text = "*tipoSocio*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nº Socio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "DNI:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Alta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo de Socio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 39)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nombre"
        '
        'btnultimo
        '
        Me.btnultimo.Enabled = False
        Me.btnultimo.Location = New System.Drawing.Point(1129, 204)
        Me.btnultimo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnultimo.Name = "btnultimo"
        Me.btnultimo.Size = New System.Drawing.Size(61, 32)
        Me.btnultimo.TabIndex = 49
        Me.btnultimo.Text = ">>"
        Me.btnultimo.UseVisualStyleBackColor = True
        '
        'btnsiguinte
        '
        Me.btnsiguinte.Enabled = False
        Me.btnsiguinte.Location = New System.Drawing.Point(911, 204)
        Me.btnsiguinte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsiguinte.Name = "btnsiguinte"
        Me.btnsiguinte.Size = New System.Drawing.Size(61, 32)
        Me.btnsiguinte.TabIndex = 48
        Me.btnsiguinte.Text = ">"
        Me.btnsiguinte.UseVisualStyleBackColor = True
        '
        'btnanterior
        '
        Me.btnanterior.Enabled = False
        Me.btnanterior.Location = New System.Drawing.Point(786, 204)
        Me.btnanterior.Margin = New System.Windows.Forms.Padding(2)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(61, 32)
        Me.btnanterior.TabIndex = 47
        Me.btnanterior.Text = "<"
        Me.btnanterior.UseVisualStyleBackColor = True
        '
        'btnprimero
        '
        Me.btnprimero.Enabled = False
        Me.btnprimero.Location = New System.Drawing.Point(520, 204)
        Me.btnprimero.Margin = New System.Windows.Forms.Padding(2)
        Me.btnprimero.Name = "btnprimero"
        Me.btnprimero.Size = New System.Drawing.Size(61, 32)
        Me.btnprimero.TabIndex = 46
        Me.btnprimero.Text = "<<"
        Me.btnprimero.UseVisualStyleBackColor = True
        '
        'DtgSocios
        '
        Me.DtgSocios.AllowUserToAddRows = False
        Me.DtgSocios.AllowUserToDeleteRows = False
        Me.DtgSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgSocios.Location = New System.Drawing.Point(520, 39)
        Me.DtgSocios.Margin = New System.Windows.Forms.Padding(2)
        Me.DtgSocios.Name = "DtgSocios"
        Me.DtgSocios.ReadOnly = True
        Me.DtgSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgSocios.Size = New System.Drawing.Size(670, 161)
        Me.DtgSocios.TabIndex = 45
        '
        'CmbNombres
        '
        Me.CmbNombres.FormattingEnabled = True
        Me.CmbNombres.Location = New System.Drawing.Point(277, 57)
        Me.CmbNombres.Name = "CmbNombres"
        Me.CmbNombres.Size = New System.Drawing.Size(219, 21)
        Me.CmbNombres.TabIndex = 54
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuSocios, Me.MnuBenef, Me.MnuOpGen, Me.MnuSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1221, 24)
        Me.MenuStrip1.TabIndex = 55
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MnuSocios
        '
        Me.MnuSocios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuNuevoSocio, Me.MnuBorrarSocio, Me.MnuModificarSocio, Me.ToolStripSeparator1, Me.MnuNumBenefSoc, Me.MnuCalcCuotaSocio})
        Me.MnuSocios.Name = "MnuSocios"
        Me.MnuSocios.Size = New System.Drawing.Size(53, 20)
        Me.MnuSocios.Text = "&Socios"
        '
        'MnuNuevoSocio
        '
        Me.MnuNuevoSocio.Name = "MnuNuevoSocio"
        Me.MnuNuevoSocio.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MnuNuevoSocio.Size = New System.Drawing.Size(225, 22)
        Me.MnuNuevoSocio.Text = "&Nuevo Socio"
        '
        'MnuBorrarSocio
        '
        Me.MnuBorrarSocio.Name = "MnuBorrarSocio"
        Me.MnuBorrarSocio.Size = New System.Drawing.Size(225, 22)
        Me.MnuBorrarSocio.Text = "&Borrar socio"
        '
        'MnuModificarSocio
        '
        Me.MnuModificarSocio.Name = "MnuModificarSocio"
        Me.MnuModificarSocio.Size = New System.Drawing.Size(225, 22)
        Me.MnuModificarSocio.Text = "Modific&ar datos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(222, 6)
        '
        'MnuNumBenefSoc
        '
        Me.MnuNumBenefSoc.Name = "MnuNumBenefSoc"
        Me.MnuNumBenefSoc.Size = New System.Drawing.Size(225, 22)
        Me.MnuNumBenefSoc.Text = "&Numero de beneficiarios"
        '
        'MnuCalcCuotaSocio
        '
        Me.MnuCalcCuotaSocio.Name = "MnuCalcCuotaSocio"
        Me.MnuCalcCuotaSocio.Size = New System.Drawing.Size(225, 22)
        Me.MnuCalcCuotaSocio.Text = "Calcular &cuota mensual total"
        '
        'MnuBenef
        '
        Me.MnuBenef.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuNuevoBenef, Me.MnuBorrarBenef, Me.MnuModificarBenef, Me.ToolStripSeparator2, Me.MnuMostrarOcultarBenef})
        Me.MnuBenef.Name = "MnuBenef"
        Me.MnuBenef.Size = New System.Drawing.Size(86, 20)
        Me.MnuBenef.Text = "&Beneficiarios"
        '
        'MnuNuevoBenef
        '
        Me.MnuNuevoBenef.Name = "MnuNuevoBenef"
        Me.MnuNuevoBenef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.MnuNuevoBenef.Size = New System.Drawing.Size(215, 22)
        Me.MnuNuevoBenef.Text = "&Nuevo beneficiario"
        '
        'MnuBorrarBenef
        '
        Me.MnuBorrarBenef.Name = "MnuBorrarBenef"
        Me.MnuBorrarBenef.Size = New System.Drawing.Size(215, 22)
        Me.MnuBorrarBenef.Text = "&Borrar Beneficiario"
        '
        'MnuModificarBenef
        '
        Me.MnuModificarBenef.Name = "MnuModificarBenef"
        Me.MnuModificarBenef.Size = New System.Drawing.Size(215, 22)
        Me.MnuModificarBenef.Text = "Modific&ar datos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(212, 6)
        '
        'MnuMostrarOcultarBenef
        '
        Me.MnuMostrarOcultarBenef.Name = "MnuMostrarOcultarBenef"
        Me.MnuMostrarOcultarBenef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.MnuMostrarOcultarBenef.Size = New System.Drawing.Size(215, 22)
        Me.MnuMostrarOcultarBenef.Tag = "0"
        Me.MnuMostrarOcultarBenef.Text = "&Mostrar / Ocultar"
        '
        'MnuOpGen
        '
        Me.MnuOpGen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuNumTotalSocios, Me.MnuNumSociosBaja, Me.MnuSociosAntig})
        Me.MnuOpGen.Name = "MnuOpGen"
        Me.MnuOpGen.Size = New System.Drawing.Size(138, 20)
        Me.MnuOpGen.Text = "&Operaciones generales"
        '
        'MnuNumTotalSocios
        '
        Me.MnuNumTotalSocios.Name = "MnuNumTotalSocios"
        Me.MnuNumTotalSocios.Size = New System.Drawing.Size(254, 22)
        Me.MnuNumTotalSocios.Text = "Numero &total de socios"
        '
        'MnuNumSociosBaja
        '
        Me.MnuNumSociosBaja.Name = "MnuNumSociosBaja"
        Me.MnuNumSociosBaja.Size = New System.Drawing.Size(254, 22)
        Me.MnuNumSociosBaja.Text = "Numero de socios de &baja"
        '
        'MnuSociosAntig
        '
        Me.MnuSociosAntig.Name = "MnuSociosAntig"
        Me.MnuSociosAntig.Size = New System.Drawing.Size(254, 22)
        Me.MnuSociosAntig.Text = "Numero de socios por &antiguedad"
        '
        'MnuSalir
        '
        Me.MnuSalir.Name = "MnuSalir"
        Me.MnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.MnuSalir.Size = New System.Drawing.Size(41, 20)
        Me.MnuSalir.Text = "Sali&r"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtsRefresh, Me.BtsToggBenef, Me.ToolStripSeparator4, Me.BtsNuevoSoc, Me.ToolStripSeparator3, Me.BtsNuevoBenef})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(37, 450)
        Me.ToolStrip1.TabIndex = 56
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtsRefresh
        '
        Me.BtsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtsRefresh.Image = CType(resources.GetObject("BtsRefresh.Image"), System.Drawing.Image)
        Me.BtsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtsRefresh.Name = "BtsRefresh"
        Me.BtsRefresh.Size = New System.Drawing.Size(34, 36)
        Me.BtsRefresh.Text = "Actualizar datos"
        '
        'BtsToggBenef
        '
        Me.BtsToggBenef.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtsToggBenef.Image = CType(resources.GetObject("BtsToggBenef.Image"), System.Drawing.Image)
        Me.BtsToggBenef.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtsToggBenef.Name = "BtsToggBenef"
        Me.BtsToggBenef.Size = New System.Drawing.Size(34, 36)
        Me.BtsToggBenef.Text = "Mostrar/Ocultar beneficiarios"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(34, 6)
        '
        'BtsNuevoSoc
        '
        Me.BtsNuevoSoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtsNuevoSoc.Image = CType(resources.GetObject("BtsNuevoSoc.Image"), System.Drawing.Image)
        Me.BtsNuevoSoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtsNuevoSoc.Name = "BtsNuevoSoc"
        Me.BtsNuevoSoc.Size = New System.Drawing.Size(34, 36)
        Me.BtsNuevoSoc.Text = "Añadir socio"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(34, 6)
        '
        'BtsNuevoBenef
        '
        Me.BtsNuevoBenef.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtsNuevoBenef.Image = CType(resources.GetObject("BtsNuevoBenef.Image"), System.Drawing.Image)
        Me.BtsNuevoBenef.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtsNuevoBenef.Name = "BtsNuevoBenef"
        Me.BtsNuevoBenef.Size = New System.Drawing.Size(34, 36)
        Me.BtsNuevoBenef.Text = "Añadir beneficiario"
        '
        'FrmMantSocBenef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 474)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CmbNombres)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblBenef)
        Me.Controls.Add(Me.DtgBenef)
        Me.Controls.Add(Me.cboxSocios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnultimo)
        Me.Controls.Add(Me.btnsiguinte)
        Me.Controls.Add(Me.btnanterior)
        Me.Controls.Add(Me.btnprimero)
        Me.Controls.Add(Me.DtgSocios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMantSocBenef"
        Me.Text = "Mantenimiento de Socios y Beneficiarios"
        CType(Me.DtgBenef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtgSocios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblBenef As Label
    Friend WithEvents DtgBenef As DataGridView
    Friend WithEvents chkBaja As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboxSocios As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNsocio As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnultimo As Button
    Friend WithEvents btnsiguinte As Button
    Friend WithEvents btnanterior As Button
    Friend WithEvents btnprimero As Button
    Friend WithEvents DtgSocios As DataGridView
    Friend WithEvents CmbNombres As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnuSocios As ToolStripMenuItem
    Friend WithEvents MnuBenef As ToolStripMenuItem
    Friend WithEvents MnuOpGen As ToolStripMenuItem
    Friend WithEvents MnuSalir As ToolStripMenuItem
    Friend WithEvents MnuNuevoSocio As ToolStripMenuItem
    Friend WithEvents MnuBorrarSocio As ToolStripMenuItem
    Friend WithEvents MnuModificarSocio As ToolStripMenuItem
    Friend WithEvents MnuNuevoBenef As ToolStripMenuItem
    Friend WithEvents MnuBorrarBenef As ToolStripMenuItem
    Friend WithEvents MnuModificarBenef As ToolStripMenuItem
    Friend WithEvents MnuNumTotalSocios As ToolStripMenuItem
    Friend WithEvents MnuNumSociosBaja As ToolStripMenuItem
    Friend WithEvents MnuSociosAntig As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MnuNumBenefSoc As ToolStripMenuItem
    Friend WithEvents MnuCalcCuotaSocio As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MnuMostrarOcultarBenef As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtsRefresh As ToolStripButton
    Friend WithEvents BtsToggBenef As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtsNuevoSoc As ToolStripButton
    Friend WithEvents BtsNuevoBenef As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
