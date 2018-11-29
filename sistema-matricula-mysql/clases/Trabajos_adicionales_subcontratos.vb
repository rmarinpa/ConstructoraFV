Imports MySql.Data.MySqlClient
Public Class Trabajos_adicionales_subcontratos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM descuentos_subcontratos_v2 where id_obra = " & id_obra & " and sincroniza <> 3 order by Fecha desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal subcontratista As String, ByVal subcontrato As String, ByVal rut As String, ByVal tipo_subcontrato As String, ByVal descripcion As String, ByVal cantidad As Double, ByVal unidad As String, ByVal monto As Double, ByVal total As Double, ByVal cuenta_contable As String, ByVal fecha As Date)
        nue_var.consulta = "INSERT INTO descuentos_subcontratos_v2 (sincroniza, version, nombre_obra, id_obra, subcontratista, subcontrato, rut, tipo_subcontrato, descripcion, cantidad, unidad, monto, total, cuenta_contable, fecha) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?subcontratista, ?subcontrato, ?rut, ?tipo_subcontrato, ?descripcion, ?cantidad, ?unidad, ?monto, ?total, ?cuenta_contable, ?fecha)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?subcontratista", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = subcontratista
            nue_var.cmd.Parameters.Add("?subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = subcontrato
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?unidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = unidad
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.Parameters.Add("?total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_contable
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub modificar(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal subcontratista As String, ByVal subcontrato As String, ByVal rut As String, ByVal tipo_subcontrato As String, ByVal descripcion As String, ByVal cantidad As Double, ByVal unidad As String, ByVal monto As Double, ByVal total As Double, ByVal cuenta_contable As String, ByVal fecha As Date)
        nue_var.consulta = "UPDATE descuentos_subcontratos_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, subcontratista = ?subcontratista, subcontrato = ?subcontrato, rut = ?rut,  tipo_subcontrato = ?tipo_subcontrato, descripcion = ?descripcion, cantidad = ?cantidad, unidad = ?unidad, monto = ?monto, total = ?total, cuenta_contable = ?cuenta_contable, fecha = ?fecha WHERE id_descuentos_subcontratos = ?Cod_adicional"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_adicional", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_adicional
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?subcontratista", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = subcontratista
            nue_var.cmd.Parameters.Add("?subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = subcontrato
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = descripcion
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?unidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = unidad
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.Parameters.Add("?total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_contable
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE descuentos_subcontratos_v2 SET sincroniza = ?sincroniza, version = ?version WHERE id_descuentos_subcontratos = ?Cod_adicional"
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
    Public Sub eliminar(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from descuentos_subcontratos_v2 WHERE id_descuentos_subcontratos = " & cod_1 & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
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
    Public Function listar2(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM nombre_subcontrato Where id_obra = " & id_obra & " order by nombre_subcon asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
End Class
