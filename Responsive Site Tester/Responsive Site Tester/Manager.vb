Public Class Manager
    Private Sub Manager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Close()
    End Sub

    Private Sub changeloc_Click(sender As Object, e As EventArgs) Handles changeloc.Click
        URLPicker.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Fasterbrowser1.Refresh()
    End Sub

    Private Sub applybtn_Click(sender As Object, e As EventArgs) Handles applybtn.Click
        If Not URLPicker.newURL = Form1.Fasterbrowser1.Url.ToString Then
            Form1.Fasterbrowser1.Navigate(URLPicker.newURL)
        End If

        If Manual.Checked = True Then
            Form1.Fasterbrowser1.Width = width.Value
            Form1.Fasterbrowser1.Height = height.Value
        ElseIf fullscreen.Checked = True Then
            Form1.Width = My.Computer.Screen.Bounds.Width
            Form1.Height = My.Computer.Screen.Bounds.Height
            Form1.Fasterbrowser1.Width = My.Computer.Screen.Bounds.Width
            Form1.Fasterbrowser1.Height = My.Computer.Screen.Bounds.Height
        ElseIf iphonePortrait.Checked = True Then
            Form1.Fasterbrowser1.Width = 310
            Form1.Fasterbrowser1.Height = 352
        ElseIf iphoneLandscape.Checked = True Then
            Form1.Fasterbrowser1.Width = 468
            Form1.Fasterbrowser1.Height = 202
        ElseIf ipadPortrait.Checked = True Then
            Form1.Fasterbrowser1.Width = 750
            Form1.Fasterbrowser1.Height = 920
        ElseIf ipadLandscape.Checked = True Then
            Form1.Fasterbrowser1.Width = 1010
            Form1.Fasterbrowser1.Height = 660
        End If

    End Sub

    Private Sub Manual_CheckedChanged(sender As Object, e As EventArgs) Handles Manual.CheckedChanged
        width.Enabled = Manual.Checked
        height.Enabled = Manual.Checked
    End Sub

    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fullscreen.Text = "Full Screen (" + Form1.Width.ToString + " x " + Form1.Height.ToString + ")"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        credits.Show()
    End Sub
End Class