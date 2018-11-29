Imports MySql.Data.MySqlClient
Public Class viajes

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar(ByVal id_obra As Integer, ByVal tipo_viaje As Double) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM viajes_v2 where id_obra = " & id_obra & " and tipo_viaje = " & tipo_viaje & " and sincroniza <> 3 order by ida_vuelta desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal ida_vuelta As String, ByVal kilometraje As Double, ByVal precio_m3_km As Double, ByVal cuenta_costo As String, ByVal tipo_viaje As Double)
        nue_var.consulta = "INSERT INTO viajes_v2 (sincroniza, version, nombre_obra, id_obra, ida_vuelta, kilometraje, precio_m3_km, cuenta_costo, tipo_viaje) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?ida_vuelta, ?kilometraje, ?precio_m3_km, ?cuenta_costo, ?tipo_viaje)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?ida_vuelta", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ida_vuelta
            nue_var.cmd.Parameters.Add("?kilometraje", MySql.Data.MySqlClient.MySqlDbType.Double).Value = kilometraje
            nue_var.cmd.Parameters.Add("?precio_m3_km", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_m3_km
            nue_var.cmd.Parameters.Add("?cuenta_costo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_costo
            nue_var.cmd.Parameters.Add("?tipo_viaje", MySql.Data.MySqlClient.MySqlDbType.Double).Value = tipo_viaje
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub modificar(ByVal Cod_viajes As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal ida_vuelta As String, ByVal kilometraje As Double, ByVal precio_m3_km As Double, ByVal cuenta_costo As String, ByVal tipo_viaje As Double)
        nue_var.consulta = "UPDATE viajes_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, ida_vuelta = ?ida_vuelta, kilometraje = ?kilometraje, precio_m3_km = ?precio_m3_km, cuenta_costo = ?cuenta_costo, tipo_viaje = ?tipo_viaje WHERE Id_viajes = ?Cod_viajes"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_viajes", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_viajes
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?ida_vuelta", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ida_vuelta
            nue_var.cmd.Parameters.Add("?kilometraje", MySql.Data.MySqlClient.MySqlDbType.Double).Value = kilometraje
            nue_var.cmd.Parameters.Add("?precio_m3_km", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_m3_km
            nue_var.cmd.Parameters.Add("?cuenta_costo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_costo
            nue_var.cmd.Parameters.Add("?tipo_viaje", MySql.Data.MySqlClient.MySqlDbType.Double).Value = tipo_viaje
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal Cod_viajes As Integer)
        nue_var.consulta = "Delete from viajes_v2 WHERE Id_viajes = " & Cod_viajes & ""
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
        nue_var.consulta = "UPDATE viajes_v2 SET sincroniza = ?sincroniza, version = ?version WHERE Id_viajes = ?Cod_identifica"
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
    Public Function listar5(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM viajes_v2 where id_obra = " & id_obra & " and sincroniza <> 3 order by ida_vuelta asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Function listar6(ByVal id_obra As Integer, ByVal Id_viajes As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM viajes_v2 where id_obra = " & id_obra & " and Id_viajes = " & Id_viajes & " and sincroniza <> 3 order by ida_vuelta asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar2(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM arrendador_equipos Where id_obra = " & id_obra & " and sincroniza <> 3 and (forma like 'Viajes' or forma like 'M3-KM') order by codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function

    Public Function listar3(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM mov_tierra_v2 where id_obra = " & id_obra & " and Form_2 = 1 and sincroniza <> 3 order by Fecha desc, Codigo desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Sub insertar_report(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal dias_trabajados As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal total_horas As Double, ByVal Panne_Descuentos As Double, ByVal Total_horas_con_desc As Double, ByVal M3 As Double, ByVal distancia_recorrida As Double, ByVal id_equipo As Integer, ByVal Form_2 As String, ByVal Form_3 As String, ByVal viajes As Double, ByVal tipo_viaje As String, ByVal turno As Integer)
        nue_var.consulta = "INSERT INTO mov_tierra_v2 (sincroniza, version, nombre_obra, id_obra, Fecha, Codigo, N_de_report, dias_trabajados, Hor_inicial, Hor_final, total_horas, Panne_Descuentos, Total_horas_con_desc, M3, distancia_recorrida, id_equipo, Form_2, Form_3, viajes, tipo_viaje, turno) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha, ?Codigo, ?N_de_report, ?dias_trabajados, ?Hor_inicial, ?Hor_final, ?total_horas, ?Panne_Descuentos, ?Total_horas_con_desc, ?M3, ?distancia_recorrida, ?id_equipo, ?Form_2, ?Form_3, ?viajes, ?tipo_viaje, ?turno)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
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
            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
            nue_var.cmd.Parameters.Add("?Form_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Form_2
            nue_var.cmd.Parameters.Add("?Form_3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Form_3
            nue_var.cmd.Parameters.Add("?viajes", MySql.Data.MySqlClient.MySqlDbType.Double).Value = viajes
            nue_var.cmd.Parameters.Add("?tipo_viaje", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_viaje
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub

    Public Sub modificar_report(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal dias_trabajados As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal total_horas As Double, ByVal Panne_Descuentos As Double, ByVal Total_horas_con_desc As Double, ByVal M3 As Double, ByVal distancia_recorrida As Double, ByVal id_equipo As Integer, ByVal Form_2 As String, ByVal Form_3 As String, ByVal viajes As Double, ByVal tipo_viaje As String, ByVal turno As Integer)
        nue_var.consulta = "UPDATE mov_tierra_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Fecha = ?Fecha, Codigo = ?Codigo, N_de_report = ?N_de_report, dias_trabajados = ?dias_trabajados, Hor_inicial = ?Hor_inicial, Hor_final = ?Hor_final, total_horas = ?total_horas, Panne_Descuentos = ?Panne_Descuentos, Total_horas_con_desc = ?Total_horas_con_desc, M3 = ?M3, distancia_recorrida = ?distancia_recorrida, id_equipo = ?id_equipo, Form_2 = ?Form_2, Form_3 = ?Form_3, viajes = ?viajes, tipo_viaje = ?tipo_viaje, turno = ?turno WHERE Id_Mov_Tierra = ?Cod_identifica"
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
            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
            nue_var.cmd.Parameters.Add("?Form_2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Form_2
            nue_var.cmd.Parameters.Add("?Form_3", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Form_3
            nue_var.cmd.Parameters.Add("?viajes", MySql.Data.MySqlClient.MySqlDbType.Double).Value = viajes
            nue_var.cmd.Parameters.Add("?tipo_viaje", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_viaje
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_report(ByVal Cod_viajes As Integer)
        nue_var.consulta = "Delete from mov_tierra_v2 WHERE Id_Mov_Tierra = " & Cod_viajes & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro_report(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
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
    Public Function listar6(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM tabla_plan_de_cuentas Where id_obra = " & id_obra & " and sincroniza <> 3 order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
End Class
