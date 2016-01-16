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
            Me.dtgproductos.DataSource = dt
            dtgproductos.ReadOnly = True
            dtgproductos.AutoResizeColumns()
            dtgproductos.Columns(0).HeaderText = "Codigo"
            dtgproductos.Columns(1).HeaderText = "Producto"
            dtgproductos.Columns(2).HeaderText = "Existencia"
            dtgproductos.Columns(3).HeaderText = "Tipo"
            dtgproductos.Columns(4).HeaderText = "Precio"

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
            Me.dtgproductos.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al obtener los registros.", "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmNuevoproducto.ShowDialog()
        Call cargadatos()
    End Sub
    Private Sub dtgproductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgproductos.CellClick
        Dim ind As Integer = dtgproductos.CurrentRow.Index
        vid = Convert.ToInt32(dtgproductos.Item("CodBarra", ind).Value)
    End Sub
    Private Sub dtgproductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgproductos.CellDoubleClick
        Dim objModificarproducto As New frmModificaRproducto
        Dim ind As Integer = dtgproductos.CurrentRow.Index
        vid_usuario = Convert.ToInt32(dtgproductos.Item("CodBarra", ind).Value)
        objModificarproducto.txtnombre.Text = Convert.ToString(dtgproductos.Item("Producto", ind).Value)
        objModificarproducto.txtexi.Text = Convert.ToString(dtgproductos.Item("Existencia", ind).Value)
        vtipo = Convert.ToInt32(dtgproductos.Item("Cat_TipoProductos_IdTipo", ind).Value)
        objModificarproducto.txtprecio.Text = Convert.ToInt32(dtgproductos.Item("Precio", ind).Value)

        objModificarproducto.ShowDialog()
        Call cargadatos()
    End Sub

    Private Sub dtgproductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgproductos.CellContentClick

    End Sub
End Class