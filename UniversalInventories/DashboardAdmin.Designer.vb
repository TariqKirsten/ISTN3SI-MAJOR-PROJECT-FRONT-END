<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdmin
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.labelLoginHistory = New MetroFramework.Controls.MetroLabel()
        Me.loginsList = New MetroFramework.Controls.MetroListView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.exportLoginHistoryBtn = New MetroFramework.Controls.MetroButton()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelLoginHistory
        '
        Me.labelLoginHistory.AutoSize = True
        Me.labelLoginHistory.Location = New System.Drawing.Point(76, 57)
        Me.labelLoginHistory.Name = "labelLoginHistory"
        Me.labelLoginHistory.Size = New System.Drawing.Size(86, 19)
        Me.labelLoginHistory.TabIndex = 0
        Me.labelLoginHistory.Text = "Login History"
        '
        'loginsList
        '
        Me.loginsList.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.loginsList.FullRowSelect = True
        Me.loginsList.Location = New System.Drawing.Point(22, 95)
        Me.loginsList.Name = "loginsList"
        Me.loginsList.OwnerDraw = True
        Me.loginsList.Size = New System.Drawing.Size(214, 258)
        Me.loginsList.TabIndex = 1
        Me.loginsList.UseCompatibleStateImageBehavior = False
        Me.loginsList.UseSelectable = True
        '
        'exportLoginHistoryBtn
        '
        Me.exportLoginHistoryBtn.Location = New System.Drawing.Point(76, 421)
        Me.exportLoginHistoryBtn.Name = "exportLoginHistoryBtn"
        Me.exportLoginHistoryBtn.Size = New System.Drawing.Size(115, 57)
        Me.exportLoginHistoryBtn.TabIndex = 2
        Me.exportLoginHistoryBtn.Text = "Export Login History"
        Me.exportLoginHistoryBtn.UseSelectable = True
        '
        'WelcomeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.exportLoginHistoryBtn)
        Me.Controls.Add(Me.loginsList)
        Me.Controls.Add(Me.labelLoginHistory)
        Me.Name = "WelcomeControl"
        Me.Size = New System.Drawing.Size(733, 496)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelLoginHistory As MetroFramework.Controls.MetroLabel
    Friend WithEvents loginsList As MetroFramework.Controls.MetroListView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents exportLoginHistoryBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
End Class
