<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SignupButton = New System.Windows.Forms.Button()
        Me.PasswordTextBoxLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTextBoxLabel = New System.Windows.Forms.Label()
        Me.RollNoTextBox = New System.Windows.Forms.TextBox()
        Me.SignupHeadingLabel = New System.Windows.Forms.Label()
        Me.FullNameTextBoxLabel = New System.Windows.Forms.Label()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(427, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Go back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SignupButton
        '
        Me.SignupButton.Location = New System.Drawing.Point(295, 327)
        Me.SignupButton.Name = "SignupButton"
        Me.SignupButton.Size = New System.Drawing.Size(84, 23)
        Me.SignupButton.TabIndex = 17
        Me.SignupButton.Text = "Signup"
        Me.SignupButton.UseVisualStyleBackColor = True
        '
        'PasswordTextBoxLabel
        '
        Me.PasswordTextBoxLabel.AutoSize = True
        Me.PasswordTextBoxLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PasswordTextBoxLabel.Location = New System.Drawing.Point(290, 258)
        Me.PasswordTextBoxLabel.Name = "PasswordTextBoxLabel"
        Me.PasswordTextBoxLabel.Size = New System.Drawing.Size(76, 21)
        Me.PasswordTextBoxLabel.TabIndex = 16
        Me.PasswordTextBoxLabel.Text = "Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(295, 282)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(216, 23)
        Me.PasswordTextBox.TabIndex = 15
        Me.PasswordTextBox.Visible = False
        '
        'LoginTextBoxLabel
        '
        Me.LoginTextBoxLabel.AutoSize = True
        Me.LoginTextBoxLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LoginTextBoxLabel.Location = New System.Drawing.Point(288, 133)
        Me.LoginTextBoxLabel.Name = "LoginTextBoxLabel"
        Me.LoginTextBoxLabel.Size = New System.Drawing.Size(65, 21)
        Me.LoginTextBoxLabel.TabIndex = 14
        Me.LoginTextBoxLabel.Text = "Roll No."
        '
        'RollNoTextBox
        '
        Me.RollNoTextBox.Location = New System.Drawing.Point(294, 157)
        Me.RollNoTextBox.Name = "RollNoTextBox"
        Me.RollNoTextBox.Size = New System.Drawing.Size(216, 23)
        Me.RollNoTextBox.TabIndex = 13
        '
        'SignupHeadingLabel
        '
        Me.SignupHeadingLabel.AutoSize = True
        Me.SignupHeadingLabel.Font = New System.Drawing.Font("Fira Code", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SignupHeadingLabel.Location = New System.Drawing.Point(328, 70)
        Me.SignupHeadingLabel.Name = "SignupHeadingLabel"
        Me.SignupHeadingLabel.Size = New System.Drawing.Size(144, 41)
        Me.SignupHeadingLabel.TabIndex = 12
        Me.SignupHeadingLabel.Text = "Signup"
        '
        'FullNameTextBoxLabel
        '
        Me.FullNameTextBoxLabel.AutoSize = True
        Me.FullNameTextBoxLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FullNameTextBoxLabel.Location = New System.Drawing.Point(291, 193)
        Me.FullNameTextBoxLabel.Name = "FullNameTextBoxLabel"
        Me.FullNameTextBoxLabel.Size = New System.Drawing.Size(81, 21)
        Me.FullNameTextBoxLabel.TabIndex = 20
        Me.FullNameTextBoxLabel.Text = "Full Name"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(294, 217)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(216, 23)
        Me.FullNameTextBox.TabIndex = 19
        '
        'SignupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FullNameTextBoxLabel)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SignupButton)
        Me.Controls.Add(Me.PasswordTextBoxLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.LoginTextBoxLabel)
        Me.Controls.Add(Me.RollNoTextBox)
        Me.Controls.Add(Me.SignupHeadingLabel)
        Me.Name = "SignupForm"
        Me.Text = "Singup - Students Authentication System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents SignupButton As Button
    Friend WithEvents PasswordTextBoxLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginTextBoxLabel As Label
    Friend WithEvents RollNoTextBox As TextBox
    Friend WithEvents SignupHeadingLabel As Label
    Friend WithEvents FullNameTextBoxLabel As Label
    Friend WithEvents FullNameTextBox As TextBox
End Class
