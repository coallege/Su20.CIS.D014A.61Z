<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPp4_2_1
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
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSqrt
        '
        Me.btnSqrt.Location = New System.Drawing.Point(20, 64)
        Me.btnSqrt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(164, 39)
        Me.btnSqrt.TabIndex = 0
        Me.btnSqrt.Text = "Square Root"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(20, 20)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(164, 30)
        Me.txtNumber.TabIndex = 1
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmEx4_2_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 116)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnSqrt)
        Me.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmEx4_2_1"
        Me.Text = "Ex4_2_1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSqrt As Button
    Friend WithEvents txtNumber As TextBox
End Class
