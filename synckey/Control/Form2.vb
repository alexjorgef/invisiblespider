Imports Limilabs.FTP.Client
Imports System.Text

Public Class Form2

    Dim client As New Ftp()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        client.Connect("localhost")       ' or ConnectSSL for SSL
        client.Login("alex", "admin123")
        If client.Connected Then
            lblStatusFTP.Text = "Connected"
            btnConnect.Enabled = False
        Else
            lblStatusFTP.Text = "Not Connected"
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = Module1.name & " v" & Module1.version
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' select the desired folder 
        client.ChangeFolder("")

        ' retrieve and display the list of files and directories 
        Dim list As List(Of FtpItem) = client.GetList()

        For Each item As FtpItem In list
            Console.Write(item.ModifyDate.ToString())
            Console.Write(item.Size.ToString().PadLeft(10, " "c))
            If item.IsFolder = True Then
                Console.Write(" [{0}]", item.Name)
            Else
                Console.Write(" {0}", item.Name)
                ListView1.Items.Add(item.Name)
            End If
            Console.WriteLine()
        Next

        client.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Upload the 'index.html' file to the specified folder on the server 
        client.Upload("/root/test.txt", "c:\test.txt")

        ' upload in memory text 
        Const message As String = "Hello from Ftp.dll"
        Dim data As Byte() = Encoding.[Default].GetBytes(message)
        client.Upload("message.txt", data)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Download the 'index.html' file from the specified folder on the server 
        client.Download("/root/test.txt", "C:\Users\Alexandre Ferreira\Downloads\testD.txt")

    End Sub
End Class