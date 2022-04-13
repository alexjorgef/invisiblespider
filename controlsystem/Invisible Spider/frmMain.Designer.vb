<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnChangeFolder = New System.Windows.Forms.Button()
        Me.btnCheckUsers = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnLoadFiles = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.lblStatusFTP = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblStatusFTPText = New System.Windows.Forms.Label()
        Me.lblFTPFolderText = New System.Windows.Forms.Label()
        Me.lblFTPFolder = New System.Windows.Forms.Label()
        Me.txtInputFTPFolder = New System.Windows.Forms.TextBox()
        Me.lblUsersOnlineText = New System.Windows.Forms.Label()
        Me.lblUsersOnline = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.users = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.online = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalUsers = New System.Windows.Forms.Label()
        Me.lblTotalUsersText = New System.Windows.Forms.Label()
        Me.lblFTPInputFolder = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(192, 206)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(156, 23)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnChangeFolder
        '
        Me.btnChangeFolder.Location = New System.Drawing.Point(193, 261)
        Me.btnChangeFolder.Name = "btnChangeFolder"
        Me.btnChangeFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeFolder.TabIndex = 0
        Me.btnChangeFolder.Text = "Change Folder"
        Me.btnChangeFolder.UseVisualStyleBackColor = True
        '
        'btnCheckUsers
        '
        Me.btnCheckUsers.Location = New System.Drawing.Point(192, 168)
        Me.btnCheckUsers.Name = "btnCheckUsers"
        Me.btnCheckUsers.Size = New System.Drawing.Size(106, 23)
        Me.btnCheckUsers.TabIndex = 0
        Me.btnCheckUsers.Text = "Check Users"
        Me.btnCheckUsers.UseVisualStyleBackColor = True
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(192, 290)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(75, 23)
        Me.btnDownload.TabIndex = 0
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(273, 290)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 0
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(273, 319)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnLoadFiles
        '
        Me.btnLoadFiles.Location = New System.Drawing.Point(273, 261)
        Me.btnLoadFiles.Name = "btnLoadFiles"
        Me.btnLoadFiles.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadFiles.TabIndex = 0
        Me.btnLoadFiles.Text = "Load Files"
        Me.btnLoadFiles.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(15, 175)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(155, 138)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'lblStatusFTP
        '
        Me.lblStatusFTP.AutoSize = True
        Me.lblStatusFTP.Location = New System.Drawing.Point(122, 28)
        Me.lblStatusFTP.Name = "lblStatusFTP"
        Me.lblStatusFTP.Size = New System.Drawing.Size(33, 13)
        Me.lblStatusFTP.TabIndex = 3
        Me.lblStatusFTP.Text = "None"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblStatusFTPText
        '
        Me.lblStatusFTPText.AutoSize = True
        Me.lblStatusFTPText.Location = New System.Drawing.Point(17, 28)
        Me.lblStatusFTPText.Name = "lblStatusFTPText"
        Me.lblStatusFTPText.Size = New System.Drawing.Size(97, 13)
        Me.lblStatusFTPText.TabIndex = 2
        Me.lblStatusFTPText.Text = "Status FTP Server:"
        '
        'lblFTPFolderText
        '
        Me.lblFTPFolderText.AutoSize = True
        Me.lblFTPFolderText.Location = New System.Drawing.Point(17, 58)
        Me.lblFTPFolderText.Name = "lblFTPFolderText"
        Me.lblFTPFolderText.Size = New System.Drawing.Size(99, 13)
        Me.lblFTPFolderText.TabIndex = 2
        Me.lblFTPFolderText.Text = "FTP Current Folder:"
        '
        'lblFTPFolder
        '
        Me.lblFTPFolder.AutoSize = True
        Me.lblFTPFolder.Location = New System.Drawing.Point(122, 58)
        Me.lblFTPFolder.Name = "lblFTPFolder"
        Me.lblFTPFolder.Size = New System.Drawing.Size(49, 13)
        Me.lblFTPFolder.TabIndex = 5
        Me.lblFTPFolder.Text = "localhost"
        '
        'txtInputFTPFolder
        '
        Me.txtInputFTPFolder.Location = New System.Drawing.Point(261, 235)
        Me.txtInputFTPFolder.Name = "txtInputFTPFolder"
        Me.txtInputFTPFolder.Size = New System.Drawing.Size(87, 20)
        Me.txtInputFTPFolder.TabIndex = 6
        '
        'lblUsersOnlineText
        '
        Me.lblUsersOnlineText.AutoSize = True
        Me.lblUsersOnlineText.Location = New System.Drawing.Point(17, 84)
        Me.lblUsersOnlineText.Name = "lblUsersOnlineText"
        Me.lblUsersOnlineText.Size = New System.Drawing.Size(70, 13)
        Me.lblUsersOnlineText.TabIndex = 7
        Me.lblUsersOnlineText.Text = "Users Online:"
        '
        'lblUsersOnline
        '
        Me.lblUsersOnline.AutoSize = True
        Me.lblUsersOnline.Location = New System.Drawing.Point(122, 84)
        Me.lblUsersOnline.Name = "lblUsersOnline"
        Me.lblUsersOnline.Size = New System.Drawing.Size(13, 13)
        Me.lblUsersOnline.TabIndex = 8
        Me.lblUsersOnline.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.users, Me.online})
        Me.DataGridView1.Location = New System.Drawing.Point(192, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'users
        '
        Me.users.HeaderText = "Users"
        Me.users.Name = "users"
        Me.users.ReadOnly = True
        '
        'online
        '
        Me.online.HeaderText = "Online"
        Me.online.Name = "online"
        Me.online.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalUsers)
        Me.GroupBox1.Controls.Add(Me.lblTotalUsersText)
        Me.GroupBox1.Controls.Add(Me.lblUsersOnlineText)
        Me.GroupBox1.Controls.Add(Me.lblStatusFTPText)
        Me.GroupBox1.Controls.Add(Me.lblUsersOnline)
        Me.GroupBox1.Controls.Add(Me.lblFTPFolderText)
        Me.GroupBox1.Controls.Add(Me.lblStatusFTP)
        Me.GroupBox1.Controls.Add(Me.lblFTPFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(514, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 317)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FTP Info"
        '
        'lblTotalUsers
        '
        Me.lblTotalUsers.AutoSize = True
        Me.lblTotalUsers.Location = New System.Drawing.Point(122, 113)
        Me.lblTotalUsers.Name = "lblTotalUsers"
        Me.lblTotalUsers.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalUsers.TabIndex = 10
        Me.lblTotalUsers.Text = "0"
        '
        'lblTotalUsersText
        '
        Me.lblTotalUsersText.AutoSize = True
        Me.lblTotalUsersText.Location = New System.Drawing.Point(20, 113)
        Me.lblTotalUsersText.Name = "lblTotalUsersText"
        Me.lblTotalUsersText.Size = New System.Drawing.Size(64, 13)
        Me.lblTotalUsersText.TabIndex = 9
        Me.lblTotalUsersText.Text = "Total Users:"
        '
        'lblFTPInputFolder
        '
        Me.lblFTPInputFolder.AutoSize = True
        Me.lblFTPInputFolder.Location = New System.Drawing.Point(193, 242)
        Me.lblFTPInputFolder.Name = "lblFTPInputFolder"
        Me.lblFTPInputFolder.Size = New System.Drawing.Size(62, 13)
        Me.lblFTPInputFolder.TabIndex = 11
        Me.lblFTPInputFolder.Text = "FTP Folder:"
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(12, 31)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(158, 97)
        Me.ListView2.TabIndex = 12
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.List
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "FTP Folders:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "FTP Files:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 425)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.lblFTPInputFolder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtInputFTPFolder)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnLoadFiles)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnCheckUsers)
        Me.Controls.Add(Me.btnChangeFolder)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "frmMain"
        Me.Text = "frmControlSystem"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnChangeFolder As System.Windows.Forms.Button
    Friend WithEvents btnCheckUsers As System.Windows.Forms.Button
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnLoadFiles As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents lblStatusFTP As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblStatusFTPText As System.Windows.Forms.Label
    Friend WithEvents lblFTPFolderText As System.Windows.Forms.Label
    Friend WithEvents lblFTPFolder As System.Windows.Forms.Label
    Friend WithEvents txtInputFTPFolder As System.Windows.Forms.TextBox
    Friend WithEvents lblUsersOnlineText As System.Windows.Forms.Label
    Friend WithEvents lblUsersOnline As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFTPInputFolder As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalUsers As System.Windows.Forms.Label
    Friend WithEvents lblTotalUsersText As System.Windows.Forms.Label
    Friend WithEvents users As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents online As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
