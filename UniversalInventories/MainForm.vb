Imports MetroFramework
Public Class MainForm
    Dim dashboardAdminPanel As DashboardAdmin = New DashboardAdmin
    Dim loginPanel As LoginPanel = New LoginPanel
    Dim dashboardPanel As DashboardAdmin = New DashboardAdmin
    Dim dataPanel As DataPanel = New DataPanel


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(loginPanel)
        dashboardButton.Enabled = True 'MAKE FALSE, ONLY TRUE FOR TESTING PURPOSES

        undergroundLabel.FontSize = MetroFramework.MetroLabelSize.Small
        undergroundLabel.FontWeight = MetroLabelWeight.Bold
        invLable.FontSize = MetroFramework.MetroLabelSize.Small
        invLable.FontWeight = MetroLabelWeight.Bold

        viewStockTile.TileTextFontSize = MetroTileTextSize.Tall
        viewStockTile.TileTextFontWeight = MetroTileTextWeight.Bold
        viewStockTile.TextAlign = ContentAlignment.MiddleCenter

        userInfoTile.TileTextFontSize = MetroTileTextSize.Tall
        userInfoTile.TileTextFontWeight = MetroTileTextWeight.Bold
        userInfoTile.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim exitForm As ExitAlertForm = New ExitAlertForm
        exitForm.ShowDialog()

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(loginPanel)
    End Sub

    Private Sub dashboardButton_Click(sender As Object, e As EventArgs) Handles dashboardButton.Click
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(dashboardPanel)
    End Sub

    Private Sub viewStockTile_Click(sender As Object, e As EventArgs) Handles viewStockTile.Click
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(dataPanel)
    End Sub
End Class
