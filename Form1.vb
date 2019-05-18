Public Class Form1

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Process.Start("msinfo32.exe")
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Process.Start("sysdm.cpl")
    End Sub

    Private Sub LinkLabel13_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Process.Start("osk.exe")
    End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        Process.Start("gpedit.msc")
    End Sub

    Private Sub LinkLabel21_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel21.LinkClicked
        Process.Start("control.exe")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel29.Hide()
        LinkLabel30.Hide()
        LinkLabel31.Hide()
        LinkLabel32.Hide()
        LinkLabel33.Hide()
        LinkLabel34.Hide()
        LinkLabel35.Hide()
        LinkLabel36.Hide()
        LinkLabel37.Hide()
        LinkLabel38.Hide()
        LinkLabel39.Hide()
        LinkLabel40.Hide()
        LinkLabel41.Hide()
        LinkLabel42.Hide()
        LinkLabel43.Hide()
        LinkLabel44.Hide()
        LinkLabel45.Hide()
        LinkLabel46.Hide()
        LinkLabel47.Hide()
        LinkLabel48.Hide()
        LinkLabel49.Hide()
        LinkLabel50.Hide()
        LinkLabel51.Hide()
        LinkLabel52.Hide()
        LinkLabel53.Hide()
        LinkLabel54.Hide()
        LinkLabel55.Hide()
        LinkLabel56.Hide()
        LinkLabel57.Hide()
        LinkLabel58.Hide()
        LinkLabel59.Hide()
        LinkLabel60.Hide()
        LinkLabel61.Hide()
        LinkLabel62.Hide()
        LinkLabel63.Hide()
        LinkLabel64.Hide()
        LinkLabel65.Hide()
        LinkLabel66.Hide()
        LinkLabel67.Hide()
        LinkLabel68.Hide()
        LinkLabel69.Hide()
        LinkLabel70.Hide()
        LinkLabel71.Hide()
        LinkLabel72.Hide()
        LinkLabel73.Hide()
        LinkLabel74.Hide()
        LinkLabel75.Hide()
        LinkLabel76.Hide()
        LinkLabel78.Hide()
        LinkLabel79.Hide()
        LinkLabel80.Hide()
        LinkLabel81.Hide()
        LinkLabel82.Hide()
        LinkLabel83.Hide()
        LinkLabel84.Hide()
        LinkLabel85.Hide()
        LinkLabel86.Hide()
        LinkLabel87.Hide()
        LinkLabel88.Hide()

    End Sub

    Private Sub LinkLabel65_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel65.LinkClicked
        Shell("control /name Microsoft.UserAccounts")
    End Sub

    Private Sub LinkLabel69_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel69.LinkClicked
        Shell("control /name Microsoft.NetworkAndSharingCenter")
    End Sub

    Private Sub LinkLabel70_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel70.LinkClicked
        Shell("control /name Microsoft.BitLockerDriveEncryption")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("ncpa.cpl")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Text = "Служебные программы Windows 7/8/8.1/10. Страница 2"
        LinkLabel1.Hide()
        LinkLabel2.Hide()
        LinkLabel3.Hide()
        LinkLabel4.Hide()
        LinkLabel5.Hide()
        LinkLabel6.Hide()
        LinkLabel7.Hide()
        LinkLabel8.Hide()
        LinkLabel9.Hide()
        LinkLabel10.Hide()
        LinkLabel11.Hide()
        LinkLabel12.Hide()
        LinkLabel13.Hide()
        LinkLabel14.Hide()
        LinkLabel15.Hide()
        LinkLabel16.Hide()
        LinkLabel17.Hide()
        LinkLabel18.Hide()
        LinkLabel19.Hide()
        LinkLabel20.Hide()
        LinkLabel21.Hide()
        LinkLabel22.Hide()
        LinkLabel23.Hide()
        LinkLabel24.Hide()
        LinkLabel25.Hide()
        LinkLabel26.Hide()
        LinkLabel27.Hide()
        LinkLabel28.Hide()
        LinkLabel57.Hide()
        LinkLabel58.Hide()
        LinkLabel59.Hide()
        LinkLabel60.Hide()
        LinkLabel61.Hide()
        LinkLabel62.Hide()
        LinkLabel63.Hide()
        LinkLabel64.Hide()
        LinkLabel65.Hide()
        LinkLabel66.Hide()
        LinkLabel67.Hide()
        LinkLabel68.Hide()
        LinkLabel69.Hide()
        LinkLabel70.Hide()
        LinkLabel71.Hide()
        LinkLabel72.Hide()
        LinkLabel73.Hide()
        LinkLabel74.Hide()
        LinkLabel75.Hide()
        LinkLabel76.Hide()
        LinkLabel77.Hide()
        LinkLabel78.Hide()
        LinkLabel79.Hide()
        LinkLabel80.Hide()
        LinkLabel81.Hide()
        LinkLabel82.Hide()
        LinkLabel83.Hide()
        LinkLabel84.Hide()
        LinkLabel85.Hide()
        LinkLabel86.Hide()
        LinkLabel87.Hide()
        LinkLabel88.Hide()


        LinkLabel29.Show()
        LinkLabel30.Show()
        LinkLabel31.Show()
        LinkLabel32.Show()
        LinkLabel33.Show()
        LinkLabel34.Show()
        LinkLabel35.Show()
        LinkLabel36.Show()
        LinkLabel37.Show()
        LinkLabel38.Show()
        LinkLabel39.Show()
        LinkLabel40.Show()
        LinkLabel41.Show()
        LinkLabel42.Show()
        LinkLabel43.Show()
        LinkLabel44.Show()
        LinkLabel45.Show()
        LinkLabel46.Show()
        LinkLabel47.Show()
        LinkLabel48.Show()
        LinkLabel49.Show()
        LinkLabel50.Show()
        LinkLabel51.Show()
        LinkLabel52.Show()
        LinkLabel53.Show()
        LinkLabel54.Show()
        LinkLabel55.Show()
        LinkLabel56.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form2.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("cmd.exe")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim StrTemp As String
        StrTemp = Me.Text
        StrTemp = Microsoft.VisualBasic.Right(StrTemp, Len(StrTemp) - 1) & Microsoft.VisualBasic.Left(StrTemp, 1)
        Me.Text = StrTemp
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Text = "Служебные программы Windows 7/8/8.1/10. Страница 1"
        LinkLabel29.Hide()
        LinkLabel30.Hide()
        LinkLabel31.Hide()
        LinkLabel32.Hide()
        LinkLabel33.Hide()
        LinkLabel34.Hide()
        LinkLabel35.Hide()
        LinkLabel36.Hide()
        LinkLabel37.Hide()
        LinkLabel38.Hide()
        LinkLabel39.Hide()
        LinkLabel40.Hide()
        LinkLabel41.Hide()
        LinkLabel42.Hide()
        LinkLabel43.Hide()
        LinkLabel44.Hide()
        LinkLabel45.Hide()
        LinkLabel46.Hide()
        LinkLabel47.Hide()
        LinkLabel48.Hide()
        LinkLabel49.Hide()
        LinkLabel50.Hide()
        LinkLabel51.Hide()
        LinkLabel52.Hide()
        LinkLabel53.Hide()
        LinkLabel54.Hide()
        LinkLabel55.Hide()
        LinkLabel56.Hide()
        LinkLabel57.Hide()
        LinkLabel58.Hide()
        LinkLabel59.Hide()
        LinkLabel60.Hide()
        LinkLabel61.Hide()
        LinkLabel62.Hide()
        LinkLabel63.Hide()
        LinkLabel64.Hide()
        LinkLabel65.Hide()
        LinkLabel66.Hide()
        LinkLabel67.Hide()
        LinkLabel68.Hide()
        LinkLabel69.Hide()
        LinkLabel70.Hide()
        LinkLabel71.Hide()
        LinkLabel72.Hide()
        LinkLabel73.Hide()
        LinkLabel74.Hide()
        LinkLabel75.Hide()
        LinkLabel76.Hide()
        LinkLabel77.Hide()
        LinkLabel78.Hide()
        LinkLabel79.Hide()
        LinkLabel80.Hide()
        LinkLabel81.Hide()
        LinkLabel82.Hide()
        LinkLabel83.Hide()
        LinkLabel84.Hide()
        LinkLabel85.Hide()
        LinkLabel86.Hide()
        LinkLabel87.Hide()
        LinkLabel88.Hide()


        LinkLabel1.Show()
        LinkLabel2.Show()
        LinkLabel3.Show()
        LinkLabel4.Show()
        LinkLabel5.Show()
        LinkLabel6.Show()
        LinkLabel7.Show()
        LinkLabel8.Show()
        LinkLabel9.Show()
        LinkLabel10.Show()
        LinkLabel11.Show()
        LinkLabel12.Show()
        LinkLabel13.Show()
        LinkLabel14.Show()
        LinkLabel15.Show()
        LinkLabel16.Show()
        LinkLabel17.Show()
        LinkLabel18.Show()
        LinkLabel19.Show()
        LinkLabel20.Show()
        LinkLabel21.Show()
        LinkLabel22.Show()
        LinkLabel23.Show()
        LinkLabel24.Show()
        LinkLabel25.Show()
        LinkLabel26.Show()
        LinkLabel27.Show()
        LinkLabel28.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Text = "Служебные программы Windows 7/8/8.1/10. Страница 3"
        LinkLabel57.Show()
        LinkLabel58.Show()
        LinkLabel59.Show()
        LinkLabel60.Show()
        LinkLabel61.Show()
        LinkLabel62.Show()
        LinkLabel63.Show()
        LinkLabel64.Show()
        LinkLabel65.Show()
        LinkLabel66.Show()
        LinkLabel67.Show()
        LinkLabel68.Show()
        LinkLabel69.Show()
        LinkLabel70.Show()
        LinkLabel71.Show()
        LinkLabel72.Show()
        LinkLabel73.Show()
        LinkLabel74.Show()
        LinkLabel75.Show()
        LinkLabel76.Show()
        LinkLabel77.Show()
        LinkLabel78.Show()
        LinkLabel79.Show()
        LinkLabel80.Show()
        LinkLabel81.Show()
        LinkLabel82.Show()

        LinkLabel84.Show()
        LinkLabel85.Show()


        LinkLabel1.Hide()
        LinkLabel2.Hide()
        LinkLabel3.Hide()
        LinkLabel4.Hide()
        LinkLabel5.Hide()
        LinkLabel6.Hide()
        LinkLabel7.Hide()
        LinkLabel8.Hide()
        LinkLabel9.Hide()
        LinkLabel10.Hide()
        LinkLabel11.Hide()
        LinkLabel12.Hide()
        LinkLabel13.Hide()
        LinkLabel14.Hide()
        LinkLabel15.Hide()
        LinkLabel16.Hide()
        LinkLabel17.Hide()
        LinkLabel18.Hide()
        LinkLabel19.Hide()
        LinkLabel20.Hide()
        LinkLabel21.Hide()
        LinkLabel22.Hide()
        LinkLabel23.Hide()
        LinkLabel24.Hide()
        LinkLabel25.Hide()
        LinkLabel26.Hide()
        LinkLabel27.Hide()
        LinkLabel28.Hide()
        LinkLabel29.Hide()
        LinkLabel30.Hide()
        LinkLabel31.Hide()
        LinkLabel32.Hide()
        LinkLabel33.Hide()
        LinkLabel34.Hide()
        LinkLabel35.Hide()
        LinkLabel36.Hide()
        LinkLabel37.Hide()
        LinkLabel38.Hide()
        LinkLabel39.Hide()
        LinkLabel40.Hide()
        LinkLabel41.Hide()
        LinkLabel42.Hide()
        LinkLabel43.Hide()
        LinkLabel44.Hide()
        LinkLabel45.Hide()
        LinkLabel46.Hide()
        LinkLabel47.Hide()
        LinkLabel48.Hide()
        LinkLabel49.Hide()
        LinkLabel50.Hide()
        LinkLabel51.Hide()
        LinkLabel52.Hide()
        LinkLabel53.Hide()
        LinkLabel54.Hide()
        LinkLabel55.Hide()
        LinkLabel56.Hide()
        LinkLabel83.Hide()
        LinkLabel86.Hide()
        LinkLabel87.Hide()
        LinkLabel88.Hide()
    End Sub

    Private Sub LinkLabel48_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel48.LinkClicked
        Shell("control /name Microsoft.Keyboard")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("regedit.exe")
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("msconfig.exe")
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("main.cpl")
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Process.Start("dxdiag.exe")
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Process.Start("wscui.cpl")
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Process.Start("inetcpl.cpl")
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Process.Start("hdwwiz.cpl")
    End Sub

    Private Sub LinkLabel12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        Process.Start("appwiz.cpl")
    End Sub

    Private Sub LinkLabel14_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        Process.Start("powercfg.cpl")
    End Sub

    Private Sub LinkLabel16_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        Process.Start("secpol.msc")
    End Sub

    Private Sub LinkLabel17_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        Process.Start("verifier.exe")
    End Sub

    Private Sub LinkLabel18_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        Process.Start("taskmgr.exe")
    End Sub

    Private Sub LinkLabel19_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel19.LinkClicked
        Process.Start("taskschd.msc")
    End Sub

    Private Sub LinkLabel20_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel20.LinkClicked
        Process.Start("services.msc")
    End Sub

    Private Sub LinkLabel22_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel22.LinkClicked
        Process.Start("compmgmt.msc")
    End Sub

    Private Sub LinkLabel23_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel23.LinkClicked
        Process.Start("cleanmgr.exe")
    End Sub

    Private Sub LinkLabel24_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel24.LinkClicked
        Shell("cmd /X /C start explorer.exe shell:::{ED7BA470-8E54-465E-825C-99712043E01C}")
    End Sub

    Private Sub LinkLabel25_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel25.LinkClicked
        Shell("cmd /X /C start explorer.exe %temp%")
    End Sub

    Private Sub LinkLabel26_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel26.LinkClicked
        Process.Start("hdwwiz.exe")
    End Sub

    Private Sub LinkLabel27_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel27.LinkClicked
        Process.Start("sigverif.exe")
    End Sub

    Private Sub LinkLabel28_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel28.LinkClicked
        Process.Start("certmgr.msc")
    End Sub

    Private Sub LinkLabel29_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel29.LinkClicked
        Shell("control /name Microsoft.Display")
    End Sub

    Private Sub LinkLabel30_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel30.LinkClicked
        Shell("control /name Microsoft.Personalization")
    End Sub

    Private Sub LinkLabel31_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel31.LinkClicked
        Shell("control /name Microsoft.WindowsUpdate")
    End Sub

    Private Sub LinkLabel32_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel32.LinkClicked
        Shell("control /name Microsoft.CardSpace")
    End Sub

    Private Sub LinkLabel33_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel33.LinkClicked

        Shell("control /name Microsoft.AutoPlay")
    End Sub

    Private Sub LinkLabel34_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel34.LinkClicked
        Shell("control /name Microsoft.OfflineFiles")
    End Sub

    Private Sub LinkLabel35_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel35.LinkClicked
        Shell("control /name Microsoft.AdministrativeTools")
    End Sub

    Private Sub LinkLabel36_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel36.LinkClicked
        Shell("control /name Microsoft.BackupAndRestore")
    End Sub

    Private Sub LinkLabel37_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel37.LinkClicked
        Shell("control /name Microsoft.WindowsFirewall")
    End Sub

    Private Sub LinkLabel38_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel38.LinkClicked
        Shell("control /name Microsoft.Recovery")
    End Sub

    Private Sub LinkLabel39_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel39.LinkClicked
        Shell("control /name Microsoft.DesktopGadgets")
    End Sub

    Private Sub LinkLabel40_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel40.LinkClicked
        Shell("control /name Microsoft.DateAndTime")
    End Sub

    Private Sub LinkLabel41_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel41.LinkClicked
        Shell("control /name Microsoft.LocationAndOtherSensors")
    End Sub

    Private Sub LinkLabel42_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel42.LinkClicked
        Shell("control /name Microsoft.CredentialManager")
    End Sub

    Private Sub LinkLabel43_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel43.LinkClicked
        Shell("control /name Microsoft.HomeGroup")
    End Sub

    Private Sub LinkLabel44_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel44.LinkClicked
        Shell("control /name Microsoft.WindowsDefender")
    End Sub

    Private Sub LinkLabel45_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel45.LinkClicked
        Shell("control /name Microsoft.Sound")
    End Sub

    Private Sub LinkLabel46_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel46.LinkClicked
        Shell("control /name Microsoft.NotificationAreaIcons")
    End Sub

    Private Sub LinkLabel47_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel47.LinkClicked
        Shell("control /name Microsoft.GameControllers")
    End Sub

    Private Sub LinkLabel49_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel49.LinkClicked
        Shell("control /name Microsoft.TaskbarAndStartMenu")
    End Sub

    Private Sub LinkLabel50_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel50.LinkClicked
        Shell("control /name Microsoft.IndexingOptions")
    End Sub

    Private Sub LinkLabel51_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel51.LinkClicked
        Shell("control /name Microsoft.FolderOptions")
    End Sub

    Private Sub LinkLabel52_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel52.LinkClicked
        Shell("control /name Microsoft.RemoteAppAndDesktopConnections")
    End Sub

    Private Sub LinkLabel53_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel53.LinkClicked
        Shell("control /name Microsoft.GetPrograms")
    End Sub

    Private Sub LinkLabel54_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel54.LinkClicked
        Shell("control /name Microsoft.GettingStarted")
    End Sub

    Private Sub LinkLabel55_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel55.LinkClicked
        Shell("control /name Microsoft.DefaultPrograms")
    End Sub

    Private Sub LinkLabel56_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel56.LinkClicked
        Shell("control /name Microsoft.SpeechRecognition")
    End Sub

    Private Sub LinkLabel57_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel57.LinkClicked
        Shell("control /name Microsoft.ParentalControls")
    End Sub

    Private Sub LinkLabel58_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel58.LinkClicked
        Shell("control /name Microsoft.System")
    End Sub

    Private Sub LinkLabel59_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel59.LinkClicked
        Shell("control /name Microsoft.ScannersAndCameras")
    End Sub

    Private Sub LinkLabel60_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel60.LinkClicked
        Shell("control /name Microsoft.PerformanceInformationAndTools")
    End Sub

    Private Sub LinkLabel61_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel61.LinkClicked
        Shell("control /name Microsoft.PhoneAndModem")
    End Sub

    Private Sub LinkLabel62_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel62.LinkClicked
        Shell("control /name Microsoft.ColorManagement")
    End Sub

    Private Sub LinkLabel63_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel63.LinkClicked
        Shell("control /name Microsoft.Troubleshooting")
    End Sub

    Private Sub LinkLabel64_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel64.LinkClicked
        Shell("cmd /X /C control /name Microsoft.DevicesAndPrinters")
    End Sub

    Private Sub LinkLabel66_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel66.LinkClicked
        Shell("control /name Microsoft.ActionCenter")
    End Sub

    Private Sub LinkLabel67_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel67.LinkClicked
        Shell("control /name Microsoft.SyncCenter")
    End Sub

    Private Sub LinkLabel68_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel68.LinkClicked
        Shell("control /name Microsoft.EaseOfAccessCenter")
    End Sub

    Private Sub LinkLabel71_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel71.LinkClicked
        Shell("control /name Microsoft.RegionAndLanguage")
    End Sub

    Private Sub LinkLabel72_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel72.LinkClicked
        Process.Start("notepad.exe")
    End Sub

    Private Sub LinkLabel73_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel73.LinkClicked
        Process.Start("dfrgui.exe")
    End Sub

    Private Sub LinkLabel74_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel74.LinkClicked
        Process.Start("Calc.exe")
    End Sub

    Private Sub LinkLabel75_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel75.LinkClicked
        Process.Start("powershell.exe")
    End Sub

    Private Sub LinkLabel76_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel76.LinkClicked
        Shell("cmd /X /C start explorer.exe shell:::{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}")

    End Sub

    Private Sub LinkLabel77_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel77.LinkClicked
        Process.Start("C:\Windows\System32\migwiz\migwiz.exe")
    End Sub

    Private Sub LinkLabel78_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel78.LinkClicked
        Shell("control desk.cpl,,1")
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub LinkLabel79_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel79.LinkClicked
        Process.Start("eventvwr.msc")
    End Sub

    Private Sub LinkLabel80_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel80.LinkClicked
        Process.Start("lusrmgr.msc")
    End Sub

    Private Sub LinkLabel81_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel81.LinkClicked
        Process.Start("dcomcnfg.exe")
    End Sub

    Private Sub LinkLabel82_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel82.LinkClicked
        Shell("cmd /X /C wmic qfe Get Caption, Description, HotFixID, InstalledOn > %Temp%\ListUpdates.txt && %Temp%\ListUpdates.txt")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Text = "Служебные программы Windows 7/8/8.1/10. Страница 4"
        LinkLabel1.Hide()
        LinkLabel2.Hide()
        LinkLabel3.Hide()
        LinkLabel4.Hide()
        LinkLabel5.Hide()
        LinkLabel6.Hide()
        LinkLabel7.Hide()
        LinkLabel8.Hide()
        LinkLabel9.Hide()
        LinkLabel10.Hide()
        LinkLabel11.Hide()
        LinkLabel12.Hide()
        LinkLabel13.Hide()
        LinkLabel14.Hide()
        LinkLabel15.Hide()
        LinkLabel16.Hide()
        LinkLabel17.Hide()
        LinkLabel18.Hide()
        LinkLabel19.Hide()
        LinkLabel20.Hide()
        LinkLabel21.Hide()
        LinkLabel22.Hide()
        LinkLabel23.Hide()
        LinkLabel24.Hide()
        LinkLabel25.Hide()
        LinkLabel26.Hide()
        LinkLabel27.Hide()
        LinkLabel28.Hide()
        LinkLabel29.Hide()
        LinkLabel30.Hide()
        LinkLabel31.Hide()
        LinkLabel32.Hide()
        LinkLabel33.Hide()
        LinkLabel34.Hide()
        LinkLabel35.Hide()
        LinkLabel36.Hide()
        LinkLabel37.Hide()
        LinkLabel38.Hide()
        LinkLabel39.Hide()
        LinkLabel40.Hide()
        LinkLabel41.Hide()
        LinkLabel42.Hide()
        LinkLabel43.Hide()
        LinkLabel44.Hide()
        LinkLabel45.Hide()
        LinkLabel46.Hide()
        LinkLabel47.Hide()
        LinkLabel48.Hide()
        LinkLabel49.Hide()
        LinkLabel50.Hide()
        LinkLabel51.Hide()
        LinkLabel52.Hide()
        LinkLabel53.Hide()
        LinkLabel54.Hide()
        LinkLabel55.Hide()
        LinkLabel56.Hide()
        LinkLabel77.Hide()


        LinkLabel57.Hide()
        LinkLabel58.Hide()
        LinkLabel59.Hide()
        LinkLabel60.Hide()
        LinkLabel61.Hide()
        LinkLabel62.Hide()
        LinkLabel63.Hide()
        LinkLabel64.Hide()
        LinkLabel65.Hide()
        LinkLabel66.Hide()
        LinkLabel67.Hide()
        LinkLabel68.Hide()
        LinkLabel69.Hide()
        LinkLabel70.Hide()
        LinkLabel71.Hide()
        LinkLabel72.Hide()
        LinkLabel73.Hide()
        LinkLabel74.Hide()
        LinkLabel75.Hide()
        LinkLabel76.Hide()
        LinkLabel78.Hide()
        LinkLabel79.Hide()
        LinkLabel80.Hide()
        LinkLabel81.Hide()
        LinkLabel82.Hide()

        LinkLabel84.Hide()
        LinkLabel85.Hide()

        LinkLabel83.Show()
        LinkLabel86.Show()
        LinkLabel87.Show()
        LinkLabel88.Show()
    End Sub

    Private Sub LinkLabel85_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel85.LinkClicked
        Process.Start("OptionalFeatures.exe")
    End Sub

    Private Sub LinkLabel84_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel84.LinkClicked

        Shell("cmd /X /C start explorer.exe shell:::{4234d49b-0245-4df3-b780-3893943456e1}")
    End Sub

    Private Sub LinkLabel83_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel83.LinkClicked

        Process.Start("C:\Windows\System32\Sysprep\Sysprep.exe")
    End Sub

    Private Sub LinkLabel86_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel86.LinkClicked
        Shell("cmd /X /C slmgr -dlv")
    End Sub

    Private Sub LinkLabel87_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel87.LinkClicked

        Process.Start("C:\Windows\System32\lpksetup.exe")
    End Sub



    Private Sub LinkLabel88_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel88.LinkClicked
        Process.Start("C:\Windows\System32\mstsc.exe")
    End Sub

    Private Sub LinkLabel89_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 
        Shell("cmd /X /K ipconfig.exe/all")

        Process.Start("netsh wlan show driver")

    End Sub
End Class