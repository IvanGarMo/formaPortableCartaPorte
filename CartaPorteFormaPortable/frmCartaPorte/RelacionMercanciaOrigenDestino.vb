Public Class RelacionMercanciaOrigenDestino
    Private _IdOrigen As String
    Private _IdDestino As String
    Private _ClaveProdServ As String
    Private _DescripcionProductoServicio As String
    Private _Cantidad As Int32
    Private _DescripcionDestino As String

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

    Public Property DescripcionDestino As String
        Get
            Return _DescripcionDestino
        End Get
        Set(value As String)
            _DescripcionDestino = value
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
End Class
