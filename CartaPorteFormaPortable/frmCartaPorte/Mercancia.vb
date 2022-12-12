Imports Newtonsoft.Json

Public Class Mercancia
    Private _ClaveProdServ As String
    Private _Descripcion As String
    Private _DescripcionInterna As String
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

    'Esto es para mantener un buen registro en el SAT
    Private _RequiereNodoMaterialPeligroso As Boolean
    Private _SatConsideraPeligrosa As Boolean
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

    'Esto es para control interno, por motivos de problemas para traslado
    Private _mercanciaIncluidaEnCartaPorteSegunSat As Boolean

    'Esto es para evitar problemas al registrar el peso
    Private _PesoCorrrecto As Boolean

    Public Sub New()
        _Descripcion = String.Empty
        _DescripcionInterna = String.Empty
    End Sub
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
            If _PesoEnKg < 1 Then
                _PesoCorrrecto = False
            End If
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

    <JsonIgnore>
    Public ReadOnly Property EsComercioInternacionalCad As String
        Get
            Dim res As String = IIf(_EsComercioInternacional, "SI", "NO")
            Return res
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property EsMaterialPeligrosoCad As String
        Get
            Dim res As String = IIf(_MaterialPeligroso, "SI", "NO")
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

    <JsonIgnore>
    Public ReadOnly Property Dimensiones As String
        Get
            Return ""
        End Get
    End Property

    Public Sub AnadeRelacion(ByRef relMercUbi As RelacionMercanciaOrigenDestino)
        Dim idUbi As String = relMercUbi.IdDestino
        If _RelacionMercanciaDestino Is Nothing Then
            _RelacionMercanciaDestino = New List(Of RelacionMercanciaOrigenDestino)
        End If
        'Si ya existe una relacion, solo la añadimos
        Dim existeRel = _RelacionMercanciaDestino.Find(Function(r) r.IdDestino.Equals(idUbi))
        If existeRel IsNot Nothing AndAlso existeRel.Equals(relMercUbi) Then
            existeRel.Cantidad = existeRel.Cantidad + relMercUbi.Cantidad
        Else
            _RelacionMercanciaDestino.Add(relMercUbi)
        End If
    End Sub

    Public Shared Function CreaCopiaMercancia(ByRef mercancia As Mercancia, ByVal incluyeRelacion As Boolean)
        Dim merc As New Mercancia

        merc.ClaveProdServ = mercancia.ClaveProdServ
        merc.Descripcion = mercancia.Descripcion
        merc.Cantidad = mercancia.Cantidad
        merc.CantidadSinAsignar = mercancia.CantidadSinAsignar

        If incluyeRelacion Then
            merc.RelacionMercanciaDestino = mercancia.RelacionMercanciaDestino
        Else
            merc.RelacionMercanciaDestino = New List(Of RelacionMercanciaOrigenDestino)
        End If
        merc.ClaveUnidad = mercancia.ClaveUnidad
        merc.Unidad = mercancia.Unidad
        merc.Longitud = mercancia.Longitud
        merc.Altura = mercancia.Altura
        merc.Anchura = mercancia.Anchura
        merc.EsCentimetros = mercancia.EsCentimetros
        merc.EsPulgadas = mercancia.EsPulgadas
        merc.MaterialPeligroso = mercancia.MaterialPeligroso
        merc.ClaveMaterialPeligroso = mercancia.ClaveMaterialPeligroso
        merc.RequiereNodoMaterialPeligroso = mercancia.RequiereNodoMaterialPeligroso
        merc.SatConsideraPeligrosa = mercancia.SatConsideraPeligrosa
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

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim mercancia = TryCast(obj, Mercancia)
        Return mercancia IsNot Nothing AndAlso
               _ClaveProdServ = mercancia._ClaveProdServ AndAlso
               _Descripcion = mercancia._Descripcion AndAlso
               _ClaveUnidad = mercancia._ClaveUnidad AndAlso
               _Unidad = mercancia._Unidad AndAlso
               _Longitud = mercancia._Longitud AndAlso
               _Altura = mercancia._Altura AndAlso
               _Anchura = mercancia._Anchura AndAlso
               _EsCentimetros = mercancia._EsCentimetros AndAlso
               _EsPulgadas = mercancia._EsPulgadas AndAlso
               _RequiereNodoMaterialPeligroso = mercancia._RequiereNodoMaterialPeligroso AndAlso
               _SatConsideraPeligrosa = mercancia._SatConsideraPeligrosa AndAlso
               _MaterialPeligroso = mercancia._MaterialPeligroso AndAlso
               _ClaveMaterialPeligroso = mercancia._ClaveMaterialPeligroso AndAlso
               _DescripcionMaterialPeligroso = mercancia._DescripcionMaterialPeligroso AndAlso
               _Embalaje = mercancia._Embalaje AndAlso
               _DescripcionEmbalaje = mercancia._DescripcionEmbalaje AndAlso
               _PesoEnKg = mercancia._PesoEnKg AndAlso
               _ValorMercancia = mercancia._ValorMercancia AndAlso
               _Moneda = mercancia._Moneda AndAlso
               _EsComercioInternacional = mercancia._EsComercioInternacional AndAlso
               _FraccionArancelaria = mercancia._FraccionArancelaria AndAlso
               _Pedimento = mercancia._Pedimento
    End Function

    Public Property RequiereNodoMaterialPeligroso As Boolean
        Get
            Return _RequiereNodoMaterialPeligroso
        End Get
        Set(value As Boolean)
            _RequiereNodoMaterialPeligroso = value
        End Set
    End Property

    Public Property SatConsideraPeligrosa As Boolean
        Get
            Return _SatConsideraPeligrosa
        End Get
        Set(value As Boolean)
            _SatConsideraPeligrosa = value
        End Set
    End Property

    <JsonIgnore>
    Public ReadOnly Property Cero As String
        Get
            Return "0"
        End Get
    End Property

    Public Property DescripcionInterna As String
        Get
            Return _DescripcionInterna
        End Get
        Set(value As String)
            _DescripcionInterna = value
        End Set
    End Property

    <JsonIgnore>
    Public ReadOnly Property DescripcionInternaModal As String
        Get
            If String.IsNullOrEmpty(_DescripcionInterna) Then
                Return _Descripcion
            End If

            If String.IsNullOrEmpty(_Descripcion) Then
                Return _DescripcionInterna
            End If

            Return String.Format("{0} - ({1})", _DescripcionInterna, _Descripcion)
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property ValorMercanciaCadena As String
        Get
            Return _ValorMercancia.ToString("N3")
        End Get
    End Property

    Public Property MercanciaIncluidaEnCartaPorteSegunSat As Boolean
        Get
            Return _mercanciaIncluidaEnCartaPorteSegunSat
        End Get
        Set(value As Boolean)
            _mercanciaIncluidaEnCartaPorteSegunSat = value
        End Set
    End Property

    Public Property PesoCorrrecto As Boolean
        Get
            Return _PesoCorrrecto
        End Get
        Set(value As Boolean)
            _PesoCorrrecto = value
        End Set
    End Property
End Class
