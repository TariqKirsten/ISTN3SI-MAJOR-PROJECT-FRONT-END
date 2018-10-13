<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPanel
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
        Me.components = New System.ComponentModel.Container()
        Me.searchButton = New MetroFramework.Controls.MetroButton()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.tablesOptionsComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.LabelTable = New MetroFramework.Controls.MetroLabel()
        Me.searchBox = New MetroFramework.Controls.MetroTextBox()
        Me.viewAllRows = New MetroFramework.Controls.MetroButton()
        Me.updateButton = New MetroFramework.Controls.MetroButton()
        Me.insertRecordBtn = New MetroFramework.Controls.MetroButton()
        Me.CustomerDataSet = New UniversalInventories.CustomerDataSet()
        Me.CustomerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New UniversalInventories.CustomerDataSetTableAdapters.ProductsTableAdapter()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(592, 20)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 2
        Me.searchButton.Text = "Search"
        Me.searchButton.UseSelectable = True
        '
        'tablesOptionsComboBox
        '
        Me.tablesOptionsComboBox.FormattingEnabled = True
        Me.tablesOptionsComboBox.ItemHeight = 23
        Me.tablesOptionsComboBox.Location = New System.Drawing.Point(86, 14)
        Me.tablesOptionsComboBox.Name = "tablesOptionsComboBox"
        Me.tablesOptionsComboBox.Size = New System.Drawing.Size(121, 29)
        Me.tablesOptionsComboBox.TabIndex = 3
        Me.tablesOptionsComboBox.UseSelectable = True
        '
        'LabelTable
        '
        Me.LabelTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTable.AutoSize = True
        Me.LabelTable.Location = New System.Drawing.Point(23, 20)
        Me.LabelTable.Name = "LabelTable"
        Me.LabelTable.Size = New System.Drawing.Size(39, 19)
        Me.LabelTable.TabIndex = 4
        Me.LabelTable.Text = "Table"
        '
        'searchBox
        '
        '
        '
        '
        Me.searchBox.CustomButton.Image = Nothing
        Me.searchBox.CustomButton.Location = New System.Drawing.Point(184, 1)
        Me.searchBox.CustomButton.Name = ""
        Me.searchBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.searchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchBox.CustomButton.TabIndex = 1
        Me.searchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchBox.CustomButton.UseSelectable = True
        Me.searchBox.CustomButton.Visible = False
        Me.searchBox.Lines = New String(-1) {}
        Me.searchBox.Location = New System.Drawing.Point(357, 20)
        Me.searchBox.MaxLength = 32767
        Me.searchBox.Name = "searchBox"
        Me.searchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchBox.SelectedText = ""
        Me.searchBox.SelectionLength = 0
        Me.searchBox.SelectionStart = 0
        Me.searchBox.ShortcutsEnabled = True
        Me.searchBox.Size = New System.Drawing.Size(206, 23)
        Me.searchBox.TabIndex = 5
        Me.searchBox.UseSelectable = True
        Me.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'viewAllRows
        '
        Me.viewAllRows.Location = New System.Drawing.Point(714, 130)
        Me.viewAllRows.Name = "viewAllRows"
        Me.viewAllRows.Size = New System.Drawing.Size(105, 30)
        Me.viewAllRows.TabIndex = 6
        Me.viewAllRows.Text = "View All Records"
        Me.viewAllRows.UseSelectable = True
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(714, 227)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(105, 33)
        Me.updateButton.TabIndex = 7
        Me.updateButton.Text = "Update A Record"
        Me.updateButton.UseSelectable = True
        '
        'insertRecordBtn
        '
        Me.insertRecordBtn.Location = New System.Drawing.Point(714, 343)
        Me.insertRecordBtn.Name = "insertRecordBtn"
        Me.insertRecordBtn.Size = New System.Drawing.Size(105, 34)
        Me.insertRecordBtn.TabIndex = 8
        Me.insertRecordBtn.Text = "Insert A Record"
        Me.insertRecordBtn.UseSelectable = True
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDataSetBindingSource
        '
        Me.CustomerDataSetBindingSource.DataSource = Me.CustomerDataSet
        Me.CustomerDataSetBindingSource.Position = 0
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.CustomerDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(23, 81)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.Size = New System.Drawing.Size(644, 342)
        Me.dataGrid.TabIndex = 9
        '
        'DataPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.insertRecordBtn)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.viewAllRows)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.LabelTable)
        Me.Controls.Add(Me.tablesOptionsComboBox)
        Me.Controls.Add(Me.searchButton)
        Me.Name = "DataPanel"
        Me.Size = New System.Drawing.Size(962, 579)
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents searchButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents tablesOptionsComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents LabelTable As MetroFramework.Controls.MetroLabel
    Friend WithEvents searchBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents viewAllRows As MetroFramework.Controls.MetroButton
    Friend WithEvents updateButton As MetroFramework.Controls.MetroButton
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CustomerDataSetBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As CustomerDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents dataGrid As DataGridView
    Public WithEvents insertRecordBtn As MetroFramework.Controls.MetroButton
End Class
