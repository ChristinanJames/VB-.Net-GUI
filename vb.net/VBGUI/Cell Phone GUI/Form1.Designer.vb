<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Camera = New System.Windows.Forms.RadioButton()
        Me.Speaker = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Windows = New System.Windows.Forms.Button()
        Me.callButton = New System.Windows.Forms.Button()
        Me.internetButton = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Panel()
        Me.messageButton = New System.Windows.Forms.Button()
        Me.appsButton = New System.Windows.Forms.Button()
        Me.Taskbar = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taskbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(59, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 14)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "HUAWEI"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Camera
        '
        Me.Camera.AutoSize = True
        Me.Camera.Location = New System.Drawing.Point(163, 24)
        Me.Camera.Name = "Camera"
        Me.Camera.Size = New System.Drawing.Size(61, 17)
        Me.Camera.TabIndex = 1
        Me.Camera.TabStop = True
        Me.Camera.Text = "Camera"
        Me.Camera.UseVisualStyleBackColor = True
        '
        'Speaker
        '
        Me.Speaker.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Speaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Speaker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Speaker.Location = New System.Drawing.Point(106, 24)
        Me.Speaker.Name = "Speaker"
        Me.Speaker.Size = New System.Drawing.Size(52, 4)
        Me.Speaker.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(199, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(55, 13)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "11:00 PM"
        '
        'Background
        '
        Me.Background.BackColor = System.Drawing.Color.Black
        Me.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Background.Image = CType(resources.GetObject("Background.Image"), System.Drawing.Image)
        Me.Background.Location = New System.Drawing.Point(20, 73)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(227, 339)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Background.TabIndex = 5
        Me.Background.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(20, 360)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'Windows
        '
        Me.Windows.BackgroundImage = CType(resources.GetObject("Windows.BackgroundImage"), System.Drawing.Image)
        Me.Windows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Windows.Location = New System.Drawing.Point(36, 374)
        Me.Windows.Name = "Windows"
        Me.Windows.Size = New System.Drawing.Size(32, 33)
        Me.Windows.TabIndex = 9
        Me.Windows.UseVisualStyleBackColor = True
        '
        'callButton
        '
        Me.callButton.BackgroundImage = CType(resources.GetObject("callButton.BackgroundImage"), System.Drawing.Image)
        Me.callButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.callButton.Location = New System.Drawing.Point(74, 374)
        Me.callButton.Name = "callButton"
        Me.callButton.Size = New System.Drawing.Size(32, 33)
        Me.callButton.TabIndex = 11
        Me.callButton.UseVisualStyleBackColor = True
        '
        'internetButton
        '
        Me.internetButton.BackgroundImage = CType(resources.GetObject("internetButton.BackgroundImage"), System.Drawing.Image)
        Me.internetButton.Location = New System.Drawing.Point(115, 374)
        Me.internetButton.Name = "internetButton"
        Me.internetButton.Size = New System.Drawing.Size(32, 33)
        Me.internetButton.TabIndex = 12
        Me.internetButton.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.BackgroundImage = CType(resources.GetObject("Status.BackgroundImage"), System.Drawing.Image)
        Me.Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Status.Location = New System.Drawing.Point(137, 47)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(56, 22)
        Me.Status.TabIndex = 14
        Me.Status.Visible = False
        '
        'messageButton
        '
        Me.messageButton.BackgroundImage = CType(resources.GetObject("messageButton.BackgroundImage"), System.Drawing.Image)
        Me.messageButton.Location = New System.Drawing.Point(156, 374)
        Me.messageButton.Name = "messageButton"
        Me.messageButton.Size = New System.Drawing.Size(32, 33)
        Me.messageButton.TabIndex = 15
        Me.messageButton.UseVisualStyleBackColor = True
        '
        'appsButton
        '
        Me.appsButton.BackgroundImage = CType(resources.GetObject("appsButton.BackgroundImage"), System.Drawing.Image)
        Me.appsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.appsButton.Location = New System.Drawing.Point(197, 374)
        Me.appsButton.Name = "appsButton"
        Me.appsButton.Size = New System.Drawing.Size(32, 33)
        Me.appsButton.TabIndex = 16
        Me.appsButton.UseVisualStyleBackColor = True
        '
        'Taskbar
        '
        Me.Taskbar.BackColor = System.Drawing.Color.Black
        Me.Taskbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Taskbar.Image = CType(resources.GetObject("Taskbar.Image"), System.Drawing.Image)
        Me.Taskbar.Location = New System.Drawing.Point(36, 416)
        Me.Taskbar.Name = "Taskbar"
        Me.Taskbar.Size = New System.Drawing.Size(193, 30)
        Me.Taskbar.TabIndex = 17
        Me.Taskbar.TabStop = False
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(269, 450)
        Me.Controls.Add(Me.appsButton)
        Me.Controls.Add(Me.messageButton)
        Me.Controls.Add(Me.internetButton)
        Me.Controls.Add(Me.callButton)
        Me.Controls.Add(Me.Windows)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Background)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Speaker)
        Me.Controls.Add(Me.Camera)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Taskbar)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GUI"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "GUI"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taskbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Camera As System.Windows.Forms.RadioButton
    Friend WithEvents Speaker As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Windows As System.Windows.Forms.Button
    Friend WithEvents callButton As System.Windows.Forms.Button
    Friend WithEvents internetButton As System.Windows.Forms.Button
    Friend WithEvents Status As System.Windows.Forms.Panel
    Friend WithEvents messageButton As System.Windows.Forms.Button
    Friend WithEvents appsButton As System.Windows.Forms.Button
    Friend WithEvents Taskbar As System.Windows.Forms.PictureBox

End Class
