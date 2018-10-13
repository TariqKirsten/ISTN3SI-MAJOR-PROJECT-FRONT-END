Public Class UpdateRecordForm
    Private Sub UpdateRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainForm.dataPanel.updateButton.Enabled = False
    End Sub

    Private Sub UpdateRecordForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.dataPanel.updateButton.Enabled = True
    End Sub
End Class