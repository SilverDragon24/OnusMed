Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class PurchaseReturn
    Private batches As DataSet = New DataSet()

    Private suppliers As DataSet = New DataSet()

    Private invoices As DataSet = New DataSet()

    Private search As DataSet = New DataSet()

    Private packc As Double

    Private stripc As Double

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim str(4) As String
        Dim year As Integer = DateTime.Today.Year
        str(0) = year.ToString()
        str(1) = "-"
        year = DateTime.Today.Month
        str(2) = year.ToString()
        str(3) = "-"
        year = DateTime.Today.Day
        str(4) = year.ToString()
        Dim idate As String = String.Concat(str)
        Dim rows As DataGridViewRowCollection = dgvList.Rows
        Dim text(18) As Object
        text(0) = dgvSearch.SelectedRows(0).Cells(0).Value.ToString()
        text(1) = cmbItemCode.Text
        text(2) = txtItemBatch.Text
        text(3) = cmbSuppId.Text
        text(4) = idate
        Dim num As Decimal = Math.Round(numQtyPack.Value, 2)
        text(5) = num.ToString()
        num = Math.Round(numQtyStrip.Value, 2)
        text(6) = num.ToString()
        num = Math.Round(numQtyPiece.Value, 2)
        text(7) = num.ToString()
        num = Math.Round(numFreePack.Value, 2)
        text(8) = num.ToString()
        num = Math.Round(numFreeStrip.Value, 2)
        text(9) = num.ToString()
        num = Math.Round(numFreePiece.Value, 2)
        text(10) = num.ToString()
        text(11) = dgvSearch.SelectedRows(0).Cells(15).Value.ToString()
        text(12) = dgvSearch.SelectedRows(0).Cells(16).Value.ToString()
        text(13) = dgvSearch.SelectedRows(0).Cells(17).Value.ToString()
        text(14) = dgvSearch.SelectedRows(0).Cells(18).Value.ToString()
        text(15) = dgvSearch.SelectedRows(0).Cells(19).Value.ToString()
        text(16) = dgvSearch.SelectedRows(0).Cells(20).Value.ToString()
        text(17) = dgvSearch.SelectedRows(0).Cells(21).Value.ToString()
        text(18) = dgvSearch.SelectedRows(0).Cells(22).Value.ToString()
        rows.Add(text)
        If (dgvList.Rows.Count = 1) Then
            selectData(String.Concat("select * from purchase where invoice_no='", txtInvoiceNo.Text, "'"), search)
            dgvSearch.DataSource = search.Tables(0)
        End If
    End Sub

    Private Sub btnComplete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnComplete.Click
        Dim p_return As String = ""
        Dim invent As String = ""
        Dim payment As String = ""
        Dim credit As String = ""
        If (dgvList.Rows.Count > 0) Then
            Dim bank_instru As String = ""
            If (radioNA.Checked) Then
                bank_instru = "N/A"
            ElseIf (radioCHQ.Checked) Then
                bank_instru = "CHQ"
            ElseIf (radioDD.Checked) Then
                bank_instru = "DD"
            End If
            Dim count As Integer = dgvList.Rows.Count - 1
            Dim i As Integer = 0
            Do
                p_return = String.Concat(New String() {"insert into purchase_r values('", dgvList.Rows(i).Cells(0).Value.ToString(), "','", dgvList.Rows(i).Cells(1).Value.ToString(), "','", dgvList.Rows(i).Cells(2).Value.ToString(), "','", dgvList.Rows(i).Cells(3).Value.ToString(), "',curdate(),", dgvList.Rows(i).Cells(5).Value.ToString(), ",", dgvList.Rows(i).Cells(6).Value.ToString(), ",", dgvList.Rows(i).Cells(7).Value.ToString(), ",", dgvList.Rows(i).Cells(8).Value.ToString(), ",", dgvList.Rows(i).Cells(9).Value.ToString(), ",", dgvList.Rows(i).Cells(10).Value.ToString(), ",", dgvList.Rows(i).Cells(11).Value.ToString(), ",", dgvList.Rows(i).Cells(12).Value.ToString(), ",", dgvList.Rows(i).Cells(13).Value.ToString(), ",", dgvList.Rows(i).Cells(14).Value.ToString(), ",", dgvList.Rows(i).Cells(15).Value.ToString(), ",", dgvList.Rows(i).Cells(16).Value.ToString(), ",", dgvList.Rows(i).Cells(17).Value.ToString(), ",", dgvList.Rows(i).Cells(18).Value.ToString(), ");commit;"})
                Dim qpack As Double = Convert.ToDouble(Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(5).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(8).Value))))
                Dim qstrip As Double = Convert.ToDouble(Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(6).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(9).Value))))
                Dim qpiece As Double = Convert.ToDouble(Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(7).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(10).Value))))
                invent = String.Concat(New String() {"update inventory set stock_pack=stock_pack-(", qpack.ToString(), "),stock_strip=stock_strip-(", qstrip.ToString(), "),stock_piece=stock_piece-(", qpiece.ToString(), ") where batchcode='", dgvList.Rows(i).Cells(2).Value.ToString(), "';commit;"})
                manipulateData(p_return)
                manipulateData(invent)
                i = i + 1
            Loop While i <= count
            Dim str(16) As String
            str(0) = "insert into pr_payments values('"
            str(1) = dgvList.Rows(0).Cells(0).Value.ToString()
            str(2) = "',curdate(),"
            Dim value As Decimal = numCash.Value
            str(3) = value.ToString()
            str(4) = ","
            value = numBank.Value
            str(5) = value.ToString()
            str(6) = ",'"
            str(7) = bank_instru
            str(8) = "','"
            str(9) = txtInstruNo.Text
            str(10) = "',"
            value = numCard.Value
            str(11) = value.ToString()
            str(12) = ",'"
            str(13) = cmbCardType.Text
            str(14) = "',"
            value = numCredit.Value
            str(15) = value.ToString()
            str(16) = ");commit;"
            payment = String.Concat(str)
            Dim strArrays() As String = {"update supplier set credit=credit-(", Nothing, Nothing, Nothing, Nothing}
            value = numCredit.Value
            strArrays(1) = value.ToString()
            strArrays(2) = ") where id='"
            strArrays(3) = dgvList.Rows(0).Cells(3).Value.ToString()
            strArrays(4) = "';commit;"
            credit = String.Concat(strArrays)
            manipulateData(payment)
            manipulateData(credit)
            MyBase.Dispose()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        pret = False
        MyBase.Dispose()
    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFInd.Click
        Dim query As String = ""
        If (radioBatch.Checked) Then
            query = String.Concat("select * from purchase where batchcode='", cmbBatchCode.Text, "'")
        ElseIf (radioSupplier.Checked) Then
            query = String.Concat("select * from purchase where suppl='", cmbSupplier.Text, "'")
        ElseIf (radioInvoice.Checked) Then
            query = String.Concat("select * from purchase where invoice_no='", cmbInvoice.Text, "'")
        End If
        selectData(query, search)
        dgvSearch.DataSource = search.Tables(0)
    End Sub

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
        Dim enumerator As IEnumerator = Nothing
        Try
            Try
                enumerator = dgvList.SelectedRows.GetEnumerator()
                While enumerator.MoveNext()
                    Dim row As DataGridViewRow = DirectCast(enumerator.Current, DataGridViewRow)
                    dgvList.Rows.Remove(row)
                End While
            Finally
                If (TypeOf enumerator Is IDisposable) Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub dgvSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles dgvSearch.Click
        If (dgvSearch.SelectedRows.Count = 1) Then
            Dim supplier As DataSet = New DataSet()
            Dim item As DataSet = New DataSet()
            Dim inventory As DataSet = New DataSet()
            Dim returnedfree As DataSet = New DataSet()
            selectData(String.Concat("select id,name,contact from supplier where id='", dgvSearch.SelectedRows(0).Cells(3).Value.ToString(), "'"), supplier)
            selectData(String.Concat("select code,name,packc,stripc from medicine where code='", dgvSearch.SelectedRows(0).Cells(1).Value.ToString(), "'"), item)
            selectData(String.Concat("select batchcode,stock_pack,stock_strip,stock_piece from inventory where batchcode='", dgvSearch.SelectedRows(0).Cells(2).Value.ToString(), "'"), inventory)
            selectData(String.Concat(New String() {"select invoice_no,sum(free_pack),sum(free_strip),sum(free_piece) from purchase_r where invoice_no='", dgvSearch.SelectedRows(0).Cells(0).Value.ToString(), "' and batchcode='", dgvSearch.SelectedRows(0).Cells(2).Value.ToString(), "'"}), returnedfree)
            txtInvoiceNo.Text = dgvSearch.SelectedRows(0).Cells(0).Value.ToString()
            cmbSuppId.Text = supplier.Tables(0).Rows(0)(0).ToString()
            cmbSuppName.Text = supplier.Tables(0).Rows(0)(1).ToString()
            txtSuppNo.Text = supplier.Tables(0).Rows(0)(2).ToString()
            cmbItemName.Text = item.Tables(0).Rows(0)(1).ToString()
            cmbItemCode.Text = item.Tables(0).Rows(0)(0).ToString()
            packc = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(item.Tables(0).Rows(0)(2))))
            stripc = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(item.Tables(0).Rows(0)(3))))
            txtItemBatch.Text = inventory.Tables(0).Rows(0)(0).ToString()
            numQtyPack.Value = Decimal.Zero
            numQtyStrip.Value = Decimal.Zero
            numQtyPiece.Value = Decimal.Zero
            numFreePack.Value = Decimal.Zero
            numFreeStrip.Value = Decimal.Zero
            numFreePiece.Value = Decimal.Zero
            Dim freepack As Double = Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(9).Value)), 2))
            Dim freestrip As Double = Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(10).Value)), 2))
            Dim freepiece As Double = Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(11).Value)), 2))
            Dim invpack As Double = Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(inventory.Tables(0).Rows(0)(1))), 2))
            Dim invstrip As Double = Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(inventory.Tables(0).Rows(0)(2))), 2))
            Dim invpiece As Double = Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(inventory.Tables(0).Rows(0)(3))), 2))
            Try
                freepack -= Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(returnedfree.Tables(0).Rows(0)(1))), 2))
                freestrip -= Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(returnedfree.Tables(0).Rows(0)(2))), 2))
                freepiece -= Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(returnedfree.Tables(0).Rows(0)(3))), 2))
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            If (invpiece > freepiece) Then
                Dim num As Double = invpack - freepack
                lblStockPack.Text = num.ToString()
                num = invstrip - freestrip
                lblStockStrip.Text = num.ToString()
                num = invpiece - freepiece
                lblStockPiece.Text = num.ToString()
                numQtyPack.Maximum = New Decimal(invpack - freepack)
                numQtyStrip.Maximum = New Decimal(invstrip - freestrip)
                numQtyPiece.Maximum = New Decimal(invpiece - freepiece)
                numFreePack.Maximum = New Decimal(freepack)
                numFreeStrip.Maximum = New Decimal(freestrip)
                numFreePiece.Maximum = New Decimal(freepiece)
            Else
                lblStockPack.Text = "0"
                lblStockStrip.Text = "0"
                lblStockPiece.Text = "0"
                numQtyPack.Maximum = Decimal.Zero
                numQtyStrip.Maximum = Decimal.Zero
                numQtyPiece.Maximum = Decimal.Zero
                numFreePack.Maximum = New Decimal(invpack)
                numFreeStrip.Maximum = New Decimal(invstrip)
                numFreePiece.Maximum = New Decimal(invpiece)
            End If
        End If
    End Sub

    Private Sub numBank_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numBank.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(numCash.Value, numCard.Value), numBank.Value))
    End Sub

    Private Sub numCard_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numCard.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(numCash.Value, numCard.Value), numBank.Value))
    End Sub

    Private Sub numCash_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numCash.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(numCash.Value, numCard.Value), numBank.Value))
    End Sub

    Private Sub numFreePack_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numFreePack.ValueChanged
        numFreeStrip.Value = New Decimal(Convert.ToDouble(numFreePack.Value) * packc)
        numFreePiece.Value = New Decimal(Convert.ToDouble(numFreePack.Value) * packc * stripc)
    End Sub

    Private Sub numFreePiece_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numFreePiece.ValueChanged
        numFreePack.Value = New Decimal(Convert.ToDouble(numFreePiece.Value) / stripc / packc)
        numFreeStrip.Value = New Decimal(Convert.ToDouble(numFreePiece.Value) / stripc)
    End Sub

    Private Sub numFreeStrip_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        numFreePack.Value = New Decimal(Convert.ToDouble(numFreeStrip.Value) / packc)
        numFreePiece.Value = New Decimal(Convert.ToDouble(numFreeStrip.Value) * stripc)
    End Sub

    Private Sub numNet_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(numCash.Value, numCard.Value), numBank.Value))
    End Sub

    Private Sub numQtyPack_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        numQtyStrip.Value = New Decimal(Convert.ToDouble(numQtyPack.Value) * packc)
        numQtyPiece.Value = New Decimal(Convert.ToDouble(numQtyPack.Value) * packc * stripc)
    End Sub

    Private Sub numQtyPiece_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        numQtyPack.Value = New Decimal(Convert.ToDouble(numQtyPiece.Value) / stripc / packc)
        numQtyStrip.Value = New Decimal(Convert.ToDouble(numQtyPiece.Value) / stripc)
    End Sub

    Private Sub numQtyStrip_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        numQtyPack.Value = New Decimal(Convert.ToDouble(numQtyStrip.Value) / packc)
        numQtyPiece.Value = New Decimal(Convert.ToDouble(numQtyStrip.Value) * stripc)
    End Sub

    Private Sub PurchaseReturn_Load(ByVal sender As Object, ByVal e As EventArgs)
        selectData("select distinct batchcode from purchase", batches)
        selectData("select distinct suppl from purchase", suppliers)
        selectData("select distinct invoice_no from purchase", invoices)
        cmbBatchCode.DataSource = batches.Tables(0)
        cmbBatchCode.DisplayMember = "batchcode"
        cmbSupplier.DataSource = suppliers.Tables(0)
        cmbSupplier.DisplayMember = "suppl"
        cmbInvoice.DataSource = invoices.Tables(0)
        cmbInvoice.DisplayMember = "invoice_no"
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If (Not (cmbBatchCode.Text.Length = 0 And cmbSupplier.Text.Length = 0 And cmbInvoice.Text.Length = 0)) Then
            btnFInd.Enabled = True
        Else
            btnFInd.Enabled = False
        End If
        If (dgvList.Rows.Count <= 0) Then
            btnRemove.Enabled = False
        Else
            btnRemove.Enabled = True
        End If
        If (Decimal.Compare(numQtyPiece.Value, Decimal.Zero) <= 0) Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
        If (radioBatch.Checked) Then
            cmbBatchCode.Enabled = True
            cmbSupplier.Text = ""
            cmbSupplier.Enabled = False
            cmbInvoice.Text = ""
            cmbInvoice.Enabled = False
        ElseIf (radioSupplier.Checked) Then
            cmbBatchCode.Text = ""
            cmbBatchCode.Enabled = False
            cmbSupplier.Enabled = True
            cmbInvoice.Text = ""
            cmbInvoice.Enabled = False
        ElseIf (Not radioInvoice.Checked) Then
            cmbBatchCode.Text = ""
            cmbBatchCode.Enabled = False
            cmbSupplier.Text = ""
            cmbSupplier.Enabled = False
            cmbInvoice.Text = ""
            cmbInvoice.Enabled = False
        Else
            cmbBatchCode.Text = ""
            cmbBatchCode.Enabled = False
            cmbSupplier.Text = ""
            cmbSupplier.Enabled = False
            cmbInvoice.Enabled = True
        End If
        If (Not radioNA.Checked) Then
            txtInstruNo.Enabled = True
        Else
            txtInstruNo.Text = ""
            txtInstruNo.Enabled = False
        End If
        If (dgvList.Rows.Count <= 0) Then
            grpFind.Enabled = True
        Else
            grpFind.Enabled = False
        End If
        If (Decimal.Compare(numCard.Value, Decimal.Zero) = 0) Then
            cmbCardType.Text = "N/A"
        End If
        If (dgvList.Rows.Count > 0) Then
            Dim gross As Double = 0
            Dim net As Double = 0
            Dim count As Integer = dgvList.Rows.Count - 1
            Dim i As Integer = 0
            Do
                Dim temptax As Double = 0
                Dim j As Integer = 15
                Do
                    temptax += Convert.ToDouble(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(j).Value)), 2))
                    j = j + 1
                Loop While j <= 18
                Dim tempgross As Double = Convert.ToDouble(Decimal.Multiply(Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(7).Value)), 2), Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(13).Value)), 2)))
                Dim tempdisc As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(14).Value)))
                Dim tempnet As Double = (100 - tempdisc) / 100 * tempgross + temptax / 100 * tempgross
                gross += tempgross
                net += tempnet
                i = i + 1
            Loop While i <= count
            numGross.Value = New Decimal(gross)
            numNet.Value = New Decimal(net)
        End If
    End Sub
End Class