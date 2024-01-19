<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkshopSelector
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
        Me.grpWorkshopListGroupBox = New System.Windows.Forms.GroupBox()
        Me.lstWorkshopList = New System.Windows.Forms.ListBox()
        Me.grpLocationListGroupBox = New System.Windows.Forms.GroupBox()
        Me.lstLocationList = New System.Windows.Forms.ListBox()
        Me.grpCostsGroupBox = New System.Windows.Forms.GroupBox()
        Me.lstCostsList = New System.Windows.Forms.ListBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblDisplayTotalCost = New System.Windows.Forms.Label()
        Me.btnAddWorkshop = New System.Windows.Forms.Button()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpWorkshopListGroupBox.SuspendLayout()
        Me.grpLocationListGroupBox.SuspendLayout()
        Me.grpCostsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpWorkshopListGroupBox
        '
        Me.grpWorkshopListGroupBox.Controls.Add(Me.lstWorkshopList)
        Me.grpWorkshopListGroupBox.Location = New System.Drawing.Point(19, 19)
        Me.grpWorkshopListGroupBox.Margin = New System.Windows.Forms.Padding(10)
        Me.grpWorkshopListGroupBox.Name = "grpWorkshopListGroupBox"
        Me.grpWorkshopListGroupBox.Size = New System.Drawing.Size(240, 200)
        Me.grpWorkshopListGroupBox.TabIndex = 0
        Me.grpWorkshopListGroupBox.TabStop = False
        Me.grpWorkshopListGroupBox.Text = "Pick a &Workshop"
        '
        'lstWorkshopList
        '
        Me.lstWorkshopList.FormattingEnabled = True
        Me.lstWorkshopList.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.lstWorkshopList.Location = New System.Drawing.Point(13, 27)
        Me.lstWorkshopList.Margin = New System.Windows.Forms.Padding(10)
        Me.lstWorkshopList.Name = "lstWorkshopList"
        Me.lstWorkshopList.Size = New System.Drawing.Size(214, 160)
        Me.lstWorkshopList.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstWorkshopList, "Click on a workshop to select.")
        '
        'grpLocationListGroupBox
        '
        Me.grpLocationListGroupBox.Controls.Add(Me.lstLocationList)
        Me.grpLocationListGroupBox.Location = New System.Drawing.Point(279, 19)
        Me.grpLocationListGroupBox.Margin = New System.Windows.Forms.Padding(10)
        Me.grpLocationListGroupBox.Name = "grpLocationListGroupBox"
        Me.grpLocationListGroupBox.Size = New System.Drawing.Size(240, 200)
        Me.grpLocationListGroupBox.TabIndex = 1
        Me.grpLocationListGroupBox.TabStop = False
        Me.grpLocationListGroupBox.Text = "Pick a &Location"
        '
        'lstLocationList
        '
        Me.lstLocationList.FormattingEnabled = True
        Me.lstLocationList.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lstLocationList.Location = New System.Drawing.Point(13, 27)
        Me.lstLocationList.Margin = New System.Windows.Forms.Padding(10)
        Me.lstLocationList.Name = "lstLocationList"
        Me.lstLocationList.Size = New System.Drawing.Size(214, 160)
        Me.lstLocationList.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstLocationList, "Click on a location to select.")
        '
        'grpCostsGroupBox
        '
        Me.grpCostsGroupBox.Controls.Add(Me.lstCostsList)
        Me.grpCostsGroupBox.Location = New System.Drawing.Point(539, 19)
        Me.grpCostsGroupBox.Margin = New System.Windows.Forms.Padding(10)
        Me.grpCostsGroupBox.Name = "grpCostsGroupBox"
        Me.grpCostsGroupBox.Size = New System.Drawing.Size(240, 200)
        Me.grpCostsGroupBox.TabIndex = 2
        Me.grpCostsGroupBox.TabStop = False
        Me.grpCostsGroupBox.Text = "List of &Costs"
        '
        'lstCostsList
        '
        Me.lstCostsList.FormatString = "C2"
        Me.lstCostsList.FormattingEnabled = True
        Me.lstCostsList.Location = New System.Drawing.Point(13, 27)
        Me.lstCostsList.Margin = New System.Windows.Forms.Padding(10)
        Me.lstCostsList.Name = "lstCostsList"
        Me.lstCostsList.Size = New System.Drawing.Size(214, 160)
        Me.lstCostsList.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstCostsList, "List of costs will be displayed.")
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(335, 288)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 3
        Me.lblTotalCost.Text = "Total Cost:"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayTotalCost
        '
        Me.lblDisplayTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayTotalCost.Location = New System.Drawing.Point(399, 283)
        Me.lblDisplayTotalCost.Name = "lblDisplayTotalCost"
        Me.lblDisplayTotalCost.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayTotalCost.TabIndex = 4
        Me.lblDisplayTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblDisplayTotalCost, "Total workshops cost.")
        '
        'btnAddWorkshop
        '
        Me.btnAddWorkshop.Location = New System.Drawing.Point(93, 374)
        Me.btnAddWorkshop.Margin = New System.Windows.Forms.Padding(10)
        Me.btnAddWorkshop.Name = "btnAddWorkshop"
        Me.btnAddWorkshop.Size = New System.Drawing.Size(140, 40)
        Me.btnAddWorkshop.TabIndex = 5
        Me.btnAddWorkshop.Text = "&Add Workshop"
        Me.ToolTip1.SetToolTip(Me.btnAddWorkshop, "Click to add a workshop.")
        Me.btnAddWorkshop.UseVisualStyleBackColor = True
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Enabled = False
        Me.btnCalculateTotal.Location = New System.Drawing.Point(253, 374)
        Me.btnCalculateTotal.Margin = New System.Windows.Forms.Padding(10)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(140, 40)
        Me.btnCalculateTotal.TabIndex = 6
        Me.btnCalculateTotal.Text = "Calculate &Total"
        Me.ToolTip1.SetToolTip(Me.btnCalculateTotal, "Click to calculate total cost.")
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(413, 374)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(10)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(140, 40)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click to reset fields and values.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(573, 374)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to exit program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmWorkshopSelector
        '
        Me.AcceptButton = Me.btnAddWorkshop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(798, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.btnAddWorkshop)
        Me.Controls.Add(Me.lblDisplayTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.grpCostsGroupBox)
        Me.Controls.Add(Me.grpLocationListGroupBox)
        Me.Controls.Add(Me.grpWorkshopListGroupBox)
        Me.Name = "frmWorkshopSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Workshop Selector by Erick Lopez"
        Me.grpWorkshopListGroupBox.ResumeLayout(False)
        Me.grpLocationListGroupBox.ResumeLayout(False)
        Me.grpCostsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpWorkshopListGroupBox As GroupBox
    Friend WithEvents lstWorkshopList As ListBox
    Friend WithEvents grpLocationListGroupBox As GroupBox
    Friend WithEvents lstLocationList As ListBox
    Friend WithEvents grpCostsGroupBox As GroupBox
    Friend WithEvents lstCostsList As ListBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblDisplayTotalCost As Label
    Friend WithEvents btnAddWorkshop As Button
    Friend WithEvents btnCalculateTotal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
