﻿Imports MySql.Data.MySqlClient
Public Class frmModificaRproducto
    Private Sub frmModificaRproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tipo()
    End Sub
    Public Sub tipo()
        conbd.Open()
        sql = "SELECT * FROM cat_tipoproductos "
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

    Private Sub btnMGuardar_Click(sender As Object, e As EventArgs) Handles btnMGuardar.Click
        Call ModificarProducto()
    End Sub
    Public Sub ModificarProducto()
        If txtCodigo.Text = "" Or txtnombre.Text = "" Or txtexi.Text = "" Or txtprecio.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "UPDATE cat_tipoproductos SET CodBarra = " & txtCodigo.Text & ", Producto = '" & txtnombre.Text & "', Existencia = " & txtexi.Text & ", Cat_TipoProductos_IdTipo = " & cmbtipo.SelectedValue & ", Precio = " & txtprecio.Text & " WHERE CodBarra = " & vid_usuario
                mycommand = New MySqlCommand(sql)
                mycommand.Connection = conbd
                mycommand.Transaction = tran
                mycommand.ExecuteNonQuery()
                MessageBox.Show("El usuario fue modificado correctamente.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tran.Commit()
                conbd.Close()
                Me.Close()
            Catch ex As Exception
                tran.Rollback()
                conbd.Close()
                MessageBox.Show("No se pudo modificar el usuario.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


End Class