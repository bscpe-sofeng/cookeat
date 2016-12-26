Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        Timer1.Start()
        Label8.Text = logname
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub Admin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Are you sure want to exit now?", "Cook Eat System", MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            Connect()
            cmd = New MySqlCommand("INSERT INTO dlog VALUES (NULL, @ub, @md,@ut,NOW())", con)
            cmd.Parameters.Add(New MySqlParameter("ub", Label8.Text))
            cmd.Parameters.Add(New MySqlParameter("md", "Logout"))
            cmd.Parameters.Add(New MySqlParameter("ut", ""))
            cmd.ExecuteNonQuery()
            disconnect()
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
        DataGridView1.Columns("password").Visible = False
    End Sub

    Private Sub search()
        LoadTable()
        If DataGridView1.SelectedRows.Count > 0 Then
            LoadTable()
        Else
            MsgBox("Search Not Found!")
        End If
    End Sub

    Private Sub clearTB()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        search()
    End Sub
    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If DataGridView1.SelectedRows.Count > 0 Then
            With DataGridView1.SelectedRows(0)
                CheckBox1.CheckState = CheckState.Unchecked
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
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Account list is Empty", MsgBoxStyle.Information, "Cook Eat System")
        Else
            If TextBox5.Text = "" Then
                MsgBox("Select User Account", MsgBoxStyle.Exclamation, "Cook Eat System")
            Else
                If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
                    MsgBox("Complete Field Required", MsgBoxStyle.Exclamation, "Cook Eat System")
                Else
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
                        MsgBox("Account Updated", MsgBoxStyle.Information, "Cook Eat System")
                        clearTB()
                    Else
                        MsgBox("Not Found")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Account list is Empty", MsgBoxStyle.Information, "Cook Eat System")
        Else
            If TextBox5.Text = "" Then
                MsgBox("Select User Account", MsgBoxStyle.Exclamation, "Cook Eat System")
            Else
                If MsgBox("Delete Username Account: " & TextBox7.Text, MsgBoxStyle.YesNo, "Cook Eat System") = MsgBoxResult.Yes Then
                    If DataGridView1.SelectedRows.Count > 0 Then
                        Connect()
                        cmd = New MySqlCommand("DELETE FROM users WHERE no = @id", con)
                        cmd.Parameters.Add(New MySqlParameter("id", DataGridView1.SelectedRows(0).Cells("no").Value))
                        cmd.ExecuteNonQuery()
                        disconnect()
                        LoadTable()
                        clearTB()
                    Else
                        MsgBox("Not Found")
                    End If
                Else
                End If

            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Register.ShowDialog()
        LoadTable()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox6.PasswordChar = ControlChars.NullChar
        Else
            TextBox6.PasswordChar = "*"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            search()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only", "Cook Eat System")
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        PictureBox5.Hide()
        PictureBox6.Show()
    End Sub

    Private Sub GroupBox6_MouseLeave(sender As Object, e As EventArgs) Handles GroupBox6.MouseLeave
        PictureBox6.Hide()
        PictureBox5.Show()
    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        LLH.ShowDialog()
        PictureBox6.Hide()
        PictureBox5.Show()
    End Sub


End Class