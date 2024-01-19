<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartup
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
        Me.lblSoccerTitle = New System.Windows.Forms.Label()
        Me.lblNumberOfPlayers = New System.Windows.Forms.Label()
        Me.txtNumberOfPlayers = New System.Windows.Forms.TextBox()
        Me.picSoccerImage = New System.Windows.Forms.PictureBox()
        Me.btnSubmitNumberOfPlayers = New System.Windows.Forms.Button()
        CType(Me.picSoccerImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSoccerTitle
        '
        Me.lblSoccerTitle.AutoSize = True
        Me.lblSoccerTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoccerTitle.Location = New System.Drawing.Point(50, 29)
        Me.lblSoccerTitle.Margin = New System.Windows.Forms.Padding(35, 0, 35, 0)
        Me.lblSoccerTitle.Name = "lblSoccerTitle"
        Me.lblSoccerTitle.Size = New System.Drawing.Size(290, 31)
        Me.lblSoccerTitle.TabIndex = 0
        Me.lblSoccerTitle.Text = "Soccer Score Keeper"
        Me.lblSoccerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumberOfPlayers
        '
        Me.lblNumberOfPlayers.AutoSize = True
        Me.lblNumberOfPlayers.Location = New System.Drawing.Point(126, 200)
        Me.lblNumberOfPlayers.Name = "lblNumberOfPlayers"
        Me.lblNumberOfPlayers.Size = New System.Drawing.Size(124, 13)
        Me.lblNumberOfPlayers.TabIndex = 1
        Me.lblNumberOfPlayers.Text = "Enter Number of Players:"
        '
        'txtNumberOfPlayers
        '
        Me.txtNumberOfPlayers.Location = New System.Drawing.Point(139, 228)
        Me.txtNumberOfPlayers.Name = "txtNumberOfPlayers"
        Me.txtNumberOfPlayers.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfPlayers.TabIndex = 2
        '
        'picSoccerImage
        '
        Me.picSoccerImage.Image = Global.Lopez_SoccerScoreKeeper.My.Resources.Resources.soccer
        Me.picSoccerImage.Location = New System.Drawing.Point(139, 79)
        Me.picSoccerImage.Name = "picSoccerImage"
        Me.picSoccerImage.Size = New System.Drawing.Size(100, 100)
        Me.picSoccerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSoccerImage.TabIndex = 3
        Me.picSoccerImage.TabStop = False
        '
        'btnSubmitNumberOfPlayers
        '
        Me.btnSubmitNumberOfPlayers.Location = New System.Drawing.Point(148, 271)
        Me.btnSubmitNumberOfPlayers.Name = "btnSubmitNumberOfPlayers"
        Me.btnSubmitNumberOfPlayers.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitNumberOfPlayers.TabIndex = 4
        Me.btnSubmitNumberOfPlayers.Text = "Continue"
        Me.btnSubmitNumberOfPlayers.UseVisualStyleBackColor = True
        '
        'frmStartup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 341)
        Me.Controls.Add(Me.btnSubmitNumberOfPlayers)
        Me.Controls.Add(Me.picSoccerImage)
        Me.Controls.Add(Me.txtNumberOfPlayers)
        Me.Controls.Add(Me.lblNumberOfPlayers)
        Me.Controls.Add(Me.lblSoccerTitle)
        Me.Name = "frmStartup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soccer Score Keeper by Erick Lopez"
        CType(Me.picSoccerImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSoccerTitle As Label
    Friend WithEvents lblNumberOfPlayers As Label
    Friend WithEvents txtNumberOfPlayers As TextBox
    Friend WithEvents picSoccerImage As PictureBox
    Friend WithEvents btnSubmitNumberOfPlayers As Button
End Class
