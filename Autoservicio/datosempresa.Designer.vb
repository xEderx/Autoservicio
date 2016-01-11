<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datosempresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(datosempresa))
        Me.txtcp = New System.Windows.Forms.TextBox()
        Me.txtciudad = New System.Windows.Forms.TextBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnMGuardar = New System.Windows.Forms.Button()
        Me.txtMPaterno = New System.Windows.Forms.TextBox()
        Me.txtMNombre = New System.Windows.Forms.TextBox()
        Me.txtMUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtcp
        '
        Me.txtcp.Location = New System.Drawing.Point(163, 196)
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(140, 20)
        Me.txtcp.TabIndex = 61
        '
        'txtciudad
        '
        Me.txtciudad.Location = New System.Drawing.Point(163, 157)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(140, 20)
        Me.txtciudad.TabIndex = 60
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(162, 128)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(140, 20)
        Me.txtestado.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Cp:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Ciudad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Estado:"
        '
        'btnMGuardar
        '
        Me.btnMGuardar.BackgroundImage = CType(resources.GetObject("btnMGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnMGuardar.Location = New System.Drawing.Point(220, 278)
        Me.btnMGuardar.Name = "btnMGuardar"
        Me.btnMGuardar.Size = New System.Drawing.Size(52, 48)
        Me.btnMGuardar.TabIndex = 55
        Me.btnMGuardar.UseVisualStyleBackColor = True
        '
        'txtMPaterno
        '
        Me.txtMPaterno.Location = New System.Drawing.Point(162, 88)
        Me.txtMPaterno.Name = "txtMPaterno"
        Me.txtMPaterno.Size = New System.Drawing.Size(140, 20)
        Me.txtMPaterno.TabIndex = 54
        '
        'txtMNombre
        '
        Me.txtMNombre.Location = New System.Drawing.Point(162, 53)
        Me.txtMNombre.Name = "txtMNombre"
        Me.txtMNombre.Size = New System.Drawing.Size(140, 20)
        Me.txtMNombre.TabIndex = 53
        '
        'txtMUsuario
        '
        Me.txtMUsuario.Location = New System.Drawing.Point(162, 20)
        Me.txtMUsuario.Name = "txtMUsuario"
        Me.txtMUsuario.Size = New System.Drawing.Size(140, 20)
        Me.txtMUsuario.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Domicilio fiscal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "RFC:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Nombre de la empresa"
        '
        'datosempresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 346)
        Me.Controls.Add(Me.txtcp)
        Me.Controls.Add(Me.txtciudad)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnMGuardar)
        Me.Controls.Add(Me.txtMPaterno)
        Me.Controls.Add(Me.txtMNombre)
        Me.Controls.Add(Me.txtMUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "datosempresa"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcp As TextBox
    Friend WithEvents txtciudad As TextBox
    Friend WithEvents txtestado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnMGuardar As Button
    Friend WithEvents txtMPaterno As TextBox
    Friend WithEvents txtMNombre As TextBox
    Friend WithEvents txtMUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
