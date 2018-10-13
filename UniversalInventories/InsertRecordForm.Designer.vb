<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InsertRecordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.parentInsertPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'parentInsertPanel
        '
        Me.parentInsertPanel.Location = New System.Drawing.Point(2, 12)
        Me.parentInsertPanel.Name = "parentInsertPanel"
        Me.parentInsertPanel.Size = New System.Drawing.Size(296, 437)
        Me.parentInsertPanel.TabIndex = 0
        '
        'InsertRecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(299, 450)
        Me.Controls.Add(Me.parentInsertPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "InsertRecordForm"
        Me.Text = "Insert Record"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents parentInsertPanel As Panel
End Class
