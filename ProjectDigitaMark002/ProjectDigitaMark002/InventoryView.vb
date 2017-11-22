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




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim cmd, cmd1 As New MySqlCommand
        'Dim dr As MySqlDataReader
        'Dim id As Integer

        'Form_login.Text = "Create Account"

        'sql = "SELECT * from yumidb where ProductNo=(SELECT max(ProductNo from yumidb)"
        'cmd = New MySqlCommand(sql, conn)
        'dr = cmd.ExecuteReader

        'If dr.Read Then
        '    id = dr("ProductNo")
        '    id = id + 1
        '    Form_login.txtid.Text = id

        '    dr.Close()
        'End If
        'dr.Close()
        'DataGridView1.Visible = False
        'Form_login.Show()
        'Form_login.Button1.Text = "Save"
    End Sub
End Class
