Public Class Mercancia
    Private _ClaveProdServ As String
    Private _Descripcion As String
    Private _Cantidad As Int32

    'Esta es la cantidad que no ha sido asignada a un destino en
    'especifico
    Private _CantidadSinAsignar As Int32
    Private _RelacionMercanciaDestino As List(Of RelacionMercanciaOrigenDestino)

    Private _ClaveUnidad As String
    Private _Unidad As String
    Private _Longitud As Int32
    Private _Altura As Int32
    Private _Anchura As Int32
    Private _EsCentimetros As Boolean
    Private _EsPulgadas As Boolean
    Private _MaterialPeligroso As Boolean

    'Esto solo aplica si es material peligroso
    Private _ClaveMaterialPeligroso As String
    Private _DescripcionMaterialPeligroso As String
    Private _Embalaje As String
    Private _DescripcionEmbalaje As String

    'Final de la sección exclusiva de material peligroso
    Private _PesoEnKg As Double
    Private _ValorMercancia As Double
    Private _Moneda As String
    Private _EsComercioInternacional As Boolean

    'Esto solo aplica si es recien importado
    Private _FraccionArancelaria As String
    Private _Pedimento As String
    'Final de sección exclusiva de mercancía importada

    Public Property ClaveProdServ As String
        Get
            Return _ClaveProdServ
        End Get
        Set(value As String)
            _ClaveProdServ = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
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

    Public Property CantidadSinAsignar As Integer
        Get
            Return _CantidadSinAsignar
        End Get
        Set(value As Integer)
            _CantidadSinAsignar = value
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

    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
        End Set
    End Property

    Public Property Longitud As Integer
        Get
            Return _Longitud
        End Get
        Set(value As Integer)
            _Longitud = value
        End Set
    End Property

    Public Property Altura As Integer
        Get
            Return _Altura
        End Get
        Set(value As Integer)
            _Altura = value
        End Set
    End Property

    Public Property Anchura As Integer
        Get
            Return _Anchura
        End Get
        Set(value As Integer)
            _Anchura = value
        End Set
    End Property

    Public Property EsCentimetros As Boolean
        Get
            Return _EsCentimetros
        End Get
        Set(value As Boolean)
            _EsCentimetros = value
        End Set
    End Property

    Public Property EsPulgadas As Boolean
        Get
            Return _EsPulgadas
        End Get
        Set(value As Boolean)
            _EsPulgadas = value
        End Set
    End Property

    Public Property MaterialPeligroso As Boolean
        Get
            Return _MaterialPeligroso
        End Get
        Set(value As Boolean)
            _MaterialPeligroso = value
        End Set
    End Property

    Public Property ClaveMaterialPeligroso As String
        Get
            Return _ClaveMaterialPeligroso
        End Get
        Set(value As String)
            _ClaveMaterialPeligroso = value
        End Set
    End Property

    Public Property Embalaje As String
        Get
            Return _Embalaje
        End Get
        Set(value As String)
            _Embalaje = value
        End Set
    End Property

    Public Property DescripcionEmbalaje As String
        Get
            Return _DescripcionEmbalaje
        End Get
        Set(value As String)
            _DescripcionEmbalaje = value
        End Set
    End Property

    Public Property PesoEnKg As Double
        Get
            Return _PesoEnKg
        End Get
        Set(value As Double)
            _PesoEnKg = value
        End Set
    End Property

    Public Property ValorMercancia As Double
        Get
            Return _ValorMercancia
        End Get
        Set(value As Double)
            _ValorMercancia = value
        End Set
    End Property

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property EsComercioInternacional As Boolean
        Get
            Return _EsComercioInternacional
        End Get
        Set(value As Boolean)
            _EsComercioInternacional = value
        End Set
    End Property

    Public Property FraccionArancelaria As String
        Get
            Return _FraccionArancelaria
        End Get
        Set(value As String)
            _FraccionArancelaria = value
        End Set
    End Property

    Public Property Pedimento As String
        Get
            Return _Pedimento
        End Get
        Set(value As String)
            _Pedimento = value
        End Set
    End Property

    Public ReadOnly Property EsComercioInternacionalCad As String
        Get
            Dim res As String = IIf(_EsComercioInternacional, "SÍ", "NO")
            Return res
        End Get
    End Property

    Public ReadOnly Property EsMaterialPeligrosoCad As String
        Get
            Dim res As String = IIf(_MaterialPeligroso, "SÍ", "NO")
            Return res
        End Get
    End Property

    Public Property DescripcionMaterialPeligroso As String
        Get
            Return _DescripcionMaterialPeligroso
        End Get
        Set(value As String)
            _DescripcionMaterialPeligroso = value
        End Set
    End Property

    Public Property RelacionMercanciaDestino As List(Of RelacionMercanciaOrigenDestino)
        Get
            If _RelacionMercanciaDestino IsNot Nothing Then
                Return _RelacionMercanciaDestino
            Else
                Return New List(Of RelacionMercanciaOrigenDestino)
            End If
        End Get
        Set(value As List(Of RelacionMercanciaOrigenDestino))
            _RelacionMercanciaDestino = value
        End Set
    End Property

    Public ReadOnly Property Dimensiones As String
        Get
            Return ""
        End Get
    End Property

    Public Shared Function CreaCopiaMercancia(ByRef mercancia As Mercancia)
        Dim merc As New Mercancia

        merc.ClaveProdServ = mercancia.ClaveProdServ
        merc.Descripcion = mercancia.Descripcion
        merc.Cantidad = mercancia.Cantidad
        merc.CantidadSinAsignar = mercancia.CantidadSinAsignar
        merc.RelacionMercanciaDestino = mercancia.RelacionMercanciaDestino
        merc.ClaveUnidad = mercancia.ClaveUnidad
        merc.Unidad = mercancia.Unidad
        merc.Longitud = mercancia.Longitud
        merc.Altura = mercancia.Altura
        merc.Anchura = mercancia.Anchura
        merc.EsCentimetros = mercancia.EsCentimetros
        merc.EsPulgadas = mercancia.EsPulgadas
        merc.MaterialPeligroso = mercancia.MaterialPeligroso
        merc.ClaveMaterialPeligroso = mercancia.ClaveMaterialPeligroso
        merc.DescripcionMaterialPeligroso = mercancia.DescripcionMaterialPeligroso
        merc.Embalaje = mercancia.Embalaje
        merc.DescripcionEmbalaje = mercancia.DescripcionEmbalaje
        merc.PesoEnKg = mercancia.PesoEnKg
        merc.ValorMercancia = mercancia.ValorMercancia
        merc.Moneda = mercancia.Moneda
        merc.EsComercioInternacional = mercancia.EsComercioInternacional
        merc.FraccionArancelaria = mercancia.FraccionArancelaria
        merc.Pedimento = mercancia.Pedimento

        Return merc
    End Function
End Class
