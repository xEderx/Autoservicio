Imports MySql.Data.MySqlClient

Public Class frmNuevaSucursal
    Private Sub frmNuevaSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conbd.Open()
        sql = "SELECT * FROM Cat_Estado"
        mycommand = New MySqlCommand()
        mycommand.CommandText = sql
        mycommand.CommandType = CommandType.Text
        mycommand.Connection = conbd
        daMySQL = New MySqlDataAdapter(mycommand)
        ds = New DataSet()
        daMySQL.Fill(ds)
        cmbEstado.DataSource = ds.Tables(0)
        cmbEstado.DisplayMember = "Estado"
        cmbEstado.ValueMember = "IdEstado"
    End Sub
End Class