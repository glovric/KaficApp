Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class ReceiptsForm

    Private Sub NewReceiptButton_Click(sender As Object, e As EventArgs) Handles NewReceiptButton.Click
        Dim receiptForm As New NewReceiptForm()
        receiptForm.ShowDialog()
    End Sub

    Private Sub CloseReceiptButton_Click(sender As Object, e As EventArgs) Handles CloseReceiptButton.Click
        Dim deleteReceiptForm As New DeleteReceiptForm()
        deleteReceiptForm.ShowDialog()
    End Sub

    Private Sub NewCafeItem_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        Dim newItemForm As New AddNewCafeItemForm()
        newItemForm.ShowDialog()
    End Sub

    Private Sub DeleteCafeItem_Click(sender As Object, e As EventArgs) Handles DeleteItemButton.Click
        Dim deleteItemForm As New RemoveCafeItemForm
        deleteItemForm.ShowDialog()
    End Sub

End Class