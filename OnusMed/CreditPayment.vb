Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class CreditPayment
    Private Sub btnGetPatCredit_Click(sender As Object, e As EventArgs) Handles btnGetPatCredit.Click
        If (Me.cmbPatID.Text.Length > 0) Then
            Dim credit As DataSet = New DataSet()
            selectData(String.Concat("select credit from patient where id='", cmbPatID.Text, "'"), credit)
            Try
                Me.numPatCredit.Value = Math.Round(Convert.ToDecimal(credit.Tables(0).Rows(0)(0).ToString()), 2)
            Catch exception As System.Exception
                Me.numPatCredit.Value = Decimal.Zero
            End Try
        End If
    End Sub

    Private Sub btnGetSuppCredit_Click(sender As Object, e As EventArgs) Handles btnGetSuppCredit.Click
        If (Me.cmbSuppID.Text.Length > 0) Then
            Dim credit As DataSet = New DataSet()
            selectData(String.Concat("select credit from supplier where id='", cmbSuppID.Text, "'"), credit)
            Try
                numSuppCredit.Value = Math.Round(Convert.ToDecimal(credit.Tables(0).Rows(0)(0).ToString()), 2)
            Catch exception As System.Exception
                Me.numSuppCredit.Value = Decimal.Zero
            End Try
        End If
    End Sub

    Private Sub btnPatPay_Click(sender As Object, e As EventArgs) Handles btnPatPay.Click
        Dim instrutype As String = ""
        Dim paid As Double = Convert.ToDouble(Math.Round(Decimal.Add(Decimal.Add(Decimal.Add(numPatCash.Value, numPatBank.Value), numPatCard.Value), numPatWallet.Value), 2))
        If (radioPatNA.Checked) Then
            instrutype = "N/A"
        ElseIf (radioPatCHQ.Checked) Then
            instrutype = "CHQ"
        ElseIf (radioPatDD.Checked) Then
            instrutype = "DD"
        End If
        Dim str(20) As String
        str(0) = "insert into pcr_payments values(curdate(),"
        Dim value As Decimal = numPatCash.Value
        str(1) = value.ToString()
        str(2) = ","
        value = numPatBank.Value
        str(3) = value.ToString()
        str(4) = ",'"
        str(5) = instrutype
        str(6) = "','"
        str(7) = txtPatInstru.Text
        str(8) = "',"
        value = numPatCard.Value
        str(9) = value.ToString()
        str(10) = ",'"
        str(11) = cmbPatCardType.Text
        str(12) = "',"
        value = numPatWallet.Value
        str(13) = value.ToString()
        str(14) = ",'"
        str(15) = txtPatWalletRem.Text
        str(16) = "');update patient set credit=credit-("
        str(17) = paid.ToString()
        str(18) = ") where id='"
        str(19) = cmbPatID.Text
        str(20) = "';commit;"
        manipulateData(String.Concat(str))
        Me.Dispose()
    End Sub

    Private Sub btnSuppPay_Click(sender As Object, e As EventArgs) Handles btnSuppPay.Click
        Dim instrutype As String = ""
        Dim paid As Double = Convert.ToDouble(Math.Round(Decimal.Add(Decimal.Add(numSuppCash.Value, numSuppBank.Value), numSuppCard.Value), 2))
        If (radioSuppNA.Checked) Then
            instrutype = "N/A"
        ElseIf (radioSuppCHQ.Checked) Then
            instrutype = "CHQ"
        ElseIf (radioSuppDD.Checked) Then
            instrutype = "DD"
        End If
        Dim str(16) As String
        str(0) = "insert into scr_payments values(curdate(),"
        Dim value As Decimal = numSuppCash.Value
        str(1) = value.ToString()
        str(2) = ","
        value = numSuppBank.Value
        str(3) = value.ToString()
        str(4) = ",'"
        str(5) = instrutype
        str(6) = "','"
        str(7) = txtSuppInstru.Text
        str(8) = "',"
        value = numSuppCard.Value
        str(9) = value.ToString()
        str(10) = ",'"
        str(11) = cmbSuppCardType.Text
        str(12) = "');update supplier set credit=credit-("
        str(13) = paid.ToString()
        str(14) = ") where id='"
        str(15) = cmbSuppID.Text
        str(16) = "';commit;"
        manipulateData(String.Concat(str))
        Me.Dispose()
    End Sub

    Private Sub CreditPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim patients As DataSet = New DataSet()
        Dim suppliers As DataSet = New DataSet()
        Dim card As DataSet = New DataSet()
        selectData("select id from patient where truncate(credit,2)>0;", patients)
        selectData("select id from supplier where truncate(credit,2)>0;", suppliers)
        selectData("select * from cardtypes", card)
        Try
            Dim count As Integer = patients.Tables(0).Rows.Count - 1
            For num As Integer = 0 To count Step 1
                If (Not cmbPatID.Items.Contains(patients.Tables(0).Rows(num)(0).ToString())) Then
                    cmbPatID.Items.Add(patients.Tables(0).Rows(num)(0).ToString())
                End If
            Next

        Catch exception As System.Exception

        End Try
        Try
            Dim count1 As Integer = suppliers.Tables(0).Rows.Count - 1
            For j As Integer = 0 To count1 Step 1
                If (Not cmbSuppID.Items.Contains(suppliers.Tables(0).Rows(j)(0).ToString())) Then
                    cmbSuppID.Items.Add(suppliers.Tables(0).Rows(j)(0).ToString())
                End If
            Next

        Catch exception1 As System.Exception

        End Try
        Try
            Dim num1 As Integer = card.Tables(0).Rows.Count - 1
            For i As Integer = 0 To num1 Step 1
                If (Not cmbPatCardType.Items.Contains(card.Tables(0).Rows(i)(0).ToString())) Then
                    cmbPatCardType.Items.Add(card.Tables(0).Rows(i)(0).ToString())
                End If
                If (Not cmbSuppCardType.Items.Contains(card.Tables(0).Rows(i)(0).ToString())) Then
                    cmbSuppCardType.Items.Add(card.Tables(0).Rows(i)(0).ToString())
                End If
            Next

        Catch exception2 As System.Exception

        End Try
        Timer1.Interval = 50
        Timer1.Start()
        radioPatNA.Checked = True
        radioSuppNA.Checked = True
        cmbPatCardType.SelectedIndex = 0
        cmbSuppCardType.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Decimal.Compare(numPatCredit.Value, Decimal.Zero) > 0) Then
            btnPatPay.Enabled = True
        Else
            btnPatPay.Enabled = False
        End If
        If (Decimal.Compare(numSuppCredit.Value, Decimal.Zero) > 0) Then
            btnSuppPay.Enabled = True
        Else
            btnSuppPay.Enabled = False
        End If
        If (radioPatNA.Checked And Decimal.Compare(Math.Round(numPatBank.Value, 2), Decimal.Zero) > 0) Then
            btnPatPay.Enabled = False
        ElseIf (Not ((radioPatCHQ.Checked Or radioPatDD.Checked) And (Decimal.Compare(numPatBank.Value, Decimal.Zero) = 0 Or txtPatInstru.Text.Length = 0))) Then
            btnPatPay.Enabled = True
        Else
            btnPatPay.Enabled = False
        End If
        If (CShort((-radioSuppNA.Checked)) = 1 And Decimal.Compare(Math.Round(numSuppBank.Value, 2), Decimal.Zero) > 0) Then
            btnSuppPay.Enabled = False
        ElseIf (Not ((radioSuppCHQ.Checked Or radioSuppDD.Checked) And (Decimal.Compare(numSuppBank.Value, Decimal.Zero) = 0 Or txtSuppInstru.Text.Length = 0))) Then
            btnSuppPay.Enabled = True
        Else
            btnSuppPay.Enabled = False
        End If
    End Sub
End Class