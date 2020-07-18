<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDemoWeek3_Thursday
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
        Me.BtnRoll = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtOut = New System.Windows.Forms.TextBox()
        Me.PicDie1 = New System.Windows.Forms.PictureBox()
        Me.PicDie2 = New System.Windows.Forms.PictureBox()
        CType(Me.PicDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRoll
        '
        Me.BtnRoll.Location = New System.Drawing.Point(38, 158)
        Me.BtnRoll.Name = "BtnRoll"
        Me.BtnRoll.Size = New System.Drawing.Size(103, 47)
        Me.BtnRoll.TabIndex = 0
        Me.BtnRoll.Text = "Roll"
        Me.BtnRoll.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(169, 158)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(103, 47)
        Me.BtnNew.TabIndex = 1
        Me.BtnNew.Text = "New Game"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(303, 158)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(103, 47)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TxtOut
        '
        Me.TxtOut.Location = New System.Drawing.Point(39, 220)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtOut.Size = New System.Drawing.Size(366, 180)
        Me.TxtOut.TabIndex = 3
        '
        'PicDie1
        '
        Me.PicDie1.Image = Global.DemoWeek3_Thursday.My.Resources.Resources.Dice_3
        Me.PicDie1.Location = New System.Drawing.Point(81, 30)
        Me.PicDie1.Name = "PicDie1"
        Me.PicDie1.Size = New System.Drawing.Size(115, 110)
        Me.PicDie1.TabIndex = 4
        Me.PicDie1.TabStop = False
        '
        'PicDie2
        '
        Me.PicDie2.Image = Global.DemoWeek3_Thursday.My.Resources.Resources.Dice_4
        Me.PicDie2.Location = New System.Drawing.Point(241, 30)
        Me.PicDie2.Name = "PicDie2"
        Me.PicDie2.Size = New System.Drawing.Size(115, 110)
        Me.PicDie2.TabIndex = 5
        Me.PicDie2.TabStop = False
        '
        'FrmDemoWeek3_Thursday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 420)
        Me.Controls.Add(Me.PicDie2)
        Me.Controls.Add(Me.PicDie1)
        Me.Controls.Add(Me.TxtOut)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnRoll)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmDemoWeek3_Thursday"
        Me.Text = "Demo Week3 Thursday"
        CType(Me.PicDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDie2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRoll As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents TxtOut As TextBox
    Friend WithEvents PicDie1 As PictureBox
    Friend WithEvents PicDie2 As PictureBox
End Class
