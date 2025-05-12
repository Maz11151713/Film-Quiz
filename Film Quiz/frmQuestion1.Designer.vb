<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion1))
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarQ1 = New System.Windows.Forms.ProgressBar()
        Me.tmrQuetion1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion1.Location = New System.Drawing.Point(44, 23)
        Me.lblQuestion1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(397, 24)
        Me.lblQuestion1.TabIndex = 0
        Me.lblQuestion1.Text = "In What Year Was Audrey Hepburn Born?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 115)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(440, 124)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'btnAnswer1
        '
        Me.btnAnswer1.AutoSize = True
        Me.btnAnswer1.Location = New System.Drawing.Point(16, 17)
        Me.btnAnswer1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(72, 28)
        Me.btnAnswer1.TabIndex = 3
        Me.btnAnswer1.TabStop = True
        Me.btnAnswer1.Text = "1920"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.AutoSize = True
        Me.btnAnswer2.Location = New System.Drawing.Point(16, 48)
        Me.btnAnswer2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(72, 28)
        Me.btnAnswer2.TabIndex = 4
        Me.btnAnswer2.TabStop = True
        Me.btnAnswer2.Text = "1921"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.AutoSize = True
        Me.btnAnswer3.Location = New System.Drawing.Point(16, 80)
        Me.btnAnswer3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(72, 28)
        Me.btnAnswer3.TabIndex = 5
        Me.btnAnswer3.TabStop = True
        Me.btnAnswer3.Text = "1931"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.AutoSize = True
        Me.btnAnswer4.Location = New System.Drawing.Point(16, 114)
        Me.btnAnswer4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(72, 28)
        Me.btnAnswer4.TabIndex = 6
        Me.btnAnswer4.TabStop = True
        Me.btnAnswer4.Text = "1935"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(454, 295)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(104, 35)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAnswer1)
        Me.GroupBox1.Controls.Add(Me.btnAnswer2)
        Me.GroupBox1.Controls.Add(Me.btnAnswer4)
        Me.GroupBox1.Controls.Add(Me.btnAnswer3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(205, 98)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(135, 164)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'ProgressBarQ1
        '
        Me.ProgressBarQ1.Location = New System.Drawing.Point(33, 295)
        Me.ProgressBarQ1.Name = "ProgressBarQ1"
        Me.ProgressBarQ1.Size = New System.Drawing.Size(376, 38)
        Me.ProgressBarQ1.TabIndex = 9
        '
        'tmrQuetion1
        '
        Me.tmrQuetion1.Interval = 1000
        '
        'frmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.ProgressBarQ1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmQuestion1"
        Me.Text = "frmQuestion1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAnswer1 As RadioButton
    Friend WithEvents btnAnswer2 As RadioButton
    Friend WithEvents btnAnswer3 As RadioButton
    Friend WithEvents btnAnswer4 As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProgressBarQ1 As ProgressBar
    Friend WithEvents tmrQuetion1 As Timer
End Class
