<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(69, 19)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(137, 94)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Button 1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(69, 138)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(137, 94)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Button 2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
End Class
