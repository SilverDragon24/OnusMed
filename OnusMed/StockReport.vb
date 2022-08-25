Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class StockReport
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim flag As Boolean
        Dim red As Boolean
        Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
        Dim folderpath As String = String.Concat(docpath, "\StockReports")
        If (Not Directory.Exists(folderpath)) Then
            Directory.CreateDirectory(folderpath)
        End If
        Dim now As DateTime = DateTime.Now
        Dim filepath As String = String.Concat(folderpath, "\StockReport_", now.ToString("MM.dd.yyyy_HH.mm.ss"), ".html")
        Using fileStream As System.IO.FileStream = System.IO.File.Create(filepath)
        End Using
        Dim file As StreamWriter = New StreamWriter(filepath)
        file.WriteLine("<html>")
        now = DateTime.Today
        file.WriteLine(String.Concat("<title>Stock Report for ", now.ToString("MM-dd-yyyy"), "</title>"))
        file.WriteLine("<head>")
        file.WriteLine("<style media=""screen"" type=""text/css"">")
        file.WriteLine("@media print {")
        file.WriteLine("thead {display: table-header-group;}")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")
        now = DateTime.Today
        file.WriteLine(String.Concat("<center><h1>Stock Report for ", now.ToString("MM-dd-yyyy"), "</h1></center>"))
        file.WriteLine("<table border=1 width=100%>")
        If (radioItem.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Available Packs</th>")
            file.Write("<th>Available Strips</th>")
            file.WriteLine("<th>Available Pieces</th>")
            file.WriteLine("</tr>")
            Dim dataSet As DataSet = New DataSet()
            Dim str As String = "select i.code,(select m.name from medicine m where m.code=i.code),sum(i.stock_pack),sum(i.stock_strip),sum(i.stock_piece) from inventory i"
            If (radioGD.Checked) Then
                str = String.Concat(str, " where location='GD'")
            ElseIf (radioSTO.Checked) Then
                str = String.Concat(str, " where location='STO'")
            End If
            str = String.Concat(str, " group by i.code;")
            selectData(str, dataSet)
            If (dataSet.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = dataSet.Tables(0).Rows.Count - 1
                For num As Integer = 0 To count Step 1
                    Dim dataSet1 As DataSet = New DataSet()
                    Dim str1 As String = String.Concat("select minstock from medicine where code='", dataSet.Tables(0).Rows(num)(0).ToString(), "'")
                    selectData(str1, dataSet1)
                    flag = If(Decimal.Compare(Convert.ToDecimal(dataSet.Tables(0).Rows(num)(2)), Convert.ToDecimal(dataSet1.Tables(0).Rows(0)(0))) > 0, False, True)
                    If (flag) Then
                        file.WriteLine("<font color=0xFF0000>")
                    End If
                    file.WriteLine("<tr>")
                    file.Write(String.Concat("<td>", dataSet.Tables(0).Rows(num)(0).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", dataSet.Tables(0).Rows(num)(1).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", dataSet.Tables(0).Rows(num)(2).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", dataSet.Tables(0).Rows(num)(3).ToString(), "</td>"))
                    file.WriteLine(String.Concat("<td>", dataSet.Tables(0).Rows(num)(4).ToString(), "</td>"))
                    file.WriteLine("</tr>")
                    If (flag) Then
                        file.WriteLine("</font>")
                    End If
                Next

            End If
        ElseIf (radioBatch.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Batch Code</th>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Expiry</th>")
            file.Write("<th>Available Packs</th>")
            file.Write("<th>Available Strips</th>")
            file.WriteLine("<th>Available Pieces</th>")
            file.WriteLine("</tr>")
            Dim report As DataSet = New DataSet()
            Dim query As String = "select i.batchcode,i.code,(select m.name from medicine m where m.code=i.code),date_format(i.expiry,'%m-%Y'),sum(i.stock_pack),sum(i.stock_strip),sum(i.stock_piece) from inventory i"
            If (radioGD.Checked) Then
                query = String.Concat(query, " where location='GD'")
            ElseIf (radioSTO.Checked) Then
                query = String.Concat(query, " where location='STO'")
            End If
            query = String.Concat(query, " group by i.batchcode,i.code;")
            selectData(query, report)
            If (report.Tables(0).Rows.Count > 0) Then
                Dim count1 As Integer = report.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count1 Step 1
                    Dim minstock As DataSet = New DataSet()
                    Dim min As String = String.Concat("select minstock from medicine where code='", report.Tables(0).Rows(i)(1).ToString(), "'")
                    selectData(min, minstock)
                    red = If(Decimal.Compare(Convert.ToDecimal(report.Tables(0).Rows(i)(4)), Convert.ToDecimal(minstock.Tables(0).Rows(0)(0))) > 0, False, True)
                    If (red) Then
                        file.WriteLine("<font color=0xFF0000>")
                    End If
                    file.WriteLine("<tr>")
                    file.Write(String.Concat("<td>", report.Tables(0).Rows(i)(0).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", report.Tables(0).Rows(i)(1).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", report.Tables(0).Rows(i)(2).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", report.Tables(0).Rows(i)(3).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", report.Tables(0).Rows(i)(4).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", report.Tables(0).Rows(i)(5).ToString(), "</td>"))
                    file.WriteLine(String.Concat("<td>", report.Tables(0).Rows(i)(6).ToString(), "</td>"))
                    file.WriteLine("</tr>")
                    If (red) Then
                        file.WriteLine("</font>")
                    End If
                Next

            End If
        End If
        file.WriteLine("</table>")
        file.WriteLine("</body>")
        file.WriteLine("</html>")
        file.Close()
        Process.Start(filepath)
    End Sub
End Class