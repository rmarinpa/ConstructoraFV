Imports MySql.Data.MySqlClient
Public Class Boleta_garantia

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las Contratos
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from boleta_consulta order by f_solicitud desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listar2(ByVal obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from boleta_consulta where obra like '%" & obra & "%' order by f_solicitud desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar2 = nue_var.dt
        Return listar2
    End Function
    'procedimiento para insertar Contratos
    Public Sub insertar(ByVal Cod_bco As String, ByVal banco As String, ByVal monto_uf As Double, ByVal monto_pesos As Double, ByVal monto_usd As Double, ByVal f_solicitud As Date, ByVal f_vcto As Date, ByVal depart_sol As String, ByVal obra As String, ByVal glosa As String, ByVal estado As String, ByVal monto_uf2 As Double, ByVal monto_pesos2 As Double, ByVal monto_usd2 As Double, ByVal dias As Double, ByVal fecha_termino As Date, ByVal termino_final As String, ByVal tramitacion As String, ByVal fecha_envio As Date, ByVal fecha_liq As Date, ByVal estado2 As String, ByVal carta_devolucion As Date, ByVal adjunto As String, ByVal tipo As String, ByVal solicitado As String, ByVal situacion As String)
        nue_var.consulta = "INSERT INTO boleta_garantia VALUES('', ?Cod_bco , ?banco , ?monto_uf , ?monto_pesos , ?monto_usd , ?f_solicitud , ?f_vcto , ?depart_sol , ?obra , ?glosa , ?estado , ?monto_uf2 , ?monto_pesos2 , ?monto_usd2 , ?dias , ?fecha_termino , ?termino_final , ?tramitacion , ?fecha_envio , ?fecha_liq, ?estado2, ?carta_devolucion, ?adjunto, ?tipo, ?solicitado, ?situacion)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Cod_bco", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cod_bco
            nue_var.cmd.Parameters.Add("?banco", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = banco
            nue_var.cmd.Parameters.Add("?monto_uf", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_uf
            nue_var.cmd.Parameters.Add("?monto_pesos", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_pesos
            nue_var.cmd.Parameters.Add("?monto_usd", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_usd
            nue_var.cmd.Parameters.Add("?f_solicitud", MySql.Data.MySqlClient.MySqlDbType.Date).Value = f_solicitud
            nue_var.cmd.Parameters.Add("?f_vcto", MySql.Data.MySqlClient.MySqlDbType.Date).Value = f_vcto
            nue_var.cmd.Parameters.Add("?depart_sol", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = depart_sol
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?glosa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa
            nue_var.cmd.Parameters.Add("?estado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = estado
            nue_var.cmd.Parameters.Add("?monto_uf2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_uf2
            nue_var.cmd.Parameters.Add("?monto_pesos2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_pesos2
            nue_var.cmd.Parameters.Add("?monto_usd2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_usd2
            nue_var.cmd.Parameters.Add("?dias", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_termino
            nue_var.cmd.Parameters.Add("?termino_final", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = termino_final
            nue_var.cmd.Parameters.Add("?tramitacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tramitacion
            nue_var.cmd.Parameters.Add("?fecha_envio", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_envio
            nue_var.cmd.Parameters.Add("?fecha_liq", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_liq
            nue_var.cmd.Parameters.Add("?estado2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = estado2
            nue_var.cmd.Parameters.Add("?carta_devolucion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = carta_devolucion
            nue_var.cmd.Parameters.Add("?adjunto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = adjunto
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?solicitado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = solicitado
            nue_var.cmd.Parameters.Add("?situacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = situacion

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Representantes
    Public Sub modificar(ByVal cod_est As Integer, ByVal Cod_bco As String, ByVal banco As String, ByVal monto_uf As Double, ByVal monto_pesos As Double, ByVal monto_usd As Double, ByVal f_solicitud As Date, ByVal f_vcto As Date, ByVal depart_sol As String, ByVal obra As String, ByVal glosa As String, ByVal estado As String, ByVal monto_uf2 As Double, ByVal monto_pesos2 As Double, ByVal monto_usd2 As Double, ByVal dias As Double, ByVal fecha_termino As Date, ByVal termino_final As String, ByVal tramitacion As String, ByVal fecha_envio As Date, ByVal fecha_liq As Date, ByVal estado2 As String, ByVal carta_devolucion As Date, ByVal adjunto As String, ByVal tipo As String, ByVal solicitado As String, ByVal situacion As String)
        nue_var.consulta = "UPDATE boleta_garantia SET Cod_bco = ?Cod_bco, banco = ?banco, monto_uf = ?monto_uf, monto_pesos = ?monto_pesos, monto_usd = ?monto_usd, f_solicitud = ?f_solicitud, f_vcto = ?f_vcto,  depart_sol = ?depart_sol, obra = ?obra, glosa = ?glosa, estado = ?estado, monto_uf2 = ?monto_uf2, monto_pesos2 = ?monto_pesos2, monto_usd2 = ?monto_usd2, dias = ?dias, fecha_termino = ?fecha_termino, termino_final = ?termino_final, tramitacion = ?tramitacion, fecha_envio = ?fecha_envio, fecha_liq = ?fecha_liq, estado2 = ?estado2, carta_devolucion = ?carta_devolucion, adjunto = ?adjunto, tipo = ?tipo, solicitado = ?solicitado, situacion = ?situacion WHERE Id_boleta_garantia = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?Cod_bco", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cod_bco
            nue_var.cmd.Parameters.Add("?banco", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = banco
            nue_var.cmd.Parameters.Add("?monto_uf", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_uf
            nue_var.cmd.Parameters.Add("?monto_pesos", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_pesos
            nue_var.cmd.Parameters.Add("?monto_usd", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_usd
            nue_var.cmd.Parameters.Add("?f_solicitud", MySql.Data.MySqlClient.MySqlDbType.Date).Value = f_solicitud
            nue_var.cmd.Parameters.Add("?f_vcto", MySql.Data.MySqlClient.MySqlDbType.Date).Value = f_vcto
            nue_var.cmd.Parameters.Add("?depart_sol", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = depart_sol
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = obra
            nue_var.cmd.Parameters.Add("?glosa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa
            nue_var.cmd.Parameters.Add("?estado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = estado
            nue_var.cmd.Parameters.Add("?monto_uf2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_uf2
            nue_var.cmd.Parameters.Add("?monto_pesos2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_pesos2
            nue_var.cmd.Parameters.Add("?monto_usd2", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_usd2
            nue_var.cmd.Parameters.Add("?dias", MySql.Data.MySqlClient.MySqlDbType.Double).Value = dias
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_termino
            nue_var.cmd.Parameters.Add("?termino_final", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = termino_final
            nue_var.cmd.Parameters.Add("?tramitacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tramitacion
            nue_var.cmd.Parameters.Add("?fecha_envio", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_envio
            nue_var.cmd.Parameters.Add("?fecha_liq", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_liq
            nue_var.cmd.Parameters.Add("?estado2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = estado2
            nue_var.cmd.Parameters.Add("?carta_devolucion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = carta_devolucion
            nue_var.cmd.Parameters.Add("?adjunto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = adjunto
            nue_var.cmd.Parameters.Add("?tipo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo
            nue_var.cmd.Parameters.Add("?solicitado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = solicitado
            nue_var.cmd.Parameters.Add("?situacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = situacion

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from boleta_garantia WHERE Id_boleta_garantia = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub insertar2(ByVal nom_corto As String, ByVal nom_licitacion As String, ByVal valor_contrato As Double, ByVal fecha_tramitacion As Date, ByVal plazo_obra As Double, ByVal fecha_termino As Date, ByVal monto_boleta As Double, ByVal fecha_vigencia As Date, ByVal glosa As String, ByVal nombre As String, ByVal fecha_apertura As Date, ByVal uf_ultima As Double, ByVal monto_ad As Double, ByVal vigencia_ad As Date, ByVal glosa_ad As String, ByVal nombre_ad As String, ByVal chk_boleta As Double, ByVal enunciado As String, ByVal aprobado As String, ByVal usuario_aprob As String)
        nue_var.consulta = "INSERT INTO boletas_iniciales VALUES('', ?nom_corto , ?nom_licitacion , ?valor_contrato , ?fecha_tramitacion , ?plazo_obra , ?fecha_termino , ?monto_boleta , ?fecha_vigencia , ?glosa , ?nombre , ?fecha_apertura , ?uf_ultima , ?monto_ad , ?vigencia_ad , ?glosa_ad , ?nombre_ad, ?chk_boleta, ?enunciado, ?aprobado, ?usuario_aprob)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nom_corto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom_corto
            nue_var.cmd.Parameters.Add("?nom_licitacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom_licitacion
            nue_var.cmd.Parameters.Add("?valor_contrato", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_contrato
            nue_var.cmd.Parameters.Add("?fecha_tramitacion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_tramitacion
            nue_var.cmd.Parameters.Add("?plazo_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = plazo_obra
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_termino
            nue_var.cmd.Parameters.Add("?monto_boleta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_boleta
            nue_var.cmd.Parameters.Add("?fecha_vigencia", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_vigencia
            nue_var.cmd.Parameters.Add("?glosa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa
            nue_var.cmd.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre
            nue_var.cmd.Parameters.Add("?fecha_apertura", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_apertura
            nue_var.cmd.Parameters.Add("?uf_ultima", MySql.Data.MySqlClient.MySqlDbType.Double).Value = uf_ultima
            nue_var.cmd.Parameters.Add("?monto_ad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_ad
            nue_var.cmd.Parameters.Add("?vigencia_ad", MySql.Data.MySqlClient.MySqlDbType.Date).Value = vigencia_ad
            nue_var.cmd.Parameters.Add("?glosa_ad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa_ad
            nue_var.cmd.Parameters.Add("?nombre_ad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_ad
            nue_var.cmd.Parameters.Add("?chk_boleta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = chk_boleta
            nue_var.cmd.Parameters.Add("?enunciado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = enunciado
            nue_var.cmd.Parameters.Add("?aprobado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = aprobado
            nue_var.cmd.Parameters.Add("?usuario_aprob", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario_aprob

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Representantes
    Public Sub modificar2(ByVal cod_est As Integer, ByVal nom_corto As String, ByVal nom_licitacion As String, ByVal valor_contrato As Double, ByVal fecha_tramitacion As Date, ByVal plazo_obra As Double, ByVal fecha_termino As Date, ByVal monto_boleta As Double, ByVal fecha_vigencia As Date, ByVal glosa As String, ByVal nombre As String, ByVal fecha_apertura As Date, ByVal uf_ultima As Double, ByVal monto_ad As Double, ByVal vigencia_ad As Date, ByVal glosa_ad As String, ByVal nombre_ad As String, ByVal chk_boleta As Double, ByVal enunciado As String, ByVal aprobado As String, ByVal usuario_aprob As String)
        nue_var.consulta = "UPDATE boletas_iniciales SET nom_corto = ?nom_corto, nom_licitacion = ?nom_licitacion, valor_contrato = ?valor_contrato, fecha_tramitacion = ?fecha_tramitacion, plazo_obra = ?plazo_obra, fecha_termino = ?fecha_termino, monto_boleta = ?monto_boleta,  fecha_vigencia = ?fecha_vigencia, glosa = ?glosa, nombre = ?nombre, fecha_apertura = ?fecha_apertura, uf_ultima = ?uf_ultima, monto_ad = ?monto_ad, vigencia_ad = ?vigencia_ad, glosa_ad = ?glosa_ad, nombre_ad = ?nombre_ad, chk_boleta = ?chk_boleta, enunciado = ?enunciado, aprobado = ?aprobado, usuario_aprob = ?usuario_aprob WHERE Id_boletas = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?nom_corto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom_corto
            nue_var.cmd.Parameters.Add("?nom_licitacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom_licitacion
            nue_var.cmd.Parameters.Add("?valor_contrato", MySql.Data.MySqlClient.MySqlDbType.Double).Value = valor_contrato
            nue_var.cmd.Parameters.Add("?fecha_tramitacion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_tramitacion
            nue_var.cmd.Parameters.Add("?plazo_obra", MySql.Data.MySqlClient.MySqlDbType.Double).Value = plazo_obra
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_termino
            nue_var.cmd.Parameters.Add("?monto_boleta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_boleta
            nue_var.cmd.Parameters.Add("?fecha_vigencia", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_vigencia
            nue_var.cmd.Parameters.Add("?glosa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa
            nue_var.cmd.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre
            nue_var.cmd.Parameters.Add("?fecha_apertura", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_apertura
            nue_var.cmd.Parameters.Add("?uf_ultima", MySql.Data.MySqlClient.MySqlDbType.Double).Value = uf_ultima
            nue_var.cmd.Parameters.Add("?monto_ad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_ad
            nue_var.cmd.Parameters.Add("?vigencia_ad", MySql.Data.MySqlClient.MySqlDbType.Date).Value = vigencia_ad
            nue_var.cmd.Parameters.Add("?glosa_ad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = glosa_ad
            nue_var.cmd.Parameters.Add("?nombre_ad", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_ad
            nue_var.cmd.Parameters.Add("?chk_boleta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = chk_boleta
            nue_var.cmd.Parameters.Add("?enunciado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = enunciado
            nue_var.cmd.Parameters.Add("?aprobado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = aprobado
            nue_var.cmd.Parameters.Add("?usuario_aprob", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario_aprob


            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar2(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from boletas_iniciales WHERE Id_boletas = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar3() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from boletas_iniciales order by nom_corto desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar3 = nue_var.dt
        Return listar3
    End Function
    Public Function listar4() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from boletas_iniciales order by nom_corto desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar4 = nue_var.dt
        Return listar4
    End Function
    Public Function listar5(ByVal nom_corto As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from boletas_iniciales where nom_corto like '" & nom_corto & "' order by nom_corto desc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar5 = nue_var.dt
        Return listar5
    End Function
    Public Sub insertar3(ByVal nombre_corto As String, ByVal aumento_monto As Double, ByVal aumento_plazo As Double, ByVal fecha_tramitacion As Date, ByVal monto_valor As Double, ByVal nombre_modificacion As String, ByVal monto_boleta As Double, ByVal monto_boleta_ad As Double, ByVal tipo_modificacion As String, ByVal num_mod As Double)
        nue_var.consulta = "INSERT INTO modificacion_boletas VALUES('', ?nombre_corto , ?aumento_monto , ?aumento_plazo , ?fecha_tramitacion , ?monto_valor , ?nombre_modificacion , ?monto_boleta , ?monto_boleta_ad , ?tipo_modificacion, ?num_mod)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nombre_corto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_corto
            nue_var.cmd.Parameters.Add("?aumento_monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = aumento_monto
            nue_var.cmd.Parameters.Add("?aumento_plazo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = aumento_plazo
            nue_var.cmd.Parameters.Add("?fecha_tramitacion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_tramitacion
            nue_var.cmd.Parameters.Add("?monto_valor", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_valor
            nue_var.cmd.Parameters.Add("?nombre_modificacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_modificacion
            nue_var.cmd.Parameters.Add("?monto_boleta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_boleta
            nue_var.cmd.Parameters.Add("?monto_boleta_ad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_boleta_ad
            nue_var.cmd.Parameters.Add("?tipo_modificacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_modificacion
            nue_var.cmd.Parameters.Add("?num_mod", MySql.Data.MySqlClient.MySqlDbType.Double).Value = num_mod

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Representantes
    Public Sub modificar3(ByVal cod_est As Integer, ByVal nombre_corto As String, ByVal aumento_monto As Double, ByVal aumento_plazo As Double, ByVal fecha_tramitacion As Date, ByVal monto_valor As Double, ByVal nombre_modificacion As String, ByVal monto_boleta As Double, ByVal monto_boleta_ad As Double, ByVal tipo_modificacion As String, ByVal num_mod As Double)
        nue_var.consulta = "UPDATE modificacion_boletas SET nombre_corto = ?nombre_corto, aumento_monto = ?aumento_monto, aumento_plazo = ?aumento_plazo, fecha_tramitacion = ?fecha_tramitacion, monto_valor = ?monto_valor, nombre_modificacion = ?nombre_modificacion, monto_boleta = ?monto_boleta,  monto_boleta_ad = ?monto_boleta_ad, tipo_modificacion = ?tipo_modificacion, num_mod = ?num_mod WHERE Id_aumento = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?nombre_corto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_corto
            nue_var.cmd.Parameters.Add("?aumento_monto", MySql.Data.MySqlClient.MySqlDbType.Double).Value = aumento_monto
            nue_var.cmd.Parameters.Add("?aumento_plazo", MySql.Data.MySqlClient.MySqlDbType.Double).Value = aumento_plazo
            nue_var.cmd.Parameters.Add("?fecha_tramitacion", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_tramitacion
            nue_var.cmd.Parameters.Add("?monto_valor", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_valor
            nue_var.cmd.Parameters.Add("?nombre_modificacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_modificacion
            nue_var.cmd.Parameters.Add("?monto_boleta", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_boleta
            nue_var.cmd.Parameters.Add("?monto_boleta_ad", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_boleta_ad
            nue_var.cmd.Parameters.Add("?tipo_modificacion", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_modificacion
            nue_var.cmd.Parameters.Add("?num_mod", MySql.Data.MySqlClient.MySqlDbType.Double).Value = num_mod


            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar3(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from modificacion_boletas WHERE Id_aumento = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function buscar_folio(ByVal nombre_corto As String) As Integer
        nue_var.consulta = "SELECT num_mod FROM modificacion_boletas WHERE nombre_corto like '" & nombre_corto & "' order by num_mod desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("num_mod")) Then
                buscar_folio = 0
            Else
                buscar_folio = nue_var.dr("num_mod")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return buscar_folio
    End Function
    Public Function listar6(ByVal nombre_corto As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from modificacion_boletas where nombre_corto like '" & nombre_corto & "' order by num_mod asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar6 = nue_var.dt
        Return listar6
    End Function
    Public Function buscar_folio2(ByVal nombre_corto As String) As Integer
        nue_var.consulta = "SELECT num_mod FROM canje_boletas WHERE nombre_corto like '" & nombre_corto & "' order by num_mod desc"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            If IsDBNull(nue_var.dr("num_mod")) Then
                buscar_folio2 = 0
            Else
                buscar_folio2 = nue_var.dr("num_mod")
            End If
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return buscar_folio2
    End Function
    Public Sub insertar4(ByVal nombre_corto As String, ByVal fecha_termino As Date, ByVal monto_valor As Double, ByVal fecha_monto As Date, ByVal nombre_canje As String, ByVal num_mod As Double)
        nue_var.consulta = "INSERT INTO canje_boletas VALUES('', ?nombre_corto , ?fecha_termino , ?monto_valor , ?fecha_monto , ?nombre_canje , ?num_mod)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nombre_corto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_corto
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_termino
            nue_var.cmd.Parameters.Add("?monto_valor", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_valor
            nue_var.cmd.Parameters.Add("?fecha_monto", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_monto
            nue_var.cmd.Parameters.Add("?nombre_canje", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_canje
            nue_var.cmd.Parameters.Add("?num_mod", MySql.Data.MySqlClient.MySqlDbType.Double).Value = num_mod

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    'procedimiento para modificar Representantes
    Public Sub modificar4(ByVal cod_est As Integer, ByVal nombre_corto As String, ByVal fecha_termino As Date, ByVal monto_valor As Double, ByVal fecha_monto As Date, ByVal nombre_canje As String, ByVal num_mod As Double)
        nue_var.consulta = "UPDATE canje_boletas SET nombre_corto = ?nombre_corto, fecha_termino = ?fecha_termino, monto_valor = ?monto_valor, fecha_monto = ?fecha_monto, nombre_canje = ?nombre_canje, num_mod = ?num_mod WHERE Id_canje = ?cod_est"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
            nue_var.cmd.Parameters.Add("?nombre_corto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_corto
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_termino
            nue_var.cmd.Parameters.Add("?monto_valor", MySql.Data.MySqlClient.MySqlDbType.Double).Value = monto_valor
            nue_var.cmd.Parameters.Add("?fecha_monto", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha_monto
            nue_var.cmd.Parameters.Add("?nombre_canje", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nombre_canje
            nue_var.cmd.Parameters.Add("?num_mod", MySql.Data.MySqlClient.MySqlDbType.Double).Value = num_mod

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub eliminar4(ByVal cod_est As Integer)
        nue_var.consulta = "Delete from canje_boletas WHERE Id_canje = " & cod_est & ""

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listar7(ByVal nombre_corto As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from canje_boletas where nombre_corto like '" & nombre_corto & "' order by num_mod asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar7 = nue_var.dt
        Return listar7
    End Function
    Public Function verificar(ByVal usuario As String) As Boolean
        nue_var.consulta = "SELECT * FROM aprobacion WHERE usuario = ?usuario"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
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
    Public Function listar8() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from boletas_iniciales where aprobado like 'NO' order by nom_corto asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar8 = nue_var.dt
        Return listar8
    End Function
    Public Sub modificar4(ByVal nom_corto As String, ByVal aprobado As String, ByVal usuario_aprob As String)
        nue_var.consulta = "UPDATE boletas_iniciales SET aprobado = ?aprobado, usuario_aprob = ?usuario_aprob WHERE nom_corto = ?nom_corto"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nom_corto", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom_corto
            nue_var.cmd.Parameters.Add("?aprobado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = aprobado
            nue_var.cmd.Parameters.Add("?usuario_aprob", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario_aprob
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
