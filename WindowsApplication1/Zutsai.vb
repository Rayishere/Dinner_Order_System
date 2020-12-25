Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()                       'Show a form at a time
        Dim hForm As New beef
        hForm.ShowDialog()
        Me.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()                       'Show a form at a time
        Dim hForm As New Form2
        hForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()                       'Show a form at a time
        Dim hForm As New noodle
        hForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()                       'Show a form at a time
        Dim hForm As New rice
        hForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TipType As New ToolTip()
        TipType.SetToolTip(Button1, "牛里脊、花椰菜、馬鈴薯、黑胡椒醬")
        Dim TipType1 As New ToolTip()
        TipType1.SetToolTip(Button2, "意大利麵、洋蔥、小黃瓜、生菜、番茄、蓮藕、紅醬")
        Dim TipType2 As New ToolTip()
        TipType2.SetToolTip(Button3, "台灣大米、起司、培根、紅蘿蔔、豌豆")


    End Sub

   
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()                       'Show a form at a time
        'Dim hForm As New Form2
        ' hForm.ShowDialog()
        'Form2.ShowDialog()
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