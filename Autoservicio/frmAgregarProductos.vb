Imports MySql.Data.MySqlClient

Public Class frmAgregarProductos
    Public Sub Ticket()
        ccbd.conectarbd()
        conbd.Open()
        sql = "SELECT * FROM tbl_ventas"
        mycommand = New MySqlCommand(sql)
        mycommand.Connection = conbd
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()
        mydata.Read()
        vticket = mydata(0)
    End Sub

    Public Sub Productos()
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
    Private Sub frmAgregarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Productos()
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        Me.lblPrecio.Text = Me.cmbProducto.DataSource.rows(Me.cmbProducto.SelectedIndex)("Precio")
    End Sub
End Class