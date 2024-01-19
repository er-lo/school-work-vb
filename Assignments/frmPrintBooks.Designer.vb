<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintBooks
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
        Me.grpSelectPrintBook = New System.Windows.Forms.GroupBox()
        Me.lstSelectablePrintBooks = New System.Windows.Forms.ListBox()
        Me.btnAddPrintBookToCart = New System.Windows.Forms.Button()
        Me.btnClosePrintBookForm = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpSelectPrintBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSelectPrintBook
        '
        Me.grpSelectPrintBook.Controls.Add(Me.lstSelectablePrintBooks)
        Me.grpSelectPrintBook.Location = New System.Drawing.Point(29, 19)
        Me.grpSelectPrintBook.Margin = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.grpSelectPrintBook.Name = "grpSelectPrintBook"
        Me.grpSelectPrintBook.Size = New System.Drawing.Size(449, 150)
        Me.grpSelectPrintBook.TabIndex = 0
        Me.grpSelectPrintBook.TabStop = False
        Me.grpSelectPrintBook.Text = "Select a Print Book"
        '
        'lstSelectablePrintBooks
        '
        Me.lstSelectablePrintBooks.FormattingEnabled = True
        Me.lstSelectablePrintBooks.Items.AddRange(New Object() {"I Did It Your Way", "The History of Scotland", "Learn Calculus in One Day", "Feel the Stress"})
        Me.lstSelectablePrintBooks.Location = New System.Drawing.Point(23, 26)
        Me.lstSelectablePrintBooks.Margin = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.lstSelectablePrintBooks.Name = "lstSelectablePrintBooks"
        Me.lstSelectablePrintBooks.Size = New System.Drawing.Size(403, 108)
        Me.lstSelectablePrintBooks.TabIndex = 0
        '
        'btnAddPrintBookToCart
        '
        Me.btnAddPrintBookToCart.Location = New System.Drawing.Point(114, 185)
        Me.btnAddPrintBookToCart.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.btnAddPrintBookToCart.Name = "btnAddPrintBookToCart"
        Me.btnAddPrintBookToCart.Size = New System.Drawing.Size(130, 40)
        Me.btnAddPrintBookToCart.TabIndex = 1
        Me.btnAddPrintBookToCart.Text = "&Add Book to Cart"
        Me.ToolTip1.SetToolTip(Me.btnAddPrintBookToCart, "Click to add book to cart on main form.")
        Me.btnAddPrintBookToCart.UseVisualStyleBackColor = True
        '
        'btnClosePrintBookForm
        '
        Me.btnClosePrintBookForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClosePrintBookForm.Location = New System.Drawing.Point(264, 185)
        Me.btnClosePrintBookForm.Margin = New System.Windows.Forms.Padding(10, 3, 3, 10)
        Me.btnClosePrintBookForm.Name = "btnClosePrintBookForm"
        Me.btnClosePrintBookForm.Size = New System.Drawing.Size(130, 40)
        Me.btnClosePrintBookForm.TabIndex = 2
        Me.btnClosePrintBookForm.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.btnClosePrintBookForm, "Click to close this window.")
        Me.btnClosePrintBookForm.UseVisualStyleBackColor = True
        '
        'frmPrintBooks
        '
        Me.AcceptButton = Me.btnAddPrintBookToCart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClosePrintBookForm
        Me.ClientSize = New System.Drawing.Size(507, 244)
        Me.Controls.Add(Me.btnClosePrintBookForm)
        Me.Controls.Add(Me.btnAddPrintBookToCart)
        Me.Controls.Add(Me.grpSelectPrintBook)
        Me.Name = "frmPrintBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print Books"
        Me.grpSelectPrintBook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSelectPrintBook As GroupBox
    Friend WithEvents lstSelectablePrintBooks As ListBox
    Friend WithEvents btnAddPrintBookToCart As Button
    Friend WithEvents btnClosePrintBookForm As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
