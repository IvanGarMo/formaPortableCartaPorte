Public Class RelacionMercanciaOrigenDestino
    Private _IdOrigen As String
    Private _IdDestino As String
    Private _ClaveProdServ As String
    Private _ClaveUnidad As String
    Private _DescripcionProductoServicio As String
    Private _Cantidad As Int32
    Private _EsMaterialPeligroso As Boolean
    Private _Valor As String

    Public Property IdOrigen As String
        Get
            Return _IdOrigen
        End Get
        Set(value As String)
            _IdOrigen = value
        End Set
    End Property

    Public Property IdDestino As String
        Get
            Return _IdDestino
        End Get
        Set(value As String)
            _IdDestino = value
        End Set
    End Property

    Public Property ClaveProdServ As String
        Get
            Return _ClaveProdServ
        End Get
        Set(value As String)
            _ClaveProdServ = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property DescripcionProductoServicio As String
        Get
            Return _DescripcionProductoServicio
        End Get
        Set(value As String)
            _DescripcionProductoServicio = value
        End Set
    End Property

    Public Property EsMaterialPeligroso As Boolean
        Get
            Return _EsMaterialPeligroso
        End Get
        Set(value As Boolean)
            _EsMaterialPeligroso = value
        End Set
    End Property

    Public Property ClaveUnidad As String
        Get
            Return _ClaveUnidad
        End Get
        Set(value As String)
            _ClaveUnidad = value
        End Set
    End Property

    Public Property Valor As String
        Get
            Return _Valor
        End Get
        Set(value As String)
            _Valor = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim destino = TryCast(obj, RelacionMercanciaOrigenDestino)
        Return destino IsNot Nothing AndAlso
               _ClaveProdServ = destino._ClaveProdServ AndAlso
               _ClaveUnidad = destino._ClaveUnidad AndAlso
               _EsMaterialPeligroso = destino._EsMaterialPeligroso
    End Function
End Class
