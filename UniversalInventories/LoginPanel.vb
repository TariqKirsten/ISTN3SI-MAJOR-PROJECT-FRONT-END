Imports MetroFramework

Public Class LoginPanel
    Private Sub LoginPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        usernameLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        passwordLabel.FontSize = MetroFramework.MetroLabelSize.Tall


    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click

    End Sub
End Class
