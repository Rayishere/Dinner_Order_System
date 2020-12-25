Imports System.Data
Imports System.Data.OleDb

Public Class OrderPreview

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim mForm As New Lottery
        mForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim eForm As New Form2
        eForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim mForm As New total
        mForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub OrderPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO:  這行程式碼會將資料載入 '資料庫2DataSet.Dinner' 資料表。您可以視需要進行移動或移除。
        ' Me.DinnerTableAdapter.Fill(Me.資料庫2DataSet.Dinner)
        Dim dbpath As String = "資料庫2.accdb"
        Dim source As String
        source = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbpath
        Dim conn As OleDbConnection
        conn = New OleDbConnection(source)
        conn.Open()
        Dim selectDDrinksCmd As String
        Dim selectDessertCmd As String
        'Dim i As Integer
        selectDDrinksCmd = "select choosedName, quantity from Dinner where classify ='飲料'"
        selectDessertCmd = "select choosedName, quantity from Dinner where classify ='甜點'"
        Dim cmd1 As OleDbCommand
        Dim cmd2 As OleDbCommand
        cmd1 = New OleDbCommand(selectDDrinksCmd, conn)
        cmd2 = New OleDbCommand(selectDessertCmd, conn)
        Dim reader1 As OleDbDataReader
        Dim reader2 As OleDbDataReader
        reader1 = cmd1.ExecuteReader
        reader2 = cmd2.ExecuteReader

        While reader1.Read
            'For a = 0 To reader1.FieldCount - 1
            TextBox4.Text &= reader1.Item(0) & vbTab & "選擇" & reader1.Item(1) & "杯" & vbCrLf
            'Next
            TextBox4.Text &= vbNewLine

        End While

        While reader2.Read
            'For a = 0 To reader1.FieldCount - 1
            TextBox5.Text &= reader2.Item(0) & vbTab & "選擇" & reader2.Item(1) & "份" & vbCrLf
            'Next
            TextBox5.Text &= vbNewLine

        End While
        conn.Close()



    End Sub


End Class