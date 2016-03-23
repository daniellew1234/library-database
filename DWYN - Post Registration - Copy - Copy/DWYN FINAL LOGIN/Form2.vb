Public Class frmStaffLogin



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
            'FillBy method will only pass the email value given by user to the query if there is a matching record
            'if there is a matching record, then number of rows will equate to one. If however, the email that
            'is passes to us is not in our table, then number of rows will equal zero


            NumberofRows = EmployeeTableAdapter.FillByEmail(Database6DataSet.Employee, txtEmail.Text)


            'if data matches a record, go get me a record. The zero indicates that we need to start
            'looking in the very first position in our collection (column 1 row 1). Initial position 0
            If NumberofRows = 1 Then
                RowData = EmployeeTableAdapter.GetDataByEmail(txtEmail.Text)(0)
                Password = RowData.Password 'this line of code grabs the password from our record. Password, our
                'variable, is an assignment statement. Column holds our password


                'Pseudocode: if the entered password matches, show form 2
                If Password = txtPassword.Text Then

                    'Me.Hide()
                    'Form2.Show()
                    MessageBox.Show("LOGIN SUCCESSFUL")
                Else
                    MessageBox.Show("LOGIN UNSUCCESSFUL") 'DISPLAY THE MESSAGE IF LOGIN WAS NOT SUCCESSFUL
                    txtPassword.Clear()
                End If
            Else
                MessageBox.Show("No record of this email registered. Please try a different email or register as a new user")

            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles DWYN.Enter

        Me.DWYN.BackColor = Color.FromArgb(128, 0, 0, 0)

    End Sub

End Class