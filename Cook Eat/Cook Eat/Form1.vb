Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Quit.Click
        If MsgBox("Are you sure want to exit now?", MsgBoxStyle.YesNo, "Cook Eat System") = MsgBoxResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Connect()
        cmd = New MySqlCommand("SELECT *  FROM users WHERE username = @un AND password = @pw", con)
        cmd.Parameters.Add(New MySqlParameter("un", TextBox1.Text))
        cmd.Parameters.Add(New MySqlParameter("pw", TextBox2.Text))
        dr = cmd.ExecuteReader
        If dr.Read Then
            MsgBox("welcome " & dr("username"))
        Else
            MsgBox("mali password mo")
        End If
        disconnect()
    End Sub


End Class
