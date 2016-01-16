Imports MySql.Data.MySqlClient

Public Class Principal
    Public Sub Sesion()
        If vsesion = 1 Then
            UsuariToolStripMenuItem.Enabled = True
        Else
            UsuariToolStripMenuItem.Enabled = False
        End If
    End Sub

    Public Sub AgregarProducto()
        Dim tran As MySqlTransaction
        Try
            ccbd.conectarbd()
            conbd.Open()
            tran = conbd.BeginTransaction
            'sql = "INSERT INTO tbl_sucursal (Sucursal, Domicilio, CP, Cat_Estado_IdEstado, Cat_Ciudades_IdCiudad) VALUES ('" & txtNSucursal.Text & "', '" & txtNDireccion.Text & "', " & txtNCP.Text & ", " & cmbEstado.SelectedValue & ", " & cmbMunicipio.SelectedValue & ")"
            sql = "INSERT INTO tbl_ventas (cliente_cod_cli, Tbl_sucursal_IdSucursal) VALUES ('Público general', " & vsucursal & ")"
            mycommand = New MySqlCommand(sql)
            mycommand.Connection = conbd
            mycommand.Transaction = tran
            mycommand.ExecuteNonQuery()
            MessageBox.Show("Ticket generado correctamente.", "Generación de ticket.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tran.Commit()
            conbd.Close()
            frmAgregarProductos.ShowDialog()
        Catch ex As Exception
            tran.Rollback()
            conbd.Close()
            MessageBox.Show("Error al generar el ticket.", "Generación de ticket.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub SalirDeProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDeProgramaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Clientes.Show()
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs)
        altacliente.Show()
    End Sub

    Private Sub UsuariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariToolStripMenuItem.Click

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Sesion()
    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Close()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        'Dim objUsuarios As New frmUsuarios
        'objUsuarios.MdiParent = Me
        'objUsuarios.FormBorderStyle = 0
        'objUsuarios.Show()
        frmUsuarios.Show()
    End Sub

    Private Sub DatosDeLaEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeLaEmpresaToolStripMenuItem.Click
        datosempresa.Show()
    End Sub

    Private Sub HolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HolaToolStripMenuItem.Click

    End Sub

    Private Sub ModificacionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Principal_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Call Sesion()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        frmSucursales.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmNuevaventa.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienteToolStripMenuItem.Click
        Clientes.Show()
        Clientes.Close()
        altacliente.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InventariosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Call AgregarProducto()
    End Sub

    Private Sub chkTipocliente_CheckedChanged(sender As Object, e As EventArgs) Handles chkTipocliente.CheckedChanged
        If chkTipocliente.Checked = True Then
            cmbNombreCliente.Enabled = False
        Else
            cmbNombreCliente.Enabled = True
        End If
    End Sub
End Class