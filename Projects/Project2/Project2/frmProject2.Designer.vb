<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProject2))
        Me.chkBurgers = New System.Windows.Forms.CheckBox()
        Me.tblLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkDrinks = New System.Windows.Forms.CheckBox()
        Me.grpBurgers = New System.Windows.Forms.GroupBox()
        Me.radGrpBurgers_cheesebacon = New System.Windows.Forms.RadioButton()
        Me.radGrpBurgers_bacon = New System.Windows.Forms.RadioButton()
        Me.radGrpBurgers_cheese = New System.Windows.Forms.RadioButton()
        Me.radGrpBurgers_regular = New System.Windows.Forms.RadioButton()
        Me.grpFries = New System.Windows.Forms.GroupBox()
        Me.radGrpFries_large = New System.Windows.Forms.RadioButton()
        Me.radGrpFries_medium = New System.Windows.Forms.RadioButton()
        Me.radGrpFries_small = New System.Windows.Forms.RadioButton()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.radGrpDrinks_water = New System.Windows.Forms.RadioButton()
        Me.radGrpDrinks_soda = New System.Windows.Forms.RadioButton()
        Me.grpTotalGroup = New System.Windows.Forms.Panel()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tblLayout.SuspendLayout()
        Me.grpBurgers.SuspendLayout()
        Me.grpFries.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.grpTotalGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkBurgers
        '
        Me.chkBurgers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkBurgers.AutoSize = True
        Me.chkBurgers.Location = New System.Drawing.Point(31, 66)
        Me.chkBurgers.Name = "chkBurgers"
        Me.chkBurgers.Size = New System.Drawing.Size(69, 19)
        Me.chkBurgers.TabIndex = 0
        Me.chkBurgers.Text = "Burgers"
        Me.chkBurgers.UseVisualStyleBackColor = True
        '
        'tblLayout
        '
        Me.tblLayout.AutoSize = True
        Me.tblLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tblLayout.ColumnCount = 3
        Me.tblLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblLayout.Controls.Add(Me.btnClose, 2, 2)
        Me.tblLayout.Controls.Add(Me.chkBurgers, 0, 0)
        Me.tblLayout.Controls.Add(Me.chkFries, 0, 1)
        Me.tblLayout.Controls.Add(Me.chkDrinks, 0, 2)
        Me.tblLayout.Controls.Add(Me.grpBurgers, 1, 0)
        Me.tblLayout.Controls.Add(Me.grpFries, 1, 1)
        Me.tblLayout.Controls.Add(Me.grpDrinks, 1, 2)
        Me.tblLayout.Controls.Add(Me.grpTotalGroup, 2, 0)
        Me.tblLayout.Controls.Add(Me.btnReset, 2, 1)
        Me.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tblLayout.Location = New System.Drawing.Point(0, 0)
        Me.tblLayout.Name = "tblLayout"
        Me.tblLayout.Padding = New System.Windows.Forms.Padding(9)
        Me.tblLayout.RowCount = 3
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblLayout.Size = New System.Drawing.Size(584, 421)
        Me.tblLayout.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Location = New System.Drawing.Point(445, 314)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 60)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(39, 200)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(53, 19)
        Me.chkFries.TabIndex = 1
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkDrinks
        '
        Me.chkDrinks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkDrinks.AutoSize = True
        Me.chkDrinks.Location = New System.Drawing.Point(35, 335)
        Me.chkDrinks.Name = "chkDrinks"
        Me.chkDrinks.Size = New System.Drawing.Size(61, 19)
        Me.chkDrinks.TabIndex = 2
        Me.chkDrinks.Text = "Drinks"
        Me.chkDrinks.UseVisualStyleBackColor = True
        '
        'grpBurgers
        '
        Me.grpBurgers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpBurgers.Controls.Add(Me.radGrpBurgers_cheesebacon)
        Me.grpBurgers.Controls.Add(Me.radGrpBurgers_bacon)
        Me.grpBurgers.Controls.Add(Me.radGrpBurgers_cheese)
        Me.grpBurgers.Controls.Add(Me.radGrpBurgers_regular)
        Me.grpBurgers.Location = New System.Drawing.Point(161, 12)
        Me.grpBurgers.Name = "grpBurgers"
        Me.grpBurgers.Size = New System.Drawing.Size(204, 128)
        Me.grpBurgers.TabIndex = 3
        Me.grpBurgers.TabStop = False
        Me.grpBurgers.Text = "Choices for Burgers"
        Me.grpBurgers.Visible = False
        '
        'radGrpBurgers_cheesebacon
        '
        Me.radGrpBurgers_cheesebacon.AutoSize = True
        Me.radGrpBurgers_cheesebacon.Location = New System.Drawing.Point(6, 96)
        Me.radGrpBurgers_cheesebacon.Name = "radGrpBurgers_cheesebacon"
        Me.radGrpBurgers_cheesebacon.Size = New System.Drawing.Size(128, 19)
        Me.radGrpBurgers_cheesebacon.TabIndex = 3
        Me.radGrpBurgers_cheesebacon.TabStop = True
        Me.radGrpBurgers_cheesebacon.Tag = "5.39"
        Me.radGrpBurgers_cheesebacon.Text = "w/Cheese && Bacon"
        Me.radGrpBurgers_cheesebacon.UseVisualStyleBackColor = True
        '
        'radGrpBurgers_bacon
        '
        Me.radGrpBurgers_bacon.AutoSize = True
        Me.radGrpBurgers_bacon.Location = New System.Drawing.Point(6, 71)
        Me.radGrpBurgers_bacon.Name = "radGrpBurgers_bacon"
        Me.radGrpBurgers_bacon.Size = New System.Drawing.Size(72, 19)
        Me.radGrpBurgers_bacon.TabIndex = 2
        Me.radGrpBurgers_bacon.TabStop = True
        Me.radGrpBurgers_bacon.Tag = "4.79"
        Me.radGrpBurgers_bacon.Text = "w/Bacon"
        Me.radGrpBurgers_bacon.UseVisualStyleBackColor = True
        '
        'radGrpBurgers_cheese
        '
        Me.radGrpBurgers_cheese.AutoSize = True
        Me.radGrpBurgers_cheese.Location = New System.Drawing.Point(7, 46)
        Me.radGrpBurgers_cheese.Name = "radGrpBurgers_cheese"
        Me.radGrpBurgers_cheese.Size = New System.Drawing.Size(79, 19)
        Me.radGrpBurgers_cheese.TabIndex = 1
        Me.radGrpBurgers_cheese.TabStop = True
        Me.radGrpBurgers_cheese.Tag = "4.79"
        Me.radGrpBurgers_cheese.Text = "w/Cheese"
        Me.radGrpBurgers_cheese.UseVisualStyleBackColor = True
        '
        'radGrpBurgers_regular
        '
        Me.radGrpBurgers_regular.AutoSize = True
        Me.radGrpBurgers_regular.Location = New System.Drawing.Point(7, 21)
        Me.radGrpBurgers_regular.Name = "radGrpBurgers_regular"
        Me.radGrpBurgers_regular.Size = New System.Drawing.Size(69, 19)
        Me.radGrpBurgers_regular.TabIndex = 0
        Me.radGrpBurgers_regular.TabStop = True
        Me.radGrpBurgers_regular.Tag = "4.19"
        Me.radGrpBurgers_regular.Text = "Regular"
        Me.radGrpBurgers_regular.UseVisualStyleBackColor = True
        '
        'grpFries
        '
        Me.grpFries.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpFries.Controls.Add(Me.radGrpFries_large)
        Me.grpFries.Controls.Add(Me.radGrpFries_medium)
        Me.grpFries.Controls.Add(Me.radGrpFries_small)
        Me.grpFries.Location = New System.Drawing.Point(161, 158)
        Me.grpFries.Name = "grpFries"
        Me.grpFries.Size = New System.Drawing.Size(205, 103)
        Me.grpFries.TabIndex = 5
        Me.grpFries.TabStop = False
        Me.grpFries.Text = "Choices for Fries"
        Me.grpFries.Visible = False
        '
        'radGrpFries_large
        '
        Me.radGrpFries_large.AutoSize = True
        Me.radGrpFries_large.Location = New System.Drawing.Point(6, 72)
        Me.radGrpFries_large.Name = "radGrpFries_large"
        Me.radGrpFries_large.Size = New System.Drawing.Size(57, 19)
        Me.radGrpFries_large.TabIndex = 2
        Me.radGrpFries_large.TabStop = True
        Me.radGrpFries_large.Tag = "4.99"
        Me.radGrpFries_large.Text = "Large"
        Me.radGrpFries_large.UseVisualStyleBackColor = True
        '
        'radGrpFries_medium
        '
        Me.radGrpFries_medium.AutoSize = True
        Me.radGrpFries_medium.Location = New System.Drawing.Point(6, 46)
        Me.radGrpFries_medium.Name = "radGrpFries_medium"
        Me.radGrpFries_medium.Size = New System.Drawing.Size(71, 19)
        Me.radGrpFries_medium.TabIndex = 1
        Me.radGrpFries_medium.TabStop = True
        Me.radGrpFries_medium.Tag = "3.09"
        Me.radGrpFries_medium.Text = "Medium"
        Me.radGrpFries_medium.UseVisualStyleBackColor = True
        '
        'radGrpFries_small
        '
        Me.radGrpFries_small.AutoSize = True
        Me.radGrpFries_small.Location = New System.Drawing.Point(7, 20)
        Me.radGrpFries_small.Name = "radGrpFries_small"
        Me.radGrpFries_small.Size = New System.Drawing.Size(57, 19)
        Me.radGrpFries_small.TabIndex = 0
        Me.radGrpFries_small.TabStop = True
        Me.radGrpFries_small.Tag = "2.39"
        Me.radGrpFries_small.Text = "Small"
        Me.radGrpFries_small.UseVisualStyleBackColor = True
        '
        'grpDrinks
        '
        Me.grpDrinks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpDrinks.Controls.Add(Me.radGrpDrinks_water)
        Me.grpDrinks.Controls.Add(Me.radGrpDrinks_soda)
        Me.grpDrinks.Location = New System.Drawing.Point(161, 303)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(205, 82)
        Me.grpDrinks.TabIndex = 6
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Choices for Drinks"
        Me.grpDrinks.Visible = False
        '
        'radGrpDrinks_water
        '
        Me.radGrpDrinks_water.AutoSize = True
        Me.radGrpDrinks_water.Location = New System.Drawing.Point(7, 53)
        Me.radGrpDrinks_water.Name = "radGrpDrinks_water"
        Me.radGrpDrinks_water.Size = New System.Drawing.Size(98, 19)
        Me.radGrpDrinks_water.TabIndex = 1
        Me.radGrpDrinks_water.TabStop = True
        Me.radGrpDrinks_water.Tag = "1.49"
        Me.radGrpDrinks_water.Text = "Bottled Water"
        Me.radGrpDrinks_water.UseVisualStyleBackColor = True
        '
        'radGrpDrinks_soda
        '
        Me.radGrpDrinks_soda.AutoSize = True
        Me.radGrpDrinks_soda.Location = New System.Drawing.Point(7, 27)
        Me.radGrpDrinks_soda.Name = "radGrpDrinks_soda"
        Me.radGrpDrinks_soda.Size = New System.Drawing.Size(54, 19)
        Me.radGrpDrinks_soda.TabIndex = 0
        Me.radGrpDrinks_soda.TabStop = True
        Me.radGrpDrinks_soda.Tag = "1.69"
        Me.radGrpDrinks_soda.Text = "Soda"
        Me.radGrpDrinks_soda.UseVisualStyleBackColor = True
        '
        'grpTotalGroup
        '
        Me.grpTotalGroup.Controls.Add(Me.btnTotal)
        Me.grpTotalGroup.Controls.Add(Me.lblOutput)
        Me.grpTotalGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTotalGroup.Location = New System.Drawing.Point(408, 12)
        Me.grpTotalGroup.Name = "grpTotalGroup"
        Me.grpTotalGroup.Size = New System.Drawing.Size(164, 128)
        Me.grpTotalGroup.TabIndex = 7
        '
        'btnTotal
        '
        Me.btnTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTotal.Location = New System.Drawing.Point(37, 13)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(90, 60)
        Me.btnTotal.TabIndex = 4
        Me.btnTotal.Text = "Total Cost"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(3, 76)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(147, 15)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "Ready for next meal..."
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.Location = New System.Drawing.Point(445, 180)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 60)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmProject2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 421)
        Me.Controls.Add(Me.tblLayout)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(450, 450)
        Me.Name = "frmProject2"
        Me.Text = "Project2: Fast Food Order Menu"
        Me.tblLayout.ResumeLayout(False)
        Me.tblLayout.PerformLayout()
        Me.grpBurgers.ResumeLayout(False)
        Me.grpBurgers.PerformLayout()
        Me.grpFries.ResumeLayout(False)
        Me.grpFries.PerformLayout()
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.grpTotalGroup.ResumeLayout(False)
        Me.grpTotalGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBurgers As CheckBox
    Friend WithEvents tblLayout As TableLayoutPanel
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkDrinks As CheckBox
    Friend WithEvents grpBurgers As GroupBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents grpFries As GroupBox
    Friend WithEvents grpDrinks As GroupBox
    Friend WithEvents grpTotalGroup As Panel
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents radGrpBurgers_regular As RadioButton
    Friend WithEvents radGrpBurgers_cheesebacon As RadioButton
    Friend WithEvents radGrpBurgers_bacon As RadioButton
    Friend WithEvents radGrpBurgers_cheese As RadioButton
    Friend WithEvents radGrpFries_small As RadioButton
    Friend WithEvents radGrpFries_medium As RadioButton
    Friend WithEvents radGrpFries_large As RadioButton
    Friend WithEvents radGrpDrinks_water As RadioButton
    Friend WithEvents radGrpDrinks_soda As RadioButton
End Class
