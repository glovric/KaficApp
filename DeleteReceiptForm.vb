Public Class DeleteReceiptForm
    ' Declare FlowLayoutPanel for receipts display

    Public Sub New()
        ' Initialize components (this will set up the FlowLayoutPanel)
        InitializeComponent()

        ' Define the Euro-based culture for currency formatting
        Dim euroCulture As New Globalization.CultureInfo("de-DE")

        ' Call the method to display receipts
        DisplayReceipts()
    End Sub

    ' Method to display receipts in the FlowLayoutPanel
    Public Sub DisplayReceipts()
        ' Clear the existing FlowLayoutPanel first
        flpReceipts.Controls.Clear()
        flpReceipts.AutoScroll = True

        ' Define the Euro-based culture (you can use any Euro-based culture here)
        Dim euroCulture As New Globalization.CultureInfo("de-DE")

        ' Loop through each receipt in GlobalData.Receipts
        For Each receipt As Receipt In GlobalData.Receipts
            ' Create a new GroupBox or Panel to represent the receipt
            Dim receiptGroup As New GroupBox()
            receiptGroup.Text = "Račun"
            receiptGroup.Size = New Size(700, 200)  ' Adjust size as needed
            receiptGroup.Margin = New Padding(10)

            ' Create a FlowLayoutPanel inside the GroupBox to hold the receipt details
            Dim receiptDetails As New FlowLayoutPanel()
            receiptDetails.Dock = DockStyle.Fill
            receiptDetails.FlowDirection = FlowDirection.TopDown
            receiptDetails.WrapContents = False
            receiptDetails.AutoScroll = True
            receiptGroup.Controls.Add(receiptDetails)

            ' Add items to the receiptDetails FlowLayoutPanel
            For Each receiptItem As ReceiptItem In receipt.Items
                ' Create a label for each receipt item
                Dim itemLabel As New Label()
                itemLabel.Text = $"{receiptItem.Item.Name}: {receiptItem.Item.Price.ToString("C", euroCulture)}"
                receiptDetails.Controls.Add(itemLabel)
            Next

            ' Create a FlowLayoutPanel for the Delete button to align it at the bottom-right
            Dim buttonPanel As New FlowLayoutPanel()
            buttonPanel.Dock = DockStyle.Bottom
            buttonPanel.FlowDirection = FlowDirection.RightToLeft  ' This will position the button to the right
            buttonPanel.WrapContents = False
            receiptGroup.Controls.Add(buttonPanel)

            ' Add a delete button for this receipt
            Dim deleteButton As New Button()
            deleteButton.Text = "Ispiši i zatvori račun"
            deleteButton.AutoSize = True  ' Automatically adjusts size based on the text
            deleteButton.Tag = receipt  ' Store the corresponding receipt in the button's Tag
            AddHandler deleteButton.Click, AddressOf DeleteReceiptButton_Click
            buttonPanel.Controls.Add(deleteButton)

            ' Add the GroupBox to the FlowLayoutPanel
            flpReceipts.Controls.Add(receiptGroup)
        Next
    End Sub

    ' Delete receipt when delete button is clicked
    Private Sub DeleteReceiptButton_Click(sender As Object, e As EventArgs)
        ' Get the clicked delete button
        Dim deleteButton As Button = CType(sender, Button)

        ' Get the associated receipt from the Tag property of the button
        Dim receiptToDelete As Receipt = CType(deleteButton.Tag, Receipt)

        ' Remove the receipt from the global state (GlobalData.Receipts)
        GlobalData.Receipts.Remove(receiptToDelete)

        ' Remove the associated GroupBox (receipt) from the FlowLayoutPanel
        flpReceipts.Controls.Remove(deleteButton.Parent)

        ' Optionally, you can refresh the UI by calling DisplayReceipts again
        DisplayReceipts()  ' Re-render the flow layout panel to show the updated receipts list
    End Sub

    ' Initialize the FlowLayoutPanel and form components
End Class