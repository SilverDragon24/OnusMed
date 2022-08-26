Imports Microsoft.VisualBasic.CompilerServices
Imports OnusMed.My
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class SearchItem
    Private comps1 As DataSet

    Private comps2 As DataSet

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        If (cmbComp.Text.Length > 0) Then
            Dim search As DataSet = New DataSet()
            selectData(String.Concat(New String() {"select code 'Code',name 'Name',manufacturer 'Manufacturer',sched 'Schedule',comp1 'Composition 1',comp2 'Composition 2' from med_test.medicine where comp1='", cmbComp.Text, "' or comp2='", cmbComp.Text, "';"}), search)
            Try
                DataGridView1.DataSource = search.Tables(0)
            Catch exception As System.Exception

            End Try
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelect.Click
        SaleEntry.cmbItemCode.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Me.Dispose()
    End Sub

    Private Sub SearchItem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
        selectData("select distinct comp1 from med_test.medicine", comps1)
        selectData("select distinct comp2 from med_test.medicine", comps2)
        Try
            Dim count As Integer = comps1.Tables(0).Rows.Count - 1
            Dim num As Integer = 0
            Do
                cmbComp.Items.Add(comps1.Tables(0).Rows(num)(0).ToString())
                num = num + 1
            Loop While num <= count
            Dim count1 As Integer = comps2.Tables(0).Rows.Count - 1
            For i As Integer = 0 To count1 Step 1
                If (Not cmbComp.Items.Contains(comps2.Tables(0).Rows(i)(0).ToString())) Then
                    cmbComp.Items.Add(comps2.Tables(0).Rows(i)(0).ToString())
                End If
            Next

        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Try
            If (DataGridView1.SelectedRows(0).Cells(0).Value.ToString().Length <= 0) Then
                btnSelect.Enabled = False
            Else
                btnSelect.Enabled = True
            End If
        Catch exception As System.Exception
            btnSelect.Enabled = False
        End Try
    End Sub
End Class