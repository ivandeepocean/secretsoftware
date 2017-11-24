Imports MySql.Data.MySqlClient

Public Class InventoryView
    Private Sub InventoryView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        Dim cmd, cmd1 As New MySqlCommand
        Dim dr As MySqlDataReader

        sql = ""
        sql = "select * from productstbl"

        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader

        While dr.Read
            DataGridView1.Rows.Add(dr("ProductNo"), dr("ProductName"), dr("Description"), dr("Quantity"), dr("Size"), dr("Price"))
        End While

        dr.Close()

        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.ColumnHeadersHeightSizeMode = False
        DataGridView1.RowHeadersWidthSizeMode = False

        DataGridView1.Rows(0).Selected = True




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Add.Click

        Home.SplitContainer1.Panel2.Controls.Clear()
        Home.SplitContainer1.Panel2.Controls.Add(New AddProduct)
        ProductNoSum = ProductNoSum + 1

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productnotable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        pricetable = DataGridView1.Item(5, gt).Value.ToString


    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productnotable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        pricetable = DataGridView1.Item(5, gt).Value.ToString
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productnotable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        pricetable = DataGridView1.Item(5, gt).Value.ToString
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productnotable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        pricetable = DataGridView1.Item(5, gt).Value.ToString
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productnotable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        pricetable = DataGridView1.Item(5, gt).Value.ToString
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productnotable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        pricetable = DataGridView1.Item(5, gt).Value.ToString


        Home.SplitContainer1.Panel2.Controls.Clear()
        Home.SplitContainer1.Panel2.Controls.Add(New EditProduct)







    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productnotable = DataGridView1.Item(0, gt).Value.ToString

        Dim cmd, cmd1 As New MySqlCommand
        Dim dr As MySqlDataReader

        sql = ""
        sql = "Update productstbl SET activity = 'no' where productno= '" & productnotable & "'"


        cmd = New MySqlCommand(sql, conn)
        Dim i = cmd.ExecuteNonQuery

        If i > 0 Then
            MessageBox.Show("update successfull")
        Else
            MessageBox.Show("Update Failed")

        End If





    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.Rows.Clear()
        Dim cmd, cmd1 As New MySqlCommand
        Dim dr As MySqlDataReader

        Dim searchqry = TextBox1.Text



        sql = ""
        sql = "select * from productstbl where ProductNo Like  '%" + searchqry + "%' or ProductName Like  '%" + searchqry + "%'
or Description Like  '%" + searchqry + "%' or Quantity Like  '%" + searchqry + "%' or Size Like  '%" + searchqry + "%' or Price Like  '%" + searchqry + "%'"

        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader

        While dr.Read
            DataGridView1.Rows.Add(dr("ProductNo"), dr("ProductName"), dr("Description"), dr("Quantity"), dr("Size"), dr("Price"))
        End While

        dr.Close()
    End Sub
End Class
