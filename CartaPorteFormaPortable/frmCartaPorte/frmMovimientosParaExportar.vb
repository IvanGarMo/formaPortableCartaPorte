Imports System.Text.RegularExpressions

Public Class frmMovimientosParaExportar
    Private listaUbicaciones As List(Of OrigenDestino)
    Private datosMercancias As Dictionary(Of String, List(Of Mercancia))
    Private estaCargadoMovimientoPadre As Boolean
    Private utils As Utils
    Private conexionesCartaPorte As ConexionesCartaPorte
    Private parametrosFormaCartaPorte As DataTable
    Private empresa As String = "EAGLE"
    Private datosEscenario As DataRow

    Public Sub New(ByVal datosEscenario As DataRow)
        InitializeComponent()
        estaCargadoMovimientoPadre = False
        listaUbicaciones = New List(Of OrigenDestino)
        datosMercancias = New Dictionary(Of String, List(Of Mercancia))
        utils = New Utils
        Me.datosEscenario = datosEscenario
    End Sub

    Private Sub frmMovimientosParaExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnReiniciar_Click(Nothing, Nothing)
        conexionesCartaPorte = New ConexionesCartaPorte
        parametrosFormaCartaPorte = conexionesCartaPorte.Get_ObtenParametros()
        lblDescripcionEscenario.Text = datosEscenario("descripcionEscenario").ToString()
    End Sub

    Private Sub AlertaMensaje(ByVal mensaje As String)
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Error")
    End Sub

    Private Function ObtenParametroPorLlave(ByRef llave As String) As String
        For Each r As DataRow In parametrosFormaCartaPorte.Rows
            If r("clave").ToString.Equals(llave) Then
                Return r("valor").ToString
            End If
        Next
        Return String.Empty
    End Function

    Private Sub LimpiaGrid(ByRef grid As DataGridView)
        grid.DataSource = Nothing
        If grid.Rows IsNot Nothing Then
            grid.Rows.Clear()
        End If
        grid.AutoGenerateColumns = False
    End Sub

    Private Sub BindGridUbicaciones()
        LimpiaGrid(dgvMovimientos)
        dgvMovimientos.Columns("MovimientosTipoMovimientoClm").DataPropertyName = NameOf(OrigenDestino.TipoMovimiento)
        dgvMovimientos.Columns("MovimientosIdUbicacionClm").DataPropertyName = NameOf(OrigenDestino.IDUbicacion)
        dgvMovimientos.Columns("MovimientosRfcClm").DataPropertyName = NameOf(OrigenDestino.RFCRemitenteDestinatario)
        dgvMovimientos.Columns("MovimientosNombreClm").DataPropertyName = NameOf(OrigenDestino.NombreUbicacionParaComplemento)
        dgvMovimientos.Columns("MovimientosCpClm").DataPropertyName = NameOf(OrigenDestino.CodigoPostalUbicacion)
        dgvMovimientos.DataSource = listaUbicaciones
    End Sub

    Private Sub BindGridMercanciasDeUbicacion(ByVal idUbicacion As String)
        LimpiaGrid(dgvMercanciasDeMovimiento)
        dgvMercanciasDeMovimiento.Columns("MercClaveProdServClm").DataPropertyName = NameOf(Mercancia.ClaveProdServ)
        dgvMercanciasDeMovimiento.Columns("MercDescripcionClm").DataPropertyName = NameOf(Mercancia.DescripcionInterna)
        dgvMercanciasDeMovimiento.Columns("MercClaveUnidadClm").DataPropertyName = NameOf(Mercancia.ClaveUnidad)
        dgvMercanciasDeMovimiento.Columns("MercPesoEnKgClm").DataPropertyName = NameOf(Mercancia.PesoEnKg)
        dgvMercanciasDeMovimiento.Columns("MercValorClm").DataPropertyName = NameOf(Mercancia.ValorMercancia)

        Dim listadoMercancias As List(Of Mercancia) = datosMercancias(idUbicacion)
        dgvMercanciasDeMovimiento.DataSource = listadoMercancias
        BindLabelMercanciasDeUbicacion(idUbicacion, listadoMercancias.Count)
    End Sub

    Private Sub BindLabelMercanciasDeUbicacion(ByVal idUbicacion As String, ByVal noMercancias As Int32)
        lblMercanciasMovimiento.Text = "Viendo movimiento " + idUbicacion + " (" + noMercancias.ToString() + " mercancías)"
    End Sub

    Private Sub dgvMovimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovimientos.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim indiceBoton As Int32 = dgvMovimientos.Columns("MovimientosDetalleBtnClm").Index
        If e.ColumnIndex <> indiceBoton Then
            Return
        End If


        Dim idUbicacion As String = dgvMovimientos.Rows(e.RowIndex).Cells("MovimientosIdUbicacionClm").Value
        If idUbicacion.Contains("OR") Then
            AlertaMensaje(ObtenParametroPorLlave("ORIGEN_SINCARGA"))
            Return
        End If

        BindGridMercanciasDeUbicacion(idUbicacion)
    End Sub

    Private Sub CargaTrasladoPadre(ByRef tipoMovimiento As String, ByRef idMovimiento As String)
        If Len(idMovimiento) > 30 Then
            AlertaMensaje(ObtenParametroPorLlave("NO_EXISTE_MOV"))
            txtIdMovimientoPadre.Text = String.Empty
            DesactivaBusquedaIntermedios()
        End If

        Dim datos As DataSet = conexionesCartaPorte.Get_DatosTraslado(empresa, tipoMovimiento, idMovimiento)
        If datos Is Nothing OrElse datos.Tables(0) Is Nothing OrElse datos.Tables(0).Rows.Count = 0 Then
            AlertaMensaje(ObtenParametroPorLlave("NO_EXISTE_MOV"))
            txtIdMovimientoPadre.Text = String.Empty
            DesactivaBusquedaIntermedios()
            Return
        End If

        Dim datosOrigen As OrigenDestino = utils.CreaObjetoOrigenDestino(datos.Tables(0).Rows(0))
        datosOrigen.FechaSalidaLlegada = DateTime.Today
        datosOrigen.HoraSalidaLlegada = "00:00"
        datosOrigen.EsDestinoIntermedio = False
        datosOrigen.IDUbicacion = "OR000001"
        datosOrigen.TipoUbicacion = "Origen"
        datosOrigen.DatosDomicilio = utils.CreaObjetoDomicilio(datos.Tables(0).Rows(0))
        listaUbicaciones.Add(datosOrigen)

        Dim datosDestino As OrigenDestino
        If datosEscenario("tipoMovimiento").ToString() = "TRASPASO" Then
            datosDestino = New OrigenDestino
            utils.CopiaDatosFiscales(datosOrigen, datosDestino)
        ElseIf datos.Tables(1).Rows.Count > 0 Then
            datosDestino = utils.CreaObjetoOrigenDestino(datos.Tables(1).Rows(0))
        Else
            datosDestino = New OrigenDestino
        End If
        datosDestino.UsuarioCausoProblemasConFecha = True
        datosDestino.UsuarioCausoProblemasConKm = True
        datosDestino.IDUbicacion = "DE0000001"
        datosDestino.TipoUbicacion = "Destino"

        Dim datosDomicilioDestino As Domicilio
        If datos.Tables(1).Rows.Count > 0 Then
            datosDomicilioDestino = utils.CreaObjetoDomicilio(datos.Tables(1).Rows(0))
        Else
            datosDomicilioDestino = New Domicilio
        End If
        datosDestino.DatosDomicilio = datosDomicilioDestino
        listaUbicaciones.Add(datosDestino)

        Dim listadoMercancias As List(Of Mercancia) = New List(Of Mercancia)
        For Each dr As DataRow In datos.Tables(2).Rows
            listadoMercancias.Add(utils.CreaObjetoMercancia(dr))
        Next

        datosMercancias.Add(datosDestino.IDUbicacion, listadoMercancias)

        txtIdMovimientoPadre.Enabled = False
        btnBuscarMovimientoPadre.Enabled = False
        txtIdMovimientoIntermedio.Enabled = True
        txtIdMovimientoIntermedio.Text = String.Empty
        btnBuscarMovimientoIntermedio.Enabled = True
        BindGridUbicaciones()
        LimpiaGrid(dgvMercanciasDeMovimiento)
        btnExportar.Enabled = True
    End Sub

    Private Sub CargaTrasladoIntermedio(ByRef idTipoMovimiento As String, ByRef idMovimiento As String)
        If Len(idMovimiento) > 30 Then
            AlertaMensaje(ObtenParametroPorLlave("NO_EXISTE_MOV"))
            txtIdMovimientoIntermedio.Text = String.Empty
        End If

        Dim datos As DataSet = conexionesCartaPorte.Get_DatosTraslado(empresa, idTipoMovimiento, idMovimiento)
        If datos Is Nothing OrElse datos.Tables(0) Is Nothing OrElse datos.Tables(0).Rows.Count = 0 Then
            AlertaMensaje(ObtenParametroPorLlave("NO_EXISTE_MOV"))
            txtIdMovimientoIntermedio.Text = String.Empty
        End If

        Dim cpUbicacion As String = datos.Tables(0).Rows(0)("cp").ToString()
        If cpUbicacion <> listaUbicaciones(0).CodigoPostalUbicacion Then
            AlertaMensaje(ObtenParametroPorLlave("ORIGEN_DISTINTO"))
            txtIdMovimientoIntermedio.Text = String.Empty
            Return
        End If


        Dim ubicacion As OrigenDestino
        If datosEscenario("tipoMovimiento").ToString() = "TRASPASO" Then
            ubicacion = New OrigenDestino
            utils.CopiaDatosFiscales(ubicacion, listaUbicaciones(0))
        ElseIf datos.Tables(1).Rows.Count > 0 Then
            ubicacion = utils.CreaObjetoOrigenDestino(datos.Tables(1).Rows(0))
        Else
            ubicacion = New OrigenDestino
        End If
        ubicacion.TipoUbicacion = "Destino"
        ubicacion.EsDestinoIntermedio = True
        ubicacion.UsuarioCausoProblemasConFecha = True
        ubicacion.UsuarioCausoProblemasConKm = True
        ubicacion.IDUbicacion = GeneraIdDestinoIntermedio()

        Dim listadoMercancia As New List(Of Mercancia)
        For Each dr As DataRow In datos.Tables(2).Rows
            listadoMercancia.Add(utils.CreaObjetoMercancia(dr))
        Next

        listaUbicaciones.Add(ubicacion)
        datosMercancias.Add(ubicacion.IDUbicacion, listadoMercancia)
        BindGridMercanciasDeUbicacion(ubicacion.IDUbicacion)
    End Sub

    Private Sub DesactivaBusquedaIntermedios()
        txtIdMovimientoIntermedio.Enabled = False
        txtIdMovimientoIntermedio.Text = String.Empty
        btnBuscarMovimientoIntermedio.Enabled = False
    End Sub

    Private Sub btnBuscarMovimientoPadre_Click(sender As Object, e As EventArgs) Handles btnBuscarMovimientoPadre.Click
        Dim tipoMovimiento As String = datosEscenario("tipoMovimiento").ToString()
        CargaTrasladoPadre(tipoMovimiento, Trim(txtIdMovimientoPadre.Text))
    End Sub

    Private Function GeneraIdDestinoIntermedio() As String
        If listaUbicaciones.Count = 2 Then
            Return "DE000011"
        End If

        Dim idRepetido As Boolean = True
        Dim idUbicacionGenerado As String = String.Empty
        While idRepetido
            Dim idUbicacionUltima As String = listaUbicaciones.Last().IDUbicacion
            Dim idDeUbicacionInt As Int32 = CInt(Regex.Replace(idUbicacionUltima, "[A-Z]+", ""))
            idDeUbicacionInt = idDeUbicacionInt + 1
            Dim idDeUbicacionCad As String = idDeUbicacionInt.ToString()
            idUbicacionGenerado = "DE"
            For i As Int16 = 0 To 6 - 2 - Len(idDeUbicacionCad) Step 1
                idUbicacionGenerado = idUbicacionGenerado + "0"
            Next
            idUbicacionGenerado = idUbicacionGenerado + idDeUbicacionCad
            idRepetido = listaUbicaciones.Exists(Function(x) x.IDUbicacion.Equals(idUbicacionGenerado))
        End While
        Return idUbicacionGenerado
    End Function

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        btnExportar.Enabled = False
        txtIdMovimientoPadre.Text = String.Empty
        txtIdMovimientoPadre.Enabled = True
        txtIdMovimientoIntermedio.Text = String.Empty
        txtIdMovimientoIntermedio.Enabled = False
        listaUbicaciones = New List(Of OrigenDestino)
        datosMercancias = New Dictionary(Of String, List(Of Mercancia))
        LimpiaGrid(dgvMovimientos)
        LimpiaGrid(dgvMercanciasDeMovimiento)
        lblMercanciasMovimiento.Text = "No hay ningún movimiento seleccionado"
        btnBuscarMovimientoPadre.Enabled = True
        btnBuscarMovimientoIntermedio.Enabled = False
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim path As String = String.Empty
        Dim dr As DialogResult = DialogResult.Yes
        While String.IsNullOrEmpty(path) AndAlso dr = DialogResult.Yes
            path = ObtenPathParaGuardar("Archivos JSON (*.json)|*.json")
            If String.IsNullOrEmpty(path) Then
                dr = MsgBox(ObtenParametroPorLlave("ARCHGUARD_NOSELEC"), vbQuestion + vbYesNo, "Alerta")
            End If
        End While
        If Not String.IsNullOrEmpty(path) Then
            utils.EscribeArchivoJson(path, listaUbicaciones, datosMercancias)
        End If
    End Sub

    Private Function ObtenPathParaGuardar(ByRef filtrosCadena As String) As String
        Dim ofd As New SaveFileDialog()
        ofd.Filter = filtrosCadena
        ofd.FilterIndex = 0

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim fileName = ofd.FileName
            Return System.IO.Path.GetFullPath(fileName)
        End If
        Return String.Empty
    End Function
End Class