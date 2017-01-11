Imports System
Imports System.IO
Imports System.Text

Public Class SQLsettings
    Private Sub SQLsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Hide()
        TextBox1.Text = ReadSettings("host")
        TextBox2.Text = ReadSettings("user")
        TextBox3.Text = ReadSettings("password")
    End Sub


    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Hide()
        PictureBox2.Show()
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox1.Show()
        PictureBox2.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        LoginForm.Show()
        LoginForm.Opacity = 1
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WriteSettings("host", TextBox1.Text)
        WriteSettings("user", TextBox2.Text)
        WriteSettings("password", TextBox3.Text)
        If ConnectionTest(ReadSettings("host"), ReadSettings("user"), ReadSettings("password")) Then
            MsgBox("Connection Success!")
        Else
            MsgBox("Connection Failed")
        End If
    End Sub



End Class