Imports Microsoft.VisualBasic.CompilerServices
Imports OnusMed.My.Resources
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class SaleReturn
    Private invoice As DataSet = New DataSet()

    Private patient As DataSet = New DataSet()

    Private cards As DataSet = New DataSet()

    Private search As DataSet = New DataSet()

    Private packc As Integer

    Private stripc As Integer

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
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
            Dim objArray(18) As Object
            objArray(0) = dgvSearch.SelectedRows(0).Cells(0).Value.ToString()
            objArray(1) = dgvSearch.SelectedRows(0).Cells(1).Value.ToString()
            objArray(2) = dgvSearch.SelectedRows(0).Cells(2).Value.ToString()
            objArray(3) = idate
            objArray(4) = dgvSearch.SelectedRows(0).Cells(4).Value.ToString()
            objArray(5) = dgvSearch.SelectedRows(0).Cells(5).Value.ToString()
            objArray(6) = dgvSearch.SelectedRows(0).Cells(6).Value.ToString()
            objArray(7) = dgvSearch.SelectedRows(0).Cells(7).Value.ToString()
            Dim value As Decimal = numQtyPacks.Value
            objArray(8) = value.ToString()
            value = numQtyStrips.Value
            objArray(9) = value.ToString()
            value = numQtyPieces.Value
            objArray(10) = value.ToString()
            objArray(11) = dgvSearch.SelectedRows(0).Cells(11).Value.ToString()
            objArray(12) = dgvSearch.SelectedRows(0).Cells(12).Value.ToString()
            objArray(13) = dgvSearch.SelectedRows(0).Cells(13).Value.ToString()
            objArray(14) = dgvSearch.SelectedRows(0).Cells(14).Value.ToString()
            objArray(15) = dgvSearch.SelectedRows(0).Cells(15).Value.ToString()
            objArray(16) = dgvSearch.SelectedRows(0).Cells(16).Value.ToString()
            objArray(17) = dgvSearch.SelectedRows(0).Cells(17).Value.ToString()
            objArray(18) = dgvSearch.SelectedRows(0).Cells(18).Value.ToString()
            rows.Add(objArray)
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub btnComplete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnComplete.Click
        If (dgvList.Rows.Count > 0) Then
            Dim sreturn As String = ""
            Dim inventory As String = ""
            Dim credit As String = ""
            Dim payment As String = ""
            Dim pid As String = ""
            Dim inv As String = ""
            Dim instru As String = ""
            If (radioNA.Checked) Then
                instru = radioNA.Text
            ElseIf (radioCHQ.Checked) Then
                instru = radioCHQ.Text
            ElseIf (radioDD.Checked) Then
                instru = radioDD.Text
            End If
            Dim count As Integer = dgvList.Rows.Count - 1
            Dim i As Integer = 0
            Do
                sreturn = String.Concat(New String() {"insert into sales_r values('", dgvList.Rows(i).Cells(0).Value.ToString(), "','", dgvList.Rows(i).Cells(1).Value.ToString(), "','", dgvList.Rows(i).Cells(2).Value.ToString(), "',curdate(),'", dgvList.Rows(i).Cells(4).Value.ToString(), "','", dgvList.Rows(i).Cells(5).Value.ToString(), "','", dgvList.Rows(i).Cells(6).Value.ToString(), "','", dgvList.Rows(i).Cells(7).Value.ToString(), "',", dgvList.Rows(i).Cells(8).Value.ToString(), ",", dgvList.Rows(i).Cells(9).Value.ToString(), ",", dgvList.Rows(i).Cells(10).Value.ToString(), ",", dgvList.Rows(i).Cells(11).Value.ToString(), ",", dgvList.Rows(i).Cells(12).Value.ToString(), ",", dgvList.Rows(i).Cells(13).Value.ToString(), ",", dgvList.Rows(i).Cells(14).Value.ToString(), ",", dgvList.Rows(i).Cells(15).Value.ToString(), ",", dgvList.Rows(i).Cells(16).Value.ToString(), ",", dgvList.Rows(i).Cells(17).Value.ToString(), ",", dgvList.Rows(i).Cells(18).Value.ToString(), ");commit;"})
                inventory = String.Concat(New String() {"update inventory set stock_pack=stock_pack+(", dgvList.Rows(i).Cells(8).Value.ToString(), "),stock_strip=stock_strip+(", dgvList.Rows(i).Cells(9).Value.ToString(), "),stock_piece=stock_piece+(", dgvList.Rows(i).Cells(10).Value.ToString(), ") where batchcode='", dgvList.Rows(i).Cells(2).Value.ToString(), "';commit;"})
                inv = dgvList.Rows(i).Cells(0).Value.ToString()
                pid = dgvList.Rows(i).Cells(4).Value.ToString()
                manipulateData(sreturn)
                manipulateData(inventory)
                i = i + 1
            Loop While i <= count
            Dim str() As String = {"insert into sr_payments values('", inv, "',curdate(),", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
            Dim value As Decimal = numCash.Value
            str(3) = value.ToString()
            str(4) = ","
            value = numBank.Value
            str(5) = value.ToString()
            str(6) = ",'"
            str(7) = instru
            str(8) = "','"
            str(9) = txtInstruNo.Text
            str(10) = "',"
            value = numCredit.Value
            str(11) = value.ToString()
            str(12) = ");commit;"
            payment = String.Concat(str)
            Dim strArrays() As String = {"update patient set credit=credit-(", Nothing, Nothing, Nothing, Nothing}
            value = numCredit.Value
            strArrays(1) = value.ToString()
            strArrays(2) = ") where id='"
            strArrays(3) = pid
            strArrays(4) = "';commit;"
            credit = String.Concat(strArrays)
            manipulateData(payment)
            manipulateData(credit)
            Me.Dispose()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        sret = False
        Me.Dispose()
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

        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Dim query As String = ""
        If (radioInvoice.Checked) Then
            query = String.Concat("select * from sales where invoice_no='", cmbInvoiceNo.Text, "'")
        ElseIf (radioPatient.Checked) Then
            query = String.Concat("select * from sales where pid='", cmbPatId.Text, "'")
        ElseIf (radioContact.Checked) Then
            Dim temp As DataSet = New DataSet()
            query = String.Concat("select id from patient where contact='", txtPhn.Text, "'")
            selectData(query, temp)
            If (temp.Tables(0).Rows.Count > 0) Then
                Dim id As String = temp.Tables(0).Rows(0)(0).ToString()
                query = String.Concat("select * from sales where pid='", id, "'")
            End If
        End If
        selectData(query, search)
        dgvSearch.DataSource = search.Tables(0)
    End Sub

    Private Sub dgvList_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvList.RowsAdded
        If (dgvList.Rows.Count > 0) Then
            Dim gross As Double = 0
            Dim net As Double = 0
            Dim count As Integer = dgvList.Rows.Count - 1
            Dim i As Integer = 0
            Do
                Dim tgross As Double = Convert.ToDouble(Decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(8).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(11).Value))))
                Dim disc As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(14).Value)))
                Dim tax As Double = 0
                Dim j As Integer = 15
                Do
                    tax += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(j).Value)))
                    j = j + 1
                Loop While j <= 18
                Dim tnet As Double = (100 - disc) / 100 * tgross + tax / 100 * tgross
                gross += tgross
                net += tnet
                i = i + 1
            Loop While i <= count
            numGross.Value = New Decimal(gross)
            numNet.Value = New Decimal(net)
        End If
        If (dgvList.Rows.Count = 1) Then
            Dim inv As String = dgvSearch.SelectedRows(0).Cells(0).Value.ToString()
            selectData(String.Concat("select * from sales where invoice_no='", inv, "'"), search)
            dgvSearch.DataSource = search.Tables(0)
        End If
    End Sub

    Private Sub dgvList_RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs) Handles dgvList.RowsRemoved
        If (dgvList.Rows.Count > 0) Then
            Dim gross As Double = 0
            Dim net As Double = 0
            Dim count As Integer = dgvList.Rows.Count - 1
            Dim i As Integer = 0
            Do
                Dim tgross As Double = Convert.ToDouble(Decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(8).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(11).Value))))
                Dim disc As Double = Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(14).Value)))
                Dim tax As Double = 0
                Dim j As Integer = 15
                Do
                    tax += Convert.ToDouble(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvList.Rows(i).Cells(j).Value)))
                    j = j + 1
                Loop While j <= 18
                Dim tnet As Double = (100 - disc) / 100 * tgross + tax / 100 * tgross
                gross += tgross
                net += tnet
                i = i + 1
            Loop While i <= count
            numGross.Value = New Decimal(gross)
            numNet.Value = New Decimal(net)
        End If
        If (dgvList.Rows.Count = 1) Then
            Dim inv As String = dgvSearch.SelectedRows(0).Cells(0).Value.ToString()
            selectData(String.Concat("select * from sales where invoice_no='", inv, "'"), search)
            dgvSearch.DataSource = search.Tables(0)
        End If
    End Sub

    Private Sub dgvSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles dgvSearch.Click
        Dim num As Decimal
        Try
            Dim temp As DataSet = New DataSet()
            Dim returns As DataSet = New DataSet()
            temp.Tables.Clear()
            temp.Clear()
            selectData(String.Concat("select name,packc,stripc from medicine where code='", dgvSearch.SelectedRows(0).Cells(1).Value.ToString(), "'"), temp)
            cmbItemName.Text = temp.Tables(0).Rows(0)(0).ToString()
            cmbItemCode.Text = dgvSearch.SelectedRows(0).Cells(1).Value.ToString()
            txtBatch.Text = dgvSearch.SelectedRows(0).Cells(2).Value.ToString()
            numDiscount.Value = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(14).Value))
            packc = Integer.Parse(Conversions.ToString(temp.Tables(0).Rows(0)(1)))
            stripc = Integer.Parse(Conversions.ToString(temp.Tables(0).Rows(0)(2)))
            returns.Tables.Clear()
            returns.Clear()
            selectData(String.Concat(New String() {"select sum(pack_q),sum(stripq),sum(pieceq) from sales_r where invoice_no='", dgvSearch.SelectedRows(0).Cells(0).Value.ToString(), "' and batchcode='", dgvSearch.SelectedRows(0).Cells(2).Value.ToString(), "'"}), returns)
            Try
                Dim str As System.Windows.Forms.Label = lblPack
                num = Decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(8).Value)), Convert.ToDecimal(returns.Tables(0).Rows(0)(0).ToString()))
                str.Text = num.ToString()
                Dim label As System.Windows.Forms.Label = lblStrip
                num = Decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(9).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(returns.Tables(0).Rows(0)(1))))
                label.Text = num.ToString()
                Dim str1 As System.Windows.Forms.Label = lblPiece
                num = Decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(10).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(returns.Tables(0).Rows(0)(2))))
                str1.Text = num.ToString()
                numQtyPacks.Maximum = Convert.ToDecimal(lblPack.Text)
                numQtyStrips.Maximum = Convert.ToDecimal(lblStrip.Text)
                numQtyPieces.Maximum = Convert.ToDecimal(lblPiece.Text)
            Catch exception As System.Exception
                Dim label1 As System.Windows.Forms.Label = lblPack
                num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(8).Value))
                label1.Text = num.ToString()
                Dim str2 As System.Windows.Forms.Label = lblStrip
                num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(9).Value))
                str2.Text = num.ToString()
                Dim label2 As System.Windows.Forms.Label = lblPiece
                num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dgvSearch.SelectedRows(0).Cells(10).Value))
                label2.Text = num.ToString()
                numQtyPacks.Maximum = Convert.ToDecimal(lblPack.Text)
                numQtyStrips.Maximum = Convert.ToDecimal(lblStrip.Text)
                numQtyPieces.Maximum = Convert.ToDecimal(lblPiece.Text)
            End Try
            numQtyPacks.Value = Decimal.Zero
            numQtyStrips.Value = Decimal.Zero
            numQtyPieces.Value = Decimal.Zero
        Catch exception1 As System.Exception

        End Try
    End Sub

    Private Sub numBank_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(numCash.Value, numBank.Value))
    End Sub

    Private Sub numCash_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(numCash.Value, numBank.Value))
    End Sub

    Private Sub numNet_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(numCash.Value, numBank.Value))
    End Sub

    Private Sub numQtyPacks_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            numQtyStrips.Value = Decimal.Multiply(numQtyPacks.Value, New Decimal(packc))
            numQtyPieces.Value = Decimal.Multiply(Decimal.Multiply(numQtyPacks.Value, New Decimal(packc)), New Decimal(stripc))
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub numQtyPieces_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            numQtyPacks.Value = Decimal.Divide(Decimal.Divide(numQtyPieces.Value, New Decimal(stripc)), New Decimal(packc))
            numQtyStrips.Value = Decimal.Divide(numQtyPieces.Value, New Decimal(stripc))
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub numQtyStrips_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            numQtyPacks.Value = Decimal.Divide(numQtyStrips.Value, New Decimal(packc))
            numQtyPieces.Value = Decimal.Multiply(numQtyStrips.Value, New Decimal(stripc))
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub SaleReturn_Load(ByVal sender As Object, ByVal e As EventArgs)
        selectData("select distinct invoice_no from sales where not pid='N/A'", invoice)
        selectData("select distinct pid from sales where not pid='N/A'", patient)
        selectData("select * from cardtypes", cards)
        cmbInvoiceNo.DataSource = invoice.Tables(0)
        cmbInvoiceNo.DisplayMember = "invoice_no"
        cmbPatId.DataSource = patient.Tables(0)
        cmbPatId.DisplayMember = "pid"
        sret = True
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If (Not radioNA.Checked) Then
                txtInstruNo.Enabled = True
            Else
                txtInstruNo.Text = ""
                txtInstruNo.Enabled = True
            End If
            If (radioInvoice.Checked) Then
                cmbInvoiceNo.Enabled = True
                cmbPatId.Text = ""
                cmbPatId.Enabled = False
                txtPhn.Text = ""
                txtPhn.Enabled = False
            ElseIf (radioPatient.Checked) Then
                cmbInvoiceNo.Text = ""
                cmbInvoiceNo.Enabled = False
                cmbPatId.Enabled = True
                txtPhn.Text = ""
                txtPhn.Enabled = False
            ElseIf (Not radioContact.Checked) Then
                cmbInvoiceNo.Text = ""
                cmbInvoiceNo.Enabled = False
                cmbPatId.Text = ""
                cmbPatId.Enabled = False
                txtPhn.Text = ""
                txtPhn.Enabled = False
            Else
                cmbInvoiceNo.Text = ""
                cmbInvoiceNo.Enabled = False
                cmbPatId.Text = ""
                cmbPatId.Enabled = False
                txtPhn.Enabled = True
            End If
            If (dgvList.Rows.Count <= 0) Then
                grpSearch.Enabled = True
                btnRemove.Enabled = False
            Else
                grpSearch.Enabled = False
                btnRemove.Enabled = True
            End If
            If (Not (Decimal.Compare(Math.Floor(numQtyPacks.Value), Decimal.Zero) > 0 Or Decimal.Compare(Math.Floor(numQtyStrips.Value), Decimal.Zero) > 0 Or Decimal.Compare(Math.Floor(numQtyPieces.Value), Decimal.Zero) > 0)) Then
                btnAdd.Enabled = False
            Else
                btnAdd.Enabled = True
            End If
            If (Not (Operators.CompareString(cmbInvoiceNo.Text, "", False) = 0 And Operators.CompareString(cmbPatId.Text, "", False) = 0 And Operators.CompareString(txtPhn.Text, "", False) = 0)) Then
                btnSearch.Enabled = True
            Else
                btnSearch.Enabled = False
            End If
            If (Not radioNA.Checked) Then
                txtInstruNo.Enabled = True
            Else
                txtInstruNo.Text = ""
                txtInstruNo.Enabled = False
                numBank.Value = Decimal.Zero
            End If
            If (radioNA.Checked And txtInstruNo.Text.Length = 0) Then
                btnComplete.Enabled = True
            ElseIf (Not (Not radioNA.Checked And txtInstruNo.Text.Length > 0)) Then
                btnComplete.Enabled = False
            Else
                btnComplete.Enabled = True
            End If
        Catch exception As System.Exception

        End Try
    End Sub
End Class