<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtNUsuario = New System.Windows.Forms.TextBox()
        Me.txtNNombre = New System.Windows.Forms.TextBox()
        Me.txtNPaterno = New System.Windows.Forms.TextBox()
        Me.txtNMaterno = New System.Windows.Forms.TextBox()
        Me.txtNContrasenia = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 201)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Administrador"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtNUsuario
        '
        Me.txtNUsuario.Location = New System.Drawing.Point(118, 13)
        Me.txtNUsuario.Name = "txtNUsuario"
        Me.txtNUsuario.Size = New System.Drawing.Size(140, 20)
        Me.txtNUsuario.TabIndex = 6
        '
        'txtNNombre
        '
        Me.txtNNombre.Location = New System.Drawing.Point(118, 46)
        Me.txtNNombre.Name = "txtNNombre"
        Me.txtNNombre.Size = New System.Drawing.Size(140, 20)
        Me.txtNNombre.TabIndex = 7
        '
        'txtNPaterno
        '
        Me.txtNPaterno.Location = New System.Drawing.Point(118, 81)
        Me.txtNPaterno.Name = "txtNPaterno"
        Me.txtNPaterno.Size = New System.Drawing.Size(140, 20)
        Me.txtNPaterno.TabIndex = 8
        '
        'txtNMaterno
        '
        Me.txtNMaterno.Location = New System.Drawing.Point(118, 116)
        Me.txtNMaterno.Name = "txtNMaterno"
        Me.txtNMaterno.Size = New System.Drawing.Size(140, 20)
        Me.txtNMaterno.TabIndex = 9
        '
        'txtNContrasenia
        '
        Me.txtNContrasenia.Location = New System.Drawing.Point(118, 151)
        Me.txtNContrasenia.Name = "txtNContrasenia"
        Me.txtNContrasenia.Size = New System.Drawing.Size(140, 20)
        Me.txtNContrasenia.TabIndex = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(197, 184)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(52, 48)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(276, 239)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtNContrasenia)
        Me.Controls.Add(Me.txtNMaterno)
        Me.Controls.Add(Me.txtNPaterno)
        Me.Controls.Add(Me.txtNNombre)
        Me.Controls.Add(Me.txtNUsuario)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevoUsuario"
        Me.Text = "Nuevo usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtNUsuario As TextBox
    Friend WithEvents txtNNombre As TextBox
    Friend WithEvents txtNPaterno As TextBox
    Friend WithEvents txtNMaterno As TextBox
    Friend WithEvents txtNContrasenia As TextBox
    Friend WithEvents btnGuardar As Button
End Class
