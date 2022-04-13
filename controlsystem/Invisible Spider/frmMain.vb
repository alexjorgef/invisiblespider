Imports Limilabs.FTP.Client
Imports System.Text

Public Class frmMain

    ' Variable Server FTP
    Public ftp_user As String = "alex"
    Public ftp_password As String = "admin123"
    Public ftp_serverip As String = "localhost"
    Public ftp_folder As String = System.Environment.UserName + "_" + Now.Date.ToString("MMM_d_yyyy")
    Public ftp_current_folder As String = ""
    Public ftp_main_server As String = "d:\others\ftp server\"

    ' Variable Local Folder
    Public local_folder As String = "c:\users\public\" + System.Environment.UserName
    Public local_log_path As String = local_folder + "\log_" + Now.Date.ToString("MMM_d_yyyy") + ".txt"
    Public local_infolog_path As String = local_folder + "\infolog_" + Now.Date.ToString("MMM_d_yyyy") + ".txt"

    Dim message As String


    Private Sub btnLoadFiles_Click(sender As Object, e As EventArgs) Handles btnLoadFiles.Click
        ListView1.Clear()
        ListView2.Clear()
        Dim client As New Ftp()
        client.Connect(ftp_serverip, 21)
        client.Login(ftp_user, ftp_password)

        client.ChangeFolder(ftp_current_folder) ' select the desired folder


        ' message = My.Computer.FileSystem.ReadAllText(local_log_path)
        ' SyncServer(message, "logs")

        ' detection IP
        'Dim fields() As String = " allthexx.no - ip.org"
        'fields() = Split(s, ",")
        'For i = 0 To UBound(fields)
        '    List1.AddItem Trim$(fields(i))
        'Next

        ' retrieve and display the list of files and directories 
        Dim items As List(Of FtpItem) = client.GetList()

        For Each item As FtpItem In items
            MsgBox("Name: " & item.Name & vbNewLine & "Size: " & item.Size & vbNewLine & "Is Folder: " & item.IsFolder & vbNewLine & "Is File: " & item.IsFile)
            If item.IsFolder = True Then
                ListView2.Items.Add(item.Name)
            Else
                ListView1.Items.Add(item.Name)
            End If
        Next

        ' - 1. Open Info Log
        'My.Computer.FileSystem.WriteAllText(local_infolog_path, "X" & " " & "OpAT: " & Now & vbNewLine, False)
        ' - 2. Write Info Log
        'My.Computer.FileSystem.WriteAllText(local_infolog_path, "Machine Name: " & System.Environment.MachineName & vbNewLine & "User Name: " & System.Environment.UserName & vbNewLine & "OS Name: " & My.Computer.Info.OSFullName & vbNewLine & "OS Plataform: " & My.Computer.Info.OSPlatform & vbNewLine & "OS Version: " & My.Computer.Info.OSVersion & vbNewLine & "Processor Name: " & CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)) & vbNewLine & "MB Model: " & CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardProduct", Nothing)) & vbNewLine & "MB Manufacturer: " & CStr(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardManufacturer", Nothing)), True)
        ' - 3. Close Info Log
        'My.Computer.FileSystem.WriteAllText(local_infolog_path, vbNewLine & "X" & " " & "ClAT: " & Now & vbNewLine, True)


        client.Close()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim client As New Ftp()
        Try
            client.Connect(ftp_serverip)
            client.Login(ftp_user, ftp_password)
            lblStatusFTP.Text = "Connected"
            btnConnect.Enabled = False
            client.Close()
        Catch ex As Exception
            lblStatusFTP.Text = "Not Connected"
        End Try

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenFileDialog1.ShowDialog()
        MsgBox(OpenFileDialog1.FileName)
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        OpenFileDialog1.ShowDialog()
        MsgBox(OpenFileDialog1.FileName)
    End Sub


    ' Metodo "SyncServer": fazer sincronizacao ficheiro com servidor
    ' @params message (String): Message to upload
    ' - 1. Create FTP Cliand and Connect to FTP Server
    ' - 2. Check/Create FTP Folder
    ' - 3. Find Local Log and upload it
    ' - 4. Close FTP Client
    Public Sub SyncServer(message As String, type As String)
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
                    ' MsgBox("ftp_folder exists!" & vbNewLine & "ftp_folder: " & ftp_server & "/" & type & "/" & ftp_folder)
                Catch ex As Exception
                    client.CreateFolder(ftp_folder)
                    client.ChangeFolder(ftp_folder)
                    ' MsgBox("ftp_folder doesn't exist!" & vbNewLine & "ftp_folder: " & ftp_server & "/" & type & "/" & ftp_folder)
                End Try
                ' MsgBox("Sending Information to Server..." & vbNewLine & vbNewLine & "Local File: " & log & vbNewLine & "FTP Folder: " & ftp_server & "/" & type & "/" & ftp_folder)
            ElseIf (type.Equals("info")) Then
                client.ChangeFolder("info") ' change folder info
                Try ' check if "ftp_folder" exists, if not create one
                    client.ChangeFolder(ftp_folder)
                    ' MsgBox("INFO:  ftp_folder exists!" & vbNewLine & "ftp_folder: " & ftp_server & "/" & type & "/" & ftp_folder)
                Catch ex As Exception
                    client.CreateFolder(ftp_folder)
                    client.ChangeFolder(ftp_folder)
                    ' MsgBox("ftp_folder doesn't exist!" & vbNewLine & "ftp_folder: " & ftp_server & "/" & type & "/" & ftp_folder)
                End Try
                ' MsgBox("Sending Information to Server..." & vbNewLine & vbNewLine & "Local File: " & info_log & vbNewLine & "FTP Folder: " & ftp_server & "/" & type & "/" & ftp_folder)
            End If
            ' - 3. Find Local Log and upload it
            Dim data As Byte() = Encoding.[Default].GetBytes(message)
            client.Upload("message.txt", data)
        Catch ex As Exception
            MsgBox("ERROR: Server Problem")
        End Try
        ' - 4. Close FTP Client
        client.Close()

    End Sub


    Private Sub btnCheckUsers_Click(sender As Object, e As EventArgs) Handles btnCheckUsers.Click
        Dim client As New Ftp()
        DataGridView1.Rows.Clear()
        lblTotalUsers.Text = 0

        
        'Try
        client.Connect(ftp_serverip, 21)
        client.Login(ftp_user, ftp_password)
        client.ChangeFolder("info")
        Dim items As List(Of FtpItem) = client.GetList()
        Dim i As Integer = 0 ' counter total users
        Dim ionline As Integer = 0 ' counter online users
        For Each item As FtpItem In items
            'Dim userName As String() = item.Name.Split("_")
            'MsgBox(item.Name)
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(ftp_main_server + "info\" + item.Name + "\online.txt")
            DataGridView1.Rows.Insert(i, item.Name)
            If (fileReader.Equals("1")) Then
                ionline = ionline + 1
                DataGridView1(1, i).Value = True
            ElseIf (fileReader.Equals("0")) Then
                DataGridView1(1, i).Value = False
            End If

            'MsgBox(fileReader)
            i = i + 1
        Next
        lblUsersOnline.Text = ionline
        lblTotalUsers.Text = i

        client.Close()
        'Catch ex As Exception
        '    MsgBox("ERROR: Cannot connect to FTP Server")
        'End Try

    End Sub

    Private Sub btnChangeFolder_Click(sender As Object, e As EventArgs) Handles btnChangeFolder.Click
        Dim client As New Ftp()
        
        Try
            client.Connect(ftp_serverip)
            client.Login(ftp_user, ftp_password)
            client.ChangeFolder(txtInputFTPFolder.Text)
            client.Close()
            ftp_current_folder = txtInputFTPFolder.Text
            lblFTPFolder.Text = ftp_current_folder
        Catch ex As Exception
            MsgBox("ERROR: Cannot change FTP folder or folder dont exists")
        End Try

    End Sub

End Class