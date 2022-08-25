Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class NewItem
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim code As String = txtCode.Text
        Dim name As String = txtName.Text
        Dim mfg As String = txtMfg.Text
        Dim type As String = cmbType.Text
        Dim sched As String = cmbSched.Text
        Dim minstock As String = txtMinStock.Text
        Dim stripsPerPack As String = txtStripsPerPack.Text
        Dim piecesPerStrip As String = txtPiecesPerStrip.Text
        Dim comp1 As String = cmbComp1.Text
        Dim comp2 As String = cmbComp2.Text
        Dim hsn As String = txtHSN.Text
        If (validTxt(txtCode, code) = 1 And validTxt(txtName, name) = 1 And validTxt(txtMfg, mfg) = 1 And validCmb(cmbType, type) = 1 And validCmb(cmbSched, sched) = 1 And validTxt(txtMinStock, minstock) = 1 And txtNumChk(txtMinStock, minstock) = 1 And validTxt(txtStripsPerPack, stripsPerPack) = 1 And txtNumChk(txtStripsPerPack, stripsPerPack) = 1 And validTxt(txtPiecesPerStrip, piecesPerStrip) = 1 And txtNumChk(txtPiecesPerStrip, piecesPerStrip) = 1 And validCmb(cmbComp1, comp1) = 1 And validCmb(cmbComp2, comp2) = 1 And validTxt(txtHSN, hsn) = 1) Then
            Dim str() As String = {"insert into medicine values('", code, "','", name, "','", mfg, "','", type, "','", sched, "',", minstock, ",", stripsPerPack, ",", piecesPerStrip, ",'", comp1, "','", comp2, "','", hsn, "',", Nothing, Nothing}
            Dim num As Decimal = Math.Round(numGST.Value)
            str(23) = num.ToString()
            str(24) = ");commit;"
            If (manipulateData(String.Concat(str)) = 1) Then
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub NewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = New DataSet()
        If (ConnectDB(db) <> 1) Then
            MsgBox("Connection Failed", MsgBoxStyle.OkOnly, Nothing)
            Application.Exit()
        Else
            selectData("select * from medtypes", ds)
            cmbType.Items.Clear()
            If (ds.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = ds.Tables(0).Rows.Count - 1
                For num As Integer = 0 To count Step 1
                    cmbType.Items.Add(ds.Tables(0).Rows(num)(0).ToString())
                Next

            End If
            selectData("select * from schedule", ds)
            cmbSched.Items.Clear()
            If (ds.Tables(0).Rows.Count > 0) Then
                Dim count1 As Integer = ds.Tables(0).Rows.Count - 1
                For j As Integer = 0 To count1 Step 1
                    cmbSched.Items.Add(ds.Tables(0).Rows(j)(0).ToString())
                Next

            End If
            selectData("select distinct comp1 from medicine", ds)
            cmbComp1.Items.Clear()
            If (ds.Tables(0).Rows.Count > 0) Then
                Dim num1 As Integer = ds.Tables(0).Rows.Count - 1
                For k As Integer = 0 To num1 Step 1
                    cmbComp1.Items.Add(ds.Tables(0).Rows(k)(0).ToString())
                Next

            End If
            selectData("select distinct comp2 from medicine", ds)
            cmbComp2.Items.Clear()
            If (ds.Tables(0).Rows.Count > 0) Then
                Dim count2 As Integer = ds.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count2 Step 1
                    cmbComp2.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next

            End If
        End If
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        Dim ds As DataSet = New DataSet()
        selectData(String.Concat("select * from medicine where code='", txtCode.Text, "';"), ds)
        If (ds.Tables(0).Rows.Count > 0) Then
            btnAdd.Enabled = False
        ElseIf (ds.Tables(0).Rows.Count = 0) Then
            btnAdd.Enabled = True
        End If
    End Sub
End Class