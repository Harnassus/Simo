<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LabelVolume = New System.Windows.Forms.Label()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.ComboBoxChooseVoice = New System.Windows.Forms.ComboBox()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.ButtonResume = New System.Windows.Forms.Button()
        Me.TrackBarvolume = New System.Windows.Forms.TrackBar()
        Me.TrackBarSpeed = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBarvolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 5)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(554, 187)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = "Hi! I'm Simo i'm vinci's first ever application. I'm very awesome"
        '
        'LabelVolume
        '
        Me.LabelVolume.AutoSize = True
        Me.LabelVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVolume.Location = New System.Drawing.Point(209, 219)
        Me.LabelVolume.Name = "LabelVolume"
        Me.LabelVolume.Size = New System.Drawing.Size(60, 16)
        Me.LabelVolume.TabIndex = 6
        Me.LabelVolume.Text = "Volume"
        '
        'LabelSpeed
        '
        Me.LabelSpeed.AutoSize = True
        Me.LabelSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSpeed.Location = New System.Drawing.Point(209, 279)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(54, 16)
        Me.LabelSpeed.TabIndex = 7
        Me.LabelSpeed.Text = "Speed"
        '
        'ComboBoxChooseVoice
        '
        Me.ComboBoxChooseVoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxChooseVoice.FormattingEnabled = True
        Me.ComboBoxChooseVoice.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxChooseVoice.Location = New System.Drawing.Point(420, 251)
        Me.ComboBoxChooseVoice.Name = "ComboBoxChooseVoice"
        Me.ComboBoxChooseVoice.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxChooseVoice.TabIndex = 8
        Me.ComboBoxChooseVoice.Text = "Male"
        '
        'ButtonPause
        '
        Me.ButtonPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPause.Location = New System.Drawing.Point(107, 270)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(74, 33)
        Me.ButtonPause.TabIndex = 9
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'ButtonResume
        '
        Me.ButtonResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResume.Location = New System.Drawing.Point(94, 210)
        Me.ButtonResume.Name = "ButtonResume"
        Me.ButtonResume.Size = New System.Drawing.Size(96, 33)
        Me.ButtonResume.TabIndex = 10
        Me.ButtonResume.Text = "Resume"
        Me.ButtonResume.UseVisualStyleBackColor = True
        '
        'TrackBarvolume
        '
        Me.TrackBarvolume.Location = New System.Drawing.Point(275, 219)
        Me.TrackBarvolume.Maximum = 100
        Me.TrackBarvolume.Name = "TrackBarvolume"
        Me.TrackBarvolume.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarvolume.TabIndex = 11
        Me.TrackBarvolume.Value = 50
        '
        'TrackBarSpeed
        '
        Me.TrackBarSpeed.Location = New System.Drawing.Point(275, 270)
        Me.TrackBarSpeed.Minimum = -10
        Me.TrackBarSpeed.Name = "TrackBarSpeed"
        Me.TrackBarSpeed.Size = New System.Drawing.Size(104, 45)
        Me.TrackBarSpeed.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(562, 327)
        Me.Controls.Add(Me.TrackBarSpeed)
        Me.Controls.Add(Me.TrackBarvolume)
        Me.Controls.Add(Me.ButtonResume)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.ComboBoxChooseVoice)
        Me.Controls.Add(Me.LabelSpeed)
        Me.Controls.Add(Me.LabelVolume)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBarvolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelVolume As System.Windows.Forms.Label
    Friend WithEvents LabelSpeed As System.Windows.Forms.Label
    Friend WithEvents ComboBoxChooseVoice As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonPause As System.Windows.Forms.Button
    Friend WithEvents ButtonResume As System.Windows.Forms.Button
    Friend WithEvents TrackBarvolume As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarSpeed As System.Windows.Forms.TrackBar

End Class
