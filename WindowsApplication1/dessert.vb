Imports System.Data
Imports System.Data.OleDb

Public Class dessert


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        Dim dbpath As String = "資料庫2.accdb"
        Dim source As String
        source = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbpath

        Dim conn As OleDbConnection 'Declear the connection object
        conn = New OleDbConnection(source) ' Connect
        conn.Open()   'Open database

        Dim selectitem As String
        Dim amount As Integer
        Dim total As Integer
        Dim insert As String

        If CheckBox1.Checked Then
            selectitem = "紅豆湯$60/份"
            amount = ListBox1.SelectedItem
            total = amount * 60
            insert = "Insert Into Dinner (classify, choosedName, quantity, totalmoney)" _
                                & "Values ('甜點" & "','" & selectitem & "','" _
                                & amount & "','" & total & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(insert, conn)
            cmd.ExecuteNonQuery()
            'MsgBox("紅豆湯新增成功!")
        End If

        If CheckBox2.Checked Then
            selectitem = "舒芙蕾$100/份"
            amount = ListBox2.SelectedItem
            total = amount * 100
            insert = "Insert Into Dinner (classify, choosedName, quantity, totalmoney)" _
                                & "Values ('甜點" & "','" & selectitem & "','" _
                                & amount & "','" & total & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(insert, conn)
            cmd.ExecuteNonQuery()
            'MsgBox("舒芙雷新增成功!")
        End If

        If CheckBox3.Checked Then
            selectitem = "蛋糕$50/份"
            amount = ListBox3.SelectedItem
            total = amount * 50
            insert = "Insert Into Dinner (classify, choosedName, quantity, totalmoney)" _
                                & "Values ('甜點" & "','" & selectitem & "','" _
                                & amount & "','" & total & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(insert, conn)
            cmd.ExecuteNonQuery()
            'MsgBox("蛋糕新增成功!")
        End If
        conn.Close()

        

        '  Me.Hide()
        'Dim back As New Form2
        ' Form2.ShowDialog()
        Me.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()                       'Show a form at a time
        Dim mForm As New redbeansoup
        mForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()                       'Show a form at a time
        Dim mForm As New suffla
        mForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()                       'Show a form at a time
        Dim mForm As New chocolate
        mForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub dessert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim TipType As New ToolTip()
        TipType.SetToolTip(Button1, "紅豆、水、白砂糖、鹽")
        Dim TipType1 As New ToolTip()
        TipType1.SetToolTip(Button2, "蛋奶醬、蛋白霜")
        Dim TipType2 As New ToolTip()
        TipType2.SetToolTip(Button3, "低筋麵粉、糖、玉米粉 、牛奶、巧克力")

   
        
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