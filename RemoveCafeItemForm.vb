Public Class RemoveCafeItemForm
    Private Sub NewReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstDeleteCafeItems.View = View.Details
        lstDeleteCafeItems.Columns.Add("Item", 120)
        lstDeleteCafeItems.Columns.Add("Price", 60)
        lstDeleteCafeItems.FullRowSelect = True


        Dim euroCulture As New Globalization.CultureInfo("de-DE")

        For Each item In GlobalData.CafeItems
            Dim listItem As New ListViewItem(item.Name)
            listItem.SubItems.Add(item.Price.ToString("C", euroCulture))
            listItem.Tag = item
            lstDeleteCafeItems.Items.Add(listItem)
        Next

    End Sub

    Private Sub DeleteCafeItem_Click(sender As Object, e As EventArgs) Handles DeleteItemButton.Click
        If lstDeleteCafeItems.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a cafe item to add to the receipt.")
            Return
        End If

        Dim selectedItem As CafeItem = CType(lstDeleteCafeItems.SelectedItems(0).Tag, CafeItem)

        Dim itemToRemove As CafeItem = GlobalData.CafeItems.Find(Function(item) item.Name.Equals(selectedItem.Name, StringComparison.OrdinalIgnoreCase))

        If itemToRemove IsNot Nothing Then
            CafeItems.Remove(itemToRemove)
            ReRenderCafeItemsList()
            MessageBox.Show(selectedItem.Name & " izbrisan.")
        Else
            MessageBox.Show("Ne postoji " & selectedItem.Name)
        End If
    End Sub

    Private Sub ReRenderCafeItemsList()
        lstDeleteCafeItems.Items.Clear()

        For Each item As CafeItem In GlobalData.CafeItems
            Dim listItem As New ListViewItem(item.Name)
            listItem.SubItems.Add(item.Price.ToString("C"))
            listItem.Tag = item
            lstDeleteCafeItems.Items.Add(listItem)
        Next
    End Sub

End Class