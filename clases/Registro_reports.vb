Imports MySql.Data.MySqlClient
Public Class Registro_reports

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Sub insertar_report(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal dias_trabajados As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal total_horas As Double, ByVal Panne_Descuentos As Double, ByVal Total_horas_con_desc As Double, ByVal M3 As Double, ByVal distancia_recorrida As Double, ByVal Observaciones As String, ByVal id_equipo As Integer, ByVal Operador As String, ByVal turno As Integer)
        nue_var.consulta = "INSERT INTO mov_tierra_v2 (sincroniza, version, nombre_obra, id_obra, Fecha, Codigo, N_de_report, dias_trabajados, Hor_inicial, Hor_final, total_horas, Panne_Descuentos, Total_horas_con_desc, M3, distancia_recorrida, Observaciones, id_equipo, Operador, turno) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha, ?Codigo, ?N_de_report, ?dias_trabajados, ?Hor_inicial, ?Hor_final, ?total_horas, ?Panne_Descuentos, ?Total_horas_con_desc, ?M3, ?distancia_recorrida, ?Observaciones, ?id_equipo, ?Operador, ?turno)"
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
    Public Sub modificar_report(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal dias_trabajados As Double, ByVal Hor_inicial As Double, ByVal Hor_final As Double, ByVal total_horas As Double, ByVal Panne_Descuentos As Double, ByVal Total_horas_con_desc As Double, ByVal M3 As Double, ByVal distancia_recorrida As Double, ByVal Observaciones As String, ByVal id_equipo As Integer, ByVal Operador As String, ByVal turno As Integer)
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
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar6(ByVal fecha As String, ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM fecha_reports where Fecha = '" & fecha & "' and id_obra = " & id_obra & " and (sincroniza <> 3 or isnull(sincroniza)) order by codigo, turno asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar7(ByVal fecha_inicio As String, ByVal fecha_final As String, ByVal id_obra As Integer, ByVal id_equipo As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM fecha_reports where Fecha >= '" & fecha_inicio & "' and Fecha <= '" & fecha_final & "' and id_obra = " & id_obra & " and id_equipo like '" & id_equipo & "' and (sincroniza <> 3 or isnull(sincroniza)) order by Fecha, codigo, turno asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Function verificar_codigo(ByVal id_obra As Integer, ByVal codigo As String) As Integer
        nue_var.consulta = "SELECT * FROM equipos WHERE id_obra = ?id_obra and codigo = ?codigo and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_codigo = 1
        Else
            verificar_codigo = 0
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_codigo
    End Function
    Public Function verificar_registro(ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal N_de_report As Double, ByVal turno As Integer) As Integer
        nue_var.consulta = "SELECT * FROM mov_tierra_v2 WHERE id_obra = ?id_obra and Fecha = ?Fecha and sincroniza <> 3 and Codigo = ?Codigo and N_de_report = ?N_de_report and turno = ?turno"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.cmd.Parameters.Add("?N_de_report", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_report
        nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_registro = 1
        Else
            verificar_registro = 0
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_registro
    End Function

    Public Sub eliminar_report(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from mov_tierra_v2 WHERE Id_Mov_Tierra = " & cod_1 & ""
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
