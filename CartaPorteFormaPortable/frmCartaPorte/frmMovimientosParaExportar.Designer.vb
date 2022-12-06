<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientosParaExportar
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
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMercanciasMovimiento = New System.Windows.Forms.Label()
        Me.btnBuscarMovimientoPadre = New System.Windows.Forms.Button()
        Me.btnBuscarMovimientoIntermedio = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.txtIdMovimientoIntermedio = New System.Windows.Forms.TextBox()
        Me.txtIdMovimientoPadre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.MovimientosTipoMovimientoClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosIdUbicacionClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosRfcClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosNombreClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosCpClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosDetalleBtnClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvMercanciasDeMovimiento = New System.Windows.Forms.DataGridView()
        Me.MercClaveProdServClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercDescripcionClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercClaveUnidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercPesoEnKgClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercValorClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.lblDescripcionEscenario = New System.Windows.Forms.Label()
        Me.tlpPrincipal.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMercanciasDeMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 5
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipal.Controls.Add(Me.Label1, 0, 0)
        Me.tlpPrincipal.Controls.Add(Me.Label2, 0, 2)
        Me.tlpPrincipal.Controls.Add(Me.lblMercanciasMovimiento, 0, 4)
        Me.tlpPrincipal.Controls.Add(Me.btnBuscarMovimientoPadre, 4, 0)
        Me.tlpPrincipal.Controls.Add(Me.btnBuscarMovimientoIntermedio, 4, 1)
        Me.tlpPrincipal.Controls.Add(Me.btnCancelar, 4, 6)
        Me.tlpPrincipal.Controls.Add(Me.btnExportar, 2, 6)
        Me.tlpPrincipal.Controls.Add(Me.txtIdMovimientoIntermedio, 3, 1)
        Me.tlpPrincipal.Controls.Add(Me.txtIdMovimientoPadre, 3, 0)
        Me.tlpPrincipal.Controls.Add(Me.Label4, 2, 0)
        Me.tlpPrincipal.Controls.Add(Me.Label5, 2, 1)
        Me.tlpPrincipal.Controls.Add(Me.dgvMovimientos, 0, 3)
        Me.tlpPrincipal.Controls.Add(Me.dgvMercanciasDeMovimiento, 0, 5)
        Me.tlpPrincipal.Controls.Add(Me.btnReiniciar, 3, 6)
        Me.tlpPrincipal.Controls.Add(Me.lblDescripcionEscenario, 1, 0)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 7
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(1051, 627)
        Me.tlpPrincipal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exportación de movimientos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Movimientos incluidos"
        '
        'lblMercanciasMovimiento
        '
        Me.lblMercanciasMovimiento.AutoSize = True
        Me.lblMercanciasMovimiento.Location = New System.Drawing.Point(3, 343)
        Me.lblMercanciasMovimiento.Name = "lblMercanciasMovimiento"
        Me.lblMercanciasMovimiento.Size = New System.Drawing.Size(198, 31)
        Me.lblMercanciasMovimiento.TabIndex = 2
        Me.lblMercanciasMovimiento.Text = "No hay ningún movimiento seleccionado"
        '
        'btnBuscarMovimientoPadre
        '
        Me.btnBuscarMovimientoPadre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBuscarMovimientoPadre.Location = New System.Drawing.Point(843, 3)
        Me.btnBuscarMovimientoPadre.Name = "btnBuscarMovimientoPadre"
        Me.btnBuscarMovimientoPadre.Size = New System.Drawing.Size(205, 56)
        Me.btnBuscarMovimientoPadre.TabIndex = 5
        Me.btnBuscarMovimientoPadre.Text = "Buscar movimiento"
        Me.btnBuscarMovimientoPadre.UseVisualStyleBackColor = True
        '
        'btnBuscarMovimientoIntermedio
        '
        Me.btnBuscarMovimientoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBuscarMovimientoIntermedio.Location = New System.Drawing.Point(843, 65)
        Me.btnBuscarMovimientoIntermedio.Name = "btnBuscarMovimientoIntermedio"
        Me.btnBuscarMovimientoIntermedio.Size = New System.Drawing.Size(205, 56)
        Me.btnBuscarMovimientoIntermedio.TabIndex = 6
        Me.btnBuscarMovimientoIntermedio.Text = "Buscar movimiento"
        Me.btnBuscarMovimientoIntermedio.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelar.Location = New System.Drawing.Point(843, 565)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(205, 59)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExportar.Location = New System.Drawing.Point(423, 565)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(204, 59)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'txtIdMovimientoIntermedio
        '
        Me.txtIdMovimientoIntermedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIdMovimientoIntermedio.Location = New System.Drawing.Point(633, 65)
        Me.txtIdMovimientoIntermedio.Name = "txtIdMovimientoIntermedio"
        Me.txtIdMovimientoIntermedio.Size = New System.Drawing.Size(204, 26)
        Me.txtIdMovimientoIntermedio.TabIndex = 8
        '
        'txtIdMovimientoPadre
        '
        Me.txtIdMovimientoPadre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIdMovimientoPadre.Location = New System.Drawing.Point(633, 3)
        Me.txtIdMovimientoPadre.Name = "txtIdMovimientoPadre"
        Me.txtIdMovimientoPadre.Size = New System.Drawing.Size(204, 26)
        Me.txtIdMovimientoPadre.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(423, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 62)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Movimiento padre:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(423, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 62)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Movimientos intermedios:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovimientosTipoMovimientoClm, Me.MovimientosIdUbicacionClm, Me.MovimientosRfcClm, Me.MovimientosNombreClm, Me.MovimientosCpClm, Me.MovimientosDetalleBtnClm})
        Me.tlpPrincipal.SetColumnSpan(Me.dgvMovimientos, 5)
        Me.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimientos.Location = New System.Drawing.Point(3, 158)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.RowHeadersVisible = False
        Me.dgvMovimientos.RowHeadersWidth = 62
        Me.dgvMovimientos.RowTemplate.Height = 28
        Me.dgvMovimientos.Size = New System.Drawing.Size(1045, 182)
        Me.dgvMovimientos.TabIndex = 11
        '
        'MovimientosTipoMovimientoClm
        '
        Me.MovimientosTipoMovimientoClm.HeaderText = "TipoUbicacion"
        Me.MovimientosTipoMovimientoClm.MinimumWidth = 8
        Me.MovimientosTipoMovimientoClm.Name = "MovimientosTipoMovimientoClm"
        Me.MovimientosTipoMovimientoClm.ReadOnly = True
        Me.MovimientosTipoMovimientoClm.Width = 150
        '
        'MovimientosIdUbicacionClm
        '
        Me.MovimientosIdUbicacionClm.HeaderText = "IdUbicacion"
        Me.MovimientosIdUbicacionClm.MinimumWidth = 8
        Me.MovimientosIdUbicacionClm.Name = "MovimientosIdUbicacionClm"
        Me.MovimientosIdUbicacionClm.ReadOnly = True
        Me.MovimientosIdUbicacionClm.Width = 150
        '
        'MovimientosRfcClm
        '
        Me.MovimientosRfcClm.HeaderText = "Rfc"
        Me.MovimientosRfcClm.MinimumWidth = 8
        Me.MovimientosRfcClm.Name = "MovimientosRfcClm"
        Me.MovimientosRfcClm.ReadOnly = True
        Me.MovimientosRfcClm.Width = 150
        '
        'MovimientosNombreClm
        '
        Me.MovimientosNombreClm.HeaderText = "Nombre o razón social"
        Me.MovimientosNombreClm.MinimumWidth = 8
        Me.MovimientosNombreClm.Name = "MovimientosNombreClm"
        Me.MovimientosNombreClm.ReadOnly = True
        Me.MovimientosNombreClm.Width = 150
        '
        'MovimientosCpClm
        '
        Me.MovimientosCpClm.HeaderText = "CP"
        Me.MovimientosCpClm.MinimumWidth = 8
        Me.MovimientosCpClm.Name = "MovimientosCpClm"
        Me.MovimientosCpClm.ReadOnly = True
        Me.MovimientosCpClm.Width = 150
        '
        'MovimientosDetalleBtnClm
        '
        Me.MovimientosDetalleBtnClm.HeaderText = "Ver detalle"
        Me.MovimientosDetalleBtnClm.MinimumWidth = 8
        Me.MovimientosDetalleBtnClm.Name = "MovimientosDetalleBtnClm"
        Me.MovimientosDetalleBtnClm.Text = "Detalle"
        Me.MovimientosDetalleBtnClm.ToolTipText = "Ver detalle del movimiento"
        Me.MovimientosDetalleBtnClm.UseColumnTextForButtonValue = True
        Me.MovimientosDetalleBtnClm.Width = 150
        '
        'dgvMercanciasDeMovimiento
        '
        Me.dgvMercanciasDeMovimiento.AllowUserToAddRows = False
        Me.dgvMercanciasDeMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMercanciasDeMovimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MercClaveProdServClm, Me.MercDescripcionClm, Me.MercClaveUnidadClm, Me.MercPesoEnKgClm, Me.MercValorClm})
        Me.tlpPrincipal.SetColumnSpan(Me.dgvMercanciasDeMovimiento, 5)
        Me.dgvMercanciasDeMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMercanciasDeMovimiento.Location = New System.Drawing.Point(3, 377)
        Me.dgvMercanciasDeMovimiento.Name = "dgvMercanciasDeMovimiento"
        Me.dgvMercanciasDeMovimiento.RowHeadersVisible = False
        Me.dgvMercanciasDeMovimiento.RowHeadersWidth = 62
        Me.dgvMercanciasDeMovimiento.RowTemplate.Height = 28
        Me.dgvMercanciasDeMovimiento.Size = New System.Drawing.Size(1045, 182)
        Me.dgvMercanciasDeMovimiento.TabIndex = 12
        '
        'MercClaveProdServClm
        '
        Me.MercClaveProdServClm.HeaderText = "ClaveProdServ"
        Me.MercClaveProdServClm.MinimumWidth = 8
        Me.MercClaveProdServClm.Name = "MercClaveProdServClm"
        Me.MercClaveProdServClm.ReadOnly = True
        Me.MercClaveProdServClm.Width = 150
        '
        'MercDescripcionClm
        '
        Me.MercDescripcionClm.HeaderText = "Descripcion"
        Me.MercDescripcionClm.MinimumWidth = 8
        Me.MercDescripcionClm.Name = "MercDescripcionClm"
        Me.MercDescripcionClm.ReadOnly = True
        Me.MercDescripcionClm.Width = 150
        '
        'MercClaveUnidadClm
        '
        Me.MercClaveUnidadClm.HeaderText = "ClaveUnidad"
        Me.MercClaveUnidadClm.MinimumWidth = 8
        Me.MercClaveUnidadClm.Name = "MercClaveUnidadClm"
        Me.MercClaveUnidadClm.ReadOnly = True
        Me.MercClaveUnidadClm.Width = 150
        '
        'MercPesoEnKgClm
        '
        Me.MercPesoEnKgClm.HeaderText = "Peso (kg.)"
        Me.MercPesoEnKgClm.MinimumWidth = 8
        Me.MercPesoEnKgClm.Name = "MercPesoEnKgClm"
        Me.MercPesoEnKgClm.ReadOnly = True
        Me.MercPesoEnKgClm.Width = 150
        '
        'MercValorClm
        '
        Me.MercValorClm.HeaderText = "Valor"
        Me.MercValorClm.MinimumWidth = 8
        Me.MercValorClm.Name = "MercValorClm"
        Me.MercValorClm.ReadOnly = True
        Me.MercValorClm.Width = 150
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReiniciar.Location = New System.Drawing.Point(633, 565)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(204, 59)
        Me.btnReiniciar.TabIndex = 15
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'lblDescripcionEscenario
        '
        Me.lblDescripcionEscenario.AutoSize = True
        Me.lblDescripcionEscenario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcionEscenario.Location = New System.Drawing.Point(213, 0)
        Me.lblDescripcionEscenario.Name = "lblDescripcionEscenario"
        Me.lblDescripcionEscenario.Size = New System.Drawing.Size(204, 62)
        Me.lblDescripcionEscenario.TabIndex = 16
        Me.lblDescripcionEscenario.Text = "lblDescripcionEscenario"
        '
        'frmMovimientosParaExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpPrincipal)
        Me.Name = "frmMovimientosParaExportar"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMercanciasDeMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMercanciasMovimiento As Label
    Friend WithEvents btnBuscarMovimientoPadre As Button
    Friend WithEvents btnBuscarMovimientoIntermedio As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents txtIdMovimientoIntermedio As TextBox
    Friend WithEvents txtIdMovimientoPadre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvMovimientos As DataGridView
    Friend WithEvents dgvMercanciasDeMovimiento As DataGridView
    Friend WithEvents MercClaveProdServClm As DataGridViewTextBoxColumn
    Friend WithEvents MercDescripcionClm As DataGridViewTextBoxColumn
    Friend WithEvents MercClaveUnidadClm As DataGridViewTextBoxColumn
    Friend WithEvents MercPesoEnKgClm As DataGridViewTextBoxColumn
    Friend WithEvents MercValorClm As DataGridViewTextBoxColumn
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents MovimientosTipoMovimientoClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientosIdUbicacionClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientosRfcClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientosNombreClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientosCpClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientosDetalleBtnClm As DataGridViewButtonColumn
    Friend WithEvents lblDescripcionEscenario As Label
End Class
