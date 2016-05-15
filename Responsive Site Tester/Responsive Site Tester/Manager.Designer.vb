<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.changeloc = New System.Windows.Forms.Button()
        Me.applybtn = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.fullscreen = New System.Windows.Forms.RadioButton()
        Me.iphonePortrait = New System.Windows.Forms.RadioButton()
        Me.iphoneLandscape = New System.Windows.Forms.RadioButton()
        Me.Manual = New System.Windows.Forms.RadioButton()
        Me.width = New System.Windows.Forms.NumericUpDown()
        Me.height = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ipadPortrait = New System.Windows.Forms.RadioButton()
        Me.ipadLandscape = New System.Windows.Forms.RadioButton()
        CType(Me.width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.height, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a screen size to test:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Browser Location:"
        '
        'changeloc
        '
        Me.changeloc.Location = New System.Drawing.Point(13, 30)
        Me.changeloc.Name = "changeloc"
        Me.changeloc.Size = New System.Drawing.Size(174, 23)
        Me.changeloc.TabIndex = 2
        Me.changeloc.Text = "Change"
        Me.changeloc.UseVisualStyleBackColor = True
        '
        'applybtn
        '
        Me.applybtn.Location = New System.Drawing.Point(13, 334)
        Me.applybtn.Name = "applybtn"
        Me.applybtn.Size = New System.Drawing.Size(174, 23)
        Me.applybtn.TabIndex = 3
        Me.applybtn.Text = "Apply Settings"
        Me.applybtn.UseVisualStyleBackColor = True
        '
        'closebtn
        '
        Me.closebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closebtn.Location = New System.Drawing.Point(173, 1)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(25, 23)
        Me.closebtn.TabIndex = 4
        Me.closebtn.Text = "X"
        Me.closebtn.UseVisualStyleBackColor = True
        Me.closebtn.Visible = False
        '
        'fullscreen
        '
        Me.fullscreen.AutoSize = True
        Me.fullscreen.Checked = True
        Me.fullscreen.Location = New System.Drawing.Point(12, 131)
        Me.fullscreen.Name = "fullscreen"
        Me.fullscreen.Size = New System.Drawing.Size(78, 17)
        Me.fullscreen.TabIndex = 5
        Me.fullscreen.TabStop = True
        Me.fullscreen.Text = "Full Screen"
        Me.fullscreen.UseVisualStyleBackColor = True
        '
        'iphonePortrait
        '
        Me.iphonePortrait.AutoSize = True
        Me.iphonePortrait.Location = New System.Drawing.Point(12, 155)
        Me.iphonePortrait.Name = "iphonePortrait"
        Me.iphonePortrait.Size = New System.Drawing.Size(150, 17)
        Me.iphonePortrait.TabIndex = 6
        Me.iphonePortrait.Text = "iPhone Portrait (310 x 352)"
        Me.iphonePortrait.UseVisualStyleBackColor = True
        '
        'iphoneLandscape
        '
        Me.iphoneLandscape.AutoSize = True
        Me.iphoneLandscape.Location = New System.Drawing.Point(12, 179)
        Me.iphoneLandscape.Name = "iphoneLandscape"
        Me.iphoneLandscape.Size = New System.Drawing.Size(170, 17)
        Me.iphoneLandscape.TabIndex = 7
        Me.iphoneLandscape.Text = "iPhone Landscape (468 x 202)"
        Me.iphoneLandscape.UseVisualStyleBackColor = True
        '
        'Manual
        '
        Me.Manual.AutoSize = True
        Me.Manual.Location = New System.Drawing.Point(12, 248)
        Me.Manual.Name = "Manual"
        Me.Manual.Size = New System.Drawing.Size(63, 17)
        Me.Manual.TabIndex = 8
        Me.Manual.Text = "Manual:"
        Me.Manual.UseVisualStyleBackColor = True
        '
        'width
        '
        Me.width.Enabled = False
        Me.width.Location = New System.Drawing.Point(27, 282)
        Me.width.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.width.Name = "width"
        Me.width.Size = New System.Drawing.Size(120, 20)
        Me.width.TabIndex = 9
        '
        'height
        '
        Me.height.Enabled = False
        Me.height.Location = New System.Drawing.Point(26, 298)
        Me.height.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.height.Name = "height"
        Me.height.Size = New System.Drawing.Size(120, 20)
        Me.height.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "px"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "px"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Y"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Key: Name (Width x Height)"
        '
        'ipadPortrait
        '
        Me.ipadPortrait.AutoSize = True
        Me.ipadPortrait.Location = New System.Drawing.Point(12, 202)
        Me.ipadPortrait.Name = "ipadPortrait"
        Me.ipadPortrait.Size = New System.Drawing.Size(138, 17)
        Me.ipadPortrait.TabIndex = 18
        Me.ipadPortrait.TabStop = True
        Me.ipadPortrait.Text = "iPad Portrait (750 x 920)"
        Me.ipadPortrait.UseVisualStyleBackColor = True
        '
        'ipadLandscape
        '
        Me.ipadLandscape.AutoSize = True
        Me.ipadLandscape.Location = New System.Drawing.Point(12, 225)
        Me.ipadLandscape.Name = "ipadLandscape"
        Me.ipadLandscape.Size = New System.Drawing.Size(164, 17)
        Me.ipadLandscape.TabIndex = 19
        Me.ipadLandscape.TabStop = True
        Me.ipadLandscape.Text = "iPad Landscape (1010 x 660)"
        Me.ipadLandscape.UseVisualStyleBackColor = True
        '
        'Manager
        '
        Me.AcceptButton = Me.applybtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.closebtn
        Me.ClientSize = New System.Drawing.Size(199, 369)
        Me.Controls.Add(Me.ipadLandscape)
        Me.Controls.Add(Me.ipadPortrait)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.height)
        Me.Controls.Add(Me.width)
        Me.Controls.Add(Me.Manual)
        Me.Controls.Add(Me.iphoneLandscape)
        Me.Controls.Add(Me.iphonePortrait)
        Me.Controls.Add(Me.fullscreen)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.applybtn)
        Me.Controls.Add(Me.changeloc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manager"
        Me.TopMost = True
        CType(Me.width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.height, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents changeloc As Button
    Friend WithEvents applybtn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents fullscreen As RadioButton
    Friend WithEvents iphonePortrait As RadioButton
    Friend WithEvents iphoneLandscape As RadioButton
    Friend WithEvents Manual As RadioButton
    Friend WithEvents width As NumericUpDown
    Friend WithEvents height As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ipadPortrait As RadioButton
    Friend WithEvents ipadLandscape As RadioButton
End Class
