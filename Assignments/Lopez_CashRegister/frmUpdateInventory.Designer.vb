<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateInventory
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
        Me.grpSearchByInventoryNumber = New System.Windows.Forms.GroupBox()
        Me.btnSearchInventory = New System.Windows.Forms.Button()
        Me.txtSearchInventory = New System.Windows.Forms.TextBox()
        Me.lblEnterInventoryNumber = New System.Windows.Forms.Label()
        Me.mnuUpdateInventoryMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpSearchByList = New System.Windows.Forms.GroupBox()
        Me.lstDisplayInventoryNumbers = New System.Windows.Forms.ListBox()
        Me.lblSelectFromList = New System.Windows.Forms.Label()
        Me.grpInventoryItemInformation = New System.Windows.Forms.GroupBox()
        Me.txtItemsOnHand = New System.Windows.Forms.TextBox()
        Me.txtItemRetailPrice = New System.Windows.Forms.TextBox()
        Me.txtItemCost = New System.Windows.Forms.TextBox()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblInventoryNumber = New System.Windows.Forms.Label()
        Me.lblDisplayInventoryNumber = New System.Windows.Forms.Label()
        Me.lblItemDescription = New System.Windows.Forms.Label()
        Me.lblItemsOnHand = New System.Windows.Forms.Label()
        Me.lblItemCost = New System.Windows.Forms.Label()
        Me.lblItemRetailPrice = New System.Windows.Forms.Label()
        Me.grpSearchByInventoryNumber.SuspendLayout()
        Me.mnuUpdateInventoryMenuStrip.SuspendLayout()
        Me.grpSearchByList.SuspendLayout()
        Me.grpInventoryItemInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSearchByInventoryNumber
        '
        Me.grpSearchByInventoryNumber.Controls.Add(Me.btnSearchInventory)
        Me.grpSearchByInventoryNumber.Controls.Add(Me.txtSearchInventory)
        Me.grpSearchByInventoryNumber.Controls.Add(Me.lblEnterInventoryNumber)
        Me.grpSearchByInventoryNumber.Location = New System.Drawing.Point(19, 34)
        Me.grpSearchByInventoryNumber.Margin = New System.Windows.Forms.Padding(10)
        Me.grpSearchByInventoryNumber.Name = "grpSearchByInventoryNumber"
        Me.grpSearchByInventoryNumber.Size = New System.Drawing.Size(237, 80)
        Me.grpSearchByInventoryNumber.TabIndex = 0
        Me.grpSearchByInventoryNumber.TabStop = False
        Me.grpSearchByInventoryNumber.Text = "Search By Inventory Number"
        '
        'btnSearchInventory
        '
        Me.btnSearchInventory.Location = New System.Drawing.Point(150, 47)
        Me.btnSearchInventory.Margin = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.btnSearchInventory.Name = "btnSearchInventory"
        Me.btnSearchInventory.Size = New System.Drawing.Size(75, 20)
        Me.btnSearchInventory.TabIndex = 16
        Me.btnSearchInventory.Text = "Search"
        Me.btnSearchInventory.UseVisualStyleBackColor = True
        '
        'txtSearchInventory
        '
        Me.txtSearchInventory.Location = New System.Drawing.Point(13, 47)
        Me.txtSearchInventory.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.txtSearchInventory.Name = "txtSearchInventory"
        Me.txtSearchInventory.Size = New System.Drawing.Size(126, 20)
        Me.txtSearchInventory.TabIndex = 13
        '
        'lblEnterInventoryNumber
        '
        Me.lblEnterInventoryNumber.AutoSize = True
        Me.lblEnterInventoryNumber.Location = New System.Drawing.Point(10, 24)
        Me.lblEnterInventoryNumber.Name = "lblEnterInventoryNumber"
        Me.lblEnterInventoryNumber.Size = New System.Drawing.Size(134, 13)
        Me.lblEnterInventoryNumber.TabIndex = 0
        Me.lblEnterInventoryNumber.Text = "Enter an Inventory Number"
        '
        'mnuUpdateInventoryMenuStrip
        '
        Me.mnuUpdateInventoryMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuUpdateInventoryMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuUpdateInventoryMenuStrip.Name = "mnuUpdateInventoryMenuStrip"
        Me.mnuUpdateInventoryMenuStrip.Size = New System.Drawing.Size(584, 24)
        Me.mnuUpdateInventoryMenuStrip.TabIndex = 1
        Me.mnuUpdateInventoryMenuStrip.Text = "MenuStrip1"
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
        Me.mnuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'grpSearchByList
        '
        Me.grpSearchByList.Controls.Add(Me.lstDisplayInventoryNumbers)
        Me.grpSearchByList.Controls.Add(Me.lblSelectFromList)
        Me.grpSearchByList.Location = New System.Drawing.Point(19, 134)
        Me.grpSearchByList.Margin = New System.Windows.Forms.Padding(10)
        Me.grpSearchByList.Name = "grpSearchByList"
        Me.grpSearchByList.Size = New System.Drawing.Size(237, 297)
        Me.grpSearchByList.TabIndex = 2
        Me.grpSearchByList.TabStop = False
        Me.grpSearchByList.Text = "Search By List"
        '
        'lstDisplayInventoryNumbers
        '
        Me.lstDisplayInventoryNumbers.FormattingEnabled = True
        Me.lstDisplayInventoryNumbers.Location = New System.Drawing.Point(13, 46)
        Me.lstDisplayInventoryNumbers.Margin = New System.Windows.Forms.Padding(10)
        Me.lstDisplayInventoryNumbers.Name = "lstDisplayInventoryNumbers"
        Me.lstDisplayInventoryNumbers.Size = New System.Drawing.Size(211, 238)
        Me.lstDisplayInventoryNumbers.TabIndex = 1
        '
        'lblSelectFromList
        '
        Me.lblSelectFromList.AutoSize = True
        Me.lblSelectFromList.Location = New System.Drawing.Point(10, 23)
        Me.lblSelectFromList.Name = "lblSelectFromList"
        Me.lblSelectFromList.Size = New System.Drawing.Size(130, 13)
        Me.lblSelectFromList.TabIndex = 0
        Me.lblSelectFromList.Text = "Select an item from the list"
        '
        'grpInventoryItemInformation
        '
        Me.grpInventoryItemInformation.Controls.Add(Me.txtItemsOnHand)
        Me.grpInventoryItemInformation.Controls.Add(Me.txtItemRetailPrice)
        Me.grpInventoryItemInformation.Controls.Add(Me.txtItemCost)
        Me.grpInventoryItemInformation.Controls.Add(Me.txtItemDescription)
        Me.grpInventoryItemInformation.Controls.Add(Me.btnUpdate)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblInventoryNumber)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblDisplayInventoryNumber)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblItemDescription)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblItemsOnHand)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblItemCost)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblItemRetailPrice)
        Me.grpInventoryItemInformation.Location = New System.Drawing.Point(276, 34)
        Me.grpInventoryItemInformation.Margin = New System.Windows.Forms.Padding(10)
        Me.grpInventoryItemInformation.Name = "grpInventoryItemInformation"
        Me.grpInventoryItemInformation.Size = New System.Drawing.Size(289, 297)
        Me.grpInventoryItemInformation.TabIndex = 3
        Me.grpInventoryItemInformation.TabStop = False
        Me.grpInventoryItemInformation.Text = "Selected Item Information"
        '
        'txtItemsOnHand
        '
        Me.txtItemsOnHand.Location = New System.Drawing.Point(161, 218)
        Me.txtItemsOnHand.Name = "txtItemsOnHand"
        Me.txtItemsOnHand.Size = New System.Drawing.Size(100, 20)
        Me.txtItemsOnHand.TabIndex = 26
        '
        'txtItemRetailPrice
        '
        Me.txtItemRetailPrice.Location = New System.Drawing.Point(161, 175)
        Me.txtItemRetailPrice.Name = "txtItemRetailPrice"
        Me.txtItemRetailPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtItemRetailPrice.TabIndex = 25
        '
        'txtItemCost
        '
        Me.txtItemCost.Location = New System.Drawing.Point(161, 132)
        Me.txtItemCost.Name = "txtItemCost"
        Me.txtItemCost.Size = New System.Drawing.Size(100, 20)
        Me.txtItemCost.TabIndex = 24
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Location = New System.Drawing.Point(161, 89)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtItemDescription.TabIndex = 23
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(99, 254)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblInventoryNumber
        '
        Me.lblInventoryNumber.AutoSize = True
        Me.lblInventoryNumber.Location = New System.Drawing.Point(24, 49)
        Me.lblInventoryNumber.Margin = New System.Windows.Forms.Padding(10)
        Me.lblInventoryNumber.Name = "lblInventoryNumber"
        Me.lblInventoryNumber.Size = New System.Drawing.Size(117, 13)
        Me.lblInventoryNumber.TabIndex = 12
        Me.lblInventoryNumber.Text = "Item Inventory Number:"
        Me.lblInventoryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayInventoryNumber
        '
        Me.lblDisplayInventoryNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayInventoryNumber.Location = New System.Drawing.Point(161, 44)
        Me.lblDisplayInventoryNumber.Margin = New System.Windows.Forms.Padding(10)
        Me.lblDisplayInventoryNumber.Name = "lblDisplayInventoryNumber"
        Me.lblDisplayInventoryNumber.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayInventoryNumber.TabIndex = 13
        Me.lblDisplayInventoryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemDescription
        '
        Me.lblItemDescription.AutoSize = True
        Me.lblItemDescription.Location = New System.Drawing.Point(55, 92)
        Me.lblItemDescription.Margin = New System.Windows.Forms.Padding(10)
        Me.lblItemDescription.Name = "lblItemDescription"
        Me.lblItemDescription.Size = New System.Drawing.Size(86, 13)
        Me.lblItemDescription.TabIndex = 14
        Me.lblItemDescription.Text = "Item Description:"
        Me.lblItemDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemsOnHand
        '
        Me.lblItemsOnHand.AutoSize = True
        Me.lblItemsOnHand.Location = New System.Drawing.Point(11, 221)
        Me.lblItemsOnHand.Margin = New System.Windows.Forms.Padding(10)
        Me.lblItemsOnHand.Name = "lblItemsOnHand"
        Me.lblItemsOnHand.Size = New System.Drawing.Size(130, 13)
        Me.lblItemsOnHand.TabIndex = 20
        Me.lblItemsOnHand.Text = "Number of Items On Hand"
        Me.lblItemsOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemCost
        '
        Me.lblItemCost.AutoSize = True
        Me.lblItemCost.Location = New System.Drawing.Point(87, 135)
        Me.lblItemCost.Margin = New System.Windows.Forms.Padding(10)
        Me.lblItemCost.Name = "lblItemCost"
        Me.lblItemCost.Size = New System.Drawing.Size(54, 13)
        Me.lblItemCost.TabIndex = 16
        Me.lblItemCost.Text = "Item Cost:"
        Me.lblItemCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemRetailPrice
        '
        Me.lblItemRetailPrice.AutoSize = True
        Me.lblItemRetailPrice.Location = New System.Drawing.Point(54, 178)
        Me.lblItemRetailPrice.Margin = New System.Windows.Forms.Padding(10)
        Me.lblItemRetailPrice.Name = "lblItemRetailPrice"
        Me.lblItemRetailPrice.Size = New System.Drawing.Size(87, 13)
        Me.lblItemRetailPrice.TabIndex = 18
        Me.lblItemRetailPrice.Text = "Item Retail Price:"
        Me.lblItemRetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmUpdateInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.grpInventoryItemInformation)
        Me.Controls.Add(Me.grpSearchByList)
        Me.Controls.Add(Me.grpSearchByInventoryNumber)
        Me.Controls.Add(Me.mnuUpdateInventoryMenuStrip)
        Me.MainMenuStrip = Me.mnuUpdateInventoryMenuStrip
        Me.Name = "frmUpdateInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update Inventory"
        Me.grpSearchByInventoryNumber.ResumeLayout(False)
        Me.grpSearchByInventoryNumber.PerformLayout()
        Me.mnuUpdateInventoryMenuStrip.ResumeLayout(False)
        Me.mnuUpdateInventoryMenuStrip.PerformLayout()
        Me.grpSearchByList.ResumeLayout(False)
        Me.grpSearchByList.PerformLayout()
        Me.grpInventoryItemInformation.ResumeLayout(False)
        Me.grpInventoryItemInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSearchByInventoryNumber As GroupBox
    Friend WithEvents mnuUpdateInventoryMenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents grpSearchByList As GroupBox
    Friend WithEvents grpInventoryItemInformation As GroupBox
    Friend WithEvents lblEnterInventoryNumber As Label
    Friend WithEvents lblSelectFromList As Label
    Friend WithEvents txtSearchInventory As TextBox
    Friend WithEvents btnSearchInventory As Button
    Friend WithEvents lstDisplayInventoryNumbers As ListBox
    Friend WithEvents txtItemsOnHand As TextBox
    Friend WithEvents txtItemRetailPrice As TextBox
    Friend WithEvents txtItemCost As TextBox
    Friend WithEvents txtItemDescription As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblInventoryNumber As Label
    Friend WithEvents lblDisplayInventoryNumber As Label
    Friend WithEvents lblItemDescription As Label
    Friend WithEvents lblItemsOnHand As Label
    Friend WithEvents lblItemCost As Label
    Friend WithEvents lblItemRetailPrice As Label
End Class
