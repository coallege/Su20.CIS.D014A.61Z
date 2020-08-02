<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject3Main
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYearPurchased = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblYearsLeft = New System.Windows.Forms.Label()
        Me.txtYearsLeft = New System.Windows.Forms.TextBox()
        Me.grpMethod = New System.Windows.Forms.GroupBox()
        Me.radDoubleDeclining = New System.Windows.Forms.RadioButton()
        Me.radStraightLine = New System.Windows.Forms.RadioButton()
        Me.tblButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.grpMethod.SuspendLayout()
        Me.tblButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(13, 8)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(478, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Depreciation to a Salvage Value of Zero"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(34, 49)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(87, 18)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "&Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(164, 46)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(305, 24)
        Me.txtDescription.TabIndex = 2
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(21, 79)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(117, 18)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "&Year Purchased:"
        '
        'txtYearPurchased
        '
        Me.txtYearPurchased.Location = New System.Drawing.Point(164, 78)
        Me.txtYearPurchased.Name = "txtYearPurchased"
        Me.txtYearPurchased.Size = New System.Drawing.Size(180, 24)
        Me.txtYearPurchased.TabIndex = 4
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(15, 112)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(130, 18)
        Me.lblAmount.TabIndex = 5
        Me.lblAmount.Text = "&Purchase Amount:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(164, 112)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(180, 24)
        Me.txtAmount.TabIndex = 6
        '
        'lblYearsLeft
        '
        Me.lblYearsLeft.AutoSize = True
        Me.lblYearsLeft.Location = New System.Drawing.Point(12, 142)
        Me.lblYearsLeft.Name = "lblYearsLeft"
        Me.lblYearsLeft.Size = New System.Drawing.Size(138, 36)
        Me.lblYearsLeft.TabIndex = 7
        Me.lblYearsLeft.Text = "&Years to Depreciate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Over:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblYearsLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtYearsLeft
        '
        Me.txtYearsLeft.Location = New System.Drawing.Point(164, 149)
        Me.txtYearsLeft.Name = "txtYearsLeft"
        Me.txtYearsLeft.Size = New System.Drawing.Size(180, 24)
        Me.txtYearsLeft.TabIndex = 8
        '
        'grpMethod
        '
        Me.grpMethod.Controls.Add(Me.radDoubleDeclining)
        Me.grpMethod.Controls.Add(Me.radStraightLine)
        Me.grpMethod.Location = New System.Drawing.Point(107, 200)
        Me.grpMethod.Name = "grpMethod"
        Me.grpMethod.Size = New System.Drawing.Size(280, 91)
        Me.grpMethod.TabIndex = 9
        Me.grpMethod.TabStop = False
        Me.grpMethod.Text = "Select a Depreciation Method"
        '
        'radDoubleDeclining
        '
        Me.radDoubleDeclining.AutoSize = True
        Me.radDoubleDeclining.Location = New System.Drawing.Point(19, 52)
        Me.radDoubleDeclining.Name = "radDoubleDeclining"
        Me.radDoubleDeclining.Size = New System.Drawing.Size(223, 22)
        Me.radDoubleDeclining.TabIndex = 1
        Me.radDoubleDeclining.TabStop = True
        Me.radDoubleDeclining.Text = "Double-declining Method (2/n)"
        Me.radDoubleDeclining.UseVisualStyleBackColor = True
        '
        'radStraightLine
        '
        Me.radStraightLine.AutoSize = True
        Me.radStraightLine.Checked = True
        Me.radStraightLine.Location = New System.Drawing.Point(19, 24)
        Me.radStraightLine.Name = "radStraightLine"
        Me.radStraightLine.Size = New System.Drawing.Size(191, 22)
        Me.radStraightLine.TabIndex = 0
        Me.radStraightLine.TabStop = True
        Me.radStraightLine.Text = "Straight-line Method (1/n)"
        Me.radStraightLine.UseVisualStyleBackColor = True
        '
        'tblButtons
        '
        Me.tblButtons.ColumnCount = 3
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblButtons.Controls.Add(Me.btnClose, 2, 0)
        Me.tblButtons.Controls.Add(Me.btnRestart, 1, 0)
        Me.tblButtons.Controls.Add(Me.btnCalc, 0, 0)
        Me.tblButtons.Location = New System.Drawing.Point(12, 297)
        Me.tblButtons.Name = "tblButtons"
        Me.tblButtons.RowCount = 1
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblButtons.Size = New System.Drawing.Size(479, 71)
        Me.tblButtons.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Location = New System.Drawing.Point(331, 18)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 34)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRestart.Location = New System.Drawing.Point(171, 18)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(135, 34)
        Me.btnRestart.TabIndex = 1
        Me.btnRestart.Text = "&Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalc.Location = New System.Drawing.Point(12, 18)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(135, 34)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Show Calculation"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmProject3Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 380)
        Me.Controls.Add(Me.tblButtons)
        Me.Controls.Add(Me.grpMethod)
        Me.Controls.Add(Me.txtYearsLeft)
        Me.Controls.Add(Me.lblYearsLeft)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtYearPurchased)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmProject3Main"
        Me.Text = "Project3: Depreciation to a Salvage Value of Zero"
        Me.grpMethod.ResumeLayout(False)
        Me.grpMethod.PerformLayout()
        Me.tblButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents txtYearPurchased As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblYearsLeft As Label
    Friend WithEvents txtYearsLeft As TextBox
    Friend WithEvents grpMethod As GroupBox
    Friend WithEvents radDoubleDeclining As RadioButton
    Friend WithEvents radStraightLine As RadioButton
    Friend WithEvents tblButtons As TableLayoutPanel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnCalc As Button
End Class
