Imports MySql.Data.MySqlClient
Public Class altacliente
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' ccbd.conectarbd()
        ' conbd.Open()
        ' mycommand = New MySqlCommand
        ' mycommand.Connection = conbd

        ' mycommand.CommandText = "insert into alumnos(id,nombre,dia_1) values(" & txtclave.Text & ",'" & txtnombre.Text & "'," & txtdia1.Text & ")"


        ' mycommand.CommandText = "insert into alumnos(dia_2) values(" & txtdia2.Text & ")"

        ' mycommand.ExecuteNonQuery()
        ' conbd.Close()

        ' MsgBox("registro agregado")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtMContrasenia_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Nuevocleinte()
    End Sub

    Public Sub Nuevocleinte()
        If txtrfc.Text = "" Or txtnombre.Text = "" Or txtdomicilio.Text = "" Or txttelefono.Text = "" Or txtcorreo.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "INSERT INTO cat_usuarios (cod_cli, nom_cli, dni_cli, tel_cli, email_cli) VALUES ('" & txtrfc.Text & "', '" & txtnombre.Text & "', '" & txtdomicilio.Text & "', '" & txttelefono.Text & "', '" & txtcorreo.Text & ")"
                mycommand = New MySqlCommand(sql)
                mycommand.Connection = conbd
                mycommand.Transaction = tran
                mycommand.ExecuteNonQuery()

                MessageBox.Show("El cliente fue agregado correctamente.", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
End Class