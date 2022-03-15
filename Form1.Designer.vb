<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fraiz
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
        Me.Li = New System.Windows.Forms.Label()
        Me.Lc = New System.Windows.Forms.Label()
        Me.Ti = New System.Windows.Forms.TextBox()
        Me.Tc = New System.Windows.Forms.TextBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Li
        '
        Me.Li.AutoSize = True
        Me.Li.Location = New System.Drawing.Point(157, 54)
        Me.Li.Name = "Li"
        Me.Li.Size = New System.Drawing.Size(62, 13)
        Me.Li.TabIndex = 0
        Me.Li.Text = "Dame inicio"
        '
        'Lc
        '
        Me.Lc.AutoSize = True
        Me.Lc.Location = New System.Drawing.Point(157, 114)
        Me.Lc.Name = "Lc"
        Me.Lc.Size = New System.Drawing.Size(63, 13)
        Me.Lc.TabIndex = 1
        Me.Lc.Text = "Dame cifras"
        '
        'Ti
        '
        Me.Ti.Location = New System.Drawing.Point(226, 51)
        Me.Ti.Name = "Ti"
        Me.Ti.Size = New System.Drawing.Size(100, 20)
        Me.Ti.TabIndex = 2
        '
        'Tc
        '
        Me.Tc.Location = New System.Drawing.Point(226, 111)
        Me.Tc.Name = "Tc"
        Me.Tc.Size = New System.Drawing.Size(100, 20)
        Me.Tc.TabIndex = 3
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(416, 111)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "&Salida"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(416, 51)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 5
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.salida.Location = New System.Drawing.Point(180, 192)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(343, 150)
        Me.salida.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Indice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Raiz"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Error"
        Me.Column3.Name = "Column3"
        '
        'Fraiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Tc)
        Me.Controls.Add(Me.Ti)
        Me.Controls.Add(Me.Lc)
        Me.Controls.Add(Me.Li)
        Me.Name = "Fraiz"
        Me.Text = "Raiz de dos"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Li As Label
    Friend WithEvents Lc As Label
    Friend WithEvents Ti As TextBox
    Friend WithEvents Tc As TextBox
    Friend WithEvents Salir As Button
    Friend WithEvents Calcular As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
