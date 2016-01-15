Imports MySql.Data.MySqlClient


Public Class frmNuevaventa
    Public Sub sucursal()
        conbd.Open()
        sql = "SELECT * FROM tbl_sucursal"
        mycommand = New MySqlCommand()
        mycommand.CommandText = sql
        mycommand.CommandType = CommandType.Text
        mycommand.Connection = conbd
        daMySQL = New MySqlDataAdapter(mycommand)
        ds = New DataSet()
        daMySQL.Fill(ds)
        cmbsucursal.DataSource = ds.Tables(0)
        cmbsucursal.DisplayMember = "IdSucursal"
        cmbsucursal.ValueMember = "IdSucursal"

        conbd.Close()

    End Sub
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
        Call cliente()
        Call sucursal()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Nuevaventa1()
    End Sub
    Public Sub Nuevaventa1()
        If txtprecio.Text = "" Or txttiket.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "INSERT INTO tbl_ventas(Ticket,cliente_cod_cli,Tbl_Sucursal_IdSucursal) VALUES (" & txttiket.Text & ", '" & cmbcliente.SelectedValue & "', " & cmbsucursal.SelectedValue & ")"
                mycommand = New MySqlCommand(sql)
                mycommand.Connection = conbd
                mycommand.Transaction = tran
                mycommand.ExecuteNonQuery()

                MessageBox.Show("La venta fue agregado correctamente.", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tran.Commit()
                conbd.Close()
                Me.Close()
            Catch ex As Exception
                tran.Rollback()
                conbd.Close()
                MessageBox.Show("No se pudo agregar la venta.", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class