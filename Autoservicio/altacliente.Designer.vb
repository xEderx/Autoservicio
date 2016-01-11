<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altacliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altacliente))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdomicilio = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtrfc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(218, 215)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(52, 48)
        Me.btnGuardar.TabIndex = 35
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(139, 147)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(140, 20)
        Me.txttelefono.TabIndex = 33
        '
        'txtdomicilio
        '
        Me.txtdomicilio.Location = New System.Drawing.Point(139, 112)
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(140, 20)
        Me.txtdomicilio.TabIndex = 32
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(139, 77)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(140, 20)
        Me.txtnombre.TabIndex = 31
        '
        'txtrfc
        '
        Me.txtrfc.Location = New System.Drawing.Point(139, 44)
        Me.txtrfc.Name = "txtrfc"
        Me.txtrfc.Size = New System.Drawing.Size(140, 20)
        Me.txtrfc.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Telefono "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Domicilio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "RFC:"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(139, 179)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(140, 20)
        Me.txtcorreo.TabIndex = 36
        '
        'altacliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 332)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtdomicilio)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtrfc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "altacliente"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdomicilio As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtrfc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcorreo As TextBox
End Class
