<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx6_3_1_5
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
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 19
        Me.lstBox.Items.AddRange(New Object() {"Bach", "Beethoven", "Chopin", "Mozart", "Tchaikovsky"})
        Me.lstBox.Location = New System.Drawing.Point(20, 19)
        Me.lstBox.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(114, 99)
        Me.lstBox.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(164, 35)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(93, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Ex6_3_1"
        Me.btn1.UseMnemonic = False
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(164, 80)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(93, 23)
        Me.btn5.TabIndex = 2
        Me.btn5.Text = "Ex6_3_5"
        Me.btn5.UseMnemonic = False
        Me.btn5.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(288, 54)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(148, 26)
        Me.txtOutput.TabIndex = 3
        '
        'frmEx6_3_1_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 145)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lstBox)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEx6_3_1_5"
        Me.Text = "Ex6_3_1_5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBox As ListBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents txtOutput As TextBox
End Class
