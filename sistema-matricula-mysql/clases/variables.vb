Imports MySql.Data.MySqlClient
Imports System.Data
Public Class variables

    Public cmd As MySqlCommand
    Public consulta As String
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public dv As DataView

    Public Function solo_numeros(ByVal tecla As Char) As Boolean
        If Char.IsControl(tecla) Or Char.IsDigit(tecla) Then
            solo_numeros = False
        Else
            solo_numeros = True
        End If
        Return solo_numeros
    End Function

    Public Sub todo_mayuscula(ByVal txt As String)
        txt.ToUpper()
    End Sub

End Class
