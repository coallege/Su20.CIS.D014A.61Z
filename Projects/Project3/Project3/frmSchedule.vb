Public Class frmSchedule
  Public Overloads Sub ShowDialog(strText As String)
    ShowDialog()
  End Sub
  Private Sub frmSchedule_Resize() Handles Me.Resize
    ' Makes that little drag thing on the bottom right side of the form useable
    tblLayout.Width = Width - 31
    tblLayout.Height = Height - 40
  End Sub

  Private Sub frmSchedule_Load() Handles MyBase.Load
    AddHandler btnClose.Click, AddressOf Close
  End Sub

  Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

  End Sub
End Class
