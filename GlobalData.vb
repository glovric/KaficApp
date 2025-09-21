Module GlobalData

    Public Receipts As New List(Of Receipt)

    Public CafeItems As New List(Of CafeItem)

    Public Sub InitializeCafeItems()
        ' You can choose to load items from a file, or just use default items
        If CafeItems.Count = 0 Then  ' Ensure items are only added once
            ' Add initial cafe items to the list
            CafeItems.Add(New CafeItem With {.Name = "Espresso", .Price = 2.5D})
            CafeItems.Add(New CafeItem With {.Name = "Latte", .Price = 3D
            })
            CafeItems.Add(New CafeItem With {.Name = "Croissant", .Price = 2D
            })
            CafeItems.Add(New CafeItem With {.Name = "Tea", .Price = 1.5D})
        End If
    End Sub

End Module

Public Class Receipt
    Public Property Items As List(Of ReceiptItem)
    Public Property Total As Decimal
    Public Sub New()
        Items = New List(Of ReceiptItem)()
    End Sub
End Class

Public Class ReceiptItem
    Public Property Item As CafeItem
    Public Property Quantity As Integer
    Public ReadOnly Property LineTotal As Decimal
        Get
            Return Item.Price * Quantity
        End Get
    End Property
End Class

Public Class CafeItem
    Public Property Name As String
    Public Property Price As Decimal
End Class