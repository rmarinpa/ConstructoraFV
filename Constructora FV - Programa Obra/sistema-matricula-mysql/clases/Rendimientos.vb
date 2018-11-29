Imports MySql.Data.MySqlClient
Public Class Rendimientos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT DISTINCT(Detalle_equipo) FROM equipos where id_obra = " & id_obra & " and sincroniza <> 3 and Detalle_equipo <> '' order by Detalle_equipo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar2() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("Truncate table mov_tierra_rendimiento", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function

    Public Function listar3() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("INSERT INTO mov_tierra_rendimiento SELECT * FROM mov_tierra_v2", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4(ByVal id_obra As Integer, ByVal fecha_in As String, ByVal fecha_fin As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_fecha where id_obra = " & id_obra & " and Fecha >= '" & fecha_in & "' and Fecha <= '" & fecha_fin & "' order by Fecha asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
    Public Sub insertar_report(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal dias_trabajados As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal total_horas As Double, ByVal Panne_Descuentos As Double, ByVal Total_horas_con_desc As Double, ByVal M3 As Double, ByVal distancia_recorrida As Double, ByVal Observaciones As String, ByVal id_equipo As Integer, ByVal Operador As String, ByVal turno As Integer)
        nue_var.consulta = "INSERT INTO mov_tierra_rendimiento (sincroniza, version, nombre_obra, id_obra, Fecha, Codigo, N_de_report, dias_trabajados, Hor_inicial, Hor_final, total_horas, Panne_Descuentos, Total_horas_con_desc, M3, distancia_recorrida, Observaciones, id_equipo, Operador, turno) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha, ?Codigo, ?N_de_report, ?dias_trabajados, ?Hor_inicial, ?Hor_final, ?total_horas, ?Panne_Descuentos, ?Total_horas_con_desc, ?M3, ?distancia_recorrida, ?Observaciones, ?id_equipo, ?Operador, ?turno)"
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
            nue_var.cmd.Parameters.Add("?Observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Observaciones
            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
            nue_var.cmd.Parameters.Add("?Operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Operador
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno


            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
    Public Function listar5() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("Truncate table tipo_maquina_rendimiento", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Sub insertar_tipo_maquina(ByVal tipo_maquina As String)
        nue_var.consulta = "INSERT INTO tipo_maquina_rendimiento (tipo_maquina) VALUES(?tipo_maquina)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?tipo_maquina", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_maquina
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
End Class
