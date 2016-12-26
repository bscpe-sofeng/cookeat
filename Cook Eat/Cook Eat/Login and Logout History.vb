Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class LLH
    Private Sub LLH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub LoadTable()
        Connect()
        da = New MySqlDataAdapter("SELECT id As `ID`, userby AS `User`, made AS `Status`, dtime As `Time` from dlog WHERE userby LIKE @search", con)
        cmd = da.SelectCommand
        cmd.Parameters.Add(New MySqlParameter("search", "%" & TextBox1.Text & "%"))
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        disconnect()
    End Sub

    Private Sub search()
        LoadTable()
        If DataGridView1.SelectedRows.Count > 0 Then
            LoadTable()
        Else
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        search()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            search()
        End If
    End Sub
End Class