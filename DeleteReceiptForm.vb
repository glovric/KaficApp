Public Class DeleteReceiptForm

    Public Sub New()
        InitializeComponent()
        Dim euroCulture As New Globalization.CultureInfo("de-DE")
        DisplayReceipts()
    End Sub

    Public Sub DisplayReceipts()
        flpReceipts.Controls.Clear()
        flpReceipts.AutoScroll = True

        Dim euroCulture As New Globalization.CultureInfo("de-DE")

        For Each receipt As Receipt In GlobalData.Receipts
            Dim receiptGroup As New GroupBox()
            receiptGroup.Text = "Račun"
            receiptGroup.Size = New Size(700, 200)
            receiptGroup.Margin = New Padding(10)

            Dim receiptDetails As New FlowLayoutPanel()
            receiptDetails.Dock = DockStyle.Fill
            receiptDetails.FlowDirection = FlowDirection.TopDown
            receiptDetails.WrapContents = False
            receiptDetails.AutoScroll = True
            receiptGroup.Controls.Add(receiptDetails)

            For Each receiptItem As ReceiptItem In receipt.Items
                Dim itemLabel As New Label()
                itemLabel.Text = $"{receiptItem.Item.Name}: {receiptItem.Item.Price.ToString("C", euroCulture)}"
                receiptDetails.Controls.Add(itemLabel)
            Next

            Dim buttonPanel As New FlowLayoutPanel()
            buttonPanel.Dock = DockStyle.Bottom
            buttonPanel.FlowDirection = FlowDirection.RightToLeft
            buttonPanel.WrapContents = False
            receiptGroup.Controls.Add(buttonPanel)

            Dim deleteButton As New Button()
            deleteButton.Text = "Ispiši i zatvori račun"
            deleteButton.AutoSize = True
            deleteButton.Tag = receipt
            AddHandler deleteButton.Click, AddressOf DeleteReceiptButton_Click
            buttonPanel.Controls.Add(deleteButton)

            flpReceipts.Controls.Add(receiptGroup)
        Next
    End Sub

    Private Sub DeleteReceiptButton_Click(sender As Object, e As EventArgs)
        Dim deleteButton As Button = CType(sender, Button)

        Dim receiptToDelete As Receipt = CType(deleteButton.Tag, Receipt)

        GlobalData.Receipts.Remove(receiptToDelete)

        flpReceipts.Controls.Remove(deleteButton.Parent)

        DisplayReceipts()
    End Sub

End Class