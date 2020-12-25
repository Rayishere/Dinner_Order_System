Public Class before

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()                       'Show a form at a time
        Dim sForm As New salad
        sForm.ShowDialog()
        Me.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()                       'Show a form at a time
        Dim bForm As New bread
        bForm.ShowDialog()
        Me.Show()

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        
        Me.Close()                       'Show a form at a time
        ' Dim mForm As New Form2
        'Form2.Show()
        ' Me.Show()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub before_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TipType As New ToolTip()
        TipType.SetToolTip(Button1, "生菜、聖女番茄、紫高麗菜、酥脆麵包塊、自製凱薩沙拉醬")
        Dim TipType1 As New ToolTip()
        TipType1.SetToolTip(Button2, "自製法國麵包，並附上新鮮奶油、自製草莓果醬")

    

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
End Class