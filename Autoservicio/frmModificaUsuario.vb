Imports MySql.Data.MySqlClient

Public Class frmModificaUsuario
    Public Sub ModificarUsuario()
        If txtMUsuario.Text = "" Or txtMNombre.Text = "" Or txtMContrasenia.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "UPDATE cat_usuarios SET Usuario = '" & txtMUsuario.Text & "', Nombre = '" & txtMNombre.Text & "', Paterno = '" & txtMPaterno.Text & "', Materno = '" & txtMPaterno.Text & "', Contrasenia = '" & txtMContrasenia.Text & "', Administrador = " & chkMAdmin.Checked & " WHERE IdUsuario = " & vid_usuario
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
    Private Sub frmModificaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txtNNombre_TextChanged(sender As Object, e As EventArgs) Handles txtMNombre.TextChanged

    End Sub

    Private Sub btnMGuardar_Click(sender As Object, e As EventArgs) Handles btnMGuardar.Click
        Call ModificarUsuario()
    End Sub

    Private Sub txtMUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ModificarUsuario()
        End If
    End Sub

    Private Sub txtMNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ModificarUsuario()
        End If
    End Sub

    Private Sub txtMPaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMPaterno.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ModificarUsuario()
        End If
    End Sub

    Private Sub txtMMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMMaterno.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ModificarUsuario()
        End If
    End Sub

    Private Sub txtMContrasenia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMContrasenia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ModificarUsuario()
        End If
    End Sub
End Class