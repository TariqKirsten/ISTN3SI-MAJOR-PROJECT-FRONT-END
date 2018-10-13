Imports System.Data.SqlClient
Imports MetroFramework
Public Class DataPanel

    Dim table As String = ""

    'Dim productInsertPanel As productInsertPanel = New productInsertPanel
    'Dim supplierInsertPanel As supplierInsertPanel = New supplierInsertPanel
    'Dim userInsertPanel As userInsertPanel = New userInsertPanel


    Private Sub DataPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelTable.FontWeight = MetroFramework.MetroLabelWeight.Bold

        initTableComboBox()

        loadDataGridViewer(GetProductList())

    End Sub


    Private Sub initTableComboBox()

        If LoginPanel.successfulLogin = True Then
            tablesOptionsComboBox.Items.Add("Products")
            tablesOptionsComboBox.Items.Add("Suppliers")
            If MainForm.user = "Admin" Then
                tablesOptionsComboBox.Items.Add("Employees")
            End If
        Else

        End If

    End Sub




    Private Sub loadDataGridViewer(dt As DataTable)
        dataGrid.BackgroundColor = Color.White
        dataGrid.RowHeadersVisible = False
        dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGrid.DataSource = dt
        dataGrid.MultiSelect = False
    End Sub

    Private Function GetProductList() As DataTable
        Dim productDataTable As New DataTable
        'Dim connectionString = "Data Source=DESKTOP-HRK18F5\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True"

        'Dim connection As New SqlConnection(connectionString)
        'Dim command As New SqlCommand()
        'command.Connection = connection
        'command.CommandText = "select * from Products"

        'connection.Open()

        'Dim reader As SqlDataReader = command.ExecuteReader
        'productDataTable.Load(reader)

        'connection.Close()
        Return productDataTable
    End Function

    Private Sub tablesOptionsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tablesOptionsComboBox.SelectedIndexChanged
        table = tablesOptionsComboBox.SelectedItem()

        Select Case table
            Case "Products"
                loadDataGridViewer(GetProductList)
            Case "Suppliers"
                loadDataGridViewer(Nothing)  'Change to getSupplier function

            Case "Employees"
                loadDataGridViewer(Nothing) 'Change to getEmployees function

        End Select

    End Sub

    Private Sub insertRecordBtn_Click(sender As Object, e As EventArgs) Handles insertRecordBtn.Click
        Dim insertRecordForm As InsertRecordForm = New InsertRecordForm
        Select Case table
            Case "Products"
                insertRecordForm.parentInsertPanel.Controls.Clear()
                insertRecordForm.parentInsertPanel.Controls.Add(New productInsertPanel)
            Case "Suppliers"
                insertRecordForm.parentInsertPanel.Controls.Clear()
                insertRecordForm.parentInsertPanel.Controls.Add(New supplierInsertPanel)

            Case "Employees"
                insertRecordForm.parentInsertPanel.Controls.Clear()
                insertRecordForm.parentInsertPanel.Controls.Add(New userInsertPanel)

        End Select
        insertRecordForm.Show()
    End Sub

    Private Sub viewAllRows_Click(sender As Object, e As EventArgs) Handles viewAllRows.Click

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim updateRecordForm As UpdateRecordForm = New UpdateRecordForm
        Select Case table
            Case "Products"
                updateRecordForm.parentUpdatePanel.Controls.Clear()
                updateRecordForm.parentUpdatePanel.Controls.Add(New productUpdatePanel)
            Case "Suppliers"
                updateRecordForm.parentUpdatePanel.Controls.Clear()
                updateRecordForm.parentUpdatePanel.Controls.Add(New supplierUpdatePanel)

            Case "Employees"
                updateRecordForm.parentUpdatePanel.Controls.Clear()
                updateRecordForm.parentUpdatePanel.Controls.Add(New userUpdatePanel)

        End Select
        updateRecordForm.Show()
    End Sub
End Class
