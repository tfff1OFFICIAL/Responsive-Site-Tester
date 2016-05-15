<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class URLPicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(URLPicker))
        Me.LocationText = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LocationText
        '
        Me.LocationText.Location = New System.Drawing.Point(13, 13)
        Me.LocationText.Name = "LocationText"
        Me.LocationText.Size = New System.Drawing.Size(397, 20)
        Me.LocationText.TabIndex = 0
        Me.LocationText.Text = "http://"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(397, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'close
        '
        Me.close.Enabled = False
        Me.close.Location = New System.Drawing.Point(335, 13)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(75, 23)
        Me.close.TabIndex = 2
        Me.close.Text = "Close"
        Me.close.UseVisualStyleBackColor = True
        Me.close.Visible = False
        '
        'URLPicker
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.close
        Me.ClientSize = New System.Drawing.Size(422, 67)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LocationText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "URLPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Please Enter a Location"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LocationText As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents close As Button
End Class
