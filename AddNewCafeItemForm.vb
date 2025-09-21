Public Class AddNewCafeItemForm

    Private Sub btnAddCafeItem_Click(sender As Object, e As EventArgs) Handles AddNewCafeItemButton.Click

        Dim itemName As String = NewCafeItemName.Text.Trim()
        Dim itemPrice As String = NewCafeItemPrice.Text.Trim()

        If String.IsNullOrEmpty(itemName) Then
            MessageBox.Show("Unesite ispravno ime.")
            Return
        End If

        Dim price As Decimal
        If Not Decimal.TryParse(itemPrice, price) Then
            MessageBox.Show("Unesite ispravnu cijenu.")
            Return
        End If

        Dim newItem As New CafeItem With {
            .Name = itemName,
            .Price = price
        }

        GlobalData.CafeItems.Add(newItem)

        NewCafeItemPrice.ResetText()
        NewCafeItemName.Clear()

        MessageBox.Show("Novo piće dodano!")
    End Sub

End Class