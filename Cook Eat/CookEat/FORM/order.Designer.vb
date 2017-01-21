<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Frost_DataGridView1 = New Frost_Controls.Frost_DataGridView()
        Me.Frost_TextField1 = New Frost_Controls.Frost_TextField()
        Me.Frost_TextField2 = New Frost_Controls.Frost_TextField()
        Me.Frost_TextField4 = New Frost_Controls.Frost_TextField()
        Me.Frost_ComboBox1 = New Frost_Controls.Frost_ComboBox()
        Me.Frost_Button1 = New Frost_Controls.Frost_Button()
        Me.Frost_TextField3 = New Frost_Controls.Frost_TextField()
        Me.Frost_Label1 = New Frost_Controls.Frost_Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.Frost_DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frost_DataGridView1
        '
        Me.Frost_DataGridView1.AllowUserToAddRows = False
        Me.Frost_DataGridView1.AllowUserToDeleteRows = False
        Me.Frost_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Frost_DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Edit, Me.delete})
        Me.Frost_DataGridView1.Location = New System.Drawing.Point(350, 66)
        Me.Frost_DataGridView1.Name = "Frost_DataGridView1"
        Me.Frost_DataGridView1.ReadOnly = True
        Me.Frost_DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Frost_DataGridView1.Size = New System.Drawing.Size(452, 384)
        Me.Frost_DataGridView1.TabIndex = 0
        Me.Frost_DataGridView1.VScrollValue = 0
        '
        'Frost_TextField1
        '
        Me.Frost_TextField1.Location = New System.Drawing.Point(99, 134)
        Me.Frost_TextField1.Name = "Frost_TextField1"
        Me.Frost_TextField1.PlaceHolder = ""
        Me.Frost_TextField1.Size = New System.Drawing.Size(159, 20)
        Me.Frost_TextField1.TabIndex = 1
        Me.Frost_TextField1.TextColour = System.Drawing.Color.Black
        '
        'Frost_TextField2
        '
        Me.Frost_TextField2.Location = New System.Drawing.Point(99, 160)
        Me.Frost_TextField2.Name = "Frost_TextField2"
        Me.Frost_TextField2.PlaceHolder = ""
        Me.Frost_TextField2.Size = New System.Drawing.Size(159, 20)
        Me.Frost_TextField2.TabIndex = 2
        Me.Frost_TextField2.TextColour = System.Drawing.Color.Black
        '
        'Frost_TextField4
        '
        Me.Frost_TextField4.FieldType = Frost_Controls.Frost_TextField.TypeOfField.[Decimal]
        Me.Frost_TextField4.Location = New System.Drawing.Point(99, 214)
        Me.Frost_TextField4.Name = "Frost_TextField4"
        Me.Frost_TextField4.PlaceHolder = ""
        Me.Frost_TextField4.Size = New System.Drawing.Size(159, 20)
        Me.Frost_TextField4.TabIndex = 4
        Me.Frost_TextField4.TextColour = System.Drawing.Color.Black
        '
        'Frost_ComboBox1
        '
        Me.Frost_ComboBox1.FormattingEnabled = True
        Me.Frost_ComboBox1.Location = New System.Drawing.Point(99, 187)
        Me.Frost_ComboBox1.Name = "Frost_ComboBox1"
        Me.Frost_ComboBox1.Size = New System.Drawing.Size(159, 21)
        Me.Frost_ComboBox1.TabIndex = 6
        '
        'Frost_Button1
        '
        Me.Frost_Button1.Location = New System.Drawing.Point(183, 315)
        Me.Frost_Button1.Name = "Frost_Button1"
        Me.Frost_Button1.Size = New System.Drawing.Size(75, 23)
        Me.Frost_Button1.TabIndex = 7
        Me.Frost_Button1.Text = "Frost_Button1"
        Me.Frost_Button1.UseVisualStyleBackColor = True
        '
        'Frost_TextField3
        '
        Me.Frost_TextField3.Location = New System.Drawing.Point(643, 40)
        Me.Frost_TextField3.Name = "Frost_TextField3"
        Me.Frost_TextField3.PlaceHolder = ""
        Me.Frost_TextField3.Size = New System.Drawing.Size(159, 20)
        Me.Frost_TextField3.TabIndex = 8
        Me.Frost_TextField3.TextColour = System.Drawing.Color.Black
        '
        'Frost_Label1
        '
        Me.Frost_Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Frost_Label1.Location = New System.Drawing.Point(99, 241)
        Me.Frost_Label1.Name = "Frost_Label1"
        Me.Frost_Label1.Size = New System.Drawing.Size(100, 23)
        Me.Frost_Label1.TabIndex = 9
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        '
        'delete
        '
        Me.delete.HeaderText = "Delete"
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 462)
        Me.Controls.Add(Me.Frost_Label1)
        Me.Controls.Add(Me.Frost_TextField3)
        Me.Controls.Add(Me.Frost_Button1)
        Me.Controls.Add(Me.Frost_ComboBox1)
        Me.Controls.Add(Me.Frost_TextField4)
        Me.Controls.Add(Me.Frost_TextField2)
        Me.Controls.Add(Me.Frost_TextField1)
        Me.Controls.Add(Me.Frost_DataGridView1)
        Me.Name = "order"
        Me.Text = "order"
        CType(Me.Frost_DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Frost_DataGridView1 As Frost_Controls.Frost_DataGridView
    Friend WithEvents Frost_TextField1 As Frost_Controls.Frost_TextField
    Friend WithEvents Frost_TextField2 As Frost_Controls.Frost_TextField
    Friend WithEvents Frost_TextField4 As Frost_Controls.Frost_TextField
    Friend WithEvents Frost_ComboBox1 As Frost_Controls.Frost_ComboBox
    Friend WithEvents Frost_Button1 As Frost_Controls.Frost_Button
    Friend WithEvents Frost_TextField3 As Frost_Controls.Frost_TextField
    Friend WithEvents Frost_Label1 As Frost_Controls.Frost_Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents delete As DataGridViewButtonColumn
End Class
