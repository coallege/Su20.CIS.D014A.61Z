<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx7_4_1_3_7_9
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnDisplay1 = New System.Windows.Forms.Button()
        Me.btnDisplay3 = New System.Windows.Forms.Button()
        Me.btnDisplay7 = New System.Windows.Forms.Button()
        Me.btnDisplay9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 25
        Me.lstOutput.Location = New System.Drawing.Point(15, 80)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(186, 104)
        Me.lstOutput.TabIndex = 0
        '
        'btnDisplay1
        '
        Me.btnDisplay1.Location = New System.Drawing.Point(15, 12)
        Me.btnDisplay1.Name = "btnDisplay1"
        Me.btnDisplay1.Size = New System.Drawing.Size(42, 50)
        Me.btnDisplay1.TabIndex = 1
        Me.btnDisplay1.Text = "1"
        Me.btnDisplay1.UseVisualStyleBackColor = True
        '
        'btnDisplay3
        '
        Me.btnDisplay3.Location = New System.Drawing.Point(63, 12)
        Me.btnDisplay3.Name = "btnDisplay3"
        Me.btnDisplay3.Size = New System.Drawing.Size(42, 50)
        Me.btnDisplay3.TabIndex = 2
        Me.btnDisplay3.Text = "3"
        Me.btnDisplay3.UseVisualStyleBackColor = True
        '
        'btnDisplay7
        '
        Me.btnDisplay7.Location = New System.Drawing.Point(111, 12)
        Me.btnDisplay7.Name = "btnDisplay7"
        Me.btnDisplay7.Size = New System.Drawing.Size(42, 50)
        Me.btnDisplay7.TabIndex = 3
        Me.btnDisplay7.Text = "7"
        Me.btnDisplay7.UseVisualStyleBackColor = True
        '
        'btnDisplay9
        '
        Me.btnDisplay9.Location = New System.Drawing.Point(159, 12)
        Me.btnDisplay9.Name = "btnDisplay9"
        Me.btnDisplay9.Size = New System.Drawing.Size(42, 50)
        Me.btnDisplay9.TabIndex = 4
        Me.btnDisplay9.Text = "9"
        Me.btnDisplay9.UseVisualStyleBackColor = True
        '
        'frmEx7_4_1_3_7_9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 199)
        Me.Controls.Add(Me.btnDisplay9)
        Me.Controls.Add(Me.btnDisplay7)
        Me.Controls.Add(Me.btnDisplay3)
        Me.Controls.Add(Me.btnDisplay1)
        Me.Controls.Add(Me.lstOutput)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEx7_4_1_3_7_9"
        Me.Text = "Ex7_4_1_3_7_9"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnDisplay1 As Button
    Friend WithEvents btnDisplay3 As Button
    Friend WithEvents btnDisplay7 As Button
    Friend WithEvents btnDisplay9 As Button
End Class
