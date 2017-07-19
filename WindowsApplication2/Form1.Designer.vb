<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.B_ordenar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.B_parentesis_final = New System.Windows.Forms.Button()
        Me.B_parentecis_inicial = New System.Windows.Forms.Button()
        Me.NUD_rango_inicio = New System.Windows.Forms.NumericUpDown()
        Me.NUD_rango = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_frecuencias = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUD_rango_inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_rango, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 22)
        Me.TextBox1.TabIndex = 0
        '
        'B_ordenar
        '
        Me.B_ordenar.Location = New System.Drawing.Point(6, 6)
        Me.B_ordenar.Name = "B_ordenar"
        Me.B_ordenar.Size = New System.Drawing.Size(75, 23)
        Me.B_ordenar.TabIndex = 1
        Me.B_ordenar.Text = "Ordenar"
        Me.B_ordenar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(669, 205)
        Me.DataGridView1.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(34, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(673, 103)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.B_ordenar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(665, 74)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ordenar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.NUD_rango)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.B_frecuencias)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(665, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "frecuencias"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.B_parentesis_final)
        Me.GroupBox1.Controls.Add(Me.B_parentecis_inicial)
        Me.GroupBox1.Controls.Add(Me.NUD_rango_inicio)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 65)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Numero de inicio"
        '
        'B_parentesis_final
        '
        Me.B_parentesis_final.Location = New System.Drawing.Point(119, 20)
        Me.B_parentesis_final.Name = "B_parentesis_final"
        Me.B_parentesis_final.Size = New System.Drawing.Size(22, 31)
        Me.B_parentesis_final.TabIndex = 6
        Me.B_parentesis_final.Text = ")"
        Me.B_parentesis_final.UseVisualStyleBackColor = True
        '
        'B_parentecis_inicial
        '
        Me.B_parentecis_inicial.Location = New System.Drawing.Point(24, 20)
        Me.B_parentecis_inicial.Name = "B_parentecis_inicial"
        Me.B_parentecis_inicial.Size = New System.Drawing.Size(22, 31)
        Me.B_parentecis_inicial.TabIndex = 3
        Me.B_parentecis_inicial.Text = "("
        Me.B_parentecis_inicial.UseVisualStyleBackColor = True
        '
        'NUD_rango_inicio
        '
        Me.NUD_rango_inicio.Location = New System.Drawing.Point(65, 25)
        Me.NUD_rango_inicio.Name = "NUD_rango_inicio"
        Me.NUD_rango_inicio.Size = New System.Drawing.Size(48, 22)
        Me.NUD_rango_inicio.TabIndex = 4
        '
        'NUD_rango
        '
        Me.NUD_rango.Location = New System.Drawing.Point(26, 33)
        Me.NUD_rango.Name = "NUD_rango"
        Me.NUD_rango.Size = New System.Drawing.Size(53, 22)
        Me.NUD_rango.TabIndex = 2
        Me.NUD_rango.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rango"
        '
        'B_frecuencias
        '
        Me.B_frecuencias.Location = New System.Drawing.Point(465, 10)
        Me.B_frecuencias.Name = "B_frecuencias"
        Me.B_frecuencias.Size = New System.Drawing.Size(75, 23)
        Me.B_frecuencias.TabIndex = 0
        Me.B_frecuencias.Text = "crear frecuencias"
        Me.B_frecuencias.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 380)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NUD_rango_inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_rango, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents B_ordenar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents NUD_rango As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents B_frecuencias As Button
    Friend WithEvents B_parentecis_inicial As Button
    Friend WithEvents B_parentesis_final As Button
    Friend WithEvents NUD_rango_inicio As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
End Class
