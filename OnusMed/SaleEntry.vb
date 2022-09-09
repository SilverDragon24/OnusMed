Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports OnusMed.My
Imports OnusMed.My.Resources
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class SaleEntry
    Private patient As DataSet = New DataSet

    Private selpatient As DataSet = New DataSet

    Private pdoctor As DataSet = New DataSet

    Private item As DataSet = New DataSet

    Private bitem As DataSet = New DataSet

    Private cards As DataSet = New DataSet

    Private invoice As String

    Private instru As String

    Private gst(4) As Double

    Private exd As Double

    Private credit As Double

    Private valid(11) As Boolean

    Private packc As Double

    Private stripc As Double

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim tempgst(3) As Double
        If (Not chkInterState.Checked) Then
            If (Not chkInterState.Checked) Then
                If (gst(0) > 0 And gst(1) > 0 And gst(2) = 0) Then
                    tempgst(0) = gst(0)
                    tempgst(1) = gst(1)
                    tempgst(2) = 0
                ElseIf (gst(0) = 0 And gst(1) = 0 And gst(2) > 0) Then
                    tempgst(0) = gst(2) / 2
                    tempgst(1) = gst(2) / 2
                    tempgst(2) = 0
                ElseIf (gst(0) = 0 And gst(1) = 0 And gst(2) = 0) Then
                    tempgst(0) = 0
                    tempgst(1) = 0
                    tempgst(2) = 0
                End If
            End If
        ElseIf (gst(0) > 0 And gst(1) > 0 And gst(2) = 0) Then
            tempgst(0) = 0
            tempgst(1) = 0
            tempgst(2) = gst(0) + gst(1)
        ElseIf (gst(0) = 0 And gst(1) = 0 And gst(2) > 0) Then
            tempgst(0) = 0
            tempgst(1) = 0
            tempgst(2) = gst(2)
        ElseIf (gst(0) = 0 And gst(1) = 0 And gst(2) = 0) Then
            tempgst(0) = 0
            tempgst(1) = 0
            tempgst(2) = 0
        End If
        Dim str(4) As String
        Dim value As DateTime = dateInvoiceDate.Value
        Dim year As Integer = value.Year
        str(0) = year.ToString()
        str(1) = "-"
        value = dateInvoiceDate.Value
        year = value.Month
        str(2) = year.ToString()
        str(3) = "-"
        value = dateInvoiceDate.Value
        year = value.Day
        str(4) = year.ToString()
        Dim idate As String = String.Concat(str)
        Dim rows As DataGridViewRowCollection = DataGridView1.Rows
        Dim text(18) As Object
        text(0) = cmbItemCode.Text
        text(1) = cmbItemName.Text
        text(2) = cmbBatchCode.Text
        text(3) = idate
        text(4) = cmbPatientID.Text
        text(5) = cmbPatientName.Text
        text(6) = cmbDocReg.Text
        text(7) = cmbDocName.Text
        Dim num As Decimal = numQtyPack.Value
        text(8) = num.ToString()
        num = numQtyStrip.Value
        text(9) = num.ToString()
        num = numQtyPiece.Value
        text(10) = num.ToString()
        Dim num1 As Double = Convert.ToDouble(Convert.ToDecimal(txtMrpPack.Text))
        text(11) = num1.ToString()
        num1 = Convert.ToDouble(Convert.ToDecimal(txtMrpStrip.Text))
        text(12) = num1.ToString()
        num1 = Convert.ToDouble(Convert.ToDecimal(txtMrpPiece.Text))
        text(13) = num1.ToString()
        num = numDiscount.Value
        text(14) = num.ToString()
        text(15) = tempgst(0).ToString()
        text(16) = tempgst(1).ToString()
        text(17) = tempgst(2).ToString()
        text(18) = exd.ToString()
        rows.Add(text)
        cmbItemName.Text = ""
        cmbItemCode.Text = ""
        cmbBatchCode.Text = ""
        cmbLiveBatch.Text = ""
        numQtyPack.Value = Decimal.Zero
        numQtyStrip.Value = Decimal.Zero
        numQtyPiece.Value = Decimal.Zero
        cmbItemName.Select()
    End Sub

    Private Sub btnComplete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnComplete.Click
        If (DataGridView1.Rows.Count > 0) Then
            Dim sales As String = ""
            Dim inventory As String = ""
            Dim payment As String = ""
            Dim credit As String = ""
            Dim invoice As String = String.Concat("SI", generateID())
            Dim count As Integer = DataGridView1.Rows.Count - 1
            Dim num As Integer = 0
            Do
                Dim amt As Double = 0
                Dim gst As Double = 0
                Dim mrp As Double = 0
                Dim discount As Double = 0
                Dim expd As Double = 0
                Dim qty As Double = 0
                gst = Convert.ToDouble(Decimal.Add(Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(num).Cells(15).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(num).Cells(16).Value))), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(num).Cells(17).Value))))
                expd = Convert.ToDouble(Convert.ToDecimal(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(num).Cells(18).Value))))
                discount = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(num).Cells(14).Value)))
                mrp = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(num).Cells(13).Value)))
                qty = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(num).Cells(10).Value)))
                amt = (100 - discount) / 100 * (mrp * qty) + gst / 100 * (mrp * qty) + expd / 100 * (mrp * qty)
                sales = String.Concat(New String() {"insert into sales values('", invoice, "','", DataGridView1.Rows(num).Cells(0).Value.ToString(), "','", DataGridView1.Rows(num).Cells(2).Value.ToString(), "', curdate(),'", DataGridView1.Rows(num).Cells(4).Value.ToString(), "','", DataGridView1.Rows(num).Cells(5).Value.ToString(), "','", DataGridView1.Rows(num).Cells(6).Value.ToString(), "','", DataGridView1.Rows(num).Cells(7).Value.ToString(), "',", DataGridView1.Rows(num).Cells(8).Value.ToString(), ",", DataGridView1.Rows(num).Cells(9).Value.ToString(), ",", DataGridView1.Rows(num).Cells(10).Value.ToString(), ",", DataGridView1.Rows(num).Cells(11).Value.ToString(), ",", DataGridView1.Rows(num).Cells(12).Value.ToString(), ",", DataGridView1.Rows(num).Cells(13).Value.ToString(), ",", DataGridView1.Rows(num).Cells(14).Value.ToString(), ",", DataGridView1.Rows(num).Cells(15).Value.ToString(), ",", DataGridView1.Rows(num).Cells(16).Value.ToString(), ",", DataGridView1.Rows(num).Cells(17).Value.ToString(), ",", DataGridView1.Rows(num).Cells(18).Value.ToString(), ",", amt.ToString(), ",'", employee, "');commit;"})
                inventory = String.Concat(New String() {"update inventory set stock_pack=stock_pack-(", DataGridView1.Rows(num).Cells(8).Value.ToString(), "),stock_strip=stock_strip-(", DataGridView1.Rows(num).Cells(9).Value.ToString(), "),stock_piece=stock_piece-(", DataGridView1.Rows(num).Cells(10).Value.ToString(), ") where batchcode='", DataGridView1.Rows(num).Cells(2).Value.ToString(), "';commit;"})
                manipulateData(sales)
                manipulateData(inventory)
                num = num + 1
            Loop While num <= count
            Dim str(20) As String
            str(0) = "insert into s_payments values('"
            str(1) = invoice
            str(2) = "', curdate(),"
            Dim value As Decimal = numCash.Value
            str(3) = value.ToString()
            str(4) = ","
            value = numCard.Value
            str(5) = value.ToString()
            str(6) = ",'"
            str(7) = cmbCardType.Text
            str(8) = "',"
            value = numWallet.Value
            str(9) = value.ToString()
            str(10) = ",'"
            str(11) = txtWalletRem.Text
            str(12) = "',"
            value = numBank.Value
            str(13) = value.ToString()
            str(14) = ",'"
            str(15) = instru
            str(16) = "','"
            str(17) = txtInstruID.Text
            str(18) = "',"
            value = numCredit.Value
            str(19) = value.ToString()
            str(20) = ");commit;"
            payment = String.Concat(str)
            Dim text() As String = {"update patient set credit=credit+(", Nothing, Nothing, Nothing, Nothing}
            value = numCredit.Value
            text(1) = value.ToString()
            text(2) = ") where id='"
            text(3) = cmbPatientID.Text
            text(4) = "';commit;"
            credit = String.Concat(text)
            manipulateData(payment)
            manipulateData(credit)
            Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
            Dim folderpath As String = String.Concat(docpath, "\OnusInvoices")
            If (Not Directory.Exists(folderpath)) Then
                Directory.CreateDirectory(folderpath)
            End If
            Dim filepath As String = String.Concat(folderpath, "\", invoice, ".html")
            Using fileStream As System.IO.FileStream = System.IO.File.Create(filepath)
            End Using
            Dim file As StreamWriter = New StreamWriter(filepath)
            file.WriteLine("<html>")
            file.WriteLine("<title></title>")
            file.WriteLine("<head>")
            file.WriteLine("<style media=""screen"" type=""text/css"">")
            file.WriteLine("@media print {")
            file.WriteLine("thead {display: table-header-group;}")
            file.WriteLine("}")
            file.WriteLine("</style>")
            file.WriteLine("</head>")
            file.WriteLine("<body>")
            file.WriteLine("<center><h1></h1></center>")
            file.WriteLine("<table border=0 width=100%>")
            Dim store As DataSet = New DataSet()
            Dim gstin As DataSet = New DataSet()
            Dim sales_invoice As DataSet = New DataSet()
            Dim pat As DataSet = New DataSet()
            selectData("select * from store", store)
            selectData("select * from gstin", gstin)
            selectData(String.Concat("select pid, pname, pdoctor_reg, pdoctor_name from sales where invoice_no='", invoice, "'"), pat)
            file.Write("<tr>")
            file.Write("<td>")
            file.Write(String.Concat(store.Tables(0).Rows(0)(0).ToString(), "<br>"))
            file.Write(String.Concat(store.Tables(0).Rows(0)(2).ToString(), "<br>"))
            file.Write(String.Concat(store.Tables(0).Rows(0)(3).ToString(), "<br>"))
            file.Write(String.Concat(store.Tables(0).Rows(0)(4).ToString(), ", "))
            file.Write(String.Concat(store.Tables(0).Rows(0)(5).ToString(), " - "))
            file.Write(String.Concat(store.Tables(0).Rows(0)(7).ToString(), "<br>"))
            file.Write(String.Concat("Phone: ", store.Tables(0).Rows(0)(8).ToString(), "<br>"))
            file.Write(String.Concat("GSTIN: ", gstin.Tables(0).Rows(0)(0).ToString(), gstin.Tables(0).Rows(0)(1).ToString()))
            file.WriteLine("</td><td>")
            file.Write("<p style=""text-align:right"">")
            file.Write(String.Concat("Patient ID: ", pat.Tables(0).Rows(0)(0).ToString(), "<br>"))
            file.Write(String.Concat("Name: ", pat.Tables(0).Rows(0)(1).ToString(), "<br><br><br>"))
            file.Write(String.Concat("Prescribing Doctor: ", pat.Tables(0).Rows(0)(3).ToString(), "<br>"))
            file.Write(String.Concat("Registration: ", pat.Tables(0).Rows(0)(2).ToString(), "<br><br>"))
            file.Write(String.Concat("Invoice No.: ", invoice))
            file.Write("</p>")
            file.Write("</td>")
            file.WriteLine("</tr>")
            file.WriteLine("</table>")
            file.WriteLine("<table border=1 width=100%>")
            file.WriteLine("<tr><th>Item Code</th><th>Item Name</th><th>Batch Code</th><th>HSN</th><th>Qty.</th><th>Discount</th><th>Price</th><th>CGST</th><th>SGST</th><th>IGST</th><th>E.D</th><th>Amount</th></tr>")
            selectData(String.Concat("select s.icode,(select m0.name from medicine m0 where m0.code=s.icode),s.batchcode,(select m1.hsn from medicine m1 where m1.code=s.icode),s.pieceq,s.discount,(s.piece_mrp*s.pieceq),((s.cgst/100)*(s.piece_mrp*s.pieceq)),((s.sgst/100)*(s.piece_mrp*s.pieceq)),((s.igst/100)*(s.piece_mrp*s.pieceq)),((s.ed/100)*(s.piece_mrp*s.pieceq)),((((100-s.discount)/100)*(s.piece_mrp*s.pieceq))+((s.cgst+s.sgst+s.igst+s.ed)/100)*(s.piece_mrp*s.pieceq)) from sales s where invoice_no='", invoice, "'"), sales_invoice)
            Dim tamt As Double = 0
            Try
                Dim count1 As Integer = sales_invoice.Tables(0).Rows.Count - 1
                Dim num1 As Integer = 0
                Do
                    file.Write("<tr>")
                    file.Write(String.Concat("<td>", sales_invoice.Tables(0).Rows(num1)(0).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", sales_invoice.Tables(0).Rows(num1)(1).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", sales_invoice.Tables(0).Rows(num1)(2).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", sales_invoice.Tables(0).Rows(num1)(3).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", sales_invoice.Tables(0).Rows(num1)(4).ToString(), "</td>"))
                    value = Math.Round(Convert.ToDecimal(sales_invoice.Tables(0).Rows(num1)(5).ToString()), 2)
                    file.Write(String.Concat("<td>", value.ToString(), "</td>"))
                    value = Math.Round(Convert.ToDecimal(sales_invoice.Tables(0).Rows(num1)(6).ToString()), 2)
                    file.Write(String.Concat("<td>", value.ToString(), "</td>"))
                    value = Math.Round(Convert.ToDecimal(sales_invoice.Tables(0).Rows(num1)(7).ToString()), 2)
                    file.Write(String.Concat("<td>", value.ToString(), "</td>"))
                    value = Math.Round(Convert.ToDecimal(sales_invoice.Tables(0).Rows(num1)(8).ToString()), 2)
                    file.Write(String.Concat("<td>", value.ToString(), "</td>"))
                    value = Math.Round(Convert.ToDecimal(sales_invoice.Tables(0).Rows(num1)(9).ToString()), 2)
                    file.Write(String.Concat("<td>", value.ToString(), "</td>"))
                    value = Math.Round(Convert.ToDecimal(sales_invoice.Tables(0).Rows(num1)(10).ToString()), 2)
                    file.Write(String.Concat("<td>", value.ToString(), "</td>"))
                    value = Math.Round(Convert.ToDecimal(sales_invoice.Tables(0).Rows(num1)(11).ToString()), 2)
                    file.Write(String.Concat("<td>", value.ToString(), "</td>"))
                    file.WriteLine("</tr>")
                    tamt += Convert.ToDouble(Math.Round(Convert.ToDecimal(sales_invoice.Tables(0).Rows(num1)(11).ToString()), 2))
                    num1 = num1 + 1
                Loop While num1 <= count1
                file.Write("<tr>")
                file.Write("<td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td>Total</td>")
                file.Write(String.Concat("<td>", tamt.ToString(), "</td>"))
                file.WriteLine("</tr>")
            Catch exception As System.Exception

            End Try
            file.WriteLine("</table>")
            Dim i As Integer = 0
            Do
                file.WriteLine("<br>")
                i = i + 1
            Loop While i <= 6
            file.Write("Authorized Signatory/Stamp")
            file.WriteLine("</body>")
            file.WriteLine("</html>")
            file.Close()
            Process.Start(filepath)
        End If
        selling = True
        MyBase.Dispose()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        selling = False
        Me.Dispose()
    End Sub

    Private Sub btnNewDoc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewDoc.Click
        NewDoctor.ShowDialog()
        selectData("select * from patient", patient)
        selectData("select * from pdoctor", pdoctor)
        selectData("select * from medicine", item)
        cmbPatientID.Items.Clear()
        cmbPatientName.Items.Clear()
        cmbDocReg.Items.Clear()
        cmbDocName.Items.Clear()
        cmbItemName.Items.Clear()
        cmbItemCode.Items.Clear()
        If (patient.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = patient.Tables(0).Rows.Count - 1
            For num As Integer = 0 To count Step 1
                cmbPatientID.Items.Add(patient.Tables(0).Rows(num)(0).ToString())
                cmbPatientName.Items.Add(patient.Tables(0).Rows(num)(1).ToString())
            Next

        End If
        If (pdoctor.Tables(0).Rows.Count > 0) Then
            Dim count1 As Integer = pdoctor.Tables(0).Rows.Count - 1
            For j As Integer = 0 To count1 Step 1
                cmbDocReg.Items.Add(pdoctor.Tables(0).Rows(j)(0).ToString())
                cmbDocName.Items.Add(pdoctor.Tables(0).Rows(j)(1).ToString())
            Next

        End If
        If (item.Tables(0).Rows.Count > 0) Then
            Dim num1 As Integer = item.Tables(0).Rows.Count - 1
            For i As Integer = 0 To num1 Step 1
                cmbItemCode.Items.Add(item.Tables(0).Rows(i)(0).ToString())
                cmbItemName.Items.Add(item.Tables(0).Rows(i)(1).ToString())
            Next

        End If
    End Sub

    Private Sub btnNewPatient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewPatient.Click
        NewPatient.ShowDialog()
        selectData("select id,name,contact,email from patient", patient)
        selectData("select * from pdoctor", pdoctor)
        selectData("select * from medicine", item)
        cmbPatientID.Items.Clear()
        cmbPatientName.Items.Clear()
        cmbDocReg.Items.Clear()
        cmbDocName.Items.Clear()
        cmbItemName.Items.Clear()
        cmbItemCode.Items.Clear()
        If (patient.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = patient.Tables(0).Rows.Count - 1
            For num As Integer = 0 To count Step 1
                cmbPatientID.Items.Add(patient.Tables(0).Rows(num)(0).ToString())
                cmbPatientName.Items.Add(patient.Tables(0).Rows(num)(1).ToString())
            Next

        End If
        If (pdoctor.Tables(0).Rows.Count > 0) Then
            Dim count1 As Integer = pdoctor.Tables(0).Rows.Count - 1
            For j As Integer = 0 To count1 Step 1
                cmbDocReg.Items.Add(pdoctor.Tables(0).Rows(j)(0).ToString())
                cmbDocName.Items.Add(pdoctor.Tables(0).Rows(j)(1).ToString())
            Next

        End If
        If (item.Tables(0).Rows.Count > 0) Then
            Dim num1 As Integer = item.Tables(0).Rows.Count - 1
            For i As Integer = 0 To num1 Step 1
                cmbItemCode.Items.Add(item.Tables(0).Rows(i)(0).ToString())
                cmbItemName.Items.Add(item.Tables(0).Rows(i)(1).ToString())
            Next

        End If
        invoice = generateID()
    End Sub

    Private Sub btnNewSale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewSale.Click
        Dim sale As SaleEntry = New SaleEntry()
        sale.Show()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            enumerator = DataGridView1.SelectedRows.GetEnumerator()
            While enumerator.MoveNext()
                Dim row As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                DataGridView1.Rows.Remove(row)
            End While
        Finally
            If (TypeOf enumerator Is IDisposable) Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        SearchItem.ShowDialog()
        cmbItemCode.Text = selected
    End Sub

    Private Sub cmbBatchCode_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbBatchCode.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numQtyPack.Select()
            numQtyPack.Select(0, numQtyPack.Text.Length)
        End If
    End Sub

    Private Sub cmbBatchCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbBatchCode.TextChanged
        Try
            cmbLiveBatch.Text = cmbBatchCode.Text
            Dim count As Integer = bitem.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            Do
                If (Operators.CompareString(cmbBatchCode.Text, bitem.Tables(0).Rows(i)(0).ToString(), False) = 0) Then
                    txtStockPack.Text = bitem.Tables(0).Rows(i)(15).ToString()
                    txtStockStrip.Text = bitem.Tables(0).Rows(i)(16).ToString()
                    txtStockPiece.Text = bitem.Tables(0).Rows(i)(17).ToString()
                    txtMrpPack.Text = bitem.Tables(0).Rows(i)(3).ToString()
                    txtMrpStrip.Text = bitem.Tables(0).Rows(i)(4).ToString()
                    txtMrpPiece.Text = bitem.Tables(0).Rows(i)(5).ToString()
                    gst(0) = Convert.ToDouble(Convert.ToDecimal(bitem.Tables(0).Rows(i)(12).ToString()))
                    gst(1) = Convert.ToDouble(Convert.ToDecimal(bitem.Tables(0).Rows(i)(13).ToString()))
                    gst(2) = Convert.ToDouble(Convert.ToDecimal(bitem.Tables(0).Rows(i)(14).ToString()))
                    exd = Convert.ToDouble(Convert.ToDecimal(bitem.Tables(0).Rows(i)(20).ToString()))
                End If
                i = i + 1
            Loop While i <= count
            If (cmbBatchCode.Text.Length <= 0) Then
                valid(8) = False
                cmbBatchCode.BackColor = Color.Pink
            Else
                valid(8) = True
                cmbBatchCode.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
        End Try
    End Sub

    Private Sub cmbCardType_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbCardType.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numBank.Select()
            numBank.Select(0, numBank.Text.Length)
        End If
    End Sub

    Private Sub cmbDocName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbDocName.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            cmbItemName.Select()
        End If
    End Sub

    Private Sub cmbDocName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDocName.TextChanged
        Try
            Dim count As Integer = pdoctor.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            Do
                If (Operators.CompareString(cmbDocName.Text, pdoctor.Tables(0).Rows(i)(1).ToString(), False) = 0) Then
                    cmbDocReg.Text = pdoctor.Tables(0).Rows(i)(0).ToString()
                    txtDocSpec.Text = pdoctor.Tables(0).Rows(i)(2).ToString()
                End If
                i = i + 1
            Loop While i <= count
            If (cmbDocName.Text.Length <= 0) Then
                valid(5) = False
                cmbDocName.BackColor = Color.Pink
            Else
                valid(5) = True
                cmbDocName.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub cmbDocReg_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDocReg.TextChanged
        Try
            Dim count As Integer = pdoctor.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            Do
                If (Operators.CompareString(cmbDocReg.Text, pdoctor.Tables(0).Rows(i)(0).ToString(), False) = 0) Then
                    cmbDocName.Text = pdoctor.Tables(0).Rows(i)(1).ToString()
                    txtDocSpec.Text = pdoctor.Tables(0).Rows(i)(2).ToString()
                End If
                i = i + 1
            Loop While i <= count
            If (cmbDocReg.Text.Length <= 0) Then
                valid(4) = False
                cmbDocReg.BackColor = Color.Pink
            Else
                valid(4) = True
                cmbDocReg.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub cmbDoctReg_KweyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbDocReg.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            cmbDocName.Select()
        End If
    End Sub

    Private Sub cmbItemCode_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbItemCode.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            cmbBatchCode.Select()
        End If
    End Sub

    Private Sub cmbItemCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbItemCode.TextChanged
        cmbBatchCode.Text = ""
        Try
            Dim count As Integer = item.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count
                If (Operators.CompareString(cmbItemCode.Text, item.Tables(0).Rows(i)(0).ToString(), False) <> 0) Then
                    i = i + 1
                Else
                    cmbItemName.Text = item.Tables(0).Rows(i)(1).ToString()
                    txtLiveID.Text = cmbItemCode.Text
                    cmbBatchCode.Items.Clear()
                    cmbLiveBatch.Items.Clear()
                    selectData(String.Concat("select * from inventory where code='", cmbItemCode.Text, "' and expiry>curdate() and stock_pack>0"), bitem)
                    Dim num As Integer = bitem.Tables(0).Rows.Count - 1
                    Dim j As Integer = 0
                    Do
                        cmbBatchCode.Items.Add(bitem.Tables(0).Rows(j)(0).ToString())
                        cmbLiveBatch.Items.Add(bitem.Tables(0).Rows(j)(0).ToString())
                        j = j + 1
                    Loop While j <= num
                    packc = Convert.ToDouble(Convert.ToDecimal(item.Tables(0).Rows(i)(6).ToString()))
                    stripc = Convert.ToDouble(Convert.ToDecimal(item.Tables(0).Rows(i)(7).ToString()))
                    Exit While
                End If
            End While
            If (cmbItemCode.Text.Length <= 0) Then
                valid(7) = False
                cmbItemCode.BackColor = Color.Pink
            Else
                valid(7) = True
                cmbItemCode.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub cmbItemName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbItemName.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            cmbItemCode.Select()
        End If
    End Sub

    Private Sub cmbItemName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbItemName.TextChanged
        cmbBatchCode.Text = ""
        Try
            Dim count As Integer = item.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count
                If (Operators.CompareString(cmbItemName.Text, item.Tables(0).Rows(i)(1).ToString(), False) <> 0) Then
                    i = i + 1
                Else
                    cmbItemCode.Text = item.Tables(0).Rows(i)(0).ToString()
                    txtLiveID.Text = cmbItemCode.Text
                    cmbBatchCode.Items.Clear()
                    cmbLiveBatch.Items.Clear()
                    selectData(String.Concat("select * from inventory where code='", cmbItemCode.Text, "' and expiry>curdate() and stock_pack>0"), bitem)
                    Dim num As Integer = bitem.Tables(0).Rows.Count - 1
                    Dim j As Integer = 0
                    Do
                        cmbBatchCode.Items.Add(bitem.Tables(0).Rows(j)(0).ToString())
                        cmbLiveBatch.Items.Add(bitem.Tables(0).Rows(j)(0).ToString())
                        j = j + 1
                    Loop While j <= num
                    packc = Convert.ToDouble(Convert.ToDecimal(item.Tables(0).Rows(i)(6).ToString()))
                    stripc = Convert.ToDouble(Convert.ToDecimal(item.Tables(0).Rows(i)(7).ToString()))
                    Exit While
                End If
            End While
            If (cmbItemName.Text.Length <= 0) Then
                valid(6) = False
                cmbItemName.BackColor = Color.Pink
            Else
                valid(6) = True
                cmbItemName.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub cmbPatientID_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbPatientID.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            cmbPatientName.Select()
        End If
    End Sub

    Private Sub cmbPatientID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbPatientID.TextChanged
        Try
            Dim count As Integer = patient.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count
                Debug.WriteLine(i.ToString())
                If (Operators.CompareString(cmbPatientID.Text, patient.Tables(0).Rows(i)(0).ToString(), False) <> 0) Then
                    i = i + 1
                Else
                    cmbPatientName.Text = patient.Tables(0).Rows(i)(1).ToString()
                    txtPatientNo.Text = patient.Tables(0).Rows(i)(2).ToString()
                    txtPatientEmail.Text = patient.Tables(0).Rows(i)(3).ToString()
                    numPatCredit.Value = Convert.ToDecimal(patient.Tables(0).Rows(i)(4).ToString())
                    Exit While
                End If
            End While
            If (cmbPatientID.Text.Length <> 0) Then
                valid(0) = True
                cmbPatientID.BackColor = Color.LightGreen
            Else
                valid(0) = False
                cmbPatientID.BackColor = Color.Pink
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub cmbPatientName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbPatientName.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            txtPatientNo.Select()
        End If
    End Sub

    Private Sub cmbPatientName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbPatientName.TextChanged
        Try
            Dim count As Integer = patient.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count
                If (Operators.CompareString(cmbPatientName.Text, patient.Tables(0).Rows(i)(1).ToString(), False) <> 0) Then
                    i = i + 1
                Else
                    cmbPatientID.Text = patient.Tables(0).Rows(i)(0).ToString()
                    txtPatientNo.Text = patient.Tables(0).Rows(i)(2).ToString()
                    txtPatientEmail.Text = " "
                    txtPatientEmail.Text = ""
                    txtPatientEmail.Text = patient.Tables(0).Rows(i)(3).ToString()
                    numPatCredit.Value = Convert.ToDecimal(patient.Tables(0).Rows(i)(4).ToString())
                    Exit While
                End If
            End While
            If (cmbPatientName.Text.Length <> 0) Then
                Text = cmbPatientID.Text
                valid(1) = True
                cmbPatientName.BackColor = Color.LightGreen
            Else
                Text = "Sales Entry"
                valid(1) = False
                cmbPatientName.BackColor = Color.Pink
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub numBank_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles numBank.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            If (Decimal.Compare(numBank.Value, Decimal.Zero) = 0) Then
                radioInstruNA.Checked = True
                numWallet.Select()
                numWallet.Select(0, numWallet.Text.Length)
            ElseIf (Decimal.Compare(numBank.Value, Decimal.Zero) > 0) Then
                radioInstruCHQ.Checked = True
                radioInstruCHQ.Select()
            End If
        End If
    End Sub

    Private Sub numBank_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numBank.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(Decimal.Add(numCash.Value, numBank.Value), numCard.Value), numWallet.Value))
    End Sub

    Private Sub numCard_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles numCard.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            If (Decimal.Compare(numCard.Value, Decimal.Zero) = 0) Then
                numBank.Select()
                numBank.Select(0, numBank.Text.Length)
            ElseIf (Decimal.Compare(numCard.Value, Decimal.Zero) > 0) Then
                cmbCardType.Select()
            End If
        End If
    End Sub

    Private Sub numCard_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numCard.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(Decimal.Add(numCash.Value, numBank.Value), numCard.Value), numWallet.Value))
    End Sub

    Private Sub numCash_Click(ByVal sender As Object, ByVal e As EventArgs) Handles numCash.Click
        numCash.Select(0, numCash.Text.Length)
    End Sub

    Private Sub numCash_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles numCash.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numCard.Select()
            numCard.Select(0, numCard.Text.Length)
        End If
    End Sub

    Private Sub numCash_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numCash.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(Decimal.Add(numCash.Value, numBank.Value), numCard.Value), numWallet.Value))
    End Sub

    Private Sub numNet_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numNet.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(Decimal.Add(numCash.Value, numCard.Value), numBank.Value), numWallet.Value))
    End Sub

    Private Sub numQtyPack_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles numQtyPack.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numQtyStrip.Select()
            numQtyStrip.Select(0, numQtyStrip.Text.Length)
        End If
    End Sub

    Private Sub numQtyPack_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numQtyPack.ValueChanged
        Try
            numQtyStrip.Value = New Decimal(Convert.ToDouble(numQtyPack.Value) * packc)
            numQtyPiece.Value = New Decimal(Convert.ToDouble(numQtyStrip.Value) * stripc)
            If (Not (Decimal.Compare(numQtyPack.Value, Decimal.Zero) > 0 And Decimal.Compare(numQtyPack.Value, Convert.ToDecimal(txtStockPack.Text)) <= 0)) Then
                valid(9) = False
                numQtyPack.BackColor = Color.Pink
            Else
                valid(9) = True
                numQtyPack.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub numQtyPiece_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles numQtyPiece.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            btnAdd.Select()
        End If
    End Sub

    Private Sub numQtyPiece_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numQtyPiece.ValueChanged
        Try
            numQtyStrip.Value = New Decimal(Convert.ToDouble(numQtyPiece.Value) / stripc)
            numQtyPack.Value = New Decimal(Convert.ToDouble(numQtyPiece.Value) / stripc / packc)
            If (Decimal.Compare(numQtyPiece.Value, Decimal.Zero) <= 0) Then
                valid(11) = False
                numQtyPiece.BackColor = Color.Pink
            Else
                valid(11) = True
                numQtyPiece.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub numQtyStrip_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles numQtyStrip.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numQtyPiece.Select()
            numQtyPiece.Select(0, numQtyPiece.Text.Length)
        End If
    End Sub

    Private Sub numQtyStrip_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numQtyStrip.ValueChanged
        Try
            numQtyPack.Value = New Decimal(Convert.ToDouble(numQtyStrip.Value) / packc)
            numQtyPiece.Value = New Decimal(Convert.ToDouble(numQtyStrip.Value) * stripc)
            If (Not (Decimal.Compare(numQtyStrip.Value, Decimal.Zero) > 0 And Decimal.Compare(numQtyStrip.Value, Convert.ToDecimal(txtStockStrip.Text)) <= 0)) Then
                valid(10) = False
                numQtyStrip.BackColor = Color.Pink
            Else
                valid(10) = True
                numQtyStrip.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub numWallet_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles numWallet.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            If (Decimal.Compare(numWallet.Value, Decimal.Zero) = 0) Then
                numCredit.Select()
                numCredit.Select(0, numCredit.Text.Length)
            ElseIf (Decimal.Compare(numWallet.Value, Decimal.Zero) > 0) Then
                txtWalletRem.Select()
            End If
        End If
    End Sub

    Private Sub numWallet_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numWallet.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(Decimal.Add(numCash.Value, numBank.Value), numCard.Value), numWallet.Value))
    End Sub

    Private Sub radioInstruCHQ_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles radioInstruCHQ.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            txtInstruID.Select()
        End If
    End Sub

    Private Sub radioInstruDD_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles radioInstruDD.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            txtInstruID.Select()
        End If
    End Sub

    Private Sub SaleEntry_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        selectData("select id,name,contact,email,credit from patient", patient)
        selectData("select * from pdoctor", pdoctor)
        selectData("select * from medicine", item)
        selectData("select * from cardtypes", cards)
        cmbPatientID.Items.Clear()
        cmbPatientName.Items.Clear()
        cmbDocReg.Items.Clear()
        cmbDocName.Items.Clear()
        cmbItemName.Items.Clear()
        cmbItemCode.Items.Clear()
        cmbBatchCode.Items.Clear()
        cmbLiveBatch.Items.Clear()
        If (cards.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = cards.Tables(0).Rows.Count - 1
            For num As Integer = 0 To count Step 1
                cmbCardType.Items.Add(cards.Tables(0).Rows(num)(0).ToString())
            Next

        End If
        If (patient.Tables(0).Rows.Count > 0) Then
            Dim count1 As Integer = patient.Tables(0).Rows.Count - 1
            For j As Integer = 0 To count1 Step 1
                cmbPatientID.Items.Add(patient.Tables(0).Rows(j)(0).ToString())
                cmbPatientName.Items.Add(patient.Tables(0).Rows(j)(1).ToString())
            Next

        End If
        If (pdoctor.Tables(0).Rows.Count > 0) Then
            Dim num1 As Integer = pdoctor.Tables(0).Rows.Count - 1
            For k As Integer = 0 To num1 Step 1
                cmbDocReg.Items.Add(pdoctor.Tables(0).Rows(k)(0).ToString())
                cmbDocName.Items.Add(pdoctor.Tables(0).Rows(k)(1).ToString())
            Next

        End If
        If (item.Tables(0).Rows.Count > 0) Then
            Dim count2 As Integer = item.Tables(0).Rows.Count - 1
            For l As Integer = 0 To count2 Step 1
                cmbItemCode.Items.Add(item.Tables(0).Rows(l)(0).ToString())
                cmbItemName.Items.Add(item.Tables(0).Rows(l)(1).ToString())
            Next

        End If
        Dim i As Integer = 0
        Do
            valid(i) = False
            i = i + 1
        Loop While i <= 11
        Timer1.Interval = 100
        Timer1.Start()
        cmbPatientID.Select()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If (DataGridView1.Rows.Count <= 0) Then
            btnRemove.Enabled = False
            cmbPatientID.Enabled = True
            cmbPatientName.Enabled = True
            txtPatientNo.Enabled = True
            txtPatientEmail.Enabled = True
            cmbDocReg.Enabled = True
            cmbDocName.Enabled = True
            btnNewPatient.Enabled = True
            btnNewDoc.Enabled = True
            numDiscount.[ReadOnly] = False
            numDiscount.Enabled = True
        Else
            btnRemove.Enabled = True
            cmbPatientID.Enabled = False
            cmbPatientName.Enabled = False
            txtPatientNo.Enabled = False
            txtPatientEmail.Enabled = False
            cmbDocReg.Enabled = False
            cmbDocName.Enabled = False
            btnNewPatient.Enabled = False
            btnNewDoc.Enabled = False
            numDiscount.[ReadOnly] = True
            numDiscount.Enabled = False
        End If
        Dim num As Integer = 0
        Do
            Debug.WriteLine(String.Concat(num.ToString(), " ", valid(num).ToString()))
            If (valid(num)) Then
                btnAdd.Enabled = True
                num = num + 1
            Else
                btnAdd.Enabled = False
                Exit Do
            End If
        Loop While num <= 11
        If (radioInstruNA.Checked) Then
            instru = "N/A"
            txtInstruID.Text = "N/A"
            txtInstruID.Enabled = False
        ElseIf (radioInstruCHQ.Checked) Then
            instru = "CHQ"
            txtInstruID.Enabled = True
        ElseIf (radioInstruDD.Checked) Then
            instru = "DD"
            txtInstruID.Enabled = True
        End If
        If (Not (Operators.CompareString(cmbPatientID.Text, "N/A", False) = 0 And Decimal.Compare(Math.Floor(numCredit.Value), Decimal.Zero) > 0 And DataGridView1.Rows.Count > 0)) Then
            btnComplete.Enabled = True
        Else
            Dim text() As String = {cmbPatientID.Text, " ", Nothing, Nothing, Nothing}
            Dim num1 As Decimal = Math.Floor(numCredit.Value)
            text(2) = num1.ToString()
            text(3) = " "
            Dim count As Integer = DataGridView1.Rows.Count
            text(4) = count.ToString()
            Debug.WriteLine(String.Concat(text))
            btnComplete.Enabled = False
        End If
        Dim amt As Double = 0
        Dim gst As Double = 0
        Dim mrp As Double = 0
        Dim discount As Double = 0
        Dim expd As Double = 0
        Dim qty As Double = 0
        Dim gross As Double = 0
        If (DataGridView1.Rows.Count > 0) Then
            Dim count1 As Integer = DataGridView1.Rows.Count - 1
            Dim i As Integer = 0
            Do
                qty = Convert.ToDouble(DataGridView1.Rows(i).Cells(10).Value)
                mrp = Convert.ToDouble(DataGridView1.Rows(i).Cells(13).Value)
                discount = Convert.ToDouble(DataGridView1.Rows(i).Cells(14).Value)
                discount = (100 - discount) / 100
                gross = mrp * qty
                amt = discount * gross
                i = i + 1
            Loop While i <= count1
            numGross.Value = New Decimal(gross)
            numNet.Value = New Decimal(amt)
        End If
    End Sub

    Private Sub txtInstruID_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtInstruID.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numWallet.Select()
            numWallet.Select(0, numWallet.Text.Length)
        End If
    End Sub

    Private Sub txtPatientEmail_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPatientEmail.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            cmbDocReg.Select()
        End If
    End Sub

    Private Sub txtPatientEmail_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPatientEmail.TextChanged
        Try
            If (txtPatientEmail.Text.Length <= 0) Then
                valid(3) = True
                txtPatientEmail.BackColor = Color.LightGreen
            ElseIf (Not (txtPatientEmail.Text.Contains("@") And txtPatientEmail.Text.Contains("."))) Then
                valid(3) = False
                txtPatientEmail.BackColor = Color.Pink
            Else
                valid(3) = True
                txtPatientEmail.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub txtPatientNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPatientNo.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            txtPatientEmail.Select()
        End If
    End Sub

    Private Sub txtPatientNo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPatientNo.TextChanged
        Try
            Dim count As Integer = patient.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count
                If (Operators.CompareString(txtPatientNo.Text, patient.Tables(0).Rows(i)(2).ToString(), False) <> 0) Then
                    i = i + 1
                Else
                    cmbPatientID.Text = patient.Tables(0).Rows(i)(0).ToString()
                    cmbPatientName.Text = patient.Tables(0).Rows(i)(1).ToString()
                    txtPatientEmail.Text = " "
                    txtPatientEmail.Text = ""
                    txtPatientEmail.Text = patient.Tables(0).Rows(i)(3).ToString()
                    numPatCredit.Value = Convert.ToDecimal(patient.Tables(0).Rows(i)(4).ToString())
                    Exit While
                End If
            End While
            If (Not (txtPatientNo.Text.Length = 0 Or Not Versioned.IsNumeric(txtPatientNo.Text))) Then
                valid(2) = True
                txtPatientNo.BackColor = Color.LightGreen
            Else
                valid(2) = False
                txtPatientNo.BackColor = Color.Pink
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub txtWalletRem_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtWalletRem.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numCredit.Select()
            numCredit.Select(0, numCredit.Text.Length)
        End If
    End Sub

    Private Sub numDiscount_ValueChanged(sender As Object, e As EventArgs) Handles numDiscount.ValueChanged
        numNet.Value = ((100 - numDiscount.Value) / 100) * numGross.Value
    End Sub
End Class