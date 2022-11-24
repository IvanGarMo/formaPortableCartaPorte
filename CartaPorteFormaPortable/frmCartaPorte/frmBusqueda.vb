Imports System.Text.RegularExpressions

Public Class frmBusqueda
    Delegate Function BuscarDetalle(ByRef clave As String) As DataTable
    Private consulta As BuscarDetalle
    Private claveSeleccionada As String = String.Empty
    Private nombreSeleccionado As String = String.Empty
    Public Event ElementoSeleccionado(ByVal clave As String)

    Public Sub New(ByRef consulta As BuscarDetalle)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.consulta = consulta
    End Sub

    Private Sub frmBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindGrid()
    End Sub

    Private Sub BindGrid()
        claveSeleccionada = String.Empty
        lblTitulo.Text = "No se ha seleccionado ningún elemento"
        lblClaveUnidad.Text = "Clave: -"
        lblDescripcion.Text = "Descripción: -"

        Dim clave = Regex.Replace(Trim(txtDescripcionBuscar.Text), " {2,}", " ")
        Dim datos As DataTable = consulta.Invoke(clave)

        'dgvDescripcionProductos.DataSource = Nothing
        'If dgvDescripcionProductos.Rows IsNot Nothing Then
        '    dgvDescripcionProductos.Rows.Clear()
        'End If

        dgvDescripcionProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDescripcionProductos.Columns(0).DataPropertyName = "clave"
        dgvDescripcionProductos.Columns(1).DataPropertyName = "descripcion"
        dgvDescripcionProductos.DataSource = datos
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Trim(txtDescripcionBuscar.Text).Length > 30 Then
            MsgBox("El texto de búsqueda no puede exceder de 30 caracteres", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        BindGrid()
    End Sub

    Private Sub dgvDescripcionProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescripcionProductos.CellContentClick
        If e.RowIndex >= 0 Then
            Dim dataRow = dgvDescripcionProductos.Rows(e.RowIndex)
            claveSeleccionada = dataRow.Cells(0).Value
            nombreSeleccionado = dataRow.Cells(1).Value
            lblTitulo.Text = "Datos encontrados"
            lblClaveUnidad.Text = "Clave: " + claveSeleccionada
            lblDescripcion.Text = nombreSeleccionado
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent ElementoSeleccionado(claveSeleccionada)
        Me.Close()
    End Sub

    Private Sub txtDescripcionBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcionBuscar.KeyDown
        If e.KeyCode = Keys.Tab Or e.KeyCode = Keys.Enter Then
            btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub
End Class