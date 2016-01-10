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
End Class