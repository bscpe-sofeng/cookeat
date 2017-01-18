Imports MySql.Data.MySqlClient
Public Class ireservation
    Private Sub ireservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = rname
        PictureBox3.Show()
        Dim dte As New DateTime(2011, 11, 11, 0, 0, 0)
        Connect()
        cmd = New MySqlCommand("select * from res where rno = @id", con)
        cmd.Parameters.Add(New MySqlParameter("id", Label1.Text))
        dr = cmd.ExecuteReader
        If dr.Read Then
            Label2.Text = (dr("cname"))
            Label3.Text = (dr("cno"))
            Label4.Text = (dr("day"))
            Label5.Text = New DateTime(2011, 11, 11, 0, 0, 0).Add(CType(dr("time"), TimeSpan)).ToString("HH:mm")
            Label6.Text = (dr("rtable"))
            Label7.Text = (dr("note"))
            Label8.Text = (dr("torder"))
        End If
        disconnect()
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Hide()
        PictureBox4.Show()
    End Sub

    Private Sub PictureBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick
        Me.Close()
        Admin.Show()
        Admin.Opacity = 1
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Hide()
        PictureBox3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Cancel Reservation: " & Label2.Text, MsgBoxStyle.YesNo, "Cook Eat System") = MsgBoxResult.Yes Then
            Connect()
            cmd = New MySqlCommand("UPDATE res SET status  = @stat  WHERE rno = @id", con)
            cmd.Parameters.Add(New MySqlParameter("id", Label1.Text))
            cmd.Parameters.Add(New MySqlParameter("stat", "Cancel"))
            cmd.ExecuteNonQuery()
            disconnect()
            Me.Close()
            Admin.Show()
            Admin.Opacity = 1
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Reservation Done: " & Label2.Text, MsgBoxStyle.YesNo, "Cook Eat System") = MsgBoxResult.Yes Then
            Connect()
            cmd = New MySqlCommand("UPDATE res SET status  = @stat  WHERE rno = @id", con)
            cmd.Parameters.Add(New MySqlParameter("id", Label1.Text))
            cmd.Parameters.Add(New MySqlParameter("stat", "Done"))
            cmd.ExecuteNonQuery()
            disconnect()
            Me.Close()
            Admin.Show()
            Admin.Opacity = 1
        End If
    End Sub
End Class