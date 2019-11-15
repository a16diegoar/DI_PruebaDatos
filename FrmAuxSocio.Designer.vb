<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuxSocio
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
        Me.GrpDatos = New System.Windows.Forms.GroupBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.DtpAlta = New System.Windows.Forms.DateTimePicker()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.chkBaja = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAcept = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GrpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpDatos
        '
        Me.GrpDatos.Controls.Add(Me.CmbTipo)
        Me.GrpDatos.Controls.Add(Me.DtpAlta)
        Me.GrpDatos.Controls.Add(Me.TxtDni)
        Me.GrpDatos.Controls.Add(Me.TxtNom)
        Me.GrpDatos.Controls.Add(Me.chkBaja)
        Me.GrpDatos.Controls.Add(Me.Label2)
        Me.GrpDatos.Controls.Add(Me.Label3)
        Me.GrpDatos.Controls.Add(Me.Label4)
        Me.GrpDatos.Controls.Add(Me.Label5)
        Me.GrpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GrpDatos.Location = New System.Drawing.Point(14, 14)
        Me.GrpDatos.Margin = New System.Windows.Forms.Padding(5)
        Me.GrpDatos.Name = "GrpDatos"
        Me.GrpDatos.Padding = New System.Windows.Forms.Padding(5)
        Me.GrpDatos.Size = New System.Drawing.Size(500, 227)
        Me.GrpDatos.TabIndex = 43
        Me.GrpDatos.TabStop = False
        Me.GrpDatos.Text = "Datos del Socio"
        '
        'CmbTipo
        '
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(186, 143)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(285, 32)
        Me.CmbTipo.TabIndex = 47
        '
        'DtpAlta
        '
        Me.DtpAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpAlta.Location = New System.Drawing.Point(186, 108)
        Me.DtpAlta.Name = "DtpAlta"
        Me.DtpAlta.Size = New System.Drawing.Size(285, 29)
        Me.DtpAlta.TabIndex = 46
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(186, 73)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(285, 29)
        Me.TxtDni.TabIndex = 45
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(186, 38)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(285, 29)
        Me.TxtNom.TabIndex = 44
        '
        'chkBaja
        '
        Me.chkBaja.AutoSize = True
        Me.chkBaja.Enabled = False
        Me.chkBaja.Location = New System.Drawing.Point(186, 183)
        Me.chkBaja.Margin = New System.Windows.Forms.Padding(5)
        Me.chkBaja.Name = "chkBaja"
        Me.chkBaja.Size = New System.Drawing.Size(65, 28)
        Me.chkBaja.TabIndex = 15
        Me.chkBaja.Text = "Baja"
        Me.chkBaja.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "DNI:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Alta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo:"
        '
        'BtnAcept
        '
        Me.BtnAcept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAcept.Location = New System.Drawing.Point(402, 259)
        Me.BtnAcept.Name = "BtnAcept"
        Me.BtnAcept.Size = New System.Drawing.Size(83, 35)
        Me.BtnAcept.TabIndex = 44
        Me.BtnAcept.Text = "Aceptar"
        Me.BtnAcept.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(200, 259)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(83, 35)
        Me.BtnCancel.TabIndex = 45
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FrmAuxSocio
        '
        Me.AcceptButton = Me.BtnAcept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(544, 332)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAcept)
        Me.Controls.Add(Me.GrpDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmAuxSocio"
        Me.GrpDatos.ResumeLayout(False)
        Me.GrpDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpDatos As GroupBox
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents DtpAlta As DateTimePicker
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents chkBaja As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAcept As Button
    Friend WithEvents BtnCancel As Button
End Class
