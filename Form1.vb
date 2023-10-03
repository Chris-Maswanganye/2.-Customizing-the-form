Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Text = "My first App 2023"
        Me.BackColor = Color.Blue
        Me.MaximizeBox = True
        MinimizeBox = True
        Me.Size = New Size(800, 800)
        Me.Opacity = 0.95 ' make it a bit transparent
        Me.CenterToParent() ' centers the execution box
    End Sub
End Class
