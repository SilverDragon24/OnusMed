Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class GSTReport
    Private Sub btnCustomReport_Click(sender As Object, e As EventArgs) Handles btnCustomReport.Click
        Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
        Dim folderpath As String = String.Concat(docpath, "\Onus_GSTR1")
        If (Not Directory.Exists(folderpath)) Then
            Directory.CreateDirectory(folderpath)
        End If
        Dim now As DateTime = DateTime.Now
        Dim filepath As String = String.Concat(folderpath, "\Onus_GSTR1_", now.ToString("MM.dd.yyyy_HH.mm.ss"), ".html")
        Using fileStream As System.IO.FileStream = System.IO.File.Create(filepath)
        End Using
        Dim file As StreamWriter = New StreamWriter(filepath)
        file.WriteLine("<html>")
        file.WriteLine("<title>GSTR-1 Report</title>")
        file.WriteLine("<head>")
        file.WriteLine("<style media=""screen"" type=""text/css"">")
        file.WriteLine("@media print {")
        file.WriteLine("thead {display: table-header-group;}")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")
        file.WriteLine("<center><h1>GSTR-1 Report</h1></center>")
        file.WriteLine("<table border=1 width=100%>")
        Dim invoices As DataSet = New DataSet()
        now = dateFrom.Value
        Dim dfrom As String = now.ToString("yyyy-MM-dd")
        now = dateTo.Value
        Dim dto As String = now.ToString("yyyy-MM-dd")
        selectData(String.Concat(New String() {"select invoice_no from sales where (idate between '", dfrom, "' and '", dto, "');"}), invoices)
        file.WriteLine("<tr><th>Invoice No.</th><th>Date</th><th>Name</th><th>Taxable Amount</th><th>CGST</th><th>SGST</th><th>IGST</th></tr>")
        Dim ino As String = ""
        Dim idate As String = ""
        Dim name As String = ""
        Dim gross As Double = 0
        Dim cgst As Double = 0
        Dim sgst As Double = 0
        Dim igst As Double = 0
        Dim rgross As Double = 0
        Dim rcgst As Double = 0
        Dim rsgst As Double = 0
        Dim rigst As Double = 0
        Dim tgross As Double = 0
        Dim tcgst As Double = 0
        Dim tsgst As Double = 0
        Dim tigst As Double = 0
        Try
            If (invoices.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = invoices.Tables(0).Rows.Count - 1
                Dim i As Integer = 0
                Do
                    Dim info As DataSet = New DataSet()
                    Dim returns As DataSet = New DataSet()
                    selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales where invoice_no='", invoices.Tables(0).Rows(i)(0).ToString(), "';"), info)
                    selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales_r where invoice_no='", invoices.Tables(0).Rows(i)(0).ToString(), "';"), returns)
                    ino = info.Tables(0).Rows(0)(0).ToString()
                    idate = info.Tables(0).Rows(0)(1).ToString()
                    name = info.Tables(0).Rows(0)(2).ToString()
                    Dim num As Integer = info.Tables(0).Rows.Count - 1
                    Dim num1 As Integer = 0
                    Do
                        gross += Convert.ToDouble(Math.Round(Convert.ToDecimal(info.Tables(0).Rows(num1)(3).ToString()), 2))
                        cgst += Convert.ToDouble(Math.Round(Convert.ToDecimal(info.Tables(0).Rows(num1)(4).ToString()), 2))
                        sgst += Convert.ToDouble(Math.Round(Convert.ToDecimal(info.Tables(0).Rows(num1)(5).ToString()), 2))
                        igst += Convert.ToDouble(Math.Round(Convert.ToDecimal(info.Tables(0).Rows(num1)(6).ToString()), 2))
                        num1 = num1 + 1
                    Loop While num1 <= num
                    If (returns.Tables(0).Rows.Count > 0) Then
                        Dim count1 As Integer = returns.Tables(0).Rows.Count - 1
                        For j As Integer = 0 To count1 Step 1
                            rgross += Convert.ToDouble(Math.Round(Convert.ToDecimal(returns.Tables(0).Rows(j)(3).ToString()), 2))
                            rcgst += Convert.ToDouble(Math.Round(Convert.ToDecimal(returns.Tables(0).Rows(j)(4).ToString()), 2))
                            rsgst += Convert.ToDouble(Math.Round(Convert.ToDecimal(returns.Tables(0).Rows(j)(5).ToString()), 2))
                            rigst += Convert.ToDouble(Math.Round(Convert.ToDecimal(returns.Tables(0).Rows(j)(6).ToString()), 2))
                        Next

                    End If
                    gross -= rgross
                    cgst -= rcgst
                    sgst -= rsgst
                    igst -= rigst
                    tgross += gross
                    tcgst += cgst
                    tsgst += sgst
                    tigst += igst
                    file.Write("<tr>")
                    file.Write(String.Concat("<td>", ino.ToString(), "</td>"))
                    file.Write(String.Concat("<td>", idate.ToString(), "</td>"))
                    file.Write(String.Concat("<td>", name.ToString(), "</td>"))
                    file.Write(String.Concat("<td>", gross.ToString(), "</td>"))
                    file.Write(String.Concat("<td>", cgst.ToString(), "</td>"))
                    file.Write(String.Concat("<td>", sgst.ToString(), "</td>"))
                    file.Write(String.Concat("<td>", igst.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                    gross = 0
                    cgst = 0
                    sgst = 0
                    igst = 0
                    rgross = 0
                    rcgst = 0
                    rsgst = 0
                    rigst = 0
                    i = i + 1
                Loop While i <= count
                file.Write("<tr>")
                file.Write("<td></td><td></td><td>Totals</td>")
                file.Write(String.Concat("<td>", tgross.ToString(), "</td>"))
                file.Write(String.Concat("<td>", tcgst.ToString(), "</td>"))
                file.Write(String.Concat("<td>", tsgst.ToString(), "</td>"))
                file.Write(String.Concat("<td>", tigst.ToString(), "</td>"))
                file.WriteLine("</tr>")
                file.Write("<tr>")
                file.Write("<td></td><td></td><td>Total tax</td>")
                file.Write("<td></td><td></td><td></td>")
                Dim num2 As Double = tcgst + tsgst + tigst
                file.Write(String.Concat("<td>", num2.ToString(), "</td>"))
                file.WriteLine("</tr>")
            End If
        Catch exception As System.Exception

        End Try
        file.WriteLine("</table>")
        file.WriteLine("</body>")
        file.WriteLine("</html>")
        file.Close()
        Process.Start(filepath)
    End Sub

    Private Sub btnQReport_Click(sender As Object, e As EventArgs) Handles btnQReport.Click
        Dim today As DateTime
        Dim num As Integer
        Dim num1 As Double
        If (radioQ1.Checked) Then
            Dim num2 As Integer = 0
            If (DateTime.Today.Month > 3) Then
                num2 = DateTime.Today.Year
            ElseIf (DateTime.Today.Month <= 3) Then
                today = DateTime.Today
                num2 = today.Year - 1
            End If
            Dim str As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
            Dim str1 As String = String.Concat(str, "\Onus_GSTR1")
            If (Not Directory.Exists(str1)) Then
                Directory.CreateDirectory(str1)
            End If
            Dim strArrays() As String = {str1, "\Onus_GSTR1_Q1_", num2.ToString(), "-", Nothing, Nothing, Nothing, Nothing}
            num = num2 + 1
            strArrays(4) = num.ToString()
            strArrays(5) = "_"
            today = DateTime.Now
            strArrays(6) = today.ToString("MM.dd.yyyy_HH.mm.ss")
            strArrays(7) = ".html"
            Dim str2 As String = String.Concat(strArrays)
            Using fileStream As System.IO.FileStream = System.IO.File.Create(str2)
            End Using
            Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(str2)
            streamWriter.WriteLine("<html>")
            Dim strArrays1() As String = {"<title>GSTR-1 Report for Quarter 1 of ", num2.ToString(), "-", Nothing, Nothing}
            num = num2 + 1
            strArrays1(3) = num.ToString()
            strArrays1(4) = "</title>"
            streamWriter.WriteLine(String.Concat(strArrays1))
            streamWriter.WriteLine("<head>")
            streamWriter.WriteLine("<style media=""screen"" type=""text/css"">")
            streamWriter.WriteLine("@media print {")
            streamWriter.WriteLine("thead {display: table-header-group;}")
            streamWriter.WriteLine("}")
            streamWriter.WriteLine("</style>")
            streamWriter.WriteLine("</head>")
            streamWriter.WriteLine("<body>")
            Dim strArrays2() As String = {"<center><h1>GSTR-1 Report for Quarter 1 of ", num2.ToString(), "-", Nothing, Nothing}
            num = num2 + 1
            strArrays2(3) = num.ToString()
            strArrays2(4) = "</h1></center>"
            streamWriter.WriteLine(String.Concat(strArrays2))
            streamWriter.WriteLine("<table border=1 width=100%>")
            Dim dataSet As DataSet = New DataSet()
            today = dateFrom.Value
            today.ToString("yyyy-MM-dd")
            today = dateTo.Value
            today.ToString("yyyy-MM-dd")
            selectData(String.Concat(New String() {"select invoice_no from sales where (idate between '", num2.ToString(), "-04-01' and '", num2.ToString(), "-06-31');"}), dataSet)
            streamWriter.WriteLine("<tr><th>Invoice No.</th><th>Date</th><th>Name</th><th>Taxable Amount</th><th>CGST</th><th>SGST</th><th>IGST</th></tr>")
            Dim str3 As String = ""
            Dim str4 As String = ""
            Dim str5 As String = ""
            Dim num3 As Double = 0
            Dim num4 As Double = 0
            Dim num5 As Double = 0
            Dim num6 As Double = 0
            Dim num7 As Double = 0
            Dim num8 As Double = 0
            Dim num9 As Double = 0
            Dim num10 As Double = 0
            Dim num11 As Double = 0
            Dim num12 As Double = 0
            Dim num13 As Double = 0
            Dim num14 As Double = 0
            Try
                If (dataSet.Tables(0).Rows.Count > 0) Then
                    Dim count As Integer = dataSet.Tables(0).Rows.Count - 1
                    Dim num15 As Integer = 0
                    Do
                        Dim dataSet1 As DataSet = New DataSet()
                        Dim dataSet2 As DataSet = New DataSet()
                        selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales where invoice_no='", dataSet.Tables(0).Rows(num15)(0).ToString(), "';"), dataSet1)
                        selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales_r where invoice_no='", dataSet.Tables(0).Rows(num15)(0).ToString(), "';"), dataSet2)
                        str3 = dataSet1.Tables(0).Rows(0)(0).ToString()
                        str4 = dataSet1.Tables(0).Rows(0)(1).ToString()
                        str5 = dataSet1.Tables(0).Rows(0)(2).ToString()
                        Dim count1 As Integer = dataSet1.Tables(0).Rows.Count - 1
                        Dim num16 As Integer = 0
                        Do
                            num3 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet1.Tables(0).Rows(num16)(3).ToString()), 2))
                            num4 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet1.Tables(0).Rows(num16)(4).ToString()), 2))
                            num5 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet1.Tables(0).Rows(num16)(5).ToString()), 2))
                            num6 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet1.Tables(0).Rows(num16)(6).ToString()), 2))
                            num16 = num16 + 1
                        Loop While num16 <= count1
                        If (dataSet2.Tables(0).Rows.Count > 0) Then
                            Dim count2 As Integer = dataSet2.Tables(0).Rows.Count - 1
                            For i1 As Integer = 0 To count2 Step 1
                                num7 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet2.Tables(0).Rows(i1)(3).ToString()), 2))
                                num8 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet2.Tables(0).Rows(i1)(4).ToString()), 2))
                                num9 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet2.Tables(0).Rows(i1)(5).ToString()), 2))
                                num10 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet2.Tables(0).Rows(i1)(6).ToString()), 2))
                            Next

                        End If
                        num3 -= num7
                        num4 -= num8
                        num5 -= num9
                        num6 -= num10
                        num11 += num3
                        num12 += num4
                        num13 += num5
                        num14 += num6
                        streamWriter.Write("<tr>")
                        streamWriter.Write(String.Concat("<td>", str3.ToString(), "</td>"))
                        streamWriter.Write(String.Concat("<td>", str4.ToString(), "</td>"))
                        streamWriter.Write(String.Concat("<td>", str5.ToString(), "</td>"))
                        streamWriter.Write(String.Concat("<td>", num3.ToString(), "</td>"))
                        streamWriter.Write(String.Concat("<td>", num4.ToString(), "</td>"))
                        streamWriter.Write(String.Concat("<td>", num5.ToString(), "</td>"))
                        streamWriter.Write(String.Concat("<td>", num6.ToString(), "</td>"))
                        streamWriter.WriteLine("</tr>")
                        num3 = 0
                        num4 = 0
                        num5 = 0
                        num6 = 0
                        num7 = 0
                        num8 = 0
                        num9 = 0
                        num10 = 0
                        num15 = num15 + 1
                    Loop While num15 <= count
                    streamWriter.Write("<tr>")
                    streamWriter.Write("<td></td><td></td><td>Totals</td>")
                    streamWriter.Write(String.Concat("<td>", num11.ToString(), "</td>"))
                    streamWriter.Write(String.Concat("<td>", num12.ToString(), "</td>"))
                    streamWriter.Write(String.Concat("<td>", num13.ToString(), "</td>"))
                    streamWriter.Write(String.Concat("<td>", num14.ToString(), "</td>"))
                    streamWriter.WriteLine("</tr>")
                    streamWriter.Write("<tr>")
                    streamWriter.Write("<td></td><td></td><td>Total tax</td>")
                    streamWriter.Write("<td></td><td></td><td></td>")
                    num1 = num12 + num13 + num14
                    streamWriter.Write(String.Concat("<td>", num1.ToString(), "</td>"))
                    streamWriter.WriteLine("</tr>")
                End If
            Catch exception As System.Exception

            End Try
            streamWriter.WriteLine("</table>")
            streamWriter.WriteLine("</body>")
            streamWriter.WriteLine("</html>")
            streamWriter.Close()
            Process.Start(str2)
        ElseIf (radioQ2.Checked) Then
            Dim num17 As Integer = 0
            If (DateTime.Today.Month > 3) Then
                num17 = DateTime.Today.Year
            ElseIf (DateTime.Today.Month <= 3) Then
                today = DateTime.Today
                num17 = today.Year - 1
            End If
            Dim str6 As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
            Dim str7 As String = String.Concat(str6, "\Onus_GSTR1")
            If (Not Directory.Exists(str7)) Then
                Directory.CreateDirectory(str7)
            End If
            Dim strArrays3() As String = {str7, "\Onus_GSTR1_Q2_", num17.ToString(), "-", Nothing, Nothing, Nothing, Nothing}
            num = num17 + 1
            strArrays3(4) = num.ToString()
            strArrays3(5) = "_"
            today = DateTime.Now
            strArrays3(6) = today.ToString("MM.dd.yyyy_HH.mm.ss")
            strArrays3(7) = ".html"
            Dim str8 As String = String.Concat(strArrays3)
            Using fileStream1 As System.IO.FileStream = System.IO.File.Create(str8)
            End Using
            Dim streamWriter1 As System.IO.StreamWriter = New System.IO.StreamWriter(str8)
            streamWriter1.WriteLine("<html>")
            Dim strArrays4() As String = {"<title>GSTR-1 Report for Quarter 2 of ", num17.ToString(), "-", Nothing, Nothing}
            num = num17 + 1
            strArrays4(3) = num.ToString()
            strArrays4(4) = "</title>"
            streamWriter1.WriteLine(String.Concat(strArrays4))
            streamWriter1.WriteLine("<head>")
            streamWriter1.WriteLine("<style media=""screen"" type=""text/css"">")
            streamWriter1.WriteLine("@media print {")
            streamWriter1.WriteLine("thead {display: table-header-group;}")
            streamWriter1.WriteLine("}")
            streamWriter1.WriteLine("</style>")
            streamWriter1.WriteLine("</head>")
            streamWriter1.WriteLine("<body>")
            Dim strArrays5() As String = {"<center><h1>GSTR-1 Report for Quarter 2 of ", num17.ToString(), "-", Nothing, Nothing}
            num = num17 + 1
            strArrays5(3) = num.ToString()
            strArrays5(4) = "</h1></center>"
            streamWriter1.WriteLine(String.Concat(strArrays5))
            streamWriter1.WriteLine("<table border=1 width=100%>")
            Dim dataSet3 As DataSet = New DataSet()
            today = dateFrom.Value
            today.ToString("yyyy-MM-dd")
            today = dateTo.Value
            today.ToString("yyyy-MM-dd")
            selectData(String.Concat(New String() {"select invoice_no from sales where (idate between '", num17.ToString(), "-07-01' and '", num17.ToString(), "-09-31');"}), dataSet3)
            streamWriter1.WriteLine("<tr><th>Invoice No.</th><th>Date</th><th>Name</th><th>Taxable Amount</th><th>CGST</th><th>SGST</th><th>IGST</th></tr>")
            Dim str9 As String = ""
            Dim str10 As String = ""
            Dim str11 As String = ""
            Dim num18 As Double = 0
            Dim num19 As Double = 0
            Dim num20 As Double = 0
            Dim num21 As Double = 0
            Dim num22 As Double = 0
            Dim num23 As Double = 0
            Dim num24 As Double = 0
            Dim num25 As Double = 0
            Dim num26 As Double = 0
            Dim num27 As Double = 0
            Dim num28 As Double = 0
            Dim num29 As Double = 0
            Try
                If (dataSet3.Tables(0).Rows.Count > 0) Then
                    Dim count3 As Integer = dataSet3.Tables(0).Rows.Count - 1
                    Dim num30 As Integer = 0
                    Do
                        Dim dataSet4 As DataSet = New DataSet()
                        Dim dataSet5 As DataSet = New DataSet()
                        selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales where invoice_no='", dataSet3.Tables(0).Rows(num30)(0).ToString(), "';"), dataSet4)
                        selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales_r where invoice_no='", dataSet3.Tables(0).Rows(num30)(0).ToString(), "';"), dataSet5)
                        str9 = dataSet4.Tables(0).Rows(0)(0).ToString()
                        str10 = dataSet4.Tables(0).Rows(0)(1).ToString()
                        str11 = dataSet4.Tables(0).Rows(0)(2).ToString()
                        Dim count4 As Integer = dataSet4.Tables(0).Rows.Count - 1
                        Dim num31 As Integer = 0
                        Do
                            num18 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet4.Tables(0).Rows(num31)(3).ToString()), 2))
                            num19 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet4.Tables(0).Rows(num31)(4).ToString()), 2))
                            num20 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet4.Tables(0).Rows(num31)(5).ToString()), 2))
                            num21 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet4.Tables(0).Rows(num31)(6).ToString()), 2))
                            num31 = num31 + 1
                        Loop While num31 <= count4
                        If (dataSet5.Tables(0).Rows.Count > 0) Then
                            Dim count5 As Integer = dataSet5.Tables(0).Rows.Count - 1
                            For j1 As Integer = 0 To count5 Step 1
                                num22 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet5.Tables(0).Rows(j1)(3).ToString()), 2))
                                num23 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet5.Tables(0).Rows(j1)(4).ToString()), 2))
                                num24 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet5.Tables(0).Rows(j1)(5).ToString()), 2))
                                num25 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet5.Tables(0).Rows(j1)(6).ToString()), 2))
                            Next

                        End If
                        num18 -= num22
                        num19 -= num23
                        num20 -= num24
                        num21 -= num25
                        num26 += num18
                        num27 += num19
                        num28 += num20
                        num29 += num21
                        streamWriter1.Write("<tr>")
                        streamWriter1.Write(String.Concat("<td>", str9.ToString(), "</td>"))
                        streamWriter1.Write(String.Concat("<td>", str10.ToString(), "</td>"))
                        streamWriter1.Write(String.Concat("<td>", str11.ToString(), "</td>"))
                        streamWriter1.Write(String.Concat("<td>", num18.ToString(), "</td>"))
                        streamWriter1.Write(String.Concat("<td>", num19.ToString(), "</td>"))
                        streamWriter1.Write(String.Concat("<td>", num20.ToString(), "</td>"))
                        streamWriter1.Write(String.Concat("<td>", num21.ToString(), "</td>"))
                        streamWriter1.WriteLine("</tr>")
                        num18 = 0
                        num19 = 0
                        num20 = 0
                        num21 = 0
                        num22 = 0
                        num23 = 0
                        num24 = 0
                        num25 = 0
                        num30 = num30 + 1
                    Loop While num30 <= count3
                    streamWriter1.Write("<tr>")
                    streamWriter1.Write("<td></td><td></td><td>Totals</td>")
                    streamWriter1.Write(String.Concat("<td>", num26.ToString(), "</td>"))
                    streamWriter1.Write(String.Concat("<td>", num27.ToString(), "</td>"))
                    streamWriter1.Write(String.Concat("<td>", num28.ToString(), "</td>"))
                    streamWriter1.Write(String.Concat("<td>", num29.ToString(), "</td>"))
                    streamWriter1.WriteLine("</tr>")
                    streamWriter1.Write("<tr>")
                    streamWriter1.Write("<td></td><td></td><td>Total tax</td>")
                    streamWriter1.Write("<td></td><td></td><td></td>")
                    num1 = num27 + num28 + num29
                    streamWriter1.Write(String.Concat("<td>", num1.ToString(), "</td>"))
                    streamWriter1.WriteLine("</tr>")
                End If
            Catch exception1 As System.Exception

            End Try
            streamWriter1.WriteLine("</table>")
            streamWriter1.WriteLine("</body>")
            streamWriter1.WriteLine("</html>")
            streamWriter1.Close()
            Process.Start(str8)
        ElseIf (radioQ3.Checked) Then
            Dim num32 As Integer = 0
            If (DateTime.Today.Month > 3) Then
                num32 = DateTime.Today.Year
            ElseIf (DateTime.Today.Month <= 3) Then
                today = DateTime.Today
                num32 = today.Year - 1
            End If
            Dim str12 As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
            Dim str13 As String = String.Concat(str12, "\Onus_GSTR1")
            If (Not Directory.Exists(str13)) Then
                Directory.CreateDirectory(str13)
            End If
            Dim strArrays6() As String = {str13, "\Onus_GSTR1_Q3_", num32.ToString(), "-", Nothing, Nothing, Nothing, Nothing}
            num = num32 + 1
            strArrays6(4) = num.ToString()
            strArrays6(5) = "_"
            today = DateTime.Now
            strArrays6(6) = today.ToString("MM.dd.yyyy_HH.mm.ss")
            strArrays6(7) = ".html"
            Dim str14 As String = String.Concat(strArrays6)
            Using fileStream2 As System.IO.FileStream = System.IO.File.Create(str14)
            End Using
            Dim streamWriter2 As System.IO.StreamWriter = New System.IO.StreamWriter(str14)
            streamWriter2.WriteLine("<html>")
            Dim strArrays7() As String = {"<title>GSTR-1 Report for Quarter 3 of ", num32.ToString(), "-", Nothing, Nothing}
            num = num32 + 1
            strArrays7(3) = num.ToString()
            strArrays7(4) = "</title>"
            streamWriter2.WriteLine(String.Concat(strArrays7))
            streamWriter2.WriteLine("<head>")
            streamWriter2.WriteLine("<style media=""screen"" type=""text/css"">")
            streamWriter2.WriteLine("@media print {")
            streamWriter2.WriteLine("thead {display: table-header-group;}")
            streamWriter2.WriteLine("}")
            streamWriter2.WriteLine("</style>")
            streamWriter2.WriteLine("</head>")
            streamWriter2.WriteLine("<body>")
            Dim strArrays8() As String = {"<center><h1>GSTR-1 Report for Quarter 3 of ", num32.ToString(), "-", Nothing, Nothing}
            num = num32 + 1
            strArrays8(3) = num.ToString()
            strArrays8(4) = "</h1></center>"
            streamWriter2.WriteLine(String.Concat(strArrays8))
            streamWriter2.WriteLine("<table border=1 width=100%>")
            Dim dataSet6 As DataSet = New DataSet()
            today = dateFrom.Value
            today.ToString("yyyy-MM-dd")
            today = dateTo.Value
            today.ToString("yyyy-MM-dd")
            selectData(String.Concat(New String() {"select invoice_no from sales where (idate between '", num32.ToString(), "-10-01' and '", num32.ToString(), "-12-31');"}), dataSet6)
            streamWriter2.WriteLine("<tr><th>Invoice No.</th><th>Date</th><th>Name</th><th>Taxable Amount</th><th>CGST</th><th>SGST</th><th>IGST</th></tr>")
            Dim str15 As String = ""
            Dim str16 As String = ""
            Dim str17 As String = ""
            Dim num33 As Double = 0
            Dim num34 As Double = 0
            Dim num35 As Double = 0
            Dim num36 As Double = 0
            Dim num37 As Double = 0
            Dim num38 As Double = 0
            Dim num39 As Double = 0
            Dim num40 As Double = 0
            Dim num41 As Double = 0
            Dim num42 As Double = 0
            Dim num43 As Double = 0
            Dim num44 As Double = 0
            Try
                If (dataSet6.Tables(0).Rows.Count > 0) Then
                    Dim count6 As Integer = dataSet6.Tables(0).Rows.Count - 1
                    Dim num45 As Integer = 0
                    Do
                        Dim dataSet7 As DataSet = New DataSet()
                        Dim dataSet8 As DataSet = New DataSet()
                        selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales where invoice_no='", dataSet6.Tables(0).Rows(num45)(0).ToString(), "';"), dataSet7)
                        selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales_r where invoice_no='", dataSet6.Tables(0).Rows(num45)(0).ToString(), "';"), dataSet8)
                        str15 = dataSet7.Tables(0).Rows(0)(0).ToString()
                        str16 = dataSet7.Tables(0).Rows(0)(1).ToString()
                        str17 = dataSet7.Tables(0).Rows(0)(2).ToString()
                        Dim count7 As Integer = dataSet7.Tables(0).Rows.Count - 1
                        Dim num46 As Integer = 0
                        Do
                            num33 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet7.Tables(0).Rows(num46)(3).ToString()), 2))
                            num34 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet7.Tables(0).Rows(num46)(4).ToString()), 2))
                            num35 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet7.Tables(0).Rows(num46)(5).ToString()), 2))
                            num36 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet7.Tables(0).Rows(num46)(6).ToString()), 2))
                            num46 = num46 + 1
                        Loop While num46 <= count7
                        If (dataSet8.Tables(0).Rows.Count > 0) Then
                            Dim count8 As Integer = dataSet8.Tables(0).Rows.Count - 1
                            For k As Integer = 0 To count8 Step 1
                                num37 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet8.Tables(0).Rows(k)(3).ToString()), 2))
                                num38 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet8.Tables(0).Rows(k)(4).ToString()), 2))
                                num39 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet8.Tables(0).Rows(k)(5).ToString()), 2))
                                num40 += Convert.ToDouble(Math.Round(Convert.ToDecimal(dataSet8.Tables(0).Rows(k)(6).ToString()), 2))
                            Next

                        End If
                        num33 -= num37
                        num34 -= num38
                        num35 -= num39
                        num36 -= num40
                        num41 += num33
                        num42 += num34
                        num43 += num35
                        num44 += num36
                        streamWriter2.Write("<tr>")
                        streamWriter2.Write(String.Concat("<td>", str15.ToString(), "</td>"))
                        streamWriter2.Write(String.Concat("<td>", str16.ToString(), "</td>"))
                        streamWriter2.Write(String.Concat("<td>", str17.ToString(), "</td>"))
                        streamWriter2.Write(String.Concat("<td>", num33.ToString(), "</td>"))
                        streamWriter2.Write(String.Concat("<td>", num34.ToString(), "</td>"))
                        streamWriter2.Write(String.Concat("<td>", num35.ToString(), "</td>"))
                        streamWriter2.Write(String.Concat("<td>", num36.ToString(), "</td>"))
                        streamWriter2.WriteLine("</tr>")
                        num33 = 0
                        num34 = 0
                        num35 = 0
                        num36 = 0
                        num37 = 0
                        num38 = 0
                        num39 = 0
                        num40 = 0
                        num45 = num45 + 1
                    Loop While num45 <= count6
                    streamWriter2.Write("<tr>")
                    streamWriter2.Write("<td></td><td></td><td>Totals</td>")
                    streamWriter2.Write(String.Concat("<td>", num41.ToString(), "</td>"))
                    streamWriter2.Write(String.Concat("<td>", num42.ToString(), "</td>"))
                    streamWriter2.Write(String.Concat("<td>", num43.ToString(), "</td>"))
                    streamWriter2.Write(String.Concat("<td>", num44.ToString(), "</td>"))
                    streamWriter2.WriteLine("</tr>")
                    streamWriter2.Write("<tr>")
                    streamWriter2.Write("<td></td><td></td><td>Total tax</td>")
                    streamWriter2.Write("<td></td><td></td><td></td>")
                    num1 = num42 + num43 + num44
                    streamWriter2.Write(String.Concat("<td>", num1.ToString(), "</td>"))
                    streamWriter2.WriteLine("</tr>")
                End If
            Catch exception2 As System.Exception

            End Try
            streamWriter2.WriteLine("</table>")
            streamWriter2.WriteLine("</body>")
            streamWriter2.WriteLine("</html>")
            streamWriter2.Close()
            Process.Start(str14)
        ElseIf (radioQ4.Checked) Then
            Dim year As Integer = 0
            If (DateTime.Today.Month > 3) Then
                year = DateTime.Today.Year
            ElseIf (DateTime.Today.Month <= 3) Then
                today = DateTime.Today
                year = today.Year - 1
            End If
            Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
            Dim folderpath As String = String.Concat(docpath, "\Onus_GSTR1")
            If (Not Directory.Exists(folderpath)) Then
                Directory.CreateDirectory(folderpath)
            End If
            Dim strArrays9() As String = {folderpath, "\Onus_GSTR1_Q4_", year.ToString(), "-", Nothing, Nothing, Nothing, Nothing}
            num = year + 1
            strArrays9(4) = num.ToString()
            strArrays9(5) = "_"
            today = DateTime.Now
            strArrays9(6) = today.ToString("MM.dd.yyyy_HH.mm.ss")
            strArrays9(7) = ".html"
            Dim filepath As String = String.Concat(strArrays9)
            Using fileStream3 As System.IO.FileStream = System.IO.File.Create(filepath)
            End Using
            Dim file As System.IO.StreamWriter = New System.IO.StreamWriter(filepath)
            file.WriteLine("<html>")
            Dim strArrays10() As String = {"<title>GSTR-1 Report for Quarter 4 of ", year.ToString(), "-", Nothing, Nothing}
            num = year + 1
            strArrays10(3) = num.ToString()
            strArrays10(4) = "</title>"
            file.WriteLine(String.Concat(strArrays10))
            file.WriteLine("<head>")
            file.WriteLine("<style media=""screen"" type=""text/css"">")
            file.WriteLine("@media print {")
            file.WriteLine("thead {display: table-header-group;}")
            file.WriteLine("}")
            file.WriteLine("</style>")
            file.WriteLine("</head>")
            file.WriteLine("<body>")
            Dim strArrays11() As String = {"<center><h1>GSTR-1 Report for Quarter 4 of ", year.ToString(), "-", Nothing, Nothing}
            num = year + 1
            strArrays11(3) = num.ToString()
            strArrays11(4) = "</h1></center>"
            file.WriteLine(String.Concat(strArrays11))
            file.WriteLine("<table border=1 width=100%>")
            Dim invoices As DataSet = New DataSet()
            today = dateFrom.Value
            today.ToString("yyyy-MM-dd")
            today = dateTo.Value
            today.ToString("yyyy-MM-dd")
            Dim strArrays12() As String = {"select invoice_no from sales where (idate between '", Nothing, Nothing, Nothing, Nothing}
            num = year + 1
            strArrays12(1) = num.ToString()
            strArrays12(2) = "-01-01' and '"
            num = year + 1
            strArrays12(3) = num.ToString()
            strArrays12(4) = "-03-31');"
            selectData(String.Concat(strArrays12), invoices)
            file.WriteLine("<tr><th>Invoice No.</th><th>Date</th><th>Name</th><th>Taxable Amount</th><th>CGST</th><th>SGST</th><th>IGST</th></tr>")
            Dim ino As String = ""
            Dim idate As String = ""
            Dim name As String = ""
            Dim gross As Double = 0
            Dim cgst As Double = 0
            Dim sgst As Double = 0
            Dim igst As Double = 0
            Dim rgross As Double = 0
            Dim rcgst As Double = 0
            Dim rsgst As Double = 0
            Dim rigst As Double = 0
            Dim tgross As Double = 0
            Dim tcgst As Double = 0
            Dim tsgst As Double = 0
            Dim tigst As Double = 0
            Try
                If (invoices.Tables(0).Rows.Count > 0) Then
                    Dim count9 As Integer = invoices.Tables(0).Rows.Count - 1
                    Dim i As Integer = 0
                    Do
                        Dim info As DataSet = New DataSet()
                        Dim returns As DataSet = New DataSet()
                        selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales where invoice_no='", invoices.Tables(0).Rows(i)(0).ToString(), "';"), info)
                        selectData(String.Concat("select invoice_no,date_format(idate,'%d-%b-%Y'),pname,(pieceq*piece_mrp),(cgst/100)*(pieceq*piece_mrp),(sgst/100)*(pieceq*piece_mrp),(igst/100)*(pieceq*piece_mrp) from sales_r where invoice_no='", invoices.Tables(0).Rows(i)(0).ToString(), "';"), returns)
                        ino = info.Tables(0).Rows(0)(0).ToString()
                        idate = info.Tables(0).Rows(0)(1).ToString()
                        name = info.Tables(0).Rows(0)(2).ToString()
                        Dim count10 As Integer = info.Tables(0).Rows.Count - 1
                        Dim num47 As Integer = 0
                        Do
                            gross += Convert.ToDouble(Math.Round(Convert.ToDecimal(info.Tables(0).Rows(num47)(3).ToString()), 2))
                            cgst += Convert.ToDouble(Math.Round(Convert.ToDecimal(info.Tables(0).Rows(num47)(4).ToString()), 2))
                            sgst += Convert.ToDouble(Math.Round(Convert.ToDecimal(info.Tables(0).Rows(num47)(5).ToString()), 2))
                            igst += Convert.ToDouble(Math.Round(Convert.ToDecimal(info.Tables(0).Rows(num47)(6).ToString()), 2))
                            num47 = num47 + 1
                        Loop While num47 <= count10
                        If (returns.Tables(0).Rows.Count > 0) Then
                            Dim count11 As Integer = returns.Tables(0).Rows.Count - 1
                            For j As Integer = 0 To count11 Step 1
                                rgross += Convert.ToDouble(Math.Round(Convert.ToDecimal(returns.Tables(0).Rows(j)(3).ToString()), 2))
                                rcgst += Convert.ToDouble(Math.Round(Convert.ToDecimal(returns.Tables(0).Rows(j)(4).ToString()), 2))
                                rsgst += Convert.ToDouble(Math.Round(Convert.ToDecimal(returns.Tables(0).Rows(j)(5).ToString()), 2))
                                rigst += Convert.ToDouble(Math.Round(Convert.ToDecimal(returns.Tables(0).Rows(j)(6).ToString()), 2))
                            Next

                        End If
                        gross -= rgross
                        cgst -= rcgst
                        sgst -= rsgst
                        igst -= rigst
                        tgross += gross
                        tcgst += cgst
                        tsgst += sgst
                        tigst += igst
                        file.Write("<tr>")
                        file.Write(String.Concat("<td>", ino.ToString(), "</td>"))
                        file.Write(String.Concat("<td>", idate.ToString(), "</td>"))
                        file.Write(String.Concat("<td>", name.ToString(), "</td>"))
                        file.Write(String.Concat("<td>", gross.ToString(), "</td>"))
                        file.Write(String.Concat("<td>", cgst.ToString(), "</td>"))
                        file.Write(String.Concat("<td>", sgst.ToString(), "</td>"))
                        file.Write(String.Concat("<td>", igst.ToString(), "</td>"))
                        file.WriteLine("</tr>")
                        gross = 0
                        cgst = 0
                        sgst = 0
                        igst = 0
                        rgross = 0
                        rcgst = 0
                        rsgst = 0
                        rigst = 0
                        i = i + 1
                    Loop While i <= count9
                    file.Write("<tr>")
                    file.Write("<td></td><td></td><td>Totals</td>")
                    file.Write(String.Concat("<td>", tgross.ToString(), "</td>"))
                    file.Write(String.Concat("<td>", tcgst.ToString(), "</td>"))
                    file.Write(String.Concat("<td>", tsgst.ToString(), "</td>"))
                    file.Write(String.Concat("<td>", tigst.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                    file.Write("<tr>")
                    file.Write("<td></td><td></td><td>Total tax</td>")
                    file.Write("<td></td><td></td><td></td>")
                    num1 = tcgst + tsgst + tigst
                    file.Write(String.Concat("<td>", num1.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                End If
            Catch exception3 As System.Exception

            End Try
            file.WriteLine("</table>")
            file.WriteLine("</body>")
            file.WriteLine("</html>")
            file.Close()
            Process.Start(filepath)
        End If
    End Sub

    Private Sub GSTReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (DateTime.Compare(dateFrom.Value, dateTo.Value) <= 0) Then
            btnCustomReport.Enabled = True
        Else
            btnCustomReport.Enabled = False
        End If
        If (Not (Not radioQ1.Checked And Not radioQ2.Checked And Not radioQ3.Checked And Not radioQ4.Checked)) Then
            btnQReport.Enabled = True
        Else
            btnQReport.Enabled = False
        End If
    End Sub
End Class