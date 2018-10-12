Imports MetroFramework
Public Class ExitAlertForm
    Private Sub yesButton_Click(sender As Object, e As EventArgs) Handles yesButton.Click
        Me.Close()
        MainForm.Close()
    End Sub

    Private Sub noButton_Click(sender As Object, e As EventArgs) Handles noButton.Click
        Me.Close()

    End Sub

    Private Sub ExitAlertForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Exit Application"
    End Sub
End Class