<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffLogin))
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DWYN = New System.Windows.Forms.GroupBox()
        Me.Database6DataSet = New DWYN_FINAL_LOGIN.Database6DataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager()
        Me.lblStaffTitle = New System.Windows.Forms.Label()
        Me.DWYN.SuspendLayout()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(158, 60)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(160, 20)
        Me.txtEmail.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(158, 108)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(160, 20)
        Me.txtPassword.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Salmon
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(199, 151)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(119, 45)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'DWYN
        '
        Me.DWYN.BackColor = System.Drawing.Color.Black
        Me.DWYN.Controls.Add(Me.btnLogin)
        Me.DWYN.Controls.Add(Me.Label2)
        Me.DWYN.Controls.Add(Me.txtPassword)
        Me.DWYN.Controls.Add(Me.Label1)
        Me.DWYN.Controls.Add(Me.txtEmail)
        Me.DWYN.Location = New System.Drawing.Point(200, 125)
        Me.DWYN.Name = "DWYN"
        Me.DWYN.Size = New System.Drawing.Size(346, 229)
        Me.DWYN.TabIndex = 14
        Me.DWYN.TabStop = False
        Me.DWYN.Text = "GroupBox1"
        '
        'Database6DataSet
        '
        Me.Database6DataSet.DataSetName = "Database6DataSet"
        Me.Database6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Database6DataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.LibraryMembersTableAdapter = Nothing
        Me.TableAdapterManager.LibraryResourcesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblStaffTitle
        '
        Me.lblStaffTitle.AutoSize = True
        Me.lblStaffTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblStaffTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffTitle.Location = New System.Drawing.Point(22, 19)
        Me.lblStaffTitle.Name = "lblStaffTitle"
        Me.lblStaffTitle.Size = New System.Drawing.Size(105, 25)
        Me.lblStaffTitle.TabIndex = 15
        Me.lblStaffTitle.Text = "Staff Login"
        '
        'frmStaffLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(627, 420)
        Me.Controls.Add(Me.lblStaffTitle)
        Me.Controls.Add(Me.DWYN)
        Me.Name = "frmStaffLogin"
        Me.Text = "DWYN Staff Login"
        Me.DWYN.ResumeLayout(False)
        Me.DWYN.PerformLayout()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Database6DataSet As DWYN_FINAL_LOGIN.Database6DataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As DWYN_FINAL_LOGIN.Database6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DWYN As System.Windows.Forms.GroupBox
    Friend WithEvents lblStaffTitle As System.Windows.Forms.Label
End Class
