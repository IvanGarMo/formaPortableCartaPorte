<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbcCartaPorte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbcCartaPorte))
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.ColAccion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColAutorizoCliente = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColTipoDocto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_solAut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTipoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColReferencia = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAcuseCANC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCotizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPoliza = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColCPoliza = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRenglones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColImpIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTipoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColId_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColcMotivoCANC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUUID_RelCANC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpPanelFiltros = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnTimbrar = New System.Windows.Forms.Button()
        Me.btnCancelaTimbre = New System.Windows.Forms.Button()
        Me.BtnXML = New System.Windows.Forms.Button()
        Me.cmdRefrescar = New System.Windows.Forms.Button()
        Me.BtnExporta_a_Excel = New System.Windows.Forms.Button()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tlpPrincipal.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPanelFiltros.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 1
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.Controls.Add(Me.Grid, 0, 0)
        Me.tlpPrincipal.Controls.Add(Me.tlpPanelFiltros, 0, 1)
        Me.tlpPrincipal.Controls.Add(Me.tlpBotones, 0, 2)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 3
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(1473, 684)
        Me.tlpPrincipal.TabIndex = 0
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColAccion, Me.ColAutorizoCliente, Me.ColTipoDocto, Me.Col_solAut, Me.ColSucursal, Me.ColEntrega, Me.ColTipoServicio, Me.ColServicio, Me.ColReferencia, Me.ColVenta, Me.ColUUID, Me.ColEstatus, Me.ColAcuseCANC, Me.ColFecha, Me.ColCotizacion, Me.ColPoliza, Me.ColCPoliza, Me.ColCliente, Me.ColNombreCliente, Me.ColConcepto, Me.ColRenglones, Me.ColPedida, Me.ColSubtotal, Me.ColImpIva, Me.ColDescuento, Me.ColImporte, Me.ColMoneda, Me.ColTC, Me.ColTipoCredito, Me.ColFum, Me.ColId_Usuario, Me.ColRFC, Me.ColcMotivoCANC, Me.ColUUID_RelCANC})
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grid.Location = New System.Drawing.Point(4, 5)
        Me.Grid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeadersWidth = 51
        Me.Grid.Size = New System.Drawing.Size(1465, 332)
        Me.Grid.TabIndex = 2
        '
        'ColAccion
        '
        Me.ColAccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColAccion.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColAccion.Frozen = True
        Me.ColAccion.HeaderText = ""
        Me.ColAccion.MinimumWidth = 6
        Me.ColAccion.Name = "ColAccion"
        Me.ColAccion.Width = 6
        '
        'ColAutorizoCliente
        '
        Me.ColAutorizoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColAutorizoCliente.HeaderText = "Autorizado"
        Me.ColAutorizoCliente.MinimumWidth = 6
        Me.ColAutorizoCliente.Name = "ColAutorizoCliente"
        Me.ColAutorizoCliente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColAutorizoCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColAutorizoCliente.Width = 122
        '
        'ColTipoDocto
        '
        Me.ColTipoDocto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColTipoDocto.HeaderText = "Tipo_Docto"
        Me.ColTipoDocto.MinimumWidth = 6
        Me.ColTipoDocto.Name = "ColTipoDocto"
        Me.ColTipoDocto.Width = 127
        '
        'Col_solAut
        '
        Me.Col_solAut.HeaderText = "Sol. Autorizacion"
        Me.Col_solAut.MinimumWidth = 6
        Me.Col_solAut.Name = "Col_solAut"
        Me.Col_solAut.Width = 125
        '
        'ColSucursal
        '
        Me.ColSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColSucursal.HeaderText = "Sucursal"
        Me.ColSucursal.MinimumWidth = 6
        Me.ColSucursal.Name = "ColSucursal"
        Me.ColSucursal.Width = 107
        '
        'ColEntrega
        '
        Me.ColEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEntrega.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColEntrega.HeaderText = "Entrega"
        Me.ColEntrega.MinimumWidth = 6
        Me.ColEntrega.Name = "ColEntrega"
        Me.ColEntrega.Width = 102
        '
        'ColTipoServicio
        '
        Me.ColTipoServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColTipoServicio.HeaderText = "Tipo Servicio"
        Me.ColTipoServicio.MinimumWidth = 6
        Me.ColTipoServicio.Name = "ColTipoServicio"
        Me.ColTipoServicio.Visible = False
        Me.ColTipoServicio.Width = 150
        '
        'ColServicio
        '
        Me.ColServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColServicio.HeaderText = "Servicio"
        Me.ColServicio.MinimumWidth = 6
        Me.ColServicio.Name = "ColServicio"
        Me.ColServicio.Visible = False
        Me.ColServicio.Width = 150
        '
        'ColReferencia
        '
        Me.ColReferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColReferencia.HeaderText = "Caso"
        Me.ColReferencia.MinimumWidth = 6
        Me.ColReferencia.Name = "ColReferencia"
        Me.ColReferencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColReferencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColReferencia.Visible = False
        Me.ColReferencia.Width = 150
        '
        'ColVenta
        '
        Me.ColVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColVenta.HeaderText = "Cve_Documento"
        Me.ColVenta.MinimumWidth = 6
        Me.ColVenta.Name = "ColVenta"
        Me.ColVenta.Width = 164
        '
        'ColUUID
        '
        Me.ColUUID.HeaderText = "UUID"
        Me.ColUUID.MinimumWidth = 6
        Me.ColUUID.Name = "ColUUID"
        Me.ColUUID.Width = 125
        '
        'ColEstatus
        '
        Me.ColEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColEstatus.HeaderText = "Estatus"
        Me.ColEstatus.MinimumWidth = 6
        Me.ColEstatus.Name = "ColEstatus"
        '
        'ColAcuseCANC
        '
        Me.ColAcuseCANC.HeaderText = "Acuse Cancelacion"
        Me.ColAcuseCANC.MinimumWidth = 6
        Me.ColAcuseCANC.Name = "ColAcuseCANC"
        Me.ColAcuseCANC.Width = 125
        '
        'ColFecha
        '
        Me.ColFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColFecha.HeaderText = "Fecha"
        Me.ColFecha.MinimumWidth = 6
        Me.ColFecha.Name = "ColFecha"
        Me.ColFecha.Width = 90
        '
        'ColCotizacion
        '
        Me.ColCotizacion.HeaderText = "Cotizacion"
        Me.ColCotizacion.MinimumWidth = 6
        Me.ColCotizacion.Name = "ColCotizacion"
        Me.ColCotizacion.Width = 125
        '
        'ColPoliza
        '
        Me.ColPoliza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColPoliza.HeaderText = "Poliza"
        Me.ColPoliza.MinimumWidth = 6
        Me.ColPoliza.Name = "ColPoliza"
        Me.ColPoliza.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColPoliza.Width = 87
        '
        'ColCPoliza
        '
        Me.ColCPoliza.HeaderText = "Poliza Cancelacion"
        Me.ColCPoliza.MinimumWidth = 6
        Me.ColCPoliza.Name = "ColCPoliza"
        Me.ColCPoliza.Width = 125
        '
        'ColCliente
        '
        Me.ColCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColCliente.HeaderText = "Cliente"
        Me.ColCliente.MinimumWidth = 6
        Me.ColCliente.Name = "ColCliente"
        Me.ColCliente.Width = 94
        '
        'ColNombreCliente
        '
        Me.ColNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColNombreCliente.HeaderText = "Nombre del Cliente"
        Me.ColNombreCliente.MinimumWidth = 6
        Me.ColNombreCliente.Name = "ColNombreCliente"
        Me.ColNombreCliente.Width = 120
        '
        'ColConcepto
        '
        Me.ColConcepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColConcepto.HeaderText = "Concepto"
        Me.ColConcepto.MinimumWidth = 6
        Me.ColConcepto.Name = "ColConcepto"
        Me.ColConcepto.Width = 114
        '
        'ColRenglones
        '
        Me.ColRenglones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColRenglones.HeaderText = "Reng"
        Me.ColRenglones.MinimumWidth = 6
        Me.ColRenglones.Name = "ColRenglones"
        Me.ColRenglones.Width = 84
        '
        'ColPedida
        '
        Me.ColPedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColPedida.HeaderText = "Cant_Pedida"
        Me.ColPedida.MinimumWidth = 6
        Me.ColPedida.Name = "ColPedida"
        Me.ColPedida.Width = 137
        '
        'ColSubtotal
        '
        Me.ColSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColSubtotal.HeaderText = "SubTotal"
        Me.ColSubtotal.MinimumWidth = 6
        Me.ColSubtotal.Name = "ColSubtotal"
        Me.ColSubtotal.Width = 109
        '
        'ColImpIva
        '
        Me.ColImpIva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColImpIva.HeaderText = "ImpIva"
        Me.ColImpIva.MinimumWidth = 6
        Me.ColImpIva.Name = "ColImpIva"
        Me.ColImpIva.Width = 93
        '
        'ColDescuento
        '
        Me.ColDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColDescuento.HeaderText = "Descuento"
        Me.ColDescuento.MinimumWidth = 6
        Me.ColDescuento.Name = "ColDescuento"
        Me.ColDescuento.Width = 123
        '
        'ColImporte
        '
        Me.ColImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColImporte.HeaderText = "Importe"
        Me.ColImporte.MinimumWidth = 6
        Me.ColImporte.Name = "ColImporte"
        '
        'ColMoneda
        '
        Me.ColMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColMoneda.HeaderText = "Moneda"
        Me.ColMoneda.MinimumWidth = 6
        Me.ColMoneda.Name = "ColMoneda"
        Me.ColMoneda.Width = 103
        '
        'ColTC
        '
        Me.ColTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColTC.HeaderText = "TC"
        Me.ColTC.MinimumWidth = 6
        Me.ColTC.Name = "ColTC"
        Me.ColTC.Width = 65
        '
        'ColTipoCredito
        '
        Me.ColTipoCredito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColTipoCredito.HeaderText = "Tipo_Credito"
        Me.ColTipoCredito.MinimumWidth = 6
        Me.ColTipoCredito.Name = "ColTipoCredito"
        Me.ColTipoCredito.Width = 135
        '
        'ColFum
        '
        Me.ColFum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColFum.HeaderText = "Fum"
        Me.ColFum.MinimumWidth = 6
        Me.ColFum.Name = "ColFum"
        Me.ColFum.Width = 77
        '
        'ColId_Usuario
        '
        Me.ColId_Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColId_Usuario.HeaderText = "id_Usuario"
        Me.ColId_Usuario.MinimumWidth = 6
        Me.ColId_Usuario.Name = "ColId_Usuario"
        Me.ColId_Usuario.Width = 121
        '
        'ColRFC
        '
        Me.ColRFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColRFC.HeaderText = "RFC"
        Me.ColRFC.MinimumWidth = 6
        Me.ColRFC.Name = "ColRFC"
        Me.ColRFC.Visible = False
        Me.ColRFC.Width = 150
        '
        'ColcMotivoCANC
        '
        Me.ColcMotivoCANC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColcMotivoCANC.HeaderText = "cMotivoCANC"
        Me.ColcMotivoCANC.MinimumWidth = 8
        Me.ColcMotivoCANC.Name = "ColcMotivoCANC"
        Me.ColcMotivoCANC.Visible = False
        Me.ColcMotivoCANC.Width = 150
        '
        'ColUUID_RelCANC
        '
        Me.ColUUID_RelCANC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColUUID_RelCANC.HeaderText = "UUID_RelCANC"
        Me.ColUUID_RelCANC.MinimumWidth = 8
        Me.ColUUID_RelCANC.Name = "ColUUID_RelCANC"
        Me.ColUUID_RelCANC.Width = 163
        '
        'tlpPanelFiltros
        '
        Me.tlpPanelFiltros.ColumnCount = 8
        Me.tlpPanelFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPanelFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPanelFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPanelFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPanelFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPanelFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPanelFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPanelFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPanelFiltros.Controls.Add(Me.BtnExporta_a_Excel, 7, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.BtnXML, 6, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.TableLayoutPanel2, 5, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.Label5, 0, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.Label4, 2, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.Label3, 2, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.Label2, 2, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.Label1, 0, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.Label47, 0, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.ComboBox1, 1, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.ComboBox2, 1, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.ComboBox3, 1, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.ComboBox4, 3, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.ComboBox5, 3, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.ComboBox6, 3, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.CheckBox1, 4, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.TableLayoutPanel1, 5, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.CheckBox2, 5, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.btnCancelaTimbre, 7, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.btnTimbrar, 6, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.cmdRefrescar, 6, 2)
        Me.tlpPanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPanelFiltros.Location = New System.Drawing.Point(3, 345)
        Me.tlpPanelFiltros.Name = "tlpPanelFiltros"
        Me.tlpPanelFiltros.RowCount = 3
        Me.tlpPanelFiltros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpPanelFiltros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpPanelFiltros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tlpPanelFiltros.Size = New System.Drawing.Size(1467, 199)
        Me.tlpPanelFiltros.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(4, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 69)
        Me.Label5.TabIndex = 558
        Me.Label5.Text = "Sucursal :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(370, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 69)
        Me.Label4.TabIndex = 557
        Me.Label4.Text = "Sucursal :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(370, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 65)
        Me.Label3.TabIndex = 556
        Me.Label3.Text = "Sucursal :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(370, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 65)
        Me.Label2.TabIndex = 555
        Me.Label2.Text = "Sucursal :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(4, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 65)
        Me.Label1.TabIndex = 554
        Me.Label1.Text = "Sucursal :"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label47.Location = New System.Drawing.Point(4, 0)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(138, 65)
        Me.Label47.TabIndex = 553
        Me.Label47.Text = "Sucursal :"
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(149, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 28)
        Me.ComboBox1.TabIndex = 559
        '
        'ComboBox2
        '
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(149, 68)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(214, 28)
        Me.ComboBox2.TabIndex = 560
        '
        'ComboBox3
        '
        Me.ComboBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(149, 133)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(214, 28)
        Me.ComboBox3.TabIndex = 561
        '
        'ComboBox4
        '
        Me.ComboBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(515, 3)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(214, 28)
        Me.ComboBox4.TabIndex = 562
        '
        'ComboBox5
        '
        Me.ComboBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(515, 68)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(214, 28)
        Me.ComboBox5.TabIndex = 563
        '
        'ComboBox6
        '
        Me.ComboBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(515, 133)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(214, 28)
        Me.ComboBox6.TabIndex = 564
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.CheckBox1.Location = New System.Drawing.Point(735, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 59)
        Me.CheckBox1.TabIndex = 565
        Me.CheckBox1.Text = "Consulta histórica"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(881, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(140, 59)
        Me.TableLayoutPanel1.TabIndex = 566
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(881, 68)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(140, 59)
        Me.TableLayoutPanel2.TabIndex = 567
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.CheckBox2.Location = New System.Drawing.Point(881, 133)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(140, 63)
        Me.CheckBox2.TabIndex = 568
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnTimbrar
        '
        Me.btnTimbrar.BackColor = System.Drawing.Color.Black
        Me.btnTimbrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTimbrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnTimbrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTimbrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimbrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimbrar.ForeColor = System.Drawing.Color.White
        Me.btnTimbrar.Image = CType(resources.GetObject("btnTimbrar.Image"), System.Drawing.Image)
        Me.btnTimbrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimbrar.Location = New System.Drawing.Point(1086, 5)
        Me.btnTimbrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTimbrar.Name = "btnTimbrar"
        Me.btnTimbrar.Size = New System.Drawing.Size(154, 55)
        Me.btnTimbrar.TabIndex = 569
        Me.btnTimbrar.Text = "Timbrar"
        Me.btnTimbrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTimbrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTimbrar.UseVisualStyleBackColor = False
        '
        'btnCancelaTimbre
        '
        Me.btnCancelaTimbre.BackColor = System.Drawing.Color.Black
        Me.btnCancelaTimbre.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancelaTimbre.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelaTimbre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancelaTimbre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelaTimbre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelaTimbre.ForeColor = System.Drawing.Color.White
        Me.btnCancelaTimbre.Image = CType(resources.GetObject("btnCancelaTimbre.Image"), System.Drawing.Image)
        Me.btnCancelaTimbre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelaTimbre.Location = New System.Drawing.Point(1309, 5)
        Me.btnCancelaTimbre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelaTimbre.Name = "btnCancelaTimbre"
        Me.btnCancelaTimbre.Size = New System.Drawing.Size(154, 55)
        Me.btnCancelaTimbre.TabIndex = 570
        Me.btnCancelaTimbre.Tag = ""
        Me.btnCancelaTimbre.Text = "Cancelar Timbre"
        Me.btnCancelaTimbre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelaTimbre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelaTimbre.UseVisualStyleBackColor = False
        '
        'BtnXML
        '
        Me.BtnXML.BackColor = System.Drawing.Color.White
        Me.BtnXML.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnXML.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnXML.Image = CType(resources.GetObject("BtnXML.Image"), System.Drawing.Image)
        Me.BtnXML.Location = New System.Drawing.Point(1086, 70)
        Me.BtnXML.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnXML.Name = "BtnXML"
        Me.BtnXML.Size = New System.Drawing.Size(154, 55)
        Me.BtnXML.TabIndex = 571
        Me.BtnXML.Text = "XML"
        Me.BtnXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnXML.UseVisualStyleBackColor = False
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.BackColor = System.Drawing.Color.White
        Me.cmdRefrescar.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdRefrescar.Location = New System.Drawing.Point(1086, 135)
        Me.cmdRefrescar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(154, 59)
        Me.cmdRefrescar.TabIndex = 572
        Me.cmdRefrescar.Text = "Refrescar"
        Me.cmdRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRefrescar.UseVisualStyleBackColor = False
        '
        'BtnExporta_a_Excel
        '
        Me.BtnExporta_a_Excel.BackColor = System.Drawing.Color.White
        Me.BtnExporta_a_Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnExporta_a_Excel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnExporta_a_Excel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnExporta_a_Excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnExporta_a_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExporta_a_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExporta_a_Excel.Image = CType(resources.GetObject("BtnExporta_a_Excel.Image"), System.Drawing.Image)
        Me.BtnExporta_a_Excel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnExporta_a_Excel.Location = New System.Drawing.Point(1309, 135)
        Me.BtnExporta_a_Excel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExporta_a_Excel.Name = "BtnExporta_a_Excel"
        Me.BtnExporta_a_Excel.Size = New System.Drawing.Size(154, 59)
        Me.BtnExporta_a_Excel.TabIndex = 573
        Me.BtnExporta_a_Excel.Text = "&Exportar Excel"
        Me.BtnExporta_a_Excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExporta_a_Excel.UseVisualStyleBackColor = False
        '
        'tlpBotones
        '
        Me.tlpBotones.ColumnCount = 7
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpBotones.Controls.Add(Me.CmdSalir, 5, 1)
        Me.tlpBotones.Controls.Add(Me.cmdNuevo, 1, 1)
        Me.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotones.Location = New System.Drawing.Point(3, 550)
        Me.tlpBotones.Name = "tlpBotones"
        Me.tlpBotones.RowCount = 3
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpBotones.Size = New System.Drawing.Size(1467, 131)
        Me.tlpBotones.TabIndex = 16
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackColor = System.Drawing.Color.White
        Me.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.ForeColor = System.Drawing.Color.Black
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNuevo.Location = New System.Drawing.Point(77, 11)
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(127, 69)
        Me.cmdNuevo.TabIndex = 13
        Me.cmdNuevo.Text = "&Nuevo"
        Me.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'CmdSalir
        '
        Me.CmdSalir.BackColor = System.Drawing.Color.White
        Me.CmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdSalir.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalir.ForeColor = System.Drawing.Color.Black
        Me.CmdSalir.Image = CType(resources.GetObject("CmdSalir.Image"), System.Drawing.Image)
        Me.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdSalir.Location = New System.Drawing.Point(1133, 11)
        Me.CmdSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(135, 69)
        Me.CmdSalir.TabIndex = 53
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CmdSalir.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "De:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "A:"
        '
        'frmAbcCartaPorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1473, 684)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.Name = "frmAbcCartaPorte"
        Me.Text = "Cartas Porte"
        Me.tlpPrincipal.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPanelFiltros.ResumeLayout(False)
        Me.tlpPanelFiltros.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tlpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents Grid As DataGridView
    Friend WithEvents ColAccion As DataGridViewButtonColumn
    Friend WithEvents ColAutorizoCliente As DataGridViewButtonColumn
    Friend WithEvents ColTipoDocto As DataGridViewTextBoxColumn
    Friend WithEvents Col_solAut As DataGridViewTextBoxColumn
    Friend WithEvents ColSucursal As DataGridViewTextBoxColumn
    Friend WithEvents ColEntrega As DataGridViewTextBoxColumn
    Friend WithEvents ColTipoServicio As DataGridViewTextBoxColumn
    Friend WithEvents ColServicio As DataGridViewTextBoxColumn
    Friend WithEvents ColReferencia As DataGridViewButtonColumn
    Friend WithEvents ColVenta As DataGridViewTextBoxColumn
    Friend WithEvents ColUUID As DataGridViewTextBoxColumn
    Friend WithEvents ColEstatus As DataGridViewTextBoxColumn
    Friend WithEvents ColAcuseCANC As DataGridViewTextBoxColumn
    Friend WithEvents ColFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColCotizacion As DataGridViewTextBoxColumn
    Friend WithEvents ColPoliza As DataGridViewButtonColumn
    Friend WithEvents ColCPoliza As DataGridViewButtonColumn
    Friend WithEvents ColCliente As DataGridViewTextBoxColumn
    Friend WithEvents ColNombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents ColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents ColRenglones As DataGridViewTextBoxColumn
    Friend WithEvents ColPedida As DataGridViewTextBoxColumn
    Friend WithEvents ColSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents ColImpIva As DataGridViewTextBoxColumn
    Friend WithEvents ColDescuento As DataGridViewTextBoxColumn
    Friend WithEvents ColImporte As DataGridViewTextBoxColumn
    Friend WithEvents ColMoneda As DataGridViewTextBoxColumn
    Friend WithEvents ColTC As DataGridViewTextBoxColumn
    Friend WithEvents ColTipoCredito As DataGridViewTextBoxColumn
    Friend WithEvents ColFum As DataGridViewTextBoxColumn
    Friend WithEvents ColId_Usuario As DataGridViewTextBoxColumn
    Friend WithEvents ColRFC As DataGridViewTextBoxColumn
    Friend WithEvents ColcMotivoCANC As DataGridViewTextBoxColumn
    Friend WithEvents ColUUID_RelCANC As DataGridViewTextBoxColumn
    Friend WithEvents tlpPanelFiltros As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Private WithEvents BtnExporta_a_Excel As Button
    Private WithEvents cmdRefrescar As Button
    Private WithEvents BtnXML As Button
    Private WithEvents btnCancelaTimbre As Button
    Private WithEvents btnTimbrar As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents tlpBotones As TableLayoutPanel
    Private WithEvents CmdSalir As Button
    Private WithEvents cmdNuevo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
