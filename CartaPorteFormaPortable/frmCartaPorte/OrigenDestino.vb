Imports System.Text.RegularExpressions

Public Class OrigenDestino
    Private _Movimiento As String
    Private _TipoUbicacion As String
    Private _IDUbicacion As String
    Private _RFCRemitenteDestinatario As String
    'Para practicidad, NombreRemitenteDestinatario
    'fue dividido en datos de persona fisica y persona moral
    Private _EsPersonaFisica As Boolean
    Private _Nombre As String
    Private _ApPaterno As String
    Private _ApMaterno As String

    Private _EsPersonaMoral As Boolean
    Private _EsExtranjero As Boolean
    Private _NombrePersonaMoral As String

    Private _NumRegIdTrib As String
    Private _ResidenciaFiscal As String
    Private _FechaSalidaLlegada As Date
    Private _HoraSalidaLlegada As String
    Private _DistanciaRecorrida As Int32
    Private _DatosDomicilio As Domicilio

    'Este campo no va incluido en la carta porte
    'pero me sirve para calculos
    Private _EsDestinoIntermedio As Boolean

    'Este campo me sirve para saber si el usuario ha modificado 
    'la fecha y hora finales luego de iniciar
    Private _UsuarioCausoProblemasConFecha As Boolean = False
    Private _UsuarioCausoProblemasConKm As Boolean = False

    Public Property TipoUbicacion As String
        Get
            Return _TipoUbicacion
        End Get
        Set(value As String)
            _TipoUbicacion = value
        End Set
    End Property

    Public Property IDUbicacion As String
        Get
            Return _IDUbicacion
        End Get
        Set(value As String)
            _IDUbicacion = value
        End Set
    End Property

    Public Property RFCRemitenteDestinatario As String
        Get
            Return _RFCRemitenteDestinatario
        End Get
        Set(value As String)
            _RFCRemitenteDestinatario = value
        End Set
    End Property

    Public Property EsPersonaFisica As Boolean
        Get
            Return _EsPersonaFisica
        End Get
        Set(value As Boolean)
            _EsPersonaFisica = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property ApPaterno As String
        Get
            Return _ApPaterno
        End Get
        Set(value As String)
            _ApPaterno = value
        End Set
    End Property

    Public Property ApMaterno As String
        Get
            Return _ApMaterno
        End Get
        Set(value As String)
            _ApMaterno = value
        End Set
    End Property

    Public Property EsPersonaMoral As Boolean
        Get
            Return _EsPersonaMoral
        End Get
        Set(value As Boolean)
            _EsPersonaMoral = value
        End Set
    End Property

    Public Property EsExtranjero As Boolean
        Get
            Return _EsExtranjero
        End Get
        Set(value As Boolean)
            _EsExtranjero = value
        End Set
    End Property

    Public Property NombrePersonaMoral As String
        Get
            Return _NombrePersonaMoral
        End Get
        Set(value As String)
            _NombrePersonaMoral = value
        End Set
    End Property

    Public Property NumRegIdTrib As String
        Get
            Return _NumRegIdTrib
        End Get
        Set(value As String)
            _NumRegIdTrib = value
        End Set
    End Property

    Public Property ResidenciaFiscal As String
        Get
            Return _ResidenciaFiscal
        End Get
        Set(value As String)
            _ResidenciaFiscal = value
        End Set
    End Property

    Public Property FechaSalidaLlegada As Date
        Get
            Return _FechaSalidaLlegada
        End Get
        Set(value As Date)
            _FechaSalidaLlegada = New DateTime(value.Year, value.Month, value.Day, 0, 0, 0)
        End Set
    End Property

    Public ReadOnly Property FechaSalidaLlegadaCadena As String
        Get
            If _UsuarioCausoProblemasConFecha Then
                Return "PENDIENTE"
            Else
                Return _FechaSalidaLlegada.Date.ToString("dd-MM-yyyy")
            End If
        End Get
    End Property

    Public Property HoraSalidaLlegada As String
        Get
            If _UsuarioCausoProblemasConFecha Then
                Return "PENDIENTE"
            Else
                Return _HoraSalidaLlegada
            End If
        End Get
        Set(value As String)
            _HoraSalidaLlegada = value
        End Set
    End Property

    Public ReadOnly Property DistanciaRecorridaCadena As String
        Get
            If _UsuarioCausoProblemasConKm Then
                Return "PENDIENTE"
            Else
                Return _DistanciaRecorrida.ToString
            End If
        End Get
    End Property

    Public Property DistanciaRecorrida As Integer
        Get
            Return _DistanciaRecorrida
        End Get
        Set(value As Integer)
            _DistanciaRecorrida = value
        End Set
    End Property

    Public Property DatosDomicilio As Domicilio
        Get
            Return _DatosDomicilio
        End Get
        Set(value As Domicilio)
            _DatosDomicilio = value
        End Set
    End Property

    Public Property EsDestinoIntermedio As Boolean
        Get
            Return _EsDestinoIntermedio
        End Get
        Set(value As Boolean)
            _EsDestinoIntermedio = value
        End Set
    End Property

    Public Property Movimiento As String
        Get
            Return _Movimiento
        End Get
        Set(value As String)
            _Movimiento = value
        End Set
    End Property

    Public ReadOnly Property NombreUbicacionParaComplemento As String
        Get
            If _EsPersonaFisica Then
                Return Regex.Replace(_Nombre + " " + _ApPaterno + " " + _ApMaterno, " {2,}", " ")
            ElseIf _EsPersonaMoral Then
                Return Regex.Replace(_NombrePersonaMoral, " {2,}", " ")
            ElseIf _EsExtranjero Then
                Return Regex.Replace(_Nombre + " " + _ApPaterno + " " + _ApMaterno, " {2,}", " ")
            End If
        End Get
    End Property
    Public ReadOnly Property DestinoDesplegado As String
        Get
            If _DatosDomicilio Is Nothing Then
                Return String.Empty
            End If
            If EsExtranjero Then
                Dim formato = "{0},{1}"
                Return String.Format(formato, _DatosDomicilio.Pais, _DatosDomicilio.Estado)
            Else
                Return _DatosDomicilio.Estado
            End If
        End Get
    End Property

    Public ReadOnly Property FechaHora As DateTime
        Get
            Dim hora As Int32
            Dim minutos As Int32
            If String.IsNullOrWhiteSpace(_HoraSalidaLlegada) Then
                hora = 0
                minutos = 0
            Else
                hora = CInt(_HoraSalidaLlegada.Split(":")(0))
                minutos = CInt(_HoraSalidaLlegada.Split(":")(1))
            End If
            Return New DateTime(_FechaSalidaLlegada.Year, _FechaSalidaLlegada.Month, _FechaSalidaLlegada.Day, hora, minutos, 0)
        End Get
    End Property

    Public ReadOnly Property FechaHoraCadena As String
        Get
            If String.IsNullOrWhiteSpace(_HoraSalidaLlegada) Then
                _HoraSalidaLlegada = "00:00"
            End If
            Return _FechaSalidaLlegada.ToString("yyyy-MM-dd") + "T" + _HoraSalidaLlegada
        End Get
    End Property

    Public ReadOnly Property TipoMovimiento As String
        Get
            If _EsDestinoIntermedio Then
                Return "Intermedio"
            Else
                Return _TipoUbicacion
            End If
        End Get
    End Property

    Public ReadOnly Property UbicacionEsOrigen As Boolean
        Get
            Return TipoUbicacion.Equals("Origen")
        End Get
    End Property

    Public ReadOnly Property UbicacionEsDestinoIntermedio As Boolean
        Get
            Return TipoUbicacion.Equals("Destino")
        End Get
    End Property

    Public ReadOnly Property UbicacionEsDestinoFinal As Boolean
        Get
            Return TipoUbicacion.Equals("Destino") And EsDestinoIntermedio
        End Get
    End Property

    Public Property UsuarioCausoProblemasConFecha As Boolean
        Get
            Return _UsuarioCausoProblemasConFecha
        End Get
        Set(value As Boolean)
            _UsuarioCausoProblemasConFecha = value
        End Set
    End Property

    Public Property UsuarioCausoProblemasConKm As Boolean
        Get
            Return _UsuarioCausoProblemasConKm
        End Get
        Set(value As Boolean)
            _UsuarioCausoProblemasConKm = value
        End Set
    End Property
End Class
