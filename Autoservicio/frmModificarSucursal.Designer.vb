<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarSucursal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarSucursal))
        Me.cmbMMunicipio = New System.Windows.Forms.ComboBox()
        Me.cmbMEstado = New System.Windows.Forms.ComboBox()
        Me.txtMCP = New System.Windows.Forms.TextBox()
        Me.txtMDireccion = New System.Windows.Forms.TextBox()
        Me.txtMSucursal = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbMMunicipio
        '
        Me.cmbMMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMMunicipio.FormattingEnabled = True
        Me.cmbMMunicipio.Location = New System.Drawing.Point(73, 213)
        Me.cmbMMunicipio.Name = "cmbMMunicipio"
        Me.cmbMMunicipio.Size = New System.Drawing.Size(201, 21)
        Me.cmbMMunicipio.TabIndex = 28
        '
        'cmbMEstado
        '
        Me.cmbMEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMEstado.FormattingEnabled = True
        Me.cmbMEstado.Location = New System.Drawing.Point(73, 177)
        Me.cmbMEstado.Name = "cmbMEstado"
        Me.cmbMEstado.Size = New System.Drawing.Size(201, 21)
        Me.cmbMEstado.TabIndex = 27
        '
        'txtMCP
        '
        Me.txtMCP.Location = New System.Drawing.Point(73, 141)
        Me.txtMCP.Name = "txtMCP"
        Me.txtMCP.Size = New System.Drawing.Size(75, 20)
        Me.txtMCP.TabIndex = 26
        '
        'txtMDireccion
        '
        Me.txtMDireccion.Location = New System.Drawing.Point(73, 45)
        Me.txtMDireccion.Multiline = True
        Me.txtMDireccion.Name = "txtMDireccion"
        Me.txtMDireccion.Size = New System.Drawing.Size(284, 82)
        Me.txtMDireccion.TabIndex = 25
        '
        'txtMSucursal
        '
        Me.txtMSucursal.Location = New System.Drawing.Point(135, 12)
        Me.txtMSucursal.Name = "txtMSucursal"
        Me.txtMSucursal.Size = New System.Drawing.Size(222, 20)
        Me.txtMSucursal.TabIndex = 24
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(296, 244)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(52, 48)
        Me.btnGuardar.TabIndex = 23
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Municipio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "C.P."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Dirección:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre de la sucursal:"
        '
        'frmModificarSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(369, 305)
        Me.Controls.Add(Me.cmbMMunicipio)
        Me.Controls.Add(Me.cmbMEstado)
        Me.Controls.Add(Me.txtMCP)
        Me.Controls.Add(Me.txtMDireccion)
        Me.Controls.Add(Me.txtMSucursal)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificarSucursal"
        Me.Text = "Modificación de sucursal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMMunicipio As ComboBox
    Friend WithEvents cmbMEstado As ComboBox
    Friend WithEvents txtMCP As TextBox
    Friend WithEvents txtMDireccion As TextBox
    Friend WithEvents txtMSucursal As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
