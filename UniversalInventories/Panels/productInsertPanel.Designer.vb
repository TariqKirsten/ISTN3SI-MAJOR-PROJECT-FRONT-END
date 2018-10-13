<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productInsertPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.insertRecordBtn = New MetroFramework.Controls.MetroButton()
        Me.targetTableLabel = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.nameTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.supplierIDTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.quantityTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.priceTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.productPriceLabel = New MetroFramework.Controls.MetroLabel()
        Me.descriptionTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.addedByTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'insertRecordBtn
        '
        Me.insertRecordBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.insertRecordBtn.Location = New System.Drawing.Point(102, 386)
        Me.insertRecordBtn.Name = "insertRecordBtn"
        Me.insertRecordBtn.Size = New System.Drawing.Size(75, 23)
        Me.insertRecordBtn.TabIndex = 3
        Me.insertRecordBtn.Text = "Insert"
        Me.insertRecordBtn.UseSelectable = True
        '
        'targetTableLabel
        '
        Me.targetTableLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.targetTableLabel.AutoSize = True
        Me.targetTableLabel.Location = New System.Drawing.Point(85, 16)
        Me.targetTableLabel.Name = "targetTableLabel"
        Me.targetTableLabel.Size = New System.Drawing.Size(137, 19)
        Me.targetTableLabel.TabIndex = 4
        Me.targetTableLabel.Text = "Target Table: Products"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Name"
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
        Me.nameTextbox.Location = New System.Drawing.Point(130, 63)
        Me.nameTextbox.MaxLength = 32767
        Me.nameTextbox.Name = "nameTextbox"
        Me.nameTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nameTextbox.SelectedText = ""
        Me.nameTextbox.SelectionLength = 0
        Me.nameTextbox.SelectionStart = 0
        Me.nameTextbox.ShortcutsEnabled = True
        Me.nameTextbox.Size = New System.Drawing.Size(145, 23)
        Me.nameTextbox.TabIndex = 6
        Me.nameTextbox.UseSelectable = True
        Me.nameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nameTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'supplierIDTextbox
        '
        '
        '
        '
        Me.supplierIDTextbox.CustomButton.Image = Nothing
        Me.supplierIDTextbox.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.supplierIDTextbox.CustomButton.Name = ""
        Me.supplierIDTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.supplierIDTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.supplierIDTextbox.CustomButton.TabIndex = 1
        Me.supplierIDTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.supplierIDTextbox.CustomButton.UseSelectable = True
        Me.supplierIDTextbox.CustomButton.Visible = False
        Me.supplierIDTextbox.Lines = New String(-1) {}
        Me.supplierIDTextbox.Location = New System.Drawing.Point(130, 182)
        Me.supplierIDTextbox.MaxLength = 32767
        Me.supplierIDTextbox.Name = "supplierIDTextbox"
        Me.supplierIDTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.supplierIDTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.supplierIDTextbox.SelectedText = ""
        Me.supplierIDTextbox.SelectionLength = 0
        Me.supplierIDTextbox.SelectionStart = 0
        Me.supplierIDTextbox.ShortcutsEnabled = True
        Me.supplierIDTextbox.Size = New System.Drawing.Size(145, 23)
        Me.supplierIDTextbox.TabIndex = 8
        Me.supplierIDTextbox.UseSelectable = True
        Me.supplierIDTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.supplierIDTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 182)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Supplier ID"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(13, 267)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel3.TabIndex = 9
        Me.MetroLabel3.Text = "Description"
        '
        'quantityTextbox
        '
        '
        '
        '
        Me.quantityTextbox.CustomButton.Image = Nothing
        Me.quantityTextbox.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.quantityTextbox.CustomButton.Name = ""
        Me.quantityTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.quantityTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.quantityTextbox.CustomButton.TabIndex = 1
        Me.quantityTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.quantityTextbox.CustomButton.UseSelectable = True
        Me.quantityTextbox.CustomButton.Visible = False
        Me.quantityTextbox.Lines = New String(-1) {}
        Me.quantityTextbox.Location = New System.Drawing.Point(130, 144)
        Me.quantityTextbox.MaxLength = 32767
        Me.quantityTextbox.Name = "quantityTextbox"
        Me.quantityTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.quantityTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.quantityTextbox.SelectedText = ""
        Me.quantityTextbox.SelectionLength = 0
        Me.quantityTextbox.SelectionStart = 0
        Me.quantityTextbox.ShortcutsEnabled = True
        Me.quantityTextbox.Size = New System.Drawing.Size(145, 23)
        Me.quantityTextbox.TabIndex = 12
        Me.quantityTextbox.UseSelectable = True
        Me.quantityTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.quantityTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(12, 144)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "Quantity"
        '
        'priceTextbox
        '
        '
        '
        '
        Me.priceTextbox.CustomButton.Image = Nothing
        Me.priceTextbox.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.priceTextbox.CustomButton.Name = ""
        Me.priceTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.priceTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.priceTextbox.CustomButton.TabIndex = 1
        Me.priceTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.priceTextbox.CustomButton.UseSelectable = True
        Me.priceTextbox.CustomButton.Visible = False
        Me.priceTextbox.Lines = New String(-1) {}
        Me.priceTextbox.Location = New System.Drawing.Point(130, 101)
        Me.priceTextbox.MaxLength = 32767
        Me.priceTextbox.Name = "priceTextbox"
        Me.priceTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.priceTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.priceTextbox.SelectedText = ""
        Me.priceTextbox.SelectionLength = 0
        Me.priceTextbox.SelectionStart = 0
        Me.priceTextbox.ShortcutsEnabled = True
        Me.priceTextbox.Size = New System.Drawing.Size(145, 23)
        Me.priceTextbox.TabIndex = 14
        Me.priceTextbox.UseSelectable = True
        Me.priceTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.priceTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'productPriceLabel
        '
        Me.productPriceLabel.AutoSize = True
        Me.productPriceLabel.Location = New System.Drawing.Point(12, 101)
        Me.productPriceLabel.Name = "productPriceLabel"
        Me.productPriceLabel.Size = New System.Drawing.Size(42, 19)
        Me.productPriceLabel.TabIndex = 13
        Me.productPriceLabel.Text = " Price"
        '
        'descriptionTextbox
        '
        '
        '
        '
        Me.descriptionTextbox.CustomButton.Image = Nothing
        Me.descriptionTextbox.CustomButton.Location = New System.Drawing.Point(49, 1)
        Me.descriptionTextbox.CustomButton.Name = ""
        Me.descriptionTextbox.CustomButton.Size = New System.Drawing.Size(95, 95)
        Me.descriptionTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.descriptionTextbox.CustomButton.TabIndex = 1
        Me.descriptionTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.descriptionTextbox.CustomButton.UseSelectable = True
        Me.descriptionTextbox.CustomButton.Visible = False
        Me.descriptionTextbox.Lines = New String(-1) {}
        Me.descriptionTextbox.Location = New System.Drawing.Point(130, 267)
        Me.descriptionTextbox.MaxLength = 32767
        Me.descriptionTextbox.Multiline = True
        Me.descriptionTextbox.Name = "descriptionTextbox"
        Me.descriptionTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.descriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.descriptionTextbox.SelectedText = ""
        Me.descriptionTextbox.SelectionLength = 0
        Me.descriptionTextbox.SelectionStart = 0
        Me.descriptionTextbox.ShortcutsEnabled = True
        Me.descriptionTextbox.Size = New System.Drawing.Size(145, 97)
        Me.descriptionTextbox.TabIndex = 15
        Me.descriptionTextbox.UseSelectable = True
        Me.descriptionTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.descriptionTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'addedByTextbox
        '
        '
        '
        '
        Me.addedByTextbox.CustomButton.Image = Nothing
        Me.addedByTextbox.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.addedByTextbox.CustomButton.Name = ""
        Me.addedByTextbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.addedByTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.addedByTextbox.CustomButton.TabIndex = 1
        Me.addedByTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.addedByTextbox.CustomButton.UseSelectable = True
        Me.addedByTextbox.CustomButton.Visible = False
        Me.addedByTextbox.Lines = New String(-1) {}
        Me.addedByTextbox.Location = New System.Drawing.Point(130, 225)
        Me.addedByTextbox.MaxLength = 32767
        Me.addedByTextbox.Name = "addedByTextbox"
        Me.addedByTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addedByTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.addedByTextbox.SelectedText = ""
        Me.addedByTextbox.SelectionLength = 0
        Me.addedByTextbox.SelectionStart = 0
        Me.addedByTextbox.ShortcutsEnabled = True
        Me.addedByTextbox.Size = New System.Drawing.Size(145, 23)
        Me.addedByTextbox.TabIndex = 17
        Me.addedByTextbox.UseSelectable = True
        Me.addedByTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.addedByTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(12, 225)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel5.TabIndex = 16
        Me.MetroLabel5.Text = "Added By"
        '
        'productInsertPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.addedByTextbox)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.descriptionTextbox)
        Me.Controls.Add(Me.priceTextbox)
        Me.Controls.Add(Me.productPriceLabel)
        Me.Controls.Add(Me.quantityTextbox)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.supplierIDTextbox)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.nameTextbox)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.targetTableLabel)
        Me.Controls.Add(Me.insertRecordBtn)
        Me.Name = "productInsertPanel"
        Me.Size = New System.Drawing.Size(296, 437)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents insertRecordBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents targetTableLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents nameTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents supplierIDTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents quantityTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents priceTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents productPriceLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents descriptionTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents addedByTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
End Class
