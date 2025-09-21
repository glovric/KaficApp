Public Class AddNewCafeItemForm

    Private Sub btnAddCafeItem_Click(sender As Object, e As EventArgs) Handles AddNewCafeItemButton.Click
        ' Get the name and price from the textboxes
        Dim itemName As String = NewCafeItemName.Text.Trim()
        Dim itemPrice As String = NewCafeItemPrice.Text.Trim()

        ' Validation for name
        If String.IsNullOrEmpty(itemName) Then
            MessageBox.Show("Unesite ispravno ime.")
            Return
        End If

        ' Validation for price (should be a valid decimal)
        Dim price As Decimal
        If Not Decimal.TryParse(itemPrice, price) Then
            MessageBox.Show("Unesite ispravnu cijenu.")
            Return
        End If

        ' Create the new CafeItem
        Dim newItem As New CafeItem With {
            .Name = itemName,
            .Price = price
        }

        ' Add the new item to the global collection (CafeItems)
        GlobalData.CafeItems.Add(newItem)

        ' Optionally, you can clear the textboxes after adding the item
        NewCafeItemPrice.ResetText()
        NewCafeItemName.Clear()

        ' Optionally, update any UI (like ListView or DataGridView) with the new item
        MessageBox.Show("Novo piće dodano!")
    End Sub

End Class