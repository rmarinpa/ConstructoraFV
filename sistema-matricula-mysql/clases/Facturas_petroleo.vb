Imports MySql.Data.MySqlClient
Public Class Facturas_petroleo

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM factura_comp where id_obra = " & id_obra & " and sincroniza <> 3 order by Fecha desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    Public Function listar_guias(ByVal id_obra As Integer, ByVal id_factura As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_guias_comp where id_obra = " & id_obra & " and id_factura = " & id_factura & " and sincroniza <> 3 order by N_guia asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar_guias = nue_var.dt
        Return listar_guias
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal N_Factura As Double, ByVal Proveedor As String, ByVal Rut As String, ByVal Litros As Double, ByVal Cargo_adic As Double)
        nue_var.consulta = "INSERT INTO factura_comp (sincroniza, version, nombre_obra, id_obra, Fecha, N_Factura, Proveedor, Rut, Litros, Cargo_adic) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha, ?N_Factura, ?Proveedor, ?Rut, ?Litros, ?Cargo_adic)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?N_Factura", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = N_Factura
            nue_var.cmd.Parameters.Add("?Proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Proveedor
            nue_var.cmd.Parameters.Add("?Rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Rut
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = Litros
            nue_var.cmd.Parameters.Add("?Cargo_adic", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Cargo_adic

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub modificar(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal N_Factura As Double, ByVal Proveedor As String, ByVal Rut As String, ByVal Litros As Double, ByVal Cargo_adic As Double)
        nue_var.consulta = "UPDATE factura_comp SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Fecha = ?Fecha, N_Factura = ?N_Factura, Proveedor = ?Proveedor, Rut = ?Rut, Litros = ?Litros, Cargo_adic = ?Cargo_adic WHERE Id_factura = ?Cod_adicional"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_adicional", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_adicional
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra


            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha
            nue_var.cmd.Parameters.Add("?N_Factura", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = N_Factura
            nue_var.cmd.Parameters.Add("?Proveedor", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Proveedor
            nue_var.cmd.Parameters.Add("?Rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Rut
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = Litros
            nue_var.cmd.Parameters.Add("?Cargo_adic", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Cargo_adic
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE factura_comp SET sincroniza = ?sincroniza, version = ?version WHERE Id_factura = ?Cod_adicional"
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

    Public Sub eliminar(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from factura_comp WHERE Id_factura = " & cod_1 & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub


    Public Sub insertar_guia(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal N_guia As Integer, ByVal Id_storage As Integer, id_factura As Integer, ByVal Precio As Double, ByVal Descuento As Double, ByVal Imp_esp_var As Double, ByVal Imp_esp_fijo As Double, ByVal Precio_base As Double, ByVal Total_neto As Double, ByVal Total_IEV As Double, ByVal Total_IEF As Double, ByVal Total_Iva As Double, ByVal Total_Compra As Double, ByVal Litros As Double)
        nue_var.consulta = "INSERT INTO guia_comp (sincroniza, version, nombre_obra, id_obra, N_guia, Id_storage, id_factura, Precio, Descuento, Imp_esp_var, Imp_esp_fijo, Precio_base, Total_neto, Total_IEV, Total_IEF, Total_Iva, Total_Compra, Litros) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?N_guia, ?Id_storage, ?id_factura, ?Precio, ?Descuento, ?Imp_esp_var, ?Imp_esp_fijo, ?Precio_base, ?Total_neto, ?Total_IEV, ?Total_IEF, ?Total_Iva, ?Total_Compra, ?Litros)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?id_factura", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_factura
            nue_var.cmd.Parameters.Add("?N_guia", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = N_guia
            nue_var.cmd.Parameters.Add("?Id_storage", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_storage

            nue_var.cmd.Parameters.Add("?Descuento", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = Descuento
            nue_var.cmd.Parameters.Add("?Imp_esp_var", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_var
            nue_var.cmd.Parameters.Add("?Imp_esp_fijo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_fijo
            nue_var.cmd.Parameters.Add("?Precio_base", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio_base
            nue_var.cmd.Parameters.Add("?Total_neto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_neto
            nue_var.cmd.Parameters.Add("?Total_Iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Iva
            nue_var.cmd.Parameters.Add("?Total_IEV", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEV
            nue_var.cmd.Parameters.Add("?Total_IEF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEF
            nue_var.cmd.Parameters.Add("?Total_Compra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Compra
            nue_var.cmd.Parameters.Add("?Precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = Litros

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub modificar_guia(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal N_guia As Integer, ByVal Id_storage As Integer, ByVal id_factura As Integer, ByVal Precio As Double, ByVal Descuento As Double, ByVal Imp_esp_var As Double, ByVal Imp_esp_fijo As Double, ByVal Precio_base As Double, ByVal Total_neto As Double, ByVal Total_IEV As Double, ByVal Total_IEF As Double, ByVal Total_Iva As Double, ByVal Total_Compra As Double, ByVal Litros As Double)
        nue_var.consulta = "UPDATE guia_comp SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, N_guia = ?N_guia, Id_storage = ?Id_storage, id_factura = ?id_factura, Precio = ?Precio, Descuento = ?Descuento, Imp_esp_var = ?Imp_esp_var, Imp_esp_fijo = ?Imp_esp_fijo, Precio_base = ?Precio_base, Total_neto = ?Total_neto, Total_IEV = ?Total_IEV, Total_IEF = ?Total_IEF, Total_Iva = ?Total_Iva, Total_Compra = ?Total_Compra, Litros = ?Litros WHERE Id_guias = ?Cod_adicional"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_adicional", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_adicional
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?id_factura", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_factura
            nue_var.cmd.Parameters.Add("?N_guia", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = N_guia
            nue_var.cmd.Parameters.Add("?Id_storage", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_storage


            nue_var.cmd.Parameters.Add("?Descuento", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = Descuento
            nue_var.cmd.Parameters.Add("?Imp_esp_var", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_var
            nue_var.cmd.Parameters.Add("?Imp_esp_fijo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Imp_esp_fijo
            nue_var.cmd.Parameters.Add("?Precio_base", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio_base
            nue_var.cmd.Parameters.Add("?Total_neto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_neto
            nue_var.cmd.Parameters.Add("?Total_Iva", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Iva
            nue_var.cmd.Parameters.Add("?Total_IEV", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEV
            nue_var.cmd.Parameters.Add("?Total_IEF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_IEF
            nue_var.cmd.Parameters.Add("?Total_Compra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Total_Compra
            nue_var.cmd.Parameters.Add("?Precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = Precio
            nue_var.cmd.Parameters.Add("?Litros", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = Litros

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro_guia(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE guia_comp SET sincroniza = ?sincroniza, version = ?version WHERE Id_guias = ?Cod_adicional"
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

    Public Sub eliminar_guia(ByVal cod_1 As Integer)
        nue_var.consulta = "Delete from guia_comp WHERE Id_guias = " & cod_1 & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Function litros_guia(ByVal Id_storage As Integer, ByVal id_obra As Integer) As Double
        nue_var.consulta = "SELECT Litros FROM Storage_v2 WHERE Id_storage = ?Id_storage and id_obra = ?id_obra and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Id_storage", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_storage
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()

        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("Litros")) Then
                litros_guia = 0
            Else
                litros_guia = nue_var.dr("Litros")
            End If
        End If

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return litros_guia
    End Function

    Public Function precio_guia(ByVal Id_storage As Integer, ByVal id_obra As Integer) As Double
        nue_var.consulta = "SELECT precio FROM Storage_v2 WHERE Id_storage = ?Id_storage and id_obra = ?id_obra and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Id_storage", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_storage
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()

        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("precio")) Then
                precio_guia = 0
            Else
                precio_guia = nue_var.dr("precio")
            End If
        End If

        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return precio_guia
    End Function
End Class
