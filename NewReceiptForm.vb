Public Class NewReceiptForm
    Private Sub NewReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure the available items ListView (lstCafeItems)
        lstCafeItems.View = View.Details
        lstCafeItems.Columns.Add("Item", 120)
        lstCafeItems.Columns.Add("Price", 60)
        lstCafeItems.FullRowSelect = True

        ' Create a culture info for Euro (e.g., German or Irish culture)
        Dim euroCulture As New Globalization.CultureInfo("de-DE") ' or "en-IE", "fr-FR", etc.

        ' Add cafe items to the available items ListView
        Dim items As New List(Of CafeItem) From {
        New CafeItem With {.Name = "Espresso", .Price = 2.5D},
        New CafeItem With {.Name = "Latte", .Price = 3D},
        New CafeItem With {.Name = "Croissant", .Price = 2D},
        New CafeItem With {.Name = "Tea", .Price = 1.5D}
    }

        For Each item In items
            ' Format the price to Euro currency
            Dim listItem As New ListViewItem(item.Name)
            listItem.SubItems.Add(item.Price.ToString("C", euroCulture)) ' Format price in Euro
            listItem.Tag = item ' Store object for later use
            lstCafeItems.Items.Add(listItem)
        Next

        ' Set up the receipt ListView (lstReceiptItems)
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

        ' Get the selected item from the available items ListView
        Dim selectedItem As CafeItem = CType(lstCafeItems.SelectedItems(0).Tag, CafeItem)

        ' Get quantity from the TextBox (or another input control)
        Dim quantity As Integer = 1

        ' Make sure to store the price as a decimal without multiplying by 100 or using incorrect values
        Dim price As Decimal = selectedItem.Price ' Ensure it's in the correct unit (e.g., €2.00, not €200)

        ' Add the selected item to the new receipt ListView
        Dim listItem As New ListViewItem(selectedItem.Name)
        listItem.SubItems.Add(price.ToString("C", Globalization.CultureInfo.GetCultureInfo("de-DE"))) ' Add price formatted in €
        listItem.SubItems.Add(quantity.ToString())
        listItem.SubItems.Add((price * quantity).ToString("C", Globalization.CultureInfo.GetCultureInfo("de-DE"))) ' Line Total in €

        SelectedCafeItems.Items.Add(listItem)

        ' Update the total
        UpdateReceiptTotal()
    End Sub

    Private Sub UpdateReceiptTotal()
        Dim total As Decimal = 0D
        ' Define the Euro-based culture (e.g., German culture)
        Dim euroCulture As New Globalization.CultureInfo("de-DE") ' or any other Euro-based culture like "en-IE", "fr-FR"

        ' Loop through each item in the receipt ListView to calculate the total
        For Each item As ListViewItem In SelectedCafeItems.Items
            ' Remove the Euro symbol and any spaces before parsing
            Dim priceString As String = item.SubItems(3).Text.Replace(" €", "").Replace(" ", "").Trim()

            ' Parse the LineTotal value as a decimal (taking into account the Euro symbol and possible comma separator)
            Dim lineTotal As Decimal = Decimal.Parse(priceString, Globalization.NumberStyles.Number, euroCulture)
            total += lineTotal
        Next

        ' Display the total in Euro (€)
        lblTotal.Text = "Total: " & total.ToString("C", euroCulture)
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        AddItemToReceipt()
    End Sub

    Private Sub SaveItemsToGlobalState()

        If SelectedCafeItems.Items.Count = 0 Then
            ' Show an error message if no items are selected
            MessageBox.Show("No items selected. Please add items to the receipt before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the function to prevent further execution
        End If

        ' Create a new Receipt object
        Dim newReceipt As New Receipt()

        ' Loop through each item in the SelectedCafeItems ListView
        For Each listItem As ListViewItem In SelectedCafeItems.Items

            Debug.WriteLine(listItem.SubItems(0).Text)
            Debug.WriteLine(listItem.SubItems(1).Text)
            Debug.WriteLine(listItem.SubItems(2).Text)

            Dim priceString As String = listItem.SubItems(1).Text.Replace(" €", "").Trim()
            Dim price As Decimal = Decimal.Parse(priceString, Globalization.CultureInfo.InvariantCulture)

            Dim receiptItem As New ReceiptItem With {
                .Item = New CafeItem With {
                    .Name = listItem.SubItems(0).Text,  ' Name
                    .Price = price  ' Cleaned Price
                },
                .Quantity = Integer.Parse(listItem.SubItems(2).Text)  ' Quantity
            }

            newReceipt.Items.Add(receiptItem)
        Next

        ' Calculate the total for the new receipt
        newReceipt.Total = newReceipt.Items.Sum(Function(r) r.LineTotal)

        ' Add the receipt to the global state
        GlobalData.Receipts.Add(newReceipt)

        ' Optional: Display a confirmation message
        MessageBox.Show("Račun stvoren.")

        ' Reset the receipt ListView
        SelectedCafeItems.Items.Clear()
        lblTotal.Text = ""
    End Sub

    Private Sub btnSaveReceipt_Click(sender As Object, e As EventArgs) Handles CreateNewReceiptButton.Click
        SaveItemsToGlobalState()
    End Sub

End Class