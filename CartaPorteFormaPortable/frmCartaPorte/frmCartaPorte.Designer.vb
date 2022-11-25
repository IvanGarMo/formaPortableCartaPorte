<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartaPorte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabOrigen = New System.Windows.Forms.TabPage()
        Me.tlpPrincipalOrigen = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContenedorDatosFiscalesOrigen = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbOrigenPersonaFisicaMoral = New System.Windows.Forms.GroupBox()
        Me.rbExtranjeroOrigen = New System.Windows.Forms.RadioButton()
        Me.rbPersonaMoralOrigen = New System.Windows.Forms.RadioButton()
        Me.rbPersonaFisicaOrigen = New System.Windows.Forms.RadioButton()
        Me.lblNombreOrigen = New System.Windows.Forms.Label()
        Me.lblApPaternoOrigen = New System.Windows.Forms.Label()
        Me.lblApMaternoOrigen = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTipoUbicacion = New System.Windows.Forms.TextBox()
        Me.txtIdUbicacionOrigen = New System.Windows.Forms.TextBox()
        Me.txtRfcRemitente = New System.Windows.Forms.TextBox()
        Me.txtNombreRemitente = New System.Windows.Forms.TextBox()
        Me.txtApMaternoRemitente = New System.Windows.Forms.TextBox()
        Me.txtApPaternoRemitente = New System.Windows.Forms.TextBox()
        Me.txtNumRegidTribRemitente = New System.Windows.Forms.TextBox()
        Me.txtPaisResidenciaFiscalRemitente = New System.Windows.Forms.TextBox()
        Me.dtFechaSalidaRemitente = New System.Windows.Forms.DateTimePicker()
        Me.cbResidenciaFiscalRemitente = New System.Windows.Forms.ComboBox()
        Me.txtHoraSalidaRemitente = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tlpDetalleDomicilioOrigen = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtReferenciaRemitente = New System.Windows.Forms.TextBox()
        Me.txtCalleRemitente = New System.Windows.Forms.TextBox()
        Me.txtNoExtRemitente = New System.Windows.Forms.TextBox()
        Me.txtNoIntRemitente = New System.Windows.Forms.TextBox()
        Me.txtCpRemitente = New System.Windows.Forms.TextBox()
        Me.cbPaisRemitente = New System.Windows.Forms.ComboBox()
        Me.cbEstadoRemitente = New System.Windows.Forms.ComboBox()
        Me.cbMunicipioRemitente = New System.Windows.Forms.ComboBox()
        Me.cbLocalidadRemitente = New System.Windows.Forms.ComboBox()
        Me.cbColoniaOrigen = New System.Windows.Forms.ComboBox()
        Me.btnSiguienteOrigen = New System.Windows.Forms.Button()
        Me.tabDestino = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpDatosDestino = New System.Windows.Forms.TableLayoutPanel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbEsExtranjeroDestino = New System.Windows.Forms.RadioButton()
        Me.rbPersonaMoralDestino = New System.Windows.Forms.RadioButton()
        Me.rbPersonaFisicaDestino = New System.Windows.Forms.RadioButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtTipoUbicacionDestino = New System.Windows.Forms.TextBox()
        Me.txtIdUbicacionDestino = New System.Windows.Forms.TextBox()
        Me.txtRfcDestino = New System.Windows.Forms.TextBox()
        Me.txtNombreDestino = New System.Windows.Forms.TextBox()
        Me.txtApMaternoDestino = New System.Windows.Forms.TextBox()
        Me.txtApPaternoDestino = New System.Windows.Forms.TextBox()
        Me.txtNumIdRegFiscalDestino = New System.Windows.Forms.TextBox()
        Me.txtResidenciaFiscalDestino = New System.Windows.Forms.TextBox()
        Me.dtFechaSalidaDestino = New System.Windows.Forms.DateTimePicker()
        Me.cbResidenciaFiscalDestino = New System.Windows.Forms.ComboBox()
        Me.tlpHoraLlegadaDestino = New System.Windows.Forms.TableLayoutPanel()
        Me.txtHoraSalidaDestino = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tlpNumKilometros = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nupKmRecorridos = New System.Windows.Forms.NumericUpDown()
        Me.tlpDetallesDestino = New System.Windows.Forms.TableLayoutPanel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtReferenciaDestino = New System.Windows.Forms.TextBox()
        Me.txtCalleDestino = New System.Windows.Forms.TextBox()
        Me.txtNoExtDestino = New System.Windows.Forms.TextBox()
        Me.txtNoIntDestino = New System.Windows.Forms.TextBox()
        Me.txtCpDestino = New System.Windows.Forms.TextBox()
        Me.cbPaisDestino = New System.Windows.Forms.ComboBox()
        Me.cbEstadoDestino = New System.Windows.Forms.ComboBox()
        Me.cbMunicipioDestino = New System.Windows.Forms.ComboBox()
        Me.cbLocalidadDestino = New System.Windows.Forms.ComboBox()
        Me.cbColoniaDestino = New System.Windows.Forms.ComboBox()
        Me.tlpBotonesSiguienteAtrasDestino = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAtrasDestino = New System.Windows.Forms.Button()
        Me.btnSiguienteDestino = New System.Windows.Forms.Button()
        Me.tabDestinosIntermedios = New System.Windows.Forms.TabPage()
        Me.tlpMainDestinosIntermedios = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpDetallesDestinoIntermedio = New System.Windows.Forms.TableLayoutPanel()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtReferenciaDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtCalleDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtNoExtDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtNoIntDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtCpDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.cbPaisDestinoIntermedio = New System.Windows.Forms.ComboBox()
        Me.cbEstadoDestinoIntermedio = New System.Windows.Forms.ComboBox()
        Me.cbMunicipioDestinoIntermedio = New System.Windows.Forms.ComboBox()
        Me.cbLocalidadDestinoIntermedio = New System.Windows.Forms.ComboBox()
        Me.cbColoniaDestinoIntermedio = New System.Windows.Forms.ComboBox()
        Me.tlpDatosFiscalesDestinoIntermedio = New System.Windows.Forms.TableLayoutPanel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbEsExtranjeroDestinoIntermedio = New System.Windows.Forms.RadioButton()
        Me.rbEsPersonaMoralDestinoIntermedio = New System.Windows.Forms.RadioButton()
        Me.rbEsPersonaFisicaDestinoIntermedio = New System.Windows.Forms.RadioButton()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtTipoUbicacionDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtIdUbicacionDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtRfcDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtNombreDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtApMaternoDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtApPaternoDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtNumregIdTribDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtPaisResidenciaFiscalDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.dtFechaLlegadaDestinoIntermedio = New System.Windows.Forms.DateTimePicker()
        Me.cbPaisResidenciaFiscalDestinoIntermedio = New System.Windows.Forms.ComboBox()
        Me.tlpHoraLlegadaDestinoIntermedio = New System.Windows.Forms.TableLayoutPanel()
        Me.txtHoraLlegadaDestinoIntermedio = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tlpKmDestinoIntermedio = New System.Windows.Forms.TableLayoutPanel()
        Me.nupKmDestinoIntermedio = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFechaHoraMaximaDestInter = New System.Windows.Forms.Label()
        Me.tlpGridDestinosIntermedios = New System.Windows.Forms.TableLayoutPanel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.dgvCartaPorteDestinosIntermedios = New System.Windows.Forms.DataGridView()
        Me.DIMovimientoClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIDestinoClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIFechaLlegadaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIHoraLlegadaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIKmClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIVerClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DIEliminarClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IDUbicacionClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIUsuarioProblemasFechaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIUsuarioCausoProblemasConKm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSiguienteDestinosIntermedios = New System.Windows.Forms.Button()
        Me.btnAtrasDestinosIntermedios = New System.Windows.Forms.Button()
        Me.btnReiniciarDestinosIntermedios = New System.Windows.Forms.Button()
        Me.btnGuardarDestinosIntermedios = New System.Windows.Forms.Button()
        Me.btnLimpiarDestinosIntermedios = New System.Windows.Forms.Button()
        Me.tabMercancias = New System.Windows.Forms.TabPage()
        Me.tlpPrincipalMercancias = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContenedorGridMovimientosPestanaMercancias = New System.Windows.Forms.TableLayoutPanel()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.dgvListadoMovimientosPestanaMercancia = New System.Windows.Forms.DataGridView()
        Me.MovimientoMercanciaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinoMercanciaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosTipoMovimientoClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercanciasBtnClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AnadirMercanciaMovimientoClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IdUbicacionMovimientoPestanaMercanciaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias = New System.Windows.Forms.TableLayoutPanel()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.dgvMercanciasPorMovimiento = New System.Windows.Forms.DataGridView()
        Me.MercanciaClaveProdServClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientoDescripcionClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveUnidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionUnidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercanciaMovimientoPeligrosaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientoComercioIntClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientoDetallesMercClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MovimientoMercanciaEliminarClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MovimientoMercanciaCheckboxMaterialPeligrosoClm = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tlpDetallesMercancia = New System.Windows.Forms.TableLayoutPanel()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txtClaveProdServMercancia = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txtCantidadMercancia = New System.Windows.Forms.TextBox()
        Me.txtUnidadClaveMercancia = New System.Windows.Forms.TextBox()
        Me.txtUnidadMercancia = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.tlpContenedorAltura = New System.Windows.Forms.TableLayoutPanel()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.numAnchura = New System.Windows.Forms.NumericUpDown()
        Me.tlpContenedorAnchura = New System.Windows.Forms.TableLayoutPanel()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.numAltura = New System.Windows.Forms.NumericUpDown()
        Me.tlpContenedorLongitud = New System.Windows.Forms.TableLayoutPanel()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.numLongitud = New System.Windows.Forms.NumericUpDown()
        Me.cbOpcionDimensiones = New System.Windows.Forms.ComboBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txtClaveMaterialPeligroso = New System.Windows.Forms.TextBox()
        Me.txtEmbalaje = New System.Windows.Forms.TextBox()
        Me.txtDescripcionMaterialPeligroso = New System.Windows.Forms.TextBox()
        Me.txtDescripcionEmbalaje = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.txtPedimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtFraccionArancelaria = New System.Windows.Forms.TextBox()
        Me.pnlMaterialPeligroso = New System.Windows.Forms.Panel()
        Me.rbSiMaterialPeligroso = New System.Windows.Forms.RadioButton()
        Me.rbNoMaterialPeligroso = New System.Windows.Forms.RadioButton()
        Me.pnlComercioInternacional = New System.Windows.Forms.Panel()
        Me.rbComercioInternacionalSi = New System.Windows.Forms.RadioButton()
        Me.rbComercioInternacionalNo = New System.Windows.Forms.RadioButton()
        Me.tlpSiguienteAtrasMercancias = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAtrasMercancia = New System.Windows.Forms.Button()
        Me.btnGuardarMercancia = New System.Windows.Forms.Button()
        Me.btnSiguienteMercancia = New System.Windows.Forms.Button()
        Me.btnLimpiarMercancia = New System.Windows.Forms.Button()
        Me.tabTransporte = New System.Windows.Forms.TabPage()
        Me.tlpContenedorPrincipalTransporte = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAtrasTransporte = New System.Windows.Forms.Button()
        Me.btnSiguienteTransporte = New System.Windows.Forms.Button()
        Me.tlpContenedorDatosTransporte = New System.Windows.Forms.TableLayoutPanel()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.cbSeleccionarVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.txtNumPermisoSCT = New System.Windows.Forms.TextBox()
        Me.txtDescripConfigVehicular = New System.Windows.Forms.TextBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.txtPlacaTransporte = New System.Windows.Forms.TextBox()
        Me.txtAnioModeloTransporte = New System.Windows.Forms.TextBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.txtAseguradoraTransporte = New System.Windows.Forms.TextBox()
        Me.txtPolizaTransporte = New System.Windows.Forms.TextBox()
        Me.txtAseguradoraCargaTransporte = New System.Windows.Forms.TextBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.tlpContenedorPoliza = New System.Windows.Forms.TableLayoutPanel()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txtPolizaCargaTransporte = New System.Windows.Forms.TextBox()
        Me.tlpContenedorPrimaSeguro = New System.Windows.Forms.TableLayoutPanel()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.txtPrimaSeguroTransporte = New System.Windows.Forms.TextBox()
        Me.txtConVeh = New System.Windows.Forms.TextBox()
        Me.txtTipoPermisoSCT = New System.Windows.Forms.TextBox()
        Me.txtDescripcionTipoPermisoSCT = New System.Windows.Forms.TextBox()
        Me.tlpContenedorRemolques = New System.Windows.Forms.TableLayoutPanel()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.numCantidadRemolquesTransporte = New System.Windows.Forms.NumericUpDown()
        Me.cbPropiedadRemolque1 = New System.Windows.Forms.ComboBox()
        Me.cbPropiedadRemolque2 = New System.Windows.Forms.ComboBox()
        Me.cbTipoRemolque1 = New System.Windows.Forms.ComboBox()
        Me.cbTipoRemolque2 = New System.Windows.Forms.ComboBox()
        Me.txtTipoRemolque1 = New System.Windows.Forms.TextBox()
        Me.txtTipoRemolque2 = New System.Windows.Forms.TextBox()
        Me.txtPlacasRemolque1 = New System.Windows.Forms.TextBox()
        Me.txtPlacasRemolque2 = New System.Windows.Forms.TextBox()
        Me.tlpContenedorSeguroMaterialPeligroso = New System.Windows.Forms.TableLayoutPanel()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.txtAseguradoraDanosMedioAmbiente = New System.Windows.Forms.TextBox()
        Me.txtPolizaSegurosDanosMedioAmbiente = New System.Windows.Forms.TextBox()
        Me.tabOperador = New System.Windows.Forms.TabPage()
        Me.tlpContenedorPrincipalOperador = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpSeleccionOperador = New System.Windows.Forms.TableLayoutPanel()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.txtRfcOperador = New System.Windows.Forms.TextBox()
        Me.txtNumRegIdTribFiscOperador = New System.Windows.Forms.TextBox()
        Me.txtNombreOperador = New System.Windows.Forms.TextBox()
        Me.txtApPaternoOperador = New System.Windows.Forms.TextBox()
        Me.txtApMaternoOperador = New System.Windows.Forms.TextBox()
        Me.cbTipoFiguraOperador = New System.Windows.Forms.ComboBox()
        Me.rbOperadorMexicano = New System.Windows.Forms.RadioButton()
        Me.rbOperadorExtranjero = New System.Windows.Forms.RadioButton()
        Me.cbOpcionesOperador = New System.Windows.Forms.ComboBox()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.txtNumLicenciaOperador = New System.Windows.Forms.TextBox()
        Me.tlpDireccionOperador = New System.Windows.Forms.TableLayoutPanel()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.tlpNoIntDomicilioOperador = New System.Windows.Forms.TableLayoutPanel()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.txtNoExtOperador = New System.Windows.Forms.TextBox()
        Me.tlpNoExtDomicilioOperador = New System.Windows.Forms.TableLayoutPanel()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.txtNoIntOperador = New System.Windows.Forms.TextBox()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.cbPaisOperador = New System.Windows.Forms.ComboBox()
        Me.cbEstadoOperador = New System.Windows.Forms.ComboBox()
        Me.cbMunicipioOperador = New System.Windows.Forms.ComboBox()
        Me.cbLocalidadOperador = New System.Windows.Forms.ComboBox()
        Me.cbColoniaOperador = New System.Windows.Forms.ComboBox()
        Me.txtCpOperador = New System.Windows.Forms.TextBox()
        Me.txtCalleOperador = New System.Windows.Forms.TextBox()
        Me.txtReferenciaOperador = New System.Windows.Forms.TextBox()
        Me.tlpAtrasSiguienteOperador = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAtrasOperador = New System.Windows.Forms.Button()
        Me.btnSiguienteOperador = New System.Windows.Forms.Button()
        Me.tlpPartesTransporteOperador = New System.Windows.Forms.TableLayoutPanel()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.cbParteTransporteOperador = New System.Windows.Forms.ComboBox()
        Me.btnAnadirParteTransporte = New System.Windows.Forms.Button()
        Me.gvParteTransporteOperador = New System.Windows.Forms.DataGridView()
        Me.ParteTransporteAnadidoClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarParteTransporteClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tabConfirmacion = New System.Windows.Forms.TabPage()
        Me.tlpPrincipalConfirmacion = New System.Windows.Forms.TableLayoutPanel()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.tlpUbicacionesConfirmacion = New System.Windows.Forms.TableLayoutPanel()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.dgvConfirmacionUbicaciones = New System.Windows.Forms.DataGridView()
        Me.IdUbicacionClmMercMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinoUbiClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDestinoPestUbiClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PestanaFinalVerDetallesClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tlpMercanciasSinAsignar = New System.Windows.Forms.TableLayoutPanel()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.dgvMercanciasSinUbicaciones = New System.Windows.Forms.DataGridView()
        Me.AsignarClaveProdServClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignarDescripcionMercClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignarClaveUnidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignarDescUnidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignarPeligrosoClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignarCantidadRestanteClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignarCantidadParaAsignarClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignarDestinoAccionClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tlpRelacionMercanciaUbicaciones = New System.Windows.Forms.TableLayoutPanel()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.dgvRelacionMercanciaUbicaciones = New System.Windows.Forms.DataGridView()
        Me.RelMercUbiIdUbiClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelMercUbiClaveProdServClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelMercUbiDescMercClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelMercUbiClaveUnidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelMercUbiDescUnidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelacionMercUbiPeligrosaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelMercUbiCantidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelMercUbiBtnEliminarClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RelMercUbiCantidadMaxima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpDatosFinalesCarga = New System.Windows.Forms.TableLayoutPanel()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.txtPesoBrutoTotalMercancias = New System.Windows.Forms.TextBox()
        Me.txtUnidadPesoTotalMercancias = New System.Windows.Forms.TextBox()
        Me.tlpBotonesGenerarAtras = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAtrasConfirmacion = New System.Windows.Forms.Button()
        Me.btnGenerarCartaPorte = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabOrigen.SuspendLayout()
        Me.tlpPrincipalOrigen.SuspendLayout()
        Me.tlpContenedorDatosFiscalesOrigen.SuspendLayout()
        Me.gbOrigenPersonaFisicaMoral.SuspendLayout()
        Me.tlpDetalleDomicilioOrigen.SuspendLayout()
        Me.tabDestino.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpDatosDestino.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tlpHoraLlegadaDestino.SuspendLayout()
        Me.tlpNumKilometros.SuspendLayout()
        CType(Me.nupKmRecorridos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDetallesDestino.SuspendLayout()
        Me.tlpBotonesSiguienteAtrasDestino.SuspendLayout()
        Me.tabDestinosIntermedios.SuspendLayout()
        Me.tlpMainDestinosIntermedios.SuspendLayout()
        Me.tlpDetallesDestinoIntermedio.SuspendLayout()
        Me.tlpDatosFiscalesDestinoIntermedio.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tlpHoraLlegadaDestinoIntermedio.SuspendLayout()
        Me.tlpKmDestinoIntermedio.SuspendLayout()
        CType(Me.nupKmDestinoIntermedio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpGridDestinosIntermedios.SuspendLayout()
        CType(Me.dgvCartaPorteDestinosIntermedios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.SuspendLayout()
        Me.tabMercancias.SuspendLayout()
        Me.tlpPrincipalMercancias.SuspendLayout()
        Me.tlpContenedorGridMovimientosPestanaMercancias.SuspendLayout()
        CType(Me.dgvListadoMovimientosPestanaMercancia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.SuspendLayout()
        CType(Me.dgvMercanciasPorMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDetallesMercancia.SuspendLayout()
        Me.tlpContenedorAltura.SuspendLayout()
        CType(Me.numAnchura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpContenedorAnchura.SuspendLayout()
        CType(Me.numAltura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpContenedorLongitud.SuspendLayout()
        CType(Me.numLongitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMaterialPeligroso.SuspendLayout()
        Me.pnlComercioInternacional.SuspendLayout()
        Me.tlpSiguienteAtrasMercancias.SuspendLayout()
        Me.tabTransporte.SuspendLayout()
        Me.tlpContenedorPrincipalTransporte.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.tlpContenedorDatosTransporte.SuspendLayout()
        Me.tlpContenedorPoliza.SuspendLayout()
        Me.tlpContenedorPrimaSeguro.SuspendLayout()
        Me.tlpContenedorRemolques.SuspendLayout()
        CType(Me.numCantidadRemolquesTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpContenedorSeguroMaterialPeligroso.SuspendLayout()
        Me.tabOperador.SuspendLayout()
        Me.tlpContenedorPrincipalOperador.SuspendLayout()
        Me.tlpSeleccionOperador.SuspendLayout()
        Me.tlpDireccionOperador.SuspendLayout()
        Me.tlpNoIntDomicilioOperador.SuspendLayout()
        Me.tlpNoExtDomicilioOperador.SuspendLayout()
        Me.tlpAtrasSiguienteOperador.SuspendLayout()
        Me.tlpPartesTransporteOperador.SuspendLayout()
        CType(Me.gvParteTransporteOperador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConfirmacion.SuspendLayout()
        Me.tlpPrincipalConfirmacion.SuspendLayout()
        Me.tlpUbicacionesConfirmacion.SuspendLayout()
        CType(Me.dgvConfirmacionUbicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMercanciasSinAsignar.SuspendLayout()
        CType(Me.dgvMercanciasSinUbicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRelacionMercanciaUbicaciones.SuspendLayout()
        CType(Me.dgvRelacionMercanciaUbicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDatosFinalesCarga.SuspendLayout()
        Me.tlpBotonesGenerarAtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabOrigen)
        Me.TabControl1.Controls.Add(Me.tabDestino)
        Me.TabControl1.Controls.Add(Me.tabDestinosIntermedios)
        Me.TabControl1.Controls.Add(Me.tabMercancias)
        Me.TabControl1.Controls.Add(Me.tabTransporte)
        Me.TabControl1.Controls.Add(Me.tabOperador)
        Me.TabControl1.Controls.Add(Me.tabConfirmacion)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1111, 657)
        Me.TabControl1.TabIndex = 0
        '
        'tabOrigen
        '
        Me.tabOrigen.Controls.Add(Me.tlpPrincipalOrigen)
        Me.tabOrigen.Location = New System.Drawing.Point(4, 29)
        Me.tabOrigen.Name = "tabOrigen"
        Me.tabOrigen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrigen.Size = New System.Drawing.Size(1103, 624)
        Me.tabOrigen.TabIndex = 0
        Me.tabOrigen.Text = "Origen"
        Me.tabOrigen.UseVisualStyleBackColor = True
        '
        'tlpPrincipalOrigen
        '
        Me.tlpPrincipalOrigen.ColumnCount = 1
        Me.tlpPrincipalOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipalOrigen.Controls.Add(Me.tlpContenedorDatosFiscalesOrigen, 0, 0)
        Me.tlpPrincipalOrigen.Controls.Add(Me.tlpDetalleDomicilioOrigen, 0, 1)
        Me.tlpPrincipalOrigen.Controls.Add(Me.btnSiguienteOrigen, 0, 2)
        Me.tlpPrincipalOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipalOrigen.Location = New System.Drawing.Point(3, 3)
        Me.tlpPrincipalOrigen.Name = "tlpPrincipalOrigen"
        Me.tlpPrincipalOrigen.RowCount = 3
        Me.tlpPrincipalOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipalOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpPrincipalOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipalOrigen.Size = New System.Drawing.Size(1097, 618)
        Me.tlpPrincipalOrigen.TabIndex = 0
        '
        'tlpContenedorDatosFiscalesOrigen
        '
        Me.tlpContenedorDatosFiscalesOrigen.BackColor = System.Drawing.Color.Transparent
        Me.tlpContenedorDatosFiscalesOrigen.ColumnCount = 4
        Me.tlpContenedorDatosFiscalesOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpContenedorDatosFiscalesOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpContenedorDatosFiscalesOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpContenedorDatosFiscalesOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.Label1, 0, 0)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.Label2, 0, 1)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.Label3, 2, 1)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.gbOrigenPersonaFisicaMoral, 0, 2)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.lblNombreOrigen, 0, 3)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.lblApPaternoOrigen, 2, 3)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.lblApMaternoOrigen, 0, 4)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.Label8, 0, 5)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.Label9, 0, 6)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.Label10, 0, 7)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.Label11, 2, 7)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.txtTipoUbicacion, 1, 1)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.txtIdUbicacionOrigen, 3, 1)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.txtRfcRemitente, 3, 2)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.txtNombreRemitente, 1, 3)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.txtApMaternoRemitente, 1, 4)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.txtApPaternoRemitente, 3, 3)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.txtNumRegidTribRemitente, 2, 5)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.txtPaisResidenciaFiscalRemitente, 2, 6)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.dtFechaSalidaRemitente, 1, 7)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.cbResidenciaFiscalRemitente, 1, 6)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.txtHoraSalidaRemitente, 3, 7)
        Me.tlpContenedorDatosFiscalesOrigen.Controls.Add(Me.Label4, 2, 2)
        Me.tlpContenedorDatosFiscalesOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorDatosFiscalesOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpContenedorDatosFiscalesOrigen.Location = New System.Drawing.Point(3, 3)
        Me.tlpContenedorDatosFiscalesOrigen.Name = "tlpContenedorDatosFiscalesOrigen"
        Me.tlpContenedorDatosFiscalesOrigen.RowCount = 8
        Me.tlpContenedorDatosFiscalesOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.26761!))
        Me.tlpContenedorDatosFiscalesOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpContenedorDatosFiscalesOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpContenedorDatosFiscalesOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpContenedorDatosFiscalesOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpContenedorDatosFiscalesOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpContenedorDatosFiscalesOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpContenedorDatosFiscalesOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpContenedorDatosFiscalesOrigen.Size = New System.Drawing.Size(1091, 303)
        Me.tlpContenedorDatosFiscalesOrigen.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos de la ubicación origen:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo ubicación: *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.IndianRed
        Me.Label3.Location = New System.Drawing.Point(547, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Ubicación: *"
        '
        'gbOrigenPersonaFisicaMoral
        '
        Me.tlpContenedorDatosFiscalesOrigen.SetColumnSpan(Me.gbOrigenPersonaFisicaMoral, 2)
        Me.gbOrigenPersonaFisicaMoral.Controls.Add(Me.rbExtranjeroOrigen)
        Me.gbOrigenPersonaFisicaMoral.Controls.Add(Me.rbPersonaMoralOrigen)
        Me.gbOrigenPersonaFisicaMoral.Controls.Add(Me.rbPersonaFisicaOrigen)
        Me.gbOrigenPersonaFisicaMoral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbOrigenPersonaFisicaMoral.Location = New System.Drawing.Point(3, 75)
        Me.gbOrigenPersonaFisicaMoral.Name = "gbOrigenPersonaFisicaMoral"
        Me.gbOrigenPersonaFisicaMoral.Size = New System.Drawing.Size(538, 32)
        Me.gbOrigenPersonaFisicaMoral.TabIndex = 4
        Me.gbOrigenPersonaFisicaMoral.TabStop = False
        '
        'rbExtranjeroOrigen
        '
        Me.rbExtranjeroOrigen.AutoSize = True
        Me.rbExtranjeroOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExtranjeroOrigen.Location = New System.Drawing.Point(361, 0)
        Me.rbExtranjeroOrigen.Name = "rbExtranjeroOrigen"
        Me.rbExtranjeroOrigen.Size = New System.Drawing.Size(140, 24)
        Me.rbExtranjeroOrigen.TabIndex = 4
        Me.rbExtranjeroOrigen.TabStop = True
        Me.rbExtranjeroOrigen.Text = "Es extranjero"
        Me.rbExtranjeroOrigen.UseVisualStyleBackColor = True
        '
        'rbPersonaMoralOrigen
        '
        Me.rbPersonaMoralOrigen.AutoSize = True
        Me.rbPersonaMoralOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPersonaMoralOrigen.Location = New System.Drawing.Point(175, 0)
        Me.rbPersonaMoralOrigen.Name = "rbPersonaMoralOrigen"
        Me.rbPersonaMoralOrigen.Size = New System.Drawing.Size(149, 24)
        Me.rbPersonaMoralOrigen.TabIndex = 3
        Me.rbPersonaMoralOrigen.TabStop = True
        Me.rbPersonaMoralOrigen.Text = "Persona moral"
        Me.rbPersonaMoralOrigen.UseVisualStyleBackColor = True
        '
        'rbPersonaFisicaOrigen
        '
        Me.rbPersonaFisicaOrigen.AutoSize = True
        Me.rbPersonaFisicaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPersonaFisicaOrigen.Location = New System.Drawing.Point(0, -3)
        Me.rbPersonaFisicaOrigen.Name = "rbPersonaFisicaOrigen"
        Me.rbPersonaFisicaOrigen.Size = New System.Drawing.Size(147, 24)
        Me.rbPersonaFisicaOrigen.TabIndex = 2
        Me.rbPersonaFisicaOrigen.TabStop = True
        Me.rbPersonaFisicaOrigen.Text = "Persona física"
        Me.rbPersonaFisicaOrigen.UseVisualStyleBackColor = True
        '
        'lblNombreOrigen
        '
        Me.lblNombreOrigen.AutoSize = True
        Me.lblNombreOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreOrigen.ForeColor = System.Drawing.Color.IndianRed
        Me.lblNombreOrigen.Location = New System.Drawing.Point(3, 110)
        Me.lblNombreOrigen.Name = "lblNombreOrigen"
        Me.lblNombreOrigen.Size = New System.Drawing.Size(88, 20)
        Me.lblNombreOrigen.TabIndex = 5
        Me.lblNombreOrigen.Text = "Nombre: *"
        '
        'lblApPaternoOrigen
        '
        Me.lblApPaternoOrigen.AutoSize = True
        Me.lblApPaternoOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApPaternoOrigen.ForeColor = System.Drawing.Color.IndianRed
        Me.lblApPaternoOrigen.Location = New System.Drawing.Point(547, 110)
        Me.lblApPaternoOrigen.Name = "lblApPaternoOrigen"
        Me.lblApPaternoOrigen.Size = New System.Drawing.Size(157, 20)
        Me.lblApPaternoOrigen.TabIndex = 6
        Me.lblApPaternoOrigen.Text = "Apellido paterno: *"
        '
        'lblApMaternoOrigen
        '
        Me.lblApMaternoOrigen.AutoSize = True
        Me.lblApMaternoOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApMaternoOrigen.ForeColor = System.Drawing.Color.IndianRed
        Me.lblApMaternoOrigen.Location = New System.Drawing.Point(3, 148)
        Me.lblApMaternoOrigen.Name = "lblApMaternoOrigen"
        Me.lblApMaternoOrigen.Size = New System.Drawing.Size(161, 20)
        Me.lblApMaternoOrigen.TabIndex = 7
        Me.lblApMaternoOrigen.Text = "Apellido materno: *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.tlpContenedorDatosFiscalesOrigen.SetColumnSpan(Me.Label8, 2)
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(538, 38)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Número de identificación o registro fiscal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Residencia fiscal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.IndianRed
        Me.Label10.Location = New System.Drawing.Point(3, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Fecha de salida: *"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.IndianRed
        Me.Label11.Location = New System.Drawing.Point(547, 262)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Hora de salida: *"
        '
        'txtTipoUbicacion
        '
        Me.txtTipoUbicacion.BackColor = System.Drawing.Color.White
        Me.txtTipoUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoUbicacion.Location = New System.Drawing.Point(275, 37)
        Me.txtTipoUbicacion.Name = "txtTipoUbicacion"
        Me.txtTipoUbicacion.Size = New System.Drawing.Size(266, 26)
        Me.txtTipoUbicacion.TabIndex = 0
        '
        'txtIdUbicacionOrigen
        '
        Me.txtIdUbicacionOrigen.BackColor = System.Drawing.Color.White
        Me.txtIdUbicacionOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIdUbicacionOrigen.Location = New System.Drawing.Point(819, 37)
        Me.txtIdUbicacionOrigen.Name = "txtIdUbicacionOrigen"
        Me.txtIdUbicacionOrigen.Size = New System.Drawing.Size(269, 26)
        Me.txtIdUbicacionOrigen.TabIndex = 1
        '
        'txtRfcRemitente
        '
        Me.txtRfcRemitente.BackColor = System.Drawing.Color.White
        Me.txtRfcRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRfcRemitente.Location = New System.Drawing.Point(819, 75)
        Me.txtRfcRemitente.Name = "txtRfcRemitente"
        Me.txtRfcRemitente.Size = New System.Drawing.Size(269, 26)
        Me.txtRfcRemitente.TabIndex = 5
        '
        'txtNombreRemitente
        '
        Me.txtNombreRemitente.BackColor = System.Drawing.Color.White
        Me.txtNombreRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombreRemitente.Location = New System.Drawing.Point(275, 113)
        Me.txtNombreRemitente.Name = "txtNombreRemitente"
        Me.txtNombreRemitente.Size = New System.Drawing.Size(266, 26)
        Me.txtNombreRemitente.TabIndex = 6
        '
        'txtApMaternoRemitente
        '
        Me.txtApMaternoRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApMaternoRemitente.Location = New System.Drawing.Point(275, 151)
        Me.txtApMaternoRemitente.Name = "txtApMaternoRemitente"
        Me.txtApMaternoRemitente.Size = New System.Drawing.Size(266, 26)
        Me.txtApMaternoRemitente.TabIndex = 8
        '
        'txtApPaternoRemitente
        '
        Me.txtApPaternoRemitente.BackColor = System.Drawing.Color.White
        Me.txtApPaternoRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApPaternoRemitente.Location = New System.Drawing.Point(819, 113)
        Me.txtApPaternoRemitente.Name = "txtApPaternoRemitente"
        Me.txtApPaternoRemitente.Size = New System.Drawing.Size(269, 26)
        Me.txtApPaternoRemitente.TabIndex = 7
        '
        'txtNumRegidTribRemitente
        '
        Me.tlpContenedorDatosFiscalesOrigen.SetColumnSpan(Me.txtNumRegidTribRemitente, 2)
        Me.txtNumRegidTribRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumRegidTribRemitente.Location = New System.Drawing.Point(547, 189)
        Me.txtNumRegidTribRemitente.Name = "txtNumRegidTribRemitente"
        Me.txtNumRegidTribRemitente.Size = New System.Drawing.Size(541, 26)
        Me.txtNumRegidTribRemitente.TabIndex = 9
        '
        'txtPaisResidenciaFiscalRemitente
        '
        Me.tlpContenedorDatosFiscalesOrigen.SetColumnSpan(Me.txtPaisResidenciaFiscalRemitente, 2)
        Me.txtPaisResidenciaFiscalRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPaisResidenciaFiscalRemitente.Location = New System.Drawing.Point(547, 227)
        Me.txtPaisResidenciaFiscalRemitente.Name = "txtPaisResidenciaFiscalRemitente"
        Me.txtPaisResidenciaFiscalRemitente.Size = New System.Drawing.Size(541, 26)
        Me.txtPaisResidenciaFiscalRemitente.TabIndex = 19
        Me.txtPaisResidenciaFiscalRemitente.TabStop = False
        '
        'dtFechaSalidaRemitente
        '
        Me.dtFechaSalidaRemitente.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtFechaSalidaRemitente.CalendarTitleBackColor = System.Drawing.SystemColors.Info
        Me.dtFechaSalidaRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtFechaSalidaRemitente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaSalidaRemitente.Location = New System.Drawing.Point(275, 265)
        Me.dtFechaSalidaRemitente.Name = "dtFechaSalidaRemitente"
        Me.dtFechaSalidaRemitente.Size = New System.Drawing.Size(266, 26)
        Me.dtFechaSalidaRemitente.TabIndex = 11
        '
        'cbResidenciaFiscalRemitente
        '
        Me.cbResidenciaFiscalRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbResidenciaFiscalRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResidenciaFiscalRemitente.FormattingEnabled = True
        Me.cbResidenciaFiscalRemitente.Location = New System.Drawing.Point(275, 227)
        Me.cbResidenciaFiscalRemitente.Name = "cbResidenciaFiscalRemitente"
        Me.cbResidenciaFiscalRemitente.Size = New System.Drawing.Size(266, 28)
        Me.cbResidenciaFiscalRemitente.TabIndex = 10
        '
        'txtHoraSalidaRemitente
        '
        Me.txtHoraSalidaRemitente.BackColor = System.Drawing.Color.White
        Me.txtHoraSalidaRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHoraSalidaRemitente.Location = New System.Drawing.Point(819, 265)
        Me.txtHoraSalidaRemitente.Name = "txtHoraSalidaRemitente"
        Me.txtHoraSalidaRemitente.Size = New System.Drawing.Size(269, 26)
        Me.txtHoraSalidaRemitente.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.IndianRed
        Me.Label4.Location = New System.Drawing.Point(547, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "RFC remitente: *"
        '
        'tlpDetalleDomicilioOrigen
        '
        Me.tlpDetalleDomicilioOrigen.BackColor = System.Drawing.Color.Transparent
        Me.tlpDetalleDomicilioOrigen.ColumnCount = 6
        Me.tlpDetalleDomicilioOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.tlpDetalleDomicilioOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetalleDomicilioOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetalleDomicilioOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetalleDomicilioOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetalleDomicilioOrigen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label12, 0, 0)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label13, 0, 1)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label14, 2, 1)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label15, 4, 1)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label16, 0, 2)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label17, 4, 2)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label18, 0, 3)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label19, 2, 3)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label20, 4, 3)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label21, 0, 4)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.Label22, 0, 5)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.txtReferenciaRemitente, 1, 5)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.txtCalleRemitente, 1, 4)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.txtNoExtRemitente, 3, 3)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.txtNoIntRemitente, 5, 3)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.txtCpRemitente, 5, 2)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.cbPaisRemitente, 1, 1)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.cbEstadoRemitente, 3, 1)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.cbMunicipioRemitente, 5, 1)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.cbLocalidadRemitente, 1, 2)
        Me.tlpDetalleDomicilioOrigen.Controls.Add(Me.cbColoniaOrigen, 1, 3)
        Me.tlpDetalleDomicilioOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDetalleDomicilioOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpDetalleDomicilioOrigen.Location = New System.Drawing.Point(3, 312)
        Me.tlpDetalleDomicilioOrigen.Name = "tlpDetalleDomicilioOrigen"
        Me.tlpDetalleDomicilioOrigen.RowCount = 6
        Me.tlpDetalleDomicilioOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetalleDomicilioOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetalleDomicilioOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetalleDomicilioOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetalleDomicilioOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetalleDomicilioOrigen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetalleDomicilioOrigen.Size = New System.Drawing.Size(1091, 241)
        Me.tlpDetalleDomicilioOrigen.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.tlpDetalleDomicilioOrigen.SetColumnSpan(Me.Label12, 3)
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(548, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Detalles de la ubicación origen:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.IndianRed
        Me.Label13.Location = New System.Drawing.Point(3, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "País: *"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.IndianRed
        Me.Label14.Location = New System.Drawing.Point(379, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Estado: *"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.IndianRed
        Me.Label15.Location = New System.Drawing.Point(735, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 20)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Municipio: *"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.IndianRed
        Me.Label16.Location = New System.Drawing.Point(3, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 20)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Localidad: *"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.IndianRed
        Me.Label17.Location = New System.Drawing.Point(735, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 20)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "CP: *"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.IndianRed
        Me.Label18.Location = New System.Drawing.Point(3, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 20)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Colonia: *"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.IndianRed
        Me.Label19.Location = New System.Drawing.Point(379, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 20)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "No. ext: *"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(735, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 20)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "No. int:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.IndianRed
        Me.Label21.Location = New System.Drawing.Point(3, 153)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 20)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Calle: *"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 196)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 20)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Referencia:"
        '
        'txtReferenciaRemitente
        '
        Me.tlpDetalleDomicilioOrigen.SetColumnSpan(Me.txtReferenciaRemitente, 5)
        Me.txtReferenciaRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReferenciaRemitente.Location = New System.Drawing.Point(201, 199)
        Me.txtReferenciaRemitente.Name = "txtReferenciaRemitente"
        Me.txtReferenciaRemitente.Size = New System.Drawing.Size(887, 26)
        Me.txtReferenciaRemitente.TabIndex = 22
        '
        'txtCalleRemitente
        '
        Me.txtCalleRemitente.BackColor = System.Drawing.Color.White
        Me.tlpDetalleDomicilioOrigen.SetColumnSpan(Me.txtCalleRemitente, 4)
        Me.txtCalleRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCalleRemitente.Location = New System.Drawing.Point(201, 156)
        Me.txtCalleRemitente.Name = "txtCalleRemitente"
        Me.txtCalleRemitente.Size = New System.Drawing.Size(706, 26)
        Me.txtCalleRemitente.TabIndex = 21
        '
        'txtNoExtRemitente
        '
        Me.txtNoExtRemitente.BackColor = System.Drawing.Color.White
        Me.txtNoExtRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoExtRemitente.Location = New System.Drawing.Point(557, 113)
        Me.txtNoExtRemitente.Name = "txtNoExtRemitente"
        Me.txtNoExtRemitente.Size = New System.Drawing.Size(172, 26)
        Me.txtNoExtRemitente.TabIndex = 19
        '
        'txtNoIntRemitente
        '
        Me.txtNoIntRemitente.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoIntRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoIntRemitente.Location = New System.Drawing.Point(913, 113)
        Me.txtNoIntRemitente.Name = "txtNoIntRemitente"
        Me.txtNoIntRemitente.Size = New System.Drawing.Size(175, 26)
        Me.txtNoIntRemitente.TabIndex = 20
        '
        'txtCpRemitente
        '
        Me.txtCpRemitente.BackColor = System.Drawing.Color.White
        Me.txtCpRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCpRemitente.Location = New System.Drawing.Point(913, 70)
        Me.txtCpRemitente.Name = "txtCpRemitente"
        Me.txtCpRemitente.Size = New System.Drawing.Size(175, 26)
        Me.txtCpRemitente.TabIndex = 17
        '
        'cbPaisRemitente
        '
        Me.cbPaisRemitente.BackColor = System.Drawing.Color.White
        Me.cbPaisRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPaisRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaisRemitente.FormattingEnabled = True
        Me.cbPaisRemitente.Location = New System.Drawing.Point(201, 27)
        Me.cbPaisRemitente.Name = "cbPaisRemitente"
        Me.cbPaisRemitente.Size = New System.Drawing.Size(172, 28)
        Me.cbPaisRemitente.TabIndex = 13
        '
        'cbEstadoRemitente
        '
        Me.cbEstadoRemitente.BackColor = System.Drawing.Color.White
        Me.cbEstadoRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbEstadoRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoRemitente.FormattingEnabled = True
        Me.cbEstadoRemitente.Location = New System.Drawing.Point(557, 27)
        Me.cbEstadoRemitente.Name = "cbEstadoRemitente"
        Me.cbEstadoRemitente.Size = New System.Drawing.Size(172, 28)
        Me.cbEstadoRemitente.TabIndex = 14
        '
        'cbMunicipioRemitente
        '
        Me.cbMunicipioRemitente.BackColor = System.Drawing.Color.White
        Me.cbMunicipioRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbMunicipioRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMunicipioRemitente.FormattingEnabled = True
        Me.cbMunicipioRemitente.Location = New System.Drawing.Point(913, 27)
        Me.cbMunicipioRemitente.Name = "cbMunicipioRemitente"
        Me.cbMunicipioRemitente.Size = New System.Drawing.Size(175, 28)
        Me.cbMunicipioRemitente.TabIndex = 15
        '
        'cbLocalidadRemitente
        '
        Me.cbLocalidadRemitente.BackColor = System.Drawing.Color.White
        Me.tlpDetalleDomicilioOrigen.SetColumnSpan(Me.cbLocalidadRemitente, 2)
        Me.cbLocalidadRemitente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbLocalidadRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLocalidadRemitente.FormattingEnabled = True
        Me.cbLocalidadRemitente.Location = New System.Drawing.Point(201, 70)
        Me.cbLocalidadRemitente.Name = "cbLocalidadRemitente"
        Me.cbLocalidadRemitente.Size = New System.Drawing.Size(350, 28)
        Me.cbLocalidadRemitente.TabIndex = 16
        '
        'cbColoniaOrigen
        '
        Me.cbColoniaOrigen.BackColor = System.Drawing.Color.White
        Me.cbColoniaOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbColoniaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColoniaOrigen.FormattingEnabled = True
        Me.cbColoniaOrigen.Location = New System.Drawing.Point(201, 113)
        Me.cbColoniaOrigen.Name = "cbColoniaOrigen"
        Me.cbColoniaOrigen.Size = New System.Drawing.Size(172, 28)
        Me.cbColoniaOrigen.TabIndex = 18
        '
        'btnSiguienteOrigen
        '
        Me.btnSiguienteOrigen.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSiguienteOrigen.Location = New System.Drawing.Point(933, 559)
        Me.btnSiguienteOrigen.Name = "btnSiguienteOrigen"
        Me.btnSiguienteOrigen.Size = New System.Drawing.Size(161, 56)
        Me.btnSiguienteOrigen.TabIndex = 23
        Me.btnSiguienteOrigen.Text = "Siguiente"
        Me.btnSiguienteOrigen.UseVisualStyleBackColor = True
        '
        'tabDestino
        '
        Me.tabDestino.Controls.Add(Me.TableLayoutPanel1)
        Me.tabDestino.Location = New System.Drawing.Point(4, 29)
        Me.tabDestino.Name = "tabDestino"
        Me.tabDestino.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDestino.Size = New System.Drawing.Size(1103, 624)
        Me.tabDestino.TabIndex = 1
        Me.tabDestino.Text = "Destino"
        Me.tabDestino.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tlpDatosDestino, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpDetallesDestino, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpBotonesSiguienteAtrasDestino, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1097, 618)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'tlpDatosDestino
        '
        Me.tlpDatosDestino.ColumnCount = 4
        Me.tlpDatosDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatosDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatosDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatosDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatosDestino.Controls.Add(Me.Label23, 0, 0)
        Me.tlpDatosDestino.Controls.Add(Me.Label24, 0, 1)
        Me.tlpDatosDestino.Controls.Add(Me.Label25, 2, 1)
        Me.tlpDatosDestino.Controls.Add(Me.Label26, 2, 2)
        Me.tlpDatosDestino.Controls.Add(Me.GroupBox1, 0, 2)
        Me.tlpDatosDestino.Controls.Add(Me.Label27, 0, 3)
        Me.tlpDatosDestino.Controls.Add(Me.Label28, 2, 3)
        Me.tlpDatosDestino.Controls.Add(Me.Label29, 0, 4)
        Me.tlpDatosDestino.Controls.Add(Me.Label30, 0, 5)
        Me.tlpDatosDestino.Controls.Add(Me.Label31, 0, 6)
        Me.tlpDatosDestino.Controls.Add(Me.Label32, 0, 7)
        Me.tlpDatosDestino.Controls.Add(Me.txtTipoUbicacionDestino, 1, 1)
        Me.tlpDatosDestino.Controls.Add(Me.txtIdUbicacionDestino, 3, 1)
        Me.tlpDatosDestino.Controls.Add(Me.txtRfcDestino, 3, 2)
        Me.tlpDatosDestino.Controls.Add(Me.txtNombreDestino, 1, 3)
        Me.tlpDatosDestino.Controls.Add(Me.txtApMaternoDestino, 1, 4)
        Me.tlpDatosDestino.Controls.Add(Me.txtApPaternoDestino, 3, 3)
        Me.tlpDatosDestino.Controls.Add(Me.txtNumIdRegFiscalDestino, 2, 5)
        Me.tlpDatosDestino.Controls.Add(Me.txtResidenciaFiscalDestino, 2, 6)
        Me.tlpDatosDestino.Controls.Add(Me.dtFechaSalidaDestino, 1, 7)
        Me.tlpDatosDestino.Controls.Add(Me.cbResidenciaFiscalDestino, 1, 6)
        Me.tlpDatosDestino.Controls.Add(Me.tlpHoraLlegadaDestino, 2, 7)
        Me.tlpDatosDestino.Controls.Add(Me.tlpNumKilometros, 3, 7)
        Me.tlpDatosDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDatosDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpDatosDestino.Location = New System.Drawing.Point(3, 3)
        Me.tlpDatosDestino.Name = "tlpDatosDestino"
        Me.tlpDatosDestino.RowCount = 8
        Me.tlpDatosDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.26761!))
        Me.tlpDatosDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpDatosDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpDatosDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpDatosDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpDatosDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpDatosDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpDatosDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.tlpDatosDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDatosDestino.Size = New System.Drawing.Size(1091, 303)
        Me.tlpDatosDestino.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(251, 20)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Datos de la ubicación destino:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.IndianRed
        Me.Label24.Location = New System.Drawing.Point(3, 34)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(141, 20)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Tipo ubicación: *"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.IndianRed
        Me.Label25.Location = New System.Drawing.Point(547, 34)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(129, 20)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "ID Ubicación: *"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.IndianRed
        Me.Label26.Location = New System.Drawing.Point(547, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(143, 20)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "RFC remitente: *"
        '
        'GroupBox1
        '
        Me.tlpDatosDestino.SetColumnSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Controls.Add(Me.rbEsExtranjeroDestino)
        Me.GroupBox1.Controls.Add(Me.rbPersonaMoralDestino)
        Me.GroupBox1.Controls.Add(Me.rbPersonaFisicaDestino)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 32)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'rbEsExtranjeroDestino
        '
        Me.rbEsExtranjeroDestino.AutoSize = True
        Me.rbEsExtranjeroDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEsExtranjeroDestino.Location = New System.Drawing.Point(345, 2)
        Me.rbEsExtranjeroDestino.Name = "rbEsExtranjeroDestino"
        Me.rbEsExtranjeroDestino.Size = New System.Drawing.Size(140, 24)
        Me.rbEsExtranjeroDestino.TabIndex = 4
        Me.rbEsExtranjeroDestino.TabStop = True
        Me.rbEsExtranjeroDestino.Text = "Es extranjero"
        Me.rbEsExtranjeroDestino.UseVisualStyleBackColor = True
        '
        'rbPersonaMoralDestino
        '
        Me.rbPersonaMoralDestino.AutoSize = True
        Me.rbPersonaMoralDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPersonaMoralDestino.Location = New System.Drawing.Point(169, 0)
        Me.rbPersonaMoralDestino.Name = "rbPersonaMoralDestino"
        Me.rbPersonaMoralDestino.Size = New System.Drawing.Size(149, 24)
        Me.rbPersonaMoralDestino.TabIndex = 3
        Me.rbPersonaMoralDestino.TabStop = True
        Me.rbPersonaMoralDestino.Text = "Persona moral"
        Me.rbPersonaMoralDestino.UseVisualStyleBackColor = True
        '
        'rbPersonaFisicaDestino
        '
        Me.rbPersonaFisicaDestino.AutoSize = True
        Me.rbPersonaFisicaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPersonaFisicaDestino.Location = New System.Drawing.Point(0, -3)
        Me.rbPersonaFisicaDestino.Name = "rbPersonaFisicaDestino"
        Me.rbPersonaFisicaDestino.Size = New System.Drawing.Size(147, 24)
        Me.rbPersonaFisicaDestino.TabIndex = 2
        Me.rbPersonaFisicaDestino.TabStop = True
        Me.rbPersonaFisicaDestino.Text = "Persona física"
        Me.rbPersonaFisicaDestino.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.IndianRed
        Me.Label27.Location = New System.Drawing.Point(3, 110)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 20)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Nombre: *"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.IndianRed
        Me.Label28.Location = New System.Drawing.Point(547, 110)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(157, 20)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "Apellido paterno: *"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.IndianRed
        Me.Label29.Location = New System.Drawing.Point(3, 148)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(161, 20)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Apellido materno: *"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.tlpDatosDestino.SetColumnSpan(Me.Label30, 2)
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(3, 186)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(538, 38)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Número de identificación o registro fiscal:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(3, 224)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(150, 20)
        Me.Label31.TabIndex = 9
        Me.Label31.Text = "Residencia fiscal:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.IndianRed
        Me.Label32.Location = New System.Drawing.Point(3, 262)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(164, 20)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Fecha de llegada: *"
        '
        'txtTipoUbicacionDestino
        '
        Me.txtTipoUbicacionDestino.BackColor = System.Drawing.Color.White
        Me.txtTipoUbicacionDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoUbicacionDestino.Location = New System.Drawing.Point(275, 37)
        Me.txtTipoUbicacionDestino.Name = "txtTipoUbicacionDestino"
        Me.txtTipoUbicacionDestino.Size = New System.Drawing.Size(266, 26)
        Me.txtTipoUbicacionDestino.TabIndex = 0
        '
        'txtIdUbicacionDestino
        '
        Me.txtIdUbicacionDestino.BackColor = System.Drawing.Color.White
        Me.txtIdUbicacionDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIdUbicacionDestino.Location = New System.Drawing.Point(819, 37)
        Me.txtIdUbicacionDestino.Name = "txtIdUbicacionDestino"
        Me.txtIdUbicacionDestino.Size = New System.Drawing.Size(269, 26)
        Me.txtIdUbicacionDestino.TabIndex = 1
        '
        'txtRfcDestino
        '
        Me.txtRfcDestino.BackColor = System.Drawing.Color.White
        Me.txtRfcDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRfcDestino.Location = New System.Drawing.Point(819, 75)
        Me.txtRfcDestino.Name = "txtRfcDestino"
        Me.txtRfcDestino.Size = New System.Drawing.Size(269, 26)
        Me.txtRfcDestino.TabIndex = 5
        '
        'txtNombreDestino
        '
        Me.txtNombreDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombreDestino.Location = New System.Drawing.Point(275, 113)
        Me.txtNombreDestino.Name = "txtNombreDestino"
        Me.txtNombreDestino.Size = New System.Drawing.Size(266, 26)
        Me.txtNombreDestino.TabIndex = 6
        '
        'txtApMaternoDestino
        '
        Me.txtApMaternoDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApMaternoDestino.Location = New System.Drawing.Point(275, 151)
        Me.txtApMaternoDestino.Name = "txtApMaternoDestino"
        Me.txtApMaternoDestino.Size = New System.Drawing.Size(266, 26)
        Me.txtApMaternoDestino.TabIndex = 8
        '
        'txtApPaternoDestino
        '
        Me.txtApPaternoDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApPaternoDestino.Location = New System.Drawing.Point(819, 113)
        Me.txtApPaternoDestino.Name = "txtApPaternoDestino"
        Me.txtApPaternoDestino.Size = New System.Drawing.Size(269, 26)
        Me.txtApPaternoDestino.TabIndex = 7
        '
        'txtNumIdRegFiscalDestino
        '
        Me.tlpDatosDestino.SetColumnSpan(Me.txtNumIdRegFiscalDestino, 2)
        Me.txtNumIdRegFiscalDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumIdRegFiscalDestino.Location = New System.Drawing.Point(547, 189)
        Me.txtNumIdRegFiscalDestino.Name = "txtNumIdRegFiscalDestino"
        Me.txtNumIdRegFiscalDestino.Size = New System.Drawing.Size(541, 26)
        Me.txtNumIdRegFiscalDestino.TabIndex = 9
        '
        'txtResidenciaFiscalDestino
        '
        Me.tlpDatosDestino.SetColumnSpan(Me.txtResidenciaFiscalDestino, 2)
        Me.txtResidenciaFiscalDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResidenciaFiscalDestino.Location = New System.Drawing.Point(547, 227)
        Me.txtResidenciaFiscalDestino.Name = "txtResidenciaFiscalDestino"
        Me.txtResidenciaFiscalDestino.Size = New System.Drawing.Size(541, 26)
        Me.txtResidenciaFiscalDestino.TabIndex = 19
        Me.txtResidenciaFiscalDestino.TabStop = False
        '
        'dtFechaSalidaDestino
        '
        Me.dtFechaSalidaDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtFechaSalidaDestino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaSalidaDestino.Location = New System.Drawing.Point(275, 265)
        Me.dtFechaSalidaDestino.Name = "dtFechaSalidaDestino"
        Me.dtFechaSalidaDestino.Size = New System.Drawing.Size(266, 26)
        Me.dtFechaSalidaDestino.TabIndex = 11
        '
        'cbResidenciaFiscalDestino
        '
        Me.cbResidenciaFiscalDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbResidenciaFiscalDestino.FormattingEnabled = True
        Me.cbResidenciaFiscalDestino.Location = New System.Drawing.Point(275, 227)
        Me.cbResidenciaFiscalDestino.Name = "cbResidenciaFiscalDestino"
        Me.cbResidenciaFiscalDestino.Size = New System.Drawing.Size(266, 28)
        Me.cbResidenciaFiscalDestino.TabIndex = 10
        '
        'tlpHoraLlegadaDestino
        '
        Me.tlpHoraLlegadaDestino.ColumnCount = 2
        Me.tlpHoraLlegadaDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHoraLlegadaDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHoraLlegadaDestino.Controls.Add(Me.txtHoraSalidaDestino, 1, 0)
        Me.tlpHoraLlegadaDestino.Controls.Add(Me.Label5, 0, 0)
        Me.tlpHoraLlegadaDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpHoraLlegadaDestino.Location = New System.Drawing.Point(547, 265)
        Me.tlpHoraLlegadaDestino.Name = "tlpHoraLlegadaDestino"
        Me.tlpHoraLlegadaDestino.RowCount = 1
        Me.tlpHoraLlegadaDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHoraLlegadaDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpHoraLlegadaDestino.Size = New System.Drawing.Size(266, 35)
        Me.tlpHoraLlegadaDestino.TabIndex = 23
        '
        'txtHoraSalidaDestino
        '
        Me.txtHoraSalidaDestino.BackColor = System.Drawing.Color.White
        Me.txtHoraSalidaDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHoraSalidaDestino.Location = New System.Drawing.Point(136, 3)
        Me.txtHoraSalidaDestino.Name = "txtHoraSalidaDestino"
        Me.txtHoraSalidaDestino.Size = New System.Drawing.Size(127, 26)
        Me.txtHoraSalidaDestino.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.IndianRed
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 35)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Hora arribo: *"
        '
        'tlpNumKilometros
        '
        Me.tlpNumKilometros.ColumnCount = 2
        Me.tlpNumKilometros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNumKilometros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNumKilometros.Controls.Add(Me.Label6, 0, 0)
        Me.tlpNumKilometros.Controls.Add(Me.nupKmRecorridos, 1, 0)
        Me.tlpNumKilometros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNumKilometros.Location = New System.Drawing.Point(819, 265)
        Me.tlpNumKilometros.Name = "tlpNumKilometros"
        Me.tlpNumKilometros.RowCount = 1
        Me.tlpNumKilometros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNumKilometros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpNumKilometros.Size = New System.Drawing.Size(269, 35)
        Me.tlpNumKilometros.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.IndianRed
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Km distancia *"
        '
        'nupKmRecorridos
        '
        Me.nupKmRecorridos.BackColor = System.Drawing.Color.White
        Me.nupKmRecorridos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nupKmRecorridos.Location = New System.Drawing.Point(137, 3)
        Me.nupKmRecorridos.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupKmRecorridos.Name = "nupKmRecorridos"
        Me.nupKmRecorridos.Size = New System.Drawing.Size(129, 26)
        Me.nupKmRecorridos.TabIndex = 13
        '
        'tlpDetallesDestino
        '
        Me.tlpDetallesDestino.ColumnCount = 6
        Me.tlpDetallesDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.tlpDetallesDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestino.Controls.Add(Me.Label34, 0, 0)
        Me.tlpDetallesDestino.Controls.Add(Me.Label35, 0, 1)
        Me.tlpDetallesDestino.Controls.Add(Me.Label36, 2, 1)
        Me.tlpDetallesDestino.Controls.Add(Me.Label37, 4, 1)
        Me.tlpDetallesDestino.Controls.Add(Me.Label38, 0, 2)
        Me.tlpDetallesDestino.Controls.Add(Me.Label39, 4, 2)
        Me.tlpDetallesDestino.Controls.Add(Me.Label40, 0, 3)
        Me.tlpDetallesDestino.Controls.Add(Me.Label41, 2, 3)
        Me.tlpDetallesDestino.Controls.Add(Me.Label42, 4, 3)
        Me.tlpDetallesDestino.Controls.Add(Me.Label43, 0, 4)
        Me.tlpDetallesDestino.Controls.Add(Me.Label44, 0, 5)
        Me.tlpDetallesDestino.Controls.Add(Me.txtReferenciaDestino, 1, 5)
        Me.tlpDetallesDestino.Controls.Add(Me.txtCalleDestino, 1, 4)
        Me.tlpDetallesDestino.Controls.Add(Me.txtNoExtDestino, 3, 3)
        Me.tlpDetallesDestino.Controls.Add(Me.txtNoIntDestino, 5, 3)
        Me.tlpDetallesDestino.Controls.Add(Me.txtCpDestino, 5, 2)
        Me.tlpDetallesDestino.Controls.Add(Me.cbPaisDestino, 1, 1)
        Me.tlpDetallesDestino.Controls.Add(Me.cbEstadoDestino, 3, 1)
        Me.tlpDetallesDestino.Controls.Add(Me.cbMunicipioDestino, 5, 1)
        Me.tlpDetallesDestino.Controls.Add(Me.cbLocalidadDestino, 1, 2)
        Me.tlpDetallesDestino.Controls.Add(Me.cbColoniaDestino, 1, 3)
        Me.tlpDetallesDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDetallesDestino.Location = New System.Drawing.Point(3, 312)
        Me.tlpDetallesDestino.Name = "tlpDetallesDestino"
        Me.tlpDetallesDestino.RowCount = 6
        Me.tlpDetallesDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestino.Size = New System.Drawing.Size(1091, 241)
        Me.tlpDetallesDestino.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.tlpDetallesDestino.SetColumnSpan(Me.Label34, 3)
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(3, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(548, 24)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Detalles de la ubicación destino:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.IndianRed
        Me.Label35.Location = New System.Drawing.Point(3, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(60, 20)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "País: *"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.IndianRed
        Me.Label36.Location = New System.Drawing.Point(379, 24)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(83, 20)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Estado: *"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.IndianRed
        Me.Label37.Location = New System.Drawing.Point(735, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(101, 20)
        Me.Label37.TabIndex = 3
        Me.Label37.Text = "Municipio: *"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.IndianRed
        Me.Label38.Location = New System.Drawing.Point(3, 67)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(103, 20)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "Localidad: *"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.IndianRed
        Me.Label39.Location = New System.Drawing.Point(735, 67)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(49, 20)
        Me.Label39.TabIndex = 5
        Me.Label39.Text = "CP: *"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.IndianRed
        Me.Label40.Location = New System.Drawing.Point(3, 110)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(86, 20)
        Me.Label40.TabIndex = 6
        Me.Label40.Text = "Colonia: *"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.IndianRed
        Me.Label41.Location = New System.Drawing.Point(379, 110)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(82, 20)
        Me.Label41.TabIndex = 7
        Me.Label41.Text = "No. ext: *"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(735, 110)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(66, 20)
        Me.Label42.TabIndex = 8
        Me.Label42.Text = "No. int:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.IndianRed
        Me.Label43.Location = New System.Drawing.Point(3, 153)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(66, 20)
        Me.Label43.TabIndex = 9
        Me.Label43.Text = "Calle: *"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(3, 196)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(102, 20)
        Me.Label44.TabIndex = 10
        Me.Label44.Text = "Referencia:"
        '
        'txtReferenciaDestino
        '
        Me.tlpDetallesDestino.SetColumnSpan(Me.txtReferenciaDestino, 5)
        Me.txtReferenciaDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReferenciaDestino.Location = New System.Drawing.Point(201, 199)
        Me.txtReferenciaDestino.Name = "txtReferenciaDestino"
        Me.txtReferenciaDestino.Size = New System.Drawing.Size(887, 26)
        Me.txtReferenciaDestino.TabIndex = 25
        '
        'txtCalleDestino
        '
        Me.txtCalleDestino.BackColor = System.Drawing.Color.White
        Me.tlpDetallesDestino.SetColumnSpan(Me.txtCalleDestino, 4)
        Me.txtCalleDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCalleDestino.Location = New System.Drawing.Point(201, 156)
        Me.txtCalleDestino.Name = "txtCalleDestino"
        Me.txtCalleDestino.Size = New System.Drawing.Size(706, 26)
        Me.txtCalleDestino.TabIndex = 24
        '
        'txtNoExtDestino
        '
        Me.txtNoExtDestino.BackColor = System.Drawing.Color.White
        Me.txtNoExtDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoExtDestino.Location = New System.Drawing.Point(557, 113)
        Me.txtNoExtDestino.Name = "txtNoExtDestino"
        Me.txtNoExtDestino.Size = New System.Drawing.Size(172, 26)
        Me.txtNoExtDestino.TabIndex = 22
        '
        'txtNoIntDestino
        '
        Me.txtNoIntDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoIntDestino.Location = New System.Drawing.Point(913, 113)
        Me.txtNoIntDestino.Name = "txtNoIntDestino"
        Me.txtNoIntDestino.Size = New System.Drawing.Size(175, 26)
        Me.txtNoIntDestino.TabIndex = 23
        '
        'txtCpDestino
        '
        Me.txtCpDestino.BackColor = System.Drawing.Color.White
        Me.txtCpDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCpDestino.Location = New System.Drawing.Point(913, 70)
        Me.txtCpDestino.Name = "txtCpDestino"
        Me.txtCpDestino.Size = New System.Drawing.Size(175, 26)
        Me.txtCpDestino.TabIndex = 20
        '
        'cbPaisDestino
        '
        Me.cbPaisDestino.BackColor = System.Drawing.SystemColors.Info
        Me.cbPaisDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPaisDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaisDestino.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbPaisDestino.FormattingEnabled = True
        Me.cbPaisDestino.Location = New System.Drawing.Point(201, 27)
        Me.cbPaisDestino.Name = "cbPaisDestino"
        Me.cbPaisDestino.Size = New System.Drawing.Size(172, 28)
        Me.cbPaisDestino.TabIndex = 14
        '
        'cbEstadoDestino
        '
        Me.cbEstadoDestino.BackColor = System.Drawing.SystemColors.Info
        Me.cbEstadoDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbEstadoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoDestino.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbEstadoDestino.FormattingEnabled = True
        Me.cbEstadoDestino.Location = New System.Drawing.Point(557, 27)
        Me.cbEstadoDestino.Name = "cbEstadoDestino"
        Me.cbEstadoDestino.Size = New System.Drawing.Size(172, 28)
        Me.cbEstadoDestino.TabIndex = 15
        '
        'cbMunicipioDestino
        '
        Me.cbMunicipioDestino.BackColor = System.Drawing.SystemColors.Info
        Me.cbMunicipioDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbMunicipioDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMunicipioDestino.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbMunicipioDestino.FormattingEnabled = True
        Me.cbMunicipioDestino.Location = New System.Drawing.Point(913, 27)
        Me.cbMunicipioDestino.Name = "cbMunicipioDestino"
        Me.cbMunicipioDestino.Size = New System.Drawing.Size(175, 28)
        Me.cbMunicipioDestino.TabIndex = 16
        '
        'cbLocalidadDestino
        '
        Me.cbLocalidadDestino.BackColor = System.Drawing.SystemColors.Info
        Me.tlpDetallesDestino.SetColumnSpan(Me.cbLocalidadDestino, 2)
        Me.cbLocalidadDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbLocalidadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLocalidadDestino.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbLocalidadDestino.FormattingEnabled = True
        Me.cbLocalidadDestino.Location = New System.Drawing.Point(201, 70)
        Me.cbLocalidadDestino.Name = "cbLocalidadDestino"
        Me.cbLocalidadDestino.Size = New System.Drawing.Size(350, 28)
        Me.cbLocalidadDestino.TabIndex = 19
        '
        'cbColoniaDestino
        '
        Me.cbColoniaDestino.BackColor = System.Drawing.SystemColors.Info
        Me.cbColoniaDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbColoniaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColoniaDestino.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbColoniaDestino.FormattingEnabled = True
        Me.cbColoniaDestino.Location = New System.Drawing.Point(201, 113)
        Me.cbColoniaDestino.Name = "cbColoniaDestino"
        Me.cbColoniaDestino.Size = New System.Drawing.Size(172, 28)
        Me.cbColoniaDestino.TabIndex = 21
        '
        'tlpBotonesSiguienteAtrasDestino
        '
        Me.tlpBotonesSiguienteAtrasDestino.ColumnCount = 3
        Me.tlpBotonesSiguienteAtrasDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpBotonesSiguienteAtrasDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotonesSiguienteAtrasDestino.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotonesSiguienteAtrasDestino.Controls.Add(Me.btnAtrasDestino, 1, 0)
        Me.tlpBotonesSiguienteAtrasDestino.Controls.Add(Me.btnSiguienteDestino, 2, 0)
        Me.tlpBotonesSiguienteAtrasDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotonesSiguienteAtrasDestino.Location = New System.Drawing.Point(3, 559)
        Me.tlpBotonesSiguienteAtrasDestino.Name = "tlpBotonesSiguienteAtrasDestino"
        Me.tlpBotonesSiguienteAtrasDestino.RowCount = 1
        Me.tlpBotonesSiguienteAtrasDestino.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBotonesSiguienteAtrasDestino.Size = New System.Drawing.Size(1091, 56)
        Me.tlpBotonesSiguienteAtrasDestino.TabIndex = 2
        '
        'btnAtrasDestino
        '
        Me.btnAtrasDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtrasDestino.Location = New System.Drawing.Point(657, 3)
        Me.btnAtrasDestino.Name = "btnAtrasDestino"
        Me.btnAtrasDestino.Size = New System.Drawing.Size(212, 50)
        Me.btnAtrasDestino.TabIndex = 26
        Me.btnAtrasDestino.Text = "Atrás"
        Me.btnAtrasDestino.UseVisualStyleBackColor = True
        '
        'btnSiguienteDestino
        '
        Me.btnSiguienteDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSiguienteDestino.Location = New System.Drawing.Point(875, 3)
        Me.btnSiguienteDestino.Name = "btnSiguienteDestino"
        Me.btnSiguienteDestino.Size = New System.Drawing.Size(213, 50)
        Me.btnSiguienteDestino.TabIndex = 27
        Me.btnSiguienteDestino.Text = "Siguiente"
        Me.btnSiguienteDestino.UseVisualStyleBackColor = True
        '
        'tabDestinosIntermedios
        '
        Me.tabDestinosIntermedios.Controls.Add(Me.tlpMainDestinosIntermedios)
        Me.tabDestinosIntermedios.Location = New System.Drawing.Point(4, 29)
        Me.tabDestinosIntermedios.Name = "tabDestinosIntermedios"
        Me.tabDestinosIntermedios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDestinosIntermedios.Size = New System.Drawing.Size(1103, 624)
        Me.tabDestinosIntermedios.TabIndex = 2
        Me.tabDestinosIntermedios.Text = "Destinos intermedios"
        Me.tabDestinosIntermedios.UseVisualStyleBackColor = True
        '
        'tlpMainDestinosIntermedios
        '
        Me.tlpMainDestinosIntermedios.ColumnCount = 1
        Me.tlpMainDestinosIntermedios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMainDestinosIntermedios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMainDestinosIntermedios.Controls.Add(Me.tlpDetallesDestinoIntermedio, 0, 2)
        Me.tlpMainDestinosIntermedios.Controls.Add(Me.tlpDatosFiscalesDestinoIntermedio, 0, 1)
        Me.tlpMainDestinosIntermedios.Controls.Add(Me.tlpGridDestinosIntermedios, 0, 0)
        Me.tlpMainDestinosIntermedios.Controls.Add(Me.tlpBotonesSiguienteAtrasDestinosIntermedios, 0, 3)
        Me.tlpMainDestinosIntermedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMainDestinosIntermedios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpMainDestinosIntermedios.Location = New System.Drawing.Point(3, 3)
        Me.tlpMainDestinosIntermedios.Name = "tlpMainDestinosIntermedios"
        Me.tlpMainDestinosIntermedios.RowCount = 4
        Me.tlpMainDestinosIntermedios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMainDestinosIntermedios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpMainDestinosIntermedios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpMainDestinosIntermedios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMainDestinosIntermedios.Size = New System.Drawing.Size(1097, 618)
        Me.tlpMainDestinosIntermedios.TabIndex = 0
        '
        'tlpDetallesDestinoIntermedio
        '
        Me.tlpDetallesDestinoIntermedio.ColumnCount = 6
        Me.tlpDetallesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.tlpDetallesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364!))
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label57, 0, 0)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label58, 0, 1)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label59, 2, 1)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label60, 4, 1)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label61, 0, 2)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label62, 4, 2)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label63, 0, 3)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label64, 2, 3)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label65, 4, 3)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label66, 0, 4)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.Label67, 0, 5)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.txtReferenciaDestinoIntermedio, 1, 5)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.txtCalleDestinoIntermedio, 1, 4)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.txtNoExtDestinoIntermedio, 3, 3)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.txtNoIntDestinoIntermedio, 5, 3)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.txtCpDestinoIntermedio, 5, 2)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.cbPaisDestinoIntermedio, 1, 1)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.cbEstadoDestinoIntermedio, 3, 1)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.cbMunicipioDestinoIntermedio, 5, 1)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.cbLocalidadDestinoIntermedio, 1, 2)
        Me.tlpDetallesDestinoIntermedio.Controls.Add(Me.cbColoniaDestinoIntermedio, 1, 3)
        Me.tlpDetallesDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDetallesDestinoIntermedio.ForeColor = System.Drawing.Color.IndianRed
        Me.tlpDetallesDestinoIntermedio.Location = New System.Drawing.Point(3, 373)
        Me.tlpDetallesDestinoIntermedio.Name = "tlpDetallesDestinoIntermedio"
        Me.tlpDetallesDestinoIntermedio.RowCount = 6
        Me.tlpDetallesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesDestinoIntermedio.Size = New System.Drawing.Size(1091, 179)
        Me.tlpDetallesDestinoIntermedio.TabIndex = 2
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.tlpDetallesDestinoIntermedio.SetColumnSpan(Me.Label57, 3)
        Me.Label57.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(3, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(548, 17)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Detalles de la ubicación destino:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.IndianRed
        Me.Label58.Location = New System.Drawing.Point(3, 17)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(60, 20)
        Me.Label58.TabIndex = 1
        Me.Label58.Text = "País: *"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.IndianRed
        Me.Label59.Location = New System.Drawing.Point(379, 17)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(83, 20)
        Me.Label59.TabIndex = 2
        Me.Label59.Text = "Estado: *"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.IndianRed
        Me.Label60.Location = New System.Drawing.Point(735, 17)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(101, 20)
        Me.Label60.TabIndex = 3
        Me.Label60.Text = "Municipio: *"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.IndianRed
        Me.Label61.Location = New System.Drawing.Point(3, 49)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(103, 20)
        Me.Label61.TabIndex = 4
        Me.Label61.Text = "Localidad: *"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.IndianRed
        Me.Label62.Location = New System.Drawing.Point(735, 49)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(49, 20)
        Me.Label62.TabIndex = 5
        Me.Label62.Text = "CP: *"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.IndianRed
        Me.Label63.Location = New System.Drawing.Point(3, 81)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(86, 20)
        Me.Label63.TabIndex = 6
        Me.Label63.Text = "Colonia: *"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.IndianRed
        Me.Label64.Location = New System.Drawing.Point(379, 81)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(82, 20)
        Me.Label64.TabIndex = 7
        Me.Label64.Text = "No. ext: *"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label65.Location = New System.Drawing.Point(735, 81)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(66, 20)
        Me.Label65.TabIndex = 8
        Me.Label65.Text = "No. int:"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.IndianRed
        Me.Label66.Location = New System.Drawing.Point(3, 113)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(66, 20)
        Me.Label66.TabIndex = 9
        Me.Label66.Text = "Calle: *"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Location = New System.Drawing.Point(3, 145)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(102, 20)
        Me.Label67.TabIndex = 10
        Me.Label67.Text = "Referencia:"
        '
        'txtReferenciaDestinoIntermedio
        '
        Me.tlpDetallesDestinoIntermedio.SetColumnSpan(Me.txtReferenciaDestinoIntermedio, 5)
        Me.txtReferenciaDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReferenciaDestinoIntermedio.Location = New System.Drawing.Point(201, 148)
        Me.txtReferenciaDestinoIntermedio.Name = "txtReferenciaDestinoIntermedio"
        Me.txtReferenciaDestinoIntermedio.Size = New System.Drawing.Size(887, 26)
        Me.txtReferenciaDestinoIntermedio.TabIndex = 23
        '
        'txtCalleDestinoIntermedio
        '
        Me.txtCalleDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.tlpDetallesDestinoIntermedio.SetColumnSpan(Me.txtCalleDestinoIntermedio, 4)
        Me.txtCalleDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCalleDestinoIntermedio.Location = New System.Drawing.Point(201, 116)
        Me.txtCalleDestinoIntermedio.Name = "txtCalleDestinoIntermedio"
        Me.txtCalleDestinoIntermedio.Size = New System.Drawing.Size(706, 26)
        Me.txtCalleDestinoIntermedio.TabIndex = 22
        '
        'txtNoExtDestinoIntermedio
        '
        Me.txtNoExtDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.txtNoExtDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoExtDestinoIntermedio.Location = New System.Drawing.Point(557, 84)
        Me.txtNoExtDestinoIntermedio.Name = "txtNoExtDestinoIntermedio"
        Me.txtNoExtDestinoIntermedio.Size = New System.Drawing.Size(172, 26)
        Me.txtNoExtDestinoIntermedio.TabIndex = 20
        '
        'txtNoIntDestinoIntermedio
        '
        Me.txtNoIntDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoIntDestinoIntermedio.Location = New System.Drawing.Point(913, 84)
        Me.txtNoIntDestinoIntermedio.Name = "txtNoIntDestinoIntermedio"
        Me.txtNoIntDestinoIntermedio.Size = New System.Drawing.Size(175, 26)
        Me.txtNoIntDestinoIntermedio.TabIndex = 21
        '
        'txtCpDestinoIntermedio
        '
        Me.txtCpDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.txtCpDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCpDestinoIntermedio.Location = New System.Drawing.Point(913, 52)
        Me.txtCpDestinoIntermedio.Name = "txtCpDestinoIntermedio"
        Me.txtCpDestinoIntermedio.Size = New System.Drawing.Size(175, 26)
        Me.txtCpDestinoIntermedio.TabIndex = 18
        '
        'cbPaisDestinoIntermedio
        '
        Me.cbPaisDestinoIntermedio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cbPaisDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPaisDestinoIntermedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaisDestinoIntermedio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbPaisDestinoIntermedio.FormattingEnabled = True
        Me.cbPaisDestinoIntermedio.Location = New System.Drawing.Point(201, 20)
        Me.cbPaisDestinoIntermedio.Name = "cbPaisDestinoIntermedio"
        Me.cbPaisDestinoIntermedio.Size = New System.Drawing.Size(172, 28)
        Me.cbPaisDestinoIntermedio.TabIndex = 14
        '
        'cbEstadoDestinoIntermedio
        '
        Me.cbEstadoDestinoIntermedio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cbEstadoDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbEstadoDestinoIntermedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoDestinoIntermedio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbEstadoDestinoIntermedio.FormattingEnabled = True
        Me.cbEstadoDestinoIntermedio.Location = New System.Drawing.Point(557, 20)
        Me.cbEstadoDestinoIntermedio.Name = "cbEstadoDestinoIntermedio"
        Me.cbEstadoDestinoIntermedio.Size = New System.Drawing.Size(172, 28)
        Me.cbEstadoDestinoIntermedio.TabIndex = 15
        '
        'cbMunicipioDestinoIntermedio
        '
        Me.cbMunicipioDestinoIntermedio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cbMunicipioDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbMunicipioDestinoIntermedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMunicipioDestinoIntermedio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbMunicipioDestinoIntermedio.FormattingEnabled = True
        Me.cbMunicipioDestinoIntermedio.Location = New System.Drawing.Point(913, 20)
        Me.cbMunicipioDestinoIntermedio.Name = "cbMunicipioDestinoIntermedio"
        Me.cbMunicipioDestinoIntermedio.Size = New System.Drawing.Size(175, 28)
        Me.cbMunicipioDestinoIntermedio.TabIndex = 16
        '
        'cbLocalidadDestinoIntermedio
        '
        Me.cbLocalidadDestinoIntermedio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tlpDetallesDestinoIntermedio.SetColumnSpan(Me.cbLocalidadDestinoIntermedio, 2)
        Me.cbLocalidadDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbLocalidadDestinoIntermedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLocalidadDestinoIntermedio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbLocalidadDestinoIntermedio.FormattingEnabled = True
        Me.cbLocalidadDestinoIntermedio.Location = New System.Drawing.Point(201, 52)
        Me.cbLocalidadDestinoIntermedio.Name = "cbLocalidadDestinoIntermedio"
        Me.cbLocalidadDestinoIntermedio.Size = New System.Drawing.Size(350, 28)
        Me.cbLocalidadDestinoIntermedio.TabIndex = 17
        '
        'cbColoniaDestinoIntermedio
        '
        Me.cbColoniaDestinoIntermedio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cbColoniaDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbColoniaDestinoIntermedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColoniaDestinoIntermedio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbColoniaDestinoIntermedio.FormattingEnabled = True
        Me.cbColoniaDestinoIntermedio.Location = New System.Drawing.Point(201, 84)
        Me.cbColoniaDestinoIntermedio.Name = "cbColoniaDestinoIntermedio"
        Me.cbColoniaDestinoIntermedio.Size = New System.Drawing.Size(172, 28)
        Me.cbColoniaDestinoIntermedio.TabIndex = 19
        '
        'tlpDatosFiscalesDestinoIntermedio
        '
        Me.tlpDatosFiscalesDestinoIntermedio.ColumnCount = 4
        Me.tlpDatosFiscalesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label46, 0, 0)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label47, 0, 1)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label48, 2, 1)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label49, 2, 2)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.GroupBox2, 0, 2)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label50, 0, 3)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label51, 2, 3)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label52, 0, 4)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label53, 0, 5)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label54, 0, 6)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.Label55, 0, 7)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.txtTipoUbicacionDestinoIntermedio, 1, 1)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.txtIdUbicacionDestinoIntermedio, 3, 1)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.txtRfcDestinoIntermedio, 3, 2)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.txtNombreDestinoIntermedio, 1, 3)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.txtApMaternoDestinoIntermedio, 1, 4)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.txtApPaternoDestinoIntermedio, 3, 3)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.txtNumregIdTribDestinoIntermedio, 2, 5)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.txtPaisResidenciaFiscalDestinoIntermedio, 2, 6)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.dtFechaLlegadaDestinoIntermedio, 1, 7)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.cbPaisResidenciaFiscalDestinoIntermedio, 1, 6)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.tlpHoraLlegadaDestinoIntermedio, 2, 7)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.tlpKmDestinoIntermedio, 3, 7)
        Me.tlpDatosFiscalesDestinoIntermedio.Controls.Add(Me.lblFechaHoraMaximaDestInter, 0, 8)
        Me.tlpDatosFiscalesDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDatosFiscalesDestinoIntermedio.Location = New System.Drawing.Point(3, 126)
        Me.tlpDatosFiscalesDestinoIntermedio.Name = "tlpDatosFiscalesDestinoIntermedio"
        Me.tlpDatosFiscalesDestinoIntermedio.RowCount = 9
        Me.tlpDatosFiscalesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDatosFiscalesDestinoIntermedio.Size = New System.Drawing.Size(1091, 241)
        Me.tlpDatosFiscalesDestinoIntermedio.TabIndex = 1
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(3, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(251, 20)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Datos de la ubicación destino:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.IndianRed
        Me.Label47.Location = New System.Drawing.Point(3, 26)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(141, 20)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "Tipo ubicación: *"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.IndianRed
        Me.Label48.Location = New System.Drawing.Point(547, 26)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(129, 20)
        Me.Label48.TabIndex = 2
        Me.Label48.Text = "ID Ubicación: *"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.IndianRed
        Me.Label49.Location = New System.Drawing.Point(547, 52)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(143, 20)
        Me.Label49.TabIndex = 3
        Me.Label49.Text = "RFC remitente: *"
        '
        'GroupBox2
        '
        Me.tlpDatosFiscalesDestinoIntermedio.SetColumnSpan(Me.GroupBox2, 2)
        Me.GroupBox2.Controls.Add(Me.rbEsExtranjeroDestinoIntermedio)
        Me.GroupBox2.Controls.Add(Me.rbEsPersonaMoralDestinoIntermedio)
        Me.GroupBox2.Controls.Add(Me.rbEsPersonaFisicaDestinoIntermedio)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 20)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'rbEsExtranjeroDestinoIntermedio
        '
        Me.rbEsExtranjeroDestinoIntermedio.AutoSize = True
        Me.rbEsExtranjeroDestinoIntermedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEsExtranjeroDestinoIntermedio.Location = New System.Drawing.Point(361, 2)
        Me.rbEsExtranjeroDestinoIntermedio.Name = "rbEsExtranjeroDestinoIntermedio"
        Me.rbEsExtranjeroDestinoIntermedio.Size = New System.Drawing.Size(140, 24)
        Me.rbEsExtranjeroDestinoIntermedio.TabIndex = 4
        Me.rbEsExtranjeroDestinoIntermedio.TabStop = True
        Me.rbEsExtranjeroDestinoIntermedio.Text = "Es extranjero"
        Me.rbEsExtranjeroDestinoIntermedio.UseVisualStyleBackColor = True
        '
        'rbEsPersonaMoralDestinoIntermedio
        '
        Me.rbEsPersonaMoralDestinoIntermedio.AutoSize = True
        Me.rbEsPersonaMoralDestinoIntermedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEsPersonaMoralDestinoIntermedio.Location = New System.Drawing.Point(173, 0)
        Me.rbEsPersonaMoralDestinoIntermedio.Name = "rbEsPersonaMoralDestinoIntermedio"
        Me.rbEsPersonaMoralDestinoIntermedio.Size = New System.Drawing.Size(149, 24)
        Me.rbEsPersonaMoralDestinoIntermedio.TabIndex = 3
        Me.rbEsPersonaMoralDestinoIntermedio.TabStop = True
        Me.rbEsPersonaMoralDestinoIntermedio.Text = "Persona moral"
        Me.rbEsPersonaMoralDestinoIntermedio.UseVisualStyleBackColor = True
        '
        'rbEsPersonaFisicaDestinoIntermedio
        '
        Me.rbEsPersonaFisicaDestinoIntermedio.AutoSize = True
        Me.rbEsPersonaFisicaDestinoIntermedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEsPersonaFisicaDestinoIntermedio.Location = New System.Drawing.Point(0, -3)
        Me.rbEsPersonaFisicaDestinoIntermedio.Name = "rbEsPersonaFisicaDestinoIntermedio"
        Me.rbEsPersonaFisicaDestinoIntermedio.Size = New System.Drawing.Size(147, 24)
        Me.rbEsPersonaFisicaDestinoIntermedio.TabIndex = 2
        Me.rbEsPersonaFisicaDestinoIntermedio.TabStop = True
        Me.rbEsPersonaFisicaDestinoIntermedio.Text = "Persona física"
        Me.rbEsPersonaFisicaDestinoIntermedio.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.IndianRed
        Me.Label50.Location = New System.Drawing.Point(3, 78)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(88, 20)
        Me.Label50.TabIndex = 5
        Me.Label50.Text = "Nombre: *"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.IndianRed
        Me.Label51.Location = New System.Drawing.Point(547, 78)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(157, 20)
        Me.Label51.TabIndex = 6
        Me.Label51.Text = "Apellido paterno: *"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.IndianRed
        Me.Label52.Location = New System.Drawing.Point(3, 104)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(161, 20)
        Me.Label52.TabIndex = 7
        Me.Label52.Text = "Apellido materno: *"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.tlpDatosFiscalesDestinoIntermedio.SetColumnSpan(Me.Label53, 2)
        Me.Label53.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(3, 130)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(538, 26)
        Me.Label53.TabIndex = 8
        Me.Label53.Text = "Número de identificación o registro fiscal:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(3, 156)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(150, 20)
        Me.Label54.TabIndex = 9
        Me.Label54.Text = "Residencia fiscal:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.IndianRed
        Me.Label55.Location = New System.Drawing.Point(3, 184)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(164, 20)
        Me.Label55.TabIndex = 10
        Me.Label55.Text = "Fecha de llegada: *"
        '
        'txtTipoUbicacionDestinoIntermedio
        '
        Me.txtTipoUbicacionDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.txtTipoUbicacionDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoUbicacionDestinoIntermedio.Location = New System.Drawing.Point(275, 29)
        Me.txtTipoUbicacionDestinoIntermedio.Name = "txtTipoUbicacionDestinoIntermedio"
        Me.txtTipoUbicacionDestinoIntermedio.Size = New System.Drawing.Size(266, 26)
        Me.txtTipoUbicacionDestinoIntermedio.TabIndex = 0
        '
        'txtIdUbicacionDestinoIntermedio
        '
        Me.txtIdUbicacionDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.txtIdUbicacionDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIdUbicacionDestinoIntermedio.Location = New System.Drawing.Point(819, 29)
        Me.txtIdUbicacionDestinoIntermedio.Name = "txtIdUbicacionDestinoIntermedio"
        Me.txtIdUbicacionDestinoIntermedio.Size = New System.Drawing.Size(269, 26)
        Me.txtIdUbicacionDestinoIntermedio.TabIndex = 1
        '
        'txtRfcDestinoIntermedio
        '
        Me.txtRfcDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.txtRfcDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRfcDestinoIntermedio.Location = New System.Drawing.Point(819, 55)
        Me.txtRfcDestinoIntermedio.Name = "txtRfcDestinoIntermedio"
        Me.txtRfcDestinoIntermedio.Size = New System.Drawing.Size(269, 26)
        Me.txtRfcDestinoIntermedio.TabIndex = 5
        '
        'txtNombreDestinoIntermedio
        '
        Me.txtNombreDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.txtNombreDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombreDestinoIntermedio.Location = New System.Drawing.Point(275, 81)
        Me.txtNombreDestinoIntermedio.Name = "txtNombreDestinoIntermedio"
        Me.txtNombreDestinoIntermedio.Size = New System.Drawing.Size(266, 26)
        Me.txtNombreDestinoIntermedio.TabIndex = 6
        '
        'txtApMaternoDestinoIntermedio
        '
        Me.txtApMaternoDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApMaternoDestinoIntermedio.Location = New System.Drawing.Point(275, 107)
        Me.txtApMaternoDestinoIntermedio.Name = "txtApMaternoDestinoIntermedio"
        Me.txtApMaternoDestinoIntermedio.Size = New System.Drawing.Size(266, 26)
        Me.txtApMaternoDestinoIntermedio.TabIndex = 8
        '
        'txtApPaternoDestinoIntermedio
        '
        Me.txtApPaternoDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApPaternoDestinoIntermedio.Location = New System.Drawing.Point(819, 81)
        Me.txtApPaternoDestinoIntermedio.Name = "txtApPaternoDestinoIntermedio"
        Me.txtApPaternoDestinoIntermedio.Size = New System.Drawing.Size(269, 26)
        Me.txtApPaternoDestinoIntermedio.TabIndex = 7
        '
        'txtNumregIdTribDestinoIntermedio
        '
        Me.tlpDatosFiscalesDestinoIntermedio.SetColumnSpan(Me.txtNumregIdTribDestinoIntermedio, 2)
        Me.txtNumregIdTribDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumregIdTribDestinoIntermedio.Location = New System.Drawing.Point(547, 133)
        Me.txtNumregIdTribDestinoIntermedio.Name = "txtNumregIdTribDestinoIntermedio"
        Me.txtNumregIdTribDestinoIntermedio.Size = New System.Drawing.Size(541, 26)
        Me.txtNumregIdTribDestinoIntermedio.TabIndex = 9
        '
        'txtPaisResidenciaFiscalDestinoIntermedio
        '
        Me.tlpDatosFiscalesDestinoIntermedio.SetColumnSpan(Me.txtPaisResidenciaFiscalDestinoIntermedio, 2)
        Me.txtPaisResidenciaFiscalDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPaisResidenciaFiscalDestinoIntermedio.Location = New System.Drawing.Point(547, 159)
        Me.txtPaisResidenciaFiscalDestinoIntermedio.Name = "txtPaisResidenciaFiscalDestinoIntermedio"
        Me.txtPaisResidenciaFiscalDestinoIntermedio.Size = New System.Drawing.Size(541, 26)
        Me.txtPaisResidenciaFiscalDestinoIntermedio.TabIndex = 19
        '
        'dtFechaLlegadaDestinoIntermedio
        '
        Me.dtFechaLlegadaDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtFechaLlegadaDestinoIntermedio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaLlegadaDestinoIntermedio.Location = New System.Drawing.Point(275, 187)
        Me.dtFechaLlegadaDestinoIntermedio.Name = "dtFechaLlegadaDestinoIntermedio"
        Me.dtFechaLlegadaDestinoIntermedio.Size = New System.Drawing.Size(266, 26)
        Me.dtFechaLlegadaDestinoIntermedio.TabIndex = 11
        '
        'cbPaisResidenciaFiscalDestinoIntermedio
        '
        Me.cbPaisResidenciaFiscalDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPaisResidenciaFiscalDestinoIntermedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaisResidenciaFiscalDestinoIntermedio.FormattingEnabled = True
        Me.cbPaisResidenciaFiscalDestinoIntermedio.Location = New System.Drawing.Point(275, 159)
        Me.cbPaisResidenciaFiscalDestinoIntermedio.Name = "cbPaisResidenciaFiscalDestinoIntermedio"
        Me.cbPaisResidenciaFiscalDestinoIntermedio.Size = New System.Drawing.Size(266, 28)
        Me.cbPaisResidenciaFiscalDestinoIntermedio.TabIndex = 10
        '
        'tlpHoraLlegadaDestinoIntermedio
        '
        Me.tlpHoraLlegadaDestinoIntermedio.ColumnCount = 2
        Me.tlpHoraLlegadaDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHoraLlegadaDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHoraLlegadaDestinoIntermedio.Controls.Add(Me.txtHoraLlegadaDestinoIntermedio, 1, 0)
        Me.tlpHoraLlegadaDestinoIntermedio.Controls.Add(Me.Label33, 0, 0)
        Me.tlpHoraLlegadaDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpHoraLlegadaDestinoIntermedio.Location = New System.Drawing.Point(547, 187)
        Me.tlpHoraLlegadaDestinoIntermedio.Name = "tlpHoraLlegadaDestinoIntermedio"
        Me.tlpHoraLlegadaDestinoIntermedio.RowCount = 1
        Me.tlpHoraLlegadaDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHoraLlegadaDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpHoraLlegadaDestinoIntermedio.Size = New System.Drawing.Size(266, 22)
        Me.tlpHoraLlegadaDestinoIntermedio.TabIndex = 23
        '
        'txtHoraLlegadaDestinoIntermedio
        '
        Me.txtHoraLlegadaDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.txtHoraLlegadaDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHoraLlegadaDestinoIntermedio.Location = New System.Drawing.Point(136, 3)
        Me.txtHoraLlegadaDestinoIntermedio.Name = "txtHoraLlegadaDestinoIntermedio"
        Me.txtHoraLlegadaDestinoIntermedio.Size = New System.Drawing.Size(127, 26)
        Me.txtHoraLlegadaDestinoIntermedio.TabIndex = 12
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.IndianRed
        Me.Label33.Location = New System.Drawing.Point(3, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(127, 22)
        Me.Label33.TabIndex = 22
        Me.Label33.Text = "Hora arribo: *"
        '
        'tlpKmDestinoIntermedio
        '
        Me.tlpKmDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.tlpKmDestinoIntermedio.ColumnCount = 2
        Me.tlpKmDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpKmDestinoIntermedio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpKmDestinoIntermedio.Controls.Add(Me.nupKmDestinoIntermedio, 1, 0)
        Me.tlpKmDestinoIntermedio.Controls.Add(Me.Label7, 0, 0)
        Me.tlpKmDestinoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpKmDestinoIntermedio.Location = New System.Drawing.Point(819, 187)
        Me.tlpKmDestinoIntermedio.Name = "tlpKmDestinoIntermedio"
        Me.tlpKmDestinoIntermedio.RowCount = 1
        Me.tlpKmDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpKmDestinoIntermedio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpKmDestinoIntermedio.Size = New System.Drawing.Size(269, 22)
        Me.tlpKmDestinoIntermedio.TabIndex = 24
        '
        'nupKmDestinoIntermedio
        '
        Me.nupKmDestinoIntermedio.BackColor = System.Drawing.Color.White
        Me.nupKmDestinoIntermedio.Location = New System.Drawing.Point(137, 3)
        Me.nupKmDestinoIntermedio.Name = "nupKmDestinoIntermedio"
        Me.nupKmDestinoIntermedio.Size = New System.Drawing.Size(120, 26)
        Me.nupKmDestinoIntermedio.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.IndianRed
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Km distancia: *"
        '
        'lblFechaHoraMaximaDestInter
        '
        Me.lblFechaHoraMaximaDestInter.AutoSize = True
        Me.lblFechaHoraMaximaDestInter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFechaHoraMaximaDestInter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHoraMaximaDestInter.Location = New System.Drawing.Point(3, 212)
        Me.lblFechaHoraMaximaDestInter.Name = "lblFechaHoraMaximaDestInter"
        Me.lblFechaHoraMaximaDestInter.Size = New System.Drawing.Size(266, 29)
        Me.lblFechaHoraMaximaDestInter.TabIndex = 25
        Me.lblFechaHoraMaximaDestInter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpGridDestinosIntermedios
        '
        Me.tlpGridDestinosIntermedios.ColumnCount = 1
        Me.tlpGridDestinosIntermedios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpGridDestinosIntermedios.Controls.Add(Me.Label45, 0, 0)
        Me.tlpGridDestinosIntermedios.Controls.Add(Me.dgvCartaPorteDestinosIntermedios, 0, 1)
        Me.tlpGridDestinosIntermedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpGridDestinosIntermedios.Location = New System.Drawing.Point(3, 3)
        Me.tlpGridDestinosIntermedios.Name = "tlpGridDestinosIntermedios"
        Me.tlpGridDestinosIntermedios.RowCount = 2
        Me.tlpGridDestinosIntermedios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpGridDestinosIntermedios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpGridDestinosIntermedios.Size = New System.Drawing.Size(1091, 117)
        Me.tlpGridDestinosIntermedios.TabIndex = 0
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(3, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(178, 20)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Destinos intermedios"
        '
        'dgvCartaPorteDestinosIntermedios
        '
        Me.dgvCartaPorteDestinosIntermedios.AllowUserToAddRows = False
        Me.dgvCartaPorteDestinosIntermedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCartaPorteDestinosIntermedios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DIMovimientoClm, Me.DIDestinoClm, Me.DIFechaLlegadaClm, Me.DIHoraLlegadaClm, Me.DIKmClm, Me.DIVerClm, Me.DIEliminarClm, Me.IDUbicacionClm, Me.DIUsuarioProblemasFechaClm, Me.DIUsuarioCausoProblemasConKm})
        Me.dgvCartaPorteDestinosIntermedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCartaPorteDestinosIntermedios.Location = New System.Drawing.Point(3, 26)
        Me.dgvCartaPorteDestinosIntermedios.Name = "dgvCartaPorteDestinosIntermedios"
        Me.dgvCartaPorteDestinosIntermedios.RowHeadersVisible = False
        Me.dgvCartaPorteDestinosIntermedios.RowHeadersWidth = 62
        Me.dgvCartaPorteDestinosIntermedios.RowTemplate.Height = 28
        Me.dgvCartaPorteDestinosIntermedios.Size = New System.Drawing.Size(1085, 88)
        Me.dgvCartaPorteDestinosIntermedios.TabIndex = 1
        Me.dgvCartaPorteDestinosIntermedios.TabStop = False
        '
        'DIMovimientoClm
        '
        Me.DIMovimientoClm.HeaderText = "Movimiento"
        Me.DIMovimientoClm.MinimumWidth = 8
        Me.DIMovimientoClm.Name = "DIMovimientoClm"
        Me.DIMovimientoClm.ReadOnly = True
        Me.DIMovimientoClm.Width = 150
        '
        'DIDestinoClm
        '
        Me.DIDestinoClm.HeaderText = "Destino"
        Me.DIDestinoClm.MinimumWidth = 8
        Me.DIDestinoClm.Name = "DIDestinoClm"
        Me.DIDestinoClm.ReadOnly = True
        Me.DIDestinoClm.Width = 150
        '
        'DIFechaLlegadaClm
        '
        Me.DIFechaLlegadaClm.HeaderText = "FechaLlegada"
        Me.DIFechaLlegadaClm.MinimumWidth = 8
        Me.DIFechaLlegadaClm.Name = "DIFechaLlegadaClm"
        Me.DIFechaLlegadaClm.ReadOnly = True
        Me.DIFechaLlegadaClm.Width = 150
        '
        'DIHoraLlegadaClm
        '
        Me.DIHoraLlegadaClm.HeaderText = "Hora llegada"
        Me.DIHoraLlegadaClm.MinimumWidth = 8
        Me.DIHoraLlegadaClm.Name = "DIHoraLlegadaClm"
        Me.DIHoraLlegadaClm.ReadOnly = True
        Me.DIHoraLlegadaClm.Width = 150
        '
        'DIKmClm
        '
        Me.DIKmClm.HeaderText = "Km"
        Me.DIKmClm.MinimumWidth = 8
        Me.DIKmClm.Name = "DIKmClm"
        Me.DIKmClm.ReadOnly = True
        Me.DIKmClm.Width = 150
        '
        'DIVerClm
        '
        Me.DIVerClm.HeaderText = "Ver"
        Me.DIVerClm.MinimumWidth = 8
        Me.DIVerClm.Name = "DIVerClm"
        Me.DIVerClm.Text = "Ver"
        Me.DIVerClm.ToolTipText = "Ver detalles del movimiento"
        Me.DIVerClm.UseColumnTextForButtonValue = True
        Me.DIVerClm.Width = 150
        '
        'DIEliminarClm
        '
        Me.DIEliminarClm.HeaderText = "Remover"
        Me.DIEliminarClm.MinimumWidth = 8
        Me.DIEliminarClm.Name = "DIEliminarClm"
        Me.DIEliminarClm.Text = "Remover"
        Me.DIEliminarClm.ToolTipText = "Remover movimiento"
        Me.DIEliminarClm.UseColumnTextForButtonValue = True
        Me.DIEliminarClm.Width = 150
        '
        'IDUbicacionClm
        '
        Me.IDUbicacionClm.HeaderText = "IdUbicacion"
        Me.IDUbicacionClm.MinimumWidth = 8
        Me.IDUbicacionClm.Name = "IDUbicacionClm"
        Me.IDUbicacionClm.ReadOnly = True
        Me.IDUbicacionClm.Visible = False
        Me.IDUbicacionClm.Width = 150
        '
        'DIUsuarioProblemasFechaClm
        '
        Me.DIUsuarioProblemasFechaClm.HeaderText = "UsuarioCausoProblemas"
        Me.DIUsuarioProblemasFechaClm.MinimumWidth = 8
        Me.DIUsuarioProblemasFechaClm.Name = "DIUsuarioProblemasFechaClm"
        Me.DIUsuarioProblemasFechaClm.ReadOnly = True
        Me.DIUsuarioProblemasFechaClm.Visible = False
        Me.DIUsuarioProblemasFechaClm.Width = 150
        '
        'DIUsuarioCausoProblemasConKm
        '
        Me.DIUsuarioCausoProblemasConKm.HeaderText = "UsuarioCausoProblemasConKm"
        Me.DIUsuarioCausoProblemasConKm.MinimumWidth = 8
        Me.DIUsuarioCausoProblemasConKm.Name = "DIUsuarioCausoProblemasConKm"
        Me.DIUsuarioCausoProblemasConKm.ReadOnly = True
        Me.DIUsuarioCausoProblemasConKm.Visible = False
        Me.DIUsuarioCausoProblemasConKm.Width = 150
        '
        'tlpBotonesSiguienteAtrasDestinosIntermedios
        '
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.ColumnCount = 6
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.Controls.Add(Me.btnSiguienteDestinosIntermedios, 5, 0)
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.Controls.Add(Me.btnAtrasDestinosIntermedios, 1, 0)
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.Controls.Add(Me.btnReiniciarDestinosIntermedios, 2, 0)
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.Controls.Add(Me.btnGuardarDestinosIntermedios, 4, 0)
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.Controls.Add(Me.btnLimpiarDestinosIntermedios, 3, 0)
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.Location = New System.Drawing.Point(3, 558)
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.Name = "tlpBotonesSiguienteAtrasDestinosIntermedios"
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.RowCount = 1
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.Size = New System.Drawing.Size(1091, 57)
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.TabIndex = 3
        '
        'btnSiguienteDestinosIntermedios
        '
        Me.btnSiguienteDestinosIntermedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSiguienteDestinosIntermedios.Location = New System.Drawing.Point(927, 3)
        Me.btnSiguienteDestinosIntermedios.Name = "btnSiguienteDestinosIntermedios"
        Me.btnSiguienteDestinosIntermedios.Size = New System.Drawing.Size(161, 51)
        Me.btnSiguienteDestinosIntermedios.TabIndex = 28
        Me.btnSiguienteDestinosIntermedios.Text = "Siguiente"
        Me.btnSiguienteDestinosIntermedios.UseVisualStyleBackColor = True
        '
        'btnAtrasDestinosIntermedios
        '
        Me.btnAtrasDestinosIntermedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtrasDestinosIntermedios.Location = New System.Drawing.Point(275, 3)
        Me.btnAtrasDestinosIntermedios.Name = "btnAtrasDestinosIntermedios"
        Me.btnAtrasDestinosIntermedios.Size = New System.Drawing.Size(157, 51)
        Me.btnAtrasDestinosIntermedios.TabIndex = 24
        Me.btnAtrasDestinosIntermedios.Text = "Atrás"
        Me.btnAtrasDestinosIntermedios.UseVisualStyleBackColor = True
        '
        'btnReiniciarDestinosIntermedios
        '
        Me.btnReiniciarDestinosIntermedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReiniciarDestinosIntermedios.Location = New System.Drawing.Point(438, 3)
        Me.btnReiniciarDestinosIntermedios.Name = "btnReiniciarDestinosIntermedios"
        Me.btnReiniciarDestinosIntermedios.Size = New System.Drawing.Size(157, 51)
        Me.btnReiniciarDestinosIntermedios.TabIndex = 25
        Me.btnReiniciarDestinosIntermedios.Text = "Nuevo"
        Me.btnReiniciarDestinosIntermedios.UseVisualStyleBackColor = True
        '
        'btnGuardarDestinosIntermedios
        '
        Me.btnGuardarDestinosIntermedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardarDestinosIntermedios.Location = New System.Drawing.Point(764, 3)
        Me.btnGuardarDestinosIntermedios.Name = "btnGuardarDestinosIntermedios"
        Me.btnGuardarDestinosIntermedios.Size = New System.Drawing.Size(157, 51)
        Me.btnGuardarDestinosIntermedios.TabIndex = 27
        Me.btnGuardarDestinosIntermedios.Text = "Guardar"
        Me.btnGuardarDestinosIntermedios.UseVisualStyleBackColor = True
        '
        'btnLimpiarDestinosIntermedios
        '
        Me.btnLimpiarDestinosIntermedios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiarDestinosIntermedios.Location = New System.Drawing.Point(601, 3)
        Me.btnLimpiarDestinosIntermedios.Name = "btnLimpiarDestinosIntermedios"
        Me.btnLimpiarDestinosIntermedios.Size = New System.Drawing.Size(157, 51)
        Me.btnLimpiarDestinosIntermedios.TabIndex = 26
        Me.btnLimpiarDestinosIntermedios.Text = "Limpiar"
        Me.btnLimpiarDestinosIntermedios.UseVisualStyleBackColor = True
        '
        'tabMercancias
        '
        Me.tabMercancias.Controls.Add(Me.tlpPrincipalMercancias)
        Me.tabMercancias.Location = New System.Drawing.Point(4, 29)
        Me.tabMercancias.Name = "tabMercancias"
        Me.tabMercancias.Size = New System.Drawing.Size(1103, 624)
        Me.tabMercancias.TabIndex = 3
        Me.tabMercancias.Text = "Mercancías"
        Me.tabMercancias.UseVisualStyleBackColor = True
        '
        'tlpPrincipalMercancias
        '
        Me.tlpPrincipalMercancias.ColumnCount = 1
        Me.tlpPrincipalMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipalMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPrincipalMercancias.Controls.Add(Me.tlpContenedorGridMovimientosPestanaMercancias, 0, 0)
        Me.tlpPrincipalMercancias.Controls.Add(Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias, 0, 1)
        Me.tlpPrincipalMercancias.Controls.Add(Me.tlpDetallesMercancia, 0, 2)
        Me.tlpPrincipalMercancias.Controls.Add(Me.tlpSiguienteAtrasMercancias, 0, 3)
        Me.tlpPrincipalMercancias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipalMercancias.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipalMercancias.Name = "tlpPrincipalMercancias"
        Me.tlpPrincipalMercancias.RowCount = 4
        Me.tlpPrincipalMercancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipalMercancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipalMercancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipalMercancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipalMercancias.Size = New System.Drawing.Size(1103, 624)
        Me.tlpPrincipalMercancias.TabIndex = 0
        '
        'tlpContenedorGridMovimientosPestanaMercancias
        '
        Me.tlpContenedorGridMovimientosPestanaMercancias.ColumnCount = 1
        Me.tlpContenedorGridMovimientosPestanaMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorGridMovimientosPestanaMercancias.Controls.Add(Me.Label68, 0, 0)
        Me.tlpContenedorGridMovimientosPestanaMercancias.Controls.Add(Me.dgvListadoMovimientosPestanaMercancia)
        Me.tlpContenedorGridMovimientosPestanaMercancias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorGridMovimientosPestanaMercancias.Location = New System.Drawing.Point(3, 3)
        Me.tlpContenedorGridMovimientosPestanaMercancias.Name = "tlpContenedorGridMovimientosPestanaMercancias"
        Me.tlpContenedorGridMovimientosPestanaMercancias.RowCount = 2
        Me.tlpContenedorGridMovimientosPestanaMercancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpContenedorGridMovimientosPestanaMercancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpContenedorGridMovimientosPestanaMercancias.Size = New System.Drawing.Size(1097, 118)
        Me.tlpContenedorGridMovimientosPestanaMercancias.TabIndex = 0
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(3, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(108, 20)
        Me.Label68.TabIndex = 0
        Me.Label68.Text = "Movimientos"
        '
        'dgvListadoMovimientosPestanaMercancia
        '
        Me.dgvListadoMovimientosPestanaMercancia.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoMovimientosPestanaMercancia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoMovimientosPestanaMercancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoMovimientosPestanaMercancia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovimientoMercanciaClm, Me.DestinoMercanciaClm, Me.MovimientosTipoMovimientoClm, Me.MercanciasBtnClm, Me.AnadirMercanciaMovimientoClm, Me.IdUbicacionMovimientoPestanaMercanciaClm})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoMovimientosPestanaMercancia.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoMovimientosPestanaMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListadoMovimientosPestanaMercancia.Location = New System.Drawing.Point(3, 26)
        Me.dgvListadoMovimientosPestanaMercancia.Name = "dgvListadoMovimientosPestanaMercancia"
        Me.dgvListadoMovimientosPestanaMercancia.RowHeadersVisible = False
        Me.dgvListadoMovimientosPestanaMercancia.RowHeadersWidth = 62
        Me.dgvListadoMovimientosPestanaMercancia.RowTemplate.Height = 28
        Me.dgvListadoMovimientosPestanaMercancia.Size = New System.Drawing.Size(1091, 89)
        Me.dgvListadoMovimientosPestanaMercancia.TabIndex = 1
        Me.dgvListadoMovimientosPestanaMercancia.TabStop = False
        '
        'MovimientoMercanciaClm
        '
        Me.MovimientoMercanciaClm.HeaderText = "Movimiento"
        Me.MovimientoMercanciaClm.MinimumWidth = 8
        Me.MovimientoMercanciaClm.Name = "MovimientoMercanciaClm"
        Me.MovimientoMercanciaClm.ReadOnly = True
        Me.MovimientoMercanciaClm.Width = 150
        '
        'DestinoMercanciaClm
        '
        Me.DestinoMercanciaClm.HeaderText = "Destino"
        Me.DestinoMercanciaClm.MinimumWidth = 8
        Me.DestinoMercanciaClm.Name = "DestinoMercanciaClm"
        Me.DestinoMercanciaClm.ReadOnly = True
        Me.DestinoMercanciaClm.Width = 150
        '
        'MovimientosTipoMovimientoClm
        '
        Me.MovimientosTipoMovimientoClm.HeaderText = "TipoMovimiento"
        Me.MovimientosTipoMovimientoClm.MinimumWidth = 8
        Me.MovimientosTipoMovimientoClm.Name = "MovimientosTipoMovimientoClm"
        Me.MovimientosTipoMovimientoClm.ReadOnly = True
        Me.MovimientosTipoMovimientoClm.Width = 150
        '
        'MercanciasBtnClm
        '
        Me.MercanciasBtnClm.HeaderText = "Ver"
        Me.MercanciasBtnClm.MinimumWidth = 8
        Me.MercanciasBtnClm.Name = "MercanciasBtnClm"
        Me.MercanciasBtnClm.Text = "Ver"
        Me.MercanciasBtnClm.ToolTipText = "Ver mercancías del movimiento"
        Me.MercanciasBtnClm.UseColumnTextForButtonValue = True
        Me.MercanciasBtnClm.Width = 150
        '
        'AnadirMercanciaMovimientoClm
        '
        Me.AnadirMercanciaMovimientoClm.HeaderText = "Añadir"
        Me.AnadirMercanciaMovimientoClm.MinimumWidth = 8
        Me.AnadirMercanciaMovimientoClm.Name = "AnadirMercanciaMovimientoClm"
        Me.AnadirMercanciaMovimientoClm.Text = "Añadir"
        Me.AnadirMercanciaMovimientoClm.ToolTipText = "Añadir mercancía individual al movimiento"
        Me.AnadirMercanciaMovimientoClm.UseColumnTextForButtonValue = True
        Me.AnadirMercanciaMovimientoClm.Width = 150
        '
        'IdUbicacionMovimientoPestanaMercanciaClm
        '
        Me.IdUbicacionMovimientoPestanaMercanciaClm.HeaderText = "IdUbicacion"
        Me.IdUbicacionMovimientoPestanaMercanciaClm.MinimumWidth = 8
        Me.IdUbicacionMovimientoPestanaMercanciaClm.Name = "IdUbicacionMovimientoPestanaMercanciaClm"
        Me.IdUbicacionMovimientoPestanaMercanciaClm.ReadOnly = True
        Me.IdUbicacionMovimientoPestanaMercanciaClm.Visible = False
        Me.IdUbicacionMovimientoPestanaMercanciaClm.Width = 150
        '
        'tlpContenedorMercanciasDelMovimientoPestanaMercancias
        '
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.ColumnCount = 1
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.Controls.Add(Me.Label69, 0, 0)
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.Controls.Add(Me.dgvMercanciasPorMovimiento, 0, 1)
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.Location = New System.Drawing.Point(3, 127)
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.Name = "tlpContenedorMercanciasDelMovimientoPestanaMercancias"
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.RowCount = 2
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.Size = New System.Drawing.Size(1097, 118)
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.TabIndex = 1
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(3, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(224, 20)
        Me.Label69.TabIndex = 0
        Me.Label69.Text = "Mercancías del movimiento"
        '
        'dgvMercanciasPorMovimiento
        '
        Me.dgvMercanciasPorMovimiento.AllowUserToAddRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMercanciasPorMovimiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMercanciasPorMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMercanciasPorMovimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MercanciaClaveProdServClm, Me.MovimientoDescripcionClm, Me.ClaveUnidadClm, Me.DescripcionUnidadClm, Me.MercanciaMovimientoPeligrosaClm, Me.MovimientoComercioIntClm, Me.MovimientoDetallesMercClm, Me.MovimientoMercanciaEliminarClm, Me.MovimientoMercanciaCheckboxMaterialPeligrosoClm})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMercanciasPorMovimiento.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMercanciasPorMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMercanciasPorMovimiento.Location = New System.Drawing.Point(3, 26)
        Me.dgvMercanciasPorMovimiento.Name = "dgvMercanciasPorMovimiento"
        Me.dgvMercanciasPorMovimiento.RowHeadersVisible = False
        Me.dgvMercanciasPorMovimiento.RowHeadersWidth = 62
        Me.dgvMercanciasPorMovimiento.RowTemplate.Height = 28
        Me.dgvMercanciasPorMovimiento.Size = New System.Drawing.Size(1091, 89)
        Me.dgvMercanciasPorMovimiento.TabIndex = 1
        Me.dgvMercanciasPorMovimiento.TabStop = False
        '
        'MercanciaClaveProdServClm
        '
        Me.MercanciaClaveProdServClm.HeaderText = "ClaveProdServ"
        Me.MercanciaClaveProdServClm.MinimumWidth = 8
        Me.MercanciaClaveProdServClm.Name = "MercanciaClaveProdServClm"
        Me.MercanciaClaveProdServClm.ReadOnly = True
        Me.MercanciaClaveProdServClm.Width = 150
        '
        'MovimientoDescripcionClm
        '
        Me.MovimientoDescripcionClm.HeaderText = "Descripcion"
        Me.MovimientoDescripcionClm.MinimumWidth = 8
        Me.MovimientoDescripcionClm.Name = "MovimientoDescripcionClm"
        Me.MovimientoDescripcionClm.ReadOnly = True
        Me.MovimientoDescripcionClm.Width = 150
        '
        'ClaveUnidadClm
        '
        Me.ClaveUnidadClm.HeaderText = "ClaveUnidad"
        Me.ClaveUnidadClm.MinimumWidth = 8
        Me.ClaveUnidadClm.Name = "ClaveUnidadClm"
        Me.ClaveUnidadClm.ReadOnly = True
        Me.ClaveUnidadClm.Width = 150
        '
        'DescripcionUnidadClm
        '
        Me.DescripcionUnidadClm.HeaderText = "DescripcionUnidad"
        Me.DescripcionUnidadClm.MinimumWidth = 8
        Me.DescripcionUnidadClm.Name = "DescripcionUnidadClm"
        Me.DescripcionUnidadClm.ReadOnly = True
        Me.DescripcionUnidadClm.Width = 150
        '
        'MercanciaMovimientoPeligrosaClm
        '
        Me.MercanciaMovimientoPeligrosaClm.HeaderText = "¿Peligroso?"
        Me.MercanciaMovimientoPeligrosaClm.MinimumWidth = 8
        Me.MercanciaMovimientoPeligrosaClm.Name = "MercanciaMovimientoPeligrosaClm"
        Me.MercanciaMovimientoPeligrosaClm.ReadOnly = True
        Me.MercanciaMovimientoPeligrosaClm.Width = 150
        '
        'MovimientoComercioIntClm
        '
        Me.MovimientoComercioIntClm.HeaderText = "¿Comercio internacional?"
        Me.MovimientoComercioIntClm.MinimumWidth = 8
        Me.MovimientoComercioIntClm.Name = "MovimientoComercioIntClm"
        Me.MovimientoComercioIntClm.ReadOnly = True
        Me.MovimientoComercioIntClm.Width = 150
        '
        'MovimientoDetallesMercClm
        '
        Me.MovimientoDetallesMercClm.HeaderText = "Detalles"
        Me.MovimientoDetallesMercClm.MinimumWidth = 8
        Me.MovimientoDetallesMercClm.Name = "MovimientoDetallesMercClm"
        Me.MovimientoDetallesMercClm.Text = "Detalles"
        Me.MovimientoDetallesMercClm.UseColumnTextForButtonValue = True
        Me.MovimientoDetallesMercClm.Width = 150
        '
        'MovimientoMercanciaEliminarClm
        '
        Me.MovimientoMercanciaEliminarClm.HeaderText = "Eliminar"
        Me.MovimientoMercanciaEliminarClm.MinimumWidth = 8
        Me.MovimientoMercanciaEliminarClm.Name = "MovimientoMercanciaEliminarClm"
        Me.MovimientoMercanciaEliminarClm.Text = "Eliminar"
        Me.MovimientoMercanciaEliminarClm.UseColumnTextForButtonValue = True
        Me.MovimientoMercanciaEliminarClm.Width = 150
        '
        'MovimientoMercanciaCheckboxMaterialPeligrosoClm
        '
        Me.MovimientoMercanciaCheckboxMaterialPeligrosoClm.HeaderText = "CheckboxMaterialPeligroso"
        Me.MovimientoMercanciaCheckboxMaterialPeligrosoClm.MinimumWidth = 8
        Me.MovimientoMercanciaCheckboxMaterialPeligrosoClm.Name = "MovimientoMercanciaCheckboxMaterialPeligrosoClm"
        Me.MovimientoMercanciaCheckboxMaterialPeligrosoClm.ReadOnly = True
        Me.MovimientoMercanciaCheckboxMaterialPeligrosoClm.Visible = False
        Me.MovimientoMercanciaCheckboxMaterialPeligrosoClm.Width = 150
        '
        'tlpDetallesMercancia
        '
        Me.tlpDetallesMercancia.ColumnCount = 6
        Me.tlpDetallesMercancia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesMercancia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesMercancia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesMercancia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesMercancia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDetallesMercancia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.Controls.Add(Me.Label70, 0, 0)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label71, 0, 1)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label72, 2, 1)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtClaveProdServMercancia, 1, 1)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtDescripcionProducto, 3, 1)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label73, 0, 2)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label74, 2, 2)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label75, 4, 2)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtCantidadMercancia, 1, 2)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtUnidadClaveMercancia, 3, 2)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtUnidadMercancia, 5, 2)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label76, 0, 3)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label77, 2, 3)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label78, 4, 3)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtPeso, 1, 3)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtValor, 3, 3)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtMoneda, 5, 3)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label79, 0, 4)
        Me.tlpDetallesMercancia.Controls.Add(Me.tlpContenedorAltura, 2, 4)
        Me.tlpDetallesMercancia.Controls.Add(Me.tlpContenedorAnchura, 3, 4)
        Me.tlpDetallesMercancia.Controls.Add(Me.tlpContenedorLongitud, 4, 4)
        Me.tlpDetallesMercancia.Controls.Add(Me.cbOpcionDimensiones, 1, 4)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label83, 0, 5)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label84, 0, 6)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label85, 0, 7)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtClaveMaterialPeligroso, 1, 6)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtEmbalaje, 1, 7)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtDescripcionMaterialPeligroso, 3, 6)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtDescripcionEmbalaje, 3, 7)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label86, 0, 8)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label87, 0, 9)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtPedimento, 1, 9)
        Me.tlpDetallesMercancia.Controls.Add(Me.Label56, 3, 9)
        Me.tlpDetallesMercancia.Controls.Add(Me.txtFraccionArancelaria, 4, 9)
        Me.tlpDetallesMercancia.Controls.Add(Me.pnlMaterialPeligroso, 1, 5)
        Me.tlpDetallesMercancia.Controls.Add(Me.pnlComercioInternacional, 1, 8)
        Me.tlpDetallesMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDetallesMercancia.Location = New System.Drawing.Point(3, 251)
        Me.tlpDetallesMercancia.Name = "tlpDetallesMercancia"
        Me.tlpDetallesMercancia.RowCount = 10
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDetallesMercancia.Size = New System.Drawing.Size(1097, 306)
        Me.tlpDetallesMercancia.TabIndex = 2
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.tlpDetallesMercancia.SetColumnSpan(Me.Label70, 3)
        Me.Label70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(3, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(585, 30)
        Me.Label70.TabIndex = 0
        Me.Label70.Text = "Detalles de la mercancía:"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.IndianRed
        Me.Label71.Location = New System.Drawing.Point(3, 30)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(191, 30)
        Me.Label71.TabIndex = 1
        Me.Label71.Text = "Clave ProdServ: * +"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.IndianRed
        Me.Label72.Location = New System.Drawing.Point(397, 30)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(191, 30)
        Me.Label72.TabIndex = 2
        Me.Label72.Text = "Descripción:"
        '
        'txtClaveProdServMercancia
        '
        Me.txtClaveProdServMercancia.BackColor = System.Drawing.Color.White
        Me.txtClaveProdServMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClaveProdServMercancia.Location = New System.Drawing.Point(200, 33)
        Me.txtClaveProdServMercancia.Name = "txtClaveProdServMercancia"
        Me.txtClaveProdServMercancia.Size = New System.Drawing.Size(191, 26)
        Me.txtClaveProdServMercancia.TabIndex = 0
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.BackColor = System.Drawing.Color.White
        Me.tlpDetallesMercancia.SetColumnSpan(Me.txtDescripcionProducto, 3)
        Me.txtDescripcionProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcionProducto.Enabled = False
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(594, 33)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(500, 26)
        Me.txtDescripcionProducto.TabIndex = 4
        Me.txtDescripcionProducto.TabStop = False
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.IndianRed
        Me.Label73.Location = New System.Drawing.Point(3, 60)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(191, 30)
        Me.Label73.TabIndex = 5
        Me.Label73.Text = "Cantidad: *"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.IndianRed
        Me.Label74.Location = New System.Drawing.Point(397, 60)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(191, 30)
        Me.Label74.TabIndex = 6
        Me.Label74.Text = "Clave unidad: * +"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.IndianRed
        Me.Label75.Location = New System.Drawing.Point(791, 60)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(191, 30)
        Me.Label75.TabIndex = 7
        Me.Label75.Text = "Unidad: *"
        '
        'txtCantidadMercancia
        '
        Me.txtCantidadMercancia.BackColor = System.Drawing.Color.White
        Me.txtCantidadMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCantidadMercancia.Location = New System.Drawing.Point(200, 63)
        Me.txtCantidadMercancia.Name = "txtCantidadMercancia"
        Me.txtCantidadMercancia.Size = New System.Drawing.Size(191, 26)
        Me.txtCantidadMercancia.TabIndex = 1
        '
        'txtUnidadClaveMercancia
        '
        Me.txtUnidadClaveMercancia.BackColor = System.Drawing.Color.White
        Me.txtUnidadClaveMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUnidadClaveMercancia.Location = New System.Drawing.Point(594, 63)
        Me.txtUnidadClaveMercancia.Name = "txtUnidadClaveMercancia"
        Me.txtUnidadClaveMercancia.Size = New System.Drawing.Size(191, 26)
        Me.txtUnidadClaveMercancia.TabIndex = 2
        '
        'txtUnidadMercancia
        '
        Me.txtUnidadMercancia.BackColor = System.Drawing.Color.White
        Me.txtUnidadMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUnidadMercancia.Location = New System.Drawing.Point(988, 63)
        Me.txtUnidadMercancia.Name = "txtUnidadMercancia"
        Me.txtUnidadMercancia.Size = New System.Drawing.Size(106, 26)
        Me.txtUnidadMercancia.TabIndex = 10
        Me.txtUnidadMercancia.TabStop = False
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.IndianRed
        Me.Label76.Location = New System.Drawing.Point(3, 90)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(66, 20)
        Me.Label76.TabIndex = 11
        Me.Label76.Text = "Peso: *"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.IndianRed
        Me.Label77.Location = New System.Drawing.Point(397, 90)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(68, 20)
        Me.Label77.TabIndex = 12
        Me.Label77.Text = "Valor: *"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.IndianRed
        Me.Label78.Location = New System.Drawing.Point(791, 90)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(105, 20)
        Me.Label78.TabIndex = 13
        Me.Label78.Text = "Moneda: * +"
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.White
        Me.txtPeso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPeso.Location = New System.Drawing.Point(200, 93)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(191, 26)
        Me.txtPeso.TabIndex = 3
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtValor.Location = New System.Drawing.Point(594, 93)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(191, 26)
        Me.txtValor.TabIndex = 4
        '
        'txtMoneda
        '
        Me.txtMoneda.BackColor = System.Drawing.Color.White
        Me.txtMoneda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMoneda.Location = New System.Drawing.Point(988, 93)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(106, 26)
        Me.txtMoneda.TabIndex = 5
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(3, 120)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(112, 20)
        Me.Label79.TabIndex = 17
        Me.Label79.Text = "Dimensiones"
        '
        'tlpContenedorAltura
        '
        Me.tlpContenedorAltura.ColumnCount = 2
        Me.tlpContenedorAltura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorAltura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorAltura.Controls.Add(Me.Label80, 0, 0)
        Me.tlpContenedorAltura.Controls.Add(Me.numAnchura, 1, 0)
        Me.tlpContenedorAltura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorAltura.Location = New System.Drawing.Point(397, 123)
        Me.tlpContenedorAltura.Name = "tlpContenedorAltura"
        Me.tlpContenedorAltura.RowCount = 1
        Me.tlpContenedorAltura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorAltura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpContenedorAltura.Size = New System.Drawing.Size(191, 24)
        Me.tlpContenedorAltura.TabIndex = 18
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(3, 0)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(89, 24)
        Me.Label80.TabIndex = 0
        Me.Label80.Text = "Anchura:"
        '
        'numAnchura
        '
        Me.numAnchura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numAnchura.Location = New System.Drawing.Point(98, 3)
        Me.numAnchura.Name = "numAnchura"
        Me.numAnchura.Size = New System.Drawing.Size(90, 26)
        Me.numAnchura.TabIndex = 7
        '
        'tlpContenedorAnchura
        '
        Me.tlpContenedorAnchura.ColumnCount = 2
        Me.tlpContenedorAnchura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorAnchura.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorAnchura.Controls.Add(Me.Label81, 0, 0)
        Me.tlpContenedorAnchura.Controls.Add(Me.numAltura, 1, 0)
        Me.tlpContenedorAnchura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorAnchura.Location = New System.Drawing.Point(594, 123)
        Me.tlpContenedorAnchura.Name = "tlpContenedorAnchura"
        Me.tlpContenedorAnchura.RowCount = 1
        Me.tlpContenedorAnchura.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorAnchura.Size = New System.Drawing.Size(191, 24)
        Me.tlpContenedorAnchura.TabIndex = 19
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(3, 0)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(89, 24)
        Me.Label81.TabIndex = 0
        Me.Label81.Text = "Altura:"
        '
        'numAltura
        '
        Me.numAltura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numAltura.Location = New System.Drawing.Point(98, 3)
        Me.numAltura.Name = "numAltura"
        Me.numAltura.Size = New System.Drawing.Size(90, 26)
        Me.numAltura.TabIndex = 8
        '
        'tlpContenedorLongitud
        '
        Me.tlpContenedorLongitud.ColumnCount = 2
        Me.tlpContenedorLongitud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorLongitud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorLongitud.Controls.Add(Me.Label82, 0, 0)
        Me.tlpContenedorLongitud.Controls.Add(Me.numLongitud, 1, 0)
        Me.tlpContenedorLongitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorLongitud.Location = New System.Drawing.Point(791, 123)
        Me.tlpContenedorLongitud.Name = "tlpContenedorLongitud"
        Me.tlpContenedorLongitud.RowCount = 1
        Me.tlpContenedorLongitud.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorLongitud.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpContenedorLongitud.Size = New System.Drawing.Size(191, 24)
        Me.tlpContenedorLongitud.TabIndex = 20
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(3, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(89, 24)
        Me.Label82.TabIndex = 0
        Me.Label82.Text = "Longitud:"
        '
        'numLongitud
        '
        Me.numLongitud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numLongitud.Location = New System.Drawing.Point(98, 3)
        Me.numLongitud.Name = "numLongitud"
        Me.numLongitud.Size = New System.Drawing.Size(90, 26)
        Me.numLongitud.TabIndex = 9
        '
        'cbOpcionDimensiones
        '
        Me.cbOpcionDimensiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbOpcionDimensiones.FormattingEnabled = True
        Me.cbOpcionDimensiones.Location = New System.Drawing.Point(200, 123)
        Me.cbOpcionDimensiones.Name = "cbOpcionDimensiones"
        Me.cbOpcionDimensiones.Size = New System.Drawing.Size(191, 28)
        Me.cbOpcionDimensiones.TabIndex = 6
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(3, 150)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(156, 20)
        Me.Label83.TabIndex = 22
        Me.Label83.Text = "Material peligroso:"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(3, 180)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(186, 20)
        Me.Label84.TabIndex = 25
        Me.Label84.Text = "Clave mat peligroso: +"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(3, 210)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(103, 20)
        Me.Label85.TabIndex = 26
        Me.Label85.Text = "Embalaje: +"
        '
        'txtClaveMaterialPeligroso
        '
        Me.txtClaveMaterialPeligroso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClaveMaterialPeligroso.Location = New System.Drawing.Point(200, 183)
        Me.txtClaveMaterialPeligroso.Name = "txtClaveMaterialPeligroso"
        Me.txtClaveMaterialPeligroso.Size = New System.Drawing.Size(191, 26)
        Me.txtClaveMaterialPeligroso.TabIndex = 12
        '
        'txtEmbalaje
        '
        Me.txtEmbalaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmbalaje.Location = New System.Drawing.Point(200, 213)
        Me.txtEmbalaje.Name = "txtEmbalaje"
        Me.txtEmbalaje.Size = New System.Drawing.Size(191, 26)
        Me.txtEmbalaje.TabIndex = 13
        '
        'txtDescripcionMaterialPeligroso
        '
        Me.tlpDetallesMercancia.SetColumnSpan(Me.txtDescripcionMaterialPeligroso, 3)
        Me.txtDescripcionMaterialPeligroso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcionMaterialPeligroso.Location = New System.Drawing.Point(594, 183)
        Me.txtDescripcionMaterialPeligroso.Name = "txtDescripcionMaterialPeligroso"
        Me.txtDescripcionMaterialPeligroso.Size = New System.Drawing.Size(500, 26)
        Me.txtDescripcionMaterialPeligroso.TabIndex = 29
        Me.txtDescripcionMaterialPeligroso.TabStop = False
        '
        'txtDescripcionEmbalaje
        '
        Me.tlpDetallesMercancia.SetColumnSpan(Me.txtDescripcionEmbalaje, 2)
        Me.txtDescripcionEmbalaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcionEmbalaje.Location = New System.Drawing.Point(594, 213)
        Me.txtDescripcionEmbalaje.Name = "txtDescripcionEmbalaje"
        Me.txtDescripcionEmbalaje.Size = New System.Drawing.Size(388, 26)
        Me.txtDescripcionEmbalaje.TabIndex = 30
        Me.txtDescripcionEmbalaje.TabStop = False
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(3, 240)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(117, 30)
        Me.Label86.TabIndex = 31
        Me.Label86.Text = "Comercio internacional:"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(3, 270)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(99, 20)
        Me.Label87.TabIndex = 32
        Me.Label87.Text = "Pedimento:"
        '
        'txtPedimento
        '
        Me.tlpDetallesMercancia.SetColumnSpan(Me.txtPedimento, 2)
        Me.txtPedimento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPedimento.Location = New System.Drawing.Point(200, 273)
        Me.txtPedimento.Name = "txtPedimento"
        Me.txtPedimento.Size = New System.Drawing.Size(388, 26)
        Me.txtPedimento.TabIndex = 16
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(594, 270)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(191, 36)
        Me.Label56.TabIndex = 36
        Me.Label56.Text = "Fracción arancelaria:"
        '
        'txtFraccionArancelaria
        '
        Me.tlpDetallesMercancia.SetColumnSpan(Me.txtFraccionArancelaria, 2)
        Me.txtFraccionArancelaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFraccionArancelaria.Location = New System.Drawing.Point(791, 273)
        Me.txtFraccionArancelaria.Name = "txtFraccionArancelaria"
        Me.txtFraccionArancelaria.Size = New System.Drawing.Size(303, 26)
        Me.txtFraccionArancelaria.TabIndex = 17
        '
        'pnlMaterialPeligroso
        '
        Me.tlpDetallesMercancia.SetColumnSpan(Me.pnlMaterialPeligroso, 2)
        Me.pnlMaterialPeligroso.Controls.Add(Me.rbSiMaterialPeligroso)
        Me.pnlMaterialPeligroso.Controls.Add(Me.rbNoMaterialPeligroso)
        Me.pnlMaterialPeligroso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMaterialPeligroso.Location = New System.Drawing.Point(200, 153)
        Me.pnlMaterialPeligroso.Name = "pnlMaterialPeligroso"
        Me.pnlMaterialPeligroso.Size = New System.Drawing.Size(388, 24)
        Me.pnlMaterialPeligroso.TabIndex = 38
        '
        'rbSiMaterialPeligroso
        '
        Me.rbSiMaterialPeligroso.AutoSize = True
        Me.rbSiMaterialPeligroso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSiMaterialPeligroso.Location = New System.Drawing.Point(0, 4)
        Me.rbSiMaterialPeligroso.Name = "rbSiMaterialPeligroso"
        Me.rbSiMaterialPeligroso.Size = New System.Drawing.Size(50, 24)
        Me.rbSiMaterialPeligroso.TabIndex = 10
        Me.rbSiMaterialPeligroso.TabStop = True
        Me.rbSiMaterialPeligroso.Text = "Sí"
        Me.rbSiMaterialPeligroso.UseVisualStyleBackColor = True
        '
        'rbNoMaterialPeligroso
        '
        Me.rbNoMaterialPeligroso.AutoSize = True
        Me.rbNoMaterialPeligroso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNoMaterialPeligroso.Location = New System.Drawing.Point(190, 0)
        Me.rbNoMaterialPeligroso.Name = "rbNoMaterialPeligroso"
        Me.rbNoMaterialPeligroso.Size = New System.Drawing.Size(56, 24)
        Me.rbNoMaterialPeligroso.TabIndex = 11
        Me.rbNoMaterialPeligroso.TabStop = True
        Me.rbNoMaterialPeligroso.Text = "No"
        Me.rbNoMaterialPeligroso.UseVisualStyleBackColor = True
        '
        'pnlComercioInternacional
        '
        Me.tlpDetallesMercancia.SetColumnSpan(Me.pnlComercioInternacional, 2)
        Me.pnlComercioInternacional.Controls.Add(Me.rbComercioInternacionalSi)
        Me.pnlComercioInternacional.Controls.Add(Me.rbComercioInternacionalNo)
        Me.pnlComercioInternacional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlComercioInternacional.Location = New System.Drawing.Point(200, 243)
        Me.pnlComercioInternacional.Name = "pnlComercioInternacional"
        Me.pnlComercioInternacional.Size = New System.Drawing.Size(388, 24)
        Me.pnlComercioInternacional.TabIndex = 39
        '
        'rbComercioInternacionalSi
        '
        Me.rbComercioInternacionalSi.AutoSize = True
        Me.rbComercioInternacionalSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbComercioInternacionalSi.Location = New System.Drawing.Point(3, 0)
        Me.rbComercioInternacionalSi.Name = "rbComercioInternacionalSi"
        Me.rbComercioInternacionalSi.Size = New System.Drawing.Size(50, 24)
        Me.rbComercioInternacionalSi.TabIndex = 14
        Me.rbComercioInternacionalSi.TabStop = True
        Me.rbComercioInternacionalSi.Text = "Sí"
        Me.rbComercioInternacionalSi.UseVisualStyleBackColor = True
        '
        'rbComercioInternacionalNo
        '
        Me.rbComercioInternacionalNo.AutoSize = True
        Me.rbComercioInternacionalNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbComercioInternacionalNo.Location = New System.Drawing.Point(190, 0)
        Me.rbComercioInternacionalNo.Name = "rbComercioInternacionalNo"
        Me.rbComercioInternacionalNo.Size = New System.Drawing.Size(56, 24)
        Me.rbComercioInternacionalNo.TabIndex = 15
        Me.rbComercioInternacionalNo.TabStop = True
        Me.rbComercioInternacionalNo.Text = "No"
        Me.rbComercioInternacionalNo.UseVisualStyleBackColor = True
        '
        'tlpSiguienteAtrasMercancias
        '
        Me.tlpSiguienteAtrasMercancias.ColumnCount = 5
        Me.tlpSiguienteAtrasMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpSiguienteAtrasMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpSiguienteAtrasMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpSiguienteAtrasMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpSiguienteAtrasMercancias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpSiguienteAtrasMercancias.Controls.Add(Me.btnAtrasMercancia, 1, 0)
        Me.tlpSiguienteAtrasMercancias.Controls.Add(Me.btnGuardarMercancia, 3, 0)
        Me.tlpSiguienteAtrasMercancias.Controls.Add(Me.btnSiguienteMercancia, 4, 0)
        Me.tlpSiguienteAtrasMercancias.Controls.Add(Me.btnLimpiarMercancia, 2, 0)
        Me.tlpSiguienteAtrasMercancias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSiguienteAtrasMercancias.Location = New System.Drawing.Point(3, 563)
        Me.tlpSiguienteAtrasMercancias.Name = "tlpSiguienteAtrasMercancias"
        Me.tlpSiguienteAtrasMercancias.RowCount = 1
        Me.tlpSiguienteAtrasMercancias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSiguienteAtrasMercancias.Size = New System.Drawing.Size(1097, 58)
        Me.tlpSiguienteAtrasMercancias.TabIndex = 3
        '
        'btnAtrasMercancia
        '
        Me.btnAtrasMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtrasMercancia.Location = New System.Drawing.Point(441, 3)
        Me.btnAtrasMercancia.Name = "btnAtrasMercancia"
        Me.btnAtrasMercancia.Size = New System.Drawing.Size(158, 52)
        Me.btnAtrasMercancia.TabIndex = 18
        Me.btnAtrasMercancia.Text = "Atrás"
        Me.btnAtrasMercancia.UseVisualStyleBackColor = True
        '
        'btnGuardarMercancia
        '
        Me.btnGuardarMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardarMercancia.Location = New System.Drawing.Point(769, 3)
        Me.btnGuardarMercancia.Name = "btnGuardarMercancia"
        Me.btnGuardarMercancia.Size = New System.Drawing.Size(158, 52)
        Me.btnGuardarMercancia.TabIndex = 20
        Me.btnGuardarMercancia.Text = "Guardar"
        Me.btnGuardarMercancia.UseVisualStyleBackColor = True
        '
        'btnSiguienteMercancia
        '
        Me.btnSiguienteMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSiguienteMercancia.Location = New System.Drawing.Point(933, 3)
        Me.btnSiguienteMercancia.Name = "btnSiguienteMercancia"
        Me.btnSiguienteMercancia.Size = New System.Drawing.Size(161, 52)
        Me.btnSiguienteMercancia.TabIndex = 21
        Me.btnSiguienteMercancia.Text = "Siguiente"
        Me.btnSiguienteMercancia.UseVisualStyleBackColor = True
        '
        'btnLimpiarMercancia
        '
        Me.btnLimpiarMercancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiarMercancia.Location = New System.Drawing.Point(605, 3)
        Me.btnLimpiarMercancia.Name = "btnLimpiarMercancia"
        Me.btnLimpiarMercancia.Size = New System.Drawing.Size(158, 52)
        Me.btnLimpiarMercancia.TabIndex = 19
        Me.btnLimpiarMercancia.Text = "Limpiar"
        Me.btnLimpiarMercancia.UseVisualStyleBackColor = True
        '
        'tabTransporte
        '
        Me.tabTransporte.Controls.Add(Me.tlpContenedorPrincipalTransporte)
        Me.tabTransporte.Location = New System.Drawing.Point(4, 29)
        Me.tabTransporte.Name = "tabTransporte"
        Me.tabTransporte.Size = New System.Drawing.Size(1103, 624)
        Me.tabTransporte.TabIndex = 4
        Me.tabTransporte.Text = "Transporte"
        Me.tabTransporte.UseVisualStyleBackColor = True
        '
        'tlpContenedorPrincipalTransporte
        '
        Me.tlpContenedorPrincipalTransporte.ColumnCount = 1
        Me.tlpContenedorPrincipalTransporte.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPrincipalTransporte.Controls.Add(Me.TableLayoutPanel6, 0, 3)
        Me.tlpContenedorPrincipalTransporte.Controls.Add(Me.tlpContenedorDatosTransporte, 0, 0)
        Me.tlpContenedorPrincipalTransporte.Controls.Add(Me.tlpContenedorRemolques, 0, 1)
        Me.tlpContenedorPrincipalTransporte.Controls.Add(Me.tlpContenedorSeguroMaterialPeligroso, 0, 2)
        Me.tlpContenedorPrincipalTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorPrincipalTransporte.Location = New System.Drawing.Point(0, 0)
        Me.tlpContenedorPrincipalTransporte.Name = "tlpContenedorPrincipalTransporte"
        Me.tlpContenedorPrincipalTransporte.RowCount = 4
        Me.tlpContenedorPrincipalTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpContenedorPrincipalTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpContenedorPrincipalTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpContenedorPrincipalTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenedorPrincipalTransporte.Size = New System.Drawing.Size(1103, 624)
        Me.tlpContenedorPrincipalTransporte.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnAtrasTransporte, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnSiguienteTransporte, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 563)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1097, 58)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'btnAtrasTransporte
        '
        Me.btnAtrasTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtrasTransporte.Location = New System.Drawing.Point(551, 3)
        Me.btnAtrasTransporte.Name = "btnAtrasTransporte"
        Me.btnAtrasTransporte.Size = New System.Drawing.Size(268, 52)
        Me.btnAtrasTransporte.TabIndex = 20
        Me.btnAtrasTransporte.Text = "Atrás"
        Me.btnAtrasTransporte.UseVisualStyleBackColor = True
        '
        'btnSiguienteTransporte
        '
        Me.btnSiguienteTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSiguienteTransporte.Location = New System.Drawing.Point(825, 3)
        Me.btnSiguienteTransporte.Name = "btnSiguienteTransporte"
        Me.btnSiguienteTransporte.Size = New System.Drawing.Size(269, 52)
        Me.btnSiguienteTransporte.TabIndex = 21
        Me.btnSiguienteTransporte.Text = "Siguiente"
        Me.btnSiguienteTransporte.UseVisualStyleBackColor = True
        '
        'tlpContenedorDatosTransporte
        '
        Me.tlpContenedorDatosTransporte.ColumnCount = 4
        Me.tlpContenedorDatosTransporte.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpContenedorDatosTransporte.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpContenedorDatosTransporte.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpContenedorDatosTransporte.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label88, 0, 0)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label89, 0, 1)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.cbSeleccionarVehiculo, 1, 1)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label90, 0, 2)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label91, 2, 1)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtNumPermisoSCT, 3, 1)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtDescripConfigVehicular, 2, 3)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label92, 0, 3)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label93, 0, 4)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label94, 2, 4)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtPlacaTransporte, 1, 4)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtAnioModeloTransporte, 3, 4)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label95, 0, 5)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label96, 2, 5)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtAseguradoraTransporte, 1, 5)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtPolizaTransporte, 3, 5)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtAseguradoraCargaTransporte, 1, 6)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.Label97, 0, 6)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.tlpContenedorPoliza, 2, 6)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.tlpContenedorPrimaSeguro, 3, 6)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtConVeh, 1, 3)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtTipoPermisoSCT, 1, 2)
        Me.tlpContenedorDatosTransporte.Controls.Add(Me.txtDescripcionTipoPermisoSCT, 2, 2)
        Me.tlpContenedorDatosTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorDatosTransporte.Location = New System.Drawing.Point(3, 3)
        Me.tlpContenedorDatosTransporte.Name = "tlpContenedorDatosTransporte"
        Me.tlpContenedorDatosTransporte.RowCount = 7
        Me.tlpContenedorDatosTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenedorDatosTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpContenedorDatosTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpContenedorDatosTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpContenedorDatosTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpContenedorDatosTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpContenedorDatosTransporte.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpContenedorDatosTransporte.Size = New System.Drawing.Size(1097, 243)
        Me.tlpContenedorDatosTransporte.TabIndex = 1
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(3, 0)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(156, 20)
        Me.Label88.TabIndex = 0
        Me.Label88.Text = "Datos del vehículo"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.IndianRed
        Me.Label89.Location = New System.Drawing.Point(3, 24)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(268, 36)
        Me.Label89.TabIndex = 1
        Me.Label89.Text = "Seleccionar vehículo: *"
        '
        'cbSeleccionarVehiculo
        '
        Me.cbSeleccionarVehiculo.BackColor = System.Drawing.Color.White
        Me.cbSeleccionarVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbSeleccionarVehiculo.FormattingEnabled = True
        Me.cbSeleccionarVehiculo.Location = New System.Drawing.Point(277, 27)
        Me.cbSeleccionarVehiculo.Name = "cbSeleccionarVehiculo"
        Me.cbSeleccionarVehiculo.Size = New System.Drawing.Size(268, 28)
        Me.cbSeleccionarVehiculo.TabIndex = 0
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.IndianRed
        Me.Label90.Location = New System.Drawing.Point(3, 60)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(268, 36)
        Me.Label90.TabIndex = 3
        Me.Label90.Text = "Perm SCT: * +"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.IndianRed
        Me.Label91.Location = New System.Drawing.Point(551, 24)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(268, 36)
        Me.Label91.TabIndex = 4
        Me.Label91.Text = "Num. permiso SCT: *"
        '
        'txtNumPermisoSCT
        '
        Me.txtNumPermisoSCT.BackColor = System.Drawing.Color.White
        Me.txtNumPermisoSCT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumPermisoSCT.Location = New System.Drawing.Point(825, 27)
        Me.txtNumPermisoSCT.Name = "txtNumPermisoSCT"
        Me.txtNumPermisoSCT.Size = New System.Drawing.Size(269, 26)
        Me.txtNumPermisoSCT.TabIndex = 1
        '
        'txtDescripConfigVehicular
        '
        Me.txtDescripConfigVehicular.BackColor = System.Drawing.Color.White
        Me.tlpContenedorDatosTransporte.SetColumnSpan(Me.txtDescripConfigVehicular, 2)
        Me.txtDescripConfigVehicular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripConfigVehicular.Enabled = False
        Me.txtDescripConfigVehicular.Location = New System.Drawing.Point(551, 99)
        Me.txtDescripConfigVehicular.Name = "txtDescripConfigVehicular"
        Me.txtDescripConfigVehicular.Size = New System.Drawing.Size(543, 26)
        Me.txtDescripConfigVehicular.TabIndex = 7
        Me.txtDescripConfigVehicular.TabStop = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.IndianRed
        Me.Label92.Location = New System.Drawing.Point(3, 96)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(169, 20)
        Me.Label92.TabIndex = 8
        Me.Label92.Text = "Config vehícular: * +"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.IndianRed
        Me.Label93.Location = New System.Drawing.Point(3, 132)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(70, 20)
        Me.Label93.TabIndex = 10
        Me.Label93.Text = "Placa: *"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.IndianRed
        Me.Label94.Location = New System.Drawing.Point(551, 132)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(121, 20)
        Me.Label94.TabIndex = 100
        Me.Label94.Text = "Año modelo: *"
        '
        'txtPlacaTransporte
        '
        Me.txtPlacaTransporte.BackColor = System.Drawing.Color.White
        Me.txtPlacaTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPlacaTransporte.Location = New System.Drawing.Point(277, 135)
        Me.txtPlacaTransporte.Name = "txtPlacaTransporte"
        Me.txtPlacaTransporte.Size = New System.Drawing.Size(268, 26)
        Me.txtPlacaTransporte.TabIndex = 4
        '
        'txtAnioModeloTransporte
        '
        Me.txtAnioModeloTransporte.BackColor = System.Drawing.Color.White
        Me.txtAnioModeloTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAnioModeloTransporte.Location = New System.Drawing.Point(825, 135)
        Me.txtAnioModeloTransporte.Name = "txtAnioModeloTransporte"
        Me.txtAnioModeloTransporte.Size = New System.Drawing.Size(269, 26)
        Me.txtAnioModeloTransporte.TabIndex = 5
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.IndianRed
        Me.Label95.Location = New System.Drawing.Point(3, 168)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(203, 20)
        Me.Label95.TabIndex = 14
        Me.Label95.Text = "Aseguradora resp civil: *"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.Color.IndianRed
        Me.Label96.Location = New System.Drawing.Point(551, 168)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(153, 20)
        Me.Label96.TabIndex = 15
        Me.Label96.Text = "Póliza resp. civil: *"
        '
        'txtAseguradoraTransporte
        '
        Me.txtAseguradoraTransporte.BackColor = System.Drawing.Color.White
        Me.txtAseguradoraTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAseguradoraTransporte.Location = New System.Drawing.Point(277, 171)
        Me.txtAseguradoraTransporte.Name = "txtAseguradoraTransporte"
        Me.txtAseguradoraTransporte.Size = New System.Drawing.Size(268, 26)
        Me.txtAseguradoraTransporte.TabIndex = 6
        '
        'txtPolizaTransporte
        '
        Me.txtPolizaTransporte.BackColor = System.Drawing.Color.White
        Me.txtPolizaTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPolizaTransporte.Location = New System.Drawing.Point(825, 171)
        Me.txtPolizaTransporte.Name = "txtPolizaTransporte"
        Me.txtPolizaTransporte.Size = New System.Drawing.Size(269, 26)
        Me.txtPolizaTransporte.TabIndex = 7
        '
        'txtAseguradoraCargaTransporte
        '
        Me.txtAseguradoraCargaTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAseguradoraCargaTransporte.Location = New System.Drawing.Point(277, 207)
        Me.txtAseguradoraCargaTransporte.Name = "txtAseguradoraCargaTransporte"
        Me.txtAseguradoraCargaTransporte.Size = New System.Drawing.Size(268, 26)
        Me.txtAseguradoraCargaTransporte.TabIndex = 8
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.Black
        Me.Label97.Location = New System.Drawing.Point(3, 204)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(197, 20)
        Me.Label97.TabIndex = 19
        Me.Label97.Text = "Aseguradora de carga: "
        '
        'tlpContenedorPoliza
        '
        Me.tlpContenedorPoliza.ColumnCount = 2
        Me.tlpContenedorPoliza.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorPoliza.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorPoliza.Controls.Add(Me.Label98, 0, 0)
        Me.tlpContenedorPoliza.Controls.Add(Me.txtPolizaCargaTransporte, 1, 0)
        Me.tlpContenedorPoliza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorPoliza.Location = New System.Drawing.Point(551, 207)
        Me.tlpContenedorPoliza.Name = "tlpContenedorPoliza"
        Me.tlpContenedorPoliza.RowCount = 1
        Me.tlpContenedorPoliza.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPoliza.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpContenedorPoliza.Size = New System.Drawing.Size(268, 33)
        Me.tlpContenedorPoliza.TabIndex = 20
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.Black
        Me.Label98.Location = New System.Drawing.Point(3, 0)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(128, 33)
        Me.Label98.TabIndex = 0
        Me.Label98.Text = "Póliza carga: "
        '
        'txtPolizaCargaTransporte
        '
        Me.txtPolizaCargaTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPolizaCargaTransporte.Location = New System.Drawing.Point(137, 3)
        Me.txtPolizaCargaTransporte.Name = "txtPolizaCargaTransporte"
        Me.txtPolizaCargaTransporte.Size = New System.Drawing.Size(128, 26)
        Me.txtPolizaCargaTransporte.TabIndex = 9
        '
        'tlpContenedorPrimaSeguro
        '
        Me.tlpContenedorPrimaSeguro.ColumnCount = 2
        Me.tlpContenedorPrimaSeguro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorPrimaSeguro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenedorPrimaSeguro.Controls.Add(Me.Label99, 0, 0)
        Me.tlpContenedorPrimaSeguro.Controls.Add(Me.txtPrimaSeguroTransporte, 1, 0)
        Me.tlpContenedorPrimaSeguro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorPrimaSeguro.Location = New System.Drawing.Point(825, 207)
        Me.tlpContenedorPrimaSeguro.Name = "tlpContenedorPrimaSeguro"
        Me.tlpContenedorPrimaSeguro.RowCount = 1
        Me.tlpContenedorPrimaSeguro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPrimaSeguro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpContenedorPrimaSeguro.Size = New System.Drawing.Size(269, 33)
        Me.tlpContenedorPrimaSeguro.TabIndex = 21
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.ForeColor = System.Drawing.Color.IndianRed
        Me.Label99.Location = New System.Drawing.Point(3, 0)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(128, 33)
        Me.Label99.TabIndex = 0
        Me.Label99.Text = "Prima seguro *"
        '
        'txtPrimaSeguroTransporte
        '
        Me.txtPrimaSeguroTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrimaSeguroTransporte.Location = New System.Drawing.Point(137, 3)
        Me.txtPrimaSeguroTransporte.Name = "txtPrimaSeguroTransporte"
        Me.txtPrimaSeguroTransporte.Size = New System.Drawing.Size(129, 26)
        Me.txtPrimaSeguroTransporte.TabIndex = 10
        '
        'txtConVeh
        '
        Me.txtConVeh.BackColor = System.Drawing.Color.White
        Me.txtConVeh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConVeh.Location = New System.Drawing.Point(277, 99)
        Me.txtConVeh.Name = "txtConVeh"
        Me.txtConVeh.Size = New System.Drawing.Size(268, 26)
        Me.txtConVeh.TabIndex = 3
        '
        'txtTipoPermisoSCT
        '
        Me.txtTipoPermisoSCT.BackColor = System.Drawing.Color.White
        Me.txtTipoPermisoSCT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoPermisoSCT.Location = New System.Drawing.Point(277, 63)
        Me.txtTipoPermisoSCT.Name = "txtTipoPermisoSCT"
        Me.txtTipoPermisoSCT.Size = New System.Drawing.Size(268, 26)
        Me.txtTipoPermisoSCT.TabIndex = 2
        '
        'txtDescripcionTipoPermisoSCT
        '
        Me.txtDescripcionTipoPermisoSCT.BackColor = System.Drawing.Color.White
        Me.tlpContenedorDatosTransporte.SetColumnSpan(Me.txtDescripcionTipoPermisoSCT, 2)
        Me.txtDescripcionTipoPermisoSCT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcionTipoPermisoSCT.Enabled = False
        Me.txtDescripcionTipoPermisoSCT.Location = New System.Drawing.Point(551, 63)
        Me.txtDescripcionTipoPermisoSCT.Name = "txtDescripcionTipoPermisoSCT"
        Me.txtDescripcionTipoPermisoSCT.Size = New System.Drawing.Size(543, 26)
        Me.txtDescripcionTipoPermisoSCT.TabIndex = 24
        Me.txtDescripcionTipoPermisoSCT.TabStop = False
        '
        'tlpContenedorRemolques
        '
        Me.tlpContenedorRemolques.ColumnCount = 6
        Me.tlpContenedorRemolques.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenedorRemolques.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpContenedorRemolques.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpContenedorRemolques.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpContenedorRemolques.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpContenedorRemolques.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpContenedorRemolques.Controls.Add(Me.Label100, 0, 0)
        Me.tlpContenedorRemolques.Controls.Add(Me.Label101, 0, 1)
        Me.tlpContenedorRemolques.Controls.Add(Me.Label104, 1, 2)
        Me.tlpContenedorRemolques.Controls.Add(Me.Label105, 1, 3)
        Me.tlpContenedorRemolques.Controls.Add(Me.Label106, 4, 2)
        Me.tlpContenedorRemolques.Controls.Add(Me.Label107, 4, 3)
        Me.tlpContenedorRemolques.Controls.Add(Me.numCantidadRemolquesTransporte, 2, 1)
        Me.tlpContenedorRemolques.Controls.Add(Me.cbPropiedadRemolque1, 0, 2)
        Me.tlpContenedorRemolques.Controls.Add(Me.cbPropiedadRemolque2, 0, 3)
        Me.tlpContenedorRemolques.Controls.Add(Me.cbTipoRemolque1, 2, 2)
        Me.tlpContenedorRemolques.Controls.Add(Me.cbTipoRemolque2, 2, 3)
        Me.tlpContenedorRemolques.Controls.Add(Me.txtTipoRemolque1, 3, 2)
        Me.tlpContenedorRemolques.Controls.Add(Me.txtTipoRemolque2, 3, 3)
        Me.tlpContenedorRemolques.Controls.Add(Me.txtPlacasRemolque1, 5, 2)
        Me.tlpContenedorRemolques.Controls.Add(Me.txtPlacasRemolque2, 5, 3)
        Me.tlpContenedorRemolques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorRemolques.Location = New System.Drawing.Point(3, 252)
        Me.tlpContenedorRemolques.Name = "tlpContenedorRemolques"
        Me.tlpContenedorRemolques.RowCount = 4
        Me.tlpContenedorRemolques.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenedorRemolques.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpContenedorRemolques.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpContenedorRemolques.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpContenedorRemolques.Size = New System.Drawing.Size(1097, 181)
        Me.tlpContenedorRemolques.TabIndex = 2
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(3, 0)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(99, 18)
        Me.Label100.TabIndex = 0
        Me.Label100.Text = "Remolques"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.tlpContenedorRemolques.SetColumnSpan(Me.Label101, 2)
        Me.Label101.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(3, 18)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(300, 54)
        Me.Label101.TabIndex = 1
        Me.Label101.Text = "Cantidad de remolques"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(112, 72)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(152, 20)
        Me.Label104.TabIndex = 4
        Me.Label104.Text = "Tipo de remolque:"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(112, 126)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(152, 20)
        Me.Label105.TabIndex = 5
        Me.Label105.Text = "Tipo de remolque:"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(703, 72)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(67, 20)
        Me.Label106.TabIndex = 6
        Me.Label106.Text = "Placas:"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(703, 126)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(67, 20)
        Me.Label107.TabIndex = 7
        Me.Label107.Text = "Placas:"
        '
        'numCantidadRemolquesTransporte
        '
        Me.numCantidadRemolquesTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numCantidadRemolquesTransporte.Location = New System.Drawing.Point(309, 21)
        Me.numCantidadRemolquesTransporte.Name = "numCantidadRemolquesTransporte"
        Me.numCantidadRemolquesTransporte.Size = New System.Drawing.Size(191, 26)
        Me.numCantidadRemolquesTransporte.TabIndex = 11
        '
        'cbPropiedadRemolque1
        '
        Me.cbPropiedadRemolque1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPropiedadRemolque1.FormattingEnabled = True
        Me.cbPropiedadRemolque1.Location = New System.Drawing.Point(3, 75)
        Me.cbPropiedadRemolque1.Name = "cbPropiedadRemolque1"
        Me.cbPropiedadRemolque1.Size = New System.Drawing.Size(103, 28)
        Me.cbPropiedadRemolque1.TabIndex = 12
        '
        'cbPropiedadRemolque2
        '
        Me.cbPropiedadRemolque2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPropiedadRemolque2.FormattingEnabled = True
        Me.cbPropiedadRemolque2.Location = New System.Drawing.Point(3, 129)
        Me.cbPropiedadRemolque2.Name = "cbPropiedadRemolque2"
        Me.cbPropiedadRemolque2.Size = New System.Drawing.Size(103, 28)
        Me.cbPropiedadRemolque2.TabIndex = 15
        '
        'cbTipoRemolque1
        '
        Me.cbTipoRemolque1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbTipoRemolque1.FormattingEnabled = True
        Me.cbTipoRemolque1.Location = New System.Drawing.Point(309, 75)
        Me.cbTipoRemolque1.Name = "cbTipoRemolque1"
        Me.cbTipoRemolque1.Size = New System.Drawing.Size(191, 28)
        Me.cbTipoRemolque1.TabIndex = 13
        '
        'cbTipoRemolque2
        '
        Me.cbTipoRemolque2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbTipoRemolque2.FormattingEnabled = True
        Me.cbTipoRemolque2.Location = New System.Drawing.Point(309, 129)
        Me.cbTipoRemolque2.Name = "cbTipoRemolque2"
        Me.cbTipoRemolque2.Size = New System.Drawing.Size(191, 28)
        Me.cbTipoRemolque2.TabIndex = 16
        '
        'txtTipoRemolque1
        '
        Me.txtTipoRemolque1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoRemolque1.Location = New System.Drawing.Point(506, 75)
        Me.txtTipoRemolque1.Name = "txtTipoRemolque1"
        Me.txtTipoRemolque1.Size = New System.Drawing.Size(191, 26)
        Me.txtTipoRemolque1.TabIndex = 13
        Me.txtTipoRemolque1.TabStop = False
        '
        'txtTipoRemolque2
        '
        Me.txtTipoRemolque2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoRemolque2.Location = New System.Drawing.Point(506, 129)
        Me.txtTipoRemolque2.Name = "txtTipoRemolque2"
        Me.txtTipoRemolque2.Size = New System.Drawing.Size(191, 26)
        Me.txtTipoRemolque2.TabIndex = 14
        Me.txtTipoRemolque2.TabStop = False
        '
        'txtPlacasRemolque1
        '
        Me.txtPlacasRemolque1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPlacasRemolque1.Location = New System.Drawing.Point(900, 75)
        Me.txtPlacasRemolque1.Name = "txtPlacasRemolque1"
        Me.txtPlacasRemolque1.Size = New System.Drawing.Size(194, 26)
        Me.txtPlacasRemolque1.TabIndex = 14
        '
        'txtPlacasRemolque2
        '
        Me.txtPlacasRemolque2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPlacasRemolque2.Location = New System.Drawing.Point(900, 129)
        Me.txtPlacasRemolque2.Name = "txtPlacasRemolque2"
        Me.txtPlacasRemolque2.Size = New System.Drawing.Size(194, 26)
        Me.txtPlacasRemolque2.TabIndex = 17
        '
        'tlpContenedorSeguroMaterialPeligroso
        '
        Me.tlpContenedorSeguroMaterialPeligroso.ColumnCount = 2
        Me.tlpContenedorSeguroMaterialPeligroso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpContenedorSeguroMaterialPeligroso.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpContenedorSeguroMaterialPeligroso.Controls.Add(Me.Label102, 0, 0)
        Me.tlpContenedorSeguroMaterialPeligroso.Controls.Add(Me.Label103, 0, 1)
        Me.tlpContenedorSeguroMaterialPeligroso.Controls.Add(Me.Label108, 0, 2)
        Me.tlpContenedorSeguroMaterialPeligroso.Controls.Add(Me.txtAseguradoraDanosMedioAmbiente, 1, 1)
        Me.tlpContenedorSeguroMaterialPeligroso.Controls.Add(Me.txtPolizaSegurosDanosMedioAmbiente, 1, 2)
        Me.tlpContenedorSeguroMaterialPeligroso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorSeguroMaterialPeligroso.Location = New System.Drawing.Point(3, 439)
        Me.tlpContenedorSeguroMaterialPeligroso.Name = "tlpContenedorSeguroMaterialPeligroso"
        Me.tlpContenedorSeguroMaterialPeligroso.RowCount = 3
        Me.tlpContenedorSeguroMaterialPeligroso.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpContenedorSeguroMaterialPeligroso.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpContenedorSeguroMaterialPeligroso.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpContenedorSeguroMaterialPeligroso.Size = New System.Drawing.Size(1097, 118)
        Me.tlpContenedorSeguroMaterialPeligroso.TabIndex = 3
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label102.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(3, 0)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(432, 23)
        Me.Label102.TabIndex = 0
        Me.Label102.Text = "Seguro por material peligroso"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(3, 23)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(432, 47)
        Me.Label103.TabIndex = 1
        Me.Label103.Text = "Aseguradora por daños al medio ambiente:"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label108.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(3, 70)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(432, 48)
        Me.Label108.TabIndex = 2
        Me.Label108.Text = "Póliza de seguros por daños al medio ambiente:"
        '
        'txtAseguradoraDanosMedioAmbiente
        '
        Me.txtAseguradoraDanosMedioAmbiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAseguradoraDanosMedioAmbiente.Location = New System.Drawing.Point(441, 26)
        Me.txtAseguradoraDanosMedioAmbiente.Name = "txtAseguradoraDanosMedioAmbiente"
        Me.txtAseguradoraDanosMedioAmbiente.Size = New System.Drawing.Size(653, 26)
        Me.txtAseguradoraDanosMedioAmbiente.TabIndex = 18
        '
        'txtPolizaSegurosDanosMedioAmbiente
        '
        Me.txtPolizaSegurosDanosMedioAmbiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPolizaSegurosDanosMedioAmbiente.Location = New System.Drawing.Point(441, 73)
        Me.txtPolizaSegurosDanosMedioAmbiente.Name = "txtPolizaSegurosDanosMedioAmbiente"
        Me.txtPolizaSegurosDanosMedioAmbiente.Size = New System.Drawing.Size(653, 26)
        Me.txtPolizaSegurosDanosMedioAmbiente.TabIndex = 19
        '
        'tabOperador
        '
        Me.tabOperador.Controls.Add(Me.tlpContenedorPrincipalOperador)
        Me.tabOperador.Location = New System.Drawing.Point(4, 29)
        Me.tabOperador.Name = "tabOperador"
        Me.tabOperador.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOperador.Size = New System.Drawing.Size(1103, 624)
        Me.tabOperador.TabIndex = 6
        Me.tabOperador.Text = "Operador"
        Me.tabOperador.UseVisualStyleBackColor = True
        '
        'tlpContenedorPrincipalOperador
        '
        Me.tlpContenedorPrincipalOperador.ColumnCount = 1
        Me.tlpContenedorPrincipalOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPrincipalOperador.Controls.Add(Me.tlpSeleccionOperador, 0, 0)
        Me.tlpContenedorPrincipalOperador.Controls.Add(Me.tlpDireccionOperador, 0, 2)
        Me.tlpContenedorPrincipalOperador.Controls.Add(Me.tlpAtrasSiguienteOperador, 0, 3)
        Me.tlpContenedorPrincipalOperador.Controls.Add(Me.tlpPartesTransporteOperador, 0, 1)
        Me.tlpContenedorPrincipalOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenedorPrincipalOperador.Location = New System.Drawing.Point(3, 3)
        Me.tlpContenedorPrincipalOperador.Name = "tlpContenedorPrincipalOperador"
        Me.tlpContenedorPrincipalOperador.RowCount = 4
        Me.tlpContenedorPrincipalOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpContenedorPrincipalOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpContenedorPrincipalOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpContenedorPrincipalOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenedorPrincipalOperador.Size = New System.Drawing.Size(1097, 618)
        Me.tlpContenedorPrincipalOperador.TabIndex = 0
        '
        'tlpSeleccionOperador
        '
        Me.tlpSeleccionOperador.BackColor = System.Drawing.Color.White
        Me.tlpSeleccionOperador.ColumnCount = 6
        Me.tlpSeleccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpSeleccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tlpSeleccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tlpSeleccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tlpSeleccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tlpSeleccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tlpSeleccionOperador.Controls.Add(Me.Label109, 0, 0)
        Me.tlpSeleccionOperador.Controls.Add(Me.Label110, 0, 1)
        Me.tlpSeleccionOperador.Controls.Add(Me.Label111, 0, 2)
        Me.tlpSeleccionOperador.Controls.Add(Me.Label112, 0, 3)
        Me.tlpSeleccionOperador.Controls.Add(Me.Label113, 2, 3)
        Me.tlpSeleccionOperador.Controls.Add(Me.Label114, 0, 4)
        Me.tlpSeleccionOperador.Controls.Add(Me.Label115, 2, 4)
        Me.tlpSeleccionOperador.Controls.Add(Me.Label116, 4, 4)
        Me.tlpSeleccionOperador.Controls.Add(Me.Label117, 0, 5)
        Me.tlpSeleccionOperador.Controls.Add(Me.txtRfcOperador, 1, 3)
        Me.tlpSeleccionOperador.Controls.Add(Me.txtNumRegIdTribFiscOperador, 3, 3)
        Me.tlpSeleccionOperador.Controls.Add(Me.txtNombreOperador, 1, 4)
        Me.tlpSeleccionOperador.Controls.Add(Me.txtApPaternoOperador, 3, 4)
        Me.tlpSeleccionOperador.Controls.Add(Me.txtApMaternoOperador, 5, 4)
        Me.tlpSeleccionOperador.Controls.Add(Me.cbTipoFiguraOperador, 1, 5)
        Me.tlpSeleccionOperador.Controls.Add(Me.rbOperadorMexicano, 1, 2)
        Me.tlpSeleccionOperador.Controls.Add(Me.rbOperadorExtranjero, 3, 2)
        Me.tlpSeleccionOperador.Controls.Add(Me.cbOpcionesOperador, 1, 1)
        Me.tlpSeleccionOperador.Controls.Add(Me.Label138, 3, 5)
        Me.tlpSeleccionOperador.Controls.Add(Me.txtNumLicenciaOperador, 4, 5)
        Me.tlpSeleccionOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSeleccionOperador.Location = New System.Drawing.Point(3, 3)
        Me.tlpSeleccionOperador.Name = "tlpSeleccionOperador"
        Me.tlpSeleccionOperador.RowCount = 6
        Me.tlpSeleccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpSeleccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpSeleccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpSeleccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpSeleccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpSeleccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpSeleccionOperador.Size = New System.Drawing.Size(1091, 241)
        Me.tlpSeleccionOperador.TabIndex = 0
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label109.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(3, 0)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(212, 24)
        Me.Label109.TabIndex = 0
        Me.Label109.Text = "Datos del operador:"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.ForeColor = System.Drawing.Color.IndianRed
        Me.Label110.Location = New System.Drawing.Point(3, 24)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(212, 43)
        Me.Label110.TabIndex = 1
        Me.Label110.Text = "Seleccione operador: *"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.Color.IndianRed
        Me.Label111.Location = New System.Drawing.Point(3, 67)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(212, 43)
        Me.Label111.TabIndex = 2
        Me.Label111.Text = "Nacionalidad: *"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label112.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.ForeColor = System.Drawing.Color.IndianRed
        Me.Label112.Location = New System.Drawing.Point(3, 110)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(212, 43)
        Me.Label112.TabIndex = 3
        Me.Label112.Text = "RFC: *"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label113.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.Location = New System.Drawing.Point(395, 110)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(168, 43)
        Me.Label113.TabIndex = 4
        Me.Label113.Text = "Num. RegIdTribFisc:"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.ForeColor = System.Drawing.Color.IndianRed
        Me.Label114.Location = New System.Drawing.Point(3, 153)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(212, 43)
        Me.Label114.TabIndex = 5
        Me.Label114.Text = "Nombre: *"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.ForeColor = System.Drawing.Color.IndianRed
        Me.Label115.Location = New System.Drawing.Point(395, 153)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(168, 43)
        Me.Label115.TabIndex = 6
        Me.Label115.Text = "Ap. paterno: *"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.ForeColor = System.Drawing.Color.IndianRed
        Me.Label116.Location = New System.Drawing.Point(743, 153)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(168, 43)
        Me.Label116.TabIndex = 7
        Me.Label116.Text = "Ap. materno: *"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.ForeColor = System.Drawing.Color.IndianRed
        Me.Label117.Location = New System.Drawing.Point(3, 196)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(212, 45)
        Me.Label117.TabIndex = 8
        Me.Label117.Text = "Tipo figura: *"
        '
        'txtRfcOperador
        '
        Me.txtRfcOperador.BackColor = System.Drawing.Color.White
        Me.txtRfcOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRfcOperador.Location = New System.Drawing.Point(221, 113)
        Me.txtRfcOperador.Name = "txtRfcOperador"
        Me.txtRfcOperador.Size = New System.Drawing.Size(168, 26)
        Me.txtRfcOperador.TabIndex = 3
        '
        'txtNumRegIdTribFiscOperador
        '
        Me.tlpSeleccionOperador.SetColumnSpan(Me.txtNumRegIdTribFiscOperador, 2)
        Me.txtNumRegIdTribFiscOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumRegIdTribFiscOperador.Location = New System.Drawing.Point(569, 113)
        Me.txtNumRegIdTribFiscOperador.Name = "txtNumRegIdTribFiscOperador"
        Me.txtNumRegIdTribFiscOperador.Size = New System.Drawing.Size(342, 26)
        Me.txtNumRegIdTribFiscOperador.TabIndex = 4
        '
        'txtNombreOperador
        '
        Me.txtNombreOperador.BackColor = System.Drawing.Color.White
        Me.txtNombreOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombreOperador.Location = New System.Drawing.Point(221, 156)
        Me.txtNombreOperador.Name = "txtNombreOperador"
        Me.txtNombreOperador.Size = New System.Drawing.Size(168, 26)
        Me.txtNombreOperador.TabIndex = 5
        '
        'txtApPaternoOperador
        '
        Me.txtApPaternoOperador.BackColor = System.Drawing.Color.White
        Me.txtApPaternoOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApPaternoOperador.Location = New System.Drawing.Point(569, 156)
        Me.txtApPaternoOperador.Name = "txtApPaternoOperador"
        Me.txtApPaternoOperador.Size = New System.Drawing.Size(168, 26)
        Me.txtApPaternoOperador.TabIndex = 6
        '
        'txtApMaternoOperador
        '
        Me.txtApMaternoOperador.BackColor = System.Drawing.Color.White
        Me.txtApMaternoOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApMaternoOperador.Location = New System.Drawing.Point(917, 156)
        Me.txtApMaternoOperador.Name = "txtApMaternoOperador"
        Me.txtApMaternoOperador.Size = New System.Drawing.Size(171, 26)
        Me.txtApMaternoOperador.TabIndex = 7
        '
        'cbTipoFiguraOperador
        '
        Me.cbTipoFiguraOperador.BackColor = System.Drawing.Color.White
        Me.cbTipoFiguraOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbTipoFiguraOperador.FormattingEnabled = True
        Me.cbTipoFiguraOperador.Location = New System.Drawing.Point(221, 199)
        Me.cbTipoFiguraOperador.Name = "cbTipoFiguraOperador"
        Me.cbTipoFiguraOperador.Size = New System.Drawing.Size(168, 28)
        Me.cbTipoFiguraOperador.TabIndex = 8
        '
        'rbOperadorMexicano
        '
        Me.rbOperadorMexicano.AutoSize = True
        Me.tlpSeleccionOperador.SetColumnSpan(Me.rbOperadorMexicano, 2)
        Me.rbOperadorMexicano.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbOperadorMexicano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOperadorMexicano.Location = New System.Drawing.Point(221, 70)
        Me.rbOperadorMexicano.Name = "rbOperadorMexicano"
        Me.rbOperadorMexicano.Size = New System.Drawing.Size(342, 37)
        Me.rbOperadorMexicano.TabIndex = 1
        Me.rbOperadorMexicano.TabStop = True
        Me.rbOperadorMexicano.Text = "Operador Mexicano"
        Me.rbOperadorMexicano.UseVisualStyleBackColor = True
        '
        'rbOperadorExtranjero
        '
        Me.rbOperadorExtranjero.AutoSize = True
        Me.tlpSeleccionOperador.SetColumnSpan(Me.rbOperadorExtranjero, 3)
        Me.rbOperadorExtranjero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbOperadorExtranjero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOperadorExtranjero.Location = New System.Drawing.Point(569, 70)
        Me.rbOperadorExtranjero.Name = "rbOperadorExtranjero"
        Me.rbOperadorExtranjero.Size = New System.Drawing.Size(519, 37)
        Me.rbOperadorExtranjero.TabIndex = 2
        Me.rbOperadorExtranjero.TabStop = True
        Me.rbOperadorExtranjero.Text = "Operador Extranjero"
        Me.rbOperadorExtranjero.UseVisualStyleBackColor = True
        '
        'cbOpcionesOperador
        '
        Me.cbOpcionesOperador.BackColor = System.Drawing.Color.White
        Me.tlpSeleccionOperador.SetColumnSpan(Me.cbOpcionesOperador, 3)
        Me.cbOpcionesOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbOpcionesOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOpcionesOperador.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbOpcionesOperador.FormattingEnabled = True
        Me.cbOpcionesOperador.Location = New System.Drawing.Point(221, 27)
        Me.cbOpcionesOperador.Name = "cbOpcionesOperador"
        Me.cbOpcionesOperador.Size = New System.Drawing.Size(516, 28)
        Me.cbOpcionesOperador.TabIndex = 0
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label138.ForeColor = System.Drawing.Color.IndianRed
        Me.Label138.Location = New System.Drawing.Point(569, 196)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(132, 20)
        Me.Label138.TabIndex = 18
        Me.Label138.Text = "Num. licencia: *"
        '
        'txtNumLicenciaOperador
        '
        Me.txtNumLicenciaOperador.BackColor = System.Drawing.Color.White
        Me.tlpSeleccionOperador.SetColumnSpan(Me.txtNumLicenciaOperador, 2)
        Me.txtNumLicenciaOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumLicenciaOperador.Location = New System.Drawing.Point(743, 199)
        Me.txtNumLicenciaOperador.Name = "txtNumLicenciaOperador"
        Me.txtNumLicenciaOperador.Size = New System.Drawing.Size(345, 26)
        Me.txtNumLicenciaOperador.TabIndex = 9
        '
        'tlpDireccionOperador
        '
        Me.tlpDireccionOperador.ColumnCount = 4
        Me.tlpDireccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDireccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDireccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDireccionOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDireccionOperador.Controls.Add(Me.Label118, 0, 0)
        Me.tlpDireccionOperador.Controls.Add(Me.Label119, 0, 1)
        Me.tlpDireccionOperador.Controls.Add(Me.Label120, 2, 1)
        Me.tlpDireccionOperador.Controls.Add(Me.Label121, 0, 2)
        Me.tlpDireccionOperador.Controls.Add(Me.Label122, 2, 2)
        Me.tlpDireccionOperador.Controls.Add(Me.Label123, 0, 3)
        Me.tlpDireccionOperador.Controls.Add(Me.Label124, 2, 3)
        Me.tlpDireccionOperador.Controls.Add(Me.tlpNoIntDomicilioOperador, 2, 4)
        Me.tlpDireccionOperador.Controls.Add(Me.tlpNoExtDomicilioOperador, 3, 4)
        Me.tlpDireccionOperador.Controls.Add(Me.Label125, 0, 4)
        Me.tlpDireccionOperador.Controls.Add(Me.Label126, 0, 5)
        Me.tlpDireccionOperador.Controls.Add(Me.cbPaisOperador, 1, 1)
        Me.tlpDireccionOperador.Controls.Add(Me.cbEstadoOperador, 3, 1)
        Me.tlpDireccionOperador.Controls.Add(Me.cbMunicipioOperador, 1, 2)
        Me.tlpDireccionOperador.Controls.Add(Me.cbLocalidadOperador, 3, 2)
        Me.tlpDireccionOperador.Controls.Add(Me.cbColoniaOperador, 3, 3)
        Me.tlpDireccionOperador.Controls.Add(Me.txtCpOperador, 1, 3)
        Me.tlpDireccionOperador.Controls.Add(Me.txtCalleOperador, 1, 4)
        Me.tlpDireccionOperador.Controls.Add(Me.txtReferenciaOperador, 1, 5)
        Me.tlpDireccionOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDireccionOperador.Location = New System.Drawing.Point(3, 373)
        Me.tlpDireccionOperador.Name = "tlpDireccionOperador"
        Me.tlpDireccionOperador.RowCount = 6
        Me.tlpDireccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpDireccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDireccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDireccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDireccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDireccionOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpDireccionOperador.Size = New System.Drawing.Size(1091, 179)
        Me.tlpDireccionOperador.TabIndex = 1
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label118.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(3, 0)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(266, 17)
        Me.Label118.TabIndex = 0
        Me.Label118.Text = "Domicilio del operador:"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.ForeColor = System.Drawing.Color.IndianRed
        Me.Label119.Location = New System.Drawing.Point(3, 17)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(60, 20)
        Me.Label119.TabIndex = 1
        Me.Label119.Text = "País: *"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.ForeColor = System.Drawing.Color.IndianRed
        Me.Label120.Location = New System.Drawing.Point(547, 17)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(83, 20)
        Me.Label120.TabIndex = 2
        Me.Label120.Text = "Estado: *"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.ForeColor = System.Drawing.Color.IndianRed
        Me.Label121.Location = New System.Drawing.Point(3, 49)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(101, 20)
        Me.Label121.TabIndex = 3
        Me.Label121.Text = "Municipio: *"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.ForeColor = System.Drawing.Color.IndianRed
        Me.Label122.Location = New System.Drawing.Point(547, 49)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(103, 20)
        Me.Label122.TabIndex = 4
        Me.Label122.Text = "Localidad: *"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.ForeColor = System.Drawing.Color.IndianRed
        Me.Label123.Location = New System.Drawing.Point(3, 81)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(49, 20)
        Me.Label123.TabIndex = 5
        Me.Label123.Text = "CP: *"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.ForeColor = System.Drawing.Color.IndianRed
        Me.Label124.Location = New System.Drawing.Point(547, 81)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(86, 20)
        Me.Label124.TabIndex = 6
        Me.Label124.Text = "Colonia: *"
        '
        'tlpNoIntDomicilioOperador
        '
        Me.tlpNoIntDomicilioOperador.ColumnCount = 2
        Me.tlpNoIntDomicilioOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNoIntDomicilioOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNoIntDomicilioOperador.Controls.Add(Me.Label128, 0, 0)
        Me.tlpNoIntDomicilioOperador.Controls.Add(Me.txtNoExtOperador, 1, 0)
        Me.tlpNoIntDomicilioOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNoIntDomicilioOperador.Location = New System.Drawing.Point(547, 116)
        Me.tlpNoIntDomicilioOperador.Name = "tlpNoIntDomicilioOperador"
        Me.tlpNoIntDomicilioOperador.RowCount = 1
        Me.tlpNoIntDomicilioOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNoIntDomicilioOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlpNoIntDomicilioOperador.Size = New System.Drawing.Size(266, 26)
        Me.tlpNoIntDomicilioOperador.TabIndex = 7
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.ForeColor = System.Drawing.Color.IndianRed
        Me.Label128.Location = New System.Drawing.Point(3, 0)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(77, 20)
        Me.Label128.TabIndex = 0
        Me.Label128.Text = "No ext: *"
        '
        'txtNoExtOperador
        '
        Me.txtNoExtOperador.BackColor = System.Drawing.Color.White
        Me.txtNoExtOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoExtOperador.Location = New System.Drawing.Point(136, 3)
        Me.txtNoExtOperador.Name = "txtNoExtOperador"
        Me.txtNoExtOperador.Size = New System.Drawing.Size(127, 26)
        Me.txtNoExtOperador.TabIndex = 19
        '
        'tlpNoExtDomicilioOperador
        '
        Me.tlpNoExtDomicilioOperador.ColumnCount = 2
        Me.tlpNoExtDomicilioOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNoExtDomicilioOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNoExtDomicilioOperador.Controls.Add(Me.Label130, 0, 0)
        Me.tlpNoExtDomicilioOperador.Controls.Add(Me.txtNoIntOperador, 1, 0)
        Me.tlpNoExtDomicilioOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNoExtDomicilioOperador.Location = New System.Drawing.Point(819, 116)
        Me.tlpNoExtDomicilioOperador.Name = "tlpNoExtDomicilioOperador"
        Me.tlpNoExtDomicilioOperador.RowCount = 1
        Me.tlpNoExtDomicilioOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNoExtDomicilioOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlpNoExtDomicilioOperador.Size = New System.Drawing.Size(269, 26)
        Me.tlpNoExtDomicilioOperador.TabIndex = 8
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(3, 0)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(66, 20)
        Me.Label130.TabIndex = 0
        Me.Label130.Text = "No. int:"
        '
        'txtNoIntOperador
        '
        Me.txtNoIntOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoIntOperador.Location = New System.Drawing.Point(137, 3)
        Me.txtNoIntOperador.Name = "txtNoIntOperador"
        Me.txtNoIntOperador.Size = New System.Drawing.Size(129, 26)
        Me.txtNoIntOperador.TabIndex = 20
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.ForeColor = System.Drawing.Color.IndianRed
        Me.Label125.Location = New System.Drawing.Point(3, 113)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(66, 20)
        Me.Label125.TabIndex = 9
        Me.Label125.Text = "Calle: *"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(3, 145)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(102, 20)
        Me.Label126.TabIndex = 10
        Me.Label126.Text = "Referencia:"
        '
        'cbPaisOperador
        '
        Me.cbPaisOperador.BackColor = System.Drawing.Color.White
        Me.cbPaisOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPaisOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaisOperador.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbPaisOperador.FormattingEnabled = True
        Me.cbPaisOperador.Location = New System.Drawing.Point(275, 20)
        Me.cbPaisOperador.Name = "cbPaisOperador"
        Me.cbPaisOperador.Size = New System.Drawing.Size(266, 28)
        Me.cbPaisOperador.TabIndex = 12
        '
        'cbEstadoOperador
        '
        Me.cbEstadoOperador.BackColor = System.Drawing.Color.White
        Me.cbEstadoOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbEstadoOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoOperador.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbEstadoOperador.FormattingEnabled = True
        Me.cbEstadoOperador.Location = New System.Drawing.Point(819, 20)
        Me.cbEstadoOperador.Name = "cbEstadoOperador"
        Me.cbEstadoOperador.Size = New System.Drawing.Size(269, 28)
        Me.cbEstadoOperador.TabIndex = 13
        '
        'cbMunicipioOperador
        '
        Me.cbMunicipioOperador.BackColor = System.Drawing.Color.White
        Me.cbMunicipioOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbMunicipioOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMunicipioOperador.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbMunicipioOperador.FormattingEnabled = True
        Me.cbMunicipioOperador.Location = New System.Drawing.Point(275, 52)
        Me.cbMunicipioOperador.Name = "cbMunicipioOperador"
        Me.cbMunicipioOperador.Size = New System.Drawing.Size(266, 28)
        Me.cbMunicipioOperador.TabIndex = 14
        '
        'cbLocalidadOperador
        '
        Me.cbLocalidadOperador.BackColor = System.Drawing.Color.White
        Me.cbLocalidadOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbLocalidadOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLocalidadOperador.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbLocalidadOperador.FormattingEnabled = True
        Me.cbLocalidadOperador.Location = New System.Drawing.Point(819, 52)
        Me.cbLocalidadOperador.Name = "cbLocalidadOperador"
        Me.cbLocalidadOperador.Size = New System.Drawing.Size(269, 28)
        Me.cbLocalidadOperador.TabIndex = 15
        '
        'cbColoniaOperador
        '
        Me.cbColoniaOperador.BackColor = System.Drawing.Color.White
        Me.cbColoniaOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbColoniaOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColoniaOperador.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbColoniaOperador.FormattingEnabled = True
        Me.cbColoniaOperador.Location = New System.Drawing.Point(819, 84)
        Me.cbColoniaOperador.Name = "cbColoniaOperador"
        Me.cbColoniaOperador.Size = New System.Drawing.Size(269, 28)
        Me.cbColoniaOperador.TabIndex = 17
        '
        'txtCpOperador
        '
        Me.txtCpOperador.BackColor = System.Drawing.Color.White
        Me.txtCpOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCpOperador.Location = New System.Drawing.Point(275, 84)
        Me.txtCpOperador.Name = "txtCpOperador"
        Me.txtCpOperador.Size = New System.Drawing.Size(266, 26)
        Me.txtCpOperador.TabIndex = 16
        '
        'txtCalleOperador
        '
        Me.txtCalleOperador.BackColor = System.Drawing.Color.White
        Me.txtCalleOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCalleOperador.Location = New System.Drawing.Point(275, 116)
        Me.txtCalleOperador.Name = "txtCalleOperador"
        Me.txtCalleOperador.Size = New System.Drawing.Size(266, 26)
        Me.txtCalleOperador.TabIndex = 18
        '
        'txtReferenciaOperador
        '
        Me.tlpDireccionOperador.SetColumnSpan(Me.txtReferenciaOperador, 2)
        Me.txtReferenciaOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReferenciaOperador.Location = New System.Drawing.Point(275, 148)
        Me.txtReferenciaOperador.Name = "txtReferenciaOperador"
        Me.txtReferenciaOperador.Size = New System.Drawing.Size(538, 26)
        Me.txtReferenciaOperador.TabIndex = 21
        '
        'tlpAtrasSiguienteOperador
        '
        Me.tlpAtrasSiguienteOperador.ColumnCount = 3
        Me.tlpAtrasSiguienteOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpAtrasSiguienteOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpAtrasSiguienteOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpAtrasSiguienteOperador.Controls.Add(Me.btnAtrasOperador, 1, 0)
        Me.tlpAtrasSiguienteOperador.Controls.Add(Me.btnSiguienteOperador, 2, 0)
        Me.tlpAtrasSiguienteOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAtrasSiguienteOperador.Location = New System.Drawing.Point(3, 558)
        Me.tlpAtrasSiguienteOperador.Name = "tlpAtrasSiguienteOperador"
        Me.tlpAtrasSiguienteOperador.RowCount = 1
        Me.tlpAtrasSiguienteOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAtrasSiguienteOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.tlpAtrasSiguienteOperador.Size = New System.Drawing.Size(1091, 57)
        Me.tlpAtrasSiguienteOperador.TabIndex = 2
        '
        'btnAtrasOperador
        '
        Me.btnAtrasOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtrasOperador.Location = New System.Drawing.Point(766, 3)
        Me.btnAtrasOperador.Name = "btnAtrasOperador"
        Me.btnAtrasOperador.Size = New System.Drawing.Size(157, 51)
        Me.btnAtrasOperador.TabIndex = 22
        Me.btnAtrasOperador.Text = "Atrás"
        Me.btnAtrasOperador.UseVisualStyleBackColor = True
        '
        'btnSiguienteOperador
        '
        Me.btnSiguienteOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSiguienteOperador.Location = New System.Drawing.Point(929, 3)
        Me.btnSiguienteOperador.Name = "btnSiguienteOperador"
        Me.btnSiguienteOperador.Size = New System.Drawing.Size(159, 51)
        Me.btnSiguienteOperador.TabIndex = 23
        Me.btnSiguienteOperador.Text = "Siguiente"
        Me.btnSiguienteOperador.UseVisualStyleBackColor = True
        '
        'tlpPartesTransporteOperador
        '
        Me.tlpPartesTransporteOperador.ColumnCount = 3
        Me.tlpPartesTransporteOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPartesTransporteOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpPartesTransporteOperador.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpPartesTransporteOperador.Controls.Add(Me.Label127, 0, 0)
        Me.tlpPartesTransporteOperador.Controls.Add(Me.Label129, 0, 1)
        Me.tlpPartesTransporteOperador.Controls.Add(Me.cbParteTransporteOperador, 1, 1)
        Me.tlpPartesTransporteOperador.Controls.Add(Me.btnAnadirParteTransporte, 1, 2)
        Me.tlpPartesTransporteOperador.Controls.Add(Me.gvParteTransporteOperador, 2, 1)
        Me.tlpPartesTransporteOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPartesTransporteOperador.Location = New System.Drawing.Point(3, 250)
        Me.tlpPartesTransporteOperador.Name = "tlpPartesTransporteOperador"
        Me.tlpPartesTransporteOperador.RowCount = 3
        Me.tlpPartesTransporteOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPartesTransporteOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tlpPartesTransporteOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpPartesTransporteOperador.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPartesTransporteOperador.Size = New System.Drawing.Size(1091, 117)
        Me.tlpPartesTransporteOperador.TabIndex = 3
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(3, 0)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(212, 17)
        Me.Label127.TabIndex = 0
        Me.Label127.Text = "Partes transporte:"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.Location = New System.Drawing.Point(3, 17)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(102, 20)
        Me.Label129.TabIndex = 2
        Me.Label129.Text = "Seleccione:"
        '
        'cbParteTransporteOperador
        '
        Me.cbParteTransporteOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbParteTransporteOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbParteTransporteOperador.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbParteTransporteOperador.FormattingEnabled = True
        Me.cbParteTransporteOperador.Location = New System.Drawing.Point(221, 20)
        Me.cbParteTransporteOperador.Name = "cbParteTransporteOperador"
        Me.cbParteTransporteOperador.Size = New System.Drawing.Size(430, 28)
        Me.cbParteTransporteOperador.TabIndex = 10
        '
        'btnAnadirParteTransporte
        '
        Me.btnAnadirParteTransporte.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAnadirParteTransporte.Location = New System.Drawing.Point(517, 72)
        Me.btnAnadirParteTransporte.Name = "btnAnadirParteTransporte"
        Me.btnAnadirParteTransporte.Size = New System.Drawing.Size(134, 42)
        Me.btnAnadirParteTransporte.TabIndex = 11
        Me.btnAnadirParteTransporte.Text = "Añadir"
        Me.btnAnadirParteTransporte.UseVisualStyleBackColor = True
        '
        'gvParteTransporteOperador
        '
        Me.gvParteTransporteOperador.AllowUserToAddRows = False
        Me.gvParteTransporteOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvParteTransporteOperador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParteTransporteAnadidoClm, Me.EliminarParteTransporteClm})
        Me.gvParteTransporteOperador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvParteTransporteOperador.Location = New System.Drawing.Point(657, 20)
        Me.gvParteTransporteOperador.Name = "gvParteTransporteOperador"
        Me.gvParteTransporteOperador.RowHeadersVisible = False
        Me.gvParteTransporteOperador.RowHeadersWidth = 62
        Me.tlpPartesTransporteOperador.SetRowSpan(Me.gvParteTransporteOperador, 2)
        Me.gvParteTransporteOperador.RowTemplate.Height = 28
        Me.gvParteTransporteOperador.Size = New System.Drawing.Size(431, 94)
        Me.gvParteTransporteOperador.TabIndex = 5
        Me.gvParteTransporteOperador.TabStop = False
        '
        'ParteTransporteAnadidoClm
        '
        Me.ParteTransporteAnadidoClm.HeaderText = "Parte Transporte"
        Me.ParteTransporteAnadidoClm.MinimumWidth = 8
        Me.ParteTransporteAnadidoClm.Name = "ParteTransporteAnadidoClm"
        Me.ParteTransporteAnadidoClm.Width = 150
        '
        'EliminarParteTransporteClm
        '
        Me.EliminarParteTransporteClm.HeaderText = "Eliminar"
        Me.EliminarParteTransporteClm.MinimumWidth = 8
        Me.EliminarParteTransporteClm.Name = "EliminarParteTransporteClm"
        Me.EliminarParteTransporteClm.Text = "Eliminar"
        Me.EliminarParteTransporteClm.ToolTipText = "Eliminar esta parte de transporte"
        Me.EliminarParteTransporteClm.UseColumnTextForButtonValue = True
        Me.EliminarParteTransporteClm.Width = 150
        '
        'tabConfirmacion
        '
        Me.tabConfirmacion.Controls.Add(Me.tlpPrincipalConfirmacion)
        Me.tabConfirmacion.Location = New System.Drawing.Point(4, 29)
        Me.tabConfirmacion.Name = "tabConfirmacion"
        Me.tabConfirmacion.Size = New System.Drawing.Size(1103, 624)
        Me.tabConfirmacion.TabIndex = 5
        Me.tabConfirmacion.Text = "Confirmación"
        Me.tabConfirmacion.UseVisualStyleBackColor = True
        '
        'tlpPrincipalConfirmacion
        '
        Me.tlpPrincipalConfirmacion.ColumnCount = 1
        Me.tlpPrincipalConfirmacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipalConfirmacion.Controls.Add(Me.Label131, 0, 0)
        Me.tlpPrincipalConfirmacion.Controls.Add(Me.tlpUbicacionesConfirmacion, 0, 1)
        Me.tlpPrincipalConfirmacion.Controls.Add(Me.tlpMercanciasSinAsignar, 0, 3)
        Me.tlpPrincipalConfirmacion.Controls.Add(Me.tlpRelacionMercanciaUbicaciones, 0, 2)
        Me.tlpPrincipalConfirmacion.Controls.Add(Me.tlpDatosFinalesCarga, 0, 4)
        Me.tlpPrincipalConfirmacion.Controls.Add(Me.tlpBotonesGenerarAtras, 0, 5)
        Me.tlpPrincipalConfirmacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipalConfirmacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpPrincipalConfirmacion.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipalConfirmacion.Name = "tlpPrincipalConfirmacion"
        Me.tlpPrincipalConfirmacion.RowCount = 6
        Me.tlpPrincipalConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpPrincipalConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPrincipalConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPrincipalConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPrincipalConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipalConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipalConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPrincipalConfirmacion.Size = New System.Drawing.Size(1103, 624)
        Me.tlpPrincipalConfirmacion.TabIndex = 0
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label131.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.Location = New System.Drawing.Point(3, 0)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(1097, 31)
        Me.Label131.TabIndex = 0
        Me.Label131.Text = "Confirmación - Asignación de destino a mercancías"
        '
        'tlpUbicacionesConfirmacion
        '
        Me.tlpUbicacionesConfirmacion.ColumnCount = 1
        Me.tlpUbicacionesConfirmacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUbicacionesConfirmacion.Controls.Add(Me.Label132, 0, 0)
        Me.tlpUbicacionesConfirmacion.Controls.Add(Me.dgvConfirmacionUbicaciones, 0, 1)
        Me.tlpUbicacionesConfirmacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUbicacionesConfirmacion.Location = New System.Drawing.Point(3, 34)
        Me.tlpUbicacionesConfirmacion.Name = "tlpUbicacionesConfirmacion"
        Me.tlpUbicacionesConfirmacion.RowCount = 2
        Me.tlpUbicacionesConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpUbicacionesConfirmacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpUbicacionesConfirmacion.Size = New System.Drawing.Size(1097, 150)
        Me.tlpUbicacionesConfirmacion.TabIndex = 1
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.Location = New System.Drawing.Point(3, 0)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(1091, 30)
        Me.Label132.TabIndex = 0
        Me.Label132.Text = "Ubicaciones:"
        '
        'dgvConfirmacionUbicaciones
        '
        Me.dgvConfirmacionUbicaciones.AllowUserToAddRows = False
        Me.dgvConfirmacionUbicaciones.AllowUserToDeleteRows = False
        Me.dgvConfirmacionUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConfirmacionUbicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUbicacionClmMercMov, Me.DestinoUbiClm, Me.TipoDestinoPestUbiClm, Me.PestanaFinalVerDetallesClm})
        Me.dgvConfirmacionUbicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvConfirmacionUbicaciones.Location = New System.Drawing.Point(3, 33)
        Me.dgvConfirmacionUbicaciones.Name = "dgvConfirmacionUbicaciones"
        Me.dgvConfirmacionUbicaciones.RowHeadersVisible = False
        Me.dgvConfirmacionUbicaciones.RowHeadersWidth = 62
        Me.dgvConfirmacionUbicaciones.RowTemplate.Height = 28
        Me.dgvConfirmacionUbicaciones.Size = New System.Drawing.Size(1091, 114)
        Me.dgvConfirmacionUbicaciones.TabIndex = 1
        Me.dgvConfirmacionUbicaciones.TabStop = False
        '
        'IdUbicacionClmMercMov
        '
        Me.IdUbicacionClmMercMov.HeaderText = "IdUbicacion"
        Me.IdUbicacionClmMercMov.MinimumWidth = 8
        Me.IdUbicacionClmMercMov.Name = "IdUbicacionClmMercMov"
        Me.IdUbicacionClmMercMov.ReadOnly = True
        Me.IdUbicacionClmMercMov.Width = 150
        '
        'DestinoUbiClm
        '
        Me.DestinoUbiClm.HeaderText = "Destino"
        Me.DestinoUbiClm.MinimumWidth = 8
        Me.DestinoUbiClm.Name = "DestinoUbiClm"
        Me.DestinoUbiClm.ReadOnly = True
        Me.DestinoUbiClm.Width = 150
        '
        'TipoDestinoPestUbiClm
        '
        Me.TipoDestinoPestUbiClm.HeaderText = "Tipo de movimiento"
        Me.TipoDestinoPestUbiClm.MinimumWidth = 8
        Me.TipoDestinoPestUbiClm.Name = "TipoDestinoPestUbiClm"
        Me.TipoDestinoPestUbiClm.ReadOnly = True
        Me.TipoDestinoPestUbiClm.Width = 150
        '
        'PestanaFinalVerDetallesClm
        '
        Me.PestanaFinalVerDetallesClm.HeaderText = "Ver carga"
        Me.PestanaFinalVerDetallesClm.MinimumWidth = 8
        Me.PestanaFinalVerDetallesClm.Name = "PestanaFinalVerDetallesClm"
        Me.PestanaFinalVerDetallesClm.ToolTipText = "Ver detalles de la carga de la mercancía"
        Me.PestanaFinalVerDetallesClm.UseColumnTextForButtonValue = True
        Me.PestanaFinalVerDetallesClm.Width = 150
        '
        'tlpMercanciasSinAsignar
        '
        Me.tlpMercanciasSinAsignar.ColumnCount = 1
        Me.tlpMercanciasSinAsignar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMercanciasSinAsignar.Controls.Add(Me.Label133, 0, 0)
        Me.tlpMercanciasSinAsignar.Controls.Add(Me.dgvMercanciasSinUbicaciones, 0, 1)
        Me.tlpMercanciasSinAsignar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMercanciasSinAsignar.Location = New System.Drawing.Point(3, 346)
        Me.tlpMercanciasSinAsignar.Name = "tlpMercanciasSinAsignar"
        Me.tlpMercanciasSinAsignar.RowCount = 2
        Me.tlpMercanciasSinAsignar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMercanciasSinAsignar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpMercanciasSinAsignar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMercanciasSinAsignar.Size = New System.Drawing.Size(1097, 150)
        Me.tlpMercanciasSinAsignar.TabIndex = 2
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.Location = New System.Drawing.Point(3, 0)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(197, 20)
        Me.Label133.TabIndex = 0
        Me.Label133.Text = "Mercancías sin asignar:"
        '
        'dgvMercanciasSinUbicaciones
        '
        Me.dgvMercanciasSinUbicaciones.AllowUserToAddRows = False
        Me.dgvMercanciasSinUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMercanciasSinUbicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AsignarClaveProdServClm, Me.AsignarDescripcionMercClm, Me.AsignarClaveUnidadClm, Me.AsignarDescUnidadClm, Me.AsignarPeligrosoClm, Me.AsignarCantidadRestanteClm, Me.AsignarCantidadParaAsignarClm, Me.AsignarDestinoAccionClm})
        Me.dgvMercanciasSinUbicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMercanciasSinUbicaciones.Location = New System.Drawing.Point(3, 33)
        Me.dgvMercanciasSinUbicaciones.Name = "dgvMercanciasSinUbicaciones"
        Me.dgvMercanciasSinUbicaciones.RowHeadersVisible = False
        Me.dgvMercanciasSinUbicaciones.RowHeadersWidth = 62
        Me.dgvMercanciasSinUbicaciones.RowTemplate.Height = 28
        Me.dgvMercanciasSinUbicaciones.Size = New System.Drawing.Size(1091, 114)
        Me.dgvMercanciasSinUbicaciones.TabIndex = 1
        Me.dgvMercanciasSinUbicaciones.TabStop = False
        '
        'AsignarClaveProdServClm
        '
        Me.AsignarClaveProdServClm.HeaderText = "ClaveProdServ"
        Me.AsignarClaveProdServClm.MinimumWidth = 8
        Me.AsignarClaveProdServClm.Name = "AsignarClaveProdServClm"
        Me.AsignarClaveProdServClm.ReadOnly = True
        Me.AsignarClaveProdServClm.Width = 150
        '
        'AsignarDescripcionMercClm
        '
        Me.AsignarDescripcionMercClm.HeaderText = "Descripcion"
        Me.AsignarDescripcionMercClm.MinimumWidth = 8
        Me.AsignarDescripcionMercClm.Name = "AsignarDescripcionMercClm"
        Me.AsignarDescripcionMercClm.ReadOnly = True
        Me.AsignarDescripcionMercClm.Width = 150
        '
        'AsignarClaveUnidadClm
        '
        Me.AsignarClaveUnidadClm.HeaderText = "ClaveUnidad"
        Me.AsignarClaveUnidadClm.MinimumWidth = 8
        Me.AsignarClaveUnidadClm.Name = "AsignarClaveUnidadClm"
        Me.AsignarClaveUnidadClm.ReadOnly = True
        Me.AsignarClaveUnidadClm.Width = 150
        '
        'AsignarDescUnidadClm
        '
        Me.AsignarDescUnidadClm.HeaderText = "Unidad"
        Me.AsignarDescUnidadClm.MinimumWidth = 8
        Me.AsignarDescUnidadClm.Name = "AsignarDescUnidadClm"
        Me.AsignarDescUnidadClm.ReadOnly = True
        Me.AsignarDescUnidadClm.Width = 150
        '
        'AsignarPeligrosoClm
        '
        Me.AsignarPeligrosoClm.HeaderText = "¿Peligroso?"
        Me.AsignarPeligrosoClm.MinimumWidth = 8
        Me.AsignarPeligrosoClm.Name = "AsignarPeligrosoClm"
        Me.AsignarPeligrosoClm.ReadOnly = True
        Me.AsignarPeligrosoClm.Width = 150
        '
        'AsignarCantidadRestanteClm
        '
        Me.AsignarCantidadRestanteClm.HeaderText = "Cantidad sin asignar"
        Me.AsignarCantidadRestanteClm.MinimumWidth = 8
        Me.AsignarCantidadRestanteClm.Name = "AsignarCantidadRestanteClm"
        Me.AsignarCantidadRestanteClm.ReadOnly = True
        Me.AsignarCantidadRestanteClm.Width = 150
        '
        'AsignarCantidadParaAsignarClm
        '
        Me.AsignarCantidadParaAsignarClm.HeaderText = "Cantidad a asignar"
        Me.AsignarCantidadParaAsignarClm.MinimumWidth = 8
        Me.AsignarCantidadParaAsignarClm.Name = "AsignarCantidadParaAsignarClm"
        Me.AsignarCantidadParaAsignarClm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AsignarCantidadParaAsignarClm.Width = 150
        '
        'AsignarDestinoAccionClm
        '
        Me.AsignarDestinoAccionClm.HeaderText = "Realizar asignación"
        Me.AsignarDestinoAccionClm.MinimumWidth = 8
        Me.AsignarDestinoAccionClm.Name = "AsignarDestinoAccionClm"
        Me.AsignarDestinoAccionClm.Width = 150
        '
        'tlpRelacionMercanciaUbicaciones
        '
        Me.tlpRelacionMercanciaUbicaciones.ColumnCount = 1
        Me.tlpRelacionMercanciaUbicaciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRelacionMercanciaUbicaciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpRelacionMercanciaUbicaciones.Controls.Add(Me.Label134, 0, 0)
        Me.tlpRelacionMercanciaUbicaciones.Controls.Add(Me.dgvRelacionMercanciaUbicaciones, 0, 1)
        Me.tlpRelacionMercanciaUbicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRelacionMercanciaUbicaciones.Location = New System.Drawing.Point(3, 190)
        Me.tlpRelacionMercanciaUbicaciones.Name = "tlpRelacionMercanciaUbicaciones"
        Me.tlpRelacionMercanciaUbicaciones.RowCount = 2
        Me.tlpRelacionMercanciaUbicaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpRelacionMercanciaUbicaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpRelacionMercanciaUbicaciones.Size = New System.Drawing.Size(1097, 150)
        Me.tlpRelacionMercanciaUbicaciones.TabIndex = 3
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Location = New System.Drawing.Point(3, 0)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(272, 20)
        Me.Label134.TabIndex = 0
        Me.Label134.Text = "Relación mercancía a ubicación: "
        '
        'dgvRelacionMercanciaUbicaciones
        '
        Me.dgvRelacionMercanciaUbicaciones.AllowUserToAddRows = False
        Me.dgvRelacionMercanciaUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRelacionMercanciaUbicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RelMercUbiIdUbiClm, Me.RelMercUbiClaveProdServClm, Me.RelMercUbiDescMercClm, Me.RelMercUbiClaveUnidadClm, Me.RelMercUbiDescUnidadClm, Me.RelacionMercUbiPeligrosaClm, Me.RelMercUbiCantidadClm, Me.RelMercUbiBtnEliminarClm, Me.RelMercUbiCantidadMaxima})
        Me.dgvRelacionMercanciaUbicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRelacionMercanciaUbicaciones.Location = New System.Drawing.Point(3, 33)
        Me.dgvRelacionMercanciaUbicaciones.Name = "dgvRelacionMercanciaUbicaciones"
        Me.dgvRelacionMercanciaUbicaciones.RowHeadersVisible = False
        Me.dgvRelacionMercanciaUbicaciones.RowHeadersWidth = 62
        Me.dgvRelacionMercanciaUbicaciones.RowTemplate.Height = 28
        Me.dgvRelacionMercanciaUbicaciones.Size = New System.Drawing.Size(1091, 114)
        Me.dgvRelacionMercanciaUbicaciones.TabIndex = 1
        Me.dgvRelacionMercanciaUbicaciones.TabStop = False
        '
        'RelMercUbiIdUbiClm
        '
        Me.RelMercUbiIdUbiClm.HeaderText = "IdUbicacion"
        Me.RelMercUbiIdUbiClm.MinimumWidth = 8
        Me.RelMercUbiIdUbiClm.Name = "RelMercUbiIdUbiClm"
        Me.RelMercUbiIdUbiClm.ReadOnly = True
        Me.RelMercUbiIdUbiClm.Width = 150
        '
        'RelMercUbiClaveProdServClm
        '
        Me.RelMercUbiClaveProdServClm.HeaderText = "ClaveProdServ"
        Me.RelMercUbiClaveProdServClm.MinimumWidth = 8
        Me.RelMercUbiClaveProdServClm.Name = "RelMercUbiClaveProdServClm"
        Me.RelMercUbiClaveProdServClm.ReadOnly = True
        Me.RelMercUbiClaveProdServClm.Width = 150
        '
        'RelMercUbiDescMercClm
        '
        Me.RelMercUbiDescMercClm.HeaderText = "Mercancía"
        Me.RelMercUbiDescMercClm.MinimumWidth = 8
        Me.RelMercUbiDescMercClm.Name = "RelMercUbiDescMercClm"
        Me.RelMercUbiDescMercClm.ReadOnly = True
        Me.RelMercUbiDescMercClm.Width = 150
        '
        'RelMercUbiClaveUnidadClm
        '
        Me.RelMercUbiClaveUnidadClm.HeaderText = "ClaveUnidad"
        Me.RelMercUbiClaveUnidadClm.MinimumWidth = 8
        Me.RelMercUbiClaveUnidadClm.Name = "RelMercUbiClaveUnidadClm"
        Me.RelMercUbiClaveUnidadClm.ReadOnly = True
        Me.RelMercUbiClaveUnidadClm.Width = 150
        '
        'RelMercUbiDescUnidadClm
        '
        Me.RelMercUbiDescUnidadClm.HeaderText = "DescripcionUnidad"
        Me.RelMercUbiDescUnidadClm.MinimumWidth = 8
        Me.RelMercUbiDescUnidadClm.Name = "RelMercUbiDescUnidadClm"
        Me.RelMercUbiDescUnidadClm.ReadOnly = True
        Me.RelMercUbiDescUnidadClm.Width = 150
        '
        'RelacionMercUbiPeligrosaClm
        '
        Me.RelacionMercUbiPeligrosaClm.HeaderText = "¿Peligrosa?"
        Me.RelacionMercUbiPeligrosaClm.MinimumWidth = 8
        Me.RelacionMercUbiPeligrosaClm.Name = "RelacionMercUbiPeligrosaClm"
        Me.RelacionMercUbiPeligrosaClm.ReadOnly = True
        Me.RelacionMercUbiPeligrosaClm.Width = 150
        '
        'RelMercUbiCantidadClm
        '
        Me.RelMercUbiCantidadClm.HeaderText = "Cantidad a remover"
        Me.RelMercUbiCantidadClm.MinimumWidth = 8
        Me.RelMercUbiCantidadClm.Name = "RelMercUbiCantidadClm"
        Me.RelMercUbiCantidadClm.Width = 150
        '
        'RelMercUbiBtnEliminarClm
        '
        Me.RelMercUbiBtnEliminarClm.HeaderText = "Remover"
        Me.RelMercUbiBtnEliminarClm.MinimumWidth = 8
        Me.RelMercUbiBtnEliminarClm.Name = "RelMercUbiBtnEliminarClm"
        Me.RelMercUbiBtnEliminarClm.Text = "Remover"
        Me.RelMercUbiBtnEliminarClm.ToolTipText = "Remueve la mercancía de este destino"
        Me.RelMercUbiBtnEliminarClm.UseColumnTextForButtonValue = True
        Me.RelMercUbiBtnEliminarClm.Width = 150
        '
        'RelMercUbiCantidadMaxima
        '
        Me.RelMercUbiCantidadMaxima.HeaderText = "CantidadMaxima"
        Me.RelMercUbiCantidadMaxima.MinimumWidth = 8
        Me.RelMercUbiCantidadMaxima.Name = "RelMercUbiCantidadMaxima"
        Me.RelMercUbiCantidadMaxima.ReadOnly = True
        Me.RelMercUbiCantidadMaxima.Visible = False
        Me.RelMercUbiCantidadMaxima.Width = 150
        '
        'tlpDatosFinalesCarga
        '
        Me.tlpDatosFinalesCarga.ColumnCount = 6
        Me.tlpDatosFinalesCarga.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5!))
        Me.tlpDatosFinalesCarga.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5!))
        Me.tlpDatosFinalesCarga.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5!))
        Me.tlpDatosFinalesCarga.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5!))
        Me.tlpDatosFinalesCarga.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.tlpDatosFinalesCarga.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.tlpDatosFinalesCarga.Controls.Add(Me.Label135, 0, 0)
        Me.tlpDatosFinalesCarga.Controls.Add(Me.Label136, 2, 0)
        Me.tlpDatosFinalesCarga.Controls.Add(Me.txtPesoBrutoTotalMercancias, 1, 0)
        Me.tlpDatosFinalesCarga.Controls.Add(Me.txtUnidadPesoTotalMercancias, 3, 0)
        Me.tlpDatosFinalesCarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDatosFinalesCarga.Location = New System.Drawing.Point(3, 502)
        Me.tlpDatosFinalesCarga.Name = "tlpDatosFinalesCarga"
        Me.tlpDatosFinalesCarga.RowCount = 1
        Me.tlpDatosFinalesCarga.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDatosFinalesCarga.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpDatosFinalesCarga.Size = New System.Drawing.Size(1097, 56)
        Me.tlpDatosFinalesCarga.TabIndex = 4
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label135.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label135.ForeColor = System.Drawing.Color.IndianRed
        Me.Label135.Location = New System.Drawing.Point(3, 0)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(175, 56)
        Me.Label135.TabIndex = 0
        Me.Label135.Text = "Peso bruto total: *"
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label136.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label136.ForeColor = System.Drawing.Color.IndianRed
        Me.Label136.Location = New System.Drawing.Point(365, 0)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(175, 56)
        Me.Label136.TabIndex = 1
        Me.Label136.Text = "Unidad peso: *"
        '
        'txtPesoBrutoTotalMercancias
        '
        Me.txtPesoBrutoTotalMercancias.BackColor = System.Drawing.Color.White
        Me.txtPesoBrutoTotalMercancias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPesoBrutoTotalMercancias.Location = New System.Drawing.Point(184, 3)
        Me.txtPesoBrutoTotalMercancias.Name = "txtPesoBrutoTotalMercancias"
        Me.txtPesoBrutoTotalMercancias.Size = New System.Drawing.Size(175, 26)
        Me.txtPesoBrutoTotalMercancias.TabIndex = 0
        '
        'txtUnidadPesoTotalMercancias
        '
        Me.txtUnidadPesoTotalMercancias.BackColor = System.Drawing.Color.White
        Me.txtUnidadPesoTotalMercancias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUnidadPesoTotalMercancias.Location = New System.Drawing.Point(546, 3)
        Me.txtUnidadPesoTotalMercancias.Name = "txtUnidadPesoTotalMercancias"
        Me.txtUnidadPesoTotalMercancias.Size = New System.Drawing.Size(175, 26)
        Me.txtUnidadPesoTotalMercancias.TabIndex = 1
        '
        'tlpBotonesGenerarAtras
        '
        Me.tlpBotonesGenerarAtras.ColumnCount = 3
        Me.tlpBotonesGenerarAtras.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpBotonesGenerarAtras.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpBotonesGenerarAtras.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpBotonesGenerarAtras.Controls.Add(Me.btnAtrasConfirmacion, 1, 0)
        Me.tlpBotonesGenerarAtras.Controls.Add(Me.btnGenerarCartaPorte, 2, 0)
        Me.tlpBotonesGenerarAtras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotonesGenerarAtras.Location = New System.Drawing.Point(3, 564)
        Me.tlpBotonesGenerarAtras.Name = "tlpBotonesGenerarAtras"
        Me.tlpBotonesGenerarAtras.RowCount = 1
        Me.tlpBotonesGenerarAtras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBotonesGenerarAtras.Size = New System.Drawing.Size(1097, 57)
        Me.tlpBotonesGenerarAtras.TabIndex = 5
        '
        'btnAtrasConfirmacion
        '
        Me.btnAtrasConfirmacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAtrasConfirmacion.Location = New System.Drawing.Point(770, 3)
        Me.btnAtrasConfirmacion.Name = "btnAtrasConfirmacion"
        Me.btnAtrasConfirmacion.Size = New System.Drawing.Size(158, 51)
        Me.btnAtrasConfirmacion.TabIndex = 2
        Me.btnAtrasConfirmacion.Text = "Atrás"
        Me.btnAtrasConfirmacion.UseVisualStyleBackColor = True
        '
        'btnGenerarCartaPorte
        '
        Me.btnGenerarCartaPorte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGenerarCartaPorte.Location = New System.Drawing.Point(934, 3)
        Me.btnGenerarCartaPorte.Name = "btnGenerarCartaPorte"
        Me.btnGenerarCartaPorte.Size = New System.Drawing.Size(160, 51)
        Me.btnGenerarCartaPorte.TabIndex = 3
        Me.btnGenerarCartaPorte.Text = "Generar carta porte"
        Me.btnGenerarCartaPorte.UseVisualStyleBackColor = True
        '
        'frmCartaPorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 657)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCartaPorte"
        Me.TabControl1.ResumeLayout(False)
        Me.tabOrigen.ResumeLayout(False)
        Me.tlpPrincipalOrigen.ResumeLayout(False)
        Me.tlpContenedorDatosFiscalesOrigen.ResumeLayout(False)
        Me.tlpContenedorDatosFiscalesOrigen.PerformLayout()
        Me.gbOrigenPersonaFisicaMoral.ResumeLayout(False)
        Me.gbOrigenPersonaFisicaMoral.PerformLayout()
        Me.tlpDetalleDomicilioOrigen.ResumeLayout(False)
        Me.tlpDetalleDomicilioOrigen.PerformLayout()
        Me.tabDestino.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tlpDatosDestino.ResumeLayout(False)
        Me.tlpDatosDestino.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tlpHoraLlegadaDestino.ResumeLayout(False)
        Me.tlpHoraLlegadaDestino.PerformLayout()
        Me.tlpNumKilometros.ResumeLayout(False)
        Me.tlpNumKilometros.PerformLayout()
        CType(Me.nupKmRecorridos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpDetallesDestino.ResumeLayout(False)
        Me.tlpDetallesDestino.PerformLayout()
        Me.tlpBotonesSiguienteAtrasDestino.ResumeLayout(False)
        Me.tabDestinosIntermedios.ResumeLayout(False)
        Me.tlpMainDestinosIntermedios.ResumeLayout(False)
        Me.tlpDetallesDestinoIntermedio.ResumeLayout(False)
        Me.tlpDetallesDestinoIntermedio.PerformLayout()
        Me.tlpDatosFiscalesDestinoIntermedio.ResumeLayout(False)
        Me.tlpDatosFiscalesDestinoIntermedio.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tlpHoraLlegadaDestinoIntermedio.ResumeLayout(False)
        Me.tlpHoraLlegadaDestinoIntermedio.PerformLayout()
        Me.tlpKmDestinoIntermedio.ResumeLayout(False)
        Me.tlpKmDestinoIntermedio.PerformLayout()
        CType(Me.nupKmDestinoIntermedio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpGridDestinosIntermedios.ResumeLayout(False)
        Me.tlpGridDestinosIntermedios.PerformLayout()
        CType(Me.dgvCartaPorteDestinosIntermedios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpBotonesSiguienteAtrasDestinosIntermedios.ResumeLayout(False)
        Me.tabMercancias.ResumeLayout(False)
        Me.tlpPrincipalMercancias.ResumeLayout(False)
        Me.tlpContenedorGridMovimientosPestanaMercancias.ResumeLayout(False)
        Me.tlpContenedorGridMovimientosPestanaMercancias.PerformLayout()
        CType(Me.dgvListadoMovimientosPestanaMercancia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.ResumeLayout(False)
        Me.tlpContenedorMercanciasDelMovimientoPestanaMercancias.PerformLayout()
        CType(Me.dgvMercanciasPorMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpDetallesMercancia.ResumeLayout(False)
        Me.tlpDetallesMercancia.PerformLayout()
        Me.tlpContenedorAltura.ResumeLayout(False)
        Me.tlpContenedorAltura.PerformLayout()
        CType(Me.numAnchura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpContenedorAnchura.ResumeLayout(False)
        Me.tlpContenedorAnchura.PerformLayout()
        CType(Me.numAltura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpContenedorLongitud.ResumeLayout(False)
        Me.tlpContenedorLongitud.PerformLayout()
        CType(Me.numLongitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMaterialPeligroso.ResumeLayout(False)
        Me.pnlMaterialPeligroso.PerformLayout()
        Me.pnlComercioInternacional.ResumeLayout(False)
        Me.pnlComercioInternacional.PerformLayout()
        Me.tlpSiguienteAtrasMercancias.ResumeLayout(False)
        Me.tabTransporte.ResumeLayout(False)
        Me.tlpContenedorPrincipalTransporte.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.tlpContenedorDatosTransporte.ResumeLayout(False)
        Me.tlpContenedorDatosTransporte.PerformLayout()
        Me.tlpContenedorPoliza.ResumeLayout(False)
        Me.tlpContenedorPoliza.PerformLayout()
        Me.tlpContenedorPrimaSeguro.ResumeLayout(False)
        Me.tlpContenedorPrimaSeguro.PerformLayout()
        Me.tlpContenedorRemolques.ResumeLayout(False)
        Me.tlpContenedorRemolques.PerformLayout()
        CType(Me.numCantidadRemolquesTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpContenedorSeguroMaterialPeligroso.ResumeLayout(False)
        Me.tlpContenedorSeguroMaterialPeligroso.PerformLayout()
        Me.tabOperador.ResumeLayout(False)
        Me.tlpContenedorPrincipalOperador.ResumeLayout(False)
        Me.tlpSeleccionOperador.ResumeLayout(False)
        Me.tlpSeleccionOperador.PerformLayout()
        Me.tlpDireccionOperador.ResumeLayout(False)
        Me.tlpDireccionOperador.PerformLayout()
        Me.tlpNoIntDomicilioOperador.ResumeLayout(False)
        Me.tlpNoIntDomicilioOperador.PerformLayout()
        Me.tlpNoExtDomicilioOperador.ResumeLayout(False)
        Me.tlpNoExtDomicilioOperador.PerformLayout()
        Me.tlpAtrasSiguienteOperador.ResumeLayout(False)
        Me.tlpPartesTransporteOperador.ResumeLayout(False)
        Me.tlpPartesTransporteOperador.PerformLayout()
        CType(Me.gvParteTransporteOperador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConfirmacion.ResumeLayout(False)
        Me.tlpPrincipalConfirmacion.ResumeLayout(False)
        Me.tlpPrincipalConfirmacion.PerformLayout()
        Me.tlpUbicacionesConfirmacion.ResumeLayout(False)
        Me.tlpUbicacionesConfirmacion.PerformLayout()
        CType(Me.dgvConfirmacionUbicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMercanciasSinAsignar.ResumeLayout(False)
        Me.tlpMercanciasSinAsignar.PerformLayout()
        CType(Me.dgvMercanciasSinUbicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpRelacionMercanciaUbicaciones.ResumeLayout(False)
        Me.tlpRelacionMercanciaUbicaciones.PerformLayout()
        CType(Me.dgvRelacionMercanciaUbicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpDatosFinalesCarga.ResumeLayout(False)
        Me.tlpDatosFinalesCarga.PerformLayout()
        Me.tlpBotonesGenerarAtras.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabOrigen As TabPage
    Friend WithEvents tabDestino As TabPage
    Friend WithEvents tabDestinosIntermedios As TabPage
    Friend WithEvents tabMercancias As TabPage
    Friend WithEvents tabTransporte As TabPage
    Friend WithEvents tabConfirmacion As TabPage
    Friend WithEvents tlpPrincipalOrigen As TableLayoutPanel
    Friend WithEvents tlpContenedorDatosFiscalesOrigen As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbOrigenPersonaFisicaMoral As GroupBox
    Friend WithEvents rbPersonaMoralOrigen As RadioButton
    Friend WithEvents rbPersonaFisicaOrigen As RadioButton
    Friend WithEvents lblNombreOrigen As Label
    Friend WithEvents lblApPaternoOrigen As Label
    Friend WithEvents lblApMaternoOrigen As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tlpDetalleDomicilioOrigen As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTipoUbicacion As TextBox
    Friend WithEvents txtIdUbicacionOrigen As TextBox
    Friend WithEvents txtRfcRemitente As TextBox
    Friend WithEvents txtNombreRemitente As TextBox
    Friend WithEvents txtApMaternoRemitente As TextBox
    Friend WithEvents txtApPaternoRemitente As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtReferenciaRemitente As TextBox
    Friend WithEvents txtCalleRemitente As TextBox
    Friend WithEvents txtNoExtRemitente As TextBox
    Friend WithEvents txtNoIntRemitente As TextBox
    Friend WithEvents txtCpRemitente As TextBox
    Friend WithEvents txtNumRegidTribRemitente As TextBox
    Friend WithEvents txtPaisResidenciaFiscalRemitente As TextBox
    Friend WithEvents dtFechaSalidaRemitente As DateTimePicker
    Friend WithEvents btnSiguienteOrigen As Button
    Friend WithEvents cbPaisRemitente As ComboBox
    Friend WithEvents cbEstadoRemitente As ComboBox
    Friend WithEvents cbMunicipioRemitente As ComboBox
    Friend WithEvents cbLocalidadRemitente As ComboBox
    Friend WithEvents cbColoniaOrigen As ComboBox
    Friend WithEvents cbResidenciaFiscalRemitente As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tlpDatosDestino As TableLayoutPanel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbPersonaMoralDestino As RadioButton
    Friend WithEvents rbPersonaFisicaDestino As RadioButton
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtTipoUbicacionDestino As TextBox
    Friend WithEvents txtIdUbicacionDestino As TextBox
    Friend WithEvents txtRfcDestino As TextBox
    Friend WithEvents txtNombreDestino As TextBox
    Friend WithEvents txtApMaternoDestino As TextBox
    Friend WithEvents txtApPaternoDestino As TextBox
    Friend WithEvents txtNumIdRegFiscalDestino As TextBox
    Friend WithEvents txtResidenciaFiscalDestino As TextBox
    Friend WithEvents dtFechaSalidaDestino As DateTimePicker
    Friend WithEvents cbResidenciaFiscalDestino As ComboBox
    Friend WithEvents tlpDetallesDestino As TableLayoutPanel
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents txtReferenciaDestino As TextBox
    Friend WithEvents txtCalleDestino As TextBox
    Friend WithEvents txtNoExtDestino As TextBox
    Friend WithEvents txtNoIntDestino As TextBox
    Friend WithEvents txtCpDestino As TextBox
    Friend WithEvents cbPaisDestino As ComboBox
    Friend WithEvents cbEstadoDestino As ComboBox
    Friend WithEvents cbMunicipioDestino As ComboBox
    Friend WithEvents cbLocalidadDestino As ComboBox
    Friend WithEvents cbColoniaDestino As ComboBox
    Friend WithEvents tlpMainDestinosIntermedios As TableLayoutPanel
    Friend WithEvents tlpGridDestinosIntermedios As TableLayoutPanel
    Friend WithEvents Label45 As Label
    Friend WithEvents dgvCartaPorteDestinosIntermedios As DataGridView
    Friend WithEvents tlpDetallesDestinoIntermedio As TableLayoutPanel
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents txtReferenciaDestinoIntermedio As TextBox
    Friend WithEvents txtCalleDestinoIntermedio As TextBox
    Friend WithEvents txtNoExtDestinoIntermedio As TextBox
    Friend WithEvents txtNoIntDestinoIntermedio As TextBox
    Friend WithEvents txtCpDestinoIntermedio As TextBox
    Friend WithEvents cbPaisDestinoIntermedio As ComboBox
    Friend WithEvents cbEstadoDestinoIntermedio As ComboBox
    Friend WithEvents cbMunicipioDestinoIntermedio As ComboBox
    Friend WithEvents cbLocalidadDestinoIntermedio As ComboBox
    Friend WithEvents cbColoniaDestinoIntermedio As ComboBox
    Friend WithEvents tlpDatosFiscalesDestinoIntermedio As TableLayoutPanel
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbEsPersonaMoralDestinoIntermedio As RadioButton
    Friend WithEvents rbEsPersonaFisicaDestinoIntermedio As RadioButton
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents txtTipoUbicacionDestinoIntermedio As TextBox
    Friend WithEvents txtIdUbicacionDestinoIntermedio As TextBox
    Friend WithEvents txtRfcDestinoIntermedio As TextBox
    Friend WithEvents txtNombreDestinoIntermedio As TextBox
    Friend WithEvents txtApMaternoDestinoIntermedio As TextBox
    Friend WithEvents txtApPaternoDestinoIntermedio As TextBox
    Friend WithEvents txtNumregIdTribDestinoIntermedio As TextBox
    Friend WithEvents txtPaisResidenciaFiscalDestinoIntermedio As TextBox
    Friend WithEvents dtFechaLlegadaDestinoIntermedio As DateTimePicker
    Friend WithEvents cbPaisResidenciaFiscalDestinoIntermedio As ComboBox
    Friend WithEvents tlpBotonesSiguienteAtrasDestino As TableLayoutPanel
    Friend WithEvents btnAtrasDestino As Button
    Friend WithEvents btnSiguienteDestino As Button
    Friend WithEvents tlpBotonesSiguienteAtrasDestinosIntermedios As TableLayoutPanel
    Friend WithEvents btnAtrasDestinosIntermedios As Button
    Friend WithEvents btnSiguienteDestinosIntermedios As Button
    Friend WithEvents btnReiniciarDestinosIntermedios As Button
    Friend WithEvents btnGuardarDestinosIntermedios As Button
    Friend WithEvents tlpPrincipalMercancias As TableLayoutPanel
    Friend WithEvents tlpContenedorGridMovimientosPestanaMercancias As TableLayoutPanel
    Friend WithEvents tlpContenedorMercanciasDelMovimientoPestanaMercancias As TableLayoutPanel
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents dgvListadoMovimientosPestanaMercancia As DataGridView
    Friend WithEvents dgvMercanciasPorMovimiento As DataGridView
    Friend WithEvents tlpDetallesMercancia As TableLayoutPanel
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents txtClaveProdServMercancia As TextBox
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents txtCantidadMercancia As TextBox
    Friend WithEvents txtUnidadClaveMercancia As TextBox
    Friend WithEvents txtUnidadMercancia As TextBox
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtMoneda As TextBox
    Friend WithEvents Label79 As Label
    Friend WithEvents tlpContenedorAltura As TableLayoutPanel
    Friend WithEvents tlpContenedorAnchura As TableLayoutPanel
    Friend WithEvents tlpContenedorLongitud As TableLayoutPanel
    Friend WithEvents Label80 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents cbOpcionDimensiones As ComboBox
    Friend WithEvents numAnchura As NumericUpDown
    Friend WithEvents numAltura As NumericUpDown
    Friend WithEvents numLongitud As NumericUpDown
    Friend WithEvents Label83 As Label
    Friend WithEvents rbSiMaterialPeligroso As RadioButton
    Friend WithEvents rbNoMaterialPeligroso As RadioButton
    Friend WithEvents Label84 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents txtClaveMaterialPeligroso As TextBox
    Friend WithEvents txtEmbalaje As TextBox
    Friend WithEvents txtDescripcionMaterialPeligroso As TextBox
    Friend WithEvents txtDescripcionEmbalaje As TextBox
    Friend WithEvents Label86 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents txtPedimento As MaskedTextBox
    Friend WithEvents rbComercioInternacionalSi As RadioButton
    Friend WithEvents rbComercioInternacionalNo As RadioButton
    Friend WithEvents tlpSiguienteAtrasMercancias As TableLayoutPanel
    Friend WithEvents btnAtrasMercancia As Button
    Friend WithEvents btnGuardarMercancia As Button
    Friend WithEvents btnSiguienteMercancia As Button
    Friend WithEvents tlpContenedorPrincipalTransporte As TableLayoutPanel
    Friend WithEvents tabOperador As TabPage
    Friend WithEvents tlpContenedorPrincipalOperador As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnAtrasTransporte As Button
    Friend WithEvents btnSiguienteTransporte As Button
    Friend WithEvents tlpContenedorDatosTransporte As TableLayoutPanel
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents cbSeleccionarVehiculo As ComboBox
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents txtNumPermisoSCT As TextBox
    Friend WithEvents txtDescripConfigVehicular As TextBox
    Friend WithEvents Label92 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents txtPlacaTransporte As TextBox
    Friend WithEvents txtAnioModeloTransporte As TextBox
    Friend WithEvents Label95 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents txtAseguradoraTransporte As TextBox
    Friend WithEvents txtPolizaTransporte As TextBox
    Friend WithEvents txtAseguradoraCargaTransporte As TextBox
    Friend WithEvents Label97 As Label
    Friend WithEvents tlpContenedorPoliza As TableLayoutPanel
    Friend WithEvents tlpContenedorPrimaSeguro As TableLayoutPanel
    Friend WithEvents Label98 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents txtPolizaCargaTransporte As TextBox
    Friend WithEvents txtPrimaSeguroTransporte As TextBox
    Friend WithEvents tlpContenedorRemolques As TableLayoutPanel
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents numCantidadRemolquesTransporte As NumericUpDown
    Friend WithEvents cbPropiedadRemolque1 As ComboBox
    Friend WithEvents cbPropiedadRemolque2 As ComboBox
    Friend WithEvents tlpContenedorSeguroMaterialPeligroso As TableLayoutPanel
    Friend WithEvents Label102 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents cbTipoRemolque1 As ComboBox
    Friend WithEvents cbTipoRemolque2 As ComboBox
    Friend WithEvents txtTipoRemolque1 As TextBox
    Friend WithEvents txtTipoRemolque2 As TextBox
    Friend WithEvents txtPlacasRemolque1 As TextBox
    Friend WithEvents txtPlacasRemolque2 As TextBox
    Friend WithEvents txtAseguradoraDanosMedioAmbiente As TextBox
    Friend WithEvents txtPolizaSegurosDanosMedioAmbiente As TextBox
    Friend WithEvents tlpSeleccionOperador As TableLayoutPanel
    Friend WithEvents Label109 As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents Label112 As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents Label116 As Label
    Friend WithEvents Label117 As Label
    Friend WithEvents txtRfcOperador As TextBox
    Friend WithEvents txtNumRegIdTribFiscOperador As TextBox
    Friend WithEvents txtNombreOperador As TextBox
    Friend WithEvents txtApPaternoOperador As TextBox
    Friend WithEvents txtApMaternoOperador As TextBox
    Friend WithEvents cbTipoFiguraOperador As ComboBox
    Friend WithEvents rbOperadorMexicano As RadioButton
    Friend WithEvents rbOperadorExtranjero As RadioButton
    Friend WithEvents tlpDireccionOperador As TableLayoutPanel
    Friend WithEvents Label118 As Label
    Friend WithEvents Label119 As Label
    Friend WithEvents Label120 As Label
    Friend WithEvents Label121 As Label
    Friend WithEvents Label122 As Label
    Friend WithEvents Label123 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents tlpNoIntDomicilioOperador As TableLayoutPanel
    Friend WithEvents tlpNoExtDomicilioOperador As TableLayoutPanel
    Friend WithEvents Label125 As Label
    Friend WithEvents Label126 As Label
    Friend WithEvents tlpAtrasSiguienteOperador As TableLayoutPanel
    Friend WithEvents btnAtrasOperador As Button
    Friend WithEvents btnSiguienteOperador As Button
    Friend WithEvents tlpPartesTransporteOperador As TableLayoutPanel
    Friend WithEvents Label127 As Label
    Friend WithEvents Label129 As Label
    Friend WithEvents cbParteTransporteOperador As ComboBox
    Friend WithEvents btnAnadirParteTransporte As Button
    Friend WithEvents gvParteTransporteOperador As DataGridView
    Friend WithEvents Label128 As Label
    Friend WithEvents Label130 As Label
    Friend WithEvents cbOpcionesOperador As ComboBox
    Friend WithEvents cbPaisOperador As ComboBox
    Friend WithEvents cbEstadoOperador As ComboBox
    Friend WithEvents cbMunicipioOperador As ComboBox
    Friend WithEvents cbLocalidadOperador As ComboBox
    Friend WithEvents cbColoniaOperador As ComboBox
    Friend WithEvents txtCpOperador As TextBox
    Friend WithEvents txtCalleOperador As TextBox
    Friend WithEvents txtReferenciaOperador As TextBox
    Friend WithEvents txtNoExtOperador As TextBox
    Friend WithEvents txtNoIntOperador As TextBox
    Friend WithEvents tlpPrincipalConfirmacion As TableLayoutPanel
    Friend WithEvents Label131 As Label
    Friend WithEvents tlpUbicacionesConfirmacion As TableLayoutPanel
    Friend WithEvents Label132 As Label
    Friend WithEvents dgvConfirmacionUbicaciones As DataGridView
    Friend WithEvents tlpMercanciasSinAsignar As TableLayoutPanel
    Friend WithEvents Label133 As Label
    Friend WithEvents dgvMercanciasSinUbicaciones As DataGridView
    Friend WithEvents tlpRelacionMercanciaUbicaciones As TableLayoutPanel
    Friend WithEvents Label134 As Label
    Friend WithEvents dgvRelacionMercanciaUbicaciones As DataGridView
    Friend WithEvents tlpDatosFinalesCarga As TableLayoutPanel
    Friend WithEvents Label135 As Label
    Friend WithEvents Label136 As Label
    Friend WithEvents txtPesoBrutoTotalMercancias As TextBox
    Friend WithEvents txtUnidadPesoTotalMercancias As TextBox
    Friend WithEvents tlpBotonesGenerarAtras As TableLayoutPanel
    Friend WithEvents btnAtrasConfirmacion As Button
    Friend WithEvents btnGenerarCartaPorte As Button
    Friend WithEvents txtHoraSalidaRemitente As MaskedTextBox
    Friend WithEvents rbExtranjeroOrigen As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rbEsExtranjeroDestino As RadioButton
    Friend WithEvents tlpHoraLlegadaDestino As TableLayoutPanel
    Friend WithEvents txtHoraSalidaDestino As TextBox
    Friend WithEvents tlpNumKilometros As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nupKmRecorridos As NumericUpDown
    Friend WithEvents rbEsExtranjeroDestinoIntermedio As RadioButton
    Friend WithEvents tlpHoraLlegadaDestinoIntermedio As TableLayoutPanel
    Friend WithEvents tlpKmDestinoIntermedio As TableLayoutPanel
    Friend WithEvents txtHoraLlegadaDestinoIntermedio As TextBox
    Friend WithEvents nupKmDestinoIntermedio As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents txtFraccionArancelaria As TextBox
    Friend WithEvents ParteTransporteAnadidoClm As DataGridViewTextBoxColumn
    Friend WithEvents EliminarParteTransporteClm As DataGridViewButtonColumn
    Friend WithEvents Label138 As Label
    Friend WithEvents txtNumLicenciaOperador As TextBox
    Friend WithEvents btnLimpiarDestinosIntermedios As Button
    Friend WithEvents btnLimpiarMercancia As Button
    Friend WithEvents MovimientoMercanciaClm As DataGridViewTextBoxColumn
    Friend WithEvents DestinoMercanciaClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientosTipoMovimientoClm As DataGridViewTextBoxColumn
    Friend WithEvents MercanciasBtnClm As DataGridViewButtonColumn
    Friend WithEvents AnadirMercanciaMovimientoClm As DataGridViewButtonColumn
    Friend WithEvents IdUbicacionMovimientoPestanaMercanciaClm As DataGridViewTextBoxColumn
    Friend WithEvents pnlMaterialPeligroso As Panel
    Friend WithEvents pnlComercioInternacional As Panel
    Friend WithEvents txtConVeh As TextBox
    Friend WithEvents txtTipoPermisoSCT As TextBox
    Friend WithEvents txtDescripcionTipoPermisoSCT As TextBox
    Friend WithEvents lblFechaHoraMaximaDestInter As Label
    Friend WithEvents DIMovimientoClm As DataGridViewTextBoxColumn
    Friend WithEvents DIDestinoClm As DataGridViewTextBoxColumn
    Friend WithEvents DIFechaLlegadaClm As DataGridViewTextBoxColumn
    Friend WithEvents DIHoraLlegadaClm As DataGridViewTextBoxColumn
    Friend WithEvents DIKmClm As DataGridViewTextBoxColumn
    Friend WithEvents DIVerClm As DataGridViewButtonColumn
    Friend WithEvents DIEliminarClm As DataGridViewButtonColumn
    Friend WithEvents IDUbicacionClm As DataGridViewTextBoxColumn
    Friend WithEvents DIUsuarioProblemasFechaClm As DataGridViewTextBoxColumn
    Friend WithEvents DIUsuarioCausoProblemasConKm As DataGridViewTextBoxColumn
    Friend WithEvents MercanciaClaveProdServClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientoDescripcionClm As DataGridViewTextBoxColumn
    Friend WithEvents ClaveUnidadClm As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionUnidadClm As DataGridViewTextBoxColumn
    Friend WithEvents MercanciaMovimientoPeligrosaClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientoComercioIntClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientoDetallesMercClm As DataGridViewButtonColumn
    Friend WithEvents MovimientoMercanciaEliminarClm As DataGridViewButtonColumn
    Friend WithEvents MovimientoMercanciaCheckboxMaterialPeligrosoClm As DataGridViewCheckBoxColumn
    Friend WithEvents IdUbicacionClmMercMov As DataGridViewTextBoxColumn
    Friend WithEvents DestinoUbiClm As DataGridViewTextBoxColumn
    Friend WithEvents TipoDestinoPestUbiClm As DataGridViewTextBoxColumn
    Friend WithEvents PestanaFinalVerDetallesClm As DataGridViewButtonColumn
    Friend WithEvents RelMercUbiIdUbiClm As DataGridViewTextBoxColumn
    Friend WithEvents RelMercUbiClaveProdServClm As DataGridViewTextBoxColumn
    Friend WithEvents RelMercUbiDescMercClm As DataGridViewTextBoxColumn
    Friend WithEvents RelMercUbiClaveUnidadClm As DataGridViewTextBoxColumn
    Friend WithEvents RelMercUbiDescUnidadClm As DataGridViewTextBoxColumn
    Friend WithEvents RelacionMercUbiPeligrosaClm As DataGridViewTextBoxColumn
    Friend WithEvents RelMercUbiCantidadClm As DataGridViewTextBoxColumn
    Friend WithEvents RelMercUbiBtnEliminarClm As DataGridViewButtonColumn
    Friend WithEvents RelMercUbiCantidadMaxima As DataGridViewTextBoxColumn
    Friend WithEvents AsignarClaveProdServClm As DataGridViewTextBoxColumn
    Friend WithEvents AsignarDescripcionMercClm As DataGridViewTextBoxColumn
    Friend WithEvents AsignarClaveUnidadClm As DataGridViewTextBoxColumn
    Friend WithEvents AsignarDescUnidadClm As DataGridViewTextBoxColumn
    Friend WithEvents AsignarPeligrosoClm As DataGridViewTextBoxColumn
    Friend WithEvents AsignarCantidadRestanteClm As DataGridViewTextBoxColumn
    Friend WithEvents AsignarCantidadParaAsignarClm As DataGridViewTextBoxColumn
    Friend WithEvents AsignarDestinoAccionClm As DataGridViewButtonColumn
End Class
