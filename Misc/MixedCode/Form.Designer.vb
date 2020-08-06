<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnDisplay24 = New System.Windows.Forms.Button()
        Me.btnDisplay36 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 41)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(302, 269)
        Me.txtOutput.TabIndex = 0
        '
        'btnDisplay24
        '
        Me.btnDisplay24.Location = New System.Drawing.Point(12, 12)
        Me.btnDisplay24.Name = "btnDisplay24"
        Me.btnDisplay24.Size = New System.Drawing.Size(142, 23)
        Me.btnDisplay24.TabIndex = 1
        Me.btnDisplay24.Text = "24"
        Me.btnDisplay24.UseVisualStyleBackColor = True
        '
        'btnDisplay36
        '
        Me.btnDisplay36.Location = New System.Drawing.Point(160, 12)
        Me.btnDisplay36.Name = "btnDisplay36"
        Me.btnDisplay36.Size = New System.Drawing.Size(154, 23)
        Me.btnDisplay36.TabIndex = 2
        Me.btnDisplay36.Text = "36"
        Me.btnDisplay36.UseVisualStyleBackColor = True
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 322)
        Me.Controls.Add(Me.btnDisplay36)
        Me.Controls.Add(Me.btnDisplay24)
        Me.Controls.Add(Me.txtOutput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form"
        Me.Text = "Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As Windows.Forms.TextBox
    Friend WithEvents btnDisplay24 As Windows.Forms.Button
    Friend WithEvents btnDisplay36 As Windows.Forms.Button
End Class
