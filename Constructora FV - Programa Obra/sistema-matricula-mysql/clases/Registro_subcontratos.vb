Imports MySql.Data.MySqlClient
Public Class Registro_subcontratos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Sub insertar_report(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal codigo_subcontrato As Integer, ByVal fecha As Date, ByVal representante As String, ByVal tipo_subcontrato As String, ByVal item As String, ByVal avance As Double, ByVal tipo_de_medicion As String, ByVal observaciones As String)
        nue_var.consulta = "INSERT INTO avance_subcontrato_v2 (sincroniza, version, nombre_obra, id_obra, codigo_subcontrato, fecha, representante, tipo_subcontrato, item, avance, tipo_de_medicion, observaciones) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?codigo_subcontrato, ?fecha, ?representante, ?tipo_subcontrato, ?item, ?avance, ?tipo_de_medicion, ?observaciones)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?codigo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = codigo_subcontrato
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?item", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = item
            nue_var.cmd.Parameters.Add("?avance", MySql.Data.MySqlClient.MySqlDbType.Double).Value = avance
            nue_var.cmd.Parameters.Add("?tipo_de_medicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_medicion
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = observaciones

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
    Public Sub modificar_report(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal codigo_subcontrato As Integer, ByVal fecha As Date, ByVal representante As String, ByVal tipo_subcontrato As String, ByVal item As String, ByVal avance As Double, ByVal tipo_de_medicion As String, ByVal observaciones As String)
        nue_var.consulta = "UPDATE avance_subcontrato_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, codigo_subcontrato = ?codigo_subcontrato, fecha = ?fecha, representante = ?representante, tipo_subcontrato = ?tipo_subcontrato, item = ?item, avance = ?avance, tipo_de_medicion = ?tipo_de_medicion, observaciones = ?observaciones WHERE Id_avance_subcontrato = ?Cod_identifica"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?codigo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = codigo_subcontrato
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?tipo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_subcontrato
            nue_var.cmd.Parameters.Add("?item", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = item
            nue_var.cmd.Parameters.Add("?avance", MySql.Data.MySqlClient.MySqlDbType.Double).Value = avance
            nue_var.cmd.Parameters.Add("?tipo_de_medicion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_de_medicion
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Observaciones

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM nombre_subcontrato Where id_obra = " & id_obra & " order by nombre_subcon asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar6(ByVal fecha As String, ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM fecha_avance_v2 where Fecha = '" & fecha & "' and id_obra = " & id_obra & "  and (sincroniza <> 3 or isnull(sincroniza)) order by razon_social, servicio, item asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar7(ByVal fecha1 As String, ByVal fecha2 As String, ByVal fecha3 As String, ByVal id_obra As Integer, ByVal rut As String, ByVal servicio As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM fecha_avance_v2 where (Fecha = '" & fecha1 & "' or Fecha = '" & fecha2 & "' or Fecha = '" & fecha3 & "') and id_obra = " & id_obra & " and rut like '" & rut & "' and servicio like '" & servicio & "' and (sincroniza <> 3 or isnull(sincroniza))  order by Fecha, razon_social, servicio, item asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function

    Public Function total_contratado(ByVal id_obra As Integer, ByVal id_item As Double) As Double
        nue_var.consulta = "SELECT cantidad FROM items_subcon WHERE id_obra = ?id_obra and id_item = ?id_item and sincroniza <> 3 "
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?id_item", MySql.Data.MySqlClient.MySqlDbType.Double).Value = id_item
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()

        If nue_var.dr.Read() Then
            total_contratado = nue_var.dr("cantidad")
        Else
            total_contratado = 0
            'If IsDBNull(nue_var.dr("cantidad")) Then
            '    total_contratado = 0
            'Else
            '    total_contratado = nue_var.dr("cantidad")
            'End If
        End If

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return total_contratado
    End Function

    Public Function total_avance(ByVal id_obra As Integer, ByVal codigo_subcontrato As Double) As Double
        nue_var.consulta = "SELECT SUM(avance) FROM avance_subcontrato_v2 WHERE id_obra = ?id_obra and codigo_subcontrato = ?codigo_subcontrato and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?codigo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.Double).Value = codigo_subcontrato
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()

        'If nue_var.dr.Read() Then
        '    total_avance = nue_var.dr("SUM(avance)")
        'Else
        '    total_avance = 0
        'End If

        If nue_var.dr.Read() Then
            If IsNumeric(nue_var.dr("SUM(avance)")) Then
                total_avance = nue_var.dr("SUM(avance)")
            Else
                total_avance = 0
            End If
        Else
            total_avance = 0
        End If

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return total_avance
    End Function

    Public Function total_avance_mod(ByVal id_obra As Integer, ByVal codigo_subcontrato As Double) As Double
        nue_var.consulta = "SELECT SUM(avance) FROM avance_subcontrato_v2 WHERE id_obra = ?id_obra and codigo_subcontrato = ?codigo_subcontrato and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?codigo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.Double).Value = codigo_subcontrato
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

        nue_var.dr = nue_var.cmd.ExecuteReader()

        'If nue_var.dr.Read() Then
        '    total_avance_mod = nue_var.dr("SUM(avance)")
        'Else
        '    total_avance_mod = 0
        'End If

        If nue_var.dr.Read() Then
            If IsNumeric(nue_var.dr("SUM(avance)")) Then
                total_avance_mod = nue_var.dr("SUM(avance)")
            Else
                total_avance_mod = 0
            End If
        Else
            total_avance_mod = 0
        End If

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return total_avance_mod
    End Function

End Class
