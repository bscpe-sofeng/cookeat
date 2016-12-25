Imports MySql.Data.MySqlClient
Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Connect()
        cmd = New MySqlCommand("INSERT INTO users VALUES (NULL, @fn, @ln,@cn,@post, @us, @p, NOW())", con)
        cmd.Parameters.Add(New MySqlParameter("fn", TextBox1.Text))
        cmd.Parameters.Add(New MySqlParameter("ln", TextBox2.Text))
        cmd.Parameters.Add(New MySqlParameter("cn", TextBox3.Text))
        cmd.Parameters.Add(New MySqlParameter("post", ComboBox1.Text))
        cmd.Parameters.Add(New MySqlParameter("us", TextBox4.Text))
        cmd.Parameters.Add(New MySqlParameter("p", TextBox5.Text))
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

End Class