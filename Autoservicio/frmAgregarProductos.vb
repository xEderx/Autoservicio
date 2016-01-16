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
    Private Sub frmAgregarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class