Imports MySql.Data.MySqlClient
Public Class Compras_petroleo

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Compras_petroleo_v2 where id_obra = " & id_obra & " and sincroniza <> 3 order by Fecha desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal N_Factura As Double, ByVal Proveedor As String, ByVal Rut As String, ByVal Descuento As Double, ByVal Imp_esp_var As Double, ByVal Imp_esp_fijo As Double, ByVal Precio_base As Double, ByVal Total_neto As Double, ByVal Total_Iva As Double, ByVal Total_IEV As Double, ByVal Total_IEF As Double, ByVal Total_Ventas As Double, ByVal Precio As Double, ByVal Litros As Double, ByVal Obra As String, ByVal costo_adm As Double)
        nue_var.consulta = "INSERT INTO Compras_petroleo_v2 (sincroniza, version, nombre_obra, id_obra, Fecha, N_Factura, Proveedor, Rut, Descuento, Imp_esp_var, Imp_esp_fijo, Precio_base, Total_neto, Total_Iva, Total_IEV, Total_IEF, Total_Ventas, Precio, Litros, Obra, costo_adm) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha, ?N_Factura, ?Proveedor, ?Rut, ?Descuento, ?Imp_esp_var, ?Imp_esp_fijo, ?Precio_base, ?Total_neto, ?Total_Iva, ?Total_IEV, ?Total_IEF, ?Total_Ventas, ?Precio, ?Litros, ?Obra, ?costo_adm)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
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
            nue_var.cmd.Parameters.Add("?costo_adm", MySql.Data.MySqlClient.MySqlDbType.Double).Value = costo_adm

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub modificar(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha As Date, ByVal N_Factura As Double, ByVal Proveedor As String, ByVal Rut As String, ByVal Descuento As Double, ByVal Imp_esp_var As Double, ByVal Imp_esp_fijo As Double, ByVal Precio_base As Double, ByVal Total_neto As Double, ByVal Total_Iva As Double, ByVal Total_IEV As Double, ByVal Total_IEF As Double, ByVal Total_Ventas As Double, ByVal Precio As Double, ByVal Litros As Double, ByVal Obra As String, ByVal costo_adm As Double)
        nue_var.consulta = "UPDATE Compras_petroleo_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Fecha = ?Fecha, N_Factura = ?N_Factura, Proveedor = ?Proveedor, Rut = ?Rut, Descuento = ?Descuento, Imp_esp_var = ?Imp_esp_var, Imp_esp_fijo = ?Imp_esp_fijo, Precio_base = ?Precio_base, Total_neto = ?Total_neto, Total_Iva = ?Total_Iva, Total_IEV = ?Total_IEV, Total_IEF = ?Total_IEF, Total_Ventas = ?Total_Ventas, Precio = ?Precio, Litros = ?Litros, Obra = ?Obra, costo_adm = ?costo_adm WHERE Id_compras = ?Cod_adicional"
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
            nue_var.cmd.Parameters.Add("?costo_adm", MySql.Data.MySqlClient.MySqlDbType.Double).Value = costo_adm
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE Compras_petroleo_v2 SET sincroniza = ?sincroniza, version = ?version WHERE Id_compras = ?Cod_adicional"
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
        nue_var.consulta = "Delete from Compras_petroleo_v2 WHERE Id_compras = " & cod_1 & ""
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
