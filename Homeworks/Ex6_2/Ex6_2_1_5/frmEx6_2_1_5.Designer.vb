<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx6_2_1_5
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
        Me.pgeEx6_2_5 = New System.Windows.Forms.TabPage()
        Me.btnDisplay5 = New System.Windows.Forms.Button()
        Me.pgeEx6_2_1 = New System.Windows.Forms.TabPage()
        Me.btnDisplay1 = New System.Windows.Forms.Button()
        Me.tabExSelector = New System.Windows.Forms.TabControl()
        Me.pgeEx6_2_5.SuspendLayout()
        Me.pgeEx6_2_1.SuspendLayout()
        Me.tabExSelector.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 16
        Me.lstBox.Location = New System.Drawing.Point(18, 154)
        Me.lstBox.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(224, 84)
        Me.lstBox.TabIndex = 1
        '
        'pgeEx6_2_5
        '
        Me.pgeEx6_2_5.Controls.Add(Me.btnDisplay5)
        Me.pgeEx6_2_5.Location = New System.Drawing.Point(4, 25)
        Me.pgeEx6_2_5.Margin = New System.Windows.Forms.Padding(4)
        Me.pgeEx6_2_5.Name = "pgeEx6_2_5"
        Me.pgeEx6_2_5.Padding = New System.Windows.Forms.Padding(4)
        Me.pgeEx6_2_5.Size = New System.Drawing.Size(221, 104)
        Me.pgeEx6_2_5.TabIndex = 2
        Me.pgeEx6_2_5.Text = "Ex6_2_5"
        Me.pgeEx6_2_5.UseVisualStyleBackColor = True
        '
        'btnDisplay5
        '
        Me.btnDisplay5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDisplay5.Location = New System.Drawing.Point(4, 4)
        Me.btnDisplay5.Name = "btnDisplay5"
        Me.btnDisplay5.Size = New System.Drawing.Size(213, 96)
        Me.btnDisplay5.TabIndex = 0
        Me.btnDisplay5.Text = "Display Ex6_2_5"
        Me.btnDisplay5.UseVisualStyleBackColor = True
        '
        'pgeEx6_2_1
        '
        Me.pgeEx6_2_1.Controls.Add(Me.btnDisplay1)
        Me.pgeEx6_2_1.Location = New System.Drawing.Point(4, 25)
        Me.pgeEx6_2_1.Margin = New System.Windows.Forms.Padding(4)
        Me.pgeEx6_2_1.Name = "pgeEx6_2_1"
        Me.pgeEx6_2_1.Padding = New System.Windows.Forms.Padding(4)
        Me.pgeEx6_2_1.Size = New System.Drawing.Size(221, 94)
        Me.pgeEx6_2_1.TabIndex = 0
        Me.pgeEx6_2_1.Text = "Ex6_2_1"
        Me.pgeEx6_2_1.UseVisualStyleBackColor = True
        '
        'btnDisplay1
        '
        Me.btnDisplay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDisplay1.Location = New System.Drawing.Point(4, 4)
        Me.btnDisplay1.Name = "btnDisplay1"
        Me.btnDisplay1.Size = New System.Drawing.Size(213, 86)
        Me.btnDisplay1.TabIndex = 0
        Me.btnDisplay1.Text = "Display Ex6_2_1"
        Me.btnDisplay1.UseVisualStyleBackColor = True
        '
        'tabExSelector
        '
        Me.tabExSelector.Controls.Add(Me.pgeEx6_2_1)
        Me.tabExSelector.Controls.Add(Me.pgeEx6_2_5)
        Me.tabExSelector.Location = New System.Drawing.Point(16, 15)
        Me.tabExSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.tabExSelector.Name = "tabExSelector"
        Me.tabExSelector.SelectedIndex = 0
        Me.tabExSelector.Size = New System.Drawing.Size(229, 123)
        Me.tabExSelector.TabIndex = 0
        '
        'frmEx6_2_1_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 254)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.tabExSelector)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmEx6_2_1_5"
        Me.Text = "Ex6_2_1_5"
        Me.pgeEx6_2_5.ResumeLayout(False)
        Me.pgeEx6_2_1.ResumeLayout(False)
        Me.tabExSelector.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstBox As ListBox
    Friend WithEvents pgeEx6_2_5 As TabPage
    Friend WithEvents btnDisplay5 As Button
    Friend WithEvents pgeEx6_2_1 As TabPage
    Friend WithEvents btnDisplay1 As Button
    Friend WithEvents tabExSelector As TabControl
End Class
