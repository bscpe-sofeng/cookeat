Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class loghistory
    Private Sub loghistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        PictureBox3.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.Rows.Count > 0 Then
            Dim wapp As Microsoft.Office.Interop.Excel.Application
            Dim wsheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim wbook As Microsoft.Office.Interop.Excel.Workbook
            Dim chartRange As Microsoft.Office.Interop.Excel.Range
            wapp = New Microsoft.Office.Interop.Excel.Application
            wapp.Visible = True
            wbook = wapp.Workbooks.Add()
            wsheet = wbook.ActiveSheet
            Dim iX As Integer
            Dim iY As Integer
            Dim iC As Integer
            For iC = 0 To DataGridView1.Columns.Count - 1
                wsheet.Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                wsheet.Cells(1, iC + 1).font.bold = True
            Next
            For iX = 0 To DataGridView1.Rows.Count - 1
                For iY = 0 To DataGridView1.Columns.Count - 1
                    wsheet.Cells(iX + 2, iY + 1).value = DataGridView1(iY, iX).Value.ToString
                Next
            Next
            wsheet.Columns.AutoFit()
            If MsgBox("Clear History?", MsgBoxStyle.YesNo, "Cook Eat System") = MsgBoxResult.Yes Then
                Connect()
                cmd = New MySqlCommand("TRUNCATE TABLE  dlog;", con)
                cmd.ExecuteNonQuery()
                disconnect()
                LoadTable()
            End If
        Else
            MsgBox("History is Empty!", MsgBoxStyle.Information, "Cook Eat System")
        End If
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
End Class