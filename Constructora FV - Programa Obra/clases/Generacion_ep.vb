Imports MySql.Data.MySqlClient
Public Class Generacion_ep

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar3(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM arrendador Where id_obra = " & id_obra & " and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal id_equipo As Integer, ByVal equipo As String, ByVal num_finiquito As Integer, ByVal adjunto As String, ByVal usuario As String, ByVal fecha As Date, ByVal hora As Date, ByVal id_faena As Integer, ByVal faena As String, ByVal lugar As String, ByVal fecha_celebracion As Date, ByVal rut_arrendador As String, ByVal nombre_arrendador As String, ByVal tipo_de_pago As String, ByVal operador As String, ByVal fecha_termino As Date, ByVal num_contrato As Integer)
        nue_var.consulta = "INSERT INTO equipos_finiquitados (sincroniza, version, nombre_obra, id_obra, id_equipo, equipo, num_finiquito, adjunto, usuario, fecha, hora, id_faena, faena, lugar, fecha_celebracion, rut_arrendador, nombre_arrendador, tipo_de_pago, operador, fecha_termino, num_contrato) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?id_equipo, ?equipo, ?num_finiquito, ?adjunto, ?usuario, ?fecha, ?hora, ?id_faena, ?faena, ?lugar, ?fecha_celebracion, ?rut_arrendador, ?nombre_arrendador, ?tipo_de_pago, ?operador, ?fecha_termino, ?num_contrato)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
            nue_var.cmd.Parameters.Add("?equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = equipo
            nue_var.cmd.Parameters.Add("?num_finiquito", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = num_finiquito
            nue_var.cmd.Parameters.Add("?adjunto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = adjunto
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?id_faena", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_faena
            nue_var.cmd.Parameters.Add("?faena", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = faena
            nue_var.cmd.Parameters.Add("?lugar", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = lugar
            nue_var.cmd.Parameters.Add("?fecha_celebracion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_celebracion
            nue_var.cmd.Parameters.Add("?rut_arrendador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut_arrendador
            nue_var.cmd.Parameters.Add("?nombre_arrendador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_arrendador
            nue_var.cmd.Parameters.Add("?tipo_de_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_pago
            nue_var.cmd.Parameters.Add("?operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = operador
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_termino
            nue_var.cmd.Parameters.Add("?num_contrato", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = num_contrato

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar4(ByVal id_obra As Integer, ByVal rut As String, ByVal fecha_in As String, ByVal fecha_fin As String) As DataTable
        'Public Function listar4() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT Ep_empresa5_v2.Codigo, Ep_empresa5_v2.id_obra, Ep_empresa5_v2.Forma_de_pago, Sum(Ep_empresa5_v2.Total_horas_con_desc) AS SumaDeMinimo, Sum(Ep_empresa5_v2.Expr2) AS SumaDeExpr2, Ep_empresa5_v2.rut, Max(Ep_empresa5_v2.Fecha) AS Fecha, Sum(Ep_empresa5_v2.Min_proporcial) AS SumaDeMin_proporcional, Min(Ep_empresa5_v2.turno_trab) AS turno_trab FROM Ep_empresa5_v2 Where Ep_empresa5_v2.id_obra = " & id_obra & " and Ep_empresa5_v2.rut = '" & rut & "' and Ep_empresa5_v2.Fecha >= '" & fecha_in & "' and Ep_empresa5_v2.Fecha <= '" & fecha_fin & "' GROUP BY Ep_empresa5_v2.Codigo, Ep_empresa5_v2.id_obra, Ep_empresa5_v2.Forma_de_pago, Ep_empresa5_v2.rut", nue_conexion.conex())
        'SELECT SUM(* FROM arrendador Where id_obra = " & id_obra & " and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
    Public Function listar5(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("Delete from Tabla_minimo WHERE id_obra = " & id_obra & "", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Sub insertar_minimos(ByVal Codigo As String, ByVal id_obra As Integer, ByVal Forma_de_Pago As String, ByVal SumaDeMinimo As Double, ByVal SumaDeExpr2 As Double, ByVal rut As String, ByVal Fecha As Date, ByVal dias_mes As Integer, ByVal Minimo_proporcional As Double, ByVal diff_dias As Integer, ByVal turno_trab As Integer)
        nue_var.consulta = "INSERT INTO Tabla_minimo (Codigo, id_obra, Forma_de_Pago, SumaDeMinimo, SumaDeExpr2, rut, Fecha, dias_mes, Minimo_proporcional, diff_dias, turno_trab) VALUES(?Codigo, ?id_obra, ?Forma_de_Pago, ?SumaDeMinimo, ?SumaDeExpr2, ?rut, ?Fecha, ?dias_mes, ?Minimo_proporcional, ?diff_dias, ?turno_trab)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?Forma_de_Pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Forma_de_Pago
            nue_var.cmd.Parameters.Add("?SumaDeMinimo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = SumaDeMinimo
            nue_var.cmd.Parameters.Add("?SumaDeExpr2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = SumaDeExpr2
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?dias_mes", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = dias_mes
            nue_var.cmd.Parameters.Add("?Minimo_proporcional", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Minimo_proporcional
            nue_var.cmd.Parameters.Add("?diff_dias", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = diff_dias
            nue_var.cmd.Parameters.Add("?turno_trab", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno_trab

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar6(ByVal id_obra As Integer, ByVal fecha_in As String, ByVal fecha_fin As String) As DataTable
        'Public Function listar4() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT Ep_empresa5_v2.Codigo, Ep_empresa5_v2.id_obra, Ep_empresa5_v2.Forma_de_pago, Sum(Ep_empresa5_v2.Total_horas_con_desc) AS SumaDeMinimo, Sum(Ep_empresa5_v2.Expr2) AS SumaDeExpr2, Ep_empresa5_v2.rut, Max(Ep_empresa5_v2.Fecha) AS Fecha, Sum(Ep_empresa5_v2.Min_proporcial) AS SumaDeMin_proporcional, Min(Ep_empresa5_v2.turno_trab) AS turno_trab FROM Ep_empresa5_v2 Where Ep_empresa5_v2.id_obra = " & id_obra & " and Ep_empresa5_v2.rut <> '81.220.300-2' and Ep_empresa5_v2.Fecha >= '" & fecha_in & "' and Ep_empresa5_v2.Fecha <= '" & fecha_fin & "' GROUP BY Ep_empresa5_v2.Codigo, Ep_empresa5_v2.id_obra, Ep_empresa5_v2.Forma_de_pago, Ep_empresa5_v2.rut", nue_conexion.conex())
        'SELECT SUM(* FROM arrendador Where id_obra = " & id_obra & " and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar6_2(ByVal id_obra As Integer, ByVal fecha_in As String, ByVal fecha_fin As String) As DataTable
        'Public Function listar4() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT Ep_empresa5_v2.Codigo, Ep_empresa5_v2.id_obra, Ep_empresa5_v2.Forma_de_pago, Sum(Ep_empresa5_v2.Total_horas_con_desc) AS SumaDeMinimo, Sum(Ep_empresa5_v2.Expr2) AS SumaDeExpr2, Ep_empresa5_v2.rut, Max(Ep_empresa5_v2.Fecha) AS Fecha, Sum(Ep_empresa5_v2.Min_proporcial) AS SumaDeMin_proporcional, Min(Ep_empresa5_v2.turno_trab) AS turno_trab FROM Ep_empresa5_v2 Where Ep_empresa5_v2.id_obra = " & id_obra & " and Ep_empresa5_v2.Fecha >= '" & fecha_in & "' and Ep_empresa5_v2.Fecha <= '" & fecha_fin & "' GROUP BY Ep_empresa5_v2.Codigo, Ep_empresa5_v2.id_obra, Ep_empresa5_v2.Forma_de_pago, Ep_empresa5_v2.rut", nue_conexion.conex())
        'SELECT SUM(* FROM arrendador Where id_obra = " & id_obra & " and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6_2 = nue_var.dt
        Return listar6_2
    End Function

    Public Function listar7(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM arrendador where id_obra = " & id_obra & " and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
End Class
