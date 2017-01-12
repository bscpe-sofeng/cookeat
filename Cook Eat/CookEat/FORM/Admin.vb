Imports MySql.Data.MySqlClient
Public Class Admin
    Dim Menu As Boolean = False
    Dim MenuB As Boolean = False
    Dim x, y As Integer
    Dim Newpoint As New Point
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label1.Text = logname
        Timer1.Start()
        Timer2.Start()
        LoadTable()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        Label17.Text = currentDate.ToString("MMMM, yyyy")
        LoadCalendar(currentDate)
    End Sub
    '============================================ Design and Layout ================================================================
    '===============================================================================================================================
    Private Sub Admin_MouseDown_1(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        x = Control.MousePosition.Y - Me.Location.Y
        Me.Opacity = 0.8
    End Sub
    Private Sub Admin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Newpoint = Control.MousePosition
            Newpoint.X -= x
            Newpoint.Y -= y
            Me.Location = Newpoint
            Application.DoEvents()
        End If
    End Sub
    Private Sub Admin_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Me.Opacity = 1
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
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Hide()
        PictureBox4.Show()
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox3.Show()
        PictureBox4.Hide()
    End Sub
    Private Sub PictureBox7_MouseHover(sender As Object, e As EventArgs) Handles PictureBox7.MouseHover
        PictureBox7.Hide()
        PictureBox8.Show()
    End Sub
    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        PictureBox7.Show()
        PictureBox8.Hide()
    End Sub
    Private Sub PictureBox8_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseClick
        Me.Refresh()
        If Not Menu Then
            Do Until Me.Width = 1100
                Me.Width += 20
                System.Threading.Thread.Sleep(1)
            Loop
            Menu = True
        Else
            Do Until Me.Width = 200
                Me.Width -= 4
                System.Threading.Thread.Sleep(1)
            Loop
            Menu = False
        End If
        If Me.Width = 1100 Then
            Do Until Panel1.Height = 375
                Panel1.Height += 5
                System.Threading.Thread.Sleep(1)
            Loop
            MenuB = True
        Else
            Do Until Panel1.Height = 10
                Panel1.Height -= 5
                System.Threading.Thread.Sleep(1)
            Loop
            MenuB = False
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.Now.ToString("h:mm:ss tt")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage2
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabPage3
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabPage4
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectedTab = TabPage5
    End Sub



    '=============================================== Exit ========================================================================
    '==============================================================================================================================
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MessageBox.Show("Are you sure want to exit now?", "Cook Eat System", MessageBoxButtons.YesNo) = DialogResult.No Then
        Else
            logout()
            Me.Close()
        End If
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If MessageBox.Show("Are you sure want to exit now?", "Cook Eat System", MessageBoxButtons.YesNo) = DialogResult.No Then
        Else
            logout()
            Me.Close()
        End If
    End Sub
    Private Sub logout()
        Connect()
        cmd = New MySqlCommand("INSERT INTO dlog VALUES (NULL, @ub, @md,@ut,NOW())", con)
        cmd.Parameters.Add(New MySqlParameter("ub", Label1.Text))
        cmd.Parameters.Add(New MySqlParameter("md", "Logout"))
        cmd.Parameters.Add(New MySqlParameter("ut", ""))
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

    '==============================================================================================================================
    '==============================================================================================================================




    '============================================User Account Panel ================================================================
    '===============================================================================================================================
    Private Sub LoadTable()
        Connect()
        da = New MySqlDataAdapter("SELECT no, fname AS `First Name`, lname AS `Last Name`, cno As `Contact No`, pos AS `Position`, username AS `Username`, password `Password`,time AS `Date Created` from users WHERE fname LIKE @search OR lname LIKE @search OR username LIKE @search", con)
        cmd = da.SelectCommand
        cmd.Parameters.Add(New MySqlParameter("search", "%" & TextBox1.Text & "%"))
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        disconnect()
        DataGridView1.Columns("no").Visible = False
        DataGridView1.Columns("password").Visible = False
    End Sub
    Private Sub search()
        LoadTable()
        If DataGridView1.SelectedRows.Count > 0 Then
            LoadTable()
        Else
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            search()
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Account list is Empty", MsgBoxStyle.Information, "Cook Eat System")
        Else
            If TextBox5.Text = "" Then
                MsgBox("Select user account!", MsgBoxStyle.Exclamation, "Cook Eat System")
            Else
                If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
                    MsgBox("Complete Field Required", MsgBoxStyle.Exclamation, "Cook Eat System")
                Else
                    If DataGridView1.SelectedRows.Count > 0 Then
                        Connect()
                        cmd = New MySqlCommand("UPDATE users SET fname = @fn, lname = @ln, cno = @cn, pos = @post, username = @us, password = @p WHERE no = @id", con)
                        cmd.Parameters.Add(New MySqlParameter("fn", TextBox2.Text))
                        cmd.Parameters.Add(New MySqlParameter("ln", TextBox3.Text))
                        cmd.Parameters.Add(New MySqlParameter("cn", TextBox4.Text))
                        cmd.Parameters.Add(New MySqlParameter("post", ComboBox1.Text))
                        cmd.Parameters.Add(New MySqlParameter("us", TextBox7.Text))
                        cmd.Parameters.Add(New MySqlParameter("p", TextBox6.Text))
                        cmd.Parameters.Add(New MySqlParameter("id", DataGridView1.SelectedRows(0).Cells("no").Value))
                        cmd.ExecuteNonQuery()
                        disconnect()
                        LoadTable()
                        MsgBox("Account Updated", MsgBoxStyle.Information, "Cook Eat System")
                        clearTB()
                    Else
                        MsgBox("Not Found")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        search()
    End Sub
    Private Sub clearTB()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox5.Clear()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox6.PasswordChar = ControlChars.NullChar
        Else
            TextBox6.PasswordChar = "*"
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Account list is Empty", MsgBoxStyle.Information, "Cook Eat System")
        Else
            If TextBox5.Text = "" Then
                MsgBox("Select User Account", MsgBoxStyle.Exclamation, "Cook Eat System")
            Else
                If MsgBox("Delete Account: " & TextBox7.Text, MsgBoxStyle.YesNo, "Cook Eat System") = MsgBoxResult.Yes Then
                    If DataGridView1.SelectedRows.Count > 0 Then
                        Connect()
                        cmd = New MySqlCommand("DELETE FROM users WHERE no = @id", con)
                        cmd.Parameters.Add(New MySqlParameter("id", DataGridView1.SelectedRows(0).Cells("no").Value))
                        cmd.ExecuteNonQuery()
                        disconnect()
                        LoadTable()
                        clearTB()
                    Else
                        MsgBox("Not Found")
                    End If
                Else
                End If

            End If
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox8.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox9.Text = "" Or TextBox13.Text = "" Or TextBox12.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Complete Information Required!", MsgBoxStyle.Exclamation, "Cook Eat System")
        Else
            If TextBox12.Text = TextBox9.Text Then
                Connect()
                cmd = New MySqlCommand("SELECT *  FROM users WHERE username = @un", con)
                cmd.Parameters.Add(New MySqlParameter("un", TextBox13.Text))
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MsgBox("Username Already Exist!", MsgBoxStyle.Exclamation, "Cook Eat System")
                    TextBox13.Clear()
                    TextBox12.Clear()
                    TextBox9.Clear()
                Else
                    Connect()
                    cmd = New MySqlCommand("INSERT INTO users VALUES (NULL, @fn, @ln,@cn,@post, @us, @p, NOW())", con)
                    cmd.Parameters.Add(New MySqlParameter("fn", TextBox8.Text))
                    cmd.Parameters.Add(New MySqlParameter("ln", TextBox10.Text))
                    cmd.Parameters.Add(New MySqlParameter("cn", TextBox11.Text))
                    cmd.Parameters.Add(New MySqlParameter("post", ComboBox2.Text))
                    cmd.Parameters.Add(New MySqlParameter("us", TextBox13.Text))
                    cmd.Parameters.Add(New MySqlParameter("p", TextBox12.Text))
                    cmd.ExecuteNonQuery()
                    disconnect()
                    MsgBox("Account Succefuly Added!", MsgBoxStyle.Exclamation, "Cook Eat System")
                    TextBox8.Clear()
                    TextBox10.Clear()
                    TextBox11.Clear()
                    TextBox13.Clear()
                    TextBox12.Clear()
                    TextBox9.Clear()
                    LoadTable()
                End If
            Else
                MsgBox("Password did not match!", MsgBoxStyle.Exclamation, "Cook Eat System")
                TextBox12.Clear()
                TextBox9.Clear()
            End If
        End If
    End Sub
    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If DataGridView1.SelectedRows.Count > 0 Then
            With DataGridView1.SelectedRows(0)
                CheckBox1.CheckState = CheckState.Unchecked
                TextBox5.Text = .Cells("no").Value
                TextBox2.Text = .Cells("First Name").Value
                TextBox3.Text = .Cells("Last Name").Value
                TextBox4.Text = .Cells("Contact No").Value
                ComboBox1.Text = .Cells("Position").Value
                TextBox7.Text = .Cells("Username").Value
                TextBox6.Text = .Cells("Password").Value
            End With
        End If
    End Sub

    '==============================================================================================================================
    '==============================================================================================================================



    '============================================Reservation ================================================================
    '===============================================================================================================================
    Private _item As New List(Of Calendar.CalendarItem)
    Private currentDate As DateTime = Now
    Private Sub LoadCalendar(dte As DateTime)
        Dim currentDay As DayOfWeek = dte.DayOfWeek
        Dim firstSunday As DateTime = dte.AddDays(-CInt(currentDay))
        Calendar1.SetViewRange(firstSunday, firstSunday.AddDays(6))
        Calendar1.Items.Clear()
        _item = New List(Of Calendar.CalendarItem)
        Connect()
        cmd = New MySqlCommand("SELECT * FROM res WHERE  `status`= @stat AND (`day` BETWEEN @start AND @end)", con)
        cmd.Parameters.Add(New MySqlParameter("start", firstSunday))
        cmd.Parameters.Add(New MySqlParameter("end", firstSunday.AddDays(6)))
        cmd.Parameters.Add(New MySqlParameter("stat", "pending"))
        dr = cmd.ExecuteReader
        While dr.Read
            Dim start As Date = CDate(dr("day")).Add(dr("time"))
            Dim dteend As Date = start.AddMinutes(30)
            Dim casl As New Calendar.CalendarItem(Calendar1, start, dteend, dr("cname"))
            casl.Tag = dr("rno")
            _item.Add(casl)
        End While
        disconnect()
        Calendar1.Reload()
    End Sub

    Private Sub Calendar1_LoadItems(sender As Object, e As Calendar.CalendarLoadEventArgs) Handles Calendar1.LoadItems
        For Each dcal As Calendar.CalendarItem In _item
            Calendar1.Items.Add(dcal)
        Next
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        currentDate = currentDate.AddDays(-7)
        LoadCalendar(currentDate)
        Label17.Text = currentDate.ToString("MMMM, yyyy")
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        currentDate = currentDate.AddDays(7)
        LoadCalendar(currentDate)
        Label17.Text = currentDate.ToString("MMMM, yyyy")
    End Sub
    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        LoadCalendar(Date.Now())
        Label17.Text = Date.Now.ToString("MMMM, yyyy")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Opacity = 0.7
        Reservation.ShowDialog()
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only", "Cook Eat System")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only", "Cook Eat System")
            e.Handled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LoadCalendar(currentDate)
        Calendar1.Reload()
    End Sub

    Private Sub Calendar1_ItemSelected(sender As Object, e As Calendar.CalendarItemEventArgs) Handles Calendar1.ItemSelected
        Connect()
        cmd = New MySqlCommand("select * from res where rno = @id", con)
        cmd.Parameters.Add(New MySqlParameter("id", e.Item.Tag))
        dr = cmd.ExecuteReader
        If dr.Read Then
            rname = dr("rno")
            MsgBox(dr("cname"))
            MsgBox(rname)
            ireservation.ShowDialog()

            'Tuloy mo nalang, ibalik mo pabalik sa mga textbox and combobox 'yung mga galing database 
        End If
        disconnect()
    End Sub
End Class