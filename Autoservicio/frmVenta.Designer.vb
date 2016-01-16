<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Txtrfc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.Btnbuscarrfc = New System.Windows.Forms.Button()
        Me.btnbuscartiket = New System.Windows.Forms.Button()
        Me.txttiket = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(331, 246)
        Me.DataGridView1.TabIndex = 5
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(370, 183)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(362, 246)
        Me.DataGridView2.TabIndex = 6
        '
        'Txtrfc
        '
        Me.Txtrfc.Location = New System.Drawing.Point(106, 12)
        Me.Txtrfc.Name = "Txtrfc"
        Me.Txtrfc.Size = New System.Drawing.Size(237, 20)
        Me.Txtrfc.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "RFC"
        '
        'btnnueva
        '
        Me.btnnueva.Location = New System.Drawing.Point(589, 12)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(143, 23)
        Me.btnnueva.TabIndex = 10
        Me.btnnueva.Text = "Nuevo"
        Me.btnnueva.UseVisualStyleBackColor = True
        '
        'Btnbuscarrfc
        '
        Me.Btnbuscarrfc.Location = New System.Drawing.Point(589, 54)
        Me.Btnbuscarrfc.Name = "Btnbuscarrfc"
        Me.Btnbuscarrfc.Size = New System.Drawing.Size(143, 23)
        Me.Btnbuscarrfc.TabIndex = 11
        Me.Btnbuscarrfc.Text = "Buscar RFC"
        Me.Btnbuscarrfc.UseVisualStyleBackColor = True
        '
        'btnbuscartiket
        '
        Me.btnbuscartiket.Location = New System.Drawing.Point(589, 112)
        Me.btnbuscartiket.Name = "btnbuscartiket"
        Me.btnbuscartiket.Size = New System.Drawing.Size(143, 23)
        Me.btnbuscartiket.TabIndex = 12
        Me.btnbuscartiket.Text = "Buscar Tiket"
        Me.btnbuscartiket.UseVisualStyleBackColor = True
        '
        'txttiket
        '
        Me.txttiket.Location = New System.Drawing.Point(106, 57)
        Me.txttiket.Name = "txttiket"
        Me.txttiket.Size = New System.Drawing.Size(237, 20)
        Me.txttiket.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tiket"
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 457)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttiket)
        Me.Controls.Add(Me.btnbuscartiket)
        Me.Controls.Add(Me.Btnbuscarrfc)
        Me.Controls.Add(Me.btnnueva)
        Me.Controls.Add(Me.Txtrfc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmVentas"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Txtrfc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnueva As Button
    Friend WithEvents Btnbuscarrfc As Button
    Friend WithEvents btnbuscartiket As Button
    Friend WithEvents txttiket As TextBox
    Friend WithEvents Label3 As Label
End Class
