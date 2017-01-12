Imports System
Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient
Module SQLconnector
    Friend host As String = ""
    Friend user As String = ""
    Friend password As String = ""
    Dim trial As Integer = 10
    Friend con As New MySqlConnection()
    Friend cmd As New MySqlCommand
    Friend dr As MySqlDataReader
    Friend da As New MySqlDataAdapter
    Friend logname As String
    Friend rname As String
    Friend Sub Connect()
        Try
            disconnect()
            con.Open()
            trial = 10
        Catch ex As Exception
            If trial > 0 Then
                trial -= 1
                host = ReadSettings("host")
                user = ReadSettings("user")
                password = ReadSettings("password")
                con = New MySqlConnection("Server=" & host & ";user=" & user & ";password=" & password & ";database=cookeat")
                Connect()
            Else
                MsgBox("cannot establish connection")
                Environment.Exit(0)
            End If
        End Try
    End Sub

    Friend Sub disconnect()
        If con.State = ConnectionState.Open Then con.Close()
    End Sub

    Public Function ConnectionTest(host As String, user As String, password As String) As Boolean
        Dim canConnect As Boolean = False
        Try
            Dim testCon As New MySqlConnection("server=" & host & ";user=" & user & ";password=" & password)
            testCon.Open()
            canConnect = True
        Catch ex As Exception
            canConnect = False
        End Try
        Return canConnect
    End Function


    Private appData As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "CookEat")
    Friend Function WriteSettings(setting As String, text As String) As Boolean
        Try
            Using writer As New StreamWriter(appData & "/" & setting & ".setting")
                writer.Write(text)
            End Using

        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Friend Function ReadSettings(setting As String) As String
        Dim strSetting As String = ""
        Try
            Using reader As New StreamReader(appData & "/" & setting & ".setting")
                strSetting = reader.ReadLine
            End Using
        Catch ex As Exception
            Return ""
        End Try
        Return strSetting
    End Function

End Module
