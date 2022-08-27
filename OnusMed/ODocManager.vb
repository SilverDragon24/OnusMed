Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class ODocManager
    Private docs As DataSet = New DataSet

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim days As String = ""
        If (chkMon.Checked) Then
            days = String.Concat(days, "(Mon)")
        End If
        If (chkTue.Checked) Then
            days = String.Concat(days, "(Tue)")
        End If
        If (chkWed.Checked) Then
            days = String.Concat(days, "(Wed)")
        End If
        If (chkThu.Checked) Then
            days = String.Concat(days, "(Thu)")
        End If
        If (chkFri.Checked) Then
            days = String.Concat(days, "(Fri)")
        End If
        If (chkSat.Checked) Then
            days = String.Concat(days, "(Sat)")
        End If
        If (chkSun.Checked) Then
            days = String.Concat(days, "(Sun)")
        End If
        Dim text() As String = {"insert into odoctor values('", txtRegNo.Text, "','", txtName.Text, "','", txtAddr1.Text, "','", txtAddr2.Text, "','", cmbCity.Text, "','", cmbState.Text, "',", txtPin.Text, ",'", txtContact.Text, "','", txtEmail.Text, "',", txtCharges.Text, ",", Nothing, Nothing, Nothing, Nothing}
        Dim num As Decimal = Math.Round(numComm.Value, 2)
        text(21) = num.ToString()
        text(22) = ",'"
        text(23) = days
        text(24) = "');commit;"
        manipulateData(String.Concat(text))
        selectData("select * from odoctor;", docs)
        Try
            DataGridView1.DataSource = docs.Tables(0)
        Catch exception As System.Exception

        End Try
        txtRegNo.Text = ""
        txtName.Text = ""
        txtAddr1.Text = ""
        txtAddr2.Text = ""
        cmbCity.Text = ""
        cmbState.Text = ""
        txtPin.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        txtCharges.Text = ""
        numComm.Value = Decimal.Zero
        days = ""
        chkMon.Checked = False
        chkTue.Checked = False
        chkWed.Checked = False
        chkThu.Checked = False
        chkFri.Checked = False
        chkSat.Checked = False
        chkSun.Checked = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (txtRegNo.Text.Length > 0) Then
            Dim query As String = ""
            query = String.Concat("delete from odoctor where reg='", txtRegNo.Text, "';commit;")
            manipulateData(query)
        End If
        selectData("select * from odoctor;", docs)
        Try
            DataGridView1.DataSource = docs.Tables(0)
        Catch exception As System.Exception

        End Try
        txtRegNo.Text = ""
        txtName.Text = ""
        txtAddr1.Text = ""
        txtAddr2.Text = ""
        cmbCity.Text = ""
        cmbState.Text = ""
        txtPin.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        txtCharges.Text = ""
        numComm.Value = Decimal.Zero
        chkMon.Checked = False
        chkTue.Checked = False
        chkWed.Checked = False
        chkThu.Checked = False
        chkFri.Checked = False
        chkSat.Checked = False
        chkSun.Checked = False
        txtRegNo.ReadOnly = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim days As String = ""
        If (chkMon.Checked) Then
            days = String.Concat(days, "(Mon)")
        End If
        If (chkTue.Checked) Then
            days = String.Concat(days, "(Tue)")
        End If
        If (chkWed.Checked) Then
            days = String.Concat(days, "(Wed)")
        End If
        If (chkThu.Checked) Then
            days = String.Concat(days, "(Thu)")
        End If
        If (chkFri.Checked) Then
            days = String.Concat(days, "(Fri)")
        End If
        If (chkSat.Checked) Then
            days = String.Concat(days, "(Sat)")
        End If
        If (chkSun.Checked) Then
            days = String.Concat(days, "(Sun)")
        End If
        Dim text() As String = {"delete from odoctor where reg='", txtRegNo.Text, "';insert into odoctor values('", txtRegNo.Text, "','", txtName.Text, "','", txtAddr1.Text, "','", txtAddr2.Text, "','", cmbCity.Text, "','", cmbState.Text, "',", txtPin.Text, ",'", txtContact.Text, "','", txtEmail.Text, "',", txtCharges.Text, ",", Nothing, Nothing, Nothing, Nothing}
        Dim num As Decimal = Math.Round(numComm.Value, 2)
        text(23) = num.ToString()
        text(24) = ",'"
        text(25) = days
        text(26) = "');commit;"
        manipulateData(String.Concat(text))
        selectData("select * from odoctor;", docs)
        Try
            DataGridView1.DataSource = docs.Tables(0)
        Catch exception As System.Exception

        End Try
        txtRegNo.Text = ""
        txtName.Text = ""
        txtAddr1.Text = ""
        txtAddr2.Text = ""
        cmbCity.Text = ""
        cmbState.Text = ""
        txtPin.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        txtCharges.Text = ""
        numComm.Value = Decimal.Zero
        days = ""
        chkMon.Checked = False
        chkTue.Checked = False
        chkWed.Checked = False
        chkThu.Checked = False
        chkFri.Checked = False
        chkSat.Checked = False
        chkSun.Checked = False
        txtRegNo.ReadOnly = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If (DataGridView1.Rows.Count > 0) Then
                txtRegNo.[ReadOnly] = True
                txtRegNo.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
                txtName.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
                txtAddr1.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
                txtAddr2.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
                cmbCity.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
                cmbState.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
                txtPin.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
                txtContact.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString()
                txtEmail.Text = DataGridView1.SelectedRows(0).Cells(8).Value.ToString()
                txtCharges.Text = DataGridView1.SelectedRows(0).Cells(9).Value.ToString()
                numComm.Value = Convert.ToDecimal(DataGridView1.SelectedRows(0).Cells(10).Value.ToString())
                chkMon.Checked = False
                chkTue.Checked = False
                chkWed.Checked = False
                chkThu.Checked = False
                chkFri.Checked = False
                chkSat.Checked = False
                chkSun.Checked = False
                If (DataGridView1.SelectedRows(0).Cells(11).Value.ToString().Contains("Mon")) Then
                    chkMon.Checked = True
                End If
                If (DataGridView1.SelectedRows(0).Cells(11).Value.ToString().Contains("Tue")) Then
                    chkTue.Checked = True
                End If
                If (DataGridView1.SelectedRows(0).Cells(11).Value.ToString().Contains("Wed")) Then
                    chkWed.Checked = True
                End If
                If (DataGridView1.SelectedRows(0).Cells(11).Value.ToString().Contains("Thu")) Then
                    chkThu.Checked = True
                End If
                If (DataGridView1.SelectedRows(0).Cells(11).Value.ToString().Contains("Fri")) Then
                    chkFri.Checked = True
                End If
                If (DataGridView1.SelectedRows(0).Cells(11).Value.ToString().Contains("Sat")) Then
                    chkSat.Checked = True
                End If
                If (DataGridView1.SelectedRows(0).Cells(11).Value.ToString().Contains("Sun")) Then
                    chkSun.Checked = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ODocManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectData("select * from odoctor;", docs)
        Try
            DataGridView1.DataSource = docs.Tables(0)
        Catch exception As System.Exception

        End Try
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim valid(10) As Boolean
        If (txtRegNo.Text.Length <= 0) Then
            valid(0) = False
            txtRegNo.BackColor = Color.Pink
        Else
            valid(0) = True
            txtRegNo.BackColor = Color.LightGreen
        End If
        If (txtName.Text.Length <= 0) Then
            valid(1) = False
            txtName.BackColor = Color.Pink
        Else
            valid(1) = True
            txtName.BackColor = Color.LightGreen
        End If
        If (txtAddr1.Text.Length <= 0) Then
            valid(2) = False
            txtAddr1.BackColor = Color.Pink
        Else
            valid(2) = True
            txtAddr1.BackColor = Color.LightGreen
        End If
        If (cmbCity.Text.Length <= 0) Then
            valid(3) = False
            cmbCity.BackColor = Color.Pink
        Else
            valid(3) = True
            cmbCity.BackColor = Color.LightGreen
        End If
        If (cmbState.Text.Length <= 0) Then
            valid(4) = False
            cmbState.BackColor = Color.Pink
        Else
            valid(4) = True
            cmbState.BackColor = Color.LightGreen
        End If
        If (txtPin.Text.Length <= 0) Then
            valid(5) = False
            txtPin.BackColor = Color.Pink
        Else
            valid(5) = True
            txtPin.BackColor = Color.LightGreen
        End If
        If (txtContact.Text.Length <= 0) Then
            valid(6) = False
            txtContact.BackColor = Color.Pink
        Else
            valid(6) = True
            txtContact.BackColor = Color.LightGreen
        End If
        If (Not (txtEmail.Text.Length = 0 Or txtEmail.Text.Length > 0 And txtEmail.Text.Contains("@") And txtEmail.Text.Contains("."))) Then
            valid(7) = False
            txtEmail.BackColor = Color.Pink
        Else
            valid(7) = True
            txtEmail.BackColor = Color.LightGreen
        End If
        If (txtCharges.Text.Length <= 0) Then
            valid(8) = False
            txtCharges.BackColor = Color.Pink
        Else
            valid(8) = True
            txtCharges.BackColor = Color.LightGreen
        End If
        If (Not (chkMon.Checked Or chkTue.Checked Or chkWed.Checked Or chkThu.Checked Or chkFri.Checked Or chkSat.Checked Or chkSun.Checked)) Then
            valid(9) = False
        Else
            valid(9) = True
        End If
        Dim i As Integer = 0
        Do
            If (valid(i)) Then
                btnAdd.Enabled = True
                btnUpdate.Enabled = True
                i = i + 1
            Else
                btnAdd.Enabled = False
                btnUpdate.Enabled = False
                Exit Do
            End If
        Loop While i <= 9
    End Sub
End Class