Imports MySql.Data.MySqlClient
Module Module1



    Friend con As New MySqlConnection("server=localhost;user=root;password=nolsaranghe9;database=cookeat")
    Friend cmd As New MySqlCommand
    Friend dr As MySqlDataReader
    Friend da As New MySqlDataAdapter


    Friend Sub Connect()
        Try
            disconnect()
            con.Open()
            trial = 10
        Catch ex As Exception
            If trial > 0 Then
                trial += 1
                con = New mysqlconnection("server--tuloy mo nalang")
                Connect()
            Else
                MsgBox("cannot establish connection")
                Environment.Exit(0)
            End If
        End Try
    End Sub

    Dim trial As Integer = 10

    Friend Sub disconnect()
        If con.state = ConnectionState.Open Then con.close()
    End Sub


End Module
