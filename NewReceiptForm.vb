Public Class NewReceiptForm
    Private Sub NewReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure the available items ListView (lstCafeItems)
        lstCafeItems.View = View.Details
        lstCafeItems.Columns.Add("Item", 120)
        lstCafeItems.Columns.Add("Price", 60)
        lstCafeItems.FullRowSelect = True

        ' Add cafe items to the available items ListView
        Dim items As New List(Of CafeItem) From {
            New CafeItem With {.Name = "Espresso", .Price = 2.5D},
            New CafeItem With {.Name = "Latte", .Price = 3D},
            New CafeItem With {.Name = "Croissant", .Price = 2D},
            New CafeItem With {.Name = "Tea", .Price = 1.5D}
        }

        For Each item In items
            Dim listItem As New ListViewItem(item.Name)
            listItem.SubItems.Add(item.Price.ToString("C"))
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

        ' Add the selected item to the new receipt ListView
        Dim listItem As New ListViewItem(selectedItem.Name)
        listItem.SubItems.Add(selectedItem.Price.ToString("C"))
        listItem.SubItems.Add(quantity.ToString())
        listItem.SubItems.Add((selectedItem.Price * quantity).ToString("C"))

        SelectedCafeItems.Items.Add(listItem)

        ' Update the total
        UpdateReceiptTotal()
    End Sub

    Private Sub UpdateReceiptTotal()
        Dim total As Decimal = 0D
        For Each item As ListViewItem In SelectedCafeItems.Items
            total += Decimal.Parse(item.SubItems(3).Text, Globalization.NumberStyles.Currency)
        Next

        lblTotal.Text = "Total: " & total.ToString("C")
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        AddItemToReceipt()
    End Sub
End Class

Public Class CafeItem
    Public Property Name As String
    Public Property Price As Decimal
End Class