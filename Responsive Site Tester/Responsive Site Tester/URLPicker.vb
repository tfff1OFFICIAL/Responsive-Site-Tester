Public Class URLPicker
    Public newURL
    Private Sub location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LocationText.Text = Form1.Fasterbrowser1.Url.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        newURL = LocationText.Text()
        Hide()
    End Sub
End Class