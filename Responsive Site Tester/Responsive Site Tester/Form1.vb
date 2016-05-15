Imports Gecko
Public Class Form1

    Sub New()
        InitializeComponent()
        Xpcom.Initialize(Environment.CurrentDirectory + "\xulrunner")
        GeckoPreferences.Default("extensions.blocklist.enabled") = False
        GeckoPreferences.Default("fasterbrowser.link.open_newwindow.override.external") = 2
        GeckoPreferences.Default("gecko.link.open_newwindow.restriction") = -1
        GeckoPreferences.Default("dom.successive_dialog_time_limit") = 0

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.Show()
        Fasterbrowser1.Width = Width
        Fasterbrowser1.Height = Height
        Fasterbrowser1.Navigate(Application.StartupPath + "\startup.html")
    End Sub

    Private Sub Fasterbrowser1_Navigated(sender As Object, e As GeckoNavigatedEventArgs) Handles Fasterbrowser1.Navigated
        Enabled = True
        Manager.Enabled = True
    End Sub

    Private Sub Fasterbrowser1_Navigating(sender As Object, e As Events.GeckoNavigatingEventArgs) Handles Fasterbrowser1.Navigating
        Enabled = False
        Manager.Enabled = False
    End Sub
End Class
