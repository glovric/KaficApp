Public Class DeleteReceiptForm
    Public Sub New()
        InitializeComponent() ' Initializes components (including the FlowLayoutPanel)

        ' Define the Euro-based culture for currency formatting
        Dim euroCulture As New Globalization.CultureInfo("de-DE")

        ' Loop through all receipts stored in GlobalData.Receipts
        For Each receipt As Receipt In GlobalData.Receipts
            ' Create a GroupBox or Panel for each receipt
            Dim receiptGroup As New GroupBox()
            receiptGroup.Text = "Receipt Total: " & receipt.Total.ToString("C", euroCulture)
            receiptGroup.AutoSize = True
            receiptGroup.Padding = New Padding(10)

            ' Inside the GroupBox, use a ListView or another control to show items
            Dim receiptItemListView As New ListView()
            receiptItemListView.View = View.Details
            receiptItemListView.Columns.Add("Item Name", 150)
            receiptItemListView.Columns.Add("Price", 80)
            receiptItemListView.Columns.Add("Quantity", 80)
            receiptItemListView.Columns.Add("Line Total", 100)
            receiptItemListView.Width = 500 ' Adjust as needed
            receiptItemListView.Height = 200 ' Adjust as needed

            ' Loop through the items in the receipt and add them to the ListView
            For Each receiptItem As ReceiptItem In receipt.Items
                Dim listItem As New ListViewItem(receiptItem.Item.Name)
                listItem.SubItems.Add(receiptItem.Item.Price.ToString("C", euroCulture)) ' Price in €
                listItem.SubItems.Add(receiptItem.Quantity.ToString()) ' Quantity
                listItem.SubItems.Add(receiptItem.LineTotal.ToString("C", euroCulture)) ' Line total in €
                receiptItemListView.Items.Add(listItem)
            Next

            ' Add the ListView to the GroupBox
            receiptGroup.Controls.Add(receiptItemListView)

            ' Add the GroupBox (which contains the ListView) to the FlowLayoutPanel
            flpReceipts.Controls.Add(receiptGroup)
        Next
    End Sub

End Class