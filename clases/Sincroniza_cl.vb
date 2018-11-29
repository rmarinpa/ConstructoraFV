Imports MySql.Data.MySqlClient
Public Class Sincroniza_cl

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Function listar(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM identificacion_obra where id_obra = " & id_obra & "", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar_remoto(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar_remoto()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM identificacion_obra where sincroniza <> 0  and id_obra = " & id_obra & "", nue_conexion.conex_remoto())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar_remoto()
        listar_remoto = nue_var.dt
        Return listar_remoto
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal nombre_faena As String, ByVal prof_residente As String, ByVal rut_prof_residente As String, ByVal jefe_oficina As String, ByVal gerente_cargo As String, ByVal mandante As String, ByVal num_resolucion As String, ByVal fecha_resol As Date, ByVal fecha_inicio As Date, ByVal plazo As Double, ByVal fecha_fin As Date, ByVal monto As Double, ByVal Detalle_Obra As String)
        nue_var.consulta = "INSERT INTO identificacion_obra (sincroniza, version, nombre_obra, id_obra, nombre_faena, prof_residente, rut_prof_residente, jefe_oficina, gerente_cargo, mandante, num_resolucion, fecha_resol, fecha_inicio, plazo, fecha_fin, monto, Detalle_Obra) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?nombre_faena, ?prof_residente, ?rut_prof_residente, ?jefe_oficina, ?gerente_cargo, ?mandante, ?num_resolucion, ?fecha_resol, ?fecha_inicio, ?plazo, ?fecha_fin, ?monto, ?Detalle_Obra)"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
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
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_remoto()
            nue_var.consulta = "SELECT MAX(Id_identificacion) from identificacion_obra"
            Try
                nue_conexion.conectar_remoto()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(Id_identificacion)")
                End If
                nue_var.dr.Close()
                nue_conexion.desconectar_remoto()

            Catch mierror As MySqlException
                MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
            End Try
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar_remoto(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal nombre_faena As String, ByVal prof_residente As String, ByVal rut_prof_residente As String, ByVal jefe_oficina As String, ByVal gerente_cargo As String, ByVal mandante As String, ByVal num_resolucion As String, ByVal fecha_resol As Date, ByVal fecha_inicio As Date, ByVal plazo As Double, ByVal fecha_fin As Date, ByVal monto As Double, ByVal Detalle_Obra As String)
        nue_var.consulta = "INSERT INTO identificacion_obra (sincroniza, version, nombre_obra, id_obra, nombre_faena, prof_residente, rut_prof_residente, jefe_oficina, gerente_cargo, mandante, num_resolucion, fecha_resol, fecha_inicio, plazo, fecha_fin, monto, Detalle_Obra) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?nombre_faena, ?prof_residente, ?rut_prof_residente, ?jefe_oficina, ?gerente_cargo, ?mandante, ?num_resolucion, ?fecha_resol, ?fecha_inicio, ?plazo, ?fecha_fin, ?monto, ?Detalle_Obra)"
        Try
            nue_conexion.conectar_local()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
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
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_local()
            nue_var.consulta = "SELECT MAX(Id_identificacion) from identificacion_obra"
            Try
                nue_conexion.conectar_local()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(Id_identificacion)")
                End If
                nue_var.dr.Close()
                nue_conexion.desconectar_local()

            Catch mierror As MySqlException
                MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
            End Try
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar_temporal(ByVal Id_seccion As Integer, ByVal Id_secundario As Integer, ByVal Id_obra As Integer, ByVal version As Integer)
        nue_var.consulta = "INSERT INTO sincroniza_temporal (Id_seccion, Id_primario, Id_secundario, Id_obra, version) VALUES(?Id_seccion, ?Id_primario, ?Id_secundario, ?Id_obra, ?version)"
        Try
            nue_conexion.conectar_local()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
            nue_var.cmd.Parameters.Add("?Id_seccion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_seccion
            nue_var.cmd.Parameters.Add("?Id_primario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = idd_sincroniza
            nue_var.cmd.Parameters.Add("?Id_secundario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_secundario
            nue_var.cmd.Parameters.Add("?Id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_obra
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_local()

        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar_temporal_remoto(ByVal Id_seccion As Integer, ByVal Id_primario As Integer, ByVal Id_obra As Integer, ByVal version As Integer)
        nue_var.consulta = "INSERT INTO sincroniza_temporal (Id_seccion, Id_primario, Id_secundario, Id_obra, version) VALUES(?Id_seccion, ?Id_primario, ?Id_secundario, ?Id_obra, ?version)"
        Try
            nue_conexion.conectar_local()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
            nue_var.cmd.Parameters.Add("?Id_seccion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_seccion
            nue_var.cmd.Parameters.Add("?Id_primario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_primario
            nue_var.cmd.Parameters.Add("?Id_secundario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = idd_sincroniza
            nue_var.cmd.Parameters.Add("?Id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_obra
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_local()

        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar(ByVal Id_identificacion As Integer, ByVal sincroniza As Integer)
        nue_var.consulta = "UPDATE identificacion_obra SET sincroniza = ?sincroniza WHERE Id_identificacion = ?Id_identificacion"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Id_identificacion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_identificacion
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
   
    Public Sub modificar_remoto(ByVal Id_identificacion As Integer, ByVal sincroniza As Integer)
        nue_var.consulta = "UPDATE identificacion_obra SET sincroniza = ?sincroniza WHERE Id_identificacion = ?Id_identificacion"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
            nue_var.cmd.Parameters.Add("?Id_identificacion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_identificacion
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_remoto()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar_modifica(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar_remoto()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM identificacion_obra where sincroniza <> 0  and sincroniza <> 1 and id_obra = " & id_obra & "", nue_conexion.conex_remoto())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar_remoto()
        listar_modifica = nue_var.dt
        Return listar_modifica
    End Function
    Public Function listar_temporal(ByVal id_seccion As Integer, ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM sincroniza_temporal where Id_seccion = " & id_seccion & " and Id_obra = " & id_obra & "", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar_temporal = nue_var.dt
        Return listar_temporal
    End Function
    Public Sub modificar_tabla(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal nombre_faena As String, ByVal prof_residente As String, ByVal rut_prof_residente As String, ByVal jefe_oficina As String, ByVal gerente_cargo As String, ByVal mandante As String, ByVal num_resolucion As String, ByVal fecha_resol As Date, ByVal fecha_inicio As Date, ByVal plazo As Double, ByVal fecha_fin As Date, ByVal monto As Double, ByVal Detalle_Obra As String)
        nue_var.consulta = "UPDATE identificacion_obra SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, nombre_faena = ?nombre_faena, prof_residente = ?prof_residente, rut_prof_residente = ?rut_prof_residente, jefe_oficina = ?jefe_oficina,  gerente_cargo = ?gerente_cargo,  mandante = ?mandante, num_resolucion = ?num_resolucion, fecha_resol = ?fecha_resol, fecha_inicio = ?fecha_inicio, plazo = ?plazo, fecha_fin = ?fecha_fin, monto = ?monto, Detalle_Obra = ?Detalle_Obra WHERE Id_identificacion = ?Cod_identifica"
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
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar_eliminar(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
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
    Public Function consultar_id(ByVal Id_seccion As Integer, ByVal Id_obra As Integer, ByVal Id_secundario As Integer) As Integer
        nue_var.consulta = "SELECT Id_primario FROM sincroniza_temporal WHERE Id_seccion = ?Id_seccion and Id_obra = ?Id_obra and Id_secundario = ?Id_secundario"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Id_seccion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_seccion
        nue_var.cmd.Parameters.Add("?Id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_obra
        nue_var.cmd.Parameters.Add("?Id_secundario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_secundario
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            consultar_id = nue_var.dr("Id_primario")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return consultar_id
    End Function
    Public Function verificar_version(ByVal Id_seccion As Integer, ByVal Id_obra As Integer, ByVal Id_secundario As Integer, ByVal version As Integer) As Integer
        nue_var.consulta = "SELECT Id_primario FROM sincroniza_temporal WHERE Id_seccion = ?Id_seccion and Id_obra = ?Id_obra and Id_secundario = ?Id_secundario and version = ?version"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Id_seccion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_seccion
        nue_var.cmd.Parameters.Add("?Id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_obra
        nue_var.cmd.Parameters.Add("?Id_secundario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_secundario
        nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_version = 0
        Else
            verificar_version = 1
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_version
    End Function
    Public Sub modificar_remoto2(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal nombre_faena As String, ByVal prof_residente As String, ByVal rut_prof_residente As String, ByVal jefe_oficina As String, ByVal gerente_cargo As String, ByVal mandante As String, ByVal num_resolucion As String, ByVal fecha_resol As Date, ByVal fecha_inicio As Date, ByVal plazo As Double, ByVal fecha_fin As Date, ByVal monto As Double, ByVal Detalle_Obra As String)
        nue_var.consulta = "UPDATE identificacion_obra SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, nombre_faena = ?nombre_faena, prof_residente = ?prof_residente, rut_prof_residente = ?rut_prof_residente, jefe_oficina = ?jefe_oficina,  gerente_cargo = ?gerente_cargo,  mandante = ?mandante, num_resolucion = ?num_resolucion, fecha_resol = ?fecha_resol, fecha_inicio = ?fecha_inicio, plazo = ?plazo, fecha_fin = ?fecha_fin, monto = ?monto, Detalle_Obra = ?Detalle_Obra WHERE Id_identificacion = ?Cod_identifica"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
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
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_remoto()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar_temporal(ByVal Id_seccion As Integer, ByVal Id_primario As Integer, ByVal Id_secundario As Integer, ByVal Id_obra As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE sincroniza_temporal SET version = ?version WHERE Id_seccion = ?Id_seccion and Id_primario = ?Id_primario and Id_secundario = ?Id_secundario"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Id_seccion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_seccion
            nue_var.cmd.Parameters.Add("?Id_primario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_primario
            nue_var.cmd.Parameters.Add("?Id_secundario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_secundario
            nue_var.cmd.Parameters.Add("?Id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_obra
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function verificar_version2(ByVal Id_identificacion As Integer, ByVal Id_obra As Integer) As Integer
        nue_var.consulta = "SELECT version FROM identificacion_obra WHERE Id_identificacion = ?Id_identificacion and id_obra = ?Id_obra"
        nue_conexion.conectar_remoto()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
        nue_var.cmd.Parameters.Add("?Id_identificacion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_identificacion
        nue_var.cmd.Parameters.Add("?Id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_version2 = nue_var.dr("version")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar_remoto()
        Return verificar_version2
    End Function
    Public Function verificar_version3(ByVal Id_seccion As Integer, ByVal Id_obra As Integer, ByVal Id_secundario As Integer) As Integer
        nue_var.consulta = "SELECT version FROM sincroniza_temporal WHERE Id_seccion = ?Id_seccion and Id_obra = ?Id_obra and Id_secundario = ?Id_secundario"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Id_seccion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_seccion
        nue_var.cmd.Parameters.Add("?Id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_obra
        nue_var.cmd.Parameters.Add("?Id_secundario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_secundario
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_version3 = nue_var.dr("version")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_version3
    End Function
    Public Sub modificar_temporal2(ByVal Id_seccion As Integer, ByVal Id_secundario As Integer, ByVal Id_obra As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE sincroniza_temporal SET version = ?version WHERE Id_seccion = ?Id_seccion and Id_secundario = ?Id_secundario"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Id_seccion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_seccion
            nue_var.cmd.Parameters.Add("?Id_secundario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_secundario
            nue_var.cmd.Parameters.Add("?Id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_obra
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
