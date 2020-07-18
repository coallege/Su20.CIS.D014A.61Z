Public Class FrmDemoWeek3_Thursday
  '*************************************************
  '*** Program: Demo Select Case; Resources: Random;
  '***          textbox as output display; pictures;
  '***          sub-routines.
  '*** Author : Art Linn
  '*** Date   : 7/16/2020
  '*************************************************
  'Class level variables
  Dim IntTurnNum As Integer    'Number of each turn user hit Roll
  Dim IntPointToGet As Integer 'Point to get
  Dim BolGameOver As Boolean   'Set True when game over

  Private Sub FrmDemoWeek3_Thursday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Setup Program
    Call Setup()

  End Sub

  Private Sub Setup()
    'Setup or Restart program
    TxtOut.Text = ""
    IntPointToGet = 0
    IntTurnNum = 0
    BolGameOver = False
    PicDie1.Image = My.Resources.Dice_4
    PicDie2.Image = My.Resources.Dice_3

  End Sub

  Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
    'Restart game
    Call Setup()

  End Sub

  Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
    'Closes the window
    Me.Close()

  End Sub

  Private Sub BtnRoll_Click(sender As Object, e As EventArgs) Handles BtnRoll.Click
    'Plays the Craps game
    Dim intDie1 As Integer
    Dim intDie2 As Integer
    Dim intTotal As Integer  'Sum of die1 and die2
    Dim StrOut As String = ""

    'Check if game is over
    If BolGameOver Then
      MsgBox("Game over. 'Hit New' Game to play.")
      Exit Sub
    End If

    'Randomize the dice
    Randomize()
    intDie1 = Int(Rnd() * 6) + 1
    intDie2 = Int(Rnd() * 6) + 1
    'Console.WriteLine("IntDie1: " & intDie1 &
    '                  "  IntDie2: " & intDie2)
    intTotal = intDie1 + intDie2
    Call DisplayDice(intDie1, intDie2)

    'Determine what happened
    IntTurnNum += 1
    StrOut &= "Turn#: " & IntTurnNum & vbCrLf
    StrOut &= "You rolled: " & intTotal & vbCrLf
    If IntTurnNum = 1 Then
      'first roll
      Select Case intTotal
        Case 2, 3, 12
          StrOut &= "You Lost!!" & vbCrLf
          BolGameOver = True
        Case 7, 11
          StrOut &= "You Won!!" & vbCrLf
          BolGameOver = True
        Case Else
          IntPointToGet = intTotal
          StrOut &= "Point to get: " & IntPointToGet & vbCrLf
      End Select
    Else
      Select Case intTotal
        Case IntPointToGet
          StrOut &= "You Won!!" & vbCrLf
          BolGameOver = True
        Case 7
          StrOut &= "You Lost!!" & vbCrLf
          BolGameOver = True
        Case Else
          StrOut &= "Point to get: " & IntPointToGet & vbCrLf
      End Select
    End If

    TxtOut.Text &= StrOut
    'Need to move cursor to end of textbox.
    TxtOut.SelectionLength = TxtOut.Text.Length
    TxtOut.ScrollToCaret()

  End Sub

  Private Sub DisplayDice(ByVal Int1 As Integer,
                          ByVal Int2 As Integer)
    'Display the rolled dice
    Select Case Int1
      Case = 1
        PicDie1.Image = My.Resources.Dice_1
      Case = 2
        PicDie1.Image = My.Resources.Dice_2
      Case = 3
        PicDie1.Image = My.Resources.Dice_3
      Case = 4
        PicDie1.Image = My.Resources.Dice_4
      Case = 5
        PicDie1.Image = My.Resources.Dice_5
      Case = 6
        PicDie1.Image = My.Resources.Dice_6
    End Select
    Select Case Int2
      Case = 1
        PicDie2.Image = My.Resources.Dice_1
      Case = 2
        PicDie2.Image = My.Resources.Dice_2
      Case = 3
        PicDie2.Image = My.Resources.Dice_3
      Case = 4
        PicDie2.Image = My.Resources.Dice_4
      Case = 5
        PicDie2.Image = My.Resources.Dice_5
      Case = 6
        PicDie2.Image = My.Resources.Dice_6
    End Select

  End Sub

End Class
