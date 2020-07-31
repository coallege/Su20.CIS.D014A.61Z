<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx7_2_9_13
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
        Me.btnDisplay9 = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnDisplay13 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDisplay9
        '
        Me.btnDisplay9.Location = New System.Drawing.Point(13, 13)
        Me.btnDisplay9.Name = "btnDisplay9"
        Me.btnDisplay9.Size = New System.Drawing.Size(98, 35)
        Me.btnDisplay9.TabIndex = 0
        Me.btnDisplay9.Text = "Display 9"
        Me.btnDisplay9.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 22
        Me.lstOutput.Location = New System.Drawing.Point(13, 60)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(298, 92)
        Me.lstOutput.TabIndex = 1
        '
        'btnDisplay13
        '
        Me.btnDisplay13.Location = New System.Drawing.Point(117, 13)
        Me.btnDisplay13.Name = "btnDisplay13"
        Me.btnDisplay13.Size = New System.Drawing.Size(112, 35)
        Me.btnDisplay13.TabIndex = 2
        Me.btnDisplay13.Text = "Display 13"
        Me.btnDisplay13.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(236, 13)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 35)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmEx7_2_9_13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 167)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDisplay13)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnDisplay9)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEx7_2_9_13"
        Me.Text = "Ex7_2_9 and Ex7_2_13"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDisplay9 As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnDisplay13 As Button
    Friend WithEvents btnReset As Button
End Class
