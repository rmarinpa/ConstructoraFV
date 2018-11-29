Imports MySql.Data.MySqlClient
Public Class Identificacion_equipos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Sub insertar_cabecera(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal domicilio As String, ByVal razon_social As String, ByVal representante As String, ByVal representante_rut As String)
        nue_var.consulta = "INSERT INTO arrendador (sincroniza, version, nombre_obra, id_obra, rut, domicilio, razon_social, representante, representante_rut) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?rut, ?domicilio, ?razon_social, ?representante, ?representante_rut)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?domicilio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = domicilio
            nue_var.cmd.Parameters.Add("?razon_social", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = razon_social
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?representante_rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante_rut
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
    Public Sub insertar_posicion(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal forma As String, ByVal fecha_ep As Integer, ByVal fecha_ep2 As Integer, ByVal codigo As String, ByVal tipo_equipo As String, ByVal detalle_equipo As String, ByVal marca As String, ByVal modelo As String, ByVal patente As String, ByVal num_motor As String, ByVal capacidad As String, ByVal obra As String, ByVal operador As String, ByVal horometro As String, ByVal un_pago As String, ByVal precio_un As Double, ByVal cuenta_maq As String, ByVal cuenta_petro As String, ByVal recupera As String, ByVal dias_fallas As Double, ByVal jornada As String, ByVal min_obra As Double, ByVal desc_obra As Double, ByVal material As String, ByVal turno As Integer, ByVal ren_est As Double, ByVal un_medida As String, ByVal activo As String)
        nue_var.consulta = "INSERT INTO equipos (sincroniza, version, nombre_obra, id_obra, rut, forma, fecha_ep, fecha_ep2, codigo, tipo_equipo, detalle_equipo, marca, modelo, patente, num_motor, capacidad, obra, operador, horometro, un_pago, precio_un, cuenta_maq, cuenta_petro, recupera, dias_fallas, jornada, min_obra, desc_obra, material, turno, ren_est, un_medida, activo) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?rut, ?forma, ?fecha_ep, ?fecha_ep2, ?codigo, ?tipo_equipo, ?detalle_equipo, ?marca, ?modelo, ?patente, ?num_motor, ?capacidad, ?obra, ?operador, ?horometro, ?un_pago, ?precio_un, ?cuenta_maq, ?cuenta_petro, ?recupera, ?dias_fallas, ?jornada, ?min_obra, ?desc_obra, ?material, ?turno, ?ren_est, ?un_medida, ?activo)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
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
            nue_var.cmd.Parameters.Add("?un_medida", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = un_medida
            nue_var.cmd.Parameters.Add("?activo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = activo

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()

        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
    Public Sub modificar_posicion(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal forma As String, ByVal fecha_ep As Integer, ByVal fecha_ep2 As Integer, ByVal codigo As String, ByVal tipo_equipo As String, ByVal detalle_equipo As String, ByVal marca As String, ByVal modelo As String, ByVal patente As String, ByVal num_motor As String, ByVal capacidad As String, ByVal obra As String, ByVal operador As String, ByVal horometro As String, ByVal un_pago As String, ByVal precio_un As Double, ByVal cuenta_maq As String, ByVal cuenta_petro As String, ByVal recupera As String, ByVal dias_fallas As Double, ByVal jornada As String, ByVal min_obra As Double, ByVal desc_obra As Double, ByVal material As String, ByVal turno As Integer, ByVal ren_est As Double, ByVal un_medida As String, ByVal activo As String)
        nue_var.consulta = "UPDATE equipos SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra,  rut = ?rut, forma = ?forma, fecha_ep = ?fecha_ep, fecha_ep2 = ?fecha_ep2, codigo = ?codigo, tipo_equipo = ?tipo_equipo, detalle_equipo = ?detalle_equipo, marca = ?marca, modelo = ?modelo, patente = ?patente, num_motor = ?num_motor, capacidad = ?capacidad, obra = ?obra, operador = ?operador, horometro = ?horometro, un_pago = ?un_pago, precio_un = ?precio_un, cuenta_maq = ?cuenta_maq, cuenta_petro = ?cuenta_petro, recupera = ?recupera, dias_fallas = ?dias_fallas, jornada = ?jornada, min_obra = ?min_obra, desc_obra = ?desc_obra, material = ?material, turno = ?turno, ren_est = ?ren_est, un_medida = ?un_medida, activo = ?activo WHERE id_equipo = ?Cod_identifica"
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
            nue_var.cmd.Parameters.Add("?un_medida", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = un_medida
            nue_var.cmd.Parameters.Add("?activo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = activo


            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar_cabecera(ByVal Cod_Plan_de_cuentas As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal domicilio As String, ByVal razon_social As String, ByVal representante As String, ByVal representante_rut As String)
        nue_var.consulta = "UPDATE arrendador SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, rut = ?rut, domicilio = ?domicilio, razon_social = ?razon_social, representante = ?representante, representante_rut = ?representante_rut  WHERE id_arrendador = ?Cod_Plan_de_cuentas"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Plan_de_cuentas", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Plan_de_cuentas
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?domicilio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = domicilio
            nue_var.cmd.Parameters.Add("?razon_social", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = razon_social
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.Parameters.Add("?representante_rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante_rut
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from arrendador WHERE id_arrendador = " & cod_1 & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_equipo(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from equipos WHERE id_equipo = " & cod_1 & ""
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
    Public Sub eliminar_sincro11(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE arrendador SET sincroniza = ?sincroniza, version = ?version WHERE id_arrendador = ?Cod_identifica"
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
    Public Function listar2(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM arrendador_equipos Where id_obra = " & id_obra & " and sincroniza <> 3 order by codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar2_reports(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM arrendador_equipos Where id_obra = " & id_obra & " and sincroniza <> 3 and ( activo <> 'NO' or isnull(activo) ) order by codigo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2_reports = nue_var.dt
        Return listar2_reports
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
    Public Function listar4(ByVal razon_social As String, ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM arrendador Where id_obra = " & id_obra & " and razon_social like '" & razon_social & "' and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
    Public Function listar5(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT nombre_faena FROM identificacion_obra Where id_obra = " & id_obra & " and sincroniza <> 3 order by nombre_faena asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Function listar6(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM cuentas_detalle Where id_obra = " & id_obra & " and sincroniza <> 3 order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function listar7(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM cuentas_detalle Where id_obra = " & id_obra & " and sincroniza <> 3 order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Function verificar_arrendador(ByVal id_obra As Integer, ByVal rut As String) As Integer
        nue_var.consulta = "SELECT * FROM arrendador WHERE id_obra = ?id_obra and rut = ?rut and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_arrendador = 1
        Else
            verificar_arrendador = 0
        End If

        nue_var.dr = nue_var.cmd.ExecuteReader()

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_arrendador
    End Function

    Public Function suma_petroleo(ByVal id_equipo As Integer, ByVal id_obra As Integer) As String
        nue_var.consulta = "SELECT SUM(Litros_consumo) FROM Petroleo_v2 WHERE id_equipo = ?id_equipo and id_obra = ?id_obra and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()

        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("SUM(Litros_consumo)")) Then
                suma_petroleo = 0
            Else
                suma_petroleo = nue_var.dr("SUM(Litros_consumo)")
            End If
        End If

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return suma_petroleo
    End Function

    Public Function suma_reports(ByVal id_equipo As Integer, ByVal id_obra As Integer) As String
        nue_var.consulta = "SELECT SUM(dias_trabajados) FROM mov_tierra_v2 WHERE id_equipo = ?id_equipo and id_obra = ?id_obra and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?id_equipo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_equipo
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()

        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("SUM(dias_trabajados)")) Then
                suma_reports = 0
            Else
                suma_reports = nue_var.dr("SUM(dias_trabajados)")
            End If
        End If

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return suma_reports
    End Function
End Class
