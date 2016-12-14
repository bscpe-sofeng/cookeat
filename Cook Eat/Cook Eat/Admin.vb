Imports System.ComponentModel

Public Class Admin

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Admin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Are you sure want to exit now?", "Cook Eat System", MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub


End Class