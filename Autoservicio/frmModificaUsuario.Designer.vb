<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificaUsuario))
        Me.btnMGuardar = New System.Windows.Forms.Button()
        Me.txtMContrasenia = New System.Windows.Forms.TextBox()
        Me.txtMMaterno = New System.Windows.Forms.TextBox()
        Me.txtMPaterno = New System.Windows.Forms.TextBox()
        Me.txtMNombre = New System.Windows.Forms.TextBox()
        Me.txtMUsuario = New System.Windows.Forms.TextBox()
        Me.chkMAdmin = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMGuardar
        '
        Me.btnMGuardar.BackgroundImage = CType(resources.GetObject("btnMGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnMGuardar.Location = New System.Drawing.Point(200, 181)
        Me.btnMGuardar.Name = "btnMGuardar"
        Me.btnMGuardar.Size = New System.Drawing.Size(52, 48)
        Me.btnMGuardar.TabIndex = 23
        Me.btnMGuardar.UseVisualStyleBackColor = True
        '
        'txtMContrasenia
        '
        Me.txtMContrasenia.Location = New System.Drawing.Point(121, 148)
        Me.txtMContrasenia.Name = "txtMContrasenia"
        Me.txtMContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMContrasenia.Size = New System.Drawing.Size(140, 20)
        Me.txtMContrasenia.TabIndex = 22
        '
        'txtMMaterno
        '
        Me.txtMMaterno.Location = New System.Drawing.Point(121, 113)
        Me.txtMMaterno.Name = "txtMMaterno"
        Me.txtMMaterno.Size = New System.Drawing.Size(140, 20)
        Me.txtMMaterno.TabIndex = 21
        '
        'txtMPaterno
        '
        Me.txtMPaterno.Location = New System.Drawing.Point(121, 78)
        Me.txtMPaterno.Name = "txtMPaterno"
        Me.txtMPaterno.Size = New System.Drawing.Size(140, 20)
        Me.txtMPaterno.TabIndex = 20
        '
        'txtMNombre
        '
        Me.txtMNombre.Location = New System.Drawing.Point(121, 43)
        Me.txtMNombre.Name = "txtMNombre"
        Me.txtMNombre.Size = New System.Drawing.Size(140, 20)
        Me.txtMNombre.TabIndex = 19
        '
        'txtMUsuario
        '
        Me.txtMUsuario.Location = New System.Drawing.Point(121, 10)
        Me.txtMUsuario.Name = "txtMUsuario"
        Me.txtMUsuario.Size = New System.Drawing.Size(140, 20)
        Me.txtMUsuario.TabIndex = 18
        '
        'chkMAdmin
        '
        Me.chkMAdmin.AutoSize = True
        Me.chkMAdmin.Location = New System.Drawing.Point(15, 198)
        Me.chkMAdmin.Name = "chkMAdmin"
        Me.chkMAdmin.Size = New System.Drawing.Size(89, 17)
        Me.chkMAdmin.TabIndex = 17
        Me.chkMAdmin.Text = "Administrador"
        Me.chkMAdmin.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Apellido materno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Apellido paterno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre de usuario:"
        '
        'frmModificaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(276, 239)
        Me.Controls.Add(Me.btnMGuardar)
        Me.Controls.Add(Me.txtMContrasenia)
        Me.Controls.Add(Me.txtMMaterno)
        Me.Controls.Add(Me.txtMPaterno)
        Me.Controls.Add(Me.txtMNombre)
        Me.Controls.Add(Me.txtMUsuario)
        Me.Controls.Add(Me.chkMAdmin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificaUsuario"
        Me.Text = "Modificar usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMGuardar As Button
    Friend WithEvents txtMContrasenia As TextBox
    Friend WithEvents txtMMaterno As TextBox
    Friend WithEvents txtMPaterno As TextBox
    Friend WithEvents txtMNombre As TextBox
    Friend WithEvents txtMUsuario As TextBox
    Friend WithEvents chkMAdmin As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
