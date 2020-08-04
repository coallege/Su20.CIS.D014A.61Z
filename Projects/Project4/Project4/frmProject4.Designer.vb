<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProject4
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProject4))
        Me.tblLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.grpSpades = New System.Windows.Forms.GroupBox()
        Me.grpSpades_dummy = New System.Windows.Forms.CheckBox()
        Me.grpHearts = New System.Windows.Forms.GroupBox()
        Me.grpHearts_dummy = New System.Windows.Forms.CheckBox()
        Me.grpDiamonds = New System.Windows.Forms.GroupBox()
        Me.grpDiamonds_dummy = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpClubs = New System.Windows.Forms.GroupBox()
        Me.grpClubs_dummy = New System.Windows.Forms.CheckBox()
        Me.tblButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.tblLayout.SuspendLayout()
        Me.grpSpades.SuspendLayout()
        Me.grpHearts.SuspendLayout()
        Me.grpDiamonds.SuspendLayout()
        Me.grpClubs.SuspendLayout()
        Me.tblButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblLayout
        '
        Me.tblLayout.ColumnCount = 4
        Me.tblLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblLayout.Controls.Add(Me.grpSpades, 3, 1)
        Me.tblLayout.Controls.Add(Me.grpHearts, 2, 1)
        Me.tblLayout.Controls.Add(Me.grpDiamonds, 1, 1)
        Me.tblLayout.Controls.Add(Me.lblTitle, 0, 0)
        Me.tblLayout.Controls.Add(Me.grpClubs, 0, 1)
        Me.tblLayout.Controls.Add(Me.tblButtons, 0, 2)
        Me.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLayout.Location = New System.Drawing.Point(0, 0)
        Me.tblLayout.Name = "tblLayout"
        Me.tblLayout.RowCount = 3
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tblLayout.Size = New System.Drawing.Size(392, 453)
        Me.tblLayout.TabIndex = 0
        '
        'grpSpades
        '
        Me.grpSpades.Controls.Add(Me.grpSpades_dummy)
        Me.grpSpades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSpades.Location = New System.Drawing.Point(304, 50)
        Me.grpSpades.Margin = New System.Windows.Forms.Padding(10)
        Me.grpSpades.Name = "grpSpades"
        Me.grpSpades.Padding = New System.Windows.Forms.Padding(0)
        Me.grpSpades.Size = New System.Drawing.Size(78, 343)
        Me.grpSpades.TabIndex = 0
        Me.grpSpades.TabStop = False
        Me.grpSpades.Text = "Spades"
        '
        'grpSpades_dummy
        '
        Me.grpSpades_dummy.AutoSize = True
        Me.grpSpades_dummy.Location = New System.Drawing.Point(14, 27)
        Me.grpSpades_dummy.Name = "grpSpades_dummy"
        Me.grpSpades_dummy.Size = New System.Drawing.Size(54, 22)
        Me.grpSpades_dummy.TabIndex = 0
        Me.grpSpades_dummy.Text = "###"
        Me.grpSpades_dummy.UseVisualStyleBackColor = True
        Me.grpSpades_dummy.Visible = False
        '
        'grpHearts
        '
        Me.grpHearts.Controls.Add(Me.grpHearts_dummy)
        Me.grpHearts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpHearts.Location = New System.Drawing.Point(206, 50)
        Me.grpHearts.Margin = New System.Windows.Forms.Padding(10)
        Me.grpHearts.Name = "grpHearts"
        Me.grpHearts.Padding = New System.Windows.Forms.Padding(0)
        Me.grpHearts.Size = New System.Drawing.Size(78, 343)
        Me.grpHearts.TabIndex = 0
        Me.grpHearts.TabStop = False
        Me.grpHearts.Text = "Hearts"
        '
        'grpHearts_dummy
        '
        Me.grpHearts_dummy.AutoSize = True
        Me.grpHearts_dummy.Location = New System.Drawing.Point(13, 27)
        Me.grpHearts_dummy.Name = "grpHearts_dummy"
        Me.grpHearts_dummy.Size = New System.Drawing.Size(54, 22)
        Me.grpHearts_dummy.TabIndex = 0
        Me.grpHearts_dummy.Text = "###"
        Me.grpHearts_dummy.UseVisualStyleBackColor = True
        Me.grpHearts_dummy.Visible = False
        '
        'grpDiamonds
        '
        Me.grpDiamonds.Controls.Add(Me.grpDiamonds_dummy)
        Me.grpDiamonds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDiamonds.Location = New System.Drawing.Point(108, 50)
        Me.grpDiamonds.Margin = New System.Windows.Forms.Padding(10)
        Me.grpDiamonds.Name = "grpDiamonds"
        Me.grpDiamonds.Padding = New System.Windows.Forms.Padding(0)
        Me.grpDiamonds.Size = New System.Drawing.Size(78, 343)
        Me.grpDiamonds.TabIndex = 0
        Me.grpDiamonds.TabStop = False
        Me.grpDiamonds.Text = "Diamonds"
        '
        'grpDiamonds_dummy
        '
        Me.grpDiamonds_dummy.AutoSize = True
        Me.grpDiamonds_dummy.Location = New System.Drawing.Point(13, 27)
        Me.grpDiamonds_dummy.Name = "grpDiamonds_dummy"
        Me.grpDiamonds_dummy.Size = New System.Drawing.Size(54, 22)
        Me.grpDiamonds_dummy.TabIndex = 0
        Me.grpDiamonds_dummy.Text = "###"
        Me.grpDiamonds_dummy.UseVisualStyleBackColor = True
        Me.grpDiamonds_dummy.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tblLayout.SetColumnSpan(Me.lblTitle, 4)
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(22, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(347, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Poker Hand Determiner"
        '
        'grpClubs
        '
        Me.grpClubs.Controls.Add(Me.grpClubs_dummy)
        Me.grpClubs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpClubs.Location = New System.Drawing.Point(10, 50)
        Me.grpClubs.Margin = New System.Windows.Forms.Padding(10)
        Me.grpClubs.Name = "grpClubs"
        Me.grpClubs.Padding = New System.Windows.Forms.Padding(0)
        Me.grpClubs.Size = New System.Drawing.Size(78, 343)
        Me.grpClubs.TabIndex = 0
        Me.grpClubs.TabStop = False
        Me.grpClubs.Text = "Clubs"
        '
        'grpClubs_dummy
        '
        Me.grpClubs_dummy.AutoSize = True
        Me.grpClubs_dummy.Location = New System.Drawing.Point(12, 27)
        Me.grpClubs_dummy.Name = "grpClubs_dummy"
        Me.grpClubs_dummy.Size = New System.Drawing.Size(54, 22)
        Me.grpClubs_dummy.TabIndex = 0
        Me.grpClubs_dummy.Text = "###"
        Me.grpClubs_dummy.UseVisualStyleBackColor = True
        Me.grpClubs_dummy.Visible = False
        '
        'tblButtons
        '
        Me.tblButtons.ColumnCount = 3
        Me.tblLayout.SetColumnSpan(Me.tblButtons, 4)
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblButtons.Controls.Add(Me.btnClose, 2, 0)
        Me.tblButtons.Controls.Add(Me.btnRestart, 1, 0)
        Me.tblButtons.Controls.Add(Me.btnShow, 0, 0)
        Me.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblButtons.Location = New System.Drawing.Point(3, 406)
        Me.tblButtons.Name = "tblButtons"
        Me.tblButtons.RowCount = 1
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.Size = New System.Drawing.Size(386, 44)
        Me.tblButtons.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(259, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 32)
        Me.btnClose.TabIndex = 62
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestart.Location = New System.Drawing.Point(131, 6)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(122, 32)
        Me.btnRestart.TabIndex = 61
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Location = New System.Drawing.Point(3, 6)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(122, 32)
        Me.btnShow.TabIndex = 60
        Me.btnShow.Text = "Show Poker Hand"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmProject4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 453)
        Me.Controls.Add(Me.tblLayout)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(410, 500)
        Me.MinimumSize = New System.Drawing.Size(410, 500)
        Me.Name = "frmProject4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project 4: Poker Hand Determiner"
        Me.tblLayout.ResumeLayout(False)
        Me.tblLayout.PerformLayout()
        Me.grpSpades.ResumeLayout(False)
        Me.grpSpades.PerformLayout()
        Me.grpHearts.ResumeLayout(False)
        Me.grpHearts.PerformLayout()
        Me.grpDiamonds.ResumeLayout(False)
        Me.grpDiamonds.PerformLayout()
        Me.grpClubs.ResumeLayout(False)
        Me.grpClubs.PerformLayout()
        Me.tblButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblLayout As TableLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpClubs As GroupBox
    Friend WithEvents grpSpades As GroupBox
    Friend WithEvents grpHearts As GroupBox
    Friend WithEvents grpDiamonds As GroupBox
    Friend WithEvents grpSpades_dummy As CheckBox
    Friend WithEvents grpHearts_dummy As CheckBox
    Friend WithEvents grpDiamonds_dummy As CheckBox
    Friend WithEvents grpClubs_dummy As CheckBox
    Friend WithEvents tblButtons As TableLayoutPanel
    Friend WithEvents btnShow As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnClose As Button
End Class
