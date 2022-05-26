<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.LoginHeadingLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginHeadingLabel
        '
        Me.LoginHeadingLabel.AutoSize = True
        Me.LoginHeadingLabel.Font = New System.Drawing.Font("Fira Code", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoginHeadingLabel.Location = New System.Drawing.Point(317, 76)
        Me.LoginHeadingLabel.Name = "LoginHeadingLabel"
        Me.LoginHeadingLabel.Size = New System.Drawing.Size(123, 41)
        Me.LoginHeadingLabel.TabIndex = 4
        Me.LoginHeadingLabel.Text = "Login"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LoginHeadingLabel)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginHeadingLabel As Label
End Class
