Imports MySql.Data.MySqlClient
Public Class Ingreso_subcontratos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Function listar1(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM nombre_subcontrato Where id_obra = " & id_obra & " order by nombre_subcon asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar1 = nue_var.dt
        Return listar1
    End Function
    Public Function listar5(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM identificacion_obra Where id_obra = " & id_obra & " and sincroniza <> 3 order by nombre_faena asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Sub insertar(ByVal sincroniza As Integer, ByVal version As Integer, ByVal nombre_obra As String, ByVal id_obra As Integer, ByVal subcontratista As String, ByVal subcontrato As String, ByVal num_contrato As Integer, ByVal adjunto As String, ByVal usuario As String, ByVal fecha As Date, ByVal hora As Date, ByVal id_faena As Integer, ByVal faena As String, ByVal lugar As String, ByVal fecha_celebracion As Date, ByVal rut_subcontratista As String)
        nue_var.consulta = "INSERT INTO subcontratos_adjuntos (sincroniza, version, nombre_obra, id_obra, subcontratista, subcontrato, num_contrato, adjunto, usuario, fecha, hora, id_faena, faena, lugar, fecha_celebracion, rut_subcontratista) VALUES(?sincroniza, ?version, ?nombre_obra, ?id_obra, ?subcontratista, ?subcontrato, ?num_contrato, ?adjunto, ?usuario, ?fecha, ?hora, ?id_faena, ?faena, ?lugar, ?fecha_celebracion, ?rut_subcontratista)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?sincroniza", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = sincroniza
            nue_var.cmd.Parameters.Add("?version", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = version
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra

            nue_var.cmd.Parameters.Add("?subcontratista", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = subcontratista
            nue_var.cmd.Parameters.Add("?subcontrato", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = subcontrato
            nue_var.cmd.Parameters.Add("?num_contrato", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = num_contrato
            nue_var.cmd.Parameters.Add("?adjunto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = adjunto
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?hora", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = hora
            nue_var.cmd.Parameters.Add("?id_faena", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_faena
            nue_var.cmd.Parameters.Add("?faena", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = faena
            nue_var.cmd.Parameters.Add("?lugar", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = lugar
            nue_var.cmd.Parameters.Add("?fecha_celebracion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_celebracion
            nue_var.cmd.Parameters.Add("?rut_subcontratista", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut_subcontratista

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar_sincro(ByVal Cod_adicional As Integer, ByVal sincroniza As Integer, ByVal version As Integer)
        nue_var.consulta = "UPDATE subcontratos_adjuntos SET sincroniza = ?sincroniza, version = ?version WHERE Id_equipos_adjuntos = ?Cod_adicional"
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
    Public Function listar14(ByVal id_obra As Integer) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM consulta_subcontratos_adj where id_obra = " & id_obra & " and ( sincroniza <> 3 or isnull(sincroniza) ) order by servicio asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar14 = nue_var.dt
        Return listar14
    End Function
    Public Function verificar_obra(ByVal id_obra As Integer, ByVal rut As String, ByVal servicio As String) As String
        nue_var.consulta = "SELECT * FROM servicio_agrupado WHERE id_obra = ?id_obra and rut = ?rut and servicio = ?servicio"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?rut", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rut
        nue_var.cmd.Parameters.Add("?id_obra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_obra
        nue_var.cmd.Parameters.Add("?servicio", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = servicio
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar_obra = nue_var.dr("obra")
        Else
            verificar_obra = ""
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar_obra
    End Function
End Class
