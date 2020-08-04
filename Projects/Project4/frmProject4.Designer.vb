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
        Me.tblLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.grpSpades = New System.Windows.Forms.GroupBox()
        Me.grpHearts = New System.Windows.Forms.GroupBox()
        Me.grpDiamonds = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpClubs = New System.Windows.Forms.GroupBox()
        Me.grpDiamonds_dummy = New System.Windows.Forms.CheckBox()
        Me.grpHearts_dummy = New System.Windows.Forms.CheckBox()
        Me.grpSpades_dummy = New System.Windows.Forms.CheckBox()
        Me.grpClubs_dummy = New System.Windows.Forms.CheckBox()
        Me.tblLayout.SuspendLayout()
        Me.grpSpades.SuspendLayout()
        Me.grpHearts.SuspendLayout()
        Me.grpDiamonds.SuspendLayout()
        Me.grpClubs.SuspendLayout()
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
        Me.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLayout.Location = New System.Drawing.Point(0, 0)
        Me.tblLayout.Name = "tblLayout"
        Me.tblLayout.RowCount = 2
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLayout.Size = New System.Drawing.Size(394, 422)
        Me.tblLayout.TabIndex = 0
        '
        'grpSpades
        '
        Me.grpSpades.Controls.Add(Me.grpSpades_dummy)
        Me.grpSpades.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSpades.Location = New System.Drawing.Point(304, 50)
        Me.grpSpades.Margin = New System.Windows.Forms.Padding(10)
        Me.grpSpades.Name = "grpSpades"
        Me.grpSpades.Padding = New System.Windows.Forms.Padding(0)
        Me.grpSpades.Size = New System.Drawing.Size(80, 362)
        Me.grpSpades.TabIndex = 0
        Me.grpSpades.TabStop = False
        Me.grpSpades.Text = "Spades"
        '
        'grpHearts
        '
        Me.grpHearts.Controls.Add(Me.grpHearts_dummy)
        Me.grpHearts.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpHearts.Location = New System.Drawing.Point(206, 50)
        Me.grpHearts.Margin = New System.Windows.Forms.Padding(10)
        Me.grpHearts.Name = "grpHearts"
        Me.grpHearts.Padding = New System.Windows.Forms.Padding(0)
        Me.grpHearts.Size = New System.Drawing.Size(78, 362)
        Me.grpHearts.TabIndex = 0
        Me.grpHearts.TabStop = False
        Me.grpHearts.Text = "Hearts"
        '
        'grpDiamonds
        '
        Me.grpDiamonds.Controls.Add(Me.grpDiamonds_dummy)
        Me.grpDiamonds.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDiamonds.Location = New System.Drawing.Point(108, 50)
        Me.grpDiamonds.Margin = New System.Windows.Forms.Padding(10)
        Me.grpDiamonds.Name = "grpDiamonds"
        Me.grpDiamonds.Padding = New System.Windows.Forms.Padding(0)
        Me.grpDiamonds.Size = New System.Drawing.Size(78, 362)
        Me.grpDiamonds.TabIndex = 0
        Me.grpDiamonds.TabStop = False
        Me.grpDiamonds.Text = "Diamonds"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tblLayout.SetColumnSpan(Me.lblTitle, 4)
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(52, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(289, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Poker Hand Determiner"
        '
        'grpClubs
        '
        Me.grpClubs.Controls.Add(Me.grpClubs_dummy)
        Me.grpClubs.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpClubs.Location = New System.Drawing.Point(10, 50)
        Me.grpClubs.Margin = New System.Windows.Forms.Padding(10)
        Me.grpClubs.Name = "grpClubs"
        Me.grpClubs.Padding = New System.Windows.Forms.Padding(0)
        Me.grpClubs.Size = New System.Drawing.Size(78, 362)
        Me.grpClubs.TabIndex = 0
        Me.grpClubs.TabStop = False
        Me.grpClubs.Text = "Clubs"
        '
        'grpDiamonds_dummy
        '
        Me.grpDiamonds_dummy.AutoSize = True
        Me.grpDiamonds_dummy.Location = New System.Drawing.Point(15, 27)
        Me.grpDiamonds_dummy.Name = "grpDiamonds_dummy"
        Me.grpDiamonds_dummy.Size = New System.Drawing.Size(47, 19)
        Me.grpDiamonds_dummy.TabIndex = 0
        Me.grpDiamonds_dummy.Text = "###"
        Me.grpDiamonds_dummy.UseVisualStyleBackColor = True
        Me.grpDiamonds_dummy.Visible = False
        '
        'grpHearts_dummy
        '
        Me.grpHearts_dummy.AutoSize = True
        Me.grpHearts_dummy.Location = New System.Drawing.Point(15, 27)
        Me.grpHearts_dummy.Name = "grpHearts_dummy"
        Me.grpHearts_dummy.Size = New System.Drawing.Size(47, 19)
        Me.grpHearts_dummy.TabIndex = 0
        Me.grpHearts_dummy.Text = "###"
        Me.grpHearts_dummy.UseVisualStyleBackColor = True
        Me.grpHearts_dummy.Visible = False
        '
        'grpSpades_dummy
        '
        Me.grpSpades_dummy.AutoSize = True
        Me.grpSpades_dummy.Location = New System.Drawing.Point(15, 27)
        Me.grpSpades_dummy.Name = "grpSpades_dummy"
        Me.grpSpades_dummy.Size = New System.Drawing.Size(47, 19)
        Me.grpSpades_dummy.TabIndex = 0
        Me.grpSpades_dummy.Text = "###"
        Me.grpSpades_dummy.UseVisualStyleBackColor = True
        Me.grpSpades_dummy.Visible = False
        '
        'grpClubs_dummy
        '
        Me.grpClubs_dummy.AutoSize = True
        Me.grpClubs_dummy.Location = New System.Drawing.Point(12, 27)
        Me.grpClubs_dummy.Name = "grpClubs_dummy"
        Me.grpClubs_dummy.Size = New System.Drawing.Size(47, 19)
        Me.grpClubs_dummy.TabIndex = 0
        Me.grpClubs_dummy.Text = "###"
        Me.grpClubs_dummy.UseVisualStyleBackColor = True
        Me.grpClubs_dummy.Visible = False
        '
        'frmProject4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 422)
        Me.Controls.Add(Me.tblLayout)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(410, 39)
        Me.Name = "frmProject4"
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
End Class
