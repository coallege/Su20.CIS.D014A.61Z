<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDemoWeek1_Tuesday
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()>
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
      Me.BtnClose = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'BtnClose
      '
      Me.BtnClose.BackColor = System.Drawing.SystemColors.InactiveCaption
      Me.BtnClose.Location = New System.Drawing.Point(85, 118)
      Me.BtnClose.Name = "BtnClose"
      Me.BtnClose.Size = New System.Drawing.Size(217, 117)
      Me.BtnClose.TabIndex = 0
      Me.BtnClose.Text = "Click to close this window"
      Me.BtnClose.UseVisualStyleBackColor = False
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(388, 364)
      Me.Controls.Add(Me.BtnClose)
      Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.Name = "Form1"
      Me.Text = "Demo Week1 Tuesday"
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents BtnClose As Button
End Class
