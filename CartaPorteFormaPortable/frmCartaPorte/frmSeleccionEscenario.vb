Public Class frmSeleccionEscenario

    Private conexion As ConexionesCartaPorte
    Private _escenarios As DataTable
    Private _empresa As String

    Public Sub New()
        InitializeComponent()
        conexion = New ConexionesCartaPorte()
    End Sub

    Private Sub CreaOpciones()
        Dim opciones As DataTable = conexion.Get_DescripcionEscenario(True, _empresa)
        _escenarios = opciones

        Dim indiceRow As Int16 = 1
        Dim indiceColumna As Int16 = 1

        For Each r As DataRow In opciones.Rows
            Dim rb As New RadioButton
            rb.Text = r("descripcionEscenario").ToString()
            TableLayoutPanel1.Controls.Add(rb)
            TableLayoutPanel1.SetColumn(rb, indiceColumna)
            TableLayoutPanel1.SetRow(rb, indiceRow)
            TableLayoutPanel1.SetColumnSpan(rb, 2)
            indiceRow = indiceRow + 1
            rb.Dock = DockStyle.Fill
            rb.Show()
        Next
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim drEscenario As DataRow = Nothing
        For Each c As Control In TableLayoutPanel1.Controls
            If c.GetType() IsNot GetType(RadioButton) Then Continue For
            Dim rb As RadioButton = CType(c, RadioButton)
            If rb.Checked Then
                Dim texto As String = rb.Text
                drEscenario = EncuentraRow(texto)
                If drEscenario Is Nothing Then Exit Sub
                Dim preguntaMediosPropiosTerceros As Boolean = CType(drEscenario("preguntaMediosPropiosTerceros").ToString(), Boolean)
                If preguntaMediosPropiosTerceros Then
                    Dim frm As New frmInicioProcesoCartaPorte(drEscenario)
                    frm.Show()
                Else
                    Dim frm As New frmCartaPorte(drEscenario("idEmpresa").ToString(), CInt(drEscenario("idEscenario")), drEscenario)
                    frm.TopLevel = False
                    TableLayoutPanel1.Controls.Add(frm)
                    TableLayoutPanel1.SetRow(frm, 1)
                    TableLayoutPanel1.SetColumn(frm, 1)
                    TableLayoutPanel1.SetColumnSpan(frm, TableLayoutPanel1.ColumnCount)
                    TableLayoutPanel1.SetRowSpan(frm, TableLayoutPanel1.RowCount - 1)
                    frm.Dock = DockStyle.Fill
                    frm.Show()
                End If
            End If
        Next
    End Sub

    Private Function EncuentraRow(ByRef descrEscenario As String) As DataRow
        For Each r As DataRow In _escenarios.Rows
            If r("descripcionEscenario").ToString().Equals(descrEscenario) Then
                Return r
            End If
        Next
        Return Nothing
    End Function

    Private Sub frmSeleccionEscenario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreaOpciones()
    End Sub
End Class