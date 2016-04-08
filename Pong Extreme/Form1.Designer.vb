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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pin1timer = New System.Windows.Forms.Timer(Me.components)
        Me.pin3timer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Pin1 = New System.Windows.Forms.PictureBox()
        Me.Pin2 = New System.Windows.Forms.PictureBox()
        Me.mewin = New System.Windows.Forms.Label()
        Me.comwin = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Score = New System.Windows.Forms.Timer(Me.components)
        Me.ball = New System.Windows.Forms.Button()
        CType(Me.Pin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pin2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'pin1timer
        '
        Me.pin1timer.Enabled = True
        Me.pin1timer.Interval = 1
        '
        'pin3timer
        '
        Me.pin3timer.Enabled = True
        Me.pin3timer.Interval = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(35, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Pin1
        '
        Me.Pin1.BackColor = System.Drawing.Color.Lime
        Me.Pin1.Location = New System.Drawing.Point(12, 139)
        Me.Pin1.Name = "Pin1"
        Me.Pin1.Size = New System.Drawing.Size(15, 100)
        Me.Pin1.TabIndex = 1
        Me.Pin1.TabStop = False
        '
        'Pin2
        '
        Me.Pin2.BackColor = System.Drawing.Color.Lime
        Me.Pin2.Location = New System.Drawing.Point(927, 139)
        Me.Pin2.Name = "Pin2"
        Me.Pin2.Size = New System.Drawing.Size(15, 100)
        Me.Pin2.TabIndex = 2
        Me.Pin2.TabStop = False
        '
        'mewin
        '
        Me.mewin.AutoSize = True
        Me.mewin.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mewin.ForeColor = System.Drawing.Color.White
        Me.mewin.Location = New System.Drawing.Point(12, 9)
        Me.mewin.Name = "mewin"
        Me.mewin.Size = New System.Drawing.Size(26, 29)
        Me.mewin.TabIndex = 4
        Me.mewin.Text = "0"
        '
        'comwin
        '
        Me.comwin.AutoSize = True
        Me.comwin.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comwin.ForeColor = System.Drawing.Color.White
        Me.comwin.Location = New System.Drawing.Point(916, 9)
        Me.comwin.Name = "comwin"
        Me.comwin.Size = New System.Drawing.Size(26, 29)
        Me.comwin.TabIndex = 5
        Me.comwin.Text = "0"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InfoText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(682, 463)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "End"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.WindowText
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(301, 463)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 32)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Additional Settings"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.InfoText
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(507, 463)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(169, 32)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Pause"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Score
        '
        Me.Score.Enabled = True
        Me.Score.Interval = 1
        '
        'ball
        '
        Me.ball.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ball.Enabled = False
        Me.ball.FlatAppearance.BorderSize = 0
        Me.ball.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ball.Location = New System.Drawing.Point(481, 219)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(20, 20)
        Me.ball.TabIndex = 15
        Me.ball.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(954, 507)
        Me.Controls.Add(Me.ball)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.comwin)
        Me.Controls.Add(Me.mewin)
        Me.Controls.Add(Me.Pin2)
        Me.Controls.Add(Me.Pin1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Pong Extreme Edition - Programmed By: Horatiu Lazu"
        CType(Me.Pin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pin2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pin1timer As System.Windows.Forms.Timer
    Friend WithEvents pin3timer As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Pin1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pin2 As System.Windows.Forms.PictureBox
    Friend WithEvents mewin As System.Windows.Forms.Label
    Friend WithEvents comwin As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Score As System.Windows.Forms.Timer
    Friend WithEvents ball As System.Windows.Forms.Button

End Class
