Imports MySql.Data.MySqlClient

Public Class TrashbinView
    Private Sub TrashbinView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        Dim cmd, cmd1 As New MySqlCommand
        Dim dr As MySqlDataReader

        sql = ""
        sql = "select * from productstbl where Activity = 'no' "

        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader

        While dr.Read
            DataGridView1.Rows.Add(dr("ProductCode"), dr("ProductName"), dr("Description"), dr("Quantity"), dr("Size"), dr("ProductNo"))
        End While




        dr.Close()


        'DataGridView1.Rows(0).Selected = True

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productcodetable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        productnotable = DataGridView1.Item(5, gt).Value.ToString



    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productcodetable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        productnotable = DataGridView1.Item(5, gt).Value.ToString

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productcodetable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        productnotable = DataGridView1.Item(5, gt).Value.ToString

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productcodetable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        productnotable = DataGridView1.Item(5, gt).Value.ToString

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
        productcodetable = DataGridView1.Item(0, gt).Value.ToString
        productnametable = DataGridView1.Item(1, gt).Value.ToString()
        descriptiontable = DataGridView1.Item(2, gt).Value.ToString
        quantitytable = DataGridView1.Item(3, gt).Value.ToString
        sizetable = DataGridView1.Item(4, gt).Value.ToString
        productnotable = DataGridView1.Item(5, gt).Value.ToString

    End Sub

    Private Sub Restore_Click(sender As Object, e As EventArgs) Handles Restore.Click
        If DataGridView1.RowCount > 0 Then
            gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
            productcodetable = DataGridView1.Item(0, gt).Value.ToString
            productnametable = DataGridView1.Item(1, gt).Value.ToString()
            descriptiontable = DataGridView1.Item(2, gt).Value.ToString
            quantitytable = DataGridView1.Item(3, gt).Value.ToString
            sizetable = DataGridView1.Item(4, gt).Value.ToString
            productnotable = DataGridView1.Item(5, gt).Value.ToString


            Dim cmd, cmd1 As New MySqlCommand
            Dim dr As MySqlDataReader

            sql = ""
            sql = "Update productstbl SET activity = 'yes' where ProductCode= '" & productcodetable & "'"


            cmd = New MySqlCommand(sql, conn)
            Dim i = cmd.ExecuteNonQuery

            If i > 0 Then

                Home.SplitContainer1.Panel2.Controls.Clear()
                Home.SplitContainer1.Panel2.Controls.Add(New InventoryView)
                MessageBox.Show("Item was restored")

            Else
                MessageBox.Show("Update Failed")

            End If

        Else
            MessageBox.Show("Table is empty")

        End If





    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If DataGridView1.RowCount > 0 Then

            gt = CInt(DataGridView1.SelectedCells(0).RowIndex.ToString)
            productcodetable = DataGridView1.Item(0, gt).Value.ToString

            Dim cmd, cmd1 As New MySqlCommand
            Dim dr As MySqlDataReader

            sql = ""
            sql = "  Delete From productstbl   Where  ProductCode= '" & productcodetable & "'"


            cmd = New MySqlCommand(sql, conn)
            Dim i = cmd.ExecuteNonQuery

            If i > 0 Then
                MessageBox.Show("Item was permanently deleted")
                Home.SplitContainer1.Panel2.Controls.Clear()
                Home.SplitContainer1.Panel2.Controls.Add(New TrashbinView)
            Else
                MessageBox.Show("Update Failed")

            End If
        Else
            MessageBox.Show("Table is empty")

        End If
    End Sub
End Class
