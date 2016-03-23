Public Class frmLOGIN

    Public memberIDGlobal As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'login code
        Dim NumberofRows As Integer

        Dim RowData As Object
        Dim Password As String

        'the following prompts a user to enter an email address and password if submit a blank field
        'PSUEDOCODE: if user enters blank, display message
        If txtEmail.Text = String.Empty Or txtPassword.Text = String.Empty Then
            MessageBox.Show("Please enter valid email and password")

        Else


            NumberofRows = LibraryMembersTableAdapter.FillByEmail(Database6DataSet.LibraryMembers, txtEmail.Text)


            'if data matches a record, go get me a record. The zero indicates that we need to start
            'looking in the very first position in our collection (column 1 row 1). Initial position 0
            If NumberofRows = 1 Then
                RowData = LibraryMembersTableAdapter.GetDataByEmail(txtEmail.Text)(0)
                Password = RowData.Password 'this line of code grabs the password from our record. Password, our
                'variable, is an assignment statement. Column holds our password


                'Pseudocode: if the entered password matches, show form 2
                If Password = txtPassword.Text Then

                    txtEmail.Clear()
                    txtPassword.Clear()
                    'Me.Close()
                    Form4.Show()
                    'MessageBox.Show("LOGIN SUCCESSFUL")
                    memberIDGlobal = RowData.MemberID
                    Form4.RefreshTable()

                Else
                    MessageBox.Show("LOGIN UNSUCCESSFUL") 'DISPLAY THE MESSAGE IF LOGIN WAS NOT SUCCESSFUL
                    txtPassword.Clear()
                End If
            Else
                MessageBox.Show("No record of this email registered. Please try a different email or register as a new user")

            End If
        End If

    End Sub


    Private Sub LibraryMembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LibraryMembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database6DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.Database6DataSet.Checkout)
        'TODO: This line of code loads data into the 'Database6DataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.Database6DataSet.LibraryResources)
        'TODO: This line of code loads data into the 'Database6DataSet.Employee' table. You can move, or remove it, as needed.
        'Me.EmployeeTableAdapter.Fill(Me.Database6DataSet.Employee)
        'TODO: This line of code loads data into the 'Database6DataSet.LibraryMembers' table. You can move, or remove it, as needed.
        'Me.LibraryMembersTableAdapter.Fill(Me.Database6DataSet.LibraryMembers)

        'label color
        Me.DWYN.BackColor = Color.FromArgb(128, 0, 0, 0)
        'Me.Label3.BackColor = Color.FromArgb(128, 0, 0, 0)
        Me.Label4.BackColor = Color.FromArgb(140, 0, 0, 0)
    End Sub


    'Pseudocode: If user clicks on sign up button, display form 4

    ' Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
    '  frmMembership.Show()
    'End Sub

    'Private Sub lnkStaff_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkStaff.LinkClicked
    'code to send user to staff login

    'Form3.Show()
    '   Me.Hide()


    'End Sub


    Private Sub lnkStaff_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkStaff.LinkClicked
        frmStaffLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        txtEmail.Clear()
        txtPassword.Clear()
        Form3.Show()
        Me.Hide()
    End Sub


    ' Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles DWYN.Enter
    '    Me.DWYN.BackColor = Color.FromArgb(128, 0, 0, 0)

    'End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class

'  End Sub

'Private Sub batSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
'frmMembership.Show()
'Me.Hide()
'End Sub

'Private Sub lnkStaff_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkStaff.LinkClicked
'frmStaffLogin.Show()
' Me.Hide()
'End Sub
'End Class
