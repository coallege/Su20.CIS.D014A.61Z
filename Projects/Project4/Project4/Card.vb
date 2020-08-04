Public Class Card
  Implements IComparable

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
    Return $"{Rank.Display} of {Suit}"
  End Function

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    ' In real code, this could fail and it would be a
    ' good idea to guard it with a typeof test but
    ' I only end up using this once so it'd hurt performance
    Dim otherCard = CType(obj, Card)
    Return Rank.CompareTo(otherCard.Rank)
  End Function
End Class
