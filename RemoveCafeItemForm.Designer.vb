<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveCafeItemForm
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
        lstDeleteCafeItems = New ListView()
        Label1 = New Label()
        DeleteItemButton = New Button()
        SuspendLayout()
        ' 
        ' lstDeleteCafeItems
        ' 
        lstDeleteCafeItems.Location = New Point(238, 116)
        lstDeleteCafeItems.Name = "lstDeleteCafeItems"
        lstDeleteCafeItems.Size = New Size(277, 143)
        lstDeleteCafeItems.TabIndex = 0
        lstDeleteCafeItems.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(299, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 15)
        Label1.TabIndex = 1
        Label1.Text = "Odaberite stavku za izbrisati"
        ' 
        ' DeleteItemButton
        ' 
        DeleteItemButton.Location = New Point(340, 310)
        DeleteItemButton.Name = "DeleteItemButton"
        DeleteItemButton.Size = New Size(75, 23)
        DeleteItemButton.TabIndex = 2
        DeleteItemButton.Text = "Izbriši stavku"
        DeleteItemButton.UseVisualStyleBackColor = True
        ' 
        ' RemoveCafeItemForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DeleteItemButton)
        Controls.Add(Label1)
        Controls.Add(lstDeleteCafeItems)
        Name = "RemoveCafeItemForm"
        Text = "Izbriši stavku"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstDeleteCafeItems As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteItemButton As Button
End Class
