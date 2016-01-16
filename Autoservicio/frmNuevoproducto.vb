Imports MySql.Data.MySqlClient
Public Class frmNuevoproducto
    Private Sub frmNuevoproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = ""
        txtnombre.Text = ""
        txtexi.Text = ""
        txtprecio.Text = ""
        Call tipo()

    End Sub
    Public Sub tipo()
        conbd.Open()
        sql = "SELECT * FROM    "
        mycommand = New MySqlCommand()
        mycommand.CommandText = sql
        mycommand.CommandType = CommandType.Text
        mycommand.Connection = conbd
        daMySQL = New MySqlDataAdapter(mycommand)
        ds = New DataSet()
        daMySQL.Fill(ds)
        cmbtipo.DataSource = ds.Tables(0)
        cmbtipo.DisplayMember = "Tipo"
        cmbtipo.ValueMember = "IdTipo"
        conbd.Close()
    End Sub

    Private Sub btnMGuardar_Click(sender As Object, e As EventArgs)
        Call Nuevoproducto()
    End Sub
    Public Sub Nuevoproducto()
        If txtCodigo.Text = "" Or txtnombre.Text = "" Or txtexi.Text = "" Or txtprecio.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "INSERT INTO cat_productos (CodBarra, Producto, Existencia, Cat_TipoProductos_IdTipo, Precio) VALUES (" & txtCodigo.Text & ", '" & txtnombre.Text & "', " & txtexi.Text & ", " & cmbtipo.SelectedValue & ", " & txtprecio.Text & ")"
                mycommand = New MySqlCommand(sql)
                mycommand.Connection = conbd
                mycommand.Transaction = tran
                mycommand.ExecuteNonQuery()
                MessageBox.Show("El usuario fue agregado correctamente.", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tran.Commit()
                conbd.Close()
                Me.Close()
            Catch ex As Exception
                tran.Rollback()
                conbd.Close()
                MessageBox.Show("No se pudo agregar el usuario.", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnMGuardar_Click_1(sender As Object, e As EventArgs) Handles btnMGuardar.Click
        Call Nuevoproducto()
    End Sub
End Class