Imports MySql.Data.MySqlClient
Public Class Contratos_Originales
    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Public Sub InsertarIngresodeContratoOriginal(ByVal obra As String, ByVal adjunto As String, ByVal usuario As String, ByVal fecha As DateTime)
        nue_var.consulta = "INSERT INTO contratosOriginales(obra,adjunto,usuario,fecha) VALUES (?obra,?adjunto,?usuario,?fecha)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.String).Value = obra
            nue_var.cmd.Parameters.Add("?adjunto", MySql.Data.MySqlClient.MySqlDbType.String).Value = adjunto
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.String).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
            MsgBox("Archivo " + adjunto + " subido correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Sub

    Public Function LeerDgvContrato(ByVal obra As String) As DataTable

        Try

            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("SELECT id_contratosOriginales,obra,case WHEN adjunto is not null then 'SI' ELSE 'NO' END AS 'Adjunto', usuario, fecha,adjunto FROM contratosoriginales where obra = '" & obra & "' order by fecha asc;", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerDgvContrato = nue_var.dt
            Return LeerDgvContrato
        Catch ex As Exception
            ex.Message.ToString()
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
            MsgBox("Se eliminó correctamente")
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
            nue_conexion.desconectar()
        End Try
    End Sub
End Class
