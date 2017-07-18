Public Class Form1
    Dim datos As DataTable
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim dato As Integer
                dato = Int(TextBox1.Text)
                datos.NewRow()
                datos.Rows(datos.Rows.Count - 1).Item(0) = dato
                TextBox1.Text = ""
            Catch ex As Exception
                L_resultado.Text = ex.ToString
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_ordenar.Click
        Dim vista As DataView = New DataView(datos)
        vista.Sort = "datos"
        DataGridView1.DataSource = vista
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datos.Columns.Add("datos")
    End Sub

    Private Sub B_frecuencias_Click(sender As Object, e As EventArgs) Handles B_frecuencias.Click
        Dim tabla_frecuencias As DataTable
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles B_parentecis_inicial.Click
        If B_parentecis_inicial.Text = "(" Then
            B_parentecis_inicial.Text = "["
        Else
            B_parentecis_inicial.Text = "("
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        If B_parentecis_inicial.Text = ")" Then
            B_parentecis_inicial.Text = "]"
        Else
            B_parentecis_inicial.Text = ")"
        End If
    End Sub
End Class
