<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddGoals
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
        Me.AddGoalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelectedPlayer = New System.Windows.Forms.Label()
        Me.lblDisplaySelectedPlayer = New System.Windows.Forms.Label()
        Me.lblNumberOfGoals = New System.Windows.Forms.Label()
        Me.txtEnterNumberOfGoals = New System.Windows.Forms.TextBox()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddGoalsToolStripMenuItem})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(374, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'AddGoalsToolStripMenuItem
        '
        Me.AddGoalsToolStripMenuItem.Name = "AddGoalsToolStripMenuItem"
        Me.AddGoalsToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.AddGoalsToolStripMenuItem.Text = "Add &Goals"
        '
        'lblSelectedPlayer
        '
        Me.lblSelectedPlayer.AutoSize = True
        Me.lblSelectedPlayer.Location = New System.Drawing.Point(96, 55)
        Me.lblSelectedPlayer.Name = "lblSelectedPlayer"
        Me.lblSelectedPlayer.Size = New System.Drawing.Size(84, 13)
        Me.lblSelectedPlayer.TabIndex = 1
        Me.lblSelectedPlayer.Text = "Selected Player:"
        Me.lblSelectedPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplaySelectedPlayer
        '
        Me.lblDisplaySelectedPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplaySelectedPlayer.Location = New System.Drawing.Point(186, 50)
        Me.lblDisplaySelectedPlayer.Name = "lblDisplaySelectedPlayer"
        Me.lblDisplaySelectedPlayer.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplaySelectedPlayer.TabIndex = 2
        Me.lblDisplaySelectedPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumberOfGoals
        '
        Me.lblNumberOfGoals.AutoSize = True
        Me.lblNumberOfGoals.Location = New System.Drawing.Point(63, 118)
        Me.lblNumberOfGoals.Name = "lblNumberOfGoals"
        Me.lblNumberOfGoals.Size = New System.Drawing.Size(117, 13)
        Me.lblNumberOfGoals.TabIndex = 3
        Me.lblNumberOfGoals.Text = "Enter Number of Goals:"
        Me.lblNumberOfGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEnterNumberOfGoals
        '
        Me.txtEnterNumberOfGoals.Location = New System.Drawing.Point(186, 115)
        Me.txtEnterNumberOfGoals.Name = "txtEnterNumberOfGoals"
        Me.txtEnterNumberOfGoals.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterNumberOfGoals.TabIndex = 4
        '
        'frmAddGoals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 191)
        Me.Controls.Add(Me.txtEnterNumberOfGoals)
        Me.Controls.Add(Me.lblNumberOfGoals)
        Me.Controls.Add(Me.lblDisplaySelectedPlayer)
        Me.Controls.Add(Me.lblSelectedPlayer)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmAddGoals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Goals"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents AddGoalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSelectedPlayer As Label
    Friend WithEvents lblDisplaySelectedPlayer As Label
    Friend WithEvents lblNumberOfGoals As Label
    Friend WithEvents txtEnterNumberOfGoals As TextBox
End Class
