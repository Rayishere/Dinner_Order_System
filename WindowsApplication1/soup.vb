Public Class soup


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()                       'Show a form at a time
        Dim cForm As New corn
        cForm.ShowDialog()
        Me.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()                       'Show a form at a time
        Dim tForm As New tomato
        tForm.ShowDialog()
        Me.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()                       'Show a form at a time
        Dim fForm As New seafood
        fForm.ShowDialog()
        Me.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()                       'Show a form at a time
        ' Dim mForm As New Form2
        ' Form2.ShowDialog()
        'Me.Show()
    End Sub

    Private Sub soup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TipType As New ToolTip()
        TipType.SetToolTip(Button1, "新鮮玉米粒、馬鈴薯塊、培根、蛋、澱粉、大骨高湯、黑胡椒粒")
        Dim TipType1 As New ToolTip()
        TipType1.SetToolTip(Button2, "番茄、高麗菜、牛肉塊、紅蘿蔔、大骨高湯")
        Dim TipType2 As New ToolTip()
        TipType2.SetToolTip(Button3, "文蛤、草蝦、透抽、洋蔥、番茄、大骨高湯")



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged


        If CheckBox1.Checked Then
            ListBox1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged


        If CheckBox2.Checked Then
            ListBox2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged


        If CheckBox3.Checked Then
            ListBox3.Enabled = True
        End If
    End Sub
End Class