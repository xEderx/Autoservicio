Imports MySql.Data.MySqlClient

Public Class frmNuevoUsuario
    Private Sub frmNuevoUsuario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtNUsuario.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim tran As MySqlTransaction
        Try
            ccbd.conectarbd()
            conbd.Open()
            tran = conbd.BeginTransaction
            sql = "INSERT INTO cat_usuarios (Usuario, Nombre, Paterno, Materno, Contrasenia, Activo, Administrador) VALUES ('" & txtNUsuario.Text & "', '" & txtNNombre.Text & "', '" & txtNPaterno.Text & "', '" & txtNMaterno.Text & "', '" & txtNContrasenia.Text & "', True, " & chkAdmin.Checked & ")"
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
    End Sub
End Class