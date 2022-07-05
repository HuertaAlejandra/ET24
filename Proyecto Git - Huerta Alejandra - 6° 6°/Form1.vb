Public Class Form1
    Public FormLeft As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm1ScreenArea = Screen.FromControl(Me).WorkingArea

        If Me.Right < frm1ScreenArea.Left + frm1ScreenArea.Width / 2 Then
            FormLeft = True
        Else
            FormLeft = False
        End If
        Form2.Show()
    End Sub
End Class
