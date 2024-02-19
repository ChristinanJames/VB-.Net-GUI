<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NosForm))
        Me.myBrowser = New System.Windows.Forms.WebBrowser()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.helpButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'myBrowser
        '
        Me.myBrowser.Location = New System.Drawing.Point(0, 0)
        Me.myBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.myBrowser.Name = "myBrowser"
        Me.myBrowser.Size = New System.Drawing.Size(607, 385)
        Me.myBrowser.TabIndex = 0
        Me.myBrowser.Url = New System.Uri("http://txtURL", System.UriKind.Absolute)
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(12, 411)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(526, 20)
        Me.txtURL.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(544, 403)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(63, 28)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("AR DARLING", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(246, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 41)
        Me.Label1.TabIndex = 4
        '
        'aboutButton
        '
        Me.aboutButton.BackColor = System.Drawing.Color.White
        Me.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.aboutButton.Font = New System.Drawing.Font("Comic Sans MS", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutButton.Location = New System.Drawing.Point(607, 128)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(17, 58)
        Me.aboutButton.TabIndex = 6
        Me.aboutButton.Text = "Help"
        Me.aboutButton.UseVisualStyleBackColor = False
        '
        'helpButton
        '
        Me.helpButton.BackColor = System.Drawing.Color.White
        Me.helpButton.BackgroundImage = CType(resources.GetObject("helpButton.BackgroundImage"), System.Drawing.Image)
        Me.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.helpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpButton.Location = New System.Drawing.Point(606, 2)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(19, 20)
        Me.helpButton.TabIndex = 7
        Me.helpButton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(12, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 27)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("AR DARLING", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(204, 383)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 27)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "NOS"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(607, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(17, 58)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "About"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.myBrowser)
        Me.Controls.Add(Me.aboutButton)
        Me.Name = "NosForm"
        Me.Text = "NOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents aboutButton As System.Windows.Forms.Button
    Friend WithEvents helpButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
