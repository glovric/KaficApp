Public Class MainForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles MainLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If username.Text = "admin" AndAlso password.Text = "admin" Then
            Me.Hide()
            Dim receiptForm As New ReceiptsForm()
            receiptForm.ShowDialog()

            Me.Close()
        Else
            MessageBox.Show("Pogrešno korisničko ime ili lozinka.")
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
