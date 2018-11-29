Imports MySql.Data.MySqlClient

Public Class frm_estadoPagoMandante
    Dim Conexion As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter

    Private Sub frm_estadoPagoMandante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Realizar las pruebas en local'
        Try
            Conexion.ConnectionString = "server=localhost;user=root;password=toor;database=const113_constructorafv"
            Conexion.Open()
            Dim consulta As String
            consulta = "SELECT nombre_faena FROM identificacion_obra Where id_obra = " & id_obra & " and sincroniza <> 3 order by nombre_faena asc"
        Catch ex As Exception

        End Try
    End Sub
End Class