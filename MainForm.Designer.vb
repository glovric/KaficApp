<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MainLabel = New Label()
        LoginButton = New Button()
        username = New TextBox()
        UsernameLabel = New Label()
        password = New TextBox()
        PasswordLabel = New Label()
        SuspendLayout()
        ' 
        ' MainLabel
        ' 
        MainLabel.AutoSize = True
        MainLabel.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainLabel.Location = New Point(292, 54)
        MainLabel.Name = "MainLabel"
        MainLabel.Size = New Size(192, 37)
        MainLabel.TabIndex = 0
        MainLabel.Text = "Kafic aplikacija"
        ' 
        ' LoginButton
        ' 
        LoginButton.Location = New Point(353, 333)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(75, 23)
        LoginButton.TabIndex = 5
        LoginButton.Text = "Prijavi se"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' username
        ' 
        username.Location = New Point(343, 180)
        username.Name = "username"
        username.Size = New Size(100, 23)
        username.TabIndex = 2
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New Point(343, 133)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(85, 15)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "Korisničko ime"
        ' 
        ' password
        ' 
        password.Location = New Point(343, 275)
        password.Name = "password"
        password.Size = New Size(100, 23)
        password.TabIndex = 4
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New Point(362, 226)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(47, 15)
        PasswordLabel.TabIndex = 3
        PasswordLabel.Text = "Lozinka"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(797, 450)
        Controls.Add(password)
        Controls.Add(PasswordLabel)
        Controls.Add(LoginButton)
        Controls.Add(username)
        Controls.Add(UsernameLabel)
        Controls.Add(MainLabel)
        Name = "MainForm"
        Text = "Kafic aplikacija"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MainLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents username As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents password As TextBox
    Friend WithEvents PasswordLabel As Label

End Class
