Public Class InsertRecordForm
    Private Sub InsertRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainForm.dataPanel.insertRecordBtn.Enabled = False
    End Sub

    Private Sub InsertRecordForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.dataPanel.insertRecordBtn.Enabled = True
    End Sub
End Class