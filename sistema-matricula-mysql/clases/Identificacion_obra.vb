Imports MySql.Data.MySqlClient
Public Class Identificacion_obra

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal nombre_faena As String, ByVal prof_residente As String, ByVal rut_prof_residente As String, ByVal jefe_oficina As String, ByVal gerente_cargo As String, ByVal mandante As String, ByVal num_resolucion As String, ByVal fecha_resol As Date, ByVal fecha_inicio As Date, ByVal plazo As Double, ByVal fecha_fin As Date, ByVal monto As Double, ByVal Detalle_Obra As String, ByVal retenciones As Double, ByVal proforma As Double)
        nue_var.consulta = "INSERT INTO identificacion_obra (sincroniza, version, nombre_obra, id_obra, nombre_faena, prof_residente, rut_prof_residente, jefe_oficina, gerente_cargo, mandante, num_resolucion, fecha_resol, fecha_inicio, plazo, fecha_fin, monto, Detalle_Obra, retenciones, proforma) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?nombre_faena, ?prof_residente, ?rut_prof_residente, ?jefe_oficina, ?gerente_cargo, ?mandante, ?num_resolucion, ?fecha_resol, ?fecha_inicio, ?plazo, ?fecha_fin, ?monto, ?Detalle_Obra, ?retenciones, ?proforma)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?nombre_faena", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_faena
            nue_var.cmd.Parameters.Add("?prof_residente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = prof_residente
            nue_var.cmd.Parameters.Add("?rut_prof_residente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut_prof_residente
            nue_var.cmd.Parameters.Add("?jefe_oficina", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = jefe_oficina
            nue_var.cmd.Parameters.Add("?gerente_cargo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = gerente_cargo
            nue_var.cmd.Parameters.Add("?mandante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = mandante
            nue_var.cmd.Parameters.Add("?num_resolucion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_resolucion
            nue_var.cmd.Parameters.Add("?fecha_resol", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_resol
            nue_var.cmd.Parameters.Add("?fecha_inicio", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_inicio
            nue_var.cmd.Parameters.Add("?plazo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = plazo
            nue_var.cmd.Parameters.Add("?fecha_fin", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_fin
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.Parameters.Add("?Detalle_Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Detalle_Obra
            nue_var.cmd.Parameters.Add("?retenciones", MySql.Data.MySqlClient.MySqlDbType.Double).Value = retenciones
            nue_var.cmd.Parameters.Add("?proforma", MySql.Data.MySqlClient.MySqlDbType.Double).Value = proforma
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()

        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
    Public Sub modificar(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal nombre_faena As String, ByVal prof_residente As String, ByVal rut_prof_residente As String, ByVal jefe_oficina As String, ByVal gerente_cargo As String, ByVal mandante As String, ByVal num_resolucion As String, ByVal fecha_resol As Date, ByVal fecha_inicio As Date, ByVal plazo As Double, ByVal fecha_fin As Date, ByVal monto As Double, ByVal Detalle_Obra As String, ByVal retenciones As Double, ByVal proforma As Double)
        nue_var.consulta = "UPDATE identificacion_obra SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, nombre_faena = ?nombre_faena, prof_residente = ?prof_residente, rut_prof_residente = ?rut_prof_residente, jefe_oficina = ?jefe_oficina,  gerente_cargo = ?gerente_cargo,  mandante = ?mandante, num_resolucion = ?num_resolucion, fecha_resol = ?fecha_resol, fecha_inicio = ?fecha_inicio, plazo = ?plazo, fecha_fin = ?fecha_fin, monto = ?monto, Detalle_Obra = ?Detalle_Obra, retenciones = ?retenciones, proforma = ?proforma WHERE Id_identificacion = ?Cod_identifica"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?nombre_faena", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_faena
            nue_var.cmd.Parameters.Add("?prof_residente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = prof_residente
            nue_var.cmd.Parameters.Add("?rut_prof_residente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut_prof_residente
            nue_var.cmd.Parameters.Add("?jefe_oficina", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = jefe_oficina
            nue_var.cmd.Parameters.Add("?gerente_cargo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = gerente_cargo
            nue_var.cmd.Parameters.Add("?mandante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = mandante
            nue_var.cmd.Parameters.Add("?num_resolucion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_resolucion
            nue_var.cmd.Parameters.Add("?fecha_resol", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_resol
            nue_var.cmd.Parameters.Add("?fecha_inicio", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_inicio
            nue_var.cmd.Parameters.Add("?plazo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = plazo
            nue_var.cmd.Parameters.Add("?fecha_fin", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_fin
            nue_var.cmd.Parameters.Add("?monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto
            nue_var.cmd.Parameters.Add("?Detalle_Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Detalle_Obra
            nue_var.cmd.Parameters.Add("?retenciones", MySql.Data.MySqlClient.MySqlDbType.Double).Value = retenciones
            nue_var.cmd.Parameters.Add("?proforma", MySql.Data.MySqlClient.MySqlDbType.Double).Value = proforma
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from identificacion_obra WHERE Id_identificacion = " & cod_1 & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE identificacion_obra SET sincroniza = ?sincroniza, version = ?version WHERE Id_identificacion = ?Cod_identifica"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM identificacion_obra Where id_obra = " & id_obra & " and sincroniza <> 3 order by fecha_inicio desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function

    Public Function LeerRetencionesProformas(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("select retenciones, proforma from identificacion_obra where nombre_faena = '" & obra & "' ", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerRetencionesProformas = nue_var.dt
            Return LeerRetencionesProformas
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Function

    Public Function LeerRetencionesProformasModificada(ByVal obra As String) As DataTable
        Try
            Dim Lista As Byte
            nue_var.ds = New DataSet
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("select retencion, proforma from listadomodificaciones where obra = '" & obra & "' ", nue_conexion.conex())
            nue_var.da.Fill(nue_var.ds, "registro")
            Lista = nue_var.ds.Tables("registro").Rows.Count
            nue_conexion.desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Function

End Class
