Imports MySql.Data.MySqlClient
Imports System
Imports System.Data

Module Module1
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public conn As New MySqlConnection
    Public sql, sql2 As String
    Public ProductNoSum As Integer
    Public gt As Integer
    Public productcodetable As String
    Public productnotable As String
    Public productnametable As String
    Public descriptiontable As String
    Public quantitytable As String
    Public sizetable As String
    Public pricetable As String
    Public log As String

    Public Sub connect()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.ConnectionString = "server=localhost; userid=root; database=yumidb;"
            conn.Open()


        Catch ex As Exception
            MsgBox("Error connection to database." & vbNewLine & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
