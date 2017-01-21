<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Frost_TextField1 = New Frost_Controls.Frost_TextField()
        Me.Frost_Label1 = New Frost_Controls.Frost_Label()
        Me.Frost_Label2 = New Frost_Controls.Frost_Label()
        Me.Frost_Label3 = New Frost_Controls.Frost_Label()
        Me.Frost_PictureBox2 = New Frost_Controls.Frost_PictureBox()
        Me.Frost_PictureBox1 = New Frost_Controls.Frost_PictureBox()
        CType(Me.Frost_PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frost_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frost_TextField1
        '
        Me.Frost_TextField1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Frost_TextField1.FieldType = Frost_Controls.Frost_TextField.TypeOfField.NonDecimal
        Me.Frost_TextField1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frost_TextField1.ForeColor = System.Drawing.Color.Black
        Me.Frost_TextField1.Location = New System.Drawing.Point(52, 86)
        Me.Frost_TextField1.Name = "Frost_TextField1"
        Me.Frost_TextField1.PlaceHolder = ""
        Me.Frost_TextField1.Size = New System.Drawing.Size(48, 40)
        Me.Frost_TextField1.TabIndex = 2
        Me.Frost_TextField1.Text = "0"
        Me.Frost_TextField1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Frost_TextField1.TextColour = System.Drawing.Color.Black
        '
        'Frost_Label1
        '
        Me.Frost_Label1.AutoSize = True
        Me.Frost_Label1.ForeColor = System.Drawing.Color.White
        Me.Frost_Label1.Location = New System.Drawing.Point(4, 4)
        Me.Frost_Label1.Name = "Frost_Label1"
        Me.Frost_Label1.Size = New System.Drawing.Size(66, 13)
        Me.Frost_Label1.TabIndex = 3
        Me.Frost_Label1.Text = "ITEM CODE"
        '
        'Frost_Label2
        '
        Me.Frost_Label2.AutoSize = True
        Me.Frost_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frost_Label2.ForeColor = System.Drawing.Color.White
        Me.Frost_Label2.Location = New System.Drawing.Point(3, 17)
        Me.Frost_Label2.Name = "Frost_Label2"
        Me.Frost_Label2.Size = New System.Drawing.Size(44, 13)
        Me.Frost_Label2.TabIndex = 4
        Me.Frost_Label2.Text = "PRICE"
        '
        'Frost_Label3
        '
        Me.Frost_Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frost_Label3.ForeColor = System.Drawing.Color.White
        Me.Frost_Label3.Location = New System.Drawing.Point(3, 30)
        Me.Frost_Label3.Name = "Frost_Label3"
        Me.Frost_Label3.Size = New System.Drawing.Size(147, 53)
        Me.Frost_Label3.TabIndex = 5
        Me.Frost_Label3.Text = "ITEM NAME"
        Me.Frost_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frost_PictureBox2
        '
        Me.Frost_PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Frost_PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Frost_PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Frost_PictureBox2.Image = Global.CookEat.My.Resources.Resources.right
        Me.Frost_PictureBox2.Location = New System.Drawing.Point(107, 86)
        Me.Frost_PictureBox2.Name = "Frost_PictureBox2"
        Me.Frost_PictureBox2.Size = New System.Drawing.Size(43, 40)
        Me.Frost_PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Frost_PictureBox2.TabIndex = 1
        Me.Frost_PictureBox2.TabStop = False
        '
        'Frost_PictureBox1
        '
        Me.Frost_PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Frost_PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Frost_PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Frost_PictureBox1.Image = Global.CookEat.My.Resources.Resources.left
        Me.Frost_PictureBox1.Location = New System.Drawing.Point(3, 86)
        Me.Frost_PictureBox1.Name = "Frost_PictureBox1"
        Me.Frost_PictureBox1.Size = New System.Drawing.Size(43, 40)
        Me.Frost_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Frost_PictureBox1.TabIndex = 0
        Me.Frost_PictureBox1.TabStop = False
        '
        'MenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Frost_Label3)
        Me.Controls.Add(Me.Frost_Label2)
        Me.Controls.Add(Me.Frost_Label1)
        Me.Controls.Add(Me.Frost_TextField1)
        Me.Controls.Add(Me.Frost_PictureBox2)
        Me.Controls.Add(Me.Frost_PictureBox1)
        Me.Name = "MenuItem"
        Me.Size = New System.Drawing.Size(153, 129)
        CType(Me.Frost_PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frost_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Frost_PictureBox1 As Frost_Controls.Frost_PictureBox
    Friend WithEvents Frost_PictureBox2 As Frost_Controls.Frost_PictureBox
    Friend WithEvents Frost_TextField1 As Frost_Controls.Frost_TextField
    Friend WithEvents Frost_Label1 As Frost_Controls.Frost_Label
    Friend WithEvents Frost_Label2 As Frost_Controls.Frost_Label
    Friend WithEvents Frost_Label3 As Frost_Controls.Frost_Label
End Class
