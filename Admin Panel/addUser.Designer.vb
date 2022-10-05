<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUser
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
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(12, 12)
        Me.username.Name = "username"
        Me.username.PlaceholderText = "Username"
        Me.username.Size = New System.Drawing.Size(182, 23)
        Me.username.TabIndex = 0
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(12, 41)
        Me.password.Name = "password"
        Me.password.PlaceholderText = "Password"
        Me.password.Size = New System.Drawing.Size(182, 23)
        Me.password.TabIndex = 1
        '
        'fName
        '
        Me.fName.Location = New System.Drawing.Point(12, 70)
        Me.fName.Name = "fName"
        Me.fName.PlaceholderText = "First Name"
        Me.fName.Size = New System.Drawing.Size(182, 23)
        Me.fName.TabIndex = 2
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(13, 100)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(177, 50)
        Me.submit.TabIndex = 3
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'addUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 162)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Name = "addUser"
        Me.Text = "addUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents fName As TextBox
    Friend WithEvents submit As Button
End Class
