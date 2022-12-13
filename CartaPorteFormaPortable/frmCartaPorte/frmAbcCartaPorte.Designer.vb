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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbcCartaPorte))
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvCartasPorte = New System.Windows.Forms.DataGridView()
        Me.tlpPanelFiltros = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExportaExcel = New System.Windows.Forms.Button()
        Me.BtnXML = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtFechaFinConsulta = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.cbTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.cbEstatus = New System.Windows.Forms.ComboBox()
        Me.cbTipoCfdi = New System.Windows.Forms.ComboBox()
        Me.cbIndividualAgrupado = New System.Windows.Forms.ComboBox()
        Me.cbxConsultaHistorica = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtFechaInicioConsulta = New System.Windows.Forms.DateTimePicker()
        Me.cbxSoloTimbrados = New System.Windows.Forms.CheckBox()
        Me.btnCancelaTimbre = New System.Windows.Forms.Button()
        Me.btnTimbrar = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.txtMovimiento = New System.Windows.Forms.TextBox()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.ColMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTipoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTipoCfdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFechaCreacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEstatusCartaPorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUsuarioCreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTimbrado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColUuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpPrincipal.SuspendLayout()
        CType(Me.dgvCartasPorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPanelFiltros.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 1
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.Controls.Add(Me.dgvCartasPorte, 0, 0)
        Me.tlpPrincipal.Controls.Add(Me.tlpPanelFiltros, 0, 1)
        Me.tlpPrincipal.Controls.Add(Me.tlpBotones, 0, 2)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 3
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(1490, 712)
        Me.tlpPrincipal.TabIndex = 0
        '
        'dgvCartasPorte
        '
        Me.dgvCartasPorte.AllowUserToAddRows = False
        Me.dgvCartasPorte.AllowUserToDeleteRows = False
        Me.dgvCartasPorte.BackgroundColor = System.Drawing.Color.White
        Me.dgvCartasPorte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCartasPorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCartasPorte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColMovimiento, Me.ColSucursal, Me.ColTipoMovimiento, Me.ColTipoCfdi, Me.ColFechaCreacion, Me.ColEstatusCartaPorte, Me.ColUsuarioCreo, Me.ColTimbrado, Me.ColUuid})
        Me.dgvCartasPorte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCartasPorte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCartasPorte.Location = New System.Drawing.Point(4, 5)
        Me.dgvCartasPorte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvCartasPorte.Name = "dgvCartasPorte"
        Me.dgvCartasPorte.RowHeadersWidth = 51
        Me.dgvCartasPorte.Size = New System.Drawing.Size(1482, 417)
        Me.dgvCartasPorte.TabIndex = 2
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
        Me.tlpPanelFiltros.Controls.Add(Me.btnExportaExcel, 7, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.BtnXML, 6, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.TableLayoutPanel2, 5, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.Label5, 0, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.Label4, 2, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.Label3, 2, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.Label2, 2, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.Label1, 0, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.Label47, 0, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.cbSucursal, 1, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.cbTipoMovimiento, 1, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.cbEstatus, 3, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.cbTipoCfdi, 3, 1)
        Me.tlpPanelFiltros.Controls.Add(Me.cbIndividualAgrupado, 3, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.cbxConsultaHistorica, 4, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.TableLayoutPanel1, 5, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.cbxSoloTimbrados, 5, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.btnCancelaTimbre, 7, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.btnTimbrar, 6, 0)
        Me.tlpPanelFiltros.Controls.Add(Me.btnRefrescar, 6, 2)
        Me.tlpPanelFiltros.Controls.Add(Me.txtMovimiento, 1, 2)
        Me.tlpPanelFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPanelFiltros.Location = New System.Drawing.Point(3, 430)
        Me.tlpPanelFiltros.Name = "tlpPanelFiltros"
        Me.tlpPanelFiltros.RowCount = 3
        Me.tlpPanelFiltros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpPanelFiltros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpPanelFiltros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tlpPanelFiltros.Size = New System.Drawing.Size(1484, 172)
        Me.tlpPanelFiltros.TabIndex = 15
        '
        'btnExportaExcel
        '
        Me.btnExportaExcel.BackColor = System.Drawing.Color.White
        Me.btnExportaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExportaExcel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExportaExcel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnExportaExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExportaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportaExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportaExcel.Image = CType(resources.GetObject("btnExportaExcel.Image"), System.Drawing.Image)
        Me.btnExportaExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportaExcel.Location = New System.Drawing.Point(1326, 117)
        Me.btnExportaExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExportaExcel.Name = "btnExportaExcel"
        Me.btnExportaExcel.Size = New System.Drawing.Size(154, 50)
        Me.btnExportaExcel.TabIndex = 573
        Me.btnExportaExcel.Text = "&Exportar Excel"
        Me.btnExportaExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportaExcel.UseVisualStyleBackColor = False
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
        Me.BtnXML.Location = New System.Drawing.Point(1100, 61)
        Me.BtnXML.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnXML.Name = "BtnXML"
        Me.BtnXML.Size = New System.Drawing.Size(154, 46)
        Me.BtnXML.TabIndex = 571
        Me.BtnXML.Text = "XML"
        Me.BtnXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnXML.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dtFechaFinConsulta, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(891, 59)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(140, 50)
        Me.TableLayoutPanel2.TabIndex = 567
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
        'dtFechaFinConsulta
        '
        Me.dtFechaFinConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtFechaFinConsulta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinConsulta.Location = New System.Drawing.Point(3, 23)
        Me.dtFechaFinConsulta.Name = "dtFechaFinConsulta"
        Me.dtFechaFinConsulta.Size = New System.Drawing.Size(134, 26)
        Me.dtFechaFinConsulta.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(4, 112)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 60)
        Me.Label5.TabIndex = 558
        Me.Label5.Text = "Movimiento :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(374, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 60)
        Me.Label4.TabIndex = 557
        Me.Label4.Text = "Individual o agrupado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(374, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 56)
        Me.Label3.TabIndex = 556
        Me.Label3.Text = "Tipo CFDI :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(374, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 56)
        Me.Label2.TabIndex = 555
        Me.Label2.Text = "Estatus :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(4, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 56)
        Me.Label1.TabIndex = 554
        Me.Label1.Text = "Tipo de movimiento:"
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
        Me.Label47.Size = New System.Drawing.Size(140, 56)
        Me.Label47.TabIndex = 553
        Me.Label47.Text = "Sucursal :"
        '
        'cbSucursal
        '
        Me.cbSucursal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(151, 3)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(216, 28)
        Me.cbSucursal.TabIndex = 559
        '
        'cbTipoMovimiento
        '
        Me.cbTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoMovimiento.FormattingEnabled = True
        Me.cbTipoMovimiento.Location = New System.Drawing.Point(151, 59)
        Me.cbTipoMovimiento.Name = "cbTipoMovimiento"
        Me.cbTipoMovimiento.Size = New System.Drawing.Size(216, 28)
        Me.cbTipoMovimiento.TabIndex = 560
        '
        'cbEstatus
        '
        Me.cbEstatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstatus.FormattingEnabled = True
        Me.cbEstatus.Location = New System.Drawing.Point(521, 3)
        Me.cbEstatus.Name = "cbEstatus"
        Me.cbEstatus.Size = New System.Drawing.Size(216, 28)
        Me.cbEstatus.TabIndex = 562
        '
        'cbTipoCfdi
        '
        Me.cbTipoCfdi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbTipoCfdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCfdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoCfdi.FormattingEnabled = True
        Me.cbTipoCfdi.Location = New System.Drawing.Point(521, 59)
        Me.cbTipoCfdi.Name = "cbTipoCfdi"
        Me.cbTipoCfdi.Size = New System.Drawing.Size(216, 28)
        Me.cbTipoCfdi.TabIndex = 563
        '
        'cbIndividualAgrupado
        '
        Me.cbIndividualAgrupado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbIndividualAgrupado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIndividualAgrupado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIndividualAgrupado.FormattingEnabled = True
        Me.cbIndividualAgrupado.Location = New System.Drawing.Point(521, 115)
        Me.cbIndividualAgrupado.Name = "cbIndividualAgrupado"
        Me.cbIndividualAgrupado.Size = New System.Drawing.Size(216, 28)
        Me.cbIndividualAgrupado.TabIndex = 564
        '
        'cbxConsultaHistorica
        '
        Me.cbxConsultaHistorica.AutoSize = True
        Me.cbxConsultaHistorica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxConsultaHistorica.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxConsultaHistorica.ForeColor = System.Drawing.Color.DarkGreen
        Me.cbxConsultaHistorica.Location = New System.Drawing.Point(743, 3)
        Me.cbxConsultaHistorica.Name = "cbxConsultaHistorica"
        Me.cbxConsultaHistorica.Size = New System.Drawing.Size(142, 50)
        Me.cbxConsultaHistorica.TabIndex = 565
        Me.cbxConsultaHistorica.Text = "Consulta histórica"
        Me.cbxConsultaHistorica.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtFechaInicioConsulta, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(891, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(140, 50)
        Me.TableLayoutPanel1.TabIndex = 566
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
        'dtFechaInicioConsulta
        '
        Me.dtFechaInicioConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtFechaInicioConsulta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicioConsulta.Location = New System.Drawing.Point(3, 23)
        Me.dtFechaInicioConsulta.Name = "dtFechaInicioConsulta"
        Me.dtFechaInicioConsulta.Size = New System.Drawing.Size(134, 26)
        Me.dtFechaInicioConsulta.TabIndex = 1
        '
        'cbxSoloTimbrados
        '
        Me.cbxSoloTimbrados.AutoSize = True
        Me.cbxSoloTimbrados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxSoloTimbrados.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSoloTimbrados.ForeColor = System.Drawing.Color.DarkGreen
        Me.cbxSoloTimbrados.Location = New System.Drawing.Point(891, 115)
        Me.cbxSoloTimbrados.Name = "cbxSoloTimbrados"
        Me.cbxSoloTimbrados.Size = New System.Drawing.Size(142, 54)
        Me.cbxSoloTimbrados.TabIndex = 568
        Me.cbxSoloTimbrados.Text = "Solo timbrados"
        Me.cbxSoloTimbrados.UseVisualStyleBackColor = True
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
        Me.btnCancelaTimbre.Location = New System.Drawing.Point(1326, 5)
        Me.btnCancelaTimbre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelaTimbre.Name = "btnCancelaTimbre"
        Me.btnCancelaTimbre.Size = New System.Drawing.Size(154, 46)
        Me.btnCancelaTimbre.TabIndex = 570
        Me.btnCancelaTimbre.Tag = ""
        Me.btnCancelaTimbre.Text = "Cancelar Timbre"
        Me.btnCancelaTimbre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelaTimbre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelaTimbre.UseVisualStyleBackColor = False
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
        Me.btnTimbrar.Location = New System.Drawing.Point(1100, 5)
        Me.btnTimbrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTimbrar.Name = "btnTimbrar"
        Me.btnTimbrar.Size = New System.Drawing.Size(154, 46)
        Me.btnTimbrar.TabIndex = 569
        Me.btnTimbrar.Text = "Timbrar"
        Me.btnTimbrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTimbrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTimbrar.UseVisualStyleBackColor = False
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackColor = System.Drawing.Color.White
        Me.btnRefrescar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefrescar.Location = New System.Drawing.Point(1100, 117)
        Me.btnRefrescar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(154, 50)
        Me.btnRefrescar.TabIndex = 572
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRefrescar.UseVisualStyleBackColor = False
        '
        'txtMovimiento
        '
        Me.txtMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovimiento.Location = New System.Drawing.Point(151, 115)
        Me.txtMovimiento.Name = "txtMovimiento"
        Me.txtMovimiento.Size = New System.Drawing.Size(216, 26)
        Me.txtMovimiento.TabIndex = 574
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
        Me.tlpBotones.Controls.Add(Me.btnLimpiar, 2, 1)
        Me.tlpBotones.Controls.Add(Me.btnSalir, 5, 1)
        Me.tlpBotones.Controls.Add(Me.cmdNuevo, 1, 1)
        Me.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotones.Location = New System.Drawing.Point(3, 608)
        Me.tlpBotones.Name = "tlpBotones"
        Me.tlpBotones.RowCount = 3
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpBotones.Size = New System.Drawing.Size(1484, 101)
        Me.tlpBotones.TabIndex = 16
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.White
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(345, 21)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(259, 69)
        Me.btnLimpiar.TabIndex = 54
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(1146, 21)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(259, 69)
        Me.btnSalir.TabIndex = 53
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackColor = System.Drawing.Color.White
        Me.cmdNuevo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevo.ForeColor = System.Drawing.Color.Black
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNuevo.Location = New System.Drawing.Point(78, 21)
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(259, 69)
        Me.cmdNuevo.TabIndex = 13
        Me.cmdNuevo.Text = "&Crear"
        Me.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'ColMovimiento
        '
        Me.ColMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColMovimiento.HeaderText = "Movimiento"
        Me.ColMovimiento.MinimumWidth = 6
        Me.ColMovimiento.Name = "ColMovimiento"
        Me.ColMovimiento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColMovimiento.Width = 125
        '
        'ColSucursal
        '
        Me.ColSucursal.HeaderText = "Sucursal"
        Me.ColSucursal.MinimumWidth = 8
        Me.ColSucursal.Name = "ColSucursal"
        Me.ColSucursal.ReadOnly = True
        Me.ColSucursal.Width = 150
        '
        'ColTipoMovimiento
        '
        Me.ColTipoMovimiento.HeaderText = "TipoMovimiento"
        Me.ColTipoMovimiento.MinimumWidth = 8
        Me.ColTipoMovimiento.Name = "ColTipoMovimiento"
        Me.ColTipoMovimiento.ReadOnly = True
        Me.ColTipoMovimiento.Width = 150
        '
        'ColTipoCfdi
        '
        Me.ColTipoCfdi.HeaderText = "Tipo CFDI"
        Me.ColTipoCfdi.MinimumWidth = 8
        Me.ColTipoCfdi.Name = "ColTipoCfdi"
        Me.ColTipoCfdi.ReadOnly = True
        Me.ColTipoCfdi.Width = 150
        '
        'ColFechaCreacion
        '
        Me.ColFechaCreacion.HeaderText = "Fecha"
        Me.ColFechaCreacion.MinimumWidth = 8
        Me.ColFechaCreacion.Name = "ColFechaCreacion"
        Me.ColFechaCreacion.ReadOnly = True
        Me.ColFechaCreacion.Width = 150
        '
        'ColEstatusCartaPorte
        '
        Me.ColEstatusCartaPorte.HeaderText = "Estatus"
        Me.ColEstatusCartaPorte.MinimumWidth = 8
        Me.ColEstatusCartaPorte.Name = "ColEstatusCartaPorte"
        Me.ColEstatusCartaPorte.ReadOnly = True
        Me.ColEstatusCartaPorte.Width = 150
        '
        'ColUsuarioCreo
        '
        Me.ColUsuarioCreo.HeaderText = "Id usuario"
        Me.ColUsuarioCreo.MinimumWidth = 8
        Me.ColUsuarioCreo.Name = "ColUsuarioCreo"
        Me.ColUsuarioCreo.ReadOnly = True
        Me.ColUsuarioCreo.Width = 150
        '
        'ColTimbrado
        '
        Me.ColTimbrado.HeaderText = "Timbrado"
        Me.ColTimbrado.MinimumWidth = 8
        Me.ColTimbrado.Name = "ColTimbrado"
        Me.ColTimbrado.ReadOnly = True
        Me.ColTimbrado.Width = 150
        '
        'ColUuid
        '
        Me.ColUuid.HeaderText = "UUID"
        Me.ColUuid.MinimumWidth = 8
        Me.ColUuid.Name = "ColUuid"
        Me.ColUuid.ReadOnly = True
        Me.ColUuid.Width = 150
        '
        'frmAbcCartaPorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1490, 712)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.Name = "frmAbcCartaPorte"
        Me.Text = "Cartas Porte"
        Me.tlpPrincipal.ResumeLayout(False)
        CType(Me.dgvCartasPorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPanelFiltros.ResumeLayout(False)
        Me.tlpPanelFiltros.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents dgvCartasPorte As DataGridView
    Friend WithEvents tlpPanelFiltros As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents cbSucursal As ComboBox
    Friend WithEvents cbTipoMovimiento As ComboBox
    Friend WithEvents cbEstatus As ComboBox
    Friend WithEvents cbTipoCfdi As ComboBox
    Friend WithEvents cbIndividualAgrupado As ComboBox
    Friend WithEvents cbxConsultaHistorica As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Private WithEvents btnExportaExcel As Button
    Private WithEvents btnRefrescar As Button
    Private WithEvents BtnXML As Button
    Private WithEvents btnCancelaTimbre As Button
    Private WithEvents btnTimbrar As Button
    Friend WithEvents cbxSoloTimbrados As CheckBox
    Friend WithEvents tlpBotones As TableLayoutPanel
    Private WithEvents btnSalir As Button
    Private WithEvents cmdNuevo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMovimiento As TextBox
    Private WithEvents btnLimpiar As Button
    Friend WithEvents dtFechaFinConsulta As DateTimePicker
    Friend WithEvents dtFechaInicioConsulta As DateTimePicker
    Friend WithEvents ColMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents ColSucursal As DataGridViewTextBoxColumn
    Friend WithEvents ColTipoMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents ColTipoCfdi As DataGridViewTextBoxColumn
    Friend WithEvents ColFechaCreacion As DataGridViewTextBoxColumn
    Friend WithEvents ColEstatusCartaPorte As DataGridViewTextBoxColumn
    Friend WithEvents ColUsuarioCreo As DataGridViewTextBoxColumn
    Friend WithEvents ColTimbrado As DataGridViewCheckBoxColumn
    Friend WithEvents ColUuid As DataGridViewTextBoxColumn
End Class
