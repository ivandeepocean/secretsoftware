Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AddProduct
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.SplitContainer1.Panel2.Controls.Clear()
        Home.SplitContainer1.Panel2.Controls.Add(New InventoryView)
    End Sub

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim cmd, cmd1 As New MySqlCommand

        Dim productcode = TextBox1.Text
        Dim productname = TextBox2.Text
        Dim description = TextBox3.Text
        Dim Quantity = TextBox4.Text
        Dim Size = TextBox5.Text

        sql = "Insert into productstbl (ProductCode,ProductName,Description,Quantity,Size,Activity) VALUES ('" & productcode & "', '" & productname & "', '" & description & "', '" & Quantity & "', '" & Size & "','yes'); "
        cmd = New MySqlCommand(sql, conn)
        Dim success = cmd.ExecuteNonQuery()
        If success > 0 Then
            MessageBox.Show("Successfully Added")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()

            log = "Added '" & productcode & "'," & productname & "," & description & "," & Quantity & "," & Size & " into inventory "
            MessageBox.Show(log)

        Else
            MessageBox.Show("Registration Failed")
        End If


        sql = "Insert into sizesandpricetbl (ProductCode,ProductName) VALUES ('" & productcode & "', '" & productname & "'); "
        cmd = New MySqlCommand(sql, conn)
        success = cmd.ExecuteNonQuery()







    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim strFileName As String

        OpenFileDialog1.InitialDirectory = "C:\Users\Ivan\Documents\Visual Studio 2017\Projects\ProjectDigitaMark002\images"
        OpenFileDialog1.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"



        Dim DidWork As Integer = OpenFileDialog1.ShowDialog()
        If DidWork <> DialogResult.Cancel Then

            strFileName = OpenFileDialog1.FileName


            Dim original As Image = Image.FromFile(strFileName)
            Dim resized As Image = ResizeImage(original, New Size(350, 350))
            Dim memStream As MemoryStream = New MemoryStream()
            resized.Save(memStream, ImageFormat.Jpeg)
            PictureBox1.Image = resized





            OpenFileDialog1.Reset()

        End If

    End Sub

    Public Shared Function ResizeImage(ByVal image As Image,
 ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image

        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth, percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If

        Dim newImage As Image = New Bitmap(newWidth, newHeight)

        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage


    End Function



End Class
