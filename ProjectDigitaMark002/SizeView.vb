Imports MySql.Data.MySqlClient

Public Class SizeView
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub SizeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()


        Dim cmd, cmd1 As New MySqlCommand

        Dim result
        sql = ""
        sql = "select * from sizesandpricetbl where ProductCode = '" & productcodetable & "'"

        cmd = New MySqlCommand(sql, conn)
        Dim dr = cmd.ExecuteReader


        While dr.Read()
            TextBox1.Text = dr("Option1").ToString
        TextBox2.Text = dr("Option2").ToString
            TextBox3.Text = dr("Option3").ToString
            TextBox4.Text = dr("Option4").ToString
            TextBox5.Text = dr("Option5").ToString
        End While
        dr.Close()








    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim option1 = TextBox1.Text
        Dim option2 = TextBox2.Text
        Dim option3 = TextBox3.Text
        Dim option4 = TextBox4.Text
        Dim option5 = TextBox5.Text

        Dim cmd, cmd1 As New MySqlCommand


        sql = "Update sizesandpricetbl SET Option1 = '" & option1 & "', Option2 = '" & option2 & "', Option3 = '" & option3 & "', Option4 = '" & option4 & "', Option5 = '" & option5 & "' where ProductCode ='" & productcodetable & "' "

        cmd = New MySqlCommand(sql, conn)
        Dim i = cmd.ExecuteNonQuery

        If i > 0 Then
            MessageBox.Show("update successfull")
            Home.SplitContainer1.Panel2.Controls.Clear()
            Home.SplitContainer1.Panel2.Controls.Add(New InventoryView())
            Me.Close()
        Else
            MessageBox.Show("Update Failed")

        End If
    End Sub
End Class