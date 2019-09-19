<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinLossForm
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
        Me.btnWin = New System.Windows.Forms.Button()
        Me.btnLoss = New System.Windows.Forms.Button()
        Me.rankedCheckbox = New System.Windows.Forms.CheckBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnWin
        '
        Me.btnWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWin.Location = New System.Drawing.Point(97, 151)
        Me.btnWin.Name = "btnWin"
        Me.btnWin.Size = New System.Drawing.Size(184, 59)
        Me.btnWin.TabIndex = 0
        Me.btnWin.Text = "Win"
        Me.btnWin.UseVisualStyleBackColor = True
        '
        'btnLoss
        '
        Me.btnLoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoss.Location = New System.Drawing.Point(511, 151)
        Me.btnLoss.Name = "btnLoss"
        Me.btnLoss.Size = New System.Drawing.Size(184, 59)
        Me.btnLoss.TabIndex = 1
        Me.btnLoss.Text = "Loss"
        Me.btnLoss.UseVisualStyleBackColor = True
        '
        'rankedCheckbox
        '
        Me.rankedCheckbox.AutoSize = True
        Me.rankedCheckbox.Checked = True
        Me.rankedCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rankedCheckbox.Location = New System.Drawing.Point(369, 310)
        Me.rankedCheckbox.Name = "rankedCheckbox"
        Me.rankedCheckbox.Size = New System.Drawing.Size(64, 17)
        Me.rankedCheckbox.TabIndex = 2
        Me.rankedCheckbox.Text = "Ranked"
        Me.rankedCheckbox.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(384, 137)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(49, 73)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "|"
        '
        'WinLossForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.rankedCheckbox)
        Me.Controls.Add(Me.btnLoss)
        Me.Controls.Add(Me.btnWin)
        Me.Name = "WinLossForm"
        Me.Text = "WinLoss"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWin As Windows.Forms.Button
    Friend WithEvents btnLoss As Windows.Forms.Button
    Friend WithEvents rankedCheckbox As Windows.Forms.CheckBox
    Friend WithEvents lbl1 As Windows.Forms.Label
End Class
