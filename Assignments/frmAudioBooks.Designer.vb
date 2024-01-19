<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioBooks
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
        Me.btnCloseAudioBookForm = New System.Windows.Forms.Button()
        Me.btnAddAudioBookToCart = New System.Windows.Forms.Button()
        Me.grpSelectAudioBook = New System.Windows.Forms.GroupBox()
        Me.lstSelectableAudioBooks = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpSelectAudioBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCloseAudioBookForm
        '
        Me.btnCloseAudioBookForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCloseAudioBookForm.Location = New System.Drawing.Point(264, 185)
        Me.btnCloseAudioBookForm.Margin = New System.Windows.Forms.Padding(10, 3, 3, 10)
        Me.btnCloseAudioBookForm.Name = "btnCloseAudioBookForm"
        Me.btnCloseAudioBookForm.Size = New System.Drawing.Size(130, 40)
        Me.btnCloseAudioBookForm.TabIndex = 5
        Me.btnCloseAudioBookForm.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.btnCloseAudioBookForm, "Click to close this window.")
        Me.btnCloseAudioBookForm.UseVisualStyleBackColor = True
        '
        'btnAddAudioBookToCart
        '
        Me.btnAddAudioBookToCart.Location = New System.Drawing.Point(114, 185)
        Me.btnAddAudioBookToCart.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.btnAddAudioBookToCart.Name = "btnAddAudioBookToCart"
        Me.btnAddAudioBookToCart.Size = New System.Drawing.Size(130, 40)
        Me.btnAddAudioBookToCart.TabIndex = 4
        Me.btnAddAudioBookToCart.Text = "&Add Book to Cart"
        Me.ToolTip1.SetToolTip(Me.btnAddAudioBookToCart, "Click to add book to the cart on the main form.")
        Me.btnAddAudioBookToCart.UseVisualStyleBackColor = True
        '
        'grpSelectAudioBook
        '
        Me.grpSelectAudioBook.Controls.Add(Me.lstSelectableAudioBooks)
        Me.grpSelectAudioBook.Location = New System.Drawing.Point(29, 19)
        Me.grpSelectAudioBook.Margin = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.grpSelectAudioBook.Name = "grpSelectAudioBook"
        Me.grpSelectAudioBook.Size = New System.Drawing.Size(449, 150)
        Me.grpSelectAudioBook.TabIndex = 3
        Me.grpSelectAudioBook.TabStop = False
        Me.grpSelectAudioBook.Text = "Select an Audio Book"
        '
        'lstSelectableAudioBooks
        '
        Me.lstSelectableAudioBooks.FormattingEnabled = True
        Me.lstSelectableAudioBooks.Items.AddRange(New Object() {"Learn Calculus in One Day", "The History of Scotland", "The Science of Body Language", "Relaxation Techniques"})
        Me.lstSelectableAudioBooks.Location = New System.Drawing.Point(23, 26)
        Me.lstSelectableAudioBooks.Margin = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.lstSelectableAudioBooks.Name = "lstSelectableAudioBooks"
        Me.lstSelectableAudioBooks.Size = New System.Drawing.Size(403, 108)
        Me.lstSelectableAudioBooks.TabIndex = 0
        '
        'frmAudioBooks
        '
        Me.AcceptButton = Me.btnAddAudioBookToCart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCloseAudioBookForm
        Me.ClientSize = New System.Drawing.Size(507, 244)
        Me.Controls.Add(Me.btnCloseAudioBookForm)
        Me.Controls.Add(Me.btnAddAudioBookToCart)
        Me.Controls.Add(Me.grpSelectAudioBook)
        Me.Name = "frmAudioBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Audio Books"
        Me.grpSelectAudioBook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCloseAudioBookForm As Button
    Friend WithEvents btnAddAudioBookToCart As Button
    Friend WithEvents grpSelectAudioBook As GroupBox
    Friend WithEvents lstSelectableAudioBooks As ListBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
