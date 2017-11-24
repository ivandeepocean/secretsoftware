Imports MySql.Data.MySqlClient

Public Class AddProduct
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.SplitContainer1.Panel2.Controls.Clear()
        Home.SplitContainer1.Panel2.Controls.Add(New InventoryView)
    End Sub

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        'Dim result
        'sql = ""
        'sql = "select Max(ProductNo)  from productstbl"

        'cmd = New MySqlCommand(sql, conn)

        'result = cmd.ExecuteScalar()
        'ProductNoSum = result
        'TextBox1.Text = ProductNoSum + 1


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cmd, cmd1 As New MySqlCommand

        Dim productcode = TextBox1.Text
        Dim productname = TextBox2.Text
        Dim description = TextBox3.Text
        Dim Quantity = TextBox4.Text
        Dim Size = TextBox5.Text

        sql = "Insert into productstbl (ProductCode,ProductName,Description,Quantity,Size) VALUES ('" & productcode & "', '" & productname & "', '" & description & "', '" & Quantity & "', '" & Size & "'); "
        cmd = New MySqlCommand(sql, conn)
        Dim success = cmd.ExecuteNonQuery()
        If success > 0 Then
            MessageBox.Show("Successfully Added")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()

        Else
            MessageBox.Show("Registration Failed")
        End If


        sql = "Insert into sizesandpricetbl (ProductCode,ProductName) VALUES ('" & productcode & "', '" & productname & "'); "
        cmd = New MySqlCommand(sql, conn)
        success = cmd.ExecuteNonQuery()


    End Sub
End Class
