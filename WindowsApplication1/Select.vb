Public Class Form2

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    
        Me.Hide()
        OrderPreview.TextBox1.Text = Me.Label2.Text
        OrderPreview.TextBox2.Text = Me.Label3.Text
        OrderPreview.TextBox3.Text = Me.Label4.Text
        OrderPreview.ShowDialog()

        Me.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()                      'Show a form at a time
        'Dim hForm As New Form4
        'hForm.ShowDialog()
        Form4.ShowDialog()

        If Form4.CheckBox1.Checked And Form4.CheckBox2.Checked And Form4.CheckBox3.Checked Then
            Label3.Text = "牛排" & Form4.CheckBox1.Text & "     " & "選擇" & Form4.ListBox1.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "意麵" & Form4.CheckBox2.Text & "     " & "選擇" & Form4.ListBox2.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "燴飯" & Form4.CheckBox3.Text & "     " & "選擇" & Form4.ListBox3.SelectedItem.ToString & "份"
        ElseIf Form4.CheckBox1.Checked Then
            Label3.Text = "牛排" & Form4.CheckBox1.Text & "     " & "選擇" & Form4.ListBox1.SelectedItem.ToString & "份"
            If Form4.CheckBox2.Checked Then
                Label3.Text = "牛排" & Form4.CheckBox1.Text & "     " & "選擇" & Form4.ListBox1.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "意麵" & Form4.CheckBox2.Text & "     " & "選擇" & Form4.ListBox2.SelectedItem.ToString & "份"
            ElseIf Form4.CheckBox3.Checked Then
                Label3.Text = "牛排" & Form4.CheckBox1.Text & "     " & "選擇" & Form4.ListBox1.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "燴飯" & Form4.CheckBox3.Text & "     " & "選擇" & Form4.ListBox3.SelectedItem.ToString & "份"
            End If

        ElseIf Form4.CheckBox2.Checked Then
            Label3.Text = "意麵" & Form4.CheckBox2.Text & "     " & "選擇" & Form4.ListBox2.SelectedItem.ToString & "份"
            If Form4.CheckBox3.Checked Then
                Label3.Text = "意麵" & Form4.CheckBox2.Text & "     " & "選擇" & Form4.ListBox2.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "燴飯" & Form4.CheckBox3.Text & "     " & "選擇" & Form4.ListBox3.SelectedItem.ToString & "份"
            End If

        ElseIf Form4.CheckBox3.Checked Then
            Label3.Text = "燴飯" & Form4.CheckBox3.Text & "     " & "選擇" & Form4.ListBox3.SelectedItem.ToString & "份"

        End If

        Me.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()  'Show a form at a time
        'Dim hForm As New before
        'hForm.ShowDialog()
        before.ShowDialog()
        If before.CheckBox1.Checked And before.CheckBox2.Checked Then
            Label2.Text = "沙拉" & before.CheckBox1.Text & "     " & "選擇" & before.ListBox1.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "麵包" & before.CheckBox2.Text & "     " & "選擇" & before.ListBox2.SelectedItem.ToString & "份"

        ElseIf before.CheckBox1.Checked Then
            Label2.Text = "沙拉" & before.CheckBox1.Text & "     " & "選擇" & before.ListBox1.SelectedItem.ToString & "份"

        ElseIf before.CheckBox2.Checked Then
            Label2.Text = "麵包" & before.CheckBox2.Text & "     " & "選擇" & before.ListBox2.SelectedItem.ToString & "份"

        End If

        Me.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()                       'Show a form at a time
        'Dim aForm As New soup
        soup.ShowDialog()

        If soup.CheckBox1.Checked And soup.CheckBox2.Checked And soup.CheckBox3.Checked Then
            Label4.Text = "玉米" & soup.CheckBox1.Text & "     " & "選擇" & soup.ListBox1.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "羅宋" & soup.CheckBox2.Text & "     " & "選擇" & soup.ListBox2.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "海鮮" & soup.CheckBox3.Text & "     " & "選擇" & soup.ListBox3.SelectedItem.ToString & "份"

        ElseIf soup.CheckBox1.Checked Then
            Label4.Text = "玉米" & soup.CheckBox1.Text & "     " & "選擇" & soup.ListBox1.SelectedItem.ToString & "份"
            If soup.CheckBox2.Checked Then
                Label4.Text = "玉米" & soup.CheckBox1.Text & "     " & "選擇" & soup.ListBox1.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "羅宋" & soup.CheckBox2.Text & "     " & "選擇" & soup.ListBox2.SelectedItem.ToString & "份"
            ElseIf soup.CheckBox3.Checked Then
                Label4.Text = "玉米" & soup.CheckBox1.Text & "     " & "選擇" & soup.ListBox1.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "海鮮" & soup.CheckBox3.Text & "     " & "選擇" & soup.ListBox3.SelectedItem.ToString & "份"
            End If

        ElseIf soup.CheckBox2.Checked Then
            Label4.Text = "羅宋" & soup.CheckBox2.Text & "     " & "選擇" & soup.ListBox2.SelectedItem.ToString & "份"
            If soup.CheckBox3.Checked Then
                Label4.Text = "羅宋" & soup.CheckBox2.Text & "     " & "選擇" & soup.ListBox2.SelectedItem.ToString & "份" & vbCrLf & vbCrLf & "海鮮" & soup.CheckBox3.Text & "     " & "選擇" & soup.ListBox3.SelectedItem.ToString & "份"
            End If

        ElseIf soup.CheckBox3.Checked Then
            Label4.Text = "海鮮" & soup.CheckBox3.Text & "     " & "選擇" & soup.ListBox3.SelectedItem.ToString & "份"

        End If

        Me.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()                       'Show a form at a time
        drink.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()                       'Show a form at a time
        dessert.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class