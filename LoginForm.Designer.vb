<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoBackButton
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
        Me.RollNoTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTextBoxLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBoxLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        'RollNoTextBox
        '
        Me.RollNoTextBox.Location = New System.Drawing.Point(287, 167)
        Me.RollNoTextBox.Name = "RollNoTextBox"
        Me.RollNoTextBox.Size = New System.Drawing.Size(216, 23)
        Me.RollNoTextBox.TabIndex = 5
        '
        'LoginTextBoxLabel
        '
        Me.LoginTextBoxLabel.AutoSize = True
        Me.LoginTextBoxLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LoginTextBoxLabel.Location = New System.Drawing.Point(283, 143)
        Me.LoginTextBoxLabel.Name = "LoginTextBoxLabel"
        Me.LoginTextBoxLabel.Size = New System.Drawing.Size(65, 21)
        Me.LoginTextBoxLabel.TabIndex = 7
        Me.LoginTextBoxLabel.Text = "Roll No."
        '
        'PasswordTextBoxLabel
        '
        Me.PasswordTextBoxLabel.AutoSize = True
        Me.PasswordTextBoxLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PasswordTextBoxLabel.Location = New System.Drawing.Point(282, 203)
        Me.PasswordTextBoxLabel.Name = "PasswordTextBoxLabel"
        Me.PasswordTextBoxLabel.Size = New System.Drawing.Size(76, 21)
        Me.PasswordTextBoxLabel.TabIndex = 9
        Me.PasswordTextBoxLabel.Text = "Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(287, 227)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(216, 23)
        Me.PasswordTextBox.TabIndex = 8
        Me.PasswordTextBox.Visible = False
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(287, 272)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(84, 23)
        Me.LoginButton.TabIndex = 10
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(419, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Go back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GoBackButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBoxLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.LoginTextBoxLabel)
        Me.Controls.Add(Me.RollNoTextBox)
        Me.Controls.Add(Me.LoginHeadingLabel)
        Me.Name = "GoBackButton"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginHeadingLabel As Label
    Friend WithEvents RollNoTextBox As TextBox
    Friend WithEvents LoginTextBoxLabel As Label
    Friend WithEvents PasswordTextBoxLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents Button1 As Button
End Class
