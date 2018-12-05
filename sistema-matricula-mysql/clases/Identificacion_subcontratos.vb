Imports MySql.Data.MySqlClient
Public Class Identificacion_subcontratos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Sub insertar_cabecera(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal domicilio As String, ByVal razon_social As String, ByVal representante As String, ByVal representante_rut As String, ByVal comuna As String, ByVal ciudad As String)
        nue_var.consulta = "INSERT INTO subcontratista (sincroniza, version, nombre_obra, id_obra, rut, domicilio, razon_social, representante, representante_rut, comuna, ciudad) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?rut, ?domicilio, ?razon_social, ?representante, ?representante_rut, ?comuna, ?ciudad)"
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
            nue_var.cmd.Parameters.Add("?comuna", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna
            nue_var.cmd.Parameters.Add("?ciudad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ciudad
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertar_posicion(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal servicio As String, ByVal obra As String, ByVal plazo As Double, ByVal valor_contrato As Double, ByVal valor_pesos As Double, ByVal valor_seguro As Double)
        nue_var.consulta = "INSERT INTO subcontrato (sincroniza, version, nombre_obra, id_obra, rut, servicio, obra, plazo, valor_contrato, valor_pesos, valor_seguro) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?rut, ?servicio, ?obra, ?plazo, ?valor_contrato, ?valor_pesos, ?valor_seguro)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?servicio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = servicio
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?plazo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = plazo
            nue_var.cmd.Parameters.Add("?valor_contrato", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_contrato
            nue_var.cmd.Parameters.Add("?valor_pesos", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_pesos
            nue_var.cmd.Parameters.Add("?valor_seguro", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_seguro
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()

        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
    Public Sub modificar_posicion(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal servicio As String, ByVal obra As String, ByVal plazo As Double, ByVal valor_contrato As Double, ByVal valor_pesos As Double, ByVal valor_seguro As Double)
        nue_var.consulta = "UPDATE subcontrato SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra,  rut = ?rut, servicio = ?servicio, obra = ?obra, plazo = ?plazo, valor_contrato = ?valor_contrato, valor_pesos = ?valor_pesos, valor_seguro = ?valor_seguro WHERE id_subcontrato = ?Cod_identifica"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?servicio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = servicio
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?plazo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = plazo
            nue_var.cmd.Parameters.Add("?valor_contrato", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_contrato
            nue_var.cmd.Parameters.Add("?valor_pesos", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_pesos
            nue_var.cmd.Parameters.Add("?valor_seguro", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_seguro
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub insertar_item(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal Id_subcontrato As Integer, ByVal item As String, ByVal unidad_pago As String, ByVal precio_un As Double, ByVal cantidad As Double, ByVal precio_total As Double, ByVal cuenta_contable As String)
        nue_var.consulta = "INSERT INTO items_subcon (sincroniza, version, nombre_obra, id_obra, rut, Id_subcontrato, item, unidad_pago, precio_un, cantidad, precio_total, cuenta_contable) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?rut, ?Id_subcontrato, ?item, ?unidad_pago, ?precio_un, ?cantidad, ?precio_total, ?cuenta_contable)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?Id_subcontrato", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_subcontrato
            nue_var.cmd.Parameters.Add("?item", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = item
            nue_var.cmd.Parameters.Add("?unidad_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = unidad_pago
            nue_var.cmd.Parameters.Add("?precio_un", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_un
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?precio_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_total
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_contable

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()

        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try

    End Sub
    Public Sub modificar_item(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal Id_subcontrato As Integer, ByVal item As String, ByVal unidad_pago As String, ByVal precio_un As Double, ByVal cantidad As Double, ByVal precio_total As Double, ByVal cuenta_contable As String)
        nue_var.consulta = "UPDATE items_subcon SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra,  rut = ?rut, Id_subcontrato = ?Id_subcontrato, item = ?item, unidad_pago = ?unidad_pago, precio_un = ?precio_un, cantidad = ?cantidad, precio_total = ?precio_total, cuenta_contable = ?cuenta_contable WHERE id_item = ?Cod_identifica"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_identifica", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_identifica
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?Id_subcontrato", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_subcontrato
            nue_var.cmd.Parameters.Add("?item", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = item
            nue_var.cmd.Parameters.Add("?unidad_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = unidad_pago
            nue_var.cmd.Parameters.Add("?precio_un", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_un
            nue_var.cmd.Parameters.Add("?cantidad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = cantidad
            nue_var.cmd.Parameters.Add("?precio_total", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio_total
            nue_var.cmd.Parameters.Add("?cuenta_contable", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_contable
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub


    Public Sub eliminar(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from identificacion_obra WHERE Id_identificacion = " & cod_1 & ""
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
        nue_var.consulta = "UPDATE subcontrato SET sincroniza = ?sincroniza, version = ?version WHERE id_subcontrato = ?Cod_identifica"
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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM ident_subcontrato Where id_obra = " & id_obra & " order by rut, razon_social, servicio asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    Public Function listar2_items(ByVal id_obra As Integer, ByVal rut As String, ByVal Id_subcontrato As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM subcontratista_subcon Where id_obra = " & id_obra & " and rut like '" & rut & "' and Id_subcontrato = " & Id_subcontrato & " AND not ISNULL(sincroniza2) order by id_subcontrato asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2_items = nue_var.dt
        Return listar2_items
    End Function
    Public Function listar3(ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM subcontratista Where id_obra = " & id_obra & " and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4(ByVal razon_social As String, ByVal id_obra As Integer) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM subcontratista Where id_obra = " & id_obra & " and razon_social like '" & razon_social & "' and sincroniza <> 3 order by razon_social asc", nue_conexion.conex())
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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM tabla_plan_de_cuentas Where id_obra = " & id_obra & " and sincroniza <> 3 order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Function listar8(ByVal id_obra As Integer, ByVal rut As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM servicio_agrupado Where id_obra = " & id_obra & " and rut = '" & rut & "' order by servicio asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar8 = nue_var.dt
        Return listar8
    End Function
    Public Function listar9(ByVal id_obra As Integer, ByVal rut As String, ByVal servicio As String) As DataTable

        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT DISTINCT(item) FROM subcontratista_subcon Where id_obra = " & id_obra & " and rut = '" & rut & "' and servicio like '" & servicio & "' and sincroniza <> 3 order by item asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar9 = nue_var.dt
        Return listar9
    End Function
    Public Function verificar_servicio(ByVal id_obra As Integer, ByVal rut As String, ByVal servicio As String) As Integer
        nue_var.consulta = "SELECT * FROM servicio_agrupado WHERE id_obra = ?id_obra and rut = ?rut and servicio = ?servicio"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.cmd.Parameters.Add("?servicio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = servicio
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_servicio = 1
        Else
            verificar_servicio = 0
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_servicio
    End Function
    Public Sub eliminar_equipo(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from subcontrato WHERE id_subcontrato = " & cod_1 & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro11(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE subcontratista SET sincroniza = ?sincroniza, version = ?version WHERE Id_subcontratista = ?Cod_identifica"
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
    Public Sub modificar_cabecera(ByVal Cod_Plan_de_cuentas As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal rut As String, ByVal domicilio As String, ByVal razon_social As String, ByVal representante As String, ByVal representante_rut As String, ByVal comuna As String, ByVal ciudad As String)
        nue_var.consulta = "UPDATE subcontratista SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, rut = ?rut, domicilio = ?domicilio, razon_social = ?razon_social, representante = ?representante, representante_rut = ?representante_rut, comuna = ?comuna, ciudad = ?ciudad  WHERE Id_subcontratista = ?Cod_Plan_de_cuentas"
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
            nue_var.cmd.Parameters.Add("?comuna", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comuna
            nue_var.cmd.Parameters.Add("?ciudad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ciudad
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function verificar_arrendador(ByVal id_obra As Integer, ByVal rut As String) As Integer
        nue_var.consulta = "SELECT * FROM subcontratista WHERE id_obra = ?id_obra and rut = ?rut and sincroniza <> 3"
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
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_arrendador
    End Function

    Public Function cuenta_a_desc(ByVal id_obra As Integer, ByVal cuenta_costo As String) As String
        nue_var.consulta = "SELECT cuenta_desc FROM cuentas_detalle WHERE id_obra = ?id_obra and Cuenta_costo = ?Cuenta_costo and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Cuenta_costo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_costo
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            cuenta_a_desc = nue_var.dr("cuenta_desc")
        Else
            cuenta_a_desc = ""
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return cuenta_a_desc
    End Function

    Public Function desc_a_cuenta(ByVal id_obra As Integer, ByVal cuenta_desc As String) As String
        nue_var.consulta = "SELECT Cuenta_costo FROM cuentas_detalle WHERE id_obra = ?id_obra and cuenta_desc = ?cuenta_desc and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?cuenta_desc", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cuenta_desc
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            desc_a_cuenta = nue_var.dr("Cuenta_costo")
        Else
            desc_a_cuenta = ""
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return desc_a_cuenta
    End Function

    Public Function suma_avances(ByVal codigo_subcontrato As Integer, ByVal id_obra As Integer) As String
        nue_var.consulta = "SELECT SUM(avance) FROM avance_subcontrato_v2_2 WHERE codigo_subcontrato = ?codigo_subcontrato and id_obra = ?id_obra"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?codigo_subcontrato", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = codigo_subcontrato
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()

        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("SUM(avance)")) Then
                suma_avances = 0
            Else
                suma_avances = nue_var.dr("SUM(avance)")
            End If
        End If

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return suma_avances
    End Function

    Public Function suma_subcontratos(ByVal rut As String, ByVal id_obra As Integer) As String
        nue_var.consulta = "SELECT SUM(sincroniza) FROM subcontratista_subcon WHERE rut = ?rut and id_obra = ?id_obra"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()

        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("SUM(sincroniza)")) Then
                suma_subcontratos = 0
            Else
                suma_subcontratos = nue_var.dr("SUM(sincroniza)")
            End If
        End If

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return suma_subcontratos
    End Function
End Class
