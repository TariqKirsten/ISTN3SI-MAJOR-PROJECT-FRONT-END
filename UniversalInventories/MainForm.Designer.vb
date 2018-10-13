<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.aboutButton = New MetroFramework.Controls.MetroButton()
        Me.logoutButton = New MetroFramework.Controls.MetroButton()
        Me.exitButton = New MetroFramework.Controls.MetroButton()
        Me.loginButton = New MetroFramework.Controls.MetroButton()
        Me.dashboardButton = New MetroFramework.Controls.MetroButton()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.controlPanel = New System.Windows.Forms.Panel()
        Me.labelUser = New MetroFramework.Controls.MetroLabel()
        Me.aboutTile = New MetroFramework.Controls.MetroTile()
        Me.labelLoggedInAs = New MetroFramework.Controls.MetroLabel()
        Me.viewStockTile = New MetroFramework.Controls.MetroTile()
        Me.displayPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.navigationPanel.SuspendLayout()
        Me.logoPanel.SuspendLayout()
        Me.controlPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.navigationPanel.Controls.Add(Me.aboutButton)
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
        'aboutButton
        '
        Me.aboutButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aboutButton.Location = New System.Drawing.Point(58, 386)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(75, 33)
        Me.aboutButton.TabIndex = 5
        Me.aboutButton.Text = "About"
        Me.aboutButton.UseSelectable = True
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
        Me.logoPanel.Controls.Add(Me.PictureBox1)
        Me.logoPanel.Location = New System.Drawing.Point(3, 3)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(251, 97)
        Me.logoPanel.TabIndex = 0
        '
        'controlPanel
        '
        Me.controlPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.controlPanel.Controls.Add(Me.labelUser)
        Me.controlPanel.Controls.Add(Me.aboutTile)
        Me.controlPanel.Controls.Add(Me.labelLoggedInAs)
        Me.controlPanel.Controls.Add(Me.viewStockTile)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.controlPanel.Location = New System.Drawing.Point(200, 0)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Size = New System.Drawing.Size(923, 100)
        Me.controlPanel.TabIndex = 2
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.ForeColor = System.Drawing.Color.White
        Me.labelUser.Location = New System.Drawing.Point(829, 8)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(0, 0)
        Me.labelUser.TabIndex = 3
        Me.labelUser.UseCustomBackColor = True
        Me.labelUser.UseCustomForeColor = True
        '
        'aboutTile
        '
        Me.aboutTile.ActiveControl = Nothing
        Me.aboutTile.ForeColor = System.Drawing.Color.Black
        Me.aboutTile.Location = New System.Drawing.Point(692, 36)
        Me.aboutTile.Name = "aboutTile"
        Me.aboutTile.Size = New System.Drawing.Size(167, 47)
        Me.aboutTile.TabIndex = 2
        Me.aboutTile.Text = "About"
        Me.aboutTile.UseCustomBackColor = True
        Me.aboutTile.UseSelectable = True
        '
        'labelLoggedInAs
        '
        Me.labelLoggedInAs.AutoSize = True
        Me.labelLoggedInAs.ForeColor = System.Drawing.Color.White
        Me.labelLoggedInAs.Location = New System.Drawing.Point(733, 9)
        Me.labelLoggedInAs.Name = "labelLoggedInAs"
        Me.labelLoggedInAs.Size = New System.Drawing.Size(89, 19)
        Me.labelLoggedInAs.TabIndex = 1
        Me.labelLoggedInAs.Text = "Logged In As:"
        Me.labelLoggedInAs.UseCustomBackColor = True
        Me.labelLoggedInAs.UseCustomForeColor = True
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UniversalInventories.My.Resources.Resources.resized_ui
        Me.PictureBox1.Location = New System.Drawing.Point(-10, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 590)
        Me.Controls.Add(Me.displayPanel)
        Me.Controls.Add(Me.controlPanel)
        Me.Controls.Add(Me.navigationPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.navigationPanel.ResumeLayout(False)
        Me.logoPanel.ResumeLayout(False)
        Me.controlPanel.ResumeLayout(False)
        Me.controlPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents viewStockTile As MetroFramework.Controls.MetroTile
    Friend WithEvents labelLoggedInAs As MetroFramework.Controls.MetroLabel
    Friend WithEvents aboutTile As MetroFramework.Controls.MetroTile
    Friend WithEvents labelUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents aboutButton As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
