<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShoppingCartByErickLopez
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
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProductsPrintBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProductsAudioBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpProductsSelected = New System.Windows.Forms.GroupBox()
        Me.lblDisplayTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDisplayShipping = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblDisplayTax = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDisplaySubtotal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnRemoveSelectedProduct = New System.Windows.Forms.Button()
        Me.lstProductsSelected = New System.Windows.Forms.ListBox()
        Me.ctxShoppingCartForm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxMenuPrintBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxMenuAudioBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMenuStrip.SuspendLayout()
        Me.grpProductsSelected.SuspendLayout()
        Me.ctxShoppingCartForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuProducts, Me.mnuHelp})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(771, 24)
        Me.mnuMenuStrip.TabIndex = 0
        Me.mnuMenuStrip.Text = "MenuStrip1"
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
        Me.mnuFileReset.Text = "R&eset"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(102, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuProducts
        '
        Me.mnuProducts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProductsPrintBooks, Me.mnuProductsAudioBooks})
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(66, 20)
        Me.mnuProducts.Text = "&Products"
        '
        'mnuProductsPrintBooks
        '
        Me.mnuProductsPrintBooks.Name = "mnuProductsPrintBooks"
        Me.mnuProductsPrintBooks.Size = New System.Drawing.Size(141, 22)
        Me.mnuProductsPrintBooks.Text = "P&rint Books"
        '
        'mnuProductsAudioBooks
        '
        Me.mnuProductsAudioBooks.Name = "mnuProductsAudioBooks"
        Me.mnuProductsAudioBooks.Size = New System.Drawing.Size(141, 22)
        Me.mnuProductsAudioBooks.Text = "&Audio Books"
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
        Me.mnuHelpAbout.Text = "&About"
        '
        'grpProductsSelected
        '
        Me.grpProductsSelected.Controls.Add(Me.lblDisplayTotal)
        Me.grpProductsSelected.Controls.Add(Me.lblTotal)
        Me.grpProductsSelected.Controls.Add(Me.lblDisplayShipping)
        Me.grpProductsSelected.Controls.Add(Me.lblShipping)
        Me.grpProductsSelected.Controls.Add(Me.lblDisplayTax)
        Me.grpProductsSelected.Controls.Add(Me.lblTax)
        Me.grpProductsSelected.Controls.Add(Me.lblDisplaySubtotal)
        Me.grpProductsSelected.Controls.Add(Me.lblSubtotal)
        Me.grpProductsSelected.Controls.Add(Me.btnRemoveSelectedProduct)
        Me.grpProductsSelected.Controls.Add(Me.lstProductsSelected)
        Me.grpProductsSelected.Location = New System.Drawing.Point(12, 39)
        Me.grpProductsSelected.Name = "grpProductsSelected"
        Me.grpProductsSelected.Size = New System.Drawing.Size(747, 249)
        Me.grpProductsSelected.TabIndex = 1
        Me.grpProductsSelected.TabStop = False
        Me.grpProductsSelected.Text = "Products Selected"
        '
        'lblDisplayTotal
        '
        Me.lblDisplayTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayTotal.Location = New System.Drawing.Point(584, 161)
        Me.lblDisplayTotal.Margin = New System.Windows.Forms.Padding(10)
        Me.lblDisplayTotal.Name = "lblDisplayTotal"
        Me.lblDisplayTotal.Size = New System.Drawing.Size(150, 25)
        Me.lblDisplayTotal.TabIndex = 9
        Me.lblDisplayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(535, 167)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayShipping
        '
        Me.lblDisplayShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayShipping.Location = New System.Drawing.Point(584, 116)
        Me.lblDisplayShipping.Margin = New System.Windows.Forms.Padding(10)
        Me.lblDisplayShipping.Name = "lblDisplayShipping"
        Me.lblDisplayShipping.Size = New System.Drawing.Size(150, 25)
        Me.lblDisplayShipping.TabIndex = 7
        Me.lblDisplayShipping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(518, 122)
        Me.lblShipping.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(51, 13)
        Me.lblShipping.TabIndex = 6
        Me.lblShipping.Text = "Shipping:"
        Me.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayTax
        '
        Me.lblDisplayTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayTax.Location = New System.Drawing.Point(584, 71)
        Me.lblDisplayTax.Margin = New System.Windows.Forms.Padding(10)
        Me.lblDisplayTax.Name = "lblDisplayTax"
        Me.lblDisplayTax.Size = New System.Drawing.Size(150, 25)
        Me.lblDisplayTax.TabIndex = 5
        Me.lblDisplayTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(541, 77)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 4
        Me.lblTax.Text = "Tax:"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplaySubtotal
        '
        Me.lblDisplaySubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplaySubtotal.Location = New System.Drawing.Point(584, 26)
        Me.lblDisplaySubtotal.Margin = New System.Windows.Forms.Padding(10)
        Me.lblDisplaySubtotal.Name = "lblDisplaySubtotal"
        Me.lblDisplaySubtotal.Size = New System.Drawing.Size(150, 25)
        Me.lblDisplaySubtotal.TabIndex = 3
        Me.lblDisplaySubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(520, 32)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 2
        Me.lblSubtotal.Text = "Subtotal:"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRemoveSelectedProduct
        '
        Me.btnRemoveSelectedProduct.Location = New System.Drawing.Point(168, 199)
        Me.btnRemoveSelectedProduct.Name = "btnRemoveSelectedProduct"
        Me.btnRemoveSelectedProduct.Size = New System.Drawing.Size(150, 35)
        Me.btnRemoveSelectedProduct.TabIndex = 1
        Me.btnRemoveSelectedProduct.Text = "&Remove"
        Me.ToolTip1.SetToolTip(Me.btnRemoveSelectedProduct, "Click to remove the selected product.")
        Me.btnRemoveSelectedProduct.UseVisualStyleBackColor = True
        '
        'lstProductsSelected
        '
        Me.lstProductsSelected.FormattingEnabled = True
        Me.lstProductsSelected.Location = New System.Drawing.Point(13, 26)
        Me.lstProductsSelected.Margin = New System.Windows.Forms.Padding(10)
        Me.lstProductsSelected.Name = "lstProductsSelected"
        Me.lstProductsSelected.Size = New System.Drawing.Size(460, 160)
        Me.lstProductsSelected.TabIndex = 0
        '
        'ctxShoppingCartForm
        '
        Me.ctxShoppingCartForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxMenuPrintBooks, Me.ctxMenuAudioBooks})
        Me.ctxShoppingCartForm.Name = "ctxShoppingCartForm"
        Me.ctxShoppingCartForm.Size = New System.Drawing.Size(142, 48)
        '
        'ctxMenuPrintBooks
        '
        Me.ctxMenuPrintBooks.Name = "ctxMenuPrintBooks"
        Me.ctxMenuPrintBooks.Size = New System.Drawing.Size(141, 22)
        Me.ctxMenuPrintBooks.Text = "Print Books"
        '
        'ctxMenuAudioBooks
        '
        Me.ctxMenuAudioBooks.Name = "ctxMenuAudioBooks"
        Me.ctxMenuAudioBooks.Size = New System.Drawing.Size(141, 22)
        Me.ctxMenuAudioBooks.Text = "Audio Books"
        '
        'frmShoppingCartByErickLopez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 311)
        Me.ContextMenuStrip = Me.ctxShoppingCartForm
        Me.Controls.Add(Me.grpProductsSelected)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.MainMenuStrip = Me.mnuMenuStrip
        Me.Name = "frmShoppingCartByErickLopez"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopping Cart by Erick Lopez"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.grpProductsSelected.ResumeLayout(False)
        Me.grpProductsSelected.PerformLayout()
        Me.ctxShoppingCartForm.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileReset As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuProducts As ToolStripMenuItem
    Friend WithEvents mnuProductsPrintBooks As ToolStripMenuItem
    Friend WithEvents mnuProductsAudioBooks As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents grpProductsSelected As GroupBox
    Friend WithEvents lblDisplayTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDisplayShipping As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblDisplayTax As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblDisplaySubtotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents btnRemoveSelectedProduct As Button
    Friend WithEvents lstProductsSelected As ListBox
    Friend WithEvents ctxShoppingCartForm As ContextMenuStrip
    Friend WithEvents ctxMenuPrintBooks As ToolStripMenuItem
    Friend WithEvents ctxMenuAudioBooks As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
