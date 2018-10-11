<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.navigationPanel = New System.Windows.Forms.Panel()
        Me.logoutButton = New MetroFramework.Controls.MetroButton()
        Me.exitButton = New MetroFramework.Controls.MetroButton()
        Me.loginButton = New MetroFramework.Controls.MetroButton()
        Me.dashboardButton = New MetroFramework.Controls.MetroButton()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.invLable = New MetroFramework.Controls.MetroLabel()
        Me.undergroundLabel = New MetroFramework.Controls.MetroLabel()
        Me.controlPanel = New System.Windows.Forms.Panel()
        Me.viewStockTile = New MetroFramework.Controls.MetroTile()
        Me.displayPanel = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.userInfoTile = New MetroFramework.Controls.MetroTile()
        Me.navigationPanel.SuspendLayout()
        Me.logoPanel.SuspendLayout()
        Me.controlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(0, 0)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.UseSelectable = True
        '
        'navigationPanel
        '
        Me.navigationPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.navigationPanel.Controls.Add(Me.logoutButton)
        Me.navigationPanel.Controls.Add(Me.exitButton)
        Me.navigationPanel.Controls.Add(Me.loginButton)
        Me.navigationPanel.Controls.Add(Me.dashboardButton)
        Me.navigationPanel.Controls.Add(Me.logoPanel)
        Me.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.navigationPanel.Location = New System.Drawing.Point(0, 0)
        Me.navigationPanel.Name = "navigationPanel"
        Me.navigationPanel.Size = New System.Drawing.Size(200, 590)
        Me.navigationPanel.TabIndex = 1
        '
        'logoutButton
        '
        Me.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logoutButton.Location = New System.Drawing.Point(58, 331)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(75, 33)
        Me.logoutButton.TabIndex = 4
        Me.logoutButton.Text = "Logout"
        Me.logoutButton.UseSelectable = True
        '
        'exitButton
        '
        Me.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.exitButton.Location = New System.Drawing.Point(58, 545)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 33)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseSelectable = True
        '
        'loginButton
        '
        Me.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginButton.Location = New System.Drawing.Point(58, 276)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(75, 34)
        Me.loginButton.TabIndex = 2
        Me.loginButton.Text = "Login"
        Me.loginButton.UseSelectable = True
        '
        'dashboardButton
        '
        Me.dashboardButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dashboardButton.Location = New System.Drawing.Point(58, 221)
        Me.dashboardButton.Name = "dashboardButton"
        Me.dashboardButton.Size = New System.Drawing.Size(75, 33)
        Me.dashboardButton.TabIndex = 1
        Me.dashboardButton.Text = "Dashboard"
        Me.dashboardButton.UseSelectable = True
        '
        'logoPanel
        '
        Me.logoPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.logoPanel.Controls.Add(Me.invLable)
        Me.logoPanel.Controls.Add(Me.undergroundLabel)
        Me.logoPanel.Location = New System.Drawing.Point(3, 3)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(251, 97)
        Me.logoPanel.TabIndex = 0
        '
        'invLable
        '
        Me.invLable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.invLable.AutoSize = True
        Me.invLable.ForeColor = System.Drawing.Color.Gold
        Me.invLable.Location = New System.Drawing.Point(45, 61)
        Me.invLable.Name = "invLable"
        Me.invLable.Size = New System.Drawing.Size(93, 19)
        Me.invLable.TabIndex = 1
        Me.invLable.Text = " INVENTORIES"
        Me.invLable.UseCustomBackColor = True
        Me.invLable.UseCustomForeColor = True
        '
        'undergroundLabel
        '
        Me.undergroundLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.undergroundLabel.AutoSize = True
        Me.undergroundLabel.ForeColor = System.Drawing.Color.Gold
        Me.undergroundLabel.Location = New System.Drawing.Point(45, 33)
        Me.undergroundLabel.Name = "undergroundLabel"
        Me.undergroundLabel.Size = New System.Drawing.Size(108, 19)
        Me.undergroundLabel.TabIndex = 0
        Me.undergroundLabel.Text = "UNDERGROUND"
        Me.undergroundLabel.UseCustomBackColor = True
        Me.undergroundLabel.UseCustomForeColor = True
        '
        'controlPanel
        '
        Me.controlPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.controlPanel.Controls.Add(Me.userInfoTile)
        Me.controlPanel.Controls.Add(Me.MetroLabel1)
        Me.controlPanel.Controls.Add(Me.viewStockTile)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.controlPanel.Location = New System.Drawing.Point(200, 0)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Size = New System.Drawing.Size(923, 100)
        Me.controlPanel.TabIndex = 2
        '
        'viewStockTile
        '
        Me.viewStockTile.ActiveControl = Nothing
        Me.viewStockTile.ForeColor = System.Drawing.Color.Black
        Me.viewStockTile.Location = New System.Drawing.Point(22, 36)
        Me.viewStockTile.Name = "viewStockTile"
        Me.viewStockTile.Size = New System.Drawing.Size(150, 47)
        Me.viewStockTile.TabIndex = 0
        Me.viewStockTile.Text = "Data Viewer"
        Me.viewStockTile.UseCustomBackColor = True
        Me.viewStockTile.UseSelectable = True
        '
        'displayPanel
        '
        Me.displayPanel.BackColor = System.Drawing.Color.White
        Me.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.displayPanel.Location = New System.Drawing.Point(200, 100)
        Me.displayPanel.Name = "displayPanel"
        Me.displayPanel.Size = New System.Drawing.Size(923, 490)
        Me.displayPanel.TabIndex = 3
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(733, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Logged In As:"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'userInfoTile
        '
        Me.userInfoTile.ActiveControl = Nothing
        Me.userInfoTile.ForeColor = System.Drawing.Color.Black
        Me.userInfoTile.Location = New System.Drawing.Point(665, 36)
        Me.userInfoTile.Name = "userInfoTile"
        Me.userInfoTile.Size = New System.Drawing.Size(235, 47)
        Me.userInfoTile.TabIndex = 2
        Me.userInfoTile.Text = "User Infomation"
        Me.userInfoTile.UseCustomBackColor = True
        Me.userInfoTile.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 590)
        Me.Controls.Add(Me.displayPanel)
        Me.Controls.Add(Me.controlPanel)
        Me.Controls.Add(Me.navigationPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.navigationPanel.ResumeLayout(False)
        Me.logoPanel.ResumeLayout(False)
        Me.logoPanel.PerformLayout()
        Me.controlPanel.ResumeLayout(False)
        Me.controlPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents navigationPanel As Panel
    Friend WithEvents logoutButton As MetroFramework.Controls.MetroButton
    Friend WithEvents exitButton As MetroFramework.Controls.MetroButton
    Friend WithEvents loginButton As MetroFramework.Controls.MetroButton
    Friend WithEvents dashboardButton As MetroFramework.Controls.MetroButton
    Friend WithEvents logoPanel As Panel
    Friend WithEvents controlPanel As Panel
    Friend WithEvents displayPanel As Panel
    Friend WithEvents undergroundLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents invLable As MetroFramework.Controls.MetroLabel
    Friend WithEvents viewStockTile As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents userInfoTile As MetroFramework.Controls.MetroTile
End Class
