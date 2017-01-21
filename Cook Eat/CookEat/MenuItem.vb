Public Class MenuItem

    Private _itemCode As String = ""
    Private _id As Integer = -1
    Private _itemname As String = ""
    Private _price As Double = 0
    Private _quantity As Integer = 0

    Public Property ItemCode() As String
        Get
            Return _itemCode
        End Get
        Set(value As String)
            _itemCode = value
            Frost_Label1.Text = _itemCode
        End Set
    End Property

    Public Property ID() As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property ITEMNAME() As String
        Get
            Return _itemname
        End Get
        Set(value As String)
            _itemname = value
            Frost_Label3.Text = _itemname
        End Set
    End Property

    Public Property PRICE() As Double
        Get
            Return _price
        End Get
        Set(value As Double)
            _price = value
            Frost_Label2.Text = _price.ToString("#,0.00")
        End Set
    End Property

    Public Property QUANTITY() As Integer
        Get
            Return _quantity
        End Get
        Set(value As Integer)
            _quantity = value
            Frost_TextField1.Text = _quantity
        End Set
    End Property


    Private Sub MenuItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Frost_PictureBox1_Click(sender As Object, e As EventArgs) Handles Frost_PictureBox1.Click
        Frost_TextField1.Text = Val(Frost_TextField1.Text) - 1
        If Frost_TextField1.Text < 0 Then
            Frost_TextField1.Text = 0
        End If
    End Sub

    Private Sub Frost_PictureBox2_Click(sender As Object, e As EventArgs) Handles Frost_PictureBox2.Click
        Frost_TextField1.Text = Val(Frost_TextField1.Text) + 1
    End Sub

    Public Event ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    Private Sub Frost_TextField1_TextChanged(sender As Object, e As EventArgs) Handles Frost_TextField1.TextChanged
        _quantity = Integer.Parse(Frost_TextField1.Text)
        RaiseEvent ValueChanged(Me, e)
    End Sub
End Class
