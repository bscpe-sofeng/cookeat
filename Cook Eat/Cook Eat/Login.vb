Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Width = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Quit.Click
        If MsgBox("Are you sure want to exit now?", MsgBoxStyle.YesNo, "Cook Eat System") = MsgBoxResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            login()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Width = PictureBox1.Width + 4
        If PictureBox1.Width >= 190 Then
            If username.Text = "" Or password.Text = "" Then
                MsgBox("Username and Password Required!", MsgBoxStyle.Exclamation, "Cook Eat System")
                username.Clear()
                password.Clear()
            Else
                Connect()
                cmd = New MySqlCommand("SELECT *  FROM users WHERE username = @un AND password = @pw", con)
                cmd.Parameters.Add(New MySqlParameter("un", username.Text))
                cmd.Parameters.Add(New MySqlParameter("pw", password.Text))
                dr = cmd.ExecuteReader
                If dr.Read Then
                    If dr("pos") = "Admin" Then
                        Me.Hide()
                        Admin.Show()
                    ElseIf dr("pos") = "Kitchen" Then
                        MsgBox("Kitchen")
                    ElseIf dr("pos") = "Cashier" Then
                        MsgBox("Cashier")
                    End If
                Else
                    MsgBox("Incorrect Username or Password!", MsgBoxStyle.Exclamation, "Cook Eat System")
                    username.Clear()
                    password.Clear()
                End If
                Timer1.Stop()
                disconnect()
            End If
        End If
    End Sub
    Private Sub login()
        If username.Text = "" Or password.Text = "" Then
            MsgBox("Username and Password Required!", MsgBoxStyle.Exclamation, "Cook Eat System")
            username.Clear()
            password.Clear()
        Else
            Connect()
            cmd = New MySqlCommand("SELECT *  FROM users WHERE username = @un AND password = @pw", con)
            cmd.Parameters.Add(New MySqlParameter("un", username.Text))
            cmd.Parameters.Add(New MySqlParameter("pw", password.Text))
            dr = cmd.ExecuteReader
            If dr.Read Then
                Timer1.Start()
            Else
                MsgBox("Incorrect Username or Password!", MsgBoxStyle.Exclamation, "Cook Eat System")
                username.Clear()
                password.Clear()
            End If
            disconnect()
        End If
    End Sub

End Class
