Imports MySql.Data.MySqlClient
Public Class sincronizacion

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim obra1 As String

    'funcion para listar los registros de Petroleo
    Public Function listar(ByVal tipo As String, ByVal nombre_obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar_local()
            nue_var.da = New MySqlDataAdapter("SELECT * FROM " & tipo & " where obra like '" & nombre_obra & "'  order by Fecha desc", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar_local()
            listar = nue_var.dt
            Return listar
        Catch mierror As MySqlException
            MsgBox("Tiene que tener abierta la base de datos local")
        End Try
    End Function
    Public Function listar_sincro_local(ByVal tipo As String, ByVal nombre_obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar_local()
            nue_var.da = New MySqlDataAdapter("SELECT * FROM " & tipo & " where obra like '" & nombre_obra & "'", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar_local()
            listar_sincro_local = nue_var.dt
            Return listar_sincro_local
        Catch mierror As MySqlException
            MsgBox("Tiene que tener abierta la base de datos local")
        End Try
    End Function
    Public Function listar_remoto(ByVal tipo As String, ByVal nombre_obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar_remoto()
            nue_var.da = New MySqlDataAdapter("SELECT * FROM " & tipo & " where obra like '" & nombre_obra & "'  order by Fecha desc", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar_remoto()
            listar_remoto = nue_var.dt
            Return listar_remoto
        Catch mierror As MySqlException
            MsgBox("No tiene conexión a Internet")
        End Try
    End Function
    Public Function listar_sincro_remoto(ByVal tipo As String, ByVal nombre_obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar_remoto()
            nue_var.da = New MySqlDataAdapter("SELECT * FROM " & tipo & " where obra like '" & nombre_obra & "'", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar_remoto()
            listar_sincro_remoto = nue_var.dt
            Return listar_sincro_remoto
        Catch mierror As MySqlException
            MsgBox("No tiene conexión a Internet")
        End Try
    End Function
    Public Function listar2(ByVal nombre_obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Contrato where obra like '%" & nombre_obra & "%' order by Codigo_maquina asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function

    'procedimiento para insertar registros de Petroleo
    Public Sub insertar(ByVal N_de_vale As Double, ByVal Codigo As String, ByVal fecha As Date, ByVal litros_consumo As Double, ByVal obra As String)
        nue_var.consulta = "INSERT INTO Petroleo VALUES('', ?N_de_vale, ?Codigo, ?fecha, ?litros_consumo, ?obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?N_de_vale", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_vale
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?litros_consumo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = litros_consumo
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()

        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub insertalocal(ByVal Id_petroleo As Integer, ByVal Id_petroleo_remoto As Integer, ByVal nombre_obra As String)
        nue_var.consulta = "INSERT INTO sincro_petroleo VALUES('', ?Id_petroleo, ?Id_petroleo_remoto, '', ?nombre_obra)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Id_petroleo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_petroleo
            nue_var.cmd.Parameters.Add("?Id_petroleo_remoto", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_petroleo_remoto
            nue_var.cmd.Parameters.Add("?nombre_obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()

        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    'procedimiento para modificar registros de Petroleo   
    Public Sub modificar(ByVal Cod_Petroleo As Integer, ByVal N_de_vale As Double, ByVal Codigo As String, ByVal fecha As Date, ByVal litros_consumo As Double, ByVal obra As String)
        nue_var.consulta = "UPDATE Petroleo SET N_de_vale = ?N_de_vale, Codigo = ?Codigo, fecha = ?fecha, litros_consumo = ?litros_consumo, obra = ?obra WHERE Id_petroleo = ?Cod_Petroleo"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_Petroleo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Cod_Petroleo
            nue_var.cmd.Parameters.Add("?N_de_vale", MySql.Data.MySqlClient.MySqlDbType.Double).Value = N_de_vale
            nue_var.cmd.Parameters.Add("?Codigo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Codigo
            nue_var.cmd.Parameters.Add("?Fecha", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
            nue_var.cmd.Parameters.Add("?litros_consumo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = litros_consumo
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'funcion para buscar el nombre de la máquina.
    Public Function descripcion_patente(ByVal num_id As String, ByVal obra As String) As String
        nue_var.consulta = "SELECT Ins_reg_civil FROM Contrato WHERE Codigo_maquina = ?num_id and Obra = ?obra"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num_id
        nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            descripcion_patente = nue_var.dr("Ins_reg_civil")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return descripcion_patente
    End Function
    Public Sub eliminar(ByVal cod_petroleo As Integer)
        nue_var.consulta = "Delete from Petroleo WHERE Id_petroleo = " & cod_petroleo & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar3(ByVal nombre_obra As String, ByVal fecha_inicio As String, ByVal fecha_final As String, ByVal codigo As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Petroleo where obra like '" & nombre_obra & "'  and Fecha >= '" & fecha_inicio & "' and Fecha <= '" & fecha_final & "' and Codigo like '%" & codigo & "%' order by Fecha asc, id_petroleo asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
End Class
