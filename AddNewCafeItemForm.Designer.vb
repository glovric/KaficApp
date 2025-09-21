<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewCafeItemForm
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
        NewCafeItemName = New TextBox()
        NewCafeItemPrice = New NumericUpDown()
        NewCafeItemNameLabel = New Label()
        Label2 = New Label()
        AddNewCafeItemButton = New Button()
        CType(NewCafeItemPrice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NewCafeItemName
        ' 
        NewCafeItemName.Location = New Point(185, 220)
        NewCafeItemName.Name = "NewCafeItemName"
        NewCafeItemName.Size = New Size(100, 23)
        NewCafeItemName.TabIndex = 0
        ' 
        ' NewCafeItemPrice
        ' 
        NewCafeItemPrice.Location = New Point(465, 221)
        NewCafeItemPrice.Name = "NewCafeItemPrice"
        NewCafeItemPrice.Size = New Size(120, 23)
        NewCafeItemPrice.TabIndex = 1
        ' 
        ' NewCafeItemNameLabel
        ' 
        NewCafeItemNameLabel.AutoSize = True
        NewCafeItemNameLabel.Location = New Point(187, 182)
        NewCafeItemNameLabel.Name = "NewCafeItemNameLabel"
        NewCafeItemNameLabel.Size = New Size(98, 15)
        NewCafeItemNameLabel.TabIndex = 2
        NewCafeItemNameLabel.Text = "Naziv novog pića"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(474, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 15)
        Label2.TabIndex = 3
        Label2.Text = "Cijena novog pića"
        ' 
        ' AddNewCafeItemButton
        ' 
        AddNewCafeItemButton.Location = New Point(324, 311)
        AddNewCafeItemButton.Name = "AddNewCafeItemButton"
        AddNewCafeItemButton.Size = New Size(115, 23)
        AddNewCafeItemButton.TabIndex = 4
        AddNewCafeItemButton.Text = "Dodaj novo piće"
        AddNewCafeItemButton.UseVisualStyleBackColor = True
        ' 
        ' AddNewCafeItemForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(AddNewCafeItemButton)
        Controls.Add(Label2)
        Controls.Add(NewCafeItemNameLabel)
        Controls.Add(NewCafeItemPrice)
        Controls.Add(NewCafeItemName)
        Name = "AddNewCafeItemForm"
        Text = "AddNewCafeItemForm"
        CType(NewCafeItemPrice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NewCafeItemName As TextBox
    Friend WithEvents NewCafeItemPrice As NumericUpDown
    Friend WithEvents NewCafeItemNameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddNewCafeItemButton As Button
End Class
