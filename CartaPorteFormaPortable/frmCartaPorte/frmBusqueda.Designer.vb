<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusqueda
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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvDescripcionProductos = New System.Windows.Forms.DataGridView()
        Me.dgvClaveClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDescripcionClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpDetallesSeleccion = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpBuscarPorDescripcion = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDescripcionBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblClaveUnidad = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tlpMain.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvDescripcionProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDetallesSeleccion.SuspendLayout()
        Me.tlpBuscarPorDescripcion.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlpBuscarPorDescripcion, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(800, 450)
        Me.tlpMain.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgvDescripcionProductos, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tlpDetallesSeleccion, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(794, 354)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'dgvDescripcionProductos
        '
        Me.dgvDescripcionProductos.AllowUserToAddRows = False
        Me.dgvDescripcionProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDescripcionProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvClaveClm, Me.dgvDescripcionClm})
        Me.dgvDescripcionProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDescripcionProductos.Location = New System.Drawing.Point(3, 3)
        Me.dgvDescripcionProductos.Name = "dgvDescripcionProductos"
        Me.dgvDescripcionProductos.RowHeadersVisible = False
        Me.dgvDescripcionProductos.RowHeadersWidth = 62
        Me.dgvDescripcionProductos.RowTemplate.Height = 28
        Me.dgvDescripcionProductos.Size = New System.Drawing.Size(549, 348)
        Me.dgvDescripcionProductos.TabIndex = 0
        '
        'dgvClaveClm
        '
        Me.dgvClaveClm.HeaderText = "Clave"
        Me.dgvClaveClm.MinimumWidth = 8
        Me.dgvClaveClm.Name = "dgvClaveClm"
        Me.dgvClaveClm.ReadOnly = True
        Me.dgvClaveClm.Width = 150
        '
        'dgvDescripcionClm
        '
        Me.dgvDescripcionClm.HeaderText = "Descripcion"
        Me.dgvDescripcionClm.MinimumWidth = 8
        Me.dgvDescripcionClm.Name = "dgvDescripcionClm"
        Me.dgvDescripcionClm.ReadOnly = True
        Me.dgvDescripcionClm.Width = 150
        '
        'tlpDetallesSeleccion
        '
        Me.tlpDetallesSeleccion.ColumnCount = 1
        Me.tlpDetallesSeleccion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDetallesSeleccion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDetallesSeleccion.Controls.Add(Me.lblTitulo, 0, 0)
        Me.tlpDetallesSeleccion.Controls.Add(Me.lblDescripcion, 0, 1)
        Me.tlpDetallesSeleccion.Controls.Add(Me.lblClaveUnidad, 0, 2)
        Me.tlpDetallesSeleccion.Controls.Add(Me.Button1, 0, 3)
        Me.tlpDetallesSeleccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDetallesSeleccion.Location = New System.Drawing.Point(558, 3)
        Me.tlpDetallesSeleccion.Name = "tlpDetallesSeleccion"
        Me.tlpDetallesSeleccion.RowCount = 4
        Me.tlpDetallesSeleccion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpDetallesSeleccion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpDetallesSeleccion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpDetallesSeleccion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDetallesSeleccion.Size = New System.Drawing.Size(233, 348)
        Me.tlpDetallesSeleccion.TabIndex = 1
        '
        'tlpBuscarPorDescripcion
        '
        Me.tlpBuscarPorDescripcion.ColumnCount = 2
        Me.tlpBuscarPorDescripcion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpBuscarPorDescripcion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpBuscarPorDescripcion.Controls.Add(Me.txtDescripcionBuscar, 0, 1)
        Me.tlpBuscarPorDescripcion.Controls.Add(Me.btnBuscar, 1, 1)
        Me.tlpBuscarPorDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBuscarPorDescripcion.Location = New System.Drawing.Point(3, 363)
        Me.tlpBuscarPorDescripcion.Name = "tlpBuscarPorDescripcion"
        Me.tlpBuscarPorDescripcion.RowCount = 3
        Me.tlpBuscarPorDescripcion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBuscarPorDescripcion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpBuscarPorDescripcion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBuscarPorDescripcion.Size = New System.Drawing.Size(794, 84)
        Me.tlpBuscarPorDescripcion.TabIndex = 1
        '
        'txtDescripcionBuscar
        '
        Me.txtDescripcionBuscar.BackColor = System.Drawing.SystemColors.Info
        Me.txtDescripcionBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcionBuscar.Location = New System.Drawing.Point(3, 19)
        Me.txtDescripcionBuscar.Name = "txtDescripcionBuscar"
        Me.txtDescripcionBuscar.Size = New System.Drawing.Size(549, 26)
        Me.txtDescripcionBuscar.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(558, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(233, 44)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.SeaShell
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(227, 69)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "lblTitulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.SeaShell
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 69)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(227, 52)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "lblDescripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClaveUnidad
        '
        Me.lblClaveUnidad.AutoSize = True
        Me.lblClaveUnidad.BackColor = System.Drawing.Color.SeaShell
        Me.lblClaveUnidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClaveUnidad.Location = New System.Drawing.Point(3, 121)
        Me.lblClaveUnidad.Name = "lblClaveUnidad"
        Me.lblClaveUnidad.Size = New System.Drawing.Size(227, 52)
        Me.lblClaveUnidad.TabIndex = 2
        Me.lblClaveUnidad.Text = "lblClaveUnidad"
        Me.lblClaveUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(3, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 49)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "frmBusqueda"
        Me.Text = "Búsqueda de elemento"
        Me.tlpMain.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgvDescripcionProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpDetallesSeleccion.ResumeLayout(False)
        Me.tlpDetallesSeleccion.PerformLayout()
        Me.tlpBuscarPorDescripcion.ResumeLayout(False)
        Me.tlpBuscarPorDescripcion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgvDescripcionProductos As DataGridView
    Friend WithEvents dgvClaveClm As DataGridViewTextBoxColumn
    Friend WithEvents dgvDescripcionClm As DataGridViewTextBoxColumn
    Friend WithEvents tlpDetallesSeleccion As TableLayoutPanel
    Public WithEvents lblTitulo As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblClaveUnidad As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tlpBuscarPorDescripcion As TableLayoutPanel
    Friend WithEvents txtDescripcionBuscar As TextBox
    Friend WithEvents btnBuscar As Button
End Class
