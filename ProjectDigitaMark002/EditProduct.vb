Imports MySql.Data.MySqlClient

Public Class EditProduct
    Private Sub EditProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = productnotable
        TextBox2.Text = productnametable
        TextBox3.Text = descriptiontable
        TextBox4.Text = quantitytable
        TextBox5.Text = sizetable
        TextBox6.Text = pricetable



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.SplitContainer1.Panel2.Controls.Clear()
        Home.SplitContainer1.Panel2.Controls.Add(New InventoryView())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        productnotable = TextBox1.Text
        productnametable = TextBox2.Text
        descriptiontable = TextBox3.Text
        quantitytable = TextBox4.Text
        sizetable = TextBox5.Text
        pricetable = TextBox6.Text




        sql = "Update productstbl SET ProductNo = '" & productnotable & "', ProductName = '" & productnametable & "', Description = '" & descriptiontable & "', Quantity = '" & quantitytable & "', Size = '" & sizetable & "', Price = '" & pricetable & "' where productno = '" & productnotable & "'"


        cmd = New MySqlCommand(sql, conn)
        Dim i = cmd.ExecuteNonQuery

        If i > 0 Then
            MessageBox.Show("update successfull")
            Home.SplitContainer1.Panel2.Controls.Clear()
            Home.SplitContainer1.Panel2.Controls.Add(New InventoryView())
        Else
            MessageBox.Show("Update Failed")

        End If

    End Sub
End Class
