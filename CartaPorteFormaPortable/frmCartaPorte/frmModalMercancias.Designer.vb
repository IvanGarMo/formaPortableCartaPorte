<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalMercancias
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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvMercanciasPorMovimiento = New System.Windows.Forms.DataGridView()
        Me.lblMercanciasMovimiento = New System.Windows.Forms.Label()
        Me.MercanciaClaveProdServClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercanciaClasificacionSATClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientoDescripcionClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveUnidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionUnidadClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorMercanciaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercanciaCantidadMercClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MercanciaMovimientoPeligrosaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientoComercioIntClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientoDetallesMercClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MovimientoMercanciaEliminarClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MovimientoMercanciaCheckboxMaterialCheckboxClm = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tlpMain.SuspendLayout()
        CType(Me.dgvMercanciasPorMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.dgvMercanciasPorMovimiento, 0, 1)
        Me.tlpMain.Controls.Add(Me.lblMercanciasMovimiento, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.tlpMain.Size = New System.Drawing.Size(800, 450)
        Me.tlpMain.TabIndex = 0
        '
        'dgvMercanciasPorMovimiento
        '
        Me.dgvMercanciasPorMovimiento.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMercanciasPorMovimiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMercanciasPorMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMercanciasPorMovimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MercanciaClaveProdServClm, Me.MercanciaClasificacionSATClm, Me.MovimientoDescripcionClm, Me.ClaveUnidadClm, Me.DescripcionUnidadClm, Me.ValorMercanciaClm, Me.MercanciaCantidadMercClm, Me.MercanciaMovimientoPeligrosaClm, Me.MovimientoComercioIntClm, Me.MovimientoDetallesMercClm, Me.MovimientoMercanciaEliminarClm, Me.MovimientoMercanciaCheckboxMaterialCheckboxClm})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMercanciasPorMovimiento.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMercanciasPorMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMercanciasPorMovimiento.Location = New System.Drawing.Point(3, 25)
        Me.dgvMercanciasPorMovimiento.Name = "dgvMercanciasPorMovimiento"
        Me.dgvMercanciasPorMovimiento.RowHeadersVisible = False
        Me.dgvMercanciasPorMovimiento.RowHeadersWidth = 62
        Me.dgvMercanciasPorMovimiento.RowTemplate.Height = 28
        Me.dgvMercanciasPorMovimiento.Size = New System.Drawing.Size(794, 422)
        Me.dgvMercanciasPorMovimiento.TabIndex = 2
        Me.dgvMercanciasPorMovimiento.TabStop = False
        '
        'lblMercanciasMovimiento
        '
        Me.lblMercanciasMovimiento.AutoSize = True
        Me.lblMercanciasMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMercanciasMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMercanciasMovimiento.Location = New System.Drawing.Point(3, 0)
        Me.lblMercanciasMovimiento.Name = "lblMercanciasMovimiento"
        Me.lblMercanciasMovimiento.Size = New System.Drawing.Size(794, 22)
        Me.lblMercanciasMovimiento.TabIndex = 0
        Me.lblMercanciasMovimiento.Text = "lblMercanciasMovimiento"
        '
        'MercanciaClaveProdServClm
        '
        Me.MercanciaClaveProdServClm.HeaderText = "ClaveProdServ"
        Me.MercanciaClaveProdServClm.MinimumWidth = 8
        Me.MercanciaClaveProdServClm.Name = "MercanciaClaveProdServClm"
        Me.MercanciaClaveProdServClm.ReadOnly = True
        Me.MercanciaClaveProdServClm.Width = 150
        '
        'MercanciaClasificacionSATClm
        '
        Me.MercanciaClasificacionSATClm.HeaderText = "ClasificacionSAT"
        Me.MercanciaClasificacionSATClm.MinimumWidth = 8
        Me.MercanciaClasificacionSATClm.Name = "MercanciaClasificacionSATClm"
        Me.MercanciaClasificacionSATClm.ReadOnly = True
        Me.MercanciaClasificacionSATClm.Width = 150
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
        'ValorMercanciaClm
        '
        Me.ValorMercanciaClm.HeaderText = "Valor"
        Me.ValorMercanciaClm.MinimumWidth = 8
        Me.ValorMercanciaClm.Name = "ValorMercanciaClm"
        Me.ValorMercanciaClm.ReadOnly = True
        Me.ValorMercanciaClm.Width = 150
        '
        'MercanciaCantidadMercClm
        '
        Me.MercanciaCantidadMercClm.HeaderText = "Cantidad"
        Me.MercanciaCantidadMercClm.MinimumWidth = 8
        Me.MercanciaCantidadMercClm.Name = "MercanciaCantidadMercClm"
        Me.MercanciaCantidadMercClm.ReadOnly = True
        Me.MercanciaCantidadMercClm.Width = 150
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
        'MovimientoMercanciaCheckboxMaterialCheckboxClm
        '
        Me.MovimientoMercanciaCheckboxMaterialCheckboxClm.HeaderText = "CheckboxMaterialPeligroso"
        Me.MovimientoMercanciaCheckboxMaterialCheckboxClm.MinimumWidth = 8
        Me.MovimientoMercanciaCheckboxMaterialCheckboxClm.Name = "MovimientoMercanciaCheckboxMaterialCheckboxClm"
        Me.MovimientoMercanciaCheckboxMaterialCheckboxClm.ReadOnly = True
        Me.MovimientoMercanciaCheckboxMaterialCheckboxClm.Visible = False
        Me.MovimientoMercanciaCheckboxMaterialCheckboxClm.Width = 150
        '
        'frmModalMercancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "frmModalMercancias"
        Me.Text = "Mercancías del movimiento"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        CType(Me.dgvMercanciasPorMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents lblMercanciasMovimiento As Label
    Friend WithEvents dgvMercanciasPorMovimiento As DataGridView
    Friend WithEvents MercanciaClaveProdServClm As DataGridViewTextBoxColumn
    Friend WithEvents MercanciaClasificacionSATClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientoDescripcionClm As DataGridViewTextBoxColumn
    Friend WithEvents ClaveUnidadClm As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionUnidadClm As DataGridViewTextBoxColumn
    Friend WithEvents ValorMercanciaClm As DataGridViewTextBoxColumn
    Friend WithEvents MercanciaCantidadMercClm As DataGridViewTextBoxColumn
    Friend WithEvents MercanciaMovimientoPeligrosaClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientoComercioIntClm As DataGridViewTextBoxColumn
    Friend WithEvents MovimientoDetallesMercClm As DataGridViewButtonColumn
    Friend WithEvents MovimientoMercanciaEliminarClm As DataGridViewButtonColumn
    Friend WithEvents MovimientoMercanciaCheckboxMaterialCheckboxClm As DataGridViewCheckBoxColumn
End Class
