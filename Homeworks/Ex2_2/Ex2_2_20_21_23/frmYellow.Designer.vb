<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYellow
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
        Me.lblAlias = New System.Windows.Forms.Label()
        Me.lstYellow = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblAlias
        '
        Me.lblAlias.AutoSize = True
        Me.lblAlias.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlias.Location = New System.Drawing.Point(13, 13)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(48, 17)
        Me.lblAlias.TabIndex = 0
        Me.lblAlias.Text = "ALIAS"
        '
        'lstYellow
        '
        Me.lstYellow.BackColor = System.Drawing.Color.Yellow
        Me.lstYellow.FormattingEnabled = True
        Me.lstYellow.ItemHeight = 16
        Me.lstYellow.Location = New System.Drawing.Point(139, 13)
        Me.lstYellow.Name = "lstYellow"
        Me.lstYellow.Size = New System.Drawing.Size(120, 84)
        Me.lstYellow.TabIndex = 1
        '
        'frmYellow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.lstYellow)
        Me.Controls.Add(Me.lblAlias)
        Me.Name = "frmYellow"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAlias As Label
    Friend WithEvents lstYellow As ListBox
End Class
