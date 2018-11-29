Imports MySql.Data.MySqlClient
Public Class Tabla_Plan_de_Cuentas

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar(ByVal id_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM tabla_plan_de_cuentas where id_obra = " & id_obra & " and sincroniza <> 3 order by Cuenta_costo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Cuenta_Costo As String, ByVal Descripcion As String)
        nue_var.consulta = "INSERT INTO tabla_plan_de_cuentas (sincroniza, version, nombre_obra, id_obra, Cuenta_costo, Descripcion) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Cuenta_costo, ?Descripcion)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?Cuenta_Costo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_Costo
            nue_var.cmd.Parameters.Add("?Descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Plan de Cuentas   
    Public Sub modificar(ByVal Cod_Plan_de_cuentas As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Cuenta_Costo As String, ByVal Descripcion As String)
        nue_var.consulta = "UPDATE tabla_plan_de_cuentas SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Cuenta_costo = ?Cuenta_costo, Descripcion = ?Descripcion WHERE Id_Tabla_Plan_de_Cuentas = ?Cod_Plan_de_cuentas"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Plan_de_cuentas", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Plan_de_cuentas
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?Cuenta_Costo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cuenta_Costo
            nue_var.cmd.Parameters.Add("?Descripcion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descripcion
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_plan_de_cuentas As Integer)
        nue_var.consulta = "Delete from tabla_plan_de_cuentas WHERE Id_Tabla_Plan_de_Cuentas = " & cod_plan_de_cuentas & ""

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
        nue_var.consulta = "UPDATE tabla_plan_de_cuentas SET sincroniza = ?sincroniza, version = ?version WHERE Id_Tabla_Plan_de_Cuentas = ?Cod_identifica"
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
End Class
