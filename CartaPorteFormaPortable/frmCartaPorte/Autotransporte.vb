Public Class Autotransporte
    Private _CveInternaVehiculo As String
    Private _PermSCT As String
    Private _NumPermisoSCT As String
    Private _ConfigVehicular As String
    Private _PlacaVM As String
    Private _AnioModeloVM As String

    'Seguros
    Private _AseguraRespCivil As String
    Private _PolizaRespCivil As String

    'Medio ambiente (solo en caso de mercancía peligrosa)
    Private _AseguraMedAmbiente As String
    Private _PolizaMedAmbiente As String

    'Aseguradora de la mercancía
    Private _AseguraCarga As String
    Private _PolizaCarga As String
    Private _PrimaSeguro As Double

    'Datos de remolques (opcional)
    Private _Remolques As List(Of Remolque)
    Private _NoRemolques As Int16

    'Datos de la figura de transporte
    Private _Transportista As DatosTransportista

    Public Property PermSCT As String
        Get
            Return _PermSCT
        End Get
        Set(value As String)
            _PermSCT = value
        End Set
    End Property

    Public Property NumPermisoSCT As String
        Get
            Return _NumPermisoSCT
        End Get
        Set(value As String)
            _NumPermisoSCT = value
        End Set
    End Property

    Public Property ConfigVehicular As String
        Get
            Return _ConfigVehicular
        End Get
        Set(value As String)
            _ConfigVehicular = value
        End Set
    End Property

    Public Property PlacaVM As String
        Get
            Return _PlacaVM
        End Get
        Set(value As String)
            _PlacaVM = value
        End Set
    End Property

    Public Property AnioModeloVM As String
        Get
            Return _AnioModeloVM
        End Get
        Set(value As String)
            _AnioModeloVM = value
        End Set
    End Property

    Public Property AseguraRespCivil As String
        Get
            Return _AseguraRespCivil
        End Get
        Set(value As String)
            _AseguraRespCivil = value
        End Set
    End Property

    Public Property PolizaRespCivil As String
        Get
            Return _PolizaRespCivil
        End Get
        Set(value As String)
            _PolizaRespCivil = value
        End Set
    End Property

    Public Property AseguraMedAmbiente As String
        Get
            Return _AseguraMedAmbiente
        End Get
        Set(value As String)
            _AseguraMedAmbiente = value
        End Set
    End Property

    Public Property PolizaMedAmbiente As String
        Get
            Return _PolizaMedAmbiente
        End Get
        Set(value As String)
            _PolizaMedAmbiente = value
        End Set
    End Property

    Public Property AseguraCarga As String
        Get
            Return _AseguraCarga
        End Get
        Set(value As String)
            _AseguraCarga = value
        End Set
    End Property

    Public Property PolizaCarga As String
        Get
            Return _PolizaCarga
        End Get
        Set(value As String)
            _PolizaCarga = value
        End Set
    End Property

    Public Property PrimaSeguro As Double
        Get
            Return _PrimaSeguro
        End Get
        Set(value As Double)
            _PrimaSeguro = value
        End Set
    End Property

    Public Property Remolques As List(Of Remolque)
        Get
            If _Remolques Is Nothing Then
                _Remolques = New List(Of Remolque)
            End If
            Return _Remolques
        End Get
        Set(value As List(Of Remolque))
            _Remolques = value
        End Set
    End Property

    Public Property NoRemolques As Short
        Get
            Return _NoRemolques
        End Get
        Set(value As Short)
            _NoRemolques = value
        End Set
    End Property

    Public Property Transportista As DatosTransportista
        Get
            Return _Transportista
        End Get
        Set(value As DatosTransportista)
            _Transportista = value
        End Set
    End Property

    Public Property CveInternaVehiculo As String
        Get
            Return _CveInternaVehiculo
        End Get
        Set(value As String)
            _CveInternaVehiculo = value
        End Set
    End Property
End Class

Public Class Remolque
    Private _SubTipoRem As String
    Private _Placa As String
    Private _PropiedadRemolque As String

    Public Property SubTipoRem As String
        Get
            Return _SubTipoRem
        End Get
        Set(value As String)
            _SubTipoRem = value
        End Set
    End Property

    Public Property Placa As String
        Get
            Return _Placa
        End Get
        Set(value As String)
            _Placa = value
        End Set
    End Property

    Public Property PropiedadRemolque As String
        Get
            Return _PropiedadRemolque
        End Get
        Set(value As String)
            _PropiedadRemolque = value
        End Set
    End Property
End Class
