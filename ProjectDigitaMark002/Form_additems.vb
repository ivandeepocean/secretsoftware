Imports MySql.Data.MySqlClient

Public Class Form_additems
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id
        Dim name
        Dim desc
        Dim qty
        Dim size
        Dim cmd, cmd1 As New MySqlCommand

        id = TextBox1.Text
        name = TextBox2.Text
        desc = TextBox3.Text
        qty = TextBox4.Text
        size = TextBox5.Text


        ''sql = "Insert into accountstbl (username, password) VALUES ('" &  & "', '" & password & "'); "
        'cmd = New MySqlCommand(sql, conn)
        '    Dim success = cmd.ExecuteNonQuery()
        'If success > 0 Then
        '    MessageBox.Show("Successfully Added")
        '    TextBox1.Clear()
        '    TextBox2.Clear()
        '    TextBox3.Clear()
        '    Me.Close()
        '    Form_login.Show()
        'Else
        '    MessageBox.Show("Registration Failed")
        'End If
    End Sub
End Class