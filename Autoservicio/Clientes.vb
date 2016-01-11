Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargadatos()
    End Sub
    Public Sub cargadatos()
        Dim dt As New DataTable
        ccbd.conectarbd()
        Try
            Txtrfc.Text = ""
            sql = "select * from cliente"

            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.DataGridView1.DataSource = dt
            DataGridView1.ReadOnly = True
            DataGridView1.AutoResizeColumns()

            DataGridView1.Columns(0).HeaderText = "RFC"
            DataGridView1.Columns(1).HeaderText = "Nombre"
            DataGridView1.Columns(2).HeaderText = "Domicilio"
            DataGridView1.Columns(3).HeaderText = "Estado"
            DataGridView1.Columns(4).HeaderText = "Ciudad"
            DataGridView1.Columns(5).HeaderText = "Telefono"
            DataGridView1.Columns(6).HeaderText = "Carpeta"
            DataGridView1.Columns(7).HeaderText = "Correo"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        altacliente.Show()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim dt As New DataTable
        Try
            sql = "select * from cliente where cod_cli like '" & "%" & Txtrfc.Text & "%'"

            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.DataGridView1.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Txtrfc_TextChanged(sender As Object, e As EventArgs) Handles Txtrfc.TextChanged

    End Sub
End Class