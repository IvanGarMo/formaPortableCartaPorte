Public Class Domicilio
    Private _Calle As String
    Private _NumeroExterior As String
    Private _NumeroInterior As String
    Private _Colonia As String
    Private _Localidad As String
    Private _Municipio As String
    Private _Estado As String
    Private _Pais As String
    Private _Referencia As String
    Private _CodigoPostal As String

    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(value As String)
            _Calle = value
        End Set
    End Property

    Public Property NumeroExterior As String
        Get
            Return _NumeroExterior
        End Get
        Set(value As String)
            _NumeroExterior = value
        End Set
    End Property

    Public Property NumeroInterior As String
        Get
            Return _NumeroInterior
        End Get
        Set(value As String)
            _NumeroInterior = value
        End Set
    End Property

    Public Property Colonia As String
        Get
            Return _Colonia
        End Get
        Set(value As String)
            _Colonia = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property

    Public Property Municipio As String
        Get
            Return _Municipio
        End Get
        Set(value As String)
            _Municipio = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property

    Public Property Pais As String
        Get
            Return _Pais
        End Get
        Set(value As String)
            _Pais = value
        End Set
    End Property

    Public Property Referencia As String
        Get
            Return _Referencia
        End Get
        Set(value As String)
            _Referencia = value
        End Set
    End Property

    Public Property CodigoPostal As String
        Get
            Return _CodigoPostal
        End Get
        Set(value As String)
            _CodigoPostal = value
        End Set
    End Property
End Class
