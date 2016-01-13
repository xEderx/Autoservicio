Imports MySql.Data.MySqlClient

Public Class frmUsuarios
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargadatos()
    End Sub
    Public Sub BuscarUsuario()
        Dim dt As New DataTable
        Try
            sql = "SELECT * FROM cat_usuarios WHERE Usuario LIKE '" & "%" & txtBuscar.Text & "%' OR Nombre LIKE '" & "%" & txtBuscar.Text & "%' OR Paterno LIKE '" & "%" & txtBuscar.Text & "%' OR MATERNO LIKE '" & "%" & txtBuscar.Text & "%'"
            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.dtgUsuarios.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al obtener los registros.", "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub cargadatos()
        Dim dt As New DataTable
        ccbd.conectarbd()
        Try
            txtBuscar.Text = ""
            sql = "SELECT * FROM cat_usuarios"
            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.dtgUsuarios.DataSource = dt
            dtgUsuarios.ReadOnly = True
            dtgUsuarios.AutoResizeColumns()
            dtgUsuarios.Columns(0).HeaderText = "Id"
            dtgUsuarios.Columns(1).HeaderText = "Usuario"
            dtgUsuarios.Columns(2).HeaderText = "Nombre"
            dtgUsuarios.Columns(3).HeaderText = "Paterno"
            dtgUsuarios.Columns(4).HeaderText = "Materno"
            dtgUsuarios.Columns(5).Visible = False
            dtgUsuarios.Columns(6).HeaderText = "Administrador"
        Catch ex As Exception
            MessageBox.Show("No se pudieron obtener los registros de la base de datos.", "Error de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUsuarios_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtBuscar.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call BuscarUsuario()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmNuevoUsuario.ShowDialog()
        Call cargadatos()
    End Sub

    Private Sub dtgUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsuarios.CellClick
        Dim ind As Integer = dtgUsuarios.CurrentRow.Index
        vid = Convert.ToInt32(dtgUsuarios.Item("IdUsuario", ind).Value)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim tran As MySqlTransaction
        Try
            ccbd.conectarbd()
            conbd.Open()
            tran = conbd.BeginTransaction
            sql = "DELETE FROM cat_usuarios WHERE IdUsuario = " & vid
            mycommand = New MySqlCommand(sql)
            mycommand.Connection = conbd
            mycommand.Transaction = tran
            mycommand.ExecuteNonQuery()
            MessageBox.Show("El usuario fue elimnado.", "Eliminación.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tran.Commit()
            conbd.Close()
            Call cargadatos()

        Catch ex As Exception
            tran.Rollback()
            conbd.Close()
            MessageBox.Show("No se pudo deshabilitar el usuario.", "Eliminación.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call BuscarUsuario()
        End If
    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub dtgUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsuarios.CellDoubleClick
        Dim objModificaUsuario As New frmModificaUsuario
        Dim ind As Integer = dtgUsuarios.CurrentRow.Index
        vid_usuario = Convert.ToInt32(dtgUsuarios.Item("IdUsuario", ind).Value)
        objModificaUsuario.txtMUsuario.Text = Convert.ToString(dtgUsuarios.Item("Usuario", ind).Value)
        objModificaUsuario.txtMNombre.Text = Convert.ToString(dtgUsuarios.Item("Nombre", ind).Value)
        objModificaUsuario.txtMPaterno.Text = Convert.ToString(dtgUsuarios.Item("Paterno", ind).Value)
        objModificaUsuario.txtMMaterno.Text = Convert.ToString(dtgUsuarios.Item("Materno", ind).Value)
        objModificaUsuario.txtMContrasenia.Text = Convert.ToString(dtgUsuarios.Item("Contrasenia", ind).Value)
        objModificaUsuario.chkMAdmin.Checked = Convert.ToBoolean(dtgUsuarios.Item("Administrador", ind).Value)
        objModificaUsuario.ShowDialog()
        Call cargadatos()
    End Sub
End Class