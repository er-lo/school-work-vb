<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoccerScoreMain
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
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddPlayer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddGoals = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.grpSelectedPlayerInfo = New System.Windows.Forms.GroupBox()
        Me.lblDisplaySelectedPlayerGoals = New System.Windows.Forms.Label()
        Me.lblSelectedPlayerGoals = New System.Windows.Forms.Label()
        Me.lblDisplaySelectedPlayerName = New System.Windows.Forms.Label()
        Me.lblSelectedPlayerName = New System.Windows.Forms.Label()
        Me.grpTeamInfo = New System.Windows.Forms.GroupBox()
        Me.lblDisplayTeamGoals = New System.Windows.Forms.Label()
        Me.lblTeamGoals = New System.Windows.Forms.Label()
        Me.picSoccerShot = New System.Windows.Forms.PictureBox()
        Me.lblTeamAverage = New System.Windows.Forms.Label()
        Me.lblDisplayTeamAverage = New System.Windows.Forms.Label()
        Me.mnuStrip.SuspendLayout()
        Me.grpSelectedPlayerInfo.SuspendLayout()
        Me.grpTeamInfo.SuspendLayout()
        CType(Me.picSoccerShot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuAddPlayer, Me.mnuAddGoals, Me.mnuHelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(637, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileReset, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileReset
        '
        Me.mnuFileReset.Name = "mnuFileReset"
        Me.mnuFileReset.Size = New System.Drawing.Size(102, 22)
        Me.mnuFileReset.Text = "&Reset"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(102, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuAddPlayer
        '
        Me.mnuAddPlayer.Name = "mnuAddPlayer"
        Me.mnuAddPlayer.Size = New System.Drawing.Size(76, 20)
        Me.mnuAddPlayer.Text = "Add &Player"
        '
        'mnuAddGoals
        '
        Me.mnuAddGoals.Name = "mnuAddGoals"
        Me.mnuAddGoals.Size = New System.Drawing.Size(73, 20)
        Me.mnuAddGoals.Text = "Add &Goals"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'lstPlayers
        '
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.Location = New System.Drawing.Point(37, 47)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(197, 368)
        Me.lstPlayers.TabIndex = 1
        '
        'grpSelectedPlayerInfo
        '
        Me.grpSelectedPlayerInfo.Controls.Add(Me.lblDisplaySelectedPlayerGoals)
        Me.grpSelectedPlayerInfo.Controls.Add(Me.lblSelectedPlayerGoals)
        Me.grpSelectedPlayerInfo.Controls.Add(Me.lblDisplaySelectedPlayerName)
        Me.grpSelectedPlayerInfo.Controls.Add(Me.lblSelectedPlayerName)
        Me.grpSelectedPlayerInfo.Location = New System.Drawing.Point(275, 47)
        Me.grpSelectedPlayerInfo.Name = "grpSelectedPlayerInfo"
        Me.grpSelectedPlayerInfo.Size = New System.Drawing.Size(301, 100)
        Me.grpSelectedPlayerInfo.TabIndex = 2
        Me.grpSelectedPlayerInfo.TabStop = False
        Me.grpSelectedPlayerInfo.Text = "Selected Player Information"
        '
        'lblDisplaySelectedPlayerGoals
        '
        Me.lblDisplaySelectedPlayerGoals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplaySelectedPlayerGoals.Location = New System.Drawing.Point(177, 56)
        Me.lblDisplaySelectedPlayerGoals.Name = "lblDisplaySelectedPlayerGoals"
        Me.lblDisplaySelectedPlayerGoals.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplaySelectedPlayerGoals.TabIndex = 3
        Me.lblDisplaySelectedPlayerGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSelectedPlayerGoals
        '
        Me.lblSelectedPlayerGoals.AutoSize = True
        Me.lblSelectedPlayerGoals.Location = New System.Drawing.Point(27, 61)
        Me.lblSelectedPlayerGoals.Name = "lblSelectedPlayerGoals"
        Me.lblSelectedPlayerGoals.Size = New System.Drawing.Size(114, 13)
        Me.lblSelectedPlayerGoals.TabIndex = 2
        Me.lblSelectedPlayerGoals.Text = "Selected Player Goals:"
        Me.lblSelectedPlayerGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplaySelectedPlayerName
        '
        Me.lblDisplaySelectedPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplaySelectedPlayerName.Location = New System.Drawing.Point(177, 20)
        Me.lblDisplaySelectedPlayerName.Name = "lblDisplaySelectedPlayerName"
        Me.lblDisplaySelectedPlayerName.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplaySelectedPlayerName.TabIndex = 1
        Me.lblDisplaySelectedPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSelectedPlayerName
        '
        Me.lblSelectedPlayerName.AutoSize = True
        Me.lblSelectedPlayerName.Location = New System.Drawing.Point(27, 25)
        Me.lblSelectedPlayerName.Name = "lblSelectedPlayerName"
        Me.lblSelectedPlayerName.Size = New System.Drawing.Size(115, 13)
        Me.lblSelectedPlayerName.TabIndex = 0
        Me.lblSelectedPlayerName.Text = "Selected Player Name:"
        Me.lblSelectedPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpTeamInfo
        '
        Me.grpTeamInfo.Controls.Add(Me.lblDisplayTeamAverage)
        Me.grpTeamInfo.Controls.Add(Me.lblTeamAverage)
        Me.grpTeamInfo.Controls.Add(Me.lblDisplayTeamGoals)
        Me.grpTeamInfo.Controls.Add(Me.lblTeamGoals)
        Me.grpTeamInfo.Location = New System.Drawing.Point(275, 153)
        Me.grpTeamInfo.Name = "grpTeamInfo"
        Me.grpTeamInfo.Size = New System.Drawing.Size(301, 100)
        Me.grpTeamInfo.TabIndex = 3
        Me.grpTeamInfo.TabStop = False
        Me.grpTeamInfo.Text = "Team Information"
        '
        'lblDisplayTeamGoals
        '
        Me.lblDisplayTeamGoals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayTeamGoals.Location = New System.Drawing.Point(177, 26)
        Me.lblDisplayTeamGoals.Name = "lblDisplayTeamGoals"
        Me.lblDisplayTeamGoals.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayTeamGoals.TabIndex = 1
        Me.lblDisplayTeamGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTeamGoals
        '
        Me.lblTeamGoals.AutoSize = True
        Me.lblTeamGoals.Location = New System.Drawing.Point(27, 31)
        Me.lblTeamGoals.Name = "lblTeamGoals"
        Me.lblTeamGoals.Size = New System.Drawing.Size(119, 13)
        Me.lblTeamGoals.TabIndex = 0
        Me.lblTeamGoals.Text = "Number of Team Goals:"
        Me.lblTeamGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picSoccerShot
        '
        Me.picSoccerShot.Image = Global.Lopez_SoccerScoreKeeper.My.Resources.Resources.soccer2
        Me.picSoccerShot.Location = New System.Drawing.Point(337, 259)
        Me.picSoccerShot.Name = "picSoccerShot"
        Me.picSoccerShot.Size = New System.Drawing.Size(180, 180)
        Me.picSoccerShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSoccerShot.TabIndex = 4
        Me.picSoccerShot.TabStop = False
        '
        'lblTeamAverage
        '
        Me.lblTeamAverage.AutoSize = True
        Me.lblTeamAverage.Location = New System.Drawing.Point(27, 65)
        Me.lblTeamAverage.Name = "lblTeamAverage"
        Me.lblTeamAverage.Size = New System.Drawing.Size(105, 13)
        Me.lblTeamAverage.TabIndex = 2
        Me.lblTeamAverage.Text = "Team Goal Average:"
        Me.lblTeamAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayTeamAverage
        '
        Me.lblDisplayTeamAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayTeamAverage.Location = New System.Drawing.Point(177, 60)
        Me.lblDisplayTeamAverage.Name = "lblDisplayTeamAverage"
        Me.lblDisplayTeamAverage.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayTeamAverage.TabIndex = 3
        Me.lblDisplayTeamAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSoccerScoreMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 450)
        Me.Controls.Add(Me.picSoccerShot)
        Me.Controls.Add(Me.grpTeamInfo)
        Me.Controls.Add(Me.grpSelectedPlayerInfo)
        Me.Controls.Add(Me.lstPlayers)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmSoccerScoreMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soccer Score Keeper by Erick Lopez"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.grpSelectedPlayerInfo.ResumeLayout(False)
        Me.grpSelectedPlayerInfo.PerformLayout()
        Me.grpTeamInfo.ResumeLayout(False)
        Me.grpTeamInfo.PerformLayout()
        CType(Me.picSoccerShot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileReset As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuAddPlayer As ToolStripMenuItem
    Friend WithEvents mnuAddGoals As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents lstPlayers As ListBox
    Friend WithEvents grpSelectedPlayerInfo As GroupBox
    Friend WithEvents grpTeamInfo As GroupBox
    Friend WithEvents lblDisplaySelectedPlayerGoals As Label
    Friend WithEvents lblSelectedPlayerGoals As Label
    Friend WithEvents lblDisplaySelectedPlayerName As Label
    Friend WithEvents lblSelectedPlayerName As Label
    Friend WithEvents lblDisplayTeamGoals As Label
    Friend WithEvents lblTeamGoals As Label
    Friend WithEvents picSoccerShot As PictureBox
    Friend WithEvents lblDisplayTeamAverage As Label
    Friend WithEvents lblTeamAverage As Label
End Class
