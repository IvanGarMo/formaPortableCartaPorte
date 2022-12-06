Imports System.Data.SqlClient

Public Class ConexionesCartaPorte
    Private mockConexion As SqlConnection
    Private tiposCartaPorte As TiposCartaPorte

    Public Sub New()
        tiposCartaPorte = New TiposCartaPorte
    End Sub

    Private Function obtenConexion() As SqlConnection
        Dim con = New SqlConnection("Server=dwh.eimportacion.com.mx,65069;Database=BD_IJGM;User Id=ijgm;Password=qw3ry22@;")
        con.Open()
        Return con
    End Function

    Public Function Get_DescripcionEscenario(ByVal incluyeEscenarioDefault As Boolean,
                                             ByRef empresa As String,
                                             Optional ByVal idEscenario As Int16 = -1) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("[sat].[SP_CCP_CargaEscenariosCartaPorte]", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitIncluyeDefault", incluyeEscenarioDefault)
        Cm.Parameters("@ParBitIncluyeDefault").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadEmpresa", empresa)
        Cm.Parameters("@ParCadEmpresa").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParIntIdEscenario", idEscenario)
        Cm.Parameters("@ParIntIdEscenario").Direction = ParameterDirection.Input


        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function


    Public Function Get_DatosTraslado(ByRef idEmpresa As String,
                                      ByRef tipoMovimiento As String,
                                      ByRef idMovimiento As String) As DataSet
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenDatosTraslado", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadEmpresa", idEmpresa)
        Cm.Parameters("@ParCadEmpresa").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadTipoMovimiento", tipoMovimiento)
        Cm.Parameters("@ParCadTipoMovimiento").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadIdMovimiento", idMovimiento)
        Cm.Parameters("@ParCadIdMovimiento").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet
    End Function

    Public Function GeneraXmlTraslado(ByVal rfcEmisor As String,
                                      ByRef nombreEmisor As String,
                                      ByRef domicilioFiscalEmisor As String,
                                      ByRef regimenFiscalEmisor As String,
                                      ByRef rfcReceptor As String,
                                      ByRef nombreReceptor As String,
                                      ByRef domicilioFiscalReceptor As String,
                                      ByRef regimenFiscalReceptor As String,
                                      ByRef listaMercancias As List(Of Mercancia))
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.FN_CCP_CreacionCFDITraslado_Tipos", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadRfcEmisor", rfcEmisor)
        Cm.Parameters("@ParCadRfcEmisor").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadNombreEmisor", nombreEmisor)
        Cm.Parameters("@ParCadNombreEmisor").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadDomicilioFiscalEmisor", domicilioFiscalEmisor)
        Cm.Parameters("@ParCadDomicilioFiscalEmisor").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadRegimenFiscalEmisor", regimenFiscalEmisor)
        Cm.Parameters("@ParCadRegimenFiscalEmisor").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadRfcReceptor", rfcReceptor)
        Cm.Parameters("@ParCadRfcReceptor").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadNombreReceptor", nombreReceptor)
        Cm.Parameters("@ParCadNombreReceptor").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadDomicilioFiscalReceptor", domicilioFiscalReceptor)
        Cm.Parameters("@ParCadDomicilioFiscalReceptor").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadRegimenFiscalReceptor", regimenFiscalReceptor)
        Cm.Parameters("@ParCadRegimenFiscalReceptor").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParBitCartaPorte", True)
        Cm.Parameters("@ParBitCartaPorte").Direction = ParameterDirection.Input

        Dim datosMercancias As DataTable = tiposCartaPorte.CantidadMercanciaTipo()
        For Each mercancia In listaMercancias
            tiposCartaPorte.AnadeMercanciaEnTabla(datosMercancias, mercancia)
        Next

        Cm.Parameters.AddWithValue("@ParTabMercancia", datosMercancias)
        Cm.Parameters("@ParTabMercancia").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadResultado", SqlDbType.Text, Int32.MaxValue)
        Cm.Parameters("@ParCadResultado").Direction = ParameterDirection.ReturnValue

        Cm.ExecuteScalar()
        Return Cm.Parameters("@ParCadResultado").Value
    End Function

    Public Function GeneraXmlCartaPorte(ByVal tipoCfdi As String,
                                        ByVal transporteInternacional As Boolean,
                                        ByVal entradaSalida As String,
                                        ByVal paisOrigenDestino As String,
                                        ByVal viaEntradaSalida As String,
                                        ByVal totalDistRecorrida As Decimal,
                                        ByRef listadoUbicaciones As List(Of OrigenDestino),
                                        ByVal pesoBrutoTotal As Decimal,
                                        ByVal unidadPesoTotal As String,
                                        ByRef listaMercancias As List(Of Mercancia),
                                        ByRef datosAutoTransporte As Autotransporte,
                                        ByRef datosOperador As DatosTransportista
                                        ) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.FN_CCP_CreacionComplementoCartaPorte", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadTipoCfdi", tipoCfdi)
        Cm.Parameters("@ParCadTipoCfdi").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParBitTransporteInternacional", transporteInternacional)
        Cm.Parameters("@ParBitTransporteInternacional").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadEntradaSalidaMercancias", entradaSalida)
        Cm.Parameters("@ParCadEntradaSalidaMercancias").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPaisOrigenDestino", paisOrigenDestino)
        Cm.Parameters("@ParCadPaisOrigenDestino").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadViaEntradaSalida", viaEntradaSalida)
        Cm.Parameters("@ParCadViaEntradaSalida").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParNumTotalDistRec", totalDistRecorrida)
        Cm.Parameters("@ParNumTotalDistRec").Direction = ParameterDirection.Input

        Dim datosUbicaciones As DataTable = tiposCartaPorte.UbicacionTipo()
        Dim datosDomiciliosUbicaciones As DataTable = tiposCartaPorte.DomicilioTipo()
        For Each ubicacion In listadoUbicaciones
            tiposCartaPorte.AnadeUbicacionEnTabla(datosUbicaciones, ubicacion)
            tiposCartaPorte.AnadeDomicilioEnTabla(datosDomiciliosUbicaciones, ubicacion.DatosDomicilio,
                                                    ubicacion.EsExtranjero, ubicacion.IDUbicacion)
        Next

        Cm.Parameters.AddWithValue("@ParTabUbicaciones", datosUbicaciones)
        Cm.Parameters("@ParTabUbicaciones").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParTabDomicilio", datosDomiciliosUbicaciones)
        Cm.Parameters("@ParTabDomicilio").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParNumPesoBrutoTotal", pesoBrutoTotal)
        Cm.Parameters("@ParNumPesoBrutoTotal").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadUnidadPeso", unidadPesoTotal)
        Cm.Parameters("@ParCadUnidadPeso").Direction = ParameterDirection.Input

        Dim datosMercancias As DataTable = tiposCartaPorte.CantidadMercanciaTipo()
        Dim destinosMercancias As DataTable = tiposCartaPorte.CantidadTransportaTipo()
        For Each mercancia In listaMercancias
            tiposCartaPorte.AnadeMercanciaEnTabla(datosMercancias, mercancia)
            For Each rel In mercancia.RelacionMercanciaDestino
                tiposCartaPorte.AnadeCantidadTransportaEnTabla(destinosMercancias, rel)
            Next
        Next

        Cm.Parameters.AddWithValue("@ParTabMercancia", datosMercancias)
        Cm.Parameters("@ParTabMercancia").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParTabMercanciaConDestinos", destinosMercancias)
        Cm.Parameters("@ParTabMercanciaConDestinos").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPermSCT", datosAutoTransporte.PermSCT)
        Cm.Parameters("@ParCadPermSCT").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadNumPermisoSCT", datosAutoTransporte.NumPermisoSCT)
        Cm.Parameters("@ParCadNumPermisoSCT").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadConfigVehicular", datosAutoTransporte.ConfigVehicular)
        Cm.Parameters("@ParCadConfigVehicular").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPlacaVM", datosAutoTransporte.PlacaVM)
        Cm.Parameters("@ParCadPlacaVM").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadAnioModeloVM", datosAutoTransporte.AnioModeloVM)
        Cm.Parameters("@ParCadAnioModeloVM").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadAseguraRespCivil", datosAutoTransporte.AseguraRespCivil)
        Cm.Parameters("@ParCadAseguraRespCivil").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPolizRespCivil", datosAutoTransporte.PolizaRespCivil)
        Cm.Parameters("@ParCadPolizRespCivil").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadAseguraMedioAmbiente", datosAutoTransporte.AseguraMedAmbiente)
        Cm.Parameters("@ParCadAseguraMedioAmbiente").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPolizaMedAmbiente", datosAutoTransporte.PolizaMedAmbiente)
        Cm.Parameters("@ParCadPolizaMedAmbiente").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadAseguraCarga", datosAutoTransporte.AseguraCarga)
        Cm.Parameters("@ParCadAseguraCarga").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPolizaCarga", datosAutoTransporte.PolizaCarga)
        Cm.Parameters("@ParCadPolizaCarga").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParNumPrimaSeguro", datosAutoTransporte.PrimaSeguro)
        Cm.Parameters("@ParNumPrimaSeguro").Direction = ParameterDirection.Input

        Dim datosRemolques As DataTable = tiposCartaPorte.RemolquesTipo()
        For Each remolque In datosAutoTransporte.Remolques
            tiposCartaPorte.AnadeRemolqueEntabla(datosRemolques, remolque)
        Next

        Cm.Parameters.AddWithValue("@ParTabRemolques", datosRemolques)
        Cm.Parameters("@ParTabRemolques").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadTipoFigura", datosOperador.TipoFigura)
        Cm.Parameters("@ParCadTipoFigura").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadRfcFiguraTransporte", datosOperador.RFCFigura)
        Cm.Parameters("@ParCadRfcFiguraTransporte").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadNumLicencia", datosOperador.NumLicencia)
        Cm.Parameters("@ParCadNumLicencia").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadNombreFiguraTransporte", datosOperador.NombreCompleto)
        Cm.Parameters("@ParCadNombreFiguraTransporte").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParBitEsTransportistaExtranjero", datosOperador.EsTransportistaExtranjero)
        Cm.Parameters("@ParBitEsTransportistaExtranjero").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadNumRegIdTribTransportista", datosOperador.NumRegIdTribFigura)
        Cm.Parameters("@ParCadNumRegIdTribTransportista").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadResidenciaFiscalFigura", datosOperador.ResidenciaFiscalFigura)
        Cm.Parameters("@ParCadResidenciaFiscalFigura").Direction = ParameterDirection.Input

        Dim datosPartesTransporte As DataTable = tiposCartaPorte.RemolquesTipo()

        Cm.Parameters.AddWithValue("@ParTabPartesTransporte", datosPartesTransporte)
        Cm.Parameters("@ParTabPartesTransporte").Direction = ParameterDirection.Input

        Dim domicilio As DataTable = tiposCartaPorte.DomicilioTipo()
        tiposCartaPorte.AnadeDomicilioEnTabla(domicilio, datosOperador.Domicilio, datosOperador.EsTransportistaExtranjero)

        Cm.Parameters.AddWithValue("@ParTabDomicilioOperador", domicilio)
        Cm.Parameters("@ParTabDomicilioOperador").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadResultado", SqlDbType.Text, Int32.MaxValue)
        Cm.Parameters("@ParCadResultado").Direction = ParameterDirection.ReturnValue

        Cm.ExecuteScalar()
        Return Cm.Parameters("@ParCadResultado").Value
    End Function

    Public Function Get_InformacionEscenarioCartaPorte(ByVal idEmpresa As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_CreaParametrosEscenarios", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadIdEmpresa", idEmpresa)
        Cm.Parameters("@ParCadIdEmpresa").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function
    Public Function RegistraDatosCreacionCartaPorte(ByVal idEmpresa As String,
                                                    ByVal tipoMovimiento As String,
                                                    ByVal idMovimiento As String,
                                                    ByVal tipoCfdi As String,
                                                    ByVal transpInter As Boolean,
                                                    ByVal entradaSalida As String,
                                                    ByVal viaEntradaSalida As String,
                                                    ByVal totalDistanciaRecorrida As String,
                                                    ByRef datosOrigen As String,
                                                    ByRef destinosIntermedios As String,
                                                    ByRef destinoFinal As String,
                                                    ByRef datosMercancia As String,
                                                    ByRef datosTransporte As String,
                                                    ByRef datosOperador As String,
                                                    ByRef pesoBrutoTotal As String,
                                                    ByRef unidadPesoTotal As String,
                                                    ByVal numTotal As String) As Boolean
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CPP_RegistraMovimientoCartaPorte", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadIdEmpresa", idEmpresa)
        Cm.Parameters("@ParCadIdEmpresa").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadTipoMovimiento", tipoMovimiento)
        Cm.Parameters("@ParCadTipoMovimiento").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadIdMovimiento", idMovimiento)
        Cm.Parameters("@ParCadIdMovimiento").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadTipoCfdi", tipoCfdi)
        Cm.Parameters("@ParCadTipoCfdi").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParBitTranspInter", transpInter)
        Cm.Parameters("@ParBitTranspInter").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadEntradaSalida", entradaSalida)
        Cm.Parameters("@ParCadEntradaSalida").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadViaEntradaSalida", viaEntradaSalida)
        Cm.Parameters("@ParCadViaEntradaSalida").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadTotalDistRecorrida", totalDistanciaRecorrida)
        Cm.Parameters("@ParCadTotalDistRecorrida").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadDatosOrigen", datosOrigen)
        Cm.Parameters("@ParCadDatosOrigen").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadDestinosIntermedios", destinosIntermedios)
        Cm.Parameters("@ParCadDestinosIntermedios").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadDatosDestinoFinal", destinoFinal)
        Cm.Parameters("@ParCadDatosDestinoFinal").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadDatosMercancia", datosMercancia)
        Cm.Parameters("@ParCadDatosMercancia").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadDatosTransporte", datosTransporte)
        Cm.Parameters("@ParCadDatosTransporte").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadDatosOperador", datosOperador)
        Cm.Parameters("@ParCadDatosOperador").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadDatosRelacionMercancia", "")
        Cm.Parameters("@ParCadDatosRelacionMercancia").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPesoBrutoTotal", pesoBrutoTotal)
        Cm.Parameters("@ParCadPesoBrutoTotal").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadUnidadPesoTotal", unidadPesoTotal)
        Cm.Parameters("@ParCadUnidadPesoTotal").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadNumTotal", numTotal)
        Cm.Parameters("@ParCadNumTotal").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParBitError", SqlDbType.Bit, 1)
        Cm.Parameters("@ParBitError").Direction = ParameterDirection.Output

        Cm.ExecuteNonQuery()

        Return CType(Cm.Parameters("@ParBitError").Value, Boolean)
    End Function
    Public Function Get_ObtenParametros() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenParametros", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenCatalogoVehiculos(ByVal idEmpresa As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_CargaOpcionesVehiculos", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadIdEmpresa", idEmpresa)
        Cm.Parameters("@ParCadIdEmpresa").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenDetalleVehiculo(ByRef idEmpresa As String,
                                             ByRef idVehiculo As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CPP_CargaDatosVehiculos", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadIdEmpresa", idEmpresa)
        Cm.Parameters("@ParCadIdEmpresa").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadIdVehiculo", idVehiculo)
        Cm.Parameters("@ParCadIdVehiculo").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenCatalogoChoferes(ByVal idEmpresa As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenListaEmpleados", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadIdEmpresa", idEmpresa)
        Cm.Parameters("@ParCadIdEmpresa").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenDetalleChofer(ByRef idEmpresa As String,
                                           ByRef idChofer As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_CargaDetalleChofer", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadIdEmpresa", idEmpresa)
        Cm.Parameters("@ParCadIdEmpresa").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadIdChofer", idChofer)
        Cm.Parameters("@ParCadIdChofer").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenPaises(ByVal opcionPorDefecto As Boolean,
                                    Optional ByVal cadPais As String = "") As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenPaises", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPais", cadPais)
        Cm.Parameters("@ParCadPais").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenDescripcionPais(ByVal cadPais As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenDescripcionPais", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClavePais", cadPais)
        Cm.Parameters("@ParCadClavePais").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionPais", SqlDbType.VarChar, 200)
        Cm.Parameters("@ParCadDescripcionPais").Direction = ParameterDirection.Output

        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionPais").Value
    End Function

    Public Function Get_ObtenEstados(ByVal opcionPorDefecto As Boolean, ByVal cadPais As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenEstadosPais", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPais", cadPais)
        Cm.Parameters("@ParCadPais").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenMunicipiosPorEstado(ByVal opcionPorDefecto As Boolean,
                                                            ByVal cadEstado As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenMunicipiosEstado", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadEstado", cadEstado)
        Cm.Parameters("@ParCadEstado").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenLocalidadesPorEstado(ByVal opcionPorDefecto As Boolean,
                                                           ByVal cadEstado As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenLocalidadesEstado", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadEstado", cadEstado)
        Cm.Parameters("@ParCadEstado").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenColoniasPorCodigoPostal(ByVal opcionPorDefecto As Boolean,
                                                           ByVal codigoPostal As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenColoniasCodigoPostal", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadCodigoPostal", codigoPostal)
        Cm.Parameters("@ParCadCodigoPostal").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ValidaCodigoPostal(ByVal codigoPostal As String,
                                           ByVal estado As String,
                                           ByVal municipio As String,
                                           ByVal localidad As String,
                                           ByRef mensaje As String) As Boolean
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ValidaCodigoPostal", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadCodigoPostal", codigoPostal)
        Cm.Parameters("@ParCadCodigoPostal").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadCodigoEstado", estado)
        Cm.Parameters("@ParCadCodigoEstado").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadMunicipio", municipio)
        Cm.Parameters("@ParCadMunicipio").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadLocalidad", localidad)
        Cm.Parameters("@ParCadLocalidad").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParBitValido", SqlDbType.Bit, 1)
        Cm.Parameters("@ParBitValido").Direction = ParameterDirection.Output

        Cm.Parameters.Add("@ParCadMensaje", SqlDbType.VarChar, 1000)
        Cm.Parameters("@ParCadMensaje").Direction = ParameterDirection.Output

        Cm.ExecuteNonQuery()

        mensaje = Cm.Parameters("@ParCadMensaje").Value
        Return CType(Cm.Parameters("@ParBitValido").Value, Boolean)
    End Function

    Public Sub Get_ObtenDescripcionPorClaveProdServ(ByRef claveProdServ As String,
                                                    ByRef descripcionProd As String,
                                                    ByRef requiereNodoPeligroso As Boolean,
                                                    ByRef satMarcadaPeligrosa As Boolean)
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_CargaDescripcionProducto", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveProdServ", claveProdServ)
        Cm.Parameters("@ParCadClaveProdServ").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionProdServ", SqlDbType.VarChar, 1000)
        Cm.Parameters("@ParCadDescripcionProdServ").Direction = ParameterDirection.Output

        Cm.Parameters.Add("@ParBitRequiereNodoMercanciaPeligrosa", SqlDbType.Bit, 1)
        Cm.Parameters("@ParBitRequiereNodoMercanciaPeligrosa").Direction = ParameterDirection.Output

        Cm.Parameters.Add("@ParBitSatConsideraPeligrosa", SqlDbType.Bit, 1)
        Cm.Parameters("@ParBitSatConsideraPeligrosa").Direction = ParameterDirection.Output

        Cm.ExecuteNonQuery()

        descripcionProd = Cm.Parameters("@ParCadDescripcionProdServ").Value
        requiereNodoPeligroso = CType(Cm.Parameters("@ParBitRequiereNodoMercanciaPeligrosa").Value, Boolean)
        satMarcadaPeligrosa = CType(Cm.Parameters("@ParBitSatConsideraPeligrosa").Value, Boolean)
    End Sub

    Public Function Get_ClaveUnidadPeso(ByRef clave As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ClaveUnidadPeso", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveUnidad", clave)
        Cm.Parameters("@ParCadClaveUnidad").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionClaveUnidad", SqlDbType.VarChar, 1000)
        Cm.Parameters("@ParCadDescripcionClaveUnidad").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionClaveUnidad").Value
    End Function

    Public Function Get_DescripcionMoneda(ByRef clave As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenDescripcionMoneda", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveMoneda", clave)
        Cm.Parameters("@ParCadClaveMoneda").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionMoneda", SqlDbType.VarChar, 1000)
        Cm.Parameters("@ParCadDescripcionMoneda").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionMoneda").Value
    End Function

    Public Function Get_ObtenDescripcionMaterialPeligroso(ByVal claveMatPeligroso As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenDescripcionMaterialPeligroso", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveMaterialPeligroso", claveMatPeligroso)
        Cm.Parameters("@ParCadClaveMaterialPeligroso").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionMaterialPeligroso", SqlDbType.VarChar, 200)
        Cm.Parameters("@ParCadDescripcionMaterialPeligroso").Direction = ParameterDirection.Output

        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionMaterialPeligroso").Value
    End Function

    Public Function Get_ObtenDescripcionEmbalaje(ByVal claveEmbalaje As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenDescripcionEmbalaje", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveEmbalaje", claveEmbalaje)
        Cm.Parameters("@ParCadClaveEmbalaje").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionEmbalaje", SqlDbType.VarChar, 200)
        Cm.Parameters("@ParCadDescripcionEmbalaje").Direction = ParameterDirection.Output

        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionEmbalaje").Value
    End Function

    Public Function Get_ObtenPosiblesDimensiones() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenOpcionesDimensiones", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenPosiblesTiposRemolque() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_TiposRemolque", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenDescripcionPorTipoSubRemolque(ByRef claveTransporte As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_CargaDescripcionTipoTransporte", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveTransporte", claveTransporte)
        Cm.Parameters("@ParCadClaveTransporte").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionTransporte", SqlDbType.VarChar, 1000)
        Cm.Parameters("@ParCadDescripcionTransporte").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionTransporte").Value
    End Function

    Public Function Get_OpcionesPropiedadTransporte() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_CargaPropiedadTransporte", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_OpcionesTipoPermiso() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenTiposPermiso", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_OpcionesConfiguracionVehicular() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CPP_CargaConfiguracionAutoTransporte", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenDescripcionConfiguracionAutoTransporte(ByRef claveConf As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CPP_CargaDescripcionConfigAutoTransporte", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClave", claveConf)
        Cm.Parameters("@ParCadClave").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcion", SqlDbType.VarChar, 2000)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcion").Value
    End Function

    Public Function Get_ObtenDescripcionTipoPermiso(ByRef claveTipoPermiso As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CPP_ObtenDetallesTipoPermiso", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClave", claveTipoPermiso)
        Cm.Parameters("@ParCadClave").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcion", SqlDbType.VarChar, 2000)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcion").Value
    End Function

    Public Function Get_ObtenFigurasDeTransporte(ByVal propiedadAjena As Boolean) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenTiposFiguraTransporte", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitPropiedadAjena", propiedadAjena)
        Cm.Parameters("@ParBitPropiedadAjena").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_CatalogoOperadores()
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenOperador", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_DetalleClaveProdServ(ByRef claveProdServ As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_BuscaDetalleClaveProdServ", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadDescripcion", claveProdServ)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_DetalleClaveUnidad(ByRef claveUnidad As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_BuscaDetalleClaveUnidad", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadDescripcion", claveUnidad)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_DetalleMoneda(ByRef moneda As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_BuscaDetalleMoneda", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadDescripcion", moneda)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_DetalleMaterialPeligroso(ByRef claveMatPeligroso As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_BuscaDetalleMaterialPeligroso", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadDescripcion", claveMatPeligroso)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_DetalleEmbalaje(ByRef claveEmbalaje As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_BuscaDetalleMaterialEmbalaje", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadDescripcion", claveEmbalaje)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_DetalleConfigVehicular(ByRef configVehicular As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_BuscaDetalleConfigVehicular", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadDescripcion", configVehicular)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_DetalleTipoPermiso(ByRef claveTipoPermiso As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_BuscaDetalleTipoPermiso", obtenConexion())
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadDescripcion", claveTipoPermiso)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter(Cm)
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function
End Class
