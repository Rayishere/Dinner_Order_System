Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrExit.Tick
        Me.Hide()
        tmrExit.Enabled = False
        Dim mForm As New Form2
        mForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
