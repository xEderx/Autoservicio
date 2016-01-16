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
        Me.DatosDeLaEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.chkTipocliente = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbNombreCliente = New System.Windows.Forms.ComboBox()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.UsuariToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 24)
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
        'DatosDeLaEmpresaToolStripMenuItem
        '
        Me.DatosDeLaEmpresaToolStripMenuItem.Name = "DatosDeLaEmpresaToolStripMenuItem"
        Me.DatosDeLaEmpresaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DatosDeLaEmpresaToolStripMenuItem.Text = "Datos de la empresa"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoToolStripMenuItem, Me.AltaClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AltaClienteToolStripMenuItem.Text = "Alta Cliente"
        '
        'UsuariToolStripMenuItem
        '
        Me.UsuariToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.CatálogosToolStripMenuItem})
        Me.UsuariToolStripMenuItem.Name = "UsuariToolStripMenuItem"
        Me.UsuariToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.UsuariToolStripMenuItem.Text = "Administración"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SucursalesToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(381, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio de venta:"
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.ForeColor = System.Drawing.Color.Red
        Me.lblFolio.Location = New System.Drawing.Point(464, 37)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(24, 13)
        Me.lblFolio.TabIndex = 3
        Me.lblFolio.Text = "No."
        '
        'chkTipocliente
        '
        Me.chkTipocliente.AutoSize = True
        Me.chkTipocliente.Location = New System.Drawing.Point(101, 33)
        Me.chkTipocliente.Name = "chkTipocliente"
        Me.chkTipocliente.Size = New System.Drawing.Size(99, 17)
        Me.chkTipocliente.TabIndex = 4
        Me.chkTipocliente.Text = "Público general"
        Me.chkTipocliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo de cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre del cliente:"
        '
        'cmbNombreCliente
        '
        Me.cmbNombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNombreCliente.FormattingEnabled = True
        Me.cmbNombreCliente.Location = New System.Drawing.Point(116, 65)
        Me.cmbNombreCliente.Name = "cmbNombreCliente"
        Me.cmbNombreCliente.Size = New System.Drawing.Size(264, 21)
        Me.cmbNombreCliente.TabIndex = 7
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(400, 62)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(75, 39)
        Me.btnAgregarProducto.TabIndex = 8
        Me.btnAgregarProducto.Text = "Agregar productos"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(515, 113)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.cmbNombreCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkTipocliente)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Principal"
        Me.Text = "Autoservicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDeProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDeLaEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFolio As Label
    Friend WithEvents chkTipocliente As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbNombreCliente As ComboBox
    Friend WithEvents btnAgregarProducto As Button
End Class
