Imports MySql.Data.MySqlClient
Public Class Registro_petroleo

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Sub insertar_report(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Codigo As String, ByVal N_de_Vale As Double, ByVal Fecha As Date, ByVal Litros_consumo As Double, ByVal Obra As String, ByVal id_equipo As Integer)
        nue_var.consulta = "INSERT INTO Petroleo_v2 (sincroniza, version, nombre_obra, id_obra, Codigo, N_de_Vale, Fecha, Litros_consumo, Obra, id_equipo) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Codigo, ?N_de_Vale, ?Fecha, ?Litros_consumo, ?Obra, ?id_equipo)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?N_de_Vale", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_Vale
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Litros_consumo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Litros_consumo
            nue_var.cmd.Parameters.Add("?Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
    Public Sub modificar_report(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Codigo As String, ByVal N_de_Vale As Double, ByVal Fecha As Date, ByVal Litros_consumo As Double, ByVal Obra As String, ByVal id_equipo As Integer)
        nue_var.consulta = "UPDATE Petroleo_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Codigo = ?Codigo, N_de_Vale = ?N_de_Vale, Fecha = ?Fecha, Litros_consumo = ?Litros_consumo, Obra = ?Obra, id_equipo = ?id_equipo WHERE id_petroleo = ?Cod_identifica"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?N_de_Vale", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_Vale
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?Litros_consumo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Litros_consumo
            nue_var.cmd.Parameters.Add("?Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar6(ByVal fecha As String, ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM fecha_vales where Fecha = '" & fecha & "' and id_obra = " & id_obra & " and (sincroniza <> 3 or isnull(sincroniza)) order by codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar7(ByVal fecha_inicio As String, ByVal fecha_final As String, ByVal id_obra As Integer, ByVal id_equipo As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM fecha_vales where Fecha >= '" & fecha_inicio & "' and Fecha <= '" & fecha_final & "' and id_obra = " & id_obra & " and id_equipo like '" & id_equipo & "' and (sincroniza <> 3 or isnull(sincroniza))  order by Fecha asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Function listar2(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM arrendador_equipos Where id_obra = " & id_obra & " and sincroniza <> 3 order by codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function verificar_registro(ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal Litros_consumo As Double) As Integer
        If sincroniza = 0 Then
            nue_var.consulta = "SELECT * FROM Petroleo_v2 WHERE id_obra = ?id_obra and Fecha = ?Fecha and sincroniza <> 3 and Codigo = ?Codigo and Litros_consumo = ?Litros_consumo"
        ElseIf sincroniza = 1 Then
            nue_var.consulta = "SELECT * FROM petroleo_v2 WHERE id_obra = ?id_obra and Fecha = ?Fecha and sincroniza <> 3 and Codigo = ?Codigo and Litros_consumo = ?Litros_consumo"
        End If

        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.cmd.Parameters.Add("?Litros_consumo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Litros_consumo
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

    Public Function verificar_registro_local(ByVal id_obra As Integer, ByVal Fecha As Date, ByVal Codigo As String, ByVal Litros_consumo As Double) As Integer
        nue_var.consulta = "SELECT * FROM petroleo_v2 WHERE id_obra = ?id_obra and Fecha = ?Fecha and sincroniza <> 3 and Codigo = ?Codigo and Litros_consumo = ?Litros_consumo"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
        nue_var.cmd.Parameters.Add("?Litros_consumo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Litros_consumo
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_registro_local = 1
        Else
            verificar_registro_local = 0
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_registro_local
    End Function
    Public Function listar3(ByVal id_obra As Integer, ByVal codigo As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM equipos Where id_obra = " & id_obra & " and sincroniza <> 3 and codigo like '" & codigo & "' order by codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Sub eliminar_report(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from petroleo_v2 WHERE id_petroleo = " & cod_1 & ""
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
