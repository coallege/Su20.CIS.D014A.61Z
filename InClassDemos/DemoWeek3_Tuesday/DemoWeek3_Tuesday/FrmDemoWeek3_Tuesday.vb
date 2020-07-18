Public Class FrmDemoWeek3_Tuesday
  '************************************************
  '*** Program: DemoWeek3_Tuesday - sample IF and
  '***          sample for Project2
  '*** Author : Art Linn
  '*** Date   : 7/14/2020
  '************************************************

  Private Sub FrmDemoWeek3_Tuesday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Setup program info
    RadGrpM_Large.Text &= " ($" & RadGrpM_Large.Tag & ")"
    RadGrpM_Medium.Text &= " ($" & RadGrpM_Medium.Tag & ")"
    RadGrpM_Small.Text &= " ($" & RadGrpM_Small.Tag & ")"
    RadGrpW_Large.Text &= " ($" & RadGrpW_Large.Tag & ")"
    RadGrpW_Medium.Text &= " ($" & RadGrpW_Medium.Tag & ")"
    RadGrpW_Small.Text &= " ($" & RadGrpW_Small.Tag & ")"
    LblInfo.Text = "Ready for Order"

    ChkWomens.Checked = False
    ChkMens.Checked = False

  End Sub

  Private Sub ChkWomens_CheckedChanged(sender As Object, e As EventArgs) Handles ChkWomens.CheckedChanged
    'Checking or unchecking the checkbox
    If ChkWomens.Checked = True Then
      GrpWSizes.Visible = True
      RadGrpW_Medium.Checked = True
    Else
      GrpWSizes.Visible = False
    End If

  End Sub

  Private Sub ChkMens_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMens.CheckedChanged
    'Checking or unchecking the checkbox
    If ChkMens.Checked = True Then
      GrpMSizes.Visible = True
      RadGrpM_Medium.Checked = True
    Else
      GrpMSizes.Visible = False
    End If

  End Sub

  Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
    'Closes the window
    Me.Close()

  End Sub

  Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
    'Order the shoes
    Dim DblAmount As Double = 0  'Cost of the order

    LblInfo.Text = "Processing Order..."
    'Are any checkboxes checked?
    If ChkMens.Checked = False And
       ChkWomens.Checked = False Then
      LblInfo.Text = "Must Check a Box"
      Exit Sub
    End If

    'Check for Womens
    If ChkWomens.Checked = True Then
      If RadGrpW_Small.Checked = True Then
        DblAmount += RadGrpW_Small.Tag
      End If
      If RadGrpW_Medium.Checked = True Then
        DblAmount += RadGrpW_Medium.Tag
      End If
      If RadGrpW_Large.Checked = True Then
        DblAmount += RadGrpW_Large.Tag
      End If
    End If
    'Check for Mens
    If ChkMens.Checked = True Then
      If RadGrpM_Small.Checked = True Then
        DblAmount += RadGrpM_Small.Tag
      End If
      If RadGrpM_Medium.Checked = True Then
        DblAmount += RadGrpM_Medium.Tag
      End If
      If RadGrpM_Large.Checked = True Then
        DblAmount += RadGrpM_Large.Tag
      End If
    End If

    LblInfo.Text = "Order amount: " & FormatCurrency(DblAmount)

  End Sub

  Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
    'Resets the menu
    LblInfo.Text = "Ready for Order"
    ChkWomens.Checked = False
    ChkMens.Checked = False

  End Sub
End Class
