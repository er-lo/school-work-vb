<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
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
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembersAllMembers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembersJoinDateMembers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayments = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentsAllPayments = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentsModifyPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentsSpecificMemberPayments = New System.Windows.Forms.ToolStripMenuItem()
        Me.picKarate = New System.Windows.Forms.PictureBox()
        Me.lblSchoolTitle = New System.Windows.Forms.Label()
        Me.mnuMenuStrip.SuspendLayout()
        CType(Me.picKarate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMembers, Me.mnuPayments})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(784, 24)
        Me.mnuMenuStrip.TabIndex = 0
        Me.mnuMenuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(93, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'mnuMembers
        '
        Me.mnuMembers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMembersAllMembers, Me.mnuMembersJoinDateMembers})
        Me.mnuMembers.Name = "mnuMembers"
        Me.mnuMembers.Size = New System.Drawing.Size(69, 20)
        Me.mnuMembers.Text = "&Members"
        '
        'mnuMembersAllMembers
        '
        Me.mnuMembersAllMembers.Name = "mnuMembersAllMembers"
        Me.mnuMembersAllMembers.Size = New System.Drawing.Size(191, 22)
        Me.mnuMembersAllMembers.Text = "&All Members"
        '
        'mnuMembersJoinDateMembers
        '
        Me.mnuMembersJoinDateMembers.Name = "mnuMembersJoinDateMembers"
        Me.mnuMembersJoinDateMembers.Size = New System.Drawing.Size(191, 22)
        Me.mnuMembersJoinDateMembers.Text = "Members by &Join Date"
        '
        'mnuPayments
        '
        Me.mnuPayments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPaymentsAllPayments, Me.mnuPaymentsModifyPayment, Me.mnuPaymentsSpecificMemberPayments})
        Me.mnuPayments.Name = "mnuPayments"
        Me.mnuPayments.Size = New System.Drawing.Size(71, 20)
        Me.mnuPayments.Text = "&Payments"
        '
        'mnuPaymentsAllPayments
        '
        Me.mnuPaymentsAllPayments.Name = "mnuPaymentsAllPayments"
        Me.mnuPaymentsAllPayments.Size = New System.Drawing.Size(229, 22)
        Me.mnuPaymentsAllPayments.Text = "&All Payments"
        '
        'mnuPaymentsModifyPayment
        '
        Me.mnuPaymentsModifyPayment.Name = "mnuPaymentsModifyPayment"
        Me.mnuPaymentsModifyPayment.Size = New System.Drawing.Size(229, 22)
        Me.mnuPaymentsModifyPayment.Text = "Modify &Existing Payment"
        '
        'mnuPaymentsSpecificMemberPayments
        '
        Me.mnuPaymentsSpecificMemberPayments.Name = "mnuPaymentsSpecificMemberPayments"
        Me.mnuPaymentsSpecificMemberPayments.Size = New System.Drawing.Size(229, 22)
        Me.mnuPaymentsSpecificMemberPayments.Text = "Payment by &Specific Member"
        '
        'picKarate
        '
        Me.picKarate.Image = Global.Lopez_Karate.My.Resources.Resources.karate
        Me.picKarate.Location = New System.Drawing.Point(49, 58)
        Me.picKarate.Name = "picKarate"
        Me.picKarate.Size = New System.Drawing.Size(300, 300)
        Me.picKarate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKarate.TabIndex = 1
        Me.picKarate.TabStop = False
        '
        'lblSchoolTitle
        '
        Me.lblSchoolTitle.AutoSize = True
        Me.lblSchoolTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSchoolTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolTitle.Location = New System.Drawing.Point(381, 194)
        Me.lblSchoolTitle.Name = "lblSchoolTitle"
        Me.lblSchoolTitle.Size = New System.Drawing.Size(378, 44)
        Me.lblSchoolTitle.TabIndex = 2
        Me.lblSchoolTitle.Text = "Kyoshi Karate School"
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.lblSchoolTitle)
        Me.Controls.Add(Me.picKarate)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.MainMenuStrip = Me.mnuMenuStrip
        Me.Name = "frmMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karate Queries by Erick Lopez"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        CType(Me.picKarate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuMembers As ToolStripMenuItem
    Friend WithEvents mnuMembersAllMembers As ToolStripMenuItem
    Friend WithEvents mnuMembersJoinDateMembers As ToolStripMenuItem
    Friend WithEvents mnuPayments As ToolStripMenuItem
    Friend WithEvents mnuPaymentsAllPayments As ToolStripMenuItem
    Friend WithEvents mnuPaymentsModifyPayment As ToolStripMenuItem
    Friend WithEvents mnuPaymentsSpecificMemberPayments As ToolStripMenuItem
    Friend WithEvents picKarate As PictureBox
    Friend WithEvents lblSchoolTitle As Label
End Class
