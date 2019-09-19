<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rating
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rating))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblGood = New System.Windows.Forms.Label()
        Me.lblAve = New System.Windows.Forms.Label()
        Me.lblBad = New System.Windows.Forms.Label()
        Me.lblTrash = New System.Windows.Forms.Label()
        Me.TrashPlus = New System.Windows.Forms.PictureBox()
        Me.TrashMinus = New System.Windows.Forms.PictureBox()
        Me.BadPlus = New System.Windows.Forms.PictureBox()
        Me.BadMinus = New System.Windows.Forms.PictureBox()
        Me.AvePlus = New System.Windows.Forms.PictureBox()
        Me.AveMinus = New System.Windows.Forms.PictureBox()
        Me.GoodPlus = New System.Windows.Forms.PictureBox()
        Me.GoodMinus = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblToxic = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.ToxicPlus = New System.Windows.Forms.PictureBox()
        Me.ToxicMinus = New System.Windows.Forms.PictureBox()
        CType(Me.TrashPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrashMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvePlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AveMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoodPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoodMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToxicPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToxicMinus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(83, 83)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(64, 25)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Good"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(232, 83)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(92, 25)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Average"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(408, 83)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(50, 25)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "Bad"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(546, 83)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(67, 25)
        Me.lbl4.TabIndex = 3
        Me.lbl4.Text = "Trash"
        '
        'lblGood
        '
        Me.lblGood.AutoSize = True
        Me.lblGood.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGood.Location = New System.Drawing.Point(88, 161)
        Me.lblGood.Name = "lblGood"
        Me.lblGood.Size = New System.Drawing.Size(18, 20)
        Me.lblGood.TabIndex = 12
        Me.lblGood.Text = "0"
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAve.Location = New System.Drawing.Point(248, 161)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(18, 20)
        Me.lblAve.TabIndex = 13
        Me.lblAve.Text = "0"
        '
        'lblBad
        '
        Me.lblBad.AutoSize = True
        Me.lblBad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBad.Location = New System.Drawing.Point(411, 161)
        Me.lblBad.Name = "lblBad"
        Me.lblBad.Size = New System.Drawing.Size(18, 20)
        Me.lblBad.TabIndex = 14
        Me.lblBad.Text = "0"
        '
        'lblTrash
        '
        Me.lblTrash.AutoSize = True
        Me.lblTrash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrash.Location = New System.Drawing.Point(549, 161)
        Me.lblTrash.Name = "lblTrash"
        Me.lblTrash.Size = New System.Drawing.Size(18, 20)
        Me.lblTrash.TabIndex = 15
        Me.lblTrash.Text = "0"
        '
        'TrashPlus
        '
        Me.TrashPlus.Image = CType(resources.GetObject("TrashPlus.Image"), System.Drawing.Image)
        Me.TrashPlus.Location = New System.Drawing.Point(552, 209)
        Me.TrashPlus.Name = "TrashPlus"
        Me.TrashPlus.Size = New System.Drawing.Size(52, 52)
        Me.TrashPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.TrashPlus.TabIndex = 11
        Me.TrashPlus.TabStop = False
        '
        'TrashMinus
        '
        Me.TrashMinus.Image = Global.DotaTeamates.My.Resources.Resources.minus1
        Me.TrashMinus.Location = New System.Drawing.Point(552, 306)
        Me.TrashMinus.Name = "TrashMinus"
        Me.TrashMinus.Size = New System.Drawing.Size(51, 52)
        Me.TrashMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.TrashMinus.TabIndex = 10
        Me.TrashMinus.TabStop = False
        '
        'BadPlus
        '
        Me.BadPlus.Image = CType(resources.GetObject("BadPlus.Image"), System.Drawing.Image)
        Me.BadPlus.Location = New System.Drawing.Point(414, 209)
        Me.BadPlus.Name = "BadPlus"
        Me.BadPlus.Size = New System.Drawing.Size(52, 52)
        Me.BadPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BadPlus.TabIndex = 9
        Me.BadPlus.TabStop = False
        '
        'BadMinus
        '
        Me.BadMinus.Image = Global.DotaTeamates.My.Resources.Resources.minus1
        Me.BadMinus.Location = New System.Drawing.Point(414, 306)
        Me.BadMinus.Name = "BadMinus"
        Me.BadMinus.Size = New System.Drawing.Size(51, 52)
        Me.BadMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BadMinus.TabIndex = 8
        Me.BadMinus.TabStop = False
        '
        'AvePlus
        '
        Me.AvePlus.Image = CType(resources.GetObject("AvePlus.Image"), System.Drawing.Image)
        Me.AvePlus.Location = New System.Drawing.Point(251, 209)
        Me.AvePlus.Name = "AvePlus"
        Me.AvePlus.Size = New System.Drawing.Size(52, 52)
        Me.AvePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AvePlus.TabIndex = 7
        Me.AvePlus.TabStop = False
        '
        'AveMinus
        '
        Me.AveMinus.Image = Global.DotaTeamates.My.Resources.Resources.minus1
        Me.AveMinus.Location = New System.Drawing.Point(251, 306)
        Me.AveMinus.Name = "AveMinus"
        Me.AveMinus.Size = New System.Drawing.Size(51, 52)
        Me.AveMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AveMinus.TabIndex = 6
        Me.AveMinus.TabStop = False
        '
        'GoodPlus
        '
        Me.GoodPlus.Image = CType(resources.GetObject("GoodPlus.Image"), System.Drawing.Image)
        Me.GoodPlus.Location = New System.Drawing.Point(88, 209)
        Me.GoodPlus.Name = "GoodPlus"
        Me.GoodPlus.Size = New System.Drawing.Size(52, 52)
        Me.GoodPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GoodPlus.TabIndex = 5
        Me.GoodPlus.TabStop = False
        '
        'GoodMinus
        '
        Me.GoodMinus.Image = Global.DotaTeamates.My.Resources.Resources.minus1
        Me.GoodMinus.Location = New System.Drawing.Point(88, 306)
        Me.GoodMinus.Name = "GoodMinus"
        Me.GoodMinus.Size = New System.Drawing.Size(51, 52)
        Me.GoodMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GoodMinus.TabIndex = 4
        Me.GoodMinus.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(291, 419)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(213, 59)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblToxic
        '
        Me.lblToxic.AutoSize = True
        Me.lblToxic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToxic.Location = New System.Drawing.Point(681, 161)
        Me.lblToxic.Name = "lblToxic"
        Me.lblToxic.Size = New System.Drawing.Size(18, 20)
        Me.lblToxic.TabIndex = 18
        Me.lblToxic.Text = "0"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(680, 83)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(64, 25)
        Me.lbl5.TabIndex = 19
        Me.lbl5.Text = "Toxic"
        '
        'ToxicPlus
        '
        Me.ToxicPlus.Image = CType(resources.GetObject("ToxicPlus.Image"), System.Drawing.Image)
        Me.ToxicPlus.Location = New System.Drawing.Point(685, 209)
        Me.ToxicPlus.Name = "ToxicPlus"
        Me.ToxicPlus.Size = New System.Drawing.Size(52, 52)
        Me.ToxicPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ToxicPlus.TabIndex = 21
        Me.ToxicPlus.TabStop = False
        '
        'ToxicMinus
        '
        Me.ToxicMinus.Image = Global.DotaTeamates.My.Resources.Resources.minus1
        Me.ToxicMinus.Location = New System.Drawing.Point(685, 306)
        Me.ToxicMinus.Name = "ToxicMinus"
        Me.ToxicMinus.Size = New System.Drawing.Size(51, 52)
        Me.ToxicMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ToxicMinus.TabIndex = 20
        Me.ToxicMinus.TabStop = False
        '
        'Rating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 519)
        Me.Controls.Add(Me.ToxicPlus)
        Me.Controls.Add(Me.ToxicMinus)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lblToxic)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTrash)
        Me.Controls.Add(Me.lblBad)
        Me.Controls.Add(Me.lblAve)
        Me.Controls.Add(Me.lblGood)
        Me.Controls.Add(Me.TrashPlus)
        Me.Controls.Add(Me.TrashMinus)
        Me.Controls.Add(Me.BadPlus)
        Me.Controls.Add(Me.BadMinus)
        Me.Controls.Add(Me.AvePlus)
        Me.Controls.Add(Me.AveMinus)
        Me.Controls.Add(Me.GoodPlus)
        Me.Controls.Add(Me.GoodMinus)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Rating"
        Me.Text = "Rating"
        CType(Me.TrashPlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrashMinus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadPlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadMinus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvePlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AveMinus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoodPlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoodMinus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToxicPlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToxicMinus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Windows.Forms.Label
    Friend WithEvents lbl2 As Windows.Forms.Label
    Friend WithEvents lbl3 As Windows.Forms.Label
    Friend WithEvents lbl4 As Windows.Forms.Label
    Friend WithEvents GoodMinus As Windows.Forms.PictureBox
    Friend WithEvents GoodPlus As Windows.Forms.PictureBox
    Friend WithEvents AvePlus As Windows.Forms.PictureBox
    Friend WithEvents AveMinus As Windows.Forms.PictureBox
    Friend WithEvents BadPlus As Windows.Forms.PictureBox
    Friend WithEvents BadMinus As Windows.Forms.PictureBox
    Friend WithEvents TrashPlus As Windows.Forms.PictureBox
    Friend WithEvents TrashMinus As Windows.Forms.PictureBox
    Friend WithEvents lblGood As Windows.Forms.Label
    Friend WithEvents lblAve As Windows.Forms.Label
    Friend WithEvents lblBad As Windows.Forms.Label
    Friend WithEvents lblTrash As Windows.Forms.Label
    Friend WithEvents btnNext As Windows.Forms.Button
    Friend WithEvents lblToxic As Windows.Forms.Label
    Friend WithEvents lbl5 As Windows.Forms.Label
    Friend WithEvents ToxicPlus As Windows.Forms.PictureBox
    Friend WithEvents ToxicMinus As Windows.Forms.PictureBox
End Class
