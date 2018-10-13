<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class supplierInsertPanel
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
        Me.targetTableLabel = New MetroFramework.Controls.MetroLabel()
        Me.contactNoTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.productPriceLabel = New MetroFramework.Controls.MetroLabel()
        Me.addressTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.emailAddressTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.nameTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.insertRecordBtn = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'targetTableLabel
        '
        Me.targetTableLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.targetTableLabel.AutoSize = True
        Me.targetTableLabel.Location = New System.Drawing.Point(85, 16)
        Me.targetTableLabel.Name = "targetTableLabel"
        Me.targetTableLabel.Size = New System.Drawing.Size(139, 19)
        Me.targetTableLabel.TabIndex = 5
        Me.targetTableLabel.Text = "Target Table: Suppliers"
        '
        'contactNoTextbox
        '
        '
        '
        '
        Me.contactNoTextbox.CustomButton.Image = Nothing
        Me.contactNoTextbox.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.contactNoTextbox.CustomButton.Name = ""
        Me.contactNoTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.contactNoTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.contactNoTextbox.CustomButton.TabIndex = 1
        Me.contactNoTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.contactNoTextbox.CustomButton.UseSelectable = True
        Me.contactNoTextbox.CustomButton.Visible = False
        Me.contactNoTextbox.Lines = New String(-1) {}
        Me.contactNoTextbox.Location = New System.Drawing.Point(133, 133)
        Me.contactNoTextbox.MaxLength = 32767
        Me.contactNoTextbox.Name = "contactNoTextbox"
        Me.contactNoTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contactNoTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.contactNoTextbox.SelectedText = ""
        Me.contactNoTextbox.SelectionLength = 0
        Me.contactNoTextbox.SelectionStart = 0
        Me.contactNoTextbox.ShortcutsEnabled = True
        Me.contactNoTextbox.Size = New System.Drawing.Size(145, 23)
        Me.contactNoTextbox.TabIndex = 22
        Me.contactNoTextbox.UseSelectable = True
        Me.contactNoTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.contactNoTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'productPriceLabel
        '
        Me.productPriceLabel.AutoSize = True
        Me.productPriceLabel.Location = New System.Drawing.Point(15, 133)
        Me.productPriceLabel.Name = "productPriceLabel"
        Me.productPriceLabel.Size = New System.Drawing.Size(79, 19)
        Me.productPriceLabel.TabIndex = 21
        Me.productPriceLabel.Text = "Contact No."
        '
        'addressTextbox
        '
        '
        '
        '
        Me.addressTextbox.CustomButton.Image = Nothing
        Me.addressTextbox.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.addressTextbox.CustomButton.Name = ""
        Me.addressTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.addressTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.addressTextbox.CustomButton.TabIndex = 1
        Me.addressTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.addressTextbox.CustomButton.UseSelectable = True
        Me.addressTextbox.CustomButton.Visible = False
        Me.addressTextbox.Lines = New String(-1) {}
        Me.addressTextbox.Location = New System.Drawing.Point(133, 194)
        Me.addressTextbox.MaxLength = 32767
        Me.addressTextbox.Name = "addressTextbox"
        Me.addressTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addressTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.addressTextbox.SelectedText = ""
        Me.addressTextbox.SelectionLength = 0
        Me.addressTextbox.SelectionStart = 0
        Me.addressTextbox.ShortcutsEnabled = True
        Me.addressTextbox.Size = New System.Drawing.Size(145, 23)
        Me.addressTextbox.TabIndex = 20
        Me.addressTextbox.UseSelectable = True
        Me.addressTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.addressTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(15, 194)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel4.TabIndex = 19
        Me.MetroLabel4.Text = "Address"
        '
        'emailAddressTextbox
        '
        '
        '
        '
        Me.emailAddressTextbox.CustomButton.Image = Nothing
        Me.emailAddressTextbox.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.emailAddressTextbox.CustomButton.Name = ""
        Me.emailAddressTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.emailAddressTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emailAddressTextbox.CustomButton.TabIndex = 1
        Me.emailAddressTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emailAddressTextbox.CustomButton.UseSelectable = True
        Me.emailAddressTextbox.CustomButton.Visible = False
        Me.emailAddressTextbox.Lines = New String(-1) {}
        Me.emailAddressTextbox.Location = New System.Drawing.Point(133, 263)
        Me.emailAddressTextbox.MaxLength = 32767
        Me.emailAddressTextbox.Name = "emailAddressTextbox"
        Me.emailAddressTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailAddressTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emailAddressTextbox.SelectedText = ""
        Me.emailAddressTextbox.SelectionLength = 0
        Me.emailAddressTextbox.SelectionStart = 0
        Me.emailAddressTextbox.ShortcutsEnabled = True
        Me.emailAddressTextbox.Size = New System.Drawing.Size(145, 23)
        Me.emailAddressTextbox.TabIndex = 18
        Me.emailAddressTextbox.UseSelectable = True
        Me.emailAddressTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emailAddressTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(16, 263)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel2.TabIndex = 17
        Me.MetroLabel2.Text = "Email Address"
        '
        'nameTextbox
        '
        '
        '
        '
        Me.nameTextbox.CustomButton.Image = Nothing
        Me.nameTextbox.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.nameTextbox.CustomButton.Name = ""
        Me.nameTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nameTextbox.CustomButton.TabIndex = 1
        Me.nameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nameTextbox.CustomButton.UseSelectable = True
        Me.nameTextbox.CustomButton.Visible = False
        Me.nameTextbox.Lines = New String(-1) {}
        Me.nameTextbox.Location = New System.Drawing.Point(133, 63)
        Me.nameTextbox.MaxLength = 32767
        Me.nameTextbox.Name = "nameTextbox"
        Me.nameTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTextbox.SelectedText = ""
        Me.nameTextbox.SelectionLength = 0
        Me.nameTextbox.SelectionStart = 0
        Me.nameTextbox.ShortcutsEnabled = True
        Me.nameTextbox.Size = New System.Drawing.Size(145, 23)
        Me.nameTextbox.TabIndex = 16
        Me.nameTextbox.UseSelectable = True
        Me.nameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 15
        Me.MetroLabel1.Text = "Name"
        '
        'insertRecordBtn
        '
        Me.insertRecordBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.insertRecordBtn.Location = New System.Drawing.Point(103, 395)
        Me.insertRecordBtn.Name = "insertRecordBtn"
        Me.insertRecordBtn.Size = New System.Drawing.Size(75, 23)
        Me.insertRecordBtn.TabIndex = 23
        Me.insertRecordBtn.Text = "Insert"
        Me.insertRecordBtn.UseSelectable = True
        '
        'supplierInsertPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.insertRecordBtn)
        Me.Controls.Add(Me.contactNoTextbox)
        Me.Controls.Add(Me.productPriceLabel)
        Me.Controls.Add(Me.addressTextbox)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.emailAddressTextbox)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.nameTextbox)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.targetTableLabel)
        Me.Name = "supplierInsertPanel"
        Me.Size = New System.Drawing.Size(296, 437)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents targetTableLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents contactNoTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents productPriceLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents addressTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents emailAddressTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents nameTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents insertRecordBtn As MetroFramework.Controls.MetroButton
End Class
