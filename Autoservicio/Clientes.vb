Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargadatos()
    End Sub
    Public Sub cargadatos()
        Dim dt As New DataTable
        ccbd.conectarbd()
        Try
            Txtrfc.Text = ""
            sql = "select * from cliente"

            daMySQL.SelectCommand = New MySqlCommand(sql, conbd)
            daMySQL.Fill(dt)
            Me.DataGridView1.DataSource = dt
            DataGridView1.ReadOnly = True
            DataGridView1.AutoResizeColumns()

            DataGridView1.Columns(0).HeaderText = "RFC"
            DataGridView1.Columns(1).HeaderText = "Nombre"
            DataGridView1.Columns(2).HeaderText = "Domicilio"
            DataGridView1.Columns(3).HeaderText = "Telefono"
            DataGridView1.Columns(4).HeaderText = "Carpeta"
            DataGridView1.Columns(5).HeaderText = "Correo"

        Catch ex As Exception

        End Try
    End Sub
End Class