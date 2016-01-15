<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Txtrfc = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Btnbuscarrfc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscartiket = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnueva
        '
        Me.btnnueva.Location = New System.Drawing.Point(738, 62)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(124, 23)
        Me.btnnueva.TabIndex = 0
        Me.btnnueva.Text = "Nueva venta"
        Me.btnnueva.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(341, 246)
        Me.DataGridView1.TabIndex = 5
        '
        'Txtrfc
        '
        Me.Txtrfc.Location = New System.Drawing.Point(101, 6)
        Me.Txtrfc.Name = "Txtrfc"
        Me.Txtrfc.Size = New System.Drawing.Size(265, 20)
        Me.Txtrfc.TabIndex = 8
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(359, 121)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(503, 246)
        Me.DataGridView2.TabIndex = 9
        '
        'Btnbuscarrfc
        '
        Me.Btnbuscarrfc.Location = New System.Drawing.Point(738, 4)
        Me.Btnbuscarrfc.Name = "Btnbuscarrfc"
        Me.Btnbuscarrfc.Size = New System.Drawing.Size(124, 23)
        Me.Btnbuscarrfc.TabIndex = 10
        Me.Btnbuscarrfc.Text = "Buscar RFC"
        Me.Btnbuscarrfc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "RFC:"
        '
        'btnbuscartiket
        '
        Me.btnbuscartiket.Location = New System.Drawing.Point(738, 33)
        Me.btnbuscartiket.Name = "btnbuscartiket"
        Me.btnbuscartiket.Size = New System.Drawing.Size(124, 23)
        Me.btnbuscartiket.TabIndex = 45
        Me.btnbuscartiket.Text = "Buscar Tiket"
        Me.btnbuscartiket.UseVisualStyleBackColor = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 379)
        Me.Controls.Add(Me.btnbuscartiket)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnbuscarrfc)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Txtrfc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnnueva)
        Me.Name = "frmVentas"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnueva As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Txtrfc As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Btnbuscarrfc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscartiket As Button
End Class
