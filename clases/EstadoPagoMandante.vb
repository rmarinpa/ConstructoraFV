Imports MySql.Data.MySqlClient

Public Class EstadoPagoMandante
    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Sub InsertarEstadoPagoFirmado(ByVal obra As String, ByVal Estado_Pago_Nro_Estado_Pago As Integer, ByVal adjunto As String, ByVal usuario As String, ByVal fecha As DateTime)
        nue_var.consulta = "INSERT INTO estado_pago_firmado(obra,estado_pago_Id_Estado_Pago,adjunto,usuario,fecha) VALUES (?obra,?estado_pago_Id_Estado_Pago,?adjunto,?usuario,?fecha)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.String).Value = obra
            nue_var.cmd.Parameters.Add("?estado_pago_Id_Estado_Pago", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Estado_Pago_Nro_Estado_Pago
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

    Public Sub InsertarFacturaFirmada(ByVal obra As String, ByVal nroEstadoPagoAsociado As Integer, ByVal nroFactura As Integer, ByVal adjunto As String, ByVal usuario As String, ByVal fecha As DateTime)
        nue_var.consulta = "INSERT INTO facturas_firmadas(obra,estado_pago_Id_Estado_Pago,Nro_Factura,adjunto,usuario,fecha) VALUES (?obra,?estado_pago_Id_Estado_Pago,?nroFactura,?adjunto,?usuario,?fecha)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.String).Value = obra
            nue_var.cmd.Parameters.Add("?estado_pago_Id_Estado_Pago", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = nroEstadoPagoAsociado
            nue_var.cmd.Parameters.Add("?nroFactura", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = nroFactura
            nue_var.cmd.Parameters.Add("?adjunto", MySql.Data.MySqlClient.MySqlDbType.String).Value = adjunto
            nue_var.cmd.Parameters.Add("?usuario", MySql.Data.MySqlClient.MySqlDbType.String).Value = usuario
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Sub

    Public Function Insertar(ByVal nro_Estado_Pago As Integer, ByVal obra As String, ByVal fecha As Date, ByVal nro_factura As Integer, ByVal obras As Integer, ByVal reajuste As Integer, ByVal retenciones As Integer, ByVal retenciones_canjeadas As Integer, ByVal multas As Integer, ByVal valor_estado_pago As Integer, ByVal valor_estado_pago_neto As Integer, ByVal obras_neto As Integer, ByVal reajuste_neto As Integer, ByVal observaciones As String)
        nue_var.consulta = "INSERT INTO ESTADO_PAGO (nro_Estado_Pago,Obra,Fecha,Nro_factura, obras, reajuste, retenciones, retenciones_canjeadas, multas, valor_estado_pago, valor_estado_pago_neto, obras_neto, reajuste_neto,observaciones) VALUES(?nro_Estado_Pago,?Obra,?Fecha,?Nro_factura, ?obras, ?reajuste, ?retenciones, ?retenciones_canjeadas, ?multas, ?valor_estado_pago, ?valor_estado_pago_neto, ?obras_neto, ?reajuste_neto,?observaciones)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?nro_Estado_Pago", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = nro_Estado_Pago
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.String).Value = obra
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.Parameters.Add("?nro_factura", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = nro_factura
            nue_var.cmd.Parameters.Add("?obras", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = obras
            nue_var.cmd.Parameters.Add("?reajuste", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = reajuste
            nue_var.cmd.Parameters.Add("?retenciones", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = retenciones
            nue_var.cmd.Parameters.Add("?retenciones_canjeadas", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = retenciones_canjeadas
            nue_var.cmd.Parameters.Add("?multas", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = multas
            nue_var.cmd.Parameters.Add("?valor_estado_pago", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = valor_estado_pago
            nue_var.cmd.Parameters.Add("?valor_estado_pago_neto", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = valor_estado_pago_neto
            nue_var.cmd.Parameters.Add("?obras_neto", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = obras_neto
            nue_var.cmd.Parameters.Add("?reajuste_neto", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = reajuste_neto
            nue_var.cmd.Parameters.Add("?observaciones", MySql.Data.MySqlClient.MySqlDbType.String).Value = observaciones
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
            Return False
        End Try
    End Function
    Public Function LeerNroEstadoPago(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("SELECT * from estado_pago where obra = '" & obra & "' order by nro_estado_pago asc", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerNroEstadoPago = nue_var.dt
            Return LeerNroEstadoPago
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Function
    Public Function LeerNroEstadoPagoFactura(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("SELECT * from estado_pago where obra = '" & obra & "' order by nro_estado_pago asc", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerNroEstadoPagoFactura = nue_var.dt
            Return LeerNroEstadoPagoFactura
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Function
    Public Function LeerFacturaFirmada(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("SELECT * from ESTADO_PAGO where obra = '" & obra & "' ", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerFacturaFirmada = nue_var.dt
            Return LeerFacturaFirmada
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Function
    Public Function LeerEstadosPagoFirmadoObra(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("select pf.Id_Estado_Pago_Firmado, pf.Obra, ep.nro_estado_pago,pf.Adjunto,pf.Usuario, pf.fecha from estado_pago_firmado pf inner join estado_pago ep on pf.estado_pago_Id_Estado_Pago = ep.Id_estado_pago where pf.obra = '" & obra & "' order by Id_Estado_Pago_Firmado desc", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerEstadosPagoFirmadoObra = nue_var.dt
            Return LeerEstadosPagoFirmadoObra
        Catch ex As Exception
            MsgBox(ex.Message)
            nue_conexion.desconectar()
        End Try
    End Function

    Public Function Leer(ByVal obra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * from estado_pago where obra = '" & obra & "' order by nro_estado_pago asc", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        Leer = nue_var.dt
        Return Leer
    End Function
    Public Function LeerAdjuntoPagosFirmados(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("select pf.Id_Estado_Pago_Firmado, pf.Obra, ep.nro_estado_pago,pf.adjunto As 'Adjunto Obra',pf.Usuario, pf.fecha,ep.obra As 'Obras',case WHEN adjunto is not null then 'SI' ELSE 'NO' END AS 'Adjunto' from estado_pago ep left join estado_pago_firmado pf on pf.estado_pago_Id_Estado_Pago = ep.Id_estado_pago WHERE ep.obra = '" & obra & "' order by ep.nro_estado_pago asc ", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerAdjuntoPagosFirmados = nue_var.dt
            Return LeerAdjuntoPagosFirmados
        Catch ex As Exception
            ex.Message.ToString()
            nue_conexion.desconectar()
        End Try
    End Function
    Public Function LeerAdjuntoFacturas(ByVal obra As String) As DataTable
        Try
            nue_var.dt = New DataTable
            nue_conexion.conectar()
            nue_var.da = New MySqlDataAdapter("select ff.idFacturas_Firmadas,ep.obra As 'Obra Adjunto',ff.Obra,ep.nro_estado_pago,ff.nro_factura,case when ff.Adjunto is not null then 'SI' else 'NO' END as 'Adjuntos',ff.usuario,ff.Fecha, ff.adjunto from estado_pago ep left join facturas_firmadas ff on ff.estado_pago_Id_Estado_pago = ep.id_estado_pago where ep.obra = '" & obra & "' order by nro_estado_pago asc", nue_conexion.conex())
            nue_var.da.Fill(nue_var.dt)
            nue_conexion.desconectar()
            LeerAdjuntoFacturas = nue_var.dt
            Return LeerAdjuntoFacturas
        Catch ex As Exception
            ex.Message.ToString()
            nue_conexion.desconectar()
        End Try
    End Function

    Public Function RegistroExistente(ByVal obra As String, ByVal nro_estadoPago As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand("SELECT * FROM ESTADO_PAGO WHERE nro_estado_pago='" & nro_estadoPago & "' AND obra='" & obra & "'", nue_conexion.conex())
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

    Public Function VerificarEstadoPagoExistente(ByVal obra As String, ByVal nro_estadoPago As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand("SELECT * FROM ESTADO_PAGO_FIRMADO WHERE estado_pago_Id_Estado_Pago='" & nro_estadoPago & "' AND obra='" & obra & "'", nue_conexion.conex())
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

    Public Function VerificarFacturaFirmadaExistente(ByVal obra As String, ByVal nro_estadoPago As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand("SELECT * FROM FACTURAS_FIRMADAS WHERE estado_pago_Id_Estado_Pago='" & nro_estadoPago & "' AND obra='" & obra & "'", nue_conexion.conex())
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

    Public Sub modificar(ByVal Id_Estado_Pago As Integer, ByVal Nro_Estado_Pago As Integer, ByVal obra As String, ByVal fecha As Date, ByVal nro_factura As Integer, ByVal Obras As Integer, ByVal reajuste As Integer, ByVal retenciones As Integer, ByVal retenciones_canjeadas As Integer, ByVal multas As Integer, ByVal valor_estado_pago As Integer, ByVal valor_estado_pago_neto As Integer, ByVal obras_neto As Integer, ByVal reajuste_neto As Integer, ByVal observaciones As String)
        nue_var.consulta = "UPDATE estado_pago SET Nro_Estado_Pago = ?Nro_Estado_Pago,obra = ?obra,fecha = ?fecha, nro_factura = ?nro_factura,  Obras = ?Obras, reajuste = ?reajuste, retenciones = ?retenciones , retenciones_canjeadas = ?retenciones_canjeadas , multas = ?multas , valor_estado_pago = ?valor_estado_pago , valor_estado_pago_neto = ?valor_estado_pago_neto , obras_neto = ?obras_neto ,reajuste_neto = ?reajuste_neto, observaciones = ?observaciones WHERE Id_Estado_Pago  = ?Id_Estado_Pago"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?Id_Estado_Pago", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id_Estado_Pago
            nue_var.cmd.Parameters.Add("?Nro_Estado_Pago", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Nro_Estado_Pago
            nue_var.cmd.Parameters.Add("?obra", MySql.Data.MySqlClient.MySqlDbType.String).Value = obra
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.Parameters.Add("?nro_factura", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = nro_factura
            nue_var.cmd.Parameters.Add("?Obras", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Obras
            nue_var.cmd.Parameters.Add("?Reajuste", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = reajuste
            nue_var.cmd.Parameters.Add("?Retenciones", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = retenciones
            nue_var.cmd.Parameters.Add("?Retenciones_Canjeadas", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = retenciones_canjeadas
            nue_var.cmd.Parameters.Add("?Multas", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = multas
            nue_var.cmd.Parameters.Add("?Valor_Estado_Pago", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = valor_estado_pago
            nue_var.cmd.Parameters.Add("?Valor_Estado_Pago_Neto", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = valor_estado_pago_neto
            nue_var.cmd.Parameters.Add("?Obras_Neto", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = obras_neto
            nue_var.cmd.Parameters.Add("?Reajuste_Neto", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = reajuste_neto
            nue_var.cmd.Parameters.Add("?Observaciones", MySql.Data.MySqlClient.MySqlDbType.String).Value = observaciones

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
            MsgBox(mierror.Message)
            Throw New Exception(mierror.Message)
            nue_conexion.desconectar()
        End Try
    End Sub

    Public Function LeerArchivoAdjunto(ByVal id As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("select adjunto from estado_pago_firmado where Id_Estado_Pago_Firmado = '" & id & "' order by id_Estado_Pago_Firmado desc ", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        LeerArchivoAdjunto = nue_var.dt
        Return LeerArchivoAdjunto
    End Function

    Public Function UltimoNroFactura(ByVal NombreObra As String) As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("select nro_factura from estadopago where obra LIKE '%" & NombreObra & "%' order by nro_factura desc limit 1;", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        UltimoNroFactura = nue_var.dt
        Return UltimoNroFactura
    End Function
    Public Function Eliminar(ByVal idestadopago As Integer)
        nue_var.consulta = "Delete from estado_pago WHERE Id_Estado_Pago = " & idestadopago & ""
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
            MsgBox("Se eliminó correctamente")
        Catch mierror As MySqlException
            MsgBox("El Estado de Pago posee archivos adjuntos, si desea eliminar este registro debe borrar dichos archivos", MsgBoxStyle.Critical)
            Throw New Exception
            nue_conexion.desconectar()
        End Try
    End Function

    Public Sub EliminarAdjunto(ByVal idestadopagofirmado As Integer)
        nue_var.consulta = "Delete from ESTADO_PAGO_FIRMADO WHERE Id_Estado_Pago_Firmado = " & idestadopagofirmado & ""
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
    Public Sub EliminarAdjuntoFacturasFirmadas(ByVal idEstadoPagoFacturasFirmadas As Integer)
        nue_var.consulta = "Delete from facturas_firmadas WHERE idFacturas_Firmadas = " & idEstadoPagoFacturasFirmadas & ""
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

    Public Function CalcularPagoIVA(ByVal val1 As Double)
        Dim val2 As Double
        val2 = 1
        If val1 <> 0 Then
            Return val1 / val2
        Else
            Throw New DivideByZeroException("¡¡¡¡No se puede dividir por CERO!!!!")
        End If
    End Function


End Class
