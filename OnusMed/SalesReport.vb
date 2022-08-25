Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class SalesReport
    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Dim num As Double
        Dim num1 As Decimal
        Dim objectValue As System.Data.DataRow
        Dim num2 As Integer
        Dim objArray As Object()
        Dim flagArray As Boolean()
        Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
        Dim folderpath As String = String.Concat(docpath, "\SaleReports")
        If (Not Directory.Exists(folderpath)) Then
            Directory.CreateDirectory(folderpath)
        End If
        Dim str() As String = {folderpath, "\SaleReport_", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
        Dim value As DateTime = dateFrom.Value
        str(2) = value.ToString("MM-dd-yyyy")
        str(3) = "-"
        value = dateTo.Value
        str(4) = value.ToString("MM-dd-yyyy")
        str(5) = "_"
        value = DateTime.Now
        str(6) = value.ToString("MM.dd.yyyy_HH.mm.ss")
        str(7) = ".html"
        Dim filepath As String = String.Concat(str)
        Using fileStream As System.IO.FileStream = System.IO.File.Create(filepath)
        End Using
        Dim file As System.IO.StreamWriter = New System.IO.StreamWriter(filepath)
        file.WriteLine("<html>")
        Dim strArrays() As String = {"<title>Sales Report from ", Nothing, Nothing, Nothing, Nothing}
        value = dateFrom.Value
        strArrays(1) = value.ToString("MM-dd-yyyy")
        strArrays(2) = " to "
        value = dateTo.Value
        strArrays(3) = value.ToString("MM-dd-yyyy")
        strArrays(4) = "</title>"
        file.WriteLine(String.Concat(strArrays))
        file.WriteLine("<head>")
        file.WriteLine("<style media=""screen"" type=""text/css"">")
        file.WriteLine("@media print {")
        file.WriteLine("thead {display: table-header-group;}")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")
        Dim str1() As String = {"<center><h1>Sales Report from ", Nothing, Nothing, Nothing, Nothing}
        value = dateFrom.Value
        str1(1) = value.ToString("MM-dd-yyyy")
        str1(2) = " to "
        value = dateTo.Value
        str1(3) = value.ToString("MM-dd-yyyy")
        str1(4) = "</h1></center>"
        file.WriteLine(String.Concat(str1))
        file.WriteLine("<table border=1 width=100%>")
        If (radioItem.Checked) Then
            file.WriteLine("<tr>")
            file.WriteLine("<th>Item Code</th>")
            file.WriteLine("<th>Item Name</th>")
            file.WriteLine("<th>Packs</th>")
            file.WriteLine("<th>Strips</th>")
            file.WriteLine("<th>Pieces</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim icodes As System.Data.DataSet = New System.Data.DataSet()
            Dim strArrays1() As String = {"select distinct s.icode,(select m.name from medicine m where m.code=s.icode) from sales s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
            value = dateFrom.Value
            strArrays1(1) = value.ToString("yyyy-MM-dd")
            strArrays1(2) = "' and '"
            value = dateTo.Value
            strArrays1(3) = value.ToString("yyyy-MM-dd")
            strArrays1(4) = "')"
            selectData(String.Concat(strArrays1), icodes)
            If (icodes.Tables(0).Rows.Count > 0) Then
                Dim num3 As Double = 0
                Dim count As Integer = icodes.Tables(0).Rows.Count - 1
                Dim num4 As Integer = 0
                Do
                    file.WriteLine("<tr>")
                    file.WriteLine(String.Concat("<td>", icodes.Tables(0).Rows(num4)(0).ToString(), "</td>"))
                    file.WriteLine(String.Concat("<td>", icodes.Tables(0).Rows(num4)(1).ToString(), "</td>"))
                    Dim num5 As Double = 0
                    Dim num6 As Double = 0
                    Dim num7 As Integer = 0
                    Dim num8 As Double = 0
                    Dim icode_sales As System.Data.DataSet = New System.Data.DataSet()
                    Dim str2() As String = {"select icode,pack_q,stripq,pieceq,amt from sales where icode='", icodes.Tables(0).Rows(num4)(0).ToString(), "' and (idate between '", Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    str2(3) = value.ToString("yyyy-MM-dd")
                    str2(4) = "' and '"
                    value = dateTo.Value
                    str2(5) = value.ToString("yyyy-MM-dd")
                    str2(6) = "')"
                    selectData(String.Concat(str2), icode_sales)
                    If (icode_sales.Tables(0).Rows.Count > 0) Then
                        Dim count1 As Integer = icode_sales.Tables(0).Rows.Count - 1
                        For i1 As Integer = 0 To count1 Step 1
                            num5 += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(icode_sales.Tables(0).Rows(i1)(1))))
                            num6 += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(icode_sales.Tables(0).Rows(i1)(2))))
                            num7 = num7 + Integer.Parse(Conversions.ToString(icode_sales.Tables(0).Rows(i1)(3)))
                            num8 += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(icode_sales.Tables(0).Rows(i1)(4))))
                        Next

                    End If
                    Dim rpackc As Double = 0
                    Dim rstripc As Double = 0
                    Dim rpiecec As Integer = 0
                    Dim num9 As Double = 0
                    Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                    Dim strArrays2() As String = {"select icode,pack_q,stripq,pieceq,(((100-discount)/100)*(pieceq*piece_mrp))+((cgst+sgst+igst+ed)/100)*(pieceq*piece_mrp) from sales_r where icode='", icodes.Tables(0).Rows(num4)(0).ToString(), "' and (idate between '", Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    strArrays2(3) = value.ToString("yyyy-MM-dd")
                    strArrays2(4) = "' and '"
                    value = dateTo.Value
                    strArrays2(5) = value.ToString("yyyy-MM-dd")
                    strArrays2(6) = "')"
                    selectData(String.Concat(strArrays2), dataSet)
                    If (dataSet.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                        Dim count2 As Integer = dataSet.Tables(0).Rows.Count - 1
                        For j1 As Integer = 0 To count2 Step 1
                            rpackc += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(j1)(1))))
                            rstripc += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(j1)(2))))
                            rpiecec = Integer.Parse(Conversions.ToString(dataSet.Tables(0).Rows(j1)(3)))
                            num9 += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(j1)(4))))
                        Next

                    End If
                    num5 -= rpackc
                    num6 -= rstripc
                    num7 = num7 - rpiecec
                    num8 -= num9
                    num = Math.Round(num5, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num6, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    num1 = Math.Round(New Decimal(num7), 2)
                    file.WriteLine(String.Concat("<td>", num1.ToString(), "</td>"))
                    num = Math.Round(num8, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                    num3 += num8
                    num4 = num4 + 1
                Loop While num4 <= count
                file.WriteLine("<tr>")
                file.WriteLine("<td colspan=5>Total</td>")
                num = Math.Round(num3, 2)
                file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                file.WriteLine("</tr>")
            End If
        ElseIf (radioBatch.Checked) Then
            file.WriteLine("<tr>")
            file.WriteLine("<th>Batch Code</th>")
            file.WriteLine("<th>Item Code</th>")
            file.WriteLine("<th>Item Name</th>")
            file.WriteLine("<th>Packs</th>")
            file.WriteLine("<th>Strips</th>")
            file.WriteLine("<th>Piece</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim batches As System.Data.DataSet = New System.Data.DataSet()
            Dim str3() As String = {"select distinct s.batchcode,s.icode,(select m.name from medicine m where m.code=s.icode) from sales s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
            value = dateFrom.Value
            str3(1) = value.ToString("yyyy-MM-dd")
            str3(2) = "' and '"
            value = dateTo.Value
            str3(3) = value.ToString("yyyy-MM-dd")
            str3(4) = "')"
            selectData(String.Concat(str3), batches)
            If (batches.Tables(0).Rows.Count > 0) Then
                Dim tamt As Double = 0
                Dim count3 As Integer = batches.Tables(0).Rows.Count - 1
                Dim num10 As Integer = 0
                Do
                    Dim packc As Double = 0
                    Dim stripc As Double = 0
                    Dim piecec As Integer = 0
                    Dim amt As Double = 0
                    Dim rpack As Double = 0
                    Dim rstrip As Double = 0
                    Dim rpiece As Integer = 0
                    Dim ramt As Double = 0
                    Dim dataSet1 As System.Data.DataSet = New System.Data.DataSet()
                    Dim dataSet2 As System.Data.DataSet = New System.Data.DataSet()
                    file.WriteLine("<tr>")
                    file.WriteLine(String.Concat("<td>", batches.Tables(0).Rows(num10)(0).ToString(), "</td>"))
                    file.WriteLine(String.Concat("<td>", batches.Tables(0).Rows(num10)(1).ToString(), "</td>"))
                    file.WriteLine(String.Concat("<td>", batches.Tables(0).Rows(num10)(2).ToString(), "</td>"))
                    Dim strArrays3() As String = {"select batchcode,pack_q,stripq,pieceq,amt from sales where (idate between '", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    strArrays3(1) = value.ToString("yyyy-MM-dd")
                    strArrays3(2) = "' and '"
                    value = dateTo.Value
                    strArrays3(3) = value.ToString("yyyy-MM-dd")
                    strArrays3(4) = "') and batchcode='"
                    strArrays3(5) = batches.Tables(0).Rows(num10)(0).ToString()
                    strArrays3(6) = "'"
                    selectData(String.Concat(strArrays3), dataSet1)
                    Dim str4() As String = {"select batchcode,pack_q,stripq,pieceq,(((100-discount)/100)*(pieceq*piece_mrp))+((cgst+sgst+igst+ed)/100)*(pieceq*piece_mrp) from sales_r where (idate between '", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    str4(1) = value.ToString("yyyy-MM-dd")
                    str4(2) = "' and '"
                    value = dateTo.Value
                    str4(3) = value.ToString("yyyy-MM-dd")
                    str4(4) = "') and batchcode='"
                    str4(5) = batches.Tables(0).Rows(num10)(0).ToString()
                    str4(6) = "'"
                    selectData(String.Concat(str4), dataSet2)
                    If (dataSet1.Tables(0).Rows.Count > 0) Then
                        Dim count4 As Integer = dataSet1.Tables(0).Rows.Count - 1
                        For k As Integer = 0 To count4 Step 1
                            packc += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(k)(1))))
                            stripc += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(k)(2))))
                            piecec = Convert.ToInt32(Decimal.Add(New Decimal(piecec), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(k)(3)))))
                            amt += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(k)(4))))
                        Next

                    End If
                    If (dataSet2.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                        Dim count5 As Integer = dataSet2.Tables(0).Rows.Count - 1
                        For l As Integer = 0 To count5 Step 1
                            rpack += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(l)(1))))
                            rstrip += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(l)(2))))
                            rpiece = Convert.ToInt32(Decimal.Add(New Decimal(rpiece), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(l)(3)))))
                            ramt += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(l)(4))))
                        Next

                    End If
                    packc -= rpack
                    stripc -= rstrip
                    piecec = piecec - rpiece
                    amt -= ramt
                    num = Math.Round(packc, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(stripc, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    num1 = Math.Round(New Decimal(piecec), 2)
                    file.WriteLine(String.Concat("<td>", num1.ToString(), "</td>"))
                    num = Math.Round(amt, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                    tamt += amt
                    num10 = num10 + 1
                Loop While num10 <= count3
                file.WriteLine("<tr>")
                file.WriteLine("<td colspan=6>Total</td>")
                num = Math.Round(tamt, 2)
                file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                file.WriteLine("</tr>")
            End If
        ElseIf (radioDoctor.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Doctor Reg No.</th>")
            file.Write("<th>Doctor Name</th>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Batch Code</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Amount</th>")
            file.WriteLine("<th>Date (MM-dd-yyyy)</th>")
            file.Write("<th>Transaction Type</th>")
            file.WriteLine("</tr>")
            Dim dataSet3 As System.Data.DataSet = New System.Data.DataSet()
            Dim dataSet4 As System.Data.DataSet = New System.Data.DataSet()
            If (Interaction.MsgBox("How would you like only valid prescriptions filtered?", MsgBoxStyle.YesNo, "Filter Confirmation") <> MsgBoxResult.No) Then
                Dim strArrays4() As String = {"select s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum(s.amt),date_format(s.idate,'%m-%d-%Y') from sales s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
                value = dateFrom.Value
                strArrays4(1) = value.ToString("yyyy-MM-dd")
                strArrays4(2) = "' and '"
                value = dateTo.Value
                strArrays4(3) = value.ToString("yyyy-MM-dd")
                strArrays4(4) = "') and not pdoctor_reg='0' group by s.pdoctor_reg,s.icode,s.batchcode,s.idate"
                selectData(String.Concat(strArrays4), dataSet3)
                Dim str5() As String = {"select s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum((((100-s.discount)/100)*(s.pieceq*s.piece_mrp))+(((s.cgst+s.sgst+s.igst+s.ed)/100)*(s.pieceq*s.piece_mrp))),date_format(s.idate,'%m-%d-%Y') from sales_r s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
                value = dateFrom.Value
                str5(1) = value.ToString("yyyy-MM-dd")
                str5(2) = "' and '"
                value = dateTo.Value
                str5(3) = value.ToString("yyyy-MM-dd")
                str5(4) = "') and not pdoctor_reg='0' group by s.pdoctor_reg,s.icode,s.batchcode,s.idate"
                selectData(String.Concat(str5), dataSet4)
            Else
                Dim strArrays5() As String = {"select s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum(s.amt),date_format(s.idate,'%m-%d-%Y') from sales s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
                value = dateFrom.Value
                strArrays5(1) = value.ToString("yyyy-MM-dd")
                strArrays5(2) = "' and '"
                value = dateTo.Value
                strArrays5(3) = value.ToString("yyyy-MM-dd")
                strArrays5(4) = "') group by s.pdoctor_reg,s.icode,s.batchcode,s.idate"
                selectData(String.Concat(strArrays5), dataSet3)
                Dim str6() As String = {"select s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum((((100-s.discount)/100)*(s.pieceq*s.piece_mrp))+(((s.cgst+s.sgst+s.igst+s.ed)/100)*(s.pieceq*s.piece_mrp))),date_format(s.idate,'%m-%d-%Y') from sales_r s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
                value = dateFrom.Value
                str6(1) = value.ToString("yyyy-MM-dd")
                str6(2) = "' and '"
                value = dateTo.Value
                str6(3) = value.ToString("yyyy-MM-dd")
                str6(4) = "') group by s.pdoctor_reg,s.icode,s.batchcode,s.idate"
                selectData(String.Concat(str6), dataSet4)
            End If
            If (dataSet3.Tables(0).Rows.Count > 0) Then
                Dim count6 As Integer = dataSet3.Tables(0).Rows.Count - 1
                For m As Integer = 0 To count6 Step 1
                    file.WriteLine("<tr>")
                    Dim num11 As Integer = 0
                    Do
                        If (num11 = 10) Then
                            file.WriteLine("<td>Sales</td>")
                        ElseIf (Not (num11 >= 5 And num11 <= 8)) Then
                            file.WriteLine(String.Concat("<td>", dataSet3.Tables(0).Rows(m)(num11).ToString(), "</td>"))
                        Else
                            Dim streamWriter As System.IO.StreamWriter = file
                            Dim type As System.Type = GetType(Math)
                            Dim item(1) As Object
                            Dim dataRow As System.Data.DataRow = dataSet3.Tables(0).Rows(m)
                            objectValue = dataRow
                            Dim num12 As Integer = num11
                            num2 = num12
                            item(0) = dataRow(num12)
                            item(1) = 2
                            objArray = item
                            Dim flagArray1() As Boolean = {True, False}
                            flagArray = flagArray1
                            Dim obj As Object = NewLateBinding.LateGet(Nothing, type, "Round", item, Nothing, Nothing, flagArray1)
                            If (flagArray(0)) Then
                                objectValue(num2) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray(0)))
                            End If
                            streamWriter.WriteLine(String.Concat("<td>", obj.ToString(), "</td>"))
                        End If
                        num11 = num11 + 1
                    Loop While num11 <= 10
                    file.WriteLine("</tr>")
                Next

            End If
            If (dataSet4.Tables(0).Rows.Count > 0) Then
                Dim count7 As Integer = dataSet4.Tables(0).Rows.Count - 1
                For n As Integer = 0 To count7 Step 1
                    file.WriteLine("<tr>")
                    Dim num13 As Integer = 0
                    Do
                        If (num13 = 10) Then
                            file.WriteLine("<td>Return</td>")
                        ElseIf (Not (num13 >= 5 And num13 <= 8)) Then
                            file.WriteLine(String.Concat("<td>", dataSet4.Tables(0).Rows(n)(num13).ToString(), "</td>"))
                        Else
                            Dim streamWriter1 As System.IO.StreamWriter = file
                            Dim type1 As System.Type = GetType(Math)
                            Dim item1(1) As Object
                            Dim dataRow1 As System.Data.DataRow = dataSet4.Tables(0).Rows(n)
                            objectValue = dataRow1
                            Dim num14 As Integer = num13
                            num2 = num14
                            item1(0) = dataRow1(num14)
                            item1(1) = 2
                            objArray = item1
                            Dim flagArray2() As Boolean = {True, False}
                            flagArray = flagArray2
                            Dim obj1 As Object = NewLateBinding.LateGet(Nothing, type1, "Round", item1, Nothing, Nothing, flagArray2)
                            If (flagArray(0)) Then
                                objectValue(num2) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray(0)))
                            End If
                            streamWriter1.WriteLine(String.Concat("<td>", obj1.ToString(), "</td>"))
                        End If
                        num13 = num13 + 1
                    Loop While num13 <= 10
                    file.WriteLine("</tr>")
                Next

            End If
        ElseIf (radioPatient.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Patient ID</th>")
            file.Write("<th>Patient Name</th>")
            file.Write("<th>Doctor Reg No.</th>")
            file.Write("<th>Doctor Name</th>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Batch Code</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Amount</th>")
            file.WriteLine("<th>Date (MM-dd-yyyy)</th>")
            file.WriteLine("<th>Transaction Type</th>")
            file.WriteLine("</tr>")
            Dim sales As System.Data.DataSet = New System.Data.DataSet()
            Dim rsales As System.Data.DataSet = New System.Data.DataSet()
            If (Interaction.MsgBox("Would you like to filter registered patients only?", MsgBoxStyle.YesNo, "Filter Confirmation") <> MsgBoxResult.No) Then
                Dim strArrays6() As String = {"select s.pid,s.pname,s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum(s.amt),date_format(s.idate,'%m-%d-%Y') from sales s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
                value = dateFrom.Value
                strArrays6(1) = value.ToString("yyyy-MM-dd")
                strArrays6(2) = "' and '"
                value = dateTo.Value
                strArrays6(3) = value.ToString("yyyy-MM-dd")
                strArrays6(4) = "') and not s.pid='N/A' group by s.pid,s.pdoctor_reg,s.icode,s.batchcode,s.idate"
                selectData(String.Concat(strArrays6), sales)
                Dim str7() As String = {"select s.pid,s.pname,s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum((((100-s.discount)/100)*(s.pieceq*s.piece_mrp))+(((s.cgst+s.sgst+s.igst+s.ed)/100)*(s.pieceq*s.piece_mrp))),date_format(s.idate,'%m-%d-%Y') from sales_r s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
                value = dateFrom.Value
                str7(1) = value.ToString("yyyy-MM-dd")
                str7(2) = "' and '"
                value = dateTo.Value
                str7(3) = value.ToString("yyyy-MM-dd")
                str7(4) = "') and not s.pid='N/A' group by s.pid,s.pdoctor_reg,s.icode,s.batchcode,s.idate"
                selectData(String.Concat(str7), rsales)
            Else
                Dim strArrays7() As String = {"select s.pid,s.pname,s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum(s.amt),date_format(s.idate,'%m-%d-%Y') from sales s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
                value = dateFrom.Value
                strArrays7(1) = value.ToString("yyyy-MM-dd")
                strArrays7(2) = "' and '"
                value = dateTo.Value
                strArrays7(3) = value.ToString("yyyy-MM-dd")
                strArrays7(4) = "') group by s.pid,s.pdoctor_reg,s.icode,s.batchcode,s.idate"
                selectData(String.Concat(strArrays7), sales)
                Dim str8() As String = {"select s.pid,s.pname,s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum((((100-s.discount)/100)*(s.pieceq*s.piece_mrp))+(((s.cgst+s.sgst+s.igst+s.ed)/100)*(s.pieceq*s.piece_mrp))),date_format(s.idate,'%m-%d-%Y') from sales_r s where (s.idate between '", Nothing, Nothing, Nothing, Nothing}
                value = dateFrom.Value
                str8(1) = value.ToString("yyyy-MM-dd")
                str8(2) = "' and '"
                value = dateTo.Value
                str8(3) = value.ToString("yyyy-MM-dd")
                str8(4) = "') group by s.pid,s.pdoctor_reg,s.icode,s.batchcode,s.idate"
                selectData(String.Concat(str8), rsales)
            End If
            If (sales.Tables(0).Rows.Count > 0) Then
                Dim count8 As Integer = sales.Tables(0).Rows.Count - 1
                For o As Integer = 0 To count8 Step 1
                    file.WriteLine("<tr>")
                    Dim num15 As Integer = 0
                    Do
                        If (num15 = 12) Then
                            file.WriteLine("<td>Sales</td>")
                        ElseIf (Not (num15 >= 7 And num15 <= 10)) Then
                            file.WriteLine(String.Concat("<td>", sales.Tables(0).Rows(o)(num15).ToString(), "</td>"))
                        Else
                            Dim streamWriter2 As System.IO.StreamWriter = file
                            Dim type2 As System.Type = GetType(Math)
                            Dim objArray1(1) As Object
                            Dim item2 As System.Data.DataRow = sales.Tables(0).Rows(o)
                            objectValue = item2
                            Dim num16 As Integer = num15
                            num2 = num16
                            objArray1(0) = item2(num16)
                            objArray1(1) = 2
                            objArray = objArray1
                            Dim flagArray3() As Boolean = {True, False}
                            flagArray = flagArray3
                            Dim obj2 As Object = NewLateBinding.LateGet(Nothing, type2, "Round", objArray1, Nothing, Nothing, flagArray3)
                            If (flagArray(0)) Then
                                objectValue(num2) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray(0)))
                            End If
                            streamWriter2.WriteLine(String.Concat("<td>", obj2.ToString(), "</td>"))
                        End If
                        num15 = num15 + 1
                    Loop While num15 <= 12
                    file.WriteLine("</tr>")
                Next

            End If
            If (rsales.Tables(0).Rows.Count > 0) Then
                Dim count9 As Integer = rsales.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count9 Step 1
                    file.WriteLine("<tr>")
                    Dim j As Integer = 0
                    Do
                        If (j = 12) Then
                            file.WriteLine("<td>Return</td>")
                        ElseIf (Not (j >= 7 And j <= 10)) Then
                            file.WriteLine(String.Concat("<td>", rsales.Tables(0).Rows(i)(j).ToString(), "</td>"))
                        Else
                            Dim streamWriter3 As System.IO.StreamWriter = file
                            Dim type3 As System.Type = GetType(Math)
                            Dim objArray2(1) As Object
                            Dim dataRow2 As System.Data.DataRow = rsales.Tables(0).Rows(i)
                            objectValue = dataRow2
                            Dim num17 As Integer = j
                            num2 = num17
                            objArray2(0) = dataRow2(num17)
                            objArray2(1) = 2
                            objArray = objArray2
                            Dim flagArray4() As Boolean = {True, False}
                            flagArray = flagArray4
                            Dim obj3 As Object = NewLateBinding.LateGet(Nothing, type3, "Round", objArray2, Nothing, Nothing, flagArray4)
                            If (flagArray(0)) Then
                                objectValue(num2) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray(0)))
                            End If
                            streamWriter3.WriteLine(String.Concat("<td>", obj3.ToString(), "</td>"))
                        End If
                        j = j + 1
                    Loop While j <= 12
                    file.WriteLine("</tr>")
                Next

            End If
        End If
        file.WriteLine("</table>")
        file.WriteLine("</body>")
        file.WriteLine("</html>")
        file.Close()
        Process.Start(filepath)
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        Dim num As Double
        Dim num1 As Decimal
        Dim objectValue As System.Data.DataRow
        Dim num2 As Integer
        Dim objArray As Object()
        Dim flagArray As Boolean()
        Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
        Dim folderpath As String = String.Concat(docpath, "\SaleReports")
        If (Not Directory.Exists(folderpath)) Then
            Directory.CreateDirectory(folderpath)
        End If
        Dim now As DateTime = DateTime.Now
        Dim filepath As String = String.Concat(folderpath, "\DailySaleReport_", now.ToString("MM.dd.yyyy_HH.mm.ss"), ".html")
        Using fileStream As System.IO.FileStream = System.IO.File.Create(filepath)
        End Using
        Dim file As System.IO.StreamWriter = New System.IO.StreamWriter(filepath)
        file.WriteLine("<html>")
        now = DateTime.Today
        file.WriteLine(String.Concat("<title>Daily Sales Report for ", now.ToString("MM-dd-yyyy"), "</title>"))
        file.WriteLine("<head>")
        file.WriteLine("<style media=""screen"" type=""text/css"">")
        file.WriteLine("@media print {")
        file.WriteLine("thead {display: table-header-group;}")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")
        now = DateTime.Today
        file.WriteLine(String.Concat("<center><h1>Sales Report for ", now.ToString("MM-dd-yyyy"), "</h1></center>"))
        file.WriteLine("<table border=1 width=100%>")
        If (radioItem.Checked) Then
            file.WriteLine("<tr>")
            file.WriteLine("<th>Item Code</th>")
            file.WriteLine("<th>Item Name</th>")
            file.WriteLine("<th>Packs</th>")
            file.WriteLine("<th>Strips</th>")
            file.WriteLine("<th>Pieces</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim icodes As System.Data.DataSet = New System.Data.DataSet()
            selectData("select distinct icode,(select m.name from medicine m where m.code=s.icode) from sales s where idate=curdate()", icodes)
            If (icodes.Tables(0).Rows.Count > 0) Then
                Dim num3 As Double = 0
                Dim count As Integer = icodes.Tables(0).Rows.Count - 1
                Dim num4 As Integer = 0
                Do
                    file.WriteLine("<tr>")
                    file.WriteLine(String.Concat("<td>", icodes.Tables(0).Rows(num4)(0).ToString(), "</td>"))
                    file.WriteLine(String.Concat("<td>", icodes.Tables(0).Rows(num4)(1).ToString(), "</td>"))
                    Dim num5 As Double = 0
                    Dim num6 As Double = 0
                    Dim num7 As Integer = 0
                    Dim num8 As Double = 0
                    Dim icode_sales As System.Data.DataSet = New System.Data.DataSet()
                    selectData(String.Concat("select icode,pack_q,stripq,pieceq,amt from sales where icode='", icodes.Tables(0).Rows(num4)(0).ToString(), "' and idate=curdate()"), icode_sales)
                    If (icode_sales.Tables(0).Rows.Count > 0) Then
                        Dim count1 As Integer = icode_sales.Tables(0).Rows.Count - 1
                        For i1 As Integer = 0 To count1 Step 1
                            num5 += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(icode_sales.Tables(0).Rows(i1)(1))))
                            num6 += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(icode_sales.Tables(0).Rows(i1)(2))))
                            num7 = num7 + Integer.Parse(Conversions.ToString(icode_sales.Tables(0).Rows(i1)(3)))
                            num8 += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(icode_sales.Tables(0).Rows(i1)(4))))
                        Next

                    End If
                    Dim rpackc As Double = 0
                    Dim rstripc As Double = 0
                    Dim rpiecec As Integer = 0
                    Dim num9 As Double = 0
                    Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                    selectData(String.Concat("select icode,pack_q,stripq,pieceq,(((100-discount)/100)*(pieceq*piece_mrp))+((cgst+sgst+igst+ed)/100)*(pieceq*piece_mrp) from sales_r where icode='", icodes.Tables(0).Rows(num4)(0).ToString(), "' and idate=curdate()"), dataSet)
                    If (dataSet.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                        Dim count2 As Integer = dataSet.Tables(0).Rows.Count - 1
                        For j1 As Integer = 0 To count2 Step 1
                            rpackc += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(j1)(1))))
                            rstripc += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(j1)(2))))
                            rpiecec = Integer.Parse(Conversions.ToString(dataSet.Tables(0).Rows(j1)(3)))
                            num9 += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(j1)(4))))
                        Next

                    End If
                    num5 -= rpackc
                    num6 -= rstripc
                    num7 = num7 - rpiecec
                    num8 -= num9
                    num = Math.Round(num5, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num6, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    num1 = Math.Round(New Decimal(num7), 2)
                    file.WriteLine(String.Concat("<td>", num1.ToString(), "</td>"))
                    num = Math.Round(num8, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                    num3 += num8
                    num4 = num4 + 1
                Loop While num4 <= count
                file.WriteLine("<tr>")
                file.WriteLine("<td colspan=5>Total</td>")
                num = Math.Round(num3, 2)
                file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                file.WriteLine("</tr>")
            End If
        ElseIf (radioBatch.Checked) Then
            file.WriteLine("<tr>")
            file.WriteLine("<th>Batch Code</th>")
            file.WriteLine("<th>Item Code</th>")
            file.WriteLine("<th>Item Name</th>")
            file.WriteLine("<th>Packs</th>")
            file.WriteLine("<th>Strips</th>")
            file.WriteLine("<th>Piece</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim batches As System.Data.DataSet = New System.Data.DataSet()
            selectData("select distinct s.batchcode,s.icode,(select m.name from medicine m where m.code=s.icode) from sales s where s.idate=curdate()", batches)
            If (batches.Tables(0).Rows.Count > 0) Then
                Dim tamt As Double = 0
                Dim count3 As Integer = batches.Tables(0).Rows.Count - 1
                Dim num10 As Integer = 0
                Do
                    Dim packc As Double = 0
                    Dim stripc As Double = 0
                    Dim piecec As Integer = 0
                    Dim amt As Double = 0
                    Dim rpack As Double = 0
                    Dim rstrip As Double = 0
                    Dim rpiece As Integer = 0
                    Dim ramt As Double = 0
                    Dim dataSet1 As System.Data.DataSet = New System.Data.DataSet()
                    Dim dataSet2 As System.Data.DataSet = New System.Data.DataSet()
                    file.WriteLine("<tr>")
                    file.WriteLine(String.Concat("<td>", batches.Tables(0).Rows(num10)(0).ToString(), "</td>"))
                    file.WriteLine(String.Concat("<td>", batches.Tables(0).Rows(num10)(1).ToString(), "</td>"))
                    file.WriteLine(String.Concat("<td>", batches.Tables(0).Rows(num10)(2).ToString(), "</td>"))
                    selectData(String.Concat("select batchcode,pack_q,stripq,pieceq,amt from sales where idate=curdate() and batchcode='", batches.Tables(0).Rows(num10)(0).ToString(), "'"), dataSet1)
                    selectData(String.Concat("select batchcode,pack_q,stripq,pieceq,(((100-discount)/100)*(pieceq*piece_mrp))+((cgst+sgst+igst+ed)/100)*(pieceq*piece_mrp) from sales_r where idate=curdate() and batchcode='", batches.Tables(0).Rows(num10)(0).ToString(), "'"), dataSet2)
                    If (dataSet1.Tables(0).Rows.Count > 0) Then
                        Dim count4 As Integer = dataSet1.Tables(0).Rows.Count - 1
                        For k As Integer = 0 To count4 Step 1
                            packc += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(k)(1))))
                            stripc += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(k)(2))))
                            piecec = Convert.ToInt32(Decimal.Add(New Decimal(piecec), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(k)(3)))))
                            amt += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(k)(4))))
                        Next

                    End If
                    If (dataSet2.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                        Dim count5 As Integer = dataSet2.Tables(0).Rows.Count - 1
                        For l As Integer = 0 To count5 Step 1
                            rpack += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(l)(1))))
                            rstrip += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(l)(2))))
                            rpiece = Convert.ToInt32(Decimal.Add(New Decimal(rpiece), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(l)(3)))))
                            ramt += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(l)(4))))
                        Next

                    End If
                    packc -= rpack
                    stripc -= rstrip
                    piecec = piecec - rpiece
                    amt -= ramt
                    num = Math.Round(packc, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(stripc, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    num1 = Math.Round(New Decimal(piecec), 2)
                    file.WriteLine(String.Concat("<td>", num1.ToString(), "</td>"))
                    num = Math.Round(amt, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                    tamt += amt
                    num10 = num10 + 1
                Loop While num10 <= count3
                file.WriteLine("<tr>")
                file.WriteLine("<td colspan=6>Total</td>")
                num = Math.Round(tamt, 2)
                file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                file.WriteLine("</tr>")
            End If
        ElseIf (radioDoctor.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Doctor Reg No.</th>")
            file.Write("<th>Doctor Name</th>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Batch Code</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Amount</th>")
            file.WriteLine("<th>Transaction Type</th>")
            file.WriteLine("</tr>")
            Dim dataSet3 As System.Data.DataSet = New System.Data.DataSet()
            Dim dataSet4 As System.Data.DataSet = New System.Data.DataSet()
            If (Interaction.MsgBox("How would you like only valid prescriptions filtered?", MsgBoxStyle.YesNo, "Filter Confirmation") <> MsgBoxResult.No) Then
                selectData("select s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum(s.amt) from sales s where idate=curdate() and not s.pdoctor_reg='0' group by s.pdoctor_reg,s.icode,s.batchcode", dataSet3)
                selectData("select s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum((((100-s.discount)/100)*(s.pieceq*s.piece_mrp))+(((s.cgst+s.sgst+s.igst+s.ed)/100)*(s.pieceq*s.piece_mrp))) from sales_r s where idate=curdate() and not s.pdoctor_reg='0' group by s.pdoctor_reg,s.icode,s.batchcode", dataSet4)
            Else
                selectData("select s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum(s.amt) from sales s where idate=curdate() group by s.pdoctor_reg,s.icode,s.batchcode", dataSet3)
                selectData("select s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum((((100-s.discount)/100)*(s.pieceq*s.piece_mrp))+(((s.cgst+s.sgst+s.igst+s.ed)/100)*(s.pieceq*s.piece_mrp))) from sales_r s where idate=curdate() group by s.pdoctor_reg,s.icode,s.batchcode", dataSet4)
            End If
            If (dataSet3.Tables(0).Rows.Count > 0) Then
                Dim count6 As Integer = dataSet3.Tables(0).Rows.Count - 1
                For m As Integer = 0 To count6 Step 1
                    file.WriteLine("<tr>")
                    Dim num11 As Integer = 0
                    Do
                        If (num11 = 9) Then
                            file.WriteLine("<td>Sales</td>")
                        ElseIf (Not (num11 >= 5 And num11 <= 8)) Then
                            file.WriteLine(String.Concat("<td>", dataSet3.Tables(0).Rows(m)(num11).ToString(), "</td>"))
                        Else
                            Dim streamWriter As System.IO.StreamWriter = file
                            Dim type As System.Type = GetType(Math)
                            Dim item(1) As Object
                            Dim dataRow As System.Data.DataRow = dataSet3.Tables(0).Rows(m)
                            objectValue = dataRow
                            Dim num12 As Integer = num11
                            num2 = num12
                            item(0) = dataRow(num12)
                            item(1) = 2
                            objArray = item
                            Dim flagArray1() As Boolean = {True, False}
                            flagArray = flagArray1
                            Dim obj As Object = NewLateBinding.LateGet(Nothing, type, "Round", item, Nothing, Nothing, flagArray1)
                            If (flagArray(0)) Then
                                objectValue(num2) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray(0)))
                            End If
                            streamWriter.WriteLine(String.Concat("<td>", obj.ToString(), "</td>"))
                        End If
                        num11 = num11 + 1
                    Loop While num11 <= 9
                    file.WriteLine("</tr>")
                Next

            End If
            If (dataSet4.Tables(0).Rows.Count > 0) Then
                Dim count7 As Integer = dataSet4.Tables(0).Rows.Count - 1
                For n As Integer = 0 To count7 Step 1
                    file.WriteLine("<tr>")
                    Dim num13 As Integer = 0
                    Do
                        If (num13 = 9) Then
                            file.WriteLine("<td>Return</td>")
                        ElseIf (Not (num13 >= 5 And num13 <= 8)) Then
                            file.WriteLine(String.Concat("<td>", dataSet4.Tables(0).Rows(n)(num13).ToString(), "</td>"))
                        Else
                            Dim streamWriter1 As System.IO.StreamWriter = file
                            Dim type1 As System.Type = GetType(Math)
                            Dim item1(1) As Object
                            Dim dataRow1 As System.Data.DataRow = dataSet4.Tables(0).Rows(n)
                            objectValue = dataRow1
                            Dim num14 As Integer = num13
                            num2 = num14
                            item1(0) = dataRow1(num14)
                            item1(1) = 2
                            objArray = item1
                            Dim flagArray2() As Boolean = {True, False}
                            flagArray = flagArray2
                            Dim obj1 As Object = NewLateBinding.LateGet(Nothing, type1, "Round", item1, Nothing, Nothing, flagArray2)
                            If (flagArray(0)) Then
                                objectValue(num2) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray(0)))
                            End If
                            streamWriter1.WriteLine(String.Concat("<td>", obj1.ToString(), "</td>"))
                        End If
                        num13 = num13 + 1
                    Loop While num13 <= 9
                    file.WriteLine("</tr>")
                Next

            End If
        ElseIf (radioPatient.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Patient ID</th>")
            file.Write("<th>Patient Name</th>")
            file.Write("<th>Doctor Reg No.</th>")
            file.Write("<th>Doctor Name</th>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Batch Code</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Amount</th>")
            file.WriteLine("<th>Transaction Type</th>")
            file.WriteLine("</tr>")
            Dim sales As System.Data.DataSet = New System.Data.DataSet()
            Dim rsales As System.Data.DataSet = New System.Data.DataSet()
            If (Interaction.MsgBox("Would you like to filter registered patients only?", MsgBoxStyle.YesNo, "Filter Confirmation") <> MsgBoxResult.No) Then
                selectData("select s.pid,s.pname,s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum(s.amt) from sales s where idate=curdate() and not s.pid='N/A' group by s.pid,s.pdoctor_reg,s.icode,s.batchcode", sales)
                selectData("select s.pid,s.pname,s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum((((100-s.discount)/100)*(s.pieceq*s.piece_mrp))+(((s.cgst+s.sgst+s.igst+s.ed)/100)*(s.pieceq*s.piece_mrp))) from sales_r s where idate=curdate() and not s.pid='N/A' group by s.pid,s.pdoctor_reg,s.icode,s.batchcode;", rsales)
            Else
                selectData("select s.pid,s.pname,s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum(s.amt) from sales s where idate=curdate() group by s.pid,s.pdoctor_reg,s.icode,s.batchcode", sales)
                selectData("select s.pid,s.pname,s.pdoctor_reg,s.pdoctor_name,s.icode,(select m.name from medicine m where m.code=s.icode),batchcode,sum(s.pack_q),sum(s.stripq),sum(s.pieceq),sum((((100-s.discount)/100)*(s.pieceq*s.piece_mrp))+(((s.cgst+s.sgst+s.igst+s.ed)/100)*(s.pieceq*s.piece_mrp))) from sales_r s where idate=curdate() group by s.pid,s.pdoctor_reg,s.icode,s.batchcode;", rsales)
            End If
            If (sales.Tables(0).Rows.Count > 0) Then
                Dim count8 As Integer = sales.Tables(0).Rows.Count - 1
                For o As Integer = 0 To count8 Step 1
                    file.WriteLine("<tr>")
                    Dim num15 As Integer = 0
                    Do
                        If (num15 = 11) Then
                            file.WriteLine("<td>Sales</td>")
                        ElseIf (Not (num15 >= 7 And num15 <= 10)) Then
                            file.WriteLine(String.Concat("<td>", sales.Tables(0).Rows(o)(num15).ToString(), "</td>"))
                        Else
                            Dim streamWriter2 As System.IO.StreamWriter = file
                            Dim type2 As System.Type = GetType(Math)
                            Dim objArray1(1) As Object
                            Dim item2 As System.Data.DataRow = sales.Tables(0).Rows(o)
                            objectValue = item2
                            Dim num16 As Integer = num15
                            num2 = num16
                            objArray1(0) = item2(num16)
                            objArray1(1) = 2
                            objArray = objArray1
                            Dim flagArray3() As Boolean = {True, False}
                            flagArray = flagArray3
                            Dim obj2 As Object = NewLateBinding.LateGet(Nothing, type2, "Round", objArray1, Nothing, Nothing, flagArray3)
                            If (flagArray(0)) Then
                                objectValue(num2) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray(0)))
                            End If
                            streamWriter2.WriteLine(String.Concat("<td>", obj2.ToString(), "</td>"))
                        End If
                        num15 = num15 + 1
                    Loop While num15 <= 11
                    file.WriteLine("</tr>")
                Next

            End If
            If (rsales.Tables(0).Rows.Count > 0) Then
                Dim count9 As Integer = rsales.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count9 Step 1
                    file.WriteLine("<tr>")
                    Dim j As Integer = 0
                    Do
                        If (j = 11) Then
                            file.WriteLine("<td>Return</td>")
                        ElseIf (Not (j >= 7 And j <= 10)) Then
                            file.WriteLine(String.Concat("<td>", rsales.Tables(0).Rows(i)(j).ToString(), "</td>"))
                        Else
                            Dim streamWriter3 As System.IO.StreamWriter = file
                            Dim type3 As System.Type = GetType(Math)
                            Dim objArray2(1) As Object
                            Dim dataRow2 As System.Data.DataRow = rsales.Tables(0).Rows(i)
                            objectValue = dataRow2
                            Dim num17 As Integer = j
                            num2 = num17
                            objArray2(0) = dataRow2(num17)
                            objArray2(1) = 2
                            objArray = objArray2
                            Dim flagArray4() As Boolean = {True, False}
                            flagArray = flagArray4
                            Dim obj3 As Object = NewLateBinding.LateGet(Nothing, type3, "Round", objArray2, Nothing, Nothing, flagArray4)
                            If (flagArray(0)) Then
                                objectValue(num2) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objArray(0)))
                            End If
                            streamWriter3.WriteLine(String.Concat("<td>", obj3.ToString(), "</td>"))
                        End If
                        j = j + 1
                    Loop While j <= 11
                    file.WriteLine("</tr>")
                Next

            End If
        End If
        file.WriteLine("</table>")
        file.WriteLine("</body>")
        file.WriteLine("</html>")
        file.Close()
        Process.Start(filepath)
    End Sub

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (DateTime.Compare(dateFrom.Value, dateTo.Value) <= 0) Then
            btnRequest.Enabled = True
        Else
            btnRequest.Enabled = False
        End If
    End Sub
End Class