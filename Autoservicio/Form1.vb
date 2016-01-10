Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If txtUsuario.Text = "" Or txtContrasenia.Text = "" Then
            MessageBox.Show("¡Tiene que poner un usuario y/o contraseña!", "Campos vacíos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ccbd.conectarbd()
            conbd.Open()
            sql = "SELECT * FROM cat_usuarios WHERE Usuario = '" & txtUsuario.Text & "' AND Contrasenia = '" & txtContrasenia.Text & "'"
            mycommand = New MySqlCommand(sql)
            mycommand.Connection = conbd
            Dim mydata As MySqlDataReader
            mydata = mycommand.ExecuteReader()
            If mydata.HasRows = 0 Then
                MessageBox.Show("El usuario o contraseña no son correctos.", "Error de acceso.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conbd.Close()
            Else
                Principal.Show()
                Me.Visible = False
                conbd.Close()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
