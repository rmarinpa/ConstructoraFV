Imports MySql.Data.MySqlClient
Public Class listadoModificaciones
    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Public Function InsertarlistadoModificaciones(ByVal obra As String, ByVal nro_modificacion As Integer, ByVal fecha As DateTime, ByVal aumentoObra As Integer, ByVal disminucionObra As Integer, ByVal obraExtraordinaria As Integer, ByVal plazo As Integer, ByVal retencion As Integer, ByVal proforma As Integer)
        nue_var.consulta = "INSERT INTO listadomodificaciones (obra,nro_modificacion,fecha,aumentoObra,disminucionObra,obraExtraordinaria,plazo,retencion,proforma) VALUES (?obra,?nro_modificacion,?fecha,?aumentoObra,?disminucionObra,?obraExtraordinaria,?plazo,?retencion,?proforma)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.String).Value = obra
            nue_var.cmd.Parameters.Add("?nro_modificacion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = nro_modificacion
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.Parameters.Add("?aumentoObra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = aumentoObra
            nue_var.cmd.Parameters.Add("?disminucionObra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = disminucionObra
            nue_var.cmd.Parameters.Add("?obraExtraordinaria", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = obraExtraordinaria
            nue_var.cmd.Parameters.Add("?plazo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = plazo
            nue_var.cmd.Parameters.Add("?retencion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = retencion
            nue_var.cmd.Parameters.Add("?proforma", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = proforma

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
            MsgBox("Se insertó correctamente")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
            Return False
        End Try
    End Function
    Public Function LeerDgvListadoModificaciones(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("SELECT * from listadomodificaciones where obra = '" & obra & "' order by fecha ASC", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerDgvListadoModificaciones = nue_var.dt
            Return LeerDgvListadoModificaciones
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try

    End Function

    Public Function ModificarListado(ByVal id_modificaciones As Integer, ByVal obra As String, ByVal nro_modificacion As Integer, ByVal fecha As Date, ByVal aumentoObra As Integer, ByVal disminucionObra As Integer, ByVal obraExtraordinaria As Integer, ByVal plazo As Integer, ByVal retencion As Integer, ByVal proforma As Integer)
        nue_var.consulta = "UPDATE listadomodificaciones SET obra = ?obra, nro_modificacion = ?nro_modificacion, fecha = ?fecha, aumentoObra = ?aumentoObra,disminucionObra= ?disminucionObra, obraExtraordinaria = ?obraExtraordinaria,  plazo = ?plazo, retencion = ?retencion, proforma =?proforma WHERE id_modificaciones = ?id_modificaciones"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id_modificaciones", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_modificaciones
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.String).Value = obra
            nue_var.cmd.Parameters.Add("?nro_modificacion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = nro_modificacion
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.Parameters.Add("?aumentoObra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = aumentoObra
            nue_var.cmd.Parameters.Add("?disminucionObra", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = disminucionObra
            nue_var.cmd.Parameters.Add("?obraExtraordinaria", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = obraExtraordinaria
            nue_var.cmd.Parameters.Add("?plazo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = plazo
            nue_var.cmd.Parameters.Add("?retencion", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = retencion
            nue_var.cmd.Parameters.Add("?proforma", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = proforma
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
            MsgBox("Se modificó correctamente")
            Return True
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
            MsgBox(mierror.Message)
            Throw New Exception(mierror.Message)
            nue_conexion.desconectar()
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal IdModificaciones As Integer)
        nue_var.consulta = "Delete from listadomodificaciones WHERE id_modificaciones = " & IdModificaciones & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
            MsgBox("Se eliminó correctamente")
            Return True
        Catch ex As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & ex.Message)
            nue_conexion.desconectar()
            Return False
        End Try
    End Function

    Public Function RegistroExistente(ByVal obra As String, ByVal nro_modificacion As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand("SELECT * FROM listadomodificaciones WHERE nro_modificacion='" & nro_modificacion & "' AND obra='" & obra & "'", nue_conexion.conex())
            nue_var.dr = nue_var.cmd.ExecuteReader
            If nue_var.dr.Read Then
                resultado = True
            End If
            nue_conexion.desconectar()
        Catch ex As Exception
            Return False
            nue_conexion.desconectar()
        End Try
        Return resultado
    End Function

    Public Function RegistroExistenteModificaciones(ByVal obra As String, ByVal ListadoModificaciones_id_modificaciones As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand("SELECT * FROM modificaciones WHERE ListadoModificaciones_id_modificaciones='" & ListadoModificaciones_id_modificaciones & "' AND obra='" & obra & "'", nue_conexion.conex())
            nue_var.dr = nue_var.cmd.ExecuteReader
            If nue_var.dr.Read Then
                resultado = True
            End If
            nue_conexion.desconectar()
        Catch ex As Exception
            Return False
            nue_conexion.desconectar()
        End Try
        Return resultado
    End Function

    Public Function RegistroAdjuntoContratoExistente(ByVal adjunto As String, ByVal obra As String) As Boolean
        Dim resultado As Boolean = False
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand("SELECT * FROM contratooriginales WHERE adjunto='" & adjunto & "' AND obra='" & obra & "'", nue_conexion.conex())
            nue_var.dr = nue_var.cmd.ExecuteReader
            If nue_var.dr.Read Then
                resultado = True
            End If
            nue_conexion.desconectar()
        Catch ex As Exception
            Return False
        End Try
        Return resultado
    End Function


End Class
