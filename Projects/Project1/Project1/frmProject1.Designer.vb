<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProject1))
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.lblYards = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.lblFeet = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtYards = New System.Windows.Forms.TextBox()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.Location = New System.Drawing.Point(14, 15)
        Me.lblMiles.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(72, 19)
        Me.lblMiles.TabIndex = 0
        Me.lblMiles.Text = "&Miles: "
        '
        'lblYards
        '
        Me.lblYards.AutoSize = True
        Me.lblYards.Location = New System.Drawing.Point(14, 52)
        Me.lblYards.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblYards.Name = "lblYards"
        Me.lblYards.Size = New System.Drawing.Size(72, 19)
        Me.lblYards.TabIndex = 2
        Me.lblYards.Text = "&Yards: "
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Location = New System.Drawing.Point(14, 130)
        Me.lblInches.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(81, 19)
        Me.lblInches.TabIndex = 6
        Me.lblInches.Text = "&Inches: "
        '
        'lblFeet
        '
        Me.lblFeet.AutoSize = True
        Me.lblFeet.Location = New System.Drawing.Point(14, 92)
        Me.lblFeet.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFeet.Name = "lblFeet"
        Me.lblFeet.Size = New System.Drawing.Size(63, 19)
        Me.lblFeet.TabIndex = 4
        Me.lblFeet.Text = "&Feet: "
        '
        'txtMiles
        '
        Me.txtMiles.AccessibleName = "Miles"
        Me.txtMiles.Location = New System.Drawing.Point(94, 12)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(125, 26)
        Me.txtMiles.TabIndex = 1
        Me.txtMiles.Text = "0"
        '
        'txtYards
        '
        Me.txtYards.AccessibleName = "Yards"
        Me.txtYards.Location = New System.Drawing.Point(94, 50)
        Me.txtYards.Name = "txtYards"
        Me.txtYards.Size = New System.Drawing.Size(125, 26)
        Me.txtYards.TabIndex = 3
        Me.txtYards.Text = "0"
        '
        'txtFeet
        '
        Me.txtFeet.AccessibleName = "Feet"
        Me.txtFeet.Location = New System.Drawing.Point(94, 86)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(125, 26)
        Me.txtFeet.TabIndex = 5
        Me.txtFeet.Text = "0"
        '
        'txtInches
        '
        Me.txtInches.AccessibleName = "Inches"
        Me.txtInches.Location = New System.Drawing.Point(94, 125)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(125, 26)
        Me.txtInches.TabIndex = 7
        Me.txtInches.Text = "0"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(244, 63)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(194, 45)
        Me.btnConvert.TabIndex = 8
        Me.btnConvert.Text = "&Convert To Meteric"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.HorizontalScrollbar = True
        Me.lstOutput.ItemHeight = 19
        Me.lstOutput.Location = New System.Drawing.Point(94, 169)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(344, 80)
        Me.lstOutput.TabIndex = 9
        '
        'frmProject1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 271)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.txtYards)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lblFeet)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.lblYards)
        Me.Controls.Add(Me.lblMiles)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProject1"
        Me.Text = "Project1: Length Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMiles As Label
    Friend WithEvents lblYards As Label
    Friend WithEvents lblInches As Label
    Friend WithEvents lblFeet As Label
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtYards As TextBox
    Friend WithEvents txtFeet As TextBox
    Friend WithEvents txtInches As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents lstOutput As ListBox
End Class
