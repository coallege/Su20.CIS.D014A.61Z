Public Class Card
  Public Suit As Suit
  Public Rank As Rank
  Public ChkBox As CheckBox

  Public Sub New(suit As Suit, rank As Rank, chkBox As CheckBox)
    Me.Suit = suit
    Me.Rank = rank
    Me.ChkBox = chkBox
  End Sub

  Public Function IsSelected() As Boolean
    Return ChkBox.Checked
  End Function

  Public Sub Deselect()
    ChkBox.Checked = False
  End Sub

  Public Overrides Function ToString() As String
    Return $"{Rank} of {Suit}"
  End Function
End Class
