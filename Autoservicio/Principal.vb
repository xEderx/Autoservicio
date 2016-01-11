Public Class Principal
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

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        altacliente.Show()
    End Sub

    Private Sub UsuariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariToolStripMenuItem.Click

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class