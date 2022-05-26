<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.FullName = New System.Windows.Forms.Label()
        Me.SignoutButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FullName
        '
        Me.FullName.AutoSize = True
        Me.FullName.Location = New System.Drawing.Point(30, 44)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(114, 15)
        Me.FullName.TabIndex = 0
        Me.FullName.Text = "Mohammad Naeem"
        '
        'SignoutButton
        '
        Me.SignoutButton.Location = New System.Drawing.Point(637, 40)
        Me.SignoutButton.Name = "SignoutButton"
        Me.SignoutButton.Size = New System.Drawing.Size(75, 23)
        Me.SignoutButton.TabIndex = 1
        Me.SignoutButton.Text = "Signout"
        Me.SignoutButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(731, 290)
        Me.DataGridView1.TabIndex = 2
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SignoutButton)
        Me.Controls.Add(Me.FullName)
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FullName As Label
    Friend WithEvents SignoutButton As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
