Namespace My
    Partial Friend Class MyApplication
        Inherits Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase

        Public Sub New(Optional ByVal licenseKey As String = "Ngo9BigBOggjHTQxAR8/V1NHaF5cXmVCf1JpRnxbf1xzZFNMYVVbRXNPMyBoS35RdURjW3hednVcR2VVUUV2")
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            ' Register Syncfusion License
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = True
            Me.ShutdownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub

    End Class
End Namespace
