Imports System
Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient
Module SQLconnector

    Dim trial As Integer = 10
    Friend con1 As New MySqlConnection()
    Friend cmd1 As New MySqlCommand
    Friend dr1 As MySqlDataReader
    Friend Function _func(bln As Boolean) As Boolean
        Return bln
    End Function

    Friend Sub Connect1()
        Try
            disconnect1()
            con1.Open()
            trial = 10
        Catch ex As Exception
            If trial > 0 Then
                trial -= 1
                host = ReadSettings("host")
                user = ReadSettings("user")
                password = ReadSettings("password")
                con1 = New MySqlConnection("Server=" & host & ";user=" & user & ";password=" & password & ";database=cookeat")
                Connect1()
            Else
                MsgBox("cannot establish connection")
                Environment.Exit(0)
            End If
        End Try
    End Sub

    Friend Sub disconnect1()
        If con1.State = ConnectionState.Open Then con1.Close()
    End Sub





End Module
