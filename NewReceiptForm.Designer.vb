<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewReceiptForm
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
        lstCafeItems = New ListView()
        SelectedCafeItems = New ListView()
        Label1 = New Label()
        Label2 = New Label()
        btnAddItem = New Button()
        lblTotal = New Label()
        CreateNewReceiptButton = New Button()
        SuspendLayout()
        ' 
        ' lstCafeItems
        ' 
        lstCafeItems.Location = New Point(84, 66)
        lstCafeItems.Name = "lstCafeItems"
        lstCafeItems.Size = New Size(255, 134)
        lstCafeItems.TabIndex = 0
        lstCafeItems.UseCompatibleStateImageBehavior = False
        ' 
        ' SelectedCafeItems
        ' 
        SelectedCafeItems.Location = New Point(484, 66)
        SelectedCafeItems.Name = "SelectedCafeItems"
        SelectedCafeItems.Size = New Size(228, 134)
        SelectedCafeItems.TabIndex = 1
        SelectedCafeItems.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(164, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 2
        Label1.Text = "Ponuda pića"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(556, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 3
        Label2.Text = "Odabrana pića"
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Location = New Point(177, 229)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(75, 23)
        btnAddItem.TabIndex = 5
        btnAddItem.Text = "Dodaj piće"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(565, 237)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(0, 15)
        lblTotal.TabIndex = 6
        ' 
        ' CreateNewReceiptButton
        ' 
        CreateNewReceiptButton.Location = New Point(565, 340)
        CreateNewReceiptButton.Name = "CreateNewReceiptButton"
        CreateNewReceiptButton.Size = New Size(84, 23)
        CreateNewReceiptButton.TabIndex = 7
        CreateNewReceiptButton.Text = "Stvori račun"
        CreateNewReceiptButton.UseVisualStyleBackColor = True
        ' 
        ' NewReceiptForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CreateNewReceiptButton)
        Controls.Add(lblTotal)
        Controls.Add(btnAddItem)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SelectedCafeItems)
        Controls.Add(lstCafeItems)
        Name = "NewReceiptForm"
        Text = "Novi račun"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstCafeItems As ListView
    Friend WithEvents SelectedCafeItems As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents CreateNewReceiptButton As Button
End Class
