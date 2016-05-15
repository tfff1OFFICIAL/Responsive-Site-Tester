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
    End Sub
End Class
