<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx6_3_13
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
        Me.lstRoseBowl = New System.Windows.Forms.ListBox()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstRoseBowl
        '
        Me.lstRoseBowl.FormattingEnabled = True
        Me.lstRoseBowl.ItemHeight = 18
        Me.lstRoseBowl.Items.AddRange(New Object() {"Michigan", "Washington State", "Oregon", "Mare Island", "Great Lakes", "Harvard", "California", "California", "USC", "Washington", "Notre Dame", "Alabama", "Stanford", "Stanford", "Georgia Tech", "USC", "Alabama", "USC", "USC", "Columbia", "Alabama", "Pittsburgh", "California", "USC", "USC", "Stanford", "Oregon State", "Georgia", "USC", "USC", "Alabama", "Illinois", "Michigan", "Northwestern", "Ohio State", "Michigan", "Illinois", "USC", "Michigan State", "Ohio State", "Michigan State", "Iowa", "Ohio State", "Iowa", "Washington", "Washington", "Minnesota", "USC", "Illinois", "Michigan", "UCLA", "Purdue", "USC", "Ohio State", "USC", "Stanford", "Stanford", "USC", "Ohio State", "USC", "UCLA", "USC", "Washington", "USC", "USC", "Michigan", "Washington", "UCLA", "UCLA", "USC", "UCLA", "Arizona State", "Michigan State", "Michigan", "USC", "Washington", "Washington", "Michigan", "Wisconsin", "Penn State", "USC", "Ohio State", "Michigan", "Wisconsin", "Wisconsin", "Washington", "Miami", "Oklahoma", "USC", "Texas", "Texas", "USC", "USC", "USC", "Ohio State", "TCU", "Oregon", "Stanford"})
        Me.lstRoseBowl.Location = New System.Drawing.Point(13, 13)
        Me.lstRoseBowl.Name = "lstRoseBowl"
        Me.lstRoseBowl.Size = New System.Drawing.Size(120, 238)
        Me.lstRoseBowl.TabIndex = 0
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(148, 13)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(124, 77)
        Me.btnCount.TabIndex = 1
        Me.btnCount.Text = "Count Number of Games Won by USC"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(148, 113)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(124, 24)
        Me.txtOutput.TabIndex = 2
        Me.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmEx6_3_13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.lstRoseBowl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEx6_3_13"
        Me.Text = "Ex6_3_13"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRoseBowl As ListBox
    Friend WithEvents btnCount As Button
    Friend WithEvents txtOutput As TextBox
End Class
