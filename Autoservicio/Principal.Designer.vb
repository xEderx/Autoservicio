<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDeProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDeLaEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem, Me.ProvedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.InventariosToolStripMenuItem, Me.UsuariToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(653, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HolaToolStripMenuItem
        '
        Me.HolaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirDeProgramaToolStripMenuItem, Me.DatosDeLaEmpresaToolStripMenuItem})
        Me.HolaToolStripMenuItem.Name = "HolaToolStripMenuItem"
        Me.HolaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HolaToolStripMenuItem.Text = "Archivo"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'SalirDeProgramaToolStripMenuItem
        '
        Me.SalirDeProgramaToolStripMenuItem.Name = "SalirDeProgramaToolStripMenuItem"
        Me.SalirDeProgramaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirDeProgramaToolStripMenuItem.Text = "Salir de programa"
        '
        'ProvedoresToolStripMenuItem
        '
        Me.ProvedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ModificacionToolStripMenuItem})
        Me.ProvedoresToolStripMenuItem.Name = "ProvedoresToolStripMenuItem"
        Me.ProvedoresToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ProvedoresToolStripMenuItem.Text = "Sucursales"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ModificacionToolStripMenuItem.Text = "Modificacion"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.ListadoToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AToolStripMenuItem.Text = "Alta"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'InventariosToolStripMenuItem
        '
        Me.InventariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.SaldosToolStripMenuItem})
        Me.InventariosToolStripMenuItem.Name = "InventariosToolStripMenuItem"
        Me.InventariosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.InventariosToolStripMenuItem.Text = "Inventarios"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'SaldosToolStripMenuItem
        '
        Me.SaldosToolStripMenuItem.Name = "SaldosToolStripMenuItem"
        Me.SaldosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaldosToolStripMenuItem.Text = "Saldos"
        '
        'UsuariToolStripMenuItem
        '
        Me.UsuariToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem})
        Me.UsuariToolStripMenuItem.Name = "UsuariToolStripMenuItem"
        Me.UsuariToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.UsuariToolStripMenuItem.Text = "Administración"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'DatosDeLaEmpresaToolStripMenuItem
        '
        Me.DatosDeLaEmpresaToolStripMenuItem.Name = "DatosDeLaEmpresaToolStripMenuItem"
        Me.DatosDeLaEmpresaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DatosDeLaEmpresaToolStripMenuItem.Text = "Datos de la empresa"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(653, 410)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Principal"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDeProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaldosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDeLaEmpresaToolStripMenuItem As ToolStripMenuItem
End Class
