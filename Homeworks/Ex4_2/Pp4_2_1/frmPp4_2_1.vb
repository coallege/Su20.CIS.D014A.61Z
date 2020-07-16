Public Class frmPp4_2_1
  Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
    'Check reasonableness of data
    Dim num As Double
    num = CDbl(txtNumber.Text)
    If num < 0 Then
      MessageBox.Show("Number can't be negative.")
    Else
      MessageBox.Show(Math.Sqrt(num))
    End If
  End Sub

End Class
