
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO

Public Class Home


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Me.IsMdiContainer = True
        SplitContainer1.IsSplitterFixed = True


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(New InventoryView())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(New CashierView)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(New accountsView)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(New SettingsView)
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form_login.Show()
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim strFileName As String

        OpenFileDialog1.InitialDirectory = "C:\Users\Ivan\Documents\Visual Studio 2017\Projects\ProjectDigitaMark002\images"
        OpenFileDialog1.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"



        Dim DidWork As Integer = OpenFileDialog1.ShowDialog()
        If DidWork <> DialogResult.Cancel Then

            strFileName = OpenFileDialog1.FileName


            Dim original As Image = Image.FromFile(strFileName)
            Dim resized As Image = ResizeImage(original, New Size(301, 303))
            Dim memStream As MemoryStream = New MemoryStream()
            resized.Save(memStream, ImageFormat.Jpeg)
            PictureBox1.Image = resized





            OpenFileDialog1.Reset()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        SplitContainer1.Panel2.Controls.Clear()
        SplitContainer1.Panel2.Controls.Add(New TrashbinView)
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