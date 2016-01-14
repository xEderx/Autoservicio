Imports MySql.Data.MySqlClient

Public Class frmModificarSucursal
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
        cmbMMunicipio.DataSource = ds.Tables(0)
        cmbMMunicipio.DisplayMember = "Ciudad"
        cmbMMunicipio.ValueMember = "IdCiudad"
        conbd.Close()
    End Sub

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
        cmbMEstado.DataSource = ds.Tables(0)
        cmbMEstado.DisplayMember = "Estado"
        cmbMEstado.ValueMember = "IdEstado"
        conbd.Close()
    End Sub
    Private Sub frmModificarSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Estados()
        Call Ciudades()
    End Sub
End Class