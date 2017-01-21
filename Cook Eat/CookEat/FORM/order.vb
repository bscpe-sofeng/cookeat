
Imports MySql.Data.MySqlClient
Imports Frost_Controls
Public Class order
    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        cmd = New MySqlCommand("select DISTINCT(category) AS catg from menu", con)
        dr = cmd.ExecuteReader
        While dr.Read
            Frost_ComboBox1.Items.Add(dr("catg"))
        End While
        disconnect()


        LoadTable()
    End Sub

    Private Sub LoadTable()
        Connect()
        da = New MySqlDataAdapter("SELECT id, itemcode AS `Item Code`, itemname AS `Item Name`, category As `Category`, price AS `Price`, color from menu WHERE itemname LIKE @search OR itemcode LIKE @search", con)
        cmd = da.SelectCommand
        cmd.Parameters.Add(New MySqlParameter("search", "%" & Frost_TextField3.Text & "%"))
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        da.Fill(dt)
        Frost_DataGridView1.DataSource = dt
        disconnect()
        Frost_DataGridView1.Columns("id").Visible = False

        For Each dtgvrow As DataGridViewRow In Frost_DataGridView1.Rows
            Dim edit As DataGridViewCell = dtgvrow.Cells(0)
            edit.Value = "Edit"

            Dim delete As DataGridViewCell = dtgvrow.Cells(1)
            delete.Value = "delete"

            dtgvrow.DefaultCellStyle.BackColor = Color.FromArgb(dtgvrow.Cells("color").Value)
            dtgvrow.DefaultCellStyle.SelectionBackColor = Color.White
            dtgvrow.DefaultCellStyle.SelectionForeColor = Color.Black
        Next

    End Sub

    Private Sub Frost_Label1_Click(sender As Object, e As EventArgs) Handles Frost_Label1.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Frost_Label1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Frost_Button1_Click(sender As Object, e As EventArgs) Handles Frost_Button1.Click
        If Frost_TextField1.Text = "" Or Frost_TextField2.Text = "" Or Frost_TextField4.Text = "" Or Frost_ComboBox1.Text = "" Then
            MsgBox("Complete Information Required!", MsgBoxStyle.Exclamation, "Cook Eat System")
        Else

            Connect()
            cmd = New MySqlCommand("SELECT *  FROM menu WHERE itemcode = @un", con)
            cmd.Parameters.Add(New MySqlParameter("un", Frost_TextField1.Text))
            dr = cmd.ExecuteReader
                If dr.Read Then
                MsgBox("Item Code Already Exist!", MsgBoxStyle.Exclamation, "Cook Eat System")

            Else
                    Connect()
                cmd = New MySqlCommand("INSERT INTO menu VALUES (NULL, @ic, @it,@cat,@pr, @clr)", con)
                cmd.Parameters.Add(New MySqlParameter("ic", Frost_TextField1.Text))
                cmd.Parameters.Add(New MySqlParameter("it", Frost_TextField2.Text))
                cmd.Parameters.Add(New MySqlParameter("cat", Frost_ComboBox1.Text))
                cmd.Parameters.Add(New MySqlParameter("pr", Frost_TextField4.Text))
                cmd.Parameters.Add(New MySqlParameter("clr", Frost_Label1.BackColor.ToArgb))


                cmd.ExecuteNonQuery()
                    disconnect()
                MsgBox("Menu Succefuly Added!", MsgBoxStyle.Exclamation, "Cook Eat System")

                Frost_TextField1.Clear()
                Frost_TextField2.Clear()
                Frost_TextField3.Clear()
                Frost_ComboBox1.SelectedIndex = -1
                LoadTable()
            End If



        End If

    End Sub

    Private Sub Frost_DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Frost_DataGridView1.CellClick
        If e.ColumnIndex = 0 Then
            Dim dtgr As DataGridViewRow = Frost_DataGridView1.SelectedRows(0)
            Frost_TextField1.Text = dtgr.Cells("Item Code").Value

        ElseIf e.ColumnIndex = 1 Then
            Dim dtgr As DataGridViewRow = Frost_DataGridView1.SelectedRows(0)
            Frost_TextField2.Text = dtgr.Cells("Item Name").Value
        End If
    End Sub

End Class