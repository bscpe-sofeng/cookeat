Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Private Sub Admin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Are you sure want to exit now?", "Cook Eat System", MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LoadTable()
        Connect()
        da = New MySqlDataAdapter("SELECT no, fname AS `First Name`, lname AS `Last Name`, cno As `Contact No`, pos AS `Position`, username AS `Username`, password `Password`,time AS `Date Created` from users WHERE fname LIKE @search OR lname LIKE @search OR username LIKE @search", con)
        cmd = da.SelectCommand
        cmd.Parameters.Add(New MySqlParameter("search", "%" & TextBox1.Text & "%"))
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        disconnect()
        DataGridView1.Columns("no").Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            LoadTable()
        Else
            MsgBox("Not Found")
        End If
    End Sub
    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If DataGridView1.SelectedRows.Count > 0 Then

            With DataGridView1.SelectedRows(0)
                TextBox5.Text = .Cells("no").Value
                TextBox2.Text = .Cells("First Name").Value
                TextBox3.Text = .Cells("Last Name").Value
                TextBox4.Text = .Cells("Contact No").Value
                ComboBox1.Text = .Cells("Position").Value
                TextBox7.Text = .Cells("Username").Value
                TextBox6.Text = .Cells("Password").Value
            End With

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Connect()
            cmd = New MySqlCommand("UPDATE users SET fname = @fn, lname = @ln, cno = @cn, pos = @post, username = @us, password = @p WHERE no = @id", con)
            cmd.Parameters.Add(New MySqlParameter("fn", TextBox2.Text))
            cmd.Parameters.Add(New MySqlParameter("ln", TextBox3.Text))
            cmd.Parameters.Add(New MySqlParameter("cn", TextBox4.Text))
            cmd.Parameters.Add(New MySqlParameter("post", ComboBox1.Text))
            cmd.Parameters.Add(New MySqlParameter("us", TextBox7.Text))
            cmd.Parameters.Add(New MySqlParameter("p", TextBox6.Text))
            cmd.Parameters.Add(New MySqlParameter("id", DataGridView1.SelectedRows(0).Cells("no").Value))
            cmd.ExecuteNonQuery()
            disconnect()
            LoadTable()

        Else
            MsgBox("Not Found")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Connect()
            cmd = New MySqlCommand("DELETE FROM users WHERE no = @id", con)
            cmd.Parameters.Add(New MySqlParameter("id", DataGridView1.SelectedRows(0).Cells("no").Value))
            cmd.ExecuteNonQuery()
            disconnect()
            LoadTable()

        Else
            MsgBox("Not Found")

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Register.ShowDialog()
        LoadTable()
    End Sub
End Class