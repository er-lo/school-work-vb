<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInventory
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
        Me.mnuAddInventoryMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInventoryNumber = New System.Windows.Forms.Label()
        Me.txtInventoryNumber = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRetail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemsOnHand = New System.Windows.Forms.TextBox()
        Me.btnAddInventoryItem = New System.Windows.Forms.Button()
        Me.mnuAddInventoryMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuAddInventoryMenuStrip
        '
        Me.mnuAddInventoryMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuAddInventoryMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuAddInventoryMenuStrip.Name = "mnuAddInventoryMenuStrip"
        Me.mnuAddInventoryMenuStrip.Size = New System.Drawing.Size(484, 24)
        Me.mnuAddInventoryMenuStrip.TabIndex = 0
        Me.mnuAddInventoryMenuStrip.Text = "MenuStrip1"
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
        'lblInventoryNumber
        '
        Me.lblInventoryNumber.AutoSize = True
        Me.lblInventoryNumber.Location = New System.Drawing.Point(106, 106)
        Me.lblInventoryNumber.Margin = New System.Windows.Forms.Padding(10)
        Me.lblInventoryNumber.Name = "lblInventoryNumber"
        Me.lblInventoryNumber.Size = New System.Drawing.Size(117, 13)
        Me.lblInventoryNumber.TabIndex = 1
        Me.lblInventoryNumber.Text = "Item Inventory Number:"
        Me.lblInventoryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInventoryNumber
        '
        Me.txtInventoryNumber.Location = New System.Drawing.Point(243, 103)
        Me.txtInventoryNumber.Margin = New System.Windows.Forms.Padding(10)
        Me.txtInventoryNumber.Name = "txtInventoryNumber"
        Me.txtInventoryNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtInventoryNumber.TabIndex = 2
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(137, 146)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(10)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(86, 13)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Item Description:"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(243, 143)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(10)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 4
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(169, 186)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(10)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(54, 13)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "Item Cost:"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(243, 183)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(10)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 226)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Item Retail Price:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRetail
        '
        Me.txtRetail.Location = New System.Drawing.Point(243, 223)
        Me.txtRetail.Margin = New System.Windows.Forms.Padding(10)
        Me.txtRetail.Name = "txtRetail"
        Me.txtRetail.Size = New System.Drawing.Size(100, 20)
        Me.txtRetail.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 266)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number on Hand:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtItemsOnHand
        '
        Me.txtItemsOnHand.Location = New System.Drawing.Point(243, 263)
        Me.txtItemsOnHand.Margin = New System.Windows.Forms.Padding(10)
        Me.txtItemsOnHand.Name = "txtItemsOnHand"
        Me.txtItemsOnHand.Size = New System.Drawing.Size(100, 20)
        Me.txtItemsOnHand.TabIndex = 10
        '
        'btnAddInventoryItem
        '
        Me.btnAddInventoryItem.Location = New System.Drawing.Point(157, 327)
        Me.btnAddInventoryItem.Name = "btnAddInventoryItem"
        Me.btnAddInventoryItem.Size = New System.Drawing.Size(150, 40)
        Me.btnAddInventoryItem.TabIndex = 11
        Me.btnAddInventoryItem.Text = "Add Item to Inventory"
        Me.btnAddInventoryItem.UseVisualStyleBackColor = True
        '
        'frmAddInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btnAddInventoryItem)
        Me.Controls.Add(Me.txtItemsOnHand)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRetail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtInventoryNumber)
        Me.Controls.Add(Me.lblInventoryNumber)
        Me.Controls.Add(Me.mnuAddInventoryMenuStrip)
        Me.MainMenuStrip = Me.mnuAddInventoryMenuStrip
        Me.Name = "frmAddInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Inventory"
        Me.mnuAddInventoryMenuStrip.ResumeLayout(False)
        Me.mnuAddInventoryMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuAddInventoryMenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents lblInventoryNumber As Label
    Friend WithEvents txtInventoryNumber As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRetail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtItemsOnHand As TextBox
    Friend WithEvents btnAddInventoryItem As Button
End Class
