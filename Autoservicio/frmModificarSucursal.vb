Imports MySql.Data.MySqlClient

Public Class frmModificarSucursal
    Public Sub ModificarSucursal()
        If txtMDireccion.Text = "" Or txtMCP.Text = "" Then
            MessageBox.Show("¡Hay algunos campos vacios!", "Modificación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim tran As MySqlTransaction
            Try
                ccbd.conectarbd()
                conbd.Open()
                tran = conbd.BeginTransaction
                sql = "UPDATE tbl_sucursal SET Sucursal = '" & txtMSucursal.Text & "', Domicilio = '" & txtMDireccion.Text & "', CP = '" & txtMCP.Text & "', Cat_Estado_IdEstado = " & cmbMEstado.SelectedValue & ", Cat_Ciudades_IdCiudad = " & cmbMMunicipio.SelectedValue & " WHERE IdSucursal = " & vid_usuario
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
        cmbMMunicipio.DataSource = ds.Tables(0)
        cmbMMunicipio.DisplayMember = "Ciudad"
        cmbMMunicipio.ValueMember = "IdCiudad"
        cmbMMunicipio.SelectedValue = vmunicipio
        conbd.Close()
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
        cmbMEstado.DataSource = ds.Tables(0)
        cmbMEstado.DisplayMember = "Estado"
        cmbMEstado.ValueMember = "IdEstado"
        cmbMEstado.SelectedValue = vestado
        conbd.Close()
    End Sub
    Private Sub frmModificarSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Estados()
        Call Ciudades()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call ModificarSucursal()
    End Sub

    Private Sub txtMSucursal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMSucursal.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ModificarSucursal()
        End If
    End Sub

    Private Sub txtMCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMCP.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ModificarSucursal()
        End If
    End Sub
End Class