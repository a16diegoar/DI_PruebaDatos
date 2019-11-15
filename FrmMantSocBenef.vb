Imports System.Data.OleDb

Public Class FrmMantSocBenef
    Dim CnnSociedad As OleDbConnection
    Dim DtaSocios, DtaBenef, DtaCuotas As OleDbDataAdapter
    Dim DtsConsultas As New DataSet
    Dim CmbSocios, CmbBenef As OleDbCommandBuilder

    Private Sub FrmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        CnnSociedad = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""L:\DesenvolvementoInterfaces\Recursos\Sociedad.accdb""")

        'Cargar datos de cuotas
        DtaCuotas = New OleDbDataAdapter("SELECT * FROM cuotas ORDER BY TipoSocio", CnnSociedad)
        DtaCuotas.Fill(DtsConsultas, "Cuotas")

        'Mostrar beneficiarios de forma predet
        LblBenef.Visible = True
        DtgBenef.Visible = True

        BtnVsocios(Nothing, Nothing)

        CmbSocios = New OleDbCommandBuilder(DtaSocios)
        CmbBenef = New OleDbCommandBuilder(DtaBenef)
    End Sub

    Private Sub EnlazarEtiquetas()
        If lblNsocio.DataBindings.Count = 0 Then
            lblNsocio.DataBindings.Add("Text", DtsConsultas.Tables("Socios"), "Nsocio")
            lblNombre.DataBindings.Add("Text", DtsConsultas.Tables("Socios"), "Nombre")
            lblDni.DataBindings.Add("Text", DtsConsultas.Tables("Socios"), "NIF")
            lblFecha.DataBindings.Add("Text", DtsConsultas.Tables("Socios"), "FechaAlta")
            lblTipo.DataBindings.Add("Text", DtsConsultas.Tables("Socios"), "TipoSocio")
            chkBaja.DataBindings.Add("Checked", DtsConsultas.Tables("Socios"), "Baja")
        End If
    End Sub

    Private Sub BtnVsocios(sender As Object, e As EventArgs)
        DtaSocios = New OleDbDataAdapter("SELECT * FROM socios " &
                                         "ORDER BY NSocio", CnnSociedad)
        If DtsConsultas.Tables("Socios") Is Nothing Then
            'fill abre la conexion automaticamente
            DtaSocios.Fill(DtsConsultas, "Socios")
        End If
        'enlazar list box
        CmbNombres.DataSource = DtsConsultas.Tables("Socios")
        CmbNombres.DisplayMember = "Nombre"
        'enlazar combo box
        cboxSocios.DataSource = DtsConsultas.Tables("Socios")
        cboxSocios.DisplayMember = "NIF"
        'enlazar datagrid
        DtgSocios.DataSource = DtsConsultas.Tables("Socios")
        'Enlazar etiquetas
        EnlazarEtiquetas()
        btnanterior.Enabled = True
        btnsiguinte.Enabled = True
        btnprimero.Enabled = True
        btnultimo.Enabled = True
    End Sub

    Private Sub Btnprimero_Click(sender As Object, e As EventArgs) Handles btnprimero.Click
        Me.BindingContext(DtsConsultas.Tables("Socios")).Position = 0
    End Sub

    Private Sub Btnanterior_Click(sender As Object, e As EventArgs) Handles btnanterior.Click
        Me.BindingContext(DtsConsultas.Tables("Socios")).Position -= 1
    End Sub

    Private Sub Btnsiguinte_Click(sender As Object, e As EventArgs) Handles btnsiguinte.Click
        Me.BindingContext(DtsConsultas.Tables("Socios")).Position += 1
    End Sub

    Private Sub Btnultimo_Click(sender As Object, e As EventArgs) Handles btnultimo.Click
        Me.BindingContext(DtsConsultas.Tables("Socios")).Position = Me.BindingContext(DtsConsultas.Tables("Socios")).Count - 1
    End Sub

    Private Sub NumTotalSocios(sender As Object, e As EventArgs) Handles MnuNumTotalSocios.Click
        MsgBox(Me.BindingContext(DtsConsultas.Tables("Socios")).Count.ToString, MsgBoxStyle.Information, "Nº Socios")
    End Sub

    Private Sub NumSociosBaja(sender As Object, e As EventArgs) Handles MnuNumSociosBaja.Click
        ' Dim CmdSociosBaja As New OleDbCommand("select count(*) from Socios where Baja = true", CnnSociedad)
        'CnnSociedad.Open()
        'Dim sociosBaja As Integer = CmdSociosBaja.ExecuteScalar
        'CnnSociedad.Close()
        'MsgBox(sociosBaja.ToString, MsgBoxStyle.Information, "Nº Socios Baja")

        'Usando el listbox para sacar la informacion
        Dim contador As Integer = 0
        For Each fila As DataRowView In CmbNombres.Items
            If fila("Baja") Then
                contador += 1
            End If
        Next
        MsgBox(contador.ToString, MsgBoxStyle.Information, "Nº Socios Baja")
    End Sub

    Private Sub NumSociosAntig(sender As Object, e As EventArgs) Handles MnuSociosAntig.Click
        DlgPedirFecha.LblTexto.Text = "Socios de alta anteriores a:"
        If DlgPedirFecha.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        Dim fecha As Date = DlgPedirFecha.DtpFecha.Value
        Dim n As Integer = 0
        For Each fila As DataRowView In CmbNombres.Items
            If fila("FechaAlta") < fecha Then
                n += 1
            End If
        Next
        MsgBox("Nº de socios anteriores a " + fecha.ToShortDateString + ": " + n.ToString, MsgBoxStyle.Information, "Antiguedades")
    End Sub

    Private Sub NumBenefSoc(sender As Object, e As EventArgs) Handles MnuNumBenefSoc.Click
        Dim cmdNBenef As New OleDbCommand("SELECT Count(*) FROM Beneficiarios " &
                                          "WHERE Beneficiarios.NSocio = " & lblNsocio.Text, CnnSociedad)
        CnnSociedad.Open()
        Dim nBenef As Integer
        nBenef = cmdNBenef.ExecuteScalar()
        CnnSociedad.Close()
        MsgBox("El Socio Nº " & lblNsocio.Text & " tiene " & nBenef.ToString & " beneficiarios", MsgBoxStyle.Information, "Nº Beneficiarios")
    End Sub

    Private Sub ActualizarBeneficiarios(sender As Object, e As EventArgs) Handles lblNsocio.TextChanged
        'Adapter
        DtaBenef = New OleDbDataAdapter("SELECT * FROM Beneficiarios " &
                                        "WHERE NSocio = " & lblNsocio.Text &
                                        " ORDER BY NBenef", CnnSociedad)
        If Not DtsConsultas.Tables("Beneficiarios") Is Nothing Then
            DtsConsultas.Tables("Beneficiarios").Rows.Clear()
        End If
        DtaBenef.Fill(DtsConsultas, "Beneficiarios")

        DtgBenef.DataSource = DtsConsultas.Tables("Beneficiarios")

        CmbBenef = New OleDbCommandBuilder(DtaBenef)
    End Sub

    Private Function GetCuota(tipoSocio As String) As Single
        Dim pos As Integer
        DtsConsultas.Tables("Cuotas").DefaultView.Sort = "TipoSocio"
        pos = DtsConsultas.Tables("Cuotas").DefaultView.Find(tipoSocio)
        Return DtsConsultas.Tables("Cuotas").Rows(pos)("Cuota")
    End Function

    Private Sub CalcularCuotaSocio(sender As Object, e As EventArgs) Handles MnuCalcCuotaSocio.Click
        If chkBaja.Checked Then
            MsgBox("El socio Nº " & lblNsocio.Text & " está de baja", MsgBoxStyle.Information, "Socio de baja")
            Exit Sub
        End If

        Dim cuotaTotal As Single = GetCuota(lblTipo.Text)
        For Each fila As DataRow In DtsConsultas.Tables("Beneficiarios").Rows
            If fila("NSocio") = lblNsocio.Text Then
                cuotaTotal += GetCuota(fila("TipoSocio"))
            End If
        Next

        MsgBox("El socio Nº " & lblNsocio.Text & " paga una cuota de " & cuotaTotal & "€", MsgBoxStyle.Information, "Cuota total")
    End Sub

    Private Sub ToggleBenefSocio(sender As Object, e As EventArgs) Handles MnuMostrarOcultarBenef.Click, BtsToggBenef.Click
        If DtgBenef.Visible Then
            LblBenef.Visible = False
            DtgBenef.Visible = False
        Else
            LblBenef.Visible = True
            DtgBenef.Visible = True
        End If
    End Sub

    Private Sub FiltrarCuotas(Tipo As String)
        Dim sFriltro As String = "AplicableA = '" & Tipo & "'"
        DtsConsultas.Tables("Cuotas").DefaultView.RowFilter = sFriltro
    End Sub

    Private Sub LeerCampos(fila As DataRow)
        With FrmAuxSocio
            fila("NIF") = .TxtDni.Text
            fila("Nombre") = .TxtNom.Text
            fila("FechaAlta") = .DtpAlta.Value
            fila("TipoSocio") = .CmbTipo.SelectedValue
            fila("Baja") = .chkBaja.Checked
        End With
    End Sub

    Private Function GetNumPers(Optional p As Integer = 0) As Short
        Dim cmdUlt As OleDbCommand
        Dim ultimo As Short
        If p = 0 Then
            cmdUlt = New OleDbCommand("SELECT Max(NSocio) FROM Socios", CnnSociedad)
        Else
            cmdUlt = New OleDbCommand("SELECT Max(NBenef) FROM Beneficiarios WHERE NSocio = " & p, CnnSociedad)
        End If

        CnnSociedad.Open()
        Dim val As Object = cmdUlt.ExecuteScalar()
        CnnSociedad.Close()
        If val Is DBNull.Value Then
            Ultimo = CShort(1)
        Else
            ultimo = CShort(val) + 1
        End If
        Return ultimo

    End Function

    Private Sub MnuNuevoSocio_Click(sender As Object, e As EventArgs) Handles MnuNuevoSocio.Click, BtsNuevoSoc.Click
        With FrmAuxSocio
            .Text = "Alta de socio nuevo"
            .chkBaja.Enabled = False
            .TxtDni.Text = ""
            .TxtNom.Text = ""
            .DtpAlta.Value = Today
            .CmbTipo.SelectedValue = "Trabajador"

            FiltrarCuotas("S")
            .CmbTipo.DataSource = DtsConsultas.Tables("Cuotas").DefaultView
            .CmbTipo.DisplayMember = "Descripcion"
            .CmbTipo.ValueMember = "TipoSocio"

            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If

            Dim fila As DataRow
            fila = DtsConsultas.Tables("Socios").NewRow
            LeerCampos(fila)
            fila("NSocio") = GetNumPers()
            DtsConsultas.Tables("Socios").Rows.Add(fila)
            CnnSociedad.Open()
            DtaSocios.Update(DtsConsultas.Tables("Socios"))
            DtsConsultas.AcceptChanges()
            CnnSociedad.Close()
        End With
    End Sub

    Private Sub MnuModificarSocio_Click(sender As Object, e As EventArgs) Handles MnuModificarSocio.Click
        With FrmAuxSocio
            .Text = "Modificar datos de socio"
            .chkBaja.Enabled = True
            .TxtNom.Text = lblNombre.Text
            .TxtDni.Text = lblDni.Text
            .DtpAlta.Value = CDate(lblFecha.Text).ToShortDateString
            .chkBaja.Checked = chkBaja.Checked
            FiltrarCuotas("S")
            .CmbTipo.DataSource = DtsConsultas.Tables("Cuotas").DefaultView
            .CmbTipo.DisplayMember = "Descripcion"
            .CmbTipo.ValueMember = "TipoSocio"
            .CmbTipo.SelectedValue = lblTipo.Text

            If (.ShowDialog = DialogResult.Cancel) Then
                Exit Sub
            End If

            Dim pos As Integer = Me.BindingContext(DtsConsultas.Tables("Socios")).Position
            Dim fila As DataRow
            fila = DtsConsultas.Tables("Socios").Rows(pos)
            fila.BeginEdit()
            LeerCampos(fila)
            fila.EndEdit()

            If fila("Baja") Then
                'Comprobar benef
                If Me.BindingContext(DtsConsultas.Tables("Beneficiarios")).Count > 0 Then
                    'Modificar beneficiarios
                    For Each filaBenef As DataRow In DtsConsultas.Tables("Beneficiarios").Rows
                        filaBenef.BeginEdit()
                        filaBenef("Baja") = True
                        filaBenef.EndEdit()
                    Next


                    DtaBenef.Update(DtsConsultas, "Beneficiarios")
                End If
            End If

            DtaSocios.Update(DtsConsultas, "Socios")
            DtsConsultas.AcceptChanges()
        End With
    End Sub

    Private Sub MnuBorrarSocio_Click(sender As Object, e As EventArgs) Handles MnuBorrarSocio.Click
        If MsgBox("¿Seguro que desea eliminar este socio y todos sus beneficiarios?",
                  MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2,
                  "¿Eliminar socio?") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Eliminar Beneficiarios
        For Each filaBenef As DataRow In DtsConsultas.Tables("Beneficiarios").Rows
            filaBenef.Delete()
        Next
        DtaBenef.Update(DtsConsultas, "Beneficiarios")

        'Eliminar socio
        Dim pos As Integer = Me.BindingContext(DtsConsultas.Tables("Socios")).Position
        Dim filaSocio As DataRow = DtsConsultas.Tables("Socios").Rows(pos)
        filaSocio.Delete()
        DtaSocios.Update(DtsConsultas, "Socios")

        'Confirmar cambios
        DtsConsultas.AcceptChanges()
    End Sub

    Private Sub MnuNuevoBenef_Click(sender As Object, e As EventArgs) Handles MnuNuevoBenef.Click
        With FrmAuxSocio
            .Text = "Alta de beneficiario nuevo"
            .GrpDatos.Text = "Datos del Beneficiario"
            .TxtNom.Text = ""
            .TxtDni.Text = ""
            .DtpAlta.Value = Today
            FiltrarCuotas("B")
            .CmbTipo.DataSource = DtsConsultas.Tables("Cuotas").DefaultView
            .CmbTipo.DisplayMember = "Descripcion"
            .CmbTipo.ValueMember = "TipoSocio"
            .chkBaja.Enabled = False

            If (.ShowDialog = DialogResult.Cancel) Then
                Exit Sub
            End If

            Dim fila As DataRow
            fila = DtsConsultas.Tables("Beneficiarios").NewRow
            LeerCampos(fila)
            fila("NSocio") = lblNsocio.Text
            fila("NBenef") = GetNumPers(CInt(lblNsocio.Text))
            DtsConsultas.Tables("Beneficiarios").Rows.Add(fila)

            CmbBenef = New OleDbCommandBuilder(DtaBenef)
            DtaBenef.Update(DtsConsultas.Tables("Beneficiarios"))
            DtsConsultas.AcceptChanges()
        End With
    End Sub

    Private Sub MnuModificarBenef_Click(sender As Object, e As EventArgs) Handles MnuModificarBenef.Click
        If Me.BindingContext(DtsConsultas.Tables("Beneficiarios")).Count <= 0 Then
            MsgBox("El socio no tiene beneficiarios", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If

        With FrmAuxSocio
            .Text = "Modificar datos del beneficiario"
            .chkBaja.Enabled = If(chkBaja.Checked, False, True)
            .TxtNom.Text = DtgBenef.CurrentRow.Cells("Nombre").Value.ToString()
            .TxtDni.Text = DtgBenef.CurrentRow.Cells("NIF").Value.ToString()
            .DtpAlta.Value = CDate(DtgBenef.CurrentRow.Cells("FechaAlta").Value).ToShortDateString
            .chkBaja.Checked = DtgBenef.CurrentRow.Cells("Baja").Value
            FiltrarCuotas("B")
            .CmbTipo.DataSource = DtsConsultas.Tables("Cuotas").DefaultView
            .CmbTipo.DisplayMember = "Descripcion"
            .CmbTipo.ValueMember = "TipoSocio"
            .CmbTipo.SelectedValue = DtgBenef.CurrentRow.Cells("TipoSocio").Value

            If (.ShowDialog = DialogResult.Cancel) Then
                Exit Sub
            End If

            Dim pos As Integer = Me.BindingContext(DtsConsultas.Tables("Beneficiarios")).Position
            Dim fila As DataRow
            fila = DtsConsultas.Tables("Beneficiarios").Rows(pos)
            fila.BeginEdit()
            LeerCampos(fila)
            fila.EndEdit()

            CmbBenef = New OleDbCommandBuilder(DtaBenef)
            DtaBenef.Update(DtsConsultas, "Beneficiarios")
            DtsConsultas.AcceptChanges()
        End With
    End Sub

    Private Sub MnuBorrarBenef_Click(sender As Object, e As EventArgs) Handles MnuBorrarBenef.Click
        Dim pos As Integer = Me.BindingContext(DtsConsultas.Tables("Beneficiarios")).Position
        If pos = -1 Then
            Exit Sub
        End If

        If MsgBox("¿Seguro que desea eliminar este beneficiario?",
                  MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2,
                  "¿Eliminar beneficiario?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim filaSocio As DataRow = DtsConsultas.Tables("Beneficiarios").Rows(pos)
        filaSocio.Delete()
        DtaBenef.Update(DtsConsultas, "Beneficiarios")
        DtsConsultas.AcceptChanges()
    End Sub

    Private Sub MnuSalir_Click(sender As Object, e As EventArgs) Handles MnuSalir.Click
        Me.Close()
    End Sub

End Class