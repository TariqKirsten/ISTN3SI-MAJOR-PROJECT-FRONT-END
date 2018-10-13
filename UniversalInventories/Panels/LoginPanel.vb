Imports MetroFramework

Public Class LoginPanel

    Public Shared successfulLogin As Boolean = True

    Private Sub LoginPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        usernameLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        passwordLabel.FontSize = MetroFramework.MetroLabelSize.Tall


    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        ' Add this code on successful login  MainForm.user = usernameLabel.Text loggedIn = True
        MainForm.labelUser.Text = MainForm.user
        loginButton.Enabled = False
    End Sub
End Class
