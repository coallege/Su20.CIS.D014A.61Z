Public Class frmEx6_3_11
  Private Sub frmEx6_3_11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    lstBox.SelectedIndex = 1
    Dim num As Integer = 0
    For n As Integer = 0 To (lstBox.Items.Count - 1)
      num += CInt(lstBox.Items(n))
    Next
    txtOutput.Text = CStr(num)
  End Sub
End Class
