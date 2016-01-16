Public Class Principal
    Public Sub Sesion()
        If vsesion = 1 Then
            UsuariToolStripMenuItem.Enabled = True
        Else
            UsuariToolStripMenuItem.Enabled = False
        End If
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

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        frmVenta.Show()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        frmVenta.Show()
        frmVenta.Close()
        frmNuevaventa.Show()
    End Sub

    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienteToolStripMenuItem.Click
        Clientes.Show()
        Clientes.Close()
        altacliente.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
End Class