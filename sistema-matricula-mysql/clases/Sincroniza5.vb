Imports MySql.Data.MySqlClient
Public Class Sincroniza5

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Function listar(ByVal id_obra As Integer, ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM mov_tierra_v2 where id_obra = " & id_obra & " and Fecha >= '" & fecha & "'", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar_remoto(ByVal id_obra As Integer, ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar_remoto()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM mov_tierra_v2 where sincroniza <> 0  and id_obra = " & id_obra & " and Fecha >= '" & fecha & "'", nue_conexion.conex_remoto())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar_remoto()
        listar_remoto = nue_var.dt
        Return listar_remoto
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal dias_trabajados As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal total_horas As Double, ByVal Panne_Descuentos As Double, ByVal Total_horas_con_desc As Double, ByVal M3 As Double, ByVal distancia_recorrida As Double, ByVal Observaciones As String, ByVal id_equipo As Integer, ByVal Operador As String, ByVal turno As Integer)
        nue_var.consulta = "INSERT INTO mov_tierra_v2 (sincroniza, version, nombre_obra, id_obra, Fecha, Codigo, N_de_report, dias_trabajados, Hor_inicial, Hor_final, total_horas, Panne_Descuentos, Total_horas_con_desc, M3, distancia_recorrida, Observaciones, id_equipo, Operador, turno) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha, ?Codigo, ?N_de_report, ?dias_trabajados, ?Hor_inicial, ?Hor_final, ?total_horas, ?Panne_Descuentos, ?Total_horas_con_desc, ?M3, ?distancia_recorrida, ?Observaciones, ?id_equipo, ?Operador, ?turno)"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?N_de_report", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_report
            nue_var.cmd.Parameters.Add("?dias_trabajados", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_trabajados
            nue_var.cmd.Parameters.Add("?Hor_inicial", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_inicial
            nue_var.cmd.Parameters.Add("?Hor_final", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_final
            nue_var.cmd.Parameters.Add("?total_horas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_horas
            nue_var.cmd.Parameters.Add("?Panne_Descuentos", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Panne_Descuentos
            nue_var.cmd.Parameters.Add("?Total_horas_con_desc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_horas_con_desc
            nue_var.cmd.Parameters.Add("?M3", MySql.Data.MySqlClient.MySqlDbType.Double).Value = M3
            nue_var.cmd.Parameters.Add("?distancia_recorrida", MySql.Data.MySqlClient.MySqlDbType.Double).Value = distancia_recorrida
            nue_var.cmd.Parameters.Add("?Observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Observaciones
            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
            nue_var.cmd.Parameters.Add("?Operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Operador
            'nue_var.cmd.Parameters.Add("?Form_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Form_2
            'nue_var.cmd.Parameters.Add("?viajes", MySql.Data.MySqlClient.MySqlDbType.Double).Value = viajes
            'nue_var.cmd.Parameters.Add("?tipo_viaje", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_viaje
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_remoto()
            nue_var.consulta = "SELECT MAX(Id_Mov_Tierra) from mov_tierra_v2"
            Try
                nue_conexion.conectar_remoto()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(Id_Mov_Tierra)")
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
    Public Sub insertar_remoto(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal dias_trabajados As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal total_horas As Double, ByVal Panne_Descuentos As Double, ByVal Total_horas_con_desc As Double, ByVal M3 As Double, ByVal distancia_recorrida As Double, ByVal Observaciones As String, ByVal id_equipo As Integer, ByVal Operador As String, ByVal turno As Integer)
        nue_var.consulta = "INSERT INTO mov_tierra_v2 (sincroniza, version, nombre_obra, id_obra, Fecha, Codigo, N_de_report, dias_trabajados, Hor_inicial, Hor_final, total_horas, Panne_Descuentos, Total_horas_con_desc, M3, distancia_recorrida, Observaciones, id_equipo, Operador, turno) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha, ?Codigo, ?N_de_report, ?dias_trabajados, ?Hor_inicial, ?Hor_final, ?total_horas, ?Panne_Descuentos, ?Total_horas_con_desc, ?M3, ?distancia_recorrida, ?Observaciones, ?id_equipo, ?Operador, ?turno)"
        Try
            nue_conexion.conectar_local()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?N_de_report", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_report
            nue_var.cmd.Parameters.Add("?dias_trabajados", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_trabajados
            nue_var.cmd.Parameters.Add("?Hor_inicial", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_inicial
            nue_var.cmd.Parameters.Add("?Hor_final", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_final
            nue_var.cmd.Parameters.Add("?total_horas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_horas
            nue_var.cmd.Parameters.Add("?Panne_Descuentos", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Panne_Descuentos
            nue_var.cmd.Parameters.Add("?Total_horas_con_desc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_horas_con_desc
            nue_var.cmd.Parameters.Add("?M3", MySql.Data.MySqlClient.MySqlDbType.Double).Value = M3
            nue_var.cmd.Parameters.Add("?distancia_recorrida", MySql.Data.MySqlClient.MySqlDbType.Double).Value = distancia_recorrida
            nue_var.cmd.Parameters.Add("?Observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Observaciones
            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
            nue_var.cmd.Parameters.Add("?Operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Operador
            'nue_var.cmd.Parameters.Add("?Form_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Form_2
            'nue_var.cmd.Parameters.Add("?viajes", MySql.Data.MySqlClient.MySqlDbType.Double).Value = viajes
            'nue_var.cmd.Parameters.Add("?tipo_viaje", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_viaje
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_local()
            nue_var.consulta = "SELECT MAX(Id_Mov_Tierra) from mov_tierra_v2"
            Try
                nue_conexion.conectar_local()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(Id_Mov_Tierra)")
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
        nue_var.consulta = "UPDATE mov_tierra_v2 SET sincroniza = ?sincroniza WHERE Id_Mov_Tierra = ?Id_identificacion"
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
        nue_var.consulta = "UPDATE mov_tierra_v2 SET sincroniza = ?sincroniza WHERE Id_Mov_Tierra = ?Id_identificacion"
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
    Public Function listar_modifica(ByVal id_obra As Integer, ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar_remoto()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM mov_tierra_v2 where sincroniza <> 0  and sincroniza <> 1 and id_obra = " & id_obra & " and Fecha >= '" & fecha & "'", nue_conexion.conex_remoto())
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
    Public Sub modificar_tabla(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal dias_trabajados As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal total_horas As Double, ByVal Panne_Descuentos As Double, ByVal Total_horas_con_desc As Double, ByVal M3 As Double, ByVal distancia_recorrida As Double, ByVal Observaciones As String, ByVal id_equipo As Integer, ByVal Operador As String, ByVal turno As Integer)
        nue_var.consulta = "UPDATE mov_tierra_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Fecha = ?Fecha, Codigo = ?Codigo, N_de_report = ?N_de_report, dias_trabajados = ?dias_trabajados, Hor_inicial = ?Hor_inicial, Hor_final = ?Hor_final, total_horas = ?total_horas, Panne_Descuentos = ?Panne_Descuentos, Total_horas_con_desc = ?Total_horas_con_desc, M3 = ?M3, distancia_recorrida = ?distancia_recorrida, Observaciones = ?Observaciones, id_equipo = ?id_equipo, Operador = ?Operador, turno = ?turno WHERE Id_Mov_Tierra = ?Cod_identifica"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?N_de_report", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_report
            nue_var.cmd.Parameters.Add("?dias_trabajados", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_trabajados
            nue_var.cmd.Parameters.Add("?Hor_inicial", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_inicial
            nue_var.cmd.Parameters.Add("?Hor_final", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_final
            nue_var.cmd.Parameters.Add("?total_horas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_horas
            nue_var.cmd.Parameters.Add("?Panne_Descuentos", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Panne_Descuentos
            nue_var.cmd.Parameters.Add("?Total_horas_con_desc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_horas_con_desc
            nue_var.cmd.Parameters.Add("?M3", MySql.Data.MySqlClient.MySqlDbType.Double).Value = M3
            nue_var.cmd.Parameters.Add("?distancia_recorrida", MySql.Data.MySqlClient.MySqlDbType.Double).Value = distancia_recorrida
            nue_var.cmd.Parameters.Add("?Observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Observaciones
            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
            nue_var.cmd.Parameters.Add("?Operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Operador
            'nue_var.cmd.Parameters.Add("?Form_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Form_2
            'nue_var.cmd.Parameters.Add("?viajes", MySql.Data.MySqlClient.MySqlDbType.Double).Value = viajes
            'nue_var.cmd.Parameters.Add("?tipo_viaje", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_viaje
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar_eliminar(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE mov_tierra_v2 SET sincroniza = ?sincroniza, version = ?version WHERE Id_Mov_Tierra = ?Cod_identifica"
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
    Public Sub modificar_remoto2(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal dias_trabajados As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal total_horas As Double, ByVal Panne_Descuentos As Double, ByVal Total_horas_con_desc As Double, ByVal M3 As Double, ByVal distancia_recorrida As Double, ByVal Observaciones As String, ByVal id_equipo As Integer, ByVal Operador As String, ByVal turno As Integer)
        nue_var.consulta = "UPDATE mov_tierra_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Fecha = ?Fecha, Codigo = ?Codigo, N_de_report = ?N_de_report, dias_trabajados = ?dias_trabajados, Hor_inicial = ?Hor_inicial, Hor_final = ?Hor_final, total_horas = ?total_horas, Panne_Descuentos = ?Panne_Descuentos, Total_horas_con_desc = ?Total_horas_con_desc, M3 = ?M3, distancia_recorrida = ?distancia_recorrida, Observaciones = ?Observaciones, id_equipo = ?id_equipo, Operador = ?Operador, turno = ?turno WHERE Id_Mov_Tierra = ?Cod_identifica"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?N_de_report", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_report
            nue_var.cmd.Parameters.Add("?dias_trabajados", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_trabajados
            nue_var.cmd.Parameters.Add("?Hor_inicial", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_inicial
            nue_var.cmd.Parameters.Add("?Hor_final", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Hor_final
            nue_var.cmd.Parameters.Add("?total_horas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = total_horas
            nue_var.cmd.Parameters.Add("?Panne_Descuentos", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Panne_Descuentos
            nue_var.cmd.Parameters.Add("?Total_horas_con_desc", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_horas_con_desc
            nue_var.cmd.Parameters.Add("?M3", MySql.Data.MySqlClient.MySqlDbType.Double).Value = M3
            nue_var.cmd.Parameters.Add("?distancia_recorrida", MySql.Data.MySqlClient.MySqlDbType.Double).Value = distancia_recorrida
            nue_var.cmd.Parameters.Add("?Observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Observaciones
            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
            nue_var.cmd.Parameters.Add("?Operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Operador
            'nue_var.cmd.Parameters.Add("?Form_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Form_2
            'nue_var.cmd.Parameters.Add("?viajes", MySql.Data.MySqlClient.MySqlDbType.Double).Value = viajes
            'nue_var.cmd.Parameters.Add("?tipo_viaje", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_viaje
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno
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
    Public Function verificar_version2(ByVal Id_Mov_Tierra As Integer, ByVal Id_obra As Integer) As Integer
        nue_var.consulta = "SELECT version FROM mov_tierra_v2 WHERE Id_Mov_Tierra = ?Id_Mov_Tierra and id_obra = ?Id_obra"
        nue_conexion.conectar_remoto()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
        nue_var.cmd.Parameters.Add("?Id_Mov_Tierra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_Mov_Tierra
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
End Class
