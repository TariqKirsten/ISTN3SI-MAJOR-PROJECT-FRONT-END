Imports MetroFramework
Public Class MainForm
    Public Shared user As String = "lel"
    Dim dashboardAdminPanel As DashboardAdmin = New DashboardAdmin
    Dim loginPanel As LoginPanel = New LoginPanel
    Dim dashboardPanel As DashboardAdmin = New DashboardAdmin
    Public Shared dataPanel As DataPanel = New DataPanel
    Dim aboutPanel As AboutPanel = New AboutPanel



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(loginPanel)
        dashboardButton.Enabled = True 'MAKE FALSE, ONLY TRUE FOR TESTING PURPOSES



        viewStockTile.TileTextFontSize = MetroTileTextSize.Tall
        viewStockTile.TileTextFontWeight = MetroTileTextWeight.Bold
        viewStockTile.TextAlign = ContentAlignment.MiddleCenter

        aboutTile.TileTextFontSize = MetroTileTextSize.Tall
        aboutTile.TileTextFontWeight = MetroTileTextWeight.Bold
        aboutTile.TextAlign = ContentAlignment.MiddleCenter

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


    Private Sub aboutTile_MouseClick(sender As Object, e As MouseEventArgs) Handles aboutTile.MouseClick
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(aboutPanel)
    End Sub











    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles controlPanel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub panelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles controlPanel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub panelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles controlPanel.MouseUp
        draggable = False
    End Sub


End Class
