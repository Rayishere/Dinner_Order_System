Public Class total

    Private Sub total_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = OrderPreview.TextBox1.Text & vbCrLf & vbCrLf & OrderPreview.TextBox2.Text & vbCrLf & vbCrLf & OrderPreview.TextBox3.Text & vbCrLf & vbCrLf & OrderPreview.TextBox4.Text & vbCrLf & vbCrLf & OrderPreview.TextBox5.Text

        TextBox2.Text = Val(before.ListBox1.Text) * 120 + Val(before.ListBox2.Text) * 80 _
                            + Val(Form4.ListBox1.Text) * 200 + Val(Form4.ListBox2.Text) * 100 + Val(Form4.ListBox3.Text) * 75 _
                            + Val(soup.ListBox1.Text) * 60 + Val(soup.ListBox2.Text) * 75 + Val(soup.ListBox3.Text) * 80 _
                            + Val(drink.ListBox1.Text) * 30 + Val(drink.ListBox2.Text) * 30 + Val(drink.ListBox3.Text) * 30 _
                            + Val(dessert.ListBox1.Text) * 60 + Val(dessert.ListBox2.Text) * 100 + Val(dessert.ListBox3.Text) * 50

        If Val(TextBox3.Text) = 0 Then
            TextBox4.Text = CDbl(TextBox2.Text)
        Else
            TextBox4.Text = CDbl(TextBox2.Text) * CDbl(TextBox3.Text)
        End If
    End Sub
End Class