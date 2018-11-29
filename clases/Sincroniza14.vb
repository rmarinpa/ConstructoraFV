Imports MySql.Data.MySqlClient
Public Class Sincroniza14

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM usuario_v2 where sincroniza = 1 ", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar_remoto() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar_remoto()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM usuario_v2 where sincroniza <> 0", nue_conexion.conex_remoto())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar_remoto()
        listar_remoto = nue_var.dt
        Return listar_remoto
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal nombre As String, ByVal password As String, ByVal super_user As Integer, ByVal autoriza_1_1 As Integer, ByVal autoriza_1_2 As Integer, ByVal autoriza_1_3 As Integer)
        nue_var.consulta = "INSERT INTO usuario_v2 (sincroniza, version, nombre_obra, id_obra, nombre, password, super_user, autoriza_1_1, autoriza_1_2, autoriza_1_3) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?nombre, ?password, ?super_user, ?autoriza_1_1, ?autoriza_1_2, ?autoriza_1_3)"
        Try
            nue_conexion.conectar_remoto()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = id_obra
            nue_var.cmd.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre
            nue_var.cmd.Parameters.Add("?password", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = password
            nue_var.cmd.Parameters.Add("?super_user", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = super_user
            nue_var.cmd.Parameters.Add("?autoriza_1_1", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = autoriza_1_1
            nue_var.cmd.Parameters.Add("?autoriza_1_2", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = autoriza_1_2
            nue_var.cmd.Parameters.Add("?autoriza_1_3", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = autoriza_1_3



            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_remoto()
            nue_var.consulta = "SELECT MAX(cod_usuario) from usuario_v2"
            Try
                nue_conexion.conectar_remoto()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_remoto())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(cod_usuario)")
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
    Public Sub insertar_remoto(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal nombre As String, ByVal password As String, ByVal super_user As Integer, ByVal autoriza_1_1 As Integer, ByVal autoriza_1_2 As Integer, ByVal autoriza_1_3 As Integer)
        nue_var.consulta = "INSERT INTO usuario_v2 (sincroniza, version, nombre_obra, id_obra, nombre, password, super_user, autoriza_1_1, autoriza_1_2, autoriza_1_3) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?nombre, ?password, ?super_user, ?autoriza_1_1, ?autoriza_1_2, ?autoriza_1_3)"
        Try
            nue_conexion.conectar_local()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = id_obra
            nue_var.cmd.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre
            nue_var.cmd.Parameters.Add("?password", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = password
            nue_var.cmd.Parameters.Add("?super_user", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = super_user
            nue_var.cmd.Parameters.Add("?autoriza_1_1", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = autoriza_1_1
            nue_var.cmd.Parameters.Add("?autoriza_1_2", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = autoriza_1_2
            nue_var.cmd.Parameters.Add("?autoriza_1_3", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = autoriza_1_3

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar_local()
            nue_var.consulta = "SELECT MAX(cod_usuario) from usuario_v2"
            Try
                nue_conexion.conectar_local()
                nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex_local())
                nue_var.dr = nue_var.cmd.ExecuteReader()
                If nue_var.dr.Read Then
                    idd_sincroniza = nue_var.dr("MAX(cod_usuario)")
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
        nue_var.consulta = "UPDATE usuario_v2 SET sincroniza = ?sincroniza WHERE cod_usuario = ?Id_identificacion"
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
        nue_var.consulta = "UPDATE usuario_v2 SET sincroniza = ?sincroniza WHERE cod_usuario = ?Id_identificacion"
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
        nue_var.da = New MySqlDataAdapter("SELECT * FROM usuario_v2 where sincroniza <> 0  and sincroniza <> 1 and id_obra = " & id_obra & "", nue_conexion.conex_remoto())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar_remoto()
        listar_modifica = nue_var.dt
        Return listar_modifica
    End Function
    Public Function listar_temporal(ByVal id_seccion As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM sincroniza_temporal where Id_seccion = " & id_seccion & "", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar_temporal = nue_var.dt
        Return listar_temporal
    End Function
    Public Sub modificar_tabla(ByVal Cod_usuario_v2 As Integer, ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal nombre As String, ByVal password As String, ByVal super_user As Integer, ByVal autoriza_1_1 As Integer, ByVal autoriza_1_2 As Integer, ByVal autoriza_1_3 As Integer)
        nue_var.consulta = "UPDATE usuario_v2 SET sincroniza = ?sincroniza, version = ?version, nombre_obra = ?nombre_obra, id_obra = ?id_obra, nombre = ?nombre, password = ?password, super_user = ?super_user, autoriza_1_1 = ?autoriza_1_1, autoriza_1_2 = ?autoriza_1_2, autoriza_1_3 = ?autoriza_1_3  WHERE cod_usuario = ?Cod_usuario_v2"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_usuario_v2", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_usuario_v2
            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = id_obra
            nue_var.cmd.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre
            nue_var.cmd.Parameters.Add("?password", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = password
            nue_var.cmd.Parameters.Add("?super_user", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = super_user
            nue_var.cmd.Parameters.Add("?autoriza_1_1", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = autoriza_1_1
            nue_var.cmd.Parameters.Add("?autoriza_1_2", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = autoriza_1_2
            nue_var.cmd.Parameters.Add("?autoriza_1_3", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = autoriza_1_3
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar_eliminar(ByVal Cod_identifica As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE usuario_v2 SET sincroniza = ?sincroniza, version = ?version WHERE cod_usuario = ?Cod_identifica"
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
End Class
