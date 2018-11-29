Imports MySql.Data.MySqlClient
Public Class Sincroniza8

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Function listar(ByVal id_obra As Integer, ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Compras_petroleo_v2 where id_obra = " & id_obra & " and Fecha >= '" & fecha & "'", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar_remoto(ByVal id_obra As Integer, ByVal fecha As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar_remoto()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Compras_petroleo_v2 where sincroniza <> 0  and id_obra = " & id_obra & " and Fecha >= '" & fecha & "'", nue_conexion.conex_remoto())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar_remoto()
        listar_remoto = nue_var.dt
        Return listar_remoto
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal N_Factura As Double, ByVal Proveedor As String, ByVal Rut As String, ByVal Descuento As Double, ByVal Imp_esp_var As Double, ByVal Imp_esp_fijo As Double, ByVal Precio_base As Double, ByVal Total_neto As Double, ByVal Total_Iva As Double, ByVal Total_IEV As Double, ByVal Total_IEF As Double, ByVal Total_Ventas As Double, ByVal Precio As Double, ByVal Litros As Double, ByVal Obra As String)
        nue_var.consulta = "INSERT INTO Compras_petroleo_v2 (sincroniza, version, nombre_obra, id_obra, Fecha, N_Factura, Proveedor, Rut, Descuento, Imp_esp_var, Imp_esp_fijo, Precio_base, Total_neto, Total_Iva, Total_IEV, Total_IEF, Total_Ventas, Precio, Litros, Obra) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha, ?N_Factura, ?Proveedor, ?Rut, ?Descuento, ?Imp_esp_var, ?Imp_esp_fijo, ?Precio_base, ?Total_neto, ?Total_Iva, ?Total_IEV, ?Total_IEF, ?Total_Ventas, ?Precio, ?Litros, ?Obra)"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra


            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?N_Factura", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = N_Factura
            nue_var.cmd.Parameters.Add("?Proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Proveedor
            nue_var.cmd.Parameters.Add("?Rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
            nue_var.cmd.Parameters.Add("?Descuento", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = Descuento
            nue_var.cmd.Parameters.Add("?Imp_esp_var", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_var
            nue_var.cmd.Parameters.Add("?Imp_esp_fijo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_fijo
            nue_var.cmd.Parameters.Add("?Precio_base", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio_base
            nue_var.cmd.Parameters.Add("?Total_neto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_neto
            nue_var.cmd.Parameters.Add("?Total_Iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Iva
            nue_var.cmd.Parameters.Add("?Total_IEV", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEV
            nue_var.cmd.Parameters.Add("?Total_IEF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEF
            nue_var.cmd.Parameters.Add("?Total_Ventas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Ventas
            nue_var.cmd.Parameters.Add("?Precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = Litros
            nue_var.cmd.Parameters.Add("?Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_remoto()
            nue_var.consulta = "SELECT MAX(Id_compras) from Compras_petroleo_v2"
            Try
                nue_conexion.conectar_remoto()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(Id_compras)")
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
    Public Sub insertar_remoto(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal N_Factura As Double, ByVal Proveedor As String, ByVal Rut As String, ByVal Descuento As Double, ByVal Imp_esp_var As Double, ByVal Imp_esp_fijo As Double, ByVal Precio_base As Double, ByVal Total_neto As Double, ByVal Total_Iva As Double, ByVal Total_IEV As Double, ByVal Total_IEF As Double, ByVal Total_Ventas As Double, ByVal Precio As Double, ByVal Litros As Double, ByVal Obra As String)
        nue_var.consulta = "INSERT INTO Compras_petroleo_v2 (sincroniza, version, nombre_obra, id_obra, Fecha, N_Factura, Proveedor, Rut, Descuento, Imp_esp_var, Imp_esp_fijo, Precio_base, Total_neto, Total_Iva, Total_IEV, Total_IEF, Total_Ventas, Precio, Litros, Obra) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha, ?N_Factura, ?Proveedor, ?Rut, ?Descuento, ?Imp_esp_var, ?Imp_esp_fijo, ?Precio_base, ?Total_neto, ?Total_Iva, ?Total_IEV, ?Total_IEF, ?Total_Ventas, ?Precio, ?Litros, ?Obra)"
        Try
            nue_conexion.conectar_local()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra


            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?N_Factura", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = N_Factura
            nue_var.cmd.Parameters.Add("?Proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Proveedor
            nue_var.cmd.Parameters.Add("?Rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Rut
            nue_var.cmd.Parameters.Add("?Descuento", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = Descuento
            nue_var.cmd.Parameters.Add("?Imp_esp_var", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_var
            nue_var.cmd.Parameters.Add("?Imp_esp_fijo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_fijo
            nue_var.cmd.Parameters.Add("?Precio_base", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio_base
            nue_var.cmd.Parameters.Add("?Total_neto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_neto
            nue_var.cmd.Parameters.Add("?Total_Iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Iva
            nue_var.cmd.Parameters.Add("?Total_IEV", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEV
            nue_var.cmd.Parameters.Add("?Total_IEF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEF
            nue_var.cmd.Parameters.Add("?Total_Ventas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Ventas
            nue_var.cmd.Parameters.Add("?Precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = Litros
            nue_var.cmd.Parameters.Add("?Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_local()
            nue_var.consulta = "SELECT MAX(Id_compras) from Compras_petroleo_v2"
            Try
                nue_conexion.conectar_local()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(Id_compras)")
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
        nue_var.consulta = "UPDATE Compras_petroleo_v2 SET sincroniza = ?sincroniza WHERE Id_compras = ?Id_identificacion"
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
        nue_var.consulta = "UPDATE Compras_petroleo_v2 SET sincroniza = ?sincroniza WHERE Id_compras = ?Id_identificacion"
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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Compras_petroleo_v2 where sincroniza <> 0  and sincroniza <> 1 and id_obra = " & id_obra & "", nue_conexion.conex_remoto())
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
    Public Sub modificar_tabla(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal N_Factura As Double, ByVal Proveedor As String, ByVal Rut As String, ByVal Descuento As Double, ByVal Imp_esp_var As Double, ByVal Imp_esp_fijo As Double, ByVal Precio_base As Double, ByVal Total_neto As Double, ByVal Total_Iva As Double, ByVal Total_IEV As Double, ByVal Total_IEF As Double, ByVal Total_Ventas As Double, ByVal Precio As Double, ByVal Litros As Double, ByVal Obra As String)
        nue_var.consulta = "UPDATE Compras_petroleo_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Fecha = ?Fecha, N_Factura = ?N_Factura, Proveedor = ?Proveedor, Rut = ?Rut, Descuento = ?Descuento, Imp_esp_var = ?Imp_esp_var, Imp_esp_fijo = ?Imp_esp_fijo, Precio_base = ?Precio_base, Total_neto = ?Total_neto, Total_Iva = ?Total_Iva, Total_IEV = ?Total_IEV, Total_IEF = ?Total_IEF, Total_Ventas = ?Total_Ventas, Precio = ?Precio, Litros = ?Litros, Obra = ?Obra WHERE Id_compras = ?Cod_adicional"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_adicional", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_adicional
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra


            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?N_Factura", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = N_Factura
            nue_var.cmd.Parameters.Add("?Proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Proveedor
            nue_var.cmd.Parameters.Add("?Rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Rut
            nue_var.cmd.Parameters.Add("?Descuento", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = Descuento
            nue_var.cmd.Parameters.Add("?Imp_esp_var", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_var
            nue_var.cmd.Parameters.Add("?Imp_esp_fijo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_fijo
            nue_var.cmd.Parameters.Add("?Precio_base", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio_base
            nue_var.cmd.Parameters.Add("?Total_neto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_neto
            nue_var.cmd.Parameters.Add("?Total_Iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Iva
            nue_var.cmd.Parameters.Add("?Total_IEV", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEV
            nue_var.cmd.Parameters.Add("?Total_IEF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEF
            nue_var.cmd.Parameters.Add("?Total_Ventas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Ventas
            nue_var.cmd.Parameters.Add("?Precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = Litros
            nue_var.cmd.Parameters.Add("?Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar_eliminar(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE Compras_petroleo_v2 SET sincroniza = ?sincroniza, version = ?version WHERE Id_compras = ?Cod_identifica"
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
    Public Function verificar_version2(ByVal Id_compras As Integer, ByVal Id_obra As Integer) As Integer
        nue_var.consulta = "SELECT version FROM Compras_petroleo_v2 WHERE Id_compras = ?Id_compras and id_obra = ?Id_obra"
        nue_conexion.conectar_remoto()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
        nue_var.cmd.Parameters.Add("?Id_compras", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_compras
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
    Public Sub modificar_remoto2(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal N_Factura As Double, ByVal Proveedor As String, ByVal Rut As String, ByVal Descuento As Double, ByVal Imp_esp_var As Double, ByVal Imp_esp_fijo As Double, ByVal Precio_base As Double, ByVal Total_neto As Double, ByVal Total_Iva As Double, ByVal Total_IEV As Double, ByVal Total_IEF As Double, ByVal Total_Ventas As Double, ByVal Precio As Double, ByVal Litros As Double, ByVal Obra As String)
        nue_var.consulta = "UPDATE Compras_petroleo_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Fecha = ?Fecha, N_Factura = ?N_Factura, Proveedor = ?Proveedor, Rut = ?Rut, Descuento = ?Descuento, Imp_esp_var = ?Imp_esp_var, Imp_esp_fijo = ?Imp_esp_fijo, Precio_base = ?Precio_base, Total_neto = ?Total_neto, Total_Iva = ?Total_Iva, Total_IEV = ?Total_IEV, Total_IEF = ?Total_IEF, Total_Ventas = ?Total_Ventas, Precio = ?Precio, Litros = ?Litros, Obra = ?Obra WHERE Id_compras = ?Cod_adicional"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
            nue_var.cmd.Parameters.Add("?Cod_adicional", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_adicional
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra


            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?N_Factura", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = N_Factura
            nue_var.cmd.Parameters.Add("?Proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Proveedor
            nue_var.cmd.Parameters.Add("?Rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Rut
            nue_var.cmd.Parameters.Add("?Descuento", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = Descuento
            nue_var.cmd.Parameters.Add("?Imp_esp_var", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_var
            nue_var.cmd.Parameters.Add("?Imp_esp_fijo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_fijo
            nue_var.cmd.Parameters.Add("?Precio_base", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio_base
            nue_var.cmd.Parameters.Add("?Total_neto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_neto
            nue_var.cmd.Parameters.Add("?Total_Iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Iva
            nue_var.cmd.Parameters.Add("?Total_IEV", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEV
            nue_var.cmd.Parameters.Add("?Total_IEF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEF
            nue_var.cmd.Parameters.Add("?Total_Ventas", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Ventas
            nue_var.cmd.Parameters.Add("?Precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = Litros
            nue_var.cmd.Parameters.Add("?Obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Obra
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
End Class
