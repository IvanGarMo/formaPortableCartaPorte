﻿Imports System.Text.RegularExpressions

Public Class frmCartaPorte
    Private parametrosFormaCartaPorte As DataTable
    Private conexionesCartaPorte As ConexionesCartaPorte

    'Datos de la carta porte 
    Private datosOrigenParaCartaPorte As OrigenDestino
    Private datosDestinoParaCartaPorte As OrigenDestino
    Private datosDestinosIntermediosParaCartaPorte As List(Of OrigenDestino)
    Private datosDestinoIntermedioEnModificacion As OrigenDestino
    Private dictMercancias As Dictionary(Of String, List(Of Mercancia)) = New Dictionary(Of String, List(Of Mercancia))()
    Private listadoMercanciasPorMovimiento As List(Of Mercancia)
    Private mercanciaEnModificacion As Mercancia
    Private datosAutoTransporte As Autotransporte

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''MÉTODOS COMUNES
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub CargaParametros()
        parametrosFormaCartaPorte = conexionesCartaPorte.Get_ObtenParametros()
    End Sub

    Private Function ObtenParametroPorLlave(ByRef llave As String) As String
        For Each r As DataRow In parametrosFormaCartaPorte.Rows
            If r("clave").ToString.Equals(llave) Then
                Return r("valor").ToString
            End If
        Next
        Return String.Empty
    End Function

    Private Sub AlertaMensaje(ByVal mensaje As String)
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Error")
    End Sub

    Private Function EsCadenaVacia(ByVal mensaje As String) As Boolean
        Return String.IsNullOrWhiteSpace(mensaje)
    End Function

    Private Function ObtenListadoPaises() As DataTable
        Return conexionesCartaPorte.Get_ObtenPaises(True)
    End Function

    Private Function ObtenDescripcionPais(ByVal codigoPais As String) As String
        Return conexionesCartaPorte.Get_ObtenDescripcionPais(codigoPais)
    End Function

    Private Function ObtenEstadosPorPais(ByVal pais As String) As DataTable
        Return conexionesCartaPorte.Get_ObtenEstados(True, pais)
    End Function

    Private Function ObtenLocalidadesPorEstado(ByVal estado As String) As DataTable
        Return conexionesCartaPorte.Get_ObtenLocalidadesPorEstado(True, estado)
    End Function

    Private Function ObtenMunicipiosPorEstado(ByVal estado As String) As DataTable
        Return conexionesCartaPorte.Get_ObtenMunicipiosPorEstado(True, estado)
    End Function

    Private Function ObtenColoniasPorCodigoPostal(ByVal codigoPostal As String) As DataTable
        Return conexionesCartaPorte.Get_ObtenColoniasPorCodigoPostal(True, codigoPostal)
    End Function

    Private Function SeEncuentraValor(ByVal valorABuscar As String,
                                      ByVal cadenaDeValores As String,
                                      ByVal separador As String) As Boolean
        Dim opc As String() = cadenaDeValores.Split(separador)
        For Each cad As String In opc
            If cad.Equals(valorABuscar) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub BindCombobox(ByRef combo As ComboBox, ByRef data As DataTable)
        If combo Is Nothing Then
            combo = New ComboBox
        End If

        combo.DataSource = Nothing
        If combo.Items IsNot Nothing Then
            combo.Items.Clear()
        End If
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id"
        combo.DataSource = data
        combo.Enabled = True
        combo.BringToFront()
    End Sub

    Private Sub creaTextbox(ByRef textbox As TextBox)
        If textbox Is Nothing Then
            textbox = New TextBox
        End If
        textbox.Text = String.Empty
        textbox.Enabled = True
    End Sub

    Private Sub LimpiaDesactivaCombobox(ByRef combo As ComboBox)
        If combo Is Nothing Then Return
        combo.DataSource = Nothing
        If combo.Items IsNot Nothing Then
            combo.Items.Clear()
        End If
        combo.Enabled = False
    End Sub

    Private Sub LimpiaDesactivaTextbox(ByRef textbox As TextBox)
        If textbox Is Nothing Then Return
        textbox.Text = String.Empty
        textbox.Enabled = False
    End Sub

    Private Function ObtenValorCombobox(ByRef combo As ComboBox) As String
        If Not combo.Enabled Then
            Return "-01"
        End If

        If combo.Items.Count = 0 Then
            Return "-01"
        End If

        Return combo.SelectedValue
    End Function

    Private Function ObtenValorTextbox(ByRef text As TextBox) As String
        If text Is Nothing Then Return String.Empty
        Return ObtenValorTextbox(text)
    End Function

    Private Sub RemueveDeGrid(ByRef control As Control, ByRef panel As TableLayoutPanel)
        If control IsNot Nothing Then
            panel.Controls.Remove(control)
        End If
        control = Nothing
    End Sub

    Private Sub SustituyeEnGrid(ByRef controlAReemplazar As Control,
                                ByRef controlNuevo As Control,
                                ByRef panel As TableLayoutPanel)
        Dim idColumna As Int32 = panel.GetColumn(controlAReemplazar)
        Dim idRenglon As Int32 = panel.GetRow(controlAReemplazar)
        RemueveDeGrid(controlAReemplazar, panel)
        controlNuevo.Dock = DockStyle.Fill
        panel.Controls.Add(controlNuevo)
        panel.SetColumn(controlNuevo, idColumna)
        panel.SetRow(controlNuevo, idRenglon)
        controlAReemplazar = Nothing
    End Sub

    Private Function PaisTieneEstados(ByRef pais As String) As Boolean
        Dim separador As String = ObtenParametroPorLlave("SEPARADOR")
        Dim listaPaisesConEstados As String = ObtenParametroPorLlave("PAISES_CON_ESTADO")
        Return SeEncuentraValor(pais, listaPaisesConEstados, separador)
    End Function

    Private Function PaisTieneMunicipioLocalidad(ByRef pais As String) As Boolean
        Dim separador = ObtenParametroPorLlave("SEPARADOR")
        Dim listaPaisesConMunicipios As String = ObtenParametroPorLlave("PAISES_CON_MUNICIPIO_LOCALIDAD")
        Return SeEncuentraValor(pais, listaPaisesConMunicipios, separador)
    End Function

    Private Function PaisTieneColonias(ByRef pais As String) As Boolean
        Dim separador = ObtenParametroPorLlave("SEPARADOR")
        Dim listaPaisesConColonias As String = ObtenParametroPorLlave("PAISES_CON_COLONIAS")
        Return SeEncuentraValor(pais, listaPaisesConColonias, separador)
    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE ORIGEN
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private INFORMACION_VALIDA_DATOS_ORIGEN As Boolean = False
    Private REMITENTE_ES_PERSONA_MORAL As Boolean = False
    Private REMITENTE_ES_PERSONA_FISICA As Boolean = False
    Private REMITENTE_ES_EXTRANJERO As Boolean = False

    Private txtEstadoOrigen As TextBox
    Private txtLocalidadOrigen As TextBox
    Private txtMunicipioOrigen As TextBox
    Private txtColoniaOrigen As TextBox

    Private refCbEstadoOrigen As ComboBox
    Private refCbMunicipioOrigen As ComboBox
    Private refCbLocalidadOrigen As ComboBox
    Private refCbColoniaOrigen As ComboBox

    Private Sub PreparaPestanaOrigen()
        INFORMACION_VALIDA_DATOS_ORIGEN = False
        refCbEstadoOrigen = cbEstadoRemitente
        refCbMunicipioOrigen = cbMunicipioRemitente
        refCbLocalidadOrigen = cbLocalidadRemitente
        refCbColoniaOrigen = cbColoniaOrigen
        LimpiarDatosOrigen()
        LimpiaDetallesOrigen()
        BindCombobox(cbPaisRemitente, ObtenListadoPaises())
        AddHandler cbPaisRemitente.SelectedValueChanged, AddressOf dtPaisRemitente_SelectedValueChanged
    End Sub

    Private Sub LimpiarDatosOrigen()
        txtRfcRemitente.Text = String.Empty
        txtNombreRemitente.Text = String.Empty
        txtApPaternoRemitente.Text = String.Empty
        txtApMaternoRemitente.Text = String.Empty
        txtNumRegidTribRemitente.Text = String.Empty
        txtPaisResidenciaFiscalRemitente.Text = String.Empty
        LimpiaDesactivaCombobox(cbResidenciaFiscalRemitente)

        REMITENTE_ES_PERSONA_FISICA = True
        REMITENTE_ES_PERSONA_MORAL = False
        REMITENTE_ES_EXTRANJERO = False
        rbPersonaFisicaOrigen.Checked = True
        txtRfcRemitente.Enabled = True
        txtNombreRemitente.Enabled = True
        txtApPaternoRemitente.Enabled = True
        txtApMaternoRemitente.Enabled = True
        LimpiaDesactivaCombobox(cbResidenciaFiscalRemitente)
        LimpiaDesactivaTextbox(txtPaisResidenciaFiscalRemitente)
    End Sub

    Private Sub LimpiaDetallesOrigen()
        txtCpRemitente.Text = String.Empty
        txtNoExtRemitente.Text = String.Empty
        txtNoIntRemitente.Text = String.Empty
        LimpiaDesactivaCombobox(refCbEstadoOrigen)
        LimpiaDesactivaTextbox(txtEstadoOrigen)
        LimpiaDesactivaCombobox(refCbMunicipioOrigen)
        LimpiaDesactivaTextbox(txtMunicipioOrigen)
        LimpiaDesactivaCombobox(refCbLocalidadOrigen)
        LimpiaDesactivaTextbox(txtLocalidadOrigen)
        LimpiaDesactivaCombobox(refCbColoniaOrigen)
        LimpiaDesactivaTextbox(txtColoniaOrigen)
        RemueveDeGrid(txtEstadoOrigen, tlpDetalleDomicilioOrigen)
        RemueveDeGrid(txtMunicipioOrigen, tlpDetalleDomicilioOrigen)
        RemueveDeGrid(txtLocalidadOrigen, tlpDetalleDomicilioOrigen)
        RemueveDeGrid(txtColoniaOrigen, tlpDetalleDomicilioOrigen)
        txtCalleRemitente.Text = String.Empty
        txtReferenciaRemitente.Text = String.Empty
    End Sub

    Private Sub TogglePersonaFisicaMoralExtranjeroOrigen()
        If rbPersonaMoralOrigen.Checked Then
            REMITENTE_ES_PERSONA_MORAL = True
            REMITENTE_ES_PERSONA_FISICA = False
            REMITENTE_ES_EXTRANJERO = False
            txtNombreRemitente.Enabled = True
            txtApPaternoRemitente.Enabled = False
            txtApMaternoRemitente.Enabled = False
            txtRfcRemitente.Enabled = True
            LimpiaDesactivaTextbox(txtNumRegidTribRemitente)
            LimpiaDesactivaTextbox(txtPaisResidenciaFiscalRemitente)
            LimpiaDesactivaCombobox(cbResidenciaFiscalRemitente)
            cbPaisRemitente.SelectedValue = "MEX"
            cbPaisRemitente.Enabled = False

        ElseIf rbPersonaFisicaOrigen.Checked Then
            REMITENTE_ES_PERSONA_MORAL = False
            REMITENTE_ES_PERSONA_FISICA = True
            REMITENTE_ES_EXTRANJERO = False
            txtNombreRemitente.Enabled = True
            txtApPaternoRemitente.Enabled = True
            txtApMaternoRemitente.Enabled = True
            txtRfcRemitente.Enabled = True
            LimpiaDesactivaTextbox(txtNumRegidTribRemitente)
            LimpiaDesactivaTextbox(txtPaisResidenciaFiscalRemitente)
            LimpiaDesactivaCombobox(cbResidenciaFiscalRemitente)
            cbPaisRemitente.SelectedValue = "MEX"
            cbPaisRemitente.Enabled = False

        ElseIf rbExtranjeroOrigen.Checked Then
            REMITENTE_ES_PERSONA_MORAL = False
            REMITENTE_ES_PERSONA_FISICA = False
            REMITENTE_ES_EXTRANJERO = True
            LimpiaDesactivaTextbox(txtRfcRemitente)
            txtRfcRemitente.Text = ObtenParametroPorLlave("RFC_GENERICO_EXTRANJERO")
            txtNumRegIdTribFiscOperador.Enabled = True
            txtNombreRemitente.Enabled = True
            txtApPaternoRemitente.Enabled = True
            txtApMaternoRemitente.Enabled = True
            BindCombobox(cbResidenciaFiscalRemitente, ObtenListadoPaises())
            cbPaisRemitente.SelectedValue = "-01"
            cbPaisRemitente.Enabled = True
        End If
    End Sub

    Private Sub ValidarDatosOrigen()
        INFORMACION_VALIDA_DATOS_ORIGEN = False
        Dim idUbicacion As String = ObtenValorTextbox(txtIdUbicacionOrigen)
        Dim rfcRemitente As String = ObtenValorTextbox(txtRfcRemitente)
        Dim nombreRemitente As String = ObtenValorTextbox(txtNombreRemitente)
        Dim apPaternoRemitente As String = ObtenValorTextbox(txtApPaternoRemitente)
        Dim apMaternoRemitente As String = ObtenValorTextbox(txtApMaternoRemitente)
        Dim numRegIdTribRemitente As String = ObtenValorTextbox(txtNumRegidTribRemitente)

        'La validación de id de origen es de a fuerza
        Dim regExpIdOrigen = ObtenParametroPorLlave("INGRESE_ID_ORIGEN")
        If Not Regex.IsMatch(idUbicacion, regExpIdOrigen) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ID_ORIGEN")) : Return

        'Primero, aplico las validaciones que dependen de un escenario

        If REMITENTE_ES_PERSONA_FISICA Then 'Validaciones exclusivas de la persona física
            Dim longitudRfcPersonaFisica As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_FISICA"))
            Dim regExpRfc = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_FISICA")

            If rfcRemitente.Length <> longitudRfcPersonaFisica Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If Not Regex.IsMatch(rfcRemitente, regExpRfc) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            If EsCadenaVacia(nombreRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoRemitente) And EsCadenaVacia(apMaternoRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            Dim mensajeError As String = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_LETRAS")
            Dim regExpSoloLetras = ObtenParametroPorLlave("REGEXP_CADENA_SOLO_LETRAS")

            If Not Regex.IsMatch(nombreRemitente, regExpSoloLetras) Then
                mensajeError = String.Format(mensajeError, "NOMBRE")
                AlertaMensaje(mensajeError)
                Return
            End If

            If Not EsCadenaVacia(apPaternoRemitente) And Not Regex.IsMatch(apPaternoRemitente, regExpSoloLetras) Then
                mensajeError = String.Format(mensajeError, "APELLIDO PATERNO")
                AlertaMensaje(mensajeError)
                Return
            End If

            If Not EsCadenaVacia(apMaternoRemitente) And Not Regex.IsMatch(apMaternoRemitente, regExpSoloLetras) Then
                mensajeError = String.Format(mensajeError, "APELLIDO MATERNO")
                AlertaMensaje(mensajeError)
                Return
            End If

        ElseIf REMITENTE_ES_PERSONA_MORAL Then 'Validaciones exclusivas de la persona moral
            Dim longitudRfcPersonaMoral As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_MORAL"))
            Dim regExpRfcPersonaMoral = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_MORAL")

            If rfcRemitente.Length <> longitudRfcPersonaMoral Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If Not Regex.IsMatch(rfcRemitente, regExpRfcPersonaMoral) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If EsCadenaVacia(nombreRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return

        ElseIf REMITENTE_ES_EXTRANJERO Then
            If EsCadenaVacia(nombreRemitente) Then AlertaMensaje(ObtenParametroPorLlave("NUM_REG_IDTRIB_NO_VALIDO")) : Return
            If EsCadenaVacia(nombreRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoRemitente) And EsCadenaVacia(apMaternoRemitente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return
            Dim paisResidenciaFiscalRemitente As String = ObtenValorCombobox(cbResidenciaFiscalDestino)
            If paisResidenciaFiscalRemitente = "-01" Then AlertaMensaje(ObtenParametroPorLlave("NUM_REG_IDTRIB_NO_VALIDO")) : Return
        End If

        Dim fechaSalida As Date = dtFechaSalidaRemitente.Value

        Dim longitudHora As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_HORA"))
        Dim regExpHora As String = ObtenParametroPorLlave("REGEXP_HORA")
        Dim horaSalida As String = txtHoraSalidaRemitente.Text
        If horaSalida.Length <> longitudHora Then AlertaMensaje(ObtenParametroPorLlave("HORA_MALFORMADA")) : Return
        If Not Regex.IsMatch(horaSalida, regExpHora) Then AlertaMensaje(ObtenParametroPorLlave("HORA_MALFORMADA")) : Return

        Dim paisSeleccionado As String = ObtenValorCombobox(cbPaisDestino)
        Dim estadoRemitente As String = String.Empty
        Dim municipioRemitente As String = String.Empty
        Dim localidadRemitente As String = String.Empty

        'Valido que el país tenga estados
        If PaisTieneEstados(paisSeleccionado) Then
            If ObtenValorCombobox(refCbEstadoOrigen) = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            estadoRemitente = ObtenValorCombobox(refCbEstadoOrigen)
        Else
            estadoRemitente = ObtenValorTextbox(txtEstadoOrigen)
        End If

        'Ahora, valido que el país tenga municipios y localidades
        If PaisTieneMunicipioLocalidad(paisSeleccionado) Then
            If ObtenValorCombobox(refCbMunicipioOrigen) = "-01" Then ObtenParametroPorLlave("INGRESE_MUNICIPIO") : Return
            If ObtenValorCombobox(refCbLocalidadOrigen) = "-01" Then ObtenParametroPorLlave("INGRESE_LOCALIDAD") : Return
            municipioRemitente = ObtenValorCombobox(refCbMunicipioOrigen)
            localidadRemitente = ObtenValorCombobox(refCbLocalidadOrigen)
        Else
            municipioRemitente = ObtenValorTextbox(txtMunicipioOrigen)
            localidadRemitente = ObtenValorTextbox(txtLocalidadOrigen)
        End If

        'Ahora, valido que el país tenga colonias
        Dim coloniaOrigen As String = String.Empty
        If PaisTieneColonias(paisSeleccionado) Then
            coloniaOrigen = ObtenValorCombobox(refCbColoniaOrigen)
            If coloniaOrigen.Equals("-01") Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        Else
            coloniaOrigen = ObtenValorTextbox(txtColoniaOrigen)
            If EsCadenaVacia(coloniaOrigen) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        End If

        Dim cpRemitente As String = Trim(txtCpRemitente.Text)
        Dim regExpCp As String = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If cpRemitente.Length <> 5 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return
        If Not Regex.IsMatch(cpRemitente, regExpCp) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return

        Dim noExt As String = txtNoExtRemitente.Text
        If EsCadenaVacia(noExt) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NO_EXT")) : Return

        Dim noInt As String = txtNoIntRemitente.Text
        Dim calle As String = ObtenValorTextbox(txtCalleRemitente)
        If EsCadenaVacia(calle) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CALLE")) : Return

        Dim referencia As String = ObtenValorTextbox(txtReferenciaRemitente)

        datosOrigenParaCartaPorte = Nothing
        datosOrigenParaCartaPorte = New OrigenDestino
        datosOrigenParaCartaPorte.TipoUbicacion = txtTipoUbicacion.Text
        datosOrigenParaCartaPorte.IDUbicacion = idUbicacion
        datosOrigenParaCartaPorte.EsDestinoIntermedio = False
        datosOrigenParaCartaPorte.EsPersonaFisica = REMITENTE_ES_PERSONA_FISICA
        datosOrigenParaCartaPorte.EsPersonaMoral = REMITENTE_ES_PERSONA_MORAL
        datosOrigenParaCartaPorte.EsExtranjero = REMITENTE_ES_EXTRANJERO

        If REMITENTE_ES_PERSONA_FISICA Then
            datosOrigenParaCartaPorte.Nombre = nombreRemitente
            datosOrigenParaCartaPorte.ApPaterno = apPaternoRemitente
            datosOrigenParaCartaPorte.ApMaterno = apMaternoRemitente
        ElseIf REMITENTE_ES_PERSONA_MORAL Then
            datosOrigenParaCartaPorte.NombrePersonaMoral = nombreRemitente
        ElseIf REMITENTE_ES_EXTRANJERO Then
            datosOrigenParaCartaPorte.Nombre = nombreRemitente
            datosOrigenParaCartaPorte.ApPaterno = apPaternoRemitente
            datosOrigenParaCartaPorte.ApMaterno = apMaternoRemitente
            datosOrigenParaCartaPorte.NumRegIdTrib = numRegIdTribRemitente
            datosOrigenParaCartaPorte.ResidenciaFiscal = cbResidenciaFiscalRemitente.SelectedValue
        End If

        datosOrigenParaCartaPorte.FechaSalidaLlegada = dtFechaSalidaRemitente.Value
        datosOrigenParaCartaPorte.HoraSalidaLlegada = horaSalida
        datosOrigenParaCartaPorte.DistanciaRecorrida = 0

        Dim domicilio As New Domicilio
        domicilio.Calle = txtCalleRemitente.Text
        domicilio.NumeroExterior = txtNoExtRemitente.Text
        domicilio.NumeroInterior = txtNoIntRemitente.Text
        domicilio.Colonia = coloniaOrigen
        domicilio.Municipio = municipioRemitente
        domicilio.Localidad = localidadRemitente
        domicilio.Estado = estadoRemitente
        domicilio.Pais = paisSeleccionado
        domicilio.Referencia = referencia
        domicilio.CodigoPostal = cpRemitente

        datosOrigenParaCartaPorte.DatosDomicilio = domicilio
        INFORMACION_VALIDA_DATOS_ORIGEN = True
    End Sub

    Private Sub btnSiguienteOrigen_Click(sender As Object, e As EventArgs) Handles btnSiguienteOrigen.Click
        ValidarDatosOrigen()
        If INFORMACION_VALIDA_DATOS_ORIGEN Then
            TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        End If
    End Sub

    Private Sub rbPersonaFisicaOrigen_CheckedChanged(sender As Object, e As EventArgs) Handles rbPersonaFisicaOrigen.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroOrigen()
    End Sub

    Private Sub rbPersonaMoralOrigen_CheckedChanged(sender As Object, e As EventArgs) Handles rbPersonaMoralOrigen.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroOrigen()
    End Sub

    Private Sub rbExtranjeroOrigen_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbExtranjeroOrigen.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroOrigen()
    End Sub

    Private Sub rbExtranjeroOrigen_CheckedChanged(sender As Object, e As EventArgs)
        TogglePersonaFisicaMoralExtranjeroOrigen()
    End Sub

    Private Sub dtPaisRemitente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisRemitente.SelectedValueChanged
        'No interesa proceder si se seleccionó la opc por defecto
        If ObtenValorCombobox(cbPaisRemitente) = "-01" Then
            Return
        End If

        LimpiaDesactivaCombobox(refCbEstadoOrigen)
        LimpiaDesactivaTextbox(txtEstadoOrigen)
        LimpiaDesactivaCombobox(refCbMunicipioOrigen)
        LimpiaDesactivaTextbox(txtMunicipioOrigen)
        LimpiaDesactivaCombobox(refCbLocalidadOrigen)
        LimpiaDesactivaTextbox(txtLocalidadOrigen)
        LimpiaDesactivaCombobox(refCbColoniaOrigen)
        LimpiaDesactivaTextbox(txtColoniaOrigen)

        Dim paisSeleccionado As String = cbPaisRemitente.SelectedValue

        'Tratamiento de estados
        If PaisTieneEstados(paisSeleccionado) Then
            If refCbEstadoOrigen Is Nothing Then 'Tengo que verificar si existen
                refCbEstadoOrigen = New ComboBox
                AddHandler refCbEstadoOrigen.SelectedValueChanged, AddressOf cbEstadoRemitente_SelectedValueChanged
                SustituyeEnGrid(txtEstadoOrigen, refCbEstadoOrigen, tlpDetalleDomicilioOrigen)
            Else
                BindCombobox(refCbEstadoOrigen, ObtenEstadosPorPais(paisSeleccionado))
            End If
        Else
            If txtEstadoOrigen Is Nothing Then
                txtEstadoOrigen = New TextBox
                txtEstadoOrigen.Text = String.Empty
                SustituyeEnGrid(refCbEstadoOrigen, txtEstadoOrigen, tlpDetalleDomicilioOrigen)
            Else
                LimpiaDesactivaCombobox(refCbEstadoOrigen)
            End If
        End If

        'Tratamiento de colonias
        If PaisTieneColonias(paisSeleccionado) Then
            If refCbColoniaOrigen Is Nothing Then
                refCbColoniaOrigen = New ComboBox
                LimpiaDesactivaCombobox(refCbColoniaOrigen)
                SustituyeEnGrid(txtColoniaOrigen, refCbColoniaOrigen, tlpDetalleDomicilioOrigen)
                txtCpRemitente_TextChanged(Nothing, Nothing)
            End If
        Else
            If txtColoniaOrigen Is Nothing Then
                txtColoniaOrigen = New TextBox
                txtColoniaOrigen.Text = String.Empty
                SustituyeEnGrid(refCbColoniaOrigen, txtColoniaOrigen, tlpDetalleDomicilioOrigen)
                LimpiaDesactivaCombobox(refCbColoniaOrigen)
            End If
        End If

        'Tratamiento de municipios y localidades
        If PaisTieneMunicipioLocalidad(paisSeleccionado) Then
            If refCbMunicipioOrigen Is Nothing Then
                refCbMunicipioOrigen = New ComboBox
                LimpiaDesactivaCombobox(refCbMunicipioOrigen)
                SustituyeEnGrid(txtMunicipioOrigen, refCbMunicipioOrigen, tlpDetalleDomicilioOrigen)
            End If
            If refCbLocalidadOrigen Is Nothing Then
                refCbLocalidadOrigen = New ComboBox
                LimpiaDesactivaCombobox(refCbLocalidadOrigen)
                SustituyeEnGrid(txtLocalidadOrigen, refCbLocalidadOrigen, tlpDetalleDomicilioOrigen)
            End If
            cbEstadoRemitente_SelectedValueChanged(Nothing, Nothing)
        Else
            If txtMunicipioOrigen Is Nothing Then
                txtMunicipioOrigen = New TextBox
                txtMunicipioOrigen.Text = String.Empty
                SustituyeEnGrid(refCbMunicipioOrigen, txtMunicipioOrigen, tlpDetalleDomicilioOrigen)
            End If
            If txtLocalidadOrigen Is Nothing Then
                txtLocalidadOrigen = New TextBox
                txtLocalidadOrigen.Text = String.Empty
                SustituyeEnGrid(refCbLocalidadOrigen, txtLocalidadOrigen, tlpDetalleDomicilioOrigen)
            End If
            LimpiaDesactivaCombobox(refCbMunicipioOrigen)
            LimpiaDesactivaCombobox(refCbLocalidadOrigen)
        End If
    End Sub

    Private Sub cbEstadoRemitente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEstadoRemitente.SelectedValueChanged
        If ObtenValorCombobox(refCbEstadoOrigen.SelectedValue) = "-01" Then 'No interesa proceder si seleccionó la opc por defecto
            Return
        End If

        Dim paisSeleccionado = cbPaisRemitente.SelectedValue
        If PaisTieneEstados(paisSeleccionado) Then
            RemueveDeGrid(txtMunicipioOrigen, tlpDetalleDomicilioOrigen)
            RemueveDeGrid(txtLocalidadOrigen, tlpDetalleDomicilioOrigen)
            LimpiaDesactivaCombobox(refCbMunicipioOrigen)
            LimpiaDesactivaCombobox(refCbLocalidadOrigen)
            BindCombobox(refCbMunicipioOrigen, ObtenMunicipiosPorEstado(refCbEstadoOrigen.SelectedValue))
            BindCombobox(refCbLocalidadOrigen, ObtenLocalidadesPorEstado(refCbEstadoOrigen.SelectedValue))
        End If
    End Sub

    Private Sub cbResidenciaFiscalRemitente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbResidenciaFiscalRemitente.SelectedValueChanged
        txtPaisResidenciaFiscalRemitente.Enabled = False
        If ObtenValorCombobox(cbResidenciaFiscalRemitente) = "-01" Then Return
        If REMITENTE_ES_EXTRANJERO Then
            Dim cvePais As String = cbResidenciaFiscalRemitente.SelectedValue
            txtPaisResidenciaFiscalRemitente.Text = ObtenDescripcionPais(cvePais)
        End If
    End Sub

    Private Sub gbOrigenPersonaFisicaMoral_Enter(sender As Object, e As EventArgs) Handles gbOrigenPersonaFisicaMoral.Enter

    End Sub

    Private Sub txtCpRemitente_TextChanged(sender As Object, e As EventArgs) Handles txtCpRemitente.TextChanged
        If Trim(txtCpRemitente.Text).Length <> 5 Then '5 es la longitud de un CP válido
            Return
        End If

        If txtColoniaOrigen IsNot Nothing Then 'No tiene caso cargar el catálogo si hay un país sin catalogo de colonias
            Return
        End If

        LimpiaDesactivaCombobox(refCbColoniaOrigen)
        Dim regExpCP As String = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If Regex.IsMatch(Trim(txtCpRemitente.Text), regExpCP) Then
            Dim coloniasPorCodigoPostal = ObtenColoniasPorCodigoPostal(txtCpRemitente.Text)
            BindCombobox(refCbColoniaOrigen, coloniasPorCodigoPostal)
        End If
    End Sub

    Private Sub CargaDatosOrigen()
        If datosOrigenParaCartaPorte IsNot Nothing Then
            txtTipoUbicacion.Text = "ORIGEN"
            txtIdUbicacionOrigen.Text = datosOrigenParaCartaPorte.IDUbicacion
            rbPersonaFisicaOrigen.Checked = datosOrigenParaCartaPorte.EsPersonaFisica
            rbPersonaMoralOrigen.Checked = datosOrigenParaCartaPorte.EsPersonaMoral
            rbExtranjeroOrigen.Checked = datosOrigenParaCartaPorte.EsExtranjero
            txtRfcRemitente.Text = datosOrigenParaCartaPorte.RFCRemitenteDestinatario
            txtNumRegidTribRemitente.Text = datosOrigenParaCartaPorte.NumRegIdTrib
            If REMITENTE_ES_EXTRANJERO Then
                cbResidenciaFiscalRemitente.SelectedValue = datosOrigenParaCartaPorte.ResidenciaFiscal
            End If
            Dim dom = datosOrigenParaCartaPorte.DatosDomicilio
            cbPaisRemitente.SelectedValue = dom.Pais

            'Cargo estados
            If refCbEstadoOrigen IsNot Nothing Then
                refCbEstadoOrigen.SelectedValue = dom.Estado
            Else
                txtEstadoOrigen.Text = dom.Estado
            End If

            'Cargo municipios y localidades
            If refCbMunicipioOrigen IsNot Nothing Then
                refCbMunicipioOrigen.SelectedValue = dom.Municipio
                refCbLocalidadOrigen.SelectedValue = dom.Localidad
            Else
                txtMunicipioOrigen.Text = dom.Municipio
                txtLocalidadOrigen.Text = dom.Localidad
            End If
            txtCpRemitente.Text = dom.CodigoPostal
            'Cargo colonias
            If refCbColoniaOrigen IsNot Nothing Then
                refCbColoniaOrigen.SelectedValue = dom.Colonia
            Else
                txtColoniaOrigen.Text = dom.Colonia
            End If
            txtNoExtRemitente.Text = dom.NumeroExterior
            txtNoIntRemitente.Text = dom.NumeroInterior
            txtCalleRemitente.Text = dom.Calle
            txtReferenciaRemitente.Text = dom.Referencia
        End If
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE DESTINO
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private txtColoniaDestino As TextBox = Nothing
    Private txtEstadoDestino As TextBox = Nothing
    Private txtMunicipioDestino As TextBox = Nothing
    Private txtLocalidadDestino As TextBox = Nothing
    Private refCbColoniaDestino As ComboBox
    Private refCbMunicipioDestino As ComboBox
    Private refCbLocalidadDestino As ComboBox
    Private refCbEstadoDestino As ComboBox
    Private ES_PERSONA_FISICA_DESTINO As Boolean = False
    Private ES_PERSONA_MORAL_DESTINO As Boolean = False
    Private ES_EXTRANJERO_DESTINO As Boolean = False
    Private INFORMACION_VALIDA_DESTINO As Boolean = False

    Private Sub PreparaPestanaDestino()
        BindCombobox(cbPaisDestino, ObtenListadoPaises())
        refCbColoniaDestino = cbColoniaDestino
        refCbMunicipioDestino = cbMunicipioDestino
        refCbLocalidadDestino = cbLocalidadDestino
        refCbEstadoDestino = cbEstadoDestino
        LimpiarDatosDestino()
        LimpiarDatosOrigen()
    End Sub

    Private Sub LimpiarDatosDestino()
        LimpiaDesactivaTextbox(txtRfcDestino)
        LimpiaDesactivaTextbox(txtNombreDestino)
        LimpiaDesactivaTextbox(txtApPaternoDestino)
        LimpiaDesactivaTextbox(txtApMaternoDestino)
        LimpiaDesactivaTextbox(txtNumIdRegFiscalDestino)
        LimpiaDesactivaTextbox(txtResidenciaFiscalDestino)
        LimpiaDesactivaCombobox(cbResidenciaFiscalDestino)
    End Sub

    Private Sub LimpiaDetallesDestino()
        LimpiaDesactivaCombobox(refCbEstadoDestino)
        LimpiaDesactivaCombobox(refCbMunicipioDestino)
        LimpiaDesactivaCombobox(refCbLocalidadDestino)
        LimpiaDesactivaCombobox(refCbColoniaDestino)
        txtCpDestino.Text = String.Empty
        txtNoExtDestino.Text = String.Empty
        txtNoIntDestino.Text = String.Empty
        txtCalleDestino.Text = String.Empty
        txtReferenciaDestino.Text = String.Empty
        txtMunicipioDestino = Nothing
        txtLocalidadDestino = Nothing
        txtEstadoDestino = Nothing
        txtColoniaDestino = Nothing
    End Sub

    Private Sub TogglePersonaFisicaMoralExtranjeroDestino()
        LimpiarDatosDestino()
        If rbPersonaFisicaDestino.Checked Then
            ES_PERSONA_FISICA_DESTINO = True
            ES_PERSONA_MORAL_DESTINO = False
            ES_EXTRANJERO_DESTINO = False
            cbPaisDestino.SelectedValue = "MEX"
            cbPaisDestino.Enabled = False
            txtRfcDestino.Enabled = True
            txtNombreDestino.Enabled = True
            txtApPaternoDestino.Enabled = True
            txtApMaternoDestino.Enabled = True
        ElseIf rbPersonaMoralDestino.Checked Then
            ES_PERSONA_FISICA_DESTINO = False
            ES_PERSONA_MORAL_DESTINO = True
            ES_EXTRANJERO_DESTINO = False
            cbPaisDestino.SelectedValue = "MEX"
            cbPaisDestino.Enabled = False
            txtRfcDestino.Enabled = True
            txtNombreDestino.Enabled = True
        ElseIf rbEsExtranjeroDestino.Checked Then
            ES_PERSONA_FISICA_DESTINO = False
            ES_PERSONA_MORAL_DESTINO = False
            ES_EXTRANJERO_DESTINO = True
            cbPaisDestino.SelectedValue = "-01"
            cbPaisDestino.Enabled = True
            BindCombobox(cbResidenciaFiscalDestino, ObtenListadoPaises())
            txtRfcDestino.Text = ObtenParametroPorLlave("RFC_GENERICO_EXTRANJERO")
            txtRfcDestino.Enabled = False
            txtNombreDestino.Enabled = True
            txtApPaternoDestino.Enabled = True
            txtApMaternoDestino.Enabled = True
            txtNumIdRegFiscalDestino.Enabled = True
        End If
    End Sub

    Private Sub rbPersonaFisicaDestino_CheckedChanged(sender As Object, e As EventArgs) Handles rbPersonaFisicaDestino.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroDestino()
    End Sub

    Private Sub rbPersonaMoralDestino_CheckedChanged(sender As Object, e As EventArgs) Handles rbPersonaMoralDestino.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroDestino()
    End Sub

    Private Sub rbEsExtranjeroDestino_CheckedChanged(sender As Object, e As EventArgs) Handles rbEsExtranjeroDestino.CheckedChanged
        TogglePersonaFisicaMoralExtranjeroDestino()
    End Sub

    Private Sub cbResidenciaFiscalDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbResidenciaFiscalDestino.SelectedValueChanged
        txtResidenciaFiscalDestino.Enabled = False
        If ES_EXTRANJERO_DESTINO Then
            If cbResidenciaFiscalDestino.SelectedValue = "-01" Then Return
            txtResidenciaFiscalDestino.Text = ObtenDescripcionPais(cbResidenciaFiscalDestino.SelectedValue)
        End If
    End Sub


    Private Sub cbPaisDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisDestino.SelectedValueChanged
        Dim paisDestino = ObtenValorCombobox(cbPaisDestino)
        If paisDestino = "-01" Then Return

        'Primero, validación de estados
        If PaisTieneEstados(paisDestino) Then
            If refCbEstadoDestino Is Nothing Then
                refCbEstadoDestino = New ComboBox
                LimpiaDesactivaCombobox(refCbEstadoDestino)
                BindCombobox(refCbEstadoDestino, ObtenEstadosPorPais(paisDestino))
                SustituyeEnGrid(txtEstadoDestino, refCbEstadoDestino, tlpDatosDestino)
                AddHandler refCbEstadoDestino.SelectedValueChanged, AddressOf cbEstadoDestino_SelectedValueChanged
            End If
        Else
            If txtEstadoDestino Is Nothing Then
                txtEstadoDestino = New TextBox
                txtEstadoDestino.Text = String.Empty
                LimpiaDesactivaCombobox(refCbEstadoDestino)
                SustituyeEnGrid(refCbEstadoDestino, txtEstadoDestino, tlpDatosDestino)
            End If
        End If

        'Después, validación de municipios y localidades
        If PaisTieneMunicipioLocalidad(paisDestino) Then
            If refCbMunicipioDestino Is Nothing Then
                refCbMunicipioDestino = New ComboBox
                LimpiaDesactivaCombobox(refCbMunicipioDestino)
                SustituyeEnGrid(txtMunicipioDestino, refCbMunicipioDestino, tlpDatosDestino)
            End If
            If refCbLocalidadDestino Is Nothing Then
                refCbLocalidadDestino = New ComboBox
                LimpiaDesactivaCombobox(refCbLocalidadDestino)
                SustituyeEnGrid(txtLocalidadDestino, refCbLocalidadDestino, tlpDatosDestino)
            End If
            cbEstadoDestino_SelectedValueChanged(Nothing, Nothing)
        Else
            If txtMunicipioDestino Is Nothing Then
                txtMunicipioDestino = New TextBox
                txtMunicipioDestino.Text = String.Empty
                SustituyeEnGrid(refCbMunicipioDestino, txtMunicipioDestino, tlpDatosDestino)
            End If
            If txtLocalidadDestino Is Nothing Then
                txtLocalidadDestino = New TextBox
                txtLocalidadDestino.Text = String.Empty
                SustituyeEnGrid(refCbLocalidadDestino, txtLocalidadDestino, tlpDatosDestino)
            End If
        End If

        'Ahora, toca la misma validación, pero en colonias
        If PaisTieneColonias(paisDestino) Then
            If refCbColoniaDestino Is Nothing Then
                refCbColoniaDestino = New ComboBox
                LimpiaDesactivaCombobox(refCbColoniaDestino)
                SustituyeEnGrid(txtColoniaDestino, refCbColoniaDestino, tlpDatosDestino)
                txtCpDestino_TextChanged(Nothing, Nothing)
            End If
        Else
            If txtColoniaDestino Is Nothing Then
                txtColoniaDestino = New TextBox
                txtColoniaDestino.Text = String.Empty
                SustituyeEnGrid(txtColoniaDestino, refCbColoniaDestino, tlpDatosDestino)
            End If
        End If
    End Sub

    Private Sub cbEstadoDestino_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEstadoDestino.SelectedValueChanged
        If ObtenValorCombobox(refCbEstadoDestino) = "-01" Then Return

        Dim paisDestino = cbPaisDestino.SelectedValue
        'Si no tenemos los municipios y localidad, ni caso tiene seguir
        If Not PaisTieneEstados(paisDestino) Then
            Return
        End If

        BindCombobox(refCbMunicipioDestino, ObtenMunicipiosPorEstado(ObtenValorCombobox(refCbEstadoDestino)))
        BindCombobox(refCbLocalidadDestino, ObtenLocalidadesPorEstado(ObtenValorCombobox(refCbEstadoDestino)))
    End Sub

    Private Sub txtCpDestino_TextChanged(sender As Object, e As EventArgs) Handles txtCpDestino.TextChanged
        Dim cp As String = ObtenValorTextbox(txtCpDestino)
        If cp.Length <> 5 Then Return '5 es la longitud de un código postal válido

        Dim paisDestino = ObtenValorCombobox(cbPaisDestino)
        If PaisTieneColonias(paisDestino) Then 'Si tenemos un país con colonias
            If Regex.IsMatch(cp, ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")) Then 'Y es un CP válido
                BindCombobox(refCbColoniaDestino, ObtenColoniasPorCodigoPostal(cp))
                Return
            End If
        End If
    End Sub

    Private Sub btnSiguienteDestino_Click(sender As Object, e As EventArgs) Handles btnSiguienteDestino.Click
        ValidarDatosDestino()
        If INFORMACION_VALIDA_DESTINO Then
            TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnAtrasDestino_Click(sender As Object, e As EventArgs) Handles btnAtrasDestino.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
    End Sub

    Private Sub ValidarDatosDestino()
        datosDestinoParaCartaPorte = Nothing
        INFORMACION_VALIDA_DESTINO = False
        Dim tipoUbicacion = ObtenValorTextbox(txtTipoUbicacionDestino)
        Dim idUbicacion = ObtenValorTextbox(txtIdUbicacionDestino)
        Dim rfcDestino As String = String.Empty
        Dim nombreDestino As String = String.Empty
        Dim apPaternoDestino As String = String.Empty
        Dim apMaternoDestino As String = String.Empty
        Dim residenciaFiscalDestino As String = String.Empty
        Dim numRegIdFiscalDestino As String = String.Empty

        If ES_PERSONA_FISICA_DESTINO Then 'Validaciones de persona física
            rfcDestino = ObtenValorTextbox(txtRfcDestino)
            Dim longitudRfcPersonaFisica As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_FISICA"))
            If rfcDestino.Length <> longitudRfcPersonaFisica Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If Not Regex.IsMatch(rfcDestino, ObtenParametroPorLlave("REGEXP_RFC_PERSONA_FISICA")) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            nombreDestino = ObtenValorTextbox(txtNombreDestino)
            apPaternoDestino = ObtenValorTextbox(txtApPaternoDestino)
            apMaternoDestino = ObtenValorTextbox(txtApMaternoDestino)

            If EsCadenaVacia(nombreDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoDestino) And EsCadenaVacia(apMaternoDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            Dim mensajeError As String = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_LETRAS")
            Dim regExpSoloLetras = ObtenParametroPorLlave("REGEXP_CADENA_SOLO_LETRAS")
            If Not Regex.IsMatch(nombreDestino, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return
            If Not EsCadenaVacia(apPaternoDestino) And Not Regex.IsMatch(apPaternoDestino, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return
            If Not EsCadenaVacia(apMaternoDestino) And Not Regex.IsMatch(apMaternoDestino, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return

        ElseIf ES_PERSONA_MORAL_DESTINO Then 'Validaciones de persona moral
            rfcDestino = ObtenValorTextbox(txtRfcDestino)
            nombreDestino = ObtenValorTextbox(txtNombreDestino)
            Dim longitudRfcDestino As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_MORAL"))
            If rfcDestino.Length <> longitudRfcDestino Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            Dim regExpRfcPersonaMoral = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_MORAL")
            If Not Regex.IsMatch(rfcDestino, regExpRfcPersonaMoral) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If EsCadenaVacia(nombreDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return

        ElseIf ES_EXTRANJERO_DESTINO Then 'Validaciones de extranjero
            nombreDestino = ObtenValorTextbox(txtNombreDestino)
            apPaternoDestino = ObtenValorTextbox(txtApPaternoDestino)
            apMaternoDestino = ObtenValorTextbox(txtApMaternoDestino)

            If EsCadenaVacia(nombreDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoDestino) And EsCadenaVacia(apMaternoDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            numRegIdFiscalDestino = ObtenValorTextbox(txtNumIdRegFiscalDestino)
            If cbResidenciaFiscalDestino.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("Es necesario que ingrese una residencia fiscal")) : Return
            residenciaFiscalDestino = cbResidenciaFiscalDestino.SelectedValue
        End If

        Dim fechaLlegadaDestino As Date
        Dim horaLlegada As String = String.Empty
        fechaLlegadaDestino = dtFechaSalidaDestino.Value

        If fechaLlegadaDestino < datosOrigenParaCartaPorte.FechaSalidaLlegada Then AlertaMensaje(ObtenParametroPorLlave("FECHA_LLEGADA_FINAL_INCORRECTA")) : Return
        horaLlegada = ObtenValorTextbox(txtHoraSalidaDestino)
        If horaLlegada.Length <> 5 Then AlertaMensaje(ObtenParametroPorLlave("HORA_MALFORMADA")) : Return

        Dim regExpHoras = ObtenParametroPorLlave("REGEXP_HORA")
        If Not Regex.IsMatch(horaLlegada, regExpHoras) Then AlertaMensaje(ObtenParametroPorLlave("HORA_MALFORMADA")) : Return

        Dim paisDestino As String = String.Empty
        Dim estadoDestino As String = String.Empty
        Dim municipioDestino As String = String.Empty
        Dim localidadDestino As String = String.Empty
        Dim coloniaDestino As String = String.Empty
        Dim calleDestino As String = String.Empty
        Dim referenciaDestino As String = String.Empty
        Dim CPDestino As String = String.Empty
        Dim noExtDestino As String = String.Empty
        Dim noIntDestino As String = String.Empty

        paisDestino = ObtenValorCombobox(cbPaisDestino)
        If REMITENTE_ES_EXTRANJERO Then 'Aquí no puedo tomar simplemente los valores de los combo
            'Tengo que hacer un montón de validaciones
            'Primero veo de donde tengo que obtener el estado
            If PaisTieneEstados(paisDestino) Then
                estadoDestino = ObtenValorCombobox(refCbEstadoDestino)
                If estadoDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            Else
                estadoDestino = ObtenValorTextbox(txtEstadoDestino)
                If EsCadenaVacia(estadoDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            End If

            If PaisTieneMunicipioLocalidad(paisDestino) Then
                municipioDestino = ObtenValorCombobox(refCbMunicipioDestino)
                localidadDestino = ObtenValorCombobox(refCbLocalidadDestino)
                If municipioDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
                If localidadDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return
            Else
                municipioDestino = ObtenValorTextbox(txtMunicipioDestino)
                localidadDestino = ObtenValorTextbox(txtLocalidadDestino)
            End If

            If PaisTieneColonias(paisDestino) Then
                coloniaDestino = ObtenValorCombobox(refCbColoniaDestino)
                If coloniaDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
            Else
                coloniaDestino = ObtenValorTextbox(txtColoniaDestino)
                If EsCadenaVacia(coloniaDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
            End If
        Else
            estadoDestino = ObtenValorCombobox(refCbEstadoDestino)
            municipioDestino = ObtenValorCombobox(refCbMunicipioDestino)
            localidadDestino = ObtenValorCombobox(refCbLocalidadDestino)
            If municipioDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            If localidadDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return

            coloniaDestino = ObtenValorCombobox(refCbColoniaDestino)
            If cbColoniaDestino.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        End If

        CPDestino = ObtenValorTextbox(txtCpDestino)
        Dim regExpCp = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If CPDestino.Length <> 5 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return
        If Not Regex.IsMatch(CPDestino, regExpCp) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return

        noExtDestino = ObtenValorTextbox(txtNoExtDestino)
        If EsCadenaVacia(noExtDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NO_EXT")) : Return

        noIntDestino = ObtenValorTextbox(txtNoIntDestino)

        calleDestino = ObtenValorTextbox(txtCalleDestino)
        If EsCadenaVacia(calleDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CALLE")) : Return

        referenciaDestino = ObtenValorTextbox(txtReferenciaDestino)

        Dim kmRecorridos As Int32 = nupKmRecorridos.Value
        If kmRecorridos <= 0 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_KILOMETROS_RECORRIDOS")) : Return

        datosDestinoParaCartaPorte = New OrigenDestino
        datosDestinoParaCartaPorte.TipoUbicacion = tipoUbicacion
        datosDestinoParaCartaPorte.IDUbicacion = idUbicacion
        datosDestinoParaCartaPorte.RFCRemitenteDestinatario = rfcDestino
        If ES_PERSONA_MORAL_DESTINO Then
            datosDestinoParaCartaPorte.NombrePersonaMoral = nombreDestino
        Else
            datosDestinoParaCartaPorte.NombrePersonaMoral = String.Empty
        End If
        datosDestinoParaCartaPorte.Nombre = nombreDestino
        datosDestinoParaCartaPorte.ApPaterno = apPaternoDestino
        datosDestinoParaCartaPorte.ApMaterno = apMaternoDestino
        datosDestinoParaCartaPorte.ResidenciaFiscal = residenciaFiscalDestino
        datosDestinoParaCartaPorte.NumRegIdTrib = numRegIdFiscalDestino
        datosDestinoParaCartaPorte.FechaSalidaLlegada = fechaLlegadaDestino
        datosDestinoParaCartaPorte.HoraSalidaLlegada = horaLlegada
        datosDestinoParaCartaPorte.DistanciaRecorrida = kmRecorridos
        datosDestinoParaCartaPorte.EsPersonaFisica = ES_PERSONA_FISICA_DESTINO
        datosDestinoParaCartaPorte.EsPersonaMoral = ES_PERSONA_MORAL_DESTINO
        datosDestinoParaCartaPorte.EsExtranjero = ES_EXTRANJERO_DESTINO

        Dim domicilio As New Domicilio
        domicilio.Calle = calleDestino
        domicilio.NumeroExterior = noExtDestino
        domicilio.NumeroInterior = noIntDestino
        domicilio.Colonia = coloniaDestino
        domicilio.Localidad = localidadDestino
        domicilio.Municipio = municipioDestino
        domicilio.Estado = estadoDestino
        domicilio.Pais = paisDestino
        domicilio.Referencia = referenciaDestino
        domicilio.CodigoPostal = CPDestino
        datosDestinoParaCartaPorte.DatosDomicilio = domicilio
        INFORMACION_VALIDA_DESTINO = True
    End Sub

    Private Sub CargaDatosDestino()
        If datosDestinoParaCartaPorte IsNot Nothing Then
            txtTipoUbicacionDestino.Text = "DESTINO"
            txtIdUbicacionDestino.Text = datosDestinoParaCartaPorte.IDUbicacion
            rbEsExtranjeroDestino.Checked = datosDestinoParaCartaPorte.EsExtranjero
            rbPersonaFisicaDestino.Checked = datosDestinoParaCartaPorte.EsPersonaFisica
            rbPersonaMoralDestino.Checked = datosDestinoParaCartaPorte.EsPersonaMoral
            txtRfcDestino.Text = datosDestinoParaCartaPorte.RFCRemitenteDestinatario
            txtNombreDestino.Text = datosDestinoParaCartaPorte.Nombre
            txtApPaternoDestino.Text = datosDestinoParaCartaPorte.ApPaterno
            txtApMaternoDestino.Text = datosDestinoParaCartaPorte.ApMaterno
            txtNumIdRegFiscalDestino.Text = datosDestinoParaCartaPorte.NumRegIdTrib

            If ES_EXTRANJERO_DESTINO Then
                cbResidenciaFiscalDestino.SelectedValue = datosDestinoParaCartaPorte.ResidenciaFiscal
                dtFechaSalidaDestino.Value = datosDestinoParaCartaPorte.FechaSalidaLlegada
                txtHoraSalidaDestino.Text = datosDestinoParaCartaPorte.HoraSalidaLlegada
                nupKmRecorridos.Value = datosDestinoParaCartaPorte.DistanciaRecorrida
            End If

            Dim dom As Domicilio = datosDestinoParaCartaPorte.DatosDomicilio
            cbPaisDestino.SelectedValue = dom.Pais
            If refCbEstadoDestino IsNot Nothing Then
                refCbEstadoDestino.SelectedValue = dom.Estado
            Else
                txtEstadoDestino.Text = dom.Estado
            End If

            If refCbMunicipioDestino IsNot Nothing Then
                refCbMunicipioDestino.SelectedValue = dom.Municipio
                refCbLocalidadDestino.SelectedValue = dom.Localidad
            Else
                txtMunicipioDestino.Text = dom.Municipio
                txtLocalidadDestino.Text = dom.Localidad
            End If

            txtCpDestino.Text = dom.CodigoPostal
            If refCbColoniaDestino IsNot Nothing Then
                refCbColoniaDestino.SelectedValue = dom.Colonia
            Else
                txtColoniaDestino.Text = dom.Colonia
            End If

            txtNoExtDestino.Text = dom.NumeroExterior
            txtNoIntDestino.Text = dom.NumeroInterior
            txtCalleDestino.Text = dom.Calle
            txtReferenciaDestino.Text = dom.Referencia
        End If
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE DESTINOS INTERMEDIOS
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub BindGridDestinosIntermedios()
        If dgvCartaPorteDestinosIntermedios.Rows IsNot Nothing Then
            dgvCartaPorteDestinosIntermedios.Rows.Clear()
        End If
        dgvCartaPorteDestinosIntermedios.DataSource = Nothing
        dgvCartaPorteDestinosIntermedios.AutoGenerateColumns = False
        dgvCartaPorteDestinosIntermedios.Columns("DIMovimientoClm").DataPropertyName = NameOf(OrigenDestino.Movimiento)
        dgvCartaPorteDestinosIntermedios.Columns("DIDestinoClm").DataPropertyName = NameOf(OrigenDestino.DestinoDesplegado)
        dgvCartaPorteDestinosIntermedios.Columns("DIFechaLlegadaClm").DataPropertyName = NameOf(OrigenDestino.FechaSalidaLlegada)
        dgvCartaPorteDestinosIntermedios.Columns("DIHoraLlegadaClm").DataPropertyName = NameOf(OrigenDestino.HoraSalidaLlegada)
        dgvCartaPorteDestinosIntermedios.Columns("DIKmClm").DataPropertyName = NameOf(OrigenDestino.DistanciaRecorrida)
        dgvCartaPorteDestinosIntermedios.Columns("IDUbicacionClm").DataPropertyName = NameOf(OrigenDestino.IDUbicacion)
        dgvCartaPorteDestinosIntermedios.DataSource = datosDestinosIntermediosParaCartaPorte
    End Sub

    Private txtEstadoDestinoIntermedio As TextBox = Nothing
    Private txtMunicipioDestinoIntermedio As TextBox = Nothing
    Private txtLocalidadDestinoIntermedio As TextBox = Nothing
    Private txtColoniaDestinoIntermedio As TextBox = Nothing
    Private refCbEstadoDestinoIntermedio As ComboBox = Nothing
    Private refCbMunicipioDestinoIntermedio As ComboBox = Nothing
    Private refCbLocalidadDestinoIntermedio As ComboBox = Nothing
    Private refCbColoniaDestinoIntermedio As ComboBox = Nothing

    Private ES_PERSONA_MORAL_DESTINO_INTERMEDIO As Boolean = False
    Private ES_PERSONA_FISICA_DESTINO_INTERMEDIO As Boolean = False
    Private ES_EXTRANJERO_DESTINO_INTERMEDIO As Boolean = False
    Private INFORMACION_VALIDA_DESTINO_INTERMEDIO As Boolean = False
    Private ESTA_CREANDO_DESTINO_INTERMEDIO As Boolean = False
    Private ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO As Boolean = False

    Private Sub PreparaPestanaDestinoIntermedio()
        BindCombobox(cbPaisDestinoIntermedio, ObtenListadoPaises())
        BindGridDestinosIntermedios()
        rbEsPersonaFisicaDestinoIntermedio.Enabled = False
        rbEsPersonaFisicaDestinoIntermedio.Checked = True
        rbEsExtranjeroDestinoIntermedio.Enabled = False
        rbEsPersonaMoralDestinoIntermedio.Enabled = False
    End Sub

    Private Sub ActivaModificacionDestinoIntermedio()
        txtIdUbicacionDestinoIntermedio.Enabled = True
        rbEsPersonaFisicaDestinoIntermedio.Enabled = True
        rbEsPersonaMoralDestinoIntermedio.Enabled = True
        rbEsExtranjeroDestinoIntermedio.Enabled = True
        dtFechaLlegadaDestinoIntermedio.Enabled = True
        txtHoraLlegadaDestinoIntermedio.Enabled = True
        nupKmDestinoIntermedio.Maximum = ObtenKilometrosDisponibles()
        nupKmDestinoIntermedio.Minimum = 0
        nupKmDestinoIntermedio.Enabled = True
        cbPaisDestinoIntermedio.Enabled = True
        txtNoExtDestinoIntermedio.Enabled = True
        txtNoIntDestinoIntermedio.Enabled = True
        txtCalleDestinoIntermedio.Enabled = True
        txtReferenciaDestinoIntermedio.Enabled = True
    End Sub

    Private Sub LimpiaDatosResidenciaFiscalDestinoIntermedio()
        txtTipoUbicacionDestinoIntermedio.Text = "DESTINO"
        txtTipoUbicacionDestinoIntermedio.Enabled = False
        nupKmDestinoIntermedio.Value = 1
        nupKmDestinoIntermedio.Enabled = False
        LimpiaDesactivaCombobox(cbPaisResidenciaFiscalDestinoIntermedio)
        txtHoraLlegadaDestinoIntermedio.Text = "00:00"
        nupKmDestinoIntermedio.Minimum = 0
        nupKmDestinoIntermedio.Maximum = datosDestinoParaCartaPorte.DistanciaRecorrida
        LimpiaDesactivaTextbox(txtIdUbicacionDestinoIntermedio)
        LimpiaDesactivaTextbox(txtRfcDestinoIntermedio)
        LimpiaDesactivaTextbox(txtNombreDestinoIntermedio)
        LimpiaDesactivaTextbox(txtApPaternoDestinoIntermedio)
        LimpiaDesactivaTextbox(txtApMaternoDestinoIntermedio)
        LimpiaDesactivaTextbox(txtPaisResidenciaFiscalDestinoIntermedio)
    End Sub

    Private Sub LimpiaDetallesDestinoIntermedio()
        RemueveDeGrid(txtEstadoDestinoIntermedio, tlpDetallesDestinoIntermedio)
        RemueveDeGrid(txtMunicipioDestinoIntermedio, tlpDetallesDestinoIntermedio)
        RemueveDeGrid(txtLocalidadDestinoIntermedio, tlpDetallesDestinoIntermedio)
        RemueveDeGrid(txtColoniaDestinoIntermedio, tlpDetallesDestinoIntermedio)
        LimpiaDesactivaCombobox(cbPaisDestinoIntermedio)
        LimpiaDesactivaCombobox(refCbEstadoDestinoIntermedio)
        LimpiaDesactivaCombobox(refCbMunicipioDestinoIntermedio)
        LimpiaDesactivaCombobox(refCbLocalidadDestinoIntermedio)
        txtCpDestinoIntermedio.Text = String.Empty
        LimpiaDesactivaTextbox(txtNoExtDestinoIntermedio)
        LimpiaDesactivaTextbox(txtNoIntDestinoIntermedio)
        LimpiaDesactivaTextbox(txtCalleDestinoIntermedio)
        LimpiaDesactivaTextbox(txtReferenciaDestinoIntermedio)
        BindCombobox(cbPaisDestinoIntermedio, ObtenListadoPaises())
    End Sub

    Private Sub TogglePersonaMoralFisicaExtranjeroDestinoIntermedio()
        LimpiaDatosResidenciaFiscalDestinoIntermedio()
        rbEsPersonaFisicaDestinoIntermedio.Enabled = True
        rbEsPersonaMoralDestinoIntermedio.Enabled = True
        rbEsExtranjeroDestinoIntermedio.Enabled = True

        If rbEsPersonaFisicaDestinoIntermedio.Checked Then
            ES_PERSONA_MORAL_DESTINO_INTERMEDIO = False
            ES_PERSONA_FISICA_DESTINO_INTERMEDIO = True
            ES_EXTRANJERO_DESTINO_INTERMEDIO = False
            txtIdUbicacionDestinoIntermedio.Enabled = True
            txtRfcDestinoIntermedio.Enabled = True
            txtNombreDestinoIntermedio.Enabled = True
            txtApPaternoDestinoIntermedio.Enabled = True
            txtApMaternoDestinoIntermedio.Enabled = True
            cbPaisDestinoIntermedio.SelectedValue = "MEX"
            cbPaisDestinoIntermedio.Enabled = False

        ElseIf rbEsPersonaMoralDestinoIntermedio.Checked Then
            ES_PERSONA_MORAL_DESTINO_INTERMEDIO = True
            ES_PERSONA_FISICA_DESTINO_INTERMEDIO = False
            ES_EXTRANJERO_DESTINO_INTERMEDIO = False
            txtRfcDestinoIntermedio.Enabled = True
            txtNombreDestinoIntermedio.Enabled = True
            cbPaisDestinoIntermedio.SelectedValue = "MEX"
            cbPaisDestinoIntermedio.Enabled = False

        ElseIf rbEsExtranjeroDestinoIntermedio.Checked Then
            ES_PERSONA_MORAL_DESTINO_INTERMEDIO = False
            ES_PERSONA_FISICA_DESTINO_INTERMEDIO = False
            ES_EXTRANJERO_DESTINO_INTERMEDIO = True

            txtRfcDestinoIntermedio.Text = ObtenParametroPorLlave("RFC_GENERICO_EXTRANJERO")
            txtRfcDestinoIntermedio.Enabled = False
            txtNumregIdTribDestinoIntermedio.Enabled = True
            txtNombreDestinoIntermedio.Enabled = True
            txtApPaternoDestinoIntermedio.Enabled = True
            txtApMaternoDestinoIntermedio.Enabled = True
            cbPaisDestinoIntermedio.SelectedValue = "-01"
            cbPaisDestinoIntermedio.Enabled = True
        End If
    End Sub

    Private Sub ValidarDatosDestinoIntermedio()
        INFORMACION_VALIDA_DESTINO_INTERMEDIO = False

        If datosDestinoIntermedioEnModificacion Is Nothing Then
            datosDestinoIntermedioEnModificacion = New OrigenDestino
        End If

        Dim tipoUbicacionDestInter As String = "DESTINO"
        Dim idUbicacionDestInter As String = ObtenValorTextbox(txtIdUbicacionDestinoIntermedio)

        'Si esta creando uno desde 0, tengo que verificar que la información no esté duplicada
        If ESTA_CREANDO_DESTINO_INTERMEDIO Then
            Dim existeObj As OrigenDestino = datosDestinosIntermediosParaCartaPorte.Find(Function(obj) obj.IDUbicacion.Equals(idUbicacionDestInter))
            If (existeObj IsNot Nothing) Or idUbicacionDestInter.Equals(datosDestinoParaCartaPorte.IDUbicacion) Then
                AlertaMensaje(ObtenParametroPorLlave("ID_UBICACION_REPETIDO"))
                Return
            End If
        End If

        Dim rfcRemitenteDestInter As String = String.Empty
        Dim nombreDestInter As String = String.Empty
        Dim apPaternoDestInter As String = String.Empty
        Dim apMaternoDestInter As String = String.Empty
        Dim paisResidenciaDestFiscal As String = String.Empty
        Dim numRegIdTribDestInter As String = String.Empty


        If ES_PERSONA_FISICA_DESTINO_INTERMEDIO Then
            rfcRemitenteDestInter = ObtenValorTextbox(txtRfcDestinoIntermedio)
            nombreDestInter = ObtenValorTextbox(txtNombreDestinoIntermedio)
            apPaternoDestInter = ObtenValorTextbox(txtApPaternoDestinoIntermedio)
            apMaternoDestInter = ObtenValorTextbox(txtApMaternoDestinoIntermedio)

            Dim longitudRfcPersonaFisica As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_FISICA"))
            If rfcRemitenteDestInter.Length <> longitudRfcPersonaFisica Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If Not Regex.IsMatch(rfcRemitenteDestInter, ObtenParametroPorLlave("REGEXP_RFC_PERSONA_FISICA")) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            If EsCadenaVacia(nombreDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoDestInter) And EsCadenaVacia(apMaternoDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            Dim mensajeError As String = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_LETRAS")
            Dim regExpSoloLetras = ObtenParametroPorLlave("REGEXP_CADENA_SOLO_LETRAS")
            If Not Regex.IsMatch(nombreDestInter, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return
            If Not EsCadenaVacia(apPaternoDestInter) And Not Regex.IsMatch(apPaternoDestInter, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return
            If Not EsCadenaVacia(apMaternoDestInter) And Not Regex.IsMatch(apMaternoDestInter, regExpSoloLetras) Then AlertaMensaje(mensajeError) : Return

        ElseIf ES_PERSONA_MORAL_DESTINO_INTERMEDIO Then
            rfcRemitenteDestInter = ObtenValorTextbox(txtRfcDestinoIntermedio)
            nombreDestInter = ObtenValorTextbox(txtNombreDestinoIntermedio)

            Dim longitudRfcDestino As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_RFC_PERSONA_MORAL"))
            If rfcRemitenteDestInter.Length <> longitudRfcDestino Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return

            Dim regExpRfcPersonaMoral = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_MORAL")
            If Not Regex.IsMatch(rfcRemitenteDestInter, regExpRfcPersonaMoral) Then AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO")) : Return
            If EsCadenaVacia(nombreDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return

        ElseIf ES_EXTRANJERO_DESTINO_INTERMEDIO Then
            rfcRemitenteDestInter = ObtenValorTextbox(txtRfcDestinoIntermedio)
            nombreDestInter = ObtenValorTextbox(txtNombreDestinoIntermedio)
            apPaternoDestInter = ObtenValorTextbox(txtApPaternoDestinoIntermedio)
            apMaternoDestInter = ObtenValorTextbox(txtApMaternoDestinoIntermedio)
            paisResidenciaDestFiscal = cbPaisResidenciaFiscalDestinoIntermedio.SelectedValue
            numRegIdTribDestInter = ObtenValorTextbox(txtNumregIdTribDestinoIntermedio)

            If EsCadenaVacia(nombreDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return
            If EsCadenaVacia(apPaternoDestInter) And EsCadenaVacia(apMaternoDestInter) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_AL_MENOS_UN_APELLIDO")) : Return

            numRegIdTribDestInter = ObtenValorTextbox(txtNumIdRegFiscalDestino)
            If cbResidenciaFiscalDestino.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("Es necesario que ingrese una residencia fiscal")) : Return
            paisResidenciaDestFiscal = cbResidenciaFiscalDestino.SelectedValue
        End If

        Dim paisDestino As String = String.Empty
        Dim estadoDestino As String = String.Empty
        Dim municipioDestino As String = String.Empty
        Dim localidadDestino As String = String.Empty
        Dim coloniaDestino As String = String.Empty
        Dim calleDestino As String = String.Empty
        Dim referenciaDestino As String = String.Empty
        Dim CPDestino As String = String.Empty
        Dim noExtDestino As String = String.Empty
        Dim noIntDestino As String = String.Empty

        paisDestino = cbPaisDestinoIntermedio.SelectedValue
        If REMITENTE_ES_EXTRANJERO Then 'Aquí no puedo tomar simplemente los valores de los combo
            'Tengo que hacer un montón de validaciones
            'Primero veo de donde tengo que obtener el estado
            If refCbEstadoDestinoIntermedio IsNot Nothing Then
                estadoDestino = ObtenValorCombobox(refCbEstadoDestinoIntermedio)
                If estadoDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            Else
                estadoDestino = ObtenValorTextbox(txtEstadoDestinoIntermedio)
                If EsCadenaVacia(estadoDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            End If

            If refCbMunicipioDestinoIntermedio IsNot Nothing Then
                municipioDestino = ObtenValorCombobox(refCbMunicipioDestinoIntermedio)
                If municipioDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            Else
                municipioDestino = ObtenValorTextbox(txtMunicipioDestinoIntermedio)
            End If
            If refCbLocalidadDestinoIntermedio IsNot Nothing Then
                localidadDestino = ObtenValorCombobox(refCbLocalidadDestinoIntermedio)
                If localidadDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return
            Else
                localidadDestino = ObtenValorTextbox(txtLocalidadDestinoIntermedio)
            End If

            If refCbColoniaDestinoIntermedio IsNot Nothing Then
                coloniaDestino = ObtenValorCombobox(refCbColoniaDestinoIntermedio)
                If coloniaDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
            Else
                coloniaDestino = ObtenValorTextbox(txtColoniaDestinoIntermedio)
                If EsCadenaVacia(coloniaDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
            End If
        Else
            estadoDestino = ObtenValorCombobox(refCbEstadoDestinoIntermedio)
            municipioDestino = ObtenValorCombobox(refCbMunicipioDestinoIntermedio)
            localidadDestino = ObtenValorCombobox(refCbLocalidadDestinoIntermedio)
            If municipioDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            If localidadDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return
            coloniaDestino = ObtenValorCombobox(refCbColoniaDestinoIntermedio)
            If coloniaDestino = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        End If

        CPDestino = ObtenValorTextbox(txtCpDestinoIntermedio)
        Dim regExpCp = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If CPDestino.Length <> 5 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return
        If Not Regex.IsMatch(CPDestino, regExpCp) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return

        noExtDestino = ObtenValorTextbox(txtNoExtDestinoIntermedio)
        If EsCadenaVacia(noExtDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NO_EXT")) : Return

        noIntDestino = ObtenValorTextbox(txtNoIntDestinoIntermedio)

        calleDestino = ObtenValorTextbox(txtCalleDestinoIntermedio)
        If EsCadenaVacia(calleDestino) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CALLE")) : Return

        referenciaDestino = ObtenValorTextbox(txtReferenciaDestinoIntermedio)

        Dim kmRecorridos As Int32 = nupKmDestinoIntermedio.Value
        If kmRecorridos <= 0 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_KILOMETROS_RECORRIDOS")) : Return

        datosDestinoIntermedioEnModificacion.TipoUbicacion = tipoUbicacionDestInter
        datosDestinoIntermedioEnModificacion.RFCRemitenteDestinatario = rfcRemitenteDestInter
        datosDestinoIntermedioEnModificacion.IDUbicacion = idUbicacionDestInter
        datosDestinoIntermedioEnModificacion.EsPersonaFisica = ES_PERSONA_FISICA_DESTINO_INTERMEDIO
        datosDestinoIntermedioEnModificacion.EsPersonaMoral = ES_PERSONA_MORAL_DESTINO_INTERMEDIO
        datosDestinoIntermedioEnModificacion.EsExtranjero = ES_EXTRANJERO_DESTINO_INTERMEDIO
        datosDestinoIntermedioEnModificacion.Nombre = IIf(ES_PERSONA_MORAL_DESTINO_INTERMEDIO, String.Empty, nombreDestInter)
        datosDestinoIntermedioEnModificacion.ApPaterno = IIf(ES_PERSONA_MORAL_DESTINO_INTERMEDIO, String.Empty, apPaternoDestInter)
        datosDestinoIntermedioEnModificacion.ApMaterno = IIf(ES_PERSONA_MORAL_DESTINO_INTERMEDIO, String.Empty, apMaternoDestInter)
        datosDestinoIntermedioEnModificacion.NombrePersonaMoral = IIf(ES_PERSONA_MORAL_DESTINO_INTERMEDIO, nombreDestInter, String.Empty)
        datosDestinoIntermedioEnModificacion.ResidenciaFiscal = paisResidenciaDestFiscal
        datosDestinoIntermedioEnModificacion.NumRegIdTrib = numRegIdTribDestInter
        datosDestinoIntermedioEnModificacion.FechaSalidaLlegada = dtFechaLlegadaDestinoIntermedio.Value
        datosDestinoIntermedioEnModificacion.HoraSalidaLlegada = txtHoraLlegadaDestinoIntermedio.Text
        datosDestinoIntermedioEnModificacion.DistanciaRecorrida = kmRecorridos

        Dim domicilio As New Domicilio
        domicilio.Calle = calleDestino
        domicilio.NumeroExterior = noExtDestino
        domicilio.NumeroInterior = noIntDestino
        domicilio.Colonia = coloniaDestino
        domicilio.Localidad = localidadDestino
        domicilio.Municipio = municipioDestino
        domicilio.Estado = estadoDestino
        domicilio.Pais = paisDestino
        domicilio.Referencia = referenciaDestino
        domicilio.CodigoPostal = CPDestino
        datosDestinoIntermedioEnModificacion.DatosDomicilio = domicilio

        'Hemos terminado la validación
        INFORMACION_VALIDA_DESTINO_INTERMEDIO = True

        'Veo si estamos actualizando o añadiendo
        If ESTA_CREANDO_DESTINO_INTERMEDIO Then
            datosDestinosIntermediosParaCartaPorte.Add(datosDestinoIntermedioEnModificacion)
        ElseIf ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO Then
            Dim objEnModif As OrigenDestino = datosDestinosIntermediosParaCartaPorte.FirstOrDefault(Function(f) f.IDUbicacion.Equals(datosDestinoIntermedioEnModificacion.IDUbicacion))
            objEnModif = datosDestinoIntermedioEnModificacion
        End If
        BindGridDestinosIntermedios()
        btnReiniciarDestinosIntermedios_Click(Nothing, Nothing)
    End Sub

    Private Function ObtenKilometrosDisponibles() As Int32
        Dim kmTotales As Int32 = datosDestinoParaCartaPorte.DistanciaRecorrida
        Dim kmConsumidosDeTotal As Int32 = 0
        If datosDestinosIntermediosParaCartaPorte Is Nothing Then
            datosDestinosIntermediosParaCartaPorte = New List(Of OrigenDestino)
        End If
        If datosDestinosIntermediosParaCartaPorte.Count > 0 Then
            For Each lugar As OrigenDestino In datosDestinosIntermediosParaCartaPorte
                kmConsumidosDeTotal = kmConsumidosDeTotal + lugar.DistanciaRecorrida
            Next
        End If
        'KmTotales-KmconsumidosDeTotal = Disponibles
        'Regreso si los disponibles son mayores o iguales al actual
        Return (kmTotales - kmConsumidosDeTotal)
    End Function

    Private Sub rbEsPersonaFisicaDestinoIntermedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbEsPersonaFisicaDestinoIntermedio.CheckedChanged
        TogglePersonaMoralFisicaExtranjeroDestinoIntermedio()
    End Sub

    Private Sub rbEsPersonaMoralDestinoIntermedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbEsPersonaMoralDestinoIntermedio.CheckedChanged
        TogglePersonaMoralFisicaExtranjeroDestinoIntermedio()
    End Sub

    Private Sub rbEsExtranjeroDestinoIntermedio_CheckedChanged(sender As Object, e As EventArgs) Handles rbEsExtranjeroDestinoIntermedio.CheckedChanged
        TogglePersonaMoralFisicaExtranjeroDestinoIntermedio()
    End Sub

    Private Sub cbPaisResidenciaFiscalDestinoIntermedio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisResidenciaFiscalDestinoIntermedio.SelectedValueChanged
        If ES_EXTRANJERO_DESTINO_INTERMEDIO Then
            If ObtenValorCombobox(cbPaisDestinoIntermedio) = "-01" Then Return
            txtPaisResidenciaFiscalDestinoIntermedio.Text = ObtenDescripcionPais(ObtenValorCombobox(cbPaisDestinoIntermedio))
        End If
    End Sub

    Private Sub cbPaisDestinoIntermedio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisDestinoIntermedio.SelectedValueChanged
        Dim paisSeleccionado As String = ObtenValorCombobox(cbPaisDestinoIntermedio)
        If paisSeleccionado = "-01" Then Return

        If PaisTieneEstados(paisSeleccionado) Then
            If refCbEstadoDestinoIntermedio Is Nothing Then
                refCbEstadoDestinoIntermedio = New ComboBox
                LimpiaDesactivaCombobox(refCbEstadoDestinoIntermedio)
                BindCombobox(refCbEstadoDestinoIntermedio, ObtenEstadosPorPais(paisSeleccionado))
                SustituyeEnGrid(txtEstadoDestinoIntermedio, refCbEstadoDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
                AddHandler refCbEstadoDestinoIntermedio.SelectedValueChanged, AddressOf cbEstadoDestinoIntermedio_SelectedValueChanged
            Else
                BindCombobox(refCbEstadoDestinoIntermedio, ObtenEstadosPorPais(paisSeleccionado))
            End If
            cbEstadoDestinoIntermedio_SelectedValueChanged(Nothing, Nothing)
        Else
            If txtEstadoDestinoIntermedio Is Nothing Then
                txtEstadoDestinoIntermedio = New TextBox
                txtEstadoDestinoIntermedio.Text = String.Empty
                SustituyeEnGrid(refCbEstadoDestinoIntermedio, txtEstadoDestino, tlpDatosFiscalesDestinoIntermedio)
            End If
        End If

        'Luego si es un país con municipios
        If PaisTieneMunicipioLocalidad(paisSeleccionado) Then
            If refCbMunicipioDestinoIntermedio Is Nothing Then
                refCbMunicipioDestinoIntermedio = New ComboBox
                LimpiaDesactivaCombobox(refCbMunicipioDestinoIntermedio)
                SustituyeEnGrid(txtMunicipioDestinoIntermedio, refCbMunicipioDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            End If
            If refCbLocalidadDestinoIntermedio Is Nothing Then
                refCbLocalidadDestinoIntermedio = New ComboBox
                LimpiaDesactivaCombobox(refCbLocalidadDestinoIntermedio)
                SustituyeEnGrid(txtLocalidadDestinoIntermedio, refCbLocalidadDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            End If
        Else
            If txtMunicipioDestinoIntermedio Is Nothing Then
                txtMunicipioDestinoIntermedio = New TextBox
                txtMunicipioDestinoIntermedio.Text = String.Empty
                SustituyeEnGrid(refCbMunicipioDestinoIntermedio, txtMunicipioDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            End If
            If txtLocalidadDestinoIntermedio Is Nothing Then
                txtLocalidadDestinoIntermedio = New TextBox
                txtLocalidadDestinoIntermedio.Text = String.Empty
                SustituyeEnGrid(refCbLocalidadDestinoIntermedio, txtLocalidadDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            End If
        End If

        'Finalmente, si es un país con colonias
        If PaisTieneColonias(paisSeleccionado) Then
            If refCbColoniaDestinoIntermedio Is Nothing Then
                refCbColoniaDestinoIntermedio = New ComboBox
                LimpiaDesactivaCombobox(refCbColoniaDestinoIntermedio)
                SustituyeEnGrid(txtColoniaDestinoIntermedio, refCbColoniaDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            End If
            txtCpDestinoIntermedio_TextChanged(Nothing, Nothing)
        Else
            If txtColoniaDestinoIntermedio Is Nothing Then
                txtColoniaDestinoIntermedio = New TextBox
                txtColoniaDestinoIntermedio.Text = String.Empty
                SustituyeEnGrid(refCbColoniaDestinoIntermedio, txtColoniaDestinoIntermedio, tlpDatosFiscalesDestinoIntermedio)
            End If
        End If
    End Sub

    Private Sub cbEstadoDestinoIntermedio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEstadoDestinoIntermedio.SelectedValueChanged
        If ObtenValorCombobox(refCbEstadoDestinoIntermedio) = "-01" Then Return

        Dim paisSeleccionado As String = ObtenValorCombobox(cbPaisDestinoIntermedio)
        If PaisTieneMunicipioLocalidad(paisSeleccionado) Then
            BindCombobox(refCbMunicipioDestinoIntermedio, ObtenMunicipiosPorEstado(cbEstadoDestinoIntermedio.SelectedValue))
            BindCombobox(refCbLocalidadDestinoIntermedio, ObtenLocalidadesPorEstado(cbEstadoDestinoIntermedio.SelectedValue))
        End If
    End Sub

    Private Sub btnReiniciarDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnReiniciarDestinosIntermedios.Click
        LimpiaDatosResidenciaFiscalDestinoIntermedio()
        LimpiaDetallesDestinoIntermedio()
        ActivaModificacionDestinoIntermedio()
        datosDestinoIntermedioEnModificacion = Nothing
        ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO = False
        ESTA_CREANDO_DESTINO_INTERMEDIO = True
    End Sub

    Private Sub btnAtrasDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnAtrasDestinosIntermedios.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
    End Sub
    Private Sub btnSiguienteDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnSiguienteDestinosIntermedios.Click
        btnGuardarDestinosIntermedios_Click(Nothing, Nothing)
        If datosDestinoIntermedioEnModificacion Is Nothing Then
            TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnGuardarDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnGuardarDestinosIntermedios.Click
        If ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO Then
            Dim rsult = MsgBox(ObtenParametroPorLlave("DEST_INTER_MODIFICACION"), vbQuestion + vbYesNo, "Alerta")
            If rsult = MsgBoxResult.No Then Return
        ElseIf ESTA_CREANDO_DESTINO_INTERMEDIO Then
            Dim rsult = MsgBox(ObtenParametroPorLlave("DEST_INTER_CREACION"), vbQuestion + vbYesNo, "Alerta")
            If rsult = MsgBoxResult.No Then Return
        End If
        ValidarDatosDestinoIntermedio()
        If INFORMACION_VALIDA_DESTINO_INTERMEDIO Then
            TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        End If
    End Sub

    Private Sub dgvCartaPorteDestinosIntermedios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCartaPorteDestinosIntermedios.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim indiceBotonVer As Int32 = dgvCartaPorteDestinosIntermedios.Columns.IndexOf(dgvCartaPorteDestinosIntermedios.Columns("DIVerClm"))
        Dim indiceBotonEliminar As Int32 = dgvCartaPorteDestinosIntermedios.Columns.IndexOf(dgvCartaPorteDestinosIntermedios.Columns("DIEliminarClm"))
        If e.ColumnIndex = indiceBotonVer Then
            Dim idUbicacion As String = dgvCartaPorteDestinosIntermedios.Rows(e.RowIndex).Cells("IDUbicacionClm").Value
            CargaDatosDestinoIntermedio(idUbicacion)
        ElseIf e.ColumnIndex = indiceBotonEliminar Then
            Dim idUbicacion As String = dgvCartaPorteDestinosIntermedios.Rows(e.RowIndex).Cells("IDUbicacionClm").Value
            Dim resp = MsgBox(ObtenParametroPorLlave("ELIMINAR_DEST_INTER"), vbQuestion + vbYesNo, "Alerta")
            If resp = MsgBoxResult.No Then Return
            EliminaDestinoIntermedio(idUbicacion)
        End If
    End Sub

    Private Sub CargaDatosDestinoIntermedio(ByVal idUbicacion As String)
        btnReiniciarDestinosIntermedios_Click(Nothing, Nothing)
        ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO = True
        ESTA_CREANDO_DESTINO_INTERMEDIO = False
        Dim objDestino As OrigenDestino = datosDestinosIntermediosParaCartaPorte.FirstOrDefault(Function(x) x.IDUbicacion.Equals(idUbicacion))
        If objDestino IsNot Nothing Then
            txtTipoUbicacionDestinoIntermedio.Text = "DESTINO"
            txtIdUbicacionDestinoIntermedio.Text = objDestino.IDUbicacion
            rbEsPersonaFisicaDestinoIntermedio.Checked = objDestino.EsPersonaFisica
            rbEsPersonaMoralDestinoIntermedio.Checked = objDestino.EsPersonaMoral
            rbEsExtranjeroDestinoIntermedio.Checked = objDestino.EsExtranjero
            ES_PERSONA_FISICA_DESTINO_INTERMEDIO = rbEsPersonaFisicaDestinoIntermedio.Checked
            ES_PERSONA_MORAL_DESTINO_INTERMEDIO = rbEsPersonaMoralDestinoIntermedio.Checked
            ES_EXTRANJERO_DESTINO_INTERMEDIO = rbEsExtranjeroDestinoIntermedio.Checked

            'Primero cargo los detalles de la ubicación
            If ES_PERSONA_FISICA_DESTINO_INTERMEDIO Then
                txtRfcDestinoIntermedio.Text = objDestino.RFCRemitenteDestinatario
                txtNombreDestinoIntermedio.Text = objDestino.Nombre
                txtApPaternoDestinoIntermedio.Text = objDestino.ApPaterno
                txtApMaternoDestinoIntermedio.Text = objDestino.ApMaterno
            ElseIf ES_PERSONA_MORAL_DESTINO_INTERMEDIO Then
                txtRfcDestinoIntermedio.Text = objDestino.RFCRemitenteDestinatario
                txtNombreDestinoIntermedio.Text = objDestino.NombrePersonaMoral
                txtApPaternoDestinoIntermedio.Text = String.Empty
                txtApMaternoDestinoIntermedio.Text = String.Empty
            ElseIf ES_EXTRANJERO_DESTINO_INTERMEDIO Then
                txtRfcDestinoIntermedio.Text = ObtenParametroPorLlave("RFC_GENERICO_EXTRANJERO")
                txtNombreDestinoIntermedio.Text = objDestino.Nombre
                txtApPaternoDestinoIntermedio.Text = objDestino.ApPaterno
                txtApMaternoDestinoIntermedio.Text = objDestino.ApMaterno
                txtNumregIdTribDestinoIntermedio.Text = objDestino.NumRegIdTrib
                BindCombobox(cbPaisResidenciaFiscalDestinoIntermedio, ObtenListadoPaises())
                cbPaisResidenciaFiscalDestinoIntermedio.SelectedValue = objDestino.ResidenciaFiscal
            End If

            dtFechaLlegadaDestinoIntermedio.Value = objDestino.FechaSalidaLlegada
            txtHoraLlegadaDestinoIntermedio.Text = objDestino.HoraSalidaLlegada
            nupKmDestinoIntermedio.Value = objDestino.DistanciaRecorrida

            'Ahora a cargar los detalles del domicilio
            'Si no es extranjero, no hay ninguna bronca
            Dim datosDomicilio As Domicilio = objDestino.DatosDomicilio
            If Not ES_EXTRANJERO_DESTINO_INTERMEDIO Then
                BindCombobox(cbPaisDestinoIntermedio, ObtenListadoPaises())
                cbPaisDestinoIntermedio.SelectedValue = datosDomicilio.Pais
                cbPaisDestinoIntermedio.Enabled = False
                cbEstadoDestinoIntermedio.SelectedValue = datosDomicilio.Estado
                cbEstadoDestinoIntermedio.Enabled = True
                cbMunicipioDestinoIntermedio.SelectedValue = datosDomicilio.Municipio
                cbMunicipioDestinoIntermedio.Enabled = True
                cbLocalidadDestinoIntermedio.SelectedValue = datosDomicilio.Localidad
                cbLocalidadDestinoIntermedio.Enabled = True
                txtCpDestinoIntermedio.Text = datosDomicilio.CodigoPostal
                txtCpDestinoIntermedio.Enabled = True
                cbColoniaDestinoIntermedio.Enabled = True
                txtNoExtDestinoIntermedio.Text = datosDomicilio.NumeroExterior
                txtNoExtDestinoIntermedio.Enabled = True
                txtNoIntDestinoIntermedio.Text = datosDomicilio.NumeroInterior
                txtNoIntDestinoIntermedio.Enabled = True
                txtCalleDestinoIntermedio.Text = datosDomicilio.Calle
                txtCalleDestinoIntermedio.Enabled = True
                txtReferenciaDestinoIntermedio.Text = datosDomicilio.Referencia
                txtReferenciaDestinoIntermedio.Enabled = True
            Else
                BindCombobox(cbPaisDestinoIntermedio, ObtenListadoPaises())
                cbPaisDestinoIntermedio.SelectedValue = datosDomicilio.Pais
                cbPaisDestinoIntermedio.Enabled = True

                'Ahora tengo que cargar la info dependiendo de donde esté
                'Estado
                If refCbEstadoDestinoIntermedio IsNot Nothing Then
                    refCbEstadoDestinoIntermedio.SelectedValue = datosDomicilio.Estado
                Else
                    txtEstadoDestinoIntermedio.Text = datosDomicilio.Calle
                End If

                'Municipio
                If refCbMunicipioDestinoIntermedio IsNot Nothing Then
                    refCbMunicipioDestinoIntermedio.SelectedValue = datosDomicilio.Municipio
                Else
                    txtMunicipioDestinoIntermedio.Text = datosDomicilio.Municipio
                End If

                'Localidad
                If refCbLocalidadDestinoIntermedio IsNot Nothing Then
                    refCbLocalidadDestinoIntermedio.SelectedValue = datosDomicilio.Localidad
                Else
                    txtLocalidadDestinoIntermedio.Text = datosDomicilio.Localidad
                End If

                'Colonia
                If refCbColoniaDestinoIntermedio IsNot Nothing Then
                    refCbColoniaDestinoIntermedio.SelectedValue = datosDomicilio.Colonia
                Else
                    txtColoniaDestinoIntermedio.Text = datosDomicilio.Colonia
                End If

                txtCpDestino.Text = datosDomicilio.CodigoPostal
                txtColoniaDestinoIntermedio.Text = datosDomicilio.Colonia
                txtCalleDestinoIntermedio.Text = datosDomicilio.Calle
                txtReferenciaDestinoIntermedio.Text = datosDomicilio.Referencia
            End If
        End If
    End Sub

    Private Sub EliminaDestinoIntermedio(ByVal idUbicacion As String)
        Dim objDestino As OrigenDestino = datosDestinosIntermediosParaCartaPorte.FirstOrDefault(Function(x) x.IDUbicacion.Equals(idUbicacion))
        If idUbicacion = ObtenValorTextbox(txtIdUbicacionDestinoIntermedio) Then
            btnLimpiarDestinosIntermedios_Click(Nothing, Nothing)
        End If
        If objDestino IsNot Nothing Then
            datosDestinosIntermediosParaCartaPorte.Remove(objDestino)
        End If
        BindGridDestinosIntermedios()
    End Sub

    Private Sub txtCpDestinoIntermedio_TextChanged(sender As Object, e As EventArgs) Handles txtCpDestinoIntermedio.TextChanged
        Dim cpDestinoIntermedio As String = ObtenValorTextbox(txtCpDestinoIntermedio)
        If refCbColoniaDestinoIntermedio Is Nothing Then Return
        If cpDestinoIntermedio.Length <> 5 Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return
        Dim regExpCp As String = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If Not Regex.IsMatch(cpDestinoIntermedio, regExpCp) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CODIGO_POSTAL")) : Return
        BindCombobox(refCbColoniaDestinoIntermedio, ObtenColoniasPorCodigoPostal(cpDestinoIntermedio))
    End Sub

    Private Sub btnLimpiarDestinosIntermedios_Click(sender As Object, e As EventArgs) Handles btnLimpiarDestinosIntermedios.Click
        rbEsPersonaFisicaDestinoIntermedio.Checked = True
        rbEsPersonaFisicaDestinoIntermedio.Enabled = False
        rbEsPersonaMoralDestinoIntermedio.Enabled = False
        rbEsExtranjeroDestinoIntermedio.Enabled = False
        LimpiaDatosResidenciaFiscalDestinoIntermedio()
        LimpiaDetallesDestinoIntermedio()
        ESTA_CREANDO_DESTINO_INTERMEDIO = False
        ESTA_ACTUALIZANDO_DESTINO_INTERMEDIO = False
        INFORMACION_VALIDA_DESTINO_INTERMEDIO = True
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE MERCANCIAS
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private ESTA_CREANDO_MERCANCIA As Boolean = False
    Private ESTA_MODIFICANDO_MERCANCIA As Boolean = False
    Private EXISTE_MERCANCIA_MATERIAL_PELIGROSO As Boolean = False
    Private INFORMACION_VALIDA_MERCANCIA As Boolean = False

    Private Sub PreparaPestanaMercancias()
        BindGridMovimientosMercancias()
        LimpiaPanelInformacionMercancias()
        If dgvMercanciasPorMovimiento.Rows IsNot Nothing Then
            dgvMercanciasPorMovimiento.Rows.Clear()
        End If
        dgvMercanciasPorMovimiento.DataSource = Nothing
    End Sub

    Private Sub LimpiaPanelInformacionMercancias()
        BindCombobox(cbOpcionDimensiones, conexionesCartaPorte.Get_ObtenPosiblesDimensiones())
        txtClaveProdServMercancia.Text = String.Empty
        txtDescripcionProducto.Text = String.Empty
        txtCantidadMercancia.Text = String.Empty
        txtUnidadClaveMercancia.Text = String.Empty
        txtUnidadMercancia.Text = String.Empty
        txtPeso.Text = String.Empty
        txtValor.Text = String.Empty
        numAnchura.Value = 0
        numAnchura.Minimum = 0
        numAltura.Value = 0
        numAltura.Minimum = 0
        numLongitud.Value = 0
        numLongitud.Minimum = 0
        rbNoMaterialPeligroso.Checked = True
        rbComercioInternacionalNo.Checked = True
        mercanciaEnModificacion = Nothing
    End Sub

    Private Sub BindGridMovimientosMercancias()
        If dgvListadoMovimientosPestanaMercancia.Rows IsNot Nothing Then
            dgvListadoMovimientosPestanaMercancia.Rows.Clear()
        End If

        dgvListadoMovimientosPestanaMercancia.DataSource = Nothing

        Dim listaTodosLosMovimientos As List(Of OrigenDestino) = New List(Of OrigenDestino)
        listaTodosLosMovimientos.AddRange(datosDestinosIntermediosParaCartaPorte)
        listaTodosLosMovimientos = datosDestinosIntermediosParaCartaPorte.OrderBy(Of DateTime)(Function(x) x.FechaHora)
        listaTodosLosMovimientos.Add(datosDestinoParaCartaPorte)

        dgvListadoMovimientosPestanaMercancia.AutoGenerateColumns = False
        dgvListadoMovimientosPestanaMercancia.Columns("MovimientoMercanciaClm").DataPropertyName = NameOf(OrigenDestino.Movimiento)
        dgvListadoMovimientosPestanaMercancia.Columns("DestinoMercanciaClm").DataPropertyName = NameOf(OrigenDestino.DestinoDesplegado)
        dgvListadoMovimientosPestanaMercancia.Columns("TipoMovimientoClm").DataPropertyName = NameOf(OrigenDestino.TipoMovimiento)
        dgvListadoMovimientosPestanaMercancia.Columns("IdUbicacionMovimientoPestanaMercanciaClm").DataPropertyName = NameOf(OrigenDestino.IDUbicacion)

        dgvListadoMovimientosPestanaMercancia.DataSource = listaTodosLosMovimientos
    End Sub

    Private Sub BindGridDetalleMercanciasPorMovimiento(ByRef mercanciasMovimiento As List(Of Mercancia))
        If dgvMercanciasPorMovimiento.Rows IsNot Nothing Then
            dgvMercanciasPorMovimiento.Rows.Clear()
        End If

        dgvMercanciasPorMovimiento.DataSource = Nothing
        dgvMercanciasPorMovimiento.AutoGenerateColumns = False
        dgvMercanciasPorMovimiento.Columns("MercanciaClaveProdServClm").DataPropertyName = NameOf(Mercancia.ClaveProdServ)
        dgvMercanciasPorMovimiento.Columns("MovimientoDescripcionClm").DataPropertyName = NameOf(Mercancia.Descripcion)
        dgvMercanciasPorMovimiento.Columns("MercanciaMovimientoPeligrosaClm").DataPropertyName = NameOf(Mercancia.EsMaterialPeligrosoCad)
        dgvMercanciasPorMovimiento.Columns("MovimientoComercioIntClm").DataPropertyName = NameOf(Mercancia.EsComercioInternacionalCad)
        dgvMercanciasPorMovimiento.DataSource = mercanciasMovimiento
    End Sub

    Private Sub dgvListadoMovimientosPestanaMercancia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoMovimientosPestanaMercancia.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If
        Dim columnaVerDetalle As Int32 = dgvListadoMovimientosPestanaMercancia.Columns.IndexOf(dgvListadoMovimientosPestanaMercancia.Columns("MercanciasBtnClm"))
        Dim columnaAnadirMercancia As Int32 = dgvListadoMovimientosPestanaMercancia.Columns.IndexOf(dgvListadoMovimientosPestanaMercancia.Columns("AnadirMercanciaMovimientoClm"))
        Dim columnaIdUbicacion As Int32 = dgvListadoMovimientosPestanaMercancia.Columns.IndexOf(dgvListadoMovimientosPestanaMercancia.Columns("IdUbicacionMovimientoPestanaMercanciaClm"))
        Dim idUbicacion As String = dgvListadoMovimientosPestanaMercancia.Rows(e.RowIndex).Cells(columnaIdUbicacion).Value
        If e.ColumnIndex = columnaVerDetalle Or e.ColumnIndex = columnaAnadirMercancia Then
            LimpiaPanelInformacionMercancias()
            listadoMercanciasPorMovimiento = dictMercancias(idUbicacion)
            BindGridDetalleMercanciasPorMovimiento(listadoMercanciasPorMovimiento)
            ESTA_CREANDO_MERCANCIA = (e.ColumnIndex = columnaAnadirMercancia)
        End If
    End Sub

    Private Sub ToggleComercioInternacional()
        If rbComercioInternacionalSi.Checked Then
            txtFraccionArancelaria.Enabled = True
            txtPedimento.Enabled = True
            If ESTA_CREANDO_MERCANCIA Then
                txtPedimento.Text = String.Empty
                txtFraccionArancelaria.Text = String.Empty
            Else
                txtPedimento.Text = mercanciaEnModificacion.Pedimento
                txtFraccionArancelaria.Text = mercanciaEnModificacion.FraccionArancelaria
            End If
        ElseIf rbComercioInternacionalNo.Checked Then
            txtPedimento.Text = String.Empty
            txtPedimento.Enabled = False
            LimpiaDesactivaTextbox(txtFraccionArancelaria)
        End If
    End Sub

    Private Sub ToggleMaterialPeligroso()
        If rbNoMaterialPeligroso.Checked Then
            LimpiaDesactivaTextbox(txtClaveMaterialPeligroso)
            LimpiaDesactivaTextbox(txtDescripcionMaterialPeligroso)
            LimpiaDesactivaTextbox(txtEmbalaje)
            LimpiaDesactivaTextbox(txtDescripcionEmbalaje)
        ElseIf rbSiMaterialPeligroso.Checked Then
            txtDescripcionMaterialPeligroso.Enabled = True
            txtClaveMaterialPeligroso.Enabled = True
            txtEmbalaje.Enabled = True
            txtDescripcionEmbalaje.Enabled = True
            If ESTA_MODIFICANDO_MERCANCIA Then
                txtDescripcionMaterialPeligroso.Text = mercanciaEnModificacion.DescripcionMaterialPeligroso
                txtClaveMaterialPeligroso.Text = mercanciaEnModificacion.ClaveMaterialPeligroso
                txtEmbalaje.Text = mercanciaEnModificacion.Embalaje
                txtDescripcionEmbalaje.Text = mercanciaEnModificacion.DescripcionEmbalaje
            End If
        End If
    End Sub

    Private Sub CargaDetallesMercancia(ByRef mercancia As Mercancia)
        txtClaveProdServMercancia.Text = mercancia.ClaveProdServ
        txtDescripcionProducto.Text = conexionesCartaPorte.Get_ObtenDescripcionPorClaveProdServ(mercancia.ClaveProdServ)
        txtCantidadMercancia.Text = mercancia.Cantidad.ToString
        txtUnidadClaveMercancia.Text = mercancia.ClaveUnidad
        txtUnidadMercancia.Text = conexionesCartaPorte.Get_ClaveUnidadPeso(mercancia.ClaveUnidad)
        txtPeso.Text = mercancia.PesoEnKg.ToString
        txtValor.Text = mercancia.ValorMercancia.ToString
        txtMoneda.Text = mercancia.Moneda
        numAltura.Value = mercancia.Altura
        numAnchura.Value = mercancia.Anchura
        numLongitud.Value = mercancia.Longitud
        If mercancia.EsCentimetros Then
            cbOpcionDimensiones.SelectedValue = "cm"
        ElseIf mercancia.EsPulgadas Then
            cbOpcionDimensiones.SelectedValue = "plg"
        Else
            cbOpcionDimensiones.SelectedValue = "-01"
        End If

        If mercancia.MaterialPeligroso Then
            rbSiMaterialPeligroso.Checked = True
            txtClaveMaterialPeligroso.Text = mercancia.ClaveMaterialPeligroso
            txtClaveMaterialPeligroso.Enabled = True
            txtEmbalaje.Text = mercancia.Embalaje
            txtEmbalaje.Enabled = False
        Else
            rbNoMaterialPeligroso.Checked = True
        End If

        If mercancia.EsComercioInternacional Then
            rbComercioInternacionalSi.Checked = True
            txtPedimento.Text = mercancia.Pedimento
            txtPedimento.Enabled = True
            txtFraccionArancelaria.Text = mercancia.FraccionArancelaria
            txtFraccionArancelaria.Enabled = True
        Else
            rbComercioInternacionalNo.Checked = True
        End If
        ESTA_MODIFICANDO_MERCANCIA = True
        ESTA_CREANDO_MERCANCIA = False
    End Sub

    Private Sub rbSiMaterialPeligroso_CheckedChanged(sender As Object, e As EventArgs) Handles rbSiMaterialPeligroso.CheckedChanged
        ToggleMaterialPeligroso()
    End Sub

    Private Sub rbNoMaterialPeligroso_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoMaterialPeligroso.CheckedChanged
        ToggleMaterialPeligroso()
    End Sub

    Private Sub rbComercioInternacionalSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbComercioInternacionalSi.CheckedChanged
        ToggleComercioInternacional()
    End Sub

    Private Sub rbComercioInternacionalNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbComercioInternacionalNo.CheckedChanged
        ToggleComercioInternacional()
    End Sub

    Private Sub txtClaveProdServMercancia_TextChanged(sender As Object, e As EventArgs) Handles txtClaveProdServMercancia.TextChanged
        txtDescripcionProducto.Enabled = False
        Dim longitudClaveProdServ As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_CLAVE_PROD_SERV"))
        Dim regExpClaveProdServ As String = ObtenParametroPorLlave("REGEXP_CLAVE_PROD_SERV")
        Dim claveProdServ As String = Trim(txtClaveProdServMercancia.Text)
        If claveProdServ.Length <> longitudClaveProdServ Then Return
        If Not Regex.IsMatch(claveProdServ, regExpClaveProdServ) Then Return
        txtDescripcionProducto.Text = conexionesCartaPorte.Get_ObtenDescripcionPorClaveProdServ(claveProdServ)
    End Sub

    Private Sub txtUnidadClaveMercancia_TextChanged(sender As Object, e As EventArgs) Handles txtUnidadClaveMercancia.TextChanged
        txtUnidadMercancia.Enabled = False
        txtUnidadMercancia.Text = String.Empty
        Dim claveUnidad As String = ObtenValorTextbox(txtUnidadClaveMercancia)
        If EsCadenaVacia(claveUnidad) Then Return
        txtUnidadMercancia.Text = conexionesCartaPorte.Get_ClaveUnidadPeso(claveUnidad)
    End Sub

    Private Sub txtClaveMaterialPeligroso_TextChanged(sender As Object, e As EventArgs) Handles txtClaveMaterialPeligroso.TextChanged

    End Sub

    Private Sub txtEmbalaje_TextChanged(sender As Object, e As EventArgs) Handles txtEmbalaje.TextChanged

    End Sub

    Private Sub ValidarInformacionMercancia()
        INFORMACION_VALIDA_MERCANCIA = False
        Dim claveProdServ As String = String.Empty
        Dim descripcionProducto As String = String.Empty
        Dim cantidadMercancia As String = String.Empty
        Dim claveUnidad As String = String.Empty
        Dim descripcionUnidad As String = String.Empty
        Dim peso As String = String.Empty
        Dim valor As String = String.Empty
        Dim moneda As String = String.Empty
        Dim anchura As Int32 = 0
        Dim altura As Int32 = 0
        Dim longitud As Int32 = 0
        Dim medidaDimension As String = String.Empty
        Dim materialPeligroso As Boolean = False
        Dim claveMaterialPeligroso As String = String.Empty
        Dim embalaje As String = String.Empty
        Dim comercioInternacional As Boolean = False
        Dim pedimento As String = String.Empty
        Dim fraccionArancelaria As String = String.Empty

        'Validación de la clave prod serv
        Dim longitudClaveProdServ As Int32 = CInt(ObtenParametroPorLlave("LONGITUD_CLAVE_PROD_SERV"))
        claveProdServ = ObtenValorTextbox(txtClaveProdServMercancia)
        If claveProdServ.Length <> longitudClaveProdServ Then AlertaMensaje(ObtenParametroPorLlave("CLAVE_PROD_SERV_NOVALIDA")) : Return
        Dim regExpClaveProdServ As String = ObtenParametroPorLlave("REGEXP_CLAVE_PROD_SERV")
        If Not Regex.IsMatch(claveProdServ, regExpClaveProdServ) Then AlertaMensaje(ObtenParametroPorLlave("CLAVE_PROD_SERV_NOVALIDA")) : Return

        cantidadMercancia = ObtenValorTextbox(txtCantidadMercancia)
        Dim regExpNumeroDecimal As String = ObtenParametroPorLlave("REGEXP_NUMERO_DECIMAL")
        If Not Regex.IsMatch(cantidadMercancia, regExpNumeroDecimal) Then
            Dim mensaje = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS")
            AlertaMensaje(String.Format(mensaje, "CANTIDAD"))
            Return
        End If

        claveUnidad = ObtenValorTextbox(txtUnidadClaveMercancia)
        If EsCadenaVacia(claveUnidad) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CLAVE_UNIDAD")) : Return

        descripcionUnidad = conexionesCartaPorte.Get_ClaveUnidadPeso(claveUnidad)
        If EsCadenaVacia(descripcionUnidad) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CLAVE_UNIDAD")) : Return
        txtUnidadClaveMercancia.Text = UCase(descripcionUnidad)

        peso = ObtenValorTextbox(txtPeso)
        If Not Regex.IsMatch(peso, regExpNumeroDecimal) Then
            Dim mensaje = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS")
            AlertaMensaje(String.Format(mensaje, "PESO"))
            Return
        End If

        valor = ObtenValorTextbox(txtValor)
        If Not Regex.IsMatch(valor, regExpNumeroDecimal) Then
            Dim mensaje = ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS")
            AlertaMensaje(String.Format(mensaje, "VALOR"))
            Return
        End If

        moneda = ObtenValorTextbox(txtMoneda)
        Dim descpMoneda As String = conexionesCartaPorte.Get_DescripcionMoneda(moneda)
        If EsCadenaVacia(descripcionUnidad) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MONEDA")) : Return

        If rbSiMaterialPeligroso.Checked Then
            materialPeligroso = True
            claveMaterialPeligroso = ObtenValorTextbox(txtClaveMaterialPeligroso)
            embalaje = ObtenValorTextbox(txtEmbalaje)
            If EsCadenaVacia(claveMaterialPeligroso) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CLAVE_MATERIAL_PELIGROSO")) : Return
            If EsCadenaVacia(embalaje) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CLAVE_EMBALAJE")) : Return
        Else
            materialPeligroso = False
        End If

        If rbComercioInternacionalSi.Checked Then
            comercioInternacional = True
            pedimento = txtPedimento.Text
            fraccionArancelaria = ObtenValorTextbox(txtFraccionArancelaria)
            If EsCadenaVacia(pedimento) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PEDIMENTO")) : Return
        Else
            comercioInternacional = False
        End If

        If ESTA_CREANDO_MERCANCIA Then mercanciaEnModificacion = New Mercancia

        mercanciaEnModificacion.ClaveProdServ = claveProdServ
        mercanciaEnModificacion.Descripcion = conexionesCartaPorte.Get_ObtenDescripcionPorClaveProdServ(claveProdServ)
        mercanciaEnModificacion.Cantidad = CInt(cantidadMercancia)
        mercanciaEnModificacion.ClaveUnidad = claveUnidad
        mercanciaEnModificacion.Unidad = descripcionUnidad
        mercanciaEnModificacion.EsCentimetros = cbOpcionDimensiones.SelectedValue.Equals("cm")
        mercanciaEnModificacion.EsPulgadas = cbOpcionDimensiones.SelectedValue("plg")
        mercanciaEnModificacion.Longitud = numLongitud.Value
        mercanciaEnModificacion.Anchura = numAnchura.Value
        mercanciaEnModificacion.Altura = numAltura.Value

        mercanciaEnModificacion.MaterialPeligroso = rbSiMaterialPeligroso.Checked
        mercanciaEnModificacion.ClaveMaterialPeligroso = claveMaterialPeligroso
        mercanciaEnModificacion.Embalaje = embalaje

        mercanciaEnModificacion.PesoEnKg = Double.Parse(peso)
        mercanciaEnModificacion.ValorMercancia = Double.Parse(valor)
        mercanciaEnModificacion.Moneda = moneda

        mercanciaEnModificacion.EsComercioInternacional = rbComercioInternacionalSi.Checked
        mercanciaEnModificacion.Pedimento = pedimento
        mercanciaEnModificacion.FraccionArancelaria = fraccionArancelaria

        If ESTA_CREANDO_MERCANCIA Then
            listadoMercanciasPorMovimiento.Add(mercanciaEnModificacion)
            ESTA_CREANDO_MERCANCIA = False
            ESTA_MODIFICANDO_MERCANCIA = False
            BindGridDetalleMercanciasPorMovimiento(listadoMercanciasPorMovimiento)
        ElseIf ESTA_MODIFICANDO_MERCANCIA Then
            Dim mercanciaModificada As Mercancia = listadoMercanciasPorMovimiento.FirstOrDefault(Function(m) m.ClaveProdServ.Equals(mercanciaEnModificacion.ClaveProdServ))
            Dim indiceMerc = listadoMercanciasPorMovimiento.IndexOf(mercanciaModificada)
            listadoMercanciasPorMovimiento(indiceMerc) = mercanciaEnModificacion
            ESTA_MODIFICANDO_MERCANCIA = False
            ESTA_CREANDO_MERCANCIA = False
            BindGridDetalleMercanciasPorMovimiento(listadoMercanciasPorMovimiento)
        End If
        LimpiaPanelInformacionMercancias()
        INFORMACION_VALIDA_MERCANCIA = True
    End Sub

    Private Sub btnGuardarMercancia_Click(sender As Object, e As EventArgs) Handles btnGuardarMercancia.Click
        ValidarInformacionMercancia()
    End Sub

    Private Sub btnSiguienteMercancia_Click(sender As Object, e As EventArgs) Handles btnSiguienteMercancia.Click
        If ESTA_CREANDO_MERCANCIA Or ESTA_MODIFICANDO_MERCANCIA Then
            Dim resp = MsgBox(ObtenParametroPorLlave("MERCANCIA_EN_MODIFICACION"), vbQuestion + vbYesNo, "Alerta")
            If resp = MsgBoxResult.No Then Return
        End If
        ValidarInformacionMercancia()
        If INFORMACION_VALIDA_MERCANCIA Then
            TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnAtrasMercancia_Click(sender As Object, e As EventArgs) Handles btnAtrasMercancia.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
    End Sub

    Private Sub dgvMercanciasPorMovimiento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMercanciasPorMovimiento.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim claveProdServ As String = dgvMercanciasPorMovimiento.Rows(e.RowIndex).Cells("MercanciaClaveProdServClm").Value
        Dim indiceDetalles As Int32 = dgvMercanciasPorMovimiento.Columns().IndexOf(dgvMercanciasPorMovimiento.Columns("MovimientoDetallesMercClm"))
        Dim indiceEliminar As Int32 = dgvMercanciasPorMovimiento.Columns().IndexOf(dgvMercanciasPorMovimiento.Columns("MovimientoMercanciaEliminarClm"))
        If e.ColumnIndex = indiceDetalles Then
            Dim mercancia As Mercancia = listadoMercanciasPorMovimiento.Find(Function(m) m.ClaveProdServ.Equals(claveProdServ))
            mercanciaEnModificacion = mercancia
            LimpiaPanelInformacionMercancias()
            CargaDetallesMercancia(mercancia)
            ESTA_CREANDO_MERCANCIA = False
            ESTA_MODIFICANDO_MERCANCIA = True
        ElseIf e.ColumnIndex = indiceEliminar Then
            Dim mercancia As Mercancia = listadoMercanciasPorMovimiento.Find(Function(m) m.ClaveProdServ.Equals(claveProdServ))
            LimpiaPanelInformacionMercancias()
            EliminaMercanciaDeMovimiento(mercancia)
        End If
    End Sub

    Private Sub EliminaMercanciaDeMovimiento(ByRef mercancia As Mercancia)
        Dim resp = MsgBox(ObtenParametroPorLlave("ELIMINAR_MERCANCIA"), vbQuestion + vbYesNo, "Alerta")
        If resp = MsgBoxResult.Yes Then
            listadoMercanciasPorMovimiento.Remove(mercancia)
            BindGridDetalleMercanciasPorMovimiento(listadoMercanciasPorMovimiento)
        End If
        btnLimpiarMercancia_Click(Nothing, Nothing)
    End Sub

    Private Sub btnLimpiarMercancia_Click(sender As Object, e As EventArgs) Handles btnLimpiarMercancia.Click
        LimpiaPanelInformacionMercancias()
        ESTA_MODIFICANDO_MERCANCIA = False
        ESTA_CREANDO_MERCANCIA = False
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DE VEHÍCULO DE TRANSPORTE
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private PARTE_DEL_REMOLQUE_ES_AJENA As Boolean = False
    Private INFORMACION_VALIDA_TRANSPORTE As Boolean = False

    Private Sub PreparaPestanaTransporte()
        ValidaExisteMercanciaQueCuenteComoPeligroso()
        BindCombobox(cbOpcionesConfigVehicular, conexionesCartaPorte.Get_OpcionesConfiguracionVehicular())
        BindCombobox(cbTipoPermisoSCT, conexionesCartaPorte.Get_OpcionesTipoPermiso())
    End Sub

    Private Sub CargaDatosTransporte()
        If datosAutoTransporte IsNot Nothing Then
            cbSeleccionarVehiculo.SelectedValue = datosAutoTransporte.CveInternaVehiculo
            cbTipoPermisoSCT.SelectedValue = datosAutoTransporte.PermSCT
            txtNumPermisoSCT.Text = datosAutoTransporte.NumPermisoSCT
            cbOpcionesConfigVehicular.SelectedValue = datosAutoTransporte.ConfigVehicular
            txtPlacaTransporte.Text = datosAutoTransporte.PlacaVM
            txtAnioModeloTransporte.Text = datosAutoTransporte.AnioModeloVM
            txtAseguradoraTransporte.Text = datosAutoTransporte.AseguraRespCivil
            txtPolizaTransporte.Text = datosAutoTransporte.PolizaRespCivil
            txtPrimaSeguroTransporte.Text = datosAutoTransporte.PrimaSeguro.ToString()
            txtAseguradoraCargaTransporte.Text = datosAutoTransporte.AseguraCarga
            txtPolizaCargaTransporte.Text = datosAutoTransporte.PolizaCarga

            'Cargo la información de los remolques
            Dim noRemolques As Int16 = datosAutoTransporte.NoRemolques
            numCantidadRemolquesTransporte.Value = noRemolques
            Dim refRemolque As Remolque
            If noRemolques >= 1 Then
                refRemolque = datosAutoTransporte.Remolques(0)
                cbPropiedadRemolque1.SelectedValue = refRemolque.PropiedadRemolque
                txtPlacasRemolque1.Text = refRemolque.Placa
                cbTipoRemolque1.SelectedValue = refRemolque.SubTipoRem
            End If
            If noRemolques = 2 Then
                refRemolque = datosAutoTransporte.Remolques(1)
                cbPropiedadRemolque2.SelectedValue = refRemolque.PropiedadRemolque
                txtPlacasRemolque2.Text = refRemolque.Placa
                cbTipoRemolque2.SelectedValue = refRemolque.SubTipoRem
            End If

            txtAseguradoraDanosMedioAmbiente.Text = datosAutoTransporte.AseguraMedAmbiente
            txtPolizaSegurosDanosMedioAmbiente.Text = datosAutoTransporte.PolizaMedAmbiente
        End If
    End Sub

    Private Sub ValidaExisteMercanciaQueCuenteComoPeligroso()
        EXISTE_MERCANCIA_MATERIAL_PELIGROSO = False
        For Each cadena As String In dictMercancias.Keys
            For Each mercancia As Mercancia In dictMercancias(cadena)
                If mercancia.MaterialPeligroso Then
                    EXISTE_MERCANCIA_MATERIAL_PELIGROSO = True
                    Return
                End If
            Next
        Next
    End Sub

    Private Sub LimpiarPanelDatosTransporte()
        PARTE_DEL_REMOLQUE_ES_AJENA = False
        INFORMACION_VALIDA_TRANSPORTE = False
        cbSeleccionarVehiculo.SelectedValue = "-01"
        LimpiaDesactivaCombobox(cbTipoPermisoSCT)
        txtNumPermisoSCT.Text = String.Empty
        LimpiaDesactivaCombobox(cbOpcionesConfigVehicular)
        txtConfigVehicular.Text = String.Empty
        txtPlacaTransporte.Text = String.Empty
        txtAnioModeloTransporte.Text = String.Empty
        txtAseguradoraTransporte.Text = String.Empty
        txtAseguradoraCargaTransporte.Text = String.Empty
        txtPolizaCargaTransporte.Text = String.Empty
        txtPrimaSeguroTransporte.Text = String.Empty
        txtPrimaSeguroTransporte.Enabled = True
        numCantidadRemolquesTransporte.Value = 0

        txtAseguradoraDanosMedioAmbiente.Text = String.Empty
        txtPolizaSegurosDanosMedioAmbiente.Text = String.Empty

        If EXISTE_MERCANCIA_MATERIAL_PELIGROSO Then
            txtAseguradoraDanosMedioAmbiente.Enabled = True
            txtPolizaSegurosDanosMedioAmbiente.Enabled = True
        Else
            txtAseguradoraDanosMedioAmbiente.Enabled = False
            txtPolizaSegurosDanosMedioAmbiente.Enabled = False
        End If
    End Sub

    Private Sub TogglePartesTransporte()
        If numCantidadRemolquesTransporte.Value = 0 Then
            LimpiaDesactivaCombobox(cbPropiedadRemolque1)
            LimpiaDesactivaCombobox(cbPropiedadRemolque2)
            LimpiaDesactivaCombobox(cbTipoRemolque1)
            LimpiaDesactivaCombobox(cbTipoRemolque2)
            LimpiaDesactivaTextbox(txtTipoRemolque1)
            LimpiaDesactivaTextbox(txtTipoRemolque2)
            LimpiaDesactivaTextbox(txtPlacasRemolque1)
            LimpiaDesactivaTextbox(txtPlacasRemolque2)
        ElseIf numCantidadRemolquesTransporte.Value >= 1 Then
            BindCombobox(cbPropiedadRemolque1, conexionesCartaPorte.Get_OpcionesPropiedadTransporte())
            LimpiaDesactivaTextbox(txtTipoRemolque1)
            txtPlacasRemolque1.Enabled = True
            LimpiaDesactivaCombobox(cbPropiedadRemolque2)
            LimpiaDesactivaCombobox(cbTipoRemolque2)
            LimpiaDesactivaTextbox(txtTipoRemolque2)
            LimpiaDesactivaTextbox(txtPlacasRemolque2)
        End If
        If numCantidadRemolquesTransporte.Value = 2 Then
            BindCombobox(cbPropiedadRemolque2, conexionesCartaPorte.Get_OpcionesPropiedadTransporte())
            txtPlacasRemolque1.Enabled = True
            txtPlacasRemolque2.Enabled = True
            LimpiaDesactivaTextbox(txtTipoRemolque2)
        End If
    End Sub

    Private Sub numCantidadRemolquesTransporte_ValueChanged(sender As Object, e As EventArgs) Handles numCantidadRemolquesTransporte.ValueChanged
        TogglePartesTransporte()
    End Sub

    Private Sub CargaTipoRemolque(ByVal numeroRemolque As Int32)
        Dim text As TextBox = IIf(numeroRemolque = 1, txtTipoRemolque1, txtTipoRemolque2)
        Dim combo As ComboBox = IIf(numeroRemolque = 1, cbTipoRemolque1, cbTipoRemolque2)
        text.Text = conexionesCartaPorte.Get_ObtenDescripcionPorTipoSubRemolque(combo.SelectedValue)
        text.Enabled = False
    End Sub

    Private Sub cbTipoRemolque1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTipoRemolque1.SelectedValueChanged
        CargaTipoRemolque(1)
    End Sub

    Private Sub cbTipoRemolque2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTipoRemolque2.SelectedValueChanged
        CargaTipoRemolque(2)
    End Sub

    Private Sub ValidaPropiedadAjena()
        If numCantidadRemolquesTransporte.Value = 0 Then
            PARTE_DEL_REMOLQUE_ES_AJENA = False
        ElseIf numCantidadRemolquesTransporte.Value = 1 Then
            PARTE_DEL_REMOLQUE_ES_AJENA = cbPropiedadRemolque1.Equals("RE")
        ElseIf numCantidadRemolquesTransporte.Value = 2 Then
            PARTE_DEL_REMOLQUE_ES_AJENA = (cbPropiedadRemolque1.Equals("RE") Or cbPropiedadRemolque2.Equals("RE"))
        End If
    End Sub

    Private Sub cbPropiedadRemolque1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPropiedadRemolque1.SelectedValueChanged
        ValidaPropiedadAjena()
    End Sub

    Private Sub cbPropiedadRemolque2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPropiedadRemolque2.SelectedValueChanged
        ValidaPropiedadAjena()
    End Sub

    Private Sub ValidaDatosTransporte()
        datosAutoTransporte = New Autotransporte
        Dim claveInternaVehiculo As String = String.Empty
        Dim tipoPermisoSct As String = String.Empty
        Dim numPermisoSct As String = String.Empty
        Dim configVehicular As String = String.Empty
        Dim placa As String = String.Empty
        Dim anioModelo As String = String.Empty
        Dim aseguraRespCivil As String = String.Empty
        Dim polizaRespCivil As String = String.Empty
        Dim aseguradoraCarga As String = String.Empty
        Dim polizaCarga As String = String.Empty
        Dim primaSeguro As Double = 0.0D
        Dim noRemolques As Int16 = 0
        Dim aseguradoraMedioAmbiente As String = String.Empty
        Dim polizaMedioAmbiente As String = String.Empty

        If ObtenValorCombobox(cbSeleccionarVehiculo) = "-01" Then AlertaMensaje(ObtenParametroPorLlave("ES_NECESARIO_VEHICULO")) : Return
        If ObtenValorCombobox(cbTipoPermisoSCT) = "-01" Then AlertaMensaje(ObtenParametroPorLlave("ES_NECESARIO_TIPO_PERMISO")) : Return
        If ObtenValorCombobox(cbOpcionesConfigVehicular) = "-01" Then AlertaMensaje(ObtenParametroPorLlave("ES_NECESARIO_CONFIG_VEHICULAR")) : Return
        claveInternaVehiculo = ObtenValorCombobox(cbSeleccionarVehiculo)
        tipoPermisoSct = ObtenValorCombobox(cbTipoPermisoSCT.SelectedValue)
        numPermisoSct = ObtenValorTextbox(txtNumPermisoSCT)
        configVehicular = ObtenValorCombobox(cbOpcionesConfigVehicular)
        placa = ObtenValorTextbox(txtPlacaTransporte).Replace("-", "").Replace(" ", "")
        If EsCadenaVacia(placa) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PLACA")) : Return

        anioModelo = ObtenValorTextbox(txtAnioModeloTransporte)
        If Not Regex.IsMatch(anioModelo, ObtenParametroPorLlave("REGEXP_CADENA_SOLO_NUMEROS")) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ANIO_MODELO")) : Return
        aseguraRespCivil = ObtenValorTextbox(txtAseguradoraTransporte)
        polizaRespCivil = ObtenValorTextbox(txtPolizaTransporte)

        aseguradoraCarga = ObtenValorTextbox(txtAseguradoraCargaTransporte)
        polizaCarga = ObtenValorTextbox(txtPolizaCargaTransporte)

        'No es necesaria la prima, pero si al ingresa, debo de verificar que sea un número decimal válido
        If Not EsCadenaVacia(txtPrimaSeguroTransporte.Text) Then
            If Not Double.TryParse(txtPrimaSeguroTransporte.Text, primaSeguro) Then AlertaMensaje(ObtenParametroPorLlave("PRIMA_SEGURO_INCORRECTA")) : Return
        End If

        noRemolques = numCantidadRemolquesTransporte.Value
        Dim remolques As List(Of Remolque) = Nothing

        'Validación de remolques
        If noRemolques >= 1 Then
            If cbPropiedadRemolque1.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PROPIEDAD_1")) : Return
            Dim remolque1 As Remolque = New Remolque
            remolque1.SubTipoRem = cbTipoRemolque1.SelectedValue
            If remolque1.SubTipoRem = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_TIPO_REMOLQUE_1")) : Return
            remolque1.Placa = ObtenValorTextbox(txtPlacasRemolque1).Replace("-", "").Replace(" ", "")
            If EsCadenaVacia(remolque1.Placa) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PLACA_1")) : Return
            remolques = New List(Of Remolque)
            remolques.Add(remolque1)
        End If

        If noRemolques = 2 Then
            If cbPropiedadRemolque2.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PROPIEDAD_2")) : Return
            Dim remolque2 As Remolque = New Remolque
            remolque2.SubTipoRem = cbTipoRemolque1.SelectedValue
            If remolque2.SubTipoRem = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_TIPO_REMOLQUE_2")) : Return
            remolque2.Placa = ObtenValorTextbox(txtPlacasRemolque1).Replace("-", "").Replace(" ", "")
            If EsCadenaVacia(remolque2.Placa) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PLACA_2")) : Return
            remolques.Add(remolque2)
        End If

        'Validación de material peligroso
        ValidaExisteMercanciaQueCuenteComoPeligroso()
        If EXISTE_MERCANCIA_MATERIAL_PELIGROSO Then
            aseguradoraMedioAmbiente = ObtenValorTextbox(txtAseguradoraDanosMedioAmbiente)
            If EsCadenaVacia(aseguradoraMedioAmbiente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MEDIO_AMBIENTE")) : Return
            polizaMedioAmbiente = ObtenValorTextbox(txtPolizaSegurosDanosMedioAmbiente)
            If EsCadenaVacia(polizaMedioAmbiente) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_P_MEDIO_AMBIENTE")) : Return
        End If

        datosAutoTransporte.CveInternaVehiculo = claveInternaVehiculo
        datosAutoTransporte.PermSCT = tipoPermisoSct
        datosAutoTransporte.NumPermisoSCT = numPermisoSct
        datosAutoTransporte.ConfigVehicular = configVehicular
        datosAutoTransporte.PlacaVM = placa
        datosAutoTransporte.AnioModeloVM = anioModelo
        datosAutoTransporte.AseguraRespCivil = aseguraRespCivil
        datosAutoTransporte.PolizaRespCivil = polizaRespCivil
        datosAutoTransporte.PrimaSeguro = primaSeguro
        datosAutoTransporte.AseguraCarga = aseguradoraCarga
        datosAutoTransporte.PolizaCarga = polizaCarga
        datosAutoTransporte.NoRemolques = noRemolques
        datosAutoTransporte.Remolques = remolques
        datosAutoTransporte.AseguraMedAmbiente = aseguradoraMedioAmbiente
        datosAutoTransporte.PolizaMedAmbiente = polizaMedioAmbiente
        INFORMACION_VALIDA_TRANSPORTE = True
        End Sub

    Private Sub cbTipoPermisoSCT_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTipoPermisoSCT.SelectedValueChanged
        txtNumPermisoSCT.Enabled = True
        If cbTipoPermisoSCT.SelectedValue = "TPXX00" Then
            'txtNumPermisoSCT.Text = String.Empty
        End If
    End Sub

    Private Sub cbOpcionesConfigVehicular_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbOpcionesConfigVehicular.SelectedValueChanged
        txtConfigVehicular.Enabled = False
        txtConfigVehicular.Text = conexionesCartaPorte.Get_ObtenDescripcionConfiguracionAutoTransporte(cbOpcionesConfigVehicular.SelectedValue)
    End Sub

    Private Sub btnSiguienteTransporte_Click(sender As Object, e As EventArgs) Handles btnSiguienteTransporte.Click
        ValidaDatosTransporte()
        If INFORMACION_VALIDA_TRANSPORTE Then
            TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnAtrasTransporte_Click(sender As Object, e As EventArgs) Handles btnAtrasTransporte.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''DATOS DEL OPERADOR
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private INFORMACION_VALIDA_OPERADOR As Boolean = False
    Private txtEstadoOperador As TextBox = Nothing
    Private txtLocalidadOperador As TextBox = Nothing
    Private txtMunicipioOperador As TextBox = Nothing
    Private txtColoniaOperador As TextBox = Nothing
    Private listaParteTransporte As List(Of ItemTransporte)

    Private Sub LimpiaInformacionOperador()
        LimpiaDesactivaCombobox(cbOpcionesOperador)
        rbOperadorMexicano.Checked = True
        txtRfcOperador.Text = String.Empty
        txtRfcOperador.Enabled = False
        txtNumregIdTribDestinoIntermedio.Text = String.Empty
        txtNumregIdTribDestinoIntermedio.Enabled = False
        txtNombreOperador.Text = String.Empty
        txtApPaternoOperador.Text = String.Empty
        txtApMaternoOperador.Text = String.Empty
        LimpiaDesactivaCombobox(cbTipoFiguraOperador)
        LimpiaDesactivaCombobox(cbParteTransporteOperador)
        RemueveDeGrid(txtEstadoOperador, tlpDireccionOperador)
        RemueveDeGrid(txtMunicipioOperador, tlpDireccionOperador)
        RemueveDeGrid(txtLocalidadOperador, tlpDireccionOperador)
        RemueveDeGrid(txtColoniaOperador, tlpDireccionOperador)
        txtEstadoOperador = Nothing
        txtLocalidadOperador = Nothing
        txtMunicipioOperador = Nothing
        txtColoniaOperador = Nothing
        LimpiaDesactivaCombobox(cbEstadoOperador)
        LimpiaDesactivaCombobox(cbMunicipioOperador)
        LimpiaDesactivaCombobox(cbLocalidadOperador)
        LimpiaDesactivaCombobox(cbColoniaOperador)
        txtCpOperador.Text = String.Empty
        txtNoIntOperador.Text = String.Empty
        txtNoExtOperador.Text = String.Empty
        txtCalleOperador.Text = String.Empty
        txtReferenciaOperador.Text = String.Empty
    End Sub

    Private Sub CargaInformacionOperador()
        If datosAutoTransporte.Transportista IsNot Nothing Then
            Dim datosOperador As DatosTransportista = datosAutoTransporte.Transportista
            cbOpcionesOperador.SelectedValue = datosOperador.CveInternaOperador
            txtNombreOperador.Text = datosOperador.NombreTransportista
            txtApPaternoOperador.Text = datosOperador.ApellidoPaternoTransportista
            txtApMaternoOperador.Text = datosOperador.ApellidoMaternoTransportista
            rbOperadorExtranjero.Checked = datosOperador.EsTransportistaExtranjero
            rbOperadorMexicano.Checked = datosOperador.EsTransportistaNacional
            txtRfcOperador.Text = datosOperador.RFCFigura
            txtNumRegIdTribFiscOperador.Text = datosOperador.NumRegIdTribFigura
            cbTipoFiguraOperador.SelectedValue = datosOperador.TipoFigura
            txtNumLicenciaOperador.Text = datosOperador.NumLicencia
            listaParteTransporte = datosOperador.ParteTransporte
            BindGridPartesTransporteOperador()

            If datosOperador.EsTransportistaNacional Then
                cbPaisOperador.SelectedValue = datosOperador.Domicilio.Pais
                cbEstadoOperador.SelectedValue = datosOperador.Domicilio.Estado
                cbMunicipioOperador.SelectedValue = datosOperador.Domicilio.Municipio
                cbLocalidadOperador.SelectedValue = datosOperador.Domicilio.Localidad
                txtCpOperador.Text = datosOperador.Domicilio.CodigoPostal
                cbColoniaOperador.SelectedValue = datosOperador.Domicilio.Colonia
                txtCalleOperador.Text = datosOperador.Domicilio.Calle
                txtReferenciaOperador.Text = datosOperador.Domicilio.Referencia
                txtNoIntDestino.Text = datosOperador.Domicilio.NumeroInterior
                txtNoExtDestino.Text = datosOperador.Domicilio.NumeroExterior
            Else
                Dim pais As String = datosOperador.Domicilio.Pais
                Dim separador As String = ObtenParametroPorLlave("SEPARADOR")
                Dim listadoPaisesConEstados As String = ObtenParametroPorLlave("PAISES_CON_ESTADO")
                Dim listadoPaisesConMunicipioLocalidad As String = ObtenParametroPorLlave("PAISES_CON_MUNICIPIO_LOCALIDAD")
                Dim listadoPaisesConColonia As String = ObtenParametroPorLlave("PAISES_CON_COLONIAS")

                'Cargo estados
                If SeEncuentraValor(pais, listadoPaisesConEstados, separador) Then
                    RemueveDeGrid(txtEstadoOperador, tlpDireccionOperador)
                    txtEstadoOperador = Nothing
                    BindCombobox(cbEstadoOperador, ObtenEstadosPorPais(pais))
                    cbEstadoOperador.SelectedValue = datosOperador.Domicilio.Estado
                Else
                    ReemplazaEnGrid(txtEstadoOperador, cbEstadoOperador, tlpNoExtDomicilioOperador)
                    txtEstadoOperador.Text = datosOperador.Domicilio.Estado
                End If

                'Cargo municipios y localidades
                If SeEncuentraValor(pais, listadoPaisesConMunicipioLocalidad, separador) Then
                    RemueveDeGrid(txtMunicipioOperador, tlpDireccionOperador)
                    RemueveDeGrid(txtLocalidadOperador, tlpDireccionOperador)
                    txtMunicipioOperador = Nothing
                    txtLocalidadOperador = Nothing
                    BindCombobox(cbMunicipioOperador, ObtenMunicipiosPorEstado(datosOperador.Domicilio.Estado))
                    BindCombobox(cbLocalidadOperador, ObtenLocalidadesPorEstado(datosOperador.Domicilio.Localidad))
                    cbMunicipioOperador.SelectedValue = datosOperador.Domicilio.Municipio
                    cbLocalidadOperador.SelectedValue = datosOperador.Domicilio.Localidad
                Else
                    ReemplazaEnGrid(txtMunicipioOperador, cbMunicipioOperador, tlpDireccionOperador)
                    ReemplazaEnGrid(txtLocalidadOperador, cbLocalidadOperador, tlpDireccionOperador)
                    txtMunicipioOperador.Text = datosOperador.Domicilio.Municipio
                    txtLocalidadOperador.Text = datosOperador.Domicilio.Localidad
                End If

                'Cargo colonias
                If SeEncuentraValor(pais, listadoPaisesConColonia, separador) Then
                    txtCpOperador.Text = datosOperador.Domicilio.CodigoPostal
                    cbColoniaOperador.SelectedValue = datosOperador.Domicilio.Colonia
                Else
                    ReemplazaEnGrid(txtColoniaOperador, cbColoniaOperador, tlpDireccionOperador)
                    txtColoniaOperador.Text = datosOperador.Domicilio.Colonia
                    txtCpOperador.Text = datosOperador.Domicilio.CodigoPostal
                End If

                'Finalmente cargo el resto de datos
                txtCalleOperador.Text = datosOperador.Domicilio.Calle
                txtReferenciaOperador.Text = datosOperador.Domicilio.Referencia
                txtNoIntDestino.Text = datosOperador.Domicilio.NumeroInterior
                txtNoExtDestino.Text = datosOperador.Domicilio.NumeroExterior
            End If
        End If
    End Sub

    Private Sub ToggleDatosOperador()
        If rbOperadorExtranjero.Checked Then
            txtRfcOperador.Text = ObtenParametroPorLlave("XEXX010101000")
            txtNumRegIdTribFiscOperador.Enabled = True
            txtRfcOperador.Enabled = False
        ElseIf rbOperadorMexicano.Checked Then
            txtRfcOperador.Text = String.Empty
            txtRfcOperador.Enabled = True
            txtNumRegIdTribFiscOperador.Text = String.Empty
            txtNumRegIdTribFiscOperador.Enabled = False
        End If
    End Sub

    Private Sub BindGridPartesTransporteOperador()
        If gvParteTransporteOperador.Rows IsNot Nothing Then
            gvParteTransporteOperador.Rows.Clear()
        End If
        gvParteTransporteOperador.DataSource = Nothing
        If listaParteTransporte Is Nothing Then Return
        gvParteTransporteOperador.Columns("ParteTransporteAnadidoClm").DataPropertyName = NameOf(ItemTransporte.DescripcionTipoTransporte)
        gvParteTransporteOperador.Columns("IdParteTransporteClm").DataPropertyName = NameOf(ItemTransporte.Id)
        gvParteTransporteOperador.DataSource = listaParteTransporte
    End Sub

    Private Sub AnadirParteTransporteOperador()
        If cbParteTransporteOperador.SelectedValue = "-01" Then Return
        If listaParteTransporte Is Nothing Then listaParteTransporte = New List(Of ItemTransporte)

        Dim nuevoId As Int32
        Dim existeId As Boolean = True
        While existeId
            nuevoId = Math.Ceiling(Rnd() * 100)
            Dim transRep As ItemTransporte = listaParteTransporte.Where(Function(it) it.Id = nuevoId).FirstOrDefault()
            existeId = (transRep IsNot Nothing)
        End While

        Dim itemTransporte As New ItemTransporte
        itemTransporte.Id = nuevoId
        itemTransporte.TipoTransporte = cbParteTransporteOperador.SelectedValue
        itemTransporte.DescripcionTipoTransporte = cbParteTransporteOperador.SelectedText
        listaParteTransporte.Add(itemTransporte)
        cbParteTransporteOperador.SelectedValue = "-01"
        BindGridPartesTransporteOperador()
    End Sub

    Private Sub EliminaParteTransporteOperador(ByVal id As Int32)
        Dim transpAEliminar As ItemTransporte = listaParteTransporte.Where(Function(it) it.Id = id).FirstOrDefault()
        listaParteTransporte.Remove(transpAEliminar)
        BindGridPartesTransporteOperador()
    End Sub

    Private Sub rbOperadorMexicano_CheckedChanged(sender As Object, e As EventArgs) Handles rbOperadorMexicano.CheckedChanged
        ToggleDatosOperador()
    End Sub

    Private Sub rbOperadorExtranjero_CheckedChanged(sender As Object, e As EventArgs) Handles rbOperadorExtranjero.CheckedChanged
        ToggleDatosOperador()
    End Sub

    Private Sub btnAnadirParteTransporte_Click(sender As Object, e As EventArgs) Handles btnAnadirParteTransporte.Click
        AnadirParteTransporteOperador()
    End Sub

    Private Sub gvParteTransporteOperador_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvParteTransporteOperador.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim indiceIdEliminar As Int32 = gvParteTransporteOperador.Columns.IndexOf(gvParteTransporteOperador.Columns("EliminarParteTransporteClm"))
        If e.ColumnIndex <> indiceIdEliminar Then Return

        Dim indiceIdParte As Int32 = gvParteTransporteOperador.Columns.IndexOf(gvParteTransporteOperador.Columns("IdParteTransporteClm"))
        Dim idOperador As Int32 = CInt(gvParteTransporteOperador.Rows(e.RowIndex).Cells(indiceIdParte).Value)
        EliminaParteTransporteOperador(idOperador)
    End Sub

    Private Sub cbPaisOperador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPaisOperador.SelectedValueChanged
        If cbPaisOperador.SelectedValue = "-01" Then Return

        Dim paisSeleccionado As String = cbPaisOperador.SelectedValue
        Dim listaPaisesConEstados As String = ObtenParametroPorLlave("PAISES_CON_ESTADO")
        Dim listaPaisesConMunicipioLocalidad As String = ObtenParametroPorLlave("PAISES_CON_MUNICIPIO_LOCALIDAD")
        Dim listaPaisesConColonia As String = ObtenParametroPorLlave("PAISES_CON_COLONIAS")
        Dim separador As String = ObtenParametroPorLlave("SEPARADOR")

        'Igual, validación de países con estados
        If SeEncuentraValor(paisSeleccionado, listaPaisesConEstados, separador) Then
            RemueveDeGrid(txtEstadoOperador, tlpDireccionOperador)
            txtEstadoOperador = Nothing
            BindCombobox(cbEstadoOperador, ObtenEstadosPorPais(paisSeleccionado))
        Else
            txtEstadoOperador = New TextBox
            txtEstadoOperador.Text = String.Empty
            ReemplazaEnGrid(txtEstadoOperador, cbEstadoOperador, tlpDireccionOperador)
        End If

        'Luego validación de países con municipios y localidades
        If SeEncuentraValor(paisSeleccionado, listaPaisesConMunicipioLocalidad, separador) Then
            RemueveDeGrid(txtMunicipioOperador, tlpDireccionOperador)
            RemueveDeGrid(txtLocalidadOperador, tlpDireccionOperador)
            txtMunicipioOperador = Nothing
            txtLocalidadOperador = Nothing
        Else
            txtMunicipioOperador = New TextBox
            txtMunicipioOperador.Text = String.Empty
            txtLocalidadOperador = New TextBox
            txtLocalidadOperador.Text = String.Empty
            ReemplazaEnGrid(txtMunicipioOperador, cbMunicipioOperador, tlpDireccionOperador)
            ReemplazaEnGrid(txtLocalidadOperador, cbLocalidadOperador, tlpDireccionOperador)
        End If

        'Luego validación de paises con colonias
        If SeEncuentraValor(paisSeleccionado, listaPaisesConColonia, separador) Then
            RemueveDeGrid(txtColoniaOperador, tlpDireccionOperador)
            txtColoniaOperador = Nothing
        Else
            txtColoniaOperador = New TextBox
            txtColoniaOperador.Text = String.Empty
            ReemplazaEnGrid(txtColoniaOperador, cbColoniaOperador, tlpDireccionOperador)
        End If
    End Sub

    Private Sub cbEstadoOperador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEstadoOperador.SelectedValueChanged
        If txtEstadoOperador IsNot Nothing Then Return
        BindCombobox(cbMunicipioOperador, ObtenMunicipiosPorEstado(cbEstadoOperador.SelectedValue))
        BindCombobox(cbLocalidadOperador, ObtenLocalidadesPorEstado(cbEstadoOperador.SelectedValue))
    End Sub

    Private Sub txtCpOperador_TextChanged(sender As Object, e As EventArgs) Handles txtCpOperador.TextChanged
        LimpiaDesactivaCombobox(cbColoniaOperador)
        If Trim(txtCpOperador.Text).Length <> 5 Then '5 es la longitud de un CP válido
            Return
        End If

        If txtColoniaOperador IsNot Nothing Then 'No tiene caso cargar el catálogo si hay un país sin catalogo de colonias
            Return
        End If

        Dim regExpCP As String = ObtenParametroPorLlave("REGEXP_CODIGO_POSTAL")
        If Regex.IsMatch(Trim(txtCpOperador.Text), regExpCP) Then
            BindCombobox(cbColoniaOperador, ObtenColoniasPorCodigoPostal(Trim(txtCpOperador))
        End If
    End Sub

    Private Sub ValidaInformacionOperador()
        INFORMACION_VALIDA_OPERADOR = False

        Dim cveInternaOperador As String = String.Empty
        Dim rfcOperador As String = String.Empty
        Dim numRegIdTribOperador As String = String.Empty
        Dim nombreOperador As String = String.Empty
        Dim apPaternoOperador As String = String.Empty
        Dim apMaternoOperador As String = String.Empty
        Dim tipoFiguraOperador As String = String.Empty
        Dim esOperadorNacional As Boolean = rbOperadorMexicano.Checked
        Dim esOperadorExtranjero As Boolean = rbOperadorExtranjero.Checked
        Dim paisOperador As String = String.Empty
        Dim estadoOperador As String = String.Empty
        Dim municipioOperador As String = String.Empty
        Dim localidadOperador As String = String.Empty
        Dim coloniaOperador As String = String.Empty
        Dim cpOperador As String = String.Empty
        Dim calleOperador As String = String.Empty
        Dim referenciaOperador As String = String.Empty
        Dim noExtOperador As String = String.Empty
        Dim noIntOperador As String = String.Empty

        If cbOpcionesOperador.SelectedValue = "-01" Then AlertaMensaje(ObtenParametroPorLlave("SELECCIONE_OPERADOR")) : Return
        esOperadorNacional = rbOperadorMexicano.Checked
        esOperadorExtranjero = rbOperadorExtranjero.Checked
        rfcOperador = ObtenValorTextbox(txtRfcOperador)
        numRegIdTribOperador = ObtenValorTextbox(txtNumRegIdTribFiscOperador)

        'Validaciones de rfcs
        If esOperadorNacional Then
            Dim regExpPersonaFisica As String = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_FISICA")
            Dim regExpPersonaMoral As String = ObtenParametroPorLlave("REGEXP_RFC_PERSONA_MORAL")

            If (Not Regex.IsMatch(rfcOperador, regExpPersonaFisica)) And (Not Regex.IsMatch(rfcOperador, regExpPersonaFisica)) Then
                AlertaMensaje(ObtenParametroPorLlave("RFC_NO_VALIDO"))
                Return
            End If
        ElseIf esOperadorExtranjero Then
            If EsCadenaVacia(Trim(numRegIdTribOperador)) Then AlertaMensaje(ObtenParametroPorLlave("NUM_REG_IDTRIB_NO_VALIDO")) : Return
        End If

        nombreOperador = ObtenValorTextbox(txtNombreOperador)
        apPaternoOperador = ObtenValorTextbox(txtApPaternoOperador)
        apMaternoOperador = ObtenValorTextbox(txtApMaternoOperador)
        If EsCadenaVacia(nombreOperador) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_NOMBRE")) : Return

        tipoFiguraOperador = cbTipoFiguraOperador.SelectedValue
        If tipoFiguraOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_TIPO_FIGURA")) : Return

        If esOperadorNacional Then
            paisOperador = cbPaisOperador.SelectedValue
            estadoOperador = ObtenValorCombobox(cbEstadoOperador)
            localidadOperador = ObtenValorCombobox(cbLocalidadOperador)
            municipioOperador = ObtenValorCombobox(cbMunicipioOperador)
            coloniaOperador = ObtenValorCombobox(cbLocalidadOperador)
            If paisOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PAIS")) : Return
            If estadoOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            If municipioOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            If localidadOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_LOCALIDAD")) : Return
            If coloniaOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        Else
            paisOperador = ObtenValorCombobox(cbPaisOperador)
            estadoOperador = IIf(txtEstadoOperador IsNot Nothing, ObtenValorTextbox(txtEstadoOperador), ObtenValorCombobox(cbEstadoOperador))
            municipioOperador = IIf(txtMunicipioOperador IsNot Nothing, ObtenValorTextbox(txtMunicipioOperador), ObtenValorCombobox(cbMunicipioOperador))
            localidadOperador = IIf(txtLocalidadOperador IsNot Nothing, ObtenValorTextbox(txtLocalidadOperador), ObtenValorCombobox(cbLocalidadOperador))
            coloniaOperador = IIf(txtColoniaOperador IsNot Nothing, ObtenValorTextbox(txtColoniaOperador), ObtenValorCombobox(cbColoniaOperador))

            If paisOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_PAIS")) : Return
            If estadoOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_ESTADO")) : Return
            If municipioOperador = "-01" Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_MUNICIPIO")) : Return
            If coloniaOperador = "-01" Or EsCadenaVacia(coloniaOperador) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_COLONIA")) : Return
        End If

        cpOperador = Trim(txtCpOperador.Text)
        If Not Regex.IsMatch(cpOperador, ObtenParametroPorLlave("REGEXP_CADENA_SOLO_NUMEROS'")) Then AlertaMensaje(String.Format(ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS"), "CP OPERADOR")) : Return
        calleOperador = ObtenValorTextbox(txtCalleOperador)
        If EsCadenaVacia(calleOperador) Then AlertaMensaje(ObtenParametroPorLlave("INGRESE_CALLE")) : Return

        noExtOperador = Trim(txtNoExtOperador.Text)
        If Not Regex.IsMatch(noExtOperador, ObtenParametroPorLlave("REGEXP_CADENA_SOLO_NUMEROS'")) Then AlertaMensaje(String.Format(ObtenParametroPorLlave("CAMPO_SOLO_ACEPTA_NUMEROS"), "NO. EXT. OPERADOR")) : Return
        noIntOperador = Trim(txtNoIntOperador.Text)
        referenciaOperador = ObtenValorTextbox(txtReferenciaOperador)

        Dim datosTransportisa As DatosTransportista = New DatosTransportista
        datosTransportisa.CveInternaOperador = cveInternaOperador
        datosTransportisa.TipoFigura = tipoFiguraOperador
        datosTransportisa.RFCFigura = rfcOperador
        datosTransportisa.NumLicencia = ObtenValorTextbox(txtNumLicenciaOperador)
        datosTransportisa.NombreTransportista = nombreOperador
        datosTransportisa.ApellidoPaternoTransportista = apPaternoOperador
        datosTransportisa.ApellidoMaternoTransportista = apMaternoOperador
        datosTransportisa.EsTransportistaNacional = esOperadorNacional
        datosTransportisa.EsTransportistaExtranjero = esOperadorExtranjero
        datosTransportisa.NumRegIdTribFigura = numRegIdTribOperador
        datosTransportisa.ResidenciaFiscalFigura = paisOperador
        datosTransportisa.ParteTransporte = listaParteTransporte

        Dim domicilioOperador As New Domicilio
        domicilioOperador.Calle = calleOperador
        domicilioOperador.NumeroExterior = noExtOperador
        domicilioOperador.NumeroInterior = noIntOperador
        domicilioOperador.Colonia = coloniaOperador
        domicilioOperador.Localidad = localidadOperador
        domicilioOperador.Municipio = municipioOperador
        domicilioOperador.Estado = estadoOperador
        domicilioOperador.Pais = paisOperador
        domicilioOperador.CodigoPostal = cpOperador
        domicilioOperador.Referencia = referenciaOperador

        datosTransportisa.Domicilio = domicilioOperador
        datosAutoTransporte.Transportista = datosTransportisa

        INFORMACION_VALIDA_OPERADOR = True
    End Sub

    Private Sub btnSiguienteOperador_Click(sender As Object, e As EventArgs) Handles btnSiguienteOperador.Click
        ValidaInformacionOperador()
        If INFORMACION_VALIDA_OPERADOR Then
            TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnAtrasOperador_Click(sender As Object, e As EventArgs) Handles btnAtrasOperador.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
    End Sub
End Class