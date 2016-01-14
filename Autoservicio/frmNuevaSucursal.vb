Imports MySql.Data.MySqlClient

Public Class frmNuevaSucursal
    Public Sub Estados()
        conbd.Open()
        sql = "SELECT * FROM cat_estado"
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
        conbd.Close()
    End Sub

    Public Sub Ciudades()
        conbd.Open()
        sql = "SELECT * FROM cat_ciudades"
        mycommand = New MySqlCommand()
        mycommand.CommandText = sql
        mycommand.CommandType = CommandType.Text
        mycommand.Connection = conbd
        daMySQL = New MySqlDataAdapter(mycommand)
        ds = New DataSet()
        daMySQL.Fill(ds)
        cmbMunicipio.DataSource = ds.Tables(0)
        cmbMunicipio.DisplayMember = "Ciudad"
        cmbMunicipio.ValueMember = "IdCiudad"
        conbd.Close()
    End Sub
    Private Sub frmNuevaSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Estados()
        Call Ciudades()
    End Sub

    Private Sub cmbEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEstado.KeyPress
    End Sub
End Class