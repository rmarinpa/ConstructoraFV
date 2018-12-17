Imports MySql.Data.MySqlClient
Public Class Modificaciones
    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Public Sub InsertarModificaciones(ByVal obra As String, ByVal nro_modificacion As Integer, ByVal adjunto As String, ByVal usuario As String, ByVal fecha As DateTime)
        nue_var.consulta = "INSERT INTO modificaciones (obra,ListadoModificaciones_id_modificaciones,adjunto,usuario,fecha) VALUES (?obra,?ListadoModificaciones_id_modificaciones,?adjunto,?usuario,?fecha)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.String).Value = obra
            nue_var.cmd.Parameters.Add("?ListadoModificaciones_id_modificaciones", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = nro_modificacion
            nue_var.cmd.Parameters.Add("?adjunto", MySql.Data.MySqlClient.MySqlDbType.String).Value = adjunto
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.String).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            MsgBox("Archivo " + adjunto + " subido correctamente")
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Sub
    Public Function LeerDgvModificaciones(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("select mo.id_modificaciones, li.obra, li.nro_modificacion, mo.adjunto, mo.usuario, mo.fecha, case WHEN adjunto is not null then 'SI' ELSE 'NO' END AS 'Adjunto', mo.obra from listadomodificaciones li left join modificaciones mo on mo.ListadoModificaciones_id_modificaciones = li.id_modificaciones where li.obra = '" & obra & "' ORDER BY li.fecha asc", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerDgvModificaciones = nue_var.dt
            Return LeerDgvModificaciones
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try

    End Function


    Public Sub EliminarContrato(ByVal id_contrato As Integer)
        nue_var.consulta = "Delete from contratosOriginales WHERE id_contratosOriginales = " & id_contrato & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Function LeerModificacionesExistente(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("SELECT * from listadomodificaciones where obra = '" & obra & "'  order by nro_modificacion asc", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerModificacionesExistente = nue_var.dt
            Return LeerModificacionesExistente
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Function
    Public Sub EliminarModificacion(ByVal id_modificacionesContrato As Integer)
        nue_var.consulta = "Delete from modificaciones WHERE id_modificaciones = " & id_modificacionesContrato & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
            MsgBox("Adjunto eliminado correctamente", MsgBoxStyle.Information)
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
            nue_conexion.desconectar()
        End Try
    End Sub
End Class



