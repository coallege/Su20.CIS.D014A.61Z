<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDemoWeek3_Tuesday
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
        Me.ChkWomens = New System.Windows.Forms.CheckBox()
        Me.RadGrpW_Small = New System.Windows.Forms.RadioButton()
        Me.RadGrpW_Medium = New System.Windows.Forms.RadioButton()
        Me.RadGrpW_Large = New System.Windows.Forms.RadioButton()
        Me.ChkMens = New System.Windows.Forms.CheckBox()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.GrpWSizes = New System.Windows.Forms.GroupBox()
        Me.GrpMSizes = New System.Windows.Forms.GroupBox()
        Me.RadGrpM_Medium = New System.Windows.Forms.RadioButton()
        Me.RadGrpM_Small = New System.Windows.Forms.RadioButton()
        Me.RadGrpM_Large = New System.Windows.Forms.RadioButton()
        Me.GrpWSizes.SuspendLayout()
        Me.GrpMSizes.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkWomens
        '
        Me.ChkWomens.AutoSize = True
        Me.ChkWomens.Checked = True
        Me.ChkWomens.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkWomens.Location = New System.Drawing.Point(35, 96)
        Me.ChkWomens.Name = "ChkWomens"
        Me.ChkWomens.Size = New System.Drawing.Size(91, 24)
        Me.ChkWomens.TabIndex = 0
        Me.ChkWomens.Text = "Womens"
        Me.ChkWomens.UseVisualStyleBackColor = True
        '
        'RadGrpW_Small
        '
        Me.RadGrpW_Small.AutoSize = True
        Me.RadGrpW_Small.Location = New System.Drawing.Point(13, 16)
        Me.RadGrpW_Small.Name = "RadGrpW_Small"
        Me.RadGrpW_Small.Size = New System.Drawing.Size(66, 24)
        Me.RadGrpW_Small.TabIndex = 1
        Me.RadGrpW_Small.TabStop = True
        Me.RadGrpW_Small.Tag = "10.00"
        Me.RadGrpW_Small.Text = "Small"
        Me.RadGrpW_Small.UseVisualStyleBackColor = True
        '
        'RadGrpW_Medium
        '
        Me.RadGrpW_Medium.AutoSize = True
        Me.RadGrpW_Medium.Location = New System.Drawing.Point(13, 46)
        Me.RadGrpW_Medium.Name = "RadGrpW_Medium"
        Me.RadGrpW_Medium.Size = New System.Drawing.Size(83, 24)
        Me.RadGrpW_Medium.TabIndex = 2
        Me.RadGrpW_Medium.TabStop = True
        Me.RadGrpW_Medium.Tag = "15.00"
        Me.RadGrpW_Medium.Text = "Medium"
        Me.RadGrpW_Medium.UseVisualStyleBackColor = True
        '
        'RadGrpW_Large
        '
        Me.RadGrpW_Large.AutoSize = True
        Me.RadGrpW_Large.Location = New System.Drawing.Point(13, 76)
        Me.RadGrpW_Large.Name = "RadGrpW_Large"
        Me.RadGrpW_Large.Size = New System.Drawing.Size(68, 24)
        Me.RadGrpW_Large.TabIndex = 3
        Me.RadGrpW_Large.TabStop = True
        Me.RadGrpW_Large.Tag = "20.00"
        Me.RadGrpW_Large.Text = "Large"
        Me.RadGrpW_Large.UseVisualStyleBackColor = True
        '
        'ChkMens
        '
        Me.ChkMens.AutoSize = True
        Me.ChkMens.Checked = True
        Me.ChkMens.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMens.Location = New System.Drawing.Point(35, 208)
        Me.ChkMens.Name = "ChkMens"
        Me.ChkMens.Size = New System.Drawing.Size(67, 24)
        Me.ChkMens.TabIndex = 4
        Me.ChkMens.Text = "Mens"
        Me.ChkMens.UseVisualStyleBackColor = True
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(335, 50)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(84, 53)
        Me.BtnOrder.TabIndex = 8
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(335, 148)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(84, 53)
        Me.BtnReset.TabIndex = 9
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(335, 233)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(84, 53)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Location = New System.Drawing.Point(49, 281)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(81, 20)
        Me.LblInfo.TabIndex = 11
        Me.LblInfo.Text = "Order Info"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(163, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(92, 27)
        Me.LblTitle.TabIndex = 12
        Me.LblTitle.Text = "SHOES"
        '
        'GrpWSizes
        '
        Me.GrpWSizes.Controls.Add(Me.RadGrpW_Medium)
        Me.GrpWSizes.Controls.Add(Me.RadGrpW_Small)
        Me.GrpWSizes.Controls.Add(Me.RadGrpW_Large)
        Me.GrpWSizes.Location = New System.Drawing.Point(132, 50)
        Me.GrpWSizes.Name = "GrpWSizes"
        Me.GrpWSizes.Size = New System.Drawing.Size(164, 106)
        Me.GrpWSizes.TabIndex = 13
        Me.GrpWSizes.TabStop = False
        Me.GrpWSizes.Text = "Sizes:"
        '
        'GrpMSizes
        '
        Me.GrpMSizes.Controls.Add(Me.RadGrpM_Medium)
        Me.GrpMSizes.Controls.Add(Me.RadGrpM_Small)
        Me.GrpMSizes.Controls.Add(Me.RadGrpM_Large)
        Me.GrpMSizes.Location = New System.Drawing.Point(132, 162)
        Me.GrpMSizes.Name = "GrpMSizes"
        Me.GrpMSizes.Size = New System.Drawing.Size(164, 106)
        Me.GrpMSizes.TabIndex = 14
        Me.GrpMSizes.TabStop = False
        Me.GrpMSizes.Text = "Sizes:"
        '
        'RadGrpM_Medium
        '
        Me.RadGrpM_Medium.AutoSize = True
        Me.RadGrpM_Medium.Location = New System.Drawing.Point(13, 46)
        Me.RadGrpM_Medium.Name = "RadGrpM_Medium"
        Me.RadGrpM_Medium.Size = New System.Drawing.Size(83, 24)
        Me.RadGrpM_Medium.TabIndex = 2
        Me.RadGrpM_Medium.TabStop = True
        Me.RadGrpM_Medium.Tag = "10.00"
        Me.RadGrpM_Medium.Text = "Medium"
        Me.RadGrpM_Medium.UseVisualStyleBackColor = True
        '
        'RadGrpM_Small
        '
        Me.RadGrpM_Small.AutoSize = True
        Me.RadGrpM_Small.Location = New System.Drawing.Point(15, 16)
        Me.RadGrpM_Small.Name = "RadGrpM_Small"
        Me.RadGrpM_Small.Size = New System.Drawing.Size(66, 24)
        Me.RadGrpM_Small.TabIndex = 1
        Me.RadGrpM_Small.TabStop = True
        Me.RadGrpM_Small.Tag = "5.00"
        Me.RadGrpM_Small.Text = "Small"
        Me.RadGrpM_Small.UseVisualStyleBackColor = True
        '
        'RadGrpM_Large
        '
        Me.RadGrpM_Large.AutoSize = True
        Me.RadGrpM_Large.Location = New System.Drawing.Point(13, 76)
        Me.RadGrpM_Large.Name = "RadGrpM_Large"
        Me.RadGrpM_Large.Size = New System.Drawing.Size(68, 24)
        Me.RadGrpM_Large.TabIndex = 3
        Me.RadGrpM_Large.TabStop = True
        Me.RadGrpM_Large.Tag = "25.00"
        Me.RadGrpM_Large.Text = "Large"
        Me.RadGrpM_Large.UseVisualStyleBackColor = True
        '
        'FrmDemoWeek3_Tuesday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 324)
        Me.Controls.Add(Me.GrpMSizes)
        Me.Controls.Add(Me.GrpWSizes)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.ChkMens)
        Me.Controls.Add(Me.ChkWomens)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmDemoWeek3_Tuesday"
        Me.Text = "Demo Week3 Tuesday"
        Me.GrpWSizes.ResumeLayout(False)
        Me.GrpWSizes.PerformLayout()
        Me.GrpMSizes.ResumeLayout(False)
        Me.GrpMSizes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChkWomens As CheckBox
    Friend WithEvents RadGrpW_Small As RadioButton
    Friend WithEvents RadGrpW_Medium As RadioButton
    Friend WithEvents RadGrpW_Large As RadioButton
    Friend WithEvents ChkMens As CheckBox
    Friend WithEvents BtnOrder As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblInfo As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents GrpWSizes As GroupBox
    Friend WithEvents GrpMSizes As GroupBox
    Friend WithEvents RadGrpM_Medium As RadioButton
    Friend WithEvents RadGrpM_Small As RadioButton
    Friend WithEvents RadGrpM_Large As RadioButton
End Class
