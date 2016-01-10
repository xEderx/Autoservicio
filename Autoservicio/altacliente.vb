Public Class altacliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        ccbd.conectarbd()
        conbd.Open()
        mycommand = New MySqlCommand
        mycommand.Connection = conbd

        mycommand.CommandText = "insert into alumnos(id,nombre,dia_1) values(" & txtclave.Text & ",'" & txtnombre.Text & "'," & txtdia1.Text & ")"


        mycommand.CommandText = "insert into alumnos(dia_2) values(" & txtdia2.Text & ")"

        mycommand.ExecuteNonQuery()
        conbd.Close()

        MsgBox("registro agregado")
    End Sub
End Class