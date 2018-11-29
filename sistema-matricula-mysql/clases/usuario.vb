Imports MySql.Data.MySqlClient
Public Class usuario
Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function verificar(ByVal nom As String, ByVal pass As String, ByVal nombre_obra As String) As Boolean
        nue_var.consulta = "SELECT * FROM usuario_v2 WHERE nombre = ?nom and password = MD5( ?pass ) and nombre_obra = ?nombre_obra and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
        nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
        nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar = True
        Else
            verificar = False
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar
    End Function
    Public Function verificar_usuario(ByVal nom As String, ByVal pass As String) As Boolean
        nue_var.consulta = "SELECT * FROM usuario_v2 WHERE nombre = ?nom and password = MD5( ?pass ) and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
        nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_usuario = True
        Else
            verificar_usuario = False
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_usuario
    End Function
    Public Function listar_usuario(ByVal nom As String, ByVal pass As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM usuario_v2 where nombre like '" & nom & "' and password like MD5('" & pass & "') and sincroniza <> 3 order by cod_usuario asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar_usuario = nue_var.dt
        Return listar_usuario
    End Function
    Public Function cod_usuario(ByVal nom As String, ByVal pass As String) As Integer
        nue_var.consulta = "SELECT * FROM usuario_v2 WHERE nombre = ?nom and password = MD5( ?pass ) and sincroniza <> 3"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
        nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            cod_usuario = nue_var.dr("cod_usuario")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return cod_usuario
    End Function
    Public Function listar2(ByVal username As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("SELECT * FROM usuario_v2 Where nombre like '" & username & "' and sincroniza <> 3 order by nombre_obra desc", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            listar2 = nue_var.dt
            Return listar2
        Catch mierror As MySqlException
            If sincroniza = 0 Then
                MsgBox("No tiene conexión a Internet")
            ElseIf sincroniza = 1 Then
                MsgBox("Necesita abrir la base de datos local")
            End If
        End Try
    End Function
    Public Sub modificar_contrasena(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre As String, ByVal password As String)
        nue_var.consulta = "UPDATE usuario_v2 SET sincroniza = ?sincroniza, version = ?version, password = ?password WHERE nombre = ?nombre"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre
            nue_var.cmd.Parameters.Add("?password", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = password

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
