Public Class Form1
    Dim datos As New DataTable
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim dato As Integer
                dato = Int(TextBox1.Text)
                datos.Rows.Add(datos.NewRow())
                datos.Rows(datos.Rows.Count - 1).Item(1) = dato
                TextBox1.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_ordenar.Click
        Dim vista As DataView = New DataView(datos)
        vista.Sort = "datos"
        DataGridView1.DataSource = vista
        NUD_rango_inicio.Value = vista.Item(0).Item(1) - 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim primaria(1) As DataColumn
        datos.Columns.Add("id")
        datos.Columns("id").Unique = True
        datos.Columns("id").AutoIncrement = True
        primaria(0) = datos.Columns("id")
        datos.PrimaryKey = primaria
        datos.Columns.Add("datos")
        datos.Columns("datos").DataType = System.Type.GetType("System.Int32")
    End Sub

    Private Sub B_frecuencias_Click(sender As Object, e As EventArgs) Handles B_frecuencias.Click
        Dim tabla_frecuencias As New DataTable
        tabla_frecuencias.Columns.Add("clase")
        tabla_frecuencias.Columns.Add("ni")
        Dim maximo As Integer = datos.Compute("MAX(datos)", "")
        Dim actual As Integer = NUD_rango_inicio.Value
        Dim rango As Integer = NUD_rango.Value
        Dim fila As Integer = 0
        While actual < maximo
            tabla_frecuencias.Rows.Add(tabla_frecuencias.NewRow())
            fila = tabla_frecuencias.Rows.Count - 1
            tabla_frecuencias.Rows(fila).Item(0) = B_parentecis_inicial.Text & actual & "-" & actual + rango & B_parentesis_final.Text
            tabla_frecuencias.Rows(fila).Item(1) = datos.Compute("Count(datos)", "datos >" & actual & "and datos <=" & actual + rango)
            actual += rango
        End While
        DataGridView1.DataSource = tabla_frecuencias
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles B_parentecis_inicial.Click
        If B_parentecis_inicial.Text = "(" Then
            B_parentecis_inicial.Text = "["
        Else
            B_parentecis_inicial.Text = "("
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles B_parentesis_final.Click
        If B_parentesis_final.Text = ")" Then
            B_parentesis_final.Text = "]"
        Else
            B_parentesis_final.Text = ")"
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class
