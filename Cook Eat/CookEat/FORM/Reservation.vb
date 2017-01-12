Imports MySql.Data.MySqlClient
Public Class Reservation
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox3.Show()
        Label19.Text = logname
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Hide()
        PictureBox4.Show()
    End Sub

    Private Sub PictureBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick
        If MessageBox.Show("Cancel Reservation?", "Cook Eat System", MessageBoxButtons.YesNo) = DialogResult.No Then
        Else
            Me.Close()
            Admin.Opacity = 1
        End If
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Hide()
        PictureBox3.Show()
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only", "Cook Eat System")
            e.Handled = True
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If DateTimePicker1.Value < Date.Today Then
            MsgBox("Selected Date invalid!", MsgBoxStyle.Exclamation, "Cook Eat System")
        Else
            If MessageBox.Show(TextBox8.Text & vbCrLf & TextBox9.Text & vbCrLf & DateTimePicker1.Text & vbCrLf & ComboBox2.Text & ":" & ComboBox3.Text & vbCrLf & TextBox10.Text & vbCrLf & RichTextBox1.Text & vbCrLf & " " & vbCrLf & "Save Reservation?", "Cook Eat System", MessageBoxButtons.YesNo) = DialogResult.No Then
            Else
                Connect()
                cmd = New MySqlCommand("INSERT INTO res VALUES (NULL, @cnm, @cn,@day,@time, @rt, @nt, @torder,@stat)", con)
                cmd.Parameters.Add(New MySqlParameter("cnm", TextBox8.Text))
                cmd.Parameters.Add(New MySqlParameter("cn", TextBox9.Text))
                cmd.Parameters.Add(New MySqlParameter("day", DateTimePicker1.Value))
                cmd.Parameters.Add(New MySqlParameter("time", (ComboBox2.Text & ":" & ComboBox3.Text)))
                cmd.Parameters.Add(New MySqlParameter("rt", TextBox10.Text))
                cmd.Parameters.Add(New MySqlParameter("nt", RichTextBox1.Text))
                cmd.Parameters.Add(New MySqlParameter("torder", Label19.Text))
                cmd.Parameters.Add(New MySqlParameter("stat", "pending"))
                cmd.ExecuteNonQuery()
                disconnect()
                MsgBox("Reservation Succefuly Added!", MsgBoxStyle.Exclamation, "Cook Eat System")
                TextBox8.Clear()
                TextBox9.Clear()
                DateTimePicker1.Value = Now()
                TextBox10.Clear()
                RichTextBox1.Clear()
                Me.Close()
                Admin.Opacity = 1
            End If
        End If
    End Sub
End Class