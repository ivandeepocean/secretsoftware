Imports MySql.Data.MySqlClient

Public Class Form_login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cmd, cmd1 As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim username
        Dim password

        username = TextBox1.Text
        password = TextBox2.Text


        sql = "SELECT * FROM accountstbl where username = '" & username & "' and password = '" & password & "' "
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader

        If dr.HasRows Then

            MessageBox.Show("correct input")
            Home.Show()
            Me.Hide()

        Else
            MessageBox.Show("incorrect input")
            TextBox1.Clear()
            TextBox2.Clear()

        End If
        dr.Close()




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        LoginFrm.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
