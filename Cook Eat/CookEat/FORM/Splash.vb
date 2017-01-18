Imports MySql.Data.MySqlClient
Public Class Splash
    Dim i As Integer
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Connect()
        cmd = New MySqlCommand("SELECT *  FROM users WHERE username = @un", con)
        cmd.Parameters.Add(New MySqlParameter("un", logname))
        dr = cmd.ExecuteReader
        If dr.Read Then
            Label1.Text = (dr("fname") & " " & dr("lname"))
        End If
        disconnect()
    End Sub
    '=============================== Entering Form =========================================
    '=======================================================================================
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox2.Visible = True Then
            PictureBox2.Hide()
            PictureBox3.Show()
        Else
            PictureBox3.Hide()
            PictureBox2.Show()
        End If
        i += 1
        If i = 4 Then
            Connect()
            cmd = New MySqlCommand("SELECT *  FROM users WHERE username = @un", con)
            cmd.Parameters.Add(New MySqlParameter("un", logname))
            dr = cmd.ExecuteReader
            If dr.Read Then
                logname = dr("username")
                Label1.Text = (dr("fname") & " " & dr("lname"))
                If dr("pos") = "Admin" Then
                    Me.Hide()
                    Admin.Show()
                    'MsgBox("Admin")
                ElseIf dr("pos") = "Kitchen" Then
                    'MsgBox("Kitchen")
                ElseIf dr("pos") = "Cashier" Then
                    pos = "cashier"
                    Me.Hide()
                    Admin.Show()
                End If
            End If
            disconnect()
            Timer1.Stop()
        End If
    End Sub
End Class