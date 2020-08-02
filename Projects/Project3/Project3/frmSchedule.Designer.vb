<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.tblLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tblLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDisplay.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(17, 16)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDisplay.Size = New System.Drawing.Size(455, 258)
        Me.txtDisplay.TabIndex = 0
        '
        'tblLayout
        '
        Me.tblLayout.ColumnCount = 1
        Me.tblLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLayout.Controls.Add(Me.txtDisplay, 0, 0)
        Me.tblLayout.Controls.Add(Me.btnClose, 0, 1)
        Me.tblLayout.Location = New System.Drawing.Point(0, 0)
        Me.tblLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.tblLayout.Name = "tblLayout"
        Me.tblLayout.Padding = New System.Windows.Forms.Padding(14, 13, 0, 13)
        Me.tblLayout.RowCount = 2
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tblLayout.Size = New System.Drawing.Size(475, 352)
        Me.tblLayout.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Location = New System.Drawing.Point(198, 289)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 37)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.tblLayout)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "frmSchedule"
        Me.Text = "Depreciation Schedule"
        Me.tblLayout.ResumeLayout(False)
        Me.tblLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents tblLayout As TableLayoutPanel
    Friend WithEvents btnClose As Button
End Class
