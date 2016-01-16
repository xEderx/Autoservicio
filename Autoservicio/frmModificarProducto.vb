Imports MySql.Data.MySqlClient
Public Class frmModificarProducto
    Private Sub btnMGuardar_Click(sender As Object, e As EventArgs) Handles btnMGuardar.Click
        Call ModificarPRODUCTO()
    End Sub
    Public Sub ModificarPRODUCTO()
        If txtCodigo.Text = "" Or txtnombre.Text = "" Or txtexi.Text = "" Or txtprecio.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "UPDATE tbl_sucursal SET Sucursal = '" & txtMSucursal.Text & "', Domicilio = '" & txtMDireccion.Text & "', CP = '" & txtMCP.Text & "', Cat_Estado_IdEstado = " & cmbMEstado.SelectedValue & ", Cat_Ciudades_IdCiudad = " & cmbMMunicipio.SelectedValue & " WHERE IdSucursal = " & vid_usuario
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