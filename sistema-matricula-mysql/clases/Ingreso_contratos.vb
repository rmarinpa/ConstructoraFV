﻿Imports MySql.Data.MySqlClient
Public Class Ingreso_contratos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar2(ByVal id_obra As Integer, ByVal forma As String, ByVal operador As String, ByVal obra As String, ByVal rut As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM check_equipos where id_obra = " & id_obra & " and forma = '" & forma & "' and operador = '" & operador & "' and obra = '" & obra & "' and rut = '" & rut & "' and sincroniza <> 3 order by codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar3(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM arrendador Where id_obra = " & id_obra & " and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar5(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM identificacion_obra Where id_obra = " & id_obra & " and sincroniza <> 3 order by nombre_faena asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal id_equipo As Integer, ByVal equipo As String, ByVal num_contrato As Integer, ByVal adjunto As String, ByVal usuario As String, ByVal fecha As Date, ByVal hora As Date, ByVal id_faena As Integer, ByVal faena As String, ByVal lugar As String, ByVal fecha_celebracion As Date, ByVal rut_arrendador As String, ByVal nombre_arrendador As String, ByVal tipo_de_pago As String, ByVal operador As String)
        nue_var.consulta = "INSERT INTO equipos_adjuntos (sincroniza, version, nombre_obra, id_obra, id_equipo, equipo, num_contrato, adjunto, usuario, fecha, hora, id_faena, faena, lugar, fecha_celebracion, rut_arrendador, nombre_arrendador, tipo_de_pago, operador) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?id_equipo, ?equipo, ?num_contrato, ?adjunto, ?usuario, ?fecha, ?hora, ?id_faena, ?faena, ?lugar, ?fecha_celebracion, ?rut_arrendador, ?nombre_arrendador, ?tipo_de_pago, ?operador)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
            nue_var.cmd.Parameters.Add("?equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = equipo
            nue_var.cmd.Parameters.Add("?num_contrato", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = num_contrato
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

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE equipos_adjuntos SET sincroniza = ?sincroniza, version = ?version WHERE Id_equipos_adjuntos = ?Cod_adicional"
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
    Public Function listar14(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_equipos_adj where id_obra = " & id_obra & " and con_sin <> 3 order by equipo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar14 = nue_var.dt
        Return listar14
    End Function

    Public Sub insertar_ep_adjunto(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal nombre_empresa As String, ByVal num_ep As Integer, ByVal adjunto As String, ByVal usuario As String, ByVal fecha As Date, ByVal hora As Date)
        nue_var.consulta = "INSERT INTO estado_pago_adjuntos (sincroniza, version, nombre_obra, id_obra, rut, nombre_empresa, num_ep, adjunto, usuario, fecha, hora) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?rut, ?nombre_empresa, ?num_ep, ?adjunto, ?usuario, ?fecha, ?hora)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?nombre_empresa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_empresa
            nue_var.cmd.Parameters.Add("?num_ep", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = num_ep
            nue_var.cmd.Parameters.Add("?adjunto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = adjunto
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Function listar_ep(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM estado_pago_adjuntos where id_obra = " & id_obra & " and sincroniza <> 3 order by nombre_empresa, num_ep asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar_ep = nue_var.dt
        Return listar_ep
    End Function

    Public Sub eliminar_sincro_ep(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE estado_pago_adjuntos SET sincroniza = ?sincroniza, version = ?version WHERE Id_estado_pago = ?Cod_adicional"
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
End Class
