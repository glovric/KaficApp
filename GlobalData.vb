Module GlobalData
    Public Receipts As New List(Of Receipt)
End Module

Public Class Receipt
    Public Property Items As List(Of ReceiptItem)
    Public Property Total As Decimal
    Public Property Timestamp As DateTime
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