<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDemoWeek2_Thursday
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
        Me.LblFName = New System.Windows.Forms.Label()
        Me.TxtFName = New System.Windows.Forms.TextBox()
        Me.TxtLName = New System.Windows.Forms.TextBox()
        Me.LblLName = New System.Windows.Forms.Label()
        Me.TxtMI = New System.Windows.Forms.TextBox()
        Me.LblMI = New System.Windows.Forms.Label()
        Me.BtnAddName = New System.Windows.Forms.Button()
        Me.BtClrNames = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LstOut = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LblFName
        '
        Me.LblFName.AutoSize = True
        Me.LblFName.Location = New System.Drawing.Point(56, 50)
        Me.LblFName.Name = "LblFName"
        Me.LblFName.Size = New System.Drawing.Size(112, 25)
        Me.LblFName.TabIndex = 0
        Me.LblFName.Text = "&First Name:"
        '
        'TxtFName
        '
        Me.TxtFName.Location = New System.Drawing.Point(163, 47)
        Me.TxtFName.Name = "TxtFName"
        Me.TxtFName.Size = New System.Drawing.Size(202, 30)
        Me.TxtFName.TabIndex = 1
        '
        'TxtLName
        '
        Me.TxtLName.Location = New System.Drawing.Point(163, 114)
        Me.TxtLName.Name = "TxtLName"
        Me.TxtLName.Size = New System.Drawing.Size(202, 30)
        Me.TxtLName.TabIndex = 5
        '
        'LblLName
        '
        Me.LblLName.AutoSize = True
        Me.LblLName.Location = New System.Drawing.Point(56, 119)
        Me.LblLName.Name = "LblLName"
        Me.LblLName.Size = New System.Drawing.Size(112, 25)
        Me.LblLName.TabIndex = 4
        Me.LblLName.Text = "&Last Name:"
        '
        'TxtMI
        '
        Me.TxtMI.Location = New System.Drawing.Point(163, 79)
        Me.TxtMI.Name = "TxtMI"
        Me.TxtMI.Size = New System.Drawing.Size(80, 30)
        Me.TxtMI.TabIndex = 3
        '
        'LblMI
        '
        Me.LblMI.AutoSize = True
        Me.LblMI.Location = New System.Drawing.Point(56, 87)
        Me.LblMI.Name = "LblMI"
        Me.LblMI.Size = New System.Drawing.Size(40, 25)
        Me.LblMI.TabIndex = 2
        Me.LblMI.Text = "&MI:"
        '
        'BtnAddName
        '
        Me.BtnAddName.Location = New System.Drawing.Point(28, 168)
        Me.BtnAddName.Name = "BtnAddName"
        Me.BtnAddName.Size = New System.Drawing.Size(113, 51)
        Me.BtnAddName.TabIndex = 6
        Me.BtnAddName.Text = "Add Name"
        Me.BtnAddName.UseVisualStyleBackColor = True
        '
        'BtClrNames
        '
        Me.BtClrNames.Location = New System.Drawing.Point(154, 168)
        Me.BtClrNames.Name = "BtClrNames"
        Me.BtClrNames.Size = New System.Drawing.Size(140, 51)
        Me.BtClrNames.TabIndex = 7
        Me.BtClrNames.Text = "Clear Names"
        Me.BtClrNames.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(311, 168)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(85, 51)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LstOut
        '
        Me.LstOut.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOut.FormattingEnabled = True
        Me.LstOut.ItemHeight = 21
        Me.LstOut.Location = New System.Drawing.Point(45, 243)
        Me.LstOut.Name = "LstOut"
        Me.LstOut.Size = New System.Drawing.Size(342, 130)
        Me.LstOut.TabIndex = 9
        '
        'FrmDemoWeek2_Thursday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 420)
        Me.Controls.Add(Me.LstOut)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtClrNames)
        Me.Controls.Add(Me.BtnAddName)
        Me.Controls.Add(Me.TxtMI)
        Me.Controls.Add(Me.LblMI)
        Me.Controls.Add(Me.TxtLName)
        Me.Controls.Add(Me.LblLName)
        Me.Controls.Add(Me.TxtFName)
        Me.Controls.Add(Me.LblFName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmDemoWeek2_Thursday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo Week2 Thursday"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFName As Label
    Friend WithEvents TxtFName As TextBox
    Friend WithEvents TxtLName As TextBox
    Friend WithEvents LblLName As Label
    Friend WithEvents TxtMI As TextBox
    Friend WithEvents LblMI As Label
    Friend WithEvents BtnAddName As Button
    Friend WithEvents BtClrNames As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LstOut As ListBox
End Class
