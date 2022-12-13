Public Class frmIncorporarMovimientos
    Private _conexiones As ConexionesCartaPorte
    Private _tipoMovimiento As String
    Private _esOrigen As Boolean
    Private _idPadre As String
    Private _listaMovtos As List(Of String)
    Public Event FinalizarSeleccion(ByVal movimientos As List(Of String), ByVal esOrigen As Boolean)

    Public Sub New(ByVal tipoMovimiento As String, ByVal esOrigen As Boolean,
                   Optional ByVal idPadre As String = "",
                   Optional ByVal listaMovtos As List(Of String) = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        _conexiones = New ConexionesCartaPorte()
        _tipoMovimiento = tipoMovimiento
        _esOrigen = esOrigen
        _idPadre = idPadre
        _listaMovtos = IIf(listaMovtos Is Nothing, New List(Of String), listaMovtos)
    End Sub

    Private Sub PreparaFiltros()
        If _tipoMovimiento = "TRASPASO" Then
            lblFiltro1.Text = "Sucursal origen"
            lblFiltro2.Text = "Sucursal destino"
            lblFiltro3.Visible = False
            cbFiltroNivel3.Visible = False
            dgvMovimiento.Columns("ColFiltroNivelUno").HeaderText = "Sucursal Origen"
            dgvMovimiento.Columns("ColFiltroNivelDos").HeaderText = "Sucursal Destino"
            dgvMovimiento.Columns("ColFiltroNivelTres").Visible = False
        Else
            lblFiltro1.Text = "Sucursal"
            lblFiltro2.Text = "Vendedor"
            lblFiltro3.Text = "Cliente"
            lblFiltro3.Visible = True
            cbFiltroNivel3.Visible = True
            dgvMovimiento.Columns("ColFiltroNivelUno").HeaderText = "Sucursal"
            dgvMovimiento.Columns("ColFiltroNivelDos").HeaderText = "Vendedor"
            dgvMovimiento.Columns("ColFiltroNivelTres").HeaderText = "Cliente"
        End If
        CargaFiltroSubNivel(1)

        If Not _esOrigen Then
            Dim datosMovtoPadre As DataTable = _conexiones.Get_DatosMovimientoPadre(_tipoMovimiento,
                                                                                    "EAGLE",
                                                                                    _idPadre)
            cbFiltroNivel1.SelectedValue = datosMovtoPadre.Rows(0)("filtroNivel1").ToString()
            cbFiltroNivel1.Enabled = False
        End If
        btnBuscar_Click(Nothing, Nothing)
    End Sub

    Private Sub CargaFiltroSubNivel(ByVal nivel As Int16)
        RemoveHandler cbFiltroNivel1.SelectedValueChanged, AddressOf cbFiltroNivel1_SelectedValueChanged
        RemoveHandler cbFiltroNivel2.SelectedValueChanged, AddressOf cbFiltroNivel2_SelectedValueChanged
        RemoveHandler cbFiltroNivel3.SelectedValueChanged, AddressOf cbFiltroNivel3_SelectedValueChanged
        AddHandler cbFiltroNivel1.SelectedValueChanged, AddressOf cbFiltroNivel1_SelectedValueChanged
        Dim dataSet As DataSet
        If nivel = 1 Then
            dataSet = _conexiones.Get_FiltrosConsultaMovimiento(_tipoMovimiento, "EAGLE", nivel:=nivel)
            BindCombobox(cbFiltroNivel2, dataSet.Tables(0))
            BindCombobox(cbFiltroNivel3, dataSet.Tables(0))
            BindCombobox(cbFiltroNivel1, dataSet.Tables(1))
            cbFiltroNivel2.Enabled = False
            cbFiltroNivel3.Enabled = False
        ElseIf nivel = 2 Then
            dataSet = _conexiones.Get_FiltrosConsultaMovimiento(_tipoMovimiento, "EAGLE", nivel:=nivel, filtroNivelUno:=cbFiltroNivel1.SelectedValue)
            BindCombobox(cbFiltroNivel3, dataSet.Tables(0))
            BindCombobox(cbFiltroNivel2, dataSet.Tables(1))
            cbFiltroNivel2.Enabled = True
            cbFiltroNivel3.Enabled = False
            AddHandler cbFiltroNivel2.SelectedValueChanged, AddressOf cbFiltroNivel2_SelectedValueChanged
        ElseIf nivel = 3 Then
            dataSet = _conexiones.Get_FiltrosConsultaMovimiento(_tipoMovimiento, "EAGLE", nivel:=nivel, filtroNivelUno:=cbFiltroNivel1.SelectedValue, filtroNivelDos:=cbFiltroNivel2.SelectedValue)
            BindCombobox(cbFiltroNivel3, dataSet.Tables(1))
            cbFiltroNivel3.Enabled = True
            AddHandler cbFiltroNivel2.SelectedValueChanged, AddressOf cbFiltroNivel2_SelectedValueChanged
            AddHandler cbFiltroNivel3.SelectedValueChanged, AddressOf cbFiltroNivel3_SelectedValueChanged
        End If
    End Sub

    Private Sub BindCombobox(ByRef cbCombo As ComboBox, ByRef source As DataTable)
        If cbCombo IsNot Nothing Then
            cbCombo = New ComboBox
        End If

        If cbCombo.Items IsNot Nothing Then
            cbCombo.Items.Clear()
        End If

        cbCombo.DataSource = Nothing
        cbCombo.ValueMember = "id"
        cbCombo.DisplayMember = "descripcion"
        cbCombo.DataSource = source
    End Sub

    Private Sub BindGrid(ByRef datos As DataTable)
        dgvMovimiento.DataSource = Nothing
        If dgvMovimiento.Rows IsNot Nothing Then
            dgvMovimiento.Rows.Clear()
        End If

        dgvMovimiento.AutoGenerateColumns = False
        dgvMovimiento.RowHeadersVisible = False
        dgvMovimiento.AllowUserToAddRows = False
        dgvMovimiento.Columns("ColSeleccionar").DataPropertyName = "seleccionado"
        dgvMovimiento.Columns("ColMovimiento").DataPropertyName = "movimiento"
        dgvMovimiento.Columns("ColFecha").DataPropertyName = "fecha"
        dgvMovimiento.Columns("ColFiltroNivelUno").DataPropertyName = "filtroNivel1"
        dgvMovimiento.Columns("ColFiltroNivelDos").DataPropertyName = "filtroNivel2"
        dgvMovimiento.Columns("ColFiltroNivelTres").DataPropertyName = "filtroNivel3"
        dgvMovimiento.Columns("ColTooltip").DataPropertyName = "tooltip"
        dgvMovimiento.Columns("ColDisponible").DataPropertyName = "disponible"
        dgvMovimiento.DataSource = datos
    End Sub

    Private Sub cbFiltroNivel1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbFiltroNivel1.SelectedValueChanged
        CargaFiltroSubNivel(2)
    End Sub

    Private Sub cbFiltroNivel2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbFiltroNivel2.SelectedValueChanged
        CargaFiltroSubNivel(3)
    End Sub

    Private Sub cbFiltroNivel3_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbFiltroNivel3.SelectedValueChanged

    End Sub

    Private Sub Respaldar()
        _listaMovtos = New List(Of String)
        Dim colSeleccionarIndex As Int32 = dgvMovimiento.Columns("ColSeleccionar").Index
        Dim colMovimientoIndex As Int32 = dgvMovimiento.Columns("ColMovimiento").Index
        For i As Int64 = 0 To dgvMovimiento.Rows.Count Step 1
            Dim seleccionado As Boolean = CType(dgvMovimiento.Rows(i).Cells(colSeleccionarIndex), DataGridViewCheckBoxCell).Value
            If seleccionado Then
                _listaMovtos.Add(dgvMovimiento.Rows(i).Cells(colMovimientoIndex).Value.ToString())
            End If
        Next
    End Sub

    Private Sub dgvMovimiento_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMovimiento.CellFormatting
        Dim indiceTooltip As Int32 = dgvMovimiento.Columns("ColTooltip").Index
        Dim indiceDisponible As Int32 = dgvMovimiento.Columns("ColDisponible").Index
        Dim indiceMovimiento As Int32 = dgvMovimiento.Columns("ColMovimiento").Index

        If e.ColumnIndex = indiceTooltip Then
            Dim textoToolTip As String = dgvMovimiento.Rows(e.RowIndex).Cells(indiceTooltip).Value.ToString()
            dgvMovimiento.Rows(e.RowIndex).Cells(indiceMovimiento).ToolTipText = textoToolTip
        ElseIf e.ColumnIndex = indiceDisponible Then
            Dim disponible As Boolean = CType(dgvMovimiento.Rows(e.RowIndex).Cells(indiceDisponible).Value, Boolean)
            If Not disponible Then
                dgvMovimiento.Rows(disponible).DefaultCellStyle.BackColor = Color.FromName("AppWorkspace")
                dgvMovimiento.Rows(disponible).Cells("ColSeleccionar").ReadOnly = True
            End If
        ElseIf e.ColumnIndex = indiceMovimiento Then
            Dim indiceSeleccionar As Int32 = dgvMovimiento.Columns("ColSeleccionar").Index
            Dim idMovto As String = dgvMovimiento.Rows(e.RowIndex).Cells("ColMovimiento").Value.ToString()
            If _listaMovtos.Contains(idMovto) Then
                CType(dgvMovimiento.Rows(e.RowIndex).Cells(indiceSeleccionar), DataGridViewCheckBoxCell).Value = True
                _listaMovtos.Remove(idMovto)
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim listadoMovimientos As DataTable = _conexiones.Get_MovimientosDisponibles(_tipoMovimiento,
                                                            "EAGLE",
                                                            dtFechaInicioBusqueda.Value,
                                                            dtFechaFinBusqueda.Value,
                                                            cbFiltroNivel1.SelectedValue,
                                                            cbFiltroNivel2.SelectedValue,
                                                            cbFiltroNivel3.SelectedValue)
        BindGrid(listadoMovimientos)
    End Sub

    Private Sub dgvMovimiento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovimiento.CellContentClick
        If Not _esOrigen Then Return
        Dim colSeleccionarIndex As Int32 = dgvMovimiento.Columns("ColSeleccionar").Index
        If e.ColumnIndex <> colSeleccionarIndex Then Return

        Dim indiceRow As Int32 = e.RowIndex
        For i As Int64 = 0 To dgvMovimiento.Rows.Count Step 1
            If indiceRow = i Then Continue For
            CType(dgvMovimiento.Rows(i).Cells(colSeleccionarIndex), DataGridViewCheckBoxCell).Value = False
        Next
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Respaldar()
        RaiseEvent FinalizarSeleccion(_listaMovtos, _esOrigen)
    End Sub
End Class