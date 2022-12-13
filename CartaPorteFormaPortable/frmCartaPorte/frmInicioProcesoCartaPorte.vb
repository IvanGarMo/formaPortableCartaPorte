Public Class frmInicioProcesoCartaPorte
    Private _escenario As DataRow
    Private _empresa As String

    Public Sub New(escenario As DataRow)
        InitializeComponent()
        _escenario = escenario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not rbConMediosPropios.Checked AndAlso Not rbConProveedor.Checked Then
            Return
        End If


        For Each ctrl In tlpPrincipal.Controls
            If ctrl.GetType() Is GetType(Form) Then
                tlpPrincipal.Controls.Remove(ctrl)
                Exit For
            End If
        Next

        If rbConMediosPropios.Checked Then
            Dim frmCartaPorte As New frmCartaPorte(_empresa, CInt(_escenario("idEscenario")), _escenario)
            frmCartaPorte.TopLevel = False
            frmCartaPorte.Dock = DockStyle.Fill
            tlpPrincipal.Controls.Add(frmCartaPorte)
            tlpPrincipal.SetColumn(frmCartaPorte, 0)
            tlpPrincipal.SetRow(frmCartaPorte, 2)
            tlpPrincipal.SetColumnSpan(frmCartaPorte, tlpPrincipal.ColumnCount)
            frmCartaPorte.Show()
        Else
            Dim frmExportar As New frmMovimientosParaExportar(_escenario)
            frmExportar.TopLevel = False
            frmExportar.Dock = DockStyle.Fill
            tlpPrincipal.Controls.Add(frmExportar)
            tlpPrincipal.SetColumn(frmExportar, 0)
            tlpPrincipal.SetRow(frmExportar, 2)
            tlpPrincipal.SetColumnSpan(frmExportar, tlpPrincipal.ColumnCount)
            frmExportar.Show()
        End If
    End Sub

    Private Sub frmInicioProcesoCartaPorte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim texto = "Hola"
    End Sub
End Class