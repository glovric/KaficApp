Public Class NewReceiptForm
    Private Sub NewReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCafeItems.View = View.Details
        lstCafeItems.Columns.Add("Item", 120)
        lstCafeItems.Columns.Add("Price", 60)
        lstCafeItems.FullRowSelect = True

        Dim euroCulture As New Globalization.CultureInfo("de-DE")

        For Each item In GlobalData.CafeItems
            Dim listItem As New ListViewItem(item.Name)
            listItem.SubItems.Add(item.Price.ToString("C", euroCulture))
            listItem.Tag = item
            lstCafeItems.Items.Add(listItem)
        Next

        SetupReceiptListView()
    End Sub

    Private Sub SetupReceiptListView()
        SelectedCafeItems.View = View.Details
        SelectedCafeItems.Columns.Add("Item", 120)
        SelectedCafeItems.Columns.Add("Price", 60)
        SelectedCafeItems.Columns.Add("Quantity", 60)
        SelectedCafeItems.Columns.Add("Total", 80)
        SelectedCafeItems.FullRowSelect = True
    End Sub

    Private Sub AddItemToReceipt()
        If lstCafeItems.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a cafe item to add to the receipt.")
            Return
        End If

        Dim selectedItem As CafeItem = CType(lstCafeItems.SelectedItems(0).Tag, CafeItem)

        Dim quantity As Integer = 1

        Dim price As Decimal = selectedItem.Price

        Dim listItem As New ListViewItem(selectedItem.Name)
        listItem.SubItems.Add(price.ToString("C", Globalization.CultureInfo.GetCultureInfo("de-DE")))
        listItem.SubItems.Add(quantity.ToString())
        listItem.SubItems.Add((price * quantity).ToString("C", Globalization.CultureInfo.GetCultureInfo("de-DE")))

        SelectedCafeItems.Items.Add(listItem)

        UpdateReceiptTotal()
    End Sub

    Private Sub UpdateReceiptTotal()
        Dim total As Decimal = 0D
        Dim euroCulture As New Globalization.CultureInfo("de-DE")

        For Each item As ListViewItem In SelectedCafeItems.Items
            Dim priceString As String = item.SubItems(3).Text.Replace(" €", "").Replace(" ", "").Trim()

            Dim lineTotal As Decimal = Decimal.Parse(priceString, Globalization.NumberStyles.Number, euroCulture)
            total += lineTotal
        Next

        lblTotal.Text = "Total: " & total.ToString("C", euroCulture)
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        AddItemToReceipt()
    End Sub

    Private Sub SaveItemsToGlobalState()

        If SelectedCafeItems.Items.Count = 0 Then
            MessageBox.Show("No items selected. Please add items to the receipt before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim newReceipt As New Receipt()

        For Each listItem As ListViewItem In SelectedCafeItems.Items

            Debug.WriteLine(listItem.SubItems(0).Text)
            Debug.WriteLine(listItem.SubItems(1).Text)
            Debug.WriteLine(listItem.SubItems(2).Text)

            Dim priceString As String = listItem.SubItems(1).Text.Replace(" €", "").Trim()
            priceString = priceString.Replace(",", ".")
            Dim price As Decimal = Decimal.Parse(priceString, Globalization.CultureInfo.InvariantCulture)

            Debug.WriteLine("Pri saveanju dobivam " & price & priceString)

            Dim receiptItem As New ReceiptItem With {
                .Item = New CafeItem With {
                    .Name = listItem.SubItems(0).Text,
                    .Price = price
                },
                .Quantity = Integer.Parse(listItem.SubItems(2).Text)
            }

            newReceipt.Items.Add(receiptItem)
        Next

        newReceipt.Total = newReceipt.Items.Sum(Function(r) r.LineTotal)

        GlobalData.Receipts.Add(newReceipt)

        MessageBox.Show("Račun stvoren.")

        SelectedCafeItems.Items.Clear()
        lblTotal.Text = ""
    End Sub

    Private Sub btnSaveReceipt_Click(sender As Object, e As EventArgs) Handles CreateNewReceiptButton.Click
        SaveItemsToGlobalState()
    End Sub

End Class