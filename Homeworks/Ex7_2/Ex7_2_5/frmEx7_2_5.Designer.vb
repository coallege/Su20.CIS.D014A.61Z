﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx7_2_5
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 13)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(99, 39)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(13, 61)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(98, 34)
        Me.txtOutput.TabIndex = 1
        '
        'frmEx7_2_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(122, 104)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEx7_2_5"
        Me.Text = "Ex7_2_5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtOutput As TextBox
End Class
