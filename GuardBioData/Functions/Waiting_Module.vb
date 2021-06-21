Imports DevExpress.XtraSplashScreen

Module Waiting_Module
    Sub Start_Waiting()
        Try
            End_Waiting()
            Dim f As New Frm_WaitingScreen
            SplashScreenManager.ShowForm(f, GetType(GuardBioData.Frm_WaitingScreen), True, True)
        Catch ex As Exception
        End Try
    End Sub
    Sub End_Waiting()
        Try
            SplashScreenManager.CloseForm()
        Catch ex As Exception
        End Try
    End Sub
End Module
