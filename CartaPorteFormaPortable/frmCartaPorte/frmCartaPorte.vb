Imports System.Text.RegularExpressions

Public Class frmCartaPorte
    Private parametrosFormaCartaPorte As DataTable
    Private conexionesCartaPorte As ConexionesCartaPorte

    'Datos de la carta porte 
    Private datosOrigenParaCartaPorte As OrigenDestino
    Private datosDestinoParaCartaPorte As OrigenDestino
    Private datosDestinosIntermediosParaCartaPorte As List(Of OrigenDestino)
    Private datosMercancias As Dictionary(Of String, List(Of Mercancia))
    Private datosAutoTransporte As Autotransporte

    'Este para evitar que el usuario se mueva en la pestaña
    Private ESTOY_CAMBIANDO_MEDIANTE_INDICE = False

    'Esto es para los escenarios
    Private numeroEscenario As Int32 = 0
    Private idEmpresa As String = String.Empty
    Private descripcionEscenario As DataTable = Nothing

    'Esto es para atrapar el evento de búsqueda de forma
    Private esperandoBusqueda As TextBox = Nothing

    'Esto es para los colores obligatorio y de fondo
    Private colorCampoObligatorio As String = String.Empty
    Private colorCampoOpcional As String = String.Empty
    Private colorUsuarioCausoProblemas As String = String.Empty

#Region "Eventos de carga de la forma"

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''MÉTODOS COMUNES
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Public Sub New(ByVal idEmpresa As String, ByVal idEscenario As Int32)
        ' This call is required by the designer.
        InitializeComponent()
        Me.numeroEscenario = idEscenario
        Me.idEmpresa = idEmpresa
    End Sub

    Private Sub PreparaPruebasCartaPorte()

        'Preparo los datos de origen
        datosOrigenParaCartaPorte = New OrigenDestino
        datosOrigenParaCartaPorte.TipoUbicacion = "Origen"
        datosOrigenParaCartaPorte.IDUbicacion = "OR000001"
        datosOrigenParaCartaPorte.EsDestinoIntermedio = False
        datosOrigenParaCartaPorte.EsPersonaFisica = False
        datosOrigenParaCartaPorte.EsPersonaMoral = True
        datosOrigenParaCartaPorte.EsExtranjero = False
        datosOrigenParaCartaPorte.Nombre = String.Empty
        datosOrigenParaCartaPorte.ApPaterno = String.Empty
        datosOrigenParaCartaPorte.ApMaterno = String.Empty
        datosOrigenParaCartaPorte.NombrePersonaMoral = "EAGLE IMPORTACIONES"
        datosOrigenParaCartaPorte.NumRegIdTrib = String.Empty
        datosOrigenParaCartaPorte.ResidenciaFiscal = String.Empty

        datosOrigenParaCartaPorte.RFCRemitenteDestinatario = "EIM951002R19"
        datosOrigenParaCartaPorte.NumRegIdTrib = String.Empty
        datosOrigenParaCartaPorte.FechaSalidaLlegada = DateTime.Today.Date
        datosOrigenParaCartaPorte.HoraSalidaLlegada = "20:00"
        datosOrigenParaCartaPorte.DistanciaRecorrida = 0

        Dim domicilio As New Domicilio
        domicilio.Calle = "LAZARO CARDENAS"
        domicilio.NumeroExterior = "170"
        domicilio.NumeroInterior = String.Empty
        domicilio.Colonia = "2034"
        domicilio.Municipio = "007"
        domicilio.Localidad = "02"
        domicilio.Estado = "DUR"
        domicilio.Pais = "MEX"
        domicilio.Referencia = String.Empty
        domicilio.CodigoPostal = "35077"
        datosOrigenParaCartaPorte.DatosDomicilio = domicilio

        'Ahora preparo los datos de destino
        datosDestinoParaCartaPorte = New OrigenDestino
        datosDestinoParaCartaPorte.UsuarioCausoProblemasConFecha = False
        datosDestinoParaCartaPorte.TipoUbicacion = "Destino"
        datosDestinoParaCartaPorte.IDUbicacion = "DE000001"
        datosDestinoParaCartaPorte.RFCRemitenteDestinatario = "EIM951002R19"
        datosDestinoParaCartaPorte.NombrePersonaMoral = "EAGLE IMPORTACIONES"
        datosDestinoParaCartaPorte.Nombre = String.Empty
        datosDestinoParaCartaPorte.ApPaterno = String.Empty
        datosDestinoParaCartaPorte.ApMaterno = String.Empty
        datosDestinoParaCartaPorte.ResidenciaFiscal = String.Empty
        datosDestinoParaCartaPorte.NumRegIdTrib = String.Empty
        datosDestinoParaCartaPorte.FechaSalidaLlegada = DateTime.Today.AddDays(1).Date
        datosDestinoParaCartaPorte.HoraSalidaLlegada = "20:00"
        datosDestinoParaCartaPorte.DistanciaRecorrida = 2000
        datosDestinoParaCartaPorte.EsPersonaFisica = False
        datosDestinoParaCartaPorte.EsPersonaMoral = True
        datosDestinoParaCartaPorte.EsExtranjero = False

        Dim domicilioDestino As New Domicilio
        domicilioDestino.Calle = "CARRETERA INTERNACIONAL KM 1.5"
        domicilioDestino.NumeroExterior = "313"
        domicilioDestino.NumeroInterior = String.Empty
        domicilioDestino.Colonia = "1079"
        domicilioDestino.Localidad = "05"
        domicilioDestino.Municipio = "012"
        domicilioDestino.Estado = "SIN"
        domicilioDestino.Pais = "MEX"
        domicilioDestino.Referencia = String.Empty
        domicilioDestino.CodigoPostal = "82129"
        datosDestinoParaCartaPorte.DatosDomicilio = domicilioDestino

        'Creo la de destinos intermedios para evitar broncas
        datosDestinosIntermediosParaCartaPorte = New List(Of OrigenDestino)

        'Ahora creo los destinos intermedios
        Dim datosDestinoIntermedio1ParaCartaPorte = New OrigenDestino
        datosDestinoIntermedio1ParaCartaPorte.UsuarioCausoProblemasConFecha = False
        datosDestinoIntermedio1ParaCartaPorte.TipoUbicacion = "Destino"
        datosDestinoIntermedio1ParaCartaPorte.IDUbicacion = "DE000011"
        datosDestinoIntermedio1ParaCartaPorte.RFCRemitenteDestinatario = "EIM951002R19"
        datosDestinoIntermedio1ParaCartaPorte.NombrePersonaMoral = "EAGLE IMPORTACIONES"
        datosDestinoIntermedio1ParaCartaPorte.Nombre = String.Empty
        datosDestinoIntermedio1ParaCartaPorte.ApPaterno = String.Empty
        datosDestinoIntermedio1ParaCartaPorte.ApMaterno = String.Empty
        datosDestinoIntermedio1ParaCartaPorte.ResidenciaFiscal = String.Empty
        datosDestinoIntermedio1ParaCartaPorte.NumRegIdTrib = String.Empty
        datosDestinoIntermedio1ParaCartaPorte.FechaSalidaLlegada = DateTime.Today.AddDays(1).Date
        datosDestinoIntermedio1ParaCartaPorte.HoraSalidaLlegada = "14:00"
        datosDestinoIntermedio1ParaCartaPorte.DistanciaRecorrida = 1000
        datosDestinoIntermedio1ParaCartaPorte.EsPersonaFisica = False
        datosDestinoIntermedio1ParaCartaPorte.EsPersonaMoral = True
        datosDestinoIntermedio1ParaCartaPorte.EsExtranjero = False

        Dim domicilioIntermedio1Destino As New Domicilio
        domicilioIntermedio1Destino.Calle = "HOTEL PARADOR"
        domicilioIntermedio1Destino.NumeroExterior = "300"
        domicilioIntermedio1Destino.NumeroInterior = String.Empty
        domicilioIntermedio1Destino.Colonia = "0001"
        domicilioIntermedio1Destino.Localidad = "03"
        domicilioIntermedio1Destino.Municipio = "056"
        domicilioIntermedio1Destino.Estado = "ZAC"
        domicilioIntermedio1Destino.Pais = "MEX"
        domicilioIntermedio1Destino.Referencia = String.Empty
        domicilioIntermedio1Destino.CodigoPostal = "98000"
        datosDestinoIntermedio1ParaCartaPorte.DatosDomicilio = domicilioIntermedio1Destino
        datosDestinosIntermediosParaCartaPorte.Add(datosDestinoIntermedio1ParaCartaPorte)

        Dim datosDestinoIntermedio2ParaCartaPorte = New OrigenDestino
        datosDestinoIntermedio2ParaCartaPorte.UsuarioCausoProblemasConFecha = False
        datosDestinoIntermedio2ParaCartaPorte.TipoUbicacion = "Destino"
        datosDestinoIntermedio2ParaCartaPorte.IDUbicacion = "DE000012"
        datosDestinoIntermedio2ParaCartaPorte.RFCRemitenteDestinatario = "EIM951002R19"
        datosDestinoIntermedio2ParaCartaPorte.NombrePersonaMoral = "EAGLE IMPORTACIONES"
        datosDestinoIntermedio2ParaCartaPorte.Nombre = String.Empty
        datosDestinoIntermedio2ParaCartaPorte.ApPaterno = String.Empty
        datosDestinoIntermedio2ParaCartaPorte.ApMaterno = String.Empty
        datosDestinoIntermedio2ParaCartaPorte.ResidenciaFiscal = String.Empty
        datosDestinoIntermedio2ParaCartaPorte.NumRegIdTrib = String.Empty
        datosDestinoIntermedio2ParaCartaPorte.FechaSalidaLlegada = DateTime.Today.AddDays(1).Date
        datosDestinoIntermedio2ParaCartaPorte.HoraSalidaLlegada = "16:00"
        datosDestinoIntermedio2ParaCartaPorte.DistanciaRecorrida = 100
        datosDestinoIntermedio2ParaCartaPorte.EsPersonaFisica = False
        datosDestinoIntermedio2ParaCartaPorte.EsPersonaMoral = True
        datosDestinoIntermedio2ParaCartaPorte.EsExtranjero = False

        Dim domicilioIntermedio2Destino As New Domicilio
        domicilioIntermedio2Destino.Calle = "GUADALAJARA CENTRO"
        domicilioIntermedio2Destino.NumeroExterior = "400"
        domicilioIntermedio2Destino.NumeroInterior = String.Empty
        domicilioIntermedio2Destino.Colonia = "0002"
        domicilioIntermedio2Destino.Localidad = "03"
        domicilioIntermedio2Destino.Municipio = "039"
        domicilioIntermedio2Destino.Estado = "JAL"
        domicilioIntermedio2Destino.Pais = "MEX"
        domicilioIntermedio2Destino.Referencia = String.Empty
        domicilioIntermedio2Destino.CodigoPostal = "440009"
        datosDestinoIntermedio2ParaCartaPorte.DatosDomicilio = domicilioIntermedio2Destino
        datosDestinosIntermediosParaCartaPorte.Add(datosDestinoIntermedio2ParaCartaPorte)

        'Ahora creo la lista de mercancías y le añado una
        Dim listaMercSinaloa As List(Of Mercancia) = New List(Of Mercancia)
        Dim mercSinaloa As Mercancia = New Mercancia

        mercSinaloa.ClaveProdServ = "12181600"
        mercSinaloa.Descripcion = "Aceites"
        mercSinaloa.RequiereNodoMaterialPeligroso = True
        mercSinaloa.SatConsideraPeligrosa = False

        mercSinaloa.Cantidad = 20
        mercSinaloa.ClaveUnidad = "XBJ"
        mercSinaloa.Unidad = "CUBETA"
        mercSinaloa.EsCentimetros = True
        mercSinaloa.EsPulgadas = True
        mercSinaloa.Longitud = 0
        mercSinaloa.Anchura = 0
        mercSinaloa.Altura = 0

        mercSinaloa.MaterialPeligroso = False
        mercSinaloa.ClaveMaterialPeligroso = String.Empty
        mercSinaloa.Embalaje = String.Empty
        mercSinaloa.DescripcionEmbalaje = String.Empty

        mercSinaloa.PesoEnKg = 10D
        mercSinaloa.ValorMercancia = 0D
        mercSinaloa.Moneda = "MXN"

        mercSinaloa.EsComercioInternacional = False
        mercSinaloa.Pedimento = String.Empty
        mercSinaloa.FraccionArancelaria = String.Empty
        listaMercSinaloa.Add(mercSinaloa)

        'Mercancia para Zacatecas
        Dim listaMercZacatecas As List(Of Mercancia) = New List(Of Mercancia)
        Dim mercZacatecas As Mercancia = New Mercancia

        mercZacatecas.ClaveProdServ = "15121807"
        mercZacatecas.Descripcion = "Anticongelante"
        mercZacatecas.RequiereNodoMaterialPeligroso = False
        mercZacatecas.SatConsideraPeligrosa = False

        mercZacatecas.Cantidad = 10
        mercZacatecas.ClaveUnidad = "XBA"
        mercZacatecas.Unidad = "BARRIL"
        mercZacatecas.EsCentimetros = True
        mercZacatecas.EsPulgadas = False
        mercZacatecas.Longitud = 0
        mercZacatecas.Anchura = 0
        mercZacatecas.Altura = 0

        mercZacatecas.MaterialPeligroso = False
        mercZacatecas.ClaveMaterialPeligroso = String.Empty
        mercZacatecas.Embalaje = String.Empty
        mercZacatecas.DescripcionEmbalaje = String.Empty

        mercZacatecas.PesoEnKg = 10D
        mercZacatecas.ValorMercancia = 0D
        mercZacatecas.Moneda = "MXN"

        mercZacatecas.EsComercioInternacional = False
        mercZacatecas.Pedimento = String.Empty
        mercZacatecas.FraccionArancelaria = String.Empty
        listaMercZacatecas.Add(mercZacatecas)

        'Mercancia para Guadalajara
        Dim listaMercJalisco As List(Of Mercancia) = New List(Of Mercancia)
        Dim mercJalisco As Mercancia = New Mercancia

        mercJalisco.ClaveProdServ = "12181600"
        mercJalisco.Descripcion = "Aceites"
        mercJalisco.RequiereNodoMaterialPeligroso = True
        mercJalisco.SatConsideraPeligrosa = False

        mercJalisco.Cantidad = 5
        mercJalisco.ClaveUnidad = "XBJ"
        mercJalisco.Unidad = "CUBETA"
        mercJalisco.EsCentimetros = True
        mercJalisco.EsPulgadas = True
        mercJalisco.Longitud = 0
        mercJalisco.Anchura = 0
        mercJalisco.Altura = 0

        mercJalisco.MaterialPeligroso = True
        mercJalisco.ClaveMaterialPeligroso = "0454"
        mercJalisco.Embalaje = "1A2"
        mercJalisco.DescripcionEmbalaje = "BIDONES (TAMBORES)"

        mercJalisco.PesoEnKg = 10D
        mercJalisco.ValorMercancia = 0D
        mercJalisco.Moneda = "MXN"

        mercJalisco.EsComercioInternacional = False
        mercJalisco.Pedimento = String.Empty
        mercJalisco.FraccionArancelaria = String.Empty

        Dim mercJalisco2 As Mercancia = New Mercancia
        mercJalisco2.ClaveProdServ = "12181600"
        mercJalisco2.Descripcion = "Aceites"
        mercJalisco2.RequiereNodoMaterialPeligroso = True
        mercJalisco2.SatConsideraPeligrosa = False
        mercJalisco2.Cantidad = 5
        mercJalisco2.ClaveUnidad = "XBA"
        mercJalisco2.Unidad = "BARRIL"
        mercJalisco2.EsCentimetros = True
        mercJalisco2.EsPulgadas = True
        mercJalisco2.Longitud = 0
        mercJalisco2.Anchura = 0
        mercJalisco2.Altura = 0
        mercJalisco2.MaterialPeligroso = True
        mercJalisco2.ClaveMaterialPeligroso = "0454"
        mercJalisco2.Embalaje = "1A2"
        mercJalisco2.DescripcionEmbalaje = "BIDONES (TAMBORES)"
        mercJalisco2.PesoEnKg = 10D
        mercJalisco2.ValorMercancia = 0D
        mercJalisco2.Moneda = "MXN"
        mercJalisco2.EsComercioInternacional = False
        mercJalisco2.Pedimento = String.Empty
        mercJalisco2.FraccionArancelaria = String.Empty
        Dim mercJalisco3 As Mercancia = New Mercancia
        mercJalisco3.ClaveProdServ = "12181600"
        mercJalisco3.Descripcion = "Aceites"
        mercJalisco3.RequiereNodoMaterialPeligroso = True
        mercJalisco3.SatConsideraPeligrosa = False
        mercJalisco3.Cantidad = 5
        mercJalisco3.ClaveUnidad = "XBA"
        mercJalisco3.Unidad = "BARRIL"
        mercJalisco3.EsCentimetros = True
        mercJalisco3.EsPulgadas = True
        mercJalisco3.Longitud = 0
        mercJalisco3.Anchura = 0
        mercJalisco3.Altura = 0
        mercJalisco3.MaterialPeligroso = False
        mercJalisco3.ClaveMaterialPeligroso = String.Empty
        mercJalisco3.Embalaje = String.Empty
        mercJalisco3.DescripcionEmbalaje = String.Empty
        mercJalisco3.PesoEnKg = 10D
        mercJalisco3.ValorMercancia = 0D
        mercJalisco3.Moneda = "MXN"
        mercJalisco3.EsComercioInternacional = False
        mercJalisco3.Pedimento = String.Empty
        mercJalisco3.FraccionArancelaria = String.Empty

        listaMercJalisco.Add(mercJalisco)
        listaMercJalisco.Add(mercJalisco2)
        listaMercJalisco.Add(mercJalisco3)

        'Ahora añado la lista de mercancias al diccionario
        datosMercancias = New Dictionary(Of String, List(Of Mercancia))
        datosMercancias.Add("DE000001", listaMercSinaloa)
        datosMercancias.Add("DE000011", listaMercZacatecas)
        datosMercancias.Add("DE000012", listaMercJalisco)
    End Sub


    'Pongo las referencias aquí para evitar cualquier problema
    'de referencias nulas
    Private Sub frmCartaPorte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refCbEstadoOrigen = cbEstadoRemitente
        refCbMunicipioOrigen = cbMunicipioRemitente
        refCbLocalidadOrigen = cbLocalidadRemitente
        refCbColoniaOrigen = cbColoniaOrigen

        refCbEstadoOrigen.DropDownStyle = ComboBoxStyle.DropDownList
        refCbMunicipioOrigen.DropDownStyle = ComboBoxStyle.DropDownList
        refCbLocalidadOrigen.DropDownStyle = ComboBoxStyle.DropDownList
        refCbColoniaOrigen.DropDownStyle = ComboBoxStyle.DropDownList

        refCbColoniaDestino = cbColoniaDestino
        refCbMunicipioDestino = cbMunicipioDestino
        refCbLocalidadDestino = cbLocalidadDestino
        refCbEstadoDestino = cbEstadoDestino

        refCbColoniaDestino.DropDownStyle = ComboBoxStyle.DropDownList
        refCbMunicipioDestino.DropDownStyle = ComboBoxStyle.DropDownList
        refCbLocalidadDestino.DropDownStyle = ComboBoxStyle.DropDownList
        refCbEstadoDestino.DropDownStyle = ComboBoxStyle.DropDownList

        refCbEstadoDestinoIntermedio = cbEstadoDestinoIntermedio
        refCbMunicipioDestinoIntermedio = cbMunicipioDestinoIntermedio
        refCbLocalidadDestinoIntermedio = cbLocalidadDestinoIntermedio
        refCbColoniaDestinoIntermedio = cbColoniaDestinoIntermedio

        refCbEstadoDestinoIntermedio.DropDownStyle = ComboBoxStyle.DropDownList
        refCbMunicipioDestinoIntermedio.DropDownStyle = ComboBoxStyle.DropDownList
        refCbLocalidadDestinoIntermedio.DropDownStyle = ComboBoxStyle.DropDownList
        refCbColoniaDestinoIntermedio.DropDownStyle = ComboBoxStyle.DropDownList

        refCbEstadoOperador = cbEstadoOperador
        refCbMunicipioOperador = cbMunicipioOperador
        refCbLocalidadOperador = cbLocalidadOperador
        refCbColoniaOperador = cbColoniaOperador

        refCbEstadoOperador.DropDownStyle = ComboBoxStyle.DropDownList
        refCbMunicipioOperador.DropDownStyle = ComboBoxStyle.DropDownList
        refCbLocalidadOperador.DropDownStyle = ComboBoxStyle.DropDownList
        refCbColoniaOperador.DropDownStyle = ComboBoxStyle.DropDownList

        conexionesCartaPorte = New ConexionesCartaPorte()
        CargaParametros()
        PreparaPestanaOrigen()

        'Para probar, me muevo a la pestaña de confirmacion
        PreparaPruebasCartaPorte()
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
        TabControl1.SelectedTab = TabControl1.TabPages("tabConfirmacion")
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
    End Sub
#End Region

#Region "Metodos Comunes usados por todas las pestañas"

    'Este método recibe un objeto Date y una cadena de horas, y entrega
    'a cambio un datetime correcto
    Private Function ObtenDateTime(ByRef fecha As DateTime, ByRef hora As String) As DateTime
        Dim horas As Int32 = CInt(hora.Split(":")(0))
        Dim minutos As Int32 = CInt(hora.Split(":")(1))
        Dim fechaCorrecta As DateTime = New DateTime(fecha.Year, fecha.Month, fecha.Day, horas, minutos, 0)
        Return fechaCorrecta
    End Function

    'Estos dos métodos son para colorear o quitar colores de fondo, y que sepan que
    'fregaos están haciendo
    Private Sub textbox_Enter(sender As Object, e As EventArgs) Handles txtRfcRemitente.Enter, txtReferenciaRemitente.Enter, txtPaisResidenciaFiscalRemitente.Enter, txtNumRegidTribRemitente.Enter, txtNombreRemitente.Enter, txtNoIntRemitente.Enter, txtNoExtRemitente.Enter, txtIdUbicacionOrigen.Enter, txtHoraSalidaRemitente.Enter, txtCpRemitente.Enter, txtCalleRemitente.Enter, txtApPaternoRemitente.Enter, txtApMaternoRemitente.Enter, txtTipoUbicacion.Enter, txtTipoUbicacionDestino.Enter, txtRfcDestino.Enter, txtResidenciaFiscalDestino.Enter, txtReferenciaDestino.Enter, txtNumIdRegFiscalDestino.Enter, txtNombreDestino.Enter, txtNoIntDestino.Enter, txtNoExtDestino.Enter, txtIdUbicacionDestino.Enter, txtHoraSalidaDestino.Enter, txtCpDestino.Enter, txtCalleDestino.Enter, txtApPaternoDestino.Enter, txtApMaternoDestino.Enter, nupKmRecorridos.Enter, cbResidenciaFiscalDestino.Enter, txtTipoUbicacionDestinoIntermedio.Enter, txtRfcDestinoIntermedio.Enter, txtReferenciaDestinoIntermedio.Enter, txtNombreDestinoIntermedio.Enter, txtNoIntDestinoIntermedio.Enter, txtNoExtDestinoIntermedio.Enter, txtIdUbicacionDestinoIntermedio.Enter, txtHoraLlegadaDestinoIntermedio.Enter, txtCpDestinoIntermedio.Enter, txtCalleDestinoIntermedio.Enter, txtApPaternoDestinoIntermedio.Enter, txtApMaternoDestinoIntermedio.Enter, nupKmDestinoIntermedio.Enter, txtValor.Enter, txtUnidadMercancia.Enter, txtUnidadClaveMercancia.Enter, txtPeso.Enter, txtPedimento.Enter, txtMoneda.Enter, txtFraccionArancelaria.Enter, txtEmbalaje.Enter, txtDescripcionProducto.Enter, txtDescripcionMaterialPeligroso.Enter, txtDescripcionEmbalaje.Enter, txtClaveProdServMercancia.Enter, txtClaveMaterialPeligroso.Enter, txtCantidadMercancia.Enter, numLongitud.Enter, numAnchura.Enter, numAltura.Enter, txtUnidadPesoTotalMercancias.Enter, txtTipoRemolque2.Enter, txtTipoRemolque1.Enter, txtTipoPermisoSCT.Enter, txtRfcOperador.Enter, txtReferenciaOperador.Enter, txtPrimaSeguroTransporte.Enter, txtPolizaTransporte.Enter, txtPolizaSegurosDanosMedioAmbiente.Enter, txtPolizaCargaTransporte.Enter, txtPlacaTransporte.Enter, txtPlacasRemolque2.Enter, txtPlacasRemolque1.Enter, txtPesoBrutoTotalMercancias.Enter, txtNumRegIdTribFiscOperador.Enter, txtNumPermisoSCT.Enter, txtNumLicenciaOperador.Enter, txtNombreOperador.Enter, txtNoIntOperador.Enter, txtNoExtOperador.Enter, txtDescripConfigVehicular.Enter, txtDescripcionTipoPermisoSCT.Enter, txtCpOperador.Enter, txtConVeh.Enter, txtCalleOperador.Enter, txtAseguradoraTransporte.Enter, txtAseguradoraDanosMedioAmbiente.Enter, txtAseguradoraCargaTransporte.Enter, txtApPaternoOperador.Enter, txtApMaternoOperador.Enter, txtAnioModeloTransporte.Enter, numCantidadRemolquesTransporte.Enter
        If sender.GetType() IsNot GetType(TextBox) Then Return
        Dim text As TextBox = CType(sender, TextBox)
        text.BackColor = Color.FromName("Info")
    End Sub

    Private Sub textbox_Leave(sender As Object, e As EventArgs) Handles txtTipoUbicacion.Leave, txtRfcRemitente.Leave, txtReferenciaRemitente.Leave, txtPaisResidenciaFiscalRemitente.Leave, txtNumRegidTribRemitente.Leave, txtNombreRemitente.Leave, txtNoIntRemitente.Leave, txtNoExtRemitente.Leave, txtIdUbicacionOrigen.Leave, txtHoraSalidaRemitente.Leave, txtCpRemitente.Leave, txtCalleRemitente.Leave, txtApPaternoRemitente.Leave, txtApMaternoRemitente.Leave, txtTipoUbicacionDestino.Leave, txtRfcDestino.Leave, txtResidenciaFiscalDestino.Leave, txtReferenciaDestino.Leave, txtNumIdRegFiscalDestino.Leave, txtNombreDestino.Leave, txtNoIntDestino.Leave, txtNoExtDestino.Leave, txtIdUbicacionDestino.Leave, txtHoraSalidaDestino.Leave, txtCpDestino.Leave, txtCalleDestino.Leave, txtApPaternoDestino.Leave, txtApMaternoDestino.Leave, nupKmRecorridos.Leave, cbResidenciaFiscalDestino.Leave, txtTipoUbicacionDestinoIntermedio.Leave, txtRfcDestinoIntermedio.Leave, txtReferenciaDestinoIntermedio.Leave, txtNombreDestinoIntermedio.Leave, txtNoIntDestinoIntermedio.Leave, txtNoExtDestinoIntermedio.Leave, txtIdUbicacionDestinoIntermedio.Leave, txtHoraLlegadaDestinoIntermedio.Leave, txtCpDestinoIntermedio.Leave, txtCalleDestinoIntermedio.Leave, txtApPaternoDestinoIntermedio.Leave, txtApMaternoDestinoIntermedio.Leave, nupKmDestinoIntermedio.Leave, txtValor.Leave, txtUnidadMercancia.Leave, txtUnidadClaveMercancia.Leave, txtPeso.Leave, txtPedimento.Leave, txtMoneda.Leave, txtFraccionArancelaria.Leave, txtEmbalaje.Leave, txtDescripcionProducto.Leave, txtDescripcionMaterialPeligroso.Leave, txtDescripcionEmbalaje.Leave, txtClaveProdServMercancia.Leave, txtClaveMaterialPeligroso.Leave, txtCantidadMercancia.Leave, numLongitud.Leave, numAnchura.Leave, numAltura.Leave, txtUnidadPesoTotalMercancias.Leave, txtTipoRemolque2.Leave, txtTipoRemolque1.Leave, txtTipoPermisoSCT.Leave, txtRfcOperador.Leave, txtReferenciaOperador.Leave, txtPrimaSeguroTransporte.Leave, txtPolizaTransporte.Leave, txtPolizaSegurosDanosMedioAmbiente.Leave, txtPolizaCargaTransporte.Leave, txtPlacaTransporte.Leave, txtPlacasRemolque2.Leave, txtPlacasRemolque1.Leave, txtPesoBrutoTotalMercancias.Leave, txtNumRegIdTribFiscOperador.Leave, txtNumPermisoSCT.Leave, txtNumLicenciaOperador.Leave, txtNombreOperador.Leave, txtNoIntOperador.Leave, txtNoExtOperador.Leave, txtDescripConfigVehicular.Leave, txtDescripcionTipoPermisoSCT.Leave, txtCpOperador.Leave, txtConVeh.Leave, txtCalleOperador.Leave, txtAseguradoraTransporte.Leave, txtAseguradoraDanosMedioAmbiente.Leave, txtAseguradoraCargaTransporte.Leave, txtApPaternoOperador.Leave, txtApMaternoOperador.Leave, txtAnioModeloTransporte.Leave, numCantidadRemolquesTransporte.Leave
        If sender.GetType() IsNot GetType(TextBox) Then Return
        Dim text As TextBox = CType(sender, TextBox)
        text.BackColor = Color.White
    End Sub

    'Este realiza la validación de cuando el SAT cuenta con catalogos de 
    'estados, municipios, localidades y códigos postales
    'y hace las sustituciones correspondientes
    Private Sub RealizaOperacionesSustitucionPaisesEstadoColonia(ByRef refCbPais As ComboBox,
                                                                 ByRef refCbEstado As ComboBox,
                                                                 ByRef refCbEstadoEH As EventHandler,
                                                                 ByRef refCbMunicipio As ComboBox,
                                                                 ByRef refCbMunicipioEH As EventHandler,
                                                                 ByRef refCbLocalidad As ComboBox,
                                                                 ByRef refCbLocalidadEH As EventHandler,
                                                                 ByRef refCbColonia As ComboBox,
                                                                 ByRef refTxtCp As TextBox,
                                                                 ByRef refTxtEstado As TextBox,
                                                                 ByRef refTxtMunicipio As TextBox,
                                                                 ByRef refTxtLocalidad As TextBox,
                                                                 ByRef refTxtColonia As TextBox,
                                                                 ByRef refPanel As TableLayoutPanel)
        Dim paisSeleccionado As String = ObtenValorCombobox(refCbPais)
        'Si esta la opción por defecto, no me interesa proceder, solo bloquear y regresar
        If paisSeleccionado = "-01" Then
            LimpiaDesactivaCombobox(refCbEstado)
            LimpiaDesactivaCombobox(refCbMunicipio)
            LimpiaDesactivaCombobox(refCbLocalidad)
            LimpiaDesactivaCombobox(refCbColonia)
            LimpiaDesactivaTextbox(refTxtCp)
            LimpiaDesactivaTextbox(refTxtEstado)
            LimpiaDesactivaTextbox(refTxtMunicipio)
            LimpiaDesactivaTextbox(refTxtLocalidad)
            LimpiaDesactivaTextbox(refTxtColonia)
            Return
        End If

        'Primero validación de estados
        If PaisTieneEstados(paisSeleccionado) Then
            If refCbEstado Is Nothing Then
                refCbEstado = New ComboBox
                AddHandler refCbEstado.SelectedValueChanged, refCbEstadoEH
                SustituyeEnGrid(refTxtEstado, refCbEstado, refPanel)
            End If
            BindCombobox(refCbEstado, ObtenEstadosPorPais(paisSeleccionado))
            MarcaCampoComoObligatorio(refCbEstado, refPanel)
        Else
            If refTxtEstado Is Nothing Then
                refTxtEstado = New TextBox
                SustituyeEnGrid(refCbEstado, refTxtEstado, refPanel)
            End If
            refTxtEstado.Text = String.Empty
            refTxtEstado.Enabled = True
            MarcaCampoComoOpcional(refTxtEstado, refPanel)
        End If

        'Luego validación de municipio/localidad
        If PaisTieneMunicipioLocalidad(paisSeleccionado) Then
            Dim valorSeleccionadoEstado As String = ObtenValorCombobox(refCbEstado)
            If refCbMunicipio Is Nothing Then
                refCbMunicipio = New ComboBox
                LimpiaDesactivaCombobox(refCbMunicipio)
                SustituyeEnGrid(refTxtMunicipio, refCbMunicipio, refPanel)
                AddHandler refCbMunicipio.SelectedValueChanged, refCbMunicipioEH
                If valorSeleccionadoEstado <> "-01" Then
                    BindCombobox(refCbMunicipio, ObtenMunicipiosPorEstado(valorSeleccionadoEstado))
                End If
            End If
            If refCbLocalidad Is Nothing Then
                refCbLocalidad = New ComboBox
                LimpiaDesactivaCombobox(refCbLocalidad)
                SustituyeEnGrid(refTxtLocalidad, refCbLocalidad, refPanel)
                AddHandler refCbLocalidad.SelectedValueChanged, refCbLocalidadEH
                If valorSeleccionadoEstado <> "-01" Then
                    BindCombobox(refCbLocalidad, ObtenLocalidadesPorEstado(valorSeleccionadoEstado))
                End If
            End If
            MarcaCampoComoObligatorio(refCbMunicipio, refPanel)
            MarcaCampoComoObligatorio(refCbLocalidad, refPanel)
        Else
            If refTxtMunicipio Is Nothing Then
                refTxtMunicipio = New TextBox
                SustituyeEnGrid(refCbMunicipio, refTxtMunicipio, refPanel)
            End If
            If refTxtLocalidad Is Nothing Then
                refTxtLocalidad = New TextBox
                SustituyeEnGrid(refCbLocalidad, refTxtLocalidad, refPanel)
            End If
            MarcaCampoComoOpcional(refTxtMunicipio, refPanel)
            MarcaCampoComoOpcional(refTxtLocalidad, refPanel)
        End If

        'Luego validación de colonias
        If PaisTieneColonias(paisSeleccionado) Then
            If refCbColonia Is Nothing Then
                refCbColonia = New ComboBox
                SustituyeEnGrid(refTxtColonia, refCbColonia, refPanel)
                Dim valorIngresadoCp As String = ObtenValorTextbox(refTxtCp)
                Dim regExpCp As String = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
                If Regex.IsMatch(valorIngresadoCp, regExpCp) Then
                    BindCombobox(refCbColonia, ObtenColoniasPorCodigoPostal(valorIngresadoCp))
                End If
            End If
            MarcaCampoComoObligatorio(refCbColonia, refPanel)
        Else
            If refTxtColonia Is Nothing Then
                refTxtColonia = New TextBox
                SustituyeEnGrid(refCbColonia, refTxtColonia, refPanel)
            End If
            refTxtColonia.Text = String.Empty
            refTxtColonia.Enabled = True
            MarcaCampoComoOpcional(refTxtColonia, refPanel)
        End If
    End Sub

    Private Sub AbreSiEsEnter(ByRef key As KeyEventArgs, ByRef handler As EventHandler)
        If key.KeyCode = Keys.Enter Then
            handler(Nothing, Nothing)
        End If
    End Sub

    'Método que realiza validación de código postal y de carga de estos
    Private Sub RealizaCargaValidacionCodigoCargaColonias(ByRef refCbEstado As ComboBox,
                                                          ByRef refCbMunicipio As ComboBox,
                                                          ByRef refCbLocalidad As ComboBox,
                                                          ByRef refCbColonia As ComboBox,
                                                          ByRef refTxtCp As TextBox)
        If refCbMunicipio Is Nothing Or refCbLocalidad Is Nothing Or refCbColonia Is Nothing Then
            Return
        End If

        Dim valorEstado As String = ObtenValorCombobox(refCbEstado)
        Dim valorMunicipio As String = ObtenValorCombobox(refCbMunicipio)
        Dim valorLocalidad As String = ObtenValorCombobox(refCbLocalidad)
        If valorEstado = "-01" Or valorMunicipio = "-01" Or valorLocalidad = "-01" Then
            LimpiaDesactivaTextbox(refTxtCp)
            LimpiaDesactivaCombobox(refCbColonia)
            Return
        End If

        Dim valorCp As String = ObtenValorTextbox(refTxtCp)
        Dim regExpCp As String = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If Not Regex.IsMatch(valorCp, regExpCp) Then
            LimpiaDesactivaCombobox(refCbColonia)
            'AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL"))
            Return
        End If

        Dim mensaje As String = String.Empty
        Dim cpValido As Boolean = conexionesCartaPorte.Get_ValidaCodigoPostal(valorCp, valorEstado, valorMunicipio, valorLocalidad, mensaje)

        If Not cpValido Then
            AlertaMensaje(mensaje)
            LimpiaDesactivaCombobox(refCbColonia)
            Return
        End If
        BindCombobox(refCbColonia, ObtenColoniasPorCodigoPostal(valorCp))
    End Sub

    Private Sub MarcaCampoComoObligatorio(ByRef control As Control,
                                          ByRef panel As TableLayoutPanel)
        If control Is Nothing Then Return
        Dim col As Int32 = panel.GetColumn(control)
        Dim row As Int32 = panel.GetRow(control)
        If col = 0 Then Return

        Dim label As Control = panel.GetControlFromPosition(col - 1, row)
        If label Is Nothing Then Return
        If label.GetType() IsNot GetType(Label) Then Return

        Dim labelCtrl As Label = CType(label, Label)
        If labelCtrl.Text.Contains("*") Then Return
        labelCtrl.Text = labelCtrl.Text + " *"
        labelCtrl.ForeColor = Color.IndianRed
    End Sub

    Private Sub MarcaCampoComoOpcional(ByRef control As Control,
                                       ByRef panel As TableLayoutPanel)
        If control Is Nothing Then Return
        Dim col As Int32 = panel.GetColumn(control)
        Dim row As Int32 = panel.GetRow(control)
        If col = 0 Then Return

        Dim label As Control = panel.GetControlFromPosition(col - 1, row)
        If label Is Nothing Then Return
        If label.GetType() IsNot GetType(Label) Then Return

        Dim labelCtrl As Label = CType(label, Label)
        If Not labelCtrl.Text.Contains("*") Then Return
        labelCtrl.Text = Trim(labelCtrl.Text.Replace("*", ""))
        labelCtrl.ForeColor = Color.Black
    End Sub

    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        If ESTOY_CAMBIANDO_MEDIANTE_INDICE Then Return
        e.Cancel = True
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim selectedTab = TabControl1.SelectedTab
        If selectedTab.Equals(TabControl1.TabPages("tabOrigen")) Then
            PreparaPestanaOrigen()
        ElseIf selectedTab.Equals(TabControl1.TabPages("tabDestino")) Then
            PreparaPestanaDestino()
        ElseIf selectedTab.Equals(TabControl1.TabPages("tabDestinosIntermedios")) Then
            PreparaPestanaDestinoIntermedio()
        ElseIf selectedTab.Equals(TabControl1.TabPages("tabMercancias")) Then
            PreparaPestanaMercancias()
        ElseIf selectedTab.Equals(TabControl1.TabPages("tabTransporte")) Then
            PreparaPestanaTransporte()
        ElseIf selectedTab.Equals(TabControl1.TabPages("tabOperador")) Then
            PreparaDatosOperador()
        ElseIf selectedTab.Equals(TabControl1.TabPages("tabConfirmacion")) Then
            PreparaPestanaConfirmacion()
        End If
    End Sub
    Private Sub CargaParametros()
        descripcionEscenario = conexionesCartaPorte.Get_InformacionEscenarioCartaPorte(Me.idEmpresa)
        parametrosFormaCartaPorte = conexionesCartaPorte.Get_ObtenParametros()
        colorCampoObligatorio = ObtenParametroPorLlave("COLOR_OBLIG")
        colorCampoOpcional = ObtenParametroPorLlave("COLOR_OPC")
        colorUsuarioCausoProblemas = ObtenParametroPorLlave("COLOR_USU_PROB")
    End Sub

    Private Function ObtenParametroPorLlave(ByRef llave As String) As String
        For Each r As DataRow In parametrosFormaCartaPorte.Rows
            If r("clave").ToString.Equals(llave) Then
                Return r("valor").ToString
            End If
        Next
        Return String.Empty
    End Function

    Private Sub AlertaMensaje(ByVal mensaje As String)
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Error")
    End Sub

    Private Sub AtrapaEvento(ByVal text As String)
        esperandoBusqueda.Text = text
    End Sub

    Private Function EsCadenaVacia(ByVal mensaje As String) As Boolean
        Return String.IsNullOrWhiteSpace(mensaje)
    End Function

    Private Function ObtenListadoPaises() As DataTable
        Return conexionesCartaPorte.Get_ObtenPaises(True)
    End Function

    Private Function ObtenListadoPaises(ByVal cadena As String) As DataTable
        Return conexionesCartaPorte.Get_ObtenPaises(True, cadena)
    End Function

    Private Function ObtenDescripcionPais(ByVal codigoPais As String) As String
        Return conexionesCartaPorte.Get_ObtenDescripcionPais(codigoPais)
    End Function

    Private Function ObtenEstadosPorPais(ByVal pais As String) As DataTable
        Return conexionesCartaPorte.Get_ObtenEstados(True, pais)
    End Function

    Private Function ObtenLocalidadesPorEstado(ByVal estado As String) As DataTable
        Return conexionesCartaPorte.Get_ObtenLocalidadesPorEstado(True, estado)
    End Function

    Private Function ObtenMunicipiosPorEstado(ByVal estado As String) As DataTable
        Return conexionesCartaPorte.Get_ObtenMunicipiosPorEstado(True, estado)
    End Function

    Private Function ObtenColoniasPorCodigoPostal(ByVal codigoPostal As String) As DataTable
        Return conexionesCartaPorte.Get_ObtenColoniasPorCodigoPostal(True, codigoPostal)
    End Function

    Private Function SeEncuentraValor(ByVal valorABuscar As String,
                                      ByVal cadenaDeValores As String,
                                      ByVal separador As String) As Boolean
        Dim opc As String() = cadenaDeValores.Split(separador)
        For Each cad As String In opc
            If cad.Equals(valorABuscar) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub BindCombobox(ByRef combo As ComboBox, ByRef data As DataTable)
        If combo Is Nothing Then
            combo = New ComboBox
        End If

        combo.DataSource = Nothing
        If combo.Items IsNot Nothing Then
            combo.Items.Clear()
        End If
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id"
        combo.DataSource = data
        combo.Enabled = True
        combo.DropDownStyle = ComboBoxStyle.DropDownList
        combo.BringToFront()
    End Sub

    Private Sub creaTextbox(ByRef textbox As TextBox)
        If textbox Is Nothing Then
            textbox = New TextBox
        End If
        textbox.Text = String.Empty
        textbox.Enabled = True
    End Sub

    Private Sub LimpiaDesactivaCombobox(ByRef combo As ComboBox)
        If combo Is Nothing Then Return
        combo.DataSource = Nothing
        If combo.Items IsNot Nothing Then
            combo.Items.Clear()
        End If
        combo.Enabled = False
    End Sub

    Private Sub LimpiaDesactivaTextbox(ByRef textbox As TextBox)
        If textbox Is Nothing Then Return
        textbox.Text = String.Empty
        textbox.Enabled = False
    End Sub

    Private Function ObtenValorCombobox(ByRef combo As ComboBox) As String
        If combo Is Nothing Then
            Return "-01"
        End If

        If combo.Items.Count = 0 Then
            Return "-01"
        End If

        If combo.SelectedValue Is Nothing Then
            Return "-01"
        End If

        Return combo.SelectedValue
    End Function

    Private Sub LimpiaGrid(ByRef grid As DataGridView)
        grid.DataSource = Nothing
        If grid.Rows IsNot Nothing Then
            grid.Rows.Clear()
        End If
    End Sub

    Private Function ObtenValorTextbox(ByRef text As TextBox) As String
        If text Is Nothing Then Return String.Empty
        Return UCase(Regex.Replace(Trim(text.Text), " {2,}", " "))
    End Function

    Private Sub RemueveDeGrid(ByRef control As Control, ByRef panel As TableLayoutPanel)
        If control IsNot Nothing Then
            panel.Controls.Remove(control)
        End If
        control = Nothing
    End Sub

    Private Sub CargaColoniasPorCodigoPostal(ByRef refCbEstado As ComboBox,
                                             ByRef refCbMunicipio As ComboBox,
                                             ByRef refCbLocalidad As ComboBox,
                                             ByRef refCbColonia As ComboBox,
                                             ByRef refTxtCp As TextBox)
        'Si esta en nulo, quiere decir que no tiene catálogo de colonias
        If refCbColonia Is Nothing Then
            Return
        End If

        'Tengo que ver si son 5 números
        Dim cpRegExp As String = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        Dim cp As String = ObtenValorTextbox(refTxtCp)
        If Not Regex.IsMatch(cp, cpRegExp) Then
            AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL"))
            Return
        End If

        'Ahora tengo que ver si la colonia es válida
        Dim mensaje As String = String.Empty
        Dim valida As Boolean = conexionesCartaPorte.Get_ValidaCodigoPostal(cp,
                                                    ObtenValorCombobox(refCbEstado),
                                                    ObtenValorCombobox(refCbMunicipio),
                                                    ObtenValorCombobox(refCbLocalidad),
                                                    mensaje)
        If Not valida Then
            AlertaMensaje(mensaje)
            Return
        End If

        'Si ya llemos hasta aquí, podemos hacer el binding sin problemas
        BindCombobox(refCbColonia, ObtenColoniasPorCodigoPostal(cp))
    End Sub

    Private Sub SustituyeEnGrid(ByRef controlAReemplazar As Control,
                                ByRef controlNuevo As Control,
                                ByRef panel As TableLayoutPanel)
        Dim idColumna As Int32 = panel.GetColumn(controlAReemplazar)
        Dim idRenglon As Int32 = panel.GetRow(controlAReemplazar)
        RemueveDeGrid(controlAReemplazar, panel)
        controlNuevo.Dock = DockStyle.Fill
        panel.Controls.Add(controlNuevo)
        panel.SetColumn(controlNuevo, idColumna)
        panel.SetRow(controlNuevo, idRenglon)
        controlAReemplazar = Nothing
    End Sub

    Private Function PaisTieneEstados(ByRef pais As String) As Boolean
        Dim separador As String = ObtenParametroPorLlave("SEPARADOR")
        Dim listaPaisesConEstados As String = ObtenParametroPorLlave("PAISES_CON_ESTADO")
        Return SeEncuentraValor(pais, listaPaisesConEstados, separador)
    End Function

    Private Function PaisTieneMunicipioLocalidad(ByRef pais As String) As Boolean
        Dim separador = ObtenParametroPorLlave("SEPARADOR")
        Dim listaPaisesConMunicipios As String = ObtenParametroPorLlave("PAISES_CON_MUNICIPIO_LOCALIDAD")
        Return SeEncuentraValor(pais, listaPaisesConMunicipios, separador)
    End Function

    Private Function PaisTieneColonias(ByRef pais As String) As Boolean
        Dim separador = ObtenParametroPorLlave("SEPARADOR")
        Dim listaPaisesConColonias As String = ObtenParametroPorLlave("PAISES_CON_COLONIAS")
        Return SeEncuentraValor(pais, listaPaisesConColonias, separador)
    End Function

    Private Sub ValidaOrdenMunicipioLocalidadCodigo(ByRef refCbPais As ComboBox,
                                                    ByRef refCbEstado As ComboBox,
                                                    ByRef refCbLocalidad As ComboBox,
                                                    ByRef refCbMunicipio As ComboBox,
                                                    ByRef refTxtCp As TextBox,
                                                    ByRef refCbColonia As ComboBox)
        'En los paises que no existe la colonia, es texto abierto el CP
        Dim valorPais As String = ObtenValorCombobox(refCbPais)
        If refCbColonia Is Nothing Then
            refTxtCp.Enabled = True
            Return
        End If

        'Si no existen municipios ni localidades, no tiene caso continuar
        'tambien es texto abierto el CP
        If refCbMunicipio Is Nothing Or refCbLocalidad Is Nothing Then
            refTxtCp.Enabled = True
            Return
        End If

        'Si ya tiene cargadas las colonias, es necesario volver a aplicar la 
        'validacion de código postal, porque podría haber cambiado
        'municipio o localidad, y así el código ya no sería válido
        If refCbColonia.Enabled Then
            RealizaCargaValidacionCodigoCargaColonias(refCbEstado, refCbMunicipio, refCbLocalidad, refCbColonia, refTxtCp)
            Return
        End If

        'Si tiene valores para todo, también es necesario aplicar la validación,
        'para que recargue las colonias
        If ObtenValorCombobox(refCbEstado) <> "-01" And ObtenValorCombobox(refCbMunicipio) <> "-01" And ObtenValorCombobox(refCbLocalidad) <> "-01" Then
            refTxtCp.Enabled = True
            RealizaCargaValidacionCodigoCargaColonias(refCbEstado, refCbMunicipio, refCbLocalidad, refCbColonia, refTxtCp)
            Return
        End If


        'Ahora sí, si tiene municipio y localidad,
        'aplico validacion de que no sea posible ingresar CP 
        'hasta que no seleccione ambos
        Dim valorMunicipio As String = ObtenValorCombobox(refCbMunicipio)
        Dim valorLocalidad As String = ObtenValorCombobox(refCbLocalidad)

        If valorMunicipio = "-01" Or valorLocalidad = "-01" Then
            LimpiaDesactivaTextbox(refTxtCp)
            LimpiaDesactivaCombobox(refCbColonia)
            Return
        End If

        refTxtCp.Enabled = True
    End Sub
#End Region

#Region "Datos de origen con sus eventos"
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE ORIGEN
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private INFORMACION_VALIDA_DATOS_ORIGEN As Boolean = False
    Private REMITENTE_ES_PERSONA_MORAL As Boolean = False
    Private REMITENTE_ES_PERSONA_FISICA As Boolean = False
    Private REMITENTE_ES_EXTRANJERO As Boolean = False

    Private txtEstadoOrigen As TextBox
    Private txtLocalidadOrigen As TextBox
    Private txtMunicipioOrigen As TextBox
    Private txtColoniaOrigen As TextBox

    Private refCbEstadoOrigen As ComboBox = Nothing
    Private refCbMunicipioOrigen As ComboBox = Nothing
    Private refCbLocalidadOrigen As ComboBox = Nothing
    Private refCbColoniaOrigen As ComboBox = Nothing

    Private ORIGEN_NO_HA_AVISADO_FECHA As Boolean = True
    Private ORIGEN_NO_HA_AVISADO_HORA As Boolean = True

    Private Sub txtHoraSalidaRemitente_Click(sender As Object, e As EventArgs) Handles txtHoraSalidaRemitente.Click
        If datosDestinoParaCartaPorte IsNot Nothing And ORIGEN_NO_HA_AVISADO_HORA Then
            Dim rsult = MsgBox(ObtenParametroPorLlave("EXISTE_FECHADF"), vbQuestion + vbYesNo, "Alerta")
            If rsult = MsgBoxResult.No Then Return
            ORIGEN_NO_HA_AVISADO_HORA = False
            ReiniciaFechaHoraDestino()
        End If
    End Sub

    Private Sub dtFechaSalidaRemitente_MouseDown(sender As Object, e As MouseEventArgs) Handles dtFechaSalidaRemitente.MouseDown
        If datosDestinoParaCartaPorte IsNot Nothing And ORIGEN_NO_HA_AVISADO_FECHA Then
            Dim rsult = MsgBox(ObtenParametroPorLlave("EXISTE_FECHADF"), vbQuestion + vbYesNo, "Alerta")
            If rsult = MsgBoxResult.No Then Return
            ORIGEN_NO_HA_AVISADO_FECHA = False
            ReiniciaFechaHoraDestino()
        End If
    End Sub


    Private Sub PreparaPestanaOrigen()
        'Ver si se puede importar la información o no
        txtTipoUbicacion.Text = "Origen"
        txtTipoUbicacion.Enabled = False
        INFORMACION_VALIDA_DATOS_ORIGEN = False
        LimpiarDatosOrigen()
        LimpiaDetallesOrigen()
        BindCombobox(cbPaisRemitente, ObtenListadoPaises())
        AddHandler cbPaisRemitente.SelectedValueChanged, AddressOf dtPaisRemitente_SelectedValueChanged
        TogglePersonaFisicaMoralExtranjeroOrigen()
        nupKmRecorridos.Minimum = 0
        nupKmRecorridos.Maximum = Int16.MaxValue
        CargaDatosOrigen()
    End Sub

    Private Sub LimpiarDatosOrigen()
        txtRfcRemitente.Text = String.Empty
        txtNombreRemitente.Text = String.Empty
        txtApPaternoRemitente.Text = String.Empty
        txtApMaternoRemitente.Text = String.Empty
        txtNumRegidTribRemitente.Text = String.Empty
        txtPaisResidenciaFiscalRemitente.Text = String.Empty
        LimpiaDesactivaCombobox(cbResidenciaFiscalRemitente)

        REMITENTE_ES_PERSONA_FISICA = True
        REMITENTE_ES_PERSONA_MORAL = False
        REMITENTE_ES_EXTRANJERO = False
        rbPersonaFisicaOrigen.Checked = True
        txtRfcRemitente.Enabled = True
        txtNombreRemitente.Enabled = True
        txtApPaternoRemitente.Enabled = True
        txtApMaternoRemitente.Enabled = True
        LimpiaDesactivaCombobox(cbResidenciaFiscalRemitente)
        LimpiaDesactivaTextbox(txtPaisResidenciaFiscalRemitente)
    End Sub

    Private Sub LimpiaDetallesOrigen()
        txtCpRemitente.Text = String.Empty
        txtNoExtRemitente.Text = String.Empty
        txtNoIntRemitente.Text = String.Empty
        LimpiaDesactivaCombobox(refCbEstadoOrigen)
        LimpiaDesactivaTextbox(txtEstadoOrigen)
        LimpiaDesactivaCombobox(refCbMunicipioOrigen)
        LimpiaDesactivaTextbox(txtMunicipioOrigen)
        LimpiaDesactivaCombobox(refCbLocalidadOrigen)
        LimpiaDesactivaTextbox(txtLocalidadOrigen)
        LimpiaDesactivaCombobox(refCbColoniaOrigen)
        LimpiaDesactivaTextbox(txtColoniaOrigen)
        RemueveDeGrid(txtEstadoOrigen, tlpDetalleDomicilioOrigen)
        RemueveDeGrid(txtMunicipioOrigen, tlpDetalleDomicilioOrigen)
        RemueveDeGrid(txtLocalidadOrigen, tlpDetalleDomicilioOrigen)
        RemueveDeGrid(txtColoniaOrigen, tlpDetalleDomicilioOrigen)
        txtCalleRemitente.Text = String.Empty
        txtReferenciaRemitente.Text = String.Empty
    End Sub

    Private Sub TogglePersonaFisicaMoralExtranjeroOrigen()
        If rbPersonaMoralOrigen.Checked Then
            REMITENTE_ES_PERSONA_MORAL = True
            REMITENTE_ES_PERSONA_FISICA = False
            REMITENTE_ES_EXTRANJERO = False
            txtNombreRemitente.Enabled = True
            txtRfcRemitente.Enabled = True
            txtRfcRemitente.Text = String.Empty

            MarcaCampoComoOpcional(txtApPaternoRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoOpcional(txtApMaternoRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoOpcional(cbResidenciaFiscalRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoOpcional(txtPaisResidenciaFiscalRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoOpcional(txtNumRegidTribRemitente, tlpContenedorDatosFiscalesOrigen)

            LimpiaDesactivaTextbox(txtApMaternoRemitente)
            LimpiaDesactivaTextbox(txtApPaternoRemitente)
            LimpiaDesactivaTextbox(txtNumRegidTribRemitente)
            LimpiaDesactivaTextbox(txtPaisResidenciaFiscalRemitente)
            LimpiaDesactivaCombobox(cbResidenciaFiscalRemitente)
            BindCombobox(cbPaisRemitente, ObtenListadoPaises("MEX"))
            cbPaisRemitente.SelectedValue = "MEX"
            cbPaisRemitente.Enabled = True

        ElseIf rbPersonaFisicaOrigen.Checked Then
            REMITENTE_ES_PERSONA_MORAL = False
            REMITENTE_ES_PERSONA_FISICA = True
            REMITENTE_ES_EXTRANJERO = False
            txtNombreRemitente.Enabled = True
            txtApPaternoRemitente.Enabled = True
            txtApMaternoRemitente.Enabled = True
            txtRfcRemitente.Text = String.Empty
            txtRfcRemitente.Enabled = True

            MarcaCampoComoObligatorio(txtApPaternoRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoObligatorio(txtApMaternoRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoOpcional(cbResidenciaFiscalRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoOpcional(txtPaisResidenciaFiscalRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoOpcional(txtNumRegidTribRemitente, tlpContenedorDatosFiscalesOrigen)

            LimpiaDesactivaTextbox(txtNumRegidTribRemitente)
            LimpiaDesactivaTextbox(txtPaisResidenciaFiscalRemitente)
            LimpiaDesactivaCombobox(cbResidenciaFiscalRemitente)
            BindCombobox(cbPaisRemitente, ObtenListadoPaises("MEX"))
            cbPaisRemitente.SelectedValue = "MEX"
            cbPaisRemitente.Enabled = True

        ElseIf rbExtranjeroOrigen.Checked Then
            REMITENTE_ES_PERSONA_MORAL = False
            REMITENTE_ES_PERSONA_FISICA = False
            REMITENTE_ES_EXTRANJERO = True

            MarcaCampoComoObligatorio(txtApPaternoRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoObligatorio(txtApMaternoRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoObligatorio(cbResidenciaFiscalRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoObligatorio(txtPaisResidenciaFiscalRemitente, tlpContenedorDatosFiscalesOrigen)
            MarcaCampoComoObligatorio(txtNumRegidTribRemitente, tlpContenedorDatosFiscalesOrigen)

            LimpiaDesactivaTextbox(txtNumRegidTribRemitente)
            txtNumRegidTribRemitente.Enabled = True
            LimpiaDesactivaTextbox(txtRfcRemitente)
            txtRfcRemitente.Text = ObtenParametroPorLlave("RFC_GENERICO_EXTRANJERO")
            txtNumRegIdTribFiscOperador.Enabled = True
            txtNombreRemitente.Enabled = True
            txtApPaternoRemitente.Enabled = True
            txtApMaternoRemitente.Enabled = True
            BindCombobox(cbResidenciaFiscalRemitente, ObtenListadoPaises())
            cbResidenciaFiscalRemitente.SelectedValue = "-01"
            BindCombobox(cbPaisRemitente, ObtenListadoPaises())
            cbPaisRemitente.SelectedValue = "-01"
            cbPaisRemitente.Enabled = True
        End If
    End Sub

    Private Sub ValidarDatosOrigen()
        INFORMACION_VALIDA_DATOS_ORIGEN = False
        Dim idUbicacion As String = ObtenValorTextbox(txtIdUbicacionOrigen)
        Dim rfcRemitente As String = ObtenValorTextbox(txtRfcRemitente)
        Dim nombreRemitente As String = ObtenValorTextbox(txtNombreRemitente)
        Dim apPaternoRemitente As String = ObtenValorTextbox(txtApPaternoRemitente)
        Dim apMaternoRemitente As String = ObtenValorTextbox(txtApMaternoRemitente)
        Dim numRegIdTribRemitente As String = ObtenValorTextbox(txtNumRegidTribRemitente)

        'La validación de id de origen es de a fuerza
        Dim regExpIdOrigen = ObtenParametroPorLlave("REGEXP_ID_ORIGEN")
        If Not Regex.IsMatch(idUbicacion, regExpIdOrigen) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ID_ORIGEN")) : Return

        'Primero, aplico las validaciones que dependen de un escenario
        If REMITENTE_ES_PERSONA_FISICA Then 'Validaciones exclusivas de la persona física
            Dim longitudRfcPersonaFisica As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_FISICA"))
            Dim regExpRfc = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_FISICA")

            If rfcRemitente.Length <> longitudRfcPersonaFisica Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If Not Regex.IsMatch(rfcRemitente, regExpRfc) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            If EsCadenaVacia(nombreRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoRemitente) And EsCadenaVacia(apMaternoRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            Dim mensajeError As String = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_LETRAS")
            Dim regExpSoloLetras = ObtenParametroPorLlave("REGEXP_CADENA_SOLO_LETRAS")

            If Not Regex.IsMatch(nombreRemitente, regExpSoloLetras) Then
                mensajeError = String.Format(mensajeError, "NOMBRE")
                AlertaMensaje(mensajeError)
                Return
            End If

            If Not EsCadenaVacia(apPaternoRemitente) And Not Regex.IsMatch(apPaternoRemitente, regExpSoloLetras) Then
                mensajeError = String.Format(mensajeError, "APELLIDO PATERNO")
                AlertaMensaje(mensajeError)
                Return
            End If

            If Not EsCadenaVacia(apMaternoRemitente) And Not Regex.IsMatch(apMaternoRemitente, regExpSoloLetras) Then
                mensajeError = String.Format(mensajeError, "APELLIDO MATERNO")
                AlertaMensaje(mensajeError)
                Return
            End If

        ElseIf REMITENTE_ES_PERSONA_MORAL Then 'Validaciones exclusivas de la persona moral
            Dim longitudRfcPersonaMoral As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_MORAL"))
            Dim regExpRfcPersonaMoral = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_MORAL")

            If rfcRemitente.Length <> longitudRfcPersonaMoral Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If Not Regex.IsMatch(rfcRemitente, regExpRfcPersonaMoral) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If EsCadenaVacia(nombreRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return

        ElseIf REMITENTE_ES_EXTRANJERO Then
            If Not Regex.IsMatch(numRegIdTribRemitente, ObtenParametroPorLlave("REGEXP_NUMREGID")) Then AlertaMensaje(ObtenParametroPorLlave("NUM_REG_IDTRIB_NO_VALIDO")) : Return
            If EsCadenaVacia(nombreRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoRemitente) And EsCadenaVacia(apMaternoRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return
            Dim paisResidenciaFiscalRemitente As String = ObtenValorCombobox(cbResidenciaFiscalDestino)
            If paisResidenciaFiscalRemitente = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_RESIDENCIA_FISCAL")) : Return
        End If

        Dim fechaSalida As Date = dtFechaSalidaRemitente.Value

        Dim longitudHora As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_HORA"))
        Dim regExpHora As String = ObtenParametroPorLlave("REGEXP_HORA")
        Dim horaSalida As String = txtHoraSalidaRemitente.Text
        If horaSalida.Length <> longitudHora Then AlertaMensaje(ObtenParametroPorLlave("HORA_MALFORMADA")) : Return
        If Not Regex.IsMatch(horaSalida, regExpHora) Then AlertaMensaje(ObtenParametroPorLlave("HORA_MALFORMADA")) : Return

        Dim paisSeleccionado As String = ObtenValorCombobox(cbPaisRemitente)
        Dim estadoRemitente As String = String.Empty
        Dim municipioRemitente As String = String.Empty
        Dim localidadRemitente As String = String.Empty

        'Valido que el país tenga estados
        If PaisTieneEstados(paisSeleccionado) Then
            If ObtenValorCombobox(refCbEstadoOrigen) = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            estadoRemitente = ObtenValorCombobox(refCbEstadoOrigen)
        Else
            estadoRemitente = ObtenValorTextbox(txtEstadoOrigen)
        End If

        'Ahora, valido que el país tenga municipios y localidades
        If PaisTieneMunicipioLocalidad(paisSeleccionado) Then
            If ObtenValorCombobox(refCbMunicipioOrigen) = "-01" Then ObtenParametroPorLlave("INGRESE_MUNICIPIO") : Return
            If ObtenValorCombobox(refCbLocalidadOrigen) = "-01" Then ObtenParametroPorLlave("INGRESE_LOCALIDAD") : Return
            municipioRemitente = ObtenValorCombobox(refCbMunicipioOrigen)
            localidadRemitente = ObtenValorCombobox(refCbLocalidadOrigen)
        Else
            municipioRemitente = ObtenValorTextbox(txtMunicipioOrigen)
            localidadRemitente = ObtenValorTextbox(txtLocalidadOrigen)
        End If

        'Ahora, valido que el país tenga colonias
        Dim coloniaOrigen As String = String.Empty
        If PaisTieneColonias(paisSeleccionado) Then
            coloniaOrigen = ObtenValorCombobox(refCbColoniaOrigen)
            If coloniaOrigen.Equals("-01") Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        Else
            coloniaOrigen = ObtenValorTextbox(txtColoniaOrigen)
            If EsCadenaVacia(coloniaOrigen) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        End If

        Dim cpRemitente As String = Trim(txtCpRemitente.Text)
        Dim regExpCp As String = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If cpRemitente.Length <> 5 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return
        If Not Regex.IsMatch(cpRemitente, regExpCp) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return

        Dim noExt As String = txtNoExtRemitente.Text
        If EsCadenaVacia(noExt) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NO_EXT")) : Return

        Dim noInt As String = txtNoIntRemitente.Text
        Dim calle As String = ObtenValorTextbox(txtCalleRemitente)
        If EsCadenaVacia(calle) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CALLE")) : Return

        Dim referencia As String = ObtenValorTextbox(txtReferenciaRemitente)

        datosOrigenParaCartaPorte = Nothing
        datosOrigenParaCartaPorte = New OrigenDestino
        datosOrigenParaCartaPorte.TipoUbicacion = txtTipoUbicacion.Text
        datosOrigenParaCartaPorte.IDUbicacion = idUbicacion
        datosOrigenParaCartaPorte.EsDestinoIntermedio = False
        datosOrigenParaCartaPorte.EsPersonaFisica = REMITENTE_ES_PERSONA_FISICA
        datosOrigenParaCartaPorte.EsPersonaMoral = REMITENTE_ES_PERSONA_MORAL
        datosOrigenParaCartaPorte.EsExtranjero = REMITENTE_ES_EXTRANJERO

        If REMITENTE_ES_PERSONA_FISICA Then
            datosOrigenParaCartaPorte.Nombre = nombreRemitente
            datosOrigenParaCartaPorte.ApPaterno = apPaternoRemitente
            datosOrigenParaCartaPorte.ApMaterno = apMaternoRemitente
        ElseIf REMITENTE_ES_PERSONA_MORAL Then
            datosOrigenParaCartaPorte.NombrePersonaMoral = nombreRemitente
        ElseIf REMITENTE_ES_EXTRANJERO Then
            datosOrigenParaCartaPorte.Nombre = nombreRemitente
            datosOrigenParaCartaPorte.ApPaterno = apPaternoRemitente
            datosOrigenParaCartaPorte.ApMaterno = apMaternoRemitente
            datosOrigenParaCartaPorte.NumRegIdTrib = numRegIdTribRemitente
            datosOrigenParaCartaPorte.ResidenciaFiscal = cbResidenciaFiscalRemitente.SelectedValue
        End If

        datosOrigenParaCartaPorte.RFCRemitenteDestinatario = rfcRemitente
        datosOrigenParaCartaPorte.NumRegIdTrib = numRegIdTribRemitente
        datosOrigenParaCartaPorte.FechaSalidaLlegada = dtFechaSalidaRemitente.Value
        datosOrigenParaCartaPorte.HoraSalidaLlegada = horaSalida
        datosOrigenParaCartaPorte.DistanciaRecorrida = 0

        Dim domicilio As New Domicilio
        domicilio.Calle = txtCalleRemitente.Text
        domicilio.NumeroExterior = txtNoExtRemitente.Text
        domicilio.NumeroInterior = txtNoIntRemitente.Text
        domicilio.Colonia = coloniaOrigen
        domicilio.Municipio = municipioRemitente
        domicilio.Localidad = localidadRemitente
        domicilio.Estado = estadoRemitente
        domicilio.Pais = paisSeleccionado
        domicilio.Referencia = referencia
        domicilio.CodigoPostal = cpRemitente

        datosOrigenParaCartaPorte.DatosDomicilio = domicilio
        INFORMACION_VALIDA_DATOS_ORIGEN = True
    End Sub

    Private Sub cbMunicipioRemitente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbMunicipioRemitente.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisRemitente,
                                            refCbEstadoOrigen,
                                            refCbLocalidadOrigen,
                                            refCbMunicipioOrigen,
                                            txtCpRemitente,
                                            refCbColoniaOrigen)
    End Sub

    Private Sub cbLocalidadRemitente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbLocalidadRemitente.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisRemitente,
                                            refCbEstadoOrigen,
                                            refCbLocalidadOrigen,
                                            refCbMunicipioOrigen,
                                            txtCpRemitente,
                                            refCbColoniaOrigen)
    End Sub

    Private Sub btnSiguienteOrigen_Click(sender As Object, e As EventArgs) Handles btnSiguienteOrigen.Click
        ValidarDatosOrigen()
        If INFORMACION_VALIDA_DATOS_ORIGEN Then
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
            TabControl1.SelectedTab = TabControl1.TabPages("tabDestino")
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
        End If
    End Sub

    Private Sub rbPersonaFisicaOrigen_CheckedChanged(sender As Object, e As EventArgs) Handles rbPersonaFisicaOrigen.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroOrigen()
    End Sub

    Private Sub rbPersonaMoralOrigen_CheckedChanged(sender As Object, e As EventArgs) Handles rbPersonaMoralOrigen.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroOrigen()
    End Sub

    Private Sub rbExtranjeroOrigen_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbExtranjeroOrigen.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroOrigen()
    End Sub

    Private Sub rbExtranjeroOrigen_CheckedChanged(sender As Object, e As EventArgs)
        TogglePersonaFisicaMoralExtranjeroOrigen()
    End Sub

    Private Sub dtPaisRemitente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisRemitente.SelectedValueChanged
        RealizaOperacionesSustitucionPaisesEstadoColonia(cbPaisRemitente,
                                                        refCbEstadoOrigen,
                                                        AddressOf cbEstadoRemitente_SelectedValueChanged,
                                                        refCbMunicipioOrigen,
                                                        AddressOf cbMunicipioRemitente_SelectedValueChanged,
                                                        refCbLocalidadOrigen,
                                                        AddressOf cbLocalidadRemitente_SelectedValueChanged,
                                                        refCbColoniaOrigen,
                                                        txtCpRemitente,
                                                        txtEstadoOrigen,
                                                        txtMunicipioOrigen,
                                                        txtLocalidadOrigen,
                                                        txtColoniaOrigen,
                                                        tlpDetalleDomicilioOrigen)
    End Sub

    Private Sub cbEstadoRemitente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEstadoRemitente.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisRemitente,
                                            refCbEstadoOrigen,
                                            refCbLocalidadOrigen,
                                            refCbMunicipioOrigen,
                                            txtCpRemitente,
                                            refCbColoniaOrigen)

        If ObtenValorCombobox(refCbEstadoOrigen) = "-01" Then 'No interesa proceder si seleccionó la opc por defecto
            LimpiaDesactivaCombobox(refCbMunicipioOrigen)
            LimpiaDesactivaCombobox(refCbLocalidadOrigen)
            Return
        End If

        Dim paisSeleccionado = ObtenValorCombobox(cbPaisRemitente)
        If PaisTieneMunicipioLocalidad(paisSeleccionado) Then
            RemueveDeGrid(txtMunicipioOrigen, tlpDetalleDomicilioOrigen)
            RemueveDeGrid(txtLocalidadOrigen, tlpDetalleDomicilioOrigen)
            LimpiaDesactivaCombobox(refCbMunicipioOrigen)
            LimpiaDesactivaCombobox(refCbLocalidadOrigen)
            BindCombobox(refCbMunicipioOrigen, ObtenMunicipiosPorEstado(ObtenValorCombobox(refCbEstadoOrigen)))
            BindCombobox(refCbLocalidadOrigen, ObtenLocalidadesPorEstado(ObtenValorCombobox(refCbEstadoOrigen)))
        End If
    End Sub

    Private Sub cbResidenciaFiscalRemitente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbResidenciaFiscalRemitente.SelectedValueChanged
        txtPaisResidenciaFiscalRemitente.Enabled = False
        If ObtenValorCombobox(cbResidenciaFiscalRemitente) = "-01" Then Return
        If REMITENTE_ES_EXTRANJERO Then
            Dim cvePais As String = ObtenValorCombobox(cbResidenciaFiscalRemitente)
            txtPaisResidenciaFiscalRemitente.Text = ObtenDescripcionPais(cvePais)
            If cbPaisRemitente.Items Is Nothing Then Return
            If cbPaisRemitente.Items.Count = 0 Then Return
            cbPaisRemitente.SelectedValue = cvePais
        End If
    End Sub

    Private Sub gbOrigenPersonaFisicaMoral_Enter(sender As Object, e As EventArgs) Handles gbOrigenPersonaFisicaMoral.Enter

    End Sub

    Private Sub txtCpRemitente_TextChanged(sender As Object, e As EventArgs) Handles txtCpRemitente.TextChanged
        RealizaCargaValidacionCodigoCargaColonias(refCbEstadoOrigen, refCbMunicipioOrigen, refCbLocalidadOrigen, refCbColoniaOrigen, txtCpRemitente)
    End Sub

    Private Sub CargaDatosOrigen()
        If datosOrigenParaCartaPorte IsNot Nothing Then
            txtTipoUbicacion.Text = "ORIGEN"
            txtIdUbicacionOrigen.Text = datosOrigenParaCartaPorte.IDUbicacion
            rbPersonaFisicaOrigen.Checked = datosOrigenParaCartaPorte.EsPersonaFisica
            rbPersonaMoralOrigen.Checked = datosOrigenParaCartaPorte.EsPersonaMoral
            rbExtranjeroOrigen.Checked = datosOrigenParaCartaPorte.EsExtranjero
            txtRfcRemitente.Text = datosOrigenParaCartaPorte.RFCRemitenteDestinatario
            txtNumRegidTribRemitente.Text = datosOrigenParaCartaPorte.NumRegIdTrib

            If REMITENTE_ES_PERSONA_FISICA Or REMITENTE_ES_EXTRANJERO Then
                txtNombreRemitente.Text = datosOrigenParaCartaPorte.Nombre
                txtApPaternoRemitente.Text = datosOrigenParaCartaPorte.ApPaterno
                txtApMaternoRemitente.Text = datosOrigenParaCartaPorte.ApMaterno
            ElseIf REMITENTE_ES_PERSONA_MORAL Then
                txtNombreRemitente.Text = datosOrigenParaCartaPorte.NombrePersonaMoral
            End If

            If REMITENTE_ES_EXTRANJERO Then
                cbResidenciaFiscalRemitente.SelectedValue = datosOrigenParaCartaPorte.ResidenciaFiscal
            End If
            Dim dom = datosOrigenParaCartaPorte.DatosDomicilio
            cbPaisRemitente.SelectedValue = dom.Pais

            'Cargo estados
            If refCbEstadoOrigen IsNot Nothing Then
                refCbEstadoOrigen.SelectedValue = dom.Estado
            Else
                txtEstadoOrigen.Text = dom.Estado
            End If

            'Cargo municipios y localidades
            If refCbMunicipioOrigen IsNot Nothing Then
                refCbMunicipioOrigen.SelectedValue = dom.Municipio
                refCbLocalidadOrigen.SelectedValue = dom.Localidad
            Else
                txtMunicipioOrigen.Text = dom.Municipio
                txtLocalidadOrigen.Text = dom.Localidad
            End If
            txtCpRemitente.Text = dom.CodigoPostal
            'Cargo colonias
            If refCbColoniaOrigen IsNot Nothing Then
                refCbColoniaOrigen.SelectedValue = dom.Colonia
            Else
                txtColoniaOrigen.Text = dom.Colonia
            End If
            txtNoExtRemitente.Text = dom.NumeroExterior
            txtNoIntRemitente.Text = dom.NumeroInterior
            txtCalleRemitente.Text = dom.Calle
            txtReferenciaRemitente.Text = dom.Referencia
        End If
    End Sub
#End Region

#Region "Datos de destino con sus eventos"
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE DESTINO
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private txtColoniaDestino As TextBox = Nothing
    Private txtEstadoDestino As TextBox = Nothing
    Private txtMunicipioDestino As TextBox = Nothing
    Private txtLocalidadDestino As TextBox = Nothing
    Private refCbColoniaDestino As ComboBox = Nothing
    Private refCbMunicipioDestino As ComboBox = Nothing
    Private refCbLocalidadDestino As ComboBox = Nothing
    Private refCbEstadoDestino As ComboBox = Nothing
    Private ES_PERSONA_FISICA_DESTINO As Boolean = False
    Private ES_PERSONA_MORAL_DESTINO As Boolean = False
    Private ES_EXTRANJERO_DESTINO As Boolean = False
    Private INFORMACION_VALIDA_DESTINO As Boolean = False

    'ESTAS SON BANDERAS PARA SABER SI YA AVISO DE POSIBLES
    'PROBLEMAS CON LAS FECHAS, HORAS Y KILOMETROS'
    Private YA_AVISO_FECHA As Boolean = True
    Private YA_AVISO_HORA As Boolean = True
    Private YA_AVISO_KM As Boolean = True

    'DEBIDO A LAS CONDICIONES PECULIARES DE ESTE OBJETO
    'ME VEO FORZADO A AÑADIR ESTA BANDERA PARA SABER SI YA CREO UNO O NO
    Private YA_CREO_DESTINO As Boolean = False

    Private Sub ReiniciaFechaHoraDestino()
        datosDestinoParaCartaPorte.UsuarioCausoProblemasConFecha = True
    End Sub

    Private Sub nupKmDestino_Click(sender As Object, e As EventArgs) Handles nupKmRecorridos.Click
        If datosDestinosIntermediosParaCartaPorte Is Nothing Then Return
        If datosDestinosIntermediosParaCartaPorte.Count = 0 Then Return
        If YA_AVISO_KM Then Return
        Dim rsult = MsgBox(ObtenParametroPorLlave("EXISTEN_KM"), vbQuestion + vbYesNo, "Alerta")
        If rsult = MsgBoxResult.No Then Return
        YA_AVISO_KM = True
        ReiniciaKm()
    End Sub

    Private Sub txtHoraLlegada_Click(sender As Object, e As EventArgs) Handles txtHoraSalidaDestino.Click
        If datosDestinosIntermediosParaCartaPorte Is Nothing Then Return
        If datosDestinosIntermediosParaCartaPorte.Count = 0 Then Return
        If YA_AVISO_HORA Then Return
        Dim rsult = MsgBox(ObtenParametroPorLlave("EXISTEN_FECHAS"), vbQuestion + vbYesNo, "Alerta")
        If rsult = MsgBoxResult.No Then Return
        YA_AVISO_HORA = True
        ReiniciaFechas()
    End Sub

    Private Sub dtFechaLlegada_MouseDown(sender As Object, e As MouseEventArgs) Handles dtFechaSalidaDestino.MouseDown
        If datosDestinosIntermediosParaCartaPorte Is Nothing Then Return
        If datosDestinosIntermediosParaCartaPorte.Count = 0 Then Return
        If YA_AVISO_FECHA Then Return
        Dim rsult = MsgBox(ObtenParametroPorLlave("EXISTEN_FECHAS"), vbQuestion + vbYesNo, "Alerta")
        If rsult = MsgBoxResult.No Then Return
        YA_AVISO_FECHA = True
        ReiniciaFechas()
    End Sub

    Private Sub ReiniciaKm()
        datosDestinosIntermediosParaCartaPorte.ForEach(Sub(x)
                                                           x.UsuarioCausoProblemasConKm = True
                                                           x.DistanciaRecorrida = 0
                                                       End Sub)
    End Sub

    Private Sub ReiniciaFechas()
        datosDestinosIntermediosParaCartaPorte.ForEach(Sub(x)
                                                           x.UsuarioCausoProblemasConFecha = True
                                                           x.FechaSalidaLlegada = datosOrigenParaCartaPorte.FechaSalidaLlegada
                                                       End Sub)
    End Sub

    Private Sub nupKmRecorridos_ValueChanged(sender As Object, e As EventArgs) Handles nupKmRecorridos.ValueChanged
        'If datosDestinosIntermediosParaCartaPorte Is Nothing Then
        '    Return
        'End If

        'If datosDestinosIntermediosParaCartaPorte.Count = 0 Then
        '    Return
        'End If

        'Dim kmConsumidos = 0
        'For Each destInter As OrigenDestino In datosDestinosIntermediosParaCartaPorte
        '    kmConsumidos = kmConsumidos + destInter.DistanciaRecorrida
        'Next

        'If nupKmRecorridos.Value > kmConsumidos Then
        '    Dim rsult = MsgBox(ObtenParametroPorLlave("PROBLEMAS_KM"), vbQuestion + vbYesNo, "Alerta")
        '    If rsult = MsgBoxResult.No Then Return
        '    For Each destInter As OrigenDestino In datosDestinosIntermediosParaCartaPorte
        '        destInter.DistanciaRecorrida = 0
        '    Next
        'End If
    End Sub
    Private Sub cbMunicipioDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbMunicipioDestino.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisDestino,
                                            refCbEstadoDestino,
                                            refCbLocalidadDestino,
                                            refCbMunicipioDestino,
                                            txtCpDestino,
                                            refCbColoniaDestino)
    End Sub

    Private Sub cbLocalidadDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbLocalidadDestino.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisDestino,
                                           refCbEstadoDestino,
                                           refCbLocalidadDestino,
                                           refCbMunicipioDestino,
                                           txtCpDestino,
                                           refCbColoniaDestino)
    End Sub

    Private Sub PreparaPestanaDestino()
        If datosDestinoParaCartaPorte Is Nothing Then
            datosDestinoParaCartaPorte = New OrigenDestino
        End If
        dtFechaSalidaDestino.MinDate = dtFechaSalidaRemitente.Value
        BindCombobox(cbPaisDestino, ObtenListadoPaises())
        LimpiarDatosDestino()
        LimpiarDatosOrigen()
        rbPersonaFisicaDestino.Checked = True
        CargaDatosDestino()
    End Sub

    Private Sub LimpiarDatosDestino()
        LimpiaDesactivaTextbox(txtRfcDestino)
        LimpiaDesactivaTextbox(txtNombreDestino)
        LimpiaDesactivaTextbox(txtApPaternoDestino)
        LimpiaDesactivaTextbox(txtApMaternoDestino)
        LimpiaDesactivaTextbox(txtNumIdRegFiscalDestino)
        LimpiaDesactivaTextbox(txtResidenciaFiscalDestino)
        LimpiaDesactivaCombobox(cbResidenciaFiscalDestino)
        txtTipoUbicacionDestino.Text = "Destino"
        txtTipoUbicacionDestino.Enabled = False
    End Sub

    Private Sub LimpiaDetallesDestino()
        LimpiaDesactivaCombobox(refCbEstadoDestino)
        LimpiaDesactivaCombobox(refCbMunicipioDestino)
        LimpiaDesactivaCombobox(refCbLocalidadDestino)
        LimpiaDesactivaCombobox(refCbColoniaDestino)
        txtCpDestino.Text = String.Empty
        txtNoExtDestino.Text = String.Empty
        txtNoIntDestino.Text = String.Empty
        txtCalleDestino.Text = String.Empty
        txtReferenciaDestino.Text = String.Empty
        txtMunicipioDestino = Nothing
        txtLocalidadDestino = Nothing
        txtEstadoDestino = Nothing
        txtColoniaDestino = Nothing
    End Sub

    Private Sub TogglePersonaFisicaMoralExtranjeroDestino()
        LimpiarDatosDestino()
        If rbPersonaFisicaDestino.Checked Then
            ES_PERSONA_FISICA_DESTINO = True
            ES_PERSONA_MORAL_DESTINO = False
            ES_EXTRANJERO_DESTINO = False
            BindCombobox(cbPaisDestino, ObtenListadoPaises("MEX"))
            cbPaisDestino.SelectedValue = "MEX"
            cbPaisDestino.Enabled = True
            txtRfcDestino.Enabled = True
            txtNombreDestino.Enabled = True
            txtApPaternoDestino.Enabled = True
            txtApMaternoDestino.Enabled = True

            MarcaCampoComoObligatorio(txtApMaternoDestino, tlpDatosDestino)
            MarcaCampoComoObligatorio(txtApPaternoDestino, tlpDatosDestino)
            MarcaCampoComoOpcional(txtNumIdRegFiscalDestino, tlpDatosDestino)
            MarcaCampoComoOpcional(cbResidenciaFiscalDestino, tlpDatosDestino)
            MarcaCampoComoOpcional(txtResidenciaFiscalDestino, tlpDatosDestino)

        ElseIf rbPersonaMoralDestino.Checked Then
            ES_PERSONA_FISICA_DESTINO = False
            ES_PERSONA_MORAL_DESTINO = True
            ES_EXTRANJERO_DESTINO = False
            BindCombobox(cbPaisDestino, ObtenListadoPaises("MEX"))
            cbPaisDestino.SelectedValue = "MEX"
            cbPaisDestino.Enabled = True
            txtRfcDestino.Enabled = True
            txtNombreDestino.Enabled = True

            MarcaCampoComoOpcional(txtApMaternoDestino, tlpDatosDestino)
            MarcaCampoComoOpcional(txtApPaternoDestino, tlpDatosDestino)
            MarcaCampoComoOpcional(txtNumIdRegFiscalDestino, tlpDatosDestino)
            MarcaCampoComoOpcional(cbResidenciaFiscalDestino, tlpDatosDestino)
            MarcaCampoComoOpcional(txtResidenciaFiscalDestino, tlpDatosDestino)

        ElseIf rbEsExtranjeroDestino.Checked Then
            ES_PERSONA_FISICA_DESTINO = False
            ES_PERSONA_MORAL_DESTINO = False
            ES_EXTRANJERO_DESTINO = True
            cbPaisDestino.SelectedValue = "-01"
            cbPaisDestino.Enabled = True
            BindCombobox(cbResidenciaFiscalDestino, ObtenListadoPaises())
            txtRfcDestino.Text = ObtenParametroPorLlave("RFC_GENERICO_EXTRANJERO")
            txtRfcDestino.Enabled = False
            txtNombreDestino.Enabled = True
            txtApPaternoDestino.Enabled = True
            txtApMaternoDestino.Enabled = True
            txtNumIdRegFiscalDestino.Enabled = True

            MarcaCampoComoObligatorio(txtApMaternoDestino, tlpDatosDestino)
            MarcaCampoComoObligatorio(txtApPaternoDestino, tlpDatosDestino)
            MarcaCampoComoObligatorio(txtNumIdRegFiscalDestino, tlpDatosDestino)
            MarcaCampoComoObligatorio(cbResidenciaFiscalDestino, tlpDatosDestino)
            MarcaCampoComoObligatorio(txtResidenciaFiscalDestino, tlpDatosDestino)
        End If
    End Sub

    Private Sub rbPersonaFisicaDestino_CheckedChanged(sender As Object, e As EventArgs) Handles rbPersonaFisicaDestino.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroDestino()
    End Sub

    Private Sub rbPersonaMoralDestino_CheckedChanged(sender As Object, e As EventArgs) Handles rbPersonaMoralDestino.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroDestino()
    End Sub

    Private Sub rbEsExtranjeroDestino_CheckedChanged(sender As Object, e As EventArgs) Handles rbEsExtranjeroDestino.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroDestino()
    End Sub

    Private Sub cbResidenciaFiscalDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbResidenciaFiscalDestino.SelectedValueChanged
        txtResidenciaFiscalDestino.Enabled = False
        If ES_EXTRANJERO_DESTINO Then
            If cbResidenciaFiscalDestino.SelectedValue = "-01" Then Return
            txtResidenciaFiscalDestino.Text = ObtenDescripcionPais(cbResidenciaFiscalDestino.SelectedValue)
        End If
    End Sub


    Private Sub cbPaisDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisDestino.SelectedValueChanged
        RealizaOperacionesSustitucionPaisesEstadoColonia(cbPaisDestino,
                                                        refCbEstadoDestino,
                                                        AddressOf cbEstadoDestino_SelectedValueChanged,
                                                        refCbMunicipioDestino,
                                                        AddressOf cbMunicipioDestino_SelectedValueChanged,
                                                        refCbLocalidadDestino,
                                                        AddressOf cbLocalidadDestino_SelectedValueChanged,
                                                        refCbColoniaDestino,
                                                        txtCpDestino,
                                                        txtEstadoDestino,
                                                        txtMunicipioDestino,
                                                        txtLocalidadDestino,
                                                        txtColoniaDestino,
                                                        tlpDetallesDestino)
    End Sub

    Private Sub cbEstadoDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEstadoDestino.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisDestino,
                                            refCbEstadoDestino,
                                            refCbLocalidadDestino,
                                            refCbMunicipioDestino,
                                            txtCpDestino,
                                            refCbColoniaDestino)

        If ObtenValorCombobox(refCbEstadoDestino) = "-01" Then
            LimpiaDesactivaCombobox(refCbMunicipioDestino)
            LimpiaDesactivaCombobox(refCbLocalidadDestino)
            Return
        End If

        Dim paisDestino = cbPaisDestino.SelectedValue
        'Si no tenemos los municipios y localidad, ni caso tiene seguir
        If Not PaisTieneEstados(paisDestino) Then
            Return
        End If

        BindCombobox(refCbMunicipioDestino, ObtenMunicipiosPorEstado(ObtenValorCombobox(refCbEstadoDestino)))
        BindCombobox(refCbLocalidadDestino, ObtenLocalidadesPorEstado(ObtenValorCombobox(refCbEstadoDestino)))
    End Sub

    Private Sub txtCpDestino_TextChanged(sender As Object, e As EventArgs) Handles txtCpDestino.TextChanged
        RealizaCargaValidacionCodigoCargaColonias(refCbEstadoDestino, refCbMunicipioDestino, refCbLocalidadDestino, refCbColoniaDestino, txtCpDestino)
    End Sub

    Private Sub btnSiguienteDestino_Click(sender As Object, e As EventArgs) Handles btnSiguienteDestino.Click
        If datosDestinoParaCartaPorte.UsuarioCausoProblemasConFecha Then
            AlertaMensaje(ObtenParametroPorLlave("REVISE_FECHAHORA"))
            Return
            datosDestinoParaCartaPorte.UsuarioCausoProblemasConFecha = False
        End If
        ValidarDatosDestino()
        If INFORMACION_VALIDA_DESTINO Then
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
            TabControl1.SelectedTab = TabControl1.TabPages("tabDestinosIntermedios")
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
        End If
    End Sub

    Private Sub btnAtrasDestino_Click(sender As Object, e As EventArgs) Handles btnAtrasDestino.Click
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
        TabControl1.SelectedTab = TabControl1.TabPages("tabOrigen")
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
    End Sub

    Private Sub ValidarDatosDestino()
        INFORMACION_VALIDA_DESTINO = False
        Dim tipoUbicacion = ObtenValorTextbox(txtTipoUbicacionDestino)
        Dim idUbicacion = ObtenValorTextbox(txtIdUbicacionDestino)
        Dim rfcDestino As String = String.Empty
        Dim nombreDestino As String = String.Empty
        Dim apPaternoDestino As String = String.Empty
        Dim apMaternoDestino As String = String.Empty
        Dim residenciaFiscalDestino As String = String.Empty
        Dim numRegIdFiscalDestino As String = String.Empty

        Dim regExpIdUbiDestino = ObtenParametroPorLlave("REGEXP_ID_DESTINO")
        If Not Regex.IsMatch(idUbicacion, regExpIdUbiDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ID_DESTINO")) : Return

        If ES_PERSONA_FISICA_DESTINO Then 'Validaciones de persona física
            rfcDestino = ObtenValorTextbox(txtRfcDestino)
            Dim longitudRfcPersonaFisica As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_FISICA"))
            If rfcDestino.Length <> longitudRfcPersonaFisica Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If Not Regex.IsMatch(rfcDestino, ObtenParametroPorLlave("REGEXP_RFC_PERSONA_FISICA")) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            nombreDestino = ObtenValorTextbox(txtNombreDestino)
            apPaternoDestino = ObtenValorTextbox(txtApPaternoDestino)
            apMaternoDestino = ObtenValorTextbox(txtApMaternoDestino)

            If EsCadenaVacia(nombreDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoDestino) And EsCadenaVacia(apMaternoDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            Dim mensajeError As String = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_LETRAS")
            Dim regExpSoloLetras = ObtenParametroPorLlave("REGEXP_CADENA_SOLO_LETRAS")
            If Not Regex.IsMatch(nombreDestino, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return
            If Not EsCadenaVacia(apPaternoDestino) And Not Regex.IsMatch(apPaternoDestino, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return
            If Not EsCadenaVacia(apMaternoDestino) And Not Regex.IsMatch(apMaternoDestino, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return

        ElseIf ES_PERSONA_MORAL_DESTINO Then 'Validaciones de persona moral
            rfcDestino = ObtenValorTextbox(txtRfcDestino)
            nombreDestino = ObtenValorTextbox(txtNombreDestino)
            Dim longitudRfcDestino As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_MORAL"))
            If rfcDestino.Length <> longitudRfcDestino Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            Dim regExpRfcPersonaMoral = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_MORAL")
            If Not Regex.IsMatch(rfcDestino, regExpRfcPersonaMoral) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If EsCadenaVacia(nombreDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return

        ElseIf ES_EXTRANJERO_DESTINO Then 'Validaciones de extranjero
            nombreDestino = ObtenValorTextbox(txtNombreDestino)
            apPaternoDestino = ObtenValorTextbox(txtApPaternoDestino)
            apMaternoDestino = ObtenValorTextbox(txtApMaternoDestino)

            If EsCadenaVacia(nombreDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoDestino) And EsCadenaVacia(apMaternoDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            numRegIdFiscalDestino = ObtenValorTextbox(txtNumIdRegFiscalDestino)
            If cbResidenciaFiscalDestino.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("Es necesario que ingrese una residencia fiscal")) : Return
            residenciaFiscalDestino = cbResidenciaFiscalDestino.SelectedValue
        End If

        Dim fechaLlegadaDestino As Date
        Dim horaLlegada As String = ObtenValorTextbox(txtHoraSalidaDestino)
        fechaLlegadaDestino = dtFechaSalidaDestino.Value

        If horaLlegada.Length <> 5 Then AlertaMensaje(ObtenParametroPorLlave("HORA_MALFORMADA")) : Return

        Dim regExpHoras = ObtenParametroPorLlave("REGEXP_HORA")
        If Not Regex.IsMatch(horaLlegada, regExpHoras) Then AlertaMensaje(ObtenParametroPorLlave("HORA_MALFORMADA")) : Return

        Dim fechaHoraParaComparacion As DateTime = ObtenDateTime(fechaLlegadaDestino, horaLlegada)
        If fechaHoraParaComparacion <= datosOrigenParaCartaPorte.FechaHora Then AlertaMensaje(ObtenParametroPorLlave("FECHA_LLEGADA_FINAL_INCORRECTA")) : Return

        Dim paisDestino As String = String.Empty
        Dim estadoDestino As String = String.Empty
        Dim municipioDestino As String = String.Empty
        Dim localidadDestino As String = String.Empty
        Dim coloniaDestino As String = String.Empty
        Dim calleDestino As String = String.Empty
        Dim referenciaDestino As String = String.Empty
        Dim CPDestino As String = String.Empty
        Dim noExtDestino As String = String.Empty
        Dim noIntDestino As String = String.Empty

        paisDestino = ObtenValorCombobox(cbPaisDestino)
        If REMITENTE_ES_EXTRANJERO Then 'Aquí no puedo tomar simplemente los valores de los combo
            'Tengo que hacer un montón de validaciones
            'Primero veo de donde tengo que obtener el estado
            If PaisTieneEstados(paisDestino) Then
                estadoDestino = ObtenValorCombobox(refCbEstadoDestino)
                If estadoDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            Else
                estadoDestino = ObtenValorTextbox(txtEstadoDestino)
                If EsCadenaVacia(estadoDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            End If

            If PaisTieneMunicipioLocalidad(paisDestino) Then
                municipioDestino = ObtenValorCombobox(refCbMunicipioDestino)
                localidadDestino = ObtenValorCombobox(refCbLocalidadDestino)
                If municipioDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
                If localidadDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return
            Else
                municipioDestino = ObtenValorTextbox(txtMunicipioDestino)
                localidadDestino = ObtenValorTextbox(txtLocalidadDestino)
            End If

            If PaisTieneColonias(paisDestino) Then
                coloniaDestino = ObtenValorCombobox(refCbColoniaDestino)
                If coloniaDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
            Else
                coloniaDestino = ObtenValorTextbox(txtColoniaDestino)
                If EsCadenaVacia(coloniaDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
            End If
        Else
            estadoDestino = ObtenValorCombobox(refCbEstadoDestino)
            municipioDestino = ObtenValorCombobox(refCbMunicipioDestino)
            localidadDestino = ObtenValorCombobox(refCbLocalidadDestino)
            If municipioDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            If localidadDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return

            coloniaDestino = ObtenValorCombobox(refCbColoniaDestino)
            If cbColoniaDestino.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        End If

        CPDestino = ObtenValorTextbox(txtCpDestino)
        Dim regExpCp = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If CPDestino.Length <> 5 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return
        If Not Regex.IsMatch(CPDestino, regExpCp) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return

        noExtDestino = ObtenValorTextbox(txtNoExtDestino)
        If EsCadenaVacia(noExtDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NO_EXT")) : Return

        noIntDestino = ObtenValorTextbox(txtNoIntDestino)

        calleDestino = ObtenValorTextbox(txtCalleDestino)
        If EsCadenaVacia(calleDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CALLE")) : Return

        referenciaDestino = ObtenValorTextbox(txtReferenciaDestino)

        Dim kmRecorridos As Int32 = nupKmRecorridos.Value
        If kmRecorridos <= 0 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_KILOMETROS_RECORRIDOS")) : Return

        datosDestinoParaCartaPorte.UsuarioCausoProblemasConFecha = False
        datosDestinoParaCartaPorte.TipoUbicacion = tipoUbicacion
        datosDestinoParaCartaPorte.IDUbicacion = idUbicacion
        datosDestinoParaCartaPorte.RFCRemitenteDestinatario = rfcDestino
        If ES_PERSONA_MORAL_DESTINO Then
            datosDestinoParaCartaPorte.NombrePersonaMoral = nombreDestino
        Else
            datosDestinoParaCartaPorte.NombrePersonaMoral = String.Empty
        End If
        datosDestinoParaCartaPorte.Nombre = nombreDestino
        datosDestinoParaCartaPorte.ApPaterno = apPaternoDestino
        datosDestinoParaCartaPorte.ApMaterno = apMaternoDestino
        datosDestinoParaCartaPorte.ResidenciaFiscal = residenciaFiscalDestino
        datosDestinoParaCartaPorte.NumRegIdTrib = numRegIdFiscalDestino
        datosDestinoParaCartaPorte.FechaSalidaLlegada = fechaLlegadaDestino
        datosDestinoParaCartaPorte.HoraSalidaLlegada = horaLlegada
        datosDestinoParaCartaPorte.DistanciaRecorrida = kmRecorridos
        datosDestinoParaCartaPorte.EsPersonaFisica = ES_PERSONA_FISICA_DESTINO
        datosDestinoParaCartaPorte.EsPersonaMoral = ES_PERSONA_MORAL_DESTINO
        datosDestinoParaCartaPorte.EsExtranjero = ES_EXTRANJERO_DESTINO

        Dim domicilio As New Domicilio
        domicilio.Calle = calleDestino
        domicilio.NumeroExterior = noExtDestino
        domicilio.NumeroInterior = noIntDestino
        domicilio.Colonia = coloniaDestino
        domicilio.Localidad = localidadDestino
        domicilio.Municipio = municipioDestino
        domicilio.Estado = estadoDestino
        domicilio.Pais = paisDestino
        domicilio.Referencia = referenciaDestino
        domicilio.CodigoPostal = CPDestino
        datosDestinoParaCartaPorte.DatosDomicilio = domicilio
        INFORMACION_VALIDA_DESTINO = True
        YA_CREO_DESTINO = True
        ORIGEN_NO_HA_AVISADO_FECHA = True
        ORIGEN_NO_HA_AVISADO_HORA = True
    End Sub

    Private Sub CargaDatosDestino()
        If YA_CREO_DESTINO Then
            txtTipoUbicacionDestino.Text = "Destino"
            txtIdUbicacionDestino.Text = datosDestinoParaCartaPorte.IDUbicacion
            rbEsExtranjeroDestino.Checked = datosDestinoParaCartaPorte.EsExtranjero
            rbPersonaFisicaDestino.Checked = datosDestinoParaCartaPorte.EsPersonaFisica
            rbPersonaMoralDestino.Checked = datosDestinoParaCartaPorte.EsPersonaMoral
            txtRfcDestino.Text = datosDestinoParaCartaPorte.RFCRemitenteDestinatario
            txtNombreDestino.Text = datosDestinoParaCartaPorte.Nombre
            txtApPaternoDestino.Text = datosDestinoParaCartaPorte.ApPaterno
            txtApMaternoDestino.Text = datosDestinoParaCartaPorte.ApMaterno
            txtNumIdRegFiscalDestino.Text = datosDestinoParaCartaPorte.NumRegIdTrib

            If datosDestinoParaCartaPorte.UsuarioCausoProblemasConFecha Then
                dtFechaSalidaDestino.Value = datosOrigenParaCartaPorte.FechaHora
                txtHoraSalidaDestino.Text = String.Empty
            Else
                dtFechaSalidaDestino.Value = datosDestinoParaCartaPorte.FechaSalidaLlegada
                txtHoraSalidaDestino.Text = datosDestinoParaCartaPorte.HoraSalidaLlegada
            End If

            nupKmRecorridos.Value = datosDestinoParaCartaPorte.DistanciaRecorrida

            If ES_EXTRANJERO_DESTINO Then
                cbResidenciaFiscalDestino.SelectedValue = datosDestinoParaCartaPorte.ResidenciaFiscal
            End If

            Dim dom As Domicilio = datosDestinoParaCartaPorte.DatosDomicilio
            cbPaisDestino.SelectedValue = dom.Pais
            If refCbEstadoDestino IsNot Nothing Then
                refCbEstadoDestino.SelectedValue = dom.Estado
            Else
                txtEstadoDestino.Text = dom.Estado
            End If

            If refCbMunicipioDestino IsNot Nothing Then
                refCbMunicipioDestino.SelectedValue = dom.Municipio
                refCbLocalidadDestino.SelectedValue = dom.Localidad
            Else
                txtMunicipioDestino.Text = dom.Municipio
                txtLocalidadDestino.Text = dom.Localidad
            End If

            txtCpDestino.Text = dom.CodigoPostal
            If refCbColoniaDestino IsNot Nothing Then
                refCbColoniaDestino.SelectedValue = dom.Colonia
            Else
                txtColoniaDestino.Text = dom.Colonia
            End If

            txtNoExtDestino.Text = dom.NumeroExterior
            txtNoIntDestino.Text = dom.NumeroInterior
            txtCalleDestino.Text = dom.Calle
            txtReferenciaDestino.Text = dom.Referencia
        End If
    End Sub
#End Region

#Region "Datos de destinos intermedios"
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE DESTINOS INTERMEDIOS
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private txtEstadoDestinoIntermedio As TextBox = Nothing
    Private txtMunicipioDestinoIntermedio As TextBox = Nothing
    Private txtLocalidadDestinoIntermedio As TextBox = Nothing
    Private txtColoniaDestinoIntermedio As TextBox = Nothing
    Private refCbEstadoDestinoIntermedio As ComboBox = Nothing
    Private refCbMunicipioDestinoIntermedio As ComboBox = Nothing
    Private refCbLocalidadDestinoIntermedio As ComboBox = Nothing
    Private refCbColoniaDestinoIntermedio As ComboBox = Nothing

    Private ES_PERSONA_MORAL_DESTINO_INTERMEDIO As Boolean = False
    Private ES_PERSONA_FISICA_DESTINO_INTERMEDIO As Boolean = False
    Private ES_EXTRANJERO_DESTINO_INTERMEDIO As Boolean = False
    Private INFORMACION_VALIDA_DESTINO_INTERMEDIO As Boolean = False
    Private ESTA_CREANDO_DESTINO_INTERMEDIO As Boolean = False
    Private ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO As Boolean = False

    Private Sub cbMunicipioDestinoIntermedio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbMunicipioDestinoIntermedio.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisDestinoIntermedio,
                                           refCbEstadoDestinoIntermedio,
                                           refCbLocalidadDestinoIntermedio,
                                           refCbMunicipioDestinoIntermedio,
                                           txtCpDestinoIntermedio,
                                           refCbColoniaDestinoIntermedio)
    End Sub

    Private Sub cbLocalidadDestinoIntermedio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbLocalidadDestinoIntermedio.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisDestinoIntermedio,
                                           refCbEstadoDestinoIntermedio,
                                           refCbLocalidadDestinoIntermedio,
                                           refCbMunicipioDestinoIntermedio,
                                           txtCpDestinoIntermedio,
                                           refCbColoniaDestinoIntermedio)
    End Sub

    Private Sub BindGridDestinosIntermedios()
        dgvCartaPorteDestinosIntermedios.DataSource = Nothing
        If dgvCartaPorteDestinosIntermedios.Rows IsNot Nothing Then
            dgvCartaPorteDestinosIntermedios.Rows.Clear()
        End If
        dgvCartaPorteDestinosIntermedios.DataSource = Nothing
        dgvCartaPorteDestinosIntermedios.AutoGenerateColumns = False
        dgvCartaPorteDestinosIntermedios.Columns("DIMovimientoClm").DataPropertyName = NameOf(OrigenDestino.IDUbicacion)
        dgvCartaPorteDestinosIntermedios.Columns("DIDestinoClm").DataPropertyName = NameOf(OrigenDestino.DestinoDesplegado)
        dgvCartaPorteDestinosIntermedios.Columns("DIFechaLlegadaClm").DataPropertyName = NameOf(OrigenDestino.FechaSalidaLlegadaCadena)
        dgvCartaPorteDestinosIntermedios.Columns("DIHoraLlegadaClm").DataPropertyName = NameOf(OrigenDestino.HoraSalidaLlegada)
        dgvCartaPorteDestinosIntermedios.Columns("DIKmClm").DataPropertyName = NameOf(OrigenDestino.DistanciaRecorridaCadena)
        dgvCartaPorteDestinosIntermedios.Columns("IDUbicacionClm").DataPropertyName = NameOf(OrigenDestino.IDUbicacion)
        dgvCartaPorteDestinosIntermedios.Columns("DIUsuarioProblemasFechaClm").DataPropertyName = NameOf(OrigenDestino.UsuarioCausoProblemasConFecha)
        dgvCartaPorteDestinosIntermedios.Columns("DIUsuarioCausoProblemasConKm").DataPropertyName = NameOf(OrigenDestino.UsuarioCausoProblemasConKm)
        dgvCartaPorteDestinosIntermedios.DataSource = datosDestinosIntermediosParaCartaPorte
    End Sub

    Private Sub dgvCartaPorteDestinosIntermedios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCartaPorteDestinosIntermedios.CellFormatting
        Dim columnaIdMovimiento = 0
        If e.ColumnIndex <> columnaIdMovimiento Then Return

        Dim idMovimiento As String = dgvCartaPorteDestinosIntermedios.Rows(e.RowIndex).Cells(columnaIdMovimiento).Value
        Dim objOrigenDestino As OrigenDestino = datosDestinosIntermediosParaCartaPorte.FirstOrDefault(Function(x) x.IDUbicacion.Equals(idMovimiento))

        Dim huboProblemas = False Or objOrigenDestino.UsuarioCausoProblemasConFecha Or objOrigenDestino.UsuarioCausoProblemasConKm
        If huboProblemas Then
            dgvCartaPorteDestinosIntermedios.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromName(colorUsuarioCausoProblemas)
        Else
            dgvCartaPorteDestinosIntermedios.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    Private Sub PreparaPestanaDestinoIntermedio()
        BloqueaDestinoIntermedio()
        BindGridDestinosIntermedios()
        If datosDestinosIntermediosParaCartaPorte Is Nothing Then
            datosDestinosIntermediosParaCartaPorte = New List(Of OrigenDestino)
        End If
    End Sub

    Private Sub BloqueaDestinoIntermedio()
        LimpiaDesactivaTextbox(txtTipoUbicacionDestinoIntermedio)
        txtTipoUbicacionDestinoIntermedio.Text = "Destino"
        LimpiaDesactivaTextbox(txtIdUbicacionDestinoIntermedio)
        rbEsPersonaFisicaDestinoIntermedio.Checked = True
        rbEsPersonaFisicaDestinoIntermedio.Enabled = False
        rbEsPersonaMoralDestinoIntermedio.Enabled = False
        rbEsExtranjeroDestinoIntermedio.Enabled = False
        LimpiaDesactivaTextbox(txtRfcDestinoIntermedio)
        LimpiaDesactivaTextbox(txtNombreDestinoIntermedio)
        LimpiaDesactivaTextbox(txtApPaternoDestinoIntermedio)
        LimpiaDesactivaTextbox(txtApMaternoDestinoIntermedio)
        LimpiaDesactivaCombobox(cbPaisResidenciaFiscalDestinoIntermedio)
        LimpiaDesactivaTextbox(txtPaisResidenciaFiscalDestinoIntermedio)
        dtFechaLlegadaDestinoIntermedio.Value = dtFechaLlegadaDestinoIntermedio.MinDate
        dtFechaLlegadaDestinoIntermedio.Enabled = False
        LimpiaDesactivaTextbox(txtHoraLlegadaDestinoIntermedio)
        nupKmDestinoIntermedio.Enabled = False
        LimpiaDesactivaCombobox(cbPaisDestinoIntermedio)
        LimpiaDesactivaCombobox(cbEstadoDestinoIntermedio)
        LimpiaDesactivaCombobox(cbMunicipioDestinoIntermedio)
        LimpiaDesactivaCombobox(cbLocalidadDestinoIntermedio)
        LimpiaDesactivaTextbox(txtCpDestinoIntermedio)
        LimpiaDesactivaTextbox(txtNoIntDestinoIntermedio)
        LimpiaDesactivaTextbox(txtNoExtDestinoIntermedio)
        LimpiaDesactivaTextbox(txtCalleDestinoIntermedio)
        LimpiaDesactivaTextbox(txtReferenciaDestinoIntermedio)
        lblFechaHoraMaximaDestInter.Text = String.Empty
    End Sub

    Private Sub ObtenMaximosMinimosFecha(ByRef fechaMinima As DateTime,
                                         ByRef fechaMaxima As DateTime)
        fechaMinima = datosOrigenParaCartaPorte.FechaHora
        fechaMaxima = datosDestinoParaCartaPorte.FechaHora
    End Sub

    Private Sub PreparaEntradaPestanaDestinoIntermedio()
        txtIdUbicacionDestinoIntermedio.Enabled = True
        rbEsPersonaFisicaDestinoIntermedio.Enabled = True
        rbEsPersonaMoralDestinoIntermedio.Enabled = True
        rbEsExtranjeroDestinoIntermedio.Enabled = True
        rbEsPersonaFisicaDestinoIntermedio.Checked = True
        TogglePersonaMoralFisicaExtranjeroDestinoIntermedio()

        nupKmDestinoIntermedio.Minimum = 0
        nupKmDestinoIntermedio.Maximum = ObtenKilometrosDisponibles()
        nupKmDestinoIntermedio.Enabled = True

        Dim fechaSalidaOrigen As DateTime
        Dim fechaLlegadaMax As DateTime
        ObtenMaximosMinimosFecha(fechaSalidaOrigen, fechaLlegadaMax)
        dtFechaLlegadaDestinoIntermedio.MinDate = fechaSalidaOrigen.Date
        dtFechaLlegadaDestinoIntermedio.MaxDate = fechaLlegadaMax.Date
        dtFechaLlegadaDestinoIntermedio.Enabled = True
        lblFechaHoraMaximaDestInter.Text = String.Format(ObtenParametroPorLlave("AVISO_FECHAS"), fechaSalidaOrigen.ToString("dd-MM-yyyy HH:mm"), fechaLlegadaMax.ToString("dd-MM-yyyy HH:mm"))
        lblFechaHoraMaximaDestInter.ForeColor = Color.Red

        txtHoraLlegadaDestinoIntermedio.Enabled = True
        txtNoExtDestinoIntermedio.Enabled = True
        txtNoIntDestinoIntermedio.Enabled = True
        txtCalleDestinoIntermedio.Enabled = True
        txtReferenciaDestinoIntermedio.Enabled = True
    End Sub

    Private Sub TogglePersonaMoralFisicaExtranjeroDestinoIntermedio()
        If rbEsPersonaFisicaDestinoIntermedio.Checked Then
            LimpiaDesactivaTextbox(txtNumregIdTribDestinoIntermedio)
            ES_PERSONA_MORAL_DESTINO_INTERMEDIO = False
            ES_PERSONA_FISICA_DESTINO_INTERMEDIO = True
            ES_EXTRANJERO_DESTINO_INTERMEDIO = False
            txtIdUbicacionDestinoIntermedio.Enabled = True
            txtRfcDestinoIntermedio.Enabled = True
            txtNombreDestinoIntermedio.Enabled = True
            txtApPaternoDestinoIntermedio.Enabled = True
            txtApMaternoDestinoIntermedio.Enabled = True
            BindCombobox(cbPaisDestinoIntermedio, ObtenListadoPaises("MEX"))
            cbPaisDestinoIntermedio.SelectedValue = "MEX"
            cbPaisDestinoIntermedio.Enabled = True

            MarcaCampoComoObligatorio(txtApPaternoDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoObligatorio(txtApMaternoDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoOpcional(txtNumregIdTribDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoOpcional(cbPaisResidenciaFiscalDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoOpcional(txtPaisResidenciaFiscalDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)

        ElseIf rbEsPersonaMoralDestinoIntermedio.Checked Then
            LimpiaDesactivaTextbox(txtNumregIdTribDestinoIntermedio)
            LimpiaDesactivaTextbox(txtApPaternoDestinoIntermedio)
            LimpiaDesactivaTextbox(txtApMaternoDestinoIntermedio)
            ES_PERSONA_MORAL_DESTINO_INTERMEDIO = True
            ES_PERSONA_FISICA_DESTINO_INTERMEDIO = False
            ES_EXTRANJERO_DESTINO_INTERMEDIO = False
            txtRfcDestinoIntermedio.Enabled = True
            txtNombreDestinoIntermedio.Enabled = True
            BindCombobox(cbPaisDestinoIntermedio, ObtenListadoPaises("MEX"))
            cbPaisDestinoIntermedio.SelectedValue = "MEX"
            cbPaisDestinoIntermedio.Enabled = True

            MarcaCampoComoOpcional(txtApPaternoDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoOpcional(txtApMaternoDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoOpcional(txtNumregIdTribDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoOpcional(cbPaisResidenciaFiscalDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoOpcional(txtPaisResidenciaFiscalDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)

        ElseIf rbEsExtranjeroDestinoIntermedio.Checked Then
            ES_PERSONA_MORAL_DESTINO_INTERMEDIO = False
            ES_PERSONA_FISICA_DESTINO_INTERMEDIO = False
            ES_EXTRANJERO_DESTINO_INTERMEDIO = True

            LimpiaDesactivaTextbox(txtRfcDestinoIntermedio)
            txtRfcDestinoIntermedio.Text = ObtenParametroPorLlave("RFC_GENERICO_EXTRANJERO")

            txtNumregIdTribDestinoIntermedio.Enabled = True
            txtNombreDestinoIntermedio.Enabled = True
            txtApPaternoDestinoIntermedio.Enabled = True
            txtApMaternoDestinoIntermedio.Enabled = True
            cbPaisDestinoIntermedio.SelectedValue = "-01"
            cbPaisDestinoIntermedio.Enabled = True

            MarcaCampoComoObligatorio(txtApPaternoDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoObligatorio(txtApMaternoDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoObligatorio(txtNumregIdTribDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoObligatorio(cbPaisResidenciaFiscalDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            MarcaCampoComoObligatorio(txtPaisResidenciaFiscalDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
        End If
    End Sub

    Private Sub ValidarDatosDestinoIntermedio()
        If (Not ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO) And
                (Not ESTA_CREANDO_DESTINO_INTERMEDIO) Then
            INFORMACION_VALIDA_DESTINO_INTERMEDIO = True
            Return
        End If


        INFORMACION_VALIDA_DESTINO_INTERMEDIO = False
        Dim tipoUbicacionDestInter As String = "Destino"
        Dim idUbicacionDestInter As String = ObtenValorTextbox(txtIdUbicacionDestinoIntermedio)


        Dim regExpIdUbiDestino = ObtenParametroPorLlave("REGEXP_ID_DESTINO")
        If Not Regex.IsMatch(idUbicacionDestInter, regExpIdUbiDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ID_DESTINO")) : Return

        'Si esta creando uno desde 0, tengo que verificar que la información no esté duplicada
        If ESTA_CREANDO_DESTINO_INTERMEDIO Then
            Dim existeObj As OrigenDestino = datosDestinosIntermediosParaCartaPorte.Find(Function(obj) obj.IDUbicacion.Equals(idUbicacionDestInter))
            If (existeObj IsNot Nothing) Or idUbicacionDestInter.Equals(datosDestinoParaCartaPorte.IDUbicacion) Then
                AlertaMensaje(ObtenParametroPorLlave("ID_UBICACION_REPETIDO"))
                Return
            End If
        End If

        Dim rfcRemitenteDestInter As String = String.Empty
        Dim nombreDestInter As String = String.Empty
        Dim apPaternoDestInter As String = String.Empty
        Dim apMaternoDestInter As String = String.Empty
        Dim paisResidenciaDestFiscal As String = String.Empty
        Dim numRegIdTribDestInter As String = String.Empty


        If ES_PERSONA_FISICA_DESTINO_INTERMEDIO Then
            rfcRemitenteDestInter = ObtenValorTextbox(txtRfcDestinoIntermedio)
            nombreDestInter = ObtenValorTextbox(txtNombreDestinoIntermedio)
            apPaternoDestInter = ObtenValorTextbox(txtApPaternoDestinoIntermedio)
            apMaternoDestInter = ObtenValorTextbox(txtApMaternoDestinoIntermedio)

            Dim longitudRfcPersonaFisica As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_FISICA"))
            If rfcRemitenteDestInter.Length <> longitudRfcPersonaFisica Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If Not Regex.IsMatch(rfcRemitenteDestInter, ObtenParametroPorLlave("REGEXP_RFC_PERSONA_FISICA")) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            If EsCadenaVacia(nombreDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoDestInter) And EsCadenaVacia(apMaternoDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            Dim mensajeError As String = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_LETRAS")
            Dim regExpSoloLetras = ObtenParametroPorLlave("REGEXP_CADENA_SOLO_LETRAS")
            If Not Regex.IsMatch(nombreDestInter, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return
            If Not EsCadenaVacia(apPaternoDestInter) And Not Regex.IsMatch(apPaternoDestInter, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return
            If Not EsCadenaVacia(apMaternoDestInter) And Not Regex.IsMatch(apMaternoDestInter, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return

        ElseIf ES_PERSONA_MORAL_DESTINO_INTERMEDIO Then
            rfcRemitenteDestInter = ObtenValorTextbox(txtRfcDestinoIntermedio)
            nombreDestInter = ObtenValorTextbox(txtNombreDestinoIntermedio)

            Dim longitudRfcDestino As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_MORAL"))
            If rfcRemitenteDestInter.Length <> longitudRfcDestino Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            Dim regExpRfcPersonaMoral = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_MORAL")
            If Not Regex.IsMatch(rfcRemitenteDestInter, regExpRfcPersonaMoral) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If EsCadenaVacia(nombreDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return

        ElseIf ES_EXTRANJERO_DESTINO_INTERMEDIO Then
            rfcRemitenteDestInter = ObtenValorTextbox(txtRfcDestinoIntermedio)
            nombreDestInter = ObtenValorTextbox(txtNombreDestinoIntermedio)
            apPaternoDestInter = ObtenValorTextbox(txtApPaternoDestinoIntermedio)
            apMaternoDestInter = ObtenValorTextbox(txtApMaternoDestinoIntermedio)
            paisResidenciaDestFiscal = cbPaisResidenciaFiscalDestinoIntermedio.SelectedValue
            numRegIdTribDestInter = ObtenValorTextbox(txtNumregIdTribDestinoIntermedio)

            If EsCadenaVacia(nombreDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoDestInter) And EsCadenaVacia(apMaternoDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            numRegIdTribDestInter = ObtenValorTextbox(txtNumIdRegFiscalDestino)
            If cbResidenciaFiscalDestino.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("Es necesario que ingrese una residencia fiscal")) : Return
            paisResidenciaDestFiscal = cbResidenciaFiscalDestino.SelectedValue
        End If

        Dim paisDestino As String = String.Empty
        Dim estadoDestino As String = String.Empty
        Dim municipioDestino As String = String.Empty
        Dim localidadDestino As String = String.Empty
        Dim coloniaDestino As String = String.Empty
        Dim calleDestino As String = String.Empty
        Dim referenciaDestino As String = String.Empty
        Dim CPDestino As String = String.Empty
        Dim noExtDestino As String = String.Empty
        Dim noIntDestino As String = String.Empty

        paisDestino = cbPaisDestinoIntermedio.SelectedValue
        If REMITENTE_ES_EXTRANJERO Then 'Aquí no puedo tomar simplemente los valores de los combo
            'Tengo que hacer un montón de validaciones
            'Primero veo de donde tengo que obtener el estado
            If refCbEstadoDestinoIntermedio IsNot Nothing Then
                estadoDestino = ObtenValorCombobox(refCbEstadoDestinoIntermedio)
                If estadoDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            Else
                estadoDestino = ObtenValorTextbox(txtEstadoDestinoIntermedio)
                If EsCadenaVacia(estadoDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            End If

            If refCbMunicipioDestinoIntermedio IsNot Nothing Then
                municipioDestino = ObtenValorCombobox(refCbMunicipioDestinoIntermedio)
                If municipioDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            Else
                municipioDestino = ObtenValorTextbox(txtMunicipioDestinoIntermedio)
            End If
            If refCbLocalidadDestinoIntermedio IsNot Nothing Then
                localidadDestino = ObtenValorCombobox(refCbLocalidadDestinoIntermedio)
                If localidadDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return
            Else
                localidadDestino = ObtenValorTextbox(txtLocalidadDestinoIntermedio)
            End If

            If refCbColoniaDestinoIntermedio IsNot Nothing Then
                coloniaDestino = ObtenValorCombobox(refCbColoniaDestinoIntermedio)
                If coloniaDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
            Else
                coloniaDestino = ObtenValorTextbox(txtColoniaDestinoIntermedio)
                If EsCadenaVacia(coloniaDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
            End If
        Else
            estadoDestino = ObtenValorCombobox(refCbEstadoDestinoIntermedio)
            municipioDestino = ObtenValorCombobox(refCbMunicipioDestinoIntermedio)
            localidadDestino = ObtenValorCombobox(refCbLocalidadDestinoIntermedio)
            If estadoDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            If municipioDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            If localidadDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return
            coloniaDestino = ObtenValorCombobox(refCbColoniaDestinoIntermedio)
            If coloniaDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
            Dim regExpCp2 As String = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
            If Not Regex.IsMatch(ObtenValorTextbox(txtCpDestinoIntermedio), regExpCp2) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return
        End If

        Dim regExpHora = ObtenParametroPorLlave("REGEXP_HORA")
        Dim horaLlegadaDestInter = ObtenValorTextbox(txtHoraLlegadaDestinoIntermedio)
        If Not Regex.IsMatch(horaLlegadaDestInter, regExpHora) Then AlertaMensaje(ObtenParametroPorLlave("HORA_MALFORMADA")) : Return

        Dim fechaLlegadaDestInter As DateTime = ObtenDateTime(dtFechaLlegadaDestinoIntermedio.Value, horaLlegadaDestInter)

        Dim fechaHoraMinima As DateTime
        Dim fechaHoraMaxima As DateTime
        ObtenMaximosMinimosFecha(fechaHoraMinima, fechaHoraMaxima)
        'Verifico que las fechas estén dentro del rango correcto
        If (fechaLlegadaDestInter <= fechaHoraMinima) Or (fechaLlegadaDestInter >= fechaHoraMaxima) Then
            AlertaMensaje(String.Format(ObtenParametroPorLlave("FECHA_ERRONEA"), fechaHoraMinima.ToString("dd-MM-yyyy HH:mm"), fechaHoraMaxima.ToString("dd-MM-yyyy HH:mm")))
            Return
        End If

        CPDestino = ObtenValorTextbox(txtCpDestinoIntermedio)
        Dim regExpCp = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If CPDestino.Length <> 5 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return
        If Not Regex.IsMatch(CPDestino, regExpCp) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return

        noExtDestino = ObtenValorTextbox(txtNoExtDestinoIntermedio)
        If EsCadenaVacia(noExtDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NO_EXT")) : Return

        noIntDestino = ObtenValorTextbox(txtNoIntDestinoIntermedio)

        calleDestino = ObtenValorTextbox(txtCalleDestinoIntermedio)
        If EsCadenaVacia(calleDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CALLE")) : Return

        referenciaDestino = ObtenValorTextbox(txtReferenciaDestinoIntermedio)

        Dim kmRecorridos As Int32 = nupKmDestinoIntermedio.Value
        If kmRecorridos <= 0 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_KILOMETROS_RECORRIDOS")) : Return
        Dim kmDisponibles As Int32 = ObtenKilometrosDisponibles()
        If kmRecorridos > kmDisponibles Then AlertaMensaje(String.Format(ObtenParametroPorLlave("KILOMETROS_EXCEDEN"), kmDisponibles)) : Return


        Dim datosDestinoIntermedioEnModificacion As OrigenDestino

        'Veo si estamos actualizando o añadiendo
        If ESTA_CREANDO_DESTINO_INTERMEDIO Then
            datosDestinoIntermedioEnModificacion = New OrigenDestino
        ElseIf ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO Then
            datosDestinoIntermedioEnModificacion = datosDestinosIntermediosParaCartaPorte.FirstOrDefault(Function(f) f.IDUbicacion.Equals(idUbicacionDestInter))
        End If

        datosDestinoIntermedioEnModificacion.TipoUbicacion = tipoUbicacionDestInter
        datosDestinoIntermedioEnModificacion.RFCRemitenteDestinatario = rfcRemitenteDestInter
        datosDestinoIntermedioEnModificacion.IDUbicacion = idUbicacionDestInter
        datosDestinoIntermedioEnModificacion.EsPersonaFisica = ES_PERSONA_FISICA_DESTINO_INTERMEDIO
        datosDestinoIntermedioEnModificacion.EsPersonaMoral = ES_PERSONA_MORAL_DESTINO_INTERMEDIO
        datosDestinoIntermedioEnModificacion.EsExtranjero = ES_EXTRANJERO_DESTINO_INTERMEDIO
        datosDestinoIntermedioEnModificacion.Nombre = IIf(ES_PERSONA_MORAL_DESTINO_INTERMEDIO, String.Empty, nombreDestInter)
        datosDestinoIntermedioEnModificacion.ApPaterno = IIf(ES_PERSONA_MORAL_DESTINO_INTERMEDIO, String.Empty, apPaternoDestInter)
        datosDestinoIntermedioEnModificacion.ApMaterno = IIf(ES_PERSONA_MORAL_DESTINO_INTERMEDIO, String.Empty, apMaternoDestInter)
        datosDestinoIntermedioEnModificacion.NombrePersonaMoral = IIf(ES_PERSONA_MORAL_DESTINO_INTERMEDIO, nombreDestInter, String.Empty)
        datosDestinoIntermedioEnModificacion.ResidenciaFiscal = paisResidenciaDestFiscal
        datosDestinoIntermedioEnModificacion.NumRegIdTrib = numRegIdTribDestInter
        datosDestinoIntermedioEnModificacion.FechaSalidaLlegada = dtFechaLlegadaDestinoIntermedio.Value
        datosDestinoIntermedioEnModificacion.HoraSalidaLlegada = ObtenValorTextbox(txtHoraLlegadaDestinoIntermedio)
        datosDestinoIntermedioEnModificacion.DistanciaRecorrida = kmRecorridos
        datosDestinoIntermedioEnModificacion.EsDestinoIntermedio = True
        datosDestinoIntermedioEnModificacion.UsuarioCausoProblemasConKm = False
        datosDestinoIntermedioEnModificacion.UsuarioCausoProblemasConFecha = False

        Dim domicilio As New Domicilio
        domicilio.Calle = calleDestino
        domicilio.NumeroExterior = noExtDestino
        domicilio.NumeroInterior = noIntDestino
        domicilio.Colonia = coloniaDestino
        domicilio.Localidad = localidadDestino
        domicilio.Municipio = municipioDestino
        domicilio.Estado = estadoDestino
        domicilio.Pais = paisDestino
        domicilio.Referencia = referenciaDestino
        domicilio.CodigoPostal = CPDestino
        datosDestinoIntermedioEnModificacion.DatosDomicilio = domicilio

        If ESTA_CREANDO_DESTINO_INTERMEDIO Then
            datosDestinosIntermediosParaCartaPorte.Add(datosDestinoIntermedioEnModificacion)
        End If

        'Hemos terminado la validación
        INFORMACION_VALIDA_DESTINO_INTERMEDIO = True
        BindGridDestinosIntermedios()
        btnReiniciarDestinosIntermedios_Click(Nothing, Nothing)
    End Sub

    Private Function ObtenKilometrosDisponibles() As Int32
        Dim kmTotales As Int32 = datosDestinoParaCartaPorte.DistanciaRecorrida
        Dim kmConsumidosDeTotal As Int32 = 0
        Dim destInterEnMod As String = String.Empty
        If ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO Then
            destInterEnMod = ObtenValorTextbox(txtIdUbicacionDestinoIntermedio)
        End If
        If datosDestinosIntermediosParaCartaPorte.Count > 0 Then
            For Each lugar As OrigenDestino In datosDestinosIntermediosParaCartaPorte
                If lugar.IDUbicacion.Equals(destInterEnMod) Then Continue For
                kmConsumidosDeTotal = IIf(lugar.UsuarioCausoProblemasConKm, kmConsumidosDeTotal, kmConsumidosDeTotal + lugar.DistanciaRecorrida)
            Next
        Else
            Return kmTotales - 1
        End If
        'KmTotales-KmconsumidosDeTotal = Disponibles
        'Regreso si los disponibles son mayores o iguales al actual
        Return (kmTotales - kmConsumidosDeTotal - 1)
    End Function

    Private Sub rbEsPersonaFisicaDestinoIntermedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbEsPersonaFisicaDestinoIntermedio.CheckedChanged
        TogglePersonaMoralFisicaExtranjeroDestinoIntermedio()
    End Sub

    Private Sub rbEsPersonaMoralDestinoIntermedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbEsPersonaMoralDestinoIntermedio.CheckedChanged
        TogglePersonaMoralFisicaExtranjeroDestinoIntermedio()
    End Sub

    Private Sub rbEsExtranjeroDestinoIntermedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbEsExtranjeroDestinoIntermedio.CheckedChanged
        TogglePersonaMoralFisicaExtranjeroDestinoIntermedio()
    End Sub

    Private Sub cbPaisResidenciaFiscalDestinoIntermedio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisResidenciaFiscalDestinoIntermedio.SelectedValueChanged
        If ES_EXTRANJERO_DESTINO_INTERMEDIO Then
            If ObtenValorCombobox(cbPaisDestinoIntermedio) = "-01" Then Return
            txtPaisResidenciaFiscalDestinoIntermedio.Text = ObtenDescripcionPais(ObtenValorCombobox(cbPaisDestinoIntermedio))
        End If
    End Sub

    Private Sub cbPaisDestinoIntermedio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisDestinoIntermedio.SelectedValueChanged
        RealizaOperacionesSustitucionPaisesEstadoColonia(cbPaisDestinoIntermedio,
                                                        refCbEstadoDestinoIntermedio,
                                                        AddressOf cbEstadoDestinoIntermedio_SelectedValueChanged,
                                                        refCbMunicipioDestinoIntermedio,
                                                        AddressOf cbMunicipioDestinoIntermedio_SelectedValueChanged,
                                                        refCbLocalidadDestinoIntermedio,
                                                        AddressOf cbLocalidadDestinoIntermedio_SelectedValueChanged,
                                                        refCbColoniaDestinoIntermedio,
                                                        txtCpDestinoIntermedio,
                                                        txtEstadoDestinoIntermedio,
                                                        txtMunicipioDestinoIntermedio,
                                                        txtLocalidadDestinoIntermedio,
                                                        txtColoniaDestinoIntermedio,
                                                        tlpDetallesDestinoIntermedio)
    End Sub

    Private Sub cbEstadoDestinoIntermedio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEstadoDestinoIntermedio.SelectedValueChanged
        If ObtenValorCombobox(refCbEstadoDestinoIntermedio) = "-01" Then
            LimpiaDesactivaCombobox(refCbMunicipioDestinoIntermedio)
            LimpiaDesactivaCombobox(refCbLocalidadDestinoIntermedio)
            LimpiaDesactivaTextbox(txtCpDestinoIntermedio)
            LimpiaDesactivaCombobox(refCbColoniaDestinoIntermedio)
            Return
        End If

        ValidaOrdenMunicipioLocalidadCodigo(cbPaisDestinoIntermedio,
                                            refCbEstadoDestinoIntermedio,
                                            refCbLocalidadDestinoIntermedio,
                                            refCbMunicipioDestinoIntermedio,
                                            txtCpDestinoIntermedio,
                                            refCbColoniaDestinoIntermedio)

        If refCbMunicipioDestinoIntermedio IsNot Nothing And refCbLocalidadDestinoIntermedio IsNot Nothing Then
            BindCombobox(refCbMunicipioDestinoIntermedio, ObtenMunicipiosPorEstado(cbEstadoDestinoIntermedio.SelectedValue))
            BindCombobox(refCbLocalidadDestinoIntermedio, ObtenLocalidadesPorEstado(cbEstadoDestinoIntermedio.SelectedValue))
        End If
    End Sub

    Private Sub btnReiniciarDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnReiniciarDestinosIntermedios.Click
        BloqueaDestinoIntermedio()
        PreparaEntradaPestanaDestinoIntermedio()
        ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO = False
        ESTA_CREANDO_DESTINO_INTERMEDIO = True
        rbEsPersonaFisicaDestinoIntermedio.Checked = True
    End Sub

    Private Sub btnAtrasDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnAtrasDestinosIntermedios.Click
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
        If datosDestinosIntermediosParaCartaPorte.Count > 0 Then
            YA_AVISO_FECHA = False
            YA_AVISO_HORA = False
            YA_AVISO_KM = False
        End If
        TabControl1.SelectedTab = TabControl1.TabPages("tabDestino")
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
    End Sub
    Private Sub btnSiguienteDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnSiguienteDestinosIntermedios.Click
        'Primero tengo que ver si no hay problemas con las
        'fechas o los kilómetros de los destinos intermedios
        For Each destInter As OrigenDestino In datosDestinosIntermediosParaCartaPorte
            If destInter.UsuarioCausoProblemasConFecha Then
                AlertaMensaje(ObtenParametroPorLlave("FECHAS_PEND"))
                Return
            End If
            If destInter.UsuarioCausoProblemasConKm Then
                AlertaMensaje(ObtenParametroPorLlave("KM_PEND"))
                Return
            End If
        Next

        If (Not ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO) And (Not ESTA_CREANDO_DESTINO_INTERMEDIO) Then
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
            TabControl1.SelectedTab = TabControl1.TabPages("tabMercancias")
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
        End If

        If ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO Then
            Dim rsult = MsgBox(ObtenParametroPorLlave("DEST_INTER_MODIFICACION"), vbQuestion + vbYesNo, "Alerta")
            If rsult = MsgBoxResult.No Then Return
        ElseIf ESTA_CREANDO_DESTINO_INTERMEDIO Then
            Dim rsult = MsgBox(ObtenParametroPorLlave("DEST_INTER_CREACION"), vbQuestion + vbYesNo, "Alerta")
            If rsult = MsgBoxResult.No Then Return
        End If
        btnGuardarDestinosIntermedios_Click(Nothing, Nothing)
        If INFORMACION_VALIDA_DESTINO_INTERMEDIO Then
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
            TabControl1.SelectedTab = TabControl1.TabPages("tabMercancias")
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
        End If
    End Sub

    Private Sub btnGuardarDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnGuardarDestinosIntermedios.Click
        ValidarDatosDestinoIntermedio()
        If INFORMACION_VALIDA_DESTINO_INTERMEDIO Then
            btnLimpiarDestinosIntermedios_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub dgvCartaPorteDestinosIntermedios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCartaPorteDestinosIntermedios.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim indiceBotonVer As Int32 = dgvCartaPorteDestinosIntermedios.Columns.IndexOf(dgvCartaPorteDestinosIntermedios.Columns("DIVerClm"))
        Dim indiceBotonEliminar As Int32 = dgvCartaPorteDestinosIntermedios.Columns.IndexOf(dgvCartaPorteDestinosIntermedios.Columns("DIEliminarClm"))
        If e.ColumnIndex = indiceBotonVer Then
            Dim idUbicacion As String = dgvCartaPorteDestinosIntermedios.Rows(e.RowIndex).Cells("IDUbicacionClm").Value
            CargaDatosDestinoIntermedio(idUbicacion)
        ElseIf e.ColumnIndex = indiceBotonEliminar Then
            Dim idUbicacion As String = dgvCartaPorteDestinosIntermedios.Rows(e.RowIndex).Cells("IDUbicacionClm").Value
            Dim resp = MsgBox(ObtenParametroPorLlave("ELIMINAR_DEST_INTER"), vbQuestion + vbYesNo, "Alerta")
            If resp = MsgBoxResult.No Then Return
            EliminaMercanciasDestino(idUbicacion)
            EliminaDestinoIntermedio(idUbicacion)
        End If
    End Sub

    Private Sub CargaDatosDestinoIntermedio(ByVal idUbicacion As String)
        btnReiniciarDestinosIntermedios_Click(Nothing, Nothing)
        ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO = True
        ESTA_CREANDO_DESTINO_INTERMEDIO = False
        Dim objDestino As OrigenDestino = datosDestinosIntermediosParaCartaPorte.FirstOrDefault(Function(x) x.IDUbicacion.Equals(idUbicacion))
        If objDestino IsNot Nothing Then
            txtTipoUbicacionDestinoIntermedio.Text = "Destino"
            txtIdUbicacionDestinoIntermedio.Enabled = False
            txtIdUbicacionDestinoIntermedio.Text = objDestino.IDUbicacion
            rbEsPersonaFisicaDestinoIntermedio.Checked = objDestino.EsPersonaFisica
            rbEsPersonaMoralDestinoIntermedio.Checked = objDestino.EsPersonaMoral
            rbEsExtranjeroDestinoIntermedio.Checked = objDestino.EsExtranjero
            ES_PERSONA_FISICA_DESTINO_INTERMEDIO = rbEsPersonaFisicaDestinoIntermedio.Checked
            ES_PERSONA_MORAL_DESTINO_INTERMEDIO = rbEsPersonaMoralDestinoIntermedio.Checked
            ES_EXTRANJERO_DESTINO_INTERMEDIO = rbEsExtranjeroDestinoIntermedio.Checked

            'Primero cargo los detalles de la ubicación
            If ES_PERSONA_FISICA_DESTINO_INTERMEDIO Then
                txtRfcDestinoIntermedio.Text = objDestino.RFCRemitenteDestinatario
                txtNombreDestinoIntermedio.Text = objDestino.Nombre
                txtApPaternoDestinoIntermedio.Text = objDestino.ApPaterno
                txtApMaternoDestinoIntermedio.Text = objDestino.ApMaterno
            ElseIf ES_PERSONA_MORAL_DESTINO_INTERMEDIO Then
                txtRfcDestinoIntermedio.Text = objDestino.RFCRemitenteDestinatario
                txtNombreDestinoIntermedio.Text = objDestino.NombrePersonaMoral
                txtApPaternoDestinoIntermedio.Text = String.Empty
                txtApMaternoDestinoIntermedio.Text = String.Empty
            ElseIf ES_EXTRANJERO_DESTINO_INTERMEDIO Then
                txtRfcDestinoIntermedio.Text = ObtenParametroPorLlave("RFC_GENERICO_EXTRANJERO")
                txtNombreDestinoIntermedio.Text = objDestino.Nombre
                txtApPaternoDestinoIntermedio.Text = objDestino.ApPaterno
                txtApMaternoDestinoIntermedio.Text = objDestino.ApMaterno
                txtNumregIdTribDestinoIntermedio.Text = objDestino.NumRegIdTrib
                BindCombobox(cbPaisResidenciaFiscalDestinoIntermedio, ObtenListadoPaises())
                cbPaisResidenciaFiscalDestinoIntermedio.SelectedValue = objDestino.ResidenciaFiscal
            End If

            Dim fechaSalidaOrigen As DateTime
            Dim fechaLlegadaMax As DateTime
            ObtenMaximosMinimosFecha(fechaSalidaOrigen, fechaLlegadaMax)
            dtFechaLlegadaDestinoIntermedio.MinDate = fechaSalidaOrigen.Date
            dtFechaLlegadaDestinoIntermedio.MaxDate = fechaLlegadaMax.Date
            lblFechaHoraMaximaDestInter.Text = String.Format(ObtenParametroPorLlave("AVISO_FECHAS"), fechaSalidaOrigen.ToString("dd-MM-yyyy HH:mm"), fechaLlegadaMax.ToString("dd-MM-yyyy HH:mm"))
            lblFechaHoraMaximaDestInter.ForeColor = Color.Red

            If objDestino.UsuarioCausoProblemasConFecha Then
                dtFechaLlegadaDestinoIntermedio.Value = dtFechaLlegadaDestinoIntermedio.MinDate
                txtHoraLlegadaDestinoIntermedio.Text = String.Empty
            Else
                dtFechaLlegadaDestinoIntermedio.Value = objDestino.FechaSalidaLlegada
                txtHoraLlegadaDestinoIntermedio.Text = objDestino.HoraSalidaLlegada
            End If

            nupKmDestinoIntermedio.Minimum = 0
            nupKmDestinoIntermedio.Maximum = datosDestinoParaCartaPorte.DistanciaRecorrida

            If objDestino.UsuarioCausoProblemasConKm Then
                nupKmDestinoIntermedio.Value = 0
            Else
                nupKmDestinoIntermedio.Value = objDestino.DistanciaRecorrida
            End If


            'Ahora a cargar los detalles del domicilio
            'Si no es extranjero, no hay ninguna bronca
            Dim datosDomicilio As Domicilio = objDestino.DatosDomicilio
            If Not ES_EXTRANJERO_DESTINO_INTERMEDIO Then
                BindCombobox(cbPaisDestinoIntermedio, ObtenListadoPaises())
                cbPaisDestinoIntermedio.SelectedValue = datosDomicilio.Pais
                cbPaisDestinoIntermedio.Enabled = False
                cbEstadoDestinoIntermedio.SelectedValue = datosDomicilio.Estado
                cbEstadoDestinoIntermedio.Enabled = True
                cbMunicipioDestinoIntermedio.SelectedValue = datosDomicilio.Municipio
                cbMunicipioDestinoIntermedio.Enabled = True
                cbLocalidadDestinoIntermedio.SelectedValue = datosDomicilio.Localidad
                cbLocalidadDestinoIntermedio.Enabled = True
                txtCpDestinoIntermedio.Text = datosDomicilio.CodigoPostal
                txtCpDestinoIntermedio.Enabled = True
                refCbColoniaDestinoIntermedio.SelectedValue = datosDomicilio.Colonia
                cbColoniaDestinoIntermedio.Enabled = True
                txtNoExtDestinoIntermedio.Text = datosDomicilio.NumeroExterior
                txtNoExtDestinoIntermedio.Enabled = True
                txtNoIntDestinoIntermedio.Text = datosDomicilio.NumeroInterior
                txtNoIntDestinoIntermedio.Enabled = True
                txtCalleDestinoIntermedio.Text = datosDomicilio.Calle
                txtCalleDestinoIntermedio.Enabled = True
                txtReferenciaDestinoIntermedio.Text = datosDomicilio.Referencia
                txtReferenciaDestinoIntermedio.Enabled = True
            Else
                BindCombobox(cbPaisDestinoIntermedio, ObtenListadoPaises())
                cbPaisDestinoIntermedio.SelectedValue = datosDomicilio.Pais
                cbPaisDestinoIntermedio.Enabled = True

                'Ahora tengo que cargar la info dependiendo de donde esté
                'Estado
                If refCbEstadoDestinoIntermedio IsNot Nothing Then
                    refCbEstadoDestinoIntermedio.SelectedValue = datosDomicilio.Estado
                Else
                    txtEstadoDestinoIntermedio.Text = datosDomicilio.Calle
                End If

                'Municipio
                If refCbMunicipioDestinoIntermedio IsNot Nothing Then
                    refCbMunicipioDestinoIntermedio.SelectedValue = datosDomicilio.Municipio
                Else
                    txtMunicipioDestinoIntermedio.Text = datosDomicilio.Municipio
                End If

                'Localidad
                If refCbLocalidadDestinoIntermedio IsNot Nothing Then
                    refCbLocalidadDestinoIntermedio.SelectedValue = datosDomicilio.Localidad
                Else
                    txtLocalidadDestinoIntermedio.Text = datosDomicilio.Localidad
                End If

                'Colonia
                If refCbColoniaDestinoIntermedio IsNot Nothing Then
                    refCbColoniaDestinoIntermedio.SelectedValue = datosDomicilio.Colonia
                Else
                    txtColoniaDestinoIntermedio.Text = datosDomicilio.Colonia
                End If

                txtCpDestino.Text = datosDomicilio.CodigoPostal
                txtColoniaDestinoIntermedio.Text = datosDomicilio.Colonia
                txtCalleDestinoIntermedio.Text = datosDomicilio.Calle
                txtReferenciaDestinoIntermedio.Text = datosDomicilio.Referencia
            End If
        End If
    End Sub

    Private Sub EliminaDestinoIntermedio(ByVal idUbicacion As String)
        Dim objDestino As OrigenDestino = datosDestinosIntermediosParaCartaPorte.FirstOrDefault(Function(x) x.IDUbicacion.Equals(idUbicacion))
        If idUbicacion = ObtenValorTextbox(txtIdUbicacionDestinoIntermedio) Then
            btnLimpiarDestinosIntermedios_Click(Nothing, Nothing)
        End If
        If objDestino IsNot Nothing Then
            datosDestinosIntermediosParaCartaPorte.Remove(objDestino)
        End If
        BindGridDestinosIntermedios()
    End Sub

    Private Sub txtCpDestinoIntermedio_TextChanged(sender As Object, e As EventArgs) Handles txtCpDestinoIntermedio.TextChanged
        RealizaCargaValidacionCodigoCargaColonias(refCbEstadoDestinoIntermedio, refCbMunicipioDestinoIntermedio, refCbLocalidadDestinoIntermedio, refCbColoniaDestinoIntermedio, txtCpDestinoIntermedio)
    End Sub

    Private Sub btnLimpiarDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnLimpiarDestinosIntermedios.Click
        BloqueaDestinoIntermedio()
        ESTA_CREANDO_DESTINO_INTERMEDIO = False
        ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO = False
    End Sub

    Private Sub nupKmDestinoIntermedio_ValueChanged(sender As Object, e As EventArgs) Handles nupKmDestinoIntermedio.ValueChanged
        If nupKmDestinoIntermedio.Value > nupKmDestinoIntermedio.Maximum Then
            AlertaMensaje("ERROR: EL VALOR MÁXIMO DE KILOMETROS ES " + ObtenKilometrosDisponibles())
            Return
            nupKmDestinoIntermedio.Value = 0
        End If
    End Sub
#End Region

#Region "Datos de las mercancías"
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE MERCANCIAS
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private ESTA_CREANDO_MERCANCIA As Boolean = False
    Private ESTA_MODIFICANDO_MERCANCIA As Boolean = False
    Private EXISTE_MERCANCIA_MATERIAL_PELIGROSO As Boolean = False
    Private INFORMACION_VALIDA_MERCANCIA As Boolean = False
    Private PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION As String = String.Empty

    Private Function ObtenMercanciasPorMovimiento(ByVal idMovimiento As String) As List(Of Mercancia)
        If Not datosMercancias.ContainsKey(idMovimiento) Then
            datosMercancias.Add(idMovimiento, New List(Of Mercancia))
        ElseIf datosMercancias(idMovimiento) Is Nothing Then
            datosMercancias(idMovimiento) = New List(Of Mercancia)
        End If
        Return datosMercancias(idMovimiento)
    End Function

    Private Sub EliminaMercanciasDestino(ByRef idMovimiento As String)
        If datosMercancias Is Nothing Then Return
        If Not datosMercancias.ContainsKey(idMovimiento) Then Return
        datosMercancias.Remove(idMovimiento)
    End Sub

    Private Function ObtenMercancia(ByVal idMovimiento As String,
                                   ByVal claveProdServ As String,
                                   ByVal claveUnidad As String,
                                   ByVal esPeligroso As Boolean) As Mercancia
        Return ObtenMercanciasPorMovimiento(idMovimiento).FirstOrDefault(Function(m) m.ClaveProdServ.Equals(claveProdServ) And m.ClaveUnidad.Equals(claveUnidad) And m.MaterialPeligroso = esPeligroso)
    End Function

    Private Function ObtenMercancia(ByRef listaABuscar As List(Of Mercancia),
                                   ByVal claveProdServ As String,
                                   ByVal claveUnidad As String,
                                   ByVal esPeligroso As Boolean) As Mercancia
        Return listaABuscar.FirstOrDefault(Function(m) m.ClaveProdServ.Equals(claveProdServ) And m.ClaveUnidad.Equals(claveUnidad) And m.MaterialPeligroso = esPeligroso)
    End Function

    Private Sub EliminaMercanciaDeMovimiento(ByVal idMovimiento As String,
                                             ByVal claveProdServ As String,
                                             ByVal claveUnidad As String,
                                             ByVal esPeligroso As Boolean)
        Dim resp = MsgBox(ObtenParametroPorLlave("ELIMINAR_MERCANCIA"), vbQuestion + vbYesNo, "Alerta")
        If resp = MsgBoxResult.Yes Then
            ObtenMercanciasPorMovimiento(idMovimiento).Remove(ObtenMercancia(idMovimiento, claveProdServ, claveUnidad, esPeligroso))
            BindGridDetalleMercanciasPorMovimiento(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
            LimpiaPanelInformacionMercancias()
        End If
    End Sub

    Private Sub PreparaPestanaMercancias()
        If datosMercancias Is Nothing Then
            datosMercancias = New Dictionary(Of String, List(Of Mercancia))
        End If
        PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION = String.Empty
        LimpiaGrid(dgvListadoMovimientosPestanaMercancia)
        LimpiaGrid(dgvMercanciasPorMovimiento)
        LimpiaPanelInformacionMercancias()
        RecargaLabelGridMercancias(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
        BindGridMovimientosMercancias()
    End Sub

    Private Sub LimpiaPanelInformacionMercancias()
        BindCombobox(cbOpcionDimensiones, conexionesCartaPorte.Get_ObtenPosiblesDimensiones())
        LimpiaDesactivaTextbox(txtClaveProdServMercancia)
        LimpiaDesactivaTextbox(txtDescripcionProducto)
        LimpiaDesactivaTextbox(txtCantidadMercancia)
        LimpiaDesactivaTextbox(txtUnidadClaveMercancia)
        LimpiaDesactivaTextbox(txtUnidadMercancia)
        LimpiaDesactivaTextbox(txtMoneda)
        LimpiaDesactivaTextbox(txtValor)
        LimpiaDesactivaTextbox(txtPeso)

        numAnchura.Value = 0
        numAnchura.Enabled = False
        numAnchura.Minimum = 0
        numAnchura.Maximum = Int16.MaxValue

        numAltura.Enabled = False
        numAltura.Value = 0
        numAltura.Minimum = 0
        numAnchura.Maximum = Int16.MaxValue

        numLongitud.Enabled = False
        numLongitud.Value = 0
        numLongitud.Minimum = 0
        numLongitud.Maximum = Int16.MaxValue

        rbNoMaterialPeligroso.Checked = True
        rbSiMaterialPeligroso.Enabled = True
        rbNoMaterialPeligroso.Enabled = True

        LimpiaDesactivaTextbox(txtClaveMaterialPeligroso)
        LimpiaDesactivaTextbox(txtDescripcionMaterialPeligroso)
        LimpiaDesactivaTextbox(txtEmbalaje)
        LimpiaDesactivaTextbox(txtDescripcionEmbalaje)
        LimpiaDesactivaTextbox(txtFraccionArancelaria)
        LimpiaDesactivaTextbox(txtMoneda)

        txtMoneda.Text = "MXN"
        txtPedimento.Enabled = False
        rbComercioInternacionalNo.Checked = True
        rbComercioInternacionalSi.Enabled = True
        rbComercioInternacionalNo.Enabled = True
    End Sub

    Private Sub HabilitaEdicionPanelMercancias()
        BindCombobox(cbOpcionDimensiones, conexionesCartaPorte.Get_ObtenPosiblesDimensiones())
        cbOpcionDimensiones.SelectedValue = "-01"
        txtClaveProdServMercancia.Enabled = True
        txtCantidadMercancia.Enabled = True
        txtUnidadClaveMercancia.Enabled = True
        txtPeso.Enabled = True
        txtValor.Enabled = True
        txtMoneda.Enabled = True
        txtMoneda.Text = "MXN"
        numAnchura.Enabled = True
        numAltura.Enabled = True
        numLongitud.Enabled = True
        rbSiMaterialPeligroso.Enabled = True
        rbNoMaterialPeligroso.Enabled = True
        rbComercioInternacionalNo.Enabled = True
        rbComercioInternacionalSi.Enabled = True
    End Sub

    Private Sub BindGridMovimientosMercancias()
        Dim listaTodosLosMovimientos As List(Of OrigenDestino)
        If datosDestinosIntermediosParaCartaPorte.Count = 0 Then
            listaTodosLosMovimientos = New List(Of OrigenDestino)
            listaTodosLosMovimientos.Add(datosDestinoParaCartaPorte)
        Else
            listaTodosLosMovimientos = datosDestinosIntermediosParaCartaPorte.OrderBy(Of DateTime)(Function(x) x.FechaHora).ToList
            listaTodosLosMovimientos.Insert(0, datosDestinoParaCartaPorte)
        End If

        dgvListadoMovimientosPestanaMercancia.AutoGenerateColumns = False
        dgvListadoMovimientosPestanaMercancia.Columns("MovimientoMercanciaClm").DataPropertyName = NameOf(OrigenDestino.IDUbicacion)
        dgvListadoMovimientosPestanaMercancia.Columns("DestinoMercanciaClm").DataPropertyName = NameOf(OrigenDestino.DestinoDesplegado)
        dgvListadoMovimientosPestanaMercancia.Columns("MovimientosTipoMovimientoClm").DataPropertyName = NameOf(OrigenDestino.TipoMovimiento)
        dgvListadoMovimientosPestanaMercancia.Columns("IdUbicacionMovimientoPestanaMercanciaClm").DataPropertyName = NameOf(OrigenDestino.IDUbicacion)

        dgvListadoMovimientosPestanaMercancia.DataSource = listaTodosLosMovimientos
    End Sub

    Private Sub BindGridDetalleMercanciasPorMovimiento(ByRef idMovimiento As String)
        LimpiaGrid(dgvMercanciasPorMovimiento)
        Dim mercanciasMovimiento = ObtenMercanciasPorMovimiento(idMovimiento)
        dgvMercanciasPorMovimiento.AutoGenerateColumns = False
        dgvMercanciasPorMovimiento.Columns("MercanciaClaveProdServClm").DataPropertyName = NameOf(Mercancia.ClaveProdServ)
        dgvMercanciasPorMovimiento.Columns("MovimientoDescripcionClm").DataPropertyName = NameOf(Mercancia.Descripcion)
        dgvMercanciasPorMovimiento.Columns("MercanciaMovimientoPeligrosaClm").DataPropertyName = NameOf(Mercancia.EsMaterialPeligrosoCad)
        dgvMercanciasPorMovimiento.Columns("MercanciaCantidadMercClm").DataPropertyName = NameOf(Mercancia.Cantidad)
        dgvMercanciasPorMovimiento.Columns("MovimientoComercioIntClm").DataPropertyName = NameOf(Mercancia.EsComercioInternacionalCad)
        dgvMercanciasPorMovimiento.Columns("ClaveUnidadClm").DataPropertyName = NameOf(Mercancia.ClaveUnidad)
        dgvMercanciasPorMovimiento.Columns("DescripcionUnidadClm").DataPropertyName = NameOf(Mercancia.Unidad)
        dgvMercanciasPorMovimiento.Columns("MovimientoMercanciaCheckboxMaterialCheckboxClm").DataPropertyName = NameOf(Mercancia.MaterialPeligroso)
        dgvMercanciasPorMovimiento.DataSource = mercanciasMovimiento
        Dim rows = dgvMercanciasPorMovimiento.Rows.Count
    End Sub

    Private Sub dgvListadoMovimientosPestanaMercancia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoMovimientosPestanaMercancia.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If
        Dim columnaVerDetalle As Int32 = dgvListadoMovimientosPestanaMercancia.Columns.IndexOf(dgvListadoMovimientosPestanaMercancia.Columns("MercanciasBtnClm"))
        Dim columnaAnadirMercancia As Int32 = dgvListadoMovimientosPestanaMercancia.Columns.IndexOf(dgvListadoMovimientosPestanaMercancia.Columns("AnadirMercanciaMovimientoClm"))
        Dim columnaIdUbicacion As Int32 = dgvListadoMovimientosPestanaMercancia.Columns.IndexOf(dgvListadoMovimientosPestanaMercancia.Columns("IdUbicacionMovimientoPestanaMercanciaClm"))
        Dim idUbicacion As String = dgvListadoMovimientosPestanaMercancia.Rows(e.RowIndex).Cells(columnaIdUbicacion).Value
        PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION = idUbicacion
        LimpiaPanelInformacionMercancias()
        If e.ColumnIndex = columnaVerDetalle Then
            ESTA_MODIFICANDO_MERCANCIA = False
            ESTA_CREANDO_MERCANCIA = False
            BindGridDetalleMercanciasPorMovimiento(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
        ElseIf e.ColumnIndex = columnaAnadirMercancia Then
            HabilitaEdicionPanelMercancias()
            ESTA_MODIFICANDO_MERCANCIA = False
            ESTA_CREANDO_MERCANCIA = True
        End If
        RecargaLabelGridMercancias(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
    End Sub

    Private Sub RecargaLabelGridMercancias(ByRef idMovimiento As String)
        If String.IsNullOrEmpty(idMovimiento) Then
            Label69.Text = "No se ha seleccionado ningún movimiento"
            Return
        End If
        Dim listMerc = ObtenMercanciasPorMovimiento(idMovimiento)
        If listMerc.Count = 0 Then
            Label69.Text = "Movimiento " + PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION + "(No hay mercancías capturadas)"
        Else
            Label69.Text = "Mercancías del movimiento " + PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION
        End If
    End Sub

    Private Sub ToggleComercioInternacional()
        If Not ESTA_CREANDO_MERCANCIA And Not ESTA_MODIFICANDO_MERCANCIA Then Return
        If rbComercioInternacionalSi.Checked Then
            MarcaCampoComoObligatorio(txtFraccionArancelaria, tlpDetallesMercancia)
            MarcaCampoComoObligatorio(txtPedimento, tlpDetallesMercancia)
            txtFraccionArancelaria.Enabled = True
            txtPedimento.Enabled = True
            If ESTA_CREANDO_MERCANCIA Then
                txtPedimento.Text = String.Empty
                txtFraccionArancelaria.Text = String.Empty
            Else
                Dim merc = ObtenMercancia(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION, txtClaveProdServMercancia.Text, ObtenValorTextbox(txtUnidadClaveMercancia), rbSiMaterialPeligroso.Checked)
                txtPedimento.Text = merc.Pedimento
                txtFraccionArancelaria.Text = merc.FraccionArancelaria
            End If
        ElseIf rbComercioInternacionalNo.Checked Then
            MarcaCampoComoOpcional(txtPedimento, tlpDetallesMercancia)
            MarcaCampoComoOpcional(txtFraccionArancelaria, tlpDetallesMercancia)
            txtPedimento.Text = String.Empty
            txtPedimento.Enabled = False
            LimpiaDesactivaTextbox(txtFraccionArancelaria)
        End If
    End Sub

    Private Sub ToggleMaterialPeligroso()
        If Not ESTA_CREANDO_MERCANCIA And Not ESTA_MODIFICANDO_MERCANCIA Then Return
        If rbNoMaterialPeligroso.Checked Then
            LimpiaDesactivaTextbox(txtClaveMaterialPeligroso)
            LimpiaDesactivaTextbox(txtDescripcionMaterialPeligroso)
            LimpiaDesactivaTextbox(txtEmbalaje)
            LimpiaDesactivaTextbox(txtDescripcionEmbalaje)

            MarcaCampoComoOpcional(txtClaveMaterialPeligroso, tlpDetallesMercancia)
            MarcaCampoComoOpcional(txtDescripcionMaterialPeligroso, tlpDetallesMercancia)
            MarcaCampoComoOpcional(txtEmbalaje, tlpDetallesMercancia)
            MarcaCampoComoOpcional(txtDescripcionEmbalaje, tlpDetallesMercancia)
        ElseIf rbSiMaterialPeligroso.Checked Then
            txtDescripcionMaterialPeligroso.Enabled = True
            txtClaveMaterialPeligroso.Enabled = True
            txtEmbalaje.Enabled = True
            txtDescripcionEmbalaje.Enabled = True

            Dim merc = ObtenMercancia(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION, txtClaveProdServMercancia.Text, ObtenValorTextbox(txtUnidadClaveMercancia), rbSiMaterialPeligroso.Checked)
            MarcaCampoComoObligatorio(txtClaveMaterialPeligroso, tlpDetallesMercancia)
            MarcaCampoComoObligatorio(txtDescripcionMaterialPeligroso, tlpDetallesMercancia)
            MarcaCampoComoObligatorio(txtEmbalaje, tlpDetallesMercancia)
            MarcaCampoComoObligatorio(txtDescripcionEmbalaje, tlpDetallesMercancia)

            If ESTA_MODIFICANDO_MERCANCIA Then
                txtDescripcionMaterialPeligroso.Text = merc.DescripcionMaterialPeligroso
                txtClaveMaterialPeligroso.Text = merc.ClaveMaterialPeligroso
                txtEmbalaje.Text = merc.Embalaje
                txtDescripcionEmbalaje.Text = merc.DescripcionEmbalaje
            End If
        End If
    End Sub

    Private Sub AplicaValidacionesSatMaterialPeligroso(ByRef requiereNodo As Boolean,
                                                       ByRef marcadaComoPeligrosa As Boolean,
                                                       Optional ByRef mercancia As Mercancia = Nothing)
        If Not requiereNodo And Not marcadaComoPeligrosa Then
            rbSiMaterialPeligroso.Checked = False
            rbNoMaterialPeligroso.Checked = True
            rbSiMaterialPeligroso.Enabled = False
            rbNoMaterialPeligroso.Enabled = False
        ElseIf requiereNodo And Not marcadaComoPeligrosa Then
            rbSiMaterialPeligroso.Enabled = True
            rbNoMaterialPeligroso.Enabled = True
            If mercancia Is Nothing Then
                rbSiMaterialPeligroso.Checked = False
                rbNoMaterialPeligroso.Checked = True
            Else
                rbSiMaterialPeligroso.Checked = mercancia.MaterialPeligroso
                rbNoMaterialPeligroso.Checked = Not mercancia.MaterialPeligroso
            End If
        ElseIf requiereNodo And marcadaComoPeligrosa Then
            rbSiMaterialPeligroso.Enabled = True
            rbNoMaterialPeligroso.Enabled = False
            rbSiMaterialPeligroso.Checked = True
        End If
    End Sub

    Private Sub CargaDetallesMercancia(ByRef mercancia As Mercancia)
        txtClaveProdServMercancia.Text = mercancia.ClaveProdServ
        txtClaveProdServMercancia.Enabled = False

        Dim descripcionProducto As String = String.Empty
        Dim requiereNodoMercPeligroso As Boolean = False
        Dim satMarcaPeligroso As Boolean = False
        conexionesCartaPorte.Get_ObtenDescripcionPorClaveProdServ(mercancia.ClaveProdServ, descripcionProducto, requiereNodoMercPeligroso, satMarcaPeligroso)

        txtCantidadMercancia.Text = mercancia.Cantidad.ToString
        txtUnidadClaveMercancia.Text = mercancia.ClaveUnidad
        txtUnidadMercancia.Text = conexionesCartaPorte.Get_ClaveUnidadPeso(mercancia.ClaveUnidad)

        txtDescripcionProducto.Text = descripcionProducto
        AplicaValidacionesSatMaterialPeligroso(requiereNodoMercPeligroso,
                                                satMarcaPeligroso,
                                                mercancia)

        txtPeso.Text = mercancia.PesoEnKg.ToString
        txtValor.Text = mercancia.ValorMercancia.ToString
        txtMoneda.Text = mercancia.Moneda
        numAltura.Value = mercancia.Altura
        numAnchura.Value = mercancia.Anchura
        numLongitud.Value = mercancia.Longitud
        If mercancia.EsCentimetros Then
            cbOpcionDimensiones.SelectedValue = "cm"
        ElseIf mercancia.EsPulgadas Then
            cbOpcionDimensiones.SelectedValue = "plg"
        Else
            cbOpcionDimensiones.SelectedValue = "-01"
        End If

        If mercancia.MaterialPeligroso Then
            rbSiMaterialPeligroso.Checked = True
            txtClaveMaterialPeligroso.Text = mercancia.ClaveMaterialPeligroso
            txtClaveMaterialPeligroso_TextChanged(Nothing, Nothing)
            txtClaveMaterialPeligroso.Enabled = True

            txtEmbalaje.Text = mercancia.Embalaje
            txtEmbalaje.Enabled = True
            txtEmbalaje_TextChanged(Nothing, Nothing)
        Else
            rbNoMaterialPeligroso.Checked = True
        End If

        If mercancia.EsComercioInternacional Then
            rbComercioInternacionalSi.Checked = True
            txtPedimento.Text = mercancia.Pedimento
            txtPedimento.Enabled = True
            txtFraccionArancelaria.Text = mercancia.FraccionArancelaria
            txtFraccionArancelaria.Enabled = True
        Else
            rbComercioInternacionalNo.Checked = True
        End If
        ESTA_MODIFICANDO_MERCANCIA = True
        ESTA_CREANDO_MERCANCIA = False
    End Sub

    Private Sub rbSiMaterialPeligroso_CheckedChanged(sender As Object, e As EventArgs) Handles rbSiMaterialPeligroso.CheckedChanged
        ToggleMaterialPeligroso()
    End Sub

    Private Sub rbNoMaterialPeligroso_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoMaterialPeligroso.CheckedChanged
        ToggleMaterialPeligroso()
    End Sub

    Private Sub rbComercioInternacionalSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbComercioInternacionalSi.CheckedChanged
        ToggleComercioInternacional()
    End Sub

    Private Sub rbComercioInternacionalNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbComercioInternacionalNo.CheckedChanged
        ToggleComercioInternacional()
    End Sub

    Private Sub txtClaveProdServMercancia_DoubleClick(sender As Object, e As EventArgs) Handles txtClaveProdServMercancia.DoubleClick
        Dim formaBusqueda As New frmBusqueda(AddressOf conexionesCartaPorte.Get_DetalleClaveProdServ)
        esperandoBusqueda = txtClaveProdServMercancia
        AddHandler formaBusqueda.ElementoSeleccionado, AddressOf AtrapaEvento
        formaBusqueda.ShowDialog()
    End Sub

    Private Sub txtUnidadClaveMercancia_DoubleClick(sender As Object, e As EventArgs) Handles txtUnidadClaveMercancia.DoubleClick
        Dim formaBusqueda As New frmBusqueda(AddressOf conexionesCartaPorte.Get_DetalleClaveUnidad)
        esperandoBusqueda = txtUnidadClaveMercancia
        AddHandler formaBusqueda.ElementoSeleccionado, AddressOf AtrapaEvento
        formaBusqueda.ShowDialog()
    End Sub

    Private Sub txtMoneda_DoubleClick(sender As Object, e As EventArgs) Handles txtMoneda.DoubleClick
        Dim formaBusqueda As New frmBusqueda(AddressOf conexionesCartaPorte.Get_DetalleMoneda)
        esperandoBusqueda = txtMoneda
        AddHandler formaBusqueda.ElementoSeleccionado, AddressOf AtrapaEvento
        formaBusqueda.ShowDialog()
    End Sub

    Private Sub txtClaveMaterialPeligroso_DoubleClick(sender As Object, e As EventArgs) Handles txtClaveMaterialPeligroso.DoubleClick
        Dim formaBusqueda As New frmBusqueda(AddressOf conexionesCartaPorte.Get_DetalleMaterialPeligroso)
        esperandoBusqueda = txtClaveMaterialPeligroso
        AddHandler formaBusqueda.ElementoSeleccionado, AddressOf AtrapaEvento
        AddHandler formaBusqueda.ElementoSeleccionado, AddressOf AtrapaEvento
        formaBusqueda.ShowDialog()
    End Sub

    Private Sub txtEmbalaje_DoubleClick(sender As Object, e As EventArgs) Handles txtEmbalaje.DoubleClick
        Dim formaBusqueda As New frmBusqueda(AddressOf conexionesCartaPorte.Get_DetalleEmbalaje)
        esperandoBusqueda = txtEmbalaje
        AddHandler formaBusqueda.ElementoSeleccionado, AddressOf AtrapaEvento
        formaBusqueda.ShowDialog()
    End Sub

    Private Sub txtClaveProdServMercancia_TextChanged(sender As Object, e As EventArgs) Handles txtClaveProdServMercancia.TextChanged
        txtDescripcionProducto.Enabled = False
        Dim longitudClaveProdServ As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_CLAVE_PROD_SERV"))
        Dim regExpClaveProdServ As String = ObtenParametroPorLlave("REGEXP_CLAVE_PROD_SERV")
        Dim claveProdServ As String = ObtenValorTextbox(txtClaveProdServMercancia)
        If claveProdServ.Length <> longitudClaveProdServ Then Return
        If Not Regex.IsMatch(claveProdServ, regExpClaveProdServ) Then Return

        Dim descripcionProducto As String = String.Empty
        Dim requiereNodoMercPeligroso As Boolean = False
        Dim satMarcaPeligroso As Boolean = False
        conexionesCartaPorte.Get_ObtenDescripcionPorClaveProdServ(claveProdServ, descripcionProducto, requiereNodoMercPeligroso, satMarcaPeligroso)

        txtDescripcionProducto.Text = descripcionProducto
        AplicaValidacionesSatMaterialPeligroso(requiereNodoMercPeligroso,
                                                satMarcaPeligroso)
    End Sub

    Private Sub txtUnidadClaveMercancia_TextChanged(sender As Object, e As EventArgs) Handles txtUnidadClaveMercancia.TextChanged
        txtUnidadMercancia.Enabled = False
        txtUnidadMercancia.Text = String.Empty
        Dim claveUnidad As String = ObtenValorTextbox(txtUnidadClaveMercancia)
        If EsCadenaVacia(claveUnidad) Then Return
        txtUnidadMercancia.Text = conexionesCartaPorte.Get_ClaveUnidadPeso(claveUnidad)
    End Sub

    Private Sub txtClaveMaterialPeligroso_TextChanged(sender As Object, e As EventArgs) Handles txtClaveMaterialPeligroso.TextChanged
        LimpiaDesactivaTextbox(txtDescripcionMaterialPeligroso)
        Dim claveMatPeligroso As String = ObtenValorTextbox(txtClaveMaterialPeligroso)
        Dim matPeligroso As String = conexionesCartaPorte.Get_ObtenDescripcionMaterialPeligroso(claveMatPeligroso)
        txtDescripcionMaterialPeligroso.Text = matPeligroso
    End Sub

    Private Sub txtEmbalaje_TextChanged(sender As Object, e As EventArgs) Handles txtEmbalaje.TextChanged
        LimpiaDesactivaTextbox(txtDescripcionEmbalaje)
        Dim claveEmbalaje As String = ObtenValorTextbox(txtEmbalaje)
        Dim descEmbalaje As String = conexionesCartaPorte.Get_ObtenDescripcionEmbalaje(claveEmbalaje)
        txtDescripcionEmbalaje.Text = descEmbalaje
    End Sub

    Private Sub txtClaveProdServMercancia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClaveProdServMercancia.KeyDown
        AbreSiEsEnter(e, AddressOf txtClaveProdServMercancia_DoubleClick)
    End Sub

    Private Sub txtUnidadClaveMercancia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnidadClaveMercancia.KeyDown
        AbreSiEsEnter(e, AddressOf txtUnidadClaveMercancia_DoubleClick)
    End Sub

    Private Sub txtMoneda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMoneda.KeyDown
        AbreSiEsEnter(e, AddressOf txtMoneda_DoubleClick)
    End Sub

    Private Sub txtClaveMaterialPeligroso_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClaveMaterialPeligroso.KeyDown
        AbreSiEsEnter(e, AddressOf txtClaveMaterialPeligroso_DoubleClick)
    End Sub

    Private Sub txtEmbalaje_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmbalaje.KeyDown
        AbreSiEsEnter(e, AddressOf txtEmbalaje_DoubleClick)
    End Sub

    Private Sub ValidarInformacionMercancia()
        INFORMACION_VALIDA_MERCANCIA = False
        Dim claveProdServ As String = String.Empty
        Dim descripcionProducto As String = String.Empty
        Dim cantidadMercancia As String = String.Empty
        Dim claveUnidad As String = String.Empty
        Dim descripcionUnidad As String = String.Empty
        Dim peso As String = String.Empty
        Dim valor As String = String.Empty
        Dim moneda As String = String.Empty
        Dim anchura As Int32 = 0
        Dim altura As Int32 = 0
        Dim longitud As Int32 = 0
        Dim medidaDimension As String = String.Empty
        Dim materialPeligroso As Boolean = False
        Dim claveMaterialPeligroso As String = String.Empty
        Dim descripcionMaterialPeligroso As String = String.Empty
        Dim embalaje As String = String.Empty
        Dim descripcionEmbalaje As String = String.Empty
        Dim comercioInternacional As Boolean = False
        Dim pedimento As String = String.Empty
        Dim fraccionArancelaria As String = String.Empty

        'Validación de la clave prod serv
        Dim longitudClaveProdServ As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_CLAVE_PROD_SERV"))
        claveProdServ = ObtenValorTextbox(txtClaveProdServMercancia)
        If claveProdServ.Length <> longitudClaveProdServ Then AlertaMensaje(ObtenParametroPorLlave("CLAVE_PROD_SERV_NOVALIDA")) : Return
        Dim regExpClaveProdServ As String = ObtenParametroPorLlave("REGEXP_CLAVE_PROD_SERV")
        If Not Regex.IsMatch(claveProdServ, regExpClaveProdServ) Then AlertaMensaje(ObtenParametroPorLlave("CLAVE_PROD_SERV_NOVALIDA")) : Return

        cantidadMercancia = ObtenValorTextbox(txtCantidadMercancia)
        Dim regExpNumeroDecimal As String = ObtenParametroPorLlave("REGEXP_NUMERO_DECIMAL")
        If Not Regex.IsMatch(cantidadMercancia, regExpNumeroDecimal) Then
            Dim mensaje = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS")
            AlertaMensaje(String.Format(mensaje, "CANTIDAD"))
            Return
        End If

        If CInt(cantidadMercancia) = 0 Then AlertaMensaje(ObtenParametroPorLlave("CANTIDAD_ERRONEA")) : Return

        claveUnidad = ObtenValorTextbox(txtUnidadClaveMercancia)
        If EsCadenaVacia(claveUnidad) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CLAVE_UNIDAD")) : Return

        descripcionUnidad = conexionesCartaPorte.Get_ClaveUnidadPeso(claveUnidad)
        If EsCadenaVacia(descripcionUnidad) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CLAVE_UNIDAD")) : Return
        txtUnidadMercancia.Text = UCase(descripcionUnidad)

        peso = ObtenValorTextbox(txtPeso)
        If Not Regex.IsMatch(peso, regExpNumeroDecimal) Then
            Dim mensaje = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS")
            AlertaMensaje(String.Format(mensaje, "PESO"))
            Return
        End If

        If CInt(peso) <= 0 Then AlertaMensaje(ObtenParametroPorLlave("PESO_ERRONEO")) : Return

        valor = ObtenValorTextbox(txtValor)
        If Not Regex.IsMatch(valor, regExpNumeroDecimal) Then
            Dim mensaje = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS")
            AlertaMensaje(String.Format(mensaje, "VALOR"))
            Return
        End If

        moneda = ObtenValorTextbox(txtMoneda)
        Dim descpMoneda As String = conexionesCartaPorte.Get_DescripcionMoneda(moneda)
        If EsCadenaVacia(descripcionUnidad) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MONEDA")) : Return

        If rbSiMaterialPeligroso.Checked Then
            materialPeligroso = True
            claveMaterialPeligroso = ObtenValorTextbox(txtClaveMaterialPeligroso)
            embalaje = ObtenValorTextbox(txtEmbalaje)
            descripcionMaterialPeligroso = ObtenValorTextbox(txtDescripcionMaterialPeligroso)
            descripcionEmbalaje = ObtenValorTextbox(txtDescripcionEmbalaje)
            If EsCadenaVacia(descripcionMaterialPeligroso) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CMP")) : Return
            If EsCadenaVacia(descripcionEmbalaje) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CEMB")) : Return
        Else
            materialPeligroso = False
        End If

        If rbComercioInternacionalSi.Checked Then
            comercioInternacional = True
            pedimento = txtPedimento.Text
            fraccionArancelaria = ObtenValorTextbox(txtFraccionArancelaria)
            If EsCadenaVacia(pedimento) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PEDIMENTO")) : Return
        Else
            comercioInternacional = False
        End If

        Dim mercanciaEnModificacion As Mercancia

        If ESTA_MODIFICANDO_MERCANCIA Then
            mercanciaEnModificacion = ObtenMercancia(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION, ObtenValorTextbox(txtClaveProdServMercancia), ObtenValorTextbox(txtUnidadClaveMercancia), rbSiMaterialPeligroso.Checked)
        Else
            mercanciaEnModificacion = New Mercancia
        End If

        mercanciaEnModificacion.ClaveProdServ = claveProdServ

        Dim requiereNodoMercPeligroso As Boolean = False
        Dim satMarcaPeligroso As Boolean = False
        conexionesCartaPorte.Get_ObtenDescripcionPorClaveProdServ(claveProdServ, descripcionProducto, requiereNodoMercPeligroso, satMarcaPeligroso)
        mercanciaEnModificacion.Descripcion = descripcionProducto
        mercanciaEnModificacion.RequiereNodoMaterialPeligroso = requiereNodoMercPeligroso
        mercanciaEnModificacion.SatConsideraPeligrosa = satMarcaPeligroso

        mercanciaEnModificacion.Cantidad = CInt(cantidadMercancia)
        mercanciaEnModificacion.ClaveUnidad = claveUnidad
        mercanciaEnModificacion.Unidad = descripcionUnidad
        mercanciaEnModificacion.EsCentimetros = cbOpcionDimensiones.SelectedValue.Equals("cm")
        mercanciaEnModificacion.EsPulgadas = cbOpcionDimensiones.SelectedValue.Equals("plg")
        mercanciaEnModificacion.Longitud = numLongitud.Value
        mercanciaEnModificacion.Anchura = numAnchura.Value
        mercanciaEnModificacion.Altura = numAltura.Value

        mercanciaEnModificacion.MaterialPeligroso = rbSiMaterialPeligroso.Checked
        mercanciaEnModificacion.ClaveMaterialPeligroso = claveMaterialPeligroso
        mercanciaEnModificacion.Embalaje = embalaje
        mercanciaEnModificacion.DescripcionEmbalaje = descripcionEmbalaje

        mercanciaEnModificacion.PesoEnKg = Double.Parse(peso)
        mercanciaEnModificacion.ValorMercancia = Double.Parse(valor)
        mercanciaEnModificacion.Moneda = moneda

        mercanciaEnModificacion.EsComercioInternacional = rbComercioInternacionalSi.Checked
        mercanciaEnModificacion.Pedimento = pedimento
        mercanciaEnModificacion.FraccionArancelaria = fraccionArancelaria

        If ESTA_CREANDO_MERCANCIA Then

            If ObtenMercancia(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION, claveProdServ, claveUnidad, rbSiMaterialPeligroso.Checked) IsNot Nothing Then
                Dim resp = MsgBox(ObtenParametroPorLlave("POSIBLE_CHOQUE"), vbQuestion + vbYesNo, "Alerta")
                If resp = MsgBoxResult.No Then
                    Return
                Else
                    Dim mercTemporal As Mercancia = ObtenMercancia(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION, claveProdServ, claveUnidad, rbSiMaterialPeligroso.Checked)
                    mercTemporal.Cantidad = mercTemporal.Cantidad + CInt(cantidadMercancia)
                    BindGridDetalleMercanciasPorMovimiento(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
                    LimpiaPanelInformacionMercancias()
                    RecargaLabelGridMercancias(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
                    INFORMACION_VALIDA_MERCANCIA = True
                    Return
                End If
            End If

            Dim listMerc As List(Of Mercancia) = ObtenMercanciasPorMovimiento(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
            listMerc.Add(mercanciaEnModificacion)
        End If
        ESTA_CREANDO_MERCANCIA = False
        ESTA_MODIFICANDO_MERCANCIA = False
        BindGridDetalleMercanciasPorMovimiento(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
        LimpiaPanelInformacionMercancias()
        RecargaLabelGridMercancias(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
        INFORMACION_VALIDA_MERCANCIA = True
    End Sub

    Private Sub btnGuardarMercancia_Click(sender As Object, e As EventArgs) Handles btnGuardarMercancia.Click
        ValidarInformacionMercancia()
    End Sub

    Private Sub btnSiguienteMercancia_Click(sender As Object, e As EventArgs) Handles btnSiguienteMercancia.Click
        Dim totalMercancias As Int32 = 0
        For Each key As String In datosMercancias.Keys
            totalMercancias = totalMercancias + datosMercancias(key).Count
        Next
        If totalMercancias = 0 Then
            AlertaMensaje(ObtenParametroPorLlave("NO_HAY_MERCANCIAS"))
            Return
        End If

        If ESTA_CREANDO_MERCANCIA Or ESTA_MODIFICANDO_MERCANCIA Then
            Dim resp = MsgBox(ObtenParametroPorLlave("MERCANCIA_EN_MODIFICACION"), vbQuestion + vbYesNo, "Alerta")
            If resp = MsgBoxResult.No Then Return

            ValidarInformacionMercancia()
            If INFORMACION_VALIDA_MERCANCIA Then
                ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
                TabControl1.SelectedTab = TabControl1.TabPages("tabTransporte")
                ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
            End If
        End If

        ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
    End Sub

    Private Sub btnAtrasMercancia_Click(sender As Object, e As EventArgs) Handles btnAtrasMercancia.Click
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
        TabControl1.SelectedTab = TabControl1.TabPages("tabDestinosIntermedios")
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
    End Sub

    Private Sub dgvMercanciasPorMovimiento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMercanciasPorMovimiento.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim claveProdServ As String = dgvMercanciasPorMovimiento.Rows(e.RowIndex).Cells("MercanciaClaveProdServClm").Value
        Dim indiceDetalles As Int32 = dgvMercanciasPorMovimiento.Columns().IndexOf(dgvMercanciasPorMovimiento.Columns("MovimientoDetallesMercClm"))
        Dim indiceEliminar As Int32 = dgvMercanciasPorMovimiento.Columns().IndexOf(dgvMercanciasPorMovimiento.Columns("MovimientoMercanciaEliminarClm"))
        Dim claveUnidad As String = dgvMercanciasPorMovimiento.Rows(e.RowIndex).Cells("ClaveUnidadClm").Value
        Dim esPeligroso As Boolean = dgvMercanciasPorMovimiento.Rows(e.RowIndex).Cells("MercanciaMovimientoPeligrosaClm").Value.ToString.ToUpper().Equals("SI")
        If e.ColumnIndex = indiceDetalles Then
            Dim mercancia As Mercancia = ObtenMercancia(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION, claveProdServ, claveUnidad, esPeligroso)
            LimpiaPanelInformacionMercancias()
            HabilitaEdicionPanelMercancias()
            ESTA_CREANDO_MERCANCIA = False
            ESTA_MODIFICANDO_MERCANCIA = True
            CargaDetallesMercancia(mercancia)
        ElseIf e.ColumnIndex = indiceEliminar Then
            ESTA_CREANDO_MERCANCIA = False
            ESTA_MODIFICANDO_MERCANCIA = False
            EliminaMercanciaDeMovimiento(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION, claveProdServ, claveUnidad, esPeligroso)
            RecargaLabelGridMercancias(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
        End If
    End Sub

    Private Sub btnLimpiarMercancia_Click(sender As Object, e As EventArgs) Handles btnLimpiarMercancia.Click
        ESTA_MODIFICANDO_MERCANCIA = False
        ESTA_CREANDO_MERCANCIA = False
        LimpiaPanelInformacionMercancias()
        LimpiaGrid(dgvMercanciasPorMovimiento)
        PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION = String.Empty
        RecargaLabelGridMercancias(PESTANA_MERCANCIAS_ID_MOVIMIENTO_EN_MODIFICACION)
        ESTA_MODIFICANDO_MERCANCIA = False
        ESTA_CREANDO_MERCANCIA = False
    End Sub
#End Region

#Region "Datos del transporte"
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE VEHÍCULO DE TRANSPORTE
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private PARTE_DEL_REMOLQUE_ES_AJENA As Boolean = False
    Private INFORMACION_VALIDA_TRANSPORTE As Boolean = False

    Private Sub PreparaPestanaTransporte()
        ValidaExisteMercanciaQueCuenteComoPeligroso()
        BindCombobox(cbSeleccionarVehiculo, conexionesCartaPorte.Get_ListadoVehiculos())
        BloqueaDatosTransporte()
        numCantidadRemolquesTransporte.Minimum = 0
        numCantidadRemolquesTransporte.Maximum = 2
        CargaDatosTransporte()
    End Sub

    Private Sub cbSeleccionarVehiculo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbSeleccionarVehiculo.SelectedValueChanged
        Dim cveVehiculo As String = ObtenValorCombobox(cbSeleccionarVehiculo)
        If cveVehiculo = "-01" Then
            BloqueaDatosTransporte()
            Return
        End If

        LimpiarPanelDatosTransporte()
        If cveVehiculo <> "00" Then
            CargaDatosTransporte()
        End If
    End Sub

    Private Sub CargaDatosTransporte()
        If datosAutoTransporte IsNot Nothing Then
            cbSeleccionarVehiculo.SelectedValue = datosAutoTransporte.CveInternaVehiculo
            txtTipoPermisoSCT.Text = datosAutoTransporte.PermSCT
            txtNumPermisoSCT.Text = datosAutoTransporte.NumPermisoSCT
            txtConVeh.Text = datosAutoTransporte.ConfigVehicular
            txtPlacaTransporte.Text = datosAutoTransporte.PlacaVM
            txtAnioModeloTransporte.Text = datosAutoTransporte.AnioModeloVM
            txtAseguradoraTransporte.Text = datosAutoTransporte.AseguraRespCivil
            txtPolizaTransporte.Text = datosAutoTransporte.PolizaRespCivil
            txtPrimaSeguroTransporte.Text = datosAutoTransporte.PrimaSeguro.ToString()
            txtAseguradoraCargaTransporte.Text = datosAutoTransporte.AseguraCarga
            txtPolizaCargaTransporte.Text = datosAutoTransporte.PolizaCarga

            'Cargo la información de los remolques
            Dim noRemolques As Int16 = datosAutoTransporte.NoRemolques
            numCantidadRemolquesTransporte.Value = noRemolques
            numCantidadRemolquesTransporte_ValueChanged(Nothing, Nothing)
            Dim refRemolque As Remolque
            If noRemolques >= 1 Then
                refRemolque = datosAutoTransporte.Remolques(0)
                cbPropiedadRemolque1.SelectedValue = refRemolque.PropiedadRemolque
                txtPlacasRemolque1.Text = refRemolque.Placa
                cbTipoRemolque1.SelectedValue = refRemolque.SubTipoRem
            End If
            If noRemolques = 2 Then
                refRemolque = datosAutoTransporte.Remolques(1)
                cbPropiedadRemolque2.SelectedValue = refRemolque.PropiedadRemolque
                txtPlacasRemolque2.Text = refRemolque.Placa
                cbTipoRemolque2.SelectedValue = refRemolque.SubTipoRem
            End If

            txtAseguradoraDanosMedioAmbiente.Text = datosAutoTransporte.AseguraMedAmbiente
            txtPolizaSegurosDanosMedioAmbiente.Text = datosAutoTransporte.PolizaMedAmbiente
        End If
    End Sub

    Private Sub ValidaExisteMercanciaQueCuenteComoPeligroso()
        EXISTE_MERCANCIA_MATERIAL_PELIGROSO = False
        For Each key As String In datosMercancias.Keys
            Dim listMerc As List(Of Mercancia) = ObtenMercanciasPorMovimiento(key)
            listMerc.ForEach(Sub(m) EXISTE_MERCANCIA_MATERIAL_PELIGROSO = EXISTE_MERCANCIA_MATERIAL_PELIGROSO Or m.MaterialPeligroso)
            If EXISTE_MERCANCIA_MATERIAL_PELIGROSO Then
                Exit For
            End If
        Next

        If EXISTE_MERCANCIA_MATERIAL_PELIGROSO Then
            MarcaCampoComoObligatorio(txtAseguradoraDanosMedioAmbiente, tlpContenedorSeguroMaterialPeligroso)
            MarcaCampoComoObligatorio(txtPolizaSegurosDanosMedioAmbiente, tlpContenedorSeguroMaterialPeligroso)
        Else
            MarcaCampoComoOpcional(txtAseguradoraDanosMedioAmbiente, tlpContenedorSeguroMaterialPeligroso)
            MarcaCampoComoOpcional(txtPolizaSegurosDanosMedioAmbiente, tlpContenedorSeguroMaterialPeligroso)
        End If
    End Sub

    Private Sub BloqueaDatosTransporte()
        PARTE_DEL_REMOLQUE_ES_AJENA = False
        INFORMACION_VALIDA_TRANSPORTE = False
        LimpiaDesactivaTextbox(txtTipoPermisoSCT)
        LimpiaDesactivaTextbox(txtNumPermisoSCT)
        LimpiaDesactivaTextbox(txtConVeh)
        LimpiaDesactivaTextbox(txtDescripConfigVehicular)
        LimpiaDesactivaTextbox(txtPlacaTransporte)
        LimpiaDesactivaTextbox(txtAnioModeloTransporte)
        LimpiaDesactivaTextbox(txtAseguradoraTransporte)
        LimpiaDesactivaTextbox(txtAseguradoraCargaTransporte)
        LimpiaDesactivaTextbox(txtPolizaCargaTransporte)
        LimpiaDesactivaTextbox(txtPrimaSeguroTransporte)
        LimpiaDesactivaTextbox(txtPrimaSeguroTransporte)
        numCantidadRemolquesTransporte.Value = 0
        numCantidadRemolquesTransporte.Enabled = False
        numCantidadRemolquesTransporte_ValueChanged(Nothing, Nothing)
        LimpiaDesactivaTextbox(txtAseguradoraDanosMedioAmbiente)
        LimpiaDesactivaTextbox(txtPolizaSegurosDanosMedioAmbiente)
    End Sub

    Private Sub LimpiarPanelDatosTransporte()
        PARTE_DEL_REMOLQUE_ES_AJENA = False
        INFORMACION_VALIDA_TRANSPORTE = False
        LimpiaDesactivaTextbox(txtTipoPermisoSCT)
        txtTipoPermisoSCT.Enabled = True
        txtNumPermisoSCT.Text = String.Empty
        txtNumPermisoSCT.Enabled = True
        LimpiaDesactivaTextbox(txtConVeh)
        txtConVeh.Enabled = True
        txtDescripConfigVehicular.Text = String.Empty
        txtDescripConfigVehicular.Enabled = True
        txtPlacaTransporte.Text = String.Empty
        txtPlacaTransporte.Enabled = True
        txtAnioModeloTransporte.Text = String.Empty
        txtAnioModeloTransporte.Enabled = True
        txtAseguradoraTransporte.Text = String.Empty
        txtAseguradoraTransporte.Enabled = True
        txtAseguradoraCargaTransporte.Text = String.Empty
        txtAseguradoraCargaTransporte.Enabled = True
        txtPolizaCargaTransporte.Text = String.Empty
        txtPolizaCargaTransporte.Enabled = True
        txtPrimaSeguroTransporte.Text = String.Empty
        txtPrimaSeguroTransporte.Enabled = True
        numCantidadRemolquesTransporte.Value = 0
        numCantidadRemolquesTransporte_ValueChanged(Nothing, Nothing)
        numCantidadRemolquesTransporte.Enabled = True
        txtAseguradoraDanosMedioAmbiente.Enabled = True
        txtPolizaSegurosDanosMedioAmbiente.Enabled = True
        ValidaExisteMercanciaQueCuenteComoPeligroso()
        If EXISTE_MERCANCIA_MATERIAL_PELIGROSO Then
            MarcaCampoComoObligatorio(txtAseguradoraDanosMedioAmbiente, tlpContenedorSeguroMaterialPeligroso)
            MarcaCampoComoObligatorio(txtPolizaSegurosDanosMedioAmbiente, tlpContenedorSeguroMaterialPeligroso)
        End If
    End Sub

    Private Sub TogglePartesTransporte()
        MarcaCampoComoOpcional(cbPropiedadRemolque1, tlpContenedorRemolques)
        MarcaCampoComoOpcional(cbPropiedadRemolque2, tlpContenedorRemolques)
        MarcaCampoComoOpcional(cbTipoRemolque1, tlpContenedorRemolques)
        MarcaCampoComoOpcional(cbTipoRemolque2, tlpContenedorRemolques)
        MarcaCampoComoOpcional(txtTipoRemolque1, tlpContenedorRemolques)
        MarcaCampoComoOpcional(txtTipoRemolque2, tlpContenedorRemolques)
        MarcaCampoComoOpcional(txtPlacasRemolque1, tlpContenedorRemolques)
        MarcaCampoComoOpcional(txtPlacasRemolque2, tlpContenedorRemolques)

        If numCantidadRemolquesTransporte.Value = 0 Then
            LimpiaDesactivaCombobox(cbPropiedadRemolque1)
            LimpiaDesactivaCombobox(cbPropiedadRemolque2)
            LimpiaDesactivaCombobox(cbTipoRemolque1)
            LimpiaDesactivaCombobox(cbTipoRemolque2)
            LimpiaDesactivaTextbox(txtTipoRemolque1)
            LimpiaDesactivaTextbox(txtTipoRemolque2)
            LimpiaDesactivaTextbox(txtPlacasRemolque1)
            LimpiaDesactivaTextbox(txtPlacasRemolque2)
        ElseIf numCantidadRemolquesTransporte.Value >= 1 Then
            BindCombobox(cbPropiedadRemolque1, conexionesCartaPorte.Get_OpcionesPropiedadTransporte())
            BindCombobox(cbTipoRemolque1, conexionesCartaPorte.Get_ObtenPosiblesTiposRemolque())
            LimpiaDesactivaTextbox(txtTipoRemolque1)
            txtPlacasRemolque1.Enabled = True
            LimpiaDesactivaCombobox(cbPropiedadRemolque2)
            LimpiaDesactivaCombobox(cbTipoRemolque2)
            LimpiaDesactivaTextbox(txtTipoRemolque2)
            LimpiaDesactivaTextbox(txtPlacasRemolque2)

            MarcaCampoComoObligatorio(cbPropiedadRemolque1, tlpContenedorRemolques)
            MarcaCampoComoObligatorio(cbTipoRemolque1, tlpContenedorRemolques)
            MarcaCampoComoObligatorio(txtTipoRemolque1, tlpContenedorRemolques)
            MarcaCampoComoObligatorio(txtPlacasRemolque1, tlpContenedorRemolques)
        End If
        If numCantidadRemolquesTransporte.Value = 2 Then
            BindCombobox(cbPropiedadRemolque2, conexionesCartaPorte.Get_OpcionesPropiedadTransporte())
            BindCombobox(cbTipoRemolque2, conexionesCartaPorte.Get_ObtenPosiblesTiposRemolque())
            txtPlacasRemolque1.Enabled = True
            txtPlacasRemolque2.Enabled = True
            LimpiaDesactivaTextbox(txtTipoRemolque2)

            MarcaCampoComoObligatorio(cbPropiedadRemolque2, tlpContenedorRemolques)
            MarcaCampoComoObligatorio(cbTipoRemolque2, tlpContenedorRemolques)
            MarcaCampoComoObligatorio(txtTipoRemolque2, tlpContenedorRemolques)
            MarcaCampoComoObligatorio(txtPlacasRemolque2, tlpContenedorRemolques)
        End If
    End Sub

    Private Sub numCantidadRemolquesTransporte_ValueChanged(sender As Object, e As EventArgs) Handles numCantidadRemolquesTransporte.ValueChanged
        TogglePartesTransporte()
    End Sub

    Private Sub CargaTipoRemolque(ByVal numeroRemolque As Int32)
        Dim text As TextBox = IIf(numeroRemolque = 1, txtTipoRemolque1, txtTipoRemolque2)
        Dim combo As ComboBox = IIf(numeroRemolque = 1, cbTipoRemolque1, cbTipoRemolque2)
        If ObtenValorCombobox(combo) = "-01" Then Return
        text.Text = conexionesCartaPorte.Get_ObtenDescripcionPorTipoSubRemolque(ObtenValorCombobox(combo))
        text.Enabled = False
    End Sub

    Private Sub cbTipoRemolque1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTipoRemolque1.SelectedValueChanged
        CargaTipoRemolque(1)
    End Sub

    Private Sub cbTipoRemolque2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTipoRemolque2.SelectedValueChanged
        CargaTipoRemolque(2)
    End Sub

    Private Sub ValidaPropiedadAjena()
        If numCantidadRemolquesTransporte.Value = 0 Then
            PARTE_DEL_REMOLQUE_ES_AJENA = False
        ElseIf numCantidadRemolquesTransporte.Value = 1 Then
            PARTE_DEL_REMOLQUE_ES_AJENA = cbPropiedadRemolque1.Equals("RE")
        ElseIf numCantidadRemolquesTransporte.Value = 2 Then
            PARTE_DEL_REMOLQUE_ES_AJENA = (cbPropiedadRemolque1.Equals("RE") Or cbPropiedadRemolque2.Equals("RE"))
        End If
    End Sub

    Private Sub cbPropiedadRemolque1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPropiedadRemolque1.SelectedValueChanged
        ValidaPropiedadAjena()
    End Sub

    Private Sub cbPropiedadRemolque2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPropiedadRemolque2.SelectedValueChanged
        ValidaPropiedadAjena()
    End Sub

    Private Sub ValidaDatosTransporte()
        INFORMACION_VALIDA_TRANSPORTE = False
        datosAutoTransporte = New Autotransporte
        Dim claveInternaVehiculo As String = String.Empty
        Dim tipoPermisoSct As String = String.Empty
        Dim numPermisoSct As String = String.Empty
        Dim configVehicular As String = String.Empty
        Dim placa As String = String.Empty
        Dim anioModelo As String = String.Empty
        Dim aseguraRespCivil As String = String.Empty
        Dim polizaRespCivil As String = String.Empty
        Dim aseguradoraCarga As String = String.Empty
        Dim polizaCarga As String = String.Empty
        Dim primaSeguro As Double = 0.0D
        Dim noRemolques As Int16 = 0
        Dim aseguradoraMedioAmbiente As String = String.Empty
        Dim polizaMedioAmbiente As String = String.Empty

        If ObtenValorCombobox(cbSeleccionarVehiculo) = "-01" Then AlertaMensaje(ObtenParametroPorLlave("ES_NECESARIO_VEHICULO")) : Return
        If EsCadenaVacia(ObtenValorTextbox(txtDescripcionTipoPermisoSCT)) = "-01" Then AlertaMensaje(ObtenParametroPorLlave("ES_NECESARIO_TIPO_PERMISO")) : Return
        If EsCadenaVacia(ObtenValorTextbox(txtDescripConfigVehicular)) = "-01" Then AlertaMensaje(ObtenParametroPorLlave("ES_NECESARIO_CONFIG_VEHICULAR")) : Return
        claveInternaVehiculo = ObtenValorCombobox(cbSeleccionarVehiculo)
        tipoPermisoSct = ObtenValorTextbox(txtTipoPermisoSCT)
        numPermisoSct = ObtenValorTextbox(txtNumPermisoSCT)

        If EsCadenaVacia(numPermisoSct) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NUMPERM")) : Return

        configVehicular = ObtenValorTextbox(txtConVeh)
        placa = ObtenValorTextbox(txtPlacaTransporte).Replace("-", "").Replace(" ", "")
        If EsCadenaVacia(placa) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PLACA")) : Return

        anioModelo = ObtenValorTextbox(txtAnioModeloTransporte)
        If Not Regex.IsMatch(anioModelo, ObtenParametroPorLlave("REGEXP_CADENA_SOLO_NUMEROS")) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ANIO_MODELO")) : Return
        aseguraRespCivil = ObtenValorTextbox(txtAseguradoraTransporte)
        polizaRespCivil = ObtenValorTextbox(txtPolizaTransporte)

        aseguradoraCarga = ObtenValorTextbox(txtAseguradoraCargaTransporte)
        polizaCarga = ObtenValorTextbox(txtPolizaCargaTransporte)

        'No es necesaria la prima, pero si al ingresa, debo de verificar que sea un número decimal válido
        If Not EsCadenaVacia(txtPrimaSeguroTransporte.Text) Then
            If Not Double.TryParse(txtPrimaSeguroTransporte.Text, primaSeguro) Then AlertaMensaje(ObtenParametroPorLlave("PRIMA_SEGURO_INCORRECTA")) : Return
        End If

        noRemolques = numCantidadRemolquesTransporte.Value
        Dim remolques As List(Of Remolque) = Nothing

        'Validación de remolques
        If noRemolques >= 1 Then
            If cbPropiedadRemolque1.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PROPIEDAD_1")) : Return
            Dim remolque1 As Remolque = New Remolque
            remolque1.PropiedadRemolque = ObtenValorCombobox(cbPropiedadRemolque1)
            remolque1.SubTipoRem = cbTipoRemolque1.SelectedValue
            If remolque1.SubTipoRem = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_TIPO_REMOLQUE_1")) : Return
            remolque1.Placa = ObtenValorTextbox(txtPlacasRemolque1).Replace("-", "").Replace(" ", "")
            If EsCadenaVacia(remolque1.Placa) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PLACA_1")) : Return
            remolques = New List(Of Remolque)
            remolques.Add(remolque1)
        End If

        If noRemolques = 2 Then
            If cbPropiedadRemolque2.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PROPIEDAD_2")) : Return
            Dim remolque2 As Remolque = New Remolque
            remolque2.PropiedadRemolque = ObtenValorCombobox(cbPropiedadRemolque2)
            remolque2.SubTipoRem = cbTipoRemolque1.SelectedValue
            If remolque2.SubTipoRem = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_TIPO_REMOLQUE_2")) : Return
            remolque2.Placa = ObtenValorTextbox(txtPlacasRemolque1).Replace("-", "").Replace(" ", "")
            If EsCadenaVacia(remolque2.Placa) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PLACA_2")) : Return
            remolques.Add(remolque2)
        End If

        'Validación de material peligroso
        ValidaExisteMercanciaQueCuenteComoPeligroso()
        If EXISTE_MERCANCIA_MATERIAL_PELIGROSO Then
            aseguradoraMedioAmbiente = ObtenValorTextbox(txtAseguradoraDanosMedioAmbiente)
            If EsCadenaVacia(aseguradoraMedioAmbiente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MEDIO_AMBIENTE")) : Return
            polizaMedioAmbiente = ObtenValorTextbox(txtPolizaSegurosDanosMedioAmbiente)
            If EsCadenaVacia(polizaMedioAmbiente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_P_MEDIO_AMBIENTE")) : Return
        End If

        datosAutoTransporte.CveInternaVehiculo = claveInternaVehiculo
        datosAutoTransporte.PermSCT = tipoPermisoSct
        datosAutoTransporte.NumPermisoSCT = numPermisoSct
        datosAutoTransporte.ConfigVehicular = configVehicular
        datosAutoTransporte.PlacaVM = placa
        datosAutoTransporte.AnioModeloVM = anioModelo
        datosAutoTransporte.AseguraRespCivil = aseguraRespCivil
        datosAutoTransporte.PolizaRespCivil = polizaRespCivil
        datosAutoTransporte.PrimaSeguro = primaSeguro
        datosAutoTransporte.AseguraCarga = aseguradoraCarga
        datosAutoTransporte.PolizaCarga = polizaCarga
        datosAutoTransporte.NoRemolques = noRemolques
        datosAutoTransporte.Remolques = remolques
        datosAutoTransporte.AseguraMedAmbiente = aseguradoraMedioAmbiente
        datosAutoTransporte.PolizaMedAmbiente = polizaMedioAmbiente
        INFORMACION_VALIDA_TRANSPORTE = True
    End Sub

    Private Sub cbTipoPermisoSCT_SelectedValueChanged(sender As Object, e As EventArgs)
        'If ObtenValorCombobox(cbTipoPermisoSCT) = "-01" Then
        '    LimpiaDesactivaTextbox(txtNumPermisoSCT)
        '    Return
        'End If
        'txtNumPermisoSCT.Enabled = True
        'If cbTipoPermisoSCT.SelectedValue = "TPXX00" Then
        '    'txtNumPermisoSCT.Text = String.Empty
        'End If
    End Sub

    Private Sub cbOpcionesConfigVehicular_SelectedValueChanged(sender As Object, e As EventArgs)
        'Dim configVehicular As String = ObtenValorCombobox(cbOpcionesConfigVehicular)
        'If configVehicular = "-01" Then
        '    LimpiaDesactivaTextbox(txtDescripConfigVehicular)
        '    Return
        'End If
        'txtDescripConfigVehicular.Enabled = False
        'txtDescripConfigVehicular.Text = conexionesCartaPorte.Get_ObtenDescripcionConfiguracionAutoTransporte(configVehicular)
    End Sub

    Private Sub btnSiguienteTransporte_Click(sender As Object, e As EventArgs) Handles btnSiguienteTransporte.Click
        ValidaDatosTransporte()
        If INFORMACION_VALIDA_TRANSPORTE Then
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
            TabControl1.SelectedTab = TabControl1.TabPages("tabOperador")
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
        End If
    End Sub

    Private Sub btnAtrasTransporte_Click(sender As Object, e As EventArgs) Handles btnAtrasTransporte.Click
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
        TabControl1.SelectedTab = TabControl1.TabPages("tabMercancias")
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
    End Sub
#End Region

#Region "Datos del operador"
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DEL OPERADOR
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private INFORMACION_VALIDA_OPERADOR As Boolean = False
    Private txtEstadoOperador As TextBox = Nothing
    Private txtLocalidadOperador As TextBox = Nothing
    Private txtMunicipioOperador As TextBox = Nothing
    Private txtColoniaOperador As TextBox = Nothing

    Private refCbEstadoOperador As ComboBox = Nothing
    Private refCbMunicipioOperador As ComboBox = Nothing
    Private refCbLocalidadOperador As ComboBox = Nothing
    Private refCbColoniaOperador As ComboBox = Nothing

    Private listaParteTransporte As List(Of ItemTransporte)

    Private Sub cbMunicipioOperador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbMunicipioOperador.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisOperador,
                                            refCbEstadoOperador,
                                            refCbLocalidadOperador,
                                            refCbMunicipioOperador,
                                            txtCpOperador,
                                            refCbColoniaOperador)
    End Sub

    Private Sub cbLocalidadOperador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbLocalidadOperador.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisOperador,
                                            refCbEstadoOperador,
                                            refCbLocalidadOperador,
                                            refCbMunicipioOperador,
                                            txtCpOperador,
                                            refCbColoniaOperador)
    End Sub

    Private Sub PreparaDatosOperador()
        BindCombobox(cbOpcionesOperador, conexionesCartaPorte.Get_CatalogoOperadores())
        BloqueaDatosOperador()
    End Sub

    Private Sub BloqueaDatosOperador()
        INFORMACION_VALIDA_OPERADOR = False
        rbOperadorMexicano.Checked = True
        rbOperadorMexicano.Enabled = False
        rbOperadorExtranjero.Enabled = False
        LimpiaDesactivaTextbox(txtRfcOperador)
        LimpiaDesactivaTextbox(txtNumRegIdTribFiscOperador)
        LimpiaDesactivaTextbox(txtNombreOperador)
        LimpiaDesactivaTextbox(txtApPaternoOperador)
        LimpiaDesactivaTextbox(txtApMaternoOperador)
        LimpiaDesactivaCombobox(cbTipoFiguraOperador)
        LimpiaDesactivaCombobox(cbParteTransporteOperador)
        RemueveDeGrid(txtEstadoOperador, tlpDireccionOperador)
        RemueveDeGrid(txtMunicipioOperador, tlpDireccionOperador)
        RemueveDeGrid(txtLocalidadOperador, tlpDireccionOperador)
        RemueveDeGrid(txtColoniaOperador, tlpDireccionOperador)
        LimpiaDesactivaCombobox(refCbEstadoOperador)
        LimpiaDesactivaCombobox(refCbMunicipioOperador)
        LimpiaDesactivaCombobox(refCbLocalidadOperador)
        LimpiaDesactivaCombobox(refCbColoniaOperador)
        LimpiaDesactivaTextbox(txtCpOperador)
        LimpiaDesactivaTextbox(txtNoIntOperador)
        LimpiaDesactivaTextbox(txtNoExtOperador)
        LimpiaDesactivaTextbox(txtCalleOperador)
        LimpiaDesactivaTextbox(txtReferenciaOperador)
    End Sub

    Private Sub LimpiaInformacionOperador()
        rbOperadorMexicano.Checked = True
        rbOperadorMexicano.Enabled = True
        rbOperadorExtranjero.Enabled = True
        txtRfcOperador.Text = String.Empty
        txtRfcOperador.Enabled = True
        txtNumRegIdTribFiscOperador.Text = String.Empty
        txtNumRegIdTribFiscOperador.Enabled = True
        txtNombreOperador.Text = String.Empty
        txtNombreOperador.Enabled = True
        txtApPaternoOperador.Text = String.Empty
        txtApPaternoOperador.Enabled = True
        txtApMaternoOperador.Text = String.Empty
        txtApMaternoOperador.Enabled = True
        LimpiaDesactivaCombobox(cbTipoFiguraOperador)
        LimpiaDesactivaCombobox(cbParteTransporteOperador)
        RemueveDeGrid(txtEstadoOperador, tlpDireccionOperador)
        RemueveDeGrid(txtMunicipioOperador, tlpDireccionOperador)
        RemueveDeGrid(txtLocalidadOperador, tlpDireccionOperador)
        RemueveDeGrid(txtColoniaOperador, tlpDireccionOperador)
        txtEstadoOperador = Nothing
        txtLocalidadOperador = Nothing
        txtMunicipioOperador = Nothing
        txtColoniaOperador = Nothing
        LimpiaDesactivaCombobox(refCbEstadoOperador)
        LimpiaDesactivaCombobox(refCbMunicipioOperador)
        LimpiaDesactivaCombobox(refCbLocalidadOperador)
        LimpiaDesactivaCombobox(refCbColoniaOperador)
        txtCpOperador.Text = String.Empty
        txtCpOperador.Enabled = True
        txtNoIntOperador.Text = String.Empty
        txtNoIntOperador.Enabled = True
        txtNoExtOperador.Text = String.Empty
        txtNoExtOperador.Enabled = True
        txtCalleOperador.Text = String.Empty
        txtCalleOperador.Enabled = True
        txtReferenciaOperador.Text = String.Empty
        txtReferenciaOperador.Enabled = True

        BindCombobox(cbPaisOperador, ObtenListadoPaises())
        ValidaPropiedadAjena()
        BindCombobox(cbTipoFiguraOperador, conexionesCartaPorte.Get_ObtenFigurasDeTransporte(PARTE_DEL_REMOLQUE_ES_AJENA))
    End Sub

    Private Sub CargaInformacionOperador()
        If datosAutoTransporte.Transportista IsNot Nothing Then
            Dim datosOperador As DatosTransportista = datosAutoTransporte.Transportista
            cbOpcionesOperador.SelectedValue = datosOperador.CveInternaOperador
            txtNombreOperador.Text = datosOperador.NombreTransportista
            txtApPaternoOperador.Text = datosOperador.ApellidoPaternoTransportista
            txtApMaternoOperador.Text = datosOperador.ApellidoMaternoTransportista
            rbOperadorExtranjero.Checked = datosOperador.EsTransportistaExtranjero
            rbOperadorMexicano.Checked = datosOperador.EsTransportistaNacional
            txtRfcOperador.Text = datosOperador.RFCFigura
            txtNumRegIdTribFiscOperador.Text = datosOperador.NumRegIdTribFigura
            cbTipoFiguraOperador.SelectedValue = datosOperador.TipoFigura
            txtNumLicenciaOperador.Text = datosOperador.NumLicencia
            listaParteTransporte = datosOperador.ParteTransporte
            cbPaisOperador.SelectedValue = datosOperador.Domicilio.Pais
            txtCpOperador.Text = datosOperador.Domicilio.CodigoPostal
            BindGridPartesTransporteOperador()

            If datosOperador.EsTransportistaNacional Then
                cbEstadoOperador.SelectedValue = datosOperador.Domicilio.Estado
                cbMunicipioOperador.SelectedValue = datosOperador.Domicilio.Municipio
                cbLocalidadOperador.SelectedValue = datosOperador.Domicilio.Localidad
                cbColoniaOperador.SelectedValue = datosOperador.Domicilio.Colonia
                txtCalleOperador.Text = datosOperador.Domicilio.Calle
                txtReferenciaOperador.Text = datosOperador.Domicilio.Referencia
                txtNoIntDestino.Text = datosOperador.Domicilio.NumeroInterior
                txtNoExtDestino.Text = datosOperador.Domicilio.NumeroExterior
            Else
                If refCbEstadoOperador IsNot Nothing Then
                    refCbEstadoOperador.SelectedValue = datosOperador.Domicilio.Estado
                ElseIf txtEstadoOperador IsNot Nothing Then
                    txtEstadoOperador.Text = datosOperador.Domicilio.Estado
                End If

                If refCbMunicipioOperador IsNot Nothing Then
                    refCbMunicipioOperador.SelectedValue = datosOperador.Domicilio.Municipio
                ElseIf txtMunicipioOperador IsNot Nothing Then
                    txtMunicipioOperador.Text = datosOperador.Domicilio.Municipio
                End If

                If refCbLocalidadOperador IsNot Nothing Then
                    refCbLocalidadOperador.SelectedValue = datosOperador.Domicilio.Localidad
                ElseIf txtLocalidadOperador IsNot Nothing Then
                    txtLocalidadOperador.Text = datosOperador.Domicilio.Localidad
                End If

                If refCbColoniaOperador IsNot Nothing Then
                    refCbColoniaOperador.SelectedValue = datosOperador.Domicilio.Colonia
                ElseIf txtColoniaOperador IsNot Nothing Then
                    txtColoniaOperador.Text = datosOperador.Domicilio.Colonia
                End If

                'Finalmente cargo el resto de datos
                txtCalleOperador.Text = datosOperador.Domicilio.Calle
                txtReferenciaOperador.Text = datosOperador.Domicilio.Referencia
                txtNoIntDestino.Text = datosOperador.Domicilio.NumeroInterior
                txtNoExtDestino.Text = datosOperador.Domicilio.NumeroExterior
            End If
        End If
    End Sub

    Private Sub ToggleDatosOperador()
        If rbOperadorExtranjero.Checked Then
            txtRfcOperador.Text = ObtenParametroPorLlave("RFC_GENERICO_EXTRANJERO")
            txtNumRegIdTribFiscOperador.Enabled = True
            txtRfcOperador.Enabled = False
            cbPaisOperador.Enabled = True
            cbPaisOperador.SelectedValue = "-01"
            MarcaCampoComoObligatorio(txtNumRegIdTribFiscOperador, tlpSeleccionOperador)
        ElseIf rbOperadorMexicano.Checked Then
            txtRfcOperador.Text = String.Empty
            txtRfcOperador.Enabled = True
            LimpiaDesactivaTextbox(txtNumRegIdTribFiscOperador)
            BindCombobox(cbPaisOperador, ObtenListadoPaises("MEX"))
            MarcaCampoComoOpcional(txtNumRegIdTribFiscOperador, tlpSeleccionOperador)
            cbPaisOperador.SelectedValue = "MEX"
            cbPaisOperador.Enabled = True
        End If
        cbPaisOperador_SelectedValueChanged(Nothing, Nothing)
    End Sub

    Private Sub BindGridPartesTransporteOperador()
        gvParteTransporteOperador.DataSource = Nothing
        If gvParteTransporteOperador.Rows IsNot Nothing Then
            gvParteTransporteOperador.Rows.Clear()
        End If

        If listaParteTransporte Is Nothing Then Return
        gvParteTransporteOperador.Columns("ParteTransporteAnadidoClm").DataPropertyName = NameOf(ItemTransporte.DescripcionTipoTransporte)
        gvParteTransporteOperador.Columns("IdParteTransporteClm").DataPropertyName = NameOf(ItemTransporte.Id)
        gvParteTransporteOperador.DataSource = listaParteTransporte
    End Sub

    Private Sub AnadirParteTransporteOperador()
        If cbParteTransporteOperador.SelectedValue = "-01" Then Return
        If listaParteTransporte Is Nothing Then listaParteTransporte = New List(Of ItemTransporte)

        Dim nuevoId As Int32
        Dim existeId As Boolean = True
        While existeId
            nuevoId = Math.Ceiling(Rnd() * 1000)
            Dim transRep As ItemTransporte = listaParteTransporte.Where(Function(it) it.Id = nuevoId).FirstOrDefault()
            existeId = (transRep IsNot Nothing)
        End While

        Dim itemTransporte As New ItemTransporte
        itemTransporte.Id = nuevoId
        itemTransporte.TipoTransporte = cbParteTransporteOperador.SelectedValue
        itemTransporte.DescripcionTipoTransporte = cbParteTransporteOperador.SelectedText
        listaParteTransporte.Add(itemTransporte)
        cbParteTransporteOperador.SelectedValue = "-01"
        BindGridPartesTransporteOperador()
    End Sub

    Private Sub EliminaParteTransporteOperador(ByVal id As Int32)
        Dim transpAEliminar As ItemTransporte = listaParteTransporte.Where(Function(it) it.Id = id).FirstOrDefault()
        listaParteTransporte.Remove(transpAEliminar)
        BindGridPartesTransporteOperador()
    End Sub

    Private Sub rbOperadorMexicano_CheckedChanged(sender As Object, e As EventArgs) Handles rbOperadorMexicano.CheckedChanged
        ToggleDatosOperador()
    End Sub

    Private Sub rbOperadorExtranjero_CheckedChanged(sender As Object, e As EventArgs) Handles rbOperadorExtranjero.CheckedChanged
        ToggleDatosOperador()
    End Sub

    Private Sub btnAnadirParteTransporte_Click(sender As Object, e As EventArgs) Handles btnAnadirParteTransporte.Click
        AnadirParteTransporteOperador()
    End Sub

    Private Sub txtTipoPermisoSCT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoPermisoSCT.KeyDown
        AbreSiEsEnter(e, AddressOf txtTipoPermisoSCT_DoubleClick)
    End Sub

    Private Sub txtConVeh_KeyDown(sender As Object, e As KeyEventArgs) Handles txtConVeh.KeyDown
        AbreSiEsEnter(e, AddressOf txtConVeh_DoubleClick)
    End Sub

    Private Sub txtTipoPermisoSCT_DoubleClick(sender As Object, e As EventArgs) Handles txtTipoPermisoSCT.DoubleClick
        Dim formaBusqueda As New frmBusqueda(AddressOf conexionesCartaPorte.Get_DetalleTipoPermiso)
        esperandoBusqueda = txtTipoPermisoSCT
        AddHandler formaBusqueda.ElementoSeleccionado, AddressOf AtrapaEvento
        formaBusqueda.ShowDialog()
    End Sub

    Private Sub txtConVeh_DoubleClick(sender As Object, e As EventArgs) Handles txtConVeh.DoubleClick
        Dim formaBusqueda As New frmBusqueda(AddressOf conexionesCartaPorte.Get_DetalleConfigVehicular)
        esperandoBusqueda = txtConVeh
        AddHandler formaBusqueda.ElementoSeleccionado, AddressOf AtrapaEvento
        formaBusqueda.ShowDialog()
    End Sub

    Private Sub txtTipoPermisoSCT_TextChanged(sender As Object, e As EventArgs) Handles txtTipoPermisoSCT.TextChanged
        LimpiaDesactivaTextbox(txtDescripcionTipoPermisoSCT)
        Dim claveTipoPermiso = ObtenValorTextbox(txtTipoPermisoSCT)
        If EsCadenaVacia(claveTipoPermiso) Then Return
        txtDescripcionTipoPermisoSCT.Text = conexionesCartaPorte.Get_ObtenDescripcionTipoPermiso(claveTipoPermiso)
    End Sub

    Private Sub txtConVeh_TextChanged(sender As Object, e As EventArgs) Handles txtConVeh.TextChanged
        LimpiaDesactivaTextbox(txtDescripConfigVehicular)
        Dim conVehicular = ObtenValorTextbox(txtConVeh)
        If EsCadenaVacia(conVehicular) Then Return
        txtDescripConfigVehicular.Text = conexionesCartaPorte.Get_ObtenDescripcionConfiguracionAutoTransporte(conVehicular)
    End Sub

    Private Sub gvParteTransporteOperador_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvParteTransporteOperador.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim indiceIdEliminar As Int32 = gvParteTransporteOperador.Columns.IndexOf(gvParteTransporteOperador.Columns("EliminarParteTransporteClm"))
        If e.ColumnIndex <> indiceIdEliminar Then Return

        Dim indiceIdParte As Int32 = gvParteTransporteOperador.Columns.IndexOf(gvParteTransporteOperador.Columns("IdParteTransporteClm"))
        Dim idOperador As Int32 = CInt(gvParteTransporteOperador.Rows(e.RowIndex).Cells(indiceIdParte).Value)
        EliminaParteTransporteOperador(idOperador)
    End Sub

    Private Sub cbPaisOperador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisOperador.SelectedValueChanged
        RealizaOperacionesSustitucionPaisesEstadoColonia(cbPaisOperador,
                                                        refCbEstadoOperador,
                                                        AddressOf cbEstadoOperador_SelectedValueChanged,
                                                        refCbMunicipioOperador,
                                                        AddressOf cbMunicipioOperador_SelectedValueChanged,
                                                        refCbLocalidadOperador,
                                                        AddressOf cbLocalidadOperador_SelectedValueChanged,
                                                        refCbColoniaOperador,
                                                        txtCpOperador,
                                                        txtEstadoOperador,
                                                        txtMunicipioOperador,
                                                        txtLocalidadOperador,
                                                        txtColoniaOperador,
                                                        tlpDireccionOperador)
    End Sub

    Private Sub cbEstadoOperador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEstadoOperador.SelectedValueChanged
        ValidaOrdenMunicipioLocalidadCodigo(cbPaisOperador,
                                            refCbEstadoOperador,
                                            refCbLocalidadOperador,
                                            refCbMunicipioOperador,
                                            txtCpOperador,
                                            refCbColoniaOperador)

        If ObtenValorCombobox(refCbEstadoOperador) = "-01" Then Return
        BindCombobox(refCbMunicipioOperador, ObtenMunicipiosPorEstado(ObtenValorCombobox(refCbEstadoOperador)))
        BindCombobox(refCbLocalidadOperador, ObtenLocalidadesPorEstado(ObtenValorCombobox(refCbEstadoOperador)))
    End Sub

    Private Sub txtCpOperador_TextChanged(sender As Object, e As EventArgs) Handles txtCpOperador.TextChanged
        RealizaCargaValidacionCodigoCargaColonias(refCbEstadoOperador, refCbMunicipioOperador, refCbLocalidadOperador, refCbColoniaOperador, txtCpOperador)
    End Sub

    Private Sub ValidaInformacionOperador()
        INFORMACION_VALIDA_OPERADOR = False

        Dim cveInternaOperador As String = String.Empty
        Dim rfcOperador As String = String.Empty
        Dim numRegIdTribOperador As String = String.Empty
        Dim nombreOperador As String = String.Empty
        Dim apPaternoOperador As String = String.Empty
        Dim apMaternoOperador As String = String.Empty
        Dim tipoFiguraOperador As String = String.Empty
        Dim esOperadorNacional As Boolean = rbOperadorMexicano.Checked
        Dim esOperadorExtranjero As Boolean = rbOperadorExtranjero.Checked
        Dim paisOperador As String = String.Empty
        Dim estadoOperador As String = String.Empty
        Dim municipioOperador As String = String.Empty
        Dim localidadOperador As String = String.Empty
        Dim coloniaOperador As String = String.Empty
        Dim cpOperador As String = String.Empty
        Dim calleOperador As String = String.Empty
        Dim referenciaOperador As String = String.Empty
        Dim noExtOperador As String = String.Empty
        Dim noIntOperador As String = String.Empty

        If ObtenValorCombobox(cbOpcionesOperador) = "-01" Then AlertaMensaje(ObtenParametroPorLlave("SELECCIONE_OPERADOR")) : Return
        esOperadorNacional = rbOperadorMexicano.Checked
        esOperadorExtranjero = rbOperadorExtranjero.Checked
        rfcOperador = ObtenValorTextbox(txtRfcOperador)
        numRegIdTribOperador = ObtenValorTextbox(txtNumRegIdTribFiscOperador)

        'Validaciones de rfcs
        If esOperadorNacional Then
            Dim regExpPersonaFisica As String = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_FISICA")
            Dim regExpPersonaMoral As String = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_MORAL")

            If (Not Regex.IsMatch(rfcOperador, regExpPersonaFisica)) And (Not Regex.IsMatch(rfcOperador, regExpPersonaFisica)) Then
                AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO"))
                Return
            End If
        ElseIf esOperadorExtranjero Then
            If EsCadenaVacia(numRegIdTribOperador) Then AlertaMensaje(ObtenParametroPorLlave("NUM_REG_IDTRIB_NO_VALIDO")) : Return
        End If

        nombreOperador = ObtenValorTextbox(txtNombreOperador)
        apPaternoOperador = ObtenValorTextbox(txtApPaternoOperador)
        apMaternoOperador = ObtenValorTextbox(txtApMaternoOperador)
        If EsCadenaVacia(nombreOperador) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
        If EsCadenaVacia(apPaternoOperador) And EsCadenaVacia(apMaternoOperador) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

        tipoFiguraOperador = ObtenValorCombobox(cbTipoFiguraOperador)
        If tipoFiguraOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_TIPO_FIGURA")) : Return

        If esOperadorNacional Then
            paisOperador = ObtenValorCombobox(cbPaisOperador)
            estadoOperador = ObtenValorCombobox(refCbEstadoOperador)
            localidadOperador = ObtenValorCombobox(refCbLocalidadOperador)
            municipioOperador = ObtenValorCombobox(refCbMunicipioOperador)
            coloniaOperador = ObtenValorCombobox(refCbColoniaOperador)
            If paisOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PAIS")) : Return
            If estadoOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            If municipioOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            If localidadOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return
            If coloniaOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        Else
            paisOperador = ObtenValorCombobox(cbPaisOperador)
            estadoOperador = IIf(txtEstadoOperador IsNot Nothing, ObtenValorTextbox(txtEstadoOperador), ObtenValorCombobox(cbEstadoOperador))
            municipioOperador = IIf(txtMunicipioOperador IsNot Nothing, ObtenValorTextbox(txtMunicipioOperador), ObtenValorCombobox(refCbMunicipioOperador))
            localidadOperador = IIf(txtLocalidadOperador IsNot Nothing, ObtenValorTextbox(txtLocalidadOperador), ObtenValorCombobox(refCbLocalidadOperador))
            coloniaOperador = IIf(txtColoniaOperador IsNot Nothing, ObtenValorTextbox(txtColoniaOperador), ObtenValorCombobox(refCbColoniaOperador))

            If paisOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PAIS")) : Return
            If estadoOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            If municipioOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            If coloniaOperador = "-01" Or EsCadenaVacia(coloniaOperador) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        End If

        cpOperador = ObtenValorTextbox(txtCpOperador)
        If Not Regex.IsMatch(cpOperador, ObtenParametroPorLlave("REGEXP_CADENA_SOLO_NUMEROS'")) Then AlertaMensaje(String.Format(ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS"), "CP OPERADOR")) : Return
        calleOperador = ObtenValorTextbox(txtCalleOperador)
        If EsCadenaVacia(calleOperador) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CALLE")) : Return

        noExtOperador = Trim(txtNoExtOperador.Text)
        If EsCadenaVacia(noExtOperador) Or Not Regex.IsMatch(noExtOperador, ObtenParametroPorLlave("REGEXP_CADENA_SOLO_NUMEROS")) Then AlertaMensaje(String.Format(ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS"), "NO. EXT. OPERADOR")) : Return
        noIntOperador = Trim(txtNoIntOperador.Text)
        referenciaOperador = ObtenValorTextbox(txtReferenciaOperador)

        Dim datosTransportisa As DatosTransportista = New DatosTransportista
        datosTransportisa.CveInternaOperador = cveInternaOperador
        datosTransportisa.TipoFigura = tipoFiguraOperador
        datosTransportisa.RFCFigura = rfcOperador
        datosTransportisa.NumLicencia = ObtenValorTextbox(txtNumLicenciaOperador)
        datosTransportisa.NombreTransportista = nombreOperador
        datosTransportisa.ApellidoPaternoTransportista = apPaternoOperador
        datosTransportisa.ApellidoMaternoTransportista = apMaternoOperador
        datosTransportisa.EsTransportistaNacional = esOperadorNacional
        datosTransportisa.EsTransportistaExtranjero = esOperadorExtranjero
        datosTransportisa.NumRegIdTribFigura = numRegIdTribOperador
        datosTransportisa.ResidenciaFiscalFigura = paisOperador
        datosTransportisa.ParteTransporte = listaParteTransporte

        Dim domicilioOperador As New Domicilio
        domicilioOperador.Calle = calleOperador
        domicilioOperador.NumeroExterior = noExtOperador
        domicilioOperador.NumeroInterior = noIntOperador
        domicilioOperador.Colonia = coloniaOperador
        domicilioOperador.Localidad = localidadOperador
        domicilioOperador.Municipio = municipioOperador
        domicilioOperador.Estado = estadoOperador
        domicilioOperador.Pais = paisOperador
        domicilioOperador.CodigoPostal = cpOperador
        domicilioOperador.Referencia = referenciaOperador

        datosTransportisa.Domicilio = domicilioOperador
        datosAutoTransporte.Transportista = datosTransportisa

        INFORMACION_VALIDA_OPERADOR = True
    End Sub

    Private Sub btnSiguienteOperador_Click(sender As Object, e As EventArgs) Handles btnSiguienteOperador.Click
        ValidaInformacionOperador()
        If INFORMACION_VALIDA_OPERADOR Then
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
            TabControl1.SelectedTab = TabControl1.TabPages("tabConfirmacion")
            ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
        End If
    End Sub

    Private Sub btnAtrasOperador_Click(sender As Object, e As EventArgs) Handles btnAtrasOperador.Click
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
        TabControl1.SelectedTab = TabControl1.TabPages("tabTransporte")
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
    End Sub

    Private Sub cbOpcionesOperador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbOpcionesOperador.SelectedValueChanged
        Dim claveOperador = ObtenValorCombobox(cbOpcionesOperador)
        If claveOperador = "-01" Then
            BloqueaDatosOperador()
            Return
        End If
        LimpiaInformacionOperador()
        If claveOperador = "00" Then
            rbOperadorMexicano.Checked = True
            ToggleDatosOperador()
        End If
        If claveOperador <> "00" Then
            CargaInformacionOperador()
            ToggleDatosOperador()
        End If
    End Sub
#End Region

#Region "Pestana de confirmacion"
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''' CONFIRMACIÓN
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private pestConfirmacionListaFinalMercancias As List(Of Mercancia)
    Private pestConfirmacionListaMercanciaSinDestino As List(Of Mercancia)
    Private pestConfirmacionListaDestinos As List(Of OrigenDestino)
    Private pestConfirmacionDestinoSeleccionado As String = String.Empty
    Private nombreDestinoDesplegado As String = String.Empty
    Private Sub PreparaPestanaConfirmacion()
        pestConfirmacionDestinoSeleccionado = String.Empty
        nombreDestinoDesplegado = String.Empty

        'Primero tenemos que preparar la lista de ubicaciones
        pestConfirmacionListaDestinos = New List(Of OrigenDestino)
        pestConfirmacionListaDestinos = datosDestinosIntermediosParaCartaPorte.OrderBy(Of DateTime)(Function(x) x.FechaHora).ToList
        pestConfirmacionListaDestinos.Insert(0, datosOrigenParaCartaPorte)
        pestConfirmacionListaDestinos.Insert(1, datosDestinoParaCartaPorte)
        PestanaConfirmacionBindGridUbicaciones()

        'Luego, limpio el grid de relación
        LimpiaGrid(dgvRelacionMercanciaUbicaciones)

        'Luego, si existen mercancías sin asignar, hago el binding del grid
        'en caso contrario, creo la lista y la dejo preparada
        If pestConfirmacionListaMercanciaSinDestino Is Nothing Then
            pestConfirmacionListaMercanciaSinDestino = New List(Of Mercancia)
        End If

    End Sub

    Private Sub PestanaConfirmacionBindGridUbicaciones()
        LimpiaGrid(dgvConfirmacionUbicaciones)
        dgvConfirmacionUbicaciones.AutoGenerateColumns = False
        dgvConfirmacionUbicaciones.Columns("IdUbicacionClmMercMov").DataPropertyName = NameOf(OrigenDestino.IDUbicacion)
        dgvConfirmacionUbicaciones.Columns("DestinoUbiClm").DataPropertyName = NameOf(OrigenDestino.DestinoDesplegado)
        dgvConfirmacionUbicaciones.Columns("TipoDestinoPestUbiClm").DataPropertyName = NameOf(OrigenDestino.TipoMovimiento)
        dgvConfirmacionUbicaciones.DataSource = pestConfirmacionListaDestinos
    End Sub

    Private Sub PestanaConfirmacionBindGridMercanciaMovimientos()
        LimpiaGrid(dgvRelacionMercanciaUbicaciones)

        If String.IsNullOrEmpty(pestConfirmacionDestinoSeleccionado) Then Return

        Dim listaMercancias As List(Of Mercancia) = ObtenMercanciasPorMovimiento(pestConfirmacionDestinoSeleccionado)

        dgvRelacionMercanciaUbicaciones.AutoGenerateColumns = False
        dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiIdUbiClm").ReadOnly = True
        dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiClaveProdServClm").DataPropertyName = NameOf(Mercancia.ClaveProdServ)
        dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiDescMercClm").DataPropertyName = NameOf(Mercancia.Descripcion)
        dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiClaveUnidadClm").DataPropertyName = NameOf(Mercancia.ClaveUnidad)
        dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiDescUnidadClm").DataPropertyName = NameOf(Mercancia.Unidad)
        dgvRelacionMercanciaUbicaciones.Columns("RelacionMercUbiPeligrosaClm").DataPropertyName = NameOf(Mercancia.EsMaterialPeligrosoCad)
        'dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiCantidadParaRemoverClm").DataPropertyName = NameOf(Mercancia.Cero)
        dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiCantidadMaxima").DataPropertyName = NameOf(Mercancia.Cantidad)
        dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiCantidadMercClm").DataPropertyName = NameOf(Mercancia.Cantidad)
        dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiCantidadParaRemoverClm").ReadOnly = False
        dgvRelacionMercanciaUbicaciones.DataSource = listaMercancias
    End Sub

    Private Sub PestanaConfirmacionBindGridMercanciasSinDestino()
        LimpiaGrid(dgvMercanciasSinUbicaciones)

        If dgvMercanciasSinUbicaciones.Columns("AsignarColumnaCombo") IsNot Nothing Then
            dgvMercanciasSinUbicaciones.Columns.RemoveAt(dgvMercanciasSinUbicaciones.Columns("AsignarColumnaCombo").Index)
        End If

        Dim comboColumn As New DataGridViewComboBoxColumn
        comboColumn.ValueMember = NameOf(OrigenDestino.IDUbicacion)
        comboColumn.DisplayMember = NameOf(OrigenDestino.DestinoDesplegado)
        comboColumn.DataSource = pestConfirmacionListaDestinos.Where(Function(x) Not x.TipoUbicacion.ToUpper().Equals("ORIGEN")).ToList
        comboColumn.Name = "AsignarColumnaCombo"
        comboColumn.HeaderText = "Posibles destinos"
        comboColumn.ToolTipText = "Posibles destinos para asignar la mercancía"

        Dim indiceColumnaBoton As Int32 = dgvMercanciasSinUbicaciones.Columns("AsignarDestinoAccionClm").Index
        dgvMercanciasSinUbicaciones.Columns.Insert(indiceColumnaBoton - 1, comboColumn)

        dgvMercanciasSinUbicaciones.AutoGenerateColumns = False
        dgvMercanciasSinUbicaciones.Columns("AsignarClaveProdServClm").DataPropertyName = NameOf(Mercancia.ClaveProdServ)
        dgvMercanciasSinUbicaciones.Columns("AsignarDescripcionMercClm").DataPropertyName = NameOf(Mercancia.Descripcion)
        dgvMercanciasSinUbicaciones.Columns("AsignarClaveUnidadClm").DataPropertyName = NameOf(Mercancia.ClaveUnidad)
        dgvMercanciasSinUbicaciones.Columns("AsignarDescUnidadClm").DataPropertyName = NameOf(Mercancia.Unidad)
        dgvMercanciasSinUbicaciones.Columns("AsignarPeligrosoClm").DataPropertyName = NameOf(Mercancia.EsMaterialPeligrosoCad)
        dgvMercanciasSinUbicaciones.Columns("AsignarCantidadRestanteClm").DataPropertyName = NameOf(Mercancia.Cantidad)
        'dgvMercanciasSinUbicaciones.Columns("AsignarCantidadParaAsignarClm").DataPropertyName = NameOf(Mercancia.Cero)
        dgvMercanciasSinUbicaciones.DataSource = pestConfirmacionListaMercanciaSinDestino
    End Sub

    Private Sub dgvConfirmacionUbicaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConfirmacionUbicaciones.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim tipoDestino As String = dgvConfirmacionUbicaciones.Rows(e.RowIndex).Cells("TipoDestinoPestUbiClm").Value
        If tipoDestino.ToUpper().Equals("ORIGEN") Then
            nombreDestinoDesplegado = String.Empty
            AlertaMensaje(ObtenParametroPorLlave("ORIGEN_SINCARGA"))
            Return
        End If

        Dim idUbicacion As String = dgvConfirmacionUbicaciones.Rows(e.RowIndex).Cells("IdUbicacionClmMercMov").Value
        nombreDestinoDesplegado = dgvConfirmacionUbicaciones.Rows(e.RowIndex).Cells("DestinoUbiClm").Value
        pestConfirmacionDestinoSeleccionado = idUbicacion
        PestanaConfirmacionBindGridMercanciaMovimientos()
    End Sub

    Private Sub dgvRelacionMercanciaUbicaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRelacionMercanciaUbicaciones.CellContentClick
        Dim indiceBotonRemover As Int32 = dgvRelacionMercanciaUbicaciones.Columns("RelMercUbiBtnEliminarClm").Index
        If e.ColumnIndex <> indiceBotonRemover Then
            Return
        End If

        'Ahora, obtengo lo que hace a la mercancía única
        Dim idMovimiento As String = dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelMercUbiIdUbiClm").Value
        Dim claveProdServ As String = dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelMercUbiClaveProdServClm").Value
        Dim claveUnidad As String = dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelMercUbiClaveUnidadClm").Value
        Dim esPeligrosa As Boolean = dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelacionMercUbiPeligrosaClm").Value.ToString().ToUpper().Equals("SI")
        Dim cantidadParaEliminarCad As String = dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelMercUbiCantidadParaRemoverClm").Value
        Dim cantidadParaEliminar As Int32 = -1
        Dim cantidadMaxima As Int32 = CInt(dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelMercUbiCantidadMaxima").Value)

        'Reviso que no me estén metiendo datos incorrectos
        If Not Int32.TryParse(cantidadParaEliminarCad, cantidadParaEliminar) Or cantidadParaEliminar <= 0 Or cantidadParaEliminar > cantidadMaxima Then
            AlertaMensaje(String.Format(ObtenParametroPorLlave("ASIGNAR_CANTIDADMAL"), cantidadMaxima))
            dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelMercUbiCantidadParaRemoverClm").Value = "0"
            Return
        End If

        'Si no, si puedo proceder a la eliminación
        RemueveMercanciaDeRelacion(pestConfirmacionDestinoSeleccionado, claveProdServ, claveUnidad, esPeligrosa, cantidadParaEliminar)
    End Sub

    Private Sub dgvRelacionMercanciaUbicaciones_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRelacionMercanciaUbicaciones.CellFormatting
        If e.ColumnIndex <> 0 Then Return
        dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells(0).Value = pestConfirmacionDestinoSeleccionado
        dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelMercUbiCantidadParaRemoverClm").Value = "0"
        dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelMercUbiCantidadParaRemoverClm").ReadOnly = False
        dgvRelacionMercanciaUbicaciones.Rows(e.RowIndex).Cells("RelMercUbiNombreDestinoClm").Value = nombreDestinoDesplegado
    End Sub

    Private Sub RemueveMercanciaDeRelacion(ByVal idMovimiento As String,
                                           ByVal claveProdServ As String,
                                           ByVal claveUnidad As String,
                                           ByVal esPeligrosa As Boolean,
                                           ByVal cantidadARemover As Int32)
        Dim listaMercancias As List(Of Mercancia) = ObtenMercanciasPorMovimiento(idMovimiento)
        Dim mercARemover As Mercancia = ObtenMercancia(idMovimiento, claveProdServ, claveUnidad, esPeligrosa)

        'Primero, tengo que revisar si no existe un posible duplicado de cantidades
        Dim posibleColision As Mercancia = ObtenMercancia(pestConfirmacionListaMercanciaSinDestino, claveProdServ, claveUnidad, esPeligrosa)
        Dim canitdadColision As Int32 = 0

        If posibleColision IsNot Nothing Then
            Dim rsult = MsgBox(ObtenParametroPorLlave("POSIBLE_CHOQUE"), vbQuestion + vbYesNo, "Alerta")
            If rsult = MsgBoxResult.No Then Return
            posibleColision.Cantidad = posibleColision.Cantidad + cantidadARemover

            If cantidadARemover = mercARemover.Cantidad Then
                listaMercancias.Remove(mercARemover)
            Else
                mercARemover.Cantidad = mercARemover.Cantidad - cantidadARemover
            End If
        Else
            If cantidadARemover = mercARemover.Cantidad Then
                listaMercancias.Remove(mercARemover)
                pestConfirmacionListaMercanciaSinDestino.Add(mercARemover)
            Else
                Dim nuevaMerc As Mercancia = Mercancia.CreaCopiaMercancia(mercARemover, False)
                pestConfirmacionListaMercanciaSinDestino.Add(nuevaMerc)
                mercARemover.Cantidad = mercARemover.Cantidad - cantidadARemover
                nuevaMerc.Cantidad = cantidadARemover
            End If
        End If

        PestanaConfirmacionBindGridMercanciaMovimientos()
        PestanaConfirmacionBindGridMercanciasSinDestino()
    End Sub

    Private Sub dgvMercanciasSinUbicaciones_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMercanciasSinUbicaciones.CellFormatting
        If e.ColumnIndex <> 0 Then Return
        dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarCantidadParaAsignarClm").Value = "0"
        dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarCantidadParaAsignarClm").ReadOnly = False
        dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarColumnaCombo").Value = datosDestinoParaCartaPorte.IDUbicacion
    End Sub

    Private Sub AnadeMercanciaARelacion(ByVal idMovimiento As String,
                                        ByVal claveProdServ As String,
                                        ByVal claveUnidad As String,
                                        ByVal esPeligrosa As Boolean,
                                        ByVal cantidadAnadir As Int32)
        'Primero, tengo que ver si no existe una mercancía con las mismas características
        'para notificar de posibles problemas
        Dim mercPosibleChoque As Mercancia = ObtenMercancia(idMovimiento, claveProdServ, claveUnidad, esPeligrosa)
        Dim mercanciaParaAnadir As Mercancia = ObtenMercancia(pestConfirmacionListaMercanciaSinDestino, claveProdServ, claveUnidad, esPeligrosa)
        If mercPosibleChoque IsNot Nothing Then
            Dim rsult = MsgBox(ObtenParametroPorLlave("POSIBLE_CHOQUE"), vbQuestion + vbYesNo, "Alerta")
            If rsult = MsgBoxResult.No Then Return
            mercPosibleChoque.Cantidad = mercPosibleChoque.Cantidad + cantidadAnadir

            If mercanciaParaAnadir.Cantidad = cantidadAnadir Then
                pestConfirmacionListaMercanciaSinDestino.Remove(mercanciaParaAnadir)
            Else
                mercanciaParaAnadir.Cantidad = mercanciaParaAnadir.Cantidad - cantidadAnadir
            End If
        Else
            Dim mercsMov As List(Of Mercancia) = ObtenMercanciasPorMovimiento(idMovimiento)
            If mercanciaParaAnadir.Cantidad = cantidadAnadir Then
                pestConfirmacionListaMercanciaSinDestino.Remove(mercanciaParaAnadir)
                mercsMov.Add(mercanciaParaAnadir)
            Else
                Dim nuevaMerc As Mercancia = Mercancia.CreaCopiaMercancia(mercanciaParaAnadir, False)
                nuevaMerc.Cantidad = cantidadAnadir
                mercanciaParaAnadir.Cantidad = mercanciaParaAnadir.Cantidad - cantidadAnadir
                mercsMov.Add(nuevaMerc)
            End If
        End If

        PestanaConfirmacionBindGridMercanciaMovimientos()
        PestanaConfirmacionBindGridMercanciasSinDestino()
    End Sub
    Private Sub btnAtrasConfirmacion_Click(sender As Object, e As EventArgs) Handles btnAtrasConfirmacion.Click
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = True
        TabControl1.SelectedTab = TabControl1.TabPages("tabOperador")
        ESTOY_CAMBIANDO_MEDIANTE_INDICE = False
    End Sub

    Private Sub dgvMercanciasSinUbicaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMercanciasSinUbicaciones.CellContentClick
        Dim indiceAsignar As Int32 = dgvMercanciasSinUbicaciones.Columns("AsignarDestinoAccionClm").Index
        If e.ColumnIndex <> indiceAsignar Then
            Return
        End If

        Dim cantidadMaxima As Int32 = CInt(dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarCantidadRestanteClm").Value)
        Dim cantidadParaAsignarCad As String = dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarCantidadParaAsignarClm").Value
        Dim cantidadParaAsignar As Int32 = -1

        'Verifico que no me estén pasando mal la información
        If Not Int32.TryParse(cantidadParaAsignarCad, cantidadParaAsignar) Or cantidadParaAsignar > cantidadMaxima Or cantidadParaAsignar <= 0 Then
            AlertaMensaje(ObtenParametroPorLlave("CANTIDAD_ASIG_NO"))
            dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarCantidadParaAsignarClm").Value = "0"
            Return
        End If


        Dim destino As String = dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarColumnaCombo").Value
        Dim claveProdServ As String = dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarClaveProdServClm").Value
        Dim claveUnidad As String = dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarClaveUnidadClm").Value
        Dim materialPeligroso As Boolean = dgvMercanciasSinUbicaciones.Rows(e.RowIndex).Cells("AsignarPeligrosoClm").Value.ToString.ToUpper().Equals("SI")

        AnadeMercanciaARelacion(destino, claveProdServ, claveUnidad, materialPeligroso, cantidadParaAsignar)
    End Sub
#End Region

#Region "Generacion de archivos"
    Private Sub btnGenerarCartaPorte_Click(sender As Object, e As EventArgs) Handles btnGenerarCartaPorte.Click
        Dim pesoBrutoTotal As String = ObtenValorTextbox(txtPesoBrutoTotalMercancias)
        Dim unidadPeso As String = ObtenValorTextbox(txtUnidadPesoTotalMercancias)

        Dim regExpDec As String = ObtenParametroPorLlave("REGEXP_NUMERO_DECIMAL")
        If Not Regex.IsMatch(pesoBrutoTotal, regExpDec) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PESOBRUTO_TOT")) : Return
        If EsCadenaVacia(unidadPeso) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_UNIDAD_TOT")) : Return

        'Preparamos la lista final de mercancías, porque la carta porte solo recibe
        'una lista de mercancías

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Para facilitar las cosas, primero vamos a ordenar, esto nos ahorrará problemas a futuro
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        For Each key As String In datosMercancias.Keys
            datosMercancias(key) = datosMercancias(key).OrderBy(Of String)(Function(m) m.ClaveProdServ).ToList
        Next

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Ahora, recorremos toda la lista de mercancías, y la iremos añadiendo y creando la relación
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        pestConfirmacionListaFinalMercancias = New List(Of Mercancia)
        For Each key As String In datosMercancias.Keys
            Dim listaMercanciasParaAnadir As List(Of Mercancia) = datosMercancias(key)
            For Each mer As Mercancia In listaMercanciasParaAnadir

                'Creamos la relación para el detalle del nodo
                Dim relMercUbi As New RelacionMercanciaOrigenDestino
                relMercUbi.IdOrigen = datosOrigenParaCartaPorte.IDUbicacion
                relMercUbi.IdDestino = key
                relMercUbi.ClaveProdServ = mer.ClaveProdServ
                relMercUbi.DescripcionProductoServicio = mer.Descripcion
                relMercUbi.EsMaterialPeligroso = mer.MaterialPeligroso
                relMercUbi.Cantidad = mer.Cantidad
                relMercUbi.ClaveUnidad = mer.ClaveUnidad
                relMercUbi.EsMaterialPeligroso = mer.MaterialPeligroso

                'Luego, vemos si existe una mercancía exactamente igual
                Dim existeMercancia As Boolean = False
                Dim posibleChoque As Mercancia = Nothing
                For Each merIncluidas In pestConfirmacionListaFinalMercancias
                    If merIncluidas.Equals(mer) Then
                        posibleChoque = merIncluidas
                        existeMercancia = True
                        Exit For
                    End If
                Next

                'En caso de que exista, solo sumo cantidades y añado la relación
                If existeMercancia Then
                    posibleChoque.Cantidad = posibleChoque.Cantidad + mer.Cantidad
                    posibleChoque.AnadeRelacion(relMercUbi)
                Else
                    pestConfirmacionListaFinalMercancias.Add(mer)
                    mer.AnadeRelacion(relMercUbi)
                End If
            Next
        Next

        'Ahora sí, a generar el XML
        Dim xmlCartaPorte As String = conexionesCartaPorte.GeneraXmlCartaPorte(
                "T", False, "", "", "", datosDestinoParaCartaPorte.DistanciaRecorrida,
                pestConfirmacionListaDestinos,
                Decimal.Parse(pesoBrutoTotal),
                unidadPeso,
                pestConfirmacionListaFinalMercancias,
                datosAutoTransporte,
                datosAutoTransporte.Transportista)

        'Ahora es necesario generar el XML de traslado
        Dim xmlTraslado As String = conexionesCartaPorte.GeneraXmlTraslado(
            datosOrigenParaCartaPorte.RFCRemitenteDestinatario,
            datosOrigenParaCartaPorte.NombreUbicacionParaComplemento,
            datosOrigenParaCartaPorte.DatosDomicilio.CodigoPostal,
            "601",
            datosDestinoParaCartaPorte.RFCRemitenteDestinatario,
            datosDestinoParaCartaPorte.NombreUbicacionParaComplemento,
            datosDestinoParaCartaPorte.DatosDomicilio.CodigoPostal,
            "601",
            pestConfirmacionListaFinalMercancias
        )
        Dim xmlFinal As String = String.Format(xmlTraslado, xmlCartaPorte)
        Dim aaaaa = xmlFinal
    End Sub

    Private Sub tlpContenedorSeguroMaterialPeligroso_Paint(sender As Object, e As PaintEventArgs) Handles tlpContenedorSeguroMaterialPeligroso.Paint

    End Sub
#End Region

End Class