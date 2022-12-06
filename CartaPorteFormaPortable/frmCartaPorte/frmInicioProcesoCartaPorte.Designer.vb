<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioProcesoCartaPorte
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbConMediosPropios = New System.Windows.Forms.RadioButton()
        Me.rbConProveedor = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tlpPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 3
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpPrincipal.Controls.Add(Me.Button1, 2, 1)
        Me.tlpPrincipal.Controls.Add(Me.Panel1, 1, 0)
        Me.tlpPrincipal.Controls.Add(Me.Label2, 0, 0)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 4
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(800, 450)
        Me.tlpPrincipal.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(539, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbConMediosPropios)
        Me.Panel1.Controls.Add(Me.rbConProveedor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(275, 3)
        Me.Panel1.Name = "Panel1"
        Me.tlpPrincipal.SetRowSpan(Me.Panel1, 2)
        Me.Panel1.Size = New System.Drawing.Size(258, 84)
        Me.Panel1.TabIndex = 3
        '
        'rbConMediosPropios
        '
        Me.rbConMediosPropios.AutoSize = True
        Me.rbConMediosPropios.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbConMediosPropios.Location = New System.Drawing.Point(0, 41)
        Me.rbConMediosPropios.Name = "rbConMediosPropios"
        Me.rbConMediosPropios.Size = New System.Drawing.Size(174, 24)
        Me.rbConMediosPropios.TabIndex = 1
        Me.rbConMediosPropios.TabStop = True
        Me.rbConMediosPropios.Text = "Con medios propios"
        Me.rbConMediosPropios.UseVisualStyleBackColor = True
        '
        'rbConProveedor
        '
        Me.rbConProveedor.AutoSize = True
        Me.rbConProveedor.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbConProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbConProveedor.Location = New System.Drawing.Point(0, 0)
        Me.rbConProveedor.Name = "rbConProveedor"
        Me.rbConProveedor.Size = New System.Drawing.Size(258, 84)
        Me.rbConProveedor.TabIndex = 0
        Me.rbConProveedor.TabStop = True
        Me.rbConProveedor.Text = "Con proveedor"
        Me.rbConProveedor.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbConProveedor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 45)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "El movimiento se efectúa:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmInicioProcesoCartaPorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.Name = "frmInicioProcesoCartaPorte"
        Me.Text = "Generación de Carta Porte"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbConMediosPropios As RadioButton
    Friend WithEvents rbConProveedor As RadioButton
    Friend WithEvents Label2 As Label
End Class
