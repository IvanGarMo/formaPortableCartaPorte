Imports System.Globalization

Public Class frmAbcCartaPorte
    Private _conexiones As ConexionesCartaPorte
    Private _empresa As String
    Public Sub New()
        InitializeComponent()
        _conexiones = New ConexionesCartaPorte
    End Sub

    Private Sub BindCombobox(ByRef refCombo As ComboBox, ByRef fuente As DataTable)
        If refCombo Is Nothing Then
            refCombo = New ComboBox
        End If
        If refCombo.Items IsNot Nothing Then
            refCombo.Items.Clear()
        End If
        refCombo.DataSource = Nothing
        refCombo.Dock = DockStyle.Fill
        refCombo.DisplayMember = "descripcion"
        refCombo.ValueMember = "id"
        refCombo.DataSource = fuente
    End Sub

    Private Sub LimpiaTextbox(ByRef text As TextBox)
        text.Dock = DockStyle.Fill
        text.Text = String.Empty
    End Sub

    Private Sub CargaFiltros()
        Dim datosFiltros As DataSet = _conexiones.Get_PosiblesFiltrosCartaPorte(_empresa)
        BindCombobox(cbSucursal, datosFiltros.Tables(0))
        BindCombobox(cbTipoMovimiento, datosFiltros.Tables(1))
        BindCombobox(cbEstatus, datosFiltros.Tables(2))
        BindCombobox(cbTipoCfdi, datosFiltros.Tables(3))
        BindCombobox(cbIndividualAgrupado, datosFiltros.Tables(4))
        txtMovimiento.Text = String.Empty
        cbxConsultaHistorica.Checked = False
        cbxConsultaHistorica.Checked = False
        dtFechaInicioConsulta.MinDate = DateTime.Parse("01/01/2020", New CultureInfo("es-MX"))
        dtFechaInicioConsulta.MaxDate = DateTime.Now.AddDays(1)
        dtFechaFinConsulta.MinDate = dtFechaInicioConsulta.MinDate
        dtFechaFinConsulta.MaxDate = dtFechaInicioConsulta.MaxDate
        dtFechaInicioConsulta.Value = DateTime.Now.AddDays((DateTime.Now.Day - 1) * -1) 'Esto para que siempre sea inicio de mes
        dtFechaFinConsulta.Value = DateTime.Now
    End Sub

    Private Sub BindGrid(ByRef datos As DataTable)
        dgvCartasPorte.DataSource = Nothing
        If dgvCartasPorte.Rows IsNot Nothing Then
            dgvCartasPorte.Rows.Clear()
        End If

        dgvCartasPorte.AutoGenerateColumns = False
        dgvCartasPorte.AllowUserToAddRows = False
        dgvCartasPorte.RowHeadersVisible = False
        dgvCartasPorte.Columns("ColMovimiento").DataPropertyName = "Movimiento"
        dgvCartasPorte.Columns("ColTipoMovimiento").DataPropertyName = "TipoMovimiento"
        dgvCartasPorte.Columns("ColTipoCfdi").DataPropertyName = "TipoCfdi"
        dgvCartasPorte.Columns("ColFechaCreacion").DataPropertyName = "FechaCreacion"
        dgvCartasPorte.Columns("ColEstatusCartaPorte").DataPropertyName = "Estatus"
        dgvCartasPorte.Columns("ColUsuarioCreo").DataPropertyName = "Usuario"
        dgvCartasPorte.Columns("ColUuid").DataPropertyName = "Uuid"
        dgvCartasPorte.Columns("ColTimbrado").DataPropertyName = "Timbrado"
        dgvCartasPorte.Columns("ColSucursal").DataPropertyName = "Sucursal"
        dgvCartasPorte.DataSource = datos
    End Sub

    Private Sub ReiniciaFiltros()
        CargaFiltros()
        RealizaBusqueda()
    End Sub

    Private Sub RealizaBusqueda()
        Dim idEmpresa As String = _empresa
        Dim idMovimiento As String = Trim(txtMovimiento.Text)
        Dim tipoMovimiento As String = cbTipoMovimiento.SelectedValue
        Dim sucursal As String = cbSucursal.SelectedValue
        Dim estatus As String = cbEstatus.SelectedValue
        Dim tipoCfdi As String = cbTipoCfdi.SelectedValue
        Dim agrupadoIndividual As String = cbIndividualAgrupado.SelectedValue
        Dim consultaHistorica As Boolean = cbxConsultaHistorica.Checked
        Dim fechaInicio As Date = dtFechaInicioConsulta.Value.Date
        Dim fechaFin As Date = dtFechaFinConsulta.Value.Date
        Dim soloTimbrados As Boolean = cbxSoloTimbrados.Checked
        Dim datosGrid As DataTable = _conexiones.Get_ConsultaAbcRelMovimientosCartaPorte(idEmpresa,
                                     idMovimiento, tipoMovimiento, sucursal, estatus,
                                     tipoCfdi, agrupadoIndividual, consultaHistorica,
                                     fechaInicio, fechaFin, soloTimbrados)
        BindGrid(datosGrid)
    End Sub

    Private Sub frmAbcCartaPorte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReiniciaFiltros()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim frmSeleccionEscenario As New frmSeleccionEscenario
        frmSeleccionEscenario.ShowDialog()
    End Sub
End Class