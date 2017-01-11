<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Login = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Signin = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.Transparent
        Me.Login.BackgroundImage = Global.CookEat.My.Resources.Resources.LoginButton
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Login.Location = New System.Drawing.Point(53, 379)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(195, 30)
        Me.Login.TabIndex = 1
        Me.Login.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 0)
        Me.Panel1.TabIndex = 2
        '
        'Signin
        '
        Me.Signin.BackColor = System.Drawing.Color.Black
        Me.Signin.BackgroundImage = Global.CookEat.My.Resources.Resources.Sign_in
        Me.Signin.FlatAppearance.BorderSize = 0
        Me.Signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Signin.ForeColor = System.Drawing.Color.Transparent
        Me.Signin.Location = New System.Drawing.Point(25, 222)
        Me.Signin.Margin = New System.Windows.Forms.Padding(0)
        Me.Signin.Name = "Signin"
        Me.Signin.Size = New System.Drawing.Size(117, 35)
        Me.Signin.TabIndex = 3
        Me.Signin.UseVisualStyleBackColor = False
        '
        'username
        '
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.DimGray
        Me.username.Location = New System.Drawing.Point(61, 300)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(156, 20)
        Me.username.TabIndex = 4
        '
        'password
        '
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.DimGray
        Me.password.Location = New System.Drawing.Point(61, 343)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(156, 20)
        Me.password.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CookEat.My.Resources.Resources.DBsetting
        Me.PictureBox1.Location = New System.Drawing.Point(213, 222)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.CookEat.My.Resources.Resources.DBsetting1
        Me.PictureBox2.Location = New System.Drawing.Point(213, 222)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.CookEat.My.Resources.Resources.Login
        Me.ClientSize = New System.Drawing.Size(300, 265)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Signin)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Signin As Button
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
