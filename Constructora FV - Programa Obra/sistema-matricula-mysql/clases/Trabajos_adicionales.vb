Imports MySql.Data.MySqlClient
Public Class Trabajos_adicionales

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM descuentos_empresa_v2 where id_obra = " & id_obra & " and sincroniza <> 3 order by Fecha desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Nombre_representante As String, ByVal rut As String, ByVal Clasificacion As String, ByVal Descripcion As String, ByVal Cantidad As Double, ByVal unidad As String, ByVal precio_unitario As Double, ByVal Total As Double, ByVal Cuenta_contable As String, ByVal Fecha As Date)
        nue_var.consulta = "INSERT INTO descuentos_empresa_v2 (sincroniza, version, nombre_obra, id_obra, Nombre_representante, rut, Clasificacion, Descripcion, Cantidad, unidad, precio_unitario, Total, Cuenta_contable, Fecha) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Nombre_representante, ?rut, ?Clasificacion, ?Descripcion, ?Cantidad, ?unidad, ?precio_unitario, ?Total, ?Cuenta_contable, ?Fecha)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?Nombre_representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Nombre_representante
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?Clasificacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Clasificacion
            nue_var.cmd.Parameters.Add("?Descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.Parameters.Add("?Cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Cantidad
            nue_var.cmd.Parameters.Add("?unidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = unidad
            nue_var.cmd.Parameters.Add("?precio_unitario", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_unitario
            nue_var.cmd.Parameters.Add("?Total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total
            nue_var.cmd.Parameters.Add("?Cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_contable
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub modificar(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Nombre_representante As String, ByVal rut As String, ByVal Clasificacion As String, ByVal Descripcion As String, ByVal Cantidad As Double, ByVal unidad As String, ByVal precio_unitario As Double, ByVal Total As Double, ByVal Cuenta_contable As String, ByVal Fecha As Date)
        nue_var.consulta = "UPDATE descuentos_empresa_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Nombre_representante = ?Nombre_representante, rut = ?rut,  Clasificacion = ?Clasificacion, Descripcion = ?Descripcion, Cantidad = ?Cantidad, unidad = ?unidad, precio_unitario = ?precio_unitario, Total = ?Total, Cuenta_contable = ?Cuenta_contable, Fecha = ?Fecha WHERE Id_descuentos = ?Cod_adicional"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_adicional", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_adicional
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?Nombre_representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Nombre_representante
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?Clasificacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Clasificacion
            nue_var.cmd.Parameters.Add("?Descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.Parameters.Add("?Cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Cantidad
            nue_var.cmd.Parameters.Add("?unidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = unidad
            nue_var.cmd.Parameters.Add("?precio_unitario", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_unitario
            nue_var.cmd.Parameters.Add("?Total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total
            nue_var.cmd.Parameters.Add("?Cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_contable
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE descuentos_empresa_v2 SET sincroniza = ?sincroniza, version = ?version WHERE Id_descuentos = ?Cod_adicional"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_adicional", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_adicional
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar6(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM cuentas_detalle Where id_obra = " & id_obra & " and sincroniza <> 3 order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar7(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM arrendador Where id_obra = " & id_obra & " and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Sub eliminar(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from descuentos_empresa_v2 WHERE Id_descuentos = " & cod_1 & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
