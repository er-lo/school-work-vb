<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayInventory
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
        Me.lstDisplayInventoryNumbers = New System.Windows.Forms.ListBox()
        Me.mnuDisplayInventoryMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInventoryNumber = New System.Windows.Forms.Label()
        Me.lblDisplayInventoryNumber = New System.Windows.Forms.Label()
        Me.lblItemDescription = New System.Windows.Forms.Label()
        Me.lblDisplayItemDescription = New System.Windows.Forms.Label()
        Me.lblItemCost = New System.Windows.Forms.Label()
        Me.lblDisplayItemCost = New System.Windows.Forms.Label()
        Me.lblItemRetailPrice = New System.Windows.Forms.Label()
        Me.lblDisplayRetailPrice = New System.Windows.Forms.Label()
        Me.lblItemsOnHand = New System.Windows.Forms.Label()
        Me.lblDisplayOnHandNumber = New System.Windows.Forms.Label()
        Me.txtSearchInventory = New System.Windows.Forms.TextBox()
        Me.grpInventoryItemInformation = New System.Windows.Forms.GroupBox()
        Me.btnSearchInventory = New System.Windows.Forms.Button()
        Me.grpSearchByInventoryNumber = New System.Windows.Forms.GroupBox()
        Me.lblEnterInventoryNumber = New System.Windows.Forms.Label()
        Me.grpSearchByList = New System.Windows.Forms.GroupBox()
        Me.lblSelectFromList = New System.Windows.Forms.Label()
        Me.grpPurchaseBox = New System.Windows.Forms.GroupBox()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.lblNumberToPurchase = New System.Windows.Forms.Label()
        Me.grpSalesInformation = New System.Windows.Forms.GroupBox()
        Me.txtNumberToPurchase = New System.Windows.Forms.TextBox()
        Me.lblDisplaySalesTotal = New System.Windows.Forms.Label()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.lblDisplaySalesTax = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.mnuDisplayInventoryMenuStrip.SuspendLayout()
        Me.grpInventoryItemInformation.SuspendLayout()
        Me.grpSearchByInventoryNumber.SuspendLayout()
        Me.grpSearchByList.SuspendLayout()
        Me.grpPurchaseBox.SuspendLayout()
        Me.grpSalesInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstDisplayInventoryNumbers
        '
        Me.lstDisplayInventoryNumbers.FormattingEnabled = True
        Me.lstDisplayInventoryNumbers.Location = New System.Drawing.Point(13, 46)
        Me.lstDisplayInventoryNumbers.Margin = New System.Windows.Forms.Padding(10)
        Me.lstDisplayInventoryNumbers.Name = "lstDisplayInventoryNumbers"
        Me.lstDisplayInventoryNumbers.Size = New System.Drawing.Size(211, 277)
        Me.lstDisplayInventoryNumbers.TabIndex = 0
        '
        'mnuDisplayInventoryMenuStrip
        '
        Me.mnuDisplayInventoryMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuDisplayInventoryMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuDisplayInventoryMenuStrip.Name = "mnuDisplayInventoryMenuStrip"
        Me.mnuDisplayInventoryMenuStrip.Size = New System.Drawing.Size(584, 24)
        Me.mnuDisplayInventoryMenuStrip.TabIndex = 1
        Me.mnuDisplayInventoryMenuStrip.Text = "MenuStrip1"
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
        Me.lblInventoryNumber.Location = New System.Drawing.Point(34, 39)
        Me.lblInventoryNumber.Margin = New System.Windows.Forms.Padding(10)
        Me.lblInventoryNumber.Name = "lblInventoryNumber"
        Me.lblInventoryNumber.Size = New System.Drawing.Size(117, 13)
        Me.lblInventoryNumber.TabIndex = 2
        Me.lblInventoryNumber.Text = "Item Inventory Number:"
        Me.lblInventoryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayInventoryNumber
        '
        Me.lblDisplayInventoryNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayInventoryNumber.Location = New System.Drawing.Point(171, 34)
        Me.lblDisplayInventoryNumber.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblDisplayInventoryNumber.Name = "lblDisplayInventoryNumber"
        Me.lblDisplayInventoryNumber.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayInventoryNumber.TabIndex = 3
        Me.lblDisplayInventoryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemDescription
        '
        Me.lblItemDescription.AutoSize = True
        Me.lblItemDescription.Location = New System.Drawing.Point(65, 72)
        Me.lblItemDescription.Margin = New System.Windows.Forms.Padding(10)
        Me.lblItemDescription.Name = "lblItemDescription"
        Me.lblItemDescription.Size = New System.Drawing.Size(86, 13)
        Me.lblItemDescription.TabIndex = 4
        Me.lblItemDescription.Text = "Item Description:"
        Me.lblItemDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayItemDescription
        '
        Me.lblDisplayItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayItemDescription.Location = New System.Drawing.Point(171, 67)
        Me.lblDisplayItemDescription.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblDisplayItemDescription.Name = "lblDisplayItemDescription"
        Me.lblDisplayItemDescription.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayItemDescription.TabIndex = 5
        Me.lblDisplayItemDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemCost
        '
        Me.lblItemCost.AutoSize = True
        Me.lblItemCost.Location = New System.Drawing.Point(97, 105)
        Me.lblItemCost.Margin = New System.Windows.Forms.Padding(10)
        Me.lblItemCost.Name = "lblItemCost"
        Me.lblItemCost.Size = New System.Drawing.Size(54, 13)
        Me.lblItemCost.TabIndex = 6
        Me.lblItemCost.Text = "Item Cost:"
        Me.lblItemCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayItemCost
        '
        Me.lblDisplayItemCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayItemCost.Location = New System.Drawing.Point(171, 100)
        Me.lblDisplayItemCost.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblDisplayItemCost.Name = "lblDisplayItemCost"
        Me.lblDisplayItemCost.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayItemCost.TabIndex = 7
        Me.lblDisplayItemCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemRetailPrice
        '
        Me.lblItemRetailPrice.AutoSize = True
        Me.lblItemRetailPrice.Location = New System.Drawing.Point(65, 138)
        Me.lblItemRetailPrice.Margin = New System.Windows.Forms.Padding(10)
        Me.lblItemRetailPrice.Name = "lblItemRetailPrice"
        Me.lblItemRetailPrice.Size = New System.Drawing.Size(87, 13)
        Me.lblItemRetailPrice.TabIndex = 8
        Me.lblItemRetailPrice.Text = "Item Retail Price:"
        Me.lblItemRetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayRetailPrice
        '
        Me.lblDisplayRetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayRetailPrice.Location = New System.Drawing.Point(171, 133)
        Me.lblDisplayRetailPrice.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblDisplayRetailPrice.Name = "lblDisplayRetailPrice"
        Me.lblDisplayRetailPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayRetailPrice.TabIndex = 9
        Me.lblDisplayRetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemsOnHand
        '
        Me.lblItemsOnHand.AutoSize = True
        Me.lblItemsOnHand.Location = New System.Drawing.Point(22, 171)
        Me.lblItemsOnHand.Margin = New System.Windows.Forms.Padding(10)
        Me.lblItemsOnHand.Name = "lblItemsOnHand"
        Me.lblItemsOnHand.Size = New System.Drawing.Size(130, 13)
        Me.lblItemsOnHand.TabIndex = 10
        Me.lblItemsOnHand.Text = "Number of Items On Hand"
        Me.lblItemsOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayOnHandNumber
        '
        Me.lblDisplayOnHandNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayOnHandNumber.Location = New System.Drawing.Point(171, 166)
        Me.lblDisplayOnHandNumber.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblDisplayOnHandNumber.Name = "lblDisplayOnHandNumber"
        Me.lblDisplayOnHandNumber.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayOnHandNumber.TabIndex = 11
        Me.lblDisplayOnHandNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearchInventory
        '
        Me.txtSearchInventory.Location = New System.Drawing.Point(13, 61)
        Me.txtSearchInventory.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.txtSearchInventory.Name = "txtSearchInventory"
        Me.txtSearchInventory.Size = New System.Drawing.Size(126, 20)
        Me.txtSearchInventory.TabIndex = 12
        '
        'grpInventoryItemInformation
        '
        Me.grpInventoryItemInformation.Controls.Add(Me.lblInventoryNumber)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblDisplayInventoryNumber)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblDisplayOnHandNumber)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblItemDescription)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblItemsOnHand)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblDisplayItemDescription)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblDisplayRetailPrice)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblItemCost)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblItemRetailPrice)
        Me.grpInventoryItemInformation.Controls.Add(Me.lblDisplayItemCost)
        Me.grpInventoryItemInformation.Location = New System.Drawing.Point(276, 34)
        Me.grpInventoryItemInformation.Margin = New System.Windows.Forms.Padding(10)
        Me.grpInventoryItemInformation.Name = "grpInventoryItemInformation"
        Me.grpInventoryItemInformation.Size = New System.Drawing.Size(289, 208)
        Me.grpInventoryItemInformation.TabIndex = 13
        Me.grpInventoryItemInformation.TabStop = False
        Me.grpInventoryItemInformation.Text = "Selected Item"
        '
        'btnSearchInventory
        '
        Me.btnSearchInventory.Location = New System.Drawing.Point(149, 61)
        Me.btnSearchInventory.Margin = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.btnSearchInventory.Name = "btnSearchInventory"
        Me.btnSearchInventory.Size = New System.Drawing.Size(75, 20)
        Me.btnSearchInventory.TabIndex = 15
        Me.btnSearchInventory.Text = "Search"
        Me.btnSearchInventory.UseVisualStyleBackColor = True
        '
        'grpSearchByInventoryNumber
        '
        Me.grpSearchByInventoryNumber.Controls.Add(Me.lblEnterInventoryNumber)
        Me.grpSearchByInventoryNumber.Controls.Add(Me.txtSearchInventory)
        Me.grpSearchByInventoryNumber.Controls.Add(Me.btnSearchInventory)
        Me.grpSearchByInventoryNumber.Location = New System.Drawing.Point(19, 34)
        Me.grpSearchByInventoryNumber.Margin = New System.Windows.Forms.Padding(10)
        Me.grpSearchByInventoryNumber.Name = "grpSearchByInventoryNumber"
        Me.grpSearchByInventoryNumber.Size = New System.Drawing.Size(237, 94)
        Me.grpSearchByInventoryNumber.TabIndex = 16
        Me.grpSearchByInventoryNumber.TabStop = False
        Me.grpSearchByInventoryNumber.Text = "Search By Inventory Number"
        '
        'lblEnterInventoryNumber
        '
        Me.lblEnterInventoryNumber.AutoSize = True
        Me.lblEnterInventoryNumber.Location = New System.Drawing.Point(10, 34)
        Me.lblEnterInventoryNumber.Name = "lblEnterInventoryNumber"
        Me.lblEnterInventoryNumber.Size = New System.Drawing.Size(134, 13)
        Me.lblEnterInventoryNumber.TabIndex = 16
        Me.lblEnterInventoryNumber.Text = "Enter an Inventory Number"
        '
        'grpSearchByList
        '
        Me.grpSearchByList.Controls.Add(Me.lblSelectFromList)
        Me.grpSearchByList.Controls.Add(Me.lstDisplayInventoryNumbers)
        Me.grpSearchByList.Location = New System.Drawing.Point(19, 148)
        Me.grpSearchByList.Margin = New System.Windows.Forms.Padding(10)
        Me.grpSearchByList.Name = "grpSearchByList"
        Me.grpSearchByList.Size = New System.Drawing.Size(237, 338)
        Me.grpSearchByList.TabIndex = 17
        Me.grpSearchByList.TabStop = False
        Me.grpSearchByList.Text = "Search By List"
        '
        'lblSelectFromList
        '
        Me.lblSelectFromList.AutoSize = True
        Me.lblSelectFromList.Location = New System.Drawing.Point(10, 23)
        Me.lblSelectFromList.Name = "lblSelectFromList"
        Me.lblSelectFromList.Size = New System.Drawing.Size(130, 13)
        Me.lblSelectFromList.TabIndex = 1
        Me.lblSelectFromList.Text = "Select an item from the list"
        '
        'grpPurchaseBox
        '
        Me.grpPurchaseBox.Controls.Add(Me.txtNumberToPurchase)
        Me.grpPurchaseBox.Controls.Add(Me.lblNumberToPurchase)
        Me.grpPurchaseBox.Controls.Add(Me.btnPurchase)
        Me.grpPurchaseBox.Location = New System.Drawing.Point(276, 262)
        Me.grpPurchaseBox.Margin = New System.Windows.Forms.Padding(10)
        Me.grpPurchaseBox.Name = "grpPurchaseBox"
        Me.grpPurchaseBox.Size = New System.Drawing.Size(289, 109)
        Me.grpPurchaseBox.TabIndex = 18
        Me.grpPurchaseBox.TabStop = False
        Me.grpPurchaseBox.Text = "Perform Purchase"
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(95, 66)
        Me.btnPurchase.Margin = New System.Windows.Forms.Padding(10)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(100, 30)
        Me.btnPurchase.TabIndex = 12
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'lblNumberToPurchase
        '
        Me.lblNumberToPurchase.AutoSize = True
        Me.lblNumberToPurchase.Location = New System.Drawing.Point(16, 34)
        Me.lblNumberToPurchase.Name = "lblNumberToPurchase"
        Me.lblNumberToPurchase.Size = New System.Drawing.Size(135, 13)
        Me.lblNumberToPurchase.TabIndex = 13
        Me.lblNumberToPurchase.Text = "Enter Number to Purchase:"
        '
        'grpSalesInformation
        '
        Me.grpSalesInformation.Controls.Add(Me.lblDisplaySalesTotal)
        Me.grpSalesInformation.Controls.Add(Me.lblSaleTotal)
        Me.grpSalesInformation.Controls.Add(Me.lblDisplaySalesTax)
        Me.grpSalesInformation.Controls.Add(Me.lblSalesTax)
        Me.grpSalesInformation.Location = New System.Drawing.Point(276, 391)
        Me.grpSalesInformation.Margin = New System.Windows.Forms.Padding(10)
        Me.grpSalesInformation.Name = "grpSalesInformation"
        Me.grpSalesInformation.Size = New System.Drawing.Size(289, 95)
        Me.grpSalesInformation.TabIndex = 19
        Me.grpSalesInformation.TabStop = False
        Me.grpSalesInformation.Text = "Sale Information"
        '
        'txtNumberToPurchase
        '
        Me.txtNumberToPurchase.Location = New System.Drawing.Point(171, 31)
        Me.txtNumberToPurchase.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.txtNumberToPurchase.Name = "txtNumberToPurchase"
        Me.txtNumberToPurchase.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberToPurchase.TabIndex = 14
        '
        'lblDisplaySalesTotal
        '
        Me.lblDisplaySalesTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplaySalesTotal.Location = New System.Drawing.Point(171, 54)
        Me.lblDisplaySalesTotal.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblDisplaySalesTotal.Name = "lblDisplaySalesTotal"
        Me.lblDisplaySalesTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplaySalesTotal.TabIndex = 15
        Me.lblDisplaySalesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.AutoSize = True
        Me.lblSaleTotal.Location = New System.Drawing.Point(93, 59)
        Me.lblSaleTotal.Margin = New System.Windows.Forms.Padding(10)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(58, 13)
        Me.lblSaleTotal.TabIndex = 14
        Me.lblSaleTotal.Text = "Sale Total:"
        Me.lblSaleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplaySalesTax
        '
        Me.lblDisplaySalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplaySalesTax.Location = New System.Drawing.Point(171, 21)
        Me.lblDisplaySalesTax.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblDisplaySalesTax.Name = "lblDisplaySalesTax"
        Me.lblDisplaySalesTax.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplaySalesTax.TabIndex = 13
        Me.lblDisplaySalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(94, 26)
        Me.lblSalesTax.Margin = New System.Windows.Forms.Padding(10)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(57, 13)
        Me.lblSalesTax.TabIndex = 12
        Me.lblSalesTax.Text = "Sales Tax:"
        Me.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDisplayInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 505)
        Me.Controls.Add(Me.grpSalesInformation)
        Me.Controls.Add(Me.grpPurchaseBox)
        Me.Controls.Add(Me.grpSearchByList)
        Me.Controls.Add(Me.grpSearchByInventoryNumber)
        Me.Controls.Add(Me.grpInventoryItemInformation)
        Me.Controls.Add(Me.mnuDisplayInventoryMenuStrip)
        Me.MainMenuStrip = Me.mnuDisplayInventoryMenuStrip
        Me.Name = "frmDisplayInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Display Inventory"
        Me.mnuDisplayInventoryMenuStrip.ResumeLayout(False)
        Me.mnuDisplayInventoryMenuStrip.PerformLayout()
        Me.grpInventoryItemInformation.ResumeLayout(False)
        Me.grpInventoryItemInformation.PerformLayout()
        Me.grpSearchByInventoryNumber.ResumeLayout(False)
        Me.grpSearchByInventoryNumber.PerformLayout()
        Me.grpSearchByList.ResumeLayout(False)
        Me.grpSearchByList.PerformLayout()
        Me.grpPurchaseBox.ResumeLayout(False)
        Me.grpPurchaseBox.PerformLayout()
        Me.grpSalesInformation.ResumeLayout(False)
        Me.grpSalesInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDisplayInventoryNumbers As ListBox
    Friend WithEvents mnuDisplayInventoryMenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents lblInventoryNumber As Label
    Friend WithEvents lblDisplayInventoryNumber As Label
    Friend WithEvents lblItemDescription As Label
    Friend WithEvents lblDisplayItemDescription As Label
    Friend WithEvents lblItemCost As Label
    Friend WithEvents lblDisplayItemCost As Label
    Friend WithEvents lblItemRetailPrice As Label
    Friend WithEvents lblDisplayRetailPrice As Label
    Friend WithEvents lblItemsOnHand As Label
    Friend WithEvents lblDisplayOnHandNumber As Label
    Friend WithEvents txtSearchInventory As TextBox
    Friend WithEvents grpInventoryItemInformation As GroupBox
    Friend WithEvents btnSearchInventory As Button
    Friend WithEvents grpSearchByInventoryNumber As GroupBox
    Friend WithEvents grpSearchByList As GroupBox
    Friend WithEvents lblEnterInventoryNumber As Label
    Friend WithEvents lblSelectFromList As Label
    Friend WithEvents grpPurchaseBox As GroupBox
    Friend WithEvents lblNumberToPurchase As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents grpSalesInformation As GroupBox
    Friend WithEvents txtNumberToPurchase As TextBox
    Friend WithEvents lblDisplaySalesTotal As Label
    Friend WithEvents lblSaleTotal As Label
    Friend WithEvents lblDisplaySalesTax As Label
    Friend WithEvents lblSalesTax As Label
End Class
