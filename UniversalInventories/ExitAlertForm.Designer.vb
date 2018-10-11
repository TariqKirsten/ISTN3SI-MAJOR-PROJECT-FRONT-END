<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExitAlertForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.yesButton = New MetroFramework.Controls.MetroButton()
        Me.noButton = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(59, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(275, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Are you sure you want to exit the application?"
        '
        'yesButton
        '
        Me.yesButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.yesButton.Location = New System.Drawing.Point(59, 40)
        Me.yesButton.Name = "yesButton"
        Me.yesButton.Size = New System.Drawing.Size(75, 23)
        Me.yesButton.TabIndex = 1
        Me.yesButton.Text = "Yes"
        Me.yesButton.UseSelectable = True
        '
        'noButton
        '
        Me.noButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.noButton.Location = New System.Drawing.Point(230, 39)
        Me.noButton.Name = "noButton"
        Me.noButton.Size = New System.Drawing.Size(75, 23)
        Me.noButton.TabIndex = 2
        Me.noButton.Text = "No"
        Me.noButton.UseSelectable = True
        '
        'ExitAlertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(385, 75)
        Me.Controls.Add(Me.noButton)
        Me.Controls.Add(Me.yesButton)
        Me.Controls.Add(Me.MetroLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ExitAlertForm"
        Me.Text = "ExitAlertForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents yesButton As MetroFramework.Controls.MetroButton
    Friend WithEvents noButton As MetroFramework.Controls.MetroButton
End Class
