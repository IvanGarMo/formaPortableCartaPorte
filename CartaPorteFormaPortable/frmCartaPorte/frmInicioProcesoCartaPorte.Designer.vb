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
        Me.rbConMediosPropios = New System.Windows.Forms.RadioButton()
        Me.rbConProveedor = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 4
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpPrincipal.Controls.Add(Me.Button1, 3, 1)
        Me.tlpPrincipal.Controls.Add(Me.rbConMediosPropios, 1, 1)
        Me.tlpPrincipal.Controls.Add(Me.rbConProveedor, 2, 1)
        Me.tlpPrincipal.Controls.Add(Me.Label1, 0, 1)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 3
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.020202!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.87878!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(800, 450)
        Me.tlpPrincipal.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(643, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbConMediosPropios
        '
        Me.rbConMediosPropios.AutoSize = True
        Me.rbConMediosPropios.Checked = True
        Me.rbConMediosPropios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbConMediosPropios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbConMediosPropios.Location = New System.Drawing.Point(323, 12)
        Me.rbConMediosPropios.Name = "rbConMediosPropios"
        Me.rbConMediosPropios.Size = New System.Drawing.Size(154, 39)
        Me.rbConMediosPropios.TabIndex = 1
        Me.rbConMediosPropios.TabStop = True
        Me.rbConMediosPropios.Text = "Con medios propios"
        Me.rbConMediosPropios.UseVisualStyleBackColor = True
        '
        'rbConProveedor
        '
        Me.rbConProveedor.AutoSize = True
        Me.rbConProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbConProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbConProveedor.Location = New System.Drawing.Point(483, 12)
        Me.rbConProveedor.Name = "rbConProveedor"
        Me.rbConProveedor.Size = New System.Drawing.Size(154, 39)
        Me.rbConProveedor.TabIndex = 0
        Me.rbConProveedor.Text = "Con proveedor"
        Me.rbConProveedor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "El movimiento se efectúa:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents rbConMediosPropios As RadioButton
    Friend WithEvents rbConProveedor As RadioButton
    Friend WithEvents Label1 As Label
End Class
