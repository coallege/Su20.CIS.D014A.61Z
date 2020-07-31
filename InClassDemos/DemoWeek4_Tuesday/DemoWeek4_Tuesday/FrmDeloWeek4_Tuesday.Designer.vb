<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeloWeek4_Tuesday
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.LblStartAt = New System.Windows.Forms.Label()
        Me.TxtStartAt = New System.Windows.Forms.TextBox()
        Me.TxtEndAt = New System.Windows.Forms.TextBox()
        Me.LblEndAt = New System.Windows.Forms.Label()
        Me.TxtIncDec = New System.Windows.Forms.TextBox()
        Me.LblIncrDecr = New System.Windows.Forms.Label()
        Me.BtnDoWhile = New System.Windows.Forms.Button()
        Me.BtnForNext = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtOut = New System.Windows.Forms.TextBox()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblStartAt
        '
        Me.LblStartAt.AutoSize = True
        Me.LblStartAt.Location = New System.Drawing.Point(32, 29)
        Me.LblStartAt.Name = "LblStartAt"
        Me.LblStartAt.Size = New System.Drawing.Size(68, 20)
        Me.LblStartAt.TabIndex = 0
        Me.LblStartAt.Text = "Start At:"
        '
        'TxtStartAt
        '
        Me.TxtStartAt.Location = New System.Drawing.Point(142, 26)
        Me.TxtStartAt.Name = "TxtStartAt"
        Me.TxtStartAt.Size = New System.Drawing.Size(180, 26)
        Me.TxtStartAt.TabIndex = 1
        '
        'TxtEndAt
        '
        Me.TxtEndAt.Location = New System.Drawing.Point(142, 69)
        Me.TxtEndAt.Name = "TxtEndAt"
        Me.TxtEndAt.Size = New System.Drawing.Size(180, 26)
        Me.TxtEndAt.TabIndex = 3
        '
        'LblEndAt
        '
        Me.LblEndAt.AutoSize = True
        Me.LblEndAt.Location = New System.Drawing.Point(32, 72)
        Me.LblEndAt.Name = "LblEndAt"
        Me.LblEndAt.Size = New System.Drawing.Size(62, 20)
        Me.LblEndAt.TabIndex = 2
        Me.LblEndAt.Text = "End At:"
        '
        'TxtIncDec
        '
        Me.TxtIncDec.Location = New System.Drawing.Point(142, 113)
        Me.TxtIncDec.Name = "TxtIncDec"
        Me.TxtIncDec.Size = New System.Drawing.Size(180, 26)
        Me.TxtIncDec.TabIndex = 5
        '
        'LblIncrDecr
        '
        Me.LblIncrDecr.AutoSize = True
        Me.LblIncrDecr.Location = New System.Drawing.Point(32, 116)
        Me.LblIncrDecr.Name = "LblIncrDecr"
        Me.LblIncrDecr.Size = New System.Drawing.Size(113, 20)
        Me.LblIncrDecr.TabIndex = 4
        Me.LblIncrDecr.Text = "In(de)crement:"
        '
        'BtnDoWhile
        '
        Me.BtnDoWhile.Location = New System.Drawing.Point(35, 166)
        Me.BtnDoWhile.Name = "BtnDoWhile"
        Me.BtnDoWhile.Size = New System.Drawing.Size(80, 60)
        Me.BtnDoWhile.TabIndex = 6
        Me.BtnDoWhile.Text = "Do While"
        Me.BtnDoWhile.UseVisualStyleBackColor = True
        '
        'BtnForNext
        '
        Me.BtnForNext.Location = New System.Drawing.Point(154, 166)
        Me.BtnForNext.Name = "BtnForNext"
        Me.BtnForNext.Size = New System.Drawing.Size(80, 60)
        Me.BtnForNext.TabIndex = 7
        Me.BtnForNext.Text = "For Next"
        Me.BtnForNext.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(268, 166)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(80, 60)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TxtOut
        '
        Me.TxtOut.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOut.Location = New System.Drawing.Point(36, 301)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtOut.Size = New System.Drawing.Size(306, 125)
        Me.TxtOut.TabIndex = 9
        Me.TxtOut.Text = "         1         2         3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "123456789012345678901234567890"
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(12, 246)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(29, 16)
        Me.LblInfo.TabIndex = 10
        Me.LblInfo.Text = "Info"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(268, 267)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 28)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        Me.BtnCancel.Visible = False
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(344, 28)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(23, 110)
        Me.BtnReset.TabIndex = 12
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmDeloWeek4_Tuesday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 438)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.TxtOut)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnForNext)
        Me.Controls.Add(Me.BtnDoWhile)
        Me.Controls.Add(Me.TxtIncDec)
        Me.Controls.Add(Me.LblIncrDecr)
        Me.Controls.Add(Me.TxtEndAt)
        Me.Controls.Add(Me.LblEndAt)
        Me.Controls.Add(Me.TxtStartAt)
        Me.Controls.Add(Me.LblStartAt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmDeloWeek4_Tuesday"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblStartAt As Label
    Friend WithEvents TxtStartAt As TextBox
    Friend WithEvents TxtEndAt As TextBox
    Friend WithEvents LblEndAt As Label
    Friend WithEvents TxtIncDec As TextBox
    Friend WithEvents LblIncrDecr As Label
    Friend WithEvents BtnDoWhile As Button
    Friend WithEvents BtnForNext As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents TxtOut As TextBox
    Friend WithEvents LblInfo As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnReset As Button
End Class
