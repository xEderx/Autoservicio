<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaSucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaSucursal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNSucursal = New System.Windows.Forms.TextBox()
        Me.txtNDireccion = New System.Windows.Forms.TextBox()
        Me.txtNCP = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "C.P."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Municipio:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(296, 245)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(52, 48)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNSucursal
        '
        Me.txtNSucursal.Location = New System.Drawing.Point(135, 13)
        Me.txtNSucursal.Name = "txtNSucursal"
        Me.txtNSucursal.Size = New System.Drawing.Size(222, 20)
        Me.txtNSucursal.TabIndex = 13
        '
        'txtNDireccion
        '
        Me.txtNDireccion.Location = New System.Drawing.Point(73, 46)
        Me.txtNDireccion.Multiline = True
        Me.txtNDireccion.Name = "txtNDireccion"
        Me.txtNDireccion.Size = New System.Drawing.Size(284, 82)
        Me.txtNDireccion.TabIndex = 14
        '
        'txtNCP
        '
        Me.txtNCP.Location = New System.Drawing.Point(73, 142)
        Me.txtNCP.Name = "txtNCP"
        Me.txtNCP.Size = New System.Drawing.Size(75, 20)
        Me.txtNCP.TabIndex = 15
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(73, 178)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(201, 21)
        Me.cmbEstado.TabIndex = 16
        '
        'cmbMunicipio
        '
        Me.cmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMunicipio.FormattingEnabled = True
        Me.cmbMunicipio.Location = New System.Drawing.Point(73, 214)
        Me.cmbMunicipio.Name = "cmbMunicipio"
        Me.cmbMunicipio.Size = New System.Drawing.Size(201, 21)
        Me.cmbMunicipio.TabIndex = 17
        '
        'frmNuevaSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 305)
        Me.Controls.Add(Me.cmbMunicipio)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.txtNCP)
        Me.Controls.Add(Me.txtNDireccion)
        Me.Controls.Add(Me.txtNSucursal)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevaSucursal"
        Me.Text = "Alta de sucursal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNSucursal As TextBox
    Friend WithEvents txtNDireccion As TextBox
    Friend WithEvents txtNCP As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbMunicipio As ComboBox
End Class
