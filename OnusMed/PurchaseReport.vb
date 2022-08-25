Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class PurchaseReport
    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Dim num As Double
        Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
        Dim folderpath As String = String.Concat(docpath, "\PurchaseReports")
        If (Not Directory.Exists(folderpath)) Then
            Directory.CreateDirectory(folderpath)
        End If
        Dim str() As String = {folderpath, "\PurchaseReport_", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
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
        Dim file As StreamWriter = New StreamWriter(filepath)
        file.WriteLine("<html>")
        Dim strArrays() As String = {"<title>Purchase Report from ", Nothing, Nothing, Nothing, Nothing}
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
        Dim str1() As String = {"<center><h1>Purchase Report from ", Nothing, Nothing, Nothing, Nothing}
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
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Free Packs</th>")
            file.Write("<th>Free Strips</th>")
            file.Write("<th>Free Pieces</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
            Dim dataSet1 As System.Data.DataSet = New System.Data.DataSet()
            Dim codes As System.Data.DataSet = New System.Data.DataSet()
            Dim strArrays1() As String = {"select distinct icode from purchase where (idate between '", Nothing, Nothing, Nothing, Nothing}
            value = dateFrom.Value
            strArrays1(1) = value.ToString("yyyy-MM-dd")
            strArrays1(2) = "' and '"
            value = dateTo.Value
            strArrays1(3) = value.ToString("yyyy-MM-dd")
            strArrays1(4) = "')"
            selectData(String.Concat(strArrays1), codes)
            If (codes.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = codes.Tables(0).Rows.Count - 1
                For i1 As Integer = 0 To count Step 1
                    Dim str2 As String = codes.Tables(0).Rows(i1)(0).ToString()
                    Dim strArrays2() As String = {"select icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum(amt) from purchase where (idate between '", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    strArrays2(1) = value.ToString("yyyy-MM-dd")
                    strArrays2(2) = "' and '"
                    value = dateTo.Value
                    strArrays2(3) = value.ToString("yyyy-MM-dd")
                    strArrays2(4) = "') and icode='"
                    strArrays2(5) = str2
                    strArrays2(6) = "' group by icode;"
                    selectData(String.Concat(strArrays2), dataSet)
                    Dim str3() As String = {"select icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum((((100-discount)/100)*(piece_q*pr_piece))+(((cgst+sgst+igst+ed)/100)*(piece_q*pr_piece))) from purchase_r where (idate between '", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    str3(1) = value.ToString("yyyy-MM-dd")
                    str3(2) = "' and '"
                    value = dateTo.Value
                    str3(3) = value.ToString("yyyy-MM-dd")
                    str3(4) = "') and icode='"
                    str3(5) = str2
                    str3(6) = "' group by icode;"
                    selectData(String.Concat(str3), dataSet1)
                    Dim icode As String = dataSet.Tables(0).Rows(0)(0).ToString()
                    Dim iname As String = dataSet.Tables(0).Rows(0)(1).ToString()
                    Dim num1 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(2))))
                    Dim num2 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(3))))
                    Dim num3 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(4))))
                    Dim num4 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(5))))
                    Dim num5 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(6))))
                    Dim num6 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(7))))
                    Dim num7 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(8))))
                    If (dataSet1.Tables.Count > 0) Then
                        If (dataSet1.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                            Dim rpack As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(2))))
                            Dim rstrip As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(3))))
                            Dim rpiece As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(4))))
                            Dim rfpack As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(5))))
                            Dim rfstrip As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(6))))
                            Dim rfpiece As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(7))))
                            Dim ramt As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(8))))
                            num1 -= rpack
                            num2 -= rstrip
                            num3 -= rpiece
                            num4 -= rfpack
                            num5 -= rfstrip
                            num6 -= rfpiece
                            num7 -= ramt
                        End If
                    End If
                    file.WriteLine("<tr>")
                    file.Write(String.Concat("<td>", icode, "</td>"))
                    file.Write(String.Concat("<td>", iname, "</td>"))
                    num = Math.Round(num1, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num2, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num3, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num4, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num5, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num6, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num7, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                Next

            End If
        ElseIf (radioBatch.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Batch Code</th>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Free Packs</th>")
            file.Write("<th>Free Strips</th>")
            file.Write("<th>Free Pieces</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim dataSet2 As System.Data.DataSet = New System.Data.DataSet()
            Dim dataSet3 As System.Data.DataSet = New System.Data.DataSet()
            Dim batches As System.Data.DataSet = New System.Data.DataSet()
            selectData("select distinct batchcode from purchase where idate=curdate()", batches)
            If (batches.Tables(0).Rows.Count > 0) Then
                Dim count1 As Integer = batches.Tables(0).Rows.Count - 1
                For j As Integer = 0 To count1 Step 1
                    Dim bcode As String = Conversions.ToString(batches.Tables(0).Rows(j)(0))
                    Dim strArrays3() As String = {"select batchcode,icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum(amt) from purchase where (idate between '", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    strArrays3(1) = value.ToString("yyyy-MM-dd")
                    strArrays3(2) = "' and '"
                    value = dateTo.Value
                    strArrays3(3) = value.ToString("yyyy-MM-dd")
                    strArrays3(4) = "') and batchcode='"
                    strArrays3(5) = bcode
                    strArrays3(6) = "' group by batchcode;"
                    selectData(String.Concat(strArrays3), dataSet2)
                    Dim str4() As String = {"select batchcode,icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum((((100-discount)/100)*(piece_q*pr_piece))+(((cgst+sgst+igst+ed)/100)*(piece_q*pr_piece))) from purchase_r where (idate between '", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    str4(1) = value.ToString("yyyy-MM-dd")
                    str4(2) = "' and '"
                    value = dateTo.Value
                    str4(3) = value.ToString("yyyy-MM-dd")
                    str4(4) = "') and batchcode='"
                    str4(5) = bcode
                    str4(6) = "' group by batchcode;"
                    selectData(String.Concat(str4), dataSet3)
                    Dim str5 As String = dataSet2.Tables(0).Rows(0)(0).ToString()
                    Dim str6 As String = dataSet2.Tables(0).Rows(0)(1).ToString()
                    Dim str7 As String = dataSet2.Tables(0).Rows(0)(2).ToString()
                    Dim num8 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(3))))
                    Dim num9 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(4))))
                    Dim num10 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(5))))
                    Dim num11 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(6))))
                    Dim num12 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(7))))
                    Dim num13 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(8))))
                    Dim num14 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(9))))
                    If (dataSet3.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                        num8 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(3))))
                        num9 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(4))))
                        num10 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(5))))
                        num11 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(6))))
                        num12 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(7))))
                        num13 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(8))))
                        num14 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(9))))
                    End If
                    file.WriteLine("<tr>")
                    file.Write(String.Concat("<td>", str5, "</td>"))
                    file.Write(String.Concat("<td>", str6, "</td>"))
                    file.Write(String.Concat("<td>", str7, "</td>"))
                    num = Math.Round(num8, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num9, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num10, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num11, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num12, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num13, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num14, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                Next

            End If
        ElseIf (radioSupplier.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Supplier ID</th>")
            file.Write("<th>Supplier</th>")
            file.Write("<th>Batch Code</th>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Free Packs</th>")
            file.Write("<th>Free Strips</th>")
            file.Write("<th>Free Pieces</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim items As System.Data.DataSet = New System.Data.DataSet()
            Dim ritems As System.Data.DataSet = New System.Data.DataSet()
            Dim suppliers As System.Data.DataSet = New System.Data.DataSet()
            selectData("select distinct suppl from purchase where idate=curdate()", suppliers)
            If (suppliers.Tables(0).Rows.Count > 0) Then
                Dim count2 As Integer = suppliers.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count2 Step 1
                    Dim supp As String = Conversions.ToString(suppliers.Tables(0).Rows(i)(0))
                    Dim strArrays4() As String = {"select suppl,(select name from supplier where id=suppl),batchcode,icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum(amt) from purchase where (idate between '", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    strArrays4(1) = value.ToString("yyyy-MM-dd")
                    strArrays4(2) = "' and '"
                    value = dateTo.Value
                    strArrays4(3) = value.ToString("yyyy-MM-dd")
                    strArrays4(4) = "') and suppl='"
                    strArrays4(5) = supp
                    strArrays4(6) = "' group by suppl,batchcode;"
                    selectData(String.Concat(strArrays4), items)
                    Dim strArrays5() As String = {"select suppl,(select name from supplier where id=suppl),batchcode,icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum((((100-discount)/100)*(piece_q*pr_piece))+(((cgst+sgst+igst+ed)/100)*(piece_q*pr_piece))) from purchase_r where (idate between '", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
                    value = dateFrom.Value
                    strArrays5(1) = value.ToString("yyyy-MM-dd")
                    strArrays5(2) = "' and '"
                    value = dateTo.Value
                    strArrays5(3) = value.ToString("yyyy-MM-dd")
                    strArrays5(4) = "') and suppl='"
                    strArrays5(5) = supp
                    strArrays5(6) = "' group by suppl,batchcode;"
                    selectData(String.Concat(strArrays5), ritems)
                    Dim suppid As String = items.Tables(0).Rows(0)(0).ToString()
                    Dim suppname As String = items.Tables(0).Rows(0)(1).ToString()
                    Dim batch As String = items.Tables(0).Rows(0)(2).ToString()
                    Dim code As String = items.Tables(0).Rows(0)(3).ToString()
                    Dim name As String = items.Tables(0).Rows(0)(4).ToString()
                    Dim ppack As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(5))))
                    Dim pstrip As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(6))))
                    Dim ppiece As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(7))))
                    Dim fpack As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(8))))
                    Dim fstrip As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(9))))
                    Dim fpiece As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(10))))
                    Dim amt As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(11))))
                    If (ritems.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                        ppack -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(5))))
                        pstrip -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(6))))
                        ppiece -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(7))))
                        fpack -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(8))))
                        fstrip -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(9))))
                        fpiece -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(10))))
                        amt -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(11))))
                    End If
                    file.WriteLine("<tr>")
                    file.Write(String.Concat("<td>", suppid, "</td>"))
                    file.Write(String.Concat("<td>", suppname, "</td>"))
                    file.Write(String.Concat("<td>", batch, "</td>"))
                    file.Write(String.Concat("<td>", code, "</td>"))
                    file.Write(String.Concat("<td>", name, "</td>"))
                    num = Math.Round(ppack, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(pstrip, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(ppiece, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(fpack, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(fstrip, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(fpiece, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(amt, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
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
        Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
        Dim folderpath As String = String.Concat(docpath, "\PrchaseReports")
        If (Not Directory.Exists(folderpath)) Then
            Directory.CreateDirectory(folderpath)
        End If
        Dim now As DateTime = DateTime.Now
        Dim filepath As String = String.Concat(folderpath, "\DailyPurchaseReport_", now.ToString("MM.dd.yyyy_HH.mm.ss"), ".html")
        Using fileStream As System.IO.FileStream = System.IO.File.Create(filepath)
        End Using
        Dim file As StreamWriter = New StreamWriter(filepath)
        file.WriteLine("<html>")
        now = DateTime.Today
        file.WriteLine(String.Concat("<title>Daily Purchase Report for ", now.ToString("MM-dd-yyyy"), "</title>"))
        file.WriteLine("<head>")
        file.WriteLine("<style media=""screen"" type=""text/css"">")
        file.WriteLine("@media print {")
        file.WriteLine("thead {display: table-header-group;}")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")
        now = DateTime.Today
        file.WriteLine(String.Concat("<center><h1>Purchase Report for ", now.ToString("MM-dd-yyyy"), "</h1></center>"))
        file.WriteLine("<table border=1 width=100%>")
        If (radioItem.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Free Packs</th>")
            file.Write("<th>Free Strips</th>")
            file.Write("<th>Free Pieces</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
            Dim dataSet1 As System.Data.DataSet = New System.Data.DataSet()
            Dim codes As System.Data.DataSet = New System.Data.DataSet()
            selectData("select distinct icode from purchase where idate=curdate()", codes)
            If (codes.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = codes.Tables(0).Rows.Count - 1
                For i1 As Integer = 0 To count Step 1
                    Dim str As String = codes.Tables(0).Rows(i1)(0).ToString()
                    selectData(String.Concat("select icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum(amt) from purchase where idate=curdate() and icode='", str, "' group by icode;"), dataSet)
                    selectData(String.Concat("select icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum((((100-discount)/100)*(piece_q*pr_piece))+(((cgst+sgst+igst+ed)/100)*(piece_q*pr_piece))) from purchase_r where idate=curdate() and icode='", str, "' group by icode;"), dataSet1)
                    Dim icode As String = dataSet.Tables(0).Rows(0)(0).ToString()
                    Dim iname As String = dataSet.Tables(0).Rows(0)(1).ToString()
                    Dim num1 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(2))))
                    Dim num2 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(3))))
                    Dim num3 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(4))))
                    Dim num4 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(5))))
                    Dim num5 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(6))))
                    Dim num6 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(7))))
                    Dim num7 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet.Tables(0).Rows(0)(8))))
                    If (dataSet1.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                        Dim rpack As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(2))))
                        Dim rstrip As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(3))))
                        Dim rpiece As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(4))))
                        Dim rfpack As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(5))))
                        Dim rfstrip As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(6))))
                        Dim rfpiece As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(7))))
                        Dim ramt As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet1.Tables(0).Rows(0)(8))))
                        num1 -= rpack
                        num2 -= rstrip
                        num3 -= rpiece
                        num4 -= rfpack
                        num5 -= rfstrip
                        num6 -= rfpiece
                        num7 -= ramt
                    End If
                    file.WriteLine("<tr>")
                    file.Write(String.Concat("<td>", icode, "</td>"))
                    file.Write(String.Concat("<td>", iname, "</td>"))
                    num = Math.Round(num1, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num2, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num3, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num4, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num5, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num6, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num7, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                Next

            End If
        ElseIf (radioBatch.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Batch Code</th>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Free Packs</th>")
            file.Write("<th>Free Strips</th>")
            file.Write("<th>Free Pieces</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim dataSet2 As System.Data.DataSet = New System.Data.DataSet()
            Dim dataSet3 As System.Data.DataSet = New System.Data.DataSet()
            Dim batches As System.Data.DataSet = New System.Data.DataSet()
            selectData("select distinct batchcode from purchase where idate=curdate()", batches)
            If (batches.Tables(0).Rows.Count > 0) Then
                Dim count1 As Integer = batches.Tables(0).Rows.Count - 1
                For j As Integer = 0 To count1 Step 1
                    Dim bcode As String = Conversions.ToString(batches.Tables(0).Rows(j)(0))
                    selectData(String.Concat("select batchcode,icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum(amt) from purchase where idate=curdate() and batchcode='", bcode, "' group by batchcode;"), dataSet2)
                    selectData(String.Concat("select batchcode,icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum((((100-discount)/100)*(piece_q*pr_piece))+(((cgst+sgst+igst+ed)/100)*(piece_q*pr_piece))) from purchase_r where idate=curdate() and batchcode='", bcode, "' group by batchcode;"), dataSet3)
                    Dim str1 As String = dataSet2.Tables(0).Rows(0)(0).ToString()
                    Dim str2 As String = dataSet2.Tables(0).Rows(0)(1).ToString()
                    Dim str3 As String = dataSet2.Tables(0).Rows(0)(2).ToString()
                    Dim num8 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(3))))
                    Dim num9 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(4))))
                    Dim num10 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(5))))
                    Dim num11 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(6))))
                    Dim num12 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(7))))
                    Dim num13 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(8))))
                    Dim num14 As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet2.Tables(0).Rows(0)(9))))
                    If (dataSet3.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                        num8 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(3))))
                        num9 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(4))))
                        num10 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(5))))
                        num11 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(6))))
                        num12 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(7))))
                        num13 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(8))))
                        num14 -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataSet3.Tables(0).Rows(0)(9))))
                    End If
                    file.WriteLine("<tr>")
                    file.Write(String.Concat("<td>", str1, "</td>"))
                    file.Write(String.Concat("<td>", str2, "</td>"))
                    file.Write(String.Concat("<td>", str3, "</td>"))
                    num = Math.Round(num8, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num9, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num10, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num11, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num12, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num13, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(num14, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                Next

            End If
        ElseIf (radioSupplier.Checked) Then
            file.WriteLine("<tr>")
            file.Write("<th>Supplier ID</th>")
            file.Write("<th>Supplier</th>")
            file.Write("<th>Batch Code</th>")
            file.Write("<th>Item Code</th>")
            file.Write("<th>Item Name</th>")
            file.Write("<th>Packs</th>")
            file.Write("<th>Strips</th>")
            file.Write("<th>Pieces</th>")
            file.Write("<th>Free Packs</th>")
            file.Write("<th>Free Strips</th>")
            file.Write("<th>Free Pieces</th>")
            file.WriteLine("<th>Amount</th>")
            file.WriteLine("</tr>")
            Dim items As System.Data.DataSet = New System.Data.DataSet()
            Dim ritems As System.Data.DataSet = New System.Data.DataSet()
            Dim suppliers As System.Data.DataSet = New System.Data.DataSet()
            selectData("select distinct suppl from purchase where idate=curdate()", suppliers)
            If (suppliers.Tables(0).Rows.Count > 0) Then
                Dim count2 As Integer = suppliers.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count2 Step 1
                    Dim supp As String = Conversions.ToString(suppliers.Tables(0).Rows(i)(0))
                    selectData(String.Concat("select suppl,(select name from supplier where id=suppl),batchcode,icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum(amt) from purchase where idate=curdate() and suppl='", supp, "' group by suppl,batchcode;"), items)
                    selectData(String.Concat("select suppl,(select name from supplier where id=suppl),batchcode,icode,(select name from medicine where code=icode),sum(pack_q),sum(strip_q),sum(piece_q),sum(free_pack),sum(free_strip),sum(free_piece),sum((((100-discount)/100)*(piece_q*pr_piece))+(((cgst+sgst+igst+ed)/100)*(piece_q*pr_piece))) from purchase_r where idate=curdate() and suppl='", supp, "' group by suppl,batchcode;"), ritems)
                    Dim suppid As String = items.Tables(0).Rows(0)(0).ToString()
                    Dim suppname As String = items.Tables(0).Rows(0)(1).ToString()
                    Dim batch As String = items.Tables(0).Rows(0)(2).ToString()
                    Dim code As String = items.Tables(0).Rows(0)(3).ToString()
                    Dim name As String = items.Tables(0).Rows(0)(4).ToString()
                    Dim ppack As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(5))))
                    Dim pstrip As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(6))))
                    Dim ppiece As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(7))))
                    Dim fpack As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(8))))
                    Dim fstrip As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(9))))
                    Dim fpiece As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(10))))
                    Dim amt As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(items.Tables(0).Rows(0)(11))))
                    If (ritems.Tables(0).Rows.Count > 0 And chkSubtract.Checked) Then
                        ppack -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(5))))
                        pstrip -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(6))))
                        ppiece -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(7))))
                        fpack -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(8))))
                        fstrip -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(9))))
                        fpiece -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(10))))
                        amt -= Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(ritems.Tables(0).Rows(0)(11))))
                    End If
                    file.WriteLine("<tr>")
                    file.Write(String.Concat("<td>", suppid, "</td>"))
                    file.Write(String.Concat("<td>", suppname, "</td>"))
                    file.Write(String.Concat("<td>", batch, "</td>"))
                    file.Write(String.Concat("<td>", code, "</td>"))
                    file.Write(String.Concat("<td>", name, "</td>"))
                    num = Math.Round(ppack, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(pstrip, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(ppiece, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(fpack, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(fstrip, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(fpiece, 2)
                    file.Write(String.Concat("<td>", num.ToString(), "</td>"))
                    num = Math.Round(amt, 2)
                    file.WriteLine(String.Concat("<td>", num.ToString(), "</td>"))
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

    Private Sub PurchaseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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