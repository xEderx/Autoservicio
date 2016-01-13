Imports MySql.Data.MySqlClient

Public Class Form1
    Public Sub Acceso()
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
            'Ejecutamos el comando "Read" el cual recorrerá las columnas de la tabla a la que se está haciendo la consulta.
            mydata.Read()
            If mydata.HasRows = 0 Then
                MessageBox.Show("El usuario o contraseña no son correctos.", "Error de acceso.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conbd.Close()
            Else
                'Almacenamos en una variable de sesión el valor de la columna que deseamos. En este caso es la columna 7, son 8 pero hay que recordar
                'que se cuenta a partir de 0, así que por eso queda con el número 7. Con esto, ese valor queda almacemado en la variable.
                'Si fuera un textbox sería el mismo procedimiento.
                vsesion = mydata(6)
                Principal.Show()
                Me.Visible = False
                conbd.Close()
            End If
        End If
    End Sub
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Call Acceso()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = "EMoreno"
        txtContrasenia.Text = "123456"
    End Sub

    Private Sub txtContrasenia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasenia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call Acceso()
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call Acceso()
        End If
    End Sub
End Class
