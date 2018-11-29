Imports MySql.Data.MySqlClient
Public Class Tabla_UF

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar(ByVal id_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM tabla_uf_v2 where id_obra = " & id_obra & " and sincroniza <> 3 order by Fecha_termino asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha_termino As Date, ByVal UF As Double)
        nue_var.consulta = "INSERT INTO tabla_uf_v2 (sincroniza, version, nombre_obra, id_obra, Fecha_termino, UF) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?Fecha_termino, ?UF)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?Fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha_termino
            nue_var.cmd.Parameters.Add("?UF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = UF
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub modificar(ByVal Cod_UF As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal Fecha_termino As Date, ByVal UF As Double)
        nue_var.consulta = "UPDATE tabla_uf_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, Fecha_termino = ?Fecha_termino, UF = ?UF WHERE Id_UF = ?Cod_UF"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_UF", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_UF
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
            nue_var.cmd.Parameters.Add("?Fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha_termino
            nue_var.cmd.Parameters.Add("?UF", MySql.Data.MySqlClient.MySqlDbType.Double).Value = UF
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro(ByVal Cod_UF As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE tabla_uf_v2 SET sincroniza = ?sincroniza, version = ?version WHERE Id_UF = ?Cod_UF"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_UF", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_UF
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function verificar_uf(ByVal id_obra As Integer, ByVal Fecha_termino As Date) As Integer
        nue_var.consulta = "SELECT * FROM tabla_uf_v2 WHERE id_obra = ?id_obra and Fecha_termino = ?Fecha_termino and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?Fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = Fecha_termino
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_uf = 1
        Else
            verificar_uf = 0
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_uf
    End Function
    Public Sub eliminar(ByVal cod_uf As Integer)
        nue_var.consulta = "Delete from tabla_uf_v2 WHERE Id_UF = " & cod_uf & ""

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
