<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDemoWeek2_Tuesday
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
        Me.LblMiles = New System.Windows.Forms.Label()
        Me.TxtMiles = New System.Windows.Forms.TextBox()
        Me.TxtYards = New System.Windows.Forms.TextBox()
        Me.LblYards = New System.Windows.Forms.Label()
        Me.TxtFeet = New System.Windows.Forms.TextBox()
        Me.LblFeet = New System.Windows.Forms.Label()
        Me.TxtInches = New System.Windows.Forms.TextBox()
        Me.LblInches = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.LstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LblMiles
        '
        Me.LblMiles.AutoSize = True
        Me.LblMiles.Location = New System.Drawing.Point(32, 31)
        Me.LblMiles.Name = "LblMiles"
        Me.LblMiles.Size = New System.Drawing.Size(45, 20)
        Me.LblMiles.TabIndex = 0
        Me.LblMiles.Text = "&Miles"
        '
        'TxtMiles
        '
        Me.TxtMiles.Location = New System.Drawing.Point(132, 27)
        Me.TxtMiles.Name = "TxtMiles"
        Me.TxtMiles.Size = New System.Drawing.Size(146, 26)
        Me.TxtMiles.TabIndex = 1
        '
        'TxtYards
        '
        Me.TxtYards.Location = New System.Drawing.Point(132, 72)
        Me.TxtYards.Name = "TxtYards"
        Me.TxtYards.Size = New System.Drawing.Size(146, 26)
        Me.TxtYards.TabIndex = 3
        '
        'LblYards
        '
        Me.LblYards.AutoSize = True
        Me.LblYards.Location = New System.Drawing.Point(32, 76)
        Me.LblYards.Name = "LblYards"
        Me.LblYards.Size = New System.Drawing.Size(51, 20)
        Me.LblYards.TabIndex = 2
        Me.LblYards.Text = "&Yards"
        '
        'TxtFeet
        '
        Me.TxtFeet.Location = New System.Drawing.Point(132, 114)
        Me.TxtFeet.Name = "TxtFeet"
        Me.TxtFeet.Size = New System.Drawing.Size(146, 26)
        Me.TxtFeet.TabIndex = 5
        '
        'LblFeet
        '
        Me.LblFeet.AutoSize = True
        Me.LblFeet.Location = New System.Drawing.Point(32, 118)
        Me.LblFeet.Name = "LblFeet"
        Me.LblFeet.Size = New System.Drawing.Size(42, 20)
        Me.LblFeet.TabIndex = 4
        Me.LblFeet.Text = "&Feet"
        '
        'TxtInches
        '
        Me.TxtInches.Location = New System.Drawing.Point(132, 157)
        Me.TxtInches.Name = "TxtInches"
        Me.TxtInches.Size = New System.Drawing.Size(146, 26)
        Me.TxtInches.TabIndex = 7
        '
        'LblInches
        '
        Me.LblInches.AutoSize = True
        Me.LblInches.Location = New System.Drawing.Point(32, 161)
        Me.LblInches.Name = "LblInches"
        Me.LblInches.Size = New System.Drawing.Size(57, 20)
        Me.LblInches.TabIndex = 6
        Me.LblInches.Text = "&Inches"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(132, 214)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(145, 47)
        Me.BtnCalculate.TabIndex = 8
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'LstOutput
        '
        Me.LstOutput.FormattingEnabled = True
        Me.LstOutput.ItemHeight = 20
        Me.LstOutput.Location = New System.Drawing.Point(37, 280)
        Me.LstOutput.Name = "LstOutput"
        Me.LstOutput.Size = New System.Drawing.Size(241, 84)
        Me.LstOutput.TabIndex = 9
        '
        'FrmDemoWeek2_Tuesday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 398)
        Me.Controls.Add(Me.LstOutput)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.TxtInches)
        Me.Controls.Add(Me.LblInches)
        Me.Controls.Add(Me.TxtFeet)
        Me.Controls.Add(Me.LblFeet)
        Me.Controls.Add(Me.TxtYards)
        Me.Controls.Add(Me.LblYards)
        Me.Controls.Add(Me.TxtMiles)
        Me.Controls.Add(Me.LblMiles)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmDemoWeek2_Tuesday"
        Me.Text = "Project1 Lenth Converions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMiles As Label
    Friend WithEvents TxtMiles As TextBox
    Friend WithEvents TxtYards As TextBox
    Friend WithEvents LblYards As Label
    Friend WithEvents TxtFeet As TextBox
    Friend WithEvents LblFeet As Label
    Friend WithEvents TxtInches As TextBox
    Friend WithEvents LblInches As Label
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents LstOutput As ListBox
End Class
