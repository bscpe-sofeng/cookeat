Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Complete Information Required!", MsgBoxStyle.Exclamation, "Cook Eat System")
        Else
            If TextBox5.Text = TextBox6.Text Then
                Connect()
                cmd = New MySqlCommand("SELECT *  FROM users WHERE username = @un", con)
                cmd.Parameters.Add(New MySqlParameter("un", TextBox4.Text))
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MsgBox("Username Already Exist!", MsgBoxStyle.Exclamation, "Cook Eat System")
                Else
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
                    MsgBox("Account Succefuly Added!", MsgBoxStyle.Exclamation, "Cook Eat System")
                    Me.Close()
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    TextBox5.Clear()
                    TextBox6.Clear()
                End If
            Else
                MsgBox("Password did not match!", MsgBoxStyle.Exclamation, "Cook Eat System")
                TextBox5.Clear()
                TextBox6.Clear()
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only", "Cook Eat System")
            e.Handled = True
        End If
    End Sub


End Class