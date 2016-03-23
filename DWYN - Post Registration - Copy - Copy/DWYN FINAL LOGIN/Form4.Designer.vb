<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVResults = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublicationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Series = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmResourceStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCheckoutPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmResourceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCheckedOutItems = New System.Windows.Forms.Button()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database6DataSet = New DWYN_FINAL_LOGIN.Database6DataSet()
        Me.CheckoutTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.CheckoutTableAdapter()
        Me.TableAdapterManager = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager()
        Me.LibraryMembersTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryMembersTableAdapter()
        Me.LibraryResourcesTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryResourcesTableAdapter()
        Me.LibraryMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EmailToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByEmailToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByEmailToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGVResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByEmailToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(87, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(621, 263)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DWYN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DGVResults
        '
        Me.DGVResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVResults.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Author, Me.PublicationDate, Me.Series, Me.clmResourceStatus, Me.clmCheckoutPeriod, Me.clmResourceID})
        Me.DGVResults.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVResults.Location = New System.Drawing.Point(113, 205)
        Me.DGVResults.Name = "DGVResults"
        Me.DGVResults.RowHeadersVisible = False
        Me.DGVResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVResults.Size = New System.Drawing.Size(581, 170)
        Me.DGVResults.TabIndex = 2
        '
        'Title
        '
        Me.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.Width = 52
        '
        'Author
        '
        Me.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        Me.Author.Width = 63
        '
        'PublicationDate
        '
        Me.PublicationDate.FillWeight = 75.0!
        Me.PublicationDate.HeaderText = "Publication Date"
        Me.PublicationDate.Name = "PublicationDate"
        '
        'Series
        '
        Me.Series.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Series.HeaderText = "Series"
        Me.Series.Name = "Series"
        Me.Series.Width = 61
        '
        'clmResourceStatus
        '
        Me.clmResourceStatus.FillWeight = 47.61905!
        Me.clmResourceStatus.HeaderText = "Due Date"
        Me.clmResourceStatus.Name = "clmResourceStatus"
        '
        'clmCheckoutPeriod
        '
        Me.clmCheckoutPeriod.HeaderText = "CheckoutPeriod"
        Me.clmCheckoutPeriod.Name = "clmCheckoutPeriod"
        Me.clmCheckoutPeriod.Visible = False
        '
        'clmResourceID
        '
        Me.clmResourceID.HeaderText = "ResourceId"
        Me.clmResourceID.Name = "clmResourceID"
        Me.clmResourceID.Visible = False
        '
        'btnCheckedOutItems
        '
        Me.btnCheckedOutItems.Location = New System.Drawing.Point(113, 381)
        Me.btnCheckedOutItems.Name = "btnCheckedOutItems"
        Me.btnCheckedOutItems.Size = New System.Drawing.Size(116, 23)
        Me.btnCheckedOutItems.TabIndex = 3
        Me.btnCheckedOutItems.Text = "Checked Out Items"
        Me.btnCheckedOutItems.UseVisualStyleBackColor = True
        Me.btnCheckedOutItems.Visible = False
        '
        'CheckoutBindingSource
        '
        Me.CheckoutBindingSource.DataMember = "Checkout"
        Me.CheckoutBindingSource.DataSource = Me.Database6DataSet
        '
        'Database6DataSet
        '
        Me.Database6DataSet.DataSetName = "Database6DataSet"
        Me.Database6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckoutTableAdapter
        '
        Me.CheckoutTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Me.CheckoutTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.LibraryMembersTableAdapter = Me.LibraryMembersTableAdapter
        Me.TableAdapterManager.LibraryResourcesTableAdapter = Me.LibraryResourcesTableAdapter
        Me.TableAdapterManager.UpdateOrder = DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LibraryMembersTableAdapter
        '
        Me.LibraryMembersTableAdapter.ClearBeforeFill = True
        '
        'LibraryResourcesTableAdapter
        '
        Me.LibraryResourcesTableAdapter.ClearBeforeFill = True
        '
        'LibraryMembersBindingSource
        '
        Me.LibraryMembersBindingSource.DataMember = "LibraryMembers"
        Me.LibraryMembersBindingSource.DataSource = Me.Database6DataSet
        '
        'LibraryResourcesBindingSource
        '
        Me.LibraryResourcesBindingSource.DataMember = "LibraryResources"
        Me.LibraryResourcesBindingSource.DataSource = Me.Database6DataSet
        '
        'EmailToolStripLabel
        '
        Me.EmailToolStripLabel.Name = "EmailToolStripLabel"
        Me.EmailToolStripLabel.Size = New System.Drawing.Size(39, 22)
        Me.EmailToolStripLabel.Text = "Email:"
        '
        'EmailToolStripTextBox
        '
        Me.EmailToolStripTextBox.Name = "EmailToolStripTextBox"
        Me.EmailToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByEmailToolStripButton
        '
        Me.FillByEmailToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByEmailToolStripButton.Name = "FillByEmailToolStripButton"
        Me.FillByEmailToolStripButton.Size = New System.Drawing.Size(68, 22)
        Me.FillByEmailToolStripButton.Text = "FillByEmail"
        '
        'FillByEmailToolStrip
        '
        Me.FillByEmailToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailToolStripLabel, Me.EmailToolStripTextBox, Me.FillByEmailToolStripButton})
        Me.FillByEmailToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByEmailToolStrip.Name = "FillByEmailToolStrip"
        Me.FillByEmailToolStrip.Size = New System.Drawing.Size(772, 25)
        Me.FillByEmailToolStrip.TabIndex = 6
        Me.FillByEmailToolStrip.Text = "FillByEmailToolStrip"
        Me.FillByEmailToolStrip.Visible = False
        '
        'btnRenew
        '
        Me.btnRenew.Location = New System.Drawing.Point(247, 381)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(75, 23)
        Me.btnRenew.TabIndex = 7
        Me.btnRenew.Text = "Renew"
        Me.btnRenew.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(772, 152)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(395, 381)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 9
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(677, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(66, 20)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log Out"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(564, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(772, 484)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.FillByEmailToolStrip)
        Me.Controls.Add(Me.btnCheckedOutItems)
        Me.Controls.Add(Me.DGVResults)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DGVResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByEmailToolStrip.ResumeLayout(False)
        Me.FillByEmailToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVResults As System.Windows.Forms.DataGridView
    Friend WithEvents btnCheckedOutItems As System.Windows.Forms.Button
    Friend WithEvents Database6DataSet As DWYN_FINAL_LOGIN.Database6DataSet
    Friend WithEvents CheckoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckoutTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents TableAdapterManager As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibraryMembersTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryMembersTableAdapter
    Friend WithEvents LibraryMembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryResourcesTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryResourcesTableAdapter
    Friend WithEvents LibraryResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmailToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EmailToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByEmailToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByEmailToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRenew As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Author As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublicationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Series As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmResourceStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCheckoutPeriod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmResourceID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
