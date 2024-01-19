<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPlayer
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
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuAddPlayer = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.txtEnterPlayerName = New System.Windows.Forms.TextBox()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddPlayer})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(374, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuAddPlayer
        '
        Me.mnuAddPlayer.Name = "mnuAddPlayer"
        Me.mnuAddPlayer.Size = New System.Drawing.Size(76, 20)
        Me.mnuAddPlayer.Text = "Add &Player"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Location = New System.Drawing.Point(60, 93)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(107, 13)
        Me.lblPlayerName.TabIndex = 1
        Me.lblPlayerName.Text = "Enter name of player:"
        Me.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEnterPlayerName
        '
        Me.txtEnterPlayerName.Location = New System.Drawing.Point(202, 93)
        Me.txtEnterPlayerName.Name = "txtEnterPlayerName"
        Me.txtEnterPlayerName.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterPlayerName.TabIndex = 2
        '
        'frmAddPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 191)
        Me.Controls.Add(Me.txtEnterPlayerName)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmAddPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Player"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuAddPlayer As ToolStripMenuItem
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents txtEnterPlayerName As TextBox
End Class
