Imports MySql.Data.MySqlClient

Public Class frmSucursales
    Public Sub BuscaSucursal()
        Dim dt As New DataTable
        Try
            sql = "SELECT * FROM v_sucursal WHERE Sucursal LIKE '" & "%" & txtBuscar.Text & "%' OR Domicilio LIKE '" & "%" & txtBuscar.Text & "%'"
            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.dtgSucursales.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al obtener los registros.", "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub cargadatos()
        Dim dt As New DataTable
        ccbd.conectarbd()
        Try
            txtBuscar.Text = ""
            sql = "SELECT * FROM v_sucursal"
            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.dtgSucursales.DataSource = dt
            dtgSucursales.ReadOnly = True
            dtgSucursales.AutoResizeColumns()
            dtgSucursales.Columns(0).HeaderText = "Id"
            dtgSucursales.Columns(1).HeaderText = "Sucursal"
            dtgSucursales.Columns(2).HeaderText = "Domicilio"
            dtgSucursales.Columns(3).HeaderText = "CP"
            dtgSucursales.Columns(4).Visible = False
            dtgSucursales.Columns(5).HeaderText = "Estado"
            dtgSucursales.Columns(6).Visible = False
            dtgSucursales.Columns(5).HeaderText = "Ciudad"

        Catch ex As Exception
            MessageBox.Show("No se pudieron obtener los registros de la base de datos.", "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmNuevaSucursal.ShowDialog()
        Call cargadatos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call BuscaSucursal()
    End Sub

    Private Sub frmSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargadatos()
    End Sub

    Private Sub btnBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call BuscaSucursal()
        End If
    End Sub

    Private Sub dtgSucursales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSucursales.CellDoubleClick
        Dim objModificarSucursal As New frmModificarSucursal
        Dim ind As Integer = dtgSucursales.CurrentRow.Index
        vid_usuario = Convert.ToInt32(dtgSucursales.Item("IdSucursal", ind).Value)
        objModificarSucursal.txtMSucursal.Text = Convert.ToString(dtgSucursales.Item("Sucursal", ind).Value)
        objModificarSucursal.txtMDireccion.Text = Convert.ToString(dtgSucursales.Item("Domicilio", ind).Value)
        objModificarSucursal.txtMCP.Text = Convert.ToInt32(dtgSucursales.Item("CP", ind).Value)
        objModificarSucursal.cmbMEstado.SelectedValue = Convert.ToInt32(dtgSucursales.Item("Cat_Estado_IdEstado", ind).Value)
        objModificarSucursal.cmbMMunicipio.SelectedValue = Convert.ToInt32(dtgSucursales.Item("Cat_Ciudades_IdCiudad", ind).Value)
        objModificarSucursal.ShowDialog()
        Call cargadatos()
    End Sub
End Class