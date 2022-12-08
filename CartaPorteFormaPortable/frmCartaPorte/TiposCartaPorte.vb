Public Class TiposCartaPorte

    Public Function UbicacionTipo() As DataTable
        Dim table As New DataTable
        table.Columns.Add("TipoUbicacion", GetType(String))
        table.Columns.Add("IDUbicacion", GetType(String))
        table.Columns.Add("RFC", GetType(String))
        table.Columns.Add("Nombre", GetType(String))
        table.Columns.Add("NumRegIdTrib", GetType(String))
        table.Columns.Add("ResidenciaFiscal", GetType(String))
        table.Columns.Add("FechaHoraSalidaLlegada", GetType(String))
        table.Columns.Add("DistanciaRecorrida", GetType(Integer))
        table.Columns.Add("EsOrigen", GetType(Boolean))
        table.Columns.Add("EsDestinoIntermedio", GetType(Boolean))
        table.Columns.Add("EsDestinoFinal", GetType(Boolean))
        table.Columns.Add("EsExtranjero", GetType(Boolean))
        Return table
    End Function

    Public Function DomicilioTipo() As DataTable
        Dim table As New DataTable
        table.Columns.Add("Calle", GetType(String))
        table.Columns.Add("NumeroExterior", GetType(String))
        table.Columns.Add("NumeroInterior", GetType(String))
        table.Columns.Add("Colonia", GetType(String))
        table.Columns.Add("Localidad", GetType(String))
        table.Columns.Add("Referencia", GetType(String))
        table.Columns.Add("Municipio", GetType(String))
        table.Columns.Add("Estado", GetType(String))
        table.Columns.Add("Pais", GetType(String))
        table.Columns.Add("CodigoPostal", GetType(String))
        table.Columns.Add("IDUbicacion", GetType(String))
        table.Columns.Add("EsExtranjero", GetType(Boolean))
        Return table
    End Function

    Public Function CantidadTransportaTipo() As DataTable
        Dim table As New DataTable
        table.Columns.Add("CadProdServ", GetType(String))
        table.Columns.Add("ClaveUnidad", GetType(String))
        table.Columns.Add("MaterialPeligroso", GetType(Boolean))
        table.Columns.Add("Valor", GetType(String))
        table.Columns.Add("IDOrigen", GetType(String))
        table.Columns.Add("IDDestino", GetType(String))
        table.Columns.Add("Cantidad", GetType(Decimal))
        Return table
    End Function

    Public Function CantidadMercanciaTipo() As DataTable
        Dim table As New DataTable
        table.Columns.Add("CadProdServ", GetType(String))
        table.Columns.Add("Descripcion", GetType(String))
        table.Columns.Add("Cantidad", GetType(Decimal))
        table.Columns.Add("ClaveUnidad", GetType(String))
        table.Columns.Add("Unidad", GetType(String))
        table.Columns.Add("Dimensiones", GetType(String))
        table.Columns.Add("RequiereNodoMaterialPeligroso", GetType(Boolean))
        table.Columns.Add("MaterialPeligroso", GetType(Boolean))
        table.Columns.Add("CveMaterialPeligroso", GetType(String))
        table.Columns.Add("Embalaje", GetType(String))
        table.Columns.Add("DescripEmbalaje", GetType(String))
        table.Columns.Add("PesoEnKg", GetType(Decimal))
        table.Columns.Add("ValorMercancia", GetType(Decimal))
        table.Columns.Add("Moneda", GetType(String))
        table.Columns.Add("FraccionArancelaria", GetType(String))
        table.Columns.Add("Pedimento", GetType(String))
        Return table
    End Function

    Public Function RemolquesTipo() As DataTable
        Dim table As New DataTable
        table.Columns.Add("SubTipoRem", GetType(String))
        table.Columns.Add("Placa", GetType(String))
        Return table
    End Function

    Public Sub AnadeUbicacionEnTabla(ByRef tabla As DataTable,
                                     ByRef ubicacion As OrigenDestino)
        Dim row As DataRow = tabla.NewRow()
        row("TipoUbicacion") = ubicacion.TipoUbicacion
        row("IDUbicacion") = ubicacion.IDUbicacion
        row("RFC") = ubicacion.RFCRemitenteDestinatario
        row("Nombre") = ubicacion.NombreUbicacionParaComplemento
        row("NumRegIdTrib") = ubicacion.NumRegIdTrib
        row("ResidenciaFiscal") = ubicacion.ResidenciaFiscal
        row("FechaHoraSalidaLlegada") = ubicacion.FechaHoraCadena
        row("DistanciaRecorrida") = ubicacion.DistanciaRecorrida
        row("EsOrigen") = ubicacion.UbicacionEsOrigen
        row("EsDestinoIntermedio") = ubicacion.UbicacionEsDestinoIntermedio
        row("EsDestinoFinal") = ubicacion.UbicacionEsDestinoFinal
        row("EsExtranjero") = ubicacion.EsExtranjero
        tabla.Rows.Add(row)
    End Sub

    Public Sub AnadeDomicilioEnTabla(ByRef tabla As DataTable,
                                     ByRef domicilio As Domicilio,
                                     ByRef esExtranjero As Boolean,
                                     Optional ByRef idUbicacion As String = "")
        Dim row As DataRow = tabla.NewRow()
        row("Calle") = domicilio.Calle
        row("NumeroExterior") = domicilio.NumeroExterior
        row("NumeroInterior") = domicilio.NumeroInterior
        row("Colonia") = domicilio.Colonia
        row("Localidad") = domicilio.Localidad
        row("Referencia") = domicilio.Referencia
        row("Municipio") = domicilio.Municipio
        row("Estado") = domicilio.Estado
        row("Pais") = domicilio.Pais
        row("CodigoPostal") = domicilio.CodigoPostal
        row("IDUbicacion") = idUbicacion
        row("EsExtranjero") = esExtranjero
        tabla.Rows.Add(row)
    End Sub

    Public Sub AnadeCantidadTransportaEnTabla(ByRef tabla As DataTable,
                                              ByRef relacionCantidadMerc As RelacionMercanciaOrigenDestino)
        Dim row As DataRow = tabla.NewRow()
        row("CadProdServ") = relacionCantidadMerc.ClaveProdServ
        row("ClaveUnidad") = relacionCantidadMerc.ClaveUnidad
        row("MaterialPeligroso") = relacionCantidadMerc.EsMaterialPeligroso
        row("Valor") = relacionCantidadMerc.Valor
        row("IDOrigen") = relacionCantidadMerc.IdOrigen
        row("IDDestino") = relacionCantidadMerc.IdDestino
        row("Cantidad") = relacionCantidadMerc.Cantidad
        tabla.Rows.Add(row)
    End Sub

    Public Sub AnadeMercanciaEnTabla(ByRef tabla As DataTable,
                                    ByRef mercancia As Mercancia)
        Dim row As DataRow = tabla.NewRow()
        row("CadProdServ") = mercancia.ClaveProdServ
        row("Descripcion") = mercancia.DescripcionInternaModal
        row("Cantidad") = mercancia.Cantidad
        row("ClaveUnidad") = mercancia.ClaveUnidad
        row("Unidad") = mercancia.Unidad
        row("Dimensiones") = mercancia.Dimensiones
        row("RequiereNodoMaterialPeligroso") = mercancia.RequiereNodoMaterialPeligroso
        row("MaterialPeligroso") = mercancia.MaterialPeligroso
        row("CveMaterialPeligroso") = mercancia.ClaveMaterialPeligroso
        row("Embalaje") = mercancia.Embalaje
        row("DescripEmbalaje") = mercancia.DescripcionEmbalaje
        row("PesoEnKg") = mercancia.PesoEnKg.ToString("N2")
        row("ValorMercancia") = mercancia.ValorMercancia
        row("Moneda") = mercancia.Moneda
        row("FraccionArancelaria") = mercancia.FraccionArancelaria
        row("Pedimento") = mercancia.Pedimento
        tabla.Rows.Add(row)
    End Sub

    Public Sub AnadeRemolqueEntabla(ByRef tabla As DataTable,
                                    ByRef subtiporem As Remolque)
        Dim row As DataRow = tabla.NewRow()
        row("SubTipoRem") = subtiporem.SubTipoRem
        row("Placa") = subtiporem.Placa
        tabla.Rows.Add(row)
    End Sub

End Class
