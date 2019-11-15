<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFiltros
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
        Me.CmbCampos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbOperadores = New System.Windows.Forms.ComboBox()
        Me.CmbValor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.ChkValorBaja = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CmbCampos
        '
        Me.CmbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCampos.FormattingEnabled = True
        Me.CmbCampos.Location = New System.Drawing.Point(34, 47)
        Me.CmbCampos.Name = "CmbCampos"
        Me.CmbCampos.Size = New System.Drawing.Size(144, 21)
        Me.CmbCampos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Campos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Operadores"
        '
        'CmbOperadores
        '
        Me.CmbOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOperadores.FormattingEnabled = True
        Me.CmbOperadores.Location = New System.Drawing.Point(210, 47)
        Me.CmbOperadores.Name = "CmbOperadores"
        Me.CmbOperadores.Size = New System.Drawing.Size(144, 21)
        Me.CmbOperadores.TabIndex = 4
        '
        'CmbValor
        '
        Me.CmbValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbValor.FormattingEnabled = True
        Me.CmbValor.Location = New System.Drawing.Point(388, 47)
        Me.CmbValor.Name = "CmbValor"
        Me.CmbValor.Size = New System.Drawing.Size(142, 21)
        Me.CmbValor.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(385, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Valor"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(388, 74)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(142, 20)
        Me.TxtValor.TabIndex = 7
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(388, 100)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(142, 20)
        Me.DtpFecha.TabIndex = 9
        '
        'ChkValorBaja
        '
        Me.ChkValorBaja.AutoSize = True
        Me.ChkValorBaja.Location = New System.Drawing.Point(388, 126)
        Me.ChkValorBaja.Name = "ChkValorBaja"
        Me.ChkValorBaja.Size = New System.Drawing.Size(47, 17)
        Me.ChkValorBaja.TabIndex = 10
        Me.ChkValorBaja.Text = "Baja"
        Me.ChkValorBaja.UseVisualStyleBackColor = True
        '
        'FrmFiltros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 200)
        Me.Controls.Add(Me.ChkValorBaja)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.CmbValor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbOperadores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbCampos)
        Me.Name = "FrmFiltros"
        Me.Text = "Escoger socios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbCampos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbOperadores As ComboBox
    Friend WithEvents CmbValor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents ChkValorBaja As CheckBox
End Class
