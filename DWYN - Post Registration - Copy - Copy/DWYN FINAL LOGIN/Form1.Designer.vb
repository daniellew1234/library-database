<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLOGIN))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lnkStaff = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DWYN = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Database6DataSet = New DWYN_FINAL_LOGIN.Database6DataSet()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckoutTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.CheckoutTableAdapter()
        Me.TableAdapterManager = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager()
        Me.EmployeeTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.EmployeeTableAdapter()
        Me.LibraryMembersTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryMembersTableAdapter()
        Me.LibraryResourcesTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryResourcesTableAdapter()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DWYN.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Salmon
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(239, 233)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 50)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(162, 96)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(177, 26)
        Me.txtEmail.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(162, 162)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(177, 26)
        Me.txtPassword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Salmon
        Me.btnSignUp.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSignUp.Location = New System.Drawing.Point(46, 235)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(119, 48)
        Me.btnSignUp.TabIndex = 3
        Me.btnSignUp.Text = "&Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lnkStaff
        '
        Me.lnkStaff.AutoSize = True
        Me.lnkStaff.BackColor = System.Drawing.Color.Transparent
        Me.lnkStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lnkStaff.LinkColor = System.Drawing.Color.White
        Me.lnkStaff.Location = New System.Drawing.Point(188, 193)
        Me.lnkStaff.Name = "lnkStaff"
        Me.lnkStaff.Size = New System.Drawing.Size(165, 20)
        Me.lnkStaff.TabIndex = 6
        Me.lnkStaff.TabStop = True
        Me.lnkStaff.Text = "Click Here for Staff Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Email Address"
        '
        'DWYN
        '
        Me.DWYN.BackColor = System.Drawing.Color.Black
        Me.DWYN.Controls.Add(Me.btnLogin)
        Me.DWYN.Controls.Add(Me.lnkStaff)
        Me.DWYN.Controls.Add(Me.Label4)
        Me.DWYN.Controls.Add(Me.Label1)
        Me.DWYN.Controls.Add(Me.btnSignUp)
        Me.DWYN.Controls.Add(Me.txtPassword)
        Me.DWYN.Controls.Add(Me.Label2)
        Me.DWYN.Controls.Add(Me.txtEmail)
        Me.DWYN.Location = New System.Drawing.Point(254, 119)
        Me.DWYN.Name = "DWYN"
        Me.DWYN.Size = New System.Drawing.Size(379, 301)
        Me.DWYN.TabIndex = 9
        Me.DWYN.TabStop = False
        Me.DWYN.Text = "Login"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 74)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Founded in 2014, DWYN library has been serving the San Jose community for over 73" & _
    "0 hours. If you are a San Jose city member, feel free to sign up for access to u" & _
    "nlimited books!"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(122, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 61)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "DWYN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 116)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Database6DataSet
        '
        Me.Database6DataSet.DataSetName = "Database6DataSet"
        Me.Database6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckoutBindingSource
        '
        Me.CheckoutBindingSource.DataMember = "Checkout"
        Me.CheckoutBindingSource.DataSource = Me.Database6DataSet
        '
        'CheckoutTableAdapter
        '
        Me.CheckoutTableAdapter.ClearBeforeFill = True
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
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'LibraryMembersTableAdapter
        '
        Me.LibraryMembersTableAdapter.ClearBeforeFill = True
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
        'frmLOGIN
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(705, 467)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DWYN)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmLOGIN"
        Me.Text = "DWYN Login"
        Me.DWYN.ResumeLayout(False)
        Me.DWYN.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database6DataSet As DWYN_FINAL_LOGIN.Database6DataSet
    Friend WithEvents CheckoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckoutTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents TableAdapterManager As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryMembersTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryMembersTableAdapter
    Friend WithEvents LibraryMembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryResourcesTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.LibraryResourcesTableAdapter
    Friend WithEvents LibraryResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSignUp As System.Windows.Forms.Button
    Friend WithEvents lnkStaff As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DWYN As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
