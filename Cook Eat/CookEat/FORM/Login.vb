Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim LoginDesign As Boolean = False
    Dim x, y As Integer
    Dim Newpoint As New Point
    '================================Login Settings=============================================================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Signin.Click
        Me.Opacity = 1
        If Not LoginDesign Then
            Do Until Me.Height = 475
                Me.Height += 1
                System.Threading.Thread.Sleep(1)
            Loop
            LoginDesign = True
        Else
            Do Until Me.Height = 265
                Me.Height -= 1
                System.Threading.Thread.Sleep(1)
            Loop
            LoginDesign = False
        End If
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        x = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Newpoint = Control.MousePosition
            Newpoint.X -= x
            Newpoint.Y -= y
            Me.Location = Newpoint
            Application.DoEvents()
        End If
    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Hide()
        PictureBox2.Show()
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox1.Show()
    End Sub
    '==================================================================================================================
    '================================Login SQLconnection===============================================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        loginFunction()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            loginFunction()
            logname = username.Text
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Opacity = 0.5
        username.Clear()
        password.Clear()
        If Not LoginDesign Then
            LoginDesign = True
        Else
            Do Until Me.Height = 265
                Me.Height -= 1
                System.Threading.Thread.Sleep(1)
            Loop
            LoginDesign = False
        End If
        SQLsettings.ShowDialog()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Clear()
        password.Clear()
    End Sub

    Private Sub loginFunction()
        If username.Text = "" Or password.Text = "" Then
            MsgBox("Username and Password Required!", MsgBoxStyle.Exclamation, "Cook Eat System")
            username.Clear()
            password.Clear()
        Else
            If ConnectionTest(ReadSettings("host"), ReadSettings("user"), ReadSettings("password")) Then
                Connect()
                cmd = New MySqlCommand("INSERT INTO dlog VALUES (NULL, @ub, @md,@ut,NOW())", con)
                cmd.Parameters.Add(New MySqlParameter("ub", username.Text))
                cmd.Parameters.Add(New MySqlParameter("md", "Login"))
                cmd.Parameters.Add(New MySqlParameter("ut", ""))
                cmd.ExecuteNonQuery()
                cmd = New MySqlCommand("SELECT *  FROM users WHERE username = @un AND password = @pw", con)
                cmd.Parameters.Add(New MySqlParameter("un", username.Text))
                cmd.Parameters.Add(New MySqlParameter("pw", password.Text))
                dr = cmd.ExecuteReader
                If dr.Read Then
                    logname = username.Text
                    Splash.Show()
                    Me.Hide()

                Else
                    MsgBox("Incorrect Username or Password!", MsgBoxStyle.Exclamation, "Cook Eat System")
                    username.Clear()
                    password.Clear()
                End If
                disconnect()
            Else
                MsgBox("Check Database Settings!")
                username.Clear()
                password.Clear()
            End If
        End If
    End Sub
    '================================================================================================================
    '================================================================================================================
End Class
