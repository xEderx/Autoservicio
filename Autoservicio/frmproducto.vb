Imports MySql.Data.MySqlClient
Public Class frmproducto
    Private Sub frmcompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargadatos()
    End Sub
    Public Sub cargadatos()
        Dim dt As New DataTable
        ccbd.conectarbd()
        Try
            txtBuscar.Text = ""
            sql = "SELECT * FROM cat_productos"
            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.dtgUsuarios.DataSource = dt
            dtgUsuarios.ReadOnly = True
            dtgUsuarios.AutoResizeColumns()
            dtgUsuarios.Columns(0).HeaderText = "Codigo"
            dtgUsuarios.Columns(1).HeaderText = "Producto"
            dtgUsuarios.Columns(2).HeaderText = "Existencia"
            dtgUsuarios.Columns(3).HeaderText = "Tipo"
            dtgUsuarios.Columns(4).HeaderText = "Precio"

        Catch ex As Exception
            MessageBox.Show("No se pudieron obtener los registros de la base de datos.", "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call Buscarproducto()
    End Sub
    Public Sub Buscarproducto()
        Dim dt As New DataTable
        Try
            sql = "select * from cat_productos where Producto like '" & "%" & txtBuscar.Text & "%'"
            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.dtgUsuarios.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al obtener los registros.", "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmNuevoproducto.ShowDialog()
        Call cargadatos()
    End Sub
End Class