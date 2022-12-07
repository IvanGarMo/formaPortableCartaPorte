Public Class frmModalMercancias
    Private _idUbicacion As String
    Private _mercancias As List(Of Mercancia)

    Public Event MercanciaSeleccionada(ByVal operacion As String, ByVal idUbicacion As String, ByVal claveProdServ As String, ByVal claveUnidad As String, ByVal esPeligroso As Boolean, ByVal valorUnidad As String)
    Public Event QuiereEliminarMercancia(ByVal operacion As String, ByVal idUbicacion As String, ByVal claveProdServ As String, ByVal claveUnidad As String, ByVal esPeligroso As Boolean, ByVal valorUnidad As String)

    Public Sub New(idUbicacion As String, mercancias As List(Of Mercancia))
        InitializeComponent()
        _idUbicacion = idUbicacion
        _mercancias = mercancias
    End Sub

    Private Sub BindGridDetalleMercanciasPorMovimiento()
        lblMercanciasMovimiento.Text = String.Format("Mercancías del movimiento - {0}", _idUbicacion)
        dgvMercanciasPorMovimiento.AutoGenerateColumns = False
        dgvMercanciasPorMovimiento.Columns("MercanciaClaveProdServClm").DataPropertyName = NameOf(Mercancia.ClaveProdServ)
        dgvMercanciasPorMovimiento.Columns("MercanciaClasificacionSATClm").DataPropertyName = NameOf(Mercancia.Descripcion)
        dgvMercanciasPorMovimiento.Columns("MovimientoDescripcionClm").DataPropertyName = NameOf(Mercancia.DescripcionInternaModal)
        dgvMercanciasPorMovimiento.Columns("MercanciaMovimientoPeligrosaClm").DataPropertyName = NameOf(Mercancia.EsMaterialPeligrosoCad)
        dgvMercanciasPorMovimiento.Columns("MercanciaCantidadMercClm").DataPropertyName = NameOf(Mercancia.Cantidad)
        dgvMercanciasPorMovimiento.Columns("MovimientoComercioIntClm").DataPropertyName = NameOf(Mercancia.EsComercioInternacionalCad)
        dgvMercanciasPorMovimiento.Columns("ClaveUnidadClm").DataPropertyName = NameOf(Mercancia.ClaveUnidad)
        dgvMercanciasPorMovimiento.Columns("DescripcionUnidadClm").DataPropertyName = NameOf(Mercancia.Unidad)
        dgvMercanciasPorMovimiento.Columns("MovimientoMercanciaCheckboxMaterialCheckboxClm").DataPropertyName = NameOf(Mercancia.MaterialPeligroso)
        dgvMercanciasPorMovimiento.Columns("ValorMercanciaClm").DataPropertyName = NameOf(Mercancia.ValorMercanciaCadena)
        dgvMercanciasPorMovimiento.DataSource = _mercancias
    End Sub

    Private Sub frmModalMercancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindGridDetalleMercanciasPorMovimiento()
    End Sub

    Private Sub dgvMercanciasPorMovimiento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMercanciasPorMovimiento.CellContentClick
        Dim indiceColumnaEliminar As Int32 = dgvMercanciasPorMovimiento.Columns("MovimientoMercanciaEliminarClm").Index
        Dim indiceColumnaDetalle As Int32 = dgvMercanciasPorMovimiento.Columns("MovimientoDetallesMercClm").Index

        If e.ColumnIndex <> indiceColumnaEliminar AndAlso e.ColumnIndex <> indiceColumnaDetalle Then
            Return
        End If

        Dim claveProdServ As String = dgvMercanciasPorMovimiento.Rows(e.RowIndex).Cells("MercanciaClaveProdServClm").Value.ToString()
        Dim claveUnidad As String = dgvMercanciasPorMovimiento.Rows(e.RowIndex).Cells("ClaveUnidadClm").Value.ToString()
        Dim mercanciaPeligrosa As Boolean = dgvMercanciasPorMovimiento.Rows(e.RowIndex).Cells("MercanciaMovimientoPeligrosaClm").Value.Equals("SI")
        Dim valorUnidad As String = dgvMercanciasPorMovimiento.Rows(e.RowIndex).Cells("ValorMercanciaClm").Value

        If e.ColumnIndex = indiceColumnaDetalle Then
            RaiseEvent MercanciaSeleccionada("DETALLE", _idUbicacion, claveProdServ, claveUnidad, mercanciaPeligrosa, valorUnidad)
        ElseIf e.ColumnIndex = indiceColumnaEliminar Then
            RaiseEvent QuiereEliminarMercancia("ELIMINAR", _idUbicacion, claveProdServ, claveUnidad, mercanciaPeligrosa, valorUnidad)
        End If
    End Sub
End Class