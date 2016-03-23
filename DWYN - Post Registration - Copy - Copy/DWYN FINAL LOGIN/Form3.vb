Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.Database6DataSet.LibraryResources)
        'TODO: This line of code loads data into the 'Database6DataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.Database6DataSet.Checkout)

        Me.GroupBox1.BackColor = Color.FromArgb(128, 0, 0, 0)


    End Sub

    Dim memberId As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'initilize variables
        Dim NumberOfRowsMembers As String

        Dim rand As New Random
        Dim MemberIDNumber As Integer
        Dim NumberOfRowsEmail As String

        'memberId = "PLIV" & memberId

        '' '' ''If IsNumeric(txtZipCode.Text) = False Then

        '' '' ''End If

        '' '' ''Dim strCpassword As String
        '' '' ''Dim strpassword As String

        '' '' ''strpassword = txtPasswordOne.Text
        '' '' ''strCpassword = txtPasswordTwo.Text

        '' '' ''If strCpassword <> "" Then
        '' '' ''    If strpassword <> strCpassword Then
        '' '' ''        MessageBox.Show("The passwords do not match. Please enter a matching password.")
        '' '' ''        txtPasswordTwo.SelectAll()
        '' '' ''        'e.Cancel = True
        '' '' ''    End If
        '' '' ''End If
        NumberOfRowsEmail = LibraryMembersTableAdapter.FillByEmail(Database6DataSet.LibraryMembers, txtEmail.Text)

      


        ' &&&&&&&&& error checking for repeat emails, nonmatching passwords, & empty input fields

        'Psuedocode:
        'if email already exists
        'display error message
        'if password one does not match password two
        'display error message
        'if textbox is empty 
        'display corresponding error message

        If NumberOfRowsEmail = 1 Then
            MessageBox.Show("Email already registered")
        ElseIf txtPasswordOne.Text <> txtPasswordTwo.Text Then
            MessageBox.Show("Passwords do not match")
        ElseIf txtFirstName.Text = String.Empty Then
            MessageBox.Show("Please enter first name")
        ElseIf txtLastName.Text = String.Empty Then
            MessageBox.Show("Please enter last name")
        ElseIf txtAddress.Text = String.Empty Then
            MessageBox.Show("Please enter address")
        ElseIf txtCity.Text = String.Empty Then
            MessageBox.Show("Please enter City")
        ElseIf cmbState.SelectedItem = Nothing Then
            MessageBox.Show("Please select a state")
        ElseIf CStr(IsNumeric(txtZipCode.Text)) = False Then
            MessageBox.Show("Please enter zip code")
        ElseIf txtEmail.Text = String.Empty Then
            MessageBox.Show("Please enter email")
        ElseIf txtPasswordOne.Text = String.Empty Then
            MessageBox.Show("Please enter password")
        ElseIf txtPasswordTwo.Text = String.Empty Then
            MessageBox.Show("Please enter password")

        Else
            ''''''&&&& loop to create member ID
            Do
                MemberIDNumber = rand.Next(0, 100000)

                If MemberIDNumber < 10 Then
                    memberId = "PLIV0000" & MemberIDNumber
                ElseIf MemberIDNumber < 100 Then
                    memberId = "PLIV000" & MemberIDNumber
                ElseIf MemberIDNumber < 1000 Then
                    memberId = "PLIV00" & MemberIDNumber
                ElseIf MemberIDNumber < 10000 Then
                    memberId = "PLIV0" & MemberIDNumber
                Else
                    memberId = "PLIV" & MemberIDNumber
                End If

                NumberOfRowsMembers = LibraryMembersTableAdapter.FillByMemberID(Database6DataSet.LibraryMembers, memberId)
            Loop While NumberOfRowsMembers = 1

            LibraryMembersTableAdapter.InsertNewMember(memberId, txtFirstName.Text, txtLastName.Text,
                                txtAddress.Text, txtCity.Text, cmbState.SelectedItem, txtZipCode.Text,
                                txtEmail.Text, (txtPasswordTwo.Text))

            MessageBox.Show("Registered")
            'field enteries 

            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtAddress.Text = ""
            txtCity.Text = ""
            txtZipCode.Text = ""
            cmbState.SelectedItem = Nothing
            txtEmail.Text = ""
            txtPasswordOne.Text = ""
            txtPasswordTwo.Text = ""
            frmLOGIN.Show()
            Me.Close()
        End If
        'LibraryMembersTableAdapter.InsertNewMember()
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'clear link
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtZipCode.Text = ""
        cmbState.SelectedItem = Nothing
        txtEmail.Text = ""
        txtPasswordOne.Text = ""
        txtPasswordTwo.Text = ""

    End Sub

    Private Sub LibraryMembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LibraryMembersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LibraryMembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database6DataSet)

    End Sub

    Private Sub FillByEmailToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByEmailToolStripButton.Click
        Try
            Me.LibraryMembersTableAdapter.FillByEmail(Me.Database6DataSet.LibraryMembers, EmailToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByEmailToolStripButton1_Click(sender As Object, e As EventArgs) Handles FillByEmailToolStripButton1.Click
        Try
            Me.EmployeeTableAdapter.FillByEmail(Me.Database6DataSet.Employee, EmailToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'cancel button
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtZipCode.Text = ""
        cmbState.SelectedItem = Nothing
        txtEmail.Text = ""
        txtPasswordOne.Text = ""
        txtPasswordTwo.Text = ""
        frmLOGIN.Show()
        Me.Close()
    End Sub

    'Private Sub txtLastName_Click(sender As Object, e As EventArgs) Handles txtLastName.Click
    '    txtLastName.Clear()
    'End Sub

    'Private Sub txtFirstName_Click(sender As Object, e As EventArgs) Handles txtFirstName.Click
    '    txtFirstName.Clear()
    'End Sub

    'Private Sub txtAddress_Click(sender As Object, e As EventArgs) Handles txtAddress.Click
    '    txtAddress.Clear()
    'End Sub

    'Private Sub txtCity_Click(sender As Object, e As EventArgs) Handles txtCity.Click
    'End Sub

    'Private Sub txtZipCode_Click(sender As Object, e As EventArgs) Handles txtZipCode.Click

    'End Sub

    'Private Sub txtEmail_Click(sender As Object, e As EventArgs) Handles txtEmail.Click

    'End Sub

    'Private Sub txtPasswordOne_Click(sender As Object, e As EventArgs) Handles txtPasswordOne.Click

    'End Sub

    'Private Sub txtPasswordTwo_Click(sender As Object, e As EventArgs) Handles txtPasswordTwo.Click

    'End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtLastName_GotFocus(sender As Object, e As EventArgs) Handles txtLastName.GotFocus
        txtLastName.SelectAll()

    End Sub

    Private Sub txtLastName_Click(sender As Object, e As EventArgs) Handles txtLastName.Click
        txtLastName.SelectAll()

    End Sub

    Private Sub txtLastName_DoubleClick(sender As Object, e As EventArgs) Handles txtLastName.DoubleClick
        txtLastName.DeselectAll()

    End Sub

End Class