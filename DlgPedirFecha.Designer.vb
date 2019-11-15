<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgPedirFecha
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
        Me.LblTexto = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnAcept = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTexto
        '
        Me.LblTexto.AutoSize = True
        Me.LblTexto.Location = New System.Drawing.Point(34, 20)
        Me.LblTexto.Name = "LblTexto"
        Me.LblTexto.Size = New System.Drawing.Size(39, 13)
        Me.LblTexto.TabIndex = 7
        Me.LblTexto.Text = "Label1"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(37, 50)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(156, 20)
        Me.DtpFecha.TabIndex = 4
        '
        'BtnAcept
        '
        Me.BtnAcept.Location = New System.Drawing.Point(118, 76)
        Me.BtnAcept.Name = "BtnAcept"
        Me.BtnAcept.Size = New System.Drawing.Size(75, 23)
        Me.BtnAcept.TabIndex = 5
        Me.BtnAcept.Text = "Aceptar"
        Me.BtnAcept.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(37, 76)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'DlgPedirFecha
        '
        Me.AcceptButton = Me.BtnAcept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(276, 161)
        Me.Controls.Add(Me.LblTexto)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.BtnAcept)
        Me.Controls.Add(Me.BtnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DlgPedirFecha"
        Me.Text = "DlgPedirFecha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTexto As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents BtnAcept As Button
    Friend WithEvents BtnCancel As Button
End Class
