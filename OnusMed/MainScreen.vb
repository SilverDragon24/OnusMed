Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports OnusMed.My
Imports OnusMed.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class MainScreen
    Private Sub btnPayCredit_Click(sender As Object, e As EventArgs) Handles btnPayCredit.Click
        CreditPayment.ShowDialog()
    End Sub

    Private Sub btnGSTR3B_Click(sender As Object, e As EventArgs) Handles btnGSTR3B.Click
        GSTR3BReport.Show()
    End Sub

    Private Sub btnGSTReport_Click(sender As Object, e As EventArgs) Handles btnGSTReport.Click
        GSTReport.ShowDialog()
    End Sub

    Private Sub btnH1Filter_Click(sender As Object, e As EventArgs) Handles btnH1Filter.Click
        SchedFilter.Show()
    End Sub

    Private Sub btnCreditReport_Click(sender As Object, e As EventArgs) Handles btnCreditReport.Click
        CreditReport.Show()
    End Sub

    Private Sub btnPret_Click(sender As Object, e As EventArgs) Handles btnPret.Click
        pret = True
        While pret
            PurchaseReturn.ShowDialog()
        End While
    End Sub

    Private Sub btnPretReport_Click(sender As Object, e As EventArgs) Handles btnPretReport.Click
        PurchaseReturnReport.Show()
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        purchasing = True
        While purchasing
            PurchaseEntry.ShowDialog()
        End While
    End Sub

    Private Sub btnPurchaseOrder_Click(sender As Object, e As EventArgs) Handles btnPurchaseOrder.Click
        MsgBox("feature in Development")
    End Sub

    Private Sub btnPurchaseReport_Click(sender As Object, e As EventArgs) Handles btnPurchaseReport.Click
        PurchaseReport.Show()
    End Sub

    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        selling = True
        While selling
            SaleEntry.ShowDialog()
        End While
    End Sub

    Private Sub btnSchedPurchase_Click(sender As Object, e As EventArgs) Handles btnSchedPurchase.Click
        SchedPurFilter.ShowDialog()
    End Sub

    Private Sub btnSret_Click(sender As Object, e As EventArgs) Handles btnSret.Click
        sret = True
        While sret
            SaleReturn.ShowDialog()
        End While
    End Sub

    Private Sub btnStockReport_Click(sender As Object, e As EventArgs) Handles btnStockReport.Click
        StockReport.Show()
    End Sub

    Private Sub btnStockTransfer_Click(sender As Object, e As EventArgs) Handles btnStockTransfer.Click
        StockTransfer.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Appointment.Show()
    End Sub

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 600000
        Timer1.Start()
    End Sub

    Private Sub MainScreen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CloseDB()
        Application.Exit()
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        SalesReport.Show()
    End Sub

    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click
        InvSearch.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            rtbNews.Text = ""
            Dim inv As DataSet = New DataSet
            selectData("select code,batchcode,date_format(expiry,'%Y-%m-%d'),stock_piece from inventory;", inv)
            For i As Integer = 0 To inv.Tables(0).Rows.Count - 1 Step 1
                Dim itm As DataSet = New DataSet
                selectData("select code,minstock from medicine where code='" + inv.Tables(0).Rows(i).Item(0).ToString + "'", itm)
                Dim stck As Integer = 0
                stck = Integer.Parse(inv.Tables(0).Rows(i).Item(3).ToString)
                Dim mstck As Integer = 0
                mstck = Integer.Parse(itm.Tables(0).Rows(0).Item(1).ToString)
                If (stck <= mstck Or stck = 0) Then
                    Dim name As DataSet = New DataSet
                    selectData("select name from medicine where code='" + itm.Tables(0).Rows(0).Item(0).ToString + "';", name)
                    Dim str As String = name.Tables(0).Rows(0).Item(0).ToString
                    Dim bat As String = inv.Tables(0).Rows(i).Item(1).ToString
                    If (stck = mstck) Then
                        rtbNews.AppendText("Stock of " + str + " with Batch Code " + bat + " is Low" + Environment.NewLine)
                    ElseIf (stck < mstck) Then
                        rtbNews.AppendText("Stock of " + str + " with Batch Code " + bat + " is Critically Low" + Environment.NewLine)
                    ElseIf (stck = 0) Then
                    Else
                    End If
                End If
            Next
            For i As Integer = 0 To inv.Tables(0).Rows.Count - 1 Step 1
                Dim itm As DataSet = New DataSet
                Dim exp As String = inv.Tables(0).Rows(i).Item(2).ToString
                Dim stck As Integer = inv.Tables(0).Rows(i).Item(3).ToString
                If stck > 0 Then
                    selectData("select datediff('" + exp + "',curdate());", itm)
                    Dim dif As Integer = Integer.Parse(itm.Tables(0).Rows(0).Item(0).ToString)
                    If dif <= 30 Then
                        Dim name As DataSet = New DataSet
                        selectData("select name from medicine where code='" + inv.Tables(0).Rows(i).Item(0).ToString + "'", name)
                        Dim bat As String = inv.Tables(0).Rows(i).Item(1).ToString
                        Dim nam As String = name.Tables(0).Rows(0).Item(0).ToString
                        rtbNews.AppendText("Stock of " + nam + " with Batch Code " + bat + " will expire in " + dif.ToString + " days." + Environment.NewLine)
                    End If
                End If
            Next
        Catch ex As Exception
            rtbNews.Text = ""
            rtbNews.Text = ex.ToString + Environment.NewLine
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Timer1_Tick(sender, e)
    End Sub
End Class