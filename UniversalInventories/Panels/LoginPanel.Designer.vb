<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.usernameTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.passwordLabel = New MetroFramework.Controls.MetroLabel()
        Me.passwordTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.usernameLabel = New MetroFramework.Controls.MetroLabel()
        Me.loginButton = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'usernameTextbox
        '
        Me.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.usernameTextbox.CustomButton.Image = Nothing
        Me.usernameTextbox.CustomButton.Location = New System.Drawing.Point(188, 1)
        Me.usernameTextbox.CustomButton.Name = ""
        Me.usernameTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.usernameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.usernameTextbox.CustomButton.TabIndex = 1
        Me.usernameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.usernameTextbox.CustomButton.UseSelectable = True
        Me.usernameTextbox.CustomButton.Visible = False
        Me.usernameTextbox.Lines = New String(-1) {}
        Me.usernameTextbox.Location = New System.Drawing.Point(131, 66)
        Me.usernameTextbox.MaxLength = 32767
        Me.usernameTextbox.Name = "usernameTextbox"
        Me.usernameTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.usernameTextbox.SelectedText = ""
        Me.usernameTextbox.SelectionLength = 0
        Me.usernameTextbox.SelectionStart = 0
        Me.usernameTextbox.ShortcutsEnabled = True
        Me.usernameTextbox.Size = New System.Drawing.Size(210, 23)
        Me.usernameTextbox.TabIndex = 0
        Me.usernameTextbox.UseSelectable = True
        Me.usernameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.usernameTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'passwordLabel
        '
        Me.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(197, 138)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(63, 19)
        Me.passwordLabel.TabIndex = 2
        Me.passwordLabel.Text = "Password"
        '
        'passwordTextbox
        '
        Me.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.passwordTextbox.CustomButton.Image = Nothing
        Me.passwordTextbox.CustomButton.Location = New System.Drawing.Point(188, 1)
        Me.passwordTextbox.CustomButton.Name = ""
        Me.passwordTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.passwordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.passwordTextbox.CustomButton.TabIndex = 1
        Me.passwordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.passwordTextbox.CustomButton.UseSelectable = True
        Me.passwordTextbox.CustomButton.Visible = False
        Me.passwordTextbox.Lines = New String(-1) {}
        Me.passwordTextbox.Location = New System.Drawing.Point(131, 169)
        Me.passwordTextbox.MaxLength = 32767
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.passwordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.passwordTextbox.SelectedText = ""
        Me.passwordTextbox.SelectionLength = 0
        Me.passwordTextbox.SelectionStart = 0
        Me.passwordTextbox.ShortcutsEnabled = True
        Me.passwordTextbox.Size = New System.Drawing.Size(210, 23)
        Me.passwordTextbox.TabIndex = 3
        Me.passwordTextbox.UseSelectable = True
        Me.passwordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.passwordTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'usernameLabel
        '
        Me.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(192, 31)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(68, 19)
        Me.usernameLabel.TabIndex = 1
        Me.usernameLabel.Text = "Username"
        '
        'loginButton
        '
        Me.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginButton.Location = New System.Drawing.Point(185, 234)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(87, 23)
        Me.loginButton.TabIndex = 4
        Me.loginButton.Text = "Login"
        Me.loginButton.UseSelectable = True
        '
        'LoginPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.passwordTextbox)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.usernameTextbox)
        Me.Name = "LoginPanel"
        Me.Size = New System.Drawing.Size(467, 388)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernameTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents passwordLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents passwordTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents usernameLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents loginButton As MetroFramework.Controls.MetroButton
End Class
