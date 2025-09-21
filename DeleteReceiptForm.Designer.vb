<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteReceiptForm
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
        flpReceipts = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' flpReceipts
        ' 
        flpReceipts.Location = New Point(53, 33)
        flpReceipts.Name = "flpReceipts"
        flpReceipts.Size = New Size(685, 383)
        flpReceipts.TabIndex = 1
        flpReceipts.AutoScroll = True  ' Enables scrolling
        flpReceipts.WrapContents = False  ' Prevents content from wrapping; keeps it horizontal
        flpReceipts.FlowDirection = FlowDirection.TopDown ' Makes sure the receipts are stacked vertically
        ' 
        ' DeleteReceiptForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(flpReceipts)
        Name = "DeleteReceiptForm"
        Text = "DeleteReceiptForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents flpReceipts As FlowLayoutPanel
End Class
