Imports System.Data.SqlClient

Public Class ConexionesCartaPorte
    Private mockConexion As SqlConnection

    Public Function Get_ObtenParametros() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenParametros", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenPaises(ByVal opcionPorDefecto As Boolean) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenPaises", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenDescripcionPais(ByVal cadPais As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenDescripcionPais", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClavePais", cadPais)
        Cm.Parameters("@ParCadClavePais").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionPais", SqlDbType.VarChar, 200)
        Cm.Parameters("@ParCadDescripcionPais").Direction = ParameterDirection.Output

        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionPais").Value
    End Function

    Public Function Get_ObtenEstados(ByVal opcionPorDefecto As Boolean, ByVal cadPais As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenEstadosPais", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadPais", cadPais)
        Cm.Parameters("@ParCadPais").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenMunicipiosPorEstado(ByVal opcionPorDefecto As Boolean,
                                                            ByVal cadEstado As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenMunicipiosEstado", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadEstado", cadEstado)
        Cm.Parameters("@ParCadEstado").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenLocalidadesPorEstado(ByVal opcionPorDefecto As Boolean,
                                                           ByVal cadEstado As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenLocalidadesEstado", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadEstado", cadEstado)
        Cm.Parameters("@ParCadEstado").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenColoniasPorCodigoPostal(ByVal opcionPorDefecto As Boolean,
                                                           ByVal codigoPostal As String) As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenColoniasCodigoPostal", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParBitOpcionPorDefecto", opcionPorDefecto)
        Cm.Parameters("@ParBitOpcionPorDefecto").Direction = ParameterDirection.Input

        Cm.Parameters.AddWithValue("@ParCadCodigoPostal", codigoPostal)
        Cm.Parameters("@ParCadCodigoPostal").Direction = ParameterDirection.Input

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenDescripcionPorClaveProdServ(ByRef claveProdServ As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_CargaDescripcionProducto", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveProdServ", claveProdServ)
        Cm.Parameters("@ParCadClaveProdServ").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionProdServ", SqlDbType.VarChar, 1000)
        Cm.Parameters("@ParCadDescripcionProdServ").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionProdServ").Value
    End Function

    Public Function Get_ClaveUnidadPeso(ByRef clave As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ClaveUnidadPeso", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveUnidad", clave)
        Cm.Parameters("@ParCadClaveUnidad").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionClaveUnidad", SqlDbType.VarChar, 1000)
        Cm.Parameters("@ParCadDescripcionClaveUnidad").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionClaveUnidad").Value
    End Function

    Public Function Get_DescripcionMoneda(ByRef clave As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenDescripcionMoneda", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveMoneda", clave)
        Cm.Parameters("@ParCadClaveMoneda").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionMoneda", SqlDbType.VarChar, 1000)
        Cm.Parameters("@ParCadDescripcionMoneda").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionMoneda").Value
    End Function

    Public Function Get_ObtenPosiblesDimensiones() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenOpcionesDimensiones", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenPosiblesTiposRemolque() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_TiposRemolque", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenDescripcionPorTipoSubRemolque(ByRef claveTransporte As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_CargaDescripcionTipoTransporte", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClaveTransporte", claveTransporte)
        Cm.Parameters("@ParCadClaveTransporte").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcionTransporte", SqlDbType.VarChar, 1000)
        Cm.Parameters("@ParCadDescripcionTransporte").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcionTransporte").Value
    End Function

    Public Function Get_OpcionesPropiedadTransporte() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_CargaPropiedadTransporte", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_OpcionesTipoPermiso() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CCP_ObtenTiposPermiso", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_OpcionesConfiguracionVehicular() As DataTable
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CPP_CargaConfiguracionAutoTransporte", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Dim sqlAdapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        sqlAdapter.Fill(dataSet)
        Return dataSet.Tables(0)
    End Function

    Public Function Get_ObtenDescripcionConfiguracionAutoTransporte(ByRef claveConf As String) As String
        Dim Cm As SqlCommand = Nothing
        Cm = New SqlCommand("sat.SP_CPP_CargaDescripcionConfigAutoTransporte", mockConexion)
        Cm.CommandType = CommandType.StoredProcedure

        Cm.Parameters.AddWithValue("@ParCadClave", claveConf)
        Cm.Parameters("@ParCadClave").Direction = ParameterDirection.Input

        Cm.Parameters.Add("@ParCadDescripcion", SqlDbType.VarChar, 2000)
        Cm.Parameters("@ParCadDescripcion").Direction = ParameterDirection.Output
        Cm.ExecuteNonQuery()
        Return Cm.Parameters("@ParCadDescripcion").Value
    End Function
End Class
