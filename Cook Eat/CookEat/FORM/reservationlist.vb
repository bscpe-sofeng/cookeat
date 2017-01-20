Imports MySql.Data.MySqlClient
Public Class reservationlist
    Private Sub reservationlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox3.Show()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        LoadTable()
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Hide()
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox3.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Admin.Opacity = 1
        Me.Close()
    End Sub


    Private Sub LoadTable()
        Connect()
        da = New MySqlDataAdapter("SELECT rno As `Reservation Number`, cname AS `Customer Name`, cno AS `Contact Number`, day As `Day`, time As `Time`, note As 'Note' from res where status ='pending' ", con)
        cmd = da.SelectCommand
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        disconnect()
    End Sub
End Class