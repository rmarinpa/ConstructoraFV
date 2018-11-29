Imports MySql.Data.MySqlClient
Public Class Archivos_Contratos

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Contratos
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        'nue_var.da = New MySqlDataAdapter("SELECT matricula.tipo_matricula, estudiante.nombres, estudiante.apellido1, curso.nombre, jornada.nombre, matricula.fecha_matricula, matricula.monto, usuario.nombre FROM matricula, estudiante, jornada, curso, usuario WHERE ", nue_conexion.conex())
        nue_var.da = New MySqlDataAdapter("SELECT * from Contrato order by Codigo_maquina asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar4(ByVal nombre_codigo As String) As String
        Dim codigo As String
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT Codigo_maquina FROM Contrato where Codigo_maquina like '%" & nombre_codigo & "%'", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        If nue_var.dt.Rows.Count > 0 Then
            codigo = nue_var.dt.Rows(0)("Codigo_maquina").ToString()
        Else
            codigo = ""
        End If
        nue_conexion.desconectar()
        'listar4 = nue_var.dt
        Return codigo
    End Function
    'procedimiento para insertar Contratos
    Public Sub insertar(ByVal cod_maq As String, ByVal ins_reg As String, ByVal per_cir As Date, ByVal forma_pago As String, ByVal precio As Double, ByVal fecha_inicio As Date, ByVal fecha_termino As Date, ByVal rev_tec As Date, ByVal tipo_maq As String, ByVal representante As String)
        nue_var.consulta = "INSERT INTO Contrato VALUES('', ?cod_maq, ?ins_reg, ?per_cir, ?forma_pago, ?precio, ?fecha_inicio, ?fecha_termino, ?rev_tec, ?tipo_maq, ?representante)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

            nue_var.cmd.Parameters.Add("?cod_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cod_maq
            nue_var.cmd.Parameters.Add("?ins_reg", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ins_reg
            nue_var.cmd.Parameters.Add("?per_cir", MySql.Data.MySqlClient.MySqlDbType.Date).Value = per_cir
            nue_var.cmd.Parameters.Add("?forma_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma_pago
            nue_var.cmd.Parameters.Add("?precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio
            nue_var.cmd.Parameters.Add("?fecha_inicio", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_inicio
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_termino
            nue_var.cmd.Parameters.Add("?rev_tec", MySql.Data.MySqlClient.MySqlDbType.Date).Value = rev_tec
            nue_var.cmd.Parameters.Add("?tipo_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_maq
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Representantes
    Public Sub modificar(ByVal cod_est As Integer, ByVal cod_maq As String, ByVal ins_reg As String, ByVal per_cir As Date, ByVal forma_pago As String, ByVal precio As Double, ByVal fecha_inicio As Date, ByVal fecha_termino As Date, ByVal rev_tec As Date, ByVal tipo_maq As String, ByVal representante As String)
        nue_var.consulta = "UPDATE Contrato SET Codigo_maquina = ?cod_maq, Ins_reg_civil = ?ins_reg, Permiso_circulacion = ?per_cir, Forma_de_pago = ?forma_pago, Precio = ?precio, Fecha_inicio = ?fecha_inicio, Fecha_termino = ?fecha_termino,  Revision_tecnica = ?rev_tec, Tipo_maquina = ?tipo_maq, Representante = ?representante  WHERE Id_contrato = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?cod_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cod_maq
            nue_var.cmd.Parameters.Add("?ins_reg", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ins_reg
            nue_var.cmd.Parameters.Add("?per_cir", MySql.Data.MySqlClient.MySqlDbType.Date).Value = per_cir
            nue_var.cmd.Parameters.Add("?forma_pago", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = forma_pago
            nue_var.cmd.Parameters.Add("?precio", MySql.Data.MySqlClient.MySqlDbType.Double).Value = precio
            nue_var.cmd.Parameters.Add("?fecha_inicio", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_inicio
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_termino
            nue_var.cmd.Parameters.Add("?rev_tec", MySql.Data.MySqlClient.MySqlDbType.Date).Value = rev_tec
            nue_var.cmd.Parameters.Add("?tipo_maq", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_maq
            nue_var.cmd.Parameters.Add("?representante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = representante
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from Contrato WHERE Id_contrato = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar2() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Representantes order by Nombre asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function

    Public Function listar3() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM Tipo_maq order by Tipo_de_maquinaria desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
End Class
