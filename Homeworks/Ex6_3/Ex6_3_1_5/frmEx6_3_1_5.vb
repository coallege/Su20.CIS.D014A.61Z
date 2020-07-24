Public Class frmEx6_3_1_5
  Private Sub frmEx6_3_1_5_Load() Handles MyBase.Load
    lstBox.SelectedIndex = 3
  End Sub

  Private Sub btn1_Click() Handles btn1.Click
    txtOutput.Text = lstBox.Text
  End Sub

  Private Sub btn5_Click() Handles btn5.Click
    txtOutput.Text = CStr(lstBox.SelectedIndex)
  End Sub
End Class
