Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.FormLeft Then
            Me.Left = Form1.Left + Form1.Width
            Me.Top = Form1.Top
        Else
            Me.Left = Form1.Right - Form1.Width * 2
            Me.Top = Form1.Top
        End If

    End Sub
End Class