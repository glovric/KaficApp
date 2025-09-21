Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class ReceiptsForm

    Private Sub NewReceiptButton_Click(sender As Object, e As EventArgs) Handles NewReceiptButton.Click
        Dim receiptForm As New NewReceiptForm()
        receiptForm.ShowDialog() ' This opens it as a modal popup
    End Sub

    Private Sub CloseReceiptButton_Click(sender As Object, e As EventArgs) Handles CloseReceiptButton.Click
        Debug.WriteLine("---- Global Data: Receipts ----")

        ' Define the Euro-based culture (you can use any Euro-based culture here)
        Dim euroCulture As New Globalization.CultureInfo("de-DE") ' or "en-IE" for Ireland, "fr-FR" for France, etc.

        ' Loop through each receipt in GlobalData.Receipts
        For Each receipt As Receipt In GlobalData.Receipts
            ' Format the total as Euro (€) using the specified Euro-based culture
            Debug.WriteLine("Receipt - Total: " & receipt.Total.ToString("C", euroCulture))

            ' Loop through each receipt item and print its details
            For Each receiptItem As ReceiptItem In receipt.Items
                ' Format the price and line total as Euro (€) using the specified Euro-based culture
                Debug.WriteLine("  Item: " & receiptItem.Item.Name & ", Price: " & receiptItem.Item.Price.ToString("C", euroCulture) &
                            ", Quantity: " & receiptItem.Quantity & ", Line Total: " & receiptItem.LineTotal.ToString("C", euroCulture))
            Next

            Debug.WriteLine("---------------------------------")
        Next
    End Sub

End Class