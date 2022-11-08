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
        table.Columns.Add("DistanciaRecorrida", GetType(String))
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

    End Sub

End Class
