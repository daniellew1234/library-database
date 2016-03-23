Public Class Form4
    'list of public variables

    Dim RowData As Object
    Dim CheckoutPeriod As Long

    Dim CheckoutRecord As Integer
    Dim bookinfo As Object
    Dim resourceid As String
    Dim Resourcestatus As String
    Dim DueDate As Date
    Dim checkoutdate As Date
    Dim strSeries As String
    Dim memberId As String = frmLOGIN.memberIDGlobal


    'public loop
    Public Sub RefreshTable()
        Dim MemberIDTest As String = frmLOGIN.memberIDGlobal
        Dim NumberOfRows As Integer = 0
        DGVResults.Rows.Clear()
        'determines the number of books the current member has checked out
        'NumberOfRows = CheckoutTableAdapter.FillByMemberCheckOut(Database6DataSet.Checkout, memberId)
        NumberOfRows = CheckoutTableAdapter.FillByMemberCheckOut(Database6DataSet.Checkout, MemberIDTest)
        'of the memeber has at least one book checked out then

        'loop to check books logged out
        If NumberOfRows > 0 Then
            Dim x As Integer = 0

            For x = 0 To NumberOfRows - 1 Step 1

                bookinfo = CheckoutTableAdapter.GetDataByMemberCheckOut(MemberIDTest)(x)
                resourceid = bookinfo.resourceID

                RowData = LibraryResourcesTableAdapter.GetDataByResourceID(resourceid)(0)

                checkoutdate = bookinfo.checkoutdate

                ' CheckoutPeriod = RowData.checkoutperiod

                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)

                Resourcestatus = DueDate.Date

                If RowData.IsCheckOutPeriodNull = True Then
                    CheckoutPeriod = 14
                Else
                    CheckoutPeriod = RowData.CheckOutPeriod
                End If

                If RowData.IsSeriesNull = True Then
                    strSeries = "None"
                Else
                    strSeries = RowData.Series
                End If



                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell


                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.title
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                If RowData.isauthormiddlenull = True Then
                    dgvCell.Value = RowData.authorfirst & " " & RowData.authorlast
                Else
                    dgvCell.Value = RowData.authorfirst & " " & RowData.authormiddle & " " & RowData.authorlast
                End If
                dgvRow.Cells.Add(dgvCell)


                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.publicationdate
                dgvRow.Cells.Add(dgvCell)


                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = strSeries
                dgvRow.Cells.Add(dgvCell)

                'dgvCell = New DataGridViewTextBoxCell()
                'dgvCell.Value = RowData.Date
                'dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Resourcestatus
                dgvRow.Cells.Add(dgvCell)



                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = CheckoutPeriod
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = resourceid
                dgvRow.Cells.Add(dgvCell)


                DGVResults.Rows.Add(dgvRow)
                'Results is the name of the DataGridView Control added to the Form

            Next

        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked at this time")
        End If

    End Sub

    Private Sub btnCheckedOutItems_Click(sender As Object, e As EventArgs) Handles btnCheckedOutItems.Click
        RefreshTable()
        'Dim MemberIDTest As String = frmLOGIN.memberIDGlobal
        'Dim NumberOfRows As Integer = 0
        'DGVResults.Rows.Clear()
        ''determines the number of books the current member has checked out
        ''NumberOfRows = CheckoutTableAdapter.FillByMemberCheckOut(Database6DataSet.Checkout, memberId)
        'NumberOfRows = CheckoutTableAdapter.FillByMemberCheckOut(Database6DataSet.Checkout, MemberIDTest)
        ''of the memeber has at least one book checked out then


        'If NumberOfRows > 0 Then
        '    Dim x As Integer = 0

        '    For x = 0 To NumberOfRows - 1 Step 1

        '        bookinfo = CheckoutTableAdapter.GetDataByMemberCheckOut(MemberIDTest)(x)
        '        resourceid = bookinfo.resourceID

        '        RowData = LibraryResourcesTableAdapter.GetDataByResourceID(resourceid)(0)

        '        checkoutdate = bookinfo.checkoutdate

        '        ' CheckoutPeriod = RowData.checkoutperiod

        '        DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)

        '        Resourcestatus = "Due " & DueDate.Date

        '        If RowData.IsCheckOutPeriodNull = True Then
        '            CheckoutPeriod = 14
        '        Else
        '            CheckoutPeriod = RowData.CheckOutPeriod
        '        End If

        '        If RowData.IsSeriesNull = True Then
        '            strSeries = "None"
        '        Else
        '            strSeries = RowData.Series
        '        End If



        '        Dim dgvRow As New DataGridViewRow
        '        Dim dgvCell As DataGridViewCell


        '        dgvCell = New DataGridViewTextBoxCell()
        '        dgvCell.Value = RowData.title
        '        dgvRow.Cells.Add(dgvCell)

        '        dgvCell = New DataGridViewTextBoxCell()
        '        dgvCell.Value = RowData.authorlast
        '        dgvRow.Cells.Add(dgvCell)


        '        dgvCell = New DataGridViewTextBoxCell()
        '        dgvCell.Value = RowData.publicationdate
        '        dgvRow.Cells.Add(dgvCell)


        '        dgvCell = New DataGridViewTextBoxCell()
        '        dgvCell.Value = strSeries
        '        dgvRow.Cells.Add(dgvCell)

        '        'dgvCell = New DataGridViewTextBoxCell()
        '        'dgvCell.Value = RowData.Date
        '        'dgvRow.Cells.Add(dgvCell)

        '        dgvCell = New DataGridViewTextBoxCell()
        '        dgvCell.Value = Resourcestatus
        '        dgvRow.Cells.Add(dgvCell)



        '        dgvCell = New DataGridViewTextBoxCell()
        '        dgvCell.Value = CheckoutPeriod
        '        dgvRow.Cells.Add(dgvCell)

        '        dgvCell = New DataGridViewTextBoxCell()
        '        dgvCell.Value = resourceid
        '        dgvRow.Cells.Add(dgvCell)


        '        DGVResults.Rows.Add(dgvRow)
        '        'Results is the name of the DataGridView Control added to the Form

        '    Next

        'ElseIf NumberOfRows = 0 Then
        '    MessageBox.Show("You have no items checked at this time")
        'End If


    End Sub

    Private Sub CheckoutBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CheckoutBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database6DataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.Database6DataSet.LibraryResources)
        'TODO: This line of code loads data into the 'Database6DataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.Database6DataSet.Checkout)

    End Sub

    Private Sub FillByEmailToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByEmailToolStripButton.Click
        Try
            Me.LibraryMembersTableAdapter.FillByEmail(Me.Database6DataSet.LibraryMembers, EmailToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'RENEW BUTTON BELOW
    
    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click

        'declarations
        Dim NumberOfRows As Integer = 0
        Dim currentdate As Date = Date.Today.Date
        Dim MemberIDTest As String = frmLOGIN.memberIDGlobal
        'Dim Results As String
        NumberOfRows = CheckoutTableAdapter.FillByMemberCheckOut(Database6DataSet.Checkout, MemberIDTest)

        If NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        Else

            If DGVResults.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select the book you wish to renew")
            ElseIf DGVResults.SelectedRows(0).Cells(6).Value = Nothing Then
                MessageBox.Show("No book has been selected")
            Else

                'renew book by altering the due date and updating the record selected in ‘the “results” data grid the numbers in parentheses are the index of the ‘data grid column holding the piece of information needed.
                resourceid = DGVResults.SelectedRows(0).Cells(6).Value

                CheckoutTableAdapter.RenewBookUpdateQuery(currentdate, resourceid)

                'CheckoutPeriod = Results.SelectedCells(6).Value
                CheckoutPeriod = DGVResults.SelectedRows(0).Cells(5).Value
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, currentdate)
                Resourcestatus = DueDate.Date
                DGVResults.SelectedRows(0).Cells(4).Value = Resourcestatus
                'DGVResults.SelectedRows(0).Cells(5).Value = currentdate

                MessageBox.Show("you have successfully renewed your book.", " Book Renewal Successful", MessageBoxButtons.OK)
                RefreshTable()
            End If
        End If
    End Sub





    'RETURN BUTTON BELOW

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        Dim NumberOfRows As Integer = 0
        Dim ResourceID As String
        Dim CurrentDate As Date
        Dim MemberID As String = frmLOGIN.memberIDGlobal



        '' Store date into Current Date
        CurrentDate = Date.Now


        '' Check to see what books are checked out


        NumberOfRows = CheckoutTableAdapter.FillByMemberCheckOut(Database6DataSet.Checkout, MemberID)


        If NumberOfRows = 0 Then
            MessageBox.Show("No books")

        Else
            If DGVResults.SelectedCells.Count = 0 Then
                MessageBox.Show("Please select book to return")
            Else
                If DGVResults.SelectedRows(0).Cells(6).Value = Nothing Then
                    MessageBox.Show("No book has been selected")
                Else
                    ResourceID = DGVResults.SelectedCells(6).Value.ToString


                    CheckoutTableAdapter.ReturnBookUpdateQuery(CurrentDate, ResourceID)
                    DGVResults.SelectedCells(5).Value = "Returned"

                    MessageBox.Show("Return Successful")
                    RefreshTable()
                End If

            End If
        End If




        ''TO AUTOMATICALLY UPDATE CHECK OUT LIST  
        'DGVResults.Rows.Clear()
        ''determine the number of books the current member has checked out.
        'MemberID = frmLOGIN.memberIDGlobal

        'NumberOfRows = CheckoutTableAdapter.FillByMemberCheckOut(Database6DataSet.Checkout, MemberID)

        'If NumberOfRows > 0 Then

        '    Dim x As Integer = 0
        '    'begin a loop that will add information for each of the currently checked out books one at a time to DataGridView
        '    '         
        '    For x = 0 To NumberOfRows - 1 Step 1

        '        bookinfo = CheckoutTableAdapter.GetDataByMemberCheckOut(MemberID)

        '        'ResourceID = bookinfo.resourceID   'de-commented this 

        '        RowData = LibraryResourcesTableAdapter.GetDataByResourceID(ResourceID)(0)
        '        'calculate the due date for a book based on the check out date and the book’s checkout period.



        '    Next

        'End If
        ''            Next
        ''        ElseIf NumberOfRows = 0 Then
        ''            MessageBox.Show("You have no items checked out at this time.")

        ''        End If


        ''    End If
        ''End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'log out link
        Me.Hide()
        frmLOGIN.Show()
        frmLOGIN.txtEmail.Focus()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'button brings us to search form
        Me.Hide()
        frmSearch.Show()



    End Sub
End Class

















'                checkoutdate = bookinfo.checkoutdate
'                CheckoutPeriod = RowData.checkoutperiod
'                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, checkoutdate)
'                'at “due” to the due date so that the member knows when the book is due
'                Resourcestatus = "Due " & DueDate.Date

'                'add information for the checked out resource to the DataGridView
'                Dim dgvRow As New DataGridViewRow
'                Dim dgvCell As DataGridViewCell

'                'add title to the first column of the DataGridView
'                dgvCell = New DataGridViewTextBoxCell()
'                dgvCell.Value = RowData.title
'                dgvRow.Cells.Add(dgvCell)

'                'add author’s last name to the 2nd column of the DataGridView
'                dgvCell = New DataGridViewTextBoxCell()
'                dgvCell.Value = RowData.authorlast
'                dgvRow.Cells.Add(dgvCell)

'                'add publication date to the 3rd  column of the DataGridView
'                dgvCell = New DataGridViewTextBoxCell()
'                dgvCell.Value = RowData.publicationdate
'                dgvRow.Cells.Add(dgvCell)

'                'add series to the 4th column of the DataGridView
'                dgvCell = New DataGridViewTextBoxCell()
'                dgvCell.Value = RowData.Series
'                dgvRow.Cells.Add(dgvCell)

'                'add checkout data to the 5th column of the DataGridView
'                dgvCell = New DataGridViewTextBoxCell()
'                dgvCell.Value = checkoutdate.Date
'                dgvRow.Cells.Add(dgvCell)

'                'add resourcestatus, created above, to the 6th column of the DataGridView
'                dgvCell = New DataGridViewTextBoxCell()
'                dgvCell.Value = Resourcestatus
'                dgvRow.Cells.Add(dgvCell)

'                'add checkout period to the 7th column of the DataGridView
'                dgvCell = New DataGridViewTextBoxCell()
'                dgvCell.Value = RowData.CheckOutPeriod
'                dgvRow.Cells.Add(dgvCell)

'                ' add resource id to column of the DataGrid View 
'                dgvCell = New DataGridViewTextBoxCell()
'                dgvCell.Value = ResourceID
'                dgvRow.Cells.Add(dgvCell)


'                Results.Rows.Add(dgvRow)
'                'Results is the name of the DataGridView Control added to the Form