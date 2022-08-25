Imports Microsoft.VisualBasic.CompilerServices
Imports OnusMed.My.Resources
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class StockTransfer

    Private inventory As DataSet

    Private items As DataSet

    Private list As Dictionary(Of String, String)

    Private stripc As Integer

    Private packc As Integer

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim code As String = ""
        If (cmbItem.Text.Length > 0) Then
            code = DirectCast(cmbItem.SelectedItem, KeyValuePair(Of String, String)).Key.ToString()
        End If
        selectData("Select i.batchcode 'Batch Code',i.code 'Item Code',(select m.name from medicine m where m.code=i.code) 'Item Name',stock_pack 'Available Packs',stock_strip 'Available Strips',stock_piece 'Available Pieces',location 'Location' from inventory i", inventory)
        DataGridView1.DataSource = inventory.Tables(0)
        Dim counts As DataSet = New DataSet()
        selectData(String.Concat("select code,packc,stripc from medicine where code='", code, "'"), counts)
        packc = Integer.Parse(Conversions.ToString(counts.Tables(0).Rows(0)(1)))
        stripc = Integer.Parse(Conversions.ToString(counts.Tables(0).Rows(0)(2)))
    End Sub

    Private Sub btnToGD_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim num As Decimal
        Dim tmp As DataSet = New DataSet()
        Dim tmp0 As DataSet = New DataSet()
        selectData(String.Concat("select * from inventory where batchcode='", DataGridView1.SelectedRows(0).Cells(0).Value.ToString(), "' and location='GD'"), tmp)
        If (tmp.Tables(0).Rows.Count = 0) Then
            selectData(String.Concat("select *,date_format(expiry,'%Y-%m-%d') from inventory where batchcode='", DataGridView1.SelectedRows(0).Cells(0).Value.ToString(), "' and location='STO'"), tmp0)
            Dim str() As String = {"insert into inventory values('", tmp0.Tables(0).Rows(0)(0).ToString(), "','", tmp0.Tables(0).Rows(0)(1).ToString(), "','", tmp0.Tables(0).Rows(0)(21).ToString(), "',", tmp0.Tables(0).Rows(0)(3).ToString(), ",", tmp0.Tables(0).Rows(0)(4).ToString(), ",", tmp0.Tables(0).Rows(0)(5).ToString(), ",", tmp0.Tables(0).Rows(0)(6).ToString(), ",", tmp0.Tables(0).Rows(0)(7).ToString(), ",", tmp0.Tables(0).Rows(0)(8).ToString(), ",", tmp0.Tables(0).Rows(0)(9).ToString(), ",", tmp0.Tables(0).Rows(0)(10).ToString(), ",", tmp0.Tables(0).Rows(0)(11).ToString(), ",", tmp0.Tables(0).Rows(0)(12).ToString(), ",", tmp0.Tables(0).Rows(0)(13).ToString(), ",", tmp0.Tables(0).Rows(0)(14).ToString(), ",", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
            num = Math.Round(numQtyPack.Value, 2)
            str(31) = num.ToString()
            str(32) = ","
            num = Math.Round(numQtyStrip.Value, 2)
            str(33) = num.ToString()
            str(34) = ","
            num = Math.Round(numQtyPiece.Value, 2)
            str(35) = num.ToString()
            str(36) = ",'GD',false,"
            str(37) = tmp0.Tables(0).Rows(0)(20).ToString()
            str(38) = ");commit;"
            Dim query As String = String.Concat(str)
            Dim text() As String = {"update inventory set stock_pack=stock_pack-(", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
            num = Math.Round(numQtyPack.Value, 2)
            text(1) = num.ToString()
            text(2) = "), stock_strip=stock_strip-("
            num = Math.Round(numQtyStrip.Value, 2)
            text(3) = num.ToString()
            text(4) = "),stock_piece=stock_piece-("
            num = Math.Round(numQtyPiece.Value, 2)
            text(5) = num.ToString()
            text(6) = ") where batchcode='"
            text(7) = txtBatchCode.Text
            text(8) = "' and location='STO';commit;"
            Dim update As String = String.Concat(text)
            manipulateData(query)
            manipulateData(update)
        ElseIf (tmp.Tables(0).Rows.Count > 0) Then
            Dim strArrays(16) As String
            strArrays(0) = "update inventory set stock_pack=stock_pack+("
            num = Math.Round(numQtyPack.Value, 2)
            strArrays(1) = num.ToString()
            strArrays(2) = "), stock_strip=stock_strip+("
            num = Math.Round(numQtyPiece.Value, 2)
            strArrays(3) = num.ToString()
            strArrays(4) = "),stock_piece=stock_piece+("
            num = Math.Round(numQtyPiece.Value, 2)
            strArrays(5) = num.ToString()
            strArrays(6) = ") where batchcode='"
            strArrays(7) = txtBatchCode.Text
            strArrays(8) = "' and location='GD';update inventory set stock_pack=stock_pack-("
            num = Math.Round(numQtyPack.Value, 2)
            strArrays(9) = num.ToString()
            strArrays(10) = "), stock_strip=stock_strip-("
            num = Math.Round(numQtyStrip.Value, 2)
            strArrays(11) = num.ToString()
            strArrays(12) = "),stock_piece=stock_piece-("
            num = Math.Round(numQtyPiece.Value, 2)
            strArrays(13) = num.ToString()
            strArrays(14) = ") where batchcode='"
            strArrays(15) = txtBatchCode.Text
            strArrays(16) = "' and location='STO';commit;"
            manipulateData(String.Concat(strArrays))
        End If
        Dim code As String = ""
        If (cmbItem.Text.Length > 0) Then
            code = DirectCast(cmbItem.SelectedItem, KeyValuePair(Of String, String)).Key.ToString()
        End If
        selectData("Select i.batchcode 'Batch Code',i.code 'Item Code',(select m.name from medicine m where m.code=i.code) 'Item Name',stock_pack 'Available Packs',stock_strip 'Available Strips',stock_piece 'Available Pieces',location 'Location' from inventory i", inventory)
        DataGridView1.DataSource = inventory.Tables(0)
        Dim counts As DataSet = New DataSet()
        selectData(String.Concat("select code,packc,stripc from medicine where code='", code, "'"), counts)
        packc = Integer.Parse(Conversions.ToString(counts.Tables(0).Rows(0)(1)))
        stripc = Integer.Parse(Conversions.ToString(counts.Tables(0).Rows(0)(2)))
        numQtyPack.Value = Decimal.Zero
        numQtyStrip.Value = Decimal.Zero
        numQtyPiece.Value = Decimal.Zero
    End Sub

    Private Sub btnToSTO_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim num As Decimal
        Dim tmp As DataSet = New DataSet()
        Dim tmp0 As DataSet = New DataSet()
        selectData(String.Concat("select * from inventory where batchcode='", DataGridView1.SelectedRows(0).Cells(0).Value.ToString(), "' and location='STO'"), tmp)
        If (tmp.Tables(0).Rows.Count = 0) Then
            selectData(String.Concat("select *,date_format(expiry,'%Y-%m-%d') from inventory where batchcode='", DataGridView1.SelectedRows(0).Cells(0).Value.ToString(), "' and location='GD'"), tmp0)
            Dim str() As String = {"insert into inventory values('", tmp0.Tables(0).Rows(0)(0).ToString(), "','", tmp0.Tables(0).Rows(0)(1).ToString(), "','", tmp0.Tables(0).Rows(0)(21).ToString(), "',", tmp0.Tables(0).Rows(0)(3).ToString(), ",", tmp0.Tables(0).Rows(0)(4).ToString(), ",", tmp0.Tables(0).Rows(0)(5).ToString(), ",", tmp0.Tables(0).Rows(0)(6).ToString(), ",", tmp0.Tables(0).Rows(0)(7).ToString(), ",", tmp0.Tables(0).Rows(0)(8).ToString(), ",", tmp0.Tables(0).Rows(0)(9).ToString(), ",", tmp0.Tables(0).Rows(0)(10).ToString(), ",", tmp0.Tables(0).Rows(0)(11).ToString(), ",", tmp0.Tables(0).Rows(0)(12).ToString(), ",", tmp0.Tables(0).Rows(0)(13).ToString(), ",", tmp0.Tables(0).Rows(0)(14).ToString(), ",", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
            num = Math.Round(numQtyPack.Value, 2)
            str(31) = num.ToString()
            str(32) = ","
            num = Math.Round(numQtyStrip.Value, 2)
            str(33) = num.ToString()
            str(34) = ","
            num = Math.Round(numQtyPiece.Value, 2)
            str(35) = num.ToString()
            str(36) = ",'STO',false,"
            str(37) = tmp0.Tables(0).Rows(0)(20).ToString()
            str(38) = ");commit;"
            Dim query As String = String.Concat(str)
            Dim text() As String = {"update inventory set stock_pack=stock_pack-(", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing}
            num = Math.Round(numQtyPack.Value, 2)
            text(1) = num.ToString()
            text(2) = "), stock_strip=stock_strip-("
            num = Math.Round(numQtyStrip.Value, 2)
            text(3) = num.ToString()
            text(4) = "),stock_piece=stock_piece-("
            num = Math.Round(numQtyPiece.Value, 2)
            text(5) = num.ToString()
            text(6) = ") where batchcode='"
            text(7) = txtBatchCode.Text
            text(8) = "' and location='GD';commit;"
            Dim update As String = String.Concat(text)
            manipulateData(query)
            manipulateData(update)
        ElseIf (tmp.Tables(0).Rows.Count > 0) Then
            Dim strArrays(16) As String
            strArrays(0) = "update inventory set stock_pack=stock_pack+("
            num = Math.Round(numQtyPack.Value, 2)
            strArrays(1) = num.ToString()
            strArrays(2) = "), stock_strip=stock_strip+("
            num = Math.Round(numQtyPiece.Value, 2)
            strArrays(3) = num.ToString()
            strArrays(4) = "),stock_piece=stock_piece+("
            num = Math.Round(numQtyPiece.Value, 2)
            strArrays(5) = num.ToString()
            strArrays(6) = ") where batchcode='"
            strArrays(7) = txtBatchCode.Text
            strArrays(8) = "' and location='STO';update inventory set stock_pack=stock_pack-("
            num = Math.Round(numQtyPack.Value, 2)
            strArrays(9) = num.ToString()
            strArrays(10) = "), stock_strip=stock_strip-("
            num = Math.Round(numQtyStrip.Value, 2)
            strArrays(11) = num.ToString()
            strArrays(12) = "),stock_piece=stock_piece-("
            num = Math.Round(numQtyPiece.Value, 2)
            strArrays(13) = num.ToString()
            strArrays(14) = ") where batchcode='"
            strArrays(15) = txtBatchCode.Text
            strArrays(16) = "' and location='GD';commit;"
            manipulateData(String.Concat(strArrays))
        End If
        Dim code As String = ""
        If (cmbItem.Text.Length > 0) Then
            code = DirectCast(cmbItem.SelectedItem, KeyValuePair(Of String, String)).Key.ToString()
        End If
        selectData("Select i.batchcode 'Batch Code',i.code 'Item Code',(select m.name from medicine m where m.code=i.code) 'Item Name',stock_pack 'Available Packs',stock_strip 'Available Strips',stock_piece 'Available Pieces',location 'Location' from inventory i", inventory)
        DataGridView1.DataSource = inventory.Tables(0)
        Dim counts As DataSet = New DataSet()
        selectData(String.Concat("select code,packc,stripc from medicine where code='", code, "'"), counts)
        packc = Integer.Parse(Conversions.ToString(counts.Tables(0).Rows(0)(1)))
        stripc = Integer.Parse(Conversions.ToString(counts.Tables(0).Rows(0)(2)))
        numQtyPack.Value = Decimal.Zero
        numQtyStrip.Value = Decimal.Zero
        numQtyPiece.Value = Decimal.Zero
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtItemCode.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        txtItemName.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        txtBatchCode.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        numQtyPack.Value = Decimal.Zero
        numQtyStrip.Value = Decimal.Zero
        numQtyPiece.Value = Decimal.Zero
        numQtyPack.Maximum = Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.SelectedRows(0).Cells(3).Value)), 2)
        numQtyStrip.Maximum = Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.SelectedRows(0).Cells(4).Value)), 2)
        numQtyPiece.Maximum = Math.Round(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(DataGridView1.SelectedRows(0).Cells(5).Value)), 2)
    End Sub

    Private Sub numQtyPack_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            numQtyStrip.Value = Decimal.Multiply(numQtyPack.Value, New Decimal(packc))
            numQtyPiece.Value = Decimal.Multiply(Decimal.Multiply(numQtyPack.Value, New Decimal(packc)), New Decimal(stripc))
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub NumQtyPiece_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            numQtyPack.Value = Decimal.Divide(Decimal.Divide(numQtyPiece.Value, New Decimal(stripc)), New Decimal(packc))
            numQtyStrip.Value = Decimal.Divide(numQtyPiece.Value, New Decimal(stripc))
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub numQtyStrip_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            numQtyPack.Value = Decimal.Divide(numQtyStrip.Value, New Decimal(packc))
            numQtyPiece.Value = Decimal.Multiply(numQtyStrip.Value, New Decimal(stripc))
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub StockTransfer_Load(ByVal sender As Object, ByVal e As EventArgs)
        selectData("select i.code,(select m0.name from medicine m0 where m0.code=i.code) from inventory i", items)
        If (items.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = items.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            Do
                If (Not list.ContainsKey(items.Tables(0).Rows(i)(0).ToString())) Then
                    list.Add(items.Tables(0).Rows(i)(0).ToString(), items.Tables(0).Rows(i)(1).ToString())
                End If
                i = i + 1
            Loop While i <= count
            cmbItem.DataSource = New BindingSource(list, Nothing)
            cmbItem.DisplayMember = "Value"
            cmbItem.ValueMember = "Key"
        End If
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim location As String = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
            If (Operators.CompareString(location, "GD", False) = 0) Then
                btnToSTO.Enabled = True
                btnToGD.Enabled = False
            ElseIf (Operators.CompareString(location, "STO", False) <> 0) Then
                btnToSTO.Enabled = False
                btnToGD.Enabled = False
            Else
                btnToSTO.Enabled = False
                btnToGD.Enabled = True
            End If
        Catch exception As System.Exception

        End Try
    End Sub
End Class