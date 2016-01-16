Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class frmVenta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        frmNuevaventa.Show()
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargadatos()
        Call cargadatos2()

    End Sub
    Public Sub cargadatos()
        Dim dt As New DataTable
        ccbd.conectarbd()
        Try
            Txtrfc.Text = ""
            sql = "select * from tbl_ventas"

            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.DataGridView1.DataSource = dt
            DataGridView1.ReadOnly = True
            DataGridView1.AutoResizeColumns()

            DataGridView1.Columns(0).HeaderText = "Ticket"
            DataGridView1.Columns(1).HeaderText = "Cliente"
            DataGridView1.Columns(2).HeaderText = "Sucursal"


        Catch ex As Exception

        End Try
    End Sub
    Public Sub cargadatos2()
        Dim dt As New DataTable
        ccbd.conectarbd()
        Try
            txttiket.Text = ""
            sql = "select * from tbl_ventas_has_cat_productos"

            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.DataGridView2.DataSource = dt
            DataGridView2.ReadOnly = True
            DataGridView2.AutoResizeColumns()

            DataGridView2.Columns(0).HeaderText = "Ticket"
            DataGridView2.Columns(1).HeaderText = "Producto"
            DataGridView2.Columns(2).HeaderText = "Cantidad"
            DataGridView2.Columns(3).HeaderText = "Precio de venta"



        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btnbuscarrfc_Click(sender As Object, e As EventArgs) Handles Btnbuscarrfc.Click
        Dim dt As New DataTable
        Try
            sql = "select * from tbl_ventas where cliente_cod_cli like '" & "%" & Txtrfc.Text & "%'"

            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.DataGridView1.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnbuscartiket_Click(sender As Object, e As EventArgs) Handles btnbuscartiket.Click
        Dim dt As New DataTable
        Try
            sql = "select * from tbl_ventas_has_cat_productos where Tbl_Ventas_Ticket like '" & "%" & txttiket.Text & "%'"

            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.DataGridView2.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub



    Private Sub frmVentas_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class