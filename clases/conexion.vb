﻿Imports MySql.Data.MySqlClient
Public Class conexion

    'aqui coloca tu cadena de conexion de xampp, wampp o lo que sea que uses
    'Esta es la conexión al servidor, a la hora de compilar la aplicación, debes sacar la el string de conexión del laboratorio
    'Private con As New MySqlConnection("server=201.148.105.75; database=const113_ConstructoraFV; user id=const113_admin2; password=Admin477547;Convert Zero Datetime=True;Convert Zero Datetime=True; Use Procedure Bodies=false;default command timeout=600")
    'Conexión de Base de Datos laboratorio
    Private con As New MySqlConnection("server=localhost; database=const113_ConstructoraFV; user id=root; password=toor;Convert Zero Datetime=True;Convert Zero Datetime=True; Use Procedure Bodies=false;default command timeout=600")
    'Private con2 As New MySqlConnection("server=localhost; database=const113_constructorafv; user id=const113_admin2; password=Admin477547;Convert Zero Datetime=True;Convert Zero Datetime=True; Use Procedure Bodies=false;default command timeout=600")
    Private con2 As New MySqlConnection("server=localhost; database=const113_constructorafv; user id=const113_admin2; password=gsolis2013;Convert Zero Datetime=True;Convert Zero Datetime=True; Use Procedure Bodies=false;default command timeout=600")
    'procedimiento que abre la conexion mysql
    Public Sub conectar()
        Try
            If sincroniza = 0 Then
                con.Open()
            ElseIf sincroniza = 1 Then
                con2.Open()
            End If
        Catch ex As Exception
            ex.Message.ToString()
        End Try

    End Sub
    Public Sub conectar_local()
        con2.Open()
    End Sub
    Public Sub desconectar_local()
        con2.Close()
    End Sub
    Function conex_local() As MySqlConnection
        conex_local = con2
        Return conex_local
    End Function

    Public Sub conectar_remoto()
        con.Open()
    End Sub
    Public Sub desconectar_remoto()
        con.Close()
    End Sub
    'Procedimiento que cierra la conexion mysql
    Public Sub desconectar()
        If sincroniza = 0 Then
            con.Close()
        ElseIf sincroniza = 1 Then
            con2.Close()
        End If
    End Sub
    'Funcion que devuelve la conexion mysql
    Function conex() As MySqlConnection
        If sincroniza = 0 Then
            conex = con
            Return conex
        ElseIf sincroniza = 1 Then
            conex = con2
            Return conex
        End If
    End Function
    Function conex_remoto() As MySqlConnection
        conex_remoto = con
        Return conex_remoto
    End Function
    Public Sub insertar(ByVal conexion_sincroniza As Integer)
        sincroniza = conexion_sincroniza
    End Sub
End Class