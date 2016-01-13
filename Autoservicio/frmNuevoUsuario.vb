Imports MySql.Data.MySqlClient

Public Class frmNuevoUsuario
    Private Sub frmNuevoUsuario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtNUsuario.Focus()
    End Sub

    Public Sub NuevoUsuario()
        If txtNUsuario.Text = "" Or txtNNombre.Text = "" Or txtNContrasenia.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "INSERT INTO cat_usuarios (Usuario, Nombre, Paterno, Materno, Contrasenia, Administrador) VALUES ('" & txtNUsuario.Text & "', '" & txtNNombre.Text & "', '" & txtNPaterno.Text & "', '" & txtNMaterno.Text & "', '" & txtNContrasenia.Text & "', " & chkAdmin.Checked & ")"
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call NuevoUsuario()
    End Sub

    Private Sub frmNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNUsuario.Text = ""
        txtNNombre.Text = ""
        txtNPaterno.Text = ""
        txtNMaterno.Text = ""
        txtNContrasenia.Text = ""
        chkAdmin.Checked = False
    End Sub

    Private Sub txtNUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call NuevoUsuario()
        End If
    End Sub

    Private Sub txtNNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call NuevoUsuario()
        End If
    End Sub

    Private Sub txtNPaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNPaterno.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call NuevoUsuario()
        End If
    End Sub

    Private Sub txtNMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNMaterno.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call NuevoUsuario()
        End If
    End Sub

    Private Sub txtNContrasenia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNContrasenia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call NuevoUsuario()
        End If
    End Sub
End Class