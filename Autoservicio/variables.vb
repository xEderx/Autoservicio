﻿Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Module variables
    Public sql As String
    Public sqln As Integer
    Public cmdtbl As New OleDbCommand
    Public datbl As New OleDbDataAdapter
    Public rdrtbl As OleDbDataReader
    Public ccbd As New clsConexion
    Public conexionMySql As New MySqlConnection
    Public conbd As New MySqlConnection
    Public mycommand As New MySqlCommand
    Public conMySQL As New MySqlConnection
    Public daMySQL As New MySqlDataAdapter
    Public rdMySQL As MySqlDataReader
End Module