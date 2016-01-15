Imports MySql.Data.MySqlClient


Public Class frmNuevaventa
    Public Sub cliente()
        conbd.Open()
        sql = "SELECT * FROM cliente"
        mycommand = New MySqlCommand()
        mycommand.CommandText = sql
        mycommand.CommandType = CommandType.Text
        mycommand.Connection = conbd
        daMySQL = New MySqlDataAdapter(mycommand)
        ds = New DataSet()
        daMySQL.Fill(ds)
        cmbcliente.DataSource = ds.Tables(0)
        cmbcliente.DisplayMember = "cod_cli"
        cmbcliente.ValueMember = "cod_cli"
        conbd.Close()

    End Sub

    Public Sub producto()
        conbd.Open()
        sql = "SELECT * FROM cat_productos"
        mycommand = New MySqlCommand()
        mycommand.CommandText = sql
        mycommand.CommandType = CommandType.Text
        mycommand.Connection = conbd
        daMySQL = New MySqlDataAdapter(mycommand)
        ds = New DataSet()
        daMySQL.Fill(ds)
        cmbProducto.DataSource = ds.Tables(0)
        cmbProducto.DisplayMember = "Producto"
        cmbProducto.ValueMember = "CodBarra"
        conbd.Close()

    End Sub
    Private Sub frmNuevaventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call producto()
        Call cliente
    End Sub

End Class