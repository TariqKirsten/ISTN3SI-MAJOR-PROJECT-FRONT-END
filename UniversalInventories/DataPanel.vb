Imports System.Data.SqlClient

Public Class DataPanel
    Private Sub DataPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelFilter.FontWeight = MetroFramework.MetroLabelWeight.Bold
        dataGrid.BackgroundColor = Color.White
        dataGrid.RowHeadersVisible = False
        dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGrid.DataSource = GetProductList()
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
End Class
