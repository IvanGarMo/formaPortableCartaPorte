<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncorporarMovimientos
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
        Me.dgvMovimiento = New System.Windows.Forms.DataGridView()
        Me.lblFiltro1 = New System.Windows.Forms.Label()
        Me.lblFiltro2 = New System.Windows.Forms.Label()
        Me.lblFiltro3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.cbFiltroNivel1 = New System.Windows.Forms.ComboBox()
        Me.cbFiltroNivel2 = New System.Windows.Forms.ComboBox()
        Me.cbFiltroNivel3 = New System.Windows.Forms.ComboBox()
        Me.dtFechaInicioBusqueda = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaFinBusqueda = New System.Windows.Forms.DateTimePicker()
        Me.ColSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFiltroNivelUno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFiltroNivelDos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFiltroNivelTres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTooltip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDisponible = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tlpPrincipal.SuspendLayout()
        CType(Me.dgvMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 3
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpPrincipal.Controls.Add(Me.dgvMovimiento, 0, 0)
        Me.tlpPrincipal.Controls.Add(Me.lblFiltro1, 1, 0)
        Me.tlpPrincipal.Controls.Add(Me.lblFiltro2, 1, 2)
        Me.tlpPrincipal.Controls.Add(Me.lblFiltro3, 1, 4)
        Me.tlpPrincipal.Controls.Add(Me.Label4, 1, 6)
        Me.tlpPrincipal.Controls.Add(Me.Label5, 1, 8)
        Me.tlpPrincipal.Controls.Add(Me.btnBuscar, 1, 10)
        Me.tlpPrincipal.Controls.Add(Me.btnFinalizar, 2, 10)
        Me.tlpPrincipal.Controls.Add(Me.cbFiltroNivel1, 1, 1)
        Me.tlpPrincipal.Controls.Add(Me.cbFiltroNivel2, 1, 3)
        Me.tlpPrincipal.Controls.Add(Me.cbFiltroNivel3, 1, 5)
        Me.tlpPrincipal.Controls.Add(Me.dtFechaInicioBusqueda, 1, 7)
        Me.tlpPrincipal.Controls.Add(Me.dtFechaFinBusqueda, 1, 9)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 11
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555556!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(800, 450)
        Me.tlpPrincipal.TabIndex = 0
        '
        'dgvMovimiento
        '
        Me.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColSeleccionar, Me.ColMovimiento, Me.ColFecha, Me.ColFiltroNivelUno, Me.ColFiltroNivelDos, Me.ColFiltroNivelTres, Me.ColTooltip, Me.ColDisponible})
        Me.dgvMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimiento.Location = New System.Drawing.Point(3, 3)
        Me.dgvMovimiento.Name = "dgvMovimiento"
        Me.dgvMovimiento.RowHeadersVisible = False
        Me.dgvMovimiento.RowHeadersWidth = 62
        Me.tlpPrincipal.SetRowSpan(Me.dgvMovimiento, 11)
        Me.dgvMovimiento.RowTemplate.Height = 28
        Me.dgvMovimiento.Size = New System.Drawing.Size(554, 444)
        Me.dgvMovimiento.TabIndex = 0
        '
        'lblFiltro1
        '
        Me.lblFiltro1.AutoSize = True
        Me.tlpPrincipal.SetColumnSpan(Me.lblFiltro1, 2)
        Me.lblFiltro1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFiltro1.Location = New System.Drawing.Point(563, 0)
        Me.lblFiltro1.Name = "lblFiltro1"
        Me.lblFiltro1.Size = New System.Drawing.Size(234, 24)
        Me.lblFiltro1.TabIndex = 1
        Me.lblFiltro1.Text = "lblFiltro1"
        '
        'lblFiltro2
        '
        Me.lblFiltro2.AutoSize = True
        Me.lblFiltro2.BackColor = System.Drawing.Color.Transparent
        Me.tlpPrincipal.SetColumnSpan(Me.lblFiltro2, 2)
        Me.lblFiltro2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFiltro2.Location = New System.Drawing.Point(563, 73)
        Me.lblFiltro2.Name = "lblFiltro2"
        Me.lblFiltro2.Size = New System.Drawing.Size(234, 24)
        Me.lblFiltro2.TabIndex = 2
        Me.lblFiltro2.Text = "lblFiltro2"
        '
        'lblFiltro3
        '
        Me.lblFiltro3.AutoSize = True
        Me.tlpPrincipal.SetColumnSpan(Me.lblFiltro3, 2)
        Me.lblFiltro3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFiltro3.Location = New System.Drawing.Point(563, 146)
        Me.lblFiltro3.Name = "lblFiltro3"
        Me.lblFiltro3.Size = New System.Drawing.Size(234, 24)
        Me.lblFiltro3.TabIndex = 3
        Me.lblFiltro3.Text = "lblFiltro3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.tlpPrincipal.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(563, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha de inicio búsqueda:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.tlpPrincipal.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(563, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha fin búsqueda:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBuscar.Location = New System.Drawing.Point(563, 368)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(114, 79)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFinalizar.Location = New System.Drawing.Point(683, 368)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(114, 79)
        Me.btnFinalizar.TabIndex = 7
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'cbFiltroNivel1
        '
        Me.tlpPrincipal.SetColumnSpan(Me.cbFiltroNivel1, 2)
        Me.cbFiltroNivel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbFiltroNivel1.FormattingEnabled = True
        Me.cbFiltroNivel1.Location = New System.Drawing.Point(563, 27)
        Me.cbFiltroNivel1.Name = "cbFiltroNivel1"
        Me.cbFiltroNivel1.Size = New System.Drawing.Size(234, 28)
        Me.cbFiltroNivel1.TabIndex = 8
        '
        'cbFiltroNivel2
        '
        Me.tlpPrincipal.SetColumnSpan(Me.cbFiltroNivel2, 2)
        Me.cbFiltroNivel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbFiltroNivel2.FormattingEnabled = True
        Me.cbFiltroNivel2.Location = New System.Drawing.Point(563, 100)
        Me.cbFiltroNivel2.Name = "cbFiltroNivel2"
        Me.cbFiltroNivel2.Size = New System.Drawing.Size(234, 28)
        Me.cbFiltroNivel2.TabIndex = 9
        '
        'cbFiltroNivel3
        '
        Me.tlpPrincipal.SetColumnSpan(Me.cbFiltroNivel3, 2)
        Me.cbFiltroNivel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbFiltroNivel3.FormattingEnabled = True
        Me.cbFiltroNivel3.Location = New System.Drawing.Point(563, 173)
        Me.cbFiltroNivel3.Name = "cbFiltroNivel3"
        Me.cbFiltroNivel3.Size = New System.Drawing.Size(234, 28)
        Me.cbFiltroNivel3.TabIndex = 10
        '
        'dtFechaInicioBusqueda
        '
        Me.tlpPrincipal.SetColumnSpan(Me.dtFechaInicioBusqueda, 2)
        Me.dtFechaInicioBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtFechaInicioBusqueda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicioBusqueda.Location = New System.Drawing.Point(563, 246)
        Me.dtFechaInicioBusqueda.Name = "dtFechaInicioBusqueda"
        Me.dtFechaInicioBusqueda.Size = New System.Drawing.Size(234, 26)
        Me.dtFechaInicioBusqueda.TabIndex = 11
        '
        'dtFechaFinBusqueda
        '
        Me.tlpPrincipal.SetColumnSpan(Me.dtFechaFinBusqueda, 2)
        Me.dtFechaFinBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtFechaFinBusqueda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinBusqueda.Location = New System.Drawing.Point(563, 319)
        Me.dtFechaFinBusqueda.Name = "dtFechaFinBusqueda"
        Me.dtFechaFinBusqueda.Size = New System.Drawing.Size(234, 26)
        Me.dtFechaFinBusqueda.TabIndex = 12
        '
        'ColSeleccionar
        '
        Me.ColSeleccionar.HeaderText = "Seleccionado"
        Me.ColSeleccionar.MinimumWidth = 8
        Me.ColSeleccionar.Name = "ColSeleccionar"
        Me.ColSeleccionar.Width = 150
        '
        'ColMovimiento
        '
        Me.ColMovimiento.HeaderText = "Movimiento"
        Me.ColMovimiento.MinimumWidth = 8
        Me.ColMovimiento.Name = "ColMovimiento"
        Me.ColMovimiento.ReadOnly = True
        Me.ColMovimiento.Width = 150
        '
        'ColFecha
        '
        Me.ColFecha.HeaderText = "Fecha"
        Me.ColFecha.MinimumWidth = 8
        Me.ColFecha.Name = "ColFecha"
        Me.ColFecha.ReadOnly = True
        Me.ColFecha.Width = 150
        '
        'ColFiltroNivelUno
        '
        Me.ColFiltroNivelUno.HeaderText = "FiltroNivelUno"
        Me.ColFiltroNivelUno.MinimumWidth = 8
        Me.ColFiltroNivelUno.Name = "ColFiltroNivelUno"
        Me.ColFiltroNivelUno.ReadOnly = True
        Me.ColFiltroNivelUno.Width = 150
        '
        'ColFiltroNivelDos
        '
        Me.ColFiltroNivelDos.HeaderText = "FiltroNivelDos"
        Me.ColFiltroNivelDos.MinimumWidth = 8
        Me.ColFiltroNivelDos.Name = "ColFiltroNivelDos"
        Me.ColFiltroNivelDos.ReadOnly = True
        Me.ColFiltroNivelDos.Width = 150
        '
        'ColFiltroNivelTres
        '
        Me.ColFiltroNivelTres.HeaderText = "FiltroNivelTres"
        Me.ColFiltroNivelTres.MinimumWidth = 8
        Me.ColFiltroNivelTres.Name = "ColFiltroNivelTres"
        Me.ColFiltroNivelTres.ReadOnly = True
        Me.ColFiltroNivelTres.Width = 150
        '
        'ColTooltip
        '
        Me.ColTooltip.HeaderText = "Tooltip"
        Me.ColTooltip.MinimumWidth = 8
        Me.ColTooltip.Name = "ColTooltip"
        Me.ColTooltip.ReadOnly = True
        Me.ColTooltip.Visible = False
        Me.ColTooltip.Width = 150
        '
        'ColDisponible
        '
        Me.ColDisponible.HeaderText = "Disponible"
        Me.ColDisponible.MinimumWidth = 8
        Me.ColDisponible.Name = "ColDisponible"
        Me.ColDisponible.ReadOnly = True
        Me.ColDisponible.Visible = False
        Me.ColDisponible.Width = 150
        '
        'frmIncorporarMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.Name = "frmIncorporarMovimientos"
        Me.Text = "Incorporar movimientos"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        CType(Me.dgvMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents dgvMovimiento As DataGridView
    Friend WithEvents lblFiltro1 As Label
    Friend WithEvents lblFiltro2 As Label
    Friend WithEvents lblFiltro3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents cbFiltroNivel1 As ComboBox
    Friend WithEvents cbFiltroNivel2 As ComboBox
    Friend WithEvents cbFiltroNivel3 As ComboBox
    Friend WithEvents dtFechaInicioBusqueda As DateTimePicker
    Friend WithEvents dtFechaFinBusqueda As DateTimePicker
    Friend WithEvents ColSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents ColMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents ColFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColFiltroNivelUno As DataGridViewTextBoxColumn
    Friend WithEvents ColFiltroNivelDos As DataGridViewTextBoxColumn
    Friend WithEvents ColFiltroNivelTres As DataGridViewTextBoxColumn
    Friend WithEvents ColTooltip As DataGridViewTextBoxColumn
    Friend WithEvents ColDisponible As DataGridViewCheckBoxColumn
End Class
