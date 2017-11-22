Imports MySql.Data.MySqlClient

Public Class LoginFrm
    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username
        Dim password
        Dim conpassword
        Dim cmd, cmd1 As New MySqlCommand
        Dim dr As MySqlDataReader

        username = TextBox1.Text
        password = TextBox2.Text
        conpassword = TextBox3.Text

        If password = conpassword Then

            sql = ""

            sql = "Insert into accountstbl (username, password) VALUES ('" & username & "', '" & password & "'); "
            cmd = New MySqlCommand(sql, conn)
            Dim success = cmd.ExecuteNonQuery()
            If success > 0 Then
                MessageBox.Show("Successfully Added")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                Me.Close()
                Form_login.Show()
            Else
                MessageBox.Show("Registration Failed")
            End If
        Else
            MessageBox.Show("Registration Failed")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form_login.Show()
    End Sub
End Class