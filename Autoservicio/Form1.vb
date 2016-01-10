Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If txtUsuario.Text = "" Or txtContrasenia.Text = "" Then
            MsgBox("¡Los campos no pueden ir vacíos!")
        Else
            ccbd.conectarbd()
            conbd.Open()
            sql = "SELECT * FROM cat_usuarios WHERE Usuario = '" & txtUsuario.Text & "' AND Contrasenia = '" & txtContrasenia.Text & "'"
            mycommand = New MySqlCommand(sql)
            mycommand.Connection = conbd
            Dim mydata As MySqlDataReader
            mydata = mycommand.ExecuteReader()
            If mydata.HasRows = 0 Then
                MsgBox("Usuario incorrecto.")
                conbd.Close()
            Else
                Principal.Show()
                conbd.Close()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
