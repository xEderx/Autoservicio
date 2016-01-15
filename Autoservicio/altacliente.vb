Imports MySql.Data.MySqlClient

Imports System.Data.SqlClient
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

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMContrasenia_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Nuevocleinte()
    End Sub

    Public Sub Nuevocleinte()
        If txttipo.Text = "" Or txtrfc.Text = "" Or txtnombre.Text = "" Or txtdomicilio.Text = "" Or txttelefono.Text = "" Or txtcorreo.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "INSERT INTO cliente(cod_cli,t_cli,nom_cli,dni_clin,cp_cli,tel_cli,email_cli,Cat_Estado_IdEstado,Cat_Ciudades_IdCiudad) VALUES ('" & txtrfc.Text & "', '" & txttipo.Text & "','" & txtnombre.Text & "', '" & txtdomicilio.Text & "', '" & txtcp.Text & "', '" & txttelefono.Text & "', '" & txtcorreo.Text & "', " & cmbEstado.SelectedValue & ", " & cmbMunicipio.SelectedValue & ")"
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



    Private Sub altacliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Estados()
        Call Ciudades()
    End Sub
    Public Sub Estados()
        conbd.Open()
        sql = "SELECT * FROM cat_estado"
        mycommand = New MySqlCommand()
        mycommand.CommandText = sql
        mycommand.CommandType = CommandType.Text
        mycommand.Connection = conbd
        daMySQL = New MySqlDataAdapter(mycommand)
        ds = New DataSet()
        daMySQL.Fill(ds)
        cmbEstado.DataSource = ds.Tables(0)
        cmbEstado.DisplayMember = "Estado"
        cmbEstado.ValueMember = "IdEstado"
        conbd.Close()
    End Sub

    Public Sub Ciudades()
        conbd.Open()
        sql = "SELECT * FROM cat_ciudades"
        mycommand = New MySqlCommand()
        mycommand.CommandText = sql
        mycommand.CommandType = CommandType.Text
        mycommand.Connection = conbd
        daMySQL = New MySqlDataAdapter(mycommand)
        ds = New DataSet()
        daMySQL.Fill(ds)
        cmbMunicipio.DataSource = ds.Tables(0)
        cmbMunicipio.DisplayMember = "Ciudad"
        cmbMunicipio.ValueMember = "IdCiudad"
        conbd.Close()
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged

    End Sub
End Class