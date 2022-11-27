Imports System.Text.RegularExpressions

Public Class DatosTransportista
    Private _CveInternaOperador As String
    Private _TipoFigura As String
    Private _RFCFigura As String
    Private _NumLicencia As String
    Private _NombreTransportista As String
    Private _ApellidoPaternoTransportista As String
    Private _ApellidoMaternoTransportista As String

    Private _EsTransportistaNacional As Boolean
    Private _EsTransportistaExtranjero As Boolean
    Private _NumRegIdTribFigura As String
    Private _ResidenciaFiscalFigura As String
    Private _ParteTransporte As List(Of ItemTransporte)
    Private _Domicilio As Domicilio

    Public Property TipoFigura As String
        Get
            Return _TipoFigura
        End Get
        Set(value As String)
            _TipoFigura = value
        End Set
    End Property

    Public Property RFCFigura As String
        Get
            Return _RFCFigura
        End Get
        Set(value As String)
            _RFCFigura = value
        End Set
    End Property

    Public Property NumLicencia As String
        Get
            Return _NumLicencia
        End Get
        Set(value As String)
            _NumLicencia = value
        End Set
    End Property

    Public Property NombreTransportista As String
        Get
            Return _NombreTransportista
        End Get
        Set(value As String)
            _NombreTransportista = value
        End Set
    End Property

    Public Property ApellidoPaternoTransportista As String
        Get
            Return _ApellidoPaternoTransportista
        End Get
        Set(value As String)
            _ApellidoPaternoTransportista = value
        End Set
    End Property

    Public Property ApellidoMaternoTransportista As String
        Get
            Return _ApellidoMaternoTransportista
        End Get
        Set(value As String)
            _ApellidoMaternoTransportista = value
        End Set
    End Property

    Public Property EsTransportistaExtranjero As Boolean
        Get
            Return _EsTransportistaExtranjero
        End Get
        Set(value As Boolean)
            _EsTransportistaExtranjero = value
        End Set
    End Property

    Public Property NumRegIdTribFigura As String
        Get
            Return _NumRegIdTribFigura
        End Get
        Set(value As String)
            _NumRegIdTribFigura = value
        End Set
    End Property

    Public Property ResidenciaFiscalFigura As String
        Get
            Return _ResidenciaFiscalFigura
        End Get
        Set(value As String)
            _ResidenciaFiscalFigura = value
        End Set
    End Property

    Public Property ParteTransporte As List(Of ItemTransporte)
        Get
            If _ParteTransporte Is Nothing Then
                Return New List(Of ItemTransporte)
            End If
            Return _ParteTransporte
        End Get
        Set(value As List(Of ItemTransporte))
            _ParteTransporte = value
        End Set
    End Property

    Public Property Domicilio As Domicilio
        Get
            Return _Domicilio
        End Get
        Set(value As Domicilio)
            _Domicilio = value
        End Set
    End Property

    Public Property CveInternaOperador As String
        Get
            Return _CveInternaOperador
        End Get
        Set(value As String)
            _CveInternaOperador = value
        End Set
    End Property

    Public Property EsTransportistaNacional As Boolean
        Get
            Return _EsTransportistaNacional
        End Get
        Set(value As Boolean)
            _EsTransportistaNacional = value
        End Set
    End Property

    Public ReadOnly Property NombreCompleto As String
        Get
            Return Regex.Replace(Trim(_NombreTransportista) + " " + Trim(_ApellidoPaternoTransportista) + " " + Trim(_ApellidoMaternoTransportista), " {2,}", " ")
        End Get
    End Property
End Class

Public Class ItemTransporte
    Private _Id As Int32
    Private _TipoTransporte As String
    Private _DescripcionTipoTransporte As String

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property TipoTransporte As String
        Get
            Return _TipoTransporte
        End Get
        Set(value As String)
            _TipoTransporte = value
        End Set
    End Property

    Public Property DescripcionTipoTransporte As String
        Get
            Return _DescripcionTipoTransporte
        End Get
        Set(value As String)
            _DescripcionTipoTransporte = value
        End Set
    End Property
End Class
