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
End Class