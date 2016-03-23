Public Class frmSearch

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'log out link
        Me.Hide()
        frmLOGIN.Show()
        frmLOGIN.txtEmail.Focus()

    End Sub
End Class