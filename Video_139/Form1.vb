Public Class Form1
    Private Sub btnRecursion_Click(sender As Object, e As EventArgs) Handles btnRecursion.Click
        MessageBox.Show(RecursiveFunction(Convert.ToInt32(TextBox1.Text)))
    End Sub

    Private Function RecursiveFunction(ByVal argInt As Integer) As Double
        If argInt <= 10 Then
            Return argInt
        End If
        If argInt > 10 Then
            Return RecursiveFunction(argInt / 2)
        End If
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 0 Then
            Try
                Convert.ToDouble(TextBox1.Text)
            Catch ex As Exception
                MessageBox.Show("please only type numbers")
                TextBox1.Clear()
            End Try
        End If
    End Sub
End Class
