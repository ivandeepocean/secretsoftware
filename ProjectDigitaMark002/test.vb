Imports System.IO

Public Class test

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With DataGridView1
            .Columns.Clear()
            .Columns.Add("No", "No")
            .Columns.Add("NIK", "NIK")
            .Columns.Add("Nama", "Nama")
            .Columns.Add("Alamat", "Alamat")
            .Columns.Add("Telp", "Telp")
        End With

    End Sub

    Private Sub BtnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadData.Click

        BtnLoadData.Text = "Please Wait..."
        BtnLoadData.Enabled = False
        Application.DoEvents()

        'LOAD 10000 ROWS INTO DATAGRIDVIEW
        For i As Integer = 1 To 10000
            With DataGridView1.Rows
                .Add(i, "3112" & i, "Student " & i, "Indonesia " & i, "021-" & i)
            End With
            Application.DoEvents()
        Next

        BtnLoadData.Text = "Load Data"
        BtnLoadData.Enabled = True

    End Sub

    Dim FlNm As String

    Private Sub ExportToExcel(ByVal DGV As DataGridView)
        Dim fs As New StreamWriter(FlNm, False)
        With fs
            .WriteLine("<?xml version=""1.0""?>")
            .WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            .WriteLine("<Workbook xmlns=""urn:schemas-microsoft-com:office:spreadsheet"">")
            .WriteLine("    <Styles>")
            .WriteLine("        <Style ss:ID=""hdr"">")
            .WriteLine("            <Alignment ss:Horizontal=""Center""/>")
            .WriteLine("            <Borders>")
            .WriteLine("                <Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("            </Borders>")
            .WriteLine("            <Font ss:FontName=""Calibri"" ss:Size=""11"" ss:Bold=""1""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""ksg"">")
            .WriteLine("            <Alignment ss:Vertical=""Bottom""/>")
            .WriteLine("            <Borders/>")
            .WriteLine("            <Font ss:FontName=""Calibri""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""isi"">")
            .WriteLine("            <Borders>")
            .WriteLine("                <Border ss:Position=""Bottom"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("            </Borders>")
            .WriteLine("            <Font ss:FontName=""Calibri"" ss:Size=""10""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("    </Styles>")
            If DGV.Name = "Student" Then
                .WriteLine("    <Worksheet ss:Name=""Student"">") 'SET NAMA SHEET
                .WriteLine("        <Table>")
                .WriteLine("            <Column ss:Width=""27.75""/>") 'No
                .WriteLine("            <Column ss:Width=""93""/>") 'NIK
                .WriteLine("            <Column ss:Width=""84""/>") 'Nama
                .WriteLine("            <Column ss:Width=""100""/>") 'Alamat
                .WriteLine("            <Column ss:Width=""84""/>") 'Telp
            End If
            'AUTO SET HEADER
            .WriteLine("            <Row ss:StyleID=""ksg"">")
            For i As Integer = 0 To DGV.Columns.Count - 1 'SET HEADER
                Application.DoEvents()
                .WriteLine("            <Cell ss:StyleID=""hdr"">")
                .WriteLine("                <Data ss:Type=""String"">{0}</Data>", DGV.Columns.Item(i).HeaderText)
                .WriteLine("            </Cell>")
            Next
            .WriteLine("            </Row>")
            For intRow As Integer = 0 To DGV.RowCount - 1
                Application.DoEvents()
                .WriteLine("        <Row ss:StyleID=""ksg"" ss:utoFitHeight =""0"">")
                For intCol As Integer = 0 To DGV.Columns.Count - 1
                    Application.DoEvents()
                    .WriteLine("        <Cell ss:StyleID=""isi"">")
                    .WriteLine("            <Data ss:Type=""String"">{0}</Data>", DGV.Item(intCol, intRow).Value.ToString)
                    .WriteLine("        </Cell>")
                Next
                .WriteLine("        </Row>")
            Next
            .WriteLine("        </Table>")
            .WriteLine("    </Worksheet>")
            .WriteLine("</Workbook>")
            .Close()
        End With
    End Sub

    Private Sub BtnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExport.Click

        If DataGridView1.RowCount = 0 Then Return

        BtnExport.Text = "Please Wait..."
        BtnExport.Enabled = False
        Application.DoEvents()

        Dim DGV As New DataGridView

        With DGV
            .AllowUserToAddRows = False
            .Name = "Student"
            .Visible = False
            .Columns.Clear()
            .Columns.Add("No", "No")
            .Columns.Add("NIK", "NIK")
            .Columns.Add("Nama", "Nama")
            .Columns.Add("Alamat", "Alamat")
            .Columns.Add("Telp", "Telp")
        End With
        With DataGridView1
            If .Rows.Count > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    Application.DoEvents()
                    DGV.Rows.Add(IIf(i = 0, 1, i + 1), .Rows(i).Cells("NIK").Value,
                                 .Rows(i).Cells("Nama").Value, .Rows(i).Cells("Alamat").Value,
                                 .Rows(i).Cells("Telp").Value)
                Next
            End If
        End With

        FlNm = "C:\\xampp\htdocs\Student " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        'FlNm = Application.StartupPath & "\Student " _
        '        & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        If File.Exists(FlNm) Then File.Delete(FlNm)
        ExportToExcel(DGV)

        DGV.Dispose()
        DGV = Nothing

        Process.Start("C:\\xampp\htdocs\secretshop " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls")

        BtnExport.Text = "Export"
        BtnExport.Enabled = True

    End Sub

End Class

