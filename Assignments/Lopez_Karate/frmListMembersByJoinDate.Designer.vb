<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListMembersByJoinDate
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
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDateSelection = New System.Windows.Forms.GroupBox()
        Me.radOnOrAfterDate = New System.Windows.Forms.RadioButton()
        Me.radBeforeDate = New System.Windows.Forms.RadioButton()
        Me.dtpSelectedDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSelectDate = New System.Windows.Forms.Label()
        Me.dgvMembersByJoinDate = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsKarate = New Lopez_Karate.dsKarate()
        Me.MembersTableAdapter = New Lopez_Karate.dsKarateTableAdapters.MembersTableAdapter()
        Me.mnuStrip.SuspendLayout()
        Me.grpDateSelection.SuspendLayout()
        CType(Me.dgvMembersByJoinDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsKarate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(584, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(103, 22)
        Me.mnuFileClose.Text = "&Close"
        '
        'grpDateSelection
        '
        Me.grpDateSelection.Controls.Add(Me.radOnOrAfterDate)
        Me.grpDateSelection.Controls.Add(Me.radBeforeDate)
        Me.grpDateSelection.Controls.Add(Me.dtpSelectedDate)
        Me.grpDateSelection.Controls.Add(Me.lblSelectDate)
        Me.grpDateSelection.Location = New System.Drawing.Point(13, 28)
        Me.grpDateSelection.Name = "grpDateSelection"
        Me.grpDateSelection.Size = New System.Drawing.Size(559, 53)
        Me.grpDateSelection.TabIndex = 1
        Me.grpDateSelection.TabStop = False
        Me.grpDateSelection.Text = "Date Selection"
        '
        'radOnOrAfterDate
        '
        Me.radOnOrAfterDate.AutoSize = True
        Me.radOnOrAfterDate.Location = New System.Drawing.Point(312, 26)
        Me.radOnOrAfterDate.Name = "radOnOrAfterDate"
        Me.radOnOrAfterDate.Size = New System.Drawing.Size(102, 17)
        Me.radOnOrAfterDate.TabIndex = 3
        Me.radOnOrAfterDate.TabStop = True
        Me.radOnOrAfterDate.Text = "On or After Date"
        Me.radOnOrAfterDate.UseVisualStyleBackColor = True
        '
        'radBeforeDate
        '
        Me.radBeforeDate.AutoSize = True
        Me.radBeforeDate.Location = New System.Drawing.Point(223, 26)
        Me.radBeforeDate.Name = "radBeforeDate"
        Me.radBeforeDate.Size = New System.Drawing.Size(82, 17)
        Me.radBeforeDate.TabIndex = 2
        Me.radBeforeDate.TabStop = True
        Me.radBeforeDate.Text = "Before Date"
        Me.radBeforeDate.UseVisualStyleBackColor = True
        '
        'dtpSelectedDate
        '
        Me.dtpSelectedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSelectedDate.Location = New System.Drawing.Point(87, 22)
        Me.dtpSelectedDate.Name = "dtpSelectedDate"
        Me.dtpSelectedDate.Size = New System.Drawing.Size(98, 20)
        Me.dtpSelectedDate.TabIndex = 1
        '
        'lblSelectDate
        '
        Me.lblSelectDate.AutoSize = True
        Me.lblSelectDate.Location = New System.Drawing.Point(6, 28)
        Me.lblSelectDate.Name = "lblSelectDate"
        Me.lblSelectDate.Size = New System.Drawing.Size(75, 13)
        Me.lblSelectDate.TabIndex = 0
        Me.lblSelectDate.Text = "Select a Date:"
        Me.lblSelectDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvMembersByJoinDate
        '
        Me.dgvMembersByJoinDate.AllowUserToAddRows = False
        Me.dgvMembersByJoinDate.AllowUserToDeleteRows = False
        Me.dgvMembersByJoinDate.AutoGenerateColumns = False
        Me.dgvMembersByJoinDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMembersByJoinDate.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMembersByJoinDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembersByJoinDate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn})
        Me.dgvMembersByJoinDate.DataSource = Me.MembersBindingSource
        Me.dgvMembersByJoinDate.Location = New System.Drawing.Point(13, 88)
        Me.dgvMembersByJoinDate.Name = "dgvMembersByJoinDate"
        Me.dgvMembersByJoinDate.ReadOnly = True
        Me.dgvMembersByJoinDate.RowHeadersVisible = False
        Me.dgvMembersByJoinDate.Size = New System.Drawing.Size(559, 261)
        Me.dgvMembersByJoinDate.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        Me.DateJoinedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.DsKarate
        '
        'DsKarate
        '
        Me.DsKarate.DataSetName = "dsKarate"
        Me.DsKarate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'frmListMembersByJoinDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.dgvMembersByJoinDate)
        Me.Controls.Add(Me.grpDateSelection)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmListMembersByJoinDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmListMembersByJoinDate"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.grpDateSelection.ResumeLayout(False)
        Me.grpDateSelection.PerformLayout()
        CType(Me.dgvMembersByJoinDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsKarate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents grpDateSelection As GroupBox
    Friend WithEvents radOnOrAfterDate As RadioButton
    Friend WithEvents radBeforeDate As RadioButton
    Friend WithEvents dtpSelectedDate As DateTimePicker
    Friend WithEvents lblSelectDate As Label
    Friend WithEvents dgvMembersByJoinDate As DataGridView
    Friend WithEvents DsKarate As dsKarate
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As dsKarateTableAdapters.MembersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
