<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PartyMembers
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
        Me.MembersChecklist = New System.Windows.Forms.CheckedListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MembersChecklist
        '
        Me.MembersChecklist.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MembersChecklist.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembersChecklist.FormattingEnabled = True
        Me.MembersChecklist.Items.AddRange(New Object() {"Antoine", "Nic", "Pat Legault", "D'Anjou", "Tony", "Simon", "M-A", "Kev"})
        Me.MembersChecklist.Location = New System.Drawing.Point(84, 175)
        Me.MembersChecklist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MembersChecklist.Name = "MembersChecklist"
        Me.MembersChecklist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MembersChecklist.Size = New System.Drawing.Size(343, 301)
        Me.MembersChecklist.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(779, 293)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(213, 59)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save Stats"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PartyMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MembersChecklist)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PartyMembers"
        Me.Text = "PartyMembers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MembersChecklist As Windows.Forms.CheckedListBox
    Friend WithEvents btnSave As Windows.Forms.Button
End Class
