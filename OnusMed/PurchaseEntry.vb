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
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class PurchaseEntry
    Private ds As DataSet = New DataSet
    Private ds0 As DataSet = New DataSet
    Private ds1 As DataSet = New DataSet
    Private s As Double
    Private p As Double
    Private credit As Double
    Private hsn As String
    Private gst As Double
    Private valid As Boolean(16)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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
        Dim strArrays(4) As String
        value = dateExpiry.Value
        year = value.Year
        strArrays(0) = year.ToString()
        strArrays(1) = "-"
        value = dateExpiry.Value
        year = value.Month
        strArrays(2) = year.ToString()
        strArrays(3) = "-"
        value = dateExpiry.Value
        year = value.Year
        Dim [integer] As Integer = Conversions.ToInteger(year.ToString())
        value = dateExpiry.Value
        year = value.Month
        year = DateTime.DaysInMonth([integer], Conversions.ToInteger(year.ToString()))
        strArrays(4) = year.ToString()
        Dim edate As String = String.Concat(strArrays)
        Dim rows As DataGridViewRowCollection = DataGridView1.Rows
        Dim text(24) As Object
        text(0) = txtItemCode.Text
        text(1) = cmbItemName.Text
        text(2) = txtBatchCode.Text
        text(3) = cmbSuppID.Text
        text(4) = cmbSuppName.Text
        text(5) = idate
        text(6) = edate
        Dim num As Decimal = numQtyPack.Value
        text(7) = num.ToString()
        num = numQtyStrip.Value
        text(8) = num.ToString()
        num = numQtyPiece.Value
        text(9) = num.ToString()
        num = numFreePack.Value
        text(10) = num.ToString()
        num = numFreeStrip.Value
        text(11) = num.ToString()
        num = numFreePiece.Value
        text(12) = num.ToString()
        num = numMrpPack.Value
        text(13) = num.ToString()
        num = numMrpStrip.Value
        text(14) = num.ToString()
        num = numMrpPiece.Value
        text(15) = num.ToString()
        num = numPrPack.Value
        text(16) = num.ToString()
        num = numPrStrip.Value
        text(17) = num.ToString()
        num = numPrPiece.Value
        text(18) = num.ToString()
        num = numDiscount.Value
        text(19) = num.ToString()
        num = numCGST.Value
        text(20) = num.ToString()
        num = numSGST.Value
        text(21) = num.ToString()
        num = numIGST.Value
        text(22) = num.ToString()
        num = numED.Value
        text(23) = num.ToString()
        num = Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Subtract(Decimal.Multiply(numQtyPack.Value, numPrPack.Value), Decimal.Multiply(Decimal.Divide(numDiscount.Value, New Decimal(CLng(100))), Decimal.Multiply(numQtyPack.Value, numPrPack.Value))), Decimal.Multiply(Decimal.Divide(numCGST.Value, New Decimal(CLng(100))), Decimal.Multiply(numQtyPack.Value, numPrPack.Value))), Decimal.Multiply(Decimal.Divide(numSGST.Value, New Decimal(CLng(100))), Decimal.Multiply(numQtyPack.Value, numPrPack.Value))), Decimal.Multiply(Decimal.Divide(numIGST.Value, New Decimal(CLng(100))), Decimal.Multiply(numQtyPack.Value, numPrPack.Value)))
        text(24) = num.ToString()
        rows.Add(text)
        txtInvoiceNo.[ReadOnly] = True
        numDiscount.[ReadOnly] = True
        cmbItemName.Text = ""
        txtItemCode.Text = ""
        txtBatchCode.Text = ""
        numQtyPack.Value = Decimal.Zero
        numQtyStrip.Value = Decimal.Zero
        numQtyPiece.Value = Decimal.Zero
        numMrpPack.Value = Decimal.Zero
        numMrpStrip.Value = Decimal.Zero
        numMrpPiece.Value = Decimal.Zero
        numFreePack.Value = Decimal.Zero
        numFreeStrip.Value = Decimal.Zero
        numFreePiece.Value = Decimal.Zero
        numPrPack.Value = Decimal.Zero
        numPrStrip.Value = Decimal.Zero
        numPrPiece.Value = Decimal.Zero
        numED.Value = Decimal.Zero
        numCGST.Value = Decimal.Zero
        numSGST.Value = Decimal.Zero
        numIGST.Value = Decimal.Zero
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
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
        If (DataGridView1.Rows.Count > 0) Then
            ProgressBar1.Minimum = 1
            ProgressBar1.Maximum = 2 * DataGridView1.Rows.Count + 2
            ProgressBar1.Value = 1
            Dim payment As String = ""
            Dim instru As String = ""
            Dim credit As String = ""
            If (radioInstruNA.Checked) Then
                instru = "N/A"
            ElseIf (radioInstruDD.Checked) Then
                instru = "DD"
            ElseIf (radioInstruCHQ.Checked) Then
                instru = "CHQ"
            End If
            Dim count As Integer = DataGridView1.Rows.Count - 1
            Dim i As Integer = 0
            Do
                Dim purchase As String = ""
                Dim inventory As String = ""
                purchase = String.Concat(New String() {"insert into purchase values('", txtInvoiceNo.Text, "','", DataGridView1.Rows(i).Cells(0).Value.ToString(), "','", DataGridView1.Rows(i).Cells(2).Value.ToString(), "','", DataGridView1.Rows(i).Cells(3).Value.ToString(), "','", DataGridView1.Rows(i).Cells(5).Value.ToString(), "','", DataGridView1.Rows(i).Cells(6).Value.ToString(), "',", DataGridView1.Rows(i).Cells(7).Value.ToString(), ",", DataGridView1.Rows(i).Cells(8).Value.ToString(), ",", DataGridView1.Rows(i).Cells(9).Value.ToString(), ",", DataGridView1.Rows(i).Cells(10).Value.ToString(), ",", DataGridView1.Rows(i).Cells(11).Value.ToString(), ",", DataGridView1.Rows(i).Cells(12).Value.ToString(), ",", DataGridView1.Rows(i).Cells(13).Value.ToString(), ",", DataGridView1.Rows(i).Cells(14).Value.ToString(), ",", DataGridView1.Rows(i).Cells(15).Value.ToString(), ",", DataGridView1.Rows(i).Cells(16).Value.ToString(), ",", DataGridView1.Rows(i).Cells(17).Value.ToString(), ",", DataGridView1.Rows(i).Cells(18).Value.ToString(), ",", DataGridView1.Rows(i).Cells(19).Value.ToString(), ",", DataGridView1.Rows(i).Cells(20).Value.ToString(), ",", DataGridView1.Rows(i).Cells(21).Value.ToString(), ",", DataGridView1.Rows(i).Cells(22).Value.ToString(), ",", DataGridView1.Rows(i).Cells(23).Value.ToString(), ",", DataGridView1.Rows(i).Cells(24).Value.ToString(), ");commit;"})
                Dim inv As DataSet = New DataSet()
                selectData(String.Concat("select batchcode from inventory where batchcode='", DataGridView1.Rows(i).Cells(2).Value.ToString(), "'"), inv)
                If (inv.Tables(0).Rows.Count = 0) Then
                    Dim stock_pack As Double = Convert.ToDouble(Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(i).Cells(7).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(i).Cells(10).Value))))
                    Dim stock_strip As Double = Convert.ToDouble(Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(i).Cells(8).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(i).Cells(11).Value))))
                    Dim stock_piece As Double = Convert.ToDouble(Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(i).Cells(9).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.Rows(i).Cells(12).Value))))
                    If (Not chkInterState.Checked) Then
                        inventory = String.Concat(New String() {"insert into inventory values('", DataGridView1.Rows(i).Cells(2).Value.ToString(), "','", DataGridView1.Rows(i).Cells(0).Value.ToString(), "','", DataGridView1.Rows(i).Cells(6).Value.ToString(), "',", DataGridView1.Rows(i).Cells(13).Value.ToString(), ",", DataGridView1.Rows(i).Cells(14).Value.ToString(), ",", DataGridView1.Rows(i).Cells(15).Value.ToString(), ",", DataGridView1.Rows(i).Cells(16).Value.ToString(), ",", DataGridView1.Rows(i).Cells(17).Value.ToString(), ",", DataGridView1.Rows(i).Cells(18).Value.ToString(), ",0,0,0,", DataGridView1.Rows(i).Cells(20).Value.ToString(), ",", DataGridView1.Rows(i).Cells(21).Value.ToString(), ",", DataGridView1.Rows(i).Cells(22).Value.ToString(), ",", stock_pack.ToString(), ",", stock_strip.ToString(), ",", stock_piece.ToString(), ",'GD',false,", DataGridView1.Rows(i).Cells(23).Value.ToString(), ");commit;"})
                    ElseIf (chkInterState.Checked) Then
                        inventory = String.Concat(New String() {"insert into inventory values('", DataGridView1.Rows(i).Cells(2).Value.ToString(), "','", DataGridView1.Rows(i).Cells(0).Value.ToString(), "','", DataGridView1.Rows(i).Cells(6).Value.ToString(), "',", DataGridView1.Rows(i).Cells(13).Value.ToString(), ",", DataGridView1.Rows(i).Cells(14).Value.ToString(), ",", DataGridView1.Rows(i).Cells(15).Value.ToString(), ",0,0,0,", DataGridView1.Rows(i).Cells(16).Value.ToString(), ",", DataGridView1.Rows(i).Cells(17).Value.ToString(), ",", DataGridView1.Rows(i).Cells(18).Value.ToString(), ",", DataGridView1.Rows(i).Cells(20).Value.ToString(), ",", DataGridView1.Rows(i).Cells(21).Value.ToString(), ",", DataGridView1.Rows(i).Cells(22).Value.ToString(), ",", stock_pack.ToString(), ",", stock_strip.ToString(), ",", stock_piece.ToString(), ",'GD', false,", DataGridView1.Rows(i).Cells(23).Value.ToString(), ");commit;"})
                    End If
                    manipulateData(inventory)
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    manipulateData(purchase)
                    ProgressBar1.Value = ProgressBar1.Value + 1
                End If
                i = i + 1
            Loop While i <= count
            Dim text(18) As String
            text(0) = "insert into p_payments values('"
            text(1) = txtInvoiceNo.Text
            text(2) = "','"
            text(3) = idate
            text(4) = "',"
            Dim num As Decimal = numCash.Value
            text(5) = num.ToString()
            text(6) = ","
            num = numCard.Value
            text(7) = num.ToString()
            text(8) = ",'"
            text(9) = cmbCardType.Text
            text(10) = "',"
            num = numBank.Value
            text(11) = num.ToString()
            text(12) = ",'"
            text(13) = instru
            text(14) = "','"
            text(15) = txtInstruNo.Text
            text(16) = "',"
            num = numCredit.Value
            text(17) = num.ToString()
            text(18) = ");commit;"
            payment = String.Concat(text)
            Dim strArrays() As String = {"update supplier set credit=credit+", Nothing, Nothing, Nothing, Nothing}
            num = numCredit.Value
            strArrays(1) = num.ToString()
            strArrays(2) = " where id='"
            strArrays(3) = cmbSuppID.Text
            strArrays(4) = "';commit;"
            credit = String.Concat(strArrays)
            manipulateData(payment)
            manipulateData(credit)
            ProgressBar1.Value = ProgressBar1.Value + 1
            purchasing = True
            Me.Dispose()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        purchasing = False
        Me.Dispose()
    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        NewItem.ShowDialog()
        selectData("select * from medicine", ds)
        cmbItemName.Items.Clear()
        If (ds.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = ds.Tables(0).Rows.Count - 1
            For i As Integer = 0 To count Step 1
                cmbItemName.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
            Next
        End If
    End Sub

    Private Sub btnNewSupp_Click(sender As Object, e As EventArgs) Handles btnNewSupp.Click
        NewSupplier.ShowDialog()
        selectData("select * from supplier", ds0)
        cmbSuppID.Items.Clear()
        cmbSuppName.Items.Clear()
        If (ds0.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = ds0.Tables(0).Rows.Count - 1
            For i As Integer = 0 To count Step 1
                cmbSuppID.Items.Add(ds0.Tables(0).Rows(i)(0).ToString())
                cmbSuppName.Items.Add(ds0.Tables(0).Rows(i)(1).ToString())
            Next
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
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

    Private Sub chkInterState_CheckedChanged(sender As Object, e As EventArgs) Handles chkInterState.CheckedChanged
        If (Not chkInterState.Checked) Then
            numIGST.Value = Decimal.Zero
        Else
            numCGST.Value = Decimal.Zero
            numSGST.Value = Decimal.Zero
        End If
    End Sub

    Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        Dim count As Integer = ds.Tables(0).Rows.Count - 1
        Dim num As Integer = 0
        While num <= count
            If (Operators.CompareString(cmbItemName.Text, ds.Tables(0).Rows(num)(1).ToString(), False) <> 0) Then
                num = num + 1
            Else
                txtItemCode.Text = ds.Tables(0).Rows(num)(0).ToString()
                p = Convert.ToDouble(Convert.ToDecimal(ds.Tables(0).Rows(num)(6).ToString()))
                s = Convert.ToDouble(Convert.ToDecimal(ds.Tables(0).Rows(num)(7).ToString()))
                hsn = ds.Tables(0).Rows(num)(10).ToString()
                gst = Convert.ToDouble(Convert.ToDecimal(ds.Tables(0).Rows(num)(11).ToString()))
                If (Not chkInterState.Checked) Then
                    numCGST.Value = New Decimal(gst / 2)
                    numSGST.Value = New Decimal(gst / 2)
                Else
                    numIGST.Value = New Decimal(gst)
                End If
                Exit While
            End If
        End While
        If (ds.Tables(0).Rows.Count > 0) Then
            Dim count1 As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count1
                If (Not Operators.ConditionalCompareObjectEqual(cmbItemName.Text, ds.Tables(0).Rows(i)(1), False)) Then
                    valid(3) = False
                    cmbItemName.BackColor = Color.Pink
                    i = i + 1
                Else
                    valid(3) = True
                    cmbItemName.BackColor = Color.LightGreen
                    Exit While
                End If
            End While
        End If
    End Sub

    Private Sub cmbItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbItemName.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            txtItemCode.Select()
        End If
    End Sub

    Private Sub cmbSuppID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSuppID.SelectedIndexChanged
        If (ds0.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = ds0.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count
                If (Operators.CompareString(cmbSuppID.Text, ds0.Tables(0).Rows(i)(0).ToString(), False) <> 0) Then
                    i = i + 1
                Else
                    cmbSuppName.Text = ds0.Tables(0).Rows(i)(1).ToString()
                    txtSuppNo.Text = ds0.Tables(0).Rows(i)(7).ToString()
                    txtSuppEmail.Text = ds0.Tables(0).Rows(i)(8).ToString()
                    credit = Convert.ToDouble(Convert.ToDecimal(ds0.Tables(0).Rows(i)(12).ToString()))
                    numSuppCredit.Value = New Decimal(credit)
                    Exit While
                End If
            End While
        End If
        If (cmbSuppID.Text.Length = 0) Then
            valid(0) = False
            cmbSuppID.BackColor = Color.Pink
            Debug.WriteLine(String.Concat("cmbSuppID: ", valid(0).ToString()))
        ElseIf (cmbSuppID.Text.Length > 0) Then
            valid(0) = True
            cmbSuppID.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub cmbSuppID_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbSuppID.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            txtSuppNo.Select()
        End If
    End Sub

    Private Sub cmbSuppName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSuppName.SelectedIndexChanged
        If (ds0.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = ds0.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count
                If (Operators.CompareString(cmbSuppName.Text, ds0.Tables(0).Rows(i)(1).ToString(), False) <> 0) Then
                    i = i + 1
                Else
                    cmbSuppID.Text = ds0.Tables(0).Rows(i)(0).ToString()
                    txtSuppNo.Text = ds0.Tables(0).Rows(i)(7).ToString()
                    txtSuppEmail.Text = ds0.Tables(0).Rows(i)(8).ToString()
                    credit = Convert.ToDouble(Convert.ToDecimal(ds0.Tables(0).Rows(i)(12).ToString()))
                    numSuppCredit.Value = New Decimal(credit)
                    Exit While
                End If
            End While
        End If
        If (cmbSuppName.Text.Length = 0) Then
            valid(1) = False
            cmbSuppName.BackColor = Color.Pink
            Debug.WriteLine(String.Concat("cmbSuppName: ", valid(1).ToString()))
        ElseIf (cmbSuppName.Text.Length > 0) Then
            valid(1) = True
            cmbSuppName.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        If (DataGridView1.Rows.Count <= 0) Then
            numGross.Value = Decimal.Zero
            txtInvoiceNo.ReadOnly = False
            numDiscount.ReadOnly = False
            chkInterState.Enabled = True
        Else
            Dim gross As Double = 0
            Dim count As Integer = DataGridView1.Rows.Count - 1
            Dim i As Integer = 0
            Do
                gross += Convert.ToDouble(Convert.ToDecimal(DataGridView1.Rows(i).Cells(24).Value.ToString()))
                i = i + 1
            Loop While i <= count
            numGross.Value = New Decimal(gross)
            chkInterState.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        If (DataGridView1.Rows.Count <= 0) Then
            numGross.Value = Decimal.Zero
            txtInvoiceNo.ReadOnly = False
            numDiscount.ReadOnly = False
            chkInterState.Enabled = True
        Else
            Dim gross As Double = 0
            Dim count As Integer = DataGridView1.Rows.Count - 1
            Dim i As Integer = 0
            Do
                gross += Convert.ToDouble(Convert.ToDecimal(DataGridView1.Rows(i).Cells(24).Value.ToString()))
                i = i + 1
            Loop While i <= count
            numGross.Value = New Decimal(gross)
            chkInterState.Enabled = False
        End If
    End Sub

    Private Sub dateExpiry_KeyDown(sender As Object, e As KeyEventArgs) Handles dateExpiry.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numPrPack.Select()
            numPrPack.Select(0, numPrPack.Text.Length)
        End If
    End Sub

    Private Sub dateExpiry_ValueChanged(sender As Object, e As EventArgs) Handles dateExpiry.ValueChanged
        If (DateAndTime.DateDiff(DateInterval.Month, DateTime.Today, dateExpiry.Value, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) < CLng(6)) Then
            valid(13) = False
            ErrorProvider1.Clear()
            ErrorProvider1.BlinkRate = 0
            ErrorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            ErrorProvider1.SetError(dateExpiry, "Invalid Date")
            Debug.WriteLine(String.Concat("dateExpiry: ", valid(13).ToString()))
        ElseIf (DateAndTime.DateDiff(DateInterval.Month, DateTime.Today, dateExpiry.Value, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) >= CLng(6)) Then
            valid(13) = True
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub dateInvoiceDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dateInvoiceDate.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numMrpPack.Select()
            numMrpPack.Select(0, numMrpPack.Text.Length)
        End If
    End Sub

    Private Sub numBank_ValueChanged(sender As Object, e As EventArgs) Handles numBank.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(numCash.Value, numCard.Value), numBank.Value))
        If (Decimal.Compare(numBank.Value, Decimal.Zero) > 0) Then
            radioInstruNA.Enabled = False
            radioInstruCHQ.Checked = True
        ElseIf (Decimal.Compare(numBank.Value, Decimal.Zero) = 0) Then
            radioInstruNA.Enabled = True
            radioInstruNA.Checked = True
        End If
    End Sub

    Private Sub numCard_ValueChanged(sender As Object, e As EventArgs) Handles numCard.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(numCash.Value, numCard.Value), numBank.Value))
        If (Decimal.Compare(numCard.Value, Decimal.Zero) = 0) Then
            cmbCardType.Text = "N/A"
        End If
    End Sub

    Private Sub numCash_ValueChanged(sender As Object, e As EventArgs) Handles numCash.ValueChanged
        numCredit.Value = Decimal.Subtract(numNet.Value, Decimal.Add(Decimal.Add(numCash.Value, numCard.Value), numBank.Value))
    End Sub

    Private Sub numCGST_KeyDown(sender As Object, e As KeyEventArgs) Handles numCGST.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numSGST.Select()
            numSGST.Select(0, numSGST.Text.Length)
        End If
    End Sub

    Private Sub numED_KeyDown(sender As Object, e As KeyEventArgs) Handles numED.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            If (Not numIGST.Enabled) Then
                numCGST.Select()
                numCGST.Select(0, numCGST.Text.Length)
            ElseIf (Not numCGST.Enabled And Not numSGST.Enabled) Then
                numIGST.Select()
                numIGST.Select(0, numIGST.Text.Length)
            End If
        End If
    End Sub

    Private Sub numFreePack_KeyDown(sender As Object, e As KeyEventArgs) Handles numFreePack.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numFreeStrip.Select()
            numFreeStrip.Select(0, numFreeStrip.Text.Length)
        End If
    End Sub

    Private Sub numFreePack_ValueChanged(sender As Object, e As EventArgs) Handles numFreePack.ValueChanged
        Try
            numFreeStrip.Value = New Decimal(Convert.ToDouble(numFreePack.Value) * p)
            numFreePiece.Value = New Decimal(Convert.ToDouble(numFreeStrip.Value) * s)
        Catch exception As System.Exception
            numFreePack.Value = Decimal.Zero
            numFreeStrip.Value = Decimal.Zero
            numFreePack.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numFreePiece_ValueChanged(sender As Object, e As EventArgs) Handles numFreePiece.ValueChanged
        Try
            numFreeStrip.Value = New Decimal(Convert.ToDouble(numFreePiece.Value) / s)
            numFreePack.Value = New Decimal(Convert.ToDouble(numFreeStrip.Value) / p)
        Catch exception As System.Exception
            numFreePack.Value = Decimal.Zero
            numFreeStrip.Value = Decimal.Zero
            numFreePack.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numFreePiece_KeyDown(sender As Object, e As KeyEventArgs) Handles numFreePiece.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            dateExpiry.Select()
        End If
    End Sub

    Private Sub numFreeStrip_KeyDown(sender As Object, e As KeyEventArgs) Handles numFreeStrip.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numFreePiece.Select()
            numFreePiece.Select(0, numFreePiece.Text.Length)
        End If
    End Sub

    Private Sub numFreeStrip_ValueChanged(sender As Object, e As EventArgs) Handles numFreeStrip.ValueChanged
        Try
            numFreePiece.Value = New Decimal(Convert.ToDouble(numFreeStrip.Value) * s)
            numFreePack.Value = New Decimal(Convert.ToDouble(numFreeStrip.Value) / p)
        Catch exception As System.Exception
            numFreePack.Value = Decimal.Zero
            numFreeStrip.Value = Decimal.Zero
            numFreePack.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numGross_ValueChanged(sender As Object, e As EventArgs) Handles numGross.ValueChanged
        numNet.Value = Decimal.Subtract(numGross.Value, Decimal.Add(Decimal.Add(numCash.Value, numCard.Value), numBank.Value))
        numCredit.Value = numNet.Value
    End Sub

    Private Sub numIGST_KeyDown(sender As Object, e As KeyEventArgs) Handles numIGST.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            btnAdd.Select()
        End If
    End Sub

    Private Sub numMrpPack_KeyDown(sender As Object, e As KeyEventArgs) Handles numMrpPack.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numMrpStrip.Select()
            numMrpStrip.Select(0, numMrpStrip.Text.Length)
        End If
    End Sub

    Private Sub numMrpPack_ValueChanged(sender As Object, e As EventArgs) Handles numMrpPack.ValueChanged
        Try
            numMrpStrip.Value = New Decimal(Convert.ToDouble(numMrpPack.Value) / p)
            numMrpPiece.Value = New Decimal(Convert.ToDouble(numMrpStrip.Value) / s)
            If (Decimal.Compare(numMrpPack.Value, Decimal.Zero) = 0) Then
                valid(10) = False
                numMrpPack.BackColor = Color.Pink
                Debug.WriteLine(String.Concat("txtMrpPack: ", valid(10).ToString()))
            ElseIf (Decimal.Compare(numMrpPack.Value, Decimal.Zero) > 0) Then
                valid(10) = True
                numMrpPack.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            numMrpPack.Value = Decimal.Zero
            numMrpStrip.Value = Decimal.Zero
            numMrpPiece.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numMrpPiece_KeyDown(sender As Object, e As KeyEventArgs) Handles numMrpPiece.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numFreePack.Select()
            numFreePack.Select(0, numFreePack.Text.Length)
        End If
    End Sub

    Private Sub numMrpPiece_ValueChanged(sender As Object, e As EventArgs) Handles numMrpPiece.ValueChanged
        Try
            numMrpStrip.Value = New Decimal(Convert.ToDouble(numMrpPiece.Value) * s)
            numMrpPack.Value = New Decimal(Convert.ToDouble(numMrpStrip.Value) * p)
            If (Decimal.Compare(numMrpPiece.Value, Decimal.Zero) = 0) Then
                valid(12) = False
                numMrpPiece.BackColor = Color.Pink
                Debug.WriteLine(String.Concat("txtMrpPiece: ", valid(12).ToString()))
            ElseIf (Decimal.Compare(numMrpPiece.Value, Decimal.Zero) > 0) Then
                valid(12) = True
                numMrpPiece.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            numMrpPack.Value = Decimal.Zero
            numMrpStrip.Value = Decimal.Zero
            numMrpPiece.Value = Decimal.Zero
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub numMrpStrip_KeyDown(sender As Object, e As KeyEventArgs) Handles numMrpStrip.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numMrpPiece.Select()
            numMrpPiece.Select(0, numMrpPiece.Text.Length)
        End If
    End Sub

    Private Sub numMrpStrip_ValueChanged(sender As Object, e As EventArgs) Handles numMrpStrip.ValueChanged
        Try
            numMrpPack.Value = New Decimal(Convert.ToDouble(numMrpStrip.Value) * p)
            numMrpPiece.Value = New Decimal(Convert.ToDouble(numMrpStrip.Value) / s)
            If (Decimal.Compare(numMrpStrip.Value, Decimal.Zero) = 0) Then
                valid(11) = False
                numMrpStrip.BackColor = Color.Pink
                Debug.WriteLine(String.Concat("txtMrpStrip: ", valid(11).ToString()))
            ElseIf (Decimal.Compare(numMrpStrip.Value, Decimal.Zero) > 0) Then
                valid(11) = True
                numMrpStrip.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            numMrpPack.Value = Decimal.Zero
            numMrpStrip.Value = Decimal.Zero
            numMrpPiece.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numPrPack_KeyDown(sender As Object, e As KeyEventArgs) Handles numPrPack.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numPrStrip.Select()
            numPrStrip.Select(0, numPrStrip.Text.Length)
        End If
    End Sub

    Private Sub numPrPack_ValueChanged(sender As Object, e As EventArgs) Handles numPrPack.ValueChanged
        Try
            numPrStrip.Value = New Decimal(Convert.ToDouble(numPrPack.Value) / p)
            numPrPiece.Value = New Decimal(Convert.ToDouble(numPrStrip.Value) / s)
            If (Decimal.Compare(numPrPack.Value, Decimal.Zero) = 0) Then
                valid(14) = False
                numPrPack.BackColor = Color.Pink
                Debug.WriteLine(String.Concat("txtPrPack: ", valid(14).ToString()))
            ElseIf (Decimal.Compare(numPrPack.Value, Decimal.Zero) > 0) Then
                valid(14) = True
                numPrPack.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            numPrPack.Value = Decimal.Zero
            numPrStrip.Value = Decimal.Zero
            numPrPiece.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numPrPiece_KeyDown(sender As Object, e As KeyEventArgs) Handles numPrPiece.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numED.Select()
            numED.Select(0, numED.Text.Length)
        End If
    End Sub

    Private Sub numPrPiece_ValueChanged(sender As Object, e As EventArgs) Handles numPrPiece.ValueChanged
        Try
            numPrStrip.Value = New Decimal(Convert.ToDouble(numPrPiece.Value) * s)
            numPrPack.Value = New Decimal(Convert.ToDouble(numPrStrip.Value) * p)
            If (Decimal.Compare(numPrPiece.Value, Decimal.Zero) = 0) Then
                valid(16) = False
                numPrPiece.BackColor = Color.Pink
                Debug.WriteLine(String.Concat("txtPrPiece: ", valid(16).ToString()))
            ElseIf (Decimal.Compare(numPrPiece.Value, Decimal.Zero) > 0) Then
                valid(16) = True
                numPrPiece.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            numPrPack.Text = Conversions.ToString(0)
            numPrStrip.Text = Conversions.ToString(0)
            numPrPiece.Text = Conversions.ToString(0)
        End Try
    End Sub

    Private Sub numPrStrip_KeyDown(sender As Object, e As KeyEventArgs) Handles numPrStrip.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numPrPiece.Select()
            numPrPiece.Select(0, numPrPiece.Text.Length)
        End If
    End Sub

    Private Sub numPrStrip_ValueChanged(sender As Object, e As EventArgs) Handles numPrStrip.ValueChanged
        Try
            numPrPack.Value = New Decimal(Convert.ToDouble(numPrStrip.Value) * p)
            numPrPiece.Value = New Decimal(Convert.ToDouble(numPrStrip.Value) / s)
            If (Decimal.Compare(numPrStrip.Value, Decimal.Zero) = 0) Then
                valid(15) = False
                numPrStrip.BackColor = Color.Pink
                Debug.WriteLine(String.Concat("txtPrStrip: ", valid(15).ToString()))
            ElseIf (Decimal.Compare(numPrStrip.Value, Decimal.Zero) > 0) Then
                valid(15) = True
                numPrStrip.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            numPrPack.Value = Decimal.Zero
            numPrStrip.Value = Decimal.Zero
            numPrPiece.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numQtyPack_KeyDown(sender As Object, e As KeyEventArgs) Handles numQtyPack.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numQtyStrip.Select()
            numQtyStrip.Select(0, numQtyStrip.Text.Length)
        End If
    End Sub

    Private Sub numQtyPack_ValueChanged(sender As Object, e As EventArgs) Handles numQtyPack.ValueChanged
        Try
            numQtyStrip.Value = New Decimal(Convert.ToDouble(numQtyPack.Value) * p)
            numQtyPiece.Value = New Decimal(Convert.ToDouble(numQtyStrip.Value) * s)
            If (Convert.ToDouble(numQtyPack.Value) = 0) Then
                valid(6) = False
                numQtyPack.BackColor = Color.Pink
                Debug.WriteLine(String.Concat("numQtyPack: ", valid(6).ToString()))
            ElseIf (Convert.ToDouble(numQtyPack.Value) > 0) Then
                valid(6) = True
                numQtyPack.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            numQtyPack.Value = Decimal.Zero
            numQtyStrip.Value = Decimal.Zero
            numQtyPack.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numQtyPiece_KeyDown(sender As Object, e As KeyEventArgs) Handles numQtyPiece.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            txtInvoiceNo.Select()
        End If
    End Sub

    Private Sub numQtyPiece_ValueChanged(sender As Object, e As EventArgs) Handles numQtyPiece.ValueChanged
        Try
            numQtyStrip.Value = New Decimal(Convert.ToDouble(numQtyPiece.Value) / s)
            numQtyPack.Value = New Decimal(Convert.ToDouble(numQtyStrip.Value) / p)
            If (Decimal.Compare(numQtyPiece.Value, Decimal.Zero) = 0) Then
                valid(8) = False
                numQtyPiece.BackColor = Color.Pink
                Debug.WriteLine(String.Concat("numQtyPiece: ", valid(8).ToString()))
            ElseIf (Decimal.Compare(numQtyPiece.Value, Decimal.Zero) > 0) Then
                valid(8) = True
                numQtyPiece.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            numQtyPack.Value = Decimal.Zero
            numQtyStrip.Value = Decimal.Zero
            numQtyPack.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numQtyStrip_KeyDown(sender As Object, e As KeyEventArgs) Handles numQtyStrip.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numQtyPiece.Select()
            numQtyPiece.Select(0, numQtyPiece.Text.Length)
        End If
    End Sub

    Private Sub numQtyStrip_ValueChanged(sender As Object, e As EventArgs) Handles numQtyStrip.ValueChanged
        Try
            numQtyPiece.Value = New Decimal(Convert.ToDouble(numQtyStrip.Value) * s)
            numQtyPack.Value = New Decimal(Convert.ToDouble(numQtyStrip.Value) / p)
            If (Convert.ToDouble(numQtyStrip.Value) = 0) Then
                valid(7) = False
                numQtyStrip.BackColor = Color.Pink
                Debug.WriteLine(String.Concat("numQtyStrip: ", valid(7).ToString()))
            ElseIf (Convert.ToDouble(numQtyStrip.Value) > 0) Then
                valid(7) = True
                numQtyStrip.BackColor = Color.LightGreen
            End If
        Catch exception As System.Exception
            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            numQtyPack.Value = Decimal.Zero
            numQtyStrip.Value = Decimal.Zero
            numQtyPack.Value = Decimal.Zero
        End Try
    End Sub

    Private Sub numSGST_KeyDown(sender As Object, e As KeyEventArgs) Handles numSGST.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            btnAdd.Select()
        End If
    End Sub

    Private Sub PurchaseEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectData("select * from medicine", ds)
        selectData("select * from supplier", ds0)
        selectData("select * from cardtypes", ds1)
        cmbItemName.Items.Clear()
        If (ds.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = ds.Tables(0).Rows.Count - 1
            For num As Integer = 0 To count Step 1
                cmbItemName.Items.Add(ds.Tables(0).Rows(num)(1).ToString())
                p = Convert.ToDouble(Convert.ToDecimal(ds.Tables(0).Rows(num)(6).ToString()))
                s = Convert.ToDouble(Convert.ToDecimal(ds.Tables(0).Rows(num)(7).ToString()))
                hsn = ds.Tables(0).Rows(num)(10).ToString()
                gst = Convert.ToDouble(Convert.ToDecimal(ds.Tables(0).Rows(num)(11).ToString()))
            Next

        End If
        cmbSuppID.Items.Clear()
        cmbSuppName.Items.Clear()
        If (ds0.Tables(0).Rows.Count > 0) Then
            Dim count1 As Integer = ds0.Tables(0).Rows.Count - 1
            For i As Integer = 0 To count1 Step 1
                cmbSuppID.Items.Add(ds0.Tables(0).Rows(i)(0).ToString())
                cmbSuppName.Items.Add(ds0.Tables(0).Rows(i)(1).ToString())
                credit = Convert.ToDouble(Convert.ToDecimal(ds0.Tables(0).Rows(i)(12).ToString()))
            Next

        End If
        cmbCardType.DataSource = ds1.Tables(0)
        cmbCardType.DisplayMember = "type"
        radioInstruNA.Checked = True
        cmbSuppID.Select()
        Timer1.Interval = 300
        Timer1.Start()
    End Sub

    Private Sub radioInstruNA_CheckedChanged(sender As Object, e As EventArgs) Handles radioInstruNA.CheckedChanged
        If (radioInstruNA.Checked) Then
            numBank.Value = Decimal.Zero
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If (chkInterState.Checked) Then
                numCGST.Value = Decimal.Zero
                numSGST.Value = Decimal.Zero
                numCGST.Enabled = False
                numSGST.Enabled = False
                numIGST.Enabled = True
            Else
                numIGST.Value = Decimal.Zero
                numIGST.Enabled = False
                numCGST.Enabled = True
                numSGST.Enabled = True
            End If
            If (DataGridView1.SelectedCells(0).RowIndex >= 0) Then
                btnRemove.Enabled = True
            End If
        Catch argumentOutOfRangeException As System.ArgumentOutOfRangeException\
            btnRemove.Enabled = False
        End Try
        Dim i As Integer = 0
        Try
            Do
                If (Not valid(i)) Then
                    btnAdd.Enabled = False
                    Exit Do
                Else
                    btnAdd.Enabled = True
                    i = i + 1
                End If
            Loop While i <= 16
        Catch ex As Exception
            btnAdd.Enabled = False
        End Try
    End Sub

    Private Sub txtBatchCode_TextChanged(sender As Object, e As EventArgs) Handles txtBatchCode.TextChanged
        If (txtBatchCode.Text.Length = 0) Then
            valid(5) = False
            txtBatchCode.BackColor = Color.Pink
            Debug.WriteLine(String.Concat("txtBatchCode: ", valid(5).ToString()))
        ElseIf (txtBatchCode.Text.Length > 0) Then
            valid(5) = True
            txtBatchCode.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub txtBatchCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBatchCode.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            numQtyPack.Select()
            numQtyPack.Select(0, numQtyPack.Text.Length)
        End If
    End Sub

    Private Sub txtInvoiceNo_TextChanged(sender As Object, e As EventArgs) Handles txtInvoiceNo.TextChanged
        If (txtInvoiceNo.Text.Length = 0) Then
            valid(9) = False
            txtInvoiceNo.BackColor = Color.Pink
            Debug.WriteLine(String.Concat("txtInvoiceNo: ", valid(9).ToString()))
        ElseIf (txtInvoiceNo.Text.Length > 0) Then
            valid(9) = True
            txtInvoiceNo.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub txtInvoiceNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInvoiceNo.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            dateInvoiceDate.Select()
        End If
    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged
        If (ds.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = ds.Tables(0).Rows.Count - 1
            Dim num As Integer = 0
            While num <= count
                If (Operators.CompareString(txtItemCode.Text, ds.Tables(0).Rows(num)(0).ToString(), False) <> 0) Then
                    num = num + 1
                Else
                    cmbItemName.Text = ds.Tables(0).Rows(num)(1).ToString()
                    p = Convert.ToDouble(Convert.ToDecimal(ds.Tables(0).Rows(num)(6).ToString()))
                    s = Convert.ToDouble(Convert.ToDecimal(ds.Tables(0).Rows(num)(7).ToString()))
                    hsn = ds.Tables(0).Rows(num)(10).ToString()
                    gst = Convert.ToDouble(Convert.ToDecimal(ds.Tables(0).Rows(num)(11).ToString()))
                    If (Not chkInterState.Checked) Then
                        numCGST.Value = New Decimal(gst / 2)
                        numSGST.Value = New Decimal(gst / 2)
                    Else
                        numIGST.Value = New Decimal(gst)
                    End If
                    Exit While
                End If
            End While
        End If
        If (ds.Tables(0).Rows.Count > 0) Then
            Dim count1 As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count1
                If (Not Operators.ConditionalCompareObjectEqual(txtItemCode.Text, ds.Tables(0).Rows(i)(0), False)) Then
                    valid(4) = False
                    txtItemCode.BackColor = Color.Pink
                    i = i + 1
                Else
                    valid(4) = True
                    txtItemCode.BackColor = Color.LightGreen
                    Exit While
                End If
            End While
        End If
    End Sub

    Private Sub txtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemCode.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            txtBatchCode.Select()
        End If
    End Sub

    Private Sub txtSuppNo_TextChanged(sender As Object, e As EventArgs) Handles txtSuppNo.TextChanged
        Dim count As Integer = ds0.Tables(0).Rows.Count - 1
        Dim i As Integer = 0
        While i <= count
            If (Operators.CompareString(ds0.Tables(0).Rows(i)(7).ToString(), txtSuppNo.Text, False) <> 0) Then
                cmbSuppID.Text = ""
                cmbSuppName.Text = ""
                txtSuppEmail.Text = ""
                i = i + 1
            Else
                cmbSuppID.Text = ds0.Tables(0).Rows(i)(0).ToString()
                cmbSuppName.Text = ds0.Tables(0).Rows(i)(1).ToString()
                txtSuppEmail.Text = ds0.Tables(0).Rows(i)(8).ToString()
                credit = Convert.ToDouble(Convert.ToDecimal(ds0.Tables(0).Rows(i)(12).ToString()))
                numSuppCredit.Value = New Decimal(credit)
                Exit While
            End If
        End While
        If (txtSuppNo.Text.Length = 0 And Not Versioned.IsNumeric(txtSuppNo.Text)) Then
            valid(2) = False
            txtSuppNo.BackColor = Color.Pink
            Debug.WriteLine(String.Concat("txtSuppNo.: ", valid(2).ToString()))
        ElseIf (txtSuppNo.Text.Length > 0 And Versioned.IsNumeric(txtSuppNo.Text)) Then
            valid(2) = True
            txtSuppNo.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub txtSuppNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSuppNo.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            txtSuppEmail.Select()
        End If
    End Sub

    Private Sub txtSuppEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSuppEmail.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter) Then
            cmbItemName.Select()
        End If
    End Sub
End Class