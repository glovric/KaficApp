<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        NewReceiptButton = New Button()
        CloseReceiptButton = New Button()
        AddItemButton = New Button()
        DeleteItemButton = New Button()
        SuspendLayout()
        ' 
        ' NewReceiptButton
        ' 
        NewReceiptButton.Location = New Point(328, 122)
        NewReceiptButton.Name = "NewReceiptButton"
        NewReceiptButton.Size = New Size(118, 23)
        NewReceiptButton.TabIndex = 0
        NewReceiptButton.Text = "Novi račun"
        NewReceiptButton.UseVisualStyleBackColor = True
        ' 
        ' CloseReceiptButton
        ' 
        CloseReceiptButton.Location = New Point(328, 184)
        CloseReceiptButton.Name = "CloseReceiptButton"
        CloseReceiptButton.Size = New Size(118, 23)
        CloseReceiptButton.TabIndex = 1
        CloseReceiptButton.Text = "Zatvori račun"
        CloseReceiptButton.UseVisualStyleBackColor = True
        ' 
        ' AddItemButton
        ' 
        AddItemButton.Location = New Point(328, 244)
        AddItemButton.Name = "AddItemButton"
        AddItemButton.Size = New Size(119, 23)
        AddItemButton.TabIndex = 2
        AddItemButton.Text = "Unesi novo piće"
        AddItemButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteItemButton
        ' 
        DeleteItemButton.Location = New Point(328, 306)
        DeleteItemButton.Name = "DeleteItemButton"
        DeleteItemButton.Size = New Size(119, 23)
        DeleteItemButton.TabIndex = 3
        DeleteItemButton.Text = "Izbriši piće"
        DeleteItemButton.UseVisualStyleBackColor = True
        ' 
        ' ReceiptsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DeleteItemButton)
        Controls.Add(AddItemButton)
        Controls.Add(CloseReceiptButton)
        Controls.Add(NewReceiptButton)
        Name = "ReceiptsForm"
        Text = "Kafic aplikacija"
        ResumeLayout(False)
    End Sub

    Friend WithEvents NewReceiptButton As Button
    Friend WithEvents CloseReceiptButton As Button
    Friend WithEvents AddItemButton As Button
    Friend WithEvents DeleteItemButton As Button
End Class
