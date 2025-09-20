Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class ReceiptsForm

    Private Sub NewReceiptButton_Click(sender As Object, e As EventArgs) Handles NewReceiptButton.Click
        Dim receiptForm As New NewReceiptForm()
        receiptForm.ShowDialog() ' This opens it as a modal popup
    End Sub

End Class