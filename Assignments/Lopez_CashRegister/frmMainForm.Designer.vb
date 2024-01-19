<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mnuMainFormMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventoryAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventoryUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventoryDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddInventory = New System.Windows.Forms.Button()
        Me.btnUpdateInventory = New System.Windows.Forms.Button()
        Me.btnDisplayInventory = New System.Windows.Forms.Button()
        Me.picCashRegister = New System.Windows.Forms.PictureBox()
        Me.mnuMainFormMenuStrip.SuspendLayout()
        CType(Me.picCashRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMainFormMenuStrip
        '
        Me.mnuMainFormMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuInventory})
        Me.mnuMainFormMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainFormMenuStrip.Name = "mnuMainFormMenuStrip"
        Me.mnuMainFormMenuStrip.Size = New System.Drawing.Size(684, 24)
        Me.mnuMainFormMenuStrip.TabIndex = 0
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSave, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(98, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(98, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'mnuInventory
        '
        Me.mnuInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInventoryAdd, Me.mnuInventoryUpdate, Me.mnuInventoryDisplay})
        Me.mnuInventory.Name = "mnuInventory"
        Me.mnuInventory.Size = New System.Drawing.Size(69, 20)
        Me.mnuInventory.Text = "&Inventory"
        '
        'mnuInventoryAdd
        '
        Me.mnuInventoryAdd.Name = "mnuInventoryAdd"
        Me.mnuInventoryAdd.Size = New System.Drawing.Size(152, 22)
        Me.mnuInventoryAdd.Text = "&Add"
        '
        'mnuInventoryUpdate
        '
        Me.mnuInventoryUpdate.Name = "mnuInventoryUpdate"
        Me.mnuInventoryUpdate.Size = New System.Drawing.Size(152, 22)
        Me.mnuInventoryUpdate.Text = "&Update"
        '
        'mnuInventoryDisplay
        '
        Me.mnuInventoryDisplay.Name = "mnuInventoryDisplay"
        Me.mnuInventoryDisplay.Size = New System.Drawing.Size(152, 22)
        Me.mnuInventoryDisplay.Text = "&Display/Search"
        '
        'btnAddInventory
        '
        Me.btnAddInventory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddInventory.Location = New System.Drawing.Point(320, 109)
        Me.btnAddInventory.Margin = New System.Windows.Forms.Padding(10)
        Me.btnAddInventory.Name = "btnAddInventory"
        Me.btnAddInventory.Size = New System.Drawing.Size(150, 60)
        Me.btnAddInventory.TabIndex = 1
        Me.btnAddInventory.Text = "&Add Inventory"
        Me.btnAddInventory.UseVisualStyleBackColor = True
        '
        'btnUpdateInventory
        '
        Me.btnUpdateInventory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateInventory.Location = New System.Drawing.Point(490, 109)
        Me.btnUpdateInventory.Margin = New System.Windows.Forms.Padding(10)
        Me.btnUpdateInventory.Name = "btnUpdateInventory"
        Me.btnUpdateInventory.Size = New System.Drawing.Size(150, 60)
        Me.btnUpdateInventory.TabIndex = 2
        Me.btnUpdateInventory.Text = "&Update Inventory"
        Me.btnUpdateInventory.UseVisualStyleBackColor = True
        '
        'btnDisplayInventory
        '
        Me.btnDisplayInventory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayInventory.Location = New System.Drawing.Point(320, 189)
        Me.btnDisplayInventory.Margin = New System.Windows.Forms.Padding(10)
        Me.btnDisplayInventory.Name = "btnDisplayInventory"
        Me.btnDisplayInventory.Size = New System.Drawing.Size(150, 60)
        Me.btnDisplayInventory.TabIndex = 3
        Me.btnDisplayInventory.Text = "&Display/Search Inventory"
        Me.btnDisplayInventory.UseVisualStyleBackColor = True
        '
        'picCashRegister
        '
        Me.picCashRegister.Image = Global.Lopez_CashRegister.My.Resources.Resources.register
        Me.picCashRegister.Location = New System.Drawing.Point(19, 60)
        Me.picCashRegister.Margin = New System.Windows.Forms.Padding(10)
        Me.picCashRegister.Name = "picCashRegister"
        Me.picCashRegister.Size = New System.Drawing.Size(250, 250)
        Me.picCashRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCashRegister.TabIndex = 1
        Me.picCashRegister.TabStop = False
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.btnDisplayInventory)
        Me.Controls.Add(Me.btnUpdateInventory)
        Me.Controls.Add(Me.btnAddInventory)
        Me.Controls.Add(Me.picCashRegister)
        Me.Controls.Add(Me.mnuMainFormMenuStrip)
        Me.MainMenuStrip = Me.mnuMainFormMenuStrip
        Me.Name = "frmMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Register by Erick Lopez"
        Me.mnuMainFormMenuStrip.ResumeLayout(False)
        Me.mnuMainFormMenuStrip.PerformLayout()
        CType(Me.picCashRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMainFormMenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuInventory As ToolStripMenuItem
    Friend WithEvents mnuInventoryAdd As ToolStripMenuItem
    Friend WithEvents mnuInventoryUpdate As ToolStripMenuItem
    Friend WithEvents mnuInventoryDisplay As ToolStripMenuItem
    Friend WithEvents picCashRegister As PictureBox
    Friend WithEvents btnAddInventory As Button
    Friend WithEvents btnUpdateInventory As Button
    Friend WithEvents btnDisplayInventory As Button
    Friend WithEvents mnuFileExit As ToolStripMenuItem
End Class
