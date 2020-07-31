Public Class FrmDeloWeek4_Tuesday
  '***************************************************
  '*** Program: Demo iteration, DoEvents, Zone formats
  '***           constants
  '*** Author : Art Linn
  '*** Date   : 7/21/2020
  '***************************************************
  'Class level variables and constants
  Dim BolContinue As Boolean
  'Should the looping end? Y continue; N end

  Const conOK As String = "OK"
  Const conINCREMENTDEFAULT As Integer = 1

  Private Sub FrmDeloWeek4_Tuesday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Setup program
    Call Reset()

  End Sub

  Private Sub Reset()
    'Reset program
    TxtStartAt.Text = ""
    TxtEndAt.Text = ""
    TxtIncDec.Text = conINCREMENTDEFAULT
    LblInfo.Text = ""
    TxtOut.Text = ""
    BolContinue = False

  End Sub

  Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
    'Reset program
    Call Reset()

  End Sub

  Private Sub BtnDoWhile_Click(sender As Object, e As EventArgs) Handles BtnDoWhile.Click
    'Do While example
    Dim DblStartAt As Double
    Dim DblEndAt As Double
    Dim LngIncDec As Long
    Dim StrRet As String
    Dim i As Double         'Loop counter

    'Edit the user's data
    StrRet = CheckData(DblStartAt, DblEndAt, LngIncDec)
    If StrRet <> conOK Then
      MsgBox(StrRet)
      Exit Sub
    End If

    'Perform the loop
    i = DblStartAt
    If LngIncDec > 0 Then
      'Incrementing 
      LblInfo.Text = "Started: " & Now
      LblInfo.Refresh()
      Do While i <= DblEndAt
        'Do somehing
        LblInfo.Text = "At: " & i
        LblInfo.Refresh()
        i += LngIncDec
      Loop
      LblInfo.Text &= " Ended: " & Now
      LblInfo.Refresh()
    Else
      'decremening
      LblInfo.Text = "Started: " & Now
      Do While i >= DblEndAt
        'Do somehing
        i -= LngIncDec
      Loop
      LblInfo.Text &= " Ended: " & Now
    End If


  End Sub

  Private Function CheckData(ByRef DBLSA As Double,
                             ByRef DblEA As Double,
                             ByRef LngID As Long) _
                             As String
    'Verify the user entered data
    Dim StrRet As String = ""

    'Check StartAt
    If Double.TryParse(TxtStartAt.Text, DBLSA) = False Then
      StrRet &= "Invalid Start At" & vbCrLf
    End If
    If Double.TryParse(TxtEndAt.Text, DblEA) = False Then
      StrRet &= "Invalid End At" & vbCrLf
    End If
    If Long.TryParse(TxtIncDec.Text, LngID) = False Then
      StrRet &= "Invalid In(De)cremet" & vbCrLf
    End If

    If StrRet = "" Then
      Return conOK
    Else
      Return StrRet
    End If

  End Function

  Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
    'Closes the window
    Me.Close()

  End Sub

  Private Sub BtnForNext_Click(sender As Object, e As EventArgs) Handles BtnForNext.Click
    'Looping using For ... Nexe
    Dim DblStartAt As Double
    Dim DblEndAt As Double
    Dim LngIncDec As Long
    Dim StrRet As String
    Dim i As Double         'Loop counter
    Dim StrOut As String
    Dim StrFormat As String = "{0,10}{1,10}{2,10}"

    '         1         2         3
    '123456789012345678901234567890
    '   StartAt     EndAt Increment
    '         1       100         1


    'Edit the user's data
    StrRet = CheckData(DblStartAt, DblEndAt, LngIncDec)
    If StrRet <> conOK Then
      MsgBox(StrRet)
      Exit Sub
    End If

    'Display the user's request
    StrOut = String.Format(StrFormat, "StartAt",
                                   "EndAt", "Increment") & vbCrLf
    StrOut &= String.Format(StrFormat, DblStartAt,
                              DblEndAt, LngIncDec) & vbCrLf
    'Setup the loop
    BolContinue = True
    BtnCancel.Visible = True
    BtnCancel.Focus()
    BtnCancel.Refresh()
    'Perform the loop
    For i = DblStartAt To DblEndAt Step LngIncDec
      If i Mod 10000 = 0 Then
        LblInfo.Text = "At: " & i
        LblInfo.Refresh()
        If BolContinue = False Then
          Exit For
        End If
        Application.DoEvents()
      End If
    Next

    BtnCancel.Visible = False
    LblInfo.Text = "Records Processed:  " & i - 1
    LblInfo.Refresh()

    TxtOut.Text &= StrOut

  End Sub

  Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
    'Cancel the loop
    BolContinue = False

  End Sub

End Class
