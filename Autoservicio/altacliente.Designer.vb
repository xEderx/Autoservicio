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
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btnnuevo
        '
        Me.Btnnuevo.Location = New System.Drawing.Point(302, 24)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btnnuevo.TabIndex = 0
        Me.Btnnuevo.Text = "Nuevo"
        Me.Btnnuevo.UseVisualStyleBackColor = True
        '
        'altacliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 421)
        Me.Controls.Add(Me.Btnnuevo)
        Me.Name = "altacliente"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnnuevo As Button
End Class
