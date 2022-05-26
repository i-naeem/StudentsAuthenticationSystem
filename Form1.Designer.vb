<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.LoginAnchorButton = New System.Windows.Forms.Button()
        Me.SignupAnchorButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginAnchorButton
        '
        Me.LoginAnchorButton.Location = New System.Drawing.Point(303, 163)
        Me.LoginAnchorButton.Name = "LoginAnchorButton"
        Me.LoginAnchorButton.Size = New System.Drawing.Size(131, 50)
        Me.LoginAnchorButton.TabIndex = 0
        Me.LoginAnchorButton.Text = "Login"
        Me.LoginAnchorButton.UseVisualStyleBackColor = True
        '
        'SignupAnchorButton
        '
        Me.SignupAnchorButton.Location = New System.Drawing.Point(303, 244)
        Me.SignupAnchorButton.Name = "SignupAnchorButton"
        Me.SignupAnchorButton.Size = New System.Drawing.Size(131, 50)
        Me.SignupAnchorButton.TabIndex = 1
        Me.SignupAnchorButton.Text = "Sign up"
        Me.SignupAnchorButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(84, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(648, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Students Authentication System"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SignupAnchorButton)
        Me.Controls.Add(Me.LoginAnchorButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginAnchorButton As Button
    Friend WithEvents SignupAnchorButton As Button
    Friend WithEvents Label1 As Label
End Class
