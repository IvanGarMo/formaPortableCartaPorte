Imports System.IO
Imports System.Text.RegularExpressions

Public Class Utils
    'Este método crea un objeto de OrigenDestino con base en los datos
    'de un datarow, dejando los aspectos más específicos para el que lo llama
    Public Function CreaObjetoOrigenDestino(ByRef rowDatos As DataRow) As OrigenDestino
        Dim datosUbicacion As New OrigenDestino
        datosUbicacion.Movimiento = rowDatos("idMovimiento").ToString()
        datosUbicacion.RFCRemitenteDestinatario = rowDatos("rfc").ToString()
        datosUbicacion.EsPersonaFisica = CType(rowDatos("esPersonaFisica"), Boolean)
        datosUbicacion.EsPersonaMoral = CType(rowDatos("esPersonaMoral"), Boolean)
        datosUbicacion.Nombre = rowDatos("nombre").ToString()
        datosUbicacion.ApPaterno = rowDatos("apellidoPaterno").ToString()
        datosUbicacion.ApMaterno = rowDatos("apellidoMaterno").ToString()
        datosUbicacion.NombrePersonaMoral = rowDatos("razonSocial").ToString()
        datosUbicacion.EsExtranjero = CType(rowDatos("esOrigenExtranjero"), Boolean)
        datosUbicacion.NumRegIdTrib = rowDatos("numRegIdTrib").ToString()
        datosUbicacion.RegimenFiscal = rowDatos("regimenFiscal").ToString()
        datosUbicacion.FueImportado = True
        Return datosUbicacion
    End Function

    'Este método copia los datos fiscales de una ubicación
    'para evitar duplicacion de código
    Public Sub CopiaDatosFiscales(ByRef objetoConDatos As OrigenDestino,
                                   ByRef objetoSinDatos As OrigenDestino)
        objetoSinDatos.RFCRemitenteDestinatario = objetoConDatos.RFCRemitenteDestinatario
        objetoSinDatos.Nombre = objetoConDatos.Nombre
        objetoSinDatos.ApPaterno = objetoConDatos.ApPaterno
        objetoSinDatos.ApMaterno = objetoConDatos.ApMaterno
        objetoSinDatos.NombrePersonaMoral = objetoConDatos.NombrePersonaMoral
        objetoSinDatos.EsPersonaFisica = objetoConDatos.EsPersonaFisica
        objetoSinDatos.EsPersonaMoral = objetoConDatos.EsPersonaMoral
        objetoSinDatos.EsExtranjero = objetoConDatos.EsExtranjero
        objetoSinDatos.NumRegIdTrib = objetoConDatos.NumRegIdTrib
        objetoSinDatos.ResidenciaFiscal = objetoConDatos.ResidenciaFiscal
        objetoSinDatos.Movimiento = objetoConDatos.Movimiento
        objetoSinDatos.RegimenFiscal = objetoConDatos.RegimenFiscal
    End Sub

    'Este método recibe un objeto DataRow y lo convierte en domicilio,
    'para evitar duplicación de código
    Public Function CreaObjetoDomicilio(ByRef rowDatos As DataRow) As Domicilio
        Dim domicilio As New Domicilio
        Dim direccion As String = rowDatos("direccion").ToString()

        Dim regExNumeros As New Regex("[0-9]+")
        Dim numExtCadOrigen As String = String.Empty

        Dim match As MatchCollection
        match = regExNumeros.Matches(direccion)
        If match.Count > 0 Then
            numExtCadOrigen = match(0).Value
        End If
        Dim calle As String = Regex.Replace(direccion, "([0-9]+| {2,}|#)", "")
        domicilio.Calle = calle
        domicilio.NumeroExterior = IIf(String.IsNullOrEmpty(numExtCadOrigen), rowDatos("numeroExterior").ToString(), numExtCadOrigen)
        domicilio.NumeroInterior = rowDatos("numeroInterior").ToString()
        domicilio.CodigoPostal = rowDatos("cp").ToString()
        domicilio.Colonia = rowDatos("colonia").ToString()
        domicilio.Localidad = rowDatos("localidad").ToString()
        domicilio.Municipio = rowDatos("municipio").ToString()
        domicilio.Estado = rowDatos("estado").ToString()
        domicilio.Pais = rowDatos("pais").ToString()
        domicilio.Referencia = rowDatos("referencia").ToString()
        Return domicilio
    End Function


    'Este método recibe un objeto DataRow y lo convierte en uno de tipo mercancía
    'esto para evitar duplicación de código
    Public Function CreaObjetoMercancia(ByRef rowDatos As DataRow) As Mercancia
        Dim mercancia As New Mercancia
        mercancia.ClaveProdServ = rowDatos("claveProdServ").ToString()
        mercancia.Descripcion = rowDatos("descripcionSAT").ToString()
        mercancia.DescripcionInterna = rowDatos("descripcion").ToString()
        mercancia.Cantidad = CInt(rowDatos("cantidad"))
        mercancia.ClaveUnidad = rowDatos("claveUnidad").ToString()
        mercancia.Unidad = rowDatos("descripcionUnidad").ToString()
        mercancia.Longitud = CInt(rowDatos("longitud"))
        mercancia.Anchura = CInt(rowDatos("anchura"))
        mercancia.Altura = CInt(rowDatos("altura"))
        mercancia.EsCentimetros = CType(rowDatos("esCentimetros"), Boolean)
        mercancia.EsPulgadas = CType(rowDatos("esPulgadas"), Boolean)
        mercancia.RequiereNodoMaterialPeligroso = CType(rowDatos("requiereAtributoMaterialPeligroso"), Boolean)
        mercancia.SatConsideraPeligrosa = CType(rowDatos("registradoComoMaterialPeligroso"), Boolean)
        mercancia.MaterialPeligroso = CType(rowDatos("registradoComoMaterialPeligroso"), Boolean)
        mercancia.ClaveMaterialPeligroso = rowDatos("claveMaterialPeligroso").ToString()
        mercancia.Embalaje = rowDatos("embalaje").ToString()
        mercancia.PesoEnKg = CType(rowDatos("pesoEnKg"), Double)
        mercancia.ValorMercancia = CType(rowDatos("valorMercancia"), Double)
        mercancia.Moneda = rowDatos("moneda").ToString()
        mercancia.EsComercioInternacional = CType(rowDatos("esComercioInternacional"), Boolean)
        mercancia.FraccionArancelaria = rowDatos("fraccionArancelaria").ToString()
        mercancia.Pedimento = rowDatos("pedimento").ToString()
        Return mercancia
    End Function

    Public Sub EscribeArchivoJson(ByRef path As String,
                                       ByRef listaUbicaciones As List(Of OrigenDestino),
                                       ByRef mercancias As Dictionary(Of String, List(Of Mercancia)))
        Dim objJson As New ObjetoJson

        Dim origen As OrigenDestino = listaUbicaciones.FirstOrDefault(Function(x1) x1.IDUbicacion.Contains("OR"))
        objJson.DatosOrigen = origen

        Dim destino As OrigenDestino = listaUbicaciones(1)
        objJson.DatosDestino = destino
        objJson.Mercancias = mercancias(destino.IDUbicacion)

        listaUbicaciones.Remove(origen)
        listaUbicaciones.Remove(destino)
        For Each ubi As OrigenDestino In listaUbicaciones
            objJson.AnadeUbicacionConCarga(ubi, mercancias(ubi.IDUbicacion))
        Next
        listaUbicaciones.Insert(0, origen)
        listaUbicaciones.Insert(1, destino)

        Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(objJson)
        EscribeArchivo(path, json)
    End Sub

    Public Sub LeeArchivoJson(ByRef path As String,
                               ByRef ubicacionOrigen As OrigenDestino,
                               ByRef ubicacionDestino As OrigenDestino,
                               ByRef listaDestinosIntermedios As List(Of OrigenDestino),
                               ByRef dictMercancias As Dictionary(Of String, List(Of Mercancia)))
        Dim cadJson As String = LeeArchivo(path)
        Dim objJson As ObjetoJson = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ObjetoJson)(cadJson)
        ubicacionOrigen = objJson.DatosOrigen
        ubicacionDestino = objJson.DatosDestino
        listaDestinosIntermedios = objJson.Get_ListadoDestinosIntermedios()
        dictMercancias = objJson.Get_DatosMercancias()
    End Sub

    Private Sub EscribeArchivo(ByRef path As String, ByRef contenido As String)
        File.WriteAllText(path, contenido)
    End Sub

    Private Function LeeArchivo(ByRef path As String) As String
        Return File.ReadAllText(path)
    End Function

End Class
