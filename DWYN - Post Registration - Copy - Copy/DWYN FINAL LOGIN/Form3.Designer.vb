<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPasswordTwo = New System.Windows.Forms.TextBox()
        Me.txtPasswordOne = New System.Windows.Forms.TextBox()
        Me.LibraryMembersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.LibraryMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database6DataSet = New DWYN_FINAL_LOGIN.Database6DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibraryMembersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillByEmailToolStrip = New System.Windows.Forms.ToolStrip()
        Me.EmailToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EmailToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByEmailToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByEmailToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.EmailToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.EmailToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByEmailToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.LibraryMembersTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryMembersTableAdapter()
        Me.TableAdapterManager = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager()
        Me.CheckoutTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.CheckoutTableAdapter()
        Me.EmployeeTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.EmployeeTableAdapter()
        Me.LibraryResourcesTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryResourcesTableAdapter()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.LibraryMembersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibraryMembersBindingNavigator.SuspendLayout()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByEmailToolStrip.SuspendLayout()
        Me.FillByEmailToolStrip1.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(60, 141)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(144, 20)
        Me.txtLastName.TabIndex = 0
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(222, 141)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(144, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(60, 200)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(280, 20)
        Me.txtAddress.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(60, 261)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(144, 20)
        Me.txtCity.TabIndex = 3
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(306, 261)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtZipCode.MaxLength = 5
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(144, 20)
        Me.txtZipCode.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(57, 319)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(287, 20)
        Me.txtEmail.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "*LAST NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(218, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "*FIRST NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(57, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "*ADDRESS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(218, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "*STATE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(302, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "*ZIP CODE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(57, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "*CITY"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(53, 294)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(122, 20)
        Me.lblEmail.TabIndex = 31
        Me.lblEmail.Text = "*EMAIL ADDRESS"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Salmon
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSubmit.Location = New System.Drawing.Point(331, 442)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(119, 68)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "&SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.cmbState)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.txtZipCode)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.txtPasswordTwo)
        Me.GroupBox1.Controls.Add(Me.txtPasswordOne)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(177, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 577)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Info"
        '
        'cmbState
        '
        Me.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cmbState.Location = New System.Drawing.Point(230, 259)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(45, 21)
        Me.cmbState.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(408, 32)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Create a free DWYN Library Membership account in order " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to enjoy access to our e" & _
    "xtensive library resources "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(241, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "*RE-ENTER PASSWORD"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(84, 465)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 45)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(81, 430)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(36, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Clear"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(53, 359)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(89, 20)
        Me.lblPassword.TabIndex = 36
        Me.lblPassword.Text = "*PASSWORD"
        '
        'txtPasswordTwo
        '
        Me.txtPasswordTwo.Location = New System.Drawing.Point(247, 382)
        Me.txtPasswordTwo.Name = "txtPasswordTwo"
        Me.txtPasswordTwo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordTwo.Size = New System.Drawing.Size(130, 20)
        Me.txtPasswordTwo.TabIndex = 8
        '
        'txtPasswordOne
        '
        Me.txtPasswordOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordOne.Location = New System.Drawing.Point(57, 382)
        Me.txtPasswordOne.Name = "txtPasswordOne"
        Me.txtPasswordOne.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordOne.Size = New System.Drawing.Size(130, 20)
        Me.txtPasswordOne.TabIndex = 7
        '
        'LibraryMembersBindingNavigator
        '
        Me.LibraryMembersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LibraryMembersBindingNavigator.BindingSource = Me.LibraryMembersBindingSource
        Me.LibraryMembersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LibraryMembersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LibraryMembersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LibraryMembersBindingNavigatorSaveItem})
        Me.LibraryMembersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LibraryMembersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LibraryMembersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LibraryMembersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LibraryMembersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LibraryMembersBindingNavigator.Name = "LibraryMembersBindingNavigator"
        Me.LibraryMembersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LibraryMembersBindingNavigator.Size = New System.Drawing.Size(874, 25)
        Me.LibraryMembersBindingNavigator.TabIndex = 35
        Me.LibraryMembersBindingNavigator.Text = "BindingNavigator1"
        Me.LibraryMembersBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'LibraryMembersBindingSource
        '
        Me.LibraryMembersBindingSource.DataMember = "LibraryMembers"
        Me.LibraryMembersBindingSource.DataSource = Me.Database6DataSet
        '
        'Database6DataSet
        '
        Me.Database6DataSet.DataSetName = "Database6DataSet"
        Me.Database6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LibraryMembersBindingNavigatorSaveItem
        '
        Me.LibraryMembersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LibraryMembersBindingNavigatorSaveItem.Name = "LibraryMembersBindingNavigatorSaveItem"
        Me.LibraryMembersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LibraryMembersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillByEmailToolStrip
        '
        Me.FillByEmailToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailToolStripLabel, Me.EmailToolStripTextBox, Me.FillByEmailToolStripButton})
        Me.FillByEmailToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByEmailToolStrip.Name = "FillByEmailToolStrip"
        Me.FillByEmailToolStrip.Size = New System.Drawing.Size(874, 25)
        Me.FillByEmailToolStrip.TabIndex = 36
        Me.FillByEmailToolStrip.Text = "FillByEmailToolStrip"
        Me.FillByEmailToolStrip.Visible = False
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
        'FillByEmailToolStrip1
        '
        Me.FillByEmailToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailToolStripLabel1, Me.EmailToolStripTextBox1, Me.FillByEmailToolStripButton1})
        Me.FillByEmailToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillByEmailToolStrip1.Name = "FillByEmailToolStrip1"
        Me.FillByEmailToolStrip1.Size = New System.Drawing.Size(874, 25)
        Me.FillByEmailToolStrip1.TabIndex = 37
        Me.FillByEmailToolStrip1.Text = "FillByEmailToolStrip1"
        Me.FillByEmailToolStrip1.Visible = False
        '
        'EmailToolStripLabel1
        '
        Me.EmailToolStripLabel1.Name = "EmailToolStripLabel1"
        Me.EmailToolStripLabel1.Size = New System.Drawing.Size(39, 22)
        Me.EmailToolStripLabel1.Text = "Email:"
        '
        'EmailToolStripTextBox1
        '
        Me.EmailToolStripTextBox1.Name = "EmailToolStripTextBox1"
        Me.EmailToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'FillByEmailToolStripButton1
        '
        Me.FillByEmailToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByEmailToolStripButton1.Name = "FillByEmailToolStripButton1"
        Me.FillByEmailToolStripButton1.Size = New System.Drawing.Size(68, 22)
        Me.FillByEmailToolStripButton1.Text = "FillByEmail"
        '
        'LibraryMembersTableAdapter
        '
        Me.LibraryMembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Me.CheckoutTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.LibraryMembersTableAdapter = Me.LibraryMembersTableAdapter
        Me.TableAdapterManager.LibraryResourcesTableAdapter = Me.LibraryResourcesTableAdapter
        Me.TableAdapterManager.UpdateOrder = DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CheckoutTableAdapter
        '
        Me.CheckoutTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'LibraryResourcesTableAdapter
        '
        Me.LibraryResourcesTableAdapter.ClearBeforeFill = True
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Database6DataSet
        '
        'CheckoutBindingSource
        '
        Me.CheckoutBindingSource.DataMember = "Checkout"
        Me.CheckoutBindingSource.DataSource = Me.Database6DataSet
        '
        'LibraryResourcesBindingSource
        '
        Me.LibraryResourcesBindingSource.DataMember = "LibraryResources"
        Me.LibraryResourcesBindingSource.DataSource = Me.Database6DataSet
        '
        'Form3
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(874, 678)
        Me.Controls.Add(Me.LibraryMembersBindingNavigator)
        Me.Controls.Add(Me.FillByEmailToolStrip)
        Me.Controls.Add(Me.FillByEmailToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "DWYN Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LibraryMembersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibraryMembersBindingNavigator.ResumeLayout(False)
        Me.LibraryMembersBindingNavigator.PerformLayout()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByEmailToolStrip.ResumeLayout(False)
        Me.FillByEmailToolStrip.PerformLayout()
        Me.FillByEmailToolStrip1.ResumeLayout(False)
        Me.FillByEmailToolStrip1.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPasswordTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordOne As System.Windows.Forms.TextBox
    Friend WithEvents Database6DataSet As DWYN_FINAL_LOGIN.Database6DataSet
    Friend WithEvents LibraryMembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryMembersTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryMembersTableAdapter
    Friend WithEvents TableAdapterManager As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibraryMembersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LibraryMembersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByEmailToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents EmailToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EmailToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByEmailToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmployeeTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FillByEmailToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents EmailToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EmailToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByEmailToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CheckoutTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents CheckoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryResourcesTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryResourcesTableAdapter
    Friend WithEvents LibraryResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbState As System.Windows.Forms.ComboBox
End Class
