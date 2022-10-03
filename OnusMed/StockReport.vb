Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Threading

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
        Dim ofile As StreamWriter = New StreamWriter(filepath)
        ofile.WriteLine("<html>")
        now = DateTime.Today
        ofile.WriteLine(String.Concat("<title>Stock Report for ", now.ToString("MM-dd-yyyy"), "</title>"))
        ofile.WriteLine("<head>")
        ofile.WriteLine("<style media=""screen"" type=""text/css"">")
        ofile.WriteLine("@media print {")
        ofile.WriteLine("thead {display: table-header-group;}")
        ofile.WriteLine("}")
        ofile.WriteLine("</style>")
        ofile.WriteLine("</head>")
        ofile.WriteLine("<body>")
        now = DateTime.Today
        ofile.WriteLine(String.Concat("<center><h1>Stock Report for ", now.ToString("dd-MMM-yyyy"), "</h1></center>"))
        ofile.WriteLine("<table border=1 width=100%>")
        If (radioItem.Checked) Then
            ofile.WriteLine("<thead><tr>")
            ofile.Write("<th>Item Code</th>")
            ofile.Write("<th>Item Name</th>")
            ofile.Write("<th>Batch Code</th>")
            ofile.Write("<th>Expiry</th>")
            ofile.Write("<th>Type</th>")
            ofile.Write("<th>Available</th>")
            ofile.Write("<th>M.R.P</th>")
            ofile.WriteLine("</tr></thead>")
            ofile.Write("<tbody>")
            Dim types As DataSet = New DataSet
            selectData("select distinct type from medicine;", types)
            If types.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To types.Tables(0).Rows.Count - 1
                    Dim ids As DataSet = New DataSet
                    selectData("select distinct code from medicine where type='" + types.Tables(0).Rows(i).Item(0).ToString + "';", ids)
                    If ids.Tables(0).Rows.Count > 0 Then
                        For j As Integer = 0 To ids.Tables(0).Rows.Count - 1
                            Dim items As DataSet = New DataSet
                            selectData("select code,batchcode,date_format(expiry,'%d-%b-%Y'),stock_piece,concat(mrp_piece,' INR') from inventory where code='" + ids.Tables(0).Rows(j).Item(0).ToString + "' and stock_piece>0;", items)
                            If items.Tables(0).Rows.Count > 0 Then
                                For k As Integer = 0 To items.Tables(0).Rows.Count - 1
                                    ofile.Write("<tr>")
                                    ofile.Write("<td>")
                                    ofile.Write(items.Tables(0).Rows(k).Item(0).ToString)
                                    ofile.Write("</td>")
                                    ofile.Write("<td>")
                                    ofile.Write(getName(items.Tables(0).Rows(k).Item(0).ToString))
                                    ofile.Write("</td>")
                                    ofile.Write("<td>")
                                    ofile.Write(items.Tables(0).Rows(k).Item(1).ToString)
                                    ofile.Write("</td>")
                                    ofile.Write("<td>")
                                    ofile.Write(items.Tables(0).Rows(k).Item(2).ToString)
                                    ofile.Write("</td>")
                                    ofile.Write("<td>")
                                    ofile.Write(types.Tables(0).Rows(i).Item(0).ToString)
                                    ofile.Write("</td>")
                                    ofile.Write("<td>")
                                    ofile.Write(items.Tables(0).Rows(k).Item(3).ToString)
                                    ofile.Write("</td>")
                                    ofile.Write("<td>")
                                    ofile.Write(items.Tables(0).Rows(k).Item(4).ToString)
                                    ofile.Write("</td>")
                                    ofile.Write("</tr>")
                                Next
                            End If
                        Next
                    End If
                Next
            End If
            ofile.Write("</tbody>")
        ElseIf (radioBatch.Checked) Then
            ofile.WriteLine("<tr>")
            ofile.Write("<th>Batch Code</th>")
            ofile.Write("<th>Item Code</th>")
            ofile.Write("<th>Item Name</th>")
            ofile.Write("<th>Expiry</th>")
            ofile.Write("<th>Available Packs</th>")
            ofile.Write("<th>Available Strips</th>")
            ofile.WriteLine("<th>Available Pieces</th>")
            ofile.WriteLine("</tr>")
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
                        ofile.WriteLine("<font color=0xFF0000>")
                    End If
                    ofile.WriteLine("<tr>")
                    ofile.Write(String.Concat("<td>", report.Tables(0).Rows(i)(0).ToString(), "</td>"))
                    ofile.Write(String.Concat("<td>", report.Tables(0).Rows(i)(1).ToString(), "</td>"))
                    ofile.Write(String.Concat("<td>", report.Tables(0).Rows(i)(2).ToString(), "</td>"))
                    ofile.Write(String.Concat("<td>", report.Tables(0).Rows(i)(3).ToString(), "</td>"))
                    ofile.Write(String.Concat("<td>", report.Tables(0).Rows(i)(4).ToString(), "</td>"))
                    ofile.Write(String.Concat("<td>", report.Tables(0).Rows(i)(5).ToString(), "</td>"))
                    ofile.WriteLine(String.Concat("<td>", report.Tables(0).Rows(i)(6).ToString(), "</td>"))
                    ofile.WriteLine("</tr>")
                    If (red) Then
                        ofile.WriteLine("</font>")
                    End If
                Next

            End If
        End If
        ofile.WriteLine("</table>")
        ofile.WriteLine("</body>")
        ofile.WriteLine("</html>")
        ofile.Close()
        If ConvertToPdf(filepath) = False Then
            Process.Start(filepath)
        End If
    End Sub
End Class