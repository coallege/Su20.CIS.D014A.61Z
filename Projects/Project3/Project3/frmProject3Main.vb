Public Class frmProject3Main
  Private Sub frmProject3Main_Load() Handles MyBase.Load
    Dim frmSchedule = New frmSchedule()
    frmSchedule.ShowDialog("blah" + vbLf)
  End Sub
End Class
