Public Class Lottery

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim randGen As New Random
        Dim intNum1 As Integer

        intNum1 = randGen.Next(1, 11)

        Select Case intNum1
            Case 1
                PictureBox1.Image = PictureBox5.Image
                total.TextBox3.Text = "1"
            Case 2
                PictureBox1.Image = PictureBox5.Image
                total.TextBox3.Text = "1"
            Case 3
                PictureBox1.Image = PictureBox5.Image
                total.TextBox3.Text = "1"
            Case 4
                PictureBox1.Image = PictureBox5.Image
                total.TextBox3.Text = "1"
            Case 5
                PictureBox1.Image = PictureBox2.Image
                total.TextBox3.Text = "0.9"
            Case 6
                PictureBox1.Image = PictureBox2.Image
                total.TextBox3.Text = "0.9"
            Case 7
                PictureBox1.Image = PictureBox2.Image
                total.TextBox3.Text = "0.9"
            Case 8
                PictureBox1.Image = PictureBox3.Image
                total.TextBox3.Text = "0.8"
            Case 9
                PictureBox1.Image = PictureBox3.Image
                total.TextBox3.Text = "0.8"
            Case 10
                PictureBox1.Image = PictureBox4.Image
                total.TextBox3.Text = "0.7"
        End Select

        Button1.Enabled = False

     

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ' Dim mForm As New total
        total.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub Lottery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class