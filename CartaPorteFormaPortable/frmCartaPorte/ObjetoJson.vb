Imports Newtonsoft.Json

Public Class ObjetoJson
    Private _datosOrigen As OrigenDestino
    Private _datosDestino As OrigenDestino
    Private _mercancias As List(Of Mercancia)
    Private _destinosIntermedios As List(Of ObjetoConMercancias)

    <JsonProperty(PropertyName:="Origen", Order:=1)>
    Public Property DatosOrigen As OrigenDestino
        Get
            Return _datosOrigen
        End Get
        Set(value As OrigenDestino)
            _datosOrigen = value
        End Set
    End Property

    <JsonProperty(PropertyName:="Carga", Order:=3)>
    Public Property Mercancias As List(Of Mercancia)
        Get
            Return _mercancias
        End Get
        Set(value As List(Of Mercancia))
            _mercancias = value
        End Set
    End Property

    <JsonProperty(PropertyName:="Destino", Order:=2)>
    Public Property DatosDestino As OrigenDestino
        Get
            Return _datosDestino
        End Get
        Set(value As OrigenDestino)
            _datosDestino = value
        End Set
    End Property

    <JsonProperty(PropertyName:="DestinosAdicionales", Order:=4)>
    Friend Property DestinosIntermedios As List(Of ObjetoConMercancias)
        Get
            Return _destinosIntermedios
        End Get
        Set(value As List(Of ObjetoConMercancias))
            _destinosIntermedios = value
        End Set
    End Property

    Public Sub AnadeUbicacionConCarga(ByRef ubicacion As OrigenDestino, ByRef carga As List(Of Mercancia))
        If _destinosIntermedios Is Nothing Then
            _destinosIntermedios = New List(Of ObjetoConMercancias)
        End If

        Dim objConMerc As New ObjetoConMercancias
        objConMerc.DetalleUbicacion = ubicacion
        objConMerc.Mercancias = carga
        _destinosIntermedios.Add(objConMerc)
    End Sub

    Public Function Get_ListadoDestinosIntermedios() As List(Of OrigenDestino)
        Dim listaUbis As New List(Of OrigenDestino)
        For Each item As ObjetoConMercancias In _destinosIntermedios
            listaUbis.Add(item.DetalleUbicacion)
        Next
        Return listaUbis
    End Function

    Public Function Get_DatosMercancias() As Dictionary(Of String, List(Of Mercancia))
        Dim dict As New Dictionary(Of String, List(Of Mercancia))
        dict.Add(_datosDestino.IDUbicacion, _mercancias)
        For Each item As ObjetoConMercancias In _destinosIntermedios
            dict.Add(item.DetalleUbicacion.IDUbicacion, Mercancias)
        Next
        Return dict
    End Function

End Class

Class ObjetoConMercancias
    Private _detalleUbicacion As OrigenDestino
    Private _mercancias As List(Of Mercancia)

    <JsonProperty(PropertyName:="Destino", Order:=1)>
    Public Property DetalleUbicacion As OrigenDestino
        Get
            Return _detalleUbicacion
        End Get
        Set(value As OrigenDestino)
            _detalleUbicacion = value
        End Set
    End Property

    <JsonProperty(PropertyName:="Carga", Order:=2)>
    Public Property Mercancias As List(Of Mercancia)
        Get
            Return _mercancias
        End Get
        Set(value As List(Of Mercancia))
            _mercancias = value
        End Set
    End Property
End Class
