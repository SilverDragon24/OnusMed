Imports Microsoft.VisualBasic.CompilerServices
Imports OnusMed.My
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class Appointment

    Private list As Dictionary(Of String, String)

    Private patients As Dictionary(Of String, String)

    Private appointments As DataSet

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim docs As DataSet = New DataSet()
        Dim pats As DataSet = New DataSet()
        selectData("select reg,name from odoctor;", docs)
        selectData("select id,name from patient where not id='N/A';", pats)
        Try
            Dim count As Integer = docs.Tables(0).Rows.Count - 1
            For num As Integer = 0 To count Step 1
                If (Not list.ContainsKey(docs.Tables(0).Rows(num)(0).ToString())) Then
                    list.Add(docs.Tables(0).Rows(num)(0).ToString(), docs.Tables(0).Rows(num)(1).ToString())
                End If
            Next

        Catch exception As System.Exception

        End Try
        Try
            Dim count1 As Integer = pats.Tables(0).Rows.Count - 1
            For i As Integer = 0 To count1 Step 1
                If (Not patients.ContainsKey(pats.Tables(0).Rows(i)(0).ToString())) Then
                    patients.Add(pats.Tables(0).Rows(i)(0).ToString(), pats.Tables(0).Rows(i)(1).ToString())
                End If
            Next

        Catch exception1 As System.Exception

        End Try
        cmbDocName.DataSource = New BindingSource(list, Nothing)
        cmbDocReg.DataSource = New BindingSource(list, Nothing)
        cmbDocReg.DisplayMember = "Key"
        cmbDocReg.ValueMember = "Value"
        cmbDocName.DisplayMember = "Value"
        cmbDocName.ValueMember = "Key"
        cmbPatId.DataSource = New BindingSource(patients, Nothing)
        cmbPatName.DataSource = New BindingSource(patients, Nothing)
        cmbPatId.DisplayMember = "Key"
        cmbPatId.ValueMember = "Value"
        cmbPatName.DisplayMember = "Value"
        cmbPatName.ValueMember = "Key"
        refreshApps()
        timeV.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Try
            Dim query As String = String.Concat("update opd set stat='Approved' where app_id='", DataGridView1.SelectedRows(0).Cells(0).Value.ToString(), "';commit;")
            manipulateData(query)
            refreshApps()
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Dim query As String = String.Concat("update opd set stat='Cancelled' where app_id='", DataGridView1.SelectedRows(0).Cells(0).Value.ToString(), "';commit;")
            manipulateData(query)
            refreshApps()
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim app_id As String = String.Concat("APP", generateID())
        Dim text() As String = {"insert into opd values('", app_id, "','", cmbDocReg.Text, "','", cmbPatId.Text, "','", txtContact.Text, "',", txtAge.Text, ",'", rtbProblem.Text, "','", Nothing, Nothing, Nothing, Nothing}
        Dim value As DateTime = dateV.Value
        text(13) = value.ToString("yyyy-MM-dd")
        text(14) = "','"
        value = timeV.Value
        text(15) = value.ToString("HH:mm:ss")
        text(16) = "','Scheduled');commit;"
        manipulateData(String.Concat(text))
        refreshApps()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NewPatient.ShowDialog()
    End Sub

    Private Sub cmbDocName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDocName.SelectedIndexChanged
        Dim str As ComboBox = cmbDocReg
        Dim selectedItem As KeyValuePair(Of String, String) = DirectCast(cmbDocName.SelectedItem, KeyValuePair(Of String, String))
        str.Text = selectedItem.Key.ToString()
    End Sub

    Private Sub cmbDocReg_TextChanged(sender As Object, e As EventArgs) Handles cmbDocReg.TextChanged
        Dim days As DataSet = New DataSet()
        selectData(String.Concat("select days from odoctor where reg='", cmbDocReg.Text, "';"), days)
        Try
            Dim dayset As String = days.Tables(0).Rows(0)(0).ToString()
            chkSun.Checked = False
            chkMon.Checked = False
            chkTue.Checked = False
            chkWed.Checked = False
            chkThu.Checked = False
            chkFri.Checked = False
            chkSat.Checked = False
            If (dayset.Contains("Sun")) Then
                chkSun.Checked = True
            End If
            If (dayset.Contains("Mon")) Then
                chkMon.Checked = True
            End If
            If (dayset.Contains("Tue")) Then
                chkTue.Checked = True
            End If
            If (dayset.Contains("Wed")) Then
                chkWed.Checked = True
            End If
            If (dayset.Contains("Thu")) Then
                chkThu.Checked = True
            End If
            If (dayset.Contains("Fri")) Then
                chkFri.Checked = True
            End If
            If (dayset.Contains("Sat")) Then
                chkSat.Checked = True
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub cmbPatId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatId.SelectedIndexChanged
        Dim str As ComboBox = cmbPatName
        Dim selectedItem As KeyValuePair(Of String, String) = DirectCast(cmbPatId.SelectedItem, KeyValuePair(Of String, String))
        str.Text = selectedItem.Value.ToString()
        Dim contact As DataSet = New DataSet()
        selectData(String.Concat("select contact from patient where id='", cmbPatId.Text, "';"), contact)
        Try
            txtContact.Text = contact.Tables(0).Rows(0)(0).ToString()
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub cmbPatName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatName.SelectedIndexChanged
        Dim str As ComboBox = cmbPatId
        Dim selectedItem As KeyValuePair(Of String, String) = DirectCast(cmbPatName.SelectedItem, KeyValuePair(Of String, String))
        str.Text = selectedItem.Key.ToString()
        Dim contact As DataSet = New DataSet()
        selectData(String.Concat("select contact from patient where id='", cmbPatId.Text, "';"), contact)
        Try
            txtContact.Text = contact.Tables(0).Rows(0)(0).ToString()
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub rtbProblem_TextChanged(sender As Object, e As EventArgs) Handles rtbProblem.TextChanged
        If (rtbProblem.Text.Length = 0) Then
            rtbProblem.Text = "N/A"
        End If
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged
        If (txtAge.Text.Length = 0) Then
            txtAge.Text = "0"
        End If
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        Try
            Dim pats As DataSet = New DataSet()
            selectData(String.Concat("select id,name from patient where contact='", txtContact.Text, "';"), pats)
            cmbPatId.Text = pats.Tables(0).Rows(0)(0).ToString()
            cmbPatName.Text = pats.Tables(0).Rows(0)(1).ToString()
        Catch exception As System.Exception

        End Try
    End Sub

    Private Function refreshApps() As Object
        Dim obj As Object = Nothing
        selectData("select app_id 'Appointment ID',(select name from odoctor where reg=doc_id) 'Doctor',(select name from patient where id=pat_id) 'Patient',contact 'Contact',age 'Age',problem 'Problem',vdate 'Visit Date',vtime 'Visit Time',stat 'Status' from opd where vdate=curdate();", appointments)
        Try
            DataGridView1.DataSource = appointments.Tables(0)
        Catch exception As System.Exception

        End Try
        Return obj
    End Function
End Class