<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicial))
        Me.MnuSociedad = New System.Windows.Forms.MenuStrip()
        Me.MnuMantenimietos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCuotas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSociosBenef = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuInformes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ts = New System.Windows.Forms.ToolStrip()
        Me.TsMantCuotas = New System.Windows.Forms.ToolStripButton()
        Me.TsSociosBenef = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsPagos = New System.Windows.Forms.ToolStripButton()
        Me.TsInformes = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsSalir = New System.Windows.Forms.ToolStripButton()
        Me.MnuSociedad.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ts.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuSociedad
        '
        Me.MnuSociedad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuMantenimietos, Me.MnuPagos, Me.MnuInformes, Me.ToolStripMenuItem1, Me.MnuSalir})
        Me.MnuSociedad.Location = New System.Drawing.Point(0, 0)
        Me.MnuSociedad.Name = "MnuSociedad"
        Me.MnuSociedad.Size = New System.Drawing.Size(674, 24)
        Me.MnuSociedad.TabIndex = 0
        Me.MnuSociedad.Text = "MenuStrip1"
        '
        'MnuMantenimietos
        '
        Me.MnuMantenimietos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCuotas, Me.MnuSociosBenef})
        Me.MnuMantenimietos.Name = "MnuMantenimietos"
        Me.MnuMantenimietos.Size = New System.Drawing.Size(106, 20)
        Me.MnuMantenimietos.Text = "Mantenimientos"
        '
        'MnuCuotas
        '
        Me.MnuCuotas.Name = "MnuCuotas"
        Me.MnuCuotas.Size = New System.Drawing.Size(232, 22)
        Me.MnuCuotas.Text = "Cuotas"
        '
        'MnuSociosBenef
        '
        Me.MnuSociosBenef.Name = "MnuSociosBenef"
        Me.MnuSociosBenef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MnuSociosBenef.Size = New System.Drawing.Size(232, 22)
        Me.MnuSociosBenef.Text = "Socios y Beneficiarios"
        '
        'MnuPagos
        '
        Me.MnuPagos.Name = "MnuPagos"
        Me.MnuPagos.Size = New System.Drawing.Size(110, 20)
        Me.MnuPagos.Text = "Control de pagos"
        '
        'MnuInformes
        '
        Me.MnuInformes.Name = "MnuInformes"
        Me.MnuInformes.Size = New System.Drawing.Size(66, 20)
        Me.MnuInformes.Text = "Informes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'MnuSalir
        '
        Me.MnuSalir.Name = "MnuSalir"
        Me.MnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.MnuSalir.Size = New System.Drawing.Size(41, 20)
        Me.MnuSalir.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 294)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Ts
        '
        Me.Ts.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.Ts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsMantCuotas, Me.TsSociosBenef, Me.ToolStripSeparator1, Me.TsPagos, Me.TsInformes, Me.ToolStripSeparator2, Me.TsSalir})
        Me.Ts.Location = New System.Drawing.Point(0, 24)
        Me.Ts.Name = "Ts"
        Me.Ts.Size = New System.Drawing.Size(674, 39)
        Me.Ts.TabIndex = 2
        Me.Ts.Text = "ToolStrip1"
        '
        'TsMantCuotas
        '
        Me.TsMantCuotas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsMantCuotas.Image = CType(resources.GetObject("TsMantCuotas.Image"), System.Drawing.Image)
        Me.TsMantCuotas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsMantCuotas.Name = "TsMantCuotas"
        Me.TsMantCuotas.Size = New System.Drawing.Size(36, 36)
        Me.TsMantCuotas.Text = "ToolStripButton1"
        Me.TsMantCuotas.ToolTipText = "Mantenimiento de cuotas"
        '
        'TsSociosBenef
        '
        Me.TsSociosBenef.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsSociosBenef.Image = CType(resources.GetObject("TsSociosBenef.Image"), System.Drawing.Image)
        Me.TsSociosBenef.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsSociosBenef.Name = "TsSociosBenef"
        Me.TsSociosBenef.Size = New System.Drawing.Size(36, 36)
        Me.TsSociosBenef.Text = "ToolStripButton1"
        Me.TsSociosBenef.ToolTipText = "Mantenimiento de socios y beneficiarios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'TsPagos
        '
        Me.TsPagos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsPagos.Image = CType(resources.GetObject("TsPagos.Image"), System.Drawing.Image)
        Me.TsPagos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsPagos.Name = "TsPagos"
        Me.TsPagos.Size = New System.Drawing.Size(36, 36)
        Me.TsPagos.Text = "ToolStripButton1"
        Me.TsPagos.ToolTipText = "Control de pagos"
        '
        'TsInformes
        '
        Me.TsInformes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsInformes.Image = CType(resources.GetObject("TsInformes.Image"), System.Drawing.Image)
        Me.TsInformes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsInformes.Name = "TsInformes"
        Me.TsInformes.Size = New System.Drawing.Size(45, 36)
        Me.TsInformes.Text = "ToolStripDropDownButton1"
        Me.TsInformes.ToolTipText = "Informes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'TsSalir
        '
        Me.TsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsSalir.Image = CType(resources.GetObject("TsSalir.Image"), System.Drawing.Image)
        Me.TsSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsSalir.Name = "TsSalir"
        Me.TsSalir.Size = New System.Drawing.Size(36, 36)
        Me.TsSalir.Text = "ToolStripButton1"
        Me.TsSalir.ToolTipText = "Salir"
        '
        'FrmInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 450)
        Me.Controls.Add(Me.Ts)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MnuSociedad)
        Me.MainMenuStrip = Me.MnuSociedad
        Me.Name = "FrmInicial"
        Me.Text = "FrmInicial"
        Me.MnuSociedad.ResumeLayout(False)
        Me.MnuSociedad.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ts.ResumeLayout(False)
        Me.Ts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuSociedad As MenuStrip
    Friend WithEvents MnuMantenimietos As ToolStripMenuItem
    Friend WithEvents MnuCuotas As ToolStripMenuItem
    Friend WithEvents MnuSociosBenef As ToolStripMenuItem
    Friend WithEvents MnuPagos As ToolStripMenuItem
    Friend WithEvents MnuInformes As ToolStripMenuItem
    Friend WithEvents MnuSalir As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Ts As ToolStrip
    Friend WithEvents TsMantCuotas As ToolStripButton
    Friend WithEvents TsSociosBenef As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TsPagos As ToolStripButton
    Friend WithEvents TsInformes As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TsSalir As ToolStripButton
End Class
