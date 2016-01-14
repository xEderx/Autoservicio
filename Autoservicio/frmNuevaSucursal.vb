Imports MySql.Data.MySqlClient

Public Class frmNuevaSucursal
    Public Sub NuevaSucursal()
        If txtNDireccion.Text = "" Or txtNCP.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Inserción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "INSERT INTO tbl_sucursal (Sucursal, Domicilio, CP, Cat_Estado_IdEstado, Cat_Ciudades_IdCiudad) VALUES ('" & txtNSucursal.Text & "', '" & txtNDireccion.Text & "', " & txtNCP.Text & ", " & cmbEstado.SelectedValue & ", " & cmbMunicipio.SelectedValue & ")"
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
    Private Sub frmNuevaSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Estados()
        Call Ciudades()
    End Sub

    Private Sub cmbEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEstado.KeyPress
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call NuevaSucursal()
    End Sub

    Private Sub txtNSucursal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNSucursal.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call NuevaSucursal()
        End If
    End Sub

    Private Sub txtNCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNCP.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call NuevaSucursal()
        End If
    End Sub
End Class