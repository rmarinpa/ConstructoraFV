Imports MySql.Data.MySqlClient
Public Class Sincroniza4

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Function listar(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM equipos where id_obra = " & id_obra & "", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar_remoto(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar_remoto()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM equipos where sincroniza <> 0  and id_obra = " & id_obra & "", nue_conexion.conex_remoto())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar_remoto()
        listar_remoto = nue_var.dt
        Return listar_remoto
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal forma As String, ByVal fecha_ep As Integer, ByVal fecha_ep2 As Integer, ByVal codigo As String, ByVal tipo_equipo As String, ByVal detalle_equipo As String, ByVal marca As String, ByVal modelo As String, ByVal patente As String, ByVal num_motor As String, ByVal capacidad As String, ByVal obra As String, ByVal operador As String, ByVal horometro As String, ByVal un_pago As String, ByVal precio_un As Double, ByVal cuenta_maq As String, ByVal cuenta_petro As String, ByVal recupera As String, ByVal dias_fallas As Double, ByVal jornada As String, ByVal min_obra As Double, ByVal desc_obra As Double, ByVal material As String, ByVal turno As Integer, ByVal ren_est As Double)
        nue_var.consulta = "INSERT INTO equipos (sincroniza, version, nombre_obra, id_obra, rut, forma, fecha_ep, fecha_ep2, codigo, tipo_equipo, detalle_equipo, marca, modelo, patente, num_motor, capacidad, obra, operador, horometro, un_pago, precio_un, cuenta_maq, cuenta_petro, recupera, dias_fallas, jornada, min_obra, desc_obra, material, turno, ren_est) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?rut, ?forma, ?fecha_ep, ?fecha_ep2, ?codigo, ?tipo_equipo, ?detalle_equipo, ?marca, ?modelo, ?patente, ?num_motor, ?capacidad, ?obra, ?operador, ?horometro, ?un_pago, ?precio_un, ?cuenta_maq, ?cuenta_petro, ?recupera, ?dias_fallas, ?jornada, ?min_obra, ?desc_obra, ?material, ?turno, ?ren_est)"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?forma", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma
            nue_var.cmd.Parameters.Add("?fecha_ep", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = fecha_ep
            nue_var.cmd.Parameters.Add("?fecha_ep2", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = fecha_ep2
            nue_var.cmd.Parameters.Add("?codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo
            nue_var.cmd.Parameters.Add("?tipo_equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_equipo
            nue_var.cmd.Parameters.Add("?detalle_equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = detalle_equipo
            nue_var.cmd.Parameters.Add("?marca", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = marca
            nue_var.cmd.Parameters.Add("?modelo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = modelo
            nue_var.cmd.Parameters.Add("?patente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = patente
            nue_var.cmd.Parameters.Add("?num_motor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_motor
            nue_var.cmd.Parameters.Add("?capacidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = capacidad
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = operador
            nue_var.cmd.Parameters.Add("?horometro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = horometro
            nue_var.cmd.Parameters.Add("?un_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = un_pago
            nue_var.cmd.Parameters.Add("?precio_un", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_un
            nue_var.cmd.Parameters.Add("?cuenta_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_maq
            nue_var.cmd.Parameters.Add("?cuenta_petro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_petro
            nue_var.cmd.Parameters.Add("?recupera", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = recupera
            nue_var.cmd.Parameters.Add("?dias_fallas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_fallas
            nue_var.cmd.Parameters.Add("?jornada", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = jornada
            nue_var.cmd.Parameters.Add("?min_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = min_obra
            nue_var.cmd.Parameters.Add("?desc_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = desc_obra
            nue_var.cmd.Parameters.Add("?material", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = material
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno
            nue_var.cmd.Parameters.Add("?ren_est", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ren_est



            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_remoto()
            nue_var.consulta = "SELECT MAX(id_equipo) from equipos"
            Try
                nue_conexion.conectar_remoto()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(id_equipo)")
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
    Public Sub insertar_remoto(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal forma As String, ByVal fecha_ep As Integer, ByVal fecha_ep2 As Integer, ByVal codigo As String, ByVal tipo_equipo As String, ByVal detalle_equipo As String, ByVal marca As String, ByVal modelo As String, ByVal patente As String, ByVal num_motor As String, ByVal capacidad As String, ByVal obra As String, ByVal operador As String, ByVal horometro As String, ByVal un_pago As String, ByVal precio_un As Double, ByVal cuenta_maq As String, ByVal cuenta_petro As String, ByVal recupera As String, ByVal dias_fallas As Double, ByVal jornada As String, ByVal min_obra As Double, ByVal desc_obra As Double, ByVal material As String, ByVal turno As Integer, ByVal ren_est As Double)
        nue_var.consulta = "INSERT INTO equipos (sincroniza, version, nombre_obra, id_obra, rut, forma, fecha_ep, fecha_ep2, codigo, tipo_equipo, detalle_equipo, marca, modelo, patente, num_motor, capacidad, obra, operador, horometro, un_pago, precio_un, cuenta_maq, cuenta_petro, recupera, dias_fallas, jornada, min_obra, desc_obra, material, turno, ren_est) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?rut, ?forma, ?fecha_ep, ?fecha_ep2, ?codigo, ?tipo_equipo, ?detalle_equipo, ?marca, ?modelo, ?patente, ?num_motor, ?capacidad, ?obra, ?operador, ?horometro, ?un_pago, ?precio_un, ?cuenta_maq, ?cuenta_petro, ?recupera, ?dias_fallas, ?jornada, ?min_obra, ?desc_obra, ?material, ?turno, ?ren_est)"
        Try
            nue_conexion.conectar_local()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?forma", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma
            nue_var.cmd.Parameters.Add("?fecha_ep", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = fecha_ep
            nue_var.cmd.Parameters.Add("?fecha_ep2", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = fecha_ep2
            nue_var.cmd.Parameters.Add("?codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo
            nue_var.cmd.Parameters.Add("?tipo_equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_equipo
            nue_var.cmd.Parameters.Add("?detalle_equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = detalle_equipo
            nue_var.cmd.Parameters.Add("?marca", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = marca
            nue_var.cmd.Parameters.Add("?modelo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = modelo
            nue_var.cmd.Parameters.Add("?patente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = patente
            nue_var.cmd.Parameters.Add("?num_motor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_motor
            nue_var.cmd.Parameters.Add("?capacidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = capacidad
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = operador
            nue_var.cmd.Parameters.Add("?horometro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = horometro
            nue_var.cmd.Parameters.Add("?un_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = un_pago
            nue_var.cmd.Parameters.Add("?precio_un", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_un
            nue_var.cmd.Parameters.Add("?cuenta_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_maq
            nue_var.cmd.Parameters.Add("?cuenta_petro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_petro
            nue_var.cmd.Parameters.Add("?recupera", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = recupera
            nue_var.cmd.Parameters.Add("?dias_fallas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_fallas
            nue_var.cmd.Parameters.Add("?jornada", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = jornada
            nue_var.cmd.Parameters.Add("?min_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = min_obra
            nue_var.cmd.Parameters.Add("?desc_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = desc_obra
            nue_var.cmd.Parameters.Add("?material", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = material
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno
            nue_var.cmd.Parameters.Add("?ren_est", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ren_est


            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_local()
            nue_var.consulta = "SELECT MAX(id_equipo) from equipos"
            Try
                nue_conexion.conectar_local()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(id_equipo)")
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
        nue_var.consulta = "UPDATE equipos SET sincroniza = ?sincroniza WHERE id_equipo = ?Id_identificacion"
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
        nue_var.consulta = "UPDATE equipos SET sincroniza = ?sincroniza WHERE id_equipo = ?Id_identificacion"
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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM equipos where sincroniza <> 0  and sincroniza <> 1 and id_obra = " & id_obra & "", nue_conexion.conex_remoto())
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
    Public Sub modificar_tabla(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal forma As String, ByVal fecha_ep As Integer, ByVal fecha_ep2 As Integer, ByVal codigo As String, ByVal tipo_equipo As String, ByVal detalle_equipo As String, ByVal marca As String, ByVal modelo As String, ByVal patente As String, ByVal num_motor As String, ByVal capacidad As String, ByVal obra As String, ByVal operador As String, ByVal horometro As String, ByVal un_pago As String, ByVal precio_un As Double, ByVal cuenta_maq As String, ByVal cuenta_petro As String, ByVal recupera As String, ByVal dias_fallas As Double, ByVal jornada As String, ByVal min_obra As Double, ByVal desc_obra As Double, ByVal material As String, ByVal turno As Integer, ByVal ren_est As Double)
        nue_var.consulta = "UPDATE equipos SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra,  rut = ?rut, forma = ?forma, fecha_ep = ?fecha_ep, fecha_ep2 = ?fecha_ep2, codigo = ?codigo, tipo_equipo = ?tipo_equipo, detalle_equipo = ?detalle_equipo, marca = ?marca, modelo = ?modelo, patente = ?patente, num_motor = ?num_motor, capacidad = ?capacidad, obra = ?obra, operador = ?operador, horometro = ?horometro, un_pago = ?un_pago, precio_un = ?precio_un, cuenta_maq = ?cuenta_maq, cuenta_petro = ?cuenta_petro, recupera = ?recupera, dias_fallas = ?dias_fallas, jornada = ?jornada, min_obra = ?min_obra, desc_obra = ?desc_obra, material = ?material, turno = ?turno, ren_est = ?ren_est WHERE id_equipo = ?Cod_identifica"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?forma", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma
            nue_var.cmd.Parameters.Add("?fecha_ep", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = fecha_ep
            nue_var.cmd.Parameters.Add("?fecha_ep2", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = fecha_ep2
            nue_var.cmd.Parameters.Add("?codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo
            nue_var.cmd.Parameters.Add("?tipo_equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_equipo
            nue_var.cmd.Parameters.Add("?detalle_equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = detalle_equipo
            nue_var.cmd.Parameters.Add("?marca", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = marca
            nue_var.cmd.Parameters.Add("?modelo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = modelo
            nue_var.cmd.Parameters.Add("?patente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = patente
            nue_var.cmd.Parameters.Add("?num_motor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_motor
            nue_var.cmd.Parameters.Add("?capacidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = capacidad
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = operador
            nue_var.cmd.Parameters.Add("?horometro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = horometro
            nue_var.cmd.Parameters.Add("?un_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = un_pago
            nue_var.cmd.Parameters.Add("?precio_un", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_un
            nue_var.cmd.Parameters.Add("?cuenta_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_maq
            nue_var.cmd.Parameters.Add("?cuenta_petro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_petro
            nue_var.cmd.Parameters.Add("?recupera", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = recupera
            nue_var.cmd.Parameters.Add("?dias_fallas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_fallas
            nue_var.cmd.Parameters.Add("?jornada", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = jornada
            nue_var.cmd.Parameters.Add("?min_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = min_obra
            nue_var.cmd.Parameters.Add("?desc_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = desc_obra
            nue_var.cmd.Parameters.Add("?material", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = material
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno
            nue_var.cmd.Parameters.Add("?ren_est", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ren_est


            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar_eliminar(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE equipos SET sincroniza = ?sincroniza, version = ?version WHERE id_equipo = ?Cod_identifica"
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
    Public Sub modificar_remoto2(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal forma As String, ByVal fecha_ep As Integer, ByVal fecha_ep2 As Integer, ByVal codigo As String, ByVal tipo_equipo As String, ByVal detalle_equipo As String, ByVal marca As String, ByVal modelo As String, ByVal patente As String, ByVal num_motor As String, ByVal capacidad As String, ByVal obra As String, ByVal operador As String, ByVal horometro As String, ByVal un_pago As String, ByVal precio_un As Double, ByVal cuenta_maq As String, ByVal cuenta_petro As String, ByVal recupera As String, ByVal dias_fallas As Double, ByVal jornada As String, ByVal min_obra As Double, ByVal desc_obra As Double, ByVal material As String, ByVal turno As Integer, ByVal ren_est As Double)
        nue_var.consulta = "UPDATE equipos SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra,  rut = ?rut, forma = ?forma, fecha_ep = ?fecha_ep, fecha_ep2 = ?fecha_ep2, codigo = ?codigo, tipo_equipo = ?tipo_equipo, detalle_equipo = ?detalle_equipo, marca = ?marca, modelo = ?modelo, patente = ?patente, num_motor = ?num_motor, capacidad = ?capacidad, obra = ?obra, operador = ?operador, horometro = ?horometro, un_pago = ?un_pago, precio_un = ?precio_un, cuenta_maq = ?cuenta_maq, cuenta_petro = ?cuenta_petro, recupera = ?recupera, dias_fallas = ?dias_fallas, jornada = ?jornada, min_obra = ?min_obra, desc_obra = ?desc_obra, material = ?material, turno = ?turno, ren_est = ?ren_est WHERE id_equipo = ?Cod_identifica"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?forma", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma
            nue_var.cmd.Parameters.Add("?fecha_ep", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = fecha_ep
            nue_var.cmd.Parameters.Add("?fecha_ep2", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = fecha_ep2
            nue_var.cmd.Parameters.Add("?codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = codigo
            nue_var.cmd.Parameters.Add("?tipo_equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_equipo
            nue_var.cmd.Parameters.Add("?detalle_equipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = detalle_equipo
            nue_var.cmd.Parameters.Add("?marca", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = marca
            nue_var.cmd.Parameters.Add("?modelo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = modelo
            nue_var.cmd.Parameters.Add("?patente", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = patente
            nue_var.cmd.Parameters.Add("?num_motor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_motor
            nue_var.cmd.Parameters.Add("?capacidad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = capacidad
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?operador", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = operador
            nue_var.cmd.Parameters.Add("?horometro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = horometro
            nue_var.cmd.Parameters.Add("?un_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = un_pago
            nue_var.cmd.Parameters.Add("?precio_un", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_un
            nue_var.cmd.Parameters.Add("?cuenta_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_maq
            nue_var.cmd.Parameters.Add("?cuenta_petro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_petro
            nue_var.cmd.Parameters.Add("?recupera", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = recupera
            nue_var.cmd.Parameters.Add("?dias_fallas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias_fallas
            nue_var.cmd.Parameters.Add("?jornada", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = jornada
            nue_var.cmd.Parameters.Add("?min_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = min_obra
            nue_var.cmd.Parameters.Add("?desc_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = desc_obra
            nue_var.cmd.Parameters.Add("?material", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = material
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = turno
            nue_var.cmd.Parameters.Add("?ren_est", MySql.Data.MySqlClient.MySqlDbType.Double).Value = ren_est

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
    Public Function verificar_version2(ByVal id_equipo As Integer, ByVal Id_obra As Integer) As Integer
        nue_var.consulta = "SELECT version FROM equipos WHERE id_equipo = ?id_equipo and id_obra = ?Id_obra"
        nue_conexion.conectar_remoto()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
        nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
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
